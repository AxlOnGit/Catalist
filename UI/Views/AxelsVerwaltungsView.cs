using MetroFramework;
using MetroFramework.Forms;
using Products.Data;
using Products.Model;
using System;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class AxelsVerwaltungsView : MetroForm
    {
        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der AxelsVerwaltungsView Klasse.
        /// </summary>
        public AxelsVerwaltungsView()
        {
            InitializeComponent();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        void ButtonKundenumsatzAktualisieren_Click(object sender, EventArgs e)
        {
            var msg = "Augenblick, das kann eine Weile dauern.";
            MetroMessageBox.Show(this, msg, "Ich aktualisiere die Kundenumsätze ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataManager.AllDataService.UpdateKundenumsatzTabelle();
            msg = "So, die Kundenumsätze sind aktuell.";
            MetroMessageBox.Show(this, msg, "Ich aktualisiere die Kundenumsätze ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ButtonLieferanten_Click(object sender, EventArgs e)
        {
            var llv = new LieferantenListView();
            llv.ShowDialog();
        }

        void ButtonCleanTerminXRefs_Click(object sender, EventArgs e)
        {
            ModelManager.AppointmentService.CleanAppointmentLinkXRefs();
        }

        void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER
    }
}
