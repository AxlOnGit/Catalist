using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class SettingsView : MetroForm
	{

		#region members

		bool myDirty;

		#endregion

		public SettingsView()
		{
			InitializeComponent();
			Properties.Settings.Default.SettingChanging += Default_SettingChanging;

		}

		#region event handler

		void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
		{
			myDirty = true;
		}

		#region Datei- und Pfadauswahl

		void SetSageExePath(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = "exe";
			ofd.Filter = "SAGE Programmdatei|cl.exe";
			ofd.InitialDirectory = Path.GetDirectoryName(mtxtSageExePfad.Text);
			ofd.Multiselect = false;
			ofd.Title = "Wo finde ich die SAGE Programmdatei?";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				mtxtSageExePfad.Text = ofd.FileName;
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
			}
		}

		void SetCatalogTemplateFilePath(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = "exe";
			ofd.Filter = "Katalogvorlage|*.docx";
			ofd.InitialDirectory = Path.GetDirectoryName(mtxtKatalogvorlagePfad.Text);
			ofd.Multiselect = false;
			ofd.Title = "Welche Vorlage soll ich für Kundenkataloge nehmen?";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				mtxtKatalogvorlagePfad.Text = ofd.FileName;
			}
		}

		void SetPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo werden Bilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtBilderPfad.Text);
			fbd.SelectedPath = mtxtBilderPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				mtxtBilderPfad.Text = fbd.SelectedPath;
			}
		}

		void SetManufacturerPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sind die Herstellerbilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtHerstellerlogoPfad.Text);
			fbd.SelectedPath = this.mtxtHerstellerlogoPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				this.mtxtHerstellerlogoPfad.Text = fbd.SelectedPath;
			}
		}

		void SetProductPicturePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sind die Produktbilder gespeichert?";
			Directory.SetCurrentDirectory(mtxtProduktbilderPfad.Text);
			fbd.SelectedPath = mtxtProduktbilderPfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				mtxtProduktbilderPfad.Text = fbd.SelectedPath;
			}
		}

		void SetOfferFilePath(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sollen die Angebote gespeichert werden?";
			Directory.SetCurrentDirectory(mtxtAngebotspfad.Text);
			fbd.SelectedPath = mtxtAngebotspfad.Text;
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				mtxtAngebotspfad.Text = fbd.SelectedPath;
			}
		}

		void SetDateilinkPfad(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Wo sollen Dateiverknüpfungen gespeichert werden?";
			Directory.SetCurrentDirectory(mtxtDateilinksPfad.Text);
			fbd.SelectedPath = mtxtDateilinksPfad.Text;
			fbd.ShowNewFolderButton = false;
			if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				mtxtDateilinksPfad.Text = fbd.SelectedPath;
			}
		}

		#endregion

		#region Textfelderaktualisierung

		void TaxRate_Validating(object sender, CancelEventArgs e)
		{
			decimal val;
			if (decimal.TryParse(mtxtTaxRateFactor.Text, out val))
			{
				Global.TaxRateMultiplier = val;
			}
			else
			{
				e.Cancel = true;
				MessageBox.Show("Hier sind nur Ziffern erlaubt, mit einem Komma als Dezimalseparator.", "So geht's nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		void Atapi_Leitung_Validating(object sender, CancelEventArgs e)
		{
			Global.AtapiLineName = mtxtAtapiLeitung.Text;
		}

		void SageExePfad_Validating(object sender, CancelEventArgs e)
		{
			Global.SageExePath = mtxtSageExePfad.Text;
		}

		void KatalogPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.CustomerCatalogPath = mtxtKatalogPfad.Text;
		}

		void KatalogvorlagePfad_Validating(object sender, CancelEventArgs e)
		{
			Global.CatalogTemplateFilePath = mtxtKatalogvorlagePfad.Text;
		}

		void BilderPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.PicturePath = mtxtBilderPfad.Text;
		}

		void ProduktbilderPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.ProductPicturePath = mtxtProduktbilderPfad.Text;
		}

		void HerstellerlogoPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.ManufacturerPicturePath = mtxtProduktbilderPfad.Text;
		}

		void AngebotsPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.OfferFilePath = mtxtAngebotspfad.Text;
		}

		void SageBenutzer_Validating(object sender, CancelEventArgs e)
		{
			Global.SageUser = mtxtSageBenutzer.Text;
		}

		void DateilinkPfad_Validating(object sender, CancelEventArgs e)
		{
			Global.LinkedFilesPath = mtxtDateilinksPfad.Text;
		}

		void mtxtSenderEmailAddress_Validated(object sender, EventArgs e)
		{
			Global.SenderEmailAddress = this.mtxtSenderEmailAddress.Text;
		}

		void mtxtSignature_Validating(object sender, CancelEventArgs e)
		{
			Global.Signature = this.mtxtSignature.Text;
		}

		#endregion

		#endregion

		#region private procedures

		void mbtnClose_Click(object sender, EventArgs e)
		{
			CheckDirtyAndClose();
		}

		void CheckDirtyAndClose()
		{
			if (myDirty)
			{
				Properties.Settings.Default.Save();
			}
			this.Close();
		}

		#endregion

	}
}
