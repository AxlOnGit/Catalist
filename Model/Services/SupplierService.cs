using System;
using System.Collections.Generic;
using System.Linq;
using Products.Model.Entities;
using Products.Data;
using Products.Data.Datasets;
using Products.Common.Collections;

namespace Products.Model.Services
{
	public class SupplierService
	{

		#region members

		SBList<Lieferant> mySupplierList;
		SBList<LieferantenRabatt> myRabattList;

		//SBList<Bestellung> myBestellungList;
		//SBList<BestellDetail> myBestellDetailList = null;
		//SBList<Bestellung> myLieferungList = null;
		//SBList<BestellDetail> myLieferungDetailList = null;
		//SBList<Bestellung> myRechnungList = null;

		readonly Dictionary<string, SBList<Bestellung>> myBestellungDictionary = new Dictionary<string, SBList<Bestellung>>();
		readonly Dictionary<string, SBList<BestellDetail>> myBestellDetailDictionary = new Dictionary<string, SBList<BestellDetail>>();
		readonly Dictionary<string, SBList<LieferantenKontakt>> myKontaktDictionary = new Dictionary<string, SBList<LieferantenKontakt>>();

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine sortierbare Liste aller Lieferanten des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Lieferant> GetSupplierList()
		{
			if (this.mySupplierList == null)
			{
				this.mySupplierList = new SBList<Lieferant>();
				var tempList = new List<Lieferant>();
				foreach (var lRow in DataManager.SupplierDataService.GetLieferantTable().Where(l => l.Name1.Length > 0))
				{
					this.mySupplierList.Add(new Lieferant(lRow));
				}
			}
			return this.mySupplierList;
		}

		/// <summary>
		/// Gibt den Lieferanten mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="supplierPK"></param>
		/// <returns></returns>
		public Lieferant GetSupplier(string supplierPK)
		{
			return this.GetSupplierList().FirstOrDefault(l => l.Lieferantennummer == supplierPK);
		}

		/// <summary>
		/// Gibt alle Lieferantenbestellungen im System zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Bestellung> GetBestellungList()
		{
			var list = new SBList<Bestellung>();
			var bestellungen = DataManager.SupplierDataService.GetBestellungTable().Where(l => l.Vorgang.ToLower() == "b");
			foreach (dsSuppliers.BestellungRow bRow in bestellungen)
			{
				list.Add(new Bestellung(bRow));
			}
			return list;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der Bestellungen des angegebenen Lieferanten zurück.
		/// </summary>
		/// <param name="lieferantPK">Primärschlüssel (Lieferantennummer) des Lieferanten der gesuchten Bestellungen.</param>
		/// <remarks>
		/// Die Methode liefert ausschließlich die Bestellungen des Lieferanten zurück. Keine der nachfolgenden Belege, wie z. B.
		/// Lieferungen, Rechnungen, Warenlieferungen oder Storno-Warenlieferungen.
		/// </remarks>
		/// <returns></returns>
		public SBList<Bestellung> GetBestellungList(string lieferantPK)
		{
			var list = new SBList<Bestellung>();
			var bestellungen = this.GetBestellungList().Where(b => b.Lieferantennummer == lieferantPK);
			foreach (var bestellung in bestellungen)
			{
				list.Add(bestellung);
			}
			return list.Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
		}

		/// <summary>
		/// Gibt eine sortierbare Liste von Bestellungen zurück, die Artikel enthalten,
		/// die den Filterkriterien entsprechen.
		/// </summary>
		/// <param name="supplierPK">Lieferantennummer.</param>
		/// <param name="filter">Suchkriterium.</param>
		/// <returns></returns>
		public SBList<Bestellung> GetBestellungListFiltered(string supplierPK, string filter)
		{
			var query = from bestellungen in this.GetBestellungList(supplierPK)
									join details in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "b")
									on bestellungen.Nummer equals details.Nummer
									where details.Artikelnummer.ToLower().Contains(filter.ToLower()) | details.Artikelbezeichnung1.ToLower().Contains(filter.ToLower())
									select bestellungen;

			var result = new SBList<Bestellung>();
			foreach (var item in query.Distinct())
			{
				var bestellung = this.GetBestellungList(supplierPK).FirstOrDefault(b => b.Nummer == item.Nummer);
				if(bestellung != null) result.Add(bestellung);
			}
			return result;
		}

		/// <summary>
		/// Gibt alle Bestellpositionen der angegebenen Bestellung zurück.
		/// </summary>
		/// <param name="bestellung"></param>
		/// <returns></returns>
		public SBList<BestellDetail> GetBestellDetailList(Bestellung bestellung)
		{
			var list = new SBList<BestellDetail>();
			var details = DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Nummer == bestellung.Nummer && d.Vorgang.ToLower() == "b");
			foreach (var dRow in details)
			{
				list.Add(new BestellDetail(dRow));
			}
			return list;
		}

		public object GetBestellDetails(string artikelPK)
		{
			var qB = from b1 in DataManager.SupplierDataService.GetBestellungTable().Where(b => b.Vorgang.ToLower() == "b")
							 join d in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "b")
							 on b1.Nummer equals d.Nummer into bG
							 from b2 in bG
							 join l in DataManager.SupplierDataService.GetLieferantTable()
							 on b1.Lieferantennummer equals l.Lieferantennummer
							 where b2.Artikelnummer == artikelPK
							 select new { b1.Vorgang, b1.Nummer, b1.Datum, Lieferant = l.Name1, b2.Artikelnummer, b2.Artikelbezeichnung1, Menge = b2.Bestellmenge, b2.Lieferdatum };

			var qL = from b1 in DataManager.SupplierDataService.GetBestellungTable().Where(b => b.Vorgang.ToLower() == "l")
							 join d in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "l")
							 on b1.Nummer equals d.Nummer into bG
							 from b2 in bG
							 join l in DataManager.SupplierDataService.GetLieferantTable()
							 on b1.Lieferantennummer equals l.Lieferantennummer
							 where b2.Artikelnummer == artikelPK
							 select new { b1.Vorgang, b1.Nummer, b1.Datum, Lieferant = l.Name1, b2.Artikelnummer, b2.Artikelbezeichnung1, Menge = b2.Liefermenge, b2.Lieferdatum };

			return qB.OrderByDescending(b => b.Datum).Take(1).Union(qL.OrderByDescending(l => l.Datum).Take(1)).ToList();
		}

		/// <summary>
		/// Gibt die DataTable mit den derzeit offenen Lieferantenbestellungen für den angegebenen Artikel zurück.
		/// </summary>
		/// <param name="artikelPK">Artikelnummer.</param>
		/// <returns></returns>
		public dsSuppliers.OffeneBestellungenDataTable GetOffeneBestellungen(string artikelPK)
		{
			return DataManager.SupplierDataService.GetOffeneBestellungenTable(artikelPK);
		}

		/// <summary>
		/// Gibt alle Bestellpositionen der angegebenen Bestellung zurück.
		/// </summary>
		/// <param name="lieferung"></param>
		/// <returns></returns>
		public SBList<BestellDetail> GetLieferDetailList(Bestellung lieferung)
		{
			var list = new SBList<BestellDetail>();
			var details = DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Nummer == lieferung.Nummer && d.Vorgang.ToLower() == "l");
			foreach (var dRow in details)
			{
				list.Add(new BestellDetail(dRow));
			}
			return list;
		}

		/// <summary>
		/// Gibt alle Bestellpositionen der angegebenen Bestellung zurück.
		/// </summary>
		/// <param name="rechnung"></param>
		/// <returns></returns>
		public SBList<BestellDetail> GetRechnungDetailList(Bestellung rechnung)
		{
			var list = new SBList<BestellDetail>();
			var details = DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Nummer == rechnung.Nummer && d.Vorgang.ToLower() == "r");
			foreach (var dRow in details)
			{
				list.Add(new BestellDetail(dRow));
			}
			return list;
		}

		/// <summary>
		/// Gibt alle Lieferungen zu der angegebenen Bestellung zurück.
		/// </summary>
		/// <param name="bestellung"></param>
		/// <returns></returns>
		public SBList<Bestellung> GetLieferungList(Bestellung bestellung)
		{
			var list = new SBList<Bestellung>();
			var lieferungen = DataManager.SupplierDataService.GetBestellungTable().Where(l => l.Bestellung == bestellung.Nummer && l.Vorgang.ToLower() == "l");
			foreach (dsSuppliers.BestellungRow lRow in lieferungen)
			{
				list.Add(new Bestellung(lRow));
			}
			return list;			
		}

		/// <summary>
		/// Gibt alle Lieferantenrechnungen im System zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Bestellung> GetRechnungList(Bestellung bestellung)
		{
			var list = new SBList<Bestellung>();
			var lieferungen = DataManager.SupplierDataService.GetBestellungTable().Where(l => l.Bestellung == bestellung.Nummer && l.Vorgang.ToLower() == "r");
			foreach (dsSuppliers.BestellungRow lRow in lieferungen)
			{
				list.Add(new Bestellung(lRow));
			}
			return list;
		}

		/// <summary>
		/// Gibt das Datum der letzten Bestellung für einen Artikel zurück.
		/// </summary>
		/// <param name="productPK"></param>
		/// <returns></returns>
		public DateTime GetDatumLetzteBestellung(string productPK)
		{
			var q = from order in DataManager.SupplierDataService.GetBestellungTable().Where(b => b.Vorgang.ToLower() == "b")
							join detail in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "b")
							on order.Nummer equals detail.Nummer
							where detail.Artikelnummer == productPK
							select order;
			return (q.Count() > 0) ? q.Max(o => o.Datum) : DateTime.MinValue;
		}

		public ShipmentDetail? GetLetzteLieferungDetail(string productPK)
		{
			var q = from shipment in DataManager.SupplierDataService.GetBestellungTable().Where(b => b.Vorgang.ToLower() == "l")
							join detail in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "l")
							on shipment.Nummer equals detail.Nummer
							where detail.Artikelnummer == productPK
							orderby shipment.Datum descending
							select new { shipment.Datum, detail.Liefermenge, detail.Mengeneinheit };
				
			var result = q.FirstOrDefault();
			if (result != null)
			{
				return new ShipmentDetail(result.Datum, result.Liefermenge, result.Mengeneinheit);

			}
			return null;
		}

		public DateTime GetDatumLetzteLieferung(string productPK)
		{
			var q = from shipment in DataManager.SupplierDataService.GetBestellungTable().Where(b => b.Vorgang.ToLower() == "l")
							join detail in DataManager.SupplierDataService.GetBestellDetailTable().Where(d => d.Vorgang.ToLower() == "l") 
							on shipment.Nummer equals detail.Nummer
							where detail.Artikelnummer == productPK
							select shipment;
			return (q.Count() > 0) ? q.Max(o => o.Datum) : DateTime.MinValue;
		}

		/// <summary>
		/// Gibt die Rabattstaffel für den angegebenen Artikel bei dem angegebenen Lieferanten zurück.
		/// </summary>
		/// <param name="artikelPK"></param>
		/// <param name="lieferantPK"></param>
		/// <returns></returns>
		public LieferantenRabatt GetOrCreateRabattStaffel(string artikelPK, string lieferantPK)
		{
			if (this.myRabattList == null)
			{
				this.myRabattList = new SBList<LieferantenRabatt>();
				dsSuppliers.RabattstaffelRow rRow = DataManager.SupplierDataService.GetRabattStaffel(artikelPK: artikelPK, lieferantPK: lieferantPK);
				if (rRow != null)
				{
					var rabatt = new LieferantenRabatt(rRow);
					this.myRabattList.Add(rabatt);
					return rabatt;
				}
				else
				{
					// Neue Rabattstaffel erstellen
					rRow = DataManager.SupplierDataService.AddRabattstaffelRow(artikelPK, lieferantPK);
					var rabatt = new LieferantenRabatt(rRow);
					this.myRabattList.Add(rabatt);
					return rabatt;
				}
			}
			else // Rabattliste existiert schon
			{
				var rabatt = this.myRabattList.FirstOrDefault(r => r.Artikelnummer == artikelPK && r.LieferantenNummer == lieferantPK);
				if (rabatt != null)
				{
					return rabatt;
				}
				else
				{
					dsSuppliers.RabattstaffelRow rRow = DataManager.SupplierDataService.AddRabattstaffelRow(artikelPK, lieferantPK);
					rabatt = new LieferantenRabatt(rRow);
					this.myRabattList.Add(rabatt);
					return rabatt;
				}
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Kontakte des Lieferanten mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="lieferantPK"></param>
		/// <returns></returns>
		public SBList<LieferantenKontakt> GetKontaktList(string lieferantPK)
		{
			if (!this.myKontaktDictionary.ContainsKey(lieferantPK))
			{
				var list = new SBList<LieferantenKontakt>();
				foreach (var kRow in DataManager.SupplierDataService.GetKontaktTable().Where(k => k.Lieferantennummer == lieferantPK))
				{
					list.Add(new LieferantenKontakt(kRow));
				}
				this.myKontaktDictionary.Add(lieferantPK, list);
			}
			return this.myKontaktDictionary[lieferantPK];
		}

		/// <summary>
		/// Gibt den Lieferantenkontakt mit dem angegebenen Primärschlüssel bei dem angegebenen Lieferanten zurück.
		/// </summary>
		/// <param name="supplierPK">Primärschlüssel des Lieferanten.</param>
		/// <param name="contactPK">Primärschlüssel der Kontaktperson (Nummer)</param>
		/// <returns></returns>
		public LieferantenKontakt GetLieferantenKontakt(string supplierPK, string contactPK)
		{
			return this.GetKontaktList(supplierPK).FirstOrDefault(k => k.Lieferantennummer == supplierPK &&  k.Nummer == contactPK);
		}

		#endregion

		#region STRUCTS

		public struct ShipmentDetail
		{
			public DateTime Datum { get; private set; }
			public double Menge { get; private set; }
			public string Mengeneinheit { get; private set; }

			public ShipmentDetail(DateTime datum, double menge, string mengenEinheit)
			{
				this.Datum = datum;
				this.Menge = menge;
				this.Mengeneinheit = mengenEinheit;
			}

		}

		#endregion

	}
}
