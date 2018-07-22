//#define LOCAL
//#define ADMINTEST
//#define MAILTEST
//#define HISTORYUPDATE
//#define DEFAULT

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common
{
	static class Program
	{
		#region MEMBERS

		static bool firstInstance;

		#endregion MEMBERS

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Mutex mutex = new Mutex(true, "FirstCatalist", out firstInstance);
			if (firstInstance)
			{
				RunMe(args);
			}
			else MessageBox.Show("Läuft schon. Bitte in der Taskleiste oder das kleine Symbol rechts unten aktivieren.");
		}

		static void RunMe(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ApplicationExit += Application_ApplicationExit;
			Application.ThreadException += Application_ThreadException;

			if (args.Length > 0)
			{
				if (args[0] == "NoErrorHandling")
				{
					Application.ThreadException -= Application_ThreadException;
				}
				else if (args[0] == "AppointmentListener")
				{
					David.DavidManager.SetAppointmentListener(true);
				}
				Global.CmdArgs = args[0];
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

		#region STATIC PROCEDURES

		static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
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
				var msg = string.Format("{0} - Error: {1}\n\nStack Trace:\n{2}", DateTime.Now, ex.Message, ex.StackTrace);
				myLog.WriteEntry(msg, EventLogEntryType.Error);
				Services.LogService.WriteLogEntry(msg);
			}
			catch (Exception exc)
			{
				try
				{
					var dummyForm = new Form();
					dummyForm.Size = new System.Drawing.Size(800, 600);
					dummyForm.StartPosition = FormStartPosition.CenterScreen;
					MetroMessageBox.Show(dummyForm, "Fatal Non-UI Error. Couldn't write the error to the event log. Reason: " + exc.Message, "Fatal Non-UI Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				finally
				{
					David.DavidManager.DavidService.Shutdown();
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
			if (kv == null) // Kalender ist noch nicht geöffnet.
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

		#endregion STATIC PROCEDURES

		#region EVENT HANDLER

		static void Application_ApplicationExit(object sender, EventArgs e)
		{
			// Shutdown des TapiManager, ReminderService und der David-Notifications.
			David.DavidManager.DavidService.Shutdown();
			Agfeo.FonManager.FonService.Shutdown();
			ModelManager.ReminderService.ShutdownScheduler();
		}

		#endregion EVENT HANDLER

	}
}