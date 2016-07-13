using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class RecentCustomerListView : MetroForm
	{

		#region members

		Kunde mySelectedKunde;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="RecentCustomerListView"/> Klasse.
		/// </summary>
		public RecentCustomerListView(List<Kunde> kundenListe)
		{
			InitializeComponent();

			this.dgvCustomers.AutoGenerateColumns = false;
			this.dgvCustomers.DataSource = kundenListe;
		}

		#endregion

		#region event handler

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.ShowKunde();
		}

		void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedKunde = this.dgvCustomers.Rows[e.RowIndex].DataBoundItem as Kunde;
		}

		void dgvCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowKunde();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void ShowKunde()
		{
			if (this.mySelectedKunde == null) return;
			var kmv = new KundeMainView(this.mySelectedKunde);
			kmv.Show();
			if (!this.mchkDontClose.Checked) this.Close();
		}

		#endregion

	}
}
