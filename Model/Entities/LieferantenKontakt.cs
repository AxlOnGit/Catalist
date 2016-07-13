using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class LieferantenKontakt : ILinkedItem
	{

		#region members

		private dsSuppliers.LieferantenKontaktRow myBase = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return string.Format("{0}{1}", this.myBase.Lieferantennummer, this.myBase.Nummer); }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Lieferantenkontakt").UID; }
		}
		
		/// <summary>
		/// Bezeichnung der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.ItemName
		{
			get { return this.myBase.Name; }
		}

		/// <summary>
		/// Bezeichnung des LinkTyps der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Lieferantenkontakt"; }
		}

		#endregion

		public string Satzart { get { return this.myBase.Satzart; } }
		public string Lieferantennummer { get { return myBase.Lieferantennummer; } }
		public string Nummer { get { return myBase.Nummer; } }
		public string Kontaktname { get { return myBase.Name; } }
		public string Abteilung { get { return myBase.Abteilung; } }
		public string Telefon { get { return myBase.Telefon; } }
		public string Telefax { get { return myBase.Telefax; } }
		public string Handy { get { return myBase.Handy; } }
		public string EMail { get { return myBase.E_Mail; } }

		#region ENTITIES

		/// <summary>
		/// Gibt den Lieferanten zurück, zu dem diese Kontaktperson gehört.
		/// </summary>
		public Lieferant Lieferant
		{
			get{return ModelManager.SupplierService.GetSupplier(this.myBase.Lieferantennummer); }
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der LieferantenKontakt Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public LieferantenKontakt(dsSuppliers.LieferantenKontaktRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
