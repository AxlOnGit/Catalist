using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;
using Products.Common;
using Products.Data.Services;
using Products.Common.Interfaces;

namespace Products.Model.Services
{
	public class MachineService
	{

		#region members

		private Dictionary<string, SortableBindingList<Kundenmaschine>> myMachineDictionary = new Dictionary<string, SortableBindingList<Kundenmaschine>>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der MachineService Klasse.
		/// </summary>
		public MachineService()
		{
			DataManager.MachineDataService.AfterMachineMoved += new EventHandler<Data.Services.MachineDataService.MachineMovedEventArgs>(MachineDataService_AfterMachineMoved);
		}

		#endregion

		#region event handler

		void MachineDataService_AfterMachineMoved(object sender, Data.Services.MachineDataService.MachineMovedEventArgs e)
		{
			// Die verschobene Maschine aus der Liste des bisherigen Kunden löschen.
			Kundenmaschine machine = this.myMachineDictionary[e.FromKundePK].FirstOrDefault(m => m.UID == e.MachinePK);
			if (machine != null) this.myMachineDictionary[e.FromKundePK].Remove(machine);

			// Und der Liste des neuen Kunden hinzufügen, wenn die schon geladen wurde.
			if (this.myMachineDictionary.ContainsKey(e.ToKundePK)) this.myMachineDictionary[e.ToKundePK].Add(machine);
		}

		#endregion

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

		#endregion

		/// <summary>
		/// Fügt den Maschinen des angegebenen Kunden eine neue Maschine hinzu.
		/// </summary>
		/// <param name="kundePK">Kundennummer des Kunden, dem die neue Maschine zugeordnet wird.</param>
		/// <returns></returns>
		public Kundenmaschine AddKundenMaschine(string kundePK)
		{
			MachineDataService.MachineBuildParams buildParams = DataManager.MachineDataService.AddKundenMaschineRow(kundePK, ModelManager.UserService.CurrentUser.UID);
			if (this.myMachineDictionary.ContainsKey(kundePK))
			{
				Dictionary<DateTime, Kunde> ownerDictionary = new Dictionary<DateTime, Kunde>();
				ownerDictionary.Add(buildParams.KundenXrefRow.Zuordnungsbeginn, ModelManager.CustomerService.GetKunde(kundePK, false));
				Kundenmaschine machine = new Kundenmaschine(buildParams.KundenMaschineRow, ownerDictionary);
				this.myMachineDictionary[kundePK].Add(machine);
				return machine;
			}
			else
			{
				SortableBindingList<Kundenmaschine> list = new SortableBindingList<Kundenmaschine>();
				foreach (var machineRow in DataManager.MachineDataService.GetKundenMaschineRows(kundePK))
				{
					Dictionary<DateTime, Kunde> ownerDictionary = this.CreateOwnerDictionary(machineRow);
					list.Add(new Kundenmaschine(machineRow, ownerDictionary));
				}
				this.myMachineDictionary.Add(kundePK, list);
				return list.FirstOrDefault(m => m.UID == buildParams.KundenMaschineRow.UID);
			}
		}

		Dictionary<DateTime, Kunde> CreateOwnerDictionary(dsMachines.KundenMaschineRow machineRow)
		{
			Dictionary<DateTime, Kunde> ownerDictionary = new Dictionary<DateTime, Kunde>();
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
				SortableBindingList<Kundenmaschine> list = new SortableBindingList<Kundenmaschine>();
				foreach (var kRow in DataManager.MachineDataService.GetKundenMaschineRows(kundePK))
				{
					Dictionary<DateTime, Kunde> ownerList = this.CreateOwnerDictionary(kRow);
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

		public void MoveMachine(Kundenmaschine machine, string fromKundePK, string toKundePK)
		{
			DataManager.MachineDataService.MoveMachineRow(machine.UID, fromKundePK, toKundePK, ModelManager.UserService.CurrentUser.UID);
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

		/// <summary>
		/// Speichert Änderungen an den Maschinen des angegebenen Kunden in der Datenbank.
		/// </summary>
		/// <param name="kundePK">Kundennummer des Kunden, dessen Maschinen gespeichert werden sollen.</param>
		/// <returns></returns>
		public int UpdateMachines(string kundePK)
		{
			return DataManager.MachineDataService.UpdateKundenMaschinen();
		}

		#endregion

		#region private procedures
		#endregion

	}
}
