using System;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Model;

namespace Products.Common.Views
{
	public partial class LagerbestandView : MetroForm
	{

		#region members

		readonly Kunde myKunde;
		readonly string myArtikelgruppe;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the ProductInventoryView class.
		/// </summary>
		public LagerbestandView(Kunde kunde, Product product)
		{
			InitializeComponent();
			this.myKunde = kunde;
			this.myArtikelgruppe = product.Artikelgruppe;

			this.dgvProducts.AutoGenerateColumns = false;
			this.dgvProducts.DataSource = ModelManager.ProductService.GetProductsByArtikelgruppe(kunde, product);
			this.lblIntro.Text = string.Format("Artikelgruppe: {0}", product.Artikelgruppe);
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
