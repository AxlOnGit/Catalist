using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Model;
using Products.Model.Builder;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class TourKundenView : MetroForm
	{
		#region MEMBERS

		Tour myTour;
		SBList<Kunde> myTourKunden;
		Kunde mySelectedKunde;
		Interessent mySelectedProspect;
		Notiz mySelectedNote;
		FileLink mySelectedDateilink;
		MetroGrid activeGrid;

		#endregion MEMBERS

		#region ### .CTOR ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TourKundenView Klasse.
		/// </summary>
		public TourKundenView(Tour tour, SBList<Kunde> tourKunden)
		{
			InitializeComponent();
			myTour = tour;
			this.myTourKunden = tourKunden;
			this.FormClosing += TourKundenView_FormClosing;
			this.xcmdDeleteNote.DropDownOpening += xcmdDeleteNote_DropDownOpening;

			this.InitializeData();
		}

		#endregion ### .CTOR ###

		#region EVENT HANDLER

		#region GRIDS

		void dgvTourKunden_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedKunde = dgvTourKunden.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kunde;
			this.LoadNotes();
			this.activeGrid = this.dgvTourKunden;
			this.Text = string.Format(@"Tour {0} - {1} (Kunde)", this.myTour.Tourname, this.mySelectedKunde.CompanyName1.Replace("&", "&&"));
			this.Invalidate();
		}

		void dgvTourKunden_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			OpenCustomer();
		}

		void dgvInteressenten_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenProspect();
		}

		void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedNote = this.dgvNotizen.Rows[e.RowIndex].DataBoundItem as Notiz;
			if (mySelectedNote != null)
			{
				this.mtxtNotiztext.Text = mySelectedNote.Body;
				var fileLinks = ModelManager.FileLinkService.GetFileLinkList(this.mySelectedNote.UID);
				if (fileLinks != null)
				{
					this.dgvDateilinks.DataSource = fileLinks.Sort("FullName");
				}
				else this.dgvDateilinks.DataSource = null;
			}
		}

		void dgvInteressenten_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedProspect = dgvInteressenten.Rows[e.RowIndex].DataBoundItem as Model.Entities.Interessent;
			this.activeGrid = this.dgvInteressenten;
			this.LoadNotes();
			this.Text = string.Format(@"Tour {0} - {1} (Interessent)", this.myTour.Tourname, this.mySelectedProspect.Firmenname.Replace("&", "&&"));
			this.Invalidate();
		}

		void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenNote();
		}

		void dgvDateilinks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenFileLink();
		}

		void dgvDateilinks_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedDateilink = this.dgvDateilinks.Rows[e.RowIndex].DataBoundItem as Model.Entities.FileLink;
		}

		#endregion GRIDS

		#region BUTTONS

		void btnAddCustomer_Click(object sender, EventArgs e)
		{
			this.AddCustomer();
		}

		void btnOpenCustomer_Click(object sender, EventArgs e)
		{
			this.OpenCustomer();
		}

		void btnOpenTourKundenDetails_Click(object sender, EventArgs e)
		{
			var tdv = new TourkundenDetailView(this.myTour);
			tdv.Show();
		}

		void btnAddBesuchsterminK_Click(object sender, EventArgs e)
		{
			if (this.mySelectedKunde != null)
			{
				this.AddAppointment(this.mySelectedKunde);
			}
		}

		void btnAddInteressent_Click(object sender, EventArgs e)
		{
			this.AddProspect();
		}

		void btnOpenInteressent_Click(object sender, EventArgs e)
		{
			OpenProspect();
		}

		void btnAddBesuchsterminI_Click(object sender, EventArgs e)
		{
			if (this.mySelectedProspect != null)
			{
				this.AddAppointment(this.mySelectedProspect);
			}
		}

		void btnAddNotiz_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void btnOpenNotiz_Click(object sender, EventArgs e)
		{
			this.OpenNote();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void btnAddFileLink_Click(object sender, System.EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.AutoUpgradeEnabled = true;
			ofd.DefaultExt = "csv";
			ofd.Filter = "Alle Dateien (*.*)|*.*";
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ofd.Multiselect = false;
			ofd.Title = "Welche Datei soll mit dieser Notiz verknüpft werden?";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				var msg = string.Format("Gut, ich verknüpfe Datei\n{0}\nund kopiere sie auf den Server.\n\nSoll die Originaldatei anschließend gelöscht werden?", ofd.FileName);
				switch (MetroMessageBox.Show(this, msg, "Dateiverknüpfungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
				{
					case DialogResult.No:
					this.AddFileLink(ofd.FileName, true);
					break;

					case DialogResult.Yes:
					this.AddFileLink(ofd.FileName, false);
					break;
				}
			}
		}

		void btnRemoveLink_Click(object sender, EventArgs e)
		{
			if (this.mySelectedDateilink != null)
			{
				string msg = "Soll auch die gespeicherte Datei auf dem Server gelöscht werden?";
				//string linkUID = this.mySelectedDateilink.LinkedItemId;
				var file = new FileInfo(this.mySelectedDateilink.FullName);
				string fileAndPath = this.mySelectedDateilink.FullName;
				ILinkedItem linkedItem = this.mySelectedNote;
				if (MetroMessageBox.Show(this, msg, "Datei löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.FileLinkService.DeleteFileLink(file, linkedItem, true);
				}
				else
				{
					ModelManager.FileLinkService.DeleteFileLink(file, linkedItem, false);
				}
				this.mySelectedDateilink = null;
			}
		}

		void btnOpenFileLink_Click(object sender, EventArgs e)
		{
			this.OpenFileLink();
		}

		void mlblFontSize_Click(object sender, EventArgs e)
		{
			if (this.mtxtNotiztext.FontSize == MetroTextBoxSize.Tall)
			{
				this.mtxtNotiztext.FontSize = MetroTextBoxSize.Small;
				return;
			}
			this.mtxtNotiztext.FontSize += 1;
		}

		#endregion BUTTONS

		#region CONTEXT MENU

		void xcmdMakeCall_Click(object sender, EventArgs e)
		{
			if (mySelectedKunde == null) return;
			if (!string.IsNullOrEmpty(mySelectedKunde.Telefon))
			{
				Agfeo.FonManager.FonService.MakeCall(mySelectedKunde.Telefon);
			}
		}

		void xcmdSendEmail_Click(object sender, EventArgs e)
		{
			if (this.mySelectedKunde == null) return;
			this.mySelectedKunde.MailToMainContact();
		}

		void xcmdRemoveFromTour_Click(object sender, EventArgs e)
		{
			this.RemoveCustomerFromTour();
		}

		void xcmdMoveToTour_Click(object sender, EventArgs e)
		{
			if (this.mySelectedKunde == null) return;
			Model.Entities.Kunde kunde = this.mySelectedKunde;

			// Neue Tour abfragen
			Model.Entities.Tour tour = null;
			var tlv = new TourListenView(ModelManager.SalesForceService.GetTourList(), true);
			if (tlv.ShowDialog(this) == DialogResult.OK && tlv.SelectedTour != null)
			{
				tour = tlv.SelectedTour;
			}
			// Aus dieser Tour löschen
			this.RemoveCustomerFromTour();

			// Neuer Tour zuordnen
			tour.AddKunde(kunde);
			var msg = string.Format("Ich habe {0} in die Tour {1} verschoben.", kunde.CompanyName1, tour.Tourname);
			MetroMessageBox.Show(this, msg, "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void xcmdAddCustomer_Click(object sender, EventArgs e)
		{
			this.AddCustomer();
		}

		void xcmdDeleteNote_DropDownOpening(object sender, EventArgs e)
		{
			this.xcmdDeleteNote.Enabled = (this.mySelectedNote != null && this.mySelectedNote.GetCanDelete());
		}

		void xcmdAddNote_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void xcmdOpenNote_Click(object sender, EventArgs e)
		{
			this.OpenNote();
		}

		void xcmdShowAppointmentList_Click(object sender, EventArgs e)
		{
			if (this.mySelectedKunde == null) return;
			var aList = ModelManager.AppointmentService.GetAppointmentList(this.mySelectedKunde);
			var alv = new AppointmentListView(aList, this.mySelectedKunde.CompanyName1);
			alv.Show();
		}

		void xcmdShowInactive_Click(object sender, EventArgs e)
		{
			this.xcmdShowInactive.Checked = !this.xcmdShowInactive.Checked;
			this.mtoggleShowInactive.Checked = !this.mtoggleShowInactive.Checked;
		}

		void xcmdDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void xcmdOpenCustomer_Click(object sender, EventArgs e)
		{
			this.OpenCustomer();
		}

		#endregion CONTEXT MENU

		#region DRAG'N DROP

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
						this.AddFileLink(filename, true);
						// Kleinet Päusken, damit der Butzemann in Ruhe kopieren kann. 1 Sekunde
						// sollte reichen ...
						System.Threading.Thread.Sleep(750);
					}
				}
				else
				{
					foreach (string filename in filenames)
					{
						this.AddFileLink(filename, false);
						System.Threading.Thread.Sleep(750);
					}
				}
			}
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

		#endregion DRAG'N DROP

		#region FORM

		void TourKundenView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.NotesService.UpdateNotes();
		}

		#endregion FORM

		void mtoggleShowInactive_CheckedChanged(object sender, EventArgs e)
		{
			if (this.mtoggleShowInactive.Checked)
			{
				if (this.activeGrid == this.dgvTourKunden && this.mySelectedKunde != null)
				{
					var kundeAsLink = this.mySelectedKunde as ILinkedItem;
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(kundeAsLink.Key, kundeAsLink.LinkTypeId);
				}
				else if (this.activeGrid == this.dgvInteressenten && this.mySelectedProspect != null)
				{
					var prospectAsLink = this.mySelectedProspect as ILinkedItem;
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(prospectAsLink.Key, prospectAsLink.LinkTypeId);
				}
			}
			else
			{
				if (this.activeGrid == this.dgvTourKunden)
				{
					var kundeAsLink = this.mySelectedKunde as ILinkedItem;
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(kundeAsLink.Key, kundeAsLink.LinkTypeId);
				}
				else if (this.activeGrid == this.dgvInteressenten)
				{
					var prospectAsLink = this.mySelectedProspect as ILinkedItem;
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(prospectAsLink.Key, prospectAsLink.LinkTypeId);
				}
			}
		}

		#endregion EVENT HANDLER

		#region PRIVATE

		void InitializeData()
		{
			this.dgvTourKunden.AutoGenerateColumns = false;
			this.dgvInteressenten.AutoGenerateColumns = false;
			this.dgvNotizen.AutoGenerateColumns = false;
			this.dgvDateilinks.AutoGenerateColumns = false;

			this.dgvTourKunden.DataSource = myTour.Tourkunden.Sort("CompanyName1");
			this.dgvInteressenten.DataSource = myTour.TourInteressenten.Sort("Firmenname");
			this.dgvDateilinks.DataSource = this.mySelectedNote != null ? this.mySelectedNote.Dateilinks : null;
		}

		void OpenCustomer()
		{
			if (this.mySelectedKunde != null)
			{
				var cdv = new CustomerDetailView(this.mySelectedKunde);
				cdv.ShowDialog();
			}
		}

		void OpenCustomerPanel()
		{
			if (this.mySelectedKunde != null)
			{
				var kmv = new KundeMainView(mySelectedKunde);
				kmv.Show();
			}
		}

		void AddCustomer()
		{
			var csv = new CustomerSearchView("Kunden für eine Tour suchen", false);
			if (csv.ShowDialog() == DialogResult.OK)
			{
				var kRow = csv.SelectedCustomer;
				if (kRow != null)
				{
					var kunde = new Kunde(kRow);
					myTour.AddKunde(kunde);
				}
			}
		}

		void OpenProspect()
		{
			if (this.mySelectedProspect != null)
			{
				var iv = new InteressentView(mySelectedProspect);
				iv.Show();
			}
		}

		void AddProspect()
		{
			var prospect = ModelManager.ProspectService.AddInteressent();
			myTour.AddInteressent(prospect);
			mySelectedProspect = prospect;
			OpenProspect();
		}

		void LoadNotes()
		{
			this.mtxtNotiztext.Text = string.Empty;

			if (this.activeGrid == this.dgvTourKunden && this.mySelectedKunde != null)
			{
				if (this.mySelectedKunde != null)
				{
					var kundeAsLink = this.mySelectedKunde as ILinkedItem;
					this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(kundeAsLink.Key, kundeAsLink.LinkTypeId);
				}
			}

			if (this.activeGrid == this.dgvInteressenten && this.mySelectedProspect != null)
			{
				var prospectAsLink = this.mySelectedProspect as ILinkedItem;
				this.dgvNotizen.DataSource = ModelManager.NotesService.GetNotesList(prospectAsLink.Key, prospectAsLink.LinkTypeId);
			}
		}

		void AddNote()
		{
			NoteBuilder builder = null;
			if (this.activeGrid == this.dgvTourKunden && this.mySelectedKunde != null)
			{
				if (this.mySelectedKunde != null)
				{
					builder = new NoteBuilder(this.mySelectedKunde, this.mySelectedKunde, this.mySelectedKunde.Kontaktlist.FirstOrDefault(k => k.MainContactFlag == true).Nummer);
					var note = ModelManager.NotesService.AddNote(builder);
					var nv = new NotizView(note, mySelectedKunde);
					nv.ShowDialog(this);
				}
			}
			else if (this.activeGrid == this.dgvInteressenten && this.mySelectedProspect != null)
			{
				builder = new NoteBuilder(this.mySelectedProspect, this.mySelectedProspect);
				var note = ModelManager.NotesService.AddNote(builder);
				var nv = new NotizView(note, this.mySelectedProspect);
				nv.ShowDialog(this);
			}
		}

		void OpenNote()
		{
			if (this.mySelectedNote != null)
			{
				ILinkedItem linkedItem = null;
				if (this.activeGrid == this.dgvTourKunden && this.mySelectedKunde != null)
				{
					linkedItem = this.mySelectedKunde;
				}
				else if (this.activeGrid == this.dgvInteressenten && this.mySelectedProspect != null)
				{
					linkedItem = this.mySelectedProspect;
				}
				var nv = new NotizView(mySelectedNote, linkedItem);
				nv.ShowDialog();
			}
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
					MetroMessageBox.Show(this, "Tja, sieht aus, als hätte irgendein Honk die Datei gelöscht.", "Öffnen tut nich", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void AddFileLink(string fileName, bool keepSourceFile = true)
		{
			if (this.mySelectedNote == null) return;
			var noteAsLink = this.mySelectedNote as ILinkedItem;
			this.mySelectedDateilink = ModelManager.FileLinkService.AddFileLink(new FileInfo(fileName), noteAsLink, keepSourceFile);
		}

		void AddAppointment(object customerOrProspect)
		{
			User currentUser = ModelManager.UserService.CurrentUser;
			// Den markierten Kunden zur LinkedItems-Liste der Kalendereinstellungen hinzufügen.
			currentUser.CalendarSettings.AddLinkedItem(customerOrProspect as ILinkedItem);
			Products.Common.Program.ShowCalendar();
		}

		void RemoveCustomerFromTour()
		{
			var msg = string.Format("{0} wirklich aus dieser Tour entfernen?", this.mySelectedKunde.CompanyName1);
			if (MetroMessageBox.Show(this, msg, "Catalist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					this.myTour.Remove(this.mySelectedKunde);
				}
				catch (Exception)
				{
					MetroMessageBox.Show(this, "Der Kunde konnte nicht entfernt werden", "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void ToggleShowInactive()
		{
			this.mtoggleShowInactive_CheckedChanged(this.mtoggleShowInactive, new EventArgs());
		}

		void DeleteNote()
		{
			if (this.activeGrid == this.dgvInteressenten && this.mySelectedKunde != null)
			{
				ModelManager.NotesService.DeleteNote(this.mySelectedNote);
			}
			else if (this.activeGrid == this.dgvTourKunden && this.mySelectedProspect != null)
			{
				ModelManager.NotesService.DeleteNote(this.mySelectedNote);
			}
		}

		#endregion PRIVATE
	}
}