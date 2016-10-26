using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Data;
using Products.Model.Entities;

namespace Products.Model.Services
{
	/// <summary>
	/// Services für unsere fabelhaften Techniker.
	/// </summary>
	public class TechnikService
	{

		#region members

		readonly SortableBindingList<WartungsTour> myWartungstourList = new SortableBindingList<WartungsTour>();

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt eine neue Wartungstour.
		/// </summary>
		/// <param name="technikerPK">Primärschlüssel des Technikers/Users der neuen Wartungstour.</param>
		/// <param name="zipCode">Postleitzahl, die den Postleitzahlbereich definiert.</param>
		/// <param name="startsAt">Datum und Uhrzeit des ersten Termins.</param>
		/// <returns></returns>
		public WartungsTour CreateWartungstour(string technikerPK, string zipCode, DateTime startsAt)
		{
			var wRow = DataManager.TechnikDataService.CreateWartungstourRow(technikerPK, zipCode, startsAt);
			var tour = new WartungsTour(wRow);
			this.myWartungstourList.Add(tour);

			return tour;
		}

		/// <summary>
		/// Gibt die Liste mit allen Wartungstouren im System zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<WartungsTour> GetWartungsTourList()
		{
			return this.myWartungstourList;
		}

		/// <summary>
		/// Gibt eine Liste aller zukünftigen Wartungstouren zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<WartungsTour> GetNextWartungsTourList()
		{
			var filtered = this.myWartungstourList.Where(w => w.TourStart >= DateTime.Now);
			return new SortableBindingList<WartungsTour>(filtered);
		}

		#endregion

	}
}
