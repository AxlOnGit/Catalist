using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Agfeo;
using MetroFramework;
using MetroFramework.Forms;
using Products.Common.Collections;
using Products.Common.Extensions;
using Products.Common.Geocoding;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CpmMainView : MetroForm
	{
		#region delegates

		delegate void CustomerGeneralViewOpenDelegate(string customerId);

		delegate void ShowReminderDelegate(Reminder reminder);

		// If the phone rings we handle an event that's fired by the Agfeo module's thread. For this
		// a delegate is needed that will be invoked by that event.
		CustomerGeneralViewOpenDelegate cgvoDelegate;

		#endregion delegates

		#region members

		List<Kunde> myRecentCustomerList = new List<Kunde>();
		Kunde myProductCustomer;
		Model.Services.AppointmentService myAppointmentService = ModelManager.AppointmentService;
		bool quit;

		#endregion members

		#region private properties

		public string SearchText { get; set; }

		// public string ProductSearchText { get; set; }

		#endregion private properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CpmMainView Klasse.
		/// </summary>
		public CpmMainView()
		{
			InitializeComponent();
			this.Text = "Cut and Print Media";
			this.mlblVersion.Text = string.Format("Ver. {0}", Application.ProductVersion);
			this.mtxtSearch.DataBindings.Add("Text", this, "SearchText");
			ModelManager.CustomerService.CurrentCustomerSet += CustomerService_CurrentCustomerSet;
			this.CustomerService_CurrentCustomerSet(this, EventArgs.Empty);
			if (ModelManager.UserService.CurrentUser != null)
			{
				this.mlblCurrentUser.Text = string.Format("Tach {0}", ModelManager.UserService.CurrentUser.NameFirst);
			}
			this.SetClock();
			this.btnTest.Visible |= ModelManager.UserService.CurrentUser.LoginWindows.ToLower() == "axel";
			try
			{
				if (!David.DavidManager.DavidService.WithAppointmentListener && FonManager.FonService.ServerReachable())
				{
					var fonService = FonManager.FonService;
					fonService.InitTapi(true, ModelManager.UserService.CurrentUser.AgfeoLoginName);
					this.SammirmalWennsKlingelt();
					cgvoDelegate = new CustomerGeneralViewOpenDelegate(ShowCustomerDashboardView);
					picCPM.BackColor = Color.Transparent;
				}
				else picCPM.BackColor = Color.FromArgb(64, 255, 0, 0);

				if (David.DavidManager.DavidService.WithAppointmentListener)
				{
					this.WindowState = FormWindowState.Minimized;
					picCPM.BackColor = Color.Transparent;
				}
			}
			catch
			{
				var msg = "Die Telefonanlage konnte nicht initialisiert werden.";
				MetroMessageBox.Show(this, msg, "Nachricht von AGFEO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				if (!FonManager.FonService.Connected)
				{
					var logText = string.Format("{0}: Die Telefonanlage konnte für den Benutzer '{1}' nicht initialisiert werden.",
						DateTime.Now,
						ModelManager.UserService.CurrentUser.AgfeoLineName);
					Services.LogService.WriteLogEntry(logText);
				}
			}
			// David Notifications starten David.DavidManager.DavidService.NewAppointmentMailEvent += DavidService_NewAppointmentMailHandler;

			//this.AppointmentWorker.RunWorkerAsync();
			//MACHEN: ModelManager.ReminderService.JobReminderExecuted += new EventHandler<Model.Services.ReminderService.JobReminderExecutedEventArgs>(ReminderService_JobReminderExecuted);
		}

		//void DavidService_NewAppointmentMailHandler(object sender, David.API.ItemNotificationEventArgs e)
		//{
		//	var msg = string.Format("Neue Nachricht mit diesem Betreff: {0}", e.MsgItems2.GetItem(0).Subject);
		//	MessageBox.Show(msg, "Catalist - Nachrichtensystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//}

		void CustomerService_CurrentCustomerSet(object sender, EventArgs e)
		{
			var kunde = ModelManager.CustomerService.CurrentCustomer;
			if (kunde != null)
			{
				this.mlnkCurrentCustomer.Text = kunde.Matchcode;
				this.mlnkCurrentCustomer.Tag = kunde;
			}
		}

		#endregion ### .ctor ###

		#region AGFEO

		public void SammirmalWennsKlingelt()
		{
			FonManager.FonService.SomeoneIsCalling += DatMachIchWennsKlingelt;
			this.btnLineOpen.BackgroundImage = Properties.Resources.telefon_32_metrogreen;
		}

		public void MirScheißegalObsKlingelt()
		{
			FonManager.FonService.SomeoneIsCalling -= DatMachIchWennsKlingelt;
			this.btnLineOpen.BackgroundImage = Properties.Resources.telefon_32_metrogray;
		}

		void DatMachIchWennsKlingelt(object sender, IncomingCallEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(cgvoDelegate, e.CallerNumber);
			}
		}

		#endregion AGFEO

		#region event handler

		void ReminderService_JobReminderExecuted(object sender, Model.Services.ReminderService.JobReminderExecutedEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new ShowReminderDelegate(ShowReminder), e.ReminderJob);
			}
		}

		void CpmMainView_MouseEnter(object sender, EventArgs e)
		{
			//if (!this.Focused)
			//{
			//	this.Focus();
			//}
		}

		#region tiles

		void mpicLineOpen_Click(object sender, EventArgs e)
		{
			if (Agfeo.FonManager.FonService.IsListening)
			{
				MirScheißegalObsKlingelt();
				btnLineOpen.BackgroundImage = global::Products.Common.Properties.Resources.telefon_32_metrogray;
			}
			else
			{
				SammirmalWennsKlingelt();
				btnLineOpen.BackgroundImage = global::Products.Common.Properties.Resources.telefon_32_metrogreen;
			}
		}

		void mtileArtikel_Click(object sender, EventArgs e)
		{
			this.ShowAppointmentListView();
		}

		void ShowAppointmentListView()
		{
			User currentUser = ModelManager.UserService.CurrentUser;
			var alv = new AppointmentListView(ModelManager.AppointmentService.GetAppointmentList(currentUser), currentUser.NameFirst);
			alv.Show();
		}

		void ShowArtikelstammView()
		{
			var asv = new ArtikelstammView();
			asv.Show();
		}

		void mtileKalender_Click(object sender, EventArgs e)
		{
			ShowCalendarView();
		}

		void mtileAngebote_Click(object sender, EventArgs e)
		{
			var alv = new AngeboteListView();
			alv.Show();
			//ShowTaskListView();
		}

		void mtileKatalog_Click(object sender, EventArgs e)
		{
			CreateCatalog();
		}

		void mtileKataloginhalt_Click(object sender, EventArgs e)
		{
			ShowCatalogView();
		}

		void mtilePresets_Click(object sender, EventArgs e)
		{
			ShowVerwaltungsView();
		}

		void btnMinimize_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion tiles

		#region context menus

		void ctxCmdViewQuit_Click(object sender, EventArgs e)
		{
			this.KommWirHaunAbHierUndLassenDenScheiss();
		}

		void ctxCmdShowSettingsView_Click(object sender, EventArgs e)
		{
			this.ShowSettingsView();
		}

		void ctxCmdMaschinentypen_Click(object sender, EventArgs e)
		{
			var mmv = new ModellListView();
			mmv.Show();
		}

		void ctxCmdShowMainView_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
			this.ShowMainView();
		}

		#endregion context menus

		void mradioArtikel_CheckedChanged(object sender, EventArgs e)
		{
			if (this.mradioArtikel.Checked)
			{
				this.Style = MetroFramework.MetroColorStyle.Magenta;
				this.mtxtSearch.Style = MetroFramework.MetroColorStyle.Magenta;
				this.mtxtSearch.WaterMark = "Artikel-Nr. oder Artikelname";
			}
			else
			{
				this.Style = MetroFramework.MetroColorStyle.Lime;
				this.mtxtSearch.Style = MetroFramework.MetroColorStyle.Lime;
				this.mtxtSearch.WaterMark = "Kd - Nr, Firma, Seriennummer | STRG + Y = CPM";
			}
			this.Invalidate();
			this.mtxtSearch.CustomButton.Invalidate();
		}

		void CpmMainView_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.Y)
			{
				this.ShowCPM();
			}
		}

		void CpmMainView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				this.ShowCPM();
			}
		}

		void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SearchText = mtxtSearch.Text.Trim();
				if (this.mradioKunden.Checked)
				{
					SearchCustomer();
				}
				else
				{
					SearchProduct();
				}
			}
		}

		void mtxtSearch_ButtonClick(object sender, EventArgs e)
		{
			this.SearchText = this.mtxtSearch.Text;
			if (this.mradioKunden.Checked)
			{
				this.SearchCustomer();
			}
			else
			{
				this.SearchProduct();
			}
		}

		void mbtnShowRecentCustomers_Click(object sender, EventArgs e)
		{
			var rcv = new RecentCustomerListView(this.myRecentCustomerList);
			rcv.Show();
		}

		void btnTopMost_Click(object sender, EventArgs e)
		{
			TopMost = !TopMost;
			if (!TopMost)
			{
				this.btnTopMost.BackgroundImage = global::Products.Common.Properties.Resources.topmost_24_metrogray;
			}
			else
			{
				this.btnTopMost.BackgroundImage = global::Products.Common.Properties.Resources.topmost_24_metrored;
			}
		}

		void tBarIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ShowMainView();
			}
		}

		void picCPM_Click(object sender, EventArgs e)
		{
			ShowSettingsView();
		}

		void CpmMainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!quit)
			{
				this.Visible = false;
				e.Cancel = true;
			}
			else ModelManager.ReminderService.ShutdownScheduler();
		}

		void WhatClock_Click(object sender, EventArgs e)
		{
			this.KommWirHaunAbHierUndLassenDenScheiss();
		}

		void mlblVersion_Click(object sender, EventArgs e)
		{
			var args = Environment.GetCommandLineArgs();
			var msg = string.Empty;
			if (args.Length == 0)
			{
				msg = "Die Anwendung wurde ohne Befehlszeilenargumente gestartet";
			}
			else if (args.Length == 1)
			{
				msg = string.Format("Catalist wurde mit diesem Befehlszeilenargument gestartet:{0}{0} {1}", Environment.NewLine, args[0]);
			}
			else
			{
				var sb = new StringBuilder();
				for (int i = 1; i < args.Length; i++)
				{
					sb.AppendLine(args[i]);
				}
				msg = string.Format("Catalist wurde mit diesem Befehlszeilenargument gestartet:{0}{0}{1}", Environment.NewLine, sb);
			}
			MetroMessageBox.Show(this, msg, "Catalist Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void mtileQuit_Click(object sender, EventArgs e)
		{
			this.KommWirHaunAbHierUndLassenDenScheiss();
		}

		#region AppointmentWorker

		void AppointmentWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			User currentUser = null;
			try
			{
				var bw = sender as BackgroundWorker;
				var AppointmentListDictionary = new Dictionary<User, SBList<Appointment>>();
				foreach (var user in ModelManager.UserService.GetActiveUsersList())
				{
					currentUser = user;
					AppointmentListDictionary.Add(user, user.Terminliste);
				}
				e.Result = AppointmentListDictionary;
			}
			catch (Exception ex)
			{
				MetroMessageBox.Show(this, string.Format("User: {0}, Fehler: {1}{2}", currentUser, ex.Message + Environment.NewLine, ex.InnerException.Message), "Bullshit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void AppointmentWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			var appointmentDictionary = e.Result as Dictionary<User, SortableBindingList<Appointment>>;
			if (appointmentDictionary != null && appointmentDictionary.Count >= 0)
			{
				this.mtileKalender.Enabled = true;
			}
		}

		#endregion AppointmentWorker

		#endregion event handler

		#region private procedures

		void SetClock()
		{
			DateTime time = DateTime.Now;
			var isDayLight = TimeZoneInfo.Local.IsDaylightSavingTime(time);
			if (isDayLight)
			{
				this.WhatWatch.UtcOffset = new TimeSpan(2, 0, 0);
			}
			else
			{
				this.WhatWatch.UtcOffset = new TimeSpan(1, 0, 0);
			}
		}

		void ShowReminder(Reminder reminder)
		{
			var rv = new ReminderView(reminder);
			rv.Show();
		}

		void ShowMainView()
		{
			if (!this.Visible)
			{
				this.WindowState = FormWindowState.Normal;
				this.Visible = true;
			}
		}

		// Delegate function that's called by the SomeoneIsCalling event handler.
		void ShowCustomerDashboardView(string theCallersId)
		{
			var customerId = Data.DataManager.AllDataService.GetCustomerIdByFonNumber(theCallersId);
			if (!string.IsNullOrEmpty(customerId))
			{
				var customer = ModelManager.CustomerService.GetKunde(customerId, true);
				//var contact = ModelManager.ContactService.GetKundenkontaktByFonNumber(customerId, theCallersId);
				Kundenkontakt contact = null;
				if (customer != null)
				{
					if (contact != null)
					{
						var kmv = new KundeMainView(customer, contact);
						kmv.Show();
					}
					else
					{
						var kmv = new KundeMainView(customer);
						kmv.Show();
					}
				}
			}
		}

		void ShowCalendarView()
		{
			if (!David.DavidManager.DavidService.Connected)
			{
				MetroMessageBox.Show(this, "Sieht so aus, als wäre der DAVID Server im Augenblick platt.", "Irgendwatt mit dem David Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			ServiceManager.UiService.ShowCalendar();
		}

		void ShowTaskListView()
		{
			User currentUser = ModelManager.UserService.CurrentUser;
			SortableBindingList<Task> taskList = null;
			if (currentUser != null)
			{
				taskList = ModelManager.TaskService.GetTaskList(currentUser);
				if (taskList != null)
				{
					var tlv = new TaskListView(taskList, currentUser);
					tlv.Show();
				}
				else this.ShowNoTasksMessage();
			}
			else this.ShowNoCurrentUserMessage();
		}

		void ShowNoCurrentUserMessage()
		{
			string msg = "Auf mir unerklärliche Weise ist es Dir gelungen, Catalist zu starten, ohne dabei aktueller Benutzer zu sein. Sowas ...";
			MetroMessageBox.Show(this, msg, "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		void ShowNoTasksMessage()
		{
			string msg = "Du hast im Augenblick keine Aufgaben";
			MetroMessageBox.Show(this, msg, "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void CreateCatalog()
		{
			// Select customer
			var csv = new CustomerSearchView("Für welchen Kunden soll der Katalog erstellt werden?", false);
			if (csv.ShowDialog(this) == DialogResult.OK && (csv.SelectedCustomer != null))
			{
				dsCustomer.CustomerRow customer = csv.SelectedCustomer;
				bool makeItShort = false;
				DocxCreator.DocXService docx;
				string newDoc = string.Empty;

				var dlg = new AuswahlDialog("Wir können kurz und lang können wir auch - was soll's werden",
					new string[] { "Kurzpreisliste", "Normaler Katalog", "Ach, lass mal" },
					MetroFramework.MetroColorStyle.Green);

				dlg.ShowDialog();
				switch (dlg.SelectedOption)
				{
					case 0:
						makeItShort = true;
						docx = DocxCreator.ServiceManager.DocXService;
						newDoc = docx.CreateCatalogDocument(customer, Properties.Settings.Default.CatalogPath, makeItShort);
						if (MetroMessageBox.Show(this, string.Format(@"Soll die Datei ""{0}"" jetzt geöffnet werden?", newDoc), "Catalist - Katalog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							var progName = "winword.exe";
							var progPath = string.Format(@"""{0}""", Path.Combine(@"\\cpm-dc\sage_ncl\catalist\kundenkataloge\", newDoc));
							Process.Start(progName, progPath);
						}
						break;

					case 1:
						makeItShort = false;
						docx = DocxCreator.ServiceManager.DocXService;
						newDoc = docx.CreateCatalogDocument(customer, Properties.Settings.Default.CatalogPath, makeItShort);
						if (MetroMessageBox.Show(this, string.Format("Soll die Datei '{0}' jetzt geöffnet werden?", newDoc), "Catalist - Katalog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							var progName = "winword.exe";
							//string progPath = Path.Combine(@"\\cpm-dc\sage_ncl\catalist\kundenkataloge", newDoc);
							var progPath = string.Format(@"""{0}""", Path.Combine(@"\\cpm-dc\sage_ncl\catalist\kundenkataloge\", newDoc));
							Process.Start(progName, progPath);
						}
						break;

					case 2:
						docx = null;
						MetroMessageBox.Show(this, "Ganz genau. Gute Wahl. Sollen die Anderen das doch machen ...");
						break;
				}
				docx = null;
			}
		}

		void ShowCatalogView()
		{
			var kv = new KatalogIndexView();
			kv.ShowDialog();
			kv.Dispose();
		}

		void ShowVerwaltungsView()
		{
			var vv = new VerwaltungsView();
			vv.Show(this);
		}

		void ShowSettingsView()
		{
			var sv = new SettingsView();
			sv.ShowDialog(this);
			sv.Dispose();
		}

		//bool SuchKunde(string searchFor)
		//{
		//	try
		//	{
		//		this.Cursor = Cursors.WaitCursor;
		//		var list = ModelManager.CustomerService.GetKundenSucheResults(searchFor);
		//		if (list == null || list.Count == 0)
		//		{
		//			errSearch.SetError(this.mtxtSearch, "Sieht aus, als hätten wir keinen solchen Kunden");
		//			this.mtxtSearch.SelectAll();
		//			return false;
		//		}
		//		errSearch.SetError(mtxtSearch, string.Empty);
		//		if (list.Count == 1)
		//		{
		//			var kunde = ModelManager.CustomerService.GetKunde(list[0].Kundennummer);
		//			var kmv = new KundeMainView(kunde);
		//			kmv.Show();
		//			return true;
		//		}
		//		else
		//		{
		//			var csv = new CustomerSearchView1(list, searchFor);
		//			var dlgResult = csv.ShowDialog(this);
		//			if (dlgResult == DialogResult.OK && csv.SelectedSuchkunde != null)
		//			{
		//				var kunde = ModelManager.CustomerService.GetKunde(csv.SelectedSuchkunde.Kundennummer);
		//				var kmv = new KundeMainView(kunde);
		//				kmv.Show();
		//				return true;
		//			}
		//			this.mtxtSearch.SelectAll();
		//			return false;
		//		}
		//	}
		//	finally
		//	{
		//		this.Cursor = Cursors.Default;
		//	}
		//}

		bool SearchCustomer()
		{
			if (string.IsNullOrEmpty(this.SearchText) || string.IsNullOrWhiteSpace(this.SearchText)) return false;

			var list = ModelManager.CustomerService.GetKundenSucheResults(this.SearchText);
			if (list == null || list.Count == 0)
			{
				var msg = string.Format("Die Suche nach '{0}' ergab leider garnichts.", this.SearchText);
				errSearch.SetError(this.mtxtSearch, msg);
				this.mtxtSearch.SelectAll();
				return false;
			}
			errSearch.SetError(mtxtSearch, string.Empty);
			if (list.Count == 1)
			{
				var kunde = ModelManager.CustomerService.GetKunde(list[0].Kundennummer, true);
				if (!this.myRecentCustomerList.Contains(kunde)) this.myRecentCustomerList.Add(kunde);
				var kmv = new KundeMainView(kunde);
				this.Cursor = Cursors.Default;
				kmv.Show();
				return true;
			}
			var csv1 = new CustomerSearchView1(list, this.SearchText);
			var dlgResult = csv1.ShowDialog(this);
			if (dlgResult == DialogResult.OK && csv1.SelectedSuchkunde != null)
			{
				var kunde = ModelManager.CustomerService.GetKunde(csv1.SelectedSuchkunde.Kundennummer, true);
				if (!this.myRecentCustomerList.Contains(kunde)) this.myRecentCustomerList.Add(kunde);
				var kmv = new KundeMainView(kunde);
				kmv.Show();
				return true;
			}
			this.mtxtSearch.SelectAll();
			return false;
		}

		bool SearchProduct()
		{
			errSearch.SetError(mtxtSearch, string.Empty);
			if (string.IsNullOrEmpty(this.SearchText) || string.IsNullOrWhiteSpace(this.SearchText)) return false;

			string kundenNr;

			if (this.SearchText.StartsWith("*", StringComparison.CurrentCulture))
			{
				var filterArray = this.SearchText.Split();
				if (filterArray.Length == 2)
				{
					kundenNr = string.Format("{0}00000", filterArray[0].Substring(1, 5));
					this.SearchText = filterArray[1];
					this.myProductCustomer = ModelManager.CustomerService.GetKunde(kundenNr, true);
				}
			}
			if (this.myProductCustomer != null)
			{
				if (!this.myRecentCustomerList.Contains(this.myProductCustomer)) this.myRecentCustomerList.Add(this.myProductCustomer);
			}
			else
			{
				this.myProductCustomer = ModelManager.CustomerService.GetKunde("1000000000", false);
			}
			var list = ModelManager.ProductService.GetProductList(this.myProductCustomer, this.SearchText);
			if (list.Count == 1)
			{
				var adv = new ArtikelDetailView(list[0], this.myProductCustomer);
				adv.Show();
			}
			else if (list.Count > 1)
			{
				var psv = new ProductSearchView(list);
				psv.ProductChosen += Psv_ProductChosen;
				psv.Show();
			}
			else
			{
				var msg = string.Format("Die Suche nach '{0}' ergab leider garnichts.", this.SearchText);
				errSearch.SetError(this.mtxtSearch, msg);
			}
			return true;
		}

		void Psv_ProductChosen(object sender, EventArgs e)
		{
			var psv = sender as ProductSearchView;
			Kunde kunde = this.myProductCustomer;
			ArtikelDetailView adv = null;
			if (kunde != null)
			{
				adv = new ArtikelDetailView(psv.SelectedProduct, kunde);
			}
			else
			{
				adv = new ArtikelDetailView(psv.SelectedProduct, ModelManager.CustomerService.GetKunde("1000000000", false));
			}
			adv.Show();
		}

		void mlnkCurrentCustomer_Click(object sender, EventArgs e)
		{
			var kunde = this.mlnkCurrentCustomer.Tag as Kunde;
			if (kunde != null)
			{
				var kmv = new KundeMainView(kunde);
				kmv.Show();
			}
		}

		void ShowCPM()
		{
			var wir = ModelManager.CustomerService.GetKunde("1000000000", true);
			var kmv = new KundeMainView(wir);
			kmv.Show();
		}

		void KommWirHaunAbHierUndLassenDenScheiss()
		{
			var msg = "Feierabend oder watt?";
			var result = MetroMessageBox.Show(this, msg, "Und Tschüss ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.Yes)
			{
				this.quit = true;
				this.Close();
			}
		}

		#endregion private procedures

		#region TESTING

		void btnTest_Click(object sender, EventArgs e)
		{
			this.TestMe10();
		}

		void TestMe10()
		{
			var kundeA = ModelManager.CustomerService.GetKunde("4901100000", false);
			var kundeB = ModelManager.CustomerService.GetKunde("4988900000", false);
			var kundeC = ModelManager.CustomerService.GetKunde("4918800000", false);
			var kundeD = ModelManager.CustomerService.GetKunde("4906900000", false);
			var coords = new Dictionary<string, GeoCoordinate>();
			coords.Add(kundeA.Matchcode.Substring(0, 1), kundeA.Adresskoordinaten);
			coords.Add(kundeB.Matchcode.Substring(0, 1), kundeB.Adresskoordinaten);
			coords.Add(kundeC.Matchcode.Substring(0, 1), kundeC.Adresskoordinaten);
			coords.Add(kundeD.Matchcode.Substring(0, 1), kundeD.Adresskoordinaten);
			var picture = GeoData.GetPoisImage(coords);
			var tv = new TestView(picture);
			tv.Show();
		}

		void mbtnTestMe_Click(object sender, EventArgs e)
		{
			this.TestMe4();
		}

		void TestMe()
		{
			var list = new List<double> { 5100.0, 4900.0, 5000.0, 5000.0, 5000.0, 6000.0, 5000.0, 5000.0, 5000.0, 5000.0 };
			var mean = list.Mean();
			//if (Math.Abs(mean) < EPSILON) return;
			var median = list.Median();
			var stdDev = list.StandardDeviation();
			var stdDevPct = stdDev * 100 / mean;
			string[] values = { mean.ToString("C2"), median.ToString("C2"), stdDev.ToString("C2"), stdDevPct.ToString("N1") };
			MetroMessageBox.Show(this, string.Format("Mittel: {0}\nMedian: {1}\nStandardabweichung: {2}\nAbweichung in Prozent: ({3}%)", values));
		}

		void OldTest_Click(object sender, EventArgs e)
		{
			var klv = new KalenderListeView(ModelManager.UserService.CurrentUser);
			if (klv.ShowDialog() == DialogResult.OK)
			{
				var terminTitel = klv.SelectedTermin.Title;
				MetroMessageBox.Show(this, string.Format("Sie haben das hier ausgewählt:\n{0}", terminTitel));
			}
		}

		void TestMe1()
		{
			int i = 0;
			string searchHere = @"C:\Windows\System32\";
			string searchFor = "EA397921";
			foreach (string file in Directory.EnumerateFiles(searchHere, "*.*", SearchOption.AllDirectories))
			{
				i += 1;
				if (Utils.GetCRC32(file) == searchFor)
				{
					MetroMessageBox.Show(this, string.Format("{0} Dateien nach '{1}' durchsucht und gefunden.", i, searchFor));
					return;
				}
			}
			MetroMessageBox.Show(this, string.Format("{0} Dateien nach '{1}' durchsucht und nicht gefunden.", i, searchFor));
		}

		void TestMe2()
		{
			foreach (var item in ModelManager.UserService.CurrentUser.Reminderliste)
			{
				MetroMessageBox.Show(this, string.Format("Erinnerung um {0}: {1}", item.RemindAt.ToShortTimeString(), item.Description));
			}
		}

		void TestMe3()
		{
			var kv = new KalenderView(new ViewController.CalendarViewController(ModelManager.UserService.CurrentUser));
			kv.Show();
		}

		void TestMe4()
		{
			var terminListe = ModelManager.AppointmentService.GetAppointmentList("4810500000", "0f941eeb-9a48-4469-b6bf-a65c70e5dfe6");
		}

		void TestMe5()
		{
			var attachmentList = David.DavidManager.DavidService.GetAttachments(@"\\david\david\archive\group\4");
			if (attachmentList != null)
			{
				var sb = new StringBuilder();
				foreach (var fInfo in attachmentList)
				{
					sb.AppendLine(fInfo.Name);
				}
				MetroMessageBox.Show(this, sb.ToString(), "Dateianhänge im DAVID Angebotsordner", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		void TestMe6()
		{
			var av = new AngeboteListView();
			av.Show();

			var pcv = new ProductCategoryView();
			pcv.Show();
		}

		void TestMe7()
		{
			var wvv = new WartungsvorschlagView(ModelManager.MachineService.CreateWartungsplanungTable());
			wvv.Show();
		}

		void TestMe8()
		{
			try
			{
				var technikerId = ModelManager.UserService.CurrentUser.UID;
				var zip = "49";
				var start = new DateTime(2016, 10, 10);
				var newTour = ModelManager.TechnikService.CreateWartungstour(technikerId, zip, start);
			}
			catch (ArgumentException ax)
			{
				MetroMessageBox.Show(this, ax.Message);
			}
		}

		#endregion TESTING

		void TestMe9()
		{
			var la1 = 38.304455;
			var lo1 = -0.599458;
			var la2 = 52.20131;
			var lo2 = 8.02996;

			var msg1 = string.Format("Das liegt {0} Km auseinander, sacht GeoDataCom, die Penner.", GeoData.GetDistance(la1, lo1, la2, lo2));
			var msg2 = string.Format("Und Bill Gates sagt, das liegt {0} Km auseinander.", GeoData.GetDistanceKm(la1, lo1, la2, lo2));
			MetroMessageBox.Show(this, msg1, "GeoData Test mit GeoDataCom", MessageBoxButtons.OK, MessageBoxIcon.Information);
			MetroMessageBox.Show(this, msg2, "GeoData Test mit Billyboy Gates", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}