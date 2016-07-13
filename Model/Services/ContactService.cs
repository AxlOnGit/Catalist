using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;
using Products.Common.Collections;
using Products.Common;

namespace Products.Model.Services
{
	public class ContactService
	{

		#region members

		readonly Dictionary<string, SortableBindingList<Kundenkontakt>> myContactDictionary = new Dictionary<string, SortableBindingList<Kundenkontakt>>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public/internal procedures

		/// <summary>
		/// Gibt eine sortierbare Liste der Ansprechpartner des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public SortableBindingList<Kundenkontakt> GetContactListForCustomer(string customerPK)
		{
			if (!this.myContactDictionary.ContainsKey(customerPK))
			{
				var kunde = ModelManager.CustomerService.GetKunde(customerPK, false);
				if (kunde != null) this.AddKundenkontakte(customerPK);
			}
			return this.myContactDictionary[customerPK];
		}

		/// <summary>
		/// Gibt eine schreibgeschützte Liste mit Kundenkontakten zurück.
		/// </summary>
		/// <returns></returns>
		public dsContacts.KundenkontaktListeDataTable GetKundenkontaktListe()
		{
			return DataManager.ContactDataService.GetKundenkontaktListe();
		}
		
		internal Kundenkontakt GetCustomerContact(string contactPK)
		{
			string kundenPK = contactPK.Substring(0, 10);
			string kontaktPK = contactPK.Substring(10, 5);
			throw new NotImplementedException();
		}

		public void CallContact(Kundenkontakt contact)
		{
			Agfeo.FonManager.FonService.MakeCall(contact.Telefon);
		}

		/// <summary>
		/// Gibt den Kundenkontakt mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="contactPK">Der aus Kunden-Nr. und Kontaktnummer zusammengesetzte Primärschlüssel des Kundenkontakts.</param>
		/// <returns></returns>
		public Kundenkontakt GetKundenkontakt(string contactPK)
		{
			var kundenNr = contactPK.Substring(0, 10);
			var kontaktNr = contactPK.Substring(10, 5);
			return this.GetContactListForCustomer(kundenNr).FirstOrDefault(k => k.Nummer == kontaktNr);
		}

		private void AddKundenkontakte(string kundenNr)
		{
			var list = new SortableBindingList<Kundenkontakt>();
			foreach (var kRow in DataManager.ContactDataService.GetKundenkontaktRows(kundenNr))
			{
				var contact = new Kundenkontakt(kRow);
				list.Add(contact);
			}
			this.myContactDictionary.Add(kundenNr, list);
		}

		public Kundenkontakt GetKundenkontaktByFonNumber(string customerId, string theCallersId)
		{
			var contact = this.GetKundenkontaktListe().FirstOrDefault(c => c.Kundennummer == customerId && (c.Telefon.ToLower().Contains(theCallersId)) | c.Handy.ToLower().Contains(theCallersId));
			if (contact != null)
			{
				return this.GetKundenkontakt(string.Format("{0}{1}", customerId, contact.Nummer));
			}
			return null;
		}

		#endregion

		#region private procedures
		#endregion

	}
}
