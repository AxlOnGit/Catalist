using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class MaschinenmodellView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der MaschinenmodellView Klasse.
		/// </summary>
		public MaschinenmodellView()
		{
			InitializeComponent();
			InitializeData();
		}

		#endregion

		#region event handler

		void lnkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ModelManager.SharedItemsService.AddMaschinenModell();
		}

		void btnAddMaschinenModell_Click(object sender, System.EventArgs e)
		{
			ModelManager.SharedItemsService.AddMaschinenModell();
		}

		void dgvModelle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			dgvModelle.FirstDisplayedScrollingRowIndex = e.RowIndex;
		}

		void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		void mbtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		void MaschinenmodellView_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateMe();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.colHerstellerrId.DataSource = ModelManager.SharedItemsService.HerstellerList.Sort("Herstellername", System.ComponentModel.ListSortDirection.Ascending);
			this.colHerstellerrId.ValueMember = "UID";
			this.colHerstellerrId.DisplayMember = "Herstellername";

			this.colMaschinenTypId.DataSource = ModelManager.SharedItemsService.MaschinenTypList.Sort("MaschinentypName", System.ComponentModel.ListSortDirection.Ascending);
			this.colMaschinenTypId.ValueMember = "UID";
			this.colMaschinenTypId.DisplayMember = "MaschinentypName";

			this.dgvModelle.AutoGenerateColumns = false;
			this.dgvModelle.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			dgvModelle.RowsAdded += dgvModelle_RowsAdded;

		}

		void UpdateMe()
		{
			ModelManager.SharedItemsService.UpdateMaschinenModell();
		}
	
		#endregion

	}
}
