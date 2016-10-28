using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Products.Model.Entities;
using Excel = NetOffice.ExcelApi;

namespace Products.OfficeBridge.Services
{
	public class ExcelService
	{
		#region PUBLIC PROCEDURES

		/// <summary>
		/// Erstellt ein neues Excel-Dokument mit einer Tabelle, die alle Zeilen der angegebenen
		/// Liste enthält.
		/// </summary>
		/// <param name="list">
		/// Eine Liste, <seealso cref="IEnumerable{T}"/>, die die zu exportierenden Zeilen enthält.
		/// </param>
		/// <param name="fullName">Der Name der zu erstellenden Excel-Datei.</param>
		/// <returns></returns>
		public bool ExportProductList(IEnumerable<Product> list, string fullName, string kundenName)
		{
			// Abbrechen, wenn es die angegebene Datei schon gibt.
			if (File.Exists(fullName)) throw new ArgumentException($"Die Datei {fullName} gibt es schon.");

			var app = new Excel.Application();
			var book = app.Workbooks.Add();
			var sheetCount = book.Sheets.Count;
			var sheet = (Excel.Worksheet)book.Sheets[1];

			if (list is IEnumerable<Product>)
			{
				var cell = sheet.Range("B2");
				cell.Value = $"Artikelpreisliste für Firma {kundenName}, Stand: {DateTime.Now.ToShortDateString()}";
				cell.Font.Bold = true;
				cell.Font.Size = 14;

				var header = sheet.Range("B2:E2");
				header.Merge();

				cell = sheet.Range("B4");
				cell.Value = "Artikel-Nr.";
				cell.Font.Bold = true;
				cell.Font.Size = 12;

				cell = sheet.Range("C4");
				cell.Value = "Artikelbezeichnung";
				cell.Font.Bold = true;
				cell.Font.Size = 12;

				cell = sheet.Range("D4");
				cell.Value = "Mengeneinheit";
				cell.Font.Bold = true;
				cell.Font.Size = 12;

				cell = sheet.Range("E4");
				cell.Value = "Nettopreis";
				cell.Font.Bold = true;
				cell.Font.Size = 12;

				int r = 5;
				foreach (var artikel in list)
				{
					for (int c = 66; c <= 69; c++)
					{
						cell = sheet.Range($"{(char)c}{r}");
						switch (c)
						{
							case 66:
								cell.NumberFormat = "@";
								if (artikel.RabattProzent > 0)
								{
									cell.Value = $"{artikel.Artikelnummer} (*)";
								}
								else cell.Value += artikel.Artikelnummer;
								break;

							case 67:
								cell.NumberFormat = "@";
								cell.Value = artikel.Bezeichnung1;
								break;

							case 68:
								cell.NumberFormat = "@";
								cell.Value = artikel.Mengeneinheit;
								break;

							case 69:
								cell.Value = artikel.Kundenpreis;
								cell.Value = artikel.Kundenpreis;
								cell.NumberFormat = "#,##0.00 $";
								break;
						}
					}
					r += 1;
				}
				var col = sheet.UsedRange.Columns["A:A"];
				col.ColumnWidth = 2.14;

				col = sheet.UsedRange.Columns["A:E"];
				col.EntireColumn.AutoFit();
				var range = sheet.Range($"$B$4:$E{list.Count() + 5}");
				sheet.ListObjects.Add(1, range, Missing.Value, 1).Name = "Preistabelle";
				sheet.ListObjects["Preistabelle"].TableStyle = "TableStyleMedium3";

				book.SaveAs(fullName);
				book.Dispose();
				app.Quit();
				app.Dispose();
			}
			return true;
		}

		public bool ExportProductList(IEnumerable<Product> list, ProductExportCriteria criteria)
		{
			// Abbrechen, wenn es die angegebene Datei schon gibt.
			if (File.Exists(criteria.ExcelFullName)) throw new ArgumentException($"Die Datei {criteria.ExcelFilename} gibt es schon.");

			int dataStartRow = 16;
			var dateCell = "$G$14";
			var lastCol = 65 + criteria.Feldliste.Count;
			var lastRow = list.Count();
			var app = new Excel.Application();
			var book = app.Workbooks.Add();
			var sheet = (Excel.Worksheet)book.ActiveSheet;
			sheet.Name = $"Preisliste {DateTime.Today.ToShortDateString()}";
			var cellAddress = string.Empty;

			if (list != null && list.Count() > 0)
			{
				// CPM Logo einfügen
				var pic = sheet.Shapes.AddPicture(@"\\Cpm-dc\sage_ncl\catalist\graphics\cpm_kopf.jpg", NetOffice.OfficeApi.Enums.MsoTriState.msoFalse, NetOffice.OfficeApi.Enums.MsoTriState.msoCTrue, 20, 20, -1.0f, -1.0f);

				// Kundenadresse und Datum
				var cell = sheet.Range("$B$10:$D$13");
				cell.Merge();
				cell.WrapText = true;
				cell.Value = criteria.Kundenadresse;

				cell = sheet.Range(dateCell);
				cell.Value = $"{DateTime.Now:d}";

				// Überschrift
				//cell = sheet.Range("B2");
				//cell.Value = $"Artikelpreisliste für Firma {criteria.Matchcode} {criteria.Kundennummer}, Stand: {DateTime.Now.ToShortDateString()}";
				//cell.Font.Size = 12;
				//cell.Font.Bold = true;
				//var lastCol = 66 + criteria.Feldliste.Count - 1;
				//var mergeThis = sheet.Range($"B2:{(char)lastCol}2");
				//mergeThis.Merge();

				// Zeilenüberschriften
				foreach (var item in criteria.Feldliste)
				{
					cellAddress = $"{item.Column}{dataStartRow}";
					cell = sheet.Range(cellAddress);
					cell.NumberFormat = item.NumberFormat;
					cell.Value = item.Header;
				}

				// Tabelleninhalt
				int rowCount = dataStartRow + 1;
				foreach (var artikel in list)
				{
					if (criteria.DiscountedOnlyFlag && artikel.RabattProzent == 0 && artikel.StaffelpreisInfo == "-") continue;
					foreach (var item in criteria.Feldliste)
					{
						cellAddress = $"{item.Column}{rowCount}";
						cell = sheet.Range(cellAddress);
						cell.NumberFormat = item.NumberFormat;
						cell.Value = artikel.GetType().GetProperty(item.Fieldname).GetValue(artikel, null);
					}
					rowCount += 1;
				}

				// Die Breite der ersten Spalte (A) auf 20pt (2.14) einstellen
				var range = sheet.Range("$A:$A");
				range.ColumnWidth = 2.14;

				// Als Tabelle formatieren
				range = sheet.Range($"$B${dataStartRow}:${(char)lastCol}{rowCount - 1}");
				sheet.ListObjects.Add(1, range, Missing.Value, 1).Name = "Preistabelle";
				var table = sheet.ListObjects["Preistabelle"];
				foreach (var item in table.ListColumns)
				{
					item.DataBodyRange.Font.Size = criteria.DataFontSize;
				}
				table.HeaderRowRange.Font.Size = criteria.HeaderFontSize;
				table.HeaderRowRange.Font.Bold = true;
				switch (criteria.Tabellenfarbe)
				{
					case ProductExportCriteria.TableStyles.LightBlue:
						table.TableStyle = "TableStyleMedium2";
						break;

					case ProductExportCriteria.TableStyles.Orange:
						table.TableStyle = "TableStyleMedium3";
						break;

					case ProductExportCriteria.TableStyles.Gray:
						table.TableStyle = "TableStyleMedium4";
						break;

					case ProductExportCriteria.TableStyles.Yellow:
						table.TableStyle = "TableStyleMedium5";
						break;

					case ProductExportCriteria.TableStyles.DarkBlue:
						table.TableStyle = "TableStyleMedium6";
						break;

					case ProductExportCriteria.TableStyles.Green:
						table.TableStyle = "TableStyleMedium7";
						break;

					default:
						table.TableStyle = "TableStyleMedium3";
						break;
				}

				// Automatische Spaltenbreiten einstellen
				var cols = $"A:{(char)lastCol}";
				var autoFitRange = sheet.UsedRange.Columns[cols];
				autoFitRange.EntireColumn.AutoFit();

				// Nach der ersten Spalte sortieren
				var sortRange = sheet.Range($"B{dataStartRow}");
				table.Sort.SortFields.Add(sortRange);
				table.Sort.Header = Excel.Enums.XlYesNoGuess.xlYes;
				table.Sort.MatchCase = false;
				table.Sort.Orientation = Excel.Enums.XlSortOrientation.xlSortColumns;
				table.Sort.SortMethod = Excel.Enums.XlSortMethod.xlPinYin;
				table.Sort.Apply();

				// Fenster ab Zeile 5 fixieren
				sheet.Range($"A{dataStartRow + 1}").Select();
				app.ActiveWindow.FreezePanes = true;
				app.ActiveWindow.DisplayGridlines = false;

				// Fußzeilen einfügen
				cell = sheet.Range($"$B{rowCount + 2}:$G{rowCount + 22}");
				cell.Merge();
				cell.WrapText = true;
				cell.VerticalAlignment = Excel.Enums.XlVAlign.xlVAlignTop;
				var sb = new StringBuilder();
				sb.AppendLine($"Die angegebenen Preise verstehen sich als Nettopreise zuzüglich der gesetzlich gültigen Mehrwertsteuer.");
				sb.AppendLine();
				sb.AppendLine("Liefer- und Zahlungsbedingungen:");
				sb.AppendLine();
				sb.AppendLine("Sofern für die Frachtpauschale keine gesonderte Vereinbarung getroffen wurde, berechnen wir bis zu einem");
				sb.AppendLine("Netto-Warenwert i.H.v. 250,- EUR eine Pauschale von 8,50 EUR pro Auftrag.");
				sb.AppendLine("Kosten für Express-, Eilgut- und Kuriersendungen gehen zu Lasten des Empfängers.");
				sb.AppendLine("Zwischenzeitliche Änderungen und Irrtümer vorbehalten.");
				sb.AppendLine("Es gelten unsere Allgemeinen Geschäfts- und Lieferbedingungen.");
				sb.AppendLine();
				sb.AppendLine("Wir möchten Sie darauf hinweisen, dass diese Sonderpreisregelung einen firstgerechten Ausgleich unserer");
				sb.AppendLine("Rechnungen voraussetzt und jährlich erneut bestätigt werden muss.");
				sb.AppendLine();
				sb.AppendLine("Für alle hier nicht aufgeführten Artikel sind unsere aktuellen Listenpreise gültig, sofern nicht aufgrund eines");
				sb.AppendLine("vorangegangenen Angebots Sonderpreise vereinbart wurden.");
				sb.AppendLine();
				sb.AppendLine("Wir freuen uns auf eine angenehme Zusammenarbeit und verbleiben");
				sb.AppendLine();
				sb.AppendLine("Mit freundlichen Grüßen");
				sb.AppendLine();
				sb.AppendLine("Cut & Print Media GmbH & Co. KG");

				cell.Value = sb.ToString();

				book.SaveAs(criteria.ExcelFullName);
				book.Dispose();
				app.Quit();
				app.Dispose();
			}

			return true;
		}

		#endregion PUBLIC PROCEDURES

		//#region EXTERNALS

		//enum DeviceCap
		//{
		//	HORZRES = 0,
		//	VERTRES = 10,
		//	LOGPIXELSX = 88,
		//	LOGPIXELSY = 90
		//}

		//[DllImport("gdi32.dll")]
		//static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		//Tuple<int, int> GetMonitorDpiX()
		//{
		//	using (var g = Graphics.FromHwnd(IntPtr.Zero))
		//	{
		//		var desktop = g.GetHdc();
		//		var hRes = GetDeviceCaps(desktop, (int)DeviceCap.HORZRES);
		//		var vRes = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
		//		var dpiX = GetDeviceCaps(desktop, (int)DeviceCap.LOGPIXELSX);
		//		var dpiY = GetDeviceCaps(desktop, (int)DeviceCap.LOGPIXELSY);
		//		var result = new Tuple<int, int>(dpiX * vRes, dpiY * hRes);
		//		return result;
		//	}
		//}

		//#endregion EXTERNALS
	}
}