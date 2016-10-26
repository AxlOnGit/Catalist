using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ModellserieListView : MetroForm
	{
		#region members

		Maschinenserie mySelectedSerie;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ModellserieListView Klasse.
		/// </summary>
		public ModellserieListView()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion ### .ctor ###



		#region private procedures

		void InitializeData()
		{
			this.dgvModellserien.RowEnter += DgvModellserien_RowEnter;
			this.dgvModellserien.MouseDoubleClick += DgvModellserien_MouseDoubleClick;
			this.dgvModellserien.AutoGenerateColumns = false;
			this.dgvModellserien.DataSource = Model.ModelManager.SharedItemsService.MaschinenSerieList.Sort("Serienname");
		}

		#endregion private procedures

		#region event handler

		void DgvModellserien_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var serie = this.dgvModellserien.Rows[e.RowIndex].DataBoundItem as Maschinenserie;
			if (serie != null) this.mySelectedSerie = serie;
		}

		void DgvModellserien_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedSerie == null) return;
			var msv = new ModellserieView(this.mySelectedSerie);
			msv.Show(this);
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler
	}
}