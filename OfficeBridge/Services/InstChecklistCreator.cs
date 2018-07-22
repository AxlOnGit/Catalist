using System;
using System.IO;
using NetOffice.WordApi;
using NetOffice.WordApi.Enums;

namespace Products.OfficeBridge.Services
{
	/// <summary>
	/// Serviceklasse für das automatische Erstellen von Installations-Checklisten.
	/// </summary>
	public class InstChecklistCreator
	{
		#region PUBLIC PROCEDURES

		public string CreateChecklist(ChecklistData checklistData, bool printIt)
		{
			var template = Path.Combine(this.CreateTemplatePath(), checklistData.VorlagenDatei);
			Application word = null;
			try
			{
				word = new Application();
				word.DisplayAlerts = WdAlertLevel.wdAlertsNone;
				var newDoc = word.Documents.Add(template);

				foreach (var control in newDoc.SelectContentControlsByTag("Technician"))
				{
					control.Range.Text = checklistData.TechnikerName;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("ChecklistDate"))
				{
					control.Range.Text = checklistData.ChecklistenDatum.ToShortDateString();
				}

				foreach (var control in newDoc.SelectContentControlsByTag("CustomerAndCustomerId"))
				{
					control.Range.Text = $"{checklistData.FirmenBezeichnung} [{checklistData.KundenNummer}]";
				}

				foreach (var control in newDoc.SelectContentControlsByTag("MachineModelAndSN"))
				{
					control.Range.Text = $"{checklistData.Maschinenmodell} [{checklistData.SeriennummerMaschine}]";
				}

				foreach (var control in newDoc.SelectContentControlsByTag("AuftragsnummerInSage"))
				{
					control.Range.Text = checklistData.AuftragsNummerSage;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("InkType"))
				{
					control.Range.Text = checklistData.Tintentyp;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("ColorSet"))
				{
					control.Range.Text = checklistData.Farbset;
				}

				foreach (var control in newDoc.SelectContentControlsByTag("FirmwareCurrent"))
				{
					control.Range.Text = checklistData.AktuelleFirmware;
				}

				var fileName = $"{checklistData.Maschinenmodell}_{checklistData.SeriennummerMaschine}_InstallationsCheckliste.docx";
				var nameFull = Path.Combine(checklistData.Dateipfad, fileName);

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

		public struct ChecklistData
		{
			/// <summary>
			/// Dateiname der Vorlage.
			/// </summary>
			public string VorlagenDatei;

			/// <summary>
			/// Name des Technikers, der die Maschine installiert/installiert hat.
			/// </summary>
			public string TechnikerName;

			/// <summary>
			/// Datum des Installationsberichts.
			/// </summary>
			public DateTime ChecklistenDatum;

			/// <summary>
			/// Firmenbezeichnung des Kunden.
			/// </summary>
			public string FirmenBezeichnung;

			/// <summary>
			/// Kundennummer des Käufers.
			/// </summary>
			public string KundenNummer;

			/// <summary>
			/// Modellbezeichnung der Maschine.
			/// </summary>
			public string Maschinenmodell;

			/// <summary>
			/// Seriennummer der Maschine.
			/// </summary>
			public string SeriennummerMaschine;

			/// <summary>
			/// Die Auftragsnummer in der Auftragsbearbeitung (Sage).
			/// </summary>
			public string AuftragsNummerSage;

			public string Tintentyp;

			public string Farbset;

			public string AktuelleFirmware;

			/// <summary>
			/// Dateipfad, unter dem der neue Installationsbericht gespeichert werden soll.
			/// </summary>
			public string Dateipfad;
		}

		#endregion STRUCTS
	}
}