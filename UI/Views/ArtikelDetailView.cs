using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Model;
using Products.Common.Collections;
using System.Linq;

namespace Products.Common.Views
{
	public partial class ArtikelDetailView : MetroForm
	{

		#region members

		readonly Product myProduct;
		readonly Kunde myKunde;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ArtikelDetailView Klasse.
		/// </summary>
		public ArtikelDetailView(Product product, Kunde kunde)
		{
			InitializeComponent();
			this.myProduct = product;
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvBestellungen.AutoGenerateColumns = false;
			this.dgvProductSales.AutoGenerateColumns = false;
			this.Text = string.Format("Artikel {0} bei {1}", this.myProduct.Artikelnummer, this.myKunde.Matchcode);
			this.mlblArtikelgruppe.Text = this.myProduct.Artikelgruppe;
			this.mlblArtikelnummer.Text = this.myProduct.Artikelnummer;
			this.mlblBezeichnung1.Text = this.myProduct.Bezeichnung1;
			this.mlblBezeichnung2.Text = this.myProduct.Bezeichnung2;
			var lieferant = ModelManager.SupplierService.GetSupplier(this.myProduct.Lieferant);
			this.mlblLieferant.Text = lieferant.Matchcode;
			this.mlblEinkaufspreis.Text = string.Format("{0:C2}", this.myProduct.Einkaufspreis);
			this.mlblVerkaufspreis.Text = string.Format("{0:C2}", this.myProduct.Standardpreis);
			this.mlblKundenpreis.Text = string.Format("{0:C2}", this.myProduct.Kundenpreis);
			this.mlblLagerbestand.Text = string.Format("{0} {1}", this.myProduct.Bestand, this.myProduct.Mengeneinheit);

			this.dgvBestellungen.DataSource = ModelManager.SupplierService.GetOffeneBestellungen(this.myProduct.Artikelnummer);
			this.dgvProductSales.DataSource = ModelManager.ProductService.GetProductSales(this.myProduct.Artikelnummer);
			this.mlblAverageSales.Text = this.GetAverageProductSales(ModelManager.ProductService.GetProductSales(this.myProduct.Artikelnummer)).ToString("F");
			var llRow = ModelManager.SupplierService.GetLetzteLieferungDetail(this.myProduct.Artikelnummer);
			var letzteLieferung = string.Empty;
			if (llRow.HasValue)
			{
				letzteLieferung = string.Format("Letzte Lieferung am {0}, ({1} {2})", llRow.Value.Datum.ToShortDateString(), llRow.Value.Menge, llRow.Value.Mengeneinheit);
			}
			else letzteLieferung = "Für diesen Artikel gibt es bisher noch keine Lieferungen";
			this.mlblLetzteLieferung.Text = letzteLieferung;
			//var list = ModelManager.SupplierService.GetBestellDetails(this.myProduct.Artikelnummer);
			//this.dgvBestellungen.DataSource = list;
		}

		double GetAverageProductSales(SBList<Model.Services.ProductService.ProductSale> salesList)
		{
			if (salesList.Count == 0) return 0;
			var count = salesList.Count();
			var sum = salesList.Sum(s => s.Menge);
			return sum / count;
		}

		void dgvBestellungen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show(ServiceManager.UiService.GetControlMetrics(this.dgvBestellungen));
		}

		#endregion

	}
}
