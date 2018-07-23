using MetroFramework.Forms;
using Products.Model.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class AppointmentListView : MetroForm
    {
        #region PROPERTIES

        SortableBindingList<Appointment> TerminListe { get; set; }

        string Title { get; set; }

        Appointment SelectedAppointment { get; set; }

        #endregion PROPERTIES

        #region ### .ctor ###

        /// <summary>
        /// Erzeugt eine neue Instanz der <seealso cref="AppointmentListView" /> Klasse.
        /// </summary>
        public AppointmentListView(SortableBindingList<Appointment> terminListe, string title)
        {
            InitializeComponent();
            this.TerminListe = terminListe;
            this.Title = title;
            this.InitializeData();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        void DgvAppointments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedAppointment = this.dgvAppointments.Rows[e.RowIndex].DataBoundItem as Appointment;
        }

        void XcmdShowAppointment_Click(object sender, EventArgs e)
        {
            this.ShowAppointment();
        }

        void DgvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowAppointment();
        }

        void MbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENT HANDLER

        #region METHODS

        void InitializeData()
        {
            this.Text = $"Terminliste für {this.Title.Replace("&", "&&")}";
            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.DataSource = this.TerminListe.Sort("StartsAt", ListSortDirection.Descending);
        }

        void ShowAppointment()
        {
            if (this.SelectedAppointment == null) return;

            var cdv = new CalendarDetailView(this.SelectedAppointment);
            cdv.Show();
        }

        #endregion METHODS
    }
}
