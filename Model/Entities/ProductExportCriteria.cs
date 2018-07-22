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

		public bool KatalogFlag { get; set; }

		public bool ArtikelnummerFlag { get; set; }

		public bool Bezeichnung1Flag { get; set; }

		public bool Bezeichnung2Flag { get; set; }

		public bool MengeneinheitFlag { get; set; }

		public bool EinkaufspreisFlag { get; set; }

		public bool VerkaufspreisFlag { get; set; }

		public bool KundenpreisFlag { get; set; }

		public bool KundenrabattFlag { get; set; }

		public bool StaffelpreisFlag { get; set; }

		public bool NurRabattierteFlag { get; set; }

		public bool TabelleAnzeigenFlag { get; set; }

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
				if (this.Bezeichnung2Flag) { this.myFieldList.Add(new ColsAndFields { Column = (char)counter, Fieldname = "Artikelzusatz", Header = "Artikelzusatz", NumberFormat = "@", ColumnWidth = 65 }); counter += 1; }
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
		/// Gibt den vollständigen Pfad und Dateinamen der Excel-Datei mit den exportierten
		/// Daten zurück.
		/// </summary>
		public string ExcelFullName => Path.Combine(this.ExportPfad, this.ExcelFilename);

		/// <summary>
		/// Gibt die Kurzbezeichnung des Kunden zurück.
		/// </summary>
		public string Matchcode => this.myKunde.Matchcode;

		/// <summary>
		/// Gibt die Kundennummer in der bei uns üblichen 5-stelligen Form zurück.
		/// </summary>
		public string Kundennummer => this.myKunde.KundenNrCpm;

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
		/// Gibt den Versandkostentext für den Kunden zurück.
		/// </summary>
		public string Frachtkosten => this.myKunde.FocText;

		/// <summary>
		/// Gibt die Zahlungsbedingungen des Kunden als Text zurück.
		/// </summary>
		public string Zahlungsbedingungen => this.myKunde.Zahlungsbedingungen;

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

		/// <summary>
		/// Gibt den Pfad des Ordners zurück, in dem die Exportdatei gespeichert werden soll.
		/// </summary>
		public string ExportPfad { get; set; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public ProductExportCriteria(Kunde kunde, string bmpHeaderFullName)
		{
			this.myKunde = kunde;
			this.myBitmapHeaderFullName = bmpHeaderFullName;
			var matchcode = this.myKunde.Matchcode.Replace("/", "_");
			var userDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			this.myFileName = $"{matchcode}_{now.ToString("yyyy")}{now.ToString("MM")}{now.ToString("dd")}_Preise.xlsx";
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		public void RestoreSettings()
		{
			this.KatalogFlag = CatalistRegistry.ProductExportCriteria.KatalogkategorieFlag == 1;
			this.ArtikelnummerFlag = CatalistRegistry.ProductExportCriteria.ArtikelnummerFlag == 1;
			this.Bezeichnung1Flag = CatalistRegistry.ProductExportCriteria.ArtikelbezeichnungFlag == 1;
			this.Bezeichnung2Flag = CatalistRegistry.ProductExportCriteria.ArtikelzusatzFlag == 1;
			this.MengeneinheitFlag = CatalistRegistry.ProductExportCriteria.MengeneinheitFlag == 1;
			this.EinkaufspreisFlag = CatalistRegistry.ProductExportCriteria.EinkaufspreisFlag == 1;
			this.VerkaufspreisFlag = CatalistRegistry.ProductExportCriteria.VerkaufspreisFlag == 1;
			this.KundenpreisFlag = CatalistRegistry.ProductExportCriteria.KundenpreisFlag == 1;
			this.KundenrabattFlag = CatalistRegistry.ProductExportCriteria.KundenrabattFlag == 1;
			this.StaffelpreisFlag = CatalistRegistry.ProductExportCriteria.StaffelpreiseFlag == 1;
			this.NurRabattierteFlag = CatalistRegistry.ProductExportCriteria.NurRabattierteFlag == 1;
			this.TabelleAnzeigenFlag = CatalistRegistry.ProductExportCriteria.TabelleAnzeigenFlag == 1;
			this.ExportPfad = CatalistRegistry.ProductExportCriteria.ExportPfad;
			if (string.IsNullOrEmpty(this.ExportPfad) || Directory.Exists(this.ExportPfad) == false)
			{
				CatalistRegistry.ProductExportCriteria.ExportPfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				this.ExportPfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			}

			switch (CatalistRegistry.ProductExportCriteria.Tabellenfarbe)
			{
				case "LightBlue":
				this.Tabellenfarbe = TableStyles.LightBlue;
				break;

				case "Orange":
				this.Tabellenfarbe = TableStyles.Orange;
				break;

				case "Gray":
				this.Tabellenfarbe = TableStyles.Gray;
				break;

				case "Yellow":
				this.Tabellenfarbe = TableStyles.Yellow;
				break;

				case "DarkBlue":
				this.Tabellenfarbe = TableStyles.DarkBlue;
				break;

				default:
				this.Tabellenfarbe = TableStyles.Green;
				break;
			}
		}

		public void SaveSettings()
		{
			CatalistRegistry.ProductExportCriteria.KatalogkategorieFlag = this.KatalogFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.ArtikelnummerFlag = this.ArtikelnummerFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.ArtikelbezeichnungFlag = this.Bezeichnung1Flag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.ArtikelzusatzFlag = this.Bezeichnung2Flag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.MengeneinheitFlag = this.MengeneinheitFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.EinkaufspreisFlag = this.EinkaufspreisFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.VerkaufspreisFlag = this.VerkaufspreisFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.KundenpreisFlag = this.KundenpreisFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.KundenrabattFlag = this.KundenrabattFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.StaffelpreiseFlag = this.StaffelpreisFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.NurRabattierteFlag = this.NurRabattierteFlag ? 1 : 0;
			CatalistRegistry.ProductExportCriteria.TabelleAnzeigenFlag = this.TabelleAnzeigenFlag ? 1 : 0;
			switch (this.Tabellenfarbe)
			{
				case TableStyles.LightBlue:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "LightBlue";
				break;

				case TableStyles.Orange:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "Orange";
				break;

				case TableStyles.Gray:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "Gray";
				break;

				case TableStyles.Yellow:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "Yellow";
				break;

				case TableStyles.DarkBlue:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "DarkBlue";
				break;

				case TableStyles.Green:
				CatalistRegistry.ProductExportCriteria.Tabellenfarbe = "Green";
				break;

			}
			CatalistRegistry.ProductExportCriteria.ExportPfad = this.ExportPfad;
		}

		#endregion PUBLIC PROCEDURES

		#region STRUCTS

		public struct ColsAndFields
		{
			public char Column { get; set; }

			public string Fieldname { get; set; }

			public string Header { get; set; }

			public string NumberFormat { get; set; }

			public double ColumnWidth { get; set; }
		}

		#endregion STRUCTS
	}
}