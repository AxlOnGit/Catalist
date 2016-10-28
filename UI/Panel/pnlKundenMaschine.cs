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
		#region members

		readonly KundeMainView myParent;
		readonly Kundenmaschine myMachine;
		FileInfo mySelectedFile;
		Notiz mySelectedNote;
		Kundensoftware mySelectedSoftware;
		bool myNotesInitialized;
		bool mySoftwareInitialized;
		bool myOrderInitialized;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt die Instanz der in diesem Panel angezeigten Kundenmaschine zurück.
		/// </summary>
		public Kundenmaschine Maschine { get { return this.myMachine; } }

		#endregion public properties

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

		void mtabProperties_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Daten der einzelnen Tabs laden
			var ix = this.mtabProperties.SelectedIndex;
			switch (ix)
			{
				case 1:   // Notizen
					if (this.myNotesInitialized) return;
					this.tabNotes.SuspendLayout();
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(this.myMachine.Key, this.myMachine.LinkTypeId);
					this.tabNotes.ResumeLayout();
					this.myNotesInitialized = true;
					break;

				case 2:   // Software
					if (this.mySoftwareInitialized) return;
					// TAB SOFTWARE
					this.tabSoftware.SuspendLayout();
					this.dgvSoftware.DataSource = ModelManager.SoftwareService.GetMachinesSoftware(this.myMachine);
					this.tabSoftware.ResumeLayout();
					this.mySoftwareInitialized = true;
					break;

				case 3:   // Auftrag/Finanzierung
					if (this.myOrderInitialized) return;
					// TAB AUFTRÄGE
					this.mtabProperties.SuspendLayout();
					this.mtxtAuftrag.DataBindings.Add("Text", this.myMachine, "AuftragsnummerSage");
					this.mtxtRechnung.DataBindings.Add("Text", this.myMachine, "RechnungsnummerSage");
					this.mtxtLieferschein.DataBindings.Add("Text", this.myMachine, "LieferscheinnummerSage");
					this.mtxtSageInfos.DataBindings.Add("Text", this.myMachine, "SageOrderInfo");
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

					this.mtabProperties.ResumeLayout();

					this.myOrderInitialized = true;
					break;
			}
		}

		#endregion INIT EVENTS

		#region FILES EVENTS

		void trvFolders_AfterSelect(object sender, TreeViewEventArgs e)
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

		void dgvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedFile = this.dgvFiles.Rows[e.RowIndex].DataBoundItem as FileInfo;
		}

		void dgvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenFile();
		}

		void xcmdOpenInExplorer_Click(object sender, EventArgs e)
		{
			this.OpenFolder();
		}

		void xcmdOpenFile_Click(object sender, EventArgs e)
		{
			this.OpenFile();
		}

		#endregion FILES EVENTS

		#region NOTES EVENTS

		void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mtxtNoteText.Text = string.Empty;
			this.mySelectedNote = this.dgvNotizen.Rows[e.RowIndex].DataBoundItem as Notiz;
			this.mtxtNoteText.Text = (this.mySelectedNote != null) ? this.mySelectedNote.Body : string.Empty;
		}

		void mbtnOpenNote_Click(object sender, EventArgs e)
		{
			this.OpenNote();
		}

		void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenNote();
		}

		void mbtnCreateNote_Click(object sender, EventArgs e)
		{
			this.CreateNote();
		}

		void btnDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void mtxtNoteText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.mySelectedNote == null) return;
			this.mySelectedNote.Body = this.mtxtNoteText.Text;
		}

		#endregion NOTES EVENTS

		#region SOFTWARE EVENTS

		void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedSoftware = this.dgvSoftware.Rows[e.RowIndex].DataBoundItem as Kundensoftware;
		}

		void mbtnOpenSoftware_Click(object sender, EventArgs e)
		{
			this.OpenSoftware();
		}

		void dgvSoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenSoftware();
		}

		void mbtnCreateSoftware_Click(object sender, EventArgs e)
		{
			this.CreateSoftware();
		}

		void mbtnDeleteSoftware_Click(object sender, EventArgs e)
		{
			this.DeleteSoftware();
		}

		#endregion SOFTWARE EVENTS

		#region AUFTRÄGE EVENTS

		void mbtnSearchInSage_Click(object sender, EventArgs e)
		{
			var msg = string.Empty;
			if (string.IsNullOrEmpty(this.myMachine.Seriennummer)) msg = "Für die Maschine wurde noch keine Seriennummer eingetragen!";
			msg = ModelManager.OrderService.GetOrderInfoBySerialNumber(this.myMachine.Seriennummer, this.myMachine.CurrentOwner.CustomerId);
			MetroMessageBox.Show(this, msg, "Vorgangssuche in SAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void mbtnOpenInSage_Click(object sender, EventArgs e)
		{
		}

		void ndtpAuftrag_Validated(object sender, EventArgs e)
		{
			if (this.ndtpAuftrag.Value == null)
			{
				this.myMachine.Auftragsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpAuftrag.Value;
			this.myMachine.Auftragsdatum = date;
		}

		void ndtpRechnung_Validated(object sender, EventArgs e)
		{
			if (this.ndtpRechnung.Value == null)
			{
				this.myMachine.Rechnungsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpRechnung.Value;
			this.myMachine.Rechnungsdatum = date;
		}

		void ndtpLieferschein_Validated(object sender, EventArgs e)
		{
			if (this.ndtpLieferschein.Value == null)
			{
				this.myMachine.Lieferdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpLieferschein.Value;
			this.myMachine.Lieferdatum = date;
		}

		void ndtpInstallation_Validated(object sender, EventArgs e)
		{
			if (this.ndtpInstallation.Value == null)
			{
				this.myMachine.Installationsdatum = null;
				return;
			}
			var date = (DateTime)this.ndtpInstallation.Value;
			this.myMachine.Installationsdatum = date;
		}

		void ndtpVertragsende_Validated(object sender, EventArgs e)
		{
			if (ndtpVertragsende.Value == null)
			{
				this.myMachine.Finanzierungsende = null;
				return;
			}
			var date = (DateTime)this.ndtpVertragsende.Value;
			this.myMachine.Finanzierungsende = date;
		}

		#endregion AUFTRÄGE EVENTS

		#region FINISHING EVENTS

		void pnlKundenMaschine_Leave(object sender, EventArgs e)
		{
			if (this.myMachine == null) return;
			ModelManager.MachineService.UpdateMachines();
			ModelManager.FileLinkService.Update();
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion FINISHING EVENTS

		#endregion EVENT HANDLER

		#region private procedures

		#region INIT PROCEDURES

		void InitializeData()
		{
			this.dgvFiles.AutoGenerateColumns = false;
			this.dgvNotizen.AutoGenerateColumns = false;
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

		void AddSubNodes(TreeNode forNode)
		{
			var dirInfo = forNode.Tag as DirectoryInfo;
			if (dirInfo != null)
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

		void CheckExistsMachineFolder()
		{
			if (string.IsNullOrEmpty(this.myMachine.Dateipfad) || !Directory.Exists(this.myMachine.Dateipfad))
			{
				// Dateipfad der Serie ermitteln z. B.: "\\NASE82002\technik\Service Maschinen\Mimaki\CJV\CJV30"
				var pfadSerie = this.myMachine.Maschinenserie.Dateipfad;

				// Ordner für die Maschine zusammenbauen. Schema: "Modell +_+ Seriennummer + (Kundenmatchcode)"
				var sn = this.myMachine.Seriennummer.Replace("/", "_");
				var model = this.myMachine.Modellbezeichnung;
				var owner = this.myMachine.CurrentOwner.Matchcode.Replace("/", "_");
				var ordnerMaschine = $"{model}_{sn} ({owner})";

				// Den Maschinenordner im Dateisystem erstellen
				try
				{
					var ordnerKomplett = Path.Combine(pfadSerie, ordnerMaschine);
					Directory.CreateDirectory(ordnerKomplett);
					this.myMachine.Dateipfad = ordnerKomplett;
					ModelManager.MachineService.UpdateMachines();
				}
				catch (Exception ex)
				{
					var nl = Environment.NewLine;
					MetroMessageBox.Show(this, "Fehler beim Anlegen des Maschinenordners", $"{nl}{ex.Message}{nl}Sehr wahrscheinlich enthält die Seriennummer ein Kackzeichen, das garnicht geht!",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		#endregion INIT PROCEDURES

		#region FILES PROCEDURES

		void OpenFolder()
		{
			var treeNode = this.trvFolders.SelectedNode;
			if (treeNode == null || treeNode.Tag == null) return;

			var si = new ProcessStartInfo();
			si.FileName = "explorer.exe";
			si.Arguments = (treeNode.Tag as DirectoryInfo).FullName;
			Process.Start(si);
		}

		void OpenFile()
		{
			if (this.mySelectedFile == null) return;
			Process.Start(this.mySelectedFile.FullName);
		}

		#endregion FILES PROCEDURES

		#region NOTES PROCEDURES

		void OpenNote()
		{
			if (mySelectedNote == null) return;
			var nv = new NotizView(this.mySelectedNote, this.myMachine.CurrentOwner);
			nv.Show();
		}

		void CreateNote()
		{
			var builder = new NoteBuilder(this.myMachine.CurrentOwner, this.myMachine);
			var note = ModelManager.NotesService.AddNote(builder);
			this.myParent.ShowNotiz(note);
		}

		void DeleteNote()
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

		#region SOFTWARE PROCEDURES

		void OpenSoftware()
		{
			if (this.mySelectedSoftware == null) return;
			this.myParent.ShowSoftware(this.mySelectedSoftware);
		}

		void CreateSoftware()
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

		void DeleteSoftware()
		{
			throw new ApplicationException("Is nochnich fettich");
		}

		#endregion SOFTWARE PROCEDURES

		#endregion private procedures
	}
}