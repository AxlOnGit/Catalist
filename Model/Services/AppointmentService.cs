using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using David;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class AppointmentService
	{
		#region MEMBERS

		private readonly string myCurrentUserPK;
		private readonly Dictionary<string, SortableBindingList<Appointment>> myAppointmentDictionary = new Dictionary<string, SortableBindingList<Appointment>>();
		private readonly Dictionary<string, SortableBindingList<ILinkedItem>> myLinkedItemsDictionary = new Dictionary<string, SortableBindingList<ILinkedItem>>();

		private SortableBindingList<AppointmentType> myAppointmentTypeList;

		private SortableBindingList<string> myLocationList;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der AppointmentService Klasse.
		/// </summary>
		/// <param name="currentUserPK"></param>
		public AppointmentService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;

			// Die Termine aller Mitarbeiter laden.
			this.InitAppointmentLists();
			if (DavidManager.DavidService.WithAppointmentListener)
			{
				DavidManager.DavidService.NewAppointmentMailEvent += DavidService_NewAppointmentMailEvent;
			}
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		// Wird vom DavidService ausgelöst, wenn eine neue automatische
		// Terminerstellungsanfrage eingeht.
		private void DavidService_NewAppointmentMailEvent(object sender, David.API.ItemNotificationEventArgs e)
		{
			if (e.MsgItems2.GetCount() > 0)
			{
				var parser = new AppointmentMailParser(e.MsgItems2.GetItem(0));
				var parseResult = parser.Parse();
				if (parseResult.Sender != null && parseResult.Kunde != null)
				{
					var termin = this.CreateAppointment(parseResult.Sender, parseResult.Start, parseResult.End, parseResult.Category);
					if (termin != null)
					{
						// Verknüpfung zum Kunden hinzufügen.
						this.AddLinkedItemToAppointment(termin, parseResult.Kunde.CustomerId, "Kunde");
						// Verknüpfung zum Hauptkontakt des Kunden hinzufügen.
						if (parseResult.Kunde.Hauptkontakt != null)
						{
							this.AddLinkedItemToAppointment(termin, parseResult.Kunde.Hauptkontakt.Key, "Kundenkontakt");
						}
						termin.Subject = string.Format("{0}: {1}", parseResult.Kunde.Matchcode, parseResult.Category);
						termin.Location = string.Format("{0}, {1} {2}", parseResult.Kunde.Street, parseResult.Kunde.ZipCode, parseResult.Kunde.City);

						// Termintext einfügen
						var body = string.Format("<p>{0}</p>", parseResult.MessageBody);
						termin.BodyHtml = body;
						termin.BodyHtml += parseResult.Kunde.GetCustomerInfoHtml(parseResult.Kunde.Hauptkontakt);
						termin.BodyHtml += parseResult.Kunde.GetNotesHtml();
						termin.BodyHtml += parseResult.Kunde.GetSpecialPriceListHtml();
						termin.Update();
					}
				}
				else
				{
					// Entweder der Absender oder der Kunde konnten nicht ermittelt werden
					// Wir schreiben dem Absender eine entsprechende E-Mail
					var to = parseResult.Sender.EmailWork;
					var msgText = string.Format("Der Fehler steckt in dieser Betreffzeile: '{0}'", parseResult.Subject);
					var bcc = new List<string>();
					bcc.Add("a.ullrich@cutprint.de");
					var mail = ModelManager.PostBuedel.CreateMailMessage(to, "Fehler beim Erstellen eines Termins", msgText, null, null, bcc);
					ModelManager.PostBuedel.SendEmail(mail);
				}
			}
		}

		#endregion EVENT HANDLER

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Erstellt einen neuen Termin für den angegebenen Benutzer.
		/// </summary>
		/// <param name="forUser"></param>
		/// <returns></returns>
		public Appointment CreateAppointment(User forUser, DateTime startsAt, DateTime endsAt, string appointmentTypePK)
		{
			// var davidAppointment = DavidManager.DavidService.CreateCalendarItem(startsAt, endsAt, forUser.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender));
			var calCreateParams = DavidManager.MessageItem2Creator.CreateCalendarItem(startsAt, endsAt, forUser.UID, forUser.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender));
			var xRow = DataManager.AppointmentDataService.AddAppointmentXref(calCreateParams.Filename, appointmentTypePK);
			//var linkList = new SBList<ILinkedItem>();
			//this.myLinkedItemsDictionary.Add(calCreateParams.Filename, linkList);
			var newAppointment = new Appointment(calCreateParams.MessageItem2Object, xRow);
			this.GetAppointmentList(forUser).Add(newAppointment);

			return newAppointment;
		}

		/// <summary>
		/// Gibt den Kalendereintrag zum angegebenen Dateinamen auf dem David-Server zurück.
		/// </summary>
		/// <param name="fullName"></param>
		/// <returns></returns>
		public Appointment GetAppointment(string fullName)
		{
			// Den Benutzer ermitteln
			var user = ModelManager.UserService.GetUser(fullName, UserService.UserSearchParamType.DavidFileName);
			if (user != null)
			{
				return this.GetAppointmentList(user).FirstOrDefault(a => a.FullName == fullName);
			}
			return null;
		}

		/// <summary>
		/// Gibt die Liste der Kalendereinträge für den angegebenen User zurück.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public SortableBindingList<Appointment> GetAppointmentList(User user)
		{
			try
			{
				if (!this.myAppointmentDictionary.ContainsKey(user.UID)) this.LoadAppointmentList(user);
				return this.myAppointmentDictionary[user.UID];
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Gibt eine Liste von Terminen zurück, mit denen das angegebene ILinkedItem
		/// verknüpft ist.
		/// </summary>
		/// <param name="linkedItem">Das verknüpfte <seealso cref="ILinkedItem"/></param>
		/// .
		/// <returns></returns>
		public SortableBindingList<Appointment> GetAppointmentList(ILinkedItem linkedItem)
		{
			var list = new SortableBindingList<Appointment>();
			foreach (var terminListe in this.myAppointmentDictionary)
			{
				list.AddRange(terminListe.Value.Where(a => a.GetLinkedItemsList().Contains(linkedItem)));
			}
			return list;
		}

		/// <summary>
		/// Fügt dem angegebenen Termin eine Verknüpfung zu dem angegebenen LinkedItem hinzu.
		/// </summary>
		/// <param name="appointment"></param>
		/// <param name="linkedItemPK"></param>
		/// <param name="linkedItemType"></param>
		/// <returns>Die Instanz des verknüpften ILinkedItem Objekts.</returns>
		public ILinkedItem AddLinkedItemToAppointment(Appointment appointment, string linkedItemPK, string linkedItemType)
		{
			var typeUid = ModelManager.SharedItemsService.GetLinkTypeByName(linkedItemType).UID;
			DataManager.AppointmentDataService.AddLinkXrefRow(appointment.FullName, linkedItemPK, typeUid);

			switch (linkedItemType)
			{
				case "Kunde":
				var kunde = ModelManager.CustomerService.GetKunde(linkedItemPK, false);
				if (!this.GetLinkedItemsList(appointment).Contains(kunde as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(kunde);
				}
				return kunde;

				case "Kundenkontakt":
				var contact = ModelManager.ContactService.GetKundenkontakt(linkedItemPK);
				if (!this.GetLinkedItemsList(appointment).Contains(contact as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(contact);
				}
				return contact;

				case "Kundenmaschine":
				var machine = RepoManager.KundenmaschinenRepository.GetKundenmaschine(linkedItemPK);
				if (!this.GetLinkedItemsList(appointment).Contains(machine as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(machine);
				}
				return machine;

				case "Lieferant":
				var supplier = ModelManager.SupplierService.GetSupplier(linkedItemPK);
				if (!this.GetLinkedItemsList(appointment).Contains(supplier as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(supplier);
				}
				return supplier;

				case "Mitarbeiter":
				var user = ModelManager.UserService.GetUser(linkedItemPK, UserService.UserSearchParamType.PrimaryKey);
				if (!this.GetLinkedItemsList(appointment).Contains(user as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(user);
				}
				return user;

				case "Datei":
				var fi = new FileInfo(linkedItemPK);
				var calendarFileLink = new CalendarFileLink(fi);
				if (!this.GetLinkedItemsList(appointment).Contains(calendarFileLink as ILinkedItem))
				{
					this.GetLinkedItemsList(appointment).Add(calendarFileLink);
				}
				return calendarFileLink;
			}
			return null;
		}

		/// <summary>
		/// Löscht den angegebenen Kalendereintrag einschließlich aller Verknüpfungen.
		/// </summary>
		/// <param name="appointment">Das zu löschende <seealso cref="Appointment"/>.</param>
		public void DeleteAppointment(Appointment appointment)
		{
			// Verknüpfungen löschen, wenn es welche gibt.
			var list = appointment.GetLinkedItemsList();
			if (list != null)
			{
				for (int i = list.Count - 1; i > -1; i--)
				{
					this.RemoveLinkedItemFromAppointment(appointment, list[i]);
				}
			}

			// David Kalendereintrag löschen
			DavidManager.DavidService.DeleteCalendarItem(appointment.FullName);

			// Eintrag aus der Appointment Liste entfernen
			this.GetAppointmentList(appointment.Responsible).Remove(appointment);
		}

		/// <summary>
		/// Entfernt die ausgewählte Verknüpfung vom angegebenen Termin.
		/// </summary>
		/// <param name="appointment"></param>
		/// <param name="linkedItem"></param>
		public void RemoveLinkedItemFromAppointment(Appointment appointment, ILinkedItem linkedItem)
		{
			this.GetLinkedItemsList(appointment).Remove(linkedItem);
			DataManager.AppointmentDataService.RemoveLinkedItem(fullName: appointment.FullName, linkedItemPK: linkedItem.Key);
		}

		/// <summary>
		/// Gibt eine Liste aller mit dem angegebenen Kalendereintrag verknüpften Elemente
		/// zurück oder Null, falls keine verknüpften Elemente existieren.
		/// </summary>
		/// <param name="appointment">
		/// Der Kalendereintrag, für den die verknüpften Elemente gesucht werden.
		/// </param>
		/// <returns>Eine <seealso cref="SBList{ILinkedItem}"/> Instanz.</returns>
		public SortableBindingList<ILinkedItem> GetLinkedItemsList(Appointment appointment)
		{
			if (!this.myLinkedItemsDictionary.ContainsKey(appointment.FullName))
			{
				var list = new SortableBindingList<ILinkedItem>();
				var linkXrefs = DataManager.AppointmentDataService.GetLinkXrefRowsForAppointment(appointment.FullName);
				foreach (var xRef in linkXrefs)
				{
					var type = ModelManager.SharedItemsService.GetLinkTypeByPK(xRef.LinkedItemTypeId);
					switch (type.Bezeichnung)
					{
						case "Kunde":
						var kunde = ModelManager.CustomerService.GetKunde(xRef.LinkedItemId, false);
						if (kunde != null) list.Add(kunde);
						break;

						case "Kundenkontakt":
						var contact = ModelManager.ContactService.GetKundenkontakt(xRef.LinkedItemId);
						if (contact != null) { list.Add(contact); }
						break;

						case "Kundenmaschine":
						var kundenmaschine = RepoManager.KundenmaschinenRepository.GetKundenmaschine(xRef.LinkedItemId);
						if (kundenmaschine != null) { list.Add(kundenmaschine); }
						break;

						case "Mitarbeiter":
						var user = ModelManager.UserService.GetUser(xRef.LinkedItemId, UserService.UserSearchParamType.PrimaryKey);
						if (user != null) list.Add(user);
						break;

						case "Lieferant":
						var lieferant = ModelManager.SupplierService.GetSupplier(xRef.LinkedItemId);
						if (lieferant != null) list.Add(lieferant);
						break;

						case "Datei":
						var fileInfo = new FileInfo(xRef.LinkedItemId);
						if (fileInfo != null) list.Add(new CalendarFileLink(fileInfo));
						break;

						case "Interessent":
						//Machen: Interessenten komplett verarzten (InteressentenService etc ...)
						break;
					}
				}
				this.myLinkedItemsDictionary.Add(appointment.FullName, list);
			}
			return this.myLinkedItemsDictionary[appointment.FullName];
		}

		/// <summary>
		/// Verschiebt den angegebenen Termin zum angegebenen Benutzer.
		/// </summary>
		/// <param name="appointment"></param>
		/// <param name="toUser"></param>
		public void MoveAppointment(Appointment appointment, User toUser)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Terminarten zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<AppointmentType> GetAppointmentTypeList()
		{
			if (this.myAppointmentTypeList == null)
			{
				this.myAppointmentTypeList = new SortableBindingList<AppointmentType>();
				foreach (var tRow in DataManager.AppointmentDataService.GetAppointmentTypeTable())
				{
					var appointmentType = new AppointmentType(tRow);
					this.myAppointmentTypeList.Add(appointmentType);
				}
			}
			return this.myAppointmentTypeList;
		}

		/// <summary>
		/// Gibt eine Liste von Orten zurück, an denen Termine stattfinden können.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<string> GetLocationList()
		{
			if (this.myLocationList == null)
			{
				this.myLocationList = new SortableBindingList<string>();
				foreach (var item in DataManager.AppointmentDataService.GetLocationTable())
				{
					this.myLocationList.Add(item.Name);
				}
				this.myLocationList.Sort("Name");
			}
			return this.myLocationList;
		}

		/// <summary>
		/// Löscht alle Einträge in Tabelle AppointmentLinkXRef, für die es keinen gültigen
		/// Termin in David gibt.
		/// </summary>
		public int CleanAppointmentLinkXRefs()
		{
			var counter = 0;
			foreach (var xRow in DataManager.AppointmentDataService.GetAppointmentLinkXrefTable())
			{
				var fullName = xRow.FullName;
				if (!File.Exists(fullName))
				{
					counter += DataManager.AppointmentDataService.DeleteAppointmentLinkXRefs(fullName);
				}
			}
			return counter;
		}

		public void RefreshAppointmentList()
		{
			this.myAppointmentDictionary.Clear();
			this.InitAppointmentLists();
		}

		#region WARTUNGSTERMINE

		/// <summary>
		/// Gibt eine sortierbare Liste aller Wartungs- und Servicetermine im System zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<Wartungstermin> GetWartungsliste(Kunde referenzKunde = null)
		{
			var list = new SortableBindingList<Wartungstermin>();
			foreach (var item in DataManager.AppointmentDataService.GetWartungsterminTable())
			{
				list.Add(new Wartungstermin(item, referenzKunde));
			}
			return list;
		}

		#endregion WARTUNGSTERMINE

		/// <summary>
		/// Aktualisiert den David Kalendereintrag
		/// </summary>
		public int Update() => DataManager.AppointmentDataService.Update();

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		void LoadAppointmentList(User user)
		{
			if (user == null) return;
			var list = new SortableBindingList<Appointment>();
			try
			{
				//var monthsBack = -12; // Termine, die 'monthsBack' Monate zurückliegen, laden.
				//var items = DavidManager.DavidService.GetCalendarItems(user.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender), DateTime.Today.AddMonths(monthsBack), DateTime.Today.AddYears(1));

				var items = DavidManager.DavidTerminRepo.GetMessageItem2List(user.UID, user.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender));
				foreach (var msgItem2 in items)
				{
					var fileName = (string)DavidManager.DavidService.GetFieldValue(msgItem2, DavidFieldsEnum.FileName);
					fileName = (fileName.EndsWith(".001", StringComparison.CurrentCulture)) ? fileName : string.Format("{0}.001", fileName);

					var xRow = DataManager.AppointmentDataService.GetXrefRow(fileName);

					var xrefList = new List<ILinkedItem>();
					foreach (var xLinkRow in DataManager.AppointmentDataService.GetLinkXrefRowsForAppointment(fileName))
					{
						var linkedItem = this.GetLinkedItem(xLinkRow);
						xrefList.Add(linkedItem);
					}
					list.Add(new Appointment(msgItem2, xRow));
				}
				this.myAppointmentDictionary.Add(user.UID, list);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		ILinkedItem GetLinkedItem(dsAppointments.AppointmentLinkXrefRow xLinkRow)
		{
			var typ = ModelManager.SharedItemsService.GetLinkTypeByPK(xLinkRow.LinkedItemTypeId);
			if (typ != null)
			{
				switch (typ.Bezeichnung)
				{
					case "Kunde":
					return ModelManager.CustomerService.GetKunde(xLinkRow.LinkedItemId, false);

					case "Kundenkontakt":
					return ModelManager.ContactService.GetKundenkontakt(xLinkRow.LinkedItemId);

					case "Kundenmaschine":
					return RepoManager.KundenmaschinenRepository.GetKundenmaschine(xLinkRow.LinkedItemId);

					case "Lieferant":
					return ModelManager.SupplierService.GetSupplier(xLinkRow.LinkedItemId);

					case "Lieferantenkontakt":
					return ModelManager.SupplierService.GetLieferantenKontakt(xLinkRow.LinkedItemId.Substring(0, 10), xLinkRow.LinkedItemId.Substring(11, 5));

					case "Mitarbeiter":
					return ModelManager.UserService.GetUser(xLinkRow.LinkedItemId, UserService.UserSearchParamType.PrimaryKey);

					default:
					return null;
				}
			}
			return null;
		}

		void InitAppointmentLists()
		{
			this.TestLoadDavidCalendarItems();
			var currentUser = ModelManager.UserService.GetUser(ModelManager.CurrentUserPK, UserService.UserSearchParamType.PrimaryKey);
			if (currentUser != null)
			{
				foreach (var user in currentUser.CalendarSettings.PreloadUserList)
				{
					this.LoadAppointmentList(user);
				}
			}
		}

		void TestLoadDavidCalendarItems()
		{
			foreach (var user in ModelManager.UserService.GetActiveUsersList())
			{
				DavidManager.DavidTerminRepo.GetMessageItem2List(user.UID, user.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender));
			}
		}

		#endregion PRIVATE PROCEDURES
	}

	public class AppointmentMailParser
	{
		#region MEMBERS

		private readonly DvApi32.MessageItem2 myMsgItem2;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AppointmentMailParser"/> Klasse.
		/// </summary>
		/// <param name="msgItem2">
		/// Die zu analysierende <seealso cref="DvApi32.MessageItem2"/> Instanz.
		/// </param>
		public AppointmentMailParser(DvApi32.MessageItem2 msgItem2)
		{
			this.myMsgItem2 = msgItem2;
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		public AppointmentMailParseResult Parse()
		{
			var result = new AppointmentMailParseResult();

			var from = (string)DavidManager.DavidService.GetFieldValue(this.myMsgItem2, DavidFieldsEnum.From);
			result.Sender = ModelManager.UserService.GetUser(from, UserService.UserSearchParamType.EmailAddressWork);

			var subject = (string)DavidManager.DavidService.GetFieldValue(this.myMsgItem2, DavidFieldsEnum.Subject);

			result.Subject = subject;
			result.Kunde = null;
			result.Start = DateTime.Now;
			result.End = result.Start.AddHours(1);
			result.MessageBody = "";

			var subjectArray = subject.Split(new char[] { ';' });

			// Kunden ermitteln
			if (subjectArray.Length > 0)
			{
				var kundeRaw = subjectArray[0].Replace(".", "").Replace(",", "");
				if (kundeRaw.Length > 5) kundeRaw = kundeRaw.Remove(5);
				var kundenNr = string.Format("{0}00000", kundeRaw);
				var kunde = ModelManager.CustomerService.GetKunde(kundenNr, false);
				if (kunde != null) result.Kunde = kunde;
			}

			// Terminbeginn ermitteln
			if (subjectArray.Length > 1)
			{
				var startString = subjectArray[1];
				DateTime start;
				var parseResult = DateTime.TryParse(startString, out start);
				if (parseResult) result.Start = start;
			}

			// Terminende ermitteln
			if (subjectArray.Length > 2)
			{
				var endString = subjectArray[2];
				DateTime end = DateTime.MinValue;
				var parseResult = DateTime.TryParse(endString, out end);
				if (parseResult)
				{
					result.End = end;
				}
			}

			if (subjectArray.Length > 3)
			{
				var category = subjectArray[3].ToLower().Trim();
				if (category.Contains("angebot")) result.Category = "Angebot";
				else if (category.Contains("demo")) result.Category = "Demo";
				else if (category.Contains("besuch")) result.Category = "Kundenbesuch";
				else if (category.Contains("lieferung")) result.Category = "Maschinenlieferung";
				else if (category.Contains("abholung")) result.Category = "Maschinenabholung";
				else if (category.Contains("privat")) result.Category = "Privat";
				else if (category.Contains("reklamation")) result.Category = "Reklamation";
				else if (category.Contains("service")) result.Category = "Servicetermin";
				else if (category.Contains("telefon")) result.Category = "Telefonat";
				else if (category.Contains("wartung")) result.Category = "Wartungstermin";
				else result.Category = "Kundenbesuch";
			}
			else result.Category = "Kundenbesuch";

			var body = (string)DavidManager.DavidService.GetFieldValue(this.myMsgItem2, DavidFieldsEnum.Content);
			if (body.Length > 0)
			{
				result.MessageBody = body;
			}
			else result.MessageBody = "";

			return result;
		}

		#endregion PUBLIC PROCEDURES
	}

	public struct AppointmentMailParseResult
	{
		User mySender;
		DvApi32.Archive myCalendarArchive;
		string mySubject;
		Kunde myKunde;
		DateTime myStart;
		DateTime myEnd;
		string myCategory;
		string myMessageBody;

		#region PUBLIC PROPERTIES

		public User Sender { get { return this.mySender; } set { this.mySender = value; } }

		public DvApi32.Archive CalendarArchive { get { return this.myCalendarArchive; } set { this.myCalendarArchive = value; } }

		public string Subject { get { return this.mySubject; } set { this.mySubject = value; } }

		public Kunde Kunde { get { return this.myKunde; } set { this.myKunde = value; } }

		public DateTime Start { get { return this.myStart; } set { this.myStart = value; } }

		public DateTime End { get { return this.myEnd; } set { this.myEnd = value; } }

		public string Category { get { return this.myCategory; } set { this.myCategory = value; } }

		public string MessageBody { get { return this.myMessageBody; } set { this.myMessageBody = value; } }

		#endregion PUBLIC PROPERTIES
	}
}