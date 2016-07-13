using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsCatalogTableAdapters;

namespace Products.Data.Services
{
	public class CatalogDataService
	{

		#region members

		string myCurrentUserPK;
		readonly dsCatalog myDS = new dsCatalog();
		taCatalog myCatalogAdapter;

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CatalogDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public CatalogDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die CatalogDataTable mit allen Katalogeinträgen im System zurück.
		/// </summary>
		/// <returns></returns>
		public dsCatalog.CatalogDataTable GetCatalogTable()
		{
			if (this.myCatalogAdapter == null)
			{
				this.myCatalogAdapter = new taCatalog();
				this.myCatalogAdapter.Fill(this.myDS.Catalog);
			}
			return this.myDS.Catalog;
		}

		/// <summary>
		/// Aktualisiert die CatalogDataTable. 
		/// </summary>
		public void Update()
		{
			this.myCatalogAdapter.Update(this.myDS.Catalog);
		}

		#endregion

		#region private procedures

		#endregion

	}
}
