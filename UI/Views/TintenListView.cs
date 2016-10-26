using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
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

		#endregion ### .ctor ###

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void TintenListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.SharedItemsService.UpdateTinteList();
		}

		void mbtnMakeEditable_Click(object sender, EventArgs e)
		{
			this.ToggleEditable();
		}

		void ToggleEditable()
		{
			if (this.dgvTinten.ReadOnly)
			{
				this.MakeEditable();
				this.metroToolTip1.SetToolTip(this.mbtnMakeEditable, "Schreibschutz einschalten");
			}
			else
			{
				this.MakeReadOnly();
				this.metroToolTip1.SetToolTip(this.mbtnMakeEditable, "Schreibschutz ausschalten");
			}
		}

		void btnNeueTinte_Click(object sender, EventArgs e)
		{
			var tinte = ModelManager.SharedItemsService.AddTinte();
			if (tinte != null)
			{
				((SortableBindingList<Tinte>)dgvTinten.DataSource).Add(tinte);
			}
			this.MakeEditable();
		}

		#endregion event handler

		#region private procedures

		void InitializeData(SortableBindingList<Tinte> tinten)
		{
			dgvTinten.AutoGenerateColumns = false;
			this.colHersteller.DataSource = ModelManager.SharedItemsService.HerstellerList;
			(this.colHersteller.DataSource as SortableBindingList<Hersteller>).Sort("Herstellername", ListSortDirection.Ascending);
			this.colHersteller.ValueMember = "UID";
			this.colHersteller.DisplayMember = "Herstellername";

			dgvTinten.DataSource = tinten;
		}

		void MakeEditable()
		{
			this.dgvTinten.ReadOnly = false;
			this.colHersteller.ReadOnly = false;
			this.colTintenbezeichnung.ReadOnly = false;
			this.colTyp.ReadOnly = false;
			this.mbtnMakeEditable.BackgroundImage = Properties.Resources.edit_32_metrogreen;
			this.dgvTinten.Style = MetroFramework.MetroColorStyle.Green;
		}

		void MakeReadOnly()
		{
			this.dgvTinten.ReadOnly = true;
			this.colHersteller.ReadOnly = true;
			this.colTintenbezeichnung.ReadOnly = true;
			this.colTyp.ReadOnly = true;
			this.mbtnMakeEditable.BackgroundImage = Properties.Resources.edit_32_metrored;
			this.dgvTinten.Style = MetroFramework.MetroColorStyle.Red;
		}

		#endregion private procedures
	}
}