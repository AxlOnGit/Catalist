using System;
using System.ComponentModel;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class SonderpreisView : MetroForm
	{

		#region members

		readonly Product myProduct;
		decimal myDefaultPrice;
		decimal myCustomerPrice;
		decimal myDiscountPercent;
		string myArtikelgruppe;
	
		#endregion

		#region public properties

		/// <summary>
		/// Returns the discount that was entered by the user.
		/// </summary>
		internal decimal DiscountPercent
		{
			get
			{
				decimal retVal = 0m;
				decimal.TryParse(this.txtDiscountPercent.Text, out retVal);

				return retVal;
			}
		}
	
		#endregion

		#region ### .ctor ###

		public SonderpreisView(Product product)
		{
			InitializeComponent();

			this.myProduct = product;
			this.myDefaultPrice = product.Standardpreis;
			this.myDiscountPercent = product.RabattProzent;
			this.myArtikelgruppe = product.Artikelgruppe;

			this.myCustomerPrice = myDefaultPrice - (myDiscountPercent * myDefaultPrice / 100);
			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		void SonderpreisView_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			this.mbtnOk.Focus();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("Sonderpreis für Artikelgruppe <{0}>", this.myArtikelgruppe);
			this.lblArtikelgruppe.Text = string.Format("{0, -15}{1}", "Artikelgruppe:", this.myArtikelgruppe);

			this.txtNewPrice.DataBindings.Add("Text", this.myProduct, "RabattPreis");
			this.txtDiscountPercent.DataBindings.Add("Text", this.myProduct, "RabattProzent");

			this.txtMenge1.DataBindings.Add("Text", this.myProduct, "SonderpreisMenge1");
			this.txtRabattPreis1.DataBindings.Add("Text", this.myProduct, "Sonderpreis1");
			this.txtRabatt1.DataBindings.Add("Text", this.myProduct, "SonderpreisRabatt1");

			this.txtMenge2.DataBindings.Add("Text", this.myProduct, "SonderpreisMenge2");
			this.txtRabattPreis2.DataBindings.Add("Text", this.myProduct, "Sonderpreis2");
			this.txtRabatt2.DataBindings.Add("Text", this.myProduct, "SonderpreisRabatt2");

			this.txtMenge3.DataBindings.Add("Text", this.myProduct, "SonderpreisMenge3");
			this.txtRabattPreis3.DataBindings.Add("Text", this.myProduct, "Sonderpreis3");
			this.txtRabatt3.DataBindings.Add("Text", this.myProduct, "SonderpreisRabatt3");

			this.txtMenge4.DataBindings.Add("Text", this.myProduct, "SonderpreisMenge4");
			this.txtRabattPreis4.DataBindings.Add("Text", this.myProduct, "Sonderpreis4");
			this.txtRabatt4.DataBindings.Add("Text", this.myProduct, "SonderpreisRabatt4");
		}

		#endregion

	}
}
