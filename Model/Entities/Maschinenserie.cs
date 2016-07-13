﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Common;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Maschinenserie : ILinkedItem
	{

		#region members

		private dsShared.MaschinenSerieRow myBase = null;
		private SortableBindingList<Maschinenmodell> myModelle = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Maschinenserie").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.Serienname; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Maschinenserie"; }
		}

		#endregion

		#region skalare

		/// <summary>
		/// Primärschlüssel der Serie.
		/// </summary>
		public string UID { get { return myBase.UID; } }

		/// <summary>
		/// Bezeichnung dieser Serie.
		/// </summary>
		public string Serienname { get { return myBase.Serienname; } set { myBase.Serienname = value; } }

		/// <summary>
		/// GUID des Herstellers.
		/// </summary>
		public string HerstellerId { get { return myBase.HerstellerId; } set { myBase.HerstellerId = value; } }

		/// <summary>
		/// GUID des Maschinentyps.
		/// </summary>
		public string MaschinentypId { get { return myBase.MaschinentypId; } set { myBase.MaschinentypId = value; } }

		#endregion

		#region entities

		/// <summary>
		/// Gibt den Hersteller dieser Serie als Objekt zurück.
		/// </summary>
		public Hersteller Hersteller
		{
			get
			{
				return ModelManager.SharedItemsService.GetHersteller(myBase.HerstellerId);
			}
		}

		/// <summary>
		/// Gibt den Maschinentyp der Serie als Objekt zurück.
		/// </summary>
		public Maschinentyp Maschinentyp
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenTyp(this.MaschinentypId);
			}
		}

		public SortableBindingList<Maschinenmodell> Maschinenmodelle
		{
			get
			{
				if (myModelle == null)
				{
					myModelle = ModelManager.SharedItemsService.GetMaschinenModellList(this);
				}
				return myModelle;
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Maschinenserie Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Maschinenserie(dsShared.MaschinenSerieRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures
		
		#endregion

		#region private procedures

		#endregion

	}
}