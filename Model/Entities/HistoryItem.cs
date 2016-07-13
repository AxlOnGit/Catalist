using System;
using Products.Data;

namespace Products.Model.Entities
{
	public class HistoryItem
	{

		#region members

		dsSage.HistorieRow myBase;
	
		#endregion

		#region public properties

		public string UID { get { return myBase.UID; } }
		public string CustomerId { get { return myBase.Kundennummer; } }
		public string LinktypId { get { return myBase.LinkTypId; } }

		public string ItemType { get { return ModelManager.SharedItemsService.GetLinkTypeByPK(myBase.LinkTypId).Bezeichnung; } }

		public string ID { get { return myBase.LinkId; } }
		public string Description { get { return myBase.Beschreibung; } }
		public DateTime OriginalDate { get { return myBase.OriginalDatum; } }
		public string OriginCreatedById { get { return myBase.OriginalErfasserId; } }

		public string OriginCreatedBy 
		{ 
			get 
			{
				if (myBase.IsOriginalErfasserIdNull())
				{
					return string.Empty;
				}
				return ModelManager.UserService.GetUser(myBase.OriginalErfasserId, Services.UserService.UserSearchParamType.PrimaryKey).UserName; 
			} 
		}

		public DateTime CreatedDate { get { return myBase.Erfassungsdatum; } }
		public string CreatedById { get { return myBase.ErfasserId; } }

		public string CreatedBy
		{
			get
			{
				if (myBase.IsOriginalErfasserIdNull())
				{
					return string.Empty;
				}
				return ModelManager.UserService.GetUser(myBase.ErfasserId, Services.UserService.UserSearchParamType.PrimaryKey).UserName;
			}
		}
	
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the HistoryItem class.
		/// </summary>
		/// <param name="baseRow"></param>
		public HistoryItem(dsSage.HistorieRow baseRow)
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
