using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
    public partial class DialogNewMachine : MetroForm
    {
        #region MEMBERS

        private readonly Kunde myKunde;

        /// <summary>
        /// Gibt die Instanz der neu angelegten Maschine zurück.
        /// </summary>
        public Kundenmaschine CreatedMachine { get; private set; }

        #endregion MEMBERS

        #region PRIVATE PROPERTIES

        public Maschinenmodell Modell { get; private set; }

        public string Seriennummer { get; private set; }

        #endregion PRIVATE PROPERTIES

        #region ### .ctor ###

        public DialogNewMachine(Kunde kunde)
        {
            InitializeComponent();
            this.myKunde = kunde;
            this.InitializeData();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        private void cmbMachineModel_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Modell = this.cmbMachineModel.SelectedItem as Maschinenmodell;
        }

        private void mtxtSerialNumber_Validated(object sender, EventArgs e)
        {
            this.Seriennummer = (!string.IsNullOrEmpty(this.mtxtSerialNumber.Text)) ? this.mtxtSerialNumber.Text : string.Empty;
        }

        private void mbtnOK_Click(object sender, EventArgs e)
        {
            if (this.Modell == null)
            {
                var msg = $"Erst das Maschinenmodell auswählen bitte.";
                MetroMessageBox.Show(this, msg, "Geht so nicht");
                return;
            }

            var sn = (this.Seriennummer != null) ? this.Seriennummer.Replace("/", "_").Replace(@"\", "_") : string.Empty;
            if (string.IsNullOrEmpty(sn))
            {
                var msg = "Soll die Maschine wirklich ohne Seriennummer angelegt werden?";
                var dlgResult = MetroMessageBox.Show(this, msg, "Keine Seriennummer", MessageBoxButtons.YesNo);
                if (dlgResult == DialogResult.No) return;
            }

            var creatingUser = ModelManager.UserService.CurrentUser;
            var newMachine = ModelManager.MachineCreatorService.CreateKundenmaschine(this.myKunde, this.Modell, creatingUser, this.Seriennummer);
            this.CreatedMachine = newMachine ?? null;

            if (CreatedMachine == null)
            {
                var msg = "Das Anlegen der Kundenmaschine hat leider nicht funktioniert.";
                MetroMessageBox.Show(this, msg, "Neue Maschine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ordner für Maschinendateien zusammenbasteln und auf dem Server erstellen.
            var pfadSerie = this.CreatedMachine.Maschinenserie.Dateipfad;
            var modell = this.CreatedMachine.Modellbezeichnung.Replace("/", "_");
            var matchcode = this.CreatedMachine.CurrentOwner.Matchcode.Replace("/", "_");
            var ordnerKomplett = string.Empty;
            try
            {
                // Ordner für die Maschine zusammenbauen. Schema: "Modell +_+ Seriennummer
                // + (Kundenmatchcode)".
                var ordnerMaschine = string.Format("{0}_{1} ({2})", modell, sn, matchcode);

                // Den Maschinenordner im Dateisystem erstellen.
                ordnerKomplett = Path.Combine(pfadSerie, ordnerMaschine);
                Directory.CreateDirectory(ordnerKomplett);
                this.CreatedMachine.Dateipfad = ordnerKomplett;
                ModelManager.MachineService.UpdateMachines();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (IOException ioEx)
            {
                var msg = $"Beim Anlegen des Maschinenordners '{ordnerKomplett}' ist ein IO-Fehler aufgetreten.{Environment.NewLine}Der Fehler war: {ioEx.Message}";
                MetroMessageBox.Show(this, msg, "IO-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                var msg = $"Beim Anlegen des Maschinenordners '{ordnerKomplett}' ist ein Zugriffsfehler aufgetreten.{Environment.NewLine}Der Fehler war: {uaEx.Message}";
                MetroMessageBox.Show(this, msg, "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var msg = $"Beim Anlegen des Maschinenordners '{ordnerKomplett}' ist ein unerwarteter Fehler aufgetreten.{Environment.NewLine}Der Fehler war: {ex.Message}";
                MetroMessageBox.Show(this, msg, "Unbekannter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER

        #region PRIVATE PROCEDURES

        private void InitializeData()
        {
            try
            {
                this.cmbMachineModel.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
                this.cmbMachineModel.DisplayMember = "Modellbezeichnung";
            }
            catch (Exception)
            {
                var msg = "Da hat beim Anlegen der neuen Maschine etwas aber auch überhaupt nicht funktioniert.";
                MetroMessageBox.Show(this, msg, "Neue Maschine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion PRIVATE PROCEDURES
    }
}