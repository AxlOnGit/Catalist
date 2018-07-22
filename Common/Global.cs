using System;

namespace Products.Common
{
	public static class Global
	{
		#region constants

		public const int MinutesPerDay = 86400;

		#endregion constants

		#region public enums

		public enum CalendarShowAsTypes
		{
			ShowAsBusy = 0,
			ShowAsFree = 1,
			ShowAsOutOfOffice = 2,
			ShowAsPreliminary = 3
		}

		/// <summary>
		/// Archivtypen im David
		/// </summary>
		public enum DavidArchiveTypes
		{
			Adressen,
			Aufgaben,
			Postausgang,
			Posteingang,
			Kalender,
			Kalenderarchiv,
			Wiedervorlagen
		}

		[Flags]
		public enum SendInfoTypes
		{
			SendEmail = 0,
			SendFax = 1,
			SendLetter = 2
		}

		#endregion public enums

		#region public properties

		public static string CmdArgs { get; set; }

		public static string CustomerCatalogPath { get; set; }

		#endregion public properties

		#region public procedures

		/// <summary>
		/// Returns the URL for opening a BING Map with the
		/// </summary>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <returns></returns>
		public static string CreateBingMapsURL(string street, string city)
			=> string.Format("{0}{1}, {2}&style=r&dir=0", CatalistRegistry.Application.BingMapsUrl, street, city);

		#endregion public procedures
	}
}