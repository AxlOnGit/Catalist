using System;
using System.Data;
using System.Windows.Forms;
using Products.Data;
using Products.Model;
using Products.Model.Entities;
using MetroFramework.Forms;
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class ProductSearchView : MetroForm
	{

		#region events

		public event EventHandler ProductChosen;

		#endregion

		#region members

		Product mySelectedProduct;
		readonly Kunde myKunde;
		readonly SBList<Product> myDatasource;

		#endregion

		#region public properties

		/// <summary>
		/// Returns the selected product.
		/// </summary>
		internal Product SelectedProduct
		{
			get
			{
				return mySelectedProduct;
			}
		}

		#endregion

		#region private properties
		#endregion

		#region ### .ctor ###

		public ProductSearchView(Kunde kunde)
		{
			InitializeComponent();
			myKunde = kunde;
			this.myDatasource = ModelManager.ProductService.GetProductList(kunde).Sort("Bezeichnung1", System.ComponentModel.ListSortDirection.Ascending);
			this.InitializeData();
		}

		public ProductSearchView(SBList<Product> dataSource)
		{
			InitializeComponent();
			this.myDatasource = dataSource;
			this.InitializeData();
		}

		void InitializeData()
		{
			this.dgvProducts.AutoGenerateColumns = false;
			this.dgvProducts.DataSource = this.myDatasource;
		}

		#endregion

		#region event handlers

		void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedProduct = this.dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
		}

		void txtProductsFilter_KeyUp(object sender, KeyEventArgs e)
		{
			string outputInfo = string.Empty;
			var keyWords = txtProductsFilter.Text.Split();

			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = string.Format(@"(Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1)", word.ToLower());
				}
				else
				{
					outputInfo += string.Format(@" AND ((Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1))", word.ToLower());
				}
				this.myDatasource.Filter = outputInfo;
			}
		}

		void mToggleCatalogOnly_CheckedChanged(object sender, EventArgs e)
		{
			var filter = this.myDatasource.Filter;

			if (this.mToggleCatalogOnly.CheckState == CheckState.Checked)
			{
				if (string.IsNullOrEmpty(filter))
				{
					filter = "KatalogFlag == true";
				}
				else
				{
					filter += " AND (KatalogFlag == true)";
				}
			}
			else
			{
				this.txtProductsFilter.Text = string.Empty;
				filter = ""; 
			}
			this.myDatasource.Filter = filter;
		}

		void lnkOk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		void cmnuOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		void dgvProducts_DoubleClick(object sender, EventArgs e)
		{
			if (mySelectedProduct != null && this.ProductChosen != null)
			{
				this.ProductChosen(this, new EventArgs());
				this.DialogResult = DialogResult.OK;
			}
			this.Close();
		}

		void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.dgvProducts.ClearSelection();
		}

		void xcmdShowLager_Click(object sender, EventArgs e)
		{
			if (this.mySelectedProduct != null)
			{
				var piv = new LagerbestandView(this.myKunde, this.mySelectedProduct);
				piv.ShowDialog();
			}
		}

		void ProductSearchView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.mchkDoNotClose.Checked && (e.CloseReason == CloseReason.None || e.CloseReason == CloseReason.UserClosing))
			{
				e.Cancel = true;
			}
		}

		void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{
			if (this.SelectedProduct != null && this.ProductChosen != null)
			{
				this.ProductChosen(this, new EventArgs());
				this.DialogResult = DialogResult.OK;
			}
			this.Close();
		}

		#endregion

	}
}
