using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class SettingsView : MetroForm
	{

		#region ### .ctor ###

		public SettingsView()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion

		#region EVENT HANDLER

		#region DATEI- UND PFADAUSWAHL

		void SetSageExePath(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = "exe";
			ofd.Filter = "SAGE Programmdatei|cl.exe";
			ofd.InitialDirectory = Path.GetDirectoryName(mtxtSageExePfad.Text);
			ofd.Multiselect = false;
			ofd.Title = "Wo finde ich die SAGE Programmdatei?";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				mtxtSageExePfad.Text = ofd.FileName;
				CatalistRegistry.Application.Sage_ExePath = ofd.FileName;
			}
		}

		void SetCatalogPath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo finde ich die Katalogvorlage?";
			Directory.SetCurrentDirectory(mtxtKatalogPfad.Text);
			fbd.SelectedPath = mtxtKatalogPfad.Text;
			fbd.ShowNewFolderButton = false;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				mtxtKatalogPfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.CatalogPath = fbd.SelectedPath;
			}
		}

		void SetCatalogTemplateFilePath(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = "exe";
			ofd.Filter = "Katalogvorlage|*.docx";
			if (!string.IsNullOrEmpty(CatalistRegistry.Application.CatalogTemplateFilePath))
			{
				ofd.InitialDirectory = Path.GetDirectoryName(CatalistRegistry.Application.CatalogTemplateFilePath);
			}
			ofd.Multiselect = false;
			ofd.Title = "Welche Vorlage soll ich für Kundenkataloge nehmen?";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				mtxtKatalogvorlagePfad.Text = ofd.FileName;
				CatalistRegistry.Application.CatalogTemplateFilePath = ofd.FileName;
			}
		}

		void SetPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo werden Bilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtBilderPfad.Text);
			fbd.SelectedPath = mtxtBilderPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				mtxtBilderPfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.PicturePath = fbd.SelectedPath;
			}
		}

		void SetManufacturerPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sind die Herstellerbilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtHerstellerlogoPfad.Text);
			fbd.SelectedPath = this.mtxtHerstellerlogoPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				this.mtxtHerstellerlogoPfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.ManufacturerPicturePath = fbd.SelectedPath;
			}
		}

		void SetProductPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sind die Produktbilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtProduktbilderPfad.Text);
			fbd.SelectedPath = mtxtProduktbilderPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				mtxtProduktbilderPfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.ProductPicturePath = fbd.SelectedPath;
			}
		}

		void SetOfferFilePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sollen die Angebote gespeichert werden?";
			Directory.SetCurrentDirectory(mtxtAngebotspfad.Text);
			fbd.SelectedPath = mtxtAngebotspfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				mtxtAngebotspfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.OfferFilePath = fbd.SelectedPath;
			}
		}

		void SetDateilinkPfad(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sollen Dateiverknüpfungen gespeichert werden?";
			Directory.SetCurrentDirectory(mtxtDateilinksPfad.Text);
			fbd.SelectedPath = mtxtDateilinksPfad.Text;
			fbd.ShowNewFolderButton = false;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				mtxtDateilinksPfad.Text = fbd.SelectedPath;
				CatalistRegistry.Application.LinkedFilesPath = fbd.SelectedPath;
			}
		}

		#endregion DATEI- UND PFADAUSWAHL

		#region TEXTFELDER

		void TaxRate_Validating(object sender, CancelEventArgs e)
		{
			double val;
			if (double.TryParse(mtxtTaxRateFactor.Text, out val))
			{
				CatalistRegistry.Application.TaxRate = val;
			}
			else
			{
				e.Cancel = true;
				MetroMessageBox.Show(this, "Hier sind nur Ziffern erlaubt, mit einem Komma als Dezimaltrennzeichen.", "Hier bitte nur Zahlen");
			}
		}

		void Atapi_Leitung_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.ATAPI_Line = mtxtAtapiLeitung.Text;
		}

		void SageExePfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.Sage_ExePath = mtxtSageExePfad.Text;
		}

		void KatalogPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.CatalogPath = this.mtxtKatalogPfad.Text;
		}

		void KatalogvorlagePfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.CatalogTemplateFilePath = mtxtKatalogvorlagePfad.Text;
		}

		void BilderPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.PicturePath = mtxtBilderPfad.Text;
		}

		void ProduktbilderPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.ProductPicturePath = mtxtProduktbilderPfad.Text;
		}

		void HerstellerlogoPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.ManufacturerPicturePath = mtxtProduktbilderPfad.Text;
		}

		void AngebotsPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.OfferFilePath = mtxtAngebotspfad.Text;
		}

		void SageBenutzer_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.UserInSage = mtxtSageBenutzer.Text;
		}

		void DateilinkPfad_Validating(object sender, CancelEventArgs e)
		{
			CatalistRegistry.Application.LinkedFilesPath = mtxtDateilinksPfad.Text;
		}

		private void mtxtSmtpPassword_Validated(object sender, EventArgs e)
		{
			CatalistRegistry.Application.SenderPW = this.mtxtSmtpPassword.Text;
		}

		#endregion TEXTFELDER

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.mtxtAngebotspfad.Text = CatalistRegistry.Application.OfferFilePath;
			this.mtxtAtapiLeitung.Text = CatalistRegistry.Application.ATAPI_Line;
			this.mtxtBilderPfad.Text = CatalistRegistry.Application.PicturePath;
			this.mtxtDateilinksPfad.Text = CatalistRegistry.Application.LinkedFilesPath;
			this.mtxtHerstellerlogoPfad.Text = CatalistRegistry.Application.ManufacturerPicturePath;
			this.mtxtKatalogPfad.Text = CatalistRegistry.Application.CatalogPath;
			this.mtxtKatalogvorlagePfad.Text = CatalistRegistry.Application.CatalogTemplateFilePath;
			this.mtxtProduktbilderPfad.Text = CatalistRegistry.Application.ProductPicturePath;
			this.mtxtSageBenutzer.Text = CatalistRegistry.Application.UserInSage;
			this.mtxtSageExePfad.Text = CatalistRegistry.Application.Sage_ExePath;
			this.mtxtSmtpPassword.Text = CatalistRegistry.Application.SenderPW;
			this.mtxtSmtpPort.Text = CatalistRegistry.Application.SmtpPort.ToString("N0");
			this.mtxtSmtpServer.Text = CatalistRegistry.Application.SmtpServer;
			this.mtxtTaxRateFactor.Text = CatalistRegistry.Application.TaxRate.ToString("N2");
		}

		#endregion PRIVATE PROCEDURES

	}
}