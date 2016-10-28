using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Products.Model.Entities
{
	public class ProductExportCriteria
	{
		#region MEMBERS

		readonly Kunde myKunde;
		readonly DateTime now = DateTime.Now;
		readonly string myFileName;
		readonly string myExcelFullName;
		readonly List<ColsAndFields> myFieldList = new List<ColsAndFields>();
		readonly string myBitmapHeaderFullName;

		#endregion MEMBERS

		#region ENUMS

		public enum TableStyles
		{
			LightBlue = 2,
			Orange = 3,
			Gray = 4,
			Yellow = 5,
			DarkBlue = 6,
			Green = 7
		}

		#endregion ENUMS

		#region PUBLIC PROPERTIES

		#region FLAG PROPERTIES

		public bool KatalogFlag { get; set; } = true;

		public bool ArtikelnummerFlag { get; set; } = true;

		public bool Bezeichnung1Flag { get; set; } = true;

		public bool Bezeichnung2Flag { get; set; } = true;

		public bool MengeneinheitFlag { get; set; } = true;

		public bool EinkaufspreisFlag { get; set; } = true;

		public bool VerkaufspreisFlag { get; set; } = true;

		public bool KundenpreisFlag { get; set; } = true;

		public bool KundenrabattFlag { get; set; } = true;

		public bool StaffelpreisFlag { get; set; } = true;

		public bool DiscountedOnlyFlag { get; set; } = true;

		public bool ShowPostExportFlag { get; set; } = true;

		#endregion FLAG PROPERTIES

		/// <summary>
		/// Gibt die Tabellenfarbe zurück oder legt sie fest.
		/// </summary>
		public TableStyles Tabellenfarbe { get; set; } = TableStyles.Green;

		/// <summary>
		/// Legt die Schriftgröße der Überschriftenzeile fest.
		/// </summary>
		public int HeaderFontSize { get; set; } = 10;

		/// <summary>
		/// Legt die Schriftgröße der Tabellendaten fest.
		/// </summary>
		public int DataFontSize { get; set; } = 9;

		/// <summary>
		/// Gibt die Liste der zu exportierenden Eigenschaften (Spalten) zurück.
		/// </summary>
		public List<ColsAndFields> Feldliste
		{
			get
			{
				int counter = 66; // 1. Spalte = 'B'
				var col = (char)counter;
				this.myFieldList.Clear();
				if (this.KatalogFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "KatalogsektionName", Header = "Katalog", NumberFormat = "@" }); counter += 1; }
				if (this.ArtikelnummerFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Artikelnummer", Header = "Artikel-Nr.", NumberFormat = "@" }); counter += 1; }
				if (this.Bezeichnung1Flag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Bezeichnung1", Header = "Artikelname", NumberFormat = "@" }); counter += 1; }
				if (this.Bezeichnung2Flag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Bezeichnung2", Header = "Artikelzusatz", NumberFormat = "@" }); counter += 1; }
				if (this.MengeneinheitFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Mengeneinheit", Header = "ME", NumberFormat = "@" }); counter += 1; }
				if (this.EinkaufspreisFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Einkaufspreis", Header = "EK", NumberFormat = "#,##0.00 $" }); counter += 1; }
				if (this.VerkaufspreisFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Standardpreis", Header = "VK", NumberFormat = "#,##0.00 $" }); counter += 1; }
				if (this.KundenpreisFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Kundenpreis", Header = "Kundenpreis", NumberFormat = "#,##0.00 $" }); counter += 1; }
				if (this.KundenrabattFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "RabattProzent", Header = "Rabatt (%)", NumberFormat = "#,#0.0" }); counter += 1; }
				if (this.StaffelpreisFlag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "StaffelpreisInfo", Header = "Staffelpreise", NumberFormat = "@" }); }

				return this.myFieldList;
			}
		}

		/// <summary>
		/// Gibt den Dateinamen der Excel-Datei mit den exportierten Daten zurück.
		/// </summary>
		public string ExcelFilename => this.myFileName;

		/// <summary>
		/// Gibt den vollständigen Pfad und Dateinamen der Excel-Datei mit den exportierten Daten zurück.
		/// </summary>
		public string ExcelFullName
		{
			get
			{
				return this.myExcelFullName;
			}
		}

		/// <summary>
		/// Gibt die Kurzbezeichnung des Kunden zurück.
		/// </summary>
		public string Matchcode { get { return this.myKunde.Matchcode; } }

		/// <summary>
		/// Gibt die Kundennummer in der bei uns üblichen 5-stelligen Form zurück.
		/// </summary>
		public string Kundennummer { get { return this.myKunde.KundenNrCpm; } }

		/// <summary>
		/// Gibt die Kundenadresse formatiert für Briefe zurück.
		/// </summary>
		public string Kundenadresse
		{
			get
			{
				var sb = new StringBuilder();
				sb.AppendLine($"{this.myKunde.CompanyName1} [{this.myKunde.KundenNrCpm}]");
				if (!string.IsNullOrEmpty(this.myKunde.CompanyName2)) sb.AppendLine($"{this.myKunde.CompanyName2}");
				sb.AppendLine(this.myKunde.Street);
				sb.AppendLine($"{this.myKunde.ZipCode} {this.myKunde.City}");
				return sb.ToString();
			}
		}

		/// <summary>
		/// Gibt die in der Kopfzeile anzuzeigende Bitmap zurück.
		/// </summary>
		public Bitmap HeaderBitmap
		{
			get
			{
				if (!File.Exists(this.myBitmapHeaderFullName)) throw new ApplicationException("Das Bild für die Kopfzeile ist auf dem Server nicht mehr vorhanden.");
				var bmp = new Bitmap(this.myBitmapHeaderFullName);
				return bmp;
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public ProductExportCriteria(Kunde kunde, string bmpHeaderFullName)
		{
			this.myKunde = kunde;
			this.myBitmapHeaderFullName = bmpHeaderFullName;
			var userDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			this.myFileName = $"{now.ToString("yyyy")}{now.ToString("MM")}{now.ToString("dd")}{now.ToString("HH")}{now.ToString("mm")}{now.ToString("ss")} Artikelpreise, {kunde.Matchcode}";
			this.myExcelFullName = Path.Combine(userDocs, this.myFileName);
		}

		#endregion ### .ctor ###

		#region STRUCTS

		public struct ColsAndFields
		{
			public char Column { get; set; }

			public string Fieldname { get; set; }

			public string Header { get; set; }

			public string NumberFormat { get; set; }
		}

		#endregion STRUCTS
	}
}