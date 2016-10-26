using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class MachineService
	{
		#region members

		Dictionary<string, SortableBindingList<Kundenmaschine>> myMachineDictionary = new Dictionary<string, SortableBindingList<Kundenmaschine>>();

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der MachineService Klasse.
		/// </summary>
		public MachineService()
		{
			DataManager.MachineDataService.AfterMachineMoved += this.MachineDataService_AfterMachineMoved;
		}

		#endregion ### .ctor ###

		#region event handler

		void MachineDataService_AfterMachineMoved(object sender, Data.Services.MachineDataService.MachineMovedEventArgs e)
		{
			// Die verschobene Maschine aus der Liste des bisherigen Kunden löschen.
			var machine = this.myMachineDictionary[e.FromKundePK].FirstOrDefault(m => m.UID == e.MachinePK);
			if (machine != null) this.myMachineDictionary[e.FromKundePK].Remove(machine);

			// Und der Liste des neuen Kunden hinzufügen, wenn die schon geladen wurde.
			if (this.myMachineDictionary.ContainsKey(e.ToKundePK)) this.myMachineDictionary[e.ToKundePK].Add(machine);
		}

		#endregion event handler

		#region public procedures

		#region Kundenmaschinensuche

		/// <summary>
		/// Gibt eine schreibgeschützte Liste aller derzeit zugeordneten Kundenmaschinen zum Suchen zurück.
		/// </summary>
		/// <returns></returns>
		public dsMachines.KundenmaschinenListeDataTable GetKundenmaschinenSearchList()
		{
			return DataManager.MachineDataService.GetKundenmaschinenSearchList();
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der Maschinen des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public SortableBindingList<dsMachines.KundenmaschinenListeRow> GetKundenmaschinenSearchList(Kunde kunde)
		{
			var list = DataManager.MachineDataService.GetKundenmaschinenSearchList(kunde.KundenNrCpm);
			return new SortableBindingList<dsMachines.KundenmaschinenListeRow>(list);
		}

		#endregion Kundenmaschinensuche

		/// <summary>
		/// Fügt den Maschinen des angegebenen Kunden eine neue Maschine hinzu.
		/// </summary>
		/// <param name="kundePK">Kundennummer des Kunden, dem die neue Maschine zugeordnet wird.</param>
		/// <returns></returns>
		public Kundenmaschine AddKundenMaschine(string kundePK)
		{
			var buildParams = DataManager.MachineDataService.AddKundenMaschineRow(kundePK, ModelManager.UserService.CurrentUser.UID);
			if (this.myMachineDictionary.ContainsKey(kundePK))
			{
				var ownerDictionary = new Dictionary<DateTime, Kunde>();
				ownerDictionary.Add(buildParams.KundenXrefRow.Zuordnungsbeginn, ModelManager.CustomerService.GetKunde(kundePK, false));
				var machine = new Kundenmaschine(buildParams.KundenMaschineRow, ownerDictionary);
				this.myMachineDictionary[kundePK].Add(machine);
				return machine;
			}
			var list = new SortableBindingList<Kundenmaschine>();
			foreach (var machineRow in DataManager.MachineDataService.GetKundenMaschineRows(kundePK))
			{
				var ownerDictionary = this.CreateOwnerDictionary(machineRow);
				list.Add(new Kundenmaschine(machineRow, ownerDictionary));
			}
			this.myMachineDictionary.Add(kundePK, list);
			return list.FirstOrDefault(m => m.UID == buildParams.KundenMaschineRow.UID);
		}

		Dictionary<DateTime, Kunde> CreateOwnerDictionary(dsMachines.KundenMaschineRow machineRow)
		{
			var ownerDictionary = new Dictionary<DateTime, Kunde>();
			foreach (var item in DataManager.MachineDataService.GetKundenMaschineXrefRows(machineRow.UID).Where(m => m.Zuordnungsende > DateTime.Now))
			{
				ownerDictionary.Add(item.Zuordnungsende, ModelManager.CustomerService.GetKunde(item.Kundennummer, false));
			}
			return ownerDictionary;
		}

		/// <summary>
		/// Gibt die sortierbare Liste der Maschinen des Kunden mit der angegebenen Kundennummer zurück.
		/// </summary>
		/// <param name="kundePK">Kundennummer des Kunden der gesuchten Maschinen.</param>
		/// <returns></returns>
		public SortableBindingList<Kundenmaschine> GetKundenMaschineList(string kundePK)
		{
			if (!this.myMachineDictionary.ContainsKey(kundePK))
			{
				var list = new SortableBindingList<Kundenmaschine>();
				foreach (var kRow in DataManager.MachineDataService.GetKundenMaschineRows(kundePK))
				{
					var ownerList = this.CreateOwnerDictionary(kRow);
					list.Add(new Kundenmaschine(kRow, ownerList));
				}
				this.myMachineDictionary.Add(kundePK, list);
			}
			return this.myMachineDictionary[kundePK];
		}

		/// <summary>
		/// Gibt die Maschine mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="kunde">Kunde, dem diese Maschine zugeordnet ist.</param>
		/// <param name="machinePK">Primärschlüssel der gesuchten Maschine.</param>
		/// <returns></returns>
		public Kundenmaschine GetKundenMaschine(Kunde kunde, string machinePK)
		{
			return this.GetKundenMaschineList(kunde.CustomerId).FirstOrDefault(m => m.UID == machinePK);
		}

		/// <summary>
		/// Gibt die Kundenmaschine mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="machinePK">Primärschlüssel der Kundenmaschine.</param>
		/// <returns></returns>
		public Kundenmaschine GetKundenMaschine(string machinePK)
		{
			var xRow = DataManager.MachineDataService.GetKundenMaschineXrefRow(machinePK);
			var kunde = ModelManager.CustomerService.GetKunde(xRow.Kundennummer, false);
			return this.GetKundenMaschine(kunde, machinePK);
		}

		/// <summary>
		/// Gibt die Anzahl der Maschinen des Kunden mit der angegebenen Kundennummer zurück.
		/// </summary>
		/// <param name="kundePK">Kundennummer des Kunden, dessen Maschinenanzahl gesucht wird.</param>
		/// <returns></returns>
		public int GetKundenMaschineCount(string kundePK)
		{
			return this.myMachineDictionary.ContainsKey(kundePK) ? this.myMachineDictionary[kundePK].Count : 0;
		}

		/// <summary>
		/// Transferiert die angegebene Maschine vom einen zum anderen Kunden.
		/// </summary>
		/// <param name="machine">Die zu transferierende Maschine.</param>
		/// <param name="fromKundePK">Kundennummer des bisherigen Eigentümers.</param>
		/// <param name="toKundePK">Kundennummer des neuen Eigentümers.</param>
		public void TransferMachine(Kundenmaschine machine, string fromKundePK, string toKundePK)
		{
			DataManager.MachineDataService.MoveMachineRow(machine.UID, fromKundePK, toKundePK, ModelManager.UserService.CurrentUser.UID);
			if (ModelManager.SoftwareService.GetMachinesSoftware(machine).Count > 0)
			{
				ModelManager.SoftwareService.TransferSoftware(machine, toKundePK);
			}
		}

		/// <summary>
		/// Löscht die angegebene KundenMaschine und alle zugehörigen Verknüpfungen in Tabelle KundenMaschineXref.
		/// </summary>
		/// <param name="machine"></param>
		public void DeleteKundenMachine(Kundenmaschine machine)
		{
			var machineAsLink = machine as ILinkedItem;
			var appointmentList = ModelManager.AppointmentService.GetAppointmentList(machineAsLink.Key, machineAsLink.LinkTypeId);
			var fileList = ModelManager.FileLinkService.GetFileLinkList(machine.UID);
			var notesList = ModelManager.NotesService.GetNotesList(machineAsLink.Key, machineAsLink.LinkTypeId);
			var softwareList = ModelManager.SoftwareService.GetMachinesSoftware(machine);
			if (fileList.Count == 0 && notesList.Count == 0 && appointmentList.Count == 0 && softwareList.Count == 0)
			{
				DataManager.MachineDataService.DeleteKundenMaschineRows(machine.UID);
			}
		}

		#region MASCHINENWARTUNG

		public SortableBindingList<Wartungsvorschlag> CreateWartungsplanungTable()
		{
			var list = this.GetWartungsmaschinenListe();
			var returnList = new SortableBindingList<Wartungsvorschlag>();
			foreach (var item in list)
			{
				// Maschine und die damit verknüpften Termine ermitteln. Es werden nur Wartungs- und
				// Servicetermine in der Vergangenheit berücksichtigt!
				var machine = this.GetKundenMaschine(item.UID);
				var appointments = ModelManager.AppointmentService.GetAppointmentList(machine).Where(
					a => (a.AppointmentType == "Wartungstermin" | a.AppointmentType == "Servicetermin") & a.StartsAt <= DateTime.Now);
				var letzterTermin = DateTime.MinValue;

				var vorschlag = new Wartungsvorschlag();
				vorschlag.Maschine = machine;
				vorschlag.LetzteWartung = DateTime.MinValue;
				vorschlag.Terminvorschlag = DateTime.MinValue;

				// Wenn es bereits Termine gegeben hat
				if (appointments != null && appointments.Count() > 0)
				{
					letzterTermin = appointments.Max(a => a.StartsAt);
					vorschlag.LetzteWartung = letzterTermin;
					if (machine.Wartungsintervall > 0) vorschlag.Terminvorschlag = letzterTermin.AddMonths(machine.Wartungsintervall);
				}
				returnList.Add(vorschlag);
			}
			return returnList;
		}

		/// <summary>
		/// Gibt eine Liste aller Kundenmaschinen zurück, die zu einer normalerweise gewarteten Serie gehören.
		/// </summary>
		/// <returns></returns>
		IEnumerable<dsMachines.KundenmaschinenListeRow> GetWartungsmaschinenListe()
		{
			return this.GetKundenmaschinenSearchList().Where(m => m.Wartungskennzeichen == 1);
		}

		System.Data.DataTable CreateWartungsDataTable()
		{
			var table = new System.Data.DataTable();
			var colUID = table.Columns.Add("UID", typeof(string));
			var colMaschine = table.Columns.Add("Maschine", typeof(string));
			var colKunde = table.Columns.Add("Kunde", typeof(string));
			var colLetzteWartung = table.Columns.Add("LetzteWartung", typeof(DateTime));
			var colGeplanteWartung = table.Columns.Add("Terminvorschlag", typeof(DateTime));
			var colKundennummer = table.Columns.Add("Kundennummer", typeof(string));

			return table;
		}

		#endregion MASCHINENWARTUNG

		/// <summary>
		/// Speichert Änderungen an den Maschinen des angegebenen Kunden in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateMachines()
		{
			return DataManager.MachineDataService.UpdateKundenMaschinen();
		}

		#endregion public procedures
	}

	public class Wartungsvorschlag
	{
		#region public properties

		public Kundenmaschine Maschine { get; set; }

		public string Maschinenname
		{
			get { return this.Maschine.Maschinenmodell.Modellbezeichnung; }
		}

		public Kunde Kunde
		{
			get { return ModelManager.CustomerService.GetKunde(this.Maschine.Kundennummer, false); }
		}

		public string Kundennummer { get { return this.Kunde.KundenNrCpm; } }

		public string Kundenname { get { return this.Kunde.Matchcode; } }

		public string Postleitzahl { get { return this.Kunde.ZipCode; } }

		public DateTime LetzteWartung { get; set; }

		public DateTime Terminvorschlag { get; set; }

		#endregion public properties
	}
}