using System;
using System.Windows.Forms;

namespace Products.Common.Views
{
	public partial class AdminCCView : Form
	{

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the AdminCCView class.
		/// </summary>
		public AdminCCView()
		{
			InitializeComponent();
		}

		#endregion

		#region event handler

		private void txtSuchDenLump_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SearchCustomer(txtSuchDenLump.Text.Trim());
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (!panelCommand.Visible)
			{
				pictureBox1.Image = global::Products.Common.Properties.Resources.cpm_green_48;
			}
			else
			{
				pictureBox1.Image = global::Products.Common.Properties.Resources.cpm_red_48;
			}
			panelCommand.Visible = !panelCommand.Visible;
		}

		private void lnkSalesToday_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Tut");
		}

		private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Quit();
		}

		#endregion

		#region private procedures

		private bool SearchCustomer(string searchFor)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				Products.Common.SortableBindingList<Model.Entities.Kunde> list = Model.ModelManager.ModelService.GetCustomersByAny(searchFor);
				if (list == null || list.Count == 0)
				{
					this.txtSuchDenLump.SelectAll();
					return false;
				}
				if (list.Count == 1)
				{
					Views.CustomerDashboardView cgv = new CustomerDashboardView(list[0]);
					cgv.Show();
					this.txtSuchDenLump.SelectAll();
					return true;
				}
				else
				{
					CustomerSearchView2 csv = new CustomerSearchView2(list);
					DialogResult dlgResult = csv.ShowDialog(this);
					if (dlgResult == System.Windows.Forms.DialogResult.OK && csv.CurrentCustomer != null)
					{
						Model.Entities.Kunde customer = csv.CurrentCustomer;
						Views.CustomerDashboardView cgv = new CustomerDashboardView(customer);
						cgv.Show();
						return true;
					}
					this.txtSuchDenLump.SelectAll();
					return false;
				}
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Quit()
		{
			this.Close();
		}

		#endregion

	}
}
