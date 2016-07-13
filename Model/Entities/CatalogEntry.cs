using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class CatalogEntry
	{

		#region members

		dsCatalog.CatalogRow myBase;

		#endregion

		#region public properties

		#region integrals

		public string Numbering { get { return myBase.Numbering; } set { myBase.Numbering = value; } }
		public string SectionName { get { return myBase.SectionName; } set { myBase.SectionName = value; } }

		#endregion

		#region entities



		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CatalogEntry class.
		/// </summary>
		/// <param name="baseRow"></param>
		public CatalogEntry(dsCatalog.CatalogRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

	}
}
