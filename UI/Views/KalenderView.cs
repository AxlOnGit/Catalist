using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Products.Common.ViewController;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KalenderView : MetroForm
	{
		#region MEMBERS

		CalendarViewController myController;
		User myCurrentUser;
		static bool toolTipSet;
		static int countTries;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KalenderView Klasse.
		/// </summary>
		public KalenderView(CalendarViewController controller)
		{
			InitializeComponent();
			this.myController = controller;
			this.myCurrentUser = ModelManager.UserService.CurrentUser;
			this.InitializeData();
			// Buttons abhängig vom TargetUser einstellen.
			this.SetNextButtons();

			this.DayViewMain.ResolveAppointments += DayViewMain_ResolveAppointments;
			this.MouseWheel += KalenderView_MouseWheel;
			this.DateSelector.DateChanged += DateSelector_DateChanged;
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		#region DAYVIEW EVENTS

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

		void DayViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.myController.SelectedAppointment != null)
			{
				this.ShowAppointment();
			}
		}

		void DayViewMain_AppointmentMove(object sender, Calendar.AppointmentEventArgs e)
		{
			var termin = e.Appointment as Appointment;
			if (termin != null && termin.IsDirty)
			{
				termin.Update();
			}
		}

		#endregion DAYVIEW EVENTS

		void myController_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			switch (e.PropertyName)
			{
				case "CalendarStartDay":
				this.Text = string.Format("{0}s Kalender - {1}", this.myController.CalendarOwner.LoginWindows, this.myController.CalendarStartDay.ToString("MMMM yyyy"));
				this.Invalidate();
				break;

				case "":
				break;
			}
		}

		void CalendarSettings_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			switch (e.PropertyName)
			{
				case "TargetUser":
				this.SetNextButtons();
				break;
			}
		}

		void SetNextButtons()
		{
			switch (this.myCurrentUser.CalendarSettings.TargetUser.SageLoginName)
			{
				case "FD":
				this.ResetNextButtons(this.mbtnFelix);
				break;

				case "MD":
				this.ResetNextButtons(this.mbtnMatti);
				break;

				case "JD":
				this.ResetNextButtons(this.mbtnJohannes);
				break;

				case "MS":
				this.ResetNextButtons(this.mbtnMarkusS);
				break;

				case "AU":
				this.ResetNextButtons(this.mbtnAxel);
				break;
			}
		}

		void DateSelector_DateChanged(object sender, DateRangeEventArgs e)
		{
			this.DayViewMain.SelectionStart = this.DateSelector.SelectionStart;
			this.myController.SelectionRange = this.DateSelector.SelectionRange;
		}

		void KalenderView_SizeChanged(object sender, EventArgs e)
		{
			var left = this.DayViewMain.Left;
			var width = this.DayViewMain.Width;
			var widthButton = (int)Math.Round((decimal)(width - 112) / 2, 0, MidpointRounding.AwayFromZero);

			this.mbtnBackOneWeek.Left = left;
			this.mbtnForwardOneWeek.Left = left + 112 + widthButton;

			this.mbtnToday.Left = left + widthButton + 6;

			this.mbtnBackOneWeek.Width = widthButton;
			this.mbtnForwardOneWeek.Width = widthButton;
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

		void cdv_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.myController.SelectedAppointment = null;
			this.DayViewMain.Invalidate();
		}

		void mtxtSelectDate_Validated(object sender, EventArgs e)
		{
			var dat = this.mtxtSelectDate.Text;
			DateTime date;
			DateTime.TryParse(dat, out date);
			if (date == DateTime.MinValue)
			{
				countTries++;
				if (countTries > 2)
				{
					var nl = Environment.NewLine;
					var msg = $"Samma, geht's noch, Holzpfosten? Du hast jetzt dreimal versucht ein Datum einzugeben.{nl}Also: Gültige Versuche wären z. B. '17.12.2016', '17/12/2016' und '17-12-2016' oder '17.12.16', '17/12/16' und '17-12-16' ";
					MetroFramework.MetroMessageBox.Show(this, msg, "He, Du Leuchte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (date < this.DateSelector.MinDate)
			{
				var msg = $"Das Datum kann nicht vor dem {this.DateSelector.MinDate.ToShortDateString()} liegen.";
				date = DateTime.Today;
			}
			this.myController.SelectionRange = new SelectionRange(date, date);
			this.DateSelector.SelectionRange = this.myController.SelectionRange;
			this.mtxtSelectDate.Text = date.ToShortDateString();
		}

		void mtxtSelectDate_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.DayViewMain.Select();
			}
		}

		#region BUTTONS

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

				// Wenn der Kalender des in den CalendarSettings eingestellte TargetUser nicht
				// angezeigt wird ...
				var currentUser = ModelManager.UserService.CurrentUser;
				if (!this.myController.ActiveUsersList.Contains(currentUser.CalendarSettings.TargetUser))
				{
					var csv = new CalendarSettingsView(currentUser.CalendarSettings);
					csv.ShowDialog();
				}

				this.DayViewMain.Invalidate();
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

		void mbtnSettings_Click(object sender, EventArgs e)
		{
			this.ShowCalendarSettings();
		}

		void btnRefreshAppointments_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			ModelManager.AppointmentService.RefreshAppointmentList();
			this.Cursor = Cursors.Default;
		}

		#endregion

		#region CONTEXT MENU

		void mctxCalendar_Opening(object sender, CancelEventArgs e)
		{
			var termin = this.DayViewMain.SelectedAppointment;

			this.xcmdShowAppointment.Enabled = (termin != null);
			this.xcmdDeleteAppointment.Enabled = (termin != null);
			this.xcmdMoveAppointment.Enabled = (termin != null);
		}

		void xcmdShowAppointment_Click(object sender, EventArgs e)
		{
			this.ShowAppointment();
		}

		void xcmdMoveAppointment_Click(object sender, EventArgs e)
		{
			this.MoveAppointment();
		}

		void xcmdNewAppointment_Click(object sender, EventArgs e)
		{
			this.CreateAppointment();
		}

		void xcmdDeleteAppointment_Click(object sender, EventArgs e)
		{
			this.DeleteAppointment();
		}

		void xcmdCalendarSettings_Click(object sender, EventArgs e)
		{
			this.ShowCalendarSettings();
		}

		#endregion CONTEXT MENU

		#region NEXT BUTTONS

		void mbtnFelix_Click(object sender, EventArgs e)
		{
			var felix = ModelManager.UserService.GetUser("FD", Model.Services.UserService.UserSearchParamType.SageLoginName);
			var uList = this.myController.ActiveUsersList;
			if (!uList.Contains(felix)) uList.Add(felix);
			this.myController.CalendarOwner.CalendarSettings.SetTargetUser(felix);
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void mbtnMatti_Click(object sender, EventArgs e)
		{
			var matti = ModelManager.UserService.GetUser("MD", Model.Services.UserService.UserSearchParamType.SageLoginName);
			var uList = this.myController.ActiveUsersList;
			if (!uList.Contains(matti)) uList.Add(matti);
			this.myController.CalendarOwner.CalendarSettings.SetTargetUser(matti);
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void mbtnJohannes_Click(object sender, EventArgs e)
		{
			var jo = ModelManager.UserService.GetUser("JD", Model.Services.UserService.UserSearchParamType.SageLoginName);
			var uList = this.myController.ActiveUsersList;
			if (!uList.Contains(jo)) uList.Add(jo);
			this.myController.CalendarOwner.CalendarSettings.SetTargetUser(jo);
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void mbtnMarkusS_Click(object sender, EventArgs e)
		{
			var markusS = ModelManager.UserService.GetUser("MS", Model.Services.UserService.UserSearchParamType.SageLoginName);
			var uList = this.myController.ActiveUsersList;
			if (!uList.Contains(markusS)) uList.Add(markusS);
			this.myController.CalendarOwner.CalendarSettings.SetTargetUser(markusS);
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void mbtnAxel_Click(object sender, EventArgs e)
		{
			var axxl = ModelManager.UserService.GetUser("AU", Model.Services.UserService.UserSearchParamType.SageLoginName);
			var uList = this.myController.ActiveUsersList;
			if (!uList.Contains(axxl)) uList.Add(axxl);
			this.myController.CalendarOwner.CalendarSettings.SetTargetUser(axxl);
			this.mlblActiveUsers.Text = this.myController.ActiveUserNames;
		}

		void mcmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion NEXT BUTTONS

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.Text = string.Format("{0}s Kalender - {1}", this.myController.CalendarOwner.LoginWindows, this.myController.CalendarStartDay.ToString("MMMM yyyy"));
			this.mlblActiveUsers.DataBindings.Add("Text", this.myController, "ActiveUserNames");
			this.DayViewMain.SelectionChanged += DayViewMain_SelectionChanged;
			this.DayViewMain.MouseMove += DayViewMain_MouseMove;
			this.myController.PropertyChanged += myController_PropertyChanged;
			this.myCurrentUser.CalendarSettings.PropertyChanged += CalendarSettings_PropertyChanged;

			this.DayViewMain.DataBindings.Add("DaysToShow", this.myController, "CalendarDaysToShow");
			this.DayViewMain.DataBindings.Add("StartDate", this.myController, "CalendarStartDay");
		}

		void ShowAppointment()
		{
			var cdv = new CalendarDetailView(this.myController.SelectedAppointment);
			cdv.FormClosed += cdv_FormClosed;
			cdv.Show();
		}

		void MoveAppointment()
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK && usv.SelectedUser != null)
			{
				ModelManager.AppointmentService.MoveAppointment(appointment: this.myController.SelectedAppointment, toUser: usv.SelectedUser);
			}
		}

		void CreateAppointment()
		{
			var currentUser = ModelManager.UserService.CurrentUser;
			if (this.DayViewMain.SelectionStart == DateTime.MinValue) return;
			var start = this.DayViewMain.SelectionStart;
			var end = this.DayViewMain.SelectionEnd;
			User forUser = ModelManager.UserService.CurrentUser.CalendarSettings.TargetUser;
			var newAppointment = ModelManager.AppointmentService.CreateAppointment(forUser, start, end, "Undefiniert");
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

		void ResetNextButtons(MetroButton exceptFor)
		{
			var buttons = new List<MetroButton>
			{
				this.mbtnFelix, this.mbtnMatti, this.mbtnJohannes,this.mbtnMarkusS, this.mbtnAxel
			};

			foreach (var btn in buttons)
			{
				if (btn.Equals(exceptFor))
				{
					btn.Style = MetroFramework.MetroColorStyle.Orange;
					btn.Invalidate();
					continue;
				}
				btn.Style = MetroFramework.MetroColorStyle.Silver;
				btn.Invalidate();
			}
		}

		#endregion PRIVATE PROCEDURES

	}
}