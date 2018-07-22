using Products.Common;
using Products.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Products.Model.Repos
{
	public class KundenmaschinenRepo
	{
		#region MEMBERS

		SortableBindingList<Kundenmaschine> myKundenmaschineList;
		readonly Dictionary<Kunde, SortableBindingList<Kundenmaschine>> myKundenmaschinenDictionary = new Dictionary<Kunde, SortableBindingList<Kundenmaschine>>();
		readonly Dictionary<string, Dictionary<DateTime, Kunde>> myMachineOwnerDictionary = new Dictionary<string, Dictionary<DateTime, Kunde>>();

		#endregion MEMBERS

		#region ### .ctor ###

		public KundenmaschinenRepo()
		{
			ModelManager.MachineCreatorService.KundenmaschineCreatedEvent += MachineCreatorService_KundenmaschineCreatedEvent;
			ModelManager.MachineService.KundenmaschineDeleting += MachineService_KundenmaschineDeleting;
			ModelManager.MachineService.KundenmaschineMoved += MachineService_KundenmaschineMoving;
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void MachineCreatorService_KundenmaschineCreatedEvent(object sender, Services.MachineCreatorService.KundenmaschineCreatedEventArgs e)
		{
			// Die neu erstellte Maschine an die Kunden- und Gesamtliste anfügen.
			var kunde = e.CreatedMachine.CurrentOwner;
			if (kunde != null)
			{
				this.GetKundenmaschinenList(kunde).Add(e.CreatedMachine);
			}
			this.GetKundenmaschinenList().Add(e.CreatedMachine);
		}

		void MachineService_KundenmaschineDeleting(object sender, Services.KundenmaschineDeletingEventArgs e)
		{
			// Die gelöschte Maschine aus der Kunden- und der Gesamtliste entfernen!
			var kunde = e.DeletedMachine.CurrentOwner;
			if (kunde != null && this.myKundenmaschinenDictionary.ContainsKey(kunde)) this.myKundenmaschinenDictionary[kunde].Remove(e.DeletedMachine);
			this.GetKundenmaschinenList().Remove(e.DeletedMachine);
		}

		void MachineService_KundenmaschineMoving(object sender, Services.KundenmaschineMovedEventArgs e)
		{
			if (this.myKundenmaschinenDictionary.ContainsKey(e.FromCustomer) && this.myKundenmaschinenDictionary[e.FromCustomer].Contains(e.MovedMachine))
				this.myKundenmaschinenDictionary[e.FromCustomer].Remove(e.MovedMachine);
			this.GetKundenmaschinenList(e.ToCustomer).Add(e.MovedMachine);
		}

		#endregion EVENT HANDLER

		#region PUBLIC/INTERNAL PROCEDURES

		/// <summary>
		/// Gibt
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<Kundenmaschine> GetKundenmaschinenList()
		{
			if (this.myKundenmaschineList == null)
			{
				this.myKundenmaschineList = new SortableBindingList<Kundenmaschine>();
				foreach (var kRow in Data.DataManager.MachineDataService.GetKundenmaschineTable())
				{
					this.myKundenmaschineList.Add(new Kundenmaschine(kRow));
				}
			}
			return this.myKundenmaschineList;
		}

		/// <summary>
		/// Gibt eine Liste der <seealso cref="Kundenmaschine"/> des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kunde, dessen Maschinen gesucht werden.</param>
		/// <returns></returns>
		public SortableBindingList<Kundenmaschine> GetKundenmaschinenList(Kunde kunde)
		{
			if (this.myKundenmaschinenDictionary.ContainsKey(kunde)) return this.myKundenmaschinenDictionary[kunde];

			var list = new SortableBindingList<Kundenmaschine>(this.GetKundenmaschinenList().Where(m => m.CurrentOwner == kunde));
			this.myKundenmaschinenDictionary.Add(kunde, list);
			return list;
		}

		/// <summary>
		/// Gibt eine Liste der <seealso cref="Kundenmaschine"/> des angegebenen
		/// Maschinenmodells zurück.
		/// </summary>
		/// <param name="modell"></param>
		/// <returns></returns>
		public SortableBindingList<Kundenmaschine> GetKundenmaschinenList(Maschinenmodell modell)
		{
			return new SortableBindingList<Kundenmaschine>(this.GetKundenmaschinenList().Where(m => m.MaschinenmodellId == modell.UID));
		}

		/// <summary>
		/// Gibt eine Liste der <seealso cref="Kundenmaschine"/> der angegebenen
		/// Maschinenserie zurück.
		/// </summary>
		/// <param name="serie"></param>
		/// <returns></returns>
		public SortableBindingList<Kundenmaschine> GetKundenmaschinenList(Maschinenserie serie)
		{
			return new SortableBindingList<Kundenmaschine>(this.GetKundenmaschinenList().Where(m => m.MaschinenserieId == serie.UID));
		}

		/// <summary>
		/// Gibt die <seealso cref="Kundenmaschine"/> mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="kundenmaschinePK"></param>
		/// <returns></returns>
		internal Kundenmaschine GetKundenmaschine(string kundenmaschinePK)
		{
			return this.GetKundenmaschinenList().FirstOrDefault(k => k.UID == kundenmaschinePK);
		}

		internal Dictionary<DateTime, Kunde> GetOwnerDictionary(string kundenmaschinePK)
		{
			if (this.myMachineOwnerDictionary.ContainsKey(kundenmaschinePK)) return this.myMachineOwnerDictionary[kundenmaschinePK];
			return this.CreateOwnerDictionary(kundenmaschinePK);
		}

		#endregion PUBLIC/INTERNAL PROCEDURES

		#region PRIVATE PROCEDURES

		Dictionary<DateTime, Kunde> CreateOwnerDictionary(string kundenmaschinePK)
		{
			//try
			//{
			var dictionary = new Dictionary<DateTime, Kunde>();
			foreach (var xRow in Data.DataManager.MachineDataService.GetKundenMaschineXrefRows(kundenmaschinePK))
			{
				var kunde = ModelManager.CustomerService.GetKunde(xRow.Kundennummer, false);
				dictionary.Add(xRow.Zuordnungsende, kunde);
			}
			// Wichtig: Das neue Dictionary zur internen Auflistung für den späteren
			//          Zugriff speichern.
			this.myMachineOwnerDictionary.Add(kundenmaschinePK, dictionary);
			return dictionary;
		}

		#endregion PRIVATE PROCEDURES
	}
}