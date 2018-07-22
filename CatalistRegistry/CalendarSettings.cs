using System;
using System.Text;
using Microsoft.Win32;

namespace CatalistRegistry
{
	public static class CalendarSettings
	{

		#region MEMBERS

		static RegistryKey myHKCU = Registry.CurrentUser;
		static string myRegPath = @"Software\UllrichIT\Catalist\CalendarSettings";

		#endregion MEMBERS

		#region ### .ctor ###

		static CalendarSettings()
		{
			// Beim ersten Start gibt es den CalendarSettings SubKey noch nicht. Den dann erstellen ...
			var key = myHKCU.OpenSubKey(myRegPath, true);
			if (key == null) myHKCU.CreateSubKey(myRegPath);
			key.Close();
		}

		#endregion

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Gibt die Liste der Mitarbeiter zurück, deren Kalender beim Start geladen werden sollen.
		/// </summary>
		/// <returns></returns>
		public static string[] GetPreloadUserList()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				var separators = new string[1] { ";" };
				if (key.GetValue("PreloadUsers") == null)
				{
					var arrayEmpty = new string[] { string.Empty };
					SetPreloadUserList(arrayEmpty);
					return arrayEmpty;
				}
				var regVal = (string)key.GetValue("PreloadUsers");
				if (regVal.Length <= 36) return new string[] { regVal };

				return ((string)key.GetValue("PreloadUsers")).Split(separators, StringSplitOptions.RemoveEmptyEntries);
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Legt die Liste der Mitarbeiter fest, deren Kalender beim Start geladen werden sollen.
		/// </summary>
		/// <param name="userPKs">Ein Zeichenfolgen-Array mit den Primärschlüsseln der betreffenden Mitarbeiter.</param>
		public static void SetPreloadUserList(string[] userPKs)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < userPKs.Length; i++)
			{
				if (i == 0)
				{
					sb.Append(userPKs[i]);
				}
				else
				{
					sb.Append($";{userPKs[i]}");
				}
			}
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("PreloadUsers", sb.ToString());
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Benutzers zurück, für den neue Kalendereinträge erstellt werden sollen.
		/// </summary>
		/// <returns></returns>
		public static string GetTargetUserKey()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				if (key.GetValue("TargetUserKey") == null)
				{
					SetTargetUserKey(string.Empty);
					return string.Empty;
				}
				return (string)key.GetValue("TargetUserKey");
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Legt den Primärschlüssel des Benutzers fest, für den neue Kalendereinträge erstellt werden sollen.
		/// </summary>
		/// <param name="userPK"></param>
		public static void SetTargetUserKey(string userPK)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("TargetUserKey", userPK);
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Gibt den Registrierungseintrag für die Anzahl der Monate zurück,
		/// die beim Laden des Kalenders zurückgeschaut wird.
		/// </summary>
		/// <returns></returns>
		public static int GetAppointmentAge()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AppointmentAgeInMonths") == null)
				{
					SetAppointmentAge(18);
					return 18;
				}
				return (int)key.GetValue("AppointmentAgeInMonths");
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Legt den Registrierungseintrag für die Anzahl der Monate fest,
		/// die beim Laden des Kalenders zurückgeschaut wird.
		/// </summary>
		/// <param name="ageInMonths"></param>
		public static void SetAppointmentAge(int ageInMonths)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AppointmentAgeInMonths", ageInMonths);
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Dieses Kennzeichen legt fest ob beim automatischen Ausfüllen eines Termins die
		/// Kundenadresse eingefügt werden soll.
		/// </summary>
		/// <returns></returns>
		public static bool GetAddCustomerAddressFlag()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AddCustomerAddressFlag") == null)
				{
					SetAddCustomerAddressFlag(true);
					return true;
				}
				return (int)key.GetValue("AddCustomerAddressFlag") == 1;
			}
			finally
			{
				key.Close();
			}
		}

		/// <summary>
		/// Dieses Kennzeichen legt fest ob beim automatischen Ausfüllen eines Termins die
		/// Kundenadresse eingefügt werden soll.
		/// </summary>
		public static void SetAddCustomerAddressFlag(bool flag)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AddCustomerAddressFlag", flag == true ? 1 : 0);
			}
			finally
			{
				key.Close();
			}
		}

		public static bool GetAddCustomerInfoFlag()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AddCustomerInfoFlag") == null)
				{
					SetAddCustomerInfoFlag(true);
					return true;
				}
				return (int)key.GetValue("AddCustomerInfoFlag") == 1;
			}
			finally
			{
				key.Close();
			}
		}

		public static void SetAddCustomerInfoFlag(bool flag)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AddCustomerInfoFlag", flag == true ? 1 : 0);
			}
			finally
			{
				key.Close();
			}
		}

		public static bool GetAddCustomerNotesFlag()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AddCustomerNotesFlag") == null)
				{
					SetAddCustomerNotesFlag(true);
					return true;
				}
				return (int)key.GetValue("AddCustomerNotesFlag") == 1;
			}
			finally
			{
				key.Close();
			}
		}

		public static void SetAddCustomerNotesFlag(bool flag)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AddCustomerNotesFlag", flag == true ? 1 : 0);
			}
			finally
			{
				key.Close();
			}
		}

		public static bool GetAddCustomerPriceListFlag()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AddCustomerPriceListFlag") == null)
				{
					SetAddCustomerPriceListFlag(true);
					return true;
				}
				return (int)key.GetValue("AddCustomerPriceListFlag") == 1;
			}
			finally
			{
				key.Close();
			}
		}

		public static void SetAddCustomerPriceListFlag(bool flag)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AddCustomerNotesFlag", flag == true ? 1 : 0);
			}
			finally
			{
				key.Close();
			}
		}

		public static bool GetCreateServiceReport()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("CreateServiceReportFlag") == null)
				{
					SetCreateServiceReport(true);
					return true;
				}
				return (int)key.GetValue("CreateServiceReportFlag") == 1;
			}
			finally
			{
				key.Close();
			}
		}

		public static void SetCreateServiceReport(bool flag)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("CreateServiceReportFlag", flag == true ? 1 : 0);
			}
			finally
			{
				key.Close();
			}
		}

		public static int GetAppointmentColor()
		{
			var key = myHKCU.OpenSubKey(myRegPath, false);
			try
			{
				if (key.GetValue("AppointmentColor") == null)
				{
					SetAppointmentColor(0);
					return 0;
				}
				return (int)key.GetValue("AppointmentColor");
			}
			finally
			{
				key.Close();
			}
		}

		public static void SetAppointmentColor(int aRGB)
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			try
			{
				if (key == null)
				{
					var msg = $@"Ich bekomme auf den Registrierungspfad {myHKCU.ToString()}\{myRegPath} keinen Zugriff.";
					throw new ApplicationException(msg);
				}
				key.SetValue("AppointmentColor", aRGB);
			}
			finally
			{
				key.Close();
			}
		}

		#endregion

	}
}
