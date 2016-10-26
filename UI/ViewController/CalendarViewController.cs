using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Products.Model.Entities;
using Products.Common.Views;
using Products.Model;
using System.ComponentModel;
using Products.Common.Collections;

namespace Products.Common.ViewController
{
	public class CalendarViewController : INotifyPropertyChanged
	{

		#region enums

		public enum DaysToShowEnum
		{
			SingleDay = 1,
			FiveDays = 5,
			SevenDays = 7
		}

		#endregion

		#region events

		public event PropertyChangedEventHandler PropertyChanged;
		public event EventHandler ActiveUserListChanged;

		#endregion

		#region members

		User myCalendarOwner = null;
		SelectionRange mySelectionRange = new SelectionRange(DateTime.Today, DateTime.Today);
		DateTime myCalendarStartDay = DateTime.Today;
		int myCalendarDaysToShow  = 5;
		readonly List<User> myActiveUsersList = new List<User>();
		Appointment mySelectedAppointment = null;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den User zurück, dessen Kalender angezeigt wird.
		/// </summary>
		public User CalendarOwner 
		{ 
			get { return this.myCalendarOwner; }
			set
			{
				if (value != this.myCalendarOwner)
				{
					this.myCalendarOwner = value;
					this.NotifyPropertyChanged("CalendarOwner");
				}
			}
		}

		/// <summary>
		/// Gibt den im CalendarView ausgewählten Datumsbereich zurück oder legt ihn fest.
		/// </summary>
		public SelectionRange SelectionRange 
		{ 
			get { return this.mySelectionRange; } 
			set 
			{
				if (value != this.mySelectionRange)
				{
					this.mySelectionRange.Start = value.Start;
					this.CalendarStartDay = this.GetPrecedingMonday(value.Start);
					TimeSpan span = value.End - value.Start;
					int daysToShow = this.GetDaysToShow(value.Start, span.Days + 1);
					if (span.Days > 0)
					{
						this.CalendarDaysToShow = daysToShow;
					}
					//else if (daysToShow > this.CalendarDaysToShow)
					//{
					//  this.CalendarDaysToShow = daysToShow;						
					//} 
					this.NotifyPropertyChanged("SelectionRange");
				}
			} 
		}

		/// <summary>
		/// Legt den Tag fest, der im Kalender in der ersten Spalte angezeigt wird.
		/// </summary>
		public DateTime CalendarStartDay
		{
			get { return this.myCalendarStartDay; }
			private set 
			{
				if (this.myCalendarStartDay != value)
				{
					this.myCalendarStartDay = value;
					this.NotifyPropertyChanged("CalendarStartDay");
				}
			}
		}

		/// <summary>
		/// Die Anzahl der im Kalender anzuzeigenden Tage.
		/// </summary>
		public int CalendarDaysToShow
		{
			get { return this.myCalendarDaysToShow; }
			set
			{
				if (this.myCalendarDaysToShow != value)
				{
					this.myCalendarDaysToShow = (value > 7) ? 7 : value;
					this.NotifyPropertyChanged("CalendarDaysToShow");
				}
			}
		}

		/// <summary>
		/// Gibt den aktuell ausgewählten Termin zurück oder legt ihn fest.
		/// </summary>
		public Appointment SelectedAppointment {
			get { return this.mySelectedAppointment; }
			set 
			{
				if (value != this.mySelectedAppointment)
				{
					this.mySelectedAppointment = value;
					this.NotifyPropertyChanged("SelectedAppointment");
					this.NotifyPropertyChanged("AppointmentInfo");
				}
			} 
		}

		/// <summary>
		/// Liste aller Benutzer, deren Kalender angezeigt werden können.
		/// </summary>
		public SBList<User> UserItemsList { get { return ModelManager.UserService.GetActiveUsersList(); } }

		/// <summary>
		/// Gibt die Liste aller Benutzer zurück, deren Kalender gerade angezeigt werden.
		/// </summary>
		public List<User> ActiveUsersList 
		{ 
			get 
			{
				return this.myActiveUsersList; 
			}
		}

		/// <summary>
		/// Gibt die Namen der ebenfalls angezeigten Kalender (bzw. die Namen der betreffenden User) zurück.
		/// </summary>
		public string ActiveUserNames
		{
			get 
			{
				string returnString = string.Empty;
				string suffix = ", ";
				int counter = this.ActiveUsersList.Count;
				for (int i = 0; i < counter; i++)
				{
					if (i == counter -2) suffix = " und ";					
					else if (i == counter - 1) suffix = string.Empty;

					returnString += string.Format("{0}{1}", this.ActiveUsersList[i].NameFirst, suffix);
				}
				returnString += string.Format(" (Neue Termine werden für {0} erstellt)", ModelManager.UserService.CurrentUser.CalendarSettings.TargetUser.NameFull);
				return returnString;
			}
		}

		/// <summary>
		/// Gibt eine Zusammenfassung des aktuell ausgewählten Termins zurück.
		/// </summary>
		public string AppointmentInfo
		{
			get
			{
				if (this.mySelectedAppointment == null) return "Kein Termin ausgewählt.";
				return this.mySelectedAppointment.AppointmentInfo;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CalendarViewController Klasse.
		/// </summary>
		/// <param name="calendarOwner"></param>
		public CalendarViewController(User calendarOwner)
		{
			this.myCalendarOwner = calendarOwner;
			this.AddUserCalendar(calendarOwner);
			this.CalendarStartDay = this.GetPrecedingMonday(DateTime.Today);
		}

		#endregion

		#region public procedures

		public void BackOneWeek()
		{
			this.CalendarStartDay = this.CalendarStartDay.AddDays(-7);
		}

		internal void GoToToday()
		{
			this.CalendarStartDay = this.GetPrecedingMonday(DateTime.Today);
		}

		public void ForwardOneWeek()
		{
			this.CalendarStartDay = this.CalendarStartDay.AddDays(7);
		}

		/// <summary>
		/// Zeigt den Kalender des angegebenen Users an.
		/// </summary>
		/// <param name="user"></param>
		public void AddUserCalendar(User user)
		{
			// Code nur ausführen, wenn der angegebene User noch nicht in der Liste ist.
			if (!this.myActiveUsersList.Contains(user))
			{
				this.myActiveUsersList.Add(user);
				this.NotifyPropertyChanged("ActiveUsersList");

				// Abonnnenten über die Änderung informieren.
				if (ActiveUserListChanged != null)
				{
					this.ActiveUserListChanged(this, new EventArgs());
				}
			}
		}

		internal void ClearActiveUserList()
		{
			int counter = this.ActiveUsersList.Count;
			for (int i = counter - 1; i >= 0 ; i--)
			{
				this.RemoveUserCalendar(this.ActiveUsersList[i]);
			}
		}

		/// <summary>
		/// Blendet den Kalender des angegebenen Users aus.
		/// </summary>
		/// <param name="user"></param>
		public void RemoveUserCalendar(User user)
		{
			// Code nur ausführen, wenn wir den angegebenen User auch in der Liste haben.
			if (this.myActiveUsersList.Contains(user))
			{
				this.myActiveUsersList.Remove(user);
				this.NotifyPropertyChanged("ActiveUsersList");

				// Abonnenten über die Änderung informieren.
				if (this.ActiveUserListChanged != null)
				{
					this.ActiveUserListChanged(this, new EventArgs());
				}
			}
		}

		#endregion

		#region private procedures

		void NotifyPropertyChanged(string propertyName)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		DateTime GetPrecedingMonday(DateTime forDate)
		{
			switch (forDate.DayOfWeek)
			{
				case DayOfWeek.Monday: return forDate;
				case DayOfWeek.Tuesday: return forDate.AddDays(-1);
				case DayOfWeek.Wednesday: return forDate.AddDays(-2);
				case DayOfWeek.Thursday: return forDate.AddDays(-3);
				case DayOfWeek.Friday: return forDate.AddDays(-4);
				case DayOfWeek.Saturday: return forDate.AddDays(-5);
				case DayOfWeek.Sunday: return forDate.AddDays(-6);
				default: return forDate;
			}
		}

		int GetDaysToShow(DateTime startDate, int selectedDays)
		{
			switch (startDate.DayOfWeek)
			{
				case DayOfWeek.Monday:
					return selectedDays;

				case DayOfWeek.Tuesday:
					return selectedDays + 1;
				case DayOfWeek.Wednesday:
					return selectedDays + 2;
				case DayOfWeek.Thursday:
					return selectedDays + 3;
				case DayOfWeek.Friday:
					return selectedDays + 4;
				case DayOfWeek.Saturday:
					return selectedDays + 5;
				case DayOfWeek.Sunday:
					return selectedDays + 6;
				default:
					return 5;
			}
		}

		#endregion

	}
}
