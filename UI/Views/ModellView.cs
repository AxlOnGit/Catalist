using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using System;

namespace Products.Common.Views
{
	public partial class ModellView : MetroForm
	{
		#region MEMBERS

		Maschinenmodell myModel;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ModellView"/> Formularklasse.
		/// </summary>
		public ModellView(Maschinenmodell model)
		{
			InitializeComponent();
			this.myModel = model;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void btnAddModel_Click(object sender, EventArgs e)
		{
			this.myModel = ModelManager.SharedItemsService.AddMaschinenModell();
			this.InitializeData();
		}

		void ModellView_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			ModelManager.SharedItemsService.UpdateMaschinenModell();
		}

		void mbtnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.DataBindings.Clear();
			this.mtxtModellbezeichnung.DataBindings.Clear();
			this.mcmbHersteller.DataBindings.Clear();
			this.mcmbMaschinenserie.DataBindings.Clear();
			this.mcmbMaschinentyp.DataBindings.Clear();

			this.DataBindings.Add("Text", this.myModel, "Modellbezeichnung");
			this.mtxtModellbezeichnung.DataBindings.Add("Text", this.myModel, "Modellbezeichnung");

			this.mcmbHersteller.DataSource = ModelManager.SharedItemsService.HerstellerList;
			this.mcmbHersteller.ValueMember = "UID";
			this.mcmbHersteller.DisplayMember = "Herstellername";
			this.mcmbHersteller.DataBindings.Add("SelectedValue", this.myModel, "HerstellerId");

			this.mcmbMaschinenserie.DataSource = ModelManager.SharedItemsService.MaschinenSerieList;
			this.mcmbMaschinenserie.ValueMember = "UID";
			this.mcmbMaschinenserie.DisplayMember = "Serienname";
			this.mcmbMaschinenserie.DataBindings.Add("SelectedValue", this.myModel, "ModellSerieId");

			this.mcmbMaschinentyp.DataSource = ModelManager.SharedItemsService.MaschinenTypList;
			this.mcmbMaschinentyp.ValueMember = "UID";
			this.mcmbMaschinentyp.DisplayMember = "MaschinentypName";
			this.mcmbMaschinentyp.DataBindings.Add("SelectedValue", this.myModel, "MaschinentypId");

			this.FormClosing += ModellView_FormClosing;
		}

		#endregion PRIVATE PROCEDURES
	}
}