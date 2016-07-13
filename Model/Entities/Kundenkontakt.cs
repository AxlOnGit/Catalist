using System;
using System.Linq;
using System.Reflection;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Kundenkontakt : ILinkedItem
	{

		#region members

		dsContacts.KundenkontaktRow myBase;
		SortableBindingList<dsSage.kontaktemailRow> contactMailList;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return string.Format("{0}{1}", this.myBase.Kundennummer, this.myBase.Nummer); }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Kundenkontakt").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return string.Format("{0} ({1})", myBase.Name, this.Kundennummer.Substring(0,5)); }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Kundenkontakt"; }
		}

		#endregion

		#region integrals

		/// <summary>
		/// Gibt den Primärschlüssel dieses Kontakts zurück, der sich aus der zusammengesetzten Zeichenfolge
		/// von Kundennummer und Kontaktnummer ergibt.
		/// </summary>
		/// <remarks>Z.B.: 100000000000001</remarks>
		public string PK { get { return string.Format("{0}{1}", myBase.Kundennummer, myBase.Nummer); } }

		public string Kundennummer { get { return myBase.Kundennummer; } }

		public string Nummer { get { return myBase.Nummer; } }

		public string Kontaktname { get { return myBase.Name; } }

		public string Abteilung { get { return myBase.Abteilung; } }

		public string Telefon { get { return myBase.Telefon.Trim(); } }

		public string Telefax { get { return myBase.Telefax.Trim(); } }

		public string Handy { get { return myBase.Handy.Trim(); } }

		public string E_Mail { get { return myBase.E_Mail; } }

		public string Infofeld { get { return myBase.Infofeld; } }

		/// <summary>
		/// Gibt true zurück, wenn der Kontakt einen Webshop Account hat.
		/// </summary>
		public bool Webshopkunde
		{
			get
			{
				return !string.IsNullOrEmpty(myBase.Infofeld);
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn der Kontakt Infopost per E-Mail erhalten möchte.
		/// </summary>
		public bool InfoPerEmail 
		{ 
			get 
			{
				if (string.IsNullOrEmpty(myBase.Auswertungskennzeichen))
				{
					return false;
				}
				int dec = Convert.ToInt32(Convert.ToInt32(myBase.Auswertungskennzeichen, 2));
				return (dec & (int)Common.Global.SendInfoTypes.SendEmail) == (int)Global.SendInfoTypes.SendEmail;
			} 
		}

		public bool InfoPerFax
		{
			get
			{
				if (string.IsNullOrEmpty(myBase.Auswertungskennzeichen))
				{
					return false;
				}
				int dec = Convert.ToInt32(Convert.ToInt32(myBase.Auswertungskennzeichen, 2));
				return (dec & (int)Common.Global.SendInfoTypes.SendFax) == (int)Global.SendInfoTypes.SendFax;
			}
		}

		public bool InfoPerBrief
		{
			get
			{
				if (string.IsNullOrEmpty(myBase.Auswertungskennzeichen))
				{
					return false;
				}
				int dec = Convert.ToInt32(Convert.ToInt32(myBase.Auswertungskennzeichen, 2));
				return (dec & (int)Common.Global.SendInfoTypes.SendLetter) == (int)Global.SendInfoTypes.SendLetter;
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn dies der Hauptansprechpartner ist.
		/// </summary>
		public bool MainContactFlag
		{
			get
			{
				if (myBase.HauptansprechpartnerKz == "1")
				{
					return true;
				}
				return false;
			}
		}

		public SortableBindingList<dsSage.kontaktemailRow> ContactMailList()
		{
			if (contactMailList == null)
			{
				contactMailList = new SortableBindingList<dsSage.kontaktemailRow>();
				foreach (dsSage.kontaktemailRow mailRow in DataManager.AllDataService.GetContactTabelle().Where(m => m.Konto == myBase.Kundennummer & m.AnsprechpartnernummerZumKonto == myBase.Nummer))
				{
					contactMailList.Add(mailRow);
				}
			}
			return contactMailList;
		}

		#endregion

		#region entities

		/// <summary>
		/// Returns the parent customer instance for this contact.
		/// </summary>
		Kunde Customer 
		{
			get
			{
				return ModelManager.CustomerService.GetKunde(myBase.Kundennummer, true);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerContact class.
		/// </summary>
		/// <param name="baseRow"></param>
		public Kundenkontakt(dsContacts.KundenkontaktRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Sets the email flag for all of the customer's contacts to 0. There can only be one ...
		/// </summary>
		/// <param name="emailField"></param>
		public void MakeUniqueEmailRecipient(string emailField)
		{
			foreach (Kundenkontakt contact in this.Customer.Kontaktlist)
			{
				if (!contact.Equals(this))
				{
					Type contactType = contact.GetType();
					foreach (PropertyInfo prop in contactType.GetProperties())
					{
						if (prop.Name == emailField)
						{
							prop.SetValue(contact, 0, null);
						}
					}
				}
			}
		}

		/// <summary>
		/// Calls the contacts' landline number.
		/// </summary>
		public void CallPhone()
		{
			if (!string.IsNullOrEmpty(this.Telefon))
			{
				Agfeo.FonManager.FonService.MakeCall(this.Telefon);
			}
		}

		/// <summary>
		/// Calls the contacts mobile phone number.
		/// </summary>
		public void CallMobile()
		{
			if (!string.IsNullOrEmpty(this.Handy))
			{
				Agfeo.FonManager.FonService.MakeCall(this.Handy);
			}
		}

		#endregion

	}
}
