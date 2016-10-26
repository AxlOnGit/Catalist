using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Model;
using Products.Model.Builder;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlNotizen : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		Notiz mySelectedNotiz;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlNotizen Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		public pnlNotizen(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as Views.KundeMainView;
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void btnAddNote_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void xcmdAddNote_Click(object sender, EventArgs e)
		{
			this.AddNote();
		}

		void btnShowNote_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void xcmdShowNote_Click(object sender, EventArgs e)
		{
			this.ShowNote();
		}

		void btnDeleteNotiz_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void xcmdDeleteNote_Click(object sender, EventArgs e)
		{
			this.DeleteNote();
		}

		void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedNotiz = this.dgvNotizen.Rows[e.RowIndex].DataBoundItem as Notiz;
			if (mySelectedNotiz != null)
			{
				this.mtxtNotiztext.Text = mySelectedNotiz.Body;
			}
		}

		void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowNote();
		}

		void mlnkFontSize_Click(object sender, EventArgs e)
		{
			if (this.mtxtNotiztext.FontSize == MetroTextBoxSize.Tall) this.mtxtNotiztext.FontSize = MetroTextBoxSize.Small;
			this.mtxtNotiztext.FontSize += 1;
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.dgvNotizen.AutoGenerateColumns = false;
			this.dgvNotizen.DataSource = myKunde.Notizlist.Sort("AssignedAt", ListSortDirection.Descending);
		}

		void AddNote()
		{
			var builder = new NoteBuilder(this.myKunde, this.myKunde, this.myKunde.Kontaktlist.FirstOrDefault(k => k.MainContactFlag == true).Nummer);
			var note = ModelManager.NotesService.AddNote(builder);
			var nv = new NotizView(note, myKunde);
			nv.Show();
		}

		void ShowNote()
		{
			if (this.mySelectedNotiz != null)
			{
				var nv = new NotizView(mySelectedNotiz, this.myKunde);
				nv.Show();
			}
		}

		void DeleteNote()
		{
			var msg = string.Empty;
			if (this.mySelectedNotiz != null && this.mySelectedNotiz.GetCanDelete())
			{
				msg = string.Format("Soll ich die Notiz '{0}' vom {1:d} endgültig löschen?", this.mySelectedNotiz.Subject, this.mySelectedNotiz.AssignedAt);
				if (MetroMessageBox.Show(this, msg, "Catalist - Notizen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.NotesService.DeleteNote(this.mySelectedNotiz);
				}
			}
			else
			{
				msg = string.Format("Die Notiz '{0}' vom {1:d} kann nicht gelöscht werden, weil sie noch mit mindestens einer Datei verknüpft ist", this.mySelectedNotiz.Subject, this.mySelectedNotiz.AssignedAt);
				MetroMessageBox.Show(this, msg, "Catalist Notizen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		#endregion private procedures
	}
}