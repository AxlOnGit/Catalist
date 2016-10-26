using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ModellListView : MetroForm
	{
		#region members

		Maschinenmodell mySelectedModel;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der MaschinenmodellView Klasse.
		/// </summary>
		public ModellListView()
		{
			InitializeComponent();
			InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void btnAddMaschinenModell_Click(object sender, System.EventArgs e)
		{
			var newModel = ModelManager.SharedItemsService.AddMaschinenModell();
			this.ShowModelView(newModel);
		}

		void btnShowModellserieListView_Click(object sender, System.EventArgs e)
		{
			var mlv = new ModellserieListView();
			mlv.Show(this);
		}

		void dgvModelle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			dgvModelle.FirstDisplayedScrollingRowIndex = e.RowIndex;
		}

		void mbtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		void DgvModelle_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var model = this.dgvModelle.Rows[e.RowIndex].DataBoundItem as Maschinenmodell;
			if (model != null) this.mySelectedModel = model;
		}

		void MaschinenmodellView_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateMe();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.colHerstellerrId.DataSource = ModelManager.SharedItemsService.HerstellerList.Sort("Herstellername", System.ComponentModel.ListSortDirection.Ascending);
			this.colHerstellerrId.ValueMember = "UID";
			this.colHerstellerrId.DisplayMember = "Herstellername";

			this.colMaschinenTypId.DataSource = ModelManager.SharedItemsService.MaschinenTypList.Sort("MaschinentypName", System.ComponentModel.ListSortDirection.Ascending);
			this.colMaschinenTypId.ValueMember = "UID";
			this.colMaschinenTypId.DisplayMember = "MaschinentypName";

			this.colModellserie.DataSource = ModelManager.SharedItemsService.MaschinenSerieList.Sort("Serienname", System.ComponentModel.ListSortDirection.Ascending);
			this.colModellserie.ValueMember = "UID";
			this.colModellserie.DisplayMember = "Serienname";

			this.dgvModelle.AutoGenerateColumns = false;
			this.dgvModelle.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			dgvModelle.RowsAdded += dgvModelle_RowsAdded;
			dgvModelle.RowEnter += DgvModelle_RowEnter;
		}

		void ShowModelView(Maschinenmodell model)
		{
			if (model != null)
			{
				var mv = new ModellView(model);
				mv.Show();
			}
		}

		void UpdateMe()
		{
			ModelManager.SharedItemsService.UpdateMaschinenModell();
		}

		#endregion private procedures

		void dgvModelle_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedModel != null)
			{
				this.ShowModelView(this.mySelectedModel);
			}
		}
	}
}