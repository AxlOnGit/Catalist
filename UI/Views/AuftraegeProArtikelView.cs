using MetroFramework.Forms;
using Products.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class AuftraegeProArtikelView : MetroForm
    {
        #region PROPERTIES

        string ArtikelNummer { get; set; }

        dsSage.AuftragProArtikelRow SelectedRow { get; set; }

        #endregion PROPERTIES

        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der AuftraegeProArtikelView Klasse.
        /// </summary>
        public AuftraegeProArtikelView(string artikelNummer)
        {
            InitializeComponent();
            this.ArtikelNummer = artikelNummer;
            this.InitializeData();
        }

        #endregion ### .ctor ###

        #region METHODS

        void InitializeData()
        {
            try
            {
                if (string.IsNullOrEmpty(this.ArtikelNummer)) return;
                this.DgvAuftraege.AutoGenerateColumns = false;
                this.DgvAuftraege.DataSource = DataManager.AllDataService.GetAuftraegeProArtikel(this.ArtikelNummer);
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        #endregion METHODS

        #region EVENT HANDLER

        void DgvAuftraege_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var drv = this.DgvAuftraege.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv != null)
            {
                this.SelectedRow = drv.Row as dsSage.AuftragProArtikelRow;
            }
        }

        void McmdCopyAuftrag_Click(object sender, EventArgs e)
        {
            if (this.SelectedRow != null)
            {
                Clipboard.SetDataObject(SelectedRow.Auftrag, true);
            }
        }

        void MbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER
    }
}
