using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ProductExportDetailsView : MetroForm
	{
		#region members

		readonly ProductExportCriteria myCriteria;
		readonly IEnumerable<Product> myExportList;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ProductExportDetailsView"/> Formularklasse.
		/// </summary>
		public ProductExportDetailsView(Kunde kunde, IEnumerable<Product> exportList)
		{
			InitializeComponent();
			var bmpFullname = Path.Combine(Properties.Settings.Default.PicturePath, "cpm_kopf.jpg");
			this.myCriteria = new ProductExportCriteria(kunde, bmpFullname);
			this.myExportList = exportList;
			this.mlblExportInfo.Text = $"Die Excel Tabelle wird im Ordner Dokumente als\n{this.myCriteria.ExcelFilename} gespeichert.";
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region private procedures

		void InitializeData()
		{
			this.mtogglKatalog.DataBindings.Add("Checked", this.myCriteria, "KatalogFlag");
			this.mtogglArtikelnummer.DataBindings.Add("Checked", this.myCriteria, "ArtikelnummerFlag");
			this.mtogglBezeichnung1.DataBindings.Add("Checked", this.myCriteria, "Bezeichnung1Flag");
			this.mtogglBezeichnung2.DataBindings.Add("Checked", this.myCriteria, "Bezeichnung2Flag");
			this.mtogglMengeneinheit.DataBindings.Add("Checked", this.myCriteria, "MengeneinheitFlag");
			this.mtogglEinkaufspreis.DataBindings.Add("Checked", this.myCriteria, "EinkaufspreisFlag");
			this.mtogglVerkaufspreis.DataBindings.Add("Checked", this.myCriteria, "VerkaufspreisFlag");
			this.mtogglKundenpreis.DataBindings.Add("Checked", this.myCriteria, "KundenpreisFlag");
			this.mtogglDiscountPercent.DataBindings.Add("Checked", this.myCriteria, "KundenrabattFlag");
			this.mtogglStaffelpreis.DataBindings.Add("Checked", this.myCriteria, "StaffelpreisFlag");
			this.mtogglDiscountedOnly.DataBindings.Add("Checked", this.myCriteria, "DiscountedOnlyFlag");
			this.mtogglShowPostExport.DataBindings.Add("Checked", this.myCriteria, "ShowPostExportFlag");
			this.mtrackHeaderFontSize.DataBindings.Add("Value", this.myCriteria, "HeaderFontSize");
			this.mtrackDataFontSize.DataBindings.Add("Value", this.myCriteria, "DataFontSize");

			this.mbtnExport.Click += mbtnExport_Click;
		}

		#endregion private procedures

		#region event handler

		void mtileLightBlue_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.LightBlue;
			this.mlblTabellenfarbe.Text = "Hellblau";
		}

		void mtileOrange_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.Orange;
			this.mlblTabellenfarbe.Text = "Orange";
		}

		void mtileGray_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.Gray;
			this.mlblTabellenfarbe.Text = "Grau";
		}

		void mtileYellow_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.Yellow;
			this.mlblTabellenfarbe.Text = "Gelb";
		}

		void mtileDarkBlue_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.DarkBlue;
			this.mlblTabellenfarbe.Text = "Dunkelblau";
		}

		void mtileGreen_Click(object sender, EventArgs e)
		{
			this.myCriteria.Tabellenfarbe = ProductExportCriteria.TableStyles.Green;
			this.mlblTabellenfarbe.Text = "Grün";
		}

		void mtxtHeaderFontSize_Validated(object sender, EventArgs e)
		{
			int fontSize = this.myCriteria.HeaderFontSize;
			if (!int.TryParse(this.mtxtHeaderFontSize.Text, out fontSize))
			{
				MetroMessageBox.Show(this, "Bitte eine Zahl zwischen 5 und 20 eingeben.");
			}
			this.myCriteria.HeaderFontSize = fontSize;
		}

		void mtxtDataFontSize_Validated(object sender, EventArgs e)
		{
			int fontSize = this.myCriteria.DataFontSize;
			if (!int.TryParse(this.mtxtDataFontSize.Text, out fontSize))
			{
				MetroMessageBox.Show(this, "Bitte eine Zahl zwischen 5 und 20 eingeben.");
			}
			this.myCriteria.DataFontSize = fontSize;
		}

		void mtrackHeaderFontSize_ValueChanged(object sender, EventArgs e)
		{
			this.mtxtHeaderFontSize.Text = $"{this.mtrackHeaderFontSize.Value}";
		}

		void mtrackDataFontSize_ValueChanged(object sender, EventArgs e)
		{
			this.mtxtDataFontSize.Text = $"{this.mtrackDataFontSize.Value}";
		}

		void mbtnExport_Click(object sender, EventArgs e)
		{
			MetroMessageBox.Show(this, "Das wird etwas dauern. Wenn nicht nur rabattierte Artikel exportiert werden, auch etwas länger.", "Ich starte den Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
			var stoppUhr = Stopwatch.StartNew();
			OfficeBridge.ServiceManager.ExcelService.ExportProductList(this.myExportList, this.myCriteria);
			stoppUhr.Stop();
			var ticks = stoppUhr.ElapsedTicks;
			var frequency = Stopwatch.Frequency;
			var seconds = ticks / frequency;

			MetroMessageBox.Show(this, $"Alle Artikel wurden in {seconds:N0} Sekunden exportiert", "So, das war's", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Excel öffnen, wenn aktiviert.
			if (this.mtogglShowPostExport.Checked)
			{
				var startInfo = new ProcessStartInfo();
				startInfo.FileName = "excel.exe";
				startInfo.Arguments = $"\"{this.myCriteria.ExcelFullName}\"";
				Process.Start(startInfo);
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler
	}
}