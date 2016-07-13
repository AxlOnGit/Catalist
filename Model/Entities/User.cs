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

		readonly dsUser.UserRow myBase;
		SBList<Reminder> myReminderList;
		CalendarSettings myCalendarSettings;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Mitarbeiter").UID; }
		}

		public string ItemName
		{
			get { return myBase.UserName; }
		}

		public string LinkTypBezeichnung
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
				var nameArray = myBase.UserName.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
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
				var nameArray = myBase.UserName.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
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
				var rgb = this.myBase.AppointmentColor.Split(new char[] { ',' });

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
				this.myBase.AppointmentColor = string.Join(",", new string[] { value.R.ToString(), value.G.ToString(), value.B.ToString() });
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

		#endregion

	}
}
