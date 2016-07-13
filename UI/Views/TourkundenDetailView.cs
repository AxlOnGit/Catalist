using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class TourkundenDetailView : MetroForm
	{

		#region members

		readonly Tour myTour;
		BindingSource bs;
		Kunde mySelectedKunde;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TourkundenDetailView Klasse.
		/// </summary>
		public TourkundenDetailView(Tour tour)
		{
			InitializeComponent();
			this.myTour = tour;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void TourkundenDetailView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.CustomerService.UpdateKunden();
		}

		void dgvTourkunden_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var kunde = this.dgvTourkunden.Rows[e.RowIndex].DataBoundItem as Kunde;
			if (kunde != null)
			{
				this.mySelectedKunde = kunde;
				this.mtxtAnmerkungen.DataBindings.Clear();
				this.mtxtAnmerkungen.DataBindings.Add("Text", this.mySelectedKunde, "Anmerkungen");
				
				this.mtxtCompetition.DataBindings.Clear();
				this.mtxtCompetition.DataBindings.Add("Text", this.mySelectedKunde, "Wettbewerber");
			}
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.bs = new BindingSource();
			this.bs.DataSource = myTour.Tourkunden;
			this.dgvTourkunden.AutoGenerateColumns = false;
			this.dgvTourkunden.DataSource = bs;
		}
		
		#endregion

	}
}
