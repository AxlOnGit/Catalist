using System;
using System.ComponentModel;
using MetroFramework.Forms;
using System.Windows.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class TintenListView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TintenListView Klasse.
		/// </summary>
		public TintenListView(SortableBindingList<Tinte> tintenTypen)
		{
			InitializeComponent();

			this.InitializeData(tintenTypen);
		}

		#endregion

		#region event handler

		void TintenListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.SharedItemsService.UpdateTinteList();
		}

		#endregion

		#region private procedures

		void InitializeData(SortableBindingList<Tinte> tinten)
		{
			dgvTinten.AutoGenerateColumns = false;

			this.colHersteller.DataSource =  ModelManager.SharedItemsService.HerstellerList;
			(this.colHersteller.DataSource as SortableBindingList<Hersteller>).Sort("Herstellername", ListSortDirection.Ascending);
			this.colHersteller.ValueMember = "UID";
			this.colHersteller.DisplayMember = "Herstellername";

			dgvTinten.DataSource = tinten;
		}

		void btnNeueTinte_Click(object sender, EventArgs e)
		{
			var tinte = ModelManager.SharedItemsService.AddTinte();
			if (tinte != null)
			{
				((SortableBindingList<Tinte>)dgvTinten.DataSource).Add(tinte);
			}
		}

		#endregion

	}
}
