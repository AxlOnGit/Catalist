
using Products.Data.Datasets;
namespace Products.Model.Entities
{
	public class Maschinentyp
	{

		#region members

		private dsShared.MaschinenTypRow myBase;
	
		#endregion

		#region public properties

		public string UID
		{
			get { return myBase.UID; }
		}

		public string MaschinentypName
		{
			get { return myBase.MaschinentypName; }
			set { myBase.MaschinentypName = value; }
		}
	
		#endregion

		#region ### .ctor ###

		public Maschinentyp(dsShared.MaschinenTypRow baseRow)
		{
			myBase = baseRow;
		}
	
		#endregion



	}
}
