using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSalesTableAdapters;

namespace Products.Data.Services
{
	public class SalesDataService
	{

		#region members

		private string myCurrentUserPK = null;

		readonly dsSales myDS = new dsSales();
		readonly taSales mySalesAdapter = new taSales();
		readonly taOffenePosten myOffenePostenAdapter = new taOffenePosten();
		readonly taVersandkostenstaffel myVersandkostenAdapter = new taVersandkostenstaffel();
		readonly taSalesStats mySalesStatsAdapter = new taSalesStats();
		readonly taQueries myQueriesAdapter = new taQueries();

		readonly Dictionary<string, dsSales.SalesStatsDataTable> mySalesStatsDictionary = new Dictionary<string, dsSales.SalesStatsDataTable>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SalesDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public SalesDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die zusammengefassten Verkäufe pro Artikel des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public dsSales.SalesDataTable GetSalesTable(string customerPK)
		{
			return this.mySalesAdapter.GetData(customerPK);
		}

		/// <summary>
		/// Gibt die Versandkostentabelle zurück.
		/// </summary>
		/// <returns></returns>
		public dsSales.VersandkostenstaffelDataTable GetVersandkostenTable()
		{
			return this.myDS.Versandkostenstaffel;
		}

		/// <summary>
		/// Gibt die Versandkostenstaffel für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public dsSales.VersandkostenstaffelRow GetVersandkostenRow(string customerPK)
		{
			return this.GetVersandkostenTable().FirstOrDefault(v => v.Kundennummer == customerPK);
		}

		/// <summary>
		/// Gibt die Tabelle mit den unbezahlten Rechnungen zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public dsSales.OffenePostenDataTable GetOffenePostenTable(string customerPK)
		{
			return this.myOffenePostenAdapter.GetData(customerPK);
		}

		/// <summary>
		/// Gibt die Tabelle mit der Verkaufsstatistik für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer.</param>
		/// <returns></returns>
		public dsSales.SalesStatsDataTable GetSalesStatsTable(string customerPK)
		{
			if (!this.mySalesStatsDictionary.ContainsKey(customerPK))
			{
				this.mySalesStatsDictionary.Add(customerPK, this.mySalesStatsAdapter.GetData(customerPK));
			}
			return this.mySalesStatsDictionary[customerPK];
		}

		#region QUERIES

		/// <summary>
		/// Gibt die Nettosumme der Rechnungsbeträge des angegebenen Kunden für den angegebenen Zeitraum zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer</param>
		/// <param name="fromDate">Beginn des Zeitraums.</param>
		/// <param name="toDate">Ende des Zeitraums.</param>
		/// <returns></returns>
		public decimal GetSalesTotals(string customerPK, DateTime fromDate, DateTime toDate)
		{
			var result = this.myQueriesAdapter.GetSalesTotal(customerPK, fromDate, toDate);
			return result ?? 0.0m;
		}

		#endregion

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.myVersandkostenAdapter.Fill(this.myDS.Versandkostenstaffel);
		}

		#endregion

	}
}
