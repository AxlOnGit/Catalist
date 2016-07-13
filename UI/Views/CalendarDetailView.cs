using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Common.Interfaces;
using Products.Model;
using System.IO;
using MetroFramework;
using System.Diagnostics;

namespace Products.Common.Views
{
	public partial class CalendarDetailView : MetroForm
	{

		#region MEMBERS

		private Appointment myAppointment;
		ILinkedItem mySelectedLinkedItem;
		User myCurrentUser;

		#endregion

		#region ### .CTOR ###

		/// <summary>
		/// Erstellt eine neue Instanz der CalendarDetailView Klasse.
		/// </summary>
		public CalendarDetailView(Appointment appointment)
		{
			InitializeComponent();
			myAppointment = appointment;
			this.myCurrentUser = ModelManager.UserService.CurrentUser;

			InitializeData();
			Application.Idle += Application_Idle;
		}

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			this.mbtnRemoveLinkedItem.Enabled = this.myAppointment.GetLinkedItemsList().Count > 0;
			this.xcmdDeleteLinkedItem.Enabled = this.mbtnRemoveLinkedItem.Enabled;
		}

		#endregion

		#region EVENT HANDLER

		// Wird das Datum des Terminbeginns geändert, zuvor die eingestellte Uhrzeit speichern.
		void dtpBeginnDatum_Validated(object sender, EventArgs e)
		{
			int preStartHour = dtpStartsAtTime.Value.Hour;
			int preStartMinute = dtpStartsAtTime.Value.Minute;
			int startYear = dtpStartsAtDate.Value.Year;
			int startMonth = dtpStartsAtDate.Value.Month;
			int startDay = dtpStartsAtDate.Value.Day;

			dtpStartsAtTime.Value = new DateTime(startYear, startMonth, startDay, preStartHour, preStartMinute, 0);
		}

		// Wird das Datum des Terminendes geändert, zuvor die eingestellte Uhrzeit speichern.
		void dtpEndeDatum_ValueChanged(object sender, EventArgs e)
		{
			int preStartHour = dtpEndsAtTime.Value.Hour;
			int preStartMinute = dtpEndsAtTime.Value.Minute;
			int startYear = dtpEndsAtDate.Value.Year;
			int startMonth = dtpEndsAtDate.Value.Month;
			int startDay = dtpEndsAtDate.Value.Day;

			dtpEndsAtTime.Value = new DateTime(startYear, startMonth, startDay, preStartHour, preStartMinute, 0);
		}

		void mcmbErinnerung_SelectedValueChanged(object sender, EventArgs e)
		{
			int reminder;
			if (int.TryParse((string)mcmbErinnerung.Text, out reminder))
			{
				myAppointment.RemindAt = reminder;
			}
			else
			{
				myAppointment.RemindAt = -1;
			}
		}

		void mchkErinnerung_CheckedChanged(object sender, EventArgs e)
		{
			if (!mchkErinnerung.Checked)
			{
				this.mcmbErinnerung.Enabled = false;
				this.mcmbErinnerung.SelectedValue = "0";
				myAppointment.RemindAt = -1;
			}
			else
			{
				this.mcmbErinnerung.Enabled = true;
			}
		}

		void mcmbAnzeigenAls_Validated(object sender, EventArgs e)
		{
			myAppointment.ShowAs = (DvApi32.DvShowAsType)mcmbAnzeigenAls.SelectedIndex;
		}

		void mcmbAnzeigenAls_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.myAppointment.ShowAs = (DvApi32.DvShowAsType)mcmbAnzeigenAls.SelectedIndex;
		}

		void mbtnAddLinkedItem_Click(object sender, EventArgs e)
		{
			this.AddLinkedItem();
		}

		void mbtnSetAutoProperties_Click(object sender, EventArgs e)
		{
			Kunde customer = null;
			Kundenkontakt contact = null;
			Kundenmaschine machine = null;

			var msg = string.Empty;
			var msgBoxTitle = "Ausfüllen der Termineigenschaften" + Environment.NewLine;
			var subject = string.Empty;
			var location = string.Empty;
			var body = string.Empty;

			foreach (var lItem in this.myAppointment.GetLinkedItemsList())
			{
				if (lItem is Kunde)
				{
					customer = lItem as Kunde;
				}
				else if (lItem is Kundenkontakt)
				{
					contact = lItem as Kundenkontakt;
				}
				else if (lItem is Kundenmaschine)
				{
					machine = lItem as Kundenmaschine;
				}
			}

			if (customer == null)
			{
				msg = "Bitte vorher den Termin zumindest mit einem Kunden verknüpfen.";
				MetroMessageBox.Show(this, msg, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			msg = "Ich trage die Eigenschaften dieses Termins automatisch ein.";
			if (MetroMessageBox.Show(this, msg, msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) return;

			switch (this.myAppointment.AppointmentType)
			{

				case "Kundenbesuch":
					if (customer != null)
					{
						subject = string.Format("{0}: Besuchstermin", customer.Matchcode);
						location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
						if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
						if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
						if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					}
					break;

				case "Wartungstermin":
					if (machine != null) subject = string.Format("{0}: Wartung {1} ({2})", customer.Matchcode, machine.Maschinenmodell, machine.Seriennummer);
					else subject = string.Format("{0}: Wartung ", customer.Matchcode);

					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Servicetermin":
					if (machine != null) subject = string.Format("{0}: Service {1} ({2})", customer.Matchcode, machine.Maschinenmodell, machine.Seriennummer);
					else subject = string.Format("{0}: Wartung ", customer.Matchcode);

					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Fernwartung":
					subject = string.Format("{0}: Fernwartung", customer.Matchcode);
					location = "Technik CPM";
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					break;

				case "Maschinenlieferung":
					if (machine != null) subject = string.Format("{0}: Auslieferung {1} ({2})", customer.Matchcode, machine.Maschinenmodell, machine.Seriennummer);
					else subject = string.Format("{0}: Auslieferung ", customer.Matchcode);

					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Maschinenabholung":
					if (machine != null) subject = string.Format("{0}: Abholung {1} ({2})", customer.Matchcode, machine.Maschinenmodell, machine.Seriennummer);
					else subject = string.Format("{0}: Auslieferung ", customer.Matchcode);
					location = "Technik CPM";
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Telefonat":
					subject = string.Format("{0}: Telefonat", customer.Matchcode);
					location = "Technik CPM";
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Undefiniert":
					subject = string.Format("{0}: Undefinierter Termin", customer.Matchcode);
					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Demo":
					if (machine != null) subject = string.Format("{0}: Abholung {1} ({2})", customer.Matchcode, machine.Maschinenmodell, machine.Seriennummer);
					else subject = string.Format("{0}: Demo ", customer.Matchcode);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Besprechung":
					subject = "Besprechung";
					location = "Empfang CPM";
					body = string.Format(@"<p><strong><u>Teilnehmer</u></strong></p><ul>{0}</ul>", myCurrentUser.CalendarSettings.TargetUser.NameFull);
					break;

				default:
					subject = string.Format("{0}: {1}", customer.Matchcode, myAppointment.AppointmentType);
					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;
			}
			this.myAppointment.Subject = subject;
			this.myAppointment.Location = location;
			this.myAppointment.BodyHtml = body;

			this.RefreshDataBindings();
		}

		void xcmdAddLinkedItem_Click(object sender, EventArgs e)
		{
			this.AddLinkedItem();
		}

		void mbtnRemoveLinkedItem_Click(object sender, EventArgs e)
		{
			this.RemoveLinkedItem();
		}

		void xcmdDeleteLinkedItem_Click(object sender, EventArgs e)
		{
			this.RemoveLinkedItem();
		}

		void dgvLinkedItems_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedLinkedItem = this.dgvLinkedItems.Rows[e.RowIndex].DataBoundItem as ILinkedItem;
		}

		void mbtnSettings_Click(object sender, EventArgs e)
		{
			this.ShowCalendarSettings();
		}

		void xcmdOpenLinkedItem_Click(object sender, EventArgs e)
		{
			var item = this.mySelectedLinkedItem;

			if (item == null) return;

			switch (item.LinkTypBezeichnung)
			{
				case "Kunde":
					var kmv = new KundeMainView(item as Kunde);
					kmv.Show();
					break;

				case "Kundenmaschine":
					var machine = item as Kundenmaschine;
					var kunde = machine.CurrentOwner;
					kmv = new KundeMainView(kunde, machine);
					kmv.Show();
					break;

				case "Kundenkontakt":
					var contact = item as Kundenkontakt;
					kunde = ModelManager.CustomerService.GetKunde(contact.Kundennummer, false);
					kmv = new KundeMainView(kunde, contact);
					kmv.Show();
					break;
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.myAppointment.Update();
			this.Close();
		}

		#endregion

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			dgvLinkedItems.AutoGenerateColumns = false;
			dtpStartsAtDate.DataBindings.Add("Value", myAppointment, "StartsAt");
			dtpStartsAtTime.DataBindings.Add("Value", myAppointment, "StartsAt");
			dtpEndsAtDate.DataBindings.Add("Value", myAppointment, "EndsAt");
			dtpEndsAtTime.DataBindings.Add("Value", myAppointment, "EndsAt");
			mtxtSubject.DataBindings.Add("Text", myAppointment, "Subject");
			mtxtLocation.DataBindings.Add("Text", myAppointment, "Location");
			mchkAllDayEvent.DataBindings.Add("Checked", myAppointment, "AllDayEvent");
			mlblCreator.Text = string.Format("{0} hat diesen Termin für {1} erstellt", myAppointment.CreatedByName, myAppointment.ResponsibleName);
			mlblLetzteAenderung.Text = string.Format("Am {0} um {1} Uhr war die letzte Änderung", myAppointment.ChangedAt.ToShortDateString(), myAppointment.ChangedAt.ToShortTimeString());
			this.htmlEditor.DataBindings.Add("InnerHtml", myAppointment, "BodyHtml", true, DataSourceUpdateMode.OnPropertyChanged);
			this.mcmbErinnerung.Text = myAppointment.RemindAt.ToString();
			this.mcmbErinnerung.Enabled = myAppointment.RemindAt != -1;
			this.mchkErinnerung.Checked = myAppointment.RemindAt != -1;
			this.mchkErinnerung.CheckedChanged += mchkErinnerung_CheckedChanged;
			this.mcmbAnzeigenAls.DataBindings.Add("SelectedIndex", myAppointment, "ShowAs", false, DataSourceUpdateMode.OnPropertyChanged);
			mcmbAppointmentType.DisplayMember = "Name";
			mcmbAppointmentType.ValueMember = "Name";
			mcmbAppointmentType.DataSource = ModelManager.AppointmentService.GetAppointmentTypeList();
			mcmbAppointmentType.DataBindings.Add("SelectedValue", myAppointment, "AppointmentType", false);
			this.dgvLinkedItems.DataSource = this.myAppointment.GetLinkedItemsList();
		}

		void RefreshDataBindings()
		{
			mtxtSubject.DataBindings.Clear();
			mtxtSubject.DataBindings.Add("Text", myAppointment, "Subject");
			mtxtLocation.DataBindings.Clear();
			mtxtLocation.DataBindings.Add("Text", myAppointment, "Location");
			htmlEditor.DataBindings.Clear();
			htmlEditor.DataBindings.Add("InnerHtml", myAppointment, "BodyHtml", true, DataSourceUpdateMode.OnPropertyChanged);
		}

		void AddLinkedItem()
		{
			string title = "Den Termin verknüpfen mit ...";
			string[] options = { "Kunde", "Kundenkontakt", "Maschine", "Lieferant", "Mitarbeiter", "Datei", "Abbrechen" };
			MetroFramework.MetroColorStyle style = MetroFramework.MetroColorStyle.Magenta;
			var ad = new AuswahlDialog(title, options, style);
			ad.ShowDialog();
			if (ad.SelectedOption == 6) return;

			switch (ad.SelectedOption)
			{
				case 0:
					// Kunde
					this.AddLinkToCustomer(null);
					break;

				case 1:
					// Kundenkontakt
					this.AddLinkToContact();
					break;

				case 2:
					// Maschine
					this.AddLinkToCustomerMachine();
					break;

				case 3:
					// Lieferant
					this.AddLinkToSupplier();
					break;

				case 4:
					// Mitarbeiter
					this.AddLinkToUser();
					break;

				case 5:
					// Datei
					this.AddLinkToFile();
					break;
			}
			this.dgvLinkedItems.DataSource = this.myAppointment.GetLinkedItemsList().Sort("ItemName");
			this.dgvLinkedItems.Invalidate();
		}

		void AddLinkToCustomer(Kunde kunde)
		{
			if (kunde == null)
			{
				var cuSv = new CustomerSearchView("Kunden für den Termin auswählen", false);
				cuSv.ShowDialog();
				var cRow = cuSv.SelectedCustomer;
				if (cuSv.DialogResult == System.Windows.Forms.DialogResult.OK && cuSv.SelectedCustomer != null)
				{
					var msg = string.Format("Ich verknüpfe den Termin mit der Firma '{0}'", cRow.Name1);
					MessageBox.Show(msg, "Verknüpfen mit Kunde", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, cRow.Kundennummer, "Kunde");
				}
			}
			else
			{
				ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, kunde.CustomerId, "Kunde");
			}
		}

		void AddLinkToContact()
		{
			var coSv = new ContactSearchView();
			if ((coSv.ShowDialog() == DialogResult.OK) && (coSv.SelectedContactRow != null))
			{
				var row = coSv.SelectedContactRow;
				var msg = string.Format("Ich verknüpfe den Termin mit dem Kontakt '{0}'", row.Kontaktname);
				var contactPK = string.Format("{0}{1}", row.Kundennummer, row.Nummer);
				MessageBox.Show(msg, "Verknüpfen mit Ansprechpartner", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var contact = ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, contactPK, "Kundenkontakt");

				// Kunden hinzufügen, wenn dieser noch nicht hinzugefügt wurde.
				var kunde = ModelManager.CustomerService.GetKunde((contact as Kundenkontakt).Kundennummer, true);
				if (kunde != null && !this.myAppointment.GetLinkedItemsList().Contains(kunde as ILinkedItem))
				{
					this.AddLinkToCustomer(kunde);
				}
			}
		}

		void AddLinkToCustomerMachine()
		{
			var kmsv = new KundenmaschineSearchView2();
			if ((kmsv.ShowDialog() == DialogResult.OK) && kmsv.SelectedMachine != null)
			{
				var mRow = kmsv.SelectedMachine;
				var msg = string.Format("Ich verknüpfe den Termin mit Maschine '{0}' von '{1}'", mRow.Maschine, mRow.Firma);
				MessageBox.Show(msg, "Verknüpfen mit Maschine", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var machine = ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, mRow.UID, "Kundenmaschine");

				// Den Eigentümer der Maschine hinzufügen, wenn er noch nicht verknüpft wurde.
				var kunde = ModelManager.CustomerService.GetKunde((machine as Kundenmaschine).Kundennummer, true);
				if (kunde != null && !this.myAppointment.GetLinkedItemsList().Contains(kunde as ILinkedItem))
				{
					this.AddLinkToCustomer(kunde);
				}
			}
		}

		void AddLinkToSupplier()
		{
			var llv = new LieferantenListView();
			if (llv.ShowDialog() == System.Windows.Forms.DialogResult.OK && llv.SelectedLieferant != null)
			{
				var lieferant = llv.SelectedLieferant;
				var msg = string.Format("Ich verknüpfe den Termin mit Lieferant '{0}'", lieferant.Name1);
				MessageBox.Show(msg, "Verknüpfen mit Lieferant", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Model.ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, lieferant.Lieferantennummer, "Lieferant");
			}
		}

		void AddLinkToUser()
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == System.Windows.Forms.DialogResult.OK && usv.SelectedUser != null)
			{
				var user = usv.SelectedUser;
				var msg = string.Format("Ich verknüpfe den Termin mit '{0}'.", user.NameFull);
				MessageBox.Show(msg, "Verknüpfen mit Mitarbeiter", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Model.ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, user.UID, "Mitarbeiter");
			}
		}

		void AddLinkToFile()
		{
			var ofd = new OpenFileDialog();
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ofd.Multiselect = true;
			ofd.Filter = "Alle Dateien|*.*|CSV-Dateien (*.csv)|*.csv|PDF (*.pdf)|*.pdf|Excel (*.xls*)|*.xls*|Word (*.doc*)|*.doc*|Text (*.txt)|*.txt";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var files = ofd.FileNames;
				foreach (var file in files)
				{
					FileInfo newFilename = ModelManager.FileLinkService.CopyFileToServerLinkFolder(file);
					Model.ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, newFilename.FullName, "Datei");
				}
			}
		}

		void RemoveLinkedItem()
		{
			if (this.mySelectedLinkedItem != null)
			{
				var msg = string.Format("Ich entferne die Verknüpfung mit '{0}'", this.mySelectedLinkedItem.ItemName);
				if (MessageBox.Show(msg, "Verknüpfung", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
				{
					Model.ModelManager.AppointmentService.RemoveLinkedItemFromAppointment(this.myAppointment, this.mySelectedLinkedItem);
				}
			}
		}

		void ShowCalendarSettings()
		{
			if (this.myCurrentUser == null) this.myCurrentUser = ModelManager.UserService.CurrentUser;
			var csv = new CalendarSettingsView(this.myCurrentUser.CalendarSettings);
			csv.ShowDialog();
		}

		#endregion

	}
}
