using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Common.Interfaces;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CalendarDetailView : MetroForm
	{
		#region MEMBERS

		Appointment myAppointment;
		ILinkedItem mySelectedLinkedItem;
		User myCurrentUser;

		#endregion MEMBERS

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
			this.mbtnRemoveLinkedItem.Enabled = ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment).Count > 0;
			this.xcmdDeleteLinkedItem.Enabled = this.mbtnRemoveLinkedItem.Enabled;
		}

		#endregion ### .CTOR ###

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

		void mbtnAddLinkToContact_Click(object sender, EventArgs e)
		{
			this.AddLinkToContact();
		}

		void mbtnAddLinkToMachine_Click(object sender, EventArgs e)
		{
			this.AddLinkToCustomerMachine();
		}

		void mbtnSetAutoProperties_Click(object sender, EventArgs e)
		{
			Kunde customer = null;
			Lieferant supplier = null;
			Kundenkontakt contact = null;
			Kundenmaschine machine = null;

			var msg = string.Empty;
			var msgBoxTitle = "Ausfüllen der Termineigenschaften" + Environment.NewLine;
			var subject = string.Empty;
			var location = string.Empty;
			var body = string.Empty;

			foreach (var lItem in ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment))
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
				else if (lItem is Lieferant)
				{
					supplier = lItem as Lieferant;
				}
			}

			if (customer == null && supplier == null)
			{
				msg = "Bitte vorher den Termin zumindest mit einem Kunden oder einem Lieferanten verknüpfen.";
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

				case "Schulung":
					if (supplier != null)
					{
						subject = string.Format("{0}: Schulung", supplier.Matchcode);
						location = string.Format("{0}, {1} {2}", supplier.Strasse, supplier.Postleitzahl, supplier.Ort);
					}
					break;

				case "Wartungstermin":
					if (machine != null) subject = string.Format("{0}: Wartung {1} ({2})", customer.Matchcode, machine.Modellbezeichnung, machine.Seriennummer);
					else subject = string.Format("{0}: Wartung ", customer.Matchcode);

					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Servicetermin":
					if (machine != null) subject = string.Format("{0}: Service {1} ({2})", customer.Matchcode, machine.Modellbezeichnung, machine.Seriennummer);
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
					if (machine != null) subject = string.Format("{0}: Auslieferung {1} ({2})", customer.Matchcode, machine.Modellbezeichnung, machine.Seriennummer);
					else subject = string.Format("{0}: Auslieferung ", customer.Matchcode);

					if (myCurrentUser.CalendarSettings.AddCustomerAddress) location = string.Format("{0}, {1} {2}", customer.Street, customer.ZipCode, customer.City);
					if (myCurrentUser.CalendarSettings.AddCustomerInfo) body = customer.GetCustomerInfoHtml(contact);
					if (myCurrentUser.CalendarSettings.AddCustomerNotes) body += customer.GetNotesHtml();
					if (myCurrentUser.CalendarSettings.AddCustomerPriceList) body += customer.GetSpecialPriceListHtml();
					break;

				case "Maschinenabholung":
					if (machine != null) subject = string.Format("{0}: Abholung {1} ({2})", customer.Matchcode, machine.Modellbezeichnung, machine.Seriennummer);
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
					if (machine != null) subject = string.Format("{0}: Abholung {1} ({2})", customer.Matchcode, machine.Modellbezeichnung, machine.Seriennummer);
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
			this.OpenLinkedItem();
		}

		void dgvLinkedItems_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenLinkedItem();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.myAppointment.Update();
			this.Close();
		}

		#endregion EVENT HANDLER

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
			this.dgvLinkedItems.DataSource = ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment);
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
			MetroColorStyle style = MetroColorStyle.Magenta;
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
		}

		void AddLinkToCustomer(Kunde kunde)
		{
			if (kunde == null)
			{
				var cuSv = new CustomerSearchView("Kunden für den Termin auswählen", false);
				cuSv.ShowDialog();
				var cRow = cuSv.SelectedCustomer;
				if (cuSv.DialogResult == DialogResult.OK && cuSv.SelectedCustomer != null)
				{
					var msg = string.Format("Ich verknüpfe den Termin mit '{0}'", cRow.Name1);
					MetroMessageBox.Show(this, msg, "Termin mit Kunden verknüpfen", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, cRow.Kundennummer, "Kunde");
					this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
				}
			}
			else
			{
				ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, kunde.CustomerId, "Kunde");
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void AddLinkToContact()
		{
			var coSv = new ContactSearchView();
			if ((coSv.ShowDialog() == DialogResult.OK) && (coSv.SelectedContact != null))
			{
				var contact = coSv.SelectedContact;
				if (contact != null)
				{
					var msg = string.Format("Ich verknüpfe den Termin mit '{0}'", contact.Kontaktname);
					MetroMessageBox.Show(this, msg, "Verknüpfen mit Ansprechpartner", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, contact.Key, contact.LinkTypBezeichnung);

					// Wenn der Kunde noch nicht hinzugefügt wurde, das jetzt direkt miterledigen.
					var kunde = contact.Kunde;
					if (kunde != null && !ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment).Contains(kunde))
					{
						this.AddLinkToCustomer(kunde);
					}
				}
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void AddLinkToCustomerMachine()
		{
			Kunde kunde = null;
			foreach (var item in ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment))
			{
				if (item is Kunde)
				{
					kunde = (Kunde)item;
				}
			}
			var kmsv = new KundenmaschineSearchView2(kunde);
			if ((kmsv.ShowDialog() == DialogResult.OK) && kmsv.SelectedMachine != null)
			{
				var mRow = kmsv.SelectedMachine;
				var msg = string.Format("Ich verknüpfe den Termin mit Maschine '{0}' von '{1}'", mRow.Maschine, mRow.Firma);
				MetroMessageBox.Show(this, msg, "Verknüpfen mit Maschine", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var machine = ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, mRow.UID, "Kundenmaschine");

				// Den Eigentümer der Maschine hinzufügen, wenn er noch nicht verknüpft wurde.
				if (kunde == null)
				{
					kunde = ModelManager.CustomerService.GetKunde((machine as Kundenmaschine).Kundennummer, true);
					if (kunde != null && !ModelManager.AppointmentService.GetLinkedItemsList(this.myAppointment).Contains(kunde as ILinkedItem))
					{
						this.AddLinkToCustomer(kunde);
					}
				}
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void AddLinkToSupplier()
		{
			var llv = new LieferantenListView();
			if (llv.ShowDialog() == DialogResult.OK && llv.SelectedLieferant != null)
			{
				var lieferant = llv.SelectedLieferant;
				var msg = string.Format("Ich verknüpfe den Termin mit Lieferant '{0}'", lieferant.Name1);
				MetroMessageBox.Show(this, msg, "Verknüpfen mit Lieferant", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, lieferant.Lieferantennummer, "Lieferant");
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void AddLinkToUser()
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK && usv.SelectedUser != null)
			{
				var user = usv.SelectedUser;
				var msg = string.Format("Ich verknüpfe den Termin mit '{0}'.", user.NameFull);
				MetroMessageBox.Show(this, msg, "Verknüpfen mit Mitarbeiter", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, user.UID, "Mitarbeiter");
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void AddLinkToFile()
		{
			var ofd = new OpenFileDialog();
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ofd.Multiselect = true;
			ofd.Filter = "Alle Dateien|*.*|CSV-Dateien (*.csv)|*.csv|PDF (*.pdf)|*.pdf|Excel (*.xls*)|*.xls*|Word (*.doc*)|*.doc*|Text (*.txt)|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				var files = ofd.FileNames;
				var counter = 0;
				foreach (var file in files)
				{
					var newFilename = ModelManager.FileLinkService.CopyFileToServerLinkFolder(file);
					ModelManager.AppointmentService.AddLinkedItemToAppointment(this.myAppointment, newFilename.FullName, "Datei");
					counter += 1;
				}
				var msg = string.Format("Ich habe {0} Dateien mit diesem Termin verknüpft und auf den Server kopiert.", counter);
				MetroMessageBox.Show(this, msg, "Termin mit Dateien verknüpfen", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.dgvLinkedItems.Sort(this.dgvLinkedItems.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
			}
		}

		void OpenLinkedItem()
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

		void RemoveLinkedItem()
		{
			if (this.mySelectedLinkedItem != null)
			{
				var msg = string.Format("Ich entferne die Verknüpfung mit '{0}'", this.mySelectedLinkedItem.ItemName);
				if (MetroMessageBox.Show(this, msg, "Verknüpfung", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
				{
					ModelManager.AppointmentService.RemoveLinkedItemFromAppointment(this.myAppointment, this.mySelectedLinkedItem);
				}
			}
		}

		void ShowCalendarSettings()
		{
			if (this.myCurrentUser == null) this.myCurrentUser = ModelManager.UserService.CurrentUser;
			var csv = new CalendarSettingsView(this.myCurrentUser.CalendarSettings);
			csv.ShowDialog();
		}

		#endregion PRIVATE PROCEDURES
	}
}