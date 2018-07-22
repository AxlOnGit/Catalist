using System;
using Microsoft.Win32;

namespace Catalist.Registry
{
	public static class CalendarSettings
	{

		#region MEMBERS

		static RegistryKey myHKCU = Microsoft.Win32.Registry.CurrentUser;
		static string myRegPath = @"Software\UllrichIT\Catalist\CalendarSettings";

		#endregion

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Gibt den Registrierungseintrag für die Anzahl der Monate zurück,
		/// die beim Laden des Kalenders zurückgeschaut wird.
		/// </summary>
		/// <returns></returns>
		public static int GetAppointmentAge()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			if (key == null) { SetAppointmentAge(12); }

			return (int)key.GetValue("AppointmentAgeInMonths");
		}

		/// <summary>
		/// Legt den Registrierungseintrag für die Anzahl der Monate fest,
		/// die beim Laden des Kalenders zurückgeschaut wird.
		/// </summary>
		/// <param name="ageInMonths"></param>
		public static void SetAppointmentAge(int ageInMonths)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			if (key == null)
			{
				var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
				throw new ApplicationException(msg);
			}
			key.SetValue("AppointmentAgeInMonths", ageInMonths);
		}

		#endregion

	}
}
