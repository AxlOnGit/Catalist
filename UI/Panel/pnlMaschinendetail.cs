﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using Products.Model;
using System.IO;
using Products.Model.Builder;
using Products.Model.Entities;
using Products.Common.Interfaces;
using Products.Common.Views;
using System.Threading;

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

		#endregion

		#region public properties

		/// <summary>
		/// Gibt die im Panel geladene Maschine zurück.
		/// </summary>
		public Kundenmaschine Maschine { get { return this.myMachine; } }

		#endregion

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

			this.InitializeData();
		}

		#endregion

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
				var msg = string.Format("Ok, ich verknüpfe Datei\n{0}\nund kopiere sie auf den Server.\n\nSoll die Originaldatei anschließend gelöscht werden?", ofd.FileName);
				switch (MessageBox.Show(msg, "Dateiverknüpfungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
				{
					case DialogResult.No:
						AddFileLink(ofd.FileName);
						break;

					case DialogResult.Yes:
						AddFileLink(ofd.FileName, true);
						break;
				}
			}
			myMachine.Update();
			//this.dgvDateilinks.DataSource =  this.myMachine.FileLinkList;
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
				MessageBox.Show("Das hat nicht geklappt", "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void dgvDateilinks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenFileLink();
		}

		void btnDeleteDateilink_Click(object sender, EventArgs e)
		{
			if (this.mySelectedDateilink != null)
			{
				var msg = "Soll auch die gespeicherte Datei auf dem Server gelöscht werden?";
				var fileAndPath = this.mySelectedDateilink.FullName;
				if (MessageBox.Show(msg, "Datei löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

		void ClearDatabindings()
		{
			this.txtColorSet.DataBindings.Clear();
			this.txtFirmware.DataBindings.Clear();
			this.txtGekauftBei.DataBindings.Clear();
			this.txtSerialNumber.DataBindings.Clear();
			this.txtAuftragInSage.DataBindings.Clear();
			this.txtFinanzierungsgesellschaft.Clear();
			this.txtWartungsintervall.DataBindings.Clear();
			this.cmbMachineModel.DataBindings.Clear();
			this.cmbInkType.DataBindings.Clear();
		}

		#region Drag and Drop

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
						// Kleinet Päusken, damit der Butzemann in Ruhe kopieren kann. 500 ms sollten reichen ...
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

		#endregion

		void pnlMaschinendetail_OnClosed(object sender, EventArgs e)
		{
			if (this.myMachine == null) return;
			ModelManager.MachineService.UpdateMachines(this.myMachine.Kundennummer);
			ModelManager.FileLinkService.Update();
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			var machineAsLink = this.myMachine as ILinkedItem;

			//this.Text = string.Format(@"Kundenmaschine von {0}, {1} [{2}]", myMachine.Kunde.CompanyName1, myMachine.Kunde.City, myMachine.Kunde.CustomerId.Substring(0, 5));
			this.mlblTitel.Text = string.Format("{0} [SN: {1}]", this.myMachine.Maschinenmodell, string.IsNullOrEmpty(this.myMachine.Seriennummer) ? "?" : this.myMachine.Seriennummer);

			this.txtColorSet.DataBindings.Add("Text", this.myMachine, "Farbset");
			this.txtFirmware.DataBindings.Add("Text", this.myMachine, "Firmware");
			this.txtGekauftBei.DataBindings.Add("Text", this.myMachine, "GekauftBei");
			this.txtSerialNumber.DataBindings.Add("Text", this.myMachine, "Seriennummer");
			this.txtAuftragInSage.DataBindings.Add("Text", this.myMachine, "AuftragsnummerSage");
			this.txtFinanzierungsgesellschaft.DataBindings.Add("Text", this.myMachine, "Finanzierungsgesellschaft");
			this.txtWartungsintervall.DataBindings.Add("Text", this.myMachine, "Wartungsintervall");

			this.cmbMachineModel.DataSource = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			this.cmbMachineModel.DisplayMember = "Modellbezeichnung";
			this.cmbMachineModel.ValueMember = "UID";
			this.cmbMachineModel.DataBindings.Add("SelectedValue", this.myMachine, "MaschinenmodellId");

			this.cmbInkType.DataSource = ModelManager.SharedItemsService.TinteList.Sort("Tintenbezeichnung", System.ComponentModel.ListSortDirection.Ascending);
			this.cmbInkType.ValueMember = "UID";
			this.cmbInkType.DisplayMember = "Tintenbezeichnung";
			this.cmbInkType.DataBindings.Add("SelectedValue", this.myMachine, "TintenId");

			this.ndtpKaufdatum.Value = this.myMachine.Kaufdatum;
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
				if (MessageBox.Show(msg, "Catalist - Kundenmaschine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.NotesService.DeleteNote(this.mySelectedNotiz);
				}
			}
			else
			{
				msg = string.Format("Die Notiz '{0}' vom {1:d} kann nicht gelöscht werden, weil sie noch mit mindestens einer Datei verknüpft ist", this.mySelectedNotiz.Subject, this.mySelectedNotiz.AssignedAt);
				MessageBox.Show(msg, "Catalist Kundenmaschine", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
			ModelManager.FileLinkService.AddFileLink(fi, this.myMachine, Global.LinkedFilesPath, keepOriginal);
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
					MessageBox.Show("Die Datei ist auf dem Server offenbar gelöscht worden.", "Fehler beim Öffnen der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		#endregion

	}
}
