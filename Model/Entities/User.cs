using System;
using System.IO;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using System.Collections;
using System.Linq;
using Products.Model.Services;
using Products.Data.Datasets;
using System.Runtime.InteropServices;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class User : ILinkedItem
	{

		#region members

		dsUser.UserRow myBase = null;
		SBList<Reminder> myReminderList = null;
		CalendarSettings myCalendarSettings;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Mitarbeiter").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return myBase.UserName; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Mitarbeiter"; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel (GUID als Zeichenfolge) des Users zurück.
		/// </summary>
		public string UID
		{
			get { return myBase.UID; }
		}

		public string UserName
		{
			get { return myBase.UserName; }
			set { myBase.UserName = value; }
		}

		public string NameFirst
		{
			get
			{
				string[] nameArray = myBase.UserName.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
				if (nameArray.Length > 0)
				{

					return nameArray[0];
				}
				return string.Empty;
			}
		}

		public string NameLast
		{
			get
			{
				string[] nameArray = myBase.UserName.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
				if (nameArray.Length > 1)
				{
					return nameArray[1];
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt den vollständigen Namen des Benutzers zurück.
		/// </summary>
		public string NameFull
		{
			get
			{
				return myBase.UserName;
			}
		}

		public string LoginWindows
		{
			get { return myBase.Login_Windows; }
			set { myBase.Login_Windows = value; }
		}

		public string SageLoginName
		{
			get { return myBase.Login_Sage; }
			set { myBase.Login_Sage = value; }
		}

		public string SageEmplyeeId
		{
			get { return myBase.SageEmployeeId; }
			set { myBase.SageEmployeeId = value; }
		}

		public string DavidLoginName
		{
			get { return myBase.Login_David; }
			set { myBase.Login_David = value; }
		}

		public string AgfeoLoginName
		{
			get { return myBase.Login_PhoneSystem; }
			set { myBase.Login_PhoneSystem = value; }
		}

		public int PhoneId
		{
			get { return myBase.PhoneLineId; }
			set { myBase.PhoneLineId = value; }
		}

		public string AgfeoLineName
		{
			get { return myBase.PhoneLineName; }
			set { myBase.PhoneLineName = value; }
		}

		public string PhoneHome
		{
			get { return myBase.PhoneHome; }
			set { myBase.PhoneHome = value; }
		}

		public string PhoneMobile
		{
			get { return myBase.PhoneMobile; }
			set { myBase.PhoneMobile = value; }
		}

		public string EmailWork
		{
			get { return myBase.EmailWork; }
			set { myBase.EmailWork = value; }
		}

		public string Signature
		{
			get { return this.myBase.Signature; }
			set { this.myBase.Signature = value; }
		}

		public string EmailPrivate
		{
			get { return myBase.EmailPrivate; }
			set { myBase.EmailPrivate = value; }
		}

		/// <summary>
		/// Gibt den Namen des Benutzerordners auf dem David Server zurück oder legt ihn fest.
		/// </summary>
		public string DavidUserFolder
		{
			get
			{
				return myBase.UserFolderDavid;
			}
			set
			{
				myBase.UserFolderDavid = value;
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung des Ordners für das Kalenderarchiv des Benutzers zurück.
		/// </summary>
		public string DavidKalenderarchiv
		{
			get
			{
				return myBase.DavidCalArchive;
			}
			set
			{
				myBase.DavidCalArchive = value;
			}
		}

		/// <summary>
		/// Gibt die Kalendereinstellungen des Benutzers zurück.
		/// </summary>
		public CalendarSettings CalendarSettings { get { return this.myCalendarSettings; } }

		/// <summary>
		/// Gibt die Farbe der Kalendereinträge des Mitarbeiters zurück oder legt sie fest.
		/// </summary>
		public System.Drawing.Color AppointmentColor
		{
			get
			{
				string[] rgb = this.myBase.AppointmentColor.Split(new char[1] { ',' });

				int red = 255; 
				int.TryParse(rgb[0], out red);

				int green = 255;
				int.TryParse(rgb[1], out green);

				int blue = 255;
				int.TryParse(rgb[2], out blue);

				return System.Drawing.Color.FromArgb(red, green, blue);
			}
			set
			{
				this.myBase.AppointmentColor = string.Join(",", new string[3] { value.R.ToString(), value.G.ToString(), value.B.ToString() });
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Termine dieses Benutzers zurück.
		/// </summary>
		public SBList<Appointment> Terminliste
		{
			get 
			{
				try
				{
					return ModelManager.AppointmentService.GetAppointmentList(this);
				}
				catch (COMException ex)
				{
					throw ex;
				}
			}
		}

		#region tasks and reminders

		/// <summary>
		/// Gibt eine sortier- und filterbare Liste aller Erinnerungen für diesen Benutzer zurück.
		/// </summary>
		/// <remarks>
		/// Es wird immer eine Liste zurückgegeben, die allerdings auch 0 Elemente enthalten kann.
		/// </remarks>
		public SBList<Reminder> Reminderliste
		{
			get
			{
				if (this.myReminderList == null)
				{
					this.myReminderList = new SBList<Reminder>();
					foreach (var task in ModelManager.TaskService.GetTaskList(this))
					{
						if (task.Reminder != null)
						{
							if (task.Reminder.RemindAt < DateTime.Now) task.DeleteReminder();
							this.myReminderList.Add(task.Reminder);
						}
					}
				}
				return this.myReminderList;
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der User Klasse.
		/// </summary>
		/// <param name="userRow">Die dsUser.UserRow, die Basis dieser Instanz ist.</param>
		public User(dsUser.UserRow userRow)
		{
			this.myBase = userRow;
			this.myCalendarSettings = new CalendarSettings(this);
			this.InitCalendarSettings();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Überschreibt base.ToString() und gibt den Vornamen des Users zurück.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.NameFirst;
		}

		////TODO: Neuer Besuchstermin muss komplett umgeschrieben werden!
		///// <summary>
		///// Erstellt einen neuen Besuchstermin und fügt ihn der Terminliste dieses Mitarbeiters hinzu.
		///// </summary>
		///// <param name="kunde">Instanz des Kunden.</param>
		///// <param name="start">Terminbeginn.</param>
		///// <param name="ende">Terminende.</param>
		//public void AddBesuchstermin(Kunde kunde, DateTime start, DateTime ende)
		//{
		//  try
		//  {
		//    // 1. Neuen David Termin erstellen
		//    string userArchive = this.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender);
		//    David.CreateMsgItm2Params calendarItemParams = David.DavidManager.DavidService.CreateCalendarItem(start, ende, userArchive);

		//    // 2. Neuen Referenzeintrag für den Kunden in Tabelle TerminLinkXref erstellen
		//    Data.DataManager.AllDataService.AddTerminLinkXrefRow(
		//      calendarItemParams.UID,
		//      calendarItemParams.Filename,
		//      kunde.CustomerId,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Kunde").UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Besuchstermin").UID,
		//      ModelManager.UserService.CurrentUser.UID);

		//    // 3. Neuen Referenzeintrag für den Vertriebsmitarbeiter in Tabelle TerminLinkXref erstellen
		//    Data.DataManager.AllDataService.AddTerminLinkXrefRow(
		//      calendarItemParams.UID,
		//      calendarItemParams.Filename,
		//      this.UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Mitarbeiter").UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Besuchstermin").UID,
		//      ModelManager.UserService.CurrentUser.UID);

		//    // 4. Neue Termin-Instanz mit dem gerade erstellten MessageItem2 erstellen
		//    //		und der Terminliste diese Benutzers hinzufügen.
		//    Appointment termin = new Appointment(calendarItemParams.MessageItem2Object,);
		//    this.Terminliste.Add(termin);

		//    // 5. Letzten und nächsten Besuchstermin akutalisieren
		//    kunde.TermindatenAktualisieren(termin.StartDate);
		//  }
		//  catch (Exception ex)
		//  {
		//    throw ex;
		//  }
		//}

		/// <summary>
		/// Macht aus dem angegebenen Termin einen Besuchstermin dieses Kunden mit dem
		/// angegebenen Außendienstmitarbeiter.
		/// </summary>
		/// <param name="termin"></param>
		/// <param name="mitarbeiter"></param>
		//public bool LinkBesuchstermin(Termin termin, Kunde kunde)
		//{
		//  // Wenn dieser Termin schon zugeordnet wurde, nichnochmaltun!
		//  //NEXT: Verhindern, dass ein Besuchstermin zum 2. Mal zugeordnet wird.
		//  //if (this.Besuchsterminliste.Contains(termin)) return false;

		//  try
		//  {
		//    // 1. Neuen Referenzeintrag für den Kunden in Tabelle TerminLinkXref erstellen
		//    DataManager.AllDataService.AddTerminLinkXrefRow(
		//      termin.TerminUID,
		//      termin.FullName,
		//      kunde.CustomerId,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Kunde").UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Besuchstermin").UID,
		//      ModelManager.UserService.CurrentUser.UID);

		//    // 2. Neuen Referenzeintrag für den Außendienstler in Tabelle TerminLinkXref erstellen.
		//    Data.DataManager.AllDataService.AddTerminLinkXrefRow(
		//      termin.TerminUID,
		//      termin.FullName,
		//      this.UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Mitarbeiter").UID,
		//      ModelManager.SharedItemsService.GetLinkTypeByName("Besuchstermin").UID,
		//      ModelManager.UserService.CurrentUser.UID);

		//    // 3. Das Datum des Termins ggf. als letzten oder nächsten Besuchstermin für diesen Kunden festlegen.
		//    kunde.TermindatenAktualisieren(termin.StartDate);

		//    return true;
		//  }
		//  catch (System.Data.ConstraintException) { return false; }
		//  catch (Exception ex) { throw ex; }
		//}

		/// <summary>
		/// Returns the complete path to the requested folder type for this user.
		/// </summary>
		/// <param name="folderType">An element of the Global.DavidFolderTypes enum.</param>
		/// <returns>This string containing the requested path.</returns>
		public string GetDavidArchivePath(Products.Common.Global.DavidArchiveTypes folderType)
		{
			switch (folderType)
			{
				case Global.DavidArchiveTypes.Adressen:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "address");

				case Global.DavidArchiveTypes.Aufgaben:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "todo");

				case Global.DavidArchiveTypes.Postausgang:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "out");

				case Global.DavidArchiveTypes.Posteingang:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "in");

				case Global.DavidArchiveTypes.Kalender:
					if (this.UserName.ToLower() == "urlaub")
					{
						return @"\\david\david\archive\group\urlaub";
					}
					else return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "cal");

				case Global.DavidArchiveTypes.Kalenderarchiv:
					return Path.Combine(GetDavidArchivePath(Common.Global.DavidArchiveTypes.Kalender), myBase.DavidCalArchive);

				case Global.DavidArchiveTypes.Wiedervorlagen:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "$remind$");

				default:
					return Path.Combine(Common.Global.DavidArchivePath, myBase.UserFolderDavid, "in");

			}
		}

		#endregion

		#region event handler

		private void OnReminderChanged(object sender, EventArgs e)
		{
			this.ResetScheduler();
		}

		#endregion

		#region private procedures

		private void InitCalendarSettings()
		{
			if (this.LoginWindows.ToLower() == "tanja" || this.LoginWindows.ToLower() == "markus")
			{
				this.CalendarSettings
					.SetAddCustomerAddress(true)
					.SetAddCustomerInfo(true)
					.SetAddCustomerNotes(true)
					.SetAddCustomerPriceList(true)
					.SetCreateServiceReport(false);
			}
			else
			{
				this.CalendarSettings
					.SetAddCustomerAddress(true)
					.SetAddCustomerInfo(true)
					.SetAddCustomerNotes(false)
					.SetAddCustomerPriceList(false)
					.SetCreateServiceReport(true);
			}
		}

		private void ResetScheduler()
		{
			// MACHEN: In der Regel wird die ResetScheduler Routine aufgerufen, wenn einem Task
			// ein Reminder hinzugefügt oder ein vorhandener geändert bzw. gelöscht wird.
			// Wir müssen den Scheduler darüber informieren, damit dessen interne Jobliste 
			// mit den vorhandenen Remindern übereinstimmt.
			throw new NotImplementedException();
		}

		#endregion

	}
}
