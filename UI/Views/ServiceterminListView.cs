using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class ServiceterminListView : MetroForm
	{

		#region members

		private Model.Entities.Kunde myCustomer;
		private Model.Entities.Kundenmaschine myMachine;
		private Model.Entities.Servicetermin currentTermin;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ServicetermineListView Klasse.
		/// </summary>
		/// <param name="linkedItem"></param>
		public ServiceterminListView(object linkedItem)
		{
			InitializeComponent();

			if (linkedItem.GetType().Equals(typeof(Model.Entities.Kunde)))
			{
				myCustomer = linkedItem as Model.Entities.Kunde;
			}
			else if (linkedItem.GetType().Equals(typeof(Model.Entities.Kundenmaschine)))
			{
				myMachine = linkedItem as Model.Entities.Kundenmaschine;
			}
			InitializeData();
		}

		#endregion

		#region event handler

		private void dgvServicetermine_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvServicetermine.Rows[e.RowIndex] != null)
			{
				currentTermin = dgvServicetermine.Rows[e.RowIndex].DataBoundItem as Model.Entities.Servicetermin;
			}
		}

		private void dgvServicetermine_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (currentTermin != null)
			{
				ServiceterminView sv = new ServiceterminView(myCustomer, currentTermin);
				sv.Show();
			}
		}

		private void btnAddServicetermin_Click(object sender, EventArgs e)
		{
			KundenmaschineSearchView ksv = new KundenmaschineSearchView(myCustomer.Kundenmaschinenliste);
			if (ksv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				if (ksv.SelectedMachine != null)
				{
					Model.Entities.Kundenmaschine selMachine = ksv.SelectedMachine;
					Model.Entities.Servicetermin neuerTermin = myCustomer.AddServicetermin(selMachine);
					ServiceterminView sv = new ServiceterminView(myCustomer, neuerTermin);
					sv.ShowDialog();
				}
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ServicetermineListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (myCustomer != null)
			{
				myCustomer.UpdateServicetermine();
			}
		}

		private void btnClose_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		private void InitializeData()
		{
			dgvServicetermine.AutoGenerateColumns = false;
			if (myCustomer != null)
			{
				lblKundenname.Text = myCustomer.CompanyName1.Replace("&", "&&");
				this.dgvServicetermine.DataSource = myCustomer.Serviceterminliste;
			}
			else if (myMachine != null)
			{
				lblKundenname.Text = myMachine.Kunde.CompanyName1.Replace("&", "&&");
				this.dgvServicetermine.DataSource = myMachine.Serviceterminliste;
			}
		}

		#endregion

	}
}
