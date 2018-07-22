using System;
using Microsoft.Win32;

namespace CatalistRegistry
{
	public static class Application
	{
		#region MEMBERS

		static RegistryKey myHKCU = Registry.CurrentUser;
		static string myRegPath = @"Software\UllrichIT\Catalist\Application";

		#endregion MEMBERS

		#region ### .ctor ###

		static Application()
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			if (key == null) myHKCU.CreateSubKey(myRegPath);
			key.Close();
		}

		#endregion ### .ctor ###

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Legt den Benutzernamen für den AGFEO TAPI Zugriff fest.
		/// </summary>
		public static string ATAPI_Line
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ATAPI_Line") == null)
					{
						ATAPI_Line = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("ATAPI_Line");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("ATAPI_Line", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string UserInSage
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("UserInSage") == null)
					{
						UserInSage = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("UserInSage");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("UserInSage", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string Sage_ExePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("Sage_ExePath") == null)
					{
						Sage_ExePath = @"\\Cpm-dc\sage new classic\2014\EXE\CL.EXE";
						return @"\\Cpm-dc\sage new classic\2014\EXE\CL.EXE";
					}
					return (string)key.GetValue("Sage_ExePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("Sage_ExePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string CatalogPath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("CatalogPath") == null)
					{
						CatalogPath = @"\\cpm-dc\sage_ncl\catalist\kundenkataloge\";
						return @"\\cpm-dc\sage_ncl\catalist\kundenkataloge\";
					}
					return (string)key.GetValue("CatalogPath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("CatalogPath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string CatalogTemplateFilePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("CatalogTemplateFilePath") == null)
					{
						CatalogTemplateFilePath = @"\\cpm-dc\sage_ncl\catalist\template\catalogtemplate.docx";
						return @"\\cpm-dc\sage_ncl\catalist\template\catalogtemplate.docx";
					}
					return (string)key.GetValue("CatalogTemplateFilePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("CatalogTemplateFilePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static double TaxRate
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("TaxRate") == null)
					{
						key.SetValue("TaxRate", 119, RegistryValueKind.DWord);
						return 1.19;
					}
					return Convert.ToDouble((int)key.GetValue("TaxRate")) / 100;
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("TaxRate", value * 100, RegistryValueKind.DWord);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string PicturePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("PicturePath") == null)
					{
						PicturePath = @"\\cpm-dc\sage_ncl\catalist\graphics\";
						return @"\\cpm-dc\sage_ncl\catalist\graphics\";
					}
					return (string)key.GetValue("PicturePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("PicturePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string ManufacturerPicturePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ManufacturerPicturePath") == null)
					{
						ManufacturerPicturePath = @"\\cpm-dc\sage_ncl\catalist\graphics\manufacturer\";
						return @"\\cpm-dc\sage_ncl\catalist\graphics\manufacturer\";
					}
					return (string)key.GetValue("ManufacturerPicturePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("ManufacturerPicturePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string ProductPicturePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ProductPicturePath") == null)
					{
						ProductPicturePath = @"\\cpm-dc\sage_ncl\catalist\graphics\productpics";
						return @"\\cpm-dc\sage_ncl\catalist\graphics\productpics";
					}
					return (string)key.GetValue("ProductPicturePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("ProductPicturePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string OfferFilePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("OfferFilePath") == null)
					{
						OfferFilePath = @"\\Cpm-dc\sage_ncl\catalist\offers\";
						return @"\\Cpm-dc\sage_ncl\catalist\offers\";
					}
					return (string)key.GetValue("OfferFilePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("OfferFilePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int CommandPanelVisibleTime
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("CommandPanelVisibleTime") == null)
					{
						CommandPanelVisibleTime = 3000;
						return 3000;
					}
					return (int)key.GetValue("CommandPanelVisibleTime");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("CommandPanelVisibleTime", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string BingMapsUrl
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("BingMapsUrl") == null)
					{
						BingMapsUrl = @"http://www.bing.com/maps/default.aspx?where1=";
						return @"http://www.bing.com/maps/default.aspx?where1=";
					}
					return (string)key.GetValue("BingMapsUrl");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("BingMapsUrl", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string SmtpServer
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("SmtpServer") == null)
					{
						SmtpServer = "192.168.0.102";
						return "192.168.0.102";
					}
					return (string)key.GetValue("SmtpServer");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("SmtpServer", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int SmtpPort
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("SmtpPort") == null)
					{
						SmtpPort = 25;
						return 25;
					}
					return (int)key.GetValue("SmtpPort");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("SmtpPort", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string SenderEmailAddress
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("SenderEmailAddress") == null)
					{
						SenderEmailAddress = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("SenderEmailAddress");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("SenderEmailAddress", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string SenderPW
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("SenderPW") == null)
					{
						SenderPW = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("SenderPW");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("SenderPW", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string DavidArchivePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("DavidArchivePath") == null)
					{
						DavidArchivePath = @"\\david\david\archive\user\";
						return @"\\david\david\archive\user\";
					}
					return (string)key.GetValue("DavidArchivePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("DavidArchivePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string LinkedFilesPath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("LinkedFilesPath") == null)
					{
						LinkedFilesPath = @"\\Cpm-dc\sage_ncl\catalist\dateilinks\";
						return @"\\Cpm-dc\sage_ncl\catalist\dateilinks\";
					}
					return (string)key.GetValue("LinkedFilesPath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("LinkedFilesPath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string TemplatePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("TemplatePath") == null)
					{
						TemplatePath = @"\\cpm-dc\sage_ncl\catalist\template\";
						return @"\\cpm-dc\sage_ncl\catalist\template\";
					}
					return (string)key.GetValue("TemplatePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("TemplatePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string Signature
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("Signature") == null)
					{
						Signature = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("Signature");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("Signature", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string AppointmentArchivePath
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("AppointmentArchivePath") == null)
					{
						AppointmentArchivePath = @"\\david\david\archive\group\b";
						return @"\\david\david\archive\group\b";
					}
					return (string)key.GetValue("AppointmentArchivePath");
				}
				finally
				{
					key.Close();
				}
			}
			set
			{
				var key = myHKCU.OpenSubKey(myRegPath, true);
				try
				{
					CheckRegAccess(key);
					key.SetValue("AppointmentArchivePath", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		#endregion PUBLIC PROPERTIES

		#region PRIVATE PROCEDURES

		static void CheckRegAccess(RegistryKey key)
		{
			if (key == null)
			{
				var msg = $"Ich konnte auf den Registrierungsschlüssel {key} nicht zugreifen.";
				throw new UnauthorizedAccessException(msg);
			}
		}

		#endregion PRIVATE PROCEDURES
	}
}
