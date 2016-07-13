using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsContactsTableAdapters;

namespace Products.Data.Services
{
	public class ContactDataService
	{

		#region members

		string myCurrentUserPK;

		readonly dsContacts myDS = new dsContacts();
		readonly taKundenkontakt myKundenkontaktAdapter = new taKundenkontakt();
		readonly taKundenkontaktListe myKundenkontaktListeAdapter = new taKundenkontaktListe();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ContactDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public ContactDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt alle KundenkontaktRows für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kundenNr"></param>
		/// <returns></returns>
		public IEnumerable<dsContacts.KundenkontaktRow> GetKundenkontaktRows(string kundenNr)
		{
			return this.myDS.Kundenkontakt.Where(k => k.Kundennummer == kundenNr);
		}

		/// <summary>
		/// Gibt eine schreibgeschützte Liste von Kundenkontakten zurück.
		/// </summary>
		/// <returns></returns>
		public dsContacts.KundenkontaktListeDataTable GetKundenkontaktListe()
		{
			return this.myKundenkontaktListeAdapter.GetData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.myKundenkontaktAdapter.Fill(this.myDS.Kundenkontakt);
		}

		#endregion

	}
}
