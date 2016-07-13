using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using David;
using Products.Common.Interfaces;
using Products.Model.Entities;
using Products.Data.Datasets;
using Products.Data;
using System.IO;
using Products.Common.Collections;
using Products.Common;

namespace Products.Model.Services
{
	public class AppointmentService
	{

		#region members

		readonly string myCurrentUserPK = null;
		readonly Dictionary<string, SBList<Appointment>> myAppointmentDictionary = new Dictionary<string, SBList<Appointment>>();
		readonly Dictionary<string, SBList<ILinkedItem>> myLinkedItemsDictionary = new Dictionary<string, SBList<ILinkedItem>>();
		SortableBindingList<AppointmentType> myAppointmentTypeList;
		SBList<string> myLocationList;

		#endregion

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
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt einen neuen Termin für den angegebenen Benutzer.
		/// </summary>
		/// <param name="forUser"></param>
		/// <returns></returns>
		public Appointment AddAppointment(Model.Entities.User forUser, DateTime startsAt, DateTime endsAt, string appointmentTypePK, List<ILinkedItem> linkedItemsList)
		{
			var davidAppointment = DavidManager.DavidService.CreateCalendarItem(startsAt, endsAt, forUser.GetDavidArchivePath(Products.Common.Global.DavidArchiveTypes.Kalender));
			dsAppointments.AppointmentXrefRow xRow = DataManager.AppointmentDataService.AddAppointmentXref(fileName: davidAppointment.Filename, appointmentType: appointmentTypePK);
			SBList<ILinkedItem> linkList = new SBList<ILinkedItem>();
			this.myLinkedItemsDictionary.Add(davidAppointment.Filename, linkList);
			var newAppointment = new Appointment(davidAppointment.MessageItem2Object, xRow);
			this.GetAppointmentList(forUser).Add(newAppointment);

			return newAppointment;
		}

		/// <summary>
		/// Gibt die Liste der Kalendereinträge für den angegebenen User zurück.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public SBList<Appointment> GetAppointmentList(User user)
		{
			if (!this.myAppointmentDictionary.ContainsKey(user.UID)) this.LoadAppointmentList(user);
			return this.myAppointmentDictionary[user.UID];
		}

		public SBList<Appointment> GetAppointmentList(string linkedItemPK, string linkedItemTypePK, string appointmentType = null)
		{
			var linkType = ModelManager.SharedItemsService.GetLinkTypeByPK(linkedItemTypePK);
			ILinkedItem linkedItem = null;

			switch (linkType.Bezeichnung)
			{
				case "Kunde":
					linkedItem = ModelManager.CustomerService.GetKunde(linkedItemPK, false);
					break;

				case "Kundenkontakt":
					linkedItem = ModelManager.ContactService.GetKundenkontakt(linkedItemPK);
					break;

				case "Kundenmaschine":
					linkedItem = ModelManager.MachineService.GetKundenMaschine(linkedItemPK);
					break;

				default:
					break;
			}

			var list = new SBList<Appointment>();
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
			DataManager.AppointmentDataService.AddLinkXrefRow(fullName: appointment.FullName, linkedItemPK: linkedItemPK, linkedItemTypePK: typeUid);

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
					var machine = ModelManager.MachineService.GetKundenMaschine(linkedItemPK);
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

		private FileInfo GetCalendarFileLink(string linkedItemPK)
		{
			throw new NotImplementedException();
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
				for (int i = list.Count -1; i > -1; i--)
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
		/// Gibt eine Liste aller mit dem angegebenen Kalendereintrag verknüpften Elemente zurück oder Null, falls keine verknüpften Elemente existieren.
		/// </summary>
		/// <param name="appointment">Der Kalendereintrag, für den die verknüpften Elemente gesucht werden.</param>
		/// <returns>Eine <seealso cref=""/>System.Collections.Generic.List<ILinkedItem> Instanz.</returns>
		public SBList<ILinkedItem> GetLinkedItemsList(Appointment appointment)
		{
			if (!this.myLinkedItemsDictionary.ContainsKey(appointment.FullName))
			{
				var list = new SBList<ILinkedItem>();
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
							var kundenmaschine = ModelManager.MachineService.GetKundenMaschine(xRef.LinkedItemId);
							if (kundenmaschine != null) { list.Add(kundenmaschine); }
							break;

						case "Mitarbeiter":
							User user = ModelManager.UserService.GetUser(xRef.LinkedItemId, UserService.UserSearchParamType.PrimaryKey);
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
		public SBList<string> GetLocationList()
		{
			if (this.myLocationList == null)
			{
				this.myLocationList = new SBList<string>();
				foreach (var item in DataManager.AppointmentDataService.GetLocationTable())
				{
					this.myLocationList.Add(item.Name);
				}
				this.myLocationList.Sort("Name");
			}
			return this.myLocationList;
		}

		/// <summary>
		/// Aktualisiert den David Kalendereintrag
		/// </summary>
		public int Update()
		{
			return DataManager.AppointmentDataService.Update();
		}

		#endregion

		#region private procedures

		void LoadAppointmentList(User user)
		{
			SBList<Appointment> list = new SBList<Appointment>();
			foreach (DvApi32.MessageItem2 msgItem2 in DavidManager.DavidService.GetCalendarItems(user.GetDavidArchivePath(Products.Common.Global.DavidArchiveTypes.Kalender), DateTime.Today.AddMonths(-3), DateTime.Today.AddYears(1)))
			{
				var fileName = (string)David.DavidManager.DavidService.GetFieldValue(msgItem2, DavidFieldEnum.FileName);
				fileName = (fileName.EndsWith(".001")) ? fileName : string.Format("{0}.001", fileName);

				var xRow = DataManager.AppointmentDataService.GetXrefRow((string)fileName);

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

		ILinkedItem GetLinkedItem(dsAppointments.AppointmentLinkXrefRow xLinkRow)
		{
			Linktyp typ = ModelManager.SharedItemsService.GetLinkTypeByPK(xLinkRow.LinkedItemTypeId);
			if (typ != null)
			{
				switch (typ.Bezeichnung)
				{
					case "Kunde":
						return ModelManager.CustomerService.GetKunde(xLinkRow.LinkedItemId, false);
					case "Kundenkontakt":
						return ModelManager.ContactService.GetKundenkontakt(xLinkRow.LinkedItemId);
					case "Kundenmaschine":
						return ModelManager.MachineService.GetKundenMaschine(xLinkRow.LinkedItemId);
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
			foreach (var user in ModelManager.UserService.GetUserList())
			{
				this.LoadAppointmentList(user);
			}
		}

		#endregion

	}
}
