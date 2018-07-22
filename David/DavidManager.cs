
namespace David
{
	public static class DavidManager
	{

		#region MEMBERS

		static bool myWithAppointmentListener;
		static DavidService myDavidService;
		static DavidTerminRepo myDavidTerminRepo;
		static MessageItem2Creator myMessageItem2Creator;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt den statischen singleton DavidService zurück.
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

		/// <summary>
		/// Gibt das statische singleton DavidTerminRepository zurück.
		/// </summary>
		public static DavidTerminRepo DavidTerminRepo
		{
			get
			{
				if (myDavidTerminRepo == null) myDavidTerminRepo = new DavidTerminRepo();
				return myDavidTerminRepo;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton MessageItem2Creator des Systems zurück.
		/// </summary>
		public static MessageItem2Creator MessageItem2Creator
		{
			get
			{
				if (myMessageItem2Creator == null) myMessageItem2Creator = new MessageItem2Creator();
				return myMessageItem2Creator;
			}
		}

		#endregion PUBLIC PROPERTIES

		#region PUBLIC PROCEDURES

		public static void SetAppointmentListener(bool setListener)
		{
			myWithAppointmentListener = setListener;
		}

		#endregion PUBLIC PROCEDURES

	}
}
