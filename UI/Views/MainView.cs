using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class MainView : MetroForm
	{

		#region delegates

		private delegate void CustomerGeneralViewOpenDelegate(string customerId);

		// If the phone rings we handle an event that's fired by the Agfeo module's thread.
		// For this a delegate is needed that will be invoked by that event.
		CustomerGeneralViewOpenDelegate cgvoDelegate;

		#endregion

		#region members

		string searchString = string.Empty;
		bool quit = false;

		#endregion

		#region private properties

		public string CustomerSearchText { get; set; }
		public string ProductSearchText { get; set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the MainView class.
		/// </summary>
		public MainView() : this(false)
		{
		}

		public MainView(bool local)
		{
			InitializeComponent();
			if (!local)
			{
				Agfeo.FonService fonService = Agfeo.FonManager.FonService;
				fonService.InitTapi(true, Properties.Settings.Default.ATAPI_Line);
			}
			SammirmalWennsKlingelt();
			cgvoDelegate = new CustomerGeneralViewOpenDelegate(ShowCustomerDashboardView);
			this.txtSearchCustomer.DataBindings.Add("Text", this, "CustomerSearchText");
			if (Model.ModelManager.ModelService.GetCurrentUser() != null)
			{
				this.lblCurrentUser.Text = string.Format("Tach {0}", Model.ModelManager.ModelService.GetCurrentUser().NameFirst);
			}
		}

		#endregion

		#region event handler

		#region AGFEO

		public void SammirmalWennsKlingelt()
		{
			Agfeo.FonManager.FonService.SomeoneIsCalling += new EventHandler<Agfeo.IncomingCallEventArgs>(DatMachIchWennsKlingelt);
			this.picLineOpen.Image = global::Products.Common.Properties.Resources.Audacity_Green;
		}

		public void MirScheißegalObsKlingelt()
		{
			Agfeo.FonManager.FonService.SomeoneIsCalling -= DatMachIchWennsKlingelt;
			this.picLineOpen.Image = global::Products.Common.Properties.Resources.Audacity_Gray;
		}

		private void DatMachIchWennsKlingelt(object sender, Agfeo.IncomingCallEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(cgvoDelegate, e.CallerNumber);
			}
		}

		#endregion

		private void lnkArtikel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowProductListView();
		}

		private void lnkArtikel_MouseClick(object sender, MouseEventArgs e)
		{
			ShowProductListView();
		}

		private void lnkKalender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//ShowCalendarView();
		}

		private void lnkKalender_MouseClick(object sender, MouseEventArgs e)
		{
			ShowCalendarView();
		}

		private void lnkShowOfferView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowOfferListView();
		}

		private void lnkShowOfferView_MouseClick(object sender, MouseEventArgs e)
		{
			ShowOfferListView();
		}

		private void lnkCreateCatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CreateCatalog();
		}

		private void lnkCreateCatalog_MouseClick(object sender, MouseEventArgs e)
		{
			CreateCatalog();
		}

		private void lnkKatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowCatalogView();
		}

		private void lnkKatalog_MouseClick(object sender, MouseEventArgs e)
		{
			ShowCatalogView();
		}

		private void lnkShowPresets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowPresetListView();
		}

		private void lnkShowPresets_MouseClick(object sender, MouseEventArgs e)
		{
			ShowPresetListView();
		}

		private void MainView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Middle)
			{
				this.TestMe();
			}
		}

		private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void MainView_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.Q)
			{
				e.SuppressKeyPress = true;
				Quit();
			}
		}

		private void lnkCustomerGeneralView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CustomerDashboardView cgv = new CustomerDashboardView(Model.ModelManager.ModelService.GetCustomerById("1000000000"));
			cgv.Show(this);
		}

		private void lnkTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show(string.Format("In diesem Zeitraum hatten wir {0} Neukunden.", Data.DataManager.DataService.Test()));
		}

		private void picCPM_Click(object sender, EventArgs e)
		{
			ShowSettingsView();
		}

		private void picLineOpen_Click(object sender, EventArgs e)
		{
			if (Agfeo.FonManager.FonService.IsListening) MirScheißegalObsKlingelt();
			else SammirmalWennsKlingelt();
		}

		private void tBarIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				ShowMainView();
			}
		}

		private void ctxCmdViewQuit_Click(object sender, EventArgs e)
		{
			Quit();
		}

		private void ctxCmdShowSettingsView_Click(object sender, EventArgs e)
		{
			ShowSettingsView();
		}

		private void ctxCmdMaschinentypen_Click(object sender, EventArgs e)
		{
			MaschinenmodellView mmv = new MaschinenmodellView();
			mmv.Show();
		}

		private void ctxCmdShowMainView_Click(object sender, EventArgs e)
		{
			ShowMainView();
		}

		private void MainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!quit)
			{
				this.Visible = false;
				e.Cancel = true;
			}
		}

		private void lnkQuit_MouseClick(object sender, MouseEventArgs e)
		{
			Quit();
		}

		private void picTopMost_Click(object sender, EventArgs e)
		{
			TopMost = !TopMost;
			if (!TopMost)
			{
				this.picTopMost.Image = global::Products.Common.Properties.Resources.Pin_gray_32;
			}
			else
			{
				this.picTopMost.Image = global::Products.Common.Properties.Resources.Pin_red_32;
			}

		}

		private void WhatClock_Click(object sender, EventArgs e)
		{
			string msg = "Damit wird die Geschichte komplett beendet. Ist das Ok?";
			DialogResult result;
			result = MessageBox.Show(msg, "Catalist beenden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				Quit();
			}
		}

		private void cMnuQuit_Click(object sender, EventArgs e)
		{
			Quit();
		}

		private void lblCurrentUser_Click(object sender, EventArgs e)
		{
			//ServiceterminView sv = new ServiceterminView();
			//sv.Show();
			// David.DavidManager.DavidService.FindeKundenadresse("1000000000");
		}

		#region customer search

		private void lnkSearchCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SearchCustomer(CustomerSearchText);
		}

		private void txtCustomerSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				CustomerSearchText = txtSearchCustomer.Text.Trim();
				SearchCustomer(CustomerSearchText);
			}
		}

		private void lnkDummy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			txtSearchCustomer.SelectAll();
			txtSearchCustomer.Focus();
		}

		#endregion

		#region test

		private void TestMe()
		{
			double val1 = DocxCreator.Utils.Multiplier("137 Zentimeter x 48,5 Meter", DocxCreator.Utils.ParseOptions.RunningMeter);
			double val2 = DocxCreator.Utils.CalcRunningMeterPrice("137cm x 48,5m", 3.57);
			string msg = string.Format("Fläche: {0:N3}m², Preis/lfm: {1:C2}", val1, val2);
			MessageBox.Show(msg, "Test-Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion

		#endregion

		#region private procedures

		private void ShowMainView()
		{
			if (!this.Visible)
			{
				this.Visible = true;
			}
		}

		private bool SearchCustomer(string searchFor)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				Products.Common.SortableBindingList<Model.Entities.Customer> list = Model.ModelManager.ModelService.GetCustomersByAny(searchFor);
				if (list == null || list.Count == 0)
				{
					errSearch.SetError(this.txtSearchCustomer, "Sieht so aus, als hätten wir keinen solchen Kunden");
					this.txtSearchCustomer.SelectAll();
					return false;
				}
				errSearch.SetError(txtSearchCustomer, string.Empty);
				if (list.Count == 1)
				{
					Views.CustomerDashboardView cgv = new CustomerDashboardView(list[0]);
					cgv.Show();
					this.txtSearchCustomer.SelectAll();
					return true;
				}
				else
				{
					CustomerSearchView2 csv = new CustomerSearchView2(list);
					DialogResult dlgResult = csv.ShowDialog(this);
					if (dlgResult == System.Windows.Forms.DialogResult.OK && csv.CurrentCustomer != null)
					{
						Model.Entities.Customer customer = csv.CurrentCustomer;
						Views.CustomerDashboardView cgv = new CustomerDashboardView(customer);
						cgv.Show();
						return true;
					}
					this.txtSearchCustomer.SelectAll();
					return false;
				}
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Delegate function that's called by the SomeoneIsCalling event handler.
		private void ShowCustomerDashboardView(string theCallersId)
		{
			string customerId = Data.DataManager.DataService.GetCustomerIdByFonNumber(theCallersId);
			if (!string.IsNullOrEmpty(customerId))
			{
				Model.Entities.Customer customer = Model.ModelManager.ModelService.GetCustomerById(customerId);
				Views.CustomerDashboardView cgv = new CustomerDashboardView(customer);
				cgv.Show();
			}
		}

		private void ShowProductListView()
		{
			ProductListView plv = new ProductListView();
			plv.ShowDialog(this);
		}

		private void ShowCalendarView()
		{
			//List<DvApi32.CalendarItem> termine = David.DavidManager.DavidService.GetCalenderItems();
			//List<Calendar.Appointment> liste = new List<Calendar.Appointment>();
			//foreach (DvApi32.CalendarItem cItem in termine)
			//{
			//  Calendar.Appointment termin = new Calendar.Appointment();
			//  termin.StartDate = (DateTime)cItem.StartTime;
			//  termin.EndDate = (DateTime)cItem.StopTime;
			//  termin.Title = cItem.Subject;
			//  liste.Add(termin);
			//}
			CalendarView cv = new CalendarView(Model.ModelManager.ModelService.GetTermine(Model.ModelManager.ModelService.GetCurrentUser()));
			cv.Show();
		}

		private void ShowOfferListView()
		{
			CustomerSearchView csv = new CustomerSearchView();
			if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK && csv.SelectedCustomer != null)
			{
				Model.Entities.Customer customer = Model.ModelManager.ModelService.GetCustomerById(csv.SelectedCustomer.Kundennummer);
				OfferListView olv = new OfferListView(customer);
				olv.Show(this);
			}
		}

		private void CreateCatalog()
		{
			// Select customer
			Views.CustomerSearchView csv = new CustomerSearchView();
			if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				Data.dsSage.CustomerRow customer = csv.SelectedCustomer;
				string msg = string.Format(@"Soll eine Kurzpreisliste für '{0}' erstellt werden?", customer.Name1);

				bool makeItShort = false;
				DialogResult result = MessageBox.Show(msg, "Wir basteln uns einen Katalog", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					makeItShort = true;
					DocxCreator.DocXService docx = DocxCreator.ServiceManager.DocXService;
					string newDoc = docx.CreateCatalogDocument(customer, Properties.Settings.Default.CatalogPath, makeItShort);
					if (MessageBox.Show(string.Format(@"Soll die Datei ""{0}"" jetzt geöffnet werden?", newDoc), "Catalist - Katalog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
					{
						string progName = "winword.exe";
						string progPath = string.Format(@"""{0}""", Path.Combine(@"\\cpm-dc\sage_ncl\catalist\kundenkataloge\", newDoc));
						Process.Start(progName, progPath);
					}
				}
				else if (result == System.Windows.Forms.DialogResult.No)
				{
					makeItShort = false;
					DocxCreator.DocXService docx = DocxCreator.ServiceManager.DocXService;
					string newDoc = docx.CreateCatalogDocument(customer, Properties.Settings.Default.CatalogPath, makeItShort);
					if (MessageBox.Show(string.Format("Soll die Datei '{0}' jetzt geöffnet werden?", newDoc), "Catalist - Katalog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
					{
						string progName = "winword.exe";
						string progPath = Path.Combine(@"\\cpm-dc\sage_ncl\catalist\kundenkataloge", newDoc);
						Process.Start(progName, progPath);
					}
				}
				else
				{
					MessageBox.Show("Gut, dann halt nicht ...", "Catalist - Katalogerstellung", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void ShowCatalogView()
		{
			Views.KatalogView kv = new KatalogView();
			kv.ShowDialog();
		}

		private void ShowPresetListView()
		{
			PresetListView plv = new PresetListView();
			plv.ShowDialog();
		}

		private void ShowSettingsView()
		{
			SettingsView sv = new SettingsView();
			sv.Show();
		}

		private void Quit()
		{
			this.quit = true;
			this.Close();
		}

		#endregion

	}
}
