using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Data;
using Products.Data.Datasets;
using Products.Data.Datasets.dsMachinesTableAdapters;

namespace Products.Data.Services
{
	public class MachineDataService
	{
		#region events

		public event EventHandler<MachineMovedEventArgs> AfterMachineMoved;

		#endregion events

		#region members

		string myCurrentUserPK;

		#region Dataset und Adapter

		dsMachines myMachinesDS;
		taKundeMaschineXref myKundeMaschineXrefAdapter;
		taKundenMaschine myKundenMaschineAdapter;
		readonly taKundenmaschinenListe myKundenmaschinenListeAdapter = new taKundenmaschinenListe();

		#endregion Dataset und Adapter

		#endregion members

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

		#region public procedures

		/// <summary>
		/// Erstellt eine neue KundenMaschineRow für den angegebenen Kunden.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public MachineBuildParams AddKundenMaschineRow(string kundePK, string createdByPK)
		{
			// Neue Zeile in Tabelle Kundenmaschine einfügen.
			var mRow = this.myMachinesDS.KundenMaschine.NewKundenMaschineRow();
			mRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			mRow.Kundennummer = kundePK;
			mRow.MaschinenmodellId = "00000000-0000-0000-0000-000000000000";
			//mRow.Seriennummer = "-";
			//mRow.Firmware = "-";
			//mRow.SetHaendlerNull();
			//mRow.Auftragsdatum = DateTime.Today;
			//mRow.Lieferdatum = DateTime.Today;
			mRow.LeasingFlag = "0";
			mRow.MietkaufFlag = "0";
			//mRow.Finanzierungsgesellschaft = "-";
			//mRow.Finanzierungsende = new DateTime(100, 1, 1, 0, 0, 0);
			mRow.ErstverwertungsFlag = "0";
			mRow.Installationsdatum = DateTime.Today;
			//mRow.Anmerkungen = "";
			mRow.TintenId = "00000000-0000-0000-0000-000000000000";
			//mRow.FarbenSet = "";
			//mRow.AuftragsnummerSage = "";
			//mRow.RechnungsnummerSage = "";
			mRow.Wartungsintervall = 12;
			//mRow.Dateipfad = "";
			//mRow.Sonderausstattung = "";

			this.myMachinesDS.KundenMaschine.AddKundenMaschineRow(mRow);

			// Neue Zeile in Tabelle KundenMaschineXref einfügen.
			var xRow = this.AddMachineXrefRow(mRow.UID, kundePK, createdByPK);

			this.UpdateKundenMaschinen();
			var retParams = new MachineBuildParams(mRow, xRow);
			return retParams;
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
		{
			return this.myMachinesDS.KundeMaschineXref.Where(m => m.MaschinenId == machinePK);
		}

		/// <summary>
		/// Gibt die KundenMaschineXrefRow für die angegebene Maschine und den angegebenen Kunden,
		/// bei der das Zuordnungsende noch nicht erreicht ist.
		/// </summary>
		/// <param name="machinePK"></param>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		public dsMachines.KundeMaschineXrefRow GetKundenMaschineXrefRow(string machinePK, string kundePK)
		{
			return this.myMachinesDS.KundeMaschineXref.FirstOrDefault(x => x.MaschinenId == machinePK && x.Kundennummer == kundePK && x.Zuordnungsende >= DateTime.Now);
		}

		/// <summary>
		/// Gibt die KundeMaschineXrefRow für die angegebene Maschine zurück, die aktuell einem
		/// Kunden zugeordnet ist.
		/// </summary>
		/// <param name="machinePK"></param>
		/// <returns></returns>
		public dsMachines.KundeMaschineXrefRow GetKundenMaschineXrefRow(string machinePK)
		{
			this.AssureMachinesInitialized();
			return this.myMachinesDS.KundeMaschineXref.FirstOrDefault(x => x.MaschinenId == machinePK & x.Zuordnungsende >= DateTime.Now);
		}

		/// <summary>
		/// Ändert die KundenMaschineRow der angegebenen Maschine und ordnet sie einem neuen Kunden zu.
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
			if (AfterMachineMoved != null)
			{
				AfterMachineMoved(this, new MachineMovedEventArgs(machinePK, fromKundePK, toKundePK));
			}

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
		/// Speichert Änderungen der angegebenen KundenMaschineRow in der Datenbank oder alle
		/// Datensätze für den angegebenen Kunden, falls keine KundenMaschineRow angegeben wurde.
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
			return result;
		}

		#region Kundenmaschinensuche

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
		/// Gibt eine Liste von aktuell zugeordneten Kundenmaschinen für den angegebenen Kunden zurück.
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

		#endregion Kundenmaschinensuche

		#endregion public procedures

		#region private procedures

		void AssureMachinesInitialized()
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

		dsMachines.KundeMaschineXrefRow AddMachineXrefRow(string machinePK, string kundePK, string creatorPK, DateTime? zuordnungsBeginn = null)
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

		#endregion private procedures

		#region SubClasses

		/// <summary>
		/// Ereignisargumente beim Verschieben von Maschinen von einem Kunden zum anderen.
		/// </summary>
		public class MachineMovedEventArgs : EventArgs
		{
			public string MachinePK { get; private set; }

			public string FromKundePK { get; private set; }

			public string ToKundePK { get; private set; }

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
		public class MachineBuildParams
		{
			public dsMachines.KundenMaschineRow KundenMaschineRow { get; private set; }

			public dsMachines.KundeMaschineXrefRow KundenXrefRow { get; private set; }

			public MachineBuildParams(dsMachines.KundenMaschineRow machineRow, dsMachines.KundeMaschineXrefRow kundenXrefRow)
			{
				this.KundenMaschineRow = machineRow;
				this.KundenXrefRow = kundenXrefRow;
			}
		}

		#endregion SubClasses
	}
}