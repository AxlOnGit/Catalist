using System;
using System.Diagnostics;
using System.IO;

namespace Products.Common
{
	public static class Utils
	{

		public enum QuarterType
		{
			Previous,
			Current,
			Next
		}

		#region members

		readonly static File_CRC32 fileCrc32 = new File_CRC32();

		#endregion

		#region public procedures

		/// <summary>
		/// Returns the german month string for the int's month.
		/// </summary>
		/// <param name="month"></param>
		/// <returns></returns>
		public static string GetMonthString(int month)
		{
			switch (month)
			{
				case 1:
					return "Januar";
				case 2:
					return "Februar";
				case 3:
					return "März";
				case 4:
					return "April";
				case 5:
					return "Mai";
				case 6:
					return "Juni";
				case 7:
					return "Juli";
				case 8:
					return "August";
				case 9:
					return "September";
				case 10:
					return "Oktober";
				case 11:
					return "November";
				default:
					return "Dezember";
			}
		}

		/// <summary>
		/// Returns a string correpsonding to the pattern 'X. Quartal' depending on
		/// the current date and the given quarterType enum.
		/// </summary>
		/// <param name="quarterType"></param>
		/// <returns></returns>
		public static string GetQuarterString(QuarterType quarterType)
		{
			var currentQuarter = GetQuarter(DateTime.Today);

			switch (quarterType)
			{
				case QuarterType.Previous:
					if (currentQuarter > 1)
					{
						return string.Format("{0}. Quartal {1}", currentQuarter - 1, DateTime.Today.Year);
					}
					else
					{
						return string.Format("4. Quartal {0}", DateTime.Today.Year - 1);
					}

				case QuarterType.Current:
					return string.Format("{0}. Quartal {1}", currentQuarter, DateTime.Today.Year);

				case QuarterType.Next:
					if (currentQuarter == 4)
					{
						return string.Format("1. Quartal {0}", DateTime.Today.Year + 1);
					}
					else
					{
						return string.Format("{0}. Quartal {1}", currentQuarter + 1, DateTime.Today.Year);
					}

				default:
					return string.Empty;
			}
		}

		/// <summary>
		/// Returns the number of the quarter for the given date.
		/// </summary>
		/// <param name="forDate"></param>
		/// <returns></returns>
		public static int GetQuarter(DateTime forDate) 
		{
			if (forDate.Month == 1 || forDate.Month == 2 || forDate.Month == 3)
			{
				return 1;
			}
			if (forDate.Month == 4 || forDate.Month == 5 || forDate.Month == 6)
			{
				return 2;
			}
			if (forDate.Month == 7 || forDate.Month == 8 || forDate.Month == 9)
			{
				return 3;
			}
			return 4;
		}

		/// <summary>
		/// Returns the first day of the given datetime's month.
		/// </summary>
		/// <param name="forDate"></param>
		/// <returns></returns>
		public static DateTime GetFirstOfMonth(DateTime forDate)
		{
			return forDate.AddDays(-forDate.Day + 1);
		}

		/// <summary>
		/// Returns the last day of the given datetime's month.
		/// </summary>
		/// <param name="forDate"></param>
		/// <returns></returns>
		public static DateTime GetLastOfMonth(DateTime forDate)
		{
			var lastOfMonth = forDate.AddDays(32);
			return lastOfMonth.AddDays(-lastOfMonth.Day);
		}

		public static DateTime GetFirstOfPreviousMonth(DateTime forDate)
		{
			return GetFirstOfMonth(GetLastOfPreviousMonth(forDate));
		}

		public static DateTime GetLastOfPreviousMonth(DateTime forDate)
		{
			return GetFirstOfMonth(forDate).AddDays(-1);
		}

		public static DateTime GetFirstOfThisQuarter(DateTime forDate)
		{
			var quarter = GetQuarter(forDate);

			switch (quarter)
			{
				case 1:
					return new DateTime(forDate.Year, 1, 1);

				case 2:
					return new DateTime(forDate.Year, 4, 1);

				case 3:
					return new DateTime(forDate.Year, 7, 1);

				default:
					return new DateTime(forDate.Year, 10, 1);
			}
		}

		public static DateTime GetLastOfThisQuarter(DateTime forDate)
		{
			var quarter = GetQuarter(forDate);

			switch (quarter)
			{
				case 1:
					return new DateTime(forDate.Year, 3, 31);

				case 2:
					return new DateTime(forDate.Year, 6, 30);

				case 3:
					return new DateTime(forDate.Year, 9, 30);
				
				default:
					return new DateTime(forDate.Year, 12, 31);
			}
		}

		public static DateTime GetFirstOfPreviousQuarter(DateTime forDate)
		{
			var quarter = GetQuarter(forDate);

			switch (quarter)
			{
				case 1:
					return new DateTime(forDate.Year - 1, 10, 1);

				case 2:
					return new DateTime(forDate.Year, 1, 1);

				case 3:
					return new DateTime(forDate.Year, 4, 1);

				default:
					return new DateTime(forDate.Year, 7, 1);
			}
		}

		public static DateTime GetLastOfPreviousQuarter(DateTime forDate)
		{
			var quarter = GetQuarter(forDate);

			switch (quarter)
			{
				case 1:
					return new DateTime(forDate.Year - 1, 12, 31);

				case 2:
					return new DateTime(forDate.Year, 3, 31);

				case 3:
					return new DateTime(forDate.Year, 6, 30);
				
				default:
					return new DateTime(forDate.Year, 9, 30);
			}

		}

		/// <summary>
		/// Gibt den CRC32 Wert für den angegebenen Dateinamen zurück.
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static string GetCRC32(string filename)
		{
			return fileCrc32.GetCRC32(filename).ToString("X");
		}

		/// <summary>
		/// Öffnet das angegebene Verzeichnis im Datei Explorer.
		/// </summary>
		/// <param name="filePath">Das anzuzeigende Verzeichnis.</param>
		public static void OpenInExplorer(string filePath)
		{
			if (Directory.Exists(filePath))
			{
				Process.Start("explorer.exe", filePath);
			}
		}

		#endregion

	}
}
