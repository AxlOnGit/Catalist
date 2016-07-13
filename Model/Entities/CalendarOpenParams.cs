using System;
using Products.Common;
using Products.Model.Entities;

namespace Products.Model.Entities
{

	/// <summary>
	/// Enumeration von 
	/// </summary>
	public enum AppointmentForType
	{
		Kunde,
		Interessent
	}

	public class CalendarOpenParams
	{

		#region members

		private bool wirSuchenEinenTermin = false;
		private Kunde myKunde = null;
		private Interessent myInteressent = null;
		private Kundenmaschine myMaschine = null;
		private User myUser = null;
		private SortableBindingList<Appointment> myTerminliste = null;
		private DateTime? myStartzeit = null;
		private DateTime? myEndzeit = null;
		private DvApi32.DvShowAsType myShowAs = DvApi32.DvShowAsType.DvShowAsFree;
		private int myReminderTime = -1;

		#endregion

		#region public properties

		public bool WirSuchenEinenTermin { get { return this.wirSuchenEinenTermin; } }
		public Kunde Kunde { get { return this.myKunde; } }
		public Interessent Interessent { get { return this.myInteressent; } }
		public Kundenmaschine Kundenmaschine{ get { return this.myMaschine; } }
		public User Mitarbeiter { get { return this.myUser; } }
		public SortableBindingList<Appointment> Terminliste { get { return this.myTerminliste; } }
		public DateTime Terminbeginn { get { return this.myStartzeit ?? DateTime.MinValue; } }
		public DateTime Terminende { get { return this.myEndzeit ?? DateTime.MinValue; } }
		public DvApi32.DvShowAsType AnzeigenAls { get { return this.myShowAs; } }
		public int ReminderTime { get { return this.myReminderTime; } }

		#endregion

		#region ### .ctor ###

		public CalendarOpenParams()
		{
			// Not a thing to do yet ...
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt fest, ob wir einen Termin zum Verknüpfen suchen oder nicht.
		/// </summary>
		/// <param name="wirSuchen">True, wenn eine Terminsuche bezweckt wird.</param>
		/// <returns></returns>
		public CalendarOpenParams SetWirSuchenEinenTermin(bool wirSuchen)
		{
			wirSuchenEinenTermin = wirSuchen;
			return this;
		}

		/// <summary>
		/// Legt den Kunden fest.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public CalendarOpenParams SetKunde(Model.Entities.Kunde kunde)
		{
			myKunde = kunde;
			return this;
		}

		/// <summary>
		/// Legt den Interessenten fest.
		/// </summary>
		/// <param name="interessent"></param>
		/// <returns></returns>
		public CalendarOpenParams SetInteressent(Interessent interessent)
		{
			myInteressent = interessent;
			return this;
		}

		/// <summary>
		/// Legt die Kundenmaschine fest.
		/// </summary>
		/// <param name="kundenmaschine"></param>
		/// <returns></returns>
		public CalendarOpenParams SetKundenmaschine(Model.Entities.Kundenmaschine kundenmaschine)
		{
			myMaschine = kundenmaschine;
			return this;
		}

		/// <summary>
		/// Legt den Techniker oder Außendienstler für Termine fest.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public CalendarOpenParams SetMitarbeiter(User user)
		{
			myUser = user;
			return this;
		}

		/// <summary>
		/// Legt die upfront anzuzeigende Liste mit Terminen fest.
		/// </summary>
		/// <param name="terminliste"></param>
		/// <returns></returns>
		public CalendarOpenParams SetTerminliste(SortableBindingList<Appointment> terminliste)
		{
			myTerminliste = terminliste;
			return this;
		}

		/// <summary>
		/// Legt einen Zeitpunkt für den Terminbeginn fest.
		/// </summary>
		/// <param name="startzeit"></param>
		/// <returns></returns>
		public CalendarOpenParams SetTerminbeginn(DateTime startzeit)
		{
			myStartzeit = startzeit;
			return this;
		}

		/// <summary>
		/// Legt einen Zeitpunkt für das Ende des Termins fest.
		/// </summary>
		/// <param name="endzeit"></param>
		/// <returns></returns>
		public CalendarOpenParams SetTerminende(DateTime endzeit)
		{
			myEndzeit = endzeit;
			return this;
		}

		/// <summary>
		/// Legt die Weckzeit in Minuten vor dem Termin fest.
		/// </summary>
		/// <param name="reminderTime"></param>
		/// <returns></returns>
		public CalendarOpenParams SetReminderTime(int reminderTime)
		{
			this.myReminderTime = reminderTime;
			return this;
		}

		/// <summary>
		/// Legt fest, ob der Termin als frei, beschäftigt, abwesend oder voraussichtlich angezeigt werden soll.
		/// </summary>
		/// <param name="showas"></param>
		/// <returns></returns>
		public CalendarOpenParams SetShowAs(DvApi32.DvShowAsType showas)
		{
			myShowAs = showas;
			return this;
		}

		#endregion

	}
}
