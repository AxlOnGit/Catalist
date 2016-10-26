using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Interfaces;
using Products.Common.Views;
using Products.Model;
using Products.Model.Builder;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlMaschinendetail : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		Kundenmaschine myMachine;

		Notiz mySelectedNotiz;
		Kundensoftware mySelectedSoftware;
		FileLink mySelectedDateilink;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt die im Panel geladene Maschine zurück.
		/// </summary>
		public Kundenmaschine Maschine { get { return this.myMachine; } }

		#endregion public properties

		#region ### .ctor ###

		public pnlMaschinendetail(ContainerControl parentCtrl, Kundenmaschine kundenmaschine, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myMachine = kundenmaschine;

			this.dgvDateilinks.MouseDoubleClick += dgvDateilinks_MouseDoubleClick;
			this.dgvDateilinks.RowEnter += dgvDateilinks_RowEnter;
			this.OnClosed += pnlMaschinendetail_OnClosed;
			Application.Idle += Application_Idle;
			this.mtxtSerialNumber.Validated += MtxtSerialNumber_Validated;

			this.InitializeData();
		}

		void MtxtSerialNumber_Validated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.myMachine.Dateipfad)) return; // nur, wenn noch kein Dateipfad existiert

			var nullGuid = "00000000-0000-0000-0000-000000000000";
			if (!this.myMachine.MaschinenmodellId.Equals(nullGuid, StringComparison.Ordinal) && !string.IsNullOrEmpty(this.mtxtSerialNumber.Text))
			{
				// Für diese Maschine einen Technikordner erstellen
				this.CreateDateipfad();
			}
		}

		#endregion ### .ctor ###

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			this.btnDeleteNotiz.Visible = this.mySelectedNotiz != null && this.mySelectedNotiz.GetCanDelete();
			this.btnDeleteSoftware.Visible = this.mySelectedSoftware != null && this.mySelectedSoftware.GetCanDelete();
		}

		void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var notiz = dgvNotizen.Rows[e.RowIndex].DataBoundItem as Notiz;
			if (notiz != null)
			{
				mySelectedNotiz = notiz;
			}
		}

		void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var software = dgvSoftware.Rows[e.RowIndex].DataBoundItem as Kundensoftware;
			if (software != null)
			{
				mySelectedSoftware = software;
			}
		}

		void ndtpAuftragsdatum_Validated(object sender, EventArgs e)
		{
			if (this.ndtpAuftragsdatum.Value == null)
			{
				this.myMachine.Auftragsdatum = null;
			}
			else
			{
				this.myMachine.Auftragsdatum = DateTime.Parse(this.ndtpAuftragsdatum.Value.ToString());
			}
		}

		void ndtpKaufdatum_Validated(object sender, EventArgs e)
		{
			if (this.ndtpKaufdatum.Value == null)
			{
				this.myMachine.Kaufdatum = null;
			}
			else
			{
				this.myMachine.Kaufdatum = DateTime.Parse(this.ndtpKaufdatum.Value.ToString());
			}
		}

		void ndtpFinanzierungsende_Validated(object sender, EventArgs e)
		{
			if (this.ndtpFinanzierungsende.Value == null)
			{
				this.myMachine.Finanzierungsende = null;
			}
			else
			{
				this.myMachine.Finanzierungsende = DateTime.Parse(this.ndtpFinanzierungsende.Value.ToString());
			}
		}

		void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowNote();
		}

		void btnShowNotiz_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void btnAddNotiz_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void btnDeleteNotiz_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void xcmdAddNote_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void xcmdShowNote_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void xcmdDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void dgvSoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowSoftware();
		}

		void btnShowSoftware_Click(object sender, EventArgs e)
		{
			this.ShowSoftware();
		}

		void btnAddSoftware_Click(object sender, EventArgs e)
		{
			this.AddSoftware();
		}

		void ModelService_OnMachineDeleted(object sender, Model.EventSystem.MachineDeletedEventArgs e)
		{
			ClearDatabindings();
			myMachine = null;
		}

		void dgvDateilinks_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedDateilink = dgvDateilinks.Rows[e.RowIndex].DataBoundItem as FileLink;
		}

		void btnAddFileLink_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = ".*";
			ofd.Filter = "Alle Dateien (*.*)|*.*|CSV-Dateien (*.csv)|*.csv|Bilddateien (*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ofd.Multiselect = false;
			ofd.Title = "Datei zu Kundenmaschine hinzufügen";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				var msg = string.Format("Ok, ich verknüpfe Datei\n{0}\nund kopiere sie auf den Server.\n\nWillst Du die Originaldatei behalten?", ofd.FileName);
				switch (MetroMessageBox.Show(this, msg, "Dateiverknüpfungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
				{
					// Originaldatei behalten.
					case DialogResult.Yes:
						AddFileLink(ofd.FileName);
						break;

					// Originaldatei zum Teufel jagen.
					case DialogResult.No:
						AddFileLink(ofd.FileName, false);
						break;
				}
			}
			myMachine.Update();
			this.dgvDateilinks.DataSource = ModelManager.FileLinkService.GetFileLinkList(this.myMachine.UID);
		}

		void btnShowFileLink_Click(object sender, EventArgs e)
		{
			this.OpenFileLink();
		}

		void btnCopyFile_Click(object sender, EventArgs e)
		{
			var origFilePath = this.mySelectedDateilink.FullName;
			var newFileName = string.Empty;
			try
			{
				if (this.mySelectedDateilink.FileTitle.ToLower().EndsWith(this.mySelectedDateilink.Extension.ToLower(), StringComparison.CurrentCulture))
				{
					newFileName = this.mySelectedDateilink.FileTitle;
				}
				else
				{
					newFileName = string.Format("{0}.{1}", this.mySelectedDateilink.FileTitle, this.mySelectedDateilink.Extension.ToLower());
				}
				var newPath = string.Empty;
				var fbd = new FolderBrowserDialog();
				fbd.Description = "Wo soll die Datei gespeichert werden?";
				fbd.RootFolder = Environment.SpecialFolder.MyComputer;
				fbd.ShowNewFolderButton = true;
				if (fbd.ShowDialog(this) == DialogResult.OK)
				{
					newPath = Path.Combine(fbd.SelectedPath, newFileName);
					File.Copy(origFilePath, newPath);
					Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(newPath));
				}
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, "Das hat nicht geklappt", "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void dgvDateilinks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenFileLink();
		}

		void btnSearchFiles_Click(object sender, EventArgs e)
		{
			this.SearchFiles();
		}

		void cmnuSearchFiles_Click(object sender, EventArgs e)
		{
			this.SearchFiles();
		}

		void btnDeleteDateilink_Click(object sender, EventArgs e)
		{
			if (this.mySelectedDateilink != null)
			{
				var msg = "Soll auch die gespeicherte Datei auf dem Server gelöscht werden?";
				var fileAndPath = this.mySelectedDateilink.FullName;
				if (MetroMessageBox.Show(this, msg, "Datei löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.myMachine.RemoveFileLink(this.mySelectedDateilink, true);
				}
				else
				{
					this.myMachine.RemoveFileLink(this.mySelectedDateilink, false);
				}
				this.mySelectedDateilink = null;
			}
		}

		void mbtnCreateInstFiles_Click(object sender, EventArgs e)
		{
			this.CreateInstFiles();
		}

		void mbtnOpenDateipfad_Click(object sender, EventArgs e)
		{
			this.CreateDateipfad();
			//Utils.OpenInExplorer(this.myMachine.Dateipfad);
			var fev = new FileExplorerView(this.myMachine);
			fev.Show();
		}

		void mbtnCreateDateipfad_Click(object sender, EventArgs e)
		{
			this.CreateDateipfad();
		}

		void ClearDatabindings()
		{
			this.txtColorSet.DataBindings.Clear();
			this.txtFirmware.DataBindings.Clear();
			this.txtGekauftBei.DataBindings.Clear();
			this.mtxtSerialNumber.DataBindings.Clear();
			this.txtAuftragInSage.DataBindings.Clear();
			this.txtFinanzierungsgesellschaft.Clear();
			this.txtWartungsintervall.DataBindings.Clear();
			this.cmbMachineModel.DataBindings.Clear();
			this.cmbInkType.DataBindings.Clear();
		}

		#region Drag 'n Drop

		void dgvDateilinks_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
			{
				var filenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];
				//DialogResult result = MessageBox.Show("Sollen die Originaldateien nach dem Kopieren gelöscht werden?", "Dateien verknüpfen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if ((e.KeyState & 4) == 4)
				{
					foreach (string filename in filenames)
					{
						this.AddFileLink(filename, false);
						// Kleinet Päusken, damit der Butzemann in Ruhe kopieren kann. 500 ms sollten
						// reichen ...
						Thread.Sleep(500);
					}
				}
				else
				{
					foreach (string filename in filenames)
					{
						this.AddFileLink(filename, true);
						Thread.Sleep(500);
					}
				}
			}
			this.dgvDateilinks.DataSource = ModelManager.FileLinkService.GetFileLinkList(this.myMachine.UID);
		}

		void dgvDateilinks_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
			{
				if ((e.KeyState & 4) == 4)
				{
					e.Effect = DragDropEffects.Link;
				}
				else
				{
					e.Effect = DragDropEffects.Copy;
				}
			}
		}

		#endregion Drag 'n Drop

		void pnlMaschinendetail_OnClosed(object sender, EventArgs e)
		{
			if (this.myMachine == null) return;
			ModelManager.MachineService.UpdateMachines();
			ModelManager.FileLinkService.Update();
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			var machineAsLink = this.myMachine as ILinkedItem;

			//this.Text = string.Format(@"Kundenmaschine von {0}, {1} [{2}]", myMachine.Kunde.CompanyName1, myMachine.Kunde.City, myMachine.Kunde.CustomerId.Substring(0, 5));
			this.mlblTitel.Text = string.Format("{0} [SN: {1}]", this.myMachine.Modellbezeichnung, string.IsNullOrEmpty(this.myMachine.Seriennummer) ? "?" : this.myMachine.Seriennummer);

			this.txtColorSet.DataBindings.Add("Text", this.myMachine, "Farbset");
			this.txtFirmware.DataBindings.Add("Text", this.myMachine, "Firmware");
			this.txtGekauftBei.DataBindings.Add("Text", this.myMachine, "GekauftBei");
			this.mtxtSerialNumber.DataBindings.Add("Text", this.myMachine, "Seriennummer");
			this.txtAuftragInSage.DataBindings.Add("Text", this.myMachine, "AuftragsnummerSage");
			this.mtxtRechnungInSage.DataBindings.Add("Text", this.myMachine, "RechnungsnummerSage");
			this.txtFinanzierungsgesellschaft.DataBindings.Add("Text", this.myMachine, "Finanzierungsgesellschaft");
			this.txtWartungsintervall.DataBindings.Add("Text", this.myMachine, "Wartungsintervall");
			this.mtxtDateipfad.DataBindings.Add("Text", this.myMachine, "Dateipfad");
			this.mtxtSonderausstattung.DataBindings.Add("Text", myMachine, "Sonderausstattlung");

			this.cmbMachineModel.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			this.cmbMachineModel.DisplayMember = "Modellbezeichnung";
			this.cmbMachineModel.ValueMember = "UID";
			this.cmbMachineModel.DataBindings.Add("SelectedValue", this.myMachine, "MaschinenmodellId");

			this.cmbInkType.DataSource = ModelManager.SharedItemsService.TinteList.Sort("Tintenbezeichnung", System.ComponentModel.ListSortDirection.Ascending);
			this.cmbInkType.ValueMember = "UID";
			this.cmbInkType.DisplayMember = "Tintenbezeichnung";
			this.cmbInkType.DataBindings.Add("SelectedValue", this.myMachine, "TintenId");

			this.ndtpKaufdatum.Value = this.myMachine.Kaufdatum;
			this.ndtpAuftragsdatum.Value = this.myMachine.Auftragsdatum;
			this.ndtpFinanzierungsende.Value = this.myMachine.Finanzierungsende;

			this.chkLeasingFlag.DataBindings.Add("Checked", this.myMachine, "LeasingFlag");
			this.chkMietkaufFlag.DataBindings.Add("Checked", this.myMachine, "MietkaufFlag");
			this.chkErstverwertungsFlag.DataBindings.Add("Checked", this.myMachine, "ErstverwertungsFlag");

			dgvSoftware.AutoGenerateColumns = false;
			this.dgvSoftware.DataSource = ModelManager.SoftwareService.GetMachinesSoftware(this.myMachine);

			dgvNotizen.AutoGenerateColumns = false;
			dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(machineAsLink.Key, machineAsLink.LinkTypeId);

			this.dgvDateilinks.AutoGenerateColumns = false;
			this.dgvDateilinks.DataSource = ModelManager.FileLinkService.GetFileLinkList(this.myMachine.UID);
		}

		void AddNote()
		{
			var builder = new NoteBuilder(this.myMachine.CurrentOwner, this.myMachine);
			var note = ModelManager.NotesService.AddNote(builder);
			this.myParent.ShowNotiz(note);
		}

		void ShowNote()
		{
			if (this.mySelectedNotiz != null)
			{
				var nv = new NotizView(this.mySelectedNotiz, this.myMachine.CurrentOwner);
				nv.ShowDialog();
			}
		}

		void DeleteNote()
		{
			var msg = string.Empty;
			if (this.mySelectedNotiz != null && this.mySelectedNotiz.GetCanDelete())
			{
				msg = string.Format("Soll ich die Notiz '{0}' vom {1:d} endgültig löschen?", this.mySelectedNotiz.Subject, this.mySelectedNotiz.AssignedAt);
				if (MetroMessageBox.Show(this, msg, "Catalist - Kundenmaschine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.NotesService.DeleteNote(this.mySelectedNotiz);
				}
			}
			else
			{
				msg = string.Format("Die Notiz '{0}' vom {1:d} kann nicht gelöscht werden, weil sie noch mit mindestens einer Datei verknüpft ist", this.mySelectedNotiz.Subject, this.mySelectedNotiz.AssignedAt);
				MetroMessageBox.Show(this, msg, "Catalist Kundenmaschine", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		void AddSoftware()
		{
			var startPanel = this.myParent as KundeMainView;
			var sw = ModelManager.SoftwareService.AddKundenSoftware(startPanel.CurrentCustomer, this.myMachine);
			myParent.ShowSoftware(sw);
		}

		void ShowSoftware()
		{
			if (this.mySelectedSoftware != null)
			{
				this.myParent.ShowSoftware(mySelectedSoftware);
			}
		}

		void AddFileLink(string fileName, bool keepOriginal = true)
		{
			var fi = new FileInfo(fileName);
			ModelManager.FileLinkService.AddFileLink(fi, this.myMachine, keepOriginal);
		}

		void OpenFileLink()
		{
			if (this.mySelectedDateilink != null)
			{
				string fileToShow = this.mySelectedDateilink.FullName;
				if (File.Exists(fileToShow))
				{
					Process.Start(fileToShow);
				}
				else
				{
					MetroMessageBox.Show(this, "Die Datei ist auf dem Server offenbar gelöscht worden.", "Fehler beim Öffnen der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void SearchFiles()
		{
			if (string.IsNullOrEmpty(this.myMachine.Seriennummer))
			{
				var msg = "Um nach Dateien für diese Maschine zu suchen, gebrauche ich die Seriennummer.";
				MetroMessageBox.Show(this, msg, "Dateisuche", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			var fsv = new FileSearchView(this.myMachine, this.myMachine.Seriennummer);
			fsv.ShowDialog();
		}

		void CreateInstFiles()
		{
			// Technikordner anlegen, falls noch nicht geschehen.
			this.CreateDateipfad();
		}

		void CreateDateipfad()
		{
			if (string.IsNullOrEmpty(this.myMachine.Dateipfad) || !Directory.Exists(this.myMachine.Dateipfad))
			{
				// Dateipfad der Serie ermitteln z. B.: "\\NASE82002\technik\Service Maschinen\Mimaki\CJV\CJV30"
				var pfadSerie = this.myMachine.Maschinenserie.Dateipfad;

				// Ordner für die Maschine zusammenbauen. Schema: "Modell +_+ Seriennummer + (Kundenmatchcode)"
				var ordnerMaschine = string.Format("{0}_{1} ({2})", this.myMachine.Modellbezeichnung, this.myMachine.Seriennummer, this.myMachine.CurrentOwner.Matchcode.Replace("/", "_"));

				// Den Maschinenordner im Dateisystem erstellen
				var ordnerKomplett = Path.Combine(pfadSerie, ordnerMaschine);
				Directory.CreateDirectory(ordnerKomplett);
				this.myMachine.Dateipfad = ordnerKomplett;
				ModelManager.MachineService.UpdateMachines();
				this.mtxtDateipfad.Text = ordnerKomplett;
			}
		}

		#endregion private procedures

		#region Testing

		void cmnuTest_Click(object sender, EventArgs e)
		{
			var fsv = new FileSearchView(this.myMachine, this.myMachine.Seriennummer);
			fsv.Show();

			//var directories = new DirectoryInfo[]
			//{
			//	new DirectoryInfo(@"\\NASE82002\technik\Parameter\Mimaki"),
			//	new DirectoryInfo(@"\\NASE82002\technik\Service Maschinen\_Mimaki"),
			//	new DirectoryInfo(@"\\NASE82002\technik\Wartung")
			//};

			//var list = ModelManager.FileSystemService.SearchFiles(directories, "m337b036");
		}

		#endregion Testing

		void btnDeleteSoftware_Click(object sender, EventArgs e)
		{
			throw new ApplicationException("Is nochnich fettich");
		}
	}
}