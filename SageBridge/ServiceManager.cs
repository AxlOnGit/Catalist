using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.SageBridge.Services;

namespace Products.SageBridge
{
	public static class ServiceManager
	{
		#region MEMBERS

		static SageService mySageService;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt den statischen singleton SageService des Systems zurück.
		/// </summary>
		public static SageService SageService
		{
			get
			{
				if (mySageService == null) mySageService = new SageService();
				return mySageService;
			}
		}

		#endregion PUBLIC PROPERTIES
	}
}