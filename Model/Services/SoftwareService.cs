using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSharedTableAdapters;
using Products.Model.Entities;
using Products.Common;
using Products.Common.Collections;

namespace Products.Model.Services
{
	public class SoftwareService
	{

		#region members

		readonly dsSoftware myDS = new Data.Datasets.dsSoftware();
		readonly List<Kundensoftware> mySoftwareCache = new List<Kundensoftware>();
		SortableBindingList<Software> mySoftwareList;

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		#region Software

		public SortableBindingList<Software> GetSoftwareList()
		{
			if (this.mySoftwareList == null)
			{
				this.mySoftwareList = new SortableBindingList<Software>();
				foreach (var sRow in DataManager.SoftwareDataService.GetSoftwareTable())
				{
					this.mySoftwareList.Add(new Software(sRow));
				}
			}
			return this.mySoftwareList;
		}

		/// <summary>
		/// Gibt die Software mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="softwarePK"></param>
		/// <returns></returns>
		public Software GetSoftware(string softwarePK)
		{
			return this.GetSoftwareList().FirstOrDefault(s => s.UID == softwarePK);
		}

		public void UpdateSoftware()
		{
			DataManager.SoftwareDataService.UpdateSoftware();
		}

		#endregion

		#region Kundensoftware

		#endregion
		/// <summary>
		/// Erstellt eine neue Software für den angegebenen Kunden und optional die angegebene Kundenmaschine.
		/// </summary>
		/// <param name="kunde">Der Kunde, für den die neue Software erfasst wird.</param>
		/// <param name="kundenmaschine">Optional, die Kundenmaschine, der die neue Software zugeordnet werden soll.</param>
		/// <returns></returns>
		public Kundensoftware AddKundenSoftware(Kunde kunde, Kundenmaschine kundenmaschine = null)
		{
			string machinePK = "";
			if(kundenmaschine != null) 
			{
				machinePK = kundenmaschine.UID;
			}
			var sRow = DataManager.SoftwareDataService.AddKundenSoftwareRow(kunde.CustomerId, machinePK);
			var sw = new Kundensoftware(sRow, kunde, kundenmaschine);
			this.mySoftwareCache.Add(sw);

			return sw;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der Kundensoftware des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public SortableBindingList<Kundensoftware> GetCustomersSoftware(Kunde kunde)
		{
			SortableBindingList<Kundensoftware> list = new SortableBindingList<Kundensoftware>();
			foreach (dsSoftware.KundenSoftwareRow sRow in DataManager.SoftwareDataService.GetCustomerSoftwareRows(kunde.CustomerId)) 
			{
				var sw = this.mySoftwareCache.FirstOrDefault(s => s.UID == sRow.UID);
				if (sw == null)
				{
					sw = new Kundensoftware(sRow, kunde);
					this.mySoftwareCache.Add(sw);
				}
				list.Add(sw);
			}
			return list;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der Software für die angegebene Maschine zurück.
		/// </summary>
		/// <param name="machine">Die Maschine, der die Software zugeordnet ist.</param>
		/// <returns></returns>
		public SBList<Kundensoftware> GetMachinesSoftware(Kundenmaschine machine)
		{
			SBList<Kundensoftware> list = new SBList<Kundensoftware>();
			foreach (dsSoftware.KundenSoftwareRow sRow in DataManager.SoftwareDataService.GetMachineSoftwareRows(machine.UID))
			{
				var sw = this.mySoftwareCache.FirstOrDefault(s => s.UID == sRow.UID);
				if (sw == null)
				{
					sw = new Kundensoftware(sRow, machine.CurrentOwner, machine);
					this.mySoftwareCache.Add(sw);
				}
				list.Add(sw);
			}
			return list;
		}

		/// <summary>
		/// Löscht die angegebene Kundensoftware.
		/// </summary>
		/// <param name="software"></param>
		public void DeleteKundenSoftware(Kundensoftware software)
		{
			if (this.mySoftwareCache.Contains(software)) this.mySoftwareCache.Remove(software);
			DataManager.SoftwareDataService.DeleteKundenSoftwareRow(software.UID);
		}

		/// <summary>
		/// Speichert neue, geänderte und gelöschte Daten in der Datenbank.
		/// </summary>
		public void UpdateKundenSoftware()
		{
			DataManager.SoftwareDataService.UpdateKundenSoftware();
		}

		#endregion

		#region private procedures
		#endregion

	}
}
