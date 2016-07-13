using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class CustomerOrderView : MetroForm
	{

		#region members

		private BindingSource bs = new BindingSource();
		private BindingSource bsDetails = new BindingSource();
		private Data.dsSage.OrderRow currentTransactionRow;
		private string currentFilter = string.Empty;
		private bool loadAllOrders = false;

		#endregion

		#region public properties

		internal Model.Entities.Kunde ThisCustomer { get; set; }

		public string CurrentFilter 
		{
			get { return currentFilter; }
			set 
			{ 
				currentFilter = value;
				if (string.IsNullOrEmpty(value))
				{
					LoadTransactions();
				}
				else
				{
					bs.DataSource = Data.DataManager.DataService.GetOrdersByDetailFilter(value);
				}
			} 
		}

		#endregion

		#region ### .ctor ###

		public CustomerOrderView()
		{
			InitializeComponent();
			this.dgvOrders.AutoGenerateColumns = false;
			this.dgvDetails.AutoGenerateColumns = false;
			txtFilterTransactions.DataBindings.Add("Text", this, "CurrentFilter");
			Application.Idle += new EventHandler(Application_Idle);
		}

		public CustomerOrderView(Model.Entities.Kunde customer, bool reopenSearch) 
			: this()
		{
			ThisCustomer = customer;
			this.lblCustomerName.Text = string.Format(@"{0} ({1})", customer.CompanyName1.Replace("&","&&"), customer.CustomerId.Substring(0, 5));
			this.lblCustomerNameAdd.Text = customer.CompanyName2;
			this.lblStreet.Text = customer.Street;
			this.lblZipAndCity.Text = string.Format("{0} {1}", customer.ZipCode, customer.City);

			Data.DataManager.DataService.GetTabelleOrdersPerKunde(customer.CustomerId);
			LoadTransactions();
			this.txtFilterTransactions.Focus();
		}

		//public CustomerOrderView(Model.Entities.Customer customer, string vorgang, string number, bool reopenSearch)
		//  : this(customer, reopenSearch)
		//{
		//  if (vorgang == "Auftrag")
		//  {
		//    vorgang = "A";
		//  }
		//  else if (vorgang == "Direktrechnung")
		//  {
		//    vorgang = "D";
		//  }
		//  else if (vorgang == "Rechnung")
		//  {
		//    vorgang = "R";
		//  }
		//  SelectRow(vorgang, number);
		//}

		#endregion

		#region event handler

		void Application_Idle(object sender, EventArgs e)
		{
			mtglNurRechnungen.Enabled = dgvOrders.Rows.Count > 0;
			txtFilterTransactions.ShowButton = !string.IsNullOrEmpty(CurrentFilter);
		}

		private void mtglNurRechnungen_CheckedChanged(object sender, EventArgs e)
		{
			if (mtglNurRechnungen.CheckState == CheckState.Checked)
			{
				bs.Filter = "Vorgang = 'D' OR Vorgang = 'R'";
				this.lblTransactions.Text = "Rechnungen und Direktrechnungen";
			}
			else
			{
				bs.Filter = string.Empty;
				this.lblTransactions.Text = "Alle Auftragsvorgänge";
			}
		}

		private void mtglAllOrders_CheckedChanged(object sender, EventArgs e)
		{
			// Den TableAdapter für Order und OrderDetails resetten, damit die Daten
			// vom MySql Server geholt werden und nicht mit den bereits geladenen Daten gearbeitet wird.
			Data.DataManager.DataService.ResetOrdersInitialized();
			if (mtglAllOrders.CheckState == CheckState.Checked)
			{
				loadAllOrders = true;
				LoadTransactions();
			}
			else
			{
				loadAllOrders = false;
				LoadTransactions();
			}
		}

		private void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (dgv.Rows[e.RowIndex] != null)
			{
				Data.dsSage.OrderRow transRow;
				DataRowView drv = dgv.Rows[e.RowIndex].DataBoundItem as DataRowView;
				if (drv != null)
				{
					transRow = (Data.dsSage.OrderRow)drv.Row;
				}
				else
				{
					transRow = (Data.dsSage.OrderRow)dgv.Rows[e.RowIndex].DataBoundItem;
				}
				this.currentTransactionRow = transRow;
				this.bsDetails.DataSource = transRow.GetOrderDetailRows().Where(d => d.VorgangspresetTemporaer == transRow.Vorgang & d.Gesamtpreis > 0).OrderBy(d => d.Positionszaehler).ToList();
				this.dgvDetails.DataSource = bsDetails;
			}
		}

		private void txtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				dgvOrders.Focus();
			}
		}

		private void txtFilterTransactions_ClearClicked()
		{
			CurrentFilter = string.Empty;
			dgvOrders.Focus();
			txtFilterTransactions.ShowButton = false;
		}

		private void dgvOrders_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.currentTransactionRow != null)
			{
				this.OpenTransactionInSage();
			}
		}

		private void xMnuOpenTransactionInSage_Click(object sender, EventArgs e)
		{
			this.OpenTransactionInSage();
		}

		private void OpenTransactionInSage()
		{
			Clipboard.SetText(currentTransactionRow.Auftrag);
			string progParams = @"/X""PA2100|00000"" /B/P";
			ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Sage_ExePath, progParams);
			Process.Start(psi);
		}

		private void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Selects the row with the specified "Vorgang" and "Number".
		/// </summary>
		/// <param name="vorgang"></param>
		/// <param name="nummer"></param>
		public void SelectRow(string vorgang, string nummer)
		{
			DataGridViewRow row = dgvOrders.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["colVorgang"].Value.ToString() == vorgang & r.Cells["colNummer"].Value.ToString() == nummer).First();
			int rowIndex = row.Index;
			dgvOrders.Rows[rowIndex].Selected = true;
			dgvOrders.FirstDisplayedScrollingRowIndex = rowIndex;
		}
	
		#endregion

		#region private procedures

		private void LoadTransactions()
		{
			bs.Filter = string.Empty;
			bs.Sort = string.Empty;
			bs.DataSource = null;
			bsDetails.DataSource = null;

			if (loadAllOrders)
			{
				bs.DataSource = Data.DataManager.DataService.GetAllOrdersPerKunde(ThisCustomer.CustomerId);
			}
			else
			{
				bs.DataSource = Data.DataManager.DataService.GetTabelleOrdersPerKunde(ThisCustomer.CustomerId);
			}
			bs.Sort = "Datum DESC";
			this.dgvOrders.DataSource = bs;
		}

		#endregion

	}
}
