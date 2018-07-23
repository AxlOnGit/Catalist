using MetroFramework.Forms;
using Products.Model.Entities;
using System;
using System.Text;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class AngeboteListView : MetroForm
    {
        #region PROPERTIES

        Kunde Kunde { get; set; }

        Angebot SelectedAngebot { get; set; }

        #endregion PROPERTIES

        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der <seealso cref="AngeboteListView" /> Formularklasse.
        /// </summary>
        public AngeboteListView(Kunde kunde = null)
        {
            this.InitializeComponent();
            if (kunde != null) this.Kunde = kunde;
            this.InitializeData();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        void DgvAngebote_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedAngebot = dgvAngebote.Rows[e.RowIndex].DataBoundItem as Angebot;
            if (this.SelectedAngebot != null)
            {
                this.dgvDetails.DataSource = Model.ModelManager.SalesService.GetAngebotsDetails(this.SelectedAngebot);

                //var sb = new StringBuilder();
                //var criteria = string.Format("O{0}", this.mySelectedAngebot.Nummer);
                //foreach (var mail in Model.ModelManager.DavidService.GetMailItems(criteria))
                //{
                //	sb.AppendLine(mail.Betreff);
                //}
                //MessageBox.Show(sb.ToString());
            }
        }

        void XcmdSearchEmails_Click(object sender, EventArgs e)
        {
            if (this.SelectedAngebot == null) return;
            var elv = new EmailListView(this.SelectedAngebot);
            elv.ShowDialog();
        }

        void XcmdOpenInSage_Click(object sender, EventArgs e)
        {
            var shorty = Model.ModelManager.UserService.CurrentUser.SageLoginName;
            var angebot = this.SelectedAngebot.Nummer;
            var kundePK = this.SelectedAngebot.Kunde.KundenNrCpm;
            SageBridge.ServiceManager.SageService.StartSageApp(SageBridge.Services.SageService.SageAppType.Angebot, shorty, angebot, kundePK);
        }

        void MbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER

        #region METHODS

        void InitializeData()
        {
            this.dgvAngebote.AutoGenerateColumns = false;
            this.dgvDetails.AutoGenerateColumns = false;
            if (this.Kunde != null)
            {
                this.Text = string.Format("Angebote in Sage für {0}", this.Kunde.Matchcode);
                this.dgvAngebote.DataSource = Model.ModelManager.SalesService.GetAngeboteSageList(this.Kunde.CustomerId).Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
            }
            else
            {
                this.dgvAngebote.DataSource = Model.ModelManager.SalesService.GetAngeboteSageList().Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
            }
            this.dgvAngebote.RowEnter += DgvAngebote_RowEnter;
        }

        #endregion METHODS
    }
}
