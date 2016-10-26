using System;
using System.Collections.Generic;
using System.Linq;
using Products.Data.Datasets;
using Products.Model.Entities;
using Products.Data;
using Products.Common.Collections;
using Products.Common;

namespace Products.Model.Services
{
	public class SalesService
	{

		#region members

		readonly Dictionary<string, SBList<Versandstaffelpreis>> myVersandkostenDictionary = new Dictionary<string, SBList<Versandstaffelpreis>>();
		readonly Dictionary<string, SBList<KundenMonatsumsatz>> mySalesStatsDictionary = new Dictionary<string, SBList<KundenMonatsumsatz>>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die zusammengefassten Verkäufe pro Artikel des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer</param>
		/// <returns></returns>
		public dsSales.SalesDataTable GetSalesTable(string customerPK)
		{
			return Data.DataManager.SalesDataService.GetSalesTable(customerPK);
		}

		/// <summary>
		/// Gibt die Nettosumme aller Rechnungen aus dem angegebenen Zeitraum für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <remarks>Die Rechnungsbeträge stammen aus der Tabelle 'opdebitoren'.</remarks>
		/// <returns></returns>
		public decimal GetSalesTotals(Kunde kunde, DateTime from, DateTime to)
		{
			return DataManager.SalesDataService.GetSalesTotals(kunde.CustomerId, from, to);
		}

		public SBList<Versandstaffelpreis> GetVersandstaffel(string customerPK)
		{
			if (!this.myVersandkostenDictionary.ContainsKey(customerPK))
			{
				var list = new SBList<Versandstaffelpreis>();
				var vRow = DataManager.SalesDataService.GetVersandkostenRow(customerPK);
				if (vRow != null)
				{

					if (vRow.AbWert1 > 0)
					{
						var p1 = new Versandstaffelpreis();
						p1.Kundennummer = customerPK;
						p1.AbWert = vRow.AbWert1;
						p1.Versandkosten = vRow.VKosten1;
						list.Add(p1);
					}
					if (vRow.AbWert2 > 0)
					{
						var p2 = new Versandstaffelpreis();
						p2.Kundennummer = customerPK;
						p2.AbWert = vRow.AbWert2;
						p2.Versandkosten = vRow.VKosten2;
						list.Add(p2);
					}
					if (vRow.AbWert3 > 0)
					{
						var p3 = new Versandstaffelpreis();
						p3.Kundennummer = customerPK;
						p3.AbWert = vRow.AbWert3;
						p3.Versandkosten = vRow.VKosten3;
						list.Add(p3);
					}
					if (vRow.AbWert4 > 0)
					{
						var p4 = new Versandstaffelpreis();
						p4.Kundennummer = customerPK;
						p4.AbWert = vRow.AbWert4;
						p4.Versandkosten = vRow.VKosten4;
						list.Add(p4);
					}
				}
				// Wir fügen die Liste auch hinzu, wenn sie leer ist.
				this.myVersandkostenDictionary.Add(customerPK, list);
			}
			return this.myVersandkostenDictionary[customerPK].Sort("AbWert");
		}

		/// <summary>
		/// Gibt den Gesamtbetrag der derzeit offenen Rechnungen zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public decimal GetOffenePostenTotal(Kunde kunde)
		{
			return DataManager.SalesDataService.GetOffenePostenTable(kunde.CustomerId).Sum(o => o.Saldo_InOP_Waehrung);
		}

		/// <summary>
		/// Gibt eine SalesStatsDataTable mit der Verkaufsstatistik für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Instanz des Kunden.</param>
		/// <returns></returns>
		public SBList<KundenMonatsumsatz> GetSalesStats(Kunde kunde)
		{
			if (!this.mySalesStatsDictionary.ContainsKey(kunde.CustomerId))
			{
				var sList = new SBList<KundenMonatsumsatz>();
				var sTable = DataManager.SalesDataService.GetSalesStatsTable(kunde.CustomerId);
				foreach (var sRow in sTable)
				{
					sList.Add(new KundenMonatsumsatz(sRow));
				}
				this.mySalesStatsDictionary.Add(kunde.CustomerId, sList);
			}
			return this.mySalesStatsDictionary[kunde.CustomerId];
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Angeboten im System zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Angebot> GetAngeboteSageList()
		{
			var list = new SBList<Angebot>();
			foreach (var aRow in DataManager.SalesDataService.GetAngebotSageTable())
			{
				list.Add(new Angebot(aRow));
			}
			return list;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Sage Angebote für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kundePK">10-stellige Kundennummer.</param>
		/// <returns></returns>
		public SBList<Angebot> GetAngeboteSageList(string kundePK)
		{
			var list = new SBList<Angebot>();
			foreach (var aRow in DataManager.SalesDataService.GetAngebotSageTable().Where(a => a.Kundennummer == kundePK))
			{
				list.Add(new Entities.Angebot(aRow));
			}
			return list;
		}

		public SortableBindingList<AngebotsDetail> GetAngebotsDetails(Angebot angebot)
		{
			var list = new SortableBindingList<AngebotsDetail>();
			var dRows = DataManager.SalesDataService.GetAngebotSagePositionRows(angebot.Nummer);
			foreach (var dRow in dRows)
			{
				var detail = new AngebotsDetail(dRow);
				if (detail != null && detail.Typ == "Artikel") list.Add(detail);
			}

			return list.Sort("Sequence");
		}

		#endregion

		#region private procedures
		#endregion

	}
}
