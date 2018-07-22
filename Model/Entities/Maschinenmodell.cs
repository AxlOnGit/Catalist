using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Maschinenmodell : ILinkedItem
	{
		#region MEMBERS

		readonly dsShared.MaschinenModellRow myBase;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Maschinenmodell").UID; }
		}

		public string ItemName
		{
			get { return this.myBase.Modellbezeichnung; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Maschinenmodell"; }
		}

		#endregion ILinkedItem

		public string UID { get { return myBase.UID; } }

		/// <summary>
		/// Wird umgeleitet auf die HerstellerId der Serie.
		/// </summary>
		public string HerstellerId
		{
			get
			{
				return this.Maschinenserie.HerstellerId;
			}
			set
			{
				myBase.HerstellerrId = value;
			}
		}

		/// <summary>
		/// Wird umgebogen auf den Hersteller der Serie.
		/// </summary>
		public Hersteller Hersteller
		{
			get
			{
				return this.Maschinenserie.Hersteller != null ? this.Maschinenserie.Hersteller : null;
			}
		}

		/// <summary>
		/// Gibt den Herstellernamen zurück.
		/// </summary>
		public string Herstellername
		{
			get
			{
				return (this.Hersteller == null) ? string.Empty : this.Hersteller.Herstellername;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel der Modellserie dieses Maschinenmodells zurück.
		/// </summary>
		public string ModellSerieId
		{
			get { return this.myBase.MaschinenserieId; }
			set
			{
				if (!this.myBase.MaschinenserieId.Equals(value, System.StringComparison.CurrentCultureIgnoreCase))
					this.myBase.MaschinenserieId = value;
			}
		}

		public Maschinenserie Maschinenserie
		{
			get
			{
				return ModelManager.SharedItemsService.GetModellSerie(this.ModellSerieId);
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung der Serie zurück, zu der dieses Maschinenmodell gehört
		/// </summary>
		public string ModellSerienName
		{
			get
			{
				return (this.Maschinenserie == null) ? string.Empty : this.Maschinenserie.Serienname;
			}
		}

		public string MaschinentypId { get { return myBase.MaschinenTypId; } set { myBase.MaschinenTypId = value; } }

		/// <summary>
		/// Gibt die Bezeichnung des Maschinentyps zurück.
		/// </summary>
		public string Maschinentyp
		{
			get
			{
				return this.Maschinenserie != null ? this.Maschinenserie.Maschinentyp.MaschinentypName : string.Empty;
			}
		}

		public string Modellbezeichnung { get { return myBase.Modellbezeichnung; } set { myBase.Modellbezeichnung = value; } }

		/// <summary>
		/// Gibt True zurück, wenn es keine Kundenmaschinen dieses Maschinenmodells gibt,
		/// sonst False.
		/// </summary>
		public bool CanDelete
		{
			get
			{
				return RepoManager.KundenmaschinenRepository.GetKundenmaschinenList(this).Count == 0;
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der MaschinenModell Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Maschinenmodell(dsShared.MaschinenModellRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion ### .ctor ###
	}
}