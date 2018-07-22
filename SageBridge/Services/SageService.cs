using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Products.SageBridge.Services
{
	/// <summary>
	/// Service für Funktionen im Zusammenhang mit unserer Sage New Classic Auftragsbearbeitung.
	/// </summary>
	public class SageService
	{
		#region ENUMS

		public enum SageAppType
		{
			Auftrag = 1,
			Angebot = 2
		}

		#endregion ENUMS

		#region CONSTANTS

		const string sageBasePath = @"\\Cpm-dc\sage_ncl\2014\";
		const string sageStationPath = @"\\Cpm-dc\sage_ncl\2014\station\";

		#endregion CONSTANTS

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Öffnet bzw. startet Sage und zeigt den Auftrag mit der angegebenen Auftragsnummer an.
		/// </summary>
		/// <param name="appType">Ein Wert der <seealso cref="SageAppType"/> Auflistung.</param>
		/// <param name="parameter">
		/// Parameter für die zu startende Sage App. Z. B. eine Auftrags- oder Angebotsnummer.
		/// </param>
		public void StartSageApp(SageAppType appType, string loginSage, string parameter, string kundePK)
		{
			var processExe = $@"{sageBasePath}\EXE\cl.exe";
			var iniFileName = $"{loginSage}.ini";
			if (!parameter.Length.Equals(11))
			{
				var msg = $"'{parameter}' ist offenbar keine gültige Auftragsnummer. Auftragsnummern sind immer 11-stellig.";
				throw new ArgumentException(msg, nameof(parameter));
			}
			if (loginSage.Length < 2 || loginSage.Length > 3)
			{
				var msg = $"Die INI-Datei '{iniFileName}' gibt es auf dem Server nicht. Bitte Axel fragen, was für Dich in der Datenbank eingetragen ist.";
				throw new ArgumentException(msg, nameof(loginSage));
			}

			var stationPath = Path.Combine(sageStationPath, iniFileName);
			var now = DateTime.Today;
			var datum = $"{now.ToString("dd")}{now.ToString("MM")}{now.ToString("yy")}";
			var arguments = string.Empty;
			switch (appType)
			{
				case SageAppType.Auftrag:
					// Die Auftragsnummer in die Zwischenablage übertragen.
					Clipboard.SetText(parameter);
					arguments = $"/S\"{stationPath}\" /U\"{loginSage}\" /K\"0540136800\" /M001 /D\"{datum}\" /X\"PA2100|00000\" /B";
					break;

				case SageAppType.Angebot:
					Clipboard.SetText(kundePK);
					arguments = $"/S\"{stationPath}\" /U\"{loginSage}\" /K\"0540136800\" /M001 /X\"PA2120|00000\" /B /P\"{parameter}\" /D\"{datum}\"";
					break;
			}

			var pi = new ProcessStartInfo();
			pi.FileName = processExe;
			pi.Arguments = arguments;

			var startThis = $"{processExe} {arguments}";
			Process.Start(processExe, arguments);
		}

		#endregion PUBLIC PROCEDURES
	}
}