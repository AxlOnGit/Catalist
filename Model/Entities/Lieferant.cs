using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Common.Interfaces;
using Products.Common;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class Lieferant : ILinkedItem
	{

		#region members

		readonly dsSuppliers.LieferantRow myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.Lieferantennummer; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Lieferant").UID; }
		}

		public string ItemName
		{
			get { return this.myBase.Name1; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Lieferant"; }
		}

		#endregion

		public string Lieferantennummer { get { return this.myBase.Lieferantennummer; } }
		public DateTime Anlagedatum { get { return this.myBase.Anlagedatum; } }
		public string UnsereKundennummer { get { return this.myBase.CpmKundennummer; } }
		public string Name1 { get { return this.myBase.Name1; } }
		public string Name2 { get { return this.myBase.Name2; } }
		public string Strasse { get { return this.myBase.Strasse; } }
		public string Adresszusatz { get { return this.myBase.Adresszusatz; } }
		public string Postleitzahl { get { return this.myBase.Postleitzahl; } }
		public string Ort { get { return this.myBase.Ort; } }
		public string LandesCode { get { return this.myBase.Laendercode; } }
		public string Matchcode { get { return this.myBase.Matchcode; } }
		public string Telefon { get { return this.myBase.Telefon; } }
		public string Telefax { get { return this.myBase.Telefax; } }
		public string EMail { get { return this.myBase.E_Mail; } }
		public string Homepage { get { return this.myBase.Homepage; } }
		public string KontaktNummer { get { return this.myBase.Ansprechpartner_Nummer; } }
		public string KontaktLieferantNr { get { return this.myBase.Ansprechpartner_Lieferantennr; } }
		public string KontaktSatzart { get { return this.myBase.Ansprechpartner_Satzart; } }

		#region ENTITIES

		/// <summary>
		/// Gibt den Hauptansprechpartner dieses Lieferanten zurück.
		/// </summary>
		public LieferantenKontakt Kontaktperson
		{
			get
			{
				return ModelManager.SupplierService.GetLieferantenKontakt(this.myBase.Ansprechpartner_Lieferantennr, this.myBase.Ansprechpartner_Nummer);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Lieferant Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Lieferant(dsSuppliers.LieferantRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine sortierbare Liste aller Bestellungen dieses Lieferanten zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Bestellung> GetBestellungList()
		{
			return ModelManager.SupplierService.GetBestellungList(this.Lieferantennummer);
		}

		#endregion

		#region private procedures
		#endregion

	}
}
