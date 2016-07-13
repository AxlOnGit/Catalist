﻿using System.Windows.Forms;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using Products.Model;
using Products.Model.Entities;
using System.IO;
using Products.Common.Interfaces;

namespace Products.Common.Views
{
	public partial class NotizView : MetroForm
	{

		#region members
	
		readonly Notiz myNotiz;
		readonly ILinkedItem myLinkedElement;
		FileLink mySelectedDateilink;
		string myLinkedElementText = string.Empty;
	
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der NotizView Klasse.
		/// </summary>
		public NotizView(Notiz notiz, ILinkedItem linkedElement)
		{
			InitializeComponent();
			this.myNotiz = notiz;
			this.myLinkedElement = linkedElement;
			this.InitializeData();
		}

		#endregion

		#region event handler

		//void lnkLinkedElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//{
		//  switch (myNotiz.LinktypId)
		//  {
		//    // Angebot (Sage)
		//    case "bd12ef61-e7ec-43ec-b95b-340c4198d9e7":
		//      break;

		//    // Auftrag (Sage)
		//    case "4e04d108-66a6-4582-b45a-e58dfc2a7291":
		//      break;

		//    // Bestellung (Sage)
		//    case "614634ec-d9ac-491f-98fd-84eebe920001":
		//      break;

		//    // Direktrechnung (Sage)
		//    case "4fac2e49-ff7a-48d2-947e-695a591c088a":
		//      break;

		//    // E-Mail Ausgang
		//    case "eda125c8-01b9-4c90-833e-c87eea029ac9":
		//      break;

		//    // E-Mail Eingang
		//    case "86234120-f630-4815-aaf8-1e7298187acd":
		//      break;

		//    // Fernwartung
		//    case "25719992-3745-4a2b-b506-353dce497c25":
		//      break;

		//    // Hardwareangebot
		//    case "a062e888-ff1a-48ce-b5a7-031c8efef6b1":
		//      break;

		//    // Hardwarebestellung
		//    case "ef118133-3c53-4c5f-a7bb-e2bf65053df6":
		//      break;

		//    // Lieferung (Sage)
		//    case "ab489203-12f4-42bd-b36f-cad88c7697ba":
		//      break;

		//    // Maschine
		//    case "302bfd79-1d44-4643-83a5-d2c6871903c4":
		//      break;

		//    // Maschinenreparatur
		//    case "af7fa02a-f4d3-4819-abd5-0049ffe8e9d6":
		//      break;

		//    // Maschinenwartung
		//    case "8d5f37f7-cf3d-4b75-b5b9-6b1c5a3ca3eb":
		//      break;

		//    // Rechnung
		//    case "f41ef0fc-de9b-45bc-9691-97612f73ff99":
		//      break;

		//    // Telefonat
		//    case "6d6e5162-3127-4388-9b1b-db50e2d7cf30":
		//      break;

		//    // Kunde
		//    default:
		//      break;

		//  }
		//}

		void mbtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		void NotizView_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateMe();
		}

		void btnDelegiereMich_Click(object sender, System.EventArgs e)
		{
			this.DelegiereMich();
		}

		void lnkDelegation_Click(object sender, System.EventArgs e)
		{
			this.DelegiereMich();
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
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string msg = string.Format("Gut, ich verknüpfe Datei\n{0}\nund kopiere sie auf den Server.\n\nSoll die Originaldatei anschließend gelöscht werden?", ofd.FileName);
				switch (MessageBox.Show(msg, "Dateiverknüpfungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
				{
					case DialogResult.No:
						ModelManager.FileLinkService.AddFileLink(new FileInfo(ofd.FileName), this.myNotiz, Global.LinkedFilesPath, true);
						break;

					case DialogResult.Yes:
						ModelManager.FileLinkService.AddFileLink(new FileInfo(ofd.FileName), this.myNotiz, Global.LinkedFilesPath, false);
						break;
				}
			}
		}

		void btnRemoveLink_Click(object sender, EventArgs e)
		{
			if (this.mySelectedDateilink != null && this.mySelectedDateilink.GetCanDelete())
			{
				var fi = new FileInfo(this.mySelectedDateilink.FullName);

				if (this.mySelectedDateilink.GetCanDelete())
				{
					string msg = "Soll ich die Datei auf dem Server auch löschen?";
					if (MessageBox.Show(msg, "Dateiverknüpfung löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
					{
						ModelManager.FileLinkService.DeleteFileLink(fi, this.myNotiz, true);
					}
				}
				else
				{
					ModelManager.FileLinkService.DeleteFileLink(fi, this.myNotiz, false);
				}
			}
		}

		void btnOpenFileLink_Click(object sender, EventArgs e)
		{
			this.OpenDateilink();
		}

		void dgvDateilinks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenDateilink();
		}

		void dgvDateilinks_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedDateilink = this.dgvDateilinks.Rows[e.RowIndex].DataBoundItem as Model.Entities.FileLink;
			this.mtoolTip.SetToolTip(this.dgvDateilinks, this.mySelectedDateilink.FileTitle);

		}

		void mlblFontSize_Click(object sender, EventArgs e)
		{
			if (this.txtNotiztext.FontSize == MetroFramework.MetroTextBoxSize.Tall)
			{
				this.txtNotiztext.FontSize = MetroFramework.MetroTextBoxSize.Small;
				return;
			}
			this.txtNotiztext.FontSize += 1;
		}

		void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = this.myNotiz.Subject;

			string dateString = myNotiz.AssignedAt.ToShortDateString();
			string timeString = myNotiz.AssignedAt.ToShortTimeString();
			this.lblErfassung.DataBindings.Add("Text", this.myNotiz, "MetaData", true, DataSourceUpdateMode.OnValidation);
			this.mdtpCreatedAt.DataBindings.Add("Value", this.myNotiz, "AssignedAt", true, DataSourceUpdateMode.OnValidation);

			var kunde = this.myLinkedElement as Kunde;
			if (kunde != null)
			{
				this.mcmbKontakt.DataSource = ModelManager.ContactService.GetContactListForCustomer(kunde.CustomerId);
				this.mcmbKontakt.ValueMember = "Nummer";
				this.mcmbKontakt.DisplayMember = "Kontaktname";
				this.mcmbKontakt.DataBindings.Add("SelectedValue", myNotiz, "ContactNumber");
			}
			else this.mcmbKontakt.Enabled = false;

			this.mtxtThema.DataBindings.Add("Text", myNotiz, "Subject", true, DataSourceUpdateMode.OnValidation);
			this.txtNotiztext.DataBindings.Add("Text", myNotiz, "Body", true, DataSourceUpdateMode.OnValidation);

			this.dgvDateilinks.AutoGenerateColumns = false;
			this.dgvDateilinks.DataSource = myNotiz.Dateilinks;
		}

		void OpenDateilink()
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
					MessageBox.Show("Tja, so wie's aussieht, hat irgendein Honk die Datei gelöscht.", "Öffnen tut nich", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void DelegiereMich()
		{
			//NEXT: Notiz delegieren ...
		}

		void AddFileLink(string fileName, bool keepSourceFile = true)
		{
			ModelManager.FileLinkService.AddFileLink(new FileInfo(fileName), this.myNotiz, Global.LinkedFilesPath, keepSourceFile);
		}

		void UpdateMe()
		{
			ModelManager.NotesService.UpdateNotes();
			ModelManager.FileLinkService.Update();
		}
	
		#endregion

	}
}
