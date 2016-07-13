using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class AppointmentListView : MetroForm
	{

		#region members

		readonly SBList<Appointment> myTerminListe;
		readonly string myTitle;
		Appointment mySelectedAppointment;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AppointmentListView"/> Klasse.
		/// </summary>
		public AppointmentListView(SBList<Appointment> terminListe, string title)
		{
			InitializeComponent();
			this.myTerminListe = terminListe;
			this.myTitle = title;
			this.InitializeData();
		}

		#endregion

		#region event handler

		void dgvAppointments_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedAppointment = this.dgvAppointments.Rows[e.RowIndex].DataBoundItem as Appointment;
		}

		void xcmdShowAppointment_Click(object sender, EventArgs e)
		{
			this.ShowAppointment();
		}

		void dgvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowAppointment();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("Terminliste für {0}", this.myTitle.Replace("&","&&"));
			this.dgvAppointments.AutoGenerateColumns = false;
			this.dgvAppointments.DataSource = this.myTerminListe.Sort("StartsAt", ListSortDirection.Descending);
		}

		void ShowAppointment()
		{
			if (this.mySelectedAppointment == null) return;

			var cdv = new CalendarDetailView(this.mySelectedAppointment);
			cdv.Show();
		}

		#endregion

	}
}
