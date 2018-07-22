using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using David.API;
using DvApi32;

namespace David
{
	#region public enums

	/// <summary>
	/// Auflistung der David Ordnertypen.
	/// </summary>
	public enum ArchiveType
	{
		Inbox,
		SentItems,
		Calender,
		Addresses,
		Tasks,
		Boilerplates,
		Reminder
	}

	/// <summary>
	/// Übersetzung von Feldindex zu lesbarem
	/// </summary>
	public enum DavidFieldsEnum
	{
		AllDayEvent = 79,
		CreatedAt = 7,
		Creator = 53,
		StopTime = 51,
		FileName = 58,
		To = 56,
		From = 57,
		LastChangedTime = 38,
		Location = 70,
		Content = 132,
		HTML = 104,
		Owner = 4,
		ReminderTime = 78,
		ShowAs = 83,
		SendTime = 8,
		Subject = 59
	}

	#endregion public enums

	public class DavidService
	{
		#region public events

		public event EventHandler<ItemNotificationEventArgs> NewAppointmentMailEvent;

		#endregion public events

		#region members

		IApplication myDavidApp = new DavidAPIClass();
		Account myAccount;
		ArchiveNotification myAutoAppointmentNotification;
		bool myConnected;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt FALSE zurück, wenn keine Verbindung zum DAVID Server besteht.
		/// </summary>
		public bool Connected => this.myConnected;

		public Account Account => this.myAccount;

		/// <summary>
		/// True, wenn die Anwendung mit dem Schalter "AppointmentListener" gestartet wurde.
		/// </summary>
		public bool WithAppointmentListener { get; }

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der PostService Klasse.
		/// </summary>
		public DavidService(bool withAppointmentListener)
		{
			try
			{
				myDavidApp.LoginOptions = DvLoginOptions.DvLoginForceAsyncDuplicate;
				myAccount = myDavidApp.Logon("", "", "", "", "", "AUTH");
				this.myConnected = true;
				this.WithAppointmentListener = withAppointmentListener;
			}
			catch (COMException)
			{
				this.myConnected = false;
				this.WithAppointmentListener = false;
			}
			// Wenn die Anwendung mit dem Schalter "AppointmentListener" gestartet wird, registrieren
			// wir die Notifications des DAVID-Ordners, in dem Terminanfragen eingehen
			// (Global.AppointmentArchivePath). Derzeit ist das der Ordner "\\david\david\archive\group\b".
			if (this.WithAppointmentListener)
			{
				var appointmentArchive = this.myAccount.GetArchive(CatalistRegistry.Application.AppointmentArchivePath);
				if (appointmentArchive != null)
				{
					this.myAutoAppointmentNotification = new ArchiveNotification();
					this.myAutoAppointmentNotification.ItemNewEvent += MyNotification_ItemNewEvent;
					this.myAutoAppointmentNotification.AddArchive(appointmentArchive);
				}
			}
		}

		// Wird ausgelöst, wenn auf dem DAVID Server eine neue Terminanforderung eintrifft.
		void MyNotification_ItemNewEvent(object sender, ItemNotificationEventArgs e)
		{
			this.NewAppointmentMailEvent?.Invoke(this, e);
		}

		#endregion ### .ctor ###

		#region public procedures

		/// <summary>
		/// Gibt eine Liste aller Termine aus dem angegebenen Archiv zurück.
		/// </summary>
		/// <param name="forArchive">
		/// Kompletter Pfad zum entsprechenden Archiv des Users. Z. B. "\\DAVID\David\Archive\USER\1003C010"
		/// </param>
		/// <param name="fromDate">Untere Grenze des Datumsbereichs.</param>
		/// <returns></returns>
		[HandleProcessCorruptedStateExceptions]
		public MessageItems2 GetCalendarItems(string forArchive, DateTime? fromDate = null, DateTime? toDate = null)
		{
			try
			{
				if (fromDate == null)
				{
					fromDate = DateTime.Today.AddMonths(-2);
				}
				if (toDate == null)
				{
					toDate = DateTime.Today.AddYears(1);
				}

				//string filter = string.Format("OnlyEMail StatusTime=\"{0} - 12-31-2200 23:59:59\"", fromDate.Value.ToString("M-d-yyyy H:m:s"));
				var calArchive = myAccount.GetArchive(forArchive);
				if (calArchive == null) throw new ApplicationException(string.Format("Der angegebene Kalenderordner '{0}' existiert nicht.", forArchive));
				//var filter = string.Format(@"OnlyEMail StatusTime=\"{0} - {1}\"", fromDate.Value.ToString("M-d-yyyy H:m:s"), toDate.Value.ToString("M-d-yyyy H:m:s"));
				var from = fromDate.Value.ToString("M-d-yyyy H:m:s");
				var to = toDate.Value.ToString("M-d-yyyy H:m:s");
				var filter = $"OnlyEMail StatusTime=\"{from} - {to}\"{char.MinValue}";
				var items = calArchive.GetArchiveEntries(filter);
				return items;
			}
			catch (AccessViolationException accEx)
			{
				throw new ApplicationException(string.Format("Auf diesen David Ordner kann ich nicht zugreifen: {0}", accEx.Message));
			}
			catch (Exception ex)
			{
				throw new ApplicationException(string.Format("Irgendetwas beim Zugriff auf die David Termine ist schief gelaufen: {0}", ex.Message));
			}
		}

		/// <summary>
		/// Gibt den mit dem angegebenen Dateinamen verknüpften Kalendereintrag des angegebenen
		/// Benutzers zurück.
		/// </summary>
		/// <param name="filename">Dateiname des Kalendereintrags.</param>
		/// <returns>Die Instanz eines DvApi32.MessageItem2 Objekts.</returns>
		public CalendarItem GetCalendarItem(string filename)
		{
			try
			{
				if (File.Exists(filename))
				{
					var archive = Path.GetDirectoryName(filename);
					var kalender = myAccount.GetArchive(archive);
					var mItem2 = kalender.GetArchiveEntryByID(filename);
					return kalender.ItemFromID(mItem2._ID, 34) as CalendarItem;
				}
				throw new FileNotFoundException("Der Kalendereintrag existiert in David nicht mehr.");
			}
			catch (COMException)
			{
				throw new FileNotFoundException("Der Kalendereintrag existiert in David nicht mehr.");
			}
		}

		/// <summary>
		/// Gibt den Kalendereintrag für den angegebenen Dateinamen als MessageItem2 Instanz zurück.
		/// </summary>
		/// <param name="filename">
		/// Vollständiger Pfad + Dateiname des Kalendereintrags im David Dateisystem.
		/// </param>
		/// <returns>Ein MessageItem2 Objekt.</returns>
		public MessageItem2 GetMessageItem2(string filename)
		{
			try
			{
				if (File.Exists(filename))
				{
					var archive = Path.GetDirectoryName(filename);
					var kalender = myAccount.GetArchive(archive);
					var mItem2 = kalender.GetArchiveEntryByID(filename);
					return mItem2;
				}
				throw new FileNotFoundException("Dieser Kalendereintrag existiert in David nicht mehr.");
			}
			catch (COMException)
			{
				throw new FileNotFoundException("Der Kalendereintrag existiert in David nicht mehr.");
			}
		}

		/// <summary>
		/// Gibt den Inhalt des angegebenen Felds für die angegebene MessageItem2 Instanz zurück.
		/// </summary>
		/// <param name="msgItem2">Die MessageItem2 Instanz.</param>
		/// <param name="field">Ein Element der <seealso cref="David.DavidFieldsEnum"/> Auflistung.</param>
		/// <returns></returns>
		public object GetFieldValue(MessageItem2 msgItem2, DavidFieldsEnum field)
		{
			var fields = msgItem2.Fields as Fields;
			if (fields != null)
			{
				return fields.Item(field).Value;
			}
			return null;
		}

		/// <summary>
		/// Erstellt einen neuen Termin für den derzeit angemeldeten Benutzer.
		/// </summary>
		/// <param name="start">Datum und Uhrzeit des Terminbeginns.</param>
		/// <param name="end">Datum und Uhrzeit des Terminendes.</param>
		/// <returns></returns>
		public MessageItem2CreationParams CreateCalendarItem(DateTime start, DateTime end, string inArchive)
		{
			var cal = myAccount.GetArchive(inArchive);
			var newItem2 = cal.CreateArchiveEntry(DvItemTypes.DvCalendarItem);
			var fields = (Fields)newItem2.Fields;

			newItem2.Subject = "Termin"; // Terminbezeichnung
			fields.Item(8).Value = start; // Terminbeginn
			fields.Item(51).Value = end; // Terminende
			fields.Item(132).Value = "Text"; // Text
			fields.Item(138).Value = "<p>Text</p>"; // HTML Text
			fields.Item(70).Value = "Terminort"; // Terminort
			fields.Item(78).Value = -1; // ReminderTime
			var uid = this.CreateGuidField(newItem2); // Benutzerdefiniertes Feld "GUID" erstellen und mit einem GUID füllen.
			newItem2.Save();
			var fileName = string.Format("{0}.001", ((Fields)newItem2.Fields).Item(58).Value);
			return new MessageItem2CreationParams(newItem2, fileName, uid);
		}

		/// <summary>
		/// Löscht den David Kalendereintrag für den angegebenen Dateinamen.
		/// </summary>
		/// <param name="msgItemFullName"></param>
		public void DeleteCalendarItem(string msgItemFullName)
		{
			var msgItem2 = this.GetMessageItem2(msgItemFullName);
			if (msgItem2 != null) msgItem2.Delete();
		}

		/// <summary>
		/// Speichert das mitgelieferte CalendarItem im Kalender des angemeldeten Benutzers.
		/// </summary>
		/// <param name="cItem"></param>
		public bool SaveCalendarItem(CalendarItem cItem, string filename)
		{
			try
			{
				var archiv = Path.GetDirectoryName(filename);
				var kalender = myAccount.GetArchive(archiv);
				var mItem2 = kalender.GetArchiveEntryByID(filename);
				var fields = (Fields)cItem.Fields;
				if (mItem2 != null)
				{
					var felder = (Fields)mItem2.Fields;
					felder.Item(8).Value = cItem.StartTime;
					felder.Item(51).Value = cItem.StopTime;
					felder.Item(132).Value = cItem.BodyText.PlainText;
					felder.Item(104).Value = cItem.BodyText.HTMLText;
					mItem2.Subject = cItem.Subject;
					mItem2.Save();
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Gibt eine Liste von FileInfo Instanzen mit allen Attachments des angegebenen David
		/// Archivs zurück.
		/// </summary>
		/// <param name="whatArchive"></param>
		/// <returns></returns>
		public List<FileInfo> GetAttachments(string whatArchive, string filter = "Subject Like %20160001183%")
		{
			// string filter = "default"
			var archive = this.myAccount.GetArchive(whatArchive);
			if (archive != null)
			{
				var list = new List<FileInfo>();
				var fileName = string.Empty;
				var fullName = string.Empty;
				foreach (var email in archive.GetArchiveEntries(filter))
				{
					if (email is MessageItem)
					{
						var msg = email as MessageItem;
						for (int i = 0; i < msg.Attachments.Count; i++)
						{
							try
							{
								var attachment = msg.Attachments.Item(i);
								fileName = attachment.FileName;
								fullName = Path.Combine(@"C:\Temp\Attachments", fileName);
								if (!File.Exists(fullName)) attachment.CopyOut(@"C:\Temp\Attachments");
								list.Add(new FileInfo(fullName));
							}
							catch (Exception ex)
							{
								var logEntry = string.Format("{0}{1}{2}", ex.Message, Environment.NewLine, fullName);
							}
						}
					}
				}
				return list;
			}
			return null;
		}

		public List<FileInfo> GetAttachmentList(string fullName)
		{
			var list = new List<FileInfo>();
			var fi = new FileInfo(fullName);
			if (fi.Exists)
			{
				var archive = this.myAccount.GetArchive(fi.DirectoryName);
				if (archive != null)
				{
					var mi2 = archive.GetArchiveEntryByID(fullName) as MessageItem2;
					if (mi2 != null)
					{
						for (int i = 0; i < mi2.Attachments.Count; i++)
						{
							var temp = Path.GetTempPath();
							var attachment = mi2.Attachments.Item(i);
							var fileName = attachment.FileName;
							var fileAndPath = Path.Combine(temp, fileName);
							if (!File.Exists(fileAndPath)) attachment.CopyOut(temp, fileName);
							list.Add(new FileInfo(fileAndPath));
						}
					}
				}
			}
			return list;
		}

		//public DvApi32.AddressItem GetCustomerAddress(string kundenNr)
		//{
		//  DvApi32.Archive kundenAdressen = myAccount.GetArchive(@"\\david\david\archive\address\kunden");
		//  foreach (var adresse in kundenAdressen.AddressBook)
		//  {
		//    DvApi32.Address addr = adresse as DvApi32.Address;
		//    DvApi32.AddressItem item = addr.AddressItem;
		//    if (item.SMSNumber.Substring(0, 5) == kundenNr.Substring(0,5))
		//    {
		//      item.DisplayName = "Die Bekloppten aus Hütte";
		//      item.Save();
		//    }
		//  }
		//  return null;
		//}

		public void Shutdown()
		{
			if (!this.myConnected) return;
			if (this.myAutoAppointmentNotification != null) this.myAutoAppointmentNotification.ClearAll(this.myAccount);
			this.myAccount.Logoff();
		}

		#endregion public procedures

		#region private procedures

		Guid CreateGuidField(MessageItem2 forMessageItem2)
		{
			var fields = (Fields)forMessageItem2.Fields;
			if (fields.UserFields.Count == 0)
			{
				var uid = Products.Common.SequentialGuid.NewID().ToString();
				var def = fields.UserFields.CreateDefinition("GUID", DvFieldType.DvFieldText);
				fields.UserFields.Add(def, uid);
				return Guid.Parse(uid);
			}
			return Guid.Empty;
		}

		#endregion private procedures
	}
}