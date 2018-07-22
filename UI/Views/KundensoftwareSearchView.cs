using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KundensoftwareSearchView : MetroForm
	{
		#region MEMBERS

		readonly Kunde myKunde;
		readonly SortableBindingList<Kundensoftware> myDatasource;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		public Kundensoftware SelectedKundensoftware { get; private set; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public KundensoftwareSearchView(Kunde kunde)
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			this.myKunde = kunde;
			this.myDatasource = Model.ModelManager.SoftwareService.GetCustomersSoftware(this.myKunde);
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void dgvKundensoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.SelectedKundensoftware = this.dgvKundensoftware.Rows[e.RowIndex].DataBoundItem as Kundensoftware;
		}

		void dgvKundensoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.SelectedKundensoftware == null)
			{
				this.DialogResult = DialogResult.Cancel;
			}
			else this.DialogResult = DialogResult.OK;
			this.Close();
		}

		void mbtnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.dgvKundensoftware.AutoGenerateColumns = false;
			this.dgvKundensoftware.DataSource = this.myDatasource;
		}

		#endregion PRIVATE PROCEDURES
	}
}