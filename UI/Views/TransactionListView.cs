using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class TransactionListView : MetroForm
	{

		#region members

		readonly string customerID;
		readonly string productID;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TransactionListView Klasse.
		/// </summary>
		/// <param name="customerId"></param>
		/// <param name="productId"></param>
		public TransactionListView(string customerId, string productId)
		{
			InitializeComponent();
			this.customerID = customerId;
			this.productID = productId;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvTransactions.AutoGenerateColumns = false;
			this.Text = string.Format("Vorgänge für Kunden-Nr. {0}", this.customerID);
			this.Text = "Vorgangsliste für Artikel-Nr. " + this.productID;
			this.dgvTransactions.DataSource = Data.DataManager.AllDataService.GetTransactionsByProduct(this.customerID, this.productID);
		}

		#endregion

	}
}
