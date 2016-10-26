using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CalcItemView : MetroForm
	{

		#region members

		Product myProduct;
		Kunde myKunde;
		decimal myDefaultPrice;
		decimal myOpenAmount;

		#endregion

		#region ### .ctor ###

		public CalcItemView(
			Product product, 
			Kunde kunde,
			decimal ek, 
			decimal customerPrice,
			decimal normalPrice,
			decimal salesPerPeriod, 
			decimal grossSales,
			decimal openAmount)
		{
			InitializeComponent();

			this.myProduct = product;
			this.myKunde = kunde;
			this.myDefaultPrice = normalPrice;
			this.myOpenAmount = openAmount;

			txtSalesPerPeriod.Text = string.Format("{0:N2}", salesPerPeriod);
			txtGrossSales.Text = string.Format("{0:N2}", grossSales);
			txtFOC.Text = string.Format("{0:N2}", Model.ModelManager.ProductService.GetFocAmount(kunde));

			this.lblOutstandingAmount.Text = string.Format("Offene Rechnungen (älter 31 Tage): {0:N2} EUR", openAmount);

			this.txtUnit.Text = product.Mengeneinheit;
			this.lblUnit2.Text = product.Mengeneinheit;
			this.lblNormalPricePRM.Text = string.Format("{0:N2} EUR", normalPrice);

			this.lblArtikelname.Text = product.Bezeichnung2;
			this.lblArtikelgruppe.Text = string.Format("Artikelgruppe: {0}", product.Artikelgruppe);
			this.txtEK.Text = string.Format("{0:N2}", ek);
			this.txtVK.Text = string.Format("{0:N2}", customerPrice);

			this.lblUnadjustedMargin1.Text = string.Format("Rohmarge ({0}):", product.Mengeneinheit);

			if (kunde.DunningFlag)
			{
				this.chkSperrvermerk1.Checked = true;
				this.chkSperrvermerk1.ForeColor = Color.Red;
			}

			if (kunde.DeliveryStopFlag)
			{
				this.chkSperrvermerk2.Checked = true;
				this.chkSperrvermerk2.ForeColor = Color.Red;
			}

			if (kunde.AdvancePaymentFlag)
			{
				this.chkSperrvermerk3.Checked = true;
				this.chkSperrvermerk3.ForeColor = Color.Red;
			}

			Application.Idle += this.IamIdle;
		}

		#endregion

		#region private procedures

		[DebuggerStepThrough]
		void IamIdle(object sender, EventArgs e) 
		{
			decimal ek = 0.0m;
			decimal vk = 0.0m;

			if (this.myOpenAmount > 0)
			{
				this.lblOutstandingAmount.ForeColor = Color.Red;
			}
			else
			{
				this.lblOutstandingAmount.ForeColor = Color.Black;
			}

			if (decimal.TryParse(this.txtVK.Text, out vk) && vk >= 0)
			{
				this.lblVk1.ForeColor = Color.Black;
				this.lblVk2.ForeColor = Color.Black;
				this.lblDiscountPercent.ForeColor = Color.Black;
			}
			else
			{
				this.lblVk1.ForeColor = Color.Red;
				this.lblVk2.ForeColor = Color.Red;
				this.lblDiscountPercent.ForeColor = Color.Red;
			}

			if (decimal.TryParse(this.txtEK.Text, out ek) && ek > 0)
			{
				this.lblEK1.ForeColor = Color.Black;
				this.lblEk2.ForeColor = Color.Black;
			}
			else
			{
				this.lblEK1.ForeColor = Color.Red;
				this.lblEk2.ForeColor = Color.Red;
			}
		}

		void CalcPrice()
		{
			decimal qty = 0.00m;
			decimal ek = 0.00m;
			decimal vk = 0.00m;

			if (decimal.TryParse(this.txtVK.Text, out vk)
				&& decimal.TryParse(this.txtEK.Text, out ek)
				&& decimal.TryParse(this.txtQuantity.Text, out qty))
			{
				// Rohmarge
				decimal margin = vk - ek;
				this.lblUnadjustedMargin2.Text = string.Format("{0:N2} EUR", margin);

				// Rohmarge gesamt
				decimal grossMargin = margin * qty;
				this.lblGrossMargin.Text = string.Format("{0:N2} EUR", grossMargin);

				// Normalpreis/lfdm
				this.lblNormalPricePRM.Text = string.Format("{0:N2} EUR", this.myDefaultPrice);

				// Rabattsatz
				var discountPercent = Math.Round(100 - (vk * 100 / this.myDefaultPrice), 2);
				this.lblDiscountPercent.Text = string.Format("= ({0:N2}%)", discountPercent);

				// Rechnungsbetrag in Sage
				decimal priceNoDiscount = this.myDefaultPrice;
				decimal discountAmount = priceNoDiscount / 100 * discountPercent;
				decimal invcAmtSage = priceNoDiscount - discountAmount;
				this.lblInvoiceAmountSage.Text = string.Format("{0:N2} EUR", invcAmtSage * qty);

				// VK
				this.lblCustomerPricePRM.Text = string.Format("{0:N4} EUR", this.txtVK.Text);

				// Marge in Prozent
				decimal marginPercent = ek > 0 ? (vk * 100 / ek) - 100 : 0;
				this.lblMarginPercent.Text = string.Format("{0:N2} %", marginPercent);
			}

		}

		#endregion

		#region event handlers

		void txtVK_TextChanged(object sender, EventArgs e)
		{
			CalcPrice();
		}

		void txtEK_TextChanged(object sender, EventArgs e)
		{
			CalcPrice();
		}

		void txtQuantity_TextChanged(object sender, EventArgs e)
		{
			CalcPrice();
		}

		void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
