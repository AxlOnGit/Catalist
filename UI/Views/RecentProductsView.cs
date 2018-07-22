using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class RecentProductsView : MetroForm
	{
		#region MEMBERS

		Product mySelectedProduct;
		readonly CpmMainView myParent;
		readonly List<Product> myProductList;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="RecentCustomerListView"/> Klasse.
		/// </summary>
		public RecentProductsView(CpmMainView parent, List<Product> artikelListe)
		{
			InitializeComponent();
			this.myParent = parent;
			this.myProductList = artikelListe;
			this.InitializeData();
		}

		void InitializeData()
		{
			this.dgvProducts.AutoGenerateColumns = false;
			// Die Kundenliste rückwärts aufbauen, um den zuletzt hinzugefügten Kunden oben anzuzeigen.
			var count = this.myProductList.Count;
			var list = new List<Product>();
			for (int i = count - 1; i >= 0; i--)
			{
				list.Add(this.myProductList[i]);
			}
			this.dgvProducts.DataSource = list;
			this.mbtnOk.Enabled = count > 0;
		}

		#endregion ### .ctor ###

		#region event handler

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.ShowProduct();
		}

		void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvProducts.DataSource == null) return;
			this.mySelectedProduct = this.dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
		}

		void dgvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowProduct();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler

		#region private procedures

		void ShowProduct()
		{
			if (this.mySelectedProduct == null) return;
			ModelManager.ProductService.CurrentProduct = this.mySelectedProduct;
			var adv = new ArtikelDetailView(this.mySelectedProduct, Model.ModelManager.CustomerService.GetCPM());
			adv.Show();
			if (!this.mchkDontClose.Checked) this.Close();
		}

		#endregion private procedures

		void xcmdClearList_Click(object sender, EventArgs e)
		{
			this.dgvProducts.DataSource = null;
			this.mbtnOk.Enabled = false;
			this.myParent.ClearRecentCustomersList();
		}

		void metroContextMenu1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
		}
	}
}