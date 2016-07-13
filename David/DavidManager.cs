
namespace David
{
	public static class DavidManager
	{

		#region members

		static DavidService davidService;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den statischen Singleton DavidService zurück.
		/// </summary>
		public static DavidService DavidService
		{
			get
			{
				if (davidService == null)
				{
					davidService = new DavidService();
				}
				return davidService;
			}
		}
	
		#endregion

	}
}
