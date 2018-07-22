using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class AppointmentListView : MetroForm
	{
		#region MEMBERS

		private readonly SortableBindingList<Appointment> myTerminListe;
		private readonly string myTitle;
		private Appointment mySelectedAppointment;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AppointmentListView"/> Klasse.
		/// </summary>
		public AppointmentListView(SortableBindingList<Appointment> terminListe, string title)
		{
			InitializeComponent();
			this.myTerminListe = terminListe;
			this.myTitle = title;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		private void dgvAppointments_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedAppointment = this.dgvAppointments.Rows[e.RowIndex].DataBoundItem as Appointment;
		}

		private void xcmdShowAppointment_Click(object sender, EventArgs e)
		{
			this.ShowAppointment();
		}

		private void dgvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowAppointment();
		}

		private void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		private void InitializeData()
		{
			this.Text = string.Format("Terminliste für {0}", this.myTitle.Replace("&", "&&"));
			this.dgvAppointments.AutoGenerateColumns = false;
			this.dgvAppointments.DataSource = this.myTerminListe.Sort("StartsAt", ListSortDirection.Descending);
		}

		private void ShowAppointment()
		{
			if (this.mySelectedAppointment == null) return;

			var cdv = new CalendarDetailView(this.mySelectedAppointment);
			cdv.Show();
		}

		#endregion PRIVATE PROCEDURES
	}
}