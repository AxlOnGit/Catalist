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
		readonly CpmMainView myParent;
		readonly List<Kunde> myKundenliste;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="RecentCustomerListView"/> Klasse.
		/// </summary>
		public RecentCustomerListView(CpmMainView parent, List<Kunde> kundenListe)
		{
			InitializeComponent();
			this.myParent = parent;
			this.myKundenliste = kundenListe;
			this.InitializeData();
		}

		void InitializeData()
		{
			this.dgvCustomers.AutoGenerateColumns = false;
			// Die Kundenliste rückwärts aufbauen, um den zuletzt hinzugefügten Kunden oben anzuzeigen.
			var count = this.myKundenliste.Count;
			var list = new List<Kunde>();
			for (int i = count - 1; i >= 0; i--)
			{
				list.Add(this.myKundenliste[i]);
			}
			this.dgvCustomers.DataSource = list;
			this.mbtnOk.Enabled = count > 0;
		}

		#endregion ### .ctor ###

		#region event handler

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.ShowKunde();
		}

		void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCustomers.DataSource == null) return;
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

		#endregion event handler

		#region private procedures

		void ShowKunde()
		{
			if (this.mySelectedKunde == null) return;
			Model.ModelManager.CustomerService.CurrentCustomer = this.mySelectedKunde;
			var kmv = new KundeMainView(this.mySelectedKunde);
			kmv.Show();
			if (!this.mchkDontClose.Checked) this.Close();
		}

		#endregion private procedures

		void xcmdClearList_Click(object sender, EventArgs e)
		{
			this.dgvCustomers.DataSource = null;
			this.mbtnOk.Enabled = false;
			this.myParent.ClearRecentCustomersList();
		}

		void metroContextMenu1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.xcmdClearList.Enabled = this.dgvCustomers.RowCount > 0;
		}
	}
}