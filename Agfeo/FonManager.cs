
namespace Agfeo
{
	public static class FonManager
	{

		#region members

		static FonService fonService;

		#endregion

		#region static properties

		/// <summary>
		/// Returns the static FonService.
		/// </summary>
		public static FonService FonService
		{
			get
			{
				if (fonService == null)
				{
					fonService = new FonService();
				}
				return fonService;
			}
		}

		#endregion

	}
}
