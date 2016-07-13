using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CustomerSearchView1 : MetroForm
	{

		#region members

		SortableBindingList<Suchkunde> mySuchkundenListe;
		Suchkunde mySelectedSuchkunde;
		 
		#endregion

		#region public properties

		/// <summary>
		/// Gibt den vom Benutzer ausgewählten Kunden zurück.
		/// </summary>
		public Suchkunde SelectedSuchkunde
		{
			get { return this.mySelectedSuchkunde; }
		}

		#endregion

		#region ### .ctor ###

		public CustomerSearchView1(SortableBindingList<Suchkunde> suchkundenListe, string suchkriterium)
		{
			InitializeComponent();
			this.mySuchkundenListe = suchkundenListe;

			this.InitializeData(suchkriterium);
		}

		#endregion

		#region private proceduress

		void InitializeData(string searchCriteria)
		{
			this.Text = string.Format("Kundensuche nach: '{0}'", searchCriteria);
			this.dgvSuchkunden.AutoGenerateColumns = false;
			this.dgvSuchkunden.DataSource = this.mySuchkundenListe;
		}

		#endregion

		#region event handler

		void dgvSuchkunden_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedSuchkunde = this.dgvSuchkunden.Rows[e.RowIndex].DataBoundItem as Suchkunde;
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.SetCurrentCustomer();
		}

		void SetCurrentCustomer()
		{
			if (this.mySelectedSuchkunde != null)
			{
				ModelManager.CustomerService.CurrentCustomer = ModelManager.CustomerService.GetKunde(this.mySelectedSuchkunde.Kundennummer, true);
			}
		}

		void dgvSuchkunden_DoubleClick(object sender, EventArgs e)
		{
			if (this.SelectedSuchkunde != null)
			{
				this.DialogResult = DialogResult.OK;
				this.SetCurrentCustomer();
				this.Close();
			}
		}

		#endregion

	}
}
