﻿using Products.Data;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Hersteller : ILinkedItem
	{

		#region members

		readonly dsShared.HerstellerRow myBase;

		#endregion

		#region public properties

		#region ILinkableItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Hersteller").UID; }
		}

		/// <summary>
		/// Gibt die Zeichenfolge 'Hersteller' zurück.
		/// </summary>
		public string LinkTypBezeichnung
		{
			get { return "Hersteller"; }
		}

		/// <summary>
		/// Gibt den Herstellernamen (Firmennamen) dieses Herstellers zurück.
		/// </summary>
		public string ItemName
		{
			get { return this.myBase.HerstellerName; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel des Herstellers zurück.
		/// </summary>
		public string UID { get { return myBase.UID; } }

		/// <summary>
		/// Gibt den Namen des Herstellers zurück.
		/// </summary>
		public string Herstellername 
		{ 
			get { return myBase.HerstellerName; } 
			set { myBase.HerstellerName = value; } 
		}
	
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Hersteller Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Hersteller(dsShared.HerstellerRow baseRow)
		{
			myBase = baseRow;
		}
	
		#endregion

	}
}
