using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ModellserieView : MetroForm
	{

		#region members

		Maschinenserie myMaschinenserie;

		#endregion

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

		#endregion

		#region event handler

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

		void btnAddSerie_Click(object sender, EventArgs e)
		{
			Model.ModelManager.SharedItemsService.UpdateMaschinenSerien();
			this.myMaschinenserie = Model.ModelManager.SharedItemsService.AddMaschinenSerie();
			this.InitializeData();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

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
			this.mlblAlle.DataBindings.Add("Visible", this.myMaschinenserie, "Wartungskennzeichen", true, DataSourceUpdateMode.OnValidation);
			this.mlblMonate.DataBindings.Add("Visible", this.myMaschinenserie, "Wartungskennzeichen", true, DataSourceUpdateMode.OnValidation);
			this.mtxtWartungsintervall.DataBindings.Add("Visible", this.myMaschinenserie, "Wartungskennzeichen", true, DataSourceUpdateMode.OnValidation);

			this.FormClosing += ModellserieView_FormClosing;
		}

		void ModellserieView_FormClosing(object sender, FormClosingEventArgs e)
		{
			Model.ModelManager.SharedItemsService.UpdateMaschinenSerien();
		}

		#endregion

	}
}
