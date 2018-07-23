using MetroFramework;
using MetroFramework.Forms;
using Products.Common.Collections;
using Products.Model;
using Products.Model.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class ArtikelDetailView : MetroForm
    {
        #region PROPERTIES

        Product Product { get; set; }

        Kunde Kunde { get; set; }

        #endregion PROPERTIES

        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der ArtikelDetailView Klasse.
        /// </summary>
        public ArtikelDetailView(Product product, Kunde kunde)
        {
            InitializeComponent();
            this.Product = product;
            this.Kunde = kunde;

            this.InitializeData();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        private void MbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER

        #region PROCEDURES

        void InitializeData()
        {
            this.dgvBestellungen.AutoGenerateColumns = false;
            this.dgvProductSales.AutoGenerateColumns = false;
            this.Text = $"Artikel {this.Product.Artikelnummer} bei {this.Kunde.Matchcode}";
            this.mlblArtikelgruppe.Text = this.Product.Artikelgruppe;
            this.mlblArtikelnummer.Text = this.Product.Artikelnummer;
            this.mlblBezeichnung1.Text = this.Product.Bezeichnung2;
            this.mlblBezeichnung2.Text = this.Product.Bezeichnung2;
            var lieferant = ModelManager.SupplierService.GetSupplier(this.Product.Lieferant);
            this.mlblLieferant.Text = (lieferant != null) ? lieferant.Matchcode : string.Empty;
            this.mlblEinkaufspreis.Text = $"{this.Product.Einkaufspreis:C2}";
            this.mlblVerkaufspreis.Text = $"{this.Product.Standardpreis:C2}";
            this.mlblKundenpreis.Text = $"{this.Product.Kundenpreis:C2}";
            this.mlblLagerbestand.Text = $"{this.Product.Bestand} {this.Product.Mengeneinheit}";

            this.dgvBestellungen.DataSource = ModelManager.SupplierService.GetOffeneBestellungen(this.Product.Artikelnummer);
            this.dgvProductSales.DataSource = ModelManager.ProductService.GetProductSales(this.Product.Artikelnummer);
            this.mlblAverageSales.Text = this.Product.AverageSalesCountPerSales;
            this.mlblAverageSales12Months.Text = this.Product.AverageSalesCountLast12Months;
            var llRow = ModelManager.SupplierService.GetLetzteLieferungDetail(this.Product.Artikelnummer);
            var letzteLieferung = string.Empty;
            if (llRow.HasValue)
            {
                letzteLieferung = $"Letzte Lieferung am {llRow.Value.Datum.ToShortDateString()}: ({llRow.Value.Menge} {llRow.Value.Mengeneinheit})";
            }
            else letzteLieferung = "Für diesen Artikel gibt es bisher noch keine Lieferungen";
            this.mlblLetzteLieferung.Text = letzteLieferung;
        }

        double GetAverageProductSales(SBList<Model.Services.ProductService.ProductSale> salesList)
        {
            if (salesList.Count == 0) return 0;
            var count = salesList.Count();
            var sum = salesList.Sum(s => s.Menge);
            return sum / count;
        }

        void DgvBestellungen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetroMessageBox.Show(this, ServiceManager.UiService.GetControlMetrics(this.dgvBestellungen));
        }

        #endregion PROCEDURES
    }
}
