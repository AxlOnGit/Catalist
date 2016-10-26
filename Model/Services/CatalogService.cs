using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class CatalogService
	{
		#region members

		SortableBindingList<CatalogEntry> myCatalogEntryList;

		#endregion members

		#region public procedures

		public CatalogEntry GetCatalogEntry(string catalogPK)
		{
			if (this.myCatalogEntryList == null) this.InitializeCatalog();
			return this.myCatalogEntryList.FirstOrDefault(c => c.Numbering == catalogPK);
		}

		/// <summary>
		/// Gibt die Bezeichnung der Katalogkategorie zurück.
		/// </summary>
		/// <param name="catalogPK"></param>
		/// <returns></returns>
		public string GetSectionName(string catalogPK)
		{
			if (this.myCatalogEntryList == null) this.InitializeCatalog();
			return this.myCatalogEntryList.FirstOrDefault(c => c.Numbering == catalogPK).SectionName;
		}

		#endregion public procedures

		#region private procedures

		void InitializeCatalog()
		{
			this.myCatalogEntryList = new SortableBindingList<CatalogEntry>();
			var catalogTable = Data.DataManager.CatalogDataService.GetCatalogTable();
			foreach (var cRow in catalogTable)
			{
				var entry = new CatalogEntry(cRow);
				this.myCatalogEntryList.Add(entry);
			}
		}

		#endregion private procedures
	}
}