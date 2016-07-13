using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSoftwareTableAdapters;

namespace Products.Data.Services
{
	public class SoftwareDataService
	{

		#region members

		readonly string myCurrentUserPK;
		readonly dsSoftware myDS = new Datasets.dsSoftware();
		readonly taKundenSoftware myKundenSoftwareAdapter = new taKundenSoftware();
		readonly taSoftware mySoftwareAdapter = new taSoftware(); 

		private string myGuidUnknown = "00000000-0000-0000-0000-000000000000";

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SoftwareDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public SoftwareDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		#region Kundensoftware

		/// <summary>
		/// Erstellt eine neue KundenSoftwareRow für den angegebenen Kunden und optional die angegebene Kundenmaschine.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Kunden.</param>
		/// <param name="machinePK">Primärschlüssel der Kundenmaschine.</param>
		/// <returns></returns>
		public dsSoftware.KundenSoftwareRow AddKundenSoftwareRow(string customerPK, string machinePK)
		{
			dsSoftware.KundenSoftwareRow sRow = this.myDS.KundenSoftware.NewKundenSoftwareRow();
			sRow.UID = Common.SequentialGuid.NewID().ToString();
			sRow.SoftwareId = myGuidUnknown;
			sRow.Kundennummer = customerPK;
			sRow.KundenMaschineId = machinePK;
			sRow.Lizenzschluessel = "";
			sRow.Installationsdatum = DateTime.Today;
			sRow.Anmerkungen = "";
			sRow.Computer = "";
			sRow.Hauptbenutzer = "";
			this.myDS.KundenSoftware.AddKundenSoftwareRow(sRow);

			return sRow;
		}

		/// <summary>
		/// Gibt eine Liste aller KundenSoftwareRows für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Kunden.</param>
		/// <returns></returns>
		public IEnumerable<dsSoftware.KundenSoftwareRow> GetCustomerSoftwareRows(string customerPK)
		{
			return this.myDS.KundenSoftware.Where(s => s.Kundennummer == customerPK);
		}

		/// <summary>
		/// Gibt eine Liste aller KundenSoftwareRows für die angegebene Kundenmaschine zurück.
		/// </summary>
		/// <param name="machinePK">Primärschlüssel der Maschine.</param>
		/// <returns></returns>
		public IEnumerable<dsSoftware.KundenSoftwareRow> GetMachineSoftwareRows(string machinePK)
		{
			return this.myDS.KundenSoftware.Where(s => s.KundenMaschineId == machinePK);
		}

		/// <summary>
		/// Gibt die KundenSoftwareDataTable mit der kompletten im System verfügbaren Kundensoftware zurück.
		/// </summary>
		/// <returns></returns>
		public dsSoftware.KundenSoftwareDataTable GetKundenSoftwareTable()
		{
			return this.myDS.KundenSoftware;
		}

		/// <summary>
		/// Löscht die KundenSoftwareRow mit dem angegebenen Primärschlüssel aus der Datenbank.
		/// </summary>
		/// <param name="softwarePK"></param>
		public void DeleteKundenSoftwareRow(string softwarePK)
		{
			dsSoftware.KundenSoftwareRow sRow = this.myDS.KundenSoftware.FindByUID(softwarePK);
			sRow.Delete();
			this.myKundenSoftwareAdapter.Update(sRow);
		}

		/// <summary>
		/// Speichert neue, geänderte und gelöschte Datensätze in der Datenbank.
		/// </summary>
		public void UpdateKundenSoftware()
		{
			if (this.myDS.KundenSoftware.GetChanges() != null)
			{
				this.myKundenSoftwareAdapter.Update(this.myDS.KundenSoftware);
			}
		}

		#endregion

		#region Software

		/// <summary>
		/// Gibt die SoftwareDataTable mit allen im System verfügbaren Softwareprogrammen zurück.
		/// </summary>
		/// <returns></returns>
		public dsSoftware.SoftwareDataTable GetSoftwareTable()
		{
			return this.myDS.Software;
		}

		/// <summary>
		/// Fügt zur Tabelle Software eine neue Zeile hinzu.
		/// </summary>
		/// <returns></returns>
		public dsSoftware.SoftwareRow AddSoftwareRow()
		{
			var sRow = this.myDS.Software.NewSoftwareRow();
			sRow.UID = Common.SequentialGuid.NewID().ToString();
			sRow.SoftwareName = "Name des Programms";
			this.myDS.Software.AddSoftwareRow(sRow);

			return sRow;
		}

		/// <summary>
		/// Aktualisiert alle neuen, geänderten und gelöschten Datensätze in der Tabelle Software.
		/// </summary>
		public void UpdateSoftware()
		{
			if (this.myDS.Software.GetChanges() != null)
			{
				this.mySoftwareAdapter.Update(this.myDS.Software);
			}
		}

		#endregion

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.mySoftwareAdapter.Fill(this.myDS.Software);
			this.myKundenSoftwareAdapter.Fill(this.myDS.KundenSoftware);
		}

		#endregion

	}
}
