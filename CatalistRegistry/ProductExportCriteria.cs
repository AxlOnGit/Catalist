using System;
using Microsoft.Win32;

namespace CatalistRegistry
{
	public static class ProductExportCriteria
	{

		#region MEMBERS

		static RegistryKey myHKCU = Registry.CurrentUser;
		static string myRegPath = @"Software\UllrichIT\Catalist\ProductExportCriteria";

		#endregion MEMBERS

		#region ### .ctor ###

		static ProductExportCriteria()
		{
			var key = myHKCU.OpenSubKey(myRegPath, true);
			if (key == null) myHKCU.CreateSubKey(myRegPath);
			key.Close();
		}

		#endregion

		#region PUBLIC PROPERTIES

		public static int ArtikelbezeichnungFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ArtikelbezeichnungFlag") == null)
					{
						ArtikelbezeichnungFlag = 1;
						return 30000;
					}
					return (int)key.GetValue("ArtikelbezeichnungFlag");
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
					key.SetValue("ArtikelbezeichnungFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int ArtikelnummerFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ArtikelnummerFlag") == null)
					{
						ArtikelnummerFlag = 1;
						return 1;
					}
					return (int)key.GetValue("ArtikelnummerFlag");
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
					key.SetValue("ArtikelnummerFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int ArtikelzusatzFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ArtikelzusatzFlag") == null)
					{
						ArtikelzusatzFlag = 1;
						return 1;
					}
					return (int)key.GetValue("ArtikelzusatzFlag");
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
					key.SetValue("ArtikelzusatzFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int EinkaufspreisFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("EinkaufspreisFlag") == null)
					{
						EinkaufspreisFlag = 1;
						return 1;
					}
					return (int)key.GetValue("EinkaufspreisFlag");
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
					key.SetValue("EinkaufspreisFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string ExportPfad
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("ExportPfad") == null)
					{
						ExportPfad = string.Empty;
						return string.Empty;
					}
					return (string)key.GetValue("ExportPfad");
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
					key.SetValue("ExportPfad", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int KatalogkategorieFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("KatalogkategorieFlag") == null)
					{
						KatalogkategorieFlag = 1;
						return 1;
					}
					return (int)key.GetValue("KatalogkategorieFlag");
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
					key.SetValue("KatalogkategorieFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int KundenpreisFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("KundenpreisFlag") == null)
					{
						KundenpreisFlag = 1;
						return 1;
					}
					return (int)key.GetValue("KundenpreisFlag");
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
					key.SetValue("KundenpreisFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int KundenrabattFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("KundenrabattFlag") == null)
					{
						KundenrabattFlag = 1;
						return 1;
					}
					return (int)key.GetValue("KundenrabattFlag");
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
					key.SetValue("KundenrabattFlag", value);
				}
				finally
				{
					key.Close();
				}

			}
		}

		public static int MengeneinheitFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("MengeneinheitFlag") == null)
					{
						MengeneinheitFlag = 1;
						return 1;
					}
					return (int)key.GetValue("MengeneinheitFlag");
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
					key.SetValue("MengeneinheitFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int NurRabattierteFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("NurRabattierteFlag") == null)
					{
						NurRabattierteFlag = 1;
						return 1;
					}
					return (int)key.GetValue("NurRabattierteFlag");
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
					key.SetValue("NurRabattierteFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int StaffelpreiseFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("StaffelpreiseFlag") == null)
					{
						StaffelpreiseFlag = 1;
						return 1;
					}
					return (int)key.GetValue("StaffelpreiseFlag");
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
					key.SetValue("StaffelpreiseFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int TabelleAnzeigenFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("TabelleAnzeigenFlag") == null)
					{
						TabelleAnzeigenFlag = 1;
						return 1;
					}
					return (int)key.GetValue("TabelleAnzeigenFlag");
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
					key.SetValue("TabelleAnzeigenFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static string Tabellenfarbe
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("Tabellenfarbe") == null)
					{
						Tabellenfarbe = "DarkBlue";
						return "DarkBlue";
					}
					return (string)key.GetValue("Tabellenfarbe");
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
					key.SetValue("Tabellenfarbe", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		public static int VerkaufspreisFlag
		{
			get
			{
				var key = myHKCU.OpenSubKey(myRegPath, false);
				try
				{
					CheckRegAccess(key);
					if (key.GetValue("VerkaufspreisFlag") == null)
					{
						VerkaufspreisFlag = 1;
						return 1;
					}
					return (int)key.GetValue("VerkaufspreisFlag");
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
					key.SetValue("VerkaufspreisFlag", value);
				}
				finally
				{
					key.Close();
				}
			}
		}

		#endregion

		#region PRIVATE PROCEDURES

		static void CheckRegAccess(RegistryKey key)
		{
			if (key == null)
			{
				var msg = $"Ich konnte auf den Registrierungsschlüssel {key} nicht zugreifen.";
				throw new UnauthorizedAccessException(msg);
			}
		}

		#endregion

	}
}
