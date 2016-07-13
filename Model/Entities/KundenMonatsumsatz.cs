using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class KundenMonatsumsatz
	{

		#region members

		private dsSales.SalesStatsRow myBase = null;
	
		#endregion

		#region public properties

		/// <summary>
		/// Gibt die Kundennummer zurück.
		/// </summary>
		public string Kundennummer { get { return this.myBase.Kundennummer; } }

		/// <summary>
		/// Liefert das Datum dieses Monatsumsatzes.
		/// </summary>
		public DateTime Datum 
		{
			get 
			{
				return this.myBase.Datum;
			} 
		}

		/// <summary>
		/// Gibt den im betreffenden Monat erzielten Umsatz des Kunden zurück.
		/// </summary>
		public decimal Umsatz { get { return this.myBase.Umsatz; } }

		/// <summary>
		/// Gibt die Gesamtmenge der verkauften Artikel dieses Kunden zurück.
		/// </summary>
		public double Menge { get { return this.myBase.Menge; } }

		/// <summary>
		/// Gibt den im betreffenden Monat erzielten Roherlös des Kunden als absoluten Betrag zurück.
		/// </summary>
		public decimal GewinnAbsolut { get { return this.myBase.RohgewinnAbsolut; } }

		/// <summary>
		/// Gibt den im betreffenden Monat erzielten Roherlös des Kunden in Prozent zurück.
		/// </summary>
		public decimal GewinnProzent { get { return this.myBase.RohgewinnProzent; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KundenMonatsumsatz Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public KundenMonatsumsatz(dsSales.SalesStatsRow baseRow)
		{
			this.myBase = baseRow;
		}
		
		#endregion

	}
}
