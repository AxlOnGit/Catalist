
using Products.Data.Datasets;
using Products.Common.Interfaces;
namespace Products.Model.Entities
{
	public class Maschinenmodell : ILinkedItem
	{

		#region members

		private dsShared.MaschinenModellRow myBase;
	
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
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Maschinenmodell").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.Modellbezeichnung; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Maschinenmodell"; }
		}

		#endregion

		public string UID { get { return myBase.UID; } }

		public string HerstellerId 
		{ 
			get 
			{ 
				return myBase.HerstellerrId; 
			} 
			set 
			{ 
				myBase.HerstellerrId = value; 
			} 
		}

		/// <summary>
		/// Gibt den Herstellernamen zurück.
		/// </summary>
		public string Herstellername 
		{ 
			get 
			{
				return ModelManager.SharedItemsService.GetHersteller(myBase.HerstellerrId).Herstellername; 
			} 
		}

		public string ModellSerieId { get { return this.myBase.MaschinenserieId; } }

		/// <summary>
		/// Gibt die Bezeichnung der Serie zurück, zu der dieses Maschinenmodell gehört
		/// </summary>
		public string ModellSerie
		{
			get { return ModelManager.SharedItemsService.GetModellSerie(seriePK: this.ModellSerieId).Serienname; }
		}

		public string MaschinentypId { get { return myBase.MaschinenTypId; } set { myBase.MaschinenTypId = value; } }

		public string Maschinentyp { get { return ModelManager.SharedItemsService.GetMaschinenTyp(myBase.MaschinenTypId).MaschinentypName; } }

		public string Modellbezeichnung { get { return myBase.Modellbezeichnung; } set { myBase.Modellbezeichnung = value; } }
	
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der MaschinenModell Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Maschinenmodell(dsShared.MaschinenModellRow baseRow)
		{
			myBase = baseRow;
		}
	
		#endregion

	}
}
