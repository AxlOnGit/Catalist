using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Model;
using Products.Model.Builder;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlKundenMaschine : pnlSlider
	{
		#region MEMBERS

		private readonly KundeMainView myParent;
		private readonly Kundenmaschine myMachine;
		private FileInfo mySelectedFile;
		private Notiz mySelectedNote;
		private Appointment mySelectedAppointment;
		private Kundensoftware mySelectedSoftware;
		private bool myNotesInitialized;
		private bool mySoftwareInitialized;
		private bool myAppointmentInitialized;
		private bool myOrderInitialized;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt die Instanz der in diesem Panel angezeigten Kundenmaschine zurück.
		/// </summary>
		public Kundenmaschine Maschine => this.myMachine;

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public pnlKundenMaschine(ContainerControl parentCtrl, Kundenmaschine machine, bool keepLoaded = true) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myMachine = machine;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		#region INIT EVENTS

		private void mtabProperties_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Daten der einzelnen Tabs laden
			var ix = this.mtabProperties.SelectedIndex;
			switch (ix)
			{
				case 1:   // Notizen
				if (this.myNotesInitialized) return;
				this.tabNotes.SuspendLayout();
				this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(this.myMachine.Key, this.myMachine.LinkTypeId);
				this.myNotesInitialized = true;
				this.tabNotes.ResumeLayout();
				break;

				case 2:   // Service/Wartung
				if (this.myAppointmentInitialized) return;
				this.mtabProperties.SuspendLayout();
				this.dgvAppointments.DataSource = ModelManager.AppointmentService.GetAppointmentList(this.myMachine).Sort("StartsAt", System.ComponentModel.ListSortDirection.Descending);
				this.myAppointmentInitialized = true;
				this.mtabProperties.ResumeLayout();
				break;

				case 3:   // Software
				if (this.mySoftwareInitialized) return;
				// TAB SOFTWARE
				this.tabSoftware.SuspendLayout();
				this.dgvSoftware.DataSource = ModelManager.SoftwareService.GetMachinesSoftware(this.myMachine);
				this.mySoftwareInitialized = true;
				this.tabSoftware.ResumeLayout();
				break;

				case 4:   // Auftrag/Finanzierung
				if (this.myOrderInitialized) return;
				// TAB AUFTRÄGE
				this.mtabProperties.SuspendLayout();
				this.mtxtAuftrag.DataBindings.Add("Text", this.myMachine, "AuftragsnummerSage");
				this.mtxtRechnung.DataBindings.Add("Text", this.myMachine, "RechnungsnummerSage");
				this.mtxtLieferschein.DataBindings.Add("Text", this.myMachine, "LieferscheinnummerSage");
				//this.mtxtSageInfos.DataBindings.Add("Text", this.myMachine, "SageOrderInfo");
				this.ndtpAuftrag.Value = this.myMachine.Auftragsdatum;
				this.ndtpRechnung.Value = this.myMachine.Rechnungsdatum;
				this.ndtpLieferschein.Value = this.myMachine.Lieferdatum;
				this.ndtpInstallation.Value = this.myMachine.Installationsdatum;

				this.mcmbTechniker.DisplayMember = "NameFirst";
				this.mcmbTechniker.ValueMember = "UID";
				this.mcmbTechniker.DataSource = ModelManager.UserService.GetSpecialUserList(Model.Services.UserService.SpecialUserType.Technicien);
				this.mcmbTechniker.DataBindings.Add("SelectedValue", this.myMachine, "InstallationDurchId");

				this.mtogglLeasing.DataBindings.Add("Checked", this.myMachine, "LeasingFlag");
				this.mtogglMietkauf.DataBindings.Add("Checked", this.myMachine, "ErstverwertungsFlag");
				this.mtogglErstverwertung.DataBindings.Add("Checked", this.myMachine, "ErstverwertungsFlag");
				this.mtxtFinanzierungDurch.DataBindings.Add("Text", this.myMachine, "Finanzierungsgesellschaft");
				this.ndtpVertragsende.Value = this.myMachine.Finanzierungsende;
				this.myOrderInitialized = true;
				this.mtabProperties.ResumeLayout();
				break;
			}
		}

		#endregion INIT EVENTS

		#region FILES EVENTS

		private void trvFolders_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var dirInfo = e.Node.Tag as DirectoryInfo;
			if (dirInfo != null)
			{
				var option = SearchOption.TopDirectoryOnly;
				if (e.Node.Parent == null) option = SearchOption.AllDirectories;
				var getFilesResult = dirInfo.GetFiles("*.*", option);
				var files = new SortableBindingList<FileInfo>(getFilesResult);
				this.dgvFiles.DataSource = files.Sort("LastWriteTime", System.ComponentModel.ListSortDirection.Descending);
			}
		}

		private void dgvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedFile = this.dgvFiles.Rows[e.RowIndex].DataBoundItem as FileInfo;
		}

		private void dgvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenFile();
		}

		private void xcmdOpenInExplorer_Click(object sender, EventArgs e)
		{
			this.OpenFolder();
		}

		private void xcmdOpenFile_Click(object sender, EventArgs e)
		{
			this.OpenFile();
		}

		private void mbtnLoadSageInfo_Click(object sender, EventArgs e)
		{
			this.mtxtSageInfos.Text = this.myMachine.SageOrderInfo;
		}

		#endregion FILES EVENTS

		#region NOTES EVENTS

		private void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mtxtNoteText.Text = string.Empty;
			this.mySelectedNote = this.dgvNotizen.Rows[e.RowIndex].DataBoundItem as Notiz;
			this.mtxtNoteText.Text = (this.mySelectedNote != null) ? this.mySelectedNote.Body : string.Empty;
		}

		private void mbtnOpenNote_Click(object sender, EventArgs e)
		{
			this.OpenNote();
		}

		private void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenNote();
		}

		private void mbtnCreateNote_Click(object sender, EventArgs e)
		{
			this.CreateNote();
		}

		private void btnDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		private void mtxtNoteText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.mySelectedNote == null) return;
			this.mySelectedNote.Body = this.mtxtNoteText.Text;
		}

		#endregion NOTES EVENTS

		#region APPOINTMENT EVENTS

		private void dgvAppointments_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var termin = this.dgvAppointments.Rows[e.RowIndex].DataBoundItem as Appointment;
			this.mySelectedAppointment = termin;
		}

		private void dgvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedAppointment == null) return;
			this.ShowAppointment();
		}

		private void xcmdOpenAppointment_Click(object sender, EventArgs e)
		{
			this.ShowAppointment();
		}

		private void xcmdShowCalendarView_Click(object sender, EventArgs e)
		{
			ServiceManager.UiService.ShowCalendar();
		}

		private void xcmdWartungsvorschlag_Click(object sender, EventArgs e)
		{
			var wvv = new WartungsvorschlagView(this.myMachine.CurrentOwner);
			wvv.Show();
		}

		#endregion APPOINTMENT EVENTS

		#region SOFTWARE EVENTS

		private void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedSoftware = this.dgvSoftware.Rows[e.RowIndex].DataBoundItem as Kundensoftware;
		}

		private void mbtnOpenSoftware_Click(object sender, EventArgs e)
		{
			this.OpenSoftware();
		}

		private void dgvSoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenSoftware();
		}

		private void mbtnCreateSoftware_Click(object sender, EventArgs e)
		{
			this.CreateSoftware();
		}

		private void mbtnDeleteSoftware_Click(object sender, EventArgs e)
		{
			this.DeleteSoftware();
		}

		#endregion SOFTWARE EVENTS

		#region FINANCIALS EVENTS

		private void mbtnSearchInSage_Click(object sender, EventArgs e)
		{
			var msg = string.Empty;
			if (string.IsNullOrEmpty(this.myMachine.Seriennummer)) msg = "Für die Maschine wurde noch keine Seriennummer eingetragen!";
			msg = ModelManager.OrderService.GetOrderInfoBySerialNumber(this.myMachine.Seriennummer, this.myMachine.CurrentOwner.CustomerId);
			MetroMessageBox.Show(this, msg, "Vorgangssuche in SAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void mbtnOpenInSage_Click(object sender, EventArgs e)
		{
			try
			{
				var shorty = ModelManager.UserService.CurrentUser.SageLoginName;
				var auftrag = this.myMachine.AuftragsnummerSage.Trim();
				SageBridge.ServiceManager.SageService.StartSageApp(SageBridge.Services.SageService.SageAppType.Auftrag, shorty, auftrag, "");
			}
			catch (ArgumentException aEx)
			{
				MetroMessageBox.Show(this, aEx.Message, "Fehler beim Öffnen von SAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ndtpAuftrag_Validated(object sender, EventArgs e)
		{
			if (this.ndtpAuftrag.Value == null)
			{
				this.myMachine.Auftragsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpAuftrag.Value;
			this.myMachine.Auftragsdatum = date;
		}

		private void ndtpRechnung_Validated(object sender, EventArgs e)
		{
			if (this.ndtpRechnung.Value == null)
			{
				this.myMachine.Rechnungsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpRechnung.Value;
			this.myMachine.Rechnungsdatum = date;
		}

		private void ndtpLieferschein_Validated(object sender, EventArgs e)
		{
			if (this.ndtpLieferschein.Value == null)
			{
				this.myMachine.Lieferdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpLieferschein.Value;
			this.myMachine.Lieferdatum = date;
		}

		private void ndtpInstallation_Validated(object sender, EventArgs e)
		{
			if (this.ndtpInstallation.Value == null)
			{
				this.myMachine.Installationsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpInstallation.Value;
			this.myMachine.Installationsdatum = date;
		}

		private void ndtpVertragsende_Validated(object sender, EventArgs e)
		{
			if (ndtpVertragsende.Value == null)
			{
				this.myMachine.Finanzierungsende = null;
				return;
			}
			var date = (DateTime)this.ndtpVertragsende.Value;
			this.myMachine.Finanzierungsende = date;
		}

		private void xcmdKundenauftrag_Click(object sender, EventArgs e)
		{
			if (this.myMachine.Maschinenauftrag != null)
			{
				var mav = new MaschinenauftragView(this.myMachine.Maschinenauftrag);
				mav.Show();
			}
			else
			{
				var neuerAuftrag = ModelManager.MachineService.AddMaschinenauftrag(this.myMachine);
				if (neuerAuftrag != null)
				{
					var mav = new MaschinenauftragView(neuerAuftrag);
					mav.Show();
				}
			}
		}

		private void mctxAuftrag_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.myMachine.Maschinenauftrag == null)
			{
				this.xcmdKundenauftrag.Text = "Maschinenauftrag erstellen";
			}
			else this.xcmdKundenauftrag.Text = "Maschinenauftrag öffnen";
		}

		#endregion FINANCIALS EVENTS

		#region FINISHING EVENTS

		private void pnlKundenMaschine_Leave(object sender, EventArgs e)
		{
			if (this.myMachine == null) return;
			ModelManager.MachineService.UpdateMachines();
			ModelManager.FileLinkService.Update();
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion FINISHING EVENTS

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		#region INIT PROCEDURES

		private void InitializeData()
		{
			this.dgvFiles.AutoGenerateColumns = false;
			this.dgvNotizen.AutoGenerateColumns = false;
			this.dgvAppointments.AutoGenerateColumns = false;
			this.dgvSoftware.AutoGenerateColumns = false;

			// PANEL
			this.mlblTitel.DataBindings.Add("Text", this.myMachine, "ItemName");

			this.cmbMachineModel.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			this.cmbMachineModel.DisplayMember = "Modellbezeichnung";
			this.cmbMachineModel.ValueMember = "UID";
			this.cmbMachineModel.DataBindings.Add("SelectedValue", this.myMachine, "MaschinenmodellId");

			this.mtxtSerialNumber.DataBindings.Add("Text", this.myMachine, "Seriennummer");

			this.cmbInkType.DataSource = ModelManager.SharedItemsService.TinteList.Sort("Tintenbezeichnung", System.ComponentModel.ListSortDirection.Ascending);
			this.cmbInkType.ValueMember = "UID";
			this.cmbInkType.DisplayMember = "Tintenbezeichnung";
			this.cmbInkType.DataBindings.Add("SelectedValue", this.myMachine, "TintenId");

			this.txtColorSet.DataBindings.Add("Text", this.myMachine, "Farbset");
			this.mtxtFirmware.DataBindings.Add("Text", this.myMachine, "Firmware");

			// TAB DATEIEN
			this.CheckExistsMachineFolder();
			var dirInfo = new DirectoryInfo(this.myMachine.Dateipfad);
			var nodes = this.trvFolders.Nodes;
			nodes.Clear();
			var rootNode = nodes.Add(this.myMachine.ItemName);
			rootNode.Tag = dirInfo;
			this.AddSubNodes(rootNode);
			this.trvFolders.SelectedNode = rootNode;

			this.mtabProperties.SelectedIndex = 0; // Fokus auf Tab Dateien setzen
		}

		private void AddSubNodes(TreeNode forNode)
		{
			var dirInfo = forNode.Tag as DirectoryInfo;
			if (dirInfo != null && dirInfo.Exists)
			{
				foreach (var subDir in dirInfo.GetDirectories())
				{
					var subNode = forNode.Nodes.Add(subDir.Name);
					subNode.Tag = subDir;
					AddSubNodes(subNode);
				}
			}
			forNode.EnsureVisible();
		}

		private void CheckExistsMachineFolder()
		{
			var machinePath = ModelManager.MachinePathCreatorService.CheckOrCreateMachinePath(this.myMachine);
			if (!string.IsNullOrEmpty(machinePath))
			{
				this.myMachine.Dateipfad = machinePath;
				ModelManager.MachineService.UpdateMachines();
			}
		}

		#endregion INIT PROCEDURES

		#region FILES PROCEDURES

		private void OpenFolder()
		{
			var treeNode = this.trvFolders.SelectedNode;
			if (treeNode == null || treeNode.Tag == null) return;

			var si = new ProcessStartInfo();
			si.FileName = "explorer.exe";
			si.Arguments = (treeNode.Tag as DirectoryInfo).FullName;
			Process.Start(si);
		}

		private void OpenFile()
		{
			if (this.mySelectedFile == null) return;
			Process.Start(this.mySelectedFile.FullName);
		}

		#endregion FILES PROCEDURES

		#region NOTES PROCEDURES

		private void OpenNote()
		{
			if (mySelectedNote == null) return;
			var nv = new NotizView(this.mySelectedNote, this.myMachine.CurrentOwner);
			nv.Show();
		}

		private void CreateNote()
		{
			var builder = new NoteBuilder(this.myMachine.CurrentOwner, this.myMachine);
			var note = ModelManager.NotesService.AddNote(builder);
			this.myParent.ShowNotiz(note);
		}

		private void DeleteNote()
		{
			if (this.mySelectedNote == null) return;
			var msg = string.Empty;
			switch (this.mySelectedNote.GetCanDelete())
			{
				case true:
				msg = $"Soll ich die Notiz '{this.mySelectedNote.Subject}' vom {this.mySelectedNote.AssignedAt:d} wirklich löschen?";
				if (MetroMessageBox.Show(this, msg, "Catalist - Kundenmaschine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.NotesService.DeleteNote(this.mySelectedNote);
				}
				break;

				case false:
				msg = $"Die Notiz '{this.mySelectedNote.Subject}' vom {this.mySelectedNote.AssignedAt:d} kann nicht gelöscht werden. Sie ist noch mit mindestens einer Datei verknüpft.";
				MetroMessageBox.Show(this, msg, "Notiz zur Kundenmaschine", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
		}

		#endregion NOTES PROCEDURES

		#region APPOINTMENT PROCEDURES

		private void ShowAppointment()
		{
			if (this.mySelectedAppointment == null) return;

			var cdv = new CalendarDetailView(this.mySelectedAppointment);
			cdv.Show();
		}

		#endregion APPOINTMENT PROCEDURES

		#region SOFTWARE PROCEDURES

		private void OpenSoftware()
		{
			if (this.mySelectedSoftware == null) return;
			this.myParent.ShowSoftware(this.mySelectedSoftware);
		}

		private void CreateSoftware()
		{
			var software = ModelManager.SoftwareService.AddKundenSoftware(this.myMachine.CurrentOwner, this.myMachine);
			if (software == null)
			{
				var msg = $"Beim Erstellen der Software ist etwas schief gelaufen.";
				MetroMessageBox.Show(this, msg, "Software für Kundenmaschine", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.myParent.ShowSoftware(software);
		}

		private void DeleteSoftware()
		{
			throw new ApplicationException("Is nochnich fettich");
		}

		#endregion SOFTWARE PROCEDURES

		#endregion PRIVATE PROCEDURES
	}
}