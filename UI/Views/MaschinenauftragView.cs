using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class MaschinenauftragView : MetroForm
	{

		#region MEMBERS

		readonly Maschinenauftrag myMaschinenauftrag;
		readonly string nl = Environment.NewLine;

		#endregion MEMBERS

		#region ### .ctor ###

		public MaschinenauftragView(Maschinenauftrag maschinenAuftrag)
		{
			InitializeComponent();
			this.myMaschinenauftrag = maschinenAuftrag;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void mlnkMaschinenbestellungDurchId_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			usv.ShowDialog(this);
			if (usv.DialogResult == DialogResult.OK && usv.SelectedUser != null)
			{
				this.mlnkMaschinenbestellungDurchId.Text = usv.SelectedUser.NameFull;
				this.myMaschinenauftrag.MaschinenbestellungDurchId = usv.SelectedUser.UID;
			}
		}

		void mlnkInstallationDurch_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			usv.ShowDialog(this);
			if (usv.DialogResult == DialogResult.OK && usv.SelectedUser != null)
			{
				this.mlnkInstallationDurch.Text = usv.SelectedUser.NameFull;
				this.myMaschinenauftrag.InstallationDurchId = usv.SelectedUser.UID;
			}
		}

		void mlnkLieferungZumKundenDurch_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			usv.ShowDialog(this);
			if (usv.DialogResult == DialogResult.OK && usv.SelectedUser != null)
			{
				this.mlnkLieferungZumKundenDurch.Text = usv.SelectedUser.NameFull;
				this.myMaschinenauftrag.LieferungZumKundenDurchId = usv.SelectedUser.UID;
			}
		}

		void xcmdOpenInExplorer_Click(object sender, EventArgs e)
		{
			var path = this.myMaschinenauftrag.Maschine.Dateipfad;
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			Process.Start("Explorer.exe", path);
		}

		void xcmdCreateInstDocuments_Click(object sender, EventArgs e)
		{
			var msg = string.Empty;
			if (!string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsChecklistenVorlage))
			{
				string missingItems = string.Empty;
				if (this.CheckInstDocRequirements(out missingItems))
				{
					this.CreateInstallationChecklist();
					if (!string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsReportVorlage))
					{
						this.CreateInstallationReport();
					}
					else
					{
						MetroMessageBox.Show(this, missingItems);
						return;
					}
				}
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void MaschinenauftragView_FormClosing(object sender, FormClosingEventArgs e)
		{
			Model.ModelManager.MachineService.UpdateMachines();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			var title = $"Maschinenauftrag - {this.myMaschinenauftrag.Maschinenmodell} für Firma {this.myMaschinenauftrag.Matchcode}";
			this.Text = title;
			this.mtxtKundenbestellungDurch.DataBindings.Add("Text", this.myMaschinenauftrag, "KundenbestellungDurch");
			this.mcmbKundenbestellungPer.DataBindings.Add("SelectedItem", this.myMaschinenauftrag, "KundenbestellungPer");
			this.mtxtBestellIdSage.DataBindings.Add("Text", this.myMaschinenauftrag, "BestellIdSage");

			this.mcmbTintenTyp.DataSource = ModelManager.SharedItemsService.TinteList.Sort("Tintenbezeichnung", System.ComponentModel.ListSortDirection.Ascending);
			this.mcmbTintenTyp.ValueMember = "UID";
			this.mcmbTintenTyp.DisplayMember = "Tintenbezeichnung";
			this.mcmbTintenTyp.DataBindings.Add("SelectedValue", this.myMaschinenauftrag.Maschine, "TintenId");

			this.mtxtFarbSet.DataBindings.Add("Text", this.myMaschinenauftrag.Maschine, "Farbset");

			this.mtxtAnmerkungenBestellung.DataBindings.Add("Text", this.myMaschinenauftrag, "AnmerkungenBestellung");

			// Link-Beschriftungen
			this.mlnkLieferungZumKundenDurch.Text = (this.myMaschinenauftrag.LieferungZumKundenDurch == null) ? "Techniker auswählen" : this.myMaschinenauftrag.LieferungZumKundenDurch.NameFull;
			this.mlnkMaschinenbestellungDurchId.Text = (this.myMaschinenauftrag.MaschinenbestellungDurch == null) ? "Besteller auswählen" : this.myMaschinenauftrag.MaschinenbestellungDurch.NameFull;
			this.mlnkInstallationDurch.Text = (this.myMaschinenauftrag.InstallationDurch == null) ? "Techniker auswählen" : this.myMaschinenauftrag.InstallationDurch.NameFull;

			this.mtxtAuftragsnummerSage.DataBindings.Add("Text", this.myMaschinenauftrag.Maschine, "AuftragsnummerSage");

			this.mtogglAuftragErledigtFlag.DataBindings.Add("Checked", this.myMaschinenauftrag, "AuftragErledigtFlag");

			// DATETIMEPICKER
			if (this.myMaschinenauftrag.KundenbestellungAm != null)
			{
				this.mdtpKundenbestellungAm.Checked = true;
				this.mdtpKundenbestellungAm.Value = this.myMaschinenauftrag.KundenbestellungAm.Value;
			}

			if (this.myMaschinenauftrag.MaschinenbestellungAm != null)
			{
				this.mdtpMaschinenbestellungAm.Checked = true;
				this.mdtpMaschinenbestellungAm.Value = this.myMaschinenauftrag.MaschinenbestellungAm.Value;
			}

			if (this.myMaschinenauftrag.MaschinenlieferungAm != null)
			{
				this.mdtpMaschinenlieferungAm.Checked = true;
				this.mdtpMaschinenlieferungAm.Value = this.myMaschinenauftrag.MaschinenlieferungAm.Value;
			}

			if (this.myMaschinenauftrag.Installationsdatum != null)
			{
				this.mdtpInstallationsdatum.Checked = true;
				this.mdtpInstallationsdatum.Value = this.myMaschinenauftrag.Installationsdatum.Value;
			}

			if (this.myMaschinenauftrag.LieferungZumKundenAm.HasValue)
			{
				this.mdtpLieferungZumKundenAm.Checked = true;
				this.mdtpLieferungZumKundenAm.Value = this.myMaschinenauftrag.LieferungZumKundenAm.Value;
			}
		}

		bool CheckInstDocRequirements(out string thisIsMissing)
		{
			thisIsMissing = string.Empty;
			var sb = new StringBuilder($"Die Installationsdokumente bedürfen noch der einen oder anderen Vorbereitung:{nl}{nl}");
			var sbLength = sb.Length;

			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Dateipfad)) sb.AppendLine(" - Der Maschinenordner fehlt. Es genügt, die einmal zu öffnen, dann passiert das automatisch.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsChecklistenVorlage)) sb.AppendLine($" - Die Checklisten-Vorlage für '{this.myMaschinenauftrag.Maschine.Maschinenserie.Serienname}' fehlt.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsReportVorlage)) sb.AppendLine($"- Die Installationsberichts-Vorlage für '{this.myMaschinenauftrag.Maschine.Maschinenserie.Serienname}' fehlt.");
			if (this.myMaschinenauftrag.Maschine.CurrentOwner == null) sb.AppendLine(" - Der Kunde/Käufer der Maschine fehlt.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschinenmodell)) sb.AppendLine(" - Das Modell der Maschine ist nicht festgelegt.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Seriennummer)) sb.AppendLine(" - Die Seriennummer fehlt.");
			if (this.myMaschinenauftrag.InstallationDurch == null) sb.AppendLine(" - Der installierende Techniker fehlt.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.AuftragsnummerSage)) sb.AppendLine(" - Die Auftragsnummer fehlt.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Tinte)) sb.AppendLine(" - Der Tintentyp ist nicht eingetragen.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Farbset)) sb.AppendLine(" - Das Farbset ist nicht eingetragen.");
			if (string.IsNullOrEmpty(this.myMaschinenauftrag.Maschine.Maschinenserie.LetzteFirmware)) sb.AppendLine(" - Die aktuellste Seriennummer der Serie fehlt noch");

			if (sb.Length > sbLength)
			{
				thisIsMissing = sb.ToString();
				return false;
			}
			return true;
		}

		void CreateInstallationChecklist()
		{
			var instPath = Path.Combine(this.myMaschinenauftrag.Maschine.Dateipfad, "Installation");
			if (!Directory.Exists(instPath)) Directory.CreateDirectory(instPath);
			var clData = new OfficeBridge.Services.InstChecklistCreator.ChecklistData();
			clData.Dateipfad = instPath;
			clData.ChecklistenDatum = DateTime.Today;
			clData.FirmenBezeichnung = this.myMaschinenauftrag.Maschine.CurrentOwner.CompanyName1;
			clData.KundenNummer = this.myMaschinenauftrag.Kundennummer;
			clData.Maschinenmodell = this.myMaschinenauftrag.Maschinenmodell;
			clData.SeriennummerMaschine = this.myMaschinenauftrag.Maschine.Seriennummer;
			clData.TechnikerName = this.myMaschinenauftrag.InstallationDurch.NameFull;
			clData.AuftragsNummerSage = this.myMaschinenauftrag.AuftragsnummerSage;
			clData.Tintentyp = this.myMaschinenauftrag.Maschine.Tinte;
			clData.Farbset = this.myMaschinenauftrag.Maschine.Farbset;
			clData.AktuelleFirmware = this.myMaschinenauftrag.Maschine.Maschinenserie.LetzteFirmware;
			clData.VorlagenDatei = this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsChecklistenVorlage;
			OfficeBridge.ServiceManager.InstallationChecklistCreator.CreateChecklist(clData, true);
		}

		void CreateInstallationReport()
		{
			var instPath = Path.Combine(this.myMaschinenauftrag.Maschine.Dateipfad, "Installation");
			var modell = this.myMaschinenauftrag.Maschinenmodell;
			var sn = this.myMaschinenauftrag.Maschine.Seriennummer;
			var farbset = this.myMaschinenauftrag.Maschine.Farbset;
			if (!Directory.Exists(instPath)) Directory.CreateDirectory(instPath);

			var irData = new OfficeBridge.Services.InstReportCreator.InstReportData();

			irData.BerichtsDatum = DateTime.Today;
			irData.BildDateiname = $"{modell}_{sn}_{farbset}_Picture";
			irData.Dateipfad = instPath;
			irData.FarbSet = farbset;
			irData.FirmwareVorUpdate = "0.00";
			irData.FirmwareNachUpdate = this.myMaschinenauftrag.Maschine.Maschinenserie.LetzteFirmware;
			irData.InstallationsDatum = DateTime.Today;
			irData.Maschinenmodell = modell;
			irData.OptionsBezeichnung = string.Empty;
			irData.OptionsSeriennummer = string.Empty;
			irData.RipSoftware = "RasterLink Pro 6";
			irData.SeriennummerMaschine = sn;
			irData.Technikername = this.myMaschinenauftrag.InstallationDurch.NameFull;
			irData.TintenTyp = this.myMaschinenauftrag.Maschine.Tinte;
			irData.VorlagenDatei = this.myMaschinenauftrag.Maschine.Maschinenserie.InstallationsReportVorlage;

			OfficeBridge.ServiceManager.InstallationReportCreator.CreateInstallationReport(irData, false);
		}

		#endregion PRIVATE PROCEDURES

		#region DATEPICKER

		void mdtpKundenbestellungAm_ValueChanged(object sender, EventArgs e)
		{
			switch (this.mdtpKundenbestellungAm.Checked)
			{
				case true:
				this.mdtpKundenbestellungAm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
				this.myMaschinenauftrag.KundenbestellungAm = this.mdtpKundenbestellungAm.Value;
				break;

				case false:
				this.mdtpKundenbestellungAm.CustomFormat = " ";
				this.mdtpKundenbestellungAm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.myMaschinenauftrag.KundenbestellungAm = null;
				break;
			}
		}

		void mdtpMaschinenbestellungAm_ValueChanged(object sender, EventArgs e)
		{
			switch (this.mdtpMaschinenbestellungAm.Checked)
			{
				case true:
				this.mdtpMaschinenbestellungAm.Format = DateTimePickerFormat.Short;
				this.myMaschinenauftrag.MaschinenbestellungAm = this.mdtpMaschinenbestellungAm.Value;
				break;

				case false:
				this.mdtpMaschinenbestellungAm.CustomFormat = " ";
				this.mdtpMaschinenbestellungAm.Format = DateTimePickerFormat.Custom;
				this.myMaschinenauftrag.MaschinenbestellungAm = null;
				break;
			}
		}

		void mdtpMaschinenlieferungAm_ValueChanged(object sender, EventArgs e)
		{
			switch (this.mdtpMaschinenlieferungAm.Checked)
			{
				case true:
				this.mdtpMaschinenlieferungAm.Format = DateTimePickerFormat.Short;
				this.myMaschinenauftrag.MaschinenlieferungAm = this.mdtpMaschinenlieferungAm.Value;
				break;

				case false:
				this.mdtpMaschinenlieferungAm.CustomFormat = " ";
				this.mdtpMaschinenlieferungAm.Format = DateTimePickerFormat.Custom;
				this.myMaschinenauftrag.MaschinenlieferungAm = null;
				break;
			}
		}

		void mdtpInstallationsdatum_ValueChanged(object sender, EventArgs e)
		{
			switch (this.mdtpInstallationsdatum.Checked)
			{
				case true:
				this.mdtpInstallationsdatum.Format = DateTimePickerFormat.Short;
				this.myMaschinenauftrag.Installationsdatum = this.mdtpInstallationsdatum.Value;
				break;

				case false:
				this.mdtpInstallationsdatum.CustomFormat = " ";
				this.mdtpInstallationsdatum.Format = DateTimePickerFormat.Custom;
				this.myMaschinenauftrag.Installationsdatum = null;
				break;
			}
		}

		void mdtpLieferungZumKundenAm_ValueChanged(object sender, EventArgs e)
		{
			switch (this.mdtpLieferungZumKundenAm.Checked)
			{
				case true:
				this.mdtpLieferungZumKundenAm.Format = DateTimePickerFormat.Short;
				this.myMaschinenauftrag.LieferungZumKundenAm = this.mdtpLieferungZumKundenAm.Value;
				break;

				case false:
				this.mdtpLieferungZumKundenAm.CustomFormat = " ";
				this.mdtpLieferungZumKundenAm.Format = DateTimePickerFormat.Custom;
				this.myMaschinenauftrag.LieferungZumKundenAm = null;
				break;
			}
		}

		#endregion DATEPICKER
	}
}