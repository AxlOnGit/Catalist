using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Products.Common;
using Products.Data.Datasets;
using Products.Data.Datasets.dsMachinesTableAdapters;

namespace Products.Data.Services
{
	public class MachineDataService
	{
		#region events

		public event EventHandler<MachineMovedEventArgs> AfterMachineMoved;

		#endregion events

		#region MEMBERS

		private string myCurrentUserPK;

		#region Dataset und Adapter

		private dsMachines myMachinesDS;
		private taKundeMaschineXref myKundeMaschineXrefAdapter;
		private taKundenMaschine myKundenMaschineAdapter;
		private taMaschinenauftrag myMaschinenauftragAdapter;

		private readonly taKundenmaschinenListe myKundenmaschinenListeAdapter = new taKundenmaschinenListe();
		private readonly taWartungsListe myWartungslisteAdapter = new taWartungsListe();

		#endregion Dataset und Adapter

		#endregion MEMBERS

		#region ### .ctor

		/// <summary>
		/// Erzeugt eine neue Instanz der MachineDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit angemeldeten Benutzers.</param>
		public MachineDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion ### .ctor

		#region PUBLIC PROCEDURES

		#region KUNDENMASCHINE

		/// <summary>
		/// Erstellt eine neue KundenMaschineRow für den angegebenen Kunden.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public MachineCreationParams NewKundenmaschineRows(string kundePK, string maschinenmodellPK, string createdByPK, string seriennummer)
		{
			// Neue Zeile in Tabelle Kundenmaschine einfügen.
			var mRow = this.myMachinesDS.KundenMaschine.NewKundenMaschineRow();
			mRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			mRow.Kundennummer = kundePK;
			mRow.MaschinenmodellId = maschinenmodellPK;
			mRow.Seriennummer = (!string.IsNullOrEmpty(seriennummer)) ? seriennummer : string.Empty;
			mRow.LeasingFlag = "0";
			mRow.MietkaufFlag = "0";
			mRow.ErstverwertungsFlag = "0";
			mRow.Installationsdatum = DateTime.Today;
			mRow.TintenId = "00000000-0000-0000-0000-000000000000";
			mRow.Wartungsintervall = 12;
			mRow.KundenauftragFlag = "0";

			this.myMachinesDS.KundenMaschine.AddKundenMaschineRow(mRow);

			// Neue Zeile in Tabelle KundenMaschineXref einfügen.
			var xRow = this.AddMachineXrefRow(mRow.UID, kundePK, createdByPK);

			this.UpdateKundenMaschinen();
			var retParams = new MachineCreationParams(mRow, xRow);
			return retParams;
		}

		/// <summary>
		/// Gibt die Tabelle mit allen Kundenmaschinen zurück.
		/// </summary>
		/// <returns></returns>
		public dsMachines.KundenMaschineDataTable GetKundenmaschineTable()
		{
			this.AssureMachinesInitialized();
			return this.myMachinesDS.KundenMaschine;
		}

		/// <summary>
		/// Gibt eine Liste aller dem angegebenen Kunden zugeordneten Maschinen zurück.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		public IEnumerable<dsMachines.KundenMaschineRow> GetKundenMaschineRows(string kundePK)
		{
			this.AssureMachinesInitialized();
			var result = from machines in this.myMachinesDS.KundenMaschine
									 join xrefs in this.myMachinesDS.KundeMaschineXref
									 on machines.UID equals xrefs.MaschinenId
									 where xrefs.Kundennummer == kundePK && xrefs.Zuordnungsende >= DateTime.Now
									 select machines;
			return result;
		}

		/// <summary>
		/// Gibt die KundenMaschineRow mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="machinePK">Primärschlüssel der KundenMaschineRow.</param>
		/// <returns></returns>
		public dsMachines.KundenMaschineRow GetKundenMaschineRow(string machinePK)
		{
			this.AssureMachinesInitialized();
			return this.myMachinesDS.KundenMaschine.FindByUID(machinePK);
		}

		/// <summary>
		/// Gibt eine Liste der KundenmaschineXrefRows zurück, die alle bisherigen und den
		/// derzeitigen Eigentümer der Maschine repräsentieren.
		/// </summary>
		/// <param name="machinePK"></param>
		/// <returns></returns>
		public IEnumerable<dsMachines.KundeMaschineXrefRow> GetKundenMaschineXrefRows(string machinePK)
			=> this.myMachinesDS.KundeMaschineXref.Where(m => m.MaschinenId == machinePK);

		/// <summary>
		/// Gibt die KundenMaschineXrefRow für die angegebene Maschine und den angegebenen
		/// Kunden, bei der das Zuordnungsende noch nicht erreicht ist.
		/// </summary>
		/// <param name="machinePK"></param>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		public dsMachines.KundeMaschineXrefRow GetKundenMaschineXrefRow(string machinePK, string kundePK)
			=> this.myMachinesDS.KundeMaschineXref.FirstOrDefault(x => x.MaschinenId == machinePK && x.Kundennummer == kundePK && x.Zuordnungsende >= DateTime.Now);

		/// <summary>
		/// Gibt die KundeMaschineXrefRow für die angegebene Maschine zurück, die aktuell
		/// einem Kunden zugeordnet ist.
		/// </summary>
		/// <param name="machinePK"></param>
		/// <returns></returns>
		public dsMachines.KundeMaschineXrefRow GetKundenMaschineXrefRow(string machinePK)
		{
			this.AssureMachinesInitialized();
			return this.myMachinesDS.KundeMaschineXref.FirstOrDefault(x => x.MaschinenId == machinePK & x.Zuordnungsende >= DateTime.Now);
		}

		/// <summary>
		/// Ändert die KundenMaschineRow der angegebenen Maschine und ordnet sie einem
		/// neuen Kunden zu.
		/// </summary>
		/// <param name="machinePK">Primärschlüssel der Maschine.</param>
		/// <param name="fromKundePK">Primärschlüssel des bisherigen Kunden.</param>
		/// <param name="toKundePK">Primärschlüssel des neuen Kunden.</param>
		public bool MoveMachineRow(string machinePK, string fromKundePK, string toKundePK, string creatorPK)
		{
			bool result = false;

			// Zuordnungsende für den alten Kunden festlegen.
			var xRowFrom = this.GetKundenMaschineXrefRow(machinePK, fromKundePK);
			xRowFrom.Zuordnungsende = DateTime.Now;
			xRowFrom.AktualisiertVon = creatorPK;
			xRowFrom.AktualisiertAm = xRowFrom.Zuordnungsende;

			// Neue XRefRow für den neuen Kunden erstellen.
			this.AddMachineXrefRow(machinePK, toKundePK, creatorPK, xRowFrom.Zuordnungsende);
			this.UpdateKundenMaschinen();

			// Ereignis nach dem Verschieben auslösen.
			AfterMachineMoved?.Invoke(this, new MachineMovedEventArgs(machinePK, fromKundePK, toKundePK));

			return result;
		}

		/// <summary>
		/// Löscht alle Datensätze dieser Maschine aus den Tabellen KundenMaschine und KundenMaschineXref.
		/// </summary>
		/// <param name="maschinePK">Primärschlüssel der zu löschenden Maschine.</param>
		/// <returns></returns>
		public int DeleteKundenMaschineRows(string maschinePK)
		{
			int result = 0;
			var mRow = this.myMachinesDS.KundenMaschine.FindByUID(maschinePK);
			if (mRow != null)
			{
				mRow.Delete();
				result += 1;
			}
			var xRows = this.myMachinesDS.KundeMaschineXref.Where(x => x.MaschinenId == maschinePK);
			foreach (var xRow in xRows)
			{
				xRow.Delete();
				result += 1;
			}
			this.UpdateKundenMaschinen();

			return result;
		}

		/// <summary>
		/// Speichert alle Änderungen in den Tabellen KundenMaschine, KundeMaschineXref und
		/// Maschinenauftrag in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateKundenMaschinen()
		{
			int result = 0;
			if (this.myMachinesDS.KundenMaschine.GetChanges() != null)
			{
				result = this.myKundenMaschineAdapter.Update(this.myMachinesDS.KundenMaschine);
			}
			if (this.myMachinesDS.KundeMaschineXref.GetChanges() != null)
			{
				result += this.myKundeMaschineXrefAdapter.Update(this.myMachinesDS.KundeMaschineXref);
			}
			if (this.myMachinesDS.Maschinenauftrag.GetChanges() != null)
			{
				result += this.myMaschinenauftragAdapter.Update(this.myMachinesDS.Maschinenauftrag);
			}
			return result;
		}

		#endregion KUNDENMASCHINE

		#region KUNDENMASCHINENSUCHE

		/// <summary>
		/// Gibt die Tabelle mit allen aktuell zugeordneten Kundenmaschinen für die Suche zurück.
		/// </summary>
		/// <returns></returns>
		public dsMachines.KundenmaschinenListeDataTable GetKundenmaschinenSearchList()
		{
			var result = this.myKundenmaschinenListeAdapter.GetData();
			return result;
			//try
			//{
			//	result =
			//	return result;
			//}
			//catch (ConstraintException)
			//{
			//	var rowErrors = this.myKundenmaschinenListeAdapter.GetData().GetErrors();
			//	for (int i = 0; i < rowErrors.Length; i++)
			//	{
			//		var msg = string.Format("{0}", rowErrors[i].RowError);
			//	}
			//	return null;
			//}
		}

		/// <summary>
		/// Gibt eine Liste von aktuell zugeordneten Kundenmaschinen für den angegebenen
		/// Kunden zurück.
		/// </summary>
		/// <param name="kundeCpm"></param>
		/// <returns></returns>
		public IEnumerable<dsMachines.KundenmaschinenListeRow> GetKundenmaschinenSearchList(string kundeCpm)
		{
			var result = this.GetKundenmaschinenSearchList();
			return result.Where(m => m.Kunde == kundeCpm);

			//try
			//{
			//}
			//catch (ConstraintException)
			//{
			//	var rowErrors = this.myKundenmaschinenListeAdapter.GetData().GetErrors();
			//	for (int i = 0; i < rowErrors.Length; i++)
			//	{
			//		var msg = string.Format("{0}", rowErrors[i].RowError);
			//	}
			//	return null;
			//}
		}

		public IEnumerable<dsMachines.KundenmaschinenListeRow> GetDueServiceMachineList()
		{
			var result = this.GetKundenmaschinenSearchList();
			return result.Where(m => m.Wartungskennzeichen == 1);
		}

		#endregion KUNDENMASCHINENSUCHE

		#region MASCHINENAUFTRAG

		/// <summary>
		/// Gibt die Tabelle mit allen Maschinenaufträgen im System zurück.
		/// </summary>
		/// <returns></returns>
		public dsMachines.MaschinenauftragDataTable GetMaschinenauftragTabelle()
		{
			if (this.myMaschinenauftragAdapter == null)
			{
				this.myMaschinenauftragAdapter = new taMaschinenauftrag();
				this.myMaschinenauftragAdapter.Fill(this.myMachinesDS.Maschinenauftrag);
			}
			return this.myMachinesDS.Maschinenauftrag;
		}

		/// <summary>
		/// Erstellt eine neue Zeile in Tabelle cpm_maschinenauftrag und gibt diese zurück.
		/// </summary>
		/// <param name="machinePK">
		/// Primärschlüssel der Maschine, für die der Maschinenauftrag erstellt wird.
		/// </param>
		/// <returns></returns>
		public dsMachines.MaschinenauftragRow CreateMaschinenauftragRow(string machinePK)
		{
			var aRow = this.myMachinesDS.Maschinenauftrag.NewMaschinenauftragRow();

			aRow.MaschinenId = machinePK;
			aRow.SetKundenbestellungAmNull();
			aRow.SetKundenbestellungDurchNull();
			aRow.SetKundenbestellungPerNull();
			aRow.SetMaschinenbestellungAmNull();
			aRow.SetMaschinenbestellungDurchIdNull();
			aRow.SetMaschinenlieferungAmNull();
			aRow.SetLieferungZumKundenAmNull();
			aRow.SetBestellIdSageNull();
			aRow.SetMaschinenlieferungAmNull();
			aRow.SetAnmerkungenBestellungNull();
			aRow.SetBestelleintrittAmNull();
			aRow.VertragsunterlagenFlag = "0";
			aRow.UebernahmebestaetigungFlag = "0";
			aRow.ObjektversicherungFlag = "0";
			aRow.AgbUnterzeichnetFlag = "0";
			aRow.SetAnmerkungenFinanzierungNull();
			aRow.SetInstallationDurchIdNull();
			aRow.SetInstallationsdatumNull();
			aRow.GarantieunterlagenFlag = "0";
			aRow.SetGarantieablaufdatumNull();
			aRow.AuftragErledigtFlag = "0";

			this.myMachinesDS.Maschinenauftrag.AddMaschinenauftragRow(aRow);
			this.myMaschinenauftragAdapter.Update(aRow);
			return aRow;
		}

		#endregion MASCHINENAUFTRAG

		#region MASCHINENWARTUNG

		/// <summary>
		/// Gibt eine Liste aller MaschinenIds und die Pfade zu David Terminen zurück, für
		/// die es einen Service- oder Wartungstermin gibt.
		/// </summary>
		/// <returns></returns>
		public dsMachines.WartungsListeDataTable GetWartungsliste()
		{
			return this.myWartungslisteAdapter.GetData();
		}

		#endregion MASCHINENWARTUNG

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		private void AssureMachinesInitialized()
		{
			if (this.myKundeMaschineXrefAdapter == null)
			{
				this.myMachinesDS = new dsMachines();
				this.myKundeMaschineXrefAdapter = new taKundeMaschineXref();
				this.myKundenMaschineAdapter = new taKundenMaschine();
				this.myKundeMaschineXrefAdapter.Fill(this.myMachinesDS.KundeMaschineXref);
				this.myKundenMaschineAdapter.Fill(this.myMachinesDS.KundenMaschine);
			}
		}

		private dsMachines.KundeMaschineXrefRow AddMachineXrefRow(string machinePK, string kundePK, string creatorPK, DateTime? zuordnungsBeginn = null)
		{
			if (!zuordnungsBeginn.HasValue) zuordnungsBeginn = DateTime.Now;
			var xRowTo = this.myMachinesDS.KundeMaschineXref.NewKundeMaschineXrefRow();
			xRowTo.UID = SequentialGuid.NewSequentialGuid().ToString();
			xRowTo.MaschinenId = machinePK;
			xRowTo.Kundennummer = kundePK;
			xRowTo.Zuordnungsbeginn = zuordnungsBeginn.Value;
			xRowTo.Zuordnungsende = new DateTime(9999, 12, 31, 0, 0, 0);
			xRowTo.ErstelltAm = xRowTo.Zuordnungsbeginn;
			xRowTo.AktualisiertAm = xRowTo.Zuordnungsbeginn;
			xRowTo.ErstelltVon = creatorPK;
			xRowTo.AktualisiertVon = creatorPK;

			this.myMachinesDS.KundeMaschineXref.AddKundeMaschineXrefRow(xRowTo);
			return xRowTo;
		}

		#endregion PRIVATE PROCEDURES

		#region SubClasses

		/// <summary>
		/// Ereignisargumente beim Verschieben von Maschinen von einem Kunden zum anderen.
		/// </summary>
		public class MachineMovedEventArgs : EventArgs
		{
			public string MachinePK { get; }

			public string FromKundePK { get; }

			public string ToKundePK { get; }

			public MachineMovedEventArgs(string machinePK, string fromKundePK, string toKundePK)
			{
				this.MachinePK = machinePK;
				this.FromKundePK = fromKundePK;
				this.ToKundePK = toKundePK;
			}
		}

		/// <summary>
		/// Rückgabeparameter für die Erstellung einer neuen Kundenmaschine.
		/// </summary>
		public class MachineCreationParams
		{
			public dsMachines.KundenMaschineRow KundenMaschineRow { get; }

			public dsMachines.KundeMaschineXrefRow KundenXrefRow { get; }

			public MachineCreationParams(dsMachines.KundenMaschineRow machineRow, dsMachines.KundeMaschineXrefRow kundenXrefRow)
			{
				this.KundenMaschineRow = machineRow;
				this.KundenXrefRow = kundenXrefRow;
			}
		}

		#endregion SubClasses
	}
}