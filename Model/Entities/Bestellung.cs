using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Common;
using Products.Data;
using Products.Common.Collections;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Bestellung :  ILinkedItem
	{

		#region members

		readonly dsSuppliers.BestellungRow myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		string ILinkedItem.Key
		{
			get { return this.myBase.Nummer; }
		}

		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Bestellung").UID; }
		}

		string ILinkedItem.ItemName
		{
			get
			{
				return string.Format("Bestellung {0} vom {1} ({2})", this.myBase.Nummer, this.myBase.Datum, this.Lieferant.Matchcode);				
			}
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Bestellung"; }
		}

		#endregion

		public string Vorgang { get { return this.myBase.Vorgang; } }
		public string Nummer { get { return this.myBase.Nummer; } }
		public string Bestellnummer { get { return this.myBase.Bestellung; } }
		public DateTime Datum { get { return this.myBase.Datum; } }
		public decimal SummeUSt_1 { get { return this.myBase.SummeUSt_1; } }
		public decimal Bruttosumme { get { return this.myBase.Bruttosumme; } }
		public string Lieferantennummer { get { return this.myBase.Lieferantennummer; } }
		public int Positionsanker { get { return this.myBase.Positionsanker; } }

		/// <summary>
		/// Gibt den Lieferanten dieser Bestellung zurück.
		/// </summary>
		public Lieferant Lieferant
		{
			get
			{
				return ModelManager.SupplierService.GetSupplier(this.myBase.Lieferantennummer);
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Bestellung Klasse.
		/// </summary>
		/// <param name="baseRow">Die Instanz einer <seealso cref="dsSuppliers.BestellungRow"/>. Basis dieser Bestellung Instanz.</param>
		public Bestellung(dsSuppliers.BestellungRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
