
namespace David
{
	public static class DavidManager
	{

		#region members

		static bool myWithAppointmentListener;
		static DavidService myDavidService;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den statischen Singleton DavidService zurück.
		/// </summary>
		public static DavidService DavidService
		{
			get
			{
				if (myDavidService == null)
				{
					myDavidService = new DavidService(myWithAppointmentListener);
				}
				return myDavidService;
			}
		}
	
		#endregion

		public static void SetAppointmentListener(bool setListener)
		{
			myWithAppointmentListener = setListener;
		}

	}
}
