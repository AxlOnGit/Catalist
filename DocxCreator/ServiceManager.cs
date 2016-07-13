
using Products.Data;
namespace Products.DocxCreator
{
	public static class ServiceManager
	{

		#region members

		private static DocXService docXService;

		#endregion

		#region public properties

		/// <summary>
		/// Returns the static DocXService.
		/// </summary>
		public static DocXService DocXService
		{
			get
			{
				if (docXService == null)
				{
					docXService = new DocXService(DataManager.CatalogDataService.GetCatalogTable());
				}
				return docXService;
			}
		}

		#endregion

	}
}
