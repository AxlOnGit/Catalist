using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Interfaces;
using System.Diagnostics;
using Products.Model;
using Products.Model.Entities;
using Products.Common.Collections;
using Products.Common.Views;
using Products.Data;

namespace Products.Common.Panel
{
	public partial class pnlAuftraege : pnlSlider, IMetroControl
	{

		#region members

		readonly Kunde myKunde;
		readonly KundeMainView myParent;

		Order mySelectedOrder;
		Order mySelectedInvoice;

		readonly BindingSource bs = new BindingSource();
		readonly BindingSource bsDetails = new BindingSource();

		string currentFilter = string.Empty;

		#endregion

		#region public properties

		public string CurrentFilter
		{
			get { return this.currentFilter; }
			set
			{
				this.currentFilter = value;
				if (string.IsNullOrEmpty(value))
				{
					this.dgvOrders.DataSource = ModelManager.OrderService.GetOrderList(this.myKunde);
				}
				else
				{
					this.dgvOrders.DataSource = ModelManager.OrderService.GetFilteredOrderList(this.myKunde, value);
				}
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlAuftraege Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		public pnlAuftraege(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as Views.KundeMainView;
			this.myKunde = kunde;

			this.InitializeData();
			this.txtFilterTransactions.CustomButton.Click += CustomButton_Click;
		}

		#endregion

		void InitializeData()
		{
			this.dgvOrders.AutoGenerateColumns = false;
			this.dgvInvoice.AutoGenerateColumns = false;
			this.dgvDetails.AutoGenerateColumns = false;
			for (int i = 1; i < 5; i++)
			{
				this.dgvOrders.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			}
			this.dgvOrders.DataSource = ModelManager.OrderService.GetOrderList(this.myKunde);
		}

		#region event handler

		void txtFilterTransactions_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.dgvOrders.Focus();
			}
		}

		void txtFilterTransactions_Validated(object sender, EventArgs e)
		{
			this.CurrentFilter = txtFilterTransactions.Text;
			this.dgvOrders.Focus();
		}

		void pnlAuftraege_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && (e.KeyCode == Keys.Home))
			{
				this.myParent.ShowStartPanel();
			}
		}

		void txtFilterTransactions_ClearClicked()
		{
			this.txtFilterTransactions.Text = string.Empty;
			this.dgvOrders.Focus();
		}

		void mtglNurRechnungen_CheckedChanged(object sender, EventArgs e)
		{
			//if (mtglNurRechnungen.CheckState == CheckState.Checked)
			//{
			//  bs.Filter = "Vorgang = 'D' OR Vorgang = 'R'";
			//  this.lblAuftraege.Text = "Rechnungen und Direktrechnungen";
			//}
			//else
			//{
			//  bs.Filter = string.Empty;
			//  this.lblAuftraege.Text = "Alle Auftragsvorgänge";
			//}
		}

		void CustomButton_Click(object sender, EventArgs e)
		{
			this.dgvOrders.Focus();
		}

		void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedOrder = this.dgvOrders.Rows[e.RowIndex].DataBoundItem as Order;
			if (this.mySelectedOrder != null)
			{
				this.dgvDetails.DataSource = ModelManager.OrderService.GetOrderDetailList(this.mySelectedOrder);
				this.dgvInvoice.DataSource = ModelManager.OrderService.GetInvoiceList(this.mySelectedOrder);
			}
			else
			{
				this.dgvDetails.DataSource = null;
				this.dgvInvoice.DataSource = null;
			}
		}

		void dgvInvoice_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedInvoice = this.dgvInvoice.Rows[e.RowIndex].DataBoundItem as Order;
			if (this.mySelectedInvoice != null)
			{
				this.dgvDetails.DataSource = ModelManager.OrderService.GetInvoiceDetailList(this.mySelectedInvoice);
			}
			else
			{
				this.dgvDetails.DataSource = null;
			}
		}

		#endregion

		#region procedures

		void LoadTransactions()
		{
			this.bs.Filter = string.Empty;
			this.bs.Sort = string.Empty;
			this.bs.DataSource = null;
			this.bsDetails.DataSource = null;
			this.bs.DataSource = DataManager.AllDataService.GetAllOrdersPerKunde(myKunde.CustomerId);
			this.bs.Sort = "Datum DESC";
			this.dgvOrders.DataSource = bs;
		}

		#endregion

	}
}
