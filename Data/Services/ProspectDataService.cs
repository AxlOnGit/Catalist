using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsProspectsTableAdapters;
using Products.Common;

namespace Products.Data.Services
{
	public class ProspectDataService
	{

		#region members

		readonly string myCurrentUserPK;
		readonly dsProspects myProspectsDS = new dsProspects();
		bool myProspectsInitialized;

		#region Adapter

		readonly taInteressent myInteressentAdapter = new taInteressent();

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ProspectDataService Klasse.
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		/// </summary>
		public ProspectDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt der Tabelle Interessent eine neue Zeile hinzu.
		/// </summary>
		/// <param name="creatorPK">Primärschlüssel des erstellenden Mitarbeiters.</param>
		/// <returns></returns>
		public dsProspects.InteressentRow AddInteressentRow(string creatorPK)
		{
			dsProspects.InteressentRow iRow = this.myProspectsDS.Interessent.NewInteressentRow();
			iRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			iRow.Adresszusatz = "";
			iRow.AkquiseAm = DateTime.Today;
			iRow.AkquiseDurch = creatorPK;
			iRow.Anmerkungen = "";
			iRow.Email = "";
			iRow.Fax = "";
			iRow.Firmenname = "";
			iRow.Firmenzusatz = "";
			iRow.Herkunft = "";
			iRow.InaktivFlag = 0;
			iRow.Kontaktperson = "";
			iRow.Mobil = "";
			iRow.Ort = "";
			iRow.Plz = "";
			iRow.Strasse = "";
			iRow.Telefon = "";
			iRow.Website = "http://www";
			this.myProspectsDS.Interessent.AddInteressentRow(iRow);
			this.UpdateInteressent(iRow);

			return iRow;
		}

		/// <summary>
		/// Gibt die Tabelle Interessent des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsProspects.InteressentDataTable GetInteressentenTable()
		{
			this.AssureInteressentInitialized();
			return this.myProspectsDS.Interessent;
		}

		/// <summary>
		/// Speichert die Änderungen an der angegebenen InteressentRow oder der gesamten Tabelle, falls keine InteressentRow übergeben wurde.
		/// </summary>
		/// <param name="interessentRow"></param>
		/// <returns></returns>
		public int UpdateInteressent(dsProspects.InteressentRow interessentRow = null)
		{
			if (interessentRow != null)
			{
				return this.myInteressentAdapter.Update(interessentRow);
			}
			return this.myInteressentAdapter.Update(this.myProspectsDS.Interessent);
		}

		#endregion

		#region private procedures

		void AssureInteressentInitialized()
		{
			if (this.myProspectsInitialized) return;
			this.myInteressentAdapter.Fill(this.myProspectsDS.Interessent);
			this.myProspectsInitialized = true;
		}

		#endregion

	}
}
