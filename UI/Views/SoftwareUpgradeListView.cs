using MetroFramework.Forms;
using Products.Model.Entities;
using System;

namespace Products.Common.Views
{
	public partial class SoftwareUpgradeListView : MetroForm
	{
		#region MEMBERS

		readonly SortableBindingList<SoftwareUpgrade> myDatasource;
		SoftwareUpgrade mySelectedSoftwareUpgrade;

		#endregion MEMBERS

		#region ### .ctor ###

		public SoftwareUpgradeListView(SortableBindingList<SoftwareUpgrade> upgradeList)
		{
			InitializeComponent();
			this.myDatasource = upgradeList ?? Model.ModelManager.SoftwareService.GetSoftwareUpgradeList();
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void dgvSoftwareUpgrades_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			this.mySelectedSoftwareUpgrade = this.dgvSoftwareUpgrades.Rows[e.RowIndex].DataBoundItem as SoftwareUpgrade;
		}

		void dgvSoftwareUpgrades_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.mySelectedSoftwareUpgrade != null)
			{
				var suv = new SoftwareUpgradeView(this.mySelectedSoftwareUpgrade);
				suv.Show();
			}
		}

		void mbtnNewSoftwareUpgrade_Click(object sender, EventArgs e)
		{
			// Die Kundennummer ermitteln.
			var title = "Kunden für neues Software-Upgrade suchen";
			Kunde kunde = null;
			var csv = new CustomerSearchView(title, false);
			csv.ShowDialog(this);
			if (csv.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				var customerRow = csv.SelectedCustomer;
				if (customerRow != null) kunde = Model.ModelManager.CustomerService.GetKunde(customerRow.Kundennummer, false);

				// Die zu aktualisierende Kundensoftware ermitteln.
				Kundensoftware alteSoftware = null;
				var ksv = new KundensoftwareSearchView(kunde);
				ksv.ShowDialog(this);
				if (ksv.DialogResult == System.Windows.Forms.DialogResult.OK)
				{
					alteSoftware = ksv.SelectedKundensoftware;
				}
				if (kunde != null && alteSoftware != null)
				{
					var newUpgrade = Model.ModelManager.SoftwareService.AddSoftwareUpgrade(kunde, alteSoftware);
					var suv = new SoftwareUpgradeView(newUpgrade);
					suv.Show();
				}
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region private procedures

		void InitializeData()
		{
			this.dgvSoftwareUpgrades.AutoGenerateColumns = false;
			this.dgvSoftwareUpgrades.DataSource = this.myDatasource;
		}

		#endregion private procedures
	}
}