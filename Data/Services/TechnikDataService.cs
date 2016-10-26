using System;
using Products.Common;
using Products.Data.Datasets;
using Products.Data.Datasets.dsTechnikTableAdapters;

namespace Products.Data.Services
{
	/// <summary>
	/// Verwaltet die Daten für den TechnikService.
	/// </summary>
	public class TechnikDataService
	{

		#region members

		readonly dsTechnik myDS = new dsTechnik();
		readonly taWartungstour myWartungstourAdapter = new taWartungstour();

		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die Tabelle mit allen Wartungstouren zurück.
		/// </summary>
		/// <returns></returns>
		public dsTechnik.WartungstourDataTable GetWartungstourTable()
		{
			return this.myDS.Wartungstour;
		}

		/// <summary>
		/// Erstellt eine neue Zeile in Tabelle Wartungstour.
		/// </summary>
		/// <param name="technikerPK">Primärschlüssel des Technikers (User) der neuen Wartungstour.</param>
		/// <param name="zipCode">Postleitzahl, die den Bereich der Tour markiert. Es werden die ersten 3 Stellen verwendet.</param>
		/// <returns></returns>
		public dsTechnik.WartungstourRow CreateWartungstourRow(string technikerPK, string zipCode, DateTime startsAt)
		{
			if (zipCode.Length < 3)
			{
				var msg = "Fehler in Prozedur 'TechnikDataService.CreateWartungstourRow'\nDer Parameter muss mindestens 3 Ziffern enthalten.";
				throw new ArgumentException(msg, nameof(zipCode));
			}
			var zip = zipCode.Substring(0, 3);
			var datum = string.Format("{0}/{1}", startsAt.ToString("MM"), startsAt.ToString("yyyy"));
			var bezeichnung = string.Format("Wartungstour <Region> - PLZ-Bereich {0} - {1}", zip, datum);

			var wRow = this.myDS.Wartungstour.NewWartungstourRow();
			wRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			wRow.Bezeichnung = bezeichnung;
			wRow.TechnikerId = technikerPK;

			this.myDS.Wartungstour.AddWartungstourRow(wRow);
			this.myWartungstourAdapter.Update(this.myDS.Wartungstour);
			return wRow;
		}

		#endregion

		#region private procedures
		#endregion

	}
}
