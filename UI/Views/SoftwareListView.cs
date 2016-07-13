using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class SoftwareListView : MetroForm
	{

		#region members

		private Model.Entities.Kundensoftware currentSoftware;
		private Model.Entities.Kunde myCustomer;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der SoftwareListView Klasse.
		/// </summary>
		public SoftwareListView(Model.Entities.Kunde customer)
		{
			InitializeComponent();
			myCustomer = customer;
			Init();
		}
		
		#endregion

		#region event handler

		private void dgvSoftware_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			String value = e.Value as string;
			if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
			{
				e.Value = e.CellStyle.NullValue;
				e.FormattingApplied = true;
			}
		}

		private void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dgvSoftware.Rows[e.RowIndex];
			if (row != null)
			{
				currentSoftware = row.DataBoundItem as Model.Entities.Kundensoftware;
				mtxtAnmerkungen.Text = currentSoftware.Anmerkungen;
			}
		}

		private void dgvSoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (currentSoftware != null)
			{
				SoftwareView sv = new SoftwareView(currentSoftware, myCustomer);
				sv.Show(this);
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			SoftwareView sv = new SoftwareView(myCustomer.AddSoftware(), myCustomer);
			sv.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		#region private procedures

		private void Init()
		{
			this.Text = string.Format("Software von {0}", myCustomer.CompanyName1);
			dgvSoftware.AutoGenerateColumns = false;
			dgvSoftware.DataSource = myCustomer.Softwareliste;
		}

		#endregion

	}
}
