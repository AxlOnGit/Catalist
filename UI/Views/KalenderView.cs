using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Products.Common.ViewController;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KalenderView : Form
	{

		#region members

		CalendarViewController myController;
		static bool toolTipSet;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KalenderView Klasse.
		/// </summary>
		public KalenderView(CalendarViewController controller)
		{
			InitializeComponent();
			this.myController = controller;
			this.InitializeData();

			this.DayViewMain.ResolveAppointments += DayViewMain_ResolveAppointments;
			this.MouseWheel += KalenderView_MouseWheel;
			this.DateSelector.DateChanged += DateSelector_DateChanged;
		}

		#endregion

		#region event handler

		void DayViewMain_ResolveAppointments(object sender, Calendar.ResolveAppointmentsEventArgs args)
		{
			var list = new List<Calendar.Appointment>();
			foreach (var user in this.myController.ActiveUsersList)
			{
				foreach (var item in user.Terminliste.Where(a => a.StartDate >= this.myController.CalendarStartDay && a.EndDate <= this.myController.CalendarStartDay.AddDays(7)))
				{
					list.Add(item);
				}
			}
			args.Appointments = list;
		}

		void DayViewMain_SelectionChanged(object sender, EventArgs e)
		{
			if (this.DayViewMain.SelectionStart.Equals(DateTime.MinValue)) return;
			if (this.DayViewMain.SelectedAppointment != null)
			{
				this.myController.SelectedAppointment = this.DayViewMain.SelectedAppointment as Appointment;
			}
			this.DateSelector.SetDate(this.DayViewMain.SelectionStart);
		}

		void DateSelector_DateChanged(object sender, DateRangeEventArgs e)
		{
			this.DayViewMain.SelectionStart = this.DateSelector.SelectionStart;
			this.myController.SelectionRange = this.DateSelector.SelectionRange;
		}

		void mbtnActiveCalendars_Click(object sender, EventArgs e)
		{
			Application.DoEvents();
			var suv = new SelectUsersView(ModelManager.UserService.GetActiveUsersList(), this.myController.ActiveUsersList, "Kalender der Kollegen");
			if (suv.ShowDialog(this) == DialogResult.OK)
			{
				this.myController.ClearActiveUserList();
				foreach (var user in suv.CheckedUsersList)
				{
					this.myController.AddUserCalendar(user as User);
				}
				this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
				
				// Wenn der Kalender des in den CalendarSettings eingestellte TargetUser nicht angezeigt wird ...
				var currentUser = ModelManager.UserService.CurrentUser;
				if (!this.myController.ActiveUsersList.Contains(currentUser.CalendarSettings.TargetUser))
				{
					var csv = new CalendarSettingsView(currentUser.CalendarSettings);
					csv.ShowDialog();
				}

				this.DayViewMain.Invalidate();
			}
		}

		void KalenderView_SizeChanged(object sender, EventArgs e)
		{
			var left = this.DayViewMain.Left;
			var width = this.DayViewMain.Width;
			var widthButton = (int)Math.Round((decimal)(width - 112) / 2 , 0, MidpointRounding.AwayFromZero);

			this.mbtnBackOneWeek.Left = left;
			this.mbtnForwardOneWeek.Left = left + 112 + widthButton;


			this.mbtnToday.Left = left + widthButton + 6;

			this.mbtnBackOneWeek.Width = widthButton;
			this.mbtnForwardOneWeek.Width = widthButton;
		}

		void mctxCalendar_Opening(object sender, CancelEventArgs e)
		{
			var termin = this.DayViewMain.SelectedAppointment;
			if (termin != null)
			{
				this.myController.SelectedAppointment = termin as Appointment;
				this.xcmdShowAppointment.Enabled = true;
				this.xcmdDeleteAppointment.Enabled = true;
			}
			else
			{
				this.xcmdShowAppointment.Enabled = false;
				this.xcmdDeleteAppointment.Enabled = false;
			}
		}

		void DayViewMain_MouseMove(object sender, MouseEventArgs e)
		{
			var termin = this.DayViewMain.GetAppointmentAt(e.X, e.Y) as Appointment;
			if (!toolTipSet)
			{
				if (termin != null)
				{
					this.tipAppointmentInfo.SetToolTip(this.DayViewMain, termin.AppointmentInfo);
				}
				else
				{
					this.tipAppointmentInfo.SetToolTip(this.DayViewMain, string.Empty);
				}
				toolTipSet = true;
				return;
			}
			toolTipSet = false;
		}

		void xcmdNewAppointment_Click(object sender, EventArgs e)
		{
			this.AddAppointment();
		}

		void KalenderView_MouseWheel(object sender, MouseEventArgs e)
		{
			if (ModifierKeys == Keys.Control)
			{
				if (e.Delta > 0)
				{
					this.myController.ForwardOneWeek();
				}
				else
				{
					this.myController.BackOneWeek();
				}
			}
		}

		void mbtnForwardOneWeek_Click(object sender, EventArgs e)
		{
			this.myController.ForwardOneWeek();
		}

		void mbtnBackOneWeek_Click(object sender, EventArgs e)
		{
			this.myController.BackOneWeek();
		}

		void mbtnToday_Click(object sender, EventArgs e)
		{
			this.myController.GoToToday();
		}

		void DayViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.myController.SelectedAppointment != null)
			{
				this.ShowAppointment();
			}
		}

		void xcmdShowAppointment_Click(object sender, EventArgs e)
		{
			this.ShowAppointment();
		}

		void xcmdDeleteAppointment_Click(object sender, EventArgs e)
		{
			this.DeleteAppointment();
		}

		void cdv_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.myController.SelectedAppointment = null;
			this.DayViewMain.Invalidate();
		}

		void mbtnSettings_Click(object sender, EventArgs e)
		{
			this.ShowCalendarSettings();
		}

		void xcmdCalendarSettings_Click(object sender, EventArgs e)
		{
			this.ShowCalendarSettings();
		}

		void mcmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("{0}s Kalender - {1}", this.myController.CalendarOwner.LoginWindows, this.myController.CalendarStartDay.ToString("MMMM yyyy"));
			this.mlblActiveUsers.DataBindings.Add("Text", this.myController, "ActiveUserNames");
			this.DayViewMain.SelectionChanged += DayViewMain_SelectionChanged;
			this.DayViewMain.MouseMove += DayViewMain_MouseMove;
			this.myController.PropertyChanged += myController_PropertyChanged;

			this.DayViewMain.DataBindings.Add("DaysToShow", this.myController, "CalendarDaysToShow");
			this.DayViewMain.DataBindings.Add("StartDate", this.myController, "CalendarStartDay");
		}

		void AddAppointment()
		{
			var currentUser = ModelManager.UserService.CurrentUser;
			if (this.DayViewMain.SelectionStart == DateTime.MinValue) return;
			var start = this.DayViewMain.SelectionStart;
			var end = this.DayViewMain.SelectionEnd;
			User forUser = ModelManager.UserService.CurrentUser.CalendarSettings.TargetUser;
			var newAppointment = ModelManager.AppointmentService.AddAppointment(forUser, start, end, "Undefiniert", null);
			this.myController.SelectedAppointment = newAppointment;

			// Verknüpfte Elemente zum Termin hinzufügen ...
			foreach (var link in currentUser.CalendarSettings.LinkedItemsList)
			{
				ModelManager.AppointmentService.AddLinkedItemToAppointment(newAppointment, link.Key, link.LinkTypBezeichnung);
			}
			// ... und anschließend die Liste leeren.
			currentUser.CalendarSettings.LinkedItemsList.Clear();

			this.DayViewMain.Invalidate();
			this.ShowAppointment();
		}

		void ShowAppointment()
		{
			var cdv = new CalendarDetailView(this.myController.SelectedAppointment);
			cdv.FormClosed += cdv_FormClosed;
			cdv.Show();

		}

		void DeleteAppointment()
		{
			var termin = this.myController.SelectedAppointment;
			if (termin == null) return;

			var msg = string.Format("{0}{1} wird endgültig gelöscht", Environment.NewLine, termin.Subject);
			var title = "Catalist Kalender";

			if (MetroFramework.MetroMessageBox.Show(this, msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				ModelManager.AppointmentService.DeleteAppointment(termin);
			}
			this.DayViewMain.Invalidate();
		}

		void ShowCalendarSettings()
		{
			var currentUser = ModelManager.UserService.CurrentUser;
			var csv = new CalendarSettingsView(currentUser.CalendarSettings);
			csv.ShowDialog();
			if (!this.myController.ActiveUsersList.Contains(currentUser.CalendarSettings.TargetUser))
			{
				this.myController.ActiveUsersList.Add(currentUser.CalendarSettings.TargetUser);
			}
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void myController_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "CalendarStartDay")
			{
				this.Text = string.Format("{0}s Kalender - {1}", this.myController.CalendarOwner.LoginWindows, this.myController.CalendarStartDay.ToString("MMMM yyyy"));
				this.Invalidate();
			}
		}

		#endregion


	}
}
