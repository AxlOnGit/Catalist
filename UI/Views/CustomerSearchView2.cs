using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CustomerSearchView2 : MetroForm
	{

		#region members

		Model.Entities.Kunde myCurrentCustomer;
		private bool DoNotMove;

		#endregion

		#region public properties

		/// <summary>
		/// Returns the selected customer.
		/// </summary>
		public Model.Entities.Kunde CurrentCustomer
		{
			get { return this.myCurrentCustomer; }
			private set { this.myCurrentCustomer = value; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerSearchView2 class.
		/// </summary>
		public CustomerSearchView2(Products.Common.SortableBindingList<Model.Entities.Kunde> customers)
		{
			InitializeComponent();
			this.dgvCustomers.AutoGenerateColumns = false;
			this.dgvCustomers.DataSource = customers;
		}

		#endregion

		#region event handler

		void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCustomers.Rows[e.RowIndex].DataBoundItem == null || DoNotMove) return;
			CurrentCustomer = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kunde;
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void dgvCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			OkAndClose();
		}

		void mbtnOpen_Click(object sender, EventArgs e)
		{
			OkAndClose();
		}

		void dgvCustomers_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.DoNotMove = true;
				e.Handled = true;
				OkAndClose();
			}
		}

		#endregion

		#region private procedures

		void OkAndClose()
		{
			if (myCurrentCustomer == null) return;
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.SetCurrentCustomer(this.myCurrentCustomer);
			this.Close();
		}

		void SetCurrentCustomer(Kunde kunde)
		{
			Model.ModelManager.CustomerService.CurrentCustomer = kunde;
		}

		#endregion

	}
}
