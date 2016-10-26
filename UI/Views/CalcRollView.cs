using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CalcRollView : MetroForm
	{
		#region members

		Product myProduct;
		Kunde myCustomer;
		decimal normalPrice;
		decimal openAmt;

		#endregion members

		#region ### .ctor ###

		public CalcRollView(
			Product product,
			Kunde customer,
			decimal ek,
			decimal customerPrice,
			decimal normalPrice,
			decimal salesPerPeriod,
			decimal grossSales,
			decimal openAmount)
		{
			InitializeComponent();

			this.myProduct = product;
			this.myCustomer = customer;
			this.normalPrice = normalPrice;
			this.openAmt = openAmount;

			mtxtSalesPerPeriod.Text = string.Format("{0:N2}", salesPerPeriod);
			mtxtGrossSales.Text = string.Format("{0:N2}", grossSales);
			mtxtFreeHomeDelivery.Text = string.Format("{0:N2}", customer.FocAmount);

			this.mlblOutstandingAmount.Text = string.Format("Offene Rechnungen (älter 31 Tage): {0:N2} EUR", openAmount);
			this.mlblNormalPricePRM.Text = string.Format("{0:N2} EUR", normalPrice);

			this.mlblArtikelname.Text = product.Bezeichnung2;
			this.mlblArtikelgruppe.Text = string.Format("Artikelgruppe: {0}", product.Artikelgruppe);
			this.mtxtEK.Text = string.Format("{0:N2}", ek);
			this.mtxtVK.Text = string.Format("{0:N2}", customerPrice);

			this.mlblEk2.Text = string.Format("EUR pro {0}", product.Mengeneinheit);
			this.mlblVk2.Text = string.Format("EUR pro {0}", product.Mengeneinheit);
			this.mlblUnadjustedMargin1.Text = string.Format("Rohmarge ({0}):", product.Mengeneinheit);

			if (customer.DunningFlag)
			{
				this.mchkSperrvermerk1.Checked = true;
				this.mchkSperrvermerk1.ForeColor = Color.Red;
			}

			if (customer.DeliveryStopFlag)
			{
				this.mchkSperrvermerk2.Checked = true;
				this.mchkSperrvermerk2.ForeColor = Color.Red;
			}

			if (customer.AdvancePaymentFlag)
			{
				this.mchkSperrvermerk3.Checked = true;
				this.mchkSperrvermerk3.ForeColor = Color.Red;
			}

			Application.Idle += this.IamIdle;
		}

		#endregion ### .ctor ###

		#region private procedures

		[DebuggerStepThrough]
		void IamIdle(object sender, EventArgs e)
		{
			decimal ek = 0.0m;
			decimal vk = 0.0m;
			decimal width = 0.0m;
			decimal length = 0.0m;

			if (this.openAmt > 0)
			{
				this.mlblOutstandingAmount.ForeColor = Color.Red;
			}
			else
			{
				this.mlblOutstandingAmount.ForeColor = Color.Black;
			}

			if (decimal.TryParse(this.mtxtRollLength.Text, out length) && length >= 0)
			{
				this.mlblLength1.ForeColor = Color.Black;
				this.mlblLength2.ForeColor = Color.Black;
			}
			else
			{
				this.mlblLength1.ForeColor = Color.Red;
				this.mlblLength2.ForeColor = Color.Red;
			}

			if (decimal.TryParse(this.mtxtRollWidth.Text, out width) && width >= 0)
			{
				this.mlblWidth1.ForeColor = Color.Black;
				this.mlblWidth2.ForeColor = Color.Black;
			}
			else
			{
				this.mlblWidth1.ForeColor = Color.Red;
				this.mlblWidth2.ForeColor = Color.Red;
			}

			if (decimal.TryParse(this.mtxtVK.Text, out vk) && vk >= 0)
			{
				this.mlblVk1.ForeColor = Color.Black;
				this.mlblVk2.ForeColor = Color.Black;
				this.mlblDiscountPercent.ForeColor = Color.Black;
			}
			else
			{
				this.mlblVk1.ForeColor = Color.Red;
				this.mlblVk2.ForeColor = Color.Red;
				this.mlblDiscountPercent.ForeColor = Color.Red;
			}

			if (decimal.TryParse(this.mtxtEK.Text, out ek) && ek > 0)
			{
				this.mlblEK1.ForeColor = Color.Black;
				this.mlblEk2.ForeColor = Color.Black;
			}
			else
			{
				this.mlblEK1.ForeColor = Color.Red;
				this.mlblEk2.ForeColor = Color.Red;
			}
		}

		void CalculateRollsSquareMeter()
		{
			double width = 0.00d;   // Rollenbreite
			double length = 0.00d;  // Rollenlänge
			decimal ek = 0.00m;
			decimal vk = 0.00m;

			if (decimal.TryParse(this.mtxtVK.Text, out vk)
					&& double.TryParse(this.mtxtRollWidth.Text, out width)
					&& double.TryParse(this.mtxtRollLength.Text, out length)
					&& decimal.TryParse(this.mtxtEK.Text, out ek))
			{
				// Rohmarge
				double margin = (double)vk - (double)ek;
				this.lblUnadjustedMargin2.Text = string.Format("{0:N2} EUR", margin);

				// Rohmarge gesamt
				double grossMargin = margin * width / 100 * length;
				this.mlblGrossMargin.Text = string.Format("{0:N2} EUR", grossMargin);

				// Normalpreis/lfdm
				var normalPricePrm = Math.Round((decimal)width / 100 * this.normalPrice, 2);
				this.mlblNormalPricePRM.Text = string.Format("{0:N2} EUR", normalPricePrm);

				// Rabattsatz
				//double discountPercent = 100 - Math.Round(((double)vk * 100 / (double)this.normalPrice), 2);
				var discountPercent = Math.Round(100 - ((double)vk * 100 / (double)this.normalPrice), 2);
				this.mlblDiscountPercent.Text = string.Format("= ({0:N2}%)", discountPercent);

				// Rechnungsbetrag in Sage
				decimal priceNoDiscount = normalPricePrm * (decimal)length;
				decimal discountAmount = priceNoDiscount / 100 * (decimal)discountPercent;
				decimal invcAmtSage = priceNoDiscount - discountAmount;
				this.mlblInvoiceAmountSage.Text = string.Format("{0:N2} EUR", invcAmtSage);

				// VK lfd. Meter
				decimal vkrm = length >= 1 ? invcAmtSage / (decimal)length : invcAmtSage;
				this.mlblCustomerPricePRM.Text = string.Format("{0:N4} EUR", vkrm);

				// Marge in Prozent
				decimal marginPercent = ek > 0 ? (vk * 100 / ek) - 100 : 0;
				this.mlblMarginPercent.Text = string.Format("{0:N2} %", marginPercent);
			}
			//else
			//{
			//  MessageBox.Show("Mindestens eine Eingabe enthält einen ungültigen Zahlenwert.", "Kalkulation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//}
		}

		void CalculateRollsRunningMeter()
		{
			double width = 0.00d;   // Rollenbreite
			double length = 0.00d;  // Rollenlänge
			decimal ek = 0.00m;
			decimal vk = 0.00m;

			if (decimal.TryParse(this.mtxtVK.Text, out vk)
					&& double.TryParse(this.mtxtRollWidth.Text, out width)
					&& double.TryParse(this.mtxtRollLength.Text, out length)
					&& decimal.TryParse(this.mtxtEK.Text, out ek))
			{
				// Rohmarge
				double margin = (double)vk - (double)ek;
				this.lblUnadjustedMargin2.Text = string.Format("{0:N2} EUR", margin);

				// Rohmarge gesamt
				double grossMargin = margin * width / 100 * length;
				this.mlblGrossMargin.Text = string.Format("{0:N2} EUR", grossMargin);

				// Normalpreis/lfdm
				//decimal normalPricePrm = Math.Round((decimal)width / 100 * this.normalPrice, 2);
				this.mlblNormalPricePRM.Text = string.Format("{0:N2} EUR", this.normalPrice);

				// Rabattsatz
				//double discountPercent = 100 - Math.Round(((double)vk * 100 / (double)this.normalPrice), 2);
				var discountPercent = Math.Round(100 - ((double)vk * 100 / (double)this.normalPrice), 2);
				this.mlblDiscountPercent.Text = string.Format("= ({0:N2}%)", discountPercent);

				// Rechnungsbetrag in Sage
				//decimal priceNoDiscount = normalPricePrm * (decimal)length;
				decimal priceNoDiscount = this.normalPrice * (decimal)length;
				decimal discountAmount = priceNoDiscount / 100 * (decimal)discountPercent;
				decimal invcAmtSage = priceNoDiscount - discountAmount;
				this.mlblInvoiceAmountSage.Text = string.Format("{0:N2} EUR", invcAmtSage);

				// VK lfd. Meter
				decimal vkrm = length >= 1 ? invcAmtSage / (decimal)length : invcAmtSage;
				this.mlblCustomerPricePRM.Text = string.Format("{0:N4} EUR", vkrm);

				// Marge in Prozent
				decimal marginPercent = ek > 0 ? (vk * 100 / ek) - 100 : 0;
				this.mlblMarginPercent.Text = string.Format("{0:N2} %", marginPercent);
			}
		}

		#endregion private procedures

		#region event handlers

		void txtRollWidth_TextChanged(object sender, EventArgs e)
		{
			if (this.myProduct.Mengeneinheit == "m²")
			{
				this.CalculateRollsSquareMeter();
			}
			else
			{
				this.CalculateRollsRunningMeter();
			}
		}

		void txtVK_TextChanged(object sender, EventArgs e)
		{
			if (this.myProduct.Mengeneinheit == "m²")
			{
				this.CalculateRollsSquareMeter();
			}
			else
			{
				this.CalculateRollsRunningMeter();
			}
		}

		void txtEK_TextChanged(object sender, EventArgs e)
		{
			if (this.myProduct.Mengeneinheit == "m²")
			{
				this.CalculateRollsSquareMeter();
			}
			else
			{
				this.CalculateRollsRunningMeter();
			}
		}

		void txtRollLength_TextChanged(object sender, EventArgs e)
		{
			if (this.myProduct.Mengeneinheit == "m²")
			{
				this.CalculateRollsSquareMeter();
			}
			else
			{
				this.CalculateRollsRunningMeter();
			}
		}

		void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handlers
	}
}