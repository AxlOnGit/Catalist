using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class MachineService
	{
		#region EVENTS

		public event EventHandler<KundenmaschineDeletingEventArgs> KundenmaschineDeleting;

		public event EventHandler<KundenmaschineMovedEventArgs> KundenmaschineMoved;

		#endregion EVENTS

		#region MEMBERS

		SortableBindingList<Maschinenauftrag> myMaschinenauftragListe;

		#endregion MEMBERS

		#region PUBLIC PROCEDURES

		#region SUCHE

		/// <summary>
		/// Gibt eine schreibgeschützte Liste aller derzeit zugeordneten Kundenmaschinen
		/// zum Suchen zurück.
		/// </summary>
		/// <returns></returns>
		public dsMachines.KundenmaschinenListeDataTable GetKundenmaschinenSearchList() 
			=> DataManager.MachineDataService.GetKundenmaschinenSearchList();

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

		#endregion SUCHE

		#region KUNDENMASCHINEN

		/// <summary>
		/// Transferiert die angegebene Maschine vom einen zum anderen Kunden.
		/// </summary>
		/// <param name="machine">Die zu transferierende Maschine.</param>
		/// <param name="quellKunde">Kundennummer des bisherigen Eigentümers.</param>
		/// <param name="zielKunde">Kundennummer des neuen Eigentümers.</param>
		public void TransferMachine(Kundenmaschine machine, Kunde quellKunde, Kunde zielKunde)
		{
			var currentUser = ModelManager.UserService.CurrentUser;
			DataManager.MachineDataService.MoveMachineRow(machine.UID, quellKunde.CustomerId, zielKunde.CustomerId, currentUser.UID);
			KundenmaschineMoved(this, new KundenmaschineMovedEventArgs(machine, quellKunde, zielKunde));
			if (ModelManager.SoftwareService.GetMachinesSoftware(machine).Count > 0)
			{
				ModelManager.SoftwareService.TransferSoftware(machine, zielKunde);
			}
		}

		/// <summary>
		/// Löscht die angegebene KundenMaschine und alle zugehörigen Verknüpfungen in
		/// Tabelle KundenMaschineXref.
		/// </summary>
		/// <param name="kundenmaschine"></param>
		public void DeleteKundenMachine(Kundenmaschine kundenmaschine)
		{
			var appointmentList = ModelManager.AppointmentService.GetAppointmentList(kundenmaschine);
			var fileList = ModelManager.FileLinkService.GetFileLinkList(kundenmaschine.UID);
			var notesList = ModelManager.NotesService.GetNotesList(kundenmaschine.Key, kundenmaschine.LinkTypeId);
			var softwareList = ModelManager.SoftwareService.GetMachinesSoftware(kundenmaschine);
			if (fileList == null && notesList.Count == 0 && appointmentList.Count == 0 && softwareList.Count == 0)
			{
				KundenmaschineDeleting(this, new KundenmaschineDeletingEventArgs(kundenmaschine));
				DataManager.MachineDataService.DeleteKundenMaschineRows(kundenmaschine.UID);
			}
			else
			{
				var msg = $"Die Maschine kann nicht gelöscht werden, weil es noch verknüpfte Dateien, Notizen oder Software gibt.";
				throw new OperationCanceledException(msg);
			}
		}

		#endregion KUNDENMASCHINEN

		#region MASCHINENWARTUNG

		public SortableBindingList<Wartungsvorschlag> CreateWartungsplanungTable()
		{
			var list = this.GetWartungsmaschinenListe();
			var returnList = new SortableBindingList<Wartungsvorschlag>();
			foreach (var item in list)
			{
				// Maschine und die damit verknüpften Termine ermitteln. Es werden nur
				// Wartungs- und Servicetermine in der Vergangenheit berücksichtigt!
				var machine = RepoManager.KundenmaschinenRepository.GetKundenmaschine(item.UID);
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
		/// Gibt eine Liste aller Kundenmaschinen zurück, die zu einer normalerweise
		/// gewarteten Serie gehören.
		/// </summary>
		/// <returns></returns>
		IEnumerable<dsMachines.KundenmaschinenListeRow> GetWartungsmaschinenListe() 
			=> this.GetKundenmaschinenSearchList().Where(m => m.Wartungskennzeichen == 1);

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

		#region MASCHINENAUFTRÄGE

		/// <summary>
		/// <seealso cref="SortableBindingList{T}"/> mit allen
		/// <seealso cref="Maschinenauftrag"/> Instanzen des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<Maschinenauftrag> GetMaschinenauftragListe()
		{
			if (this.myMaschinenauftragListe == null)
			{
				this.myMaschinenauftragListe = new SortableBindingList<Maschinenauftrag>();
				foreach (var aRow in DataManager.MachineDataService.GetMaschinenauftragTabelle())
				{
					var auftrag = new Maschinenauftrag(aRow);
					this.myMaschinenauftragListe.Add(auftrag);
				}
			}
			return this.myMaschinenauftragListe;
		}

		/// <summary>
		/// Gibt die Liste der aktiven (Maschine noch nicht ausgeliefert) Maschinenaufträge zurück.
		/// </summary>
		/// <returns>
		/// Gibt eine <seealso cref="SortableBindingList{T}"/> zurück. T ist vom Typ <seealso cref="Maschinenauftrag"/>.
		/// </returns>
		public SortableBindingList<Maschinenauftrag> GetMaschinenauftragAktivListe()
		{
			var list = this.GetMaschinenauftragListe().Where(m => m.AuftragErledigtFlag == false);
			return new SortableBindingList<Maschinenauftrag>(list);
		}

		/// <summary>
		/// Gibt den Maschinenauftrag für die Maschine mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="machinePK">
		/// Primärschlüssel (GUID) der Maschine des gesuchten Maschinenauftrags.
		/// </param>
		/// <returns></returns>
		public Maschinenauftrag GetMaschinenauftrag(string machinePK) 
			=> this.GetMaschinenauftragListe().FirstOrDefault(a => a.MaschinenId == machinePK);

		/// <summary>
		/// Erzeugt einen neuen Maschinenauftrag für den angegebenen Kunden und das
		/// angegebene Maschinenmodell.
		/// </summary>
		/// <param name="kunde">Der Auftragskunde.</param>
		/// <param name="maschinenmodell">Der Primärschlüssel des Maschinenmodells.</param>
		/// <returns></returns>
		public Maschinenauftrag AddMaschinenauftrag(Kunde kunde, Maschinenmodell maschinenmodell)
		{
			// Kundenmaschine anlegen
			var creatingUser = ModelManager.UserService.CurrentUser;
			var newMachine = ModelManager.MachineCreatorService.CreateKundenmaschine(kunde, maschinenmodell, creatingUser, string.Empty);

			// Maschinenauftrag
			var auftragRow = DataManager.MachineDataService.CreateMaschinenauftragRow(newMachine.UID);
			var newAuftrag = new Maschinenauftrag(auftragRow);
			this.GetMaschinenauftragListe().Add(newAuftrag);
			return newAuftrag;
		}

		public Maschinenauftrag AddMaschinenauftrag(Kundenmaschine kundenMaschine)
		{
			var mRow = DataManager.MachineDataService.CreateMaschinenauftragRow(kundenMaschine.UID);
			if (mRow != null)
			{
				var newAuftrag = new Maschinenauftrag(mRow);
				this.GetMaschinenauftragListe().Add(newAuftrag);
				return newAuftrag;
			}
			return null;
		}

		#endregion MASCHINENAUFTRÄGE

		/// <summary>
		/// Speichert Änderungen an den Maschinen des angegebenen Kunden in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateMachines() => DataManager.MachineDataService.UpdateKundenMaschinen();

		#endregion PUBLIC PROCEDURES
	}

	#region SUB CLASSES

	public class KundenmaschineDeletingEventArgs : EventArgs
	{
		#region MEMBERS

		public readonly Kundenmaschine DeletedMachine;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="KundenmaschineDeletingEventArgs"/> Klasse.
		/// </summary>
		/// <param name="kundenmaschine">Die gelöschte <seealso cref="Kundenmaschine"/>.</param>
		public KundenmaschineDeletingEventArgs(Kundenmaschine kundenmaschine)
		{
			this.DeletedMachine = kundenmaschine;
		}

		#endregion ### .ctor ###
	}

	public class KundenmaschineMovedEventArgs : EventArgs
	{
		#region MEMBERS

		public readonly Kundenmaschine MovedMachine;
		public readonly Kunde FromCustomer;
		public readonly Kunde ToCustomer;

		#endregion MEMBERS

		#region ### .ctor ###

		public KundenmaschineMovedEventArgs(Kundenmaschine kundenmaschine, Kunde quellKunde, Kunde zielKunde)
		{
			this.MovedMachine = kundenmaschine;
			this.FromCustomer = quellKunde;
			this.ToCustomer = zielKunde;
		}

		#endregion ### .ctor ###
	}

	public class Wartungsvorschlag
	{
		#region PUBLIC PROPERTIES

		public Kundenmaschine Maschine { get; set; }

		public string Maschinenname => this.Maschine.Maschinenmodell.Modellbezeichnung;

		public Kunde Kunde => ModelManager.CustomerService.GetKunde(this.Maschine.Kundennummer, false);

		public string Kundennummer => this.Kunde.KundenNrCpm;

		public string Kundenname => this.Kunde.Matchcode;

		public string Postleitzahl => this.Kunde.ZipCode;

		public DateTime LetzteWartung { get; set; }

		public DateTime Terminvorschlag { get; set; }

		#endregion PUBLIC PROPERTIES
	}

	#endregion SUB CLASSES
}