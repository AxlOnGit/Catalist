using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ProductListView : MetroForm
	{

		#region members

		Data.dsSage.CustomizedPriceRow mySelectedProductRow;
		Kunde myKunde;
		private int selectedIndex = 0;

		#endregion

		#region private properties

		DataView GridDataView 
		{
			get 
			{
				return this.dgvProducts.DataSource as DataView;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance  of the ProductListView class.
		/// </summary>
		public ProductListView()
		{
			InitializeComponent();
			lblCustomer.Visible = true;
			mtxtCustomer.Visible = true;
			lnkCustomerName.Visible = true;
			this.dgvProducts.AutoGenerateColumns = false;
		}

		/// <summary>
		/// Creates a new instance of the ProductListView class and
		/// shows the products with prices for the given customer.
		/// </summary>
		/// <param name="customer"></param>
		public ProductListView(Model.Entities.Kunde customer)
		{
			InitializeComponent();
			this.mtxtCustomer.Clear();
			this.myKunde = customer;
			this.lnkCustomerName.ForeColor = Color.Black;
			if (customer.CustomerId == "1000100000")
			{
				this.lnkCustomerName.Text = "Standard-Preisliste == Cut && Print Media";
			}
			else
			{
				this.lnkCustomerName.Text = string.Format("{0}     [{1} {2}]", customer.CompanyName1, customer.ZipCode, customer.City);
			}

			dgvProducts.AutoGenerateColumns = false;
			DataView dv = customer.Kundenpreisliste.DefaultView;
			this.dgvProducts.DataSource = dv;
			this.txtProductsFilter.Focus();
		}

		#endregion

		#region event handlers

		private void LoadProducts()
		{
			if (this.mtxtCustomer.Text.Length > 0)
			{
				string kundePK = this.mtxtCustomer.Text.Trim();
				if (kundePK.Length == 5)
				{
					kundePK += "00000";
				}
				Kunde kunde = ModelManager.CustomerService.GetKunde(kundePK);
				if (kunde == null)
				{
					this.lnkCustomerName.Text = string.Format("Den Kunden mit der Kunden-Nr. \"{0}\" gibt es nicht", kundePK);
					this.lnkCustomerName.ForeColor = Color.Red;
					return;
				}
				this.myKunde = kunde;
				this.lnkCustomerName.ForeColor = Color.Black;

				if (kunde.CustomerId == "1000100000")
				{
					this.lnkCustomerName.Text = "Standard-Preisliste Cut && Print Media";
				}
				else
				{
					this.lnkCustomerName.Text = string.Format("{0}     [{1} {2}]", kunde.CompanyName1.Replace("&", "&&"), kunde.ZipCode, kunde.City);
				}

				DataView dv = kunde.Kundenpreisliste.DefaultView;
				this.dgvProducts.DataSource = dv;
				this.txtProductsFilter.Focus();
			}
		}

		private void dgvProducts_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && mySelectedProductRow != null)
			{
				e.Handled = true;
				ShowDetailsView();
			}
		}

		private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataRowView drv = dgvProducts.Rows[e.RowIndex].DataBoundItem as DataRowView;
			if (drv != null)
			{
				Data.dsSage.CustomizedPriceRow tableRow = drv.Row as Data.dsSage.CustomizedPriceRow;
				this.mySelectedProductRow = tableRow;
			}
		}

		private void lnkLoadProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoadProducts();
		}

		private void dgvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowDetailsView();
		}

		private void mbtnArtikeldetails_Click(object sender, EventArgs e)
		{
			ShowDetailsView();
		}

		private void cmnuDetails_Click(object sender, EventArgs e)
		{
			this.ShowDetailsView();
		}

		private void txtProductsFilter_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.GridDataView == null) return;
			string outputInfo = string.Empty;
			string[] keyWords = txtProductsFilter.Text.Split();

			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = "(Bezeichnung1 LIKE '%" + word + "%' OR Matchcode LIKE '%" + word + "%' OR Artikel LIKE '%" + word + "%')";
				}
				else
				{
					outputInfo += " AND (Bezeichnung1 LIKE '%" + word + "%' OR Matchcode LIKE '%" + word + "%' OR Artikel LIKE '%" + word + "%')";
				}
				this.GridDataView.RowFilter = outputInfo;
			}
		}

		private void lnkCustomerName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CustomerSearchView csv = new CustomerSearchView("Kunden auswählen", false);
			if (csv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.mtxtCustomer.Text = csv.SelectedCustomer.Kundennummer.Substring(0, 5);
				LoadProducts();
			}
		}

		private void btnSearchCustomer_Click(object sender, EventArgs e)
		{
			CustomerSearchView csv = new CustomerSearchView("Kunden auswählen", false);
			if (csv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.mtxtCustomer.Text = csv.SelectedCustomer.Kundennummer.Substring(0, 5);
				LoadProducts();
			}
		}

		private void txtCustomer_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				LoadProducts();
			}
		}

		private void mbtnKalkulation_Click(object sender, EventArgs e)
		{
			ShowCalcView();
		}

		private void cmnuCalc_Click(object sender, EventArgs e)
		{
			ShowCalcView();
		}

		private void mbtnLagerbestand_Click(object sender, EventArgs e)
		{
			ShowInventoryView();
		}

		private void cmnuInventory_Click(object sender, EventArgs e)
		{
			this.ShowInventoryView();
		}

		private void cmnuSpecialPrice_Click(object sender, EventArgs e)
		{
			this.ShowSonderpreisView();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		private void ShowCalcView()
		{
			if (this.mySelectedProductRow != null)
			{
				string productName = string.Empty;
				string productGroup = string.Empty;
				decimal ek = 0;
				decimal price = 0;
				decimal salesPerPeriod = 0m;
				decimal salesTotal = 0m;
				decimal openAmount = 0m;
				decimal normalPrice = 0m;

				if (!this.mySelectedProductRow.IsEKNull())
				{
					ek = this.mySelectedProductRow.EK;
				}

				if (!this.mySelectedProductRow.IsKundenpreisNull())
				{
					price = this.mySelectedProductRow.Kundenpreis;
				}

				normalPrice = this.mySelectedProductRow.Verkaufspreis1;

				// get customer sales stats and outstanding amounts
				Data.dsSage.CustomerSalesRow statsRow = Data.DataManager.AllDataService.GetVerkaufsstatistik(this.myKunde.CustomerId);
				Data.dsSage.UnpaidItemRow openAmountsRow = Data.DataManager.AllDataService.GetOffenePostenBetrag(this.myKunde.CustomerId);

				if (statsRow != null)
				{
					if (!statsRow.IsUmsatzPeriodeNull())
					{
						salesPerPeriod = statsRow.UmsatzPeriode;
					}
					if (!statsRow.IsUmsatzKumuliertNull())
					{
						salesTotal = statsRow.UmsatzKumuliert;
					}
				}

				if (openAmountsRow != null)
				{
					if (!openAmountsRow.IsOPBetragNull())
					{
						openAmount = openAmountsRow.OPBetrag;
					}
				}

				if (mySelectedProductRow.Mengeneinheit == "m²" || mySelectedProductRow.Mengeneinheit == "lfm" || mySelectedProductRow.Mengeneinheit == "lfdm")
				{
					CalcRollView crv = new CalcRollView(
						this.mySelectedProductRow,
						this.myKunde,
						ek,
						price,
						normalPrice,
						salesPerPeriod,
						salesTotal,
						openAmount);
					crv.ShowDialog(this);
				}
				else
				{
					CalcItemView cv = new CalcItemView(
						this.mySelectedProductRow,
						this.myKunde,
						ek,
						price,
						normalPrice,
						salesPerPeriod,
						salesTotal,
						openAmount);
					cv.ShowDialog(this);
				}
			}
		}

		private void ShowDetailsView()
		{
			if (this.mySelectedProductRow != null)
			{
				Views.ProductDetailView pdv = new ProductDetailView(this.mySelectedProductRow);
				pdv.ShowDialog(this);
			}
		}

		private void ShowInventoryView()
		{
			if (this.mySelectedProductRow != null)
			{
				LagerbestandView piv = new LagerbestandView(this.mySelectedProductRow.Artikelgruppe);
				piv.ShowDialog();
			}
		}

		private void ShowSonderpreisView()
		{
			if (this.mySelectedProductRow != null)
			{
				SonderpreisView spv = new SonderpreisView(this.myKunde.CompanyName1, this.myKunde.CustomerId, this.mySelectedProductRow.Artikelgruppe, this.mySelectedProductRow);
				if (spv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					if (Data.DataManager.AllDataService.CreateOrChangeSpecialCustomerPrice(this.myKunde.CustomerId, this.mySelectedProductRow) == 1)
					{
						this.mySelectedProductRow.Prozent = spv.DiscountPercent;
						this.mySelectedProductRow.Kundenpreis = this.mySelectedProductRow.Verkaufspreis1 * ((100 - mySelectedProductRow.Prozent) / 100);
						this.myKunde.RefreshArtikelpreisliste();
						MessageBox.Show("Der neue Sonderpreis wurde gespeichert.", "Da sacht der Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Der neue Sonderpreis konnte nicht gespeichert werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void ProductListView_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				int preIndex = selectedIndex;
				myKunde.RefreshPriceListTripleA();
				dgvProducts.Rows[preIndex].Selected = true;
				dgvProducts.CurrentCell = dgvProducts.Rows[preIndex].Cells[0];
			}
		}

		#endregion

	}
}
