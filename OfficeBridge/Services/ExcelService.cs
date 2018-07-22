using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Products.Model.Entities;
using Excel = NetOffice.ExcelApi;

namespace Products.OfficeBridge.Services
{
	public class ExcelService
	{
		#region PUBLIC PROCEDURES

		public bool ExportProductList(IEnumerable<Product> list, ProductExportCriteria criteria)
		{
			// Abbrechen, wenn es die angegebene Datei schon gibt. if
			// (File.Exists(criteria.ExcelFullName)) File.Delete(criteria.ExcelFilename);

			int dataStartRow = 16;
			var dateCell = "$G$14";
			var lastColumn = 65 + criteria.Feldliste.Count;
			var lastRow = list.Count();
			var app = new Excel.Application();
			var book = app.Workbooks.Add();
			var sheet = (Excel.Worksheet)book.ActiveSheet;
			sheet.Name = $"Preisliste {DateTime.Today.ToShortDateString()}";
			var artikelZusatzColumnAddress = string.Empty;
			double artikelZusatzColumnWidth = 65;
			var cellAddress = string.Empty;

			if (list != null && list.Count() > 0)
			{
				// CPM Logo einfügen
				var pic = sheet.Shapes.AddPicture(@"\\Cpm-dc\sage_ncl\catalist\graphics\cpm_kopf.jpg", NetOffice.OfficeApi.Enums.MsoTriState.msoFalse, NetOffice.OfficeApi.Enums.MsoTriState.msoCTrue, 20, 20, -1.0f, -1.0f);

				// Kundenadresse und Datum
				var range = sheet.Range("$B$10:$D$14");
				range.Merge();
				range.VerticalAlignment = Excel.Enums.XlVAlign.xlVAlignTop;
				range.WrapText = true;
				range.Value = criteria.Kundenadresse;

				range = sheet.Range(dateCell);
				range.Value = $"{DateTime.Now:d}";

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
					range = sheet.Range(cellAddress);
					range.NumberFormat = item.NumberFormat;
					range.Value = item.Header;
					if (item.Header == "Artikelzusatz")
					{
						artikelZusatzColumnAddress = cellAddress;
						artikelZusatzColumnWidth = item.ColumnWidth;
					}
				}

				// Tabelleninhalt
				int rowCount = dataStartRow + 1;
				foreach (var artikel in list)
				{
					if (!artikel.SelectedFlag || (criteria.NurRabattierteFlag && artikel.RabattProzent == 0 && artikel.StaffelpreisInfo == "-")) continue;
					foreach (var item in criteria.Feldliste)
					{
						cellAddress = $"{item.Column}{rowCount}";
						range = sheet.Range(cellAddress);
						range.NumberFormat = item.NumberFormat;
						range.Value = artikel.GetType().GetProperty(item.Fieldname).GetValue(artikel, null);
						range.VerticalAlignment = Excel.Enums.XlVAlign.xlVAlignTop;
						if (item.Fieldname == "Artikelzusatz") range.WrapText = true;
					}
					range.RowHeight = 40;
					rowCount += 1;
				}

				// Die Breite der ersten Spalte (A) auf 20pt (2.14) einstellen
				range = sheet.Range("$A:$A");
				range.ColumnWidth = 2.14;

				// Als Tabelle formatieren
				range = sheet.Range($"$B${dataStartRow}:${(char)lastColumn}{rowCount - 1}");
				sheet.ListObjects.Add(1, range, Missing.Value, 1).Name = "Preistabelle";
				var table = sheet.ListObjects["Preistabelle"];
				foreach (var item in table.ListColumns)
				{
					if (item.DataBodyRange != null) item.DataBodyRange.Font.Size = criteria.DataFontSize;
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
				var cols = $"A:{(char)lastColumn}";
				var autoFitRange = sheet.UsedRange.Columns[cols];
				autoFitRange.EntireColumn.AutoFit();
				var col = artikelZusatzColumnAddress.Substring(0, 1);
				var artikelZusatzColumn = sheet.Range($"${col}:${col}");
				artikelZusatzColumn.ColumnWidth = 65;

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
				range = sheet.Range($"$B{rowCount + 3}:$G{rowCount + 22}");
				range.Merge();
				range.WrapText = true;
				range.VerticalAlignment = Excel.Enums.XlVAlign.xlVAlignTop;
				var sb = new StringBuilder();
				sb.AppendLine($"Alle angegebenen Preise verstehen sich als Nettopreise zuzüglich der gesetzlich gültigen Mehrwertsteuer.");
				sb.AppendLine();
				sb.AppendLine("Liefer- und Zahlungsbedingungen:");
				sb.AppendLine("----------------------------------------------");
				sb.AppendLine(criteria.Frachtkosten);
				sb.AppendLine("Kosten für Express-, Eilgut- und Kuriersendungen gehen zu Lasten des Empfängers.");
				sb.AppendLine();
				sb.AppendLine(criteria.Zahlungsbedingungen);
				sb.AppendLine("----------------------------------------------------------------------------------------------------------");
				sb.AppendLine();
				sb.AppendLine("Zwischenzeitliche Änderungen und Irrtümer vorbehalten.");
				sb.AppendLine("Es gelten unsere Allgemeinen Geschäfts- und Lieferbedingungen.");
				sb.AppendLine();
				sb.AppendLine("Wir möchten Sie darauf hinweisen, dass diese Sonderpreisregelung einen fristgerechten Ausgleich unserer");
				sb.AppendLine("Rechnungen voraussetzt und jährlich erneut bestätigt werden muss.");
				sb.AppendLine();
				sb.AppendLine("Für alle hier nicht aufgeführten Artikel gelten unsere aktuellen Listenpreise, sofern nicht aufgrund eines");
				sb.AppendLine("vorangegangenen Angebots Sonderpreise vereinbart wurden.");
				sb.AppendLine();
				sb.AppendLine("Wir freuen uns auf eine angenehme Zusammenarbeit und verbleiben");
				sb.AppendLine();
				sb.AppendLine("mit freundlichen Grüßen");
				sb.AppendLine();
				sb.AppendLine("Cut & Print Media GmbH & Co. KG");

				range.Value = sb.ToString();

				book.SaveAs(criteria.ExcelFullName);
				book.Dispose();
				app.Quit();
				app.Dispose();
			}

			return true;
		}

		#endregion PUBLIC PROCEDURES
	}
}