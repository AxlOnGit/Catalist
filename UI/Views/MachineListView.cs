using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Products.Common.Views
{
	public partial class MachineListView : Form
	{

		#region members

		Model.Entities.Kunde myKunde;
		Model.Entities.Kundenmaschine currentMachine;
	
		#endregion

		#region ### .ctor ###

		public MachineListView(Model.Entities.Kunde kunde)
		{
			InitializeComponent();
			this.myKunde = kunde;
			this.Text = string.Format("{0} - Maschinenliste",kunde.CompanyName1);
			this.dgvMachines.AutoGenerateColumns = false;
			this.dgvMachines.DataSource = kunde.Kundenmaschinenliste;
		}

		#endregion

		#region private procedures
	
		#endregion

		#region event handler

		private void lnkNewMachine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Model.Entities.Kundenmaschine newMachine = myKunde.AddKundenmaschine();
			CustomerMachineView cmv = new CustomerMachineView(newMachine);
			cmv.Show();
		}

		private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void MachineListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateMe();
		}

		private void dgvMachines_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvMachines.RowCount > 0 && dgvMachines.Rows[e.RowIndex].DataBoundItem != null)
			{
				currentMachine = dgvMachines.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kundenmaschine;
			}
		}

		private void dgvMachines_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ShowMachineDetails();
		}

		private void lnkShowDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowMachineDetails();
		}

		private void cmnuLinkToOtherCustomer_Click(object sender, EventArgs e)
		{
			if (currentMachine != null)
			{
				CustomerSearchView csv = new CustomerSearchView("Kunden zum Verknüpfen auswählen");
				if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK && csv.SelectedCustomer != null)
				{
					myKunde.MoveKundenmaschine(currentMachine, csv.SelectedCustomer.Kundennummer);
				}
				dgvMachines.DataSource = Model.ModelManager.ModelService.Kundenmaschinen(myKunde);
				dgvMachines.Sort(colModell, ListSortDirection.Ascending);
			}
		}

		private void lnkServicetermine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowServicetermine();
		}

		#endregion

		#region private procedures

		private void UpdateMe()
		{
			Model.ModelManager.ModelService.UpdateKundenmaschinen();
		}

		private void ShowMachineDetails()
		{
			if (currentMachine != null)
			{
				CustomerMachineView cmv = new CustomerMachineView(currentMachine);
				cmv.Show();
			}
		}

		private void ShowServicetermine()
		{

		}

		#endregion

	}
}
