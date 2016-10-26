using System;

namespace Products.Common
{
	public static class Global
	{

		#region constants

		public const int MinutesPerDay = 86400;

		#endregion

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

		#endregion

		#region public properties

		public static string AppointmentArchivePath { get; set; }

		public static string AtapiLineName { get; set; }
		public static string BingMapsURL { get; set; }
		public static string CatalogTemplateFilePath { get; set; }
		public static string CustomerCatalogPath { get; set; }
		public static string DavidArchivePath { get; set; }
		public static string LinkedFilesPath { get; set; }
		public static string ManufacturerPicturePath { get; set; }
		public static string OfferFilePath { get; set; }
		public static string PicturePath { get; set; }
		public static string ProductPicturePath { get; set; }
		public static string SageExePath { get; set; }
		public static string SageUser { get; set; }
		public static string SenderEmailAddress { get; set; }
		public static string SenderPW { get; set; }
		public static string Signature { get; set; }
		public static string SmtpServer { get; set; }
		public static int SmtpPort { get; set; }
		public static decimal TaxRateMultiplier { get; set; }
		public static string TemplatePath { get; set; }
		public static string UserName(string loginName)
		{
			if (loginName == "Axel")
			{
				return "Axel Ullrich";
			}
			if (loginName == "eduard")
			{
				return "Eduard Apelhans";
			}
			if (loginName == "Eva")
			{
				return "Eva Averdiek";
			}
			if (loginName == "Felix")
			{
				return "Felix Deutz";
			}
			if (loginName == "Johannes")
			{
				return "Johannes Düwel";
			}
			if (loginName == "Julian")
			{
				return "Julian Zwillich";
			}
			if (loginName == "Mario")
			{
				return "Mario Heidemann";
			}
			if (loginName == "Markus")
			{
				return "Markus Sprehe";
			}
			if (loginName == "MarkusR")
			{
				return "Markus Roggenkamp";
			}
			if (loginName == "Matthias")
			{
				return "Mathias Deutz";
			}
			if (loginName == "Rupert")
			{
				return "Rupert Deutz";
			}
			if (loginName == "Saskia")
			{
				return "Saskia Pollmeier";
			}
			if (loginName == "Sezen")
			{
				return "Sezen Colak";
			}
			if (loginName == "Tanja")
			{
				return "Tanja Trentmann";
			}
			return "Kennichnich";
		}

		public static DateTime MySqlNullDate
		{
			get { return new DateTime(1970, 1, 1, 0, 0, 0); }
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Returns the URL for opening a BING Map with the
		/// </summary>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <returns></returns>
		public static string CreateBingMapsURL(string street, string city)
		{
			return string.Format("{0}{1}, {2}&style=r&dir=0", BingMapsURL, street, city);
		}

		#endregion

	}

}
