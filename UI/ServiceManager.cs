
namespace Products.Common
{
	public static class ServiceManager
	{

		#region members

		static UiService myUiService;
		static PostOffice myPostOffice;
		static LogService myLogService;
	
		#endregion

		#region public procedures

		/// <summary>
		/// Gibt den statischen UiService des Systems zurück.
		/// </summary>
		public static UiService UiService
		{
			get
			{
				if (myUiService == null)
				{
					myUiService = new UiService();
				}
				return myUiService;
			}
		}

		/// <summary>
		/// Returns the static singleton PostOffice.
		/// </summary>
		/// <param name="user">The David SMTP username.</param>
		/// <param name="password">That user's password.</param>
		/// <returns></returns>
		public static Products.Common.PostOffice PostOffice(string user, string password)
		{
			if (myPostOffice == null)
			{
				myPostOffice = new PostOffice(user, password, Model.ModelManager.UserService.CurrentUser.EmailWork);
			}
			return myPostOffice;
		}

		internal static LogService Logger
		{
			get
			{
				if (myLogService == null)
				{
					myLogService = new LogService();
				}
				return myLogService;
			}
		}

		#endregion

	}
}
