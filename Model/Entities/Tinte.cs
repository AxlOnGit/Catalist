
using Products.Data.Datasets;
namespace Products.Model.Entities
{
	public class Tinte
	{

		#region members

		dsShared.TinteRow myBase;
	
		#endregion

		#region public properties

		public string UID { get { return myBase.UID; } }

		public string Typ { get { return myBase.Typ; } set { myBase.Typ = value; } }

		public string Tintenbezeichnung { get { return myBase.Tintenbezeichnung; } set { myBase.Tintenbezeichnung = value; } }

		public string HerstellerId { get { return myBase.HerstellerId; } set { myBase.HerstellerId = value; } }

		public string Herstellername { get { return ModelManager.SharedItemsService.GetHersteller(myBase.HerstellerId).Herstellername; } }
	
		#endregion

		#region ### .ctor ###

		public Tinte(dsShared.TinteRow baseRow)
		{
			myBase = baseRow;
		}
	
		#endregion

	}
}
