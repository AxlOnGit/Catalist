using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Model;
using Products.Model.Builder;
using Products.Common.Interfaces;
using System.Diagnostics;
using System.IO;

namespace Products.Common.Views
{
	public partial class BestellungListView : MetroForm
	{

		#region members

		readonly Lieferant myLieferant;
		Bestellung mySelectedBestellung;
		Bestellung mySelectedLieferung;
		Bestellung mySelectedRechnung;
		Notiz mySelectedNote;
		FileLink mySelectedFileLink;

		#endregion

		#region private properties

		private string Filter { get; set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der BestellungListView();
		/// </summary>
		public BestellungListView(Lieferant lieferant)
		{
			InitializeComponent();
			this.myLieferant = lieferant;
			this.InitializeData();

			Application.Idle += this.Application_Idle;
		}

		#endregion

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			this.btnOpenNote.Enabled = this.mySelectedNote != null;
			this.btnDeleteNote.Enabled = (this.mySelectedNote != null && this.mySelectedNote.GetCanDelete());
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			this.Filter = this.mtxtFilter.Text.Trim();
			if (e.KeyCode == Keys.Enter)
			{
				this.ResetGrids();
				if (string.IsNullOrEmpty(this.Filter))
				{
					this.dgvBestellungen.DataSource = ModelManager.SupplierService.GetBestellungList(this.myLieferant.Lieferantennummer);
				}
				else
				{
					this.dgvBestellungen.DataSource = ModelManager.SupplierService.GetBestellungListFiltered(this.myLieferant.Lieferantennummer, this.Filter);
				}
			}
		}

		void mtxtFilter_ClearClicked()
		{
			this.Filter = "";
			this.dgvBestellungen.DataSource = ModelManager.SupplierService.GetBestellungList(this.myLieferant.Lieferantennummer);
		}

		void dgvBestellungen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedBestellung = this.dgvBestellungen.Rows[e.RowIndex].DataBoundItem as Bestellung;
			if (this.mySelectedBestellung != null)
			{
				this.ResetGrids();
				this.dgvLieferungen.DataSource = ModelManager.SupplierService.GetLieferungList(this.mySelectedBestellung);
				this.dgvRechnungen.DataSource = ModelManager.SupplierService.GetRechnungList(this.mySelectedBestellung);
				this.dgvDetails.DataSource = ModelManager.SupplierService.GetBestellDetailList(this.mySelectedBestellung);
				this.dgvNotes.DataSource = ModelManager.NotesService.GetNotesList(this.mySelectedBestellung.Nummer, "Bestellung");
			}
		}

		void ResetGrids()
		{
			this.mySelectedLieferung = null;
			this.dgvLieferungen.DataSource = null;
			this.mySelectedRechnung = null;
			this.dgvRechnungen.DataSource = null;
			this.dgvDetails.DataSource = null;
			this.mySelectedNote = null;
			this.mySelectedNote = null;
			this.dgvNotes.DataSource = null;
			this.mySelectedFileLink = null;
			this.dgvFileLinks.DataSource = null;
		}

		void dgvLieferungen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedLieferung = this.dgvLieferungen.Rows[e.RowIndex].DataBoundItem as Bestellung;
			if (this.mySelectedLieferung != null)
			{
				this.dgvDetails.DataSource = ModelManager.SupplierService.GetLieferDetailList(this.mySelectedLieferung);
			}
			else this.dgvDetails.DataSource = null;
		}

		void dgvRechnungen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedRechnung = this.dgvRechnungen.Rows[e.RowIndex].DataBoundItem as Bestellung;
			if (this.mySelectedRechnung != null)
			{
				this.dgvDetails.DataSource = ModelManager.SupplierService.GetRechnungDetailList(this.mySelectedRechnung);
			}
			else this.dgvDetails.DataSource = null;
		}

		void dgvNotes_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedNote = this.dgvNotes.Rows[e.RowIndex].DataBoundItem as Notiz;
			this.dgvFileLinks.DataSource = this.mySelectedNote.Dateilinks;
		}

		void dgvFileLinks_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedFileLink = this.dgvFileLinks.Rows[e.RowIndex].DataBoundItem as FileLink;
		}

		void dgvFileLinks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowFileLink();
		}

		void btnAddNotiz_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void xcmdAddNote_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void btnShowNotiz_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void xcmdShowNote_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void dgvNotes_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowNote();
		}

		void btnDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void xcmdDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void xmnuNotes_Opening(object sender, CancelEventArgs e)
		{
			this.xcmdDeleteNote.Enabled = (this.mySelectedNote != null && this.mySelectedNote.GetCanDelete());
			this.xcmdShowNote.Enabled = this.mySelectedNote != null;
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("Bestellungen - {0}", this.myLieferant.Name1);
			this.dgvBestellungen.AutoGenerateColumns = false;
			this.dgvLieferungen.AutoGenerateColumns = false;
			this.dgvRechnungen.AutoGenerateColumns = false;
			this.dgvDetails.AutoGenerateColumns = false;
			this.dgvNotes.AutoGenerateColumns = false;
			this.dgvFileLinks.AutoGenerateColumns = false;

			this.dgvBestellungen.DataSource = this.myLieferant.GetBestellungList();
		}

		void AddNote()
		{
			var currentUser = ModelManager.UserService.CurrentUser as ILinkedItem;
			var builder = new NoteBuilder(currentUser, this.mySelectedBestellung as ILinkedItem);
			var newNote = ModelManager.NotesService.AddNote(builder);
			var nv = new Views.NotizView(newNote, this.mySelectedBestellung);
			nv.Show();
		}

		void ShowNote()
		{
			if (this.mySelectedNote != null && this.mySelectedBestellung != null)
			{
				var nv = new NotizView(this.mySelectedNote, this.mySelectedBestellung);
				nv.Show();
			}
		}

		void DeleteNote()
		{
			if (this.mySelectedNote != null && this.mySelectedNote.GetCanDelete())
			{
				ModelManager.NotesService.DeleteNote(this.mySelectedNote);
			}
		}

		void ShowFileLink()
		{
			if (this.mySelectedFileLink != null)
			{
				string fileToShow = this.mySelectedFileLink.FullName;
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

		#region DRAG'N DROP

		void dgvFileLinks_DragOver(object sender, DragEventArgs e)
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

		void dgvFileLinks_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
			{
				var filenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];
				if ((e.KeyState & 4) == 4) // 4 = Shift-Taste: Verschieben
				{
					foreach (var filename in filenames)
					{
						this.AddFileLink(filename, false);
						System.Threading.Thread.Sleep(750);
					}
				}
				else
				{
					foreach (var filename in filenames)
					{
						this.AddFileLink(filename, true);	// Ohne Shift-Taste: Kopieren
						System.Threading.Thread.Sleep(750);
					}
				}
			}
		}

		void AddFileLink(string fileName, bool keepSourceFile = true)
		{
			var fi = new FileInfo(fileName);
			ModelManager.FileLinkService.AddFileLink(fi, this.mySelectedNote, Global.LinkedFilesPath, keepSourceFile);
		}

		#endregion

	}
}
