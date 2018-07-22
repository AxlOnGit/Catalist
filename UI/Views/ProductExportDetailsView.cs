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
		#region MEMBERS

		readonly ProductExportCriteria myCriteria;
		readonly List<Product> myExportList;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ProductExportDetailsView"/> Formularklasse.
		/// </summary>
		public ProductExportDetailsView(Kunde kunde, List<Product> exportList)
		{
			InitializeComponent();
			var bmpFullname = Path.Combine(CatalistRegistry.Application.PicturePath, "cpm_kopf.jpg");
			this.myCriteria = new ProductExportCriteria(kunde, bmpFullname);
			this.myCriteria.RestoreSettings();
			this.myExportList = exportList;
			this.mlblExportInfo.Text = $"als '{this.myCriteria.ExcelFilename}'";
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region PRIVATE PROCEDURES

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
			this.mtogglDiscountedOnly.DataBindings.Add("Checked", this.myCriteria, "NurRabattierteFlag");
			this.mtogglShowPostExport.DataBindings.Add("Checked", this.myCriteria, "TabelleAnzeigenFlag");
			this.mtrackHeaderFontSize.DataBindings.Add("Value", this.myCriteria, "HeaderFontSize");
			this.mtrackDataFontSize.DataBindings.Add("Value", this.myCriteria, "DataFontSize");
			this.mlnkExportPfad.Text = this.myCriteria.ExportPfad;

			switch (this.myCriteria.Tabellenfarbe)
			{
				case ProductExportCriteria.TableStyles.LightBlue:
				this.mlblTabellenfarbe.Text = "Hellblau";
				break;

				case ProductExportCriteria.TableStyles.Orange:
				this.mlblTabellenfarbe.Text = "Orange";
				break;

				case ProductExportCriteria.TableStyles.Gray:
				this.mlblTabellenfarbe.Text = "Grau";
				break;

				case ProductExportCriteria.TableStyles.Yellow:
				this.mlblTabellenfarbe.Text = "Gelb";
				break;

				case ProductExportCriteria.TableStyles.DarkBlue:
				this.mlblTabellenfarbe.Text = "Dunkelblau";
				break;

				case ProductExportCriteria.TableStyles.Green:
				this.mlblTabellenfarbe.Text = "Grün";
				break;
			}

			this.mbtnExport.Click += mbtnExport_Click;
		}

		#endregion PRIVATE PROCEDURES

		#region EVENT HANDLER

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

		private void mlnkExportPfad_Click(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Bitte den Ordner auswählen, in dem ich die exportierten Dateien speichern soll.";
			if (Directory.Exists(this.myCriteria.ExportPfad)) fbd.SelectedPath = this.myCriteria.ExportPfad;
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.myCriteria.ExportPfad = fbd.SelectedPath;
				this.mlnkExportPfad.Text = fbd.SelectedPath;
			}
		}

		void mbtnExport_Click(object sender, EventArgs e)
		{
			var msg = string.Empty;
			bool isEmpty = true;
			foreach (var item in this.myExportList)
			{
				if (item.RabattProzent > 0)
				{
					isEmpty = false;
					break;
				}
			}

			if (this.mtogglDiscountedOnly.Checked && isEmpty)
			{
				msg = "Der Kunde hat noch keine rabattierten Artikel. Die Liste wäre also leer.\nMöchtest Du stattdessen alle Artikel in der Liste exportieren?";
				if (MetroMessageBox.Show(this, msg, "Macht keinen Sinn", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.myCriteria.NurRabattierteFlag = false;
				}
				else return;
			}
			OfficeBridge.ServiceManager.ExcelService.ExportProductList(this.myExportList, this.myCriteria);
			msg = string.Empty;

			// Excel öffnen, wenn aktiviert.
			if (this.mtogglShowPostExport.Checked)
			{
				msg = "Export abgeschlossen. Excel wird automatisch gestartet.";
				var startInfo = new ProcessStartInfo();
				startInfo.FileName = "excel.exe";
				startInfo.Arguments = $"\"{this.myCriteria.ExcelFullName}\"";
				Process.Start(startInfo);
				return;
			}
			msg = $"Die ist im Ordner 'Dokumente' zu finden als: {Environment.NewLine}{this.myCriteria.ExcelFilename}";
			MetroMessageBox.Show(this, msg, "So, finito carusello");
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			if (!this.mtogglSaveSettings.Checked) this.myCriteria.SaveSettings();
			this.Close();
		}

		#endregion event handler

	}
}