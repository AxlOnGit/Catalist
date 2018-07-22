using System;
using System.IO;
using NetOffice.WordApi;
using NetOffice.WordApi.Enums;

namespace Products.OfficeBridge.Services
{
	public class InstReportCreator
	{
		#region PUBLIC PROCEDURES

		public string CreateInstallationReport(InstReportData instReportData, bool printIt)
		{
			var template = Path.Combine(this.CreateTemplatePath(), instReportData.VorlagenDatei);
			Application word = null;

			if (instReportData.BerichtsDatum == null) instReportData.BerichtsDatum = DateTime.Today;
			if (instReportData.InstallationsDatum == null) instReportData.InstallationsDatum = DateTime.Today;
			if (string.IsNullOrEmpty(instReportData.OptionsBezeichnung)) instReportData.OptionsBezeichnung = "n.a.";
			if (string.IsNullOrEmpty(instReportData.OptionsSeriennummer)) instReportData.OptionsSeriennummer = "n.a.";

			try
			{
				word = new Application();
				word.DisplayAlerts = WdAlertLevel.wdAlertsNone;
				var newDoc = word.Documents.Add(template);

				foreach (var control in newDoc.SelectContentControlsByTag("SN"))
				{
					control.Range.Text = instReportData.SeriennummerMaschine;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("ReportDate"))
				{
					control.Range.Text = instReportData.BerichtsDatum.ToShortDateString();
				}

				foreach (var control in newDoc.SelectContentControlsByTag("MachineModel"))
				{
					control.Range.Text = instReportData.Maschinenmodell;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("InstallationDate"))
				{
					control.Range.Text = instReportData.InstallationsDatum.ToShortDateString();
				}

				foreach (var control in newDoc.SelectContentControlsByTag("InkType"))
				{
					control.Range.Text = instReportData.TintenTyp;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("ColorSet"))
				{
					control.Range.Text = instReportData.FarbSet;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("Rip"))
				{
					control.Range.Text = instReportData.RipSoftware;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("Technician"))
				{
					control.Range.Text = instReportData.Technikername;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("FwBeforeUpdate"))
				{
					control.Range.Text = instReportData.FirmwareVorUpdate;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("FwAfterUpdate"))
				{
					control.Range.Text = instReportData.FirmwareNachUpdate;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("Option"))
				{
					control.Range.Text = instReportData.OptionsBezeichnung;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("OptionSN"))
				{
					control.Range.Text = instReportData.OptionsSeriennummer;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("PictureFileName"))
				{
					control.Range.Text = instReportData.BildDateiname;
				}

				var fileName = $"{instReportData.Maschinenmodell}_{instReportData.SeriennummerMaschine}_InstallationsBericht.docx";
				var nameFull = Path.Combine(instReportData.Dateipfad, fileName);
				newDoc.SaveAs(nameFull);
				if (printIt) newDoc.PrintOut();

				return nameFull;
			}
			finally
			{
				if (word != null) { word.Quit(); word.Dispose(); }
			}
		}

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		string CreateTemplatePath()
		{
			var userName = Model.ModelManager.UserService.CurrentUser.NameFirst;
			var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			var oneDriveCPM = string.Empty;
			if (userName.ToLower() == "axel")
			{
				oneDriveCPM = @"OneDrive\VAN ANDEREN";
			}
			else
			{
				oneDriveCPM = @"OneDrive\CPM";
			}
			return Path.Combine(userFolder, oneDriveCPM, @"CPM_INTERN\Firmenvorlagen\CatalistAuto"); ;
		}

		#endregion

		#region STRUCTS

		public struct InstReportData
		{
			/// <summary>
			/// Dateiname der Vorlage.
			/// </summary>
			public string VorlagenDatei;

			/// <summary>
			/// Seriennummer der Maschine.
			/// </summary>
			public string SeriennummerMaschine;

			/// <summary>
			/// Datum des Installationsberichts.
			/// </summary>
			public DateTime BerichtsDatum;

			/// <summary>
			/// Modellbezeichnung der Maschine.
			/// </summary>
			public string Maschinenmodell;

			/// <summary>
			/// Datum der Installation.
			/// </summary>
			public DateTime InstallationsDatum;

			/// <summary>
			/// Name des installierten Tintentyps.
			/// </summary>
			public string TintenTyp;

			/// <summary>
			/// Bezeichnung des installierten Farbsets.
			/// </summary>
			public string FarbSet;

			/// <summary>
			/// Bezeichnung der RIP-Software.
			/// </summary>
			public string RipSoftware;

			/// <summary>
			/// Name des Technikers, der die Maschine installiert/installiert hat.
			/// </summary>
			public string Technikername;

			/// <summary>
			/// Bezeichnung der Maschinenoption.
			/// </summary>
			public string OptionsBezeichnung;

			/// <summary>
			/// Seriennummer der Maschinenoption.
			/// </summary>
			public string OptionsSeriennummer;

			/// <summary>
			/// Name der Bilddatei der Maschine.
			/// </summary>
			public string BildDateiname;

			/// <summary>
			/// Dateipfad, unter dem der neue Installationsbericht gespeichert werden soll.
			/// </summary>
			public string Dateipfad;

			/// <summary>
			/// Firmware-Version im Auslieferungszustand.
			/// </summary>
			public string FirmwareVorUpdate;

			/// <summary>
			/// Firmware-Version nach Aktualisierung.
			/// </summary>
			public string FirmwareNachUpdate;

		}

		#endregion

	}
}
