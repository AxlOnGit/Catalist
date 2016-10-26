using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Products.Model.Entities;
using Excel = NetOffice.ExcelApi;

namespace Products.OfficeBridge.Services
{
	public class ExcelService
	{
		#region public procedures

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

			var app = new Excel.Application();
			var book = app.Workbooks.Add();
			var sheet = (Excel.Worksheet)book.ActiveSheet;
			sheet.Name = $"Preisliste {DateTime.Today.ToShortDateString()}";
			var cellAddress = string.Empty;

			if (list != null && list.Count() > 0)
			{
				// Überschrift
				var cell = sheet.Range("B2");
				cell.Value = $"Artikelpreisliste für Firma {criteria.Matchcode}, Stand: {DateTime.Now.ToShortDateString()}";
				cell.Font.Size = 12;
				cell.Font.Bold = true;
				var lastCol = 66 + criteria.Feldliste.Count - 1;
				var mergeThis = sheet.Range($"B2:{(char)lastCol}2");
				mergeThis.Merge();

				// Zeilenüberschriften
				foreach (var item in criteria.Feldliste)
				{
					cellAddress = $"{item.Column}4";
					cell = sheet.Range(cellAddress);
					cell.NumberFormat = item.NumberFormat;
					cell.Value = item.Header;
				}

				// Tabelleninhalt
				int rowCount = 5;
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

				// Die erste Spalte auf 20pt (2.14) einstellen
				var range = sheet.Range("$A:$A");
				range.ColumnWidth = 2.14;

				// Als Tabelle formatieren
				range = sheet.Range($"$B$4:${(char)lastCol}{rowCount - 1}");
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
				var sortRange = sheet.Range("B4");
				table.Sort.SortFields.Add(sortRange);
				table.Sort.Header = Excel.Enums.XlYesNoGuess.xlYes;
				table.Sort.MatchCase = false;
				table.Sort.Orientation = Excel.Enums.XlSortOrientation.xlSortColumns;
				table.Sort.SortMethod = Excel.Enums.XlSortMethod.xlPinYin;
				table.Sort.Apply();

				// Fenster ab Zeile 5 fixieren
				sheet.Range("A5").Select();
				app.ActiveWindow.FreezePanes = true;

				book.SaveAs(criteria.ExcelFullName);
				book.Dispose();
				app.Quit();
				app.Dispose();
			}

			return true;
		}

		#endregion public procedures
	}
}