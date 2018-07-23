using MetroFramework.Forms;
using Products.Common.Collections;
using Products.Model;
using Products.Model.Entities;
using System;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class ArtikelstammView : MetroForm
    {
        #region PROPERTIES

        Kunde Kunde { get; set; }

        Product SelectedProduct { get; set; }

        SBList<Product> DataSource { get; set; }

        #endregion PROPERTIES

        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der ArtikelstammView Klasse.
        /// </summary>
        public ArtikelstammView(Kunde kunde = null)
        {
            InitializeComponent();
            if (kunde == null)
            {
                Kunde = ModelManager.CustomerService.GetKunde("1000000000", false);
            }
            else Kunde = kunde;
            this.DataSource = ModelManager.ProductService.GetProductList(Kunde);
            this.MTxtFilter.KeyUp += this.MTxtFilter_KeyUp;
            this.DgvArtikel.AutoGenerateColumns = false;

            this.InitializeData();
            this.Location.Offset(1, 1);
            this.Location.Offset(-1, -1);
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        void MTxtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(this.MTxtFilter.Text))
            {
                this.DataSource.Filter = "";
                return;
            }

            var outputInfo = string.Empty;
            var keyWords = this.MTxtFilter.Text.Split();
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
                this.DataSource.Filter = outputInfo;

                // this.mtxtFilter.ShowButton = !string.IsNullOrEmpty(outputInfo);
            }
        }

        void MtxtFilter_ClearClicked()
        {
            this.DataSource.Filter = "";
            this.MTxtFilter.ShowButton = false;
        }

        void BtnChangeKunde_Click(object sender, EventArgs e)
        {
            var csv = new CustomerSearchView("Für welchen Kunden soll der Artikelstamm angezeigt werden?", true);
            if (csv.ShowDialog() == DialogResult.OK)
            {
                this.Kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, false);
                if (Kunde != null) this.InitializeData();
            }
        }

        void McmdAuftraege_Click(object sender, EventArgs e)
        {
            if (this.SelectedProduct != null)
            {
                var apav = new AuftraegeProArtikelView(this.SelectedProduct.Artikelnummer);
                apav.ShowDialog();
            }
        }

        void DgvArtikel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedProduct = this.DgvArtikel.Rows[e.RowIndex].DataBoundItem as Product;
        }

        void DgvArtikel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DgvArtikel.ClearSelection();
        }

        void XcmdShowInventoryView_Click(object sender, EventArgs e)
        {
            if (this.SelectedProduct != null)
            {
                var piv = new LagerbestandView(this.Kunde, this.SelectedProduct);
                piv.ShowDialog();
            }
        }

        void MbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER

        #region METHODS

        void InitializeData()
        {
            this.Text = string.Format("Artikelstamm für {0}{1}", Kunde.CompanyName1.Replace("&", "&&"), Environment.NewLine);
            DgvArtikel.DataSource = this.DataSource;
        }

        #endregion METHODS
    }
}
