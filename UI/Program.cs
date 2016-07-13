//#define LOCAL
//#define ADMINTEST
//#define MAILTEST
//#define HISTORYUPDATE
//#define DEFAULT

using System;
using System.Diagnostics;
using System.Windows.Forms;
using Products.Common.Views;
using Products.Model.Entities;
using Products.Model;

namespace Products.Common
{
	static class Program
	{

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += Application_ThreadException;
			//Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ApplicationExit += Application_ApplicationExit;
			try
			{
				InitSettings();
			}
			catch (Exception ex)
			{
				throw ex;
			}

#if (HISTORYUPDATE)

			Data.DataManager.DataService.AddInvoicesToHistory();

#endif

#if (MAILTEST)

			ServiceManager.PostOffice(Model.ModelManager.ModelService.GetCurrentUser().DavidLoginName, Common.Global.SenderPW).SendEmail("a_ullrich@msn.com", "Anmeldung", "Axel hat sich gerade angemeldet und schickt die Mail auch außer Haus. Geil.");
 
#endif

#if (ADMINTEST == true)
		{
			//if (user == "Felix Deutz" || user == "Matthias Deutz" | user == "Johannes Düwel") //user == "Axel Ullrich" || 
			if (user == "Axel Ullrich" || user == "Felix Deutz" || user == "Matthias Deutz" | user == "Johannes Düwel")
			{
				Application.Run(new AdminCCView());
			}
			else
			{
				Application.Run(new CpmMainView());
			}
		}
#else
		Application.Run(new CpmMainView()); 		
#endif

		}

		#region static procedures

		static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			try
			{
				Exception ex = e.Exception;
				if (!EventLog.SourceExists("Application Error"))
				{
					EventLog.CreateEventSource("Application Error", "Application");
				}
				var myLog = new EventLog();
				myLog.Source = "Application Error";
				myLog.WriteEntry("Catalist application error. " + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace, EventLogEntryType.Error);
				ServiceManager.Logger.WriteLogEntry(DateTime.Now + ": " + ex.Message);
			}
			catch (Exception exc)
			{
				try
				{
					MessageBox.Show("Fatal Non-UI Error. Couldn't write the error to the event log. Reason: " + exc.Message, "Fatal Non-UI Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				finally
				{
					Application.Exit();
				}
			}
		}

		public static void ShowCalendar()
		{
			KalenderView kv = null;
			var forms = Application.OpenForms;
			foreach (var form in forms)
			{
				if (form is KalenderView)
				{
					kv = form as KalenderView;
					break;
				}
			}
			if (kv == null)	// Kalender ist noch nicht geöffnet.
			{
				User currentUser = ModelManager.UserService.CurrentUser;
				kv = new KalenderView(new ViewController.CalendarViewController(currentUser));
			}
			if (kv.WindowState == FormWindowState.Minimized)
			{
				kv.WindowState = FormWindowState.Normal;
			}
			kv.Show();
			kv.Focus();
		}

		#endregion

		#region event handler

		static void Application_ApplicationExit(object sender, EventArgs e)
		{
			// Shutdown the TapiManager.
			Agfeo.FonManager.FonService.Shutdown();
			Model.ModelManager.ReminderService.ShutdownScheduler();
		}
	
		#endregion

		#region private procedures

		private static void InitSettings()
		{
			Products.Common.Global.AtapiLineName = Properties.Settings.Default.ATAPI_Line;
			Products.Common.Global.CatalogTemplateFilePath = Properties.Settings.Default.CatalogTemplateFilePath;
			Products.Common.Global.CustomerCatalogPath = Properties.Settings.Default.CatalogPath;
			Products.Common.Global.ManufacturerPicturePath = Properties.Settings.Default.ManufacturerPicturePath;
			Products.Common.Global.OfferFilePath = Properties.Settings.Default.OfferFilePath;
			Products.Common.Global.PicturePath = Properties.Settings.Default.PicturePath;
			Products.Common.Global.ProductPicturePath = Properties.Settings.Default.ProductPicturePath;
			Products.Common.Global.SageExePath = Properties.Settings.Default.Sage_ExePath;
			Products.Common.Global.SageUser = Properties.Settings.Default.UserInSage;
			decimal taxRate;
			if (decimal.TryParse(Properties.Settings.Default.TaxRate, out taxRate))
			{
				Products.Common.Global.TaxRateMultiplier = taxRate;
			}
			else
			{
				Products.Common.Global.TaxRateMultiplier = 1.19m;
			}
			Products.Common.Global.BingMapsURL = Properties.Settings.Default.BingMapsUrl;
			Products.Common.Global.SmtpServer = Properties.Settings.Default.SmtpServer;
			Products.Common.Global.SmtpPort = int.Parse(Properties.Settings.Default.SmtpPort);
			Products.Common.Global.SenderEmailAddress = Properties.Settings.Default.SenderEmailAddress;
			Products.Common.Global.SenderPW = Properties.Settings.Default.SenderPW;
			Products.Common.Global.DavidArchivePath = Properties.Settings.Default.DavidArchivePath;
			Products.Common.Global.LinkedFilesPath = Properties.Settings.Default.LinkedFilesPath;
			Products.Common.Global.TemplatePath = Properties.Settings.Default.TemplatePath;
			Products.Common.Global.Signature = Properties.Settings.Default.Signature;
		}

		#endregion

	}

}
