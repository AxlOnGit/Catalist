using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ModellserieView : MetroForm
	{

		#region CONST

		const string templatePath = @"CPM_INTERN\Firmenvorlagen\CatalistAuto";

		#endregion

		#region MEMBERS

		Maschinenserie myMaschinenserie;
		bool mySaveChanges = true;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ModellserieView"/> Formularklasse.
		/// </summary>
		/// <param name="serie">Die anzuzeigende Maschinenserie.</param>
		public ModellserieView(Maschinenserie serie)
		{
			InitializeComponent();
			this.myMaschinenserie = serie;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void btnSetTechnikordner_Click(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog();
			fbd.Description = "Technikordner auswählen";
			if (!string.IsNullOrEmpty(this.myMaschinenserie.Dateipfad)) fbd.SelectedPath = this.myMaschinenserie.Dateipfad;

			if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
			{
				this.mtxtDateipfad.Text = fbd.SelectedPath;
				this.myMaschinenserie.Dateipfad = fbd.SelectedPath;
			}
		}

		private void btnSetInstChecklistVorlage_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			ofd.Filter = "Word Vorlage (*.dotx)|*.dotx";
			if (ModelManager.UserService.CurrentUser.NameFirst.ToLower() == "axel")
			{
				ofd.InitialDirectory = Path.Combine(userDir, @"OneDrive\VAN ANDEREN", templatePath);
			}
			else
			{
				ofd.InitialDirectory = Path.Combine(userDir, @"OneDrive\CPM", templatePath);
			}
			if (ofd.ShowDialog(this) == DialogResult.OK)
			{
				var checkFi = new FileInfo(ofd.FileName);
				var filename = checkFi.Name;
				this.myMaschinenserie.InstallationsChecklistenVorlage = filename;
			}
		}

		private void btnSetInstReportVorlage_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			ofd.DefaultExt = "dotx";
			ofd.Filter = "Word Vorlage (*.dotx)|*.dotx";
			if (ModelManager.UserService.CurrentUser.NameFirst.ToLower() == "axel")
			{
				ofd.InitialDirectory = Path.Combine(userDir, @"OneDrive\VAN ANDEREN", templatePath);
			}
			else
			{
				ofd.InitialDirectory = Path.Combine(userDir, @"OneDrive\CPM", templatePath);
			}
			if (ofd.ShowDialog(this) == DialogResult.OK)
			{
				var checkFi = new FileInfo(ofd.FileName);
				var filename = checkFi.Name;
				this.myMaschinenserie.InstallationsReportVorlage = filename;
			}
		}

		void btnAddSerie_Click(object sender, EventArgs e)
		{
			Model.ModelManager.SharedItemsService.UpdateMaschinenSerien();
			this.myMaschinenserie = Model.ModelManager.SharedItemsService.AddMaschinenSerie();
			this.InitializeData();
		}

		void chkWartungskennzeichen_CheckedChanged(object sender, EventArgs e)
		{
			this.SetWartung(this.chkWartungskennzeichen.Checked);
		}

		void mbtnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.mySaveChanges = false;
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.DataBindings.Clear();
			this.mtxtDateipfad.DataBindings.Clear();
			this.mtxtSerienname.DataBindings.Clear();
			this.mcmbHersteller.DataBindings.Clear();
			this.mcmbMaschinentyp.DataBindings.Clear();
			this.mtxtEinfuehrung.DataBindings.Clear();
			this.mtxtLetzteFirmware.DataBindings.Clear();
			this.mtxtWartungsintervall.DataBindings.Clear();
			this.chkWartungskennzeichen.DataBindings.Clear();

			this.DataBindings.Add("Text", this.myMaschinenserie, "Serienname");
			this.mtxtSerienname.DataBindings.Add("Text", this.myMaschinenserie, "Serienname");
			this.mtxtDateipfad.DataBindings.Add("Text", this.myMaschinenserie, "Dateipfad");

			this.mcmbHersteller.DataSource = Model.ModelManager.SharedItemsService.HerstellerList;
			this.mcmbHersteller.ValueMember = "UID";
			this.mcmbHersteller.DisplayMember = "Herstellername";
			this.mcmbHersteller.DataBindings.Add("SelectedValue", this.myMaschinenserie, "HerstellerId");

			this.mcmbMaschinentyp.DataSource = Model.ModelManager.SharedItemsService.MaschinenTypList;
			this.mcmbMaschinentyp.ValueMember = "UID";
			this.mcmbMaschinentyp.DisplayMember = "MaschinentypName";
			this.mcmbMaschinentyp.DataBindings.Add("SelectedValue", this.myMaschinenserie, "MaschinentypId");

			this.mtxtLetzteFirmware.DataBindings.Add("Text", this.myMaschinenserie, "LetzteFirmware");
			this.mtxtEinfuehrung.DataBindings.Add("Text", this.myMaschinenserie, "Markteinfuehrung");
			this.mtxtWartungsintervall.DataBindings.Add("Text", this.myMaschinenserie, "Wartungsintervall");
			this.chkWartungskennzeichen.DataBindings.Add("Checked", this.myMaschinenserie, "Wartungskennzeichen");
			this.SetWartung(this.myMaschinenserie.Wartungskennzeichen);

			this.mtxtInstChecklistVorlage.DataBindings.Add("Text", this.myMaschinenserie, "InstallationsChecklistenVorlage");
			this.mtxtInstReportVorlage.DataBindings.Add("Text", this.myMaschinenserie, "InstallationsReportVorlage");

			this.FormClosing += ModellserieView_FormClosing;
		}

		void SetWartung(bool yesOrNo)
		{
			switch (yesOrNo)
			{
				case true:
				this.chkWartungskennzeichen.Text = "Wird gewartet";
				this.mlblAlle.Visible = true;
				this.mtxtWartungsintervall.Visible = true;
				this.mlblMonate.Visible = true;
				break;

				case false:
				this.chkWartungskennzeichen.Text = "Wird nicht gewartet";
				this.mlblAlle.Visible = false;
				this.mtxtWartungsintervall.Visible = false;
				this.mlblMonate.Visible = false;
				break;
			}
		}

		void ModellserieView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.mySaveChanges) ModelManager.SharedItemsService.UpdateMaschinenSerien();
		}

		#endregion PRIVATE PROCEDURES

	}
}