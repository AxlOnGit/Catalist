using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Common.Collections;
using Products.Data;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSharedTableAdapters;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class SoftwareService
	{
		#region members

		readonly dsSoftware myDS = new dsSoftware();
		readonly List<Kundensoftware> myKundensoftwareList = new List<Kundensoftware>();
		SortableBindingList<Software> mySoftwareList;
		SortableBindingList<SoftwareUpgrade> mySoftwareUpgradeList;

		#endregion members

		#region PUBLIC PROCEDURES

		#region SOFTWARE

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

		#endregion SOFTWARE

		#region KUNDENSOFTWARE

		/// <summary>
		/// Erstellt eine neue Software für den angegebenen Kunden und optional die
		/// angegebene Kundenmaschine.
		/// </summary>
		/// <param name="kunde">Der Kunde, für den die neue Software erfasst wird.</param>
		/// <param name="kundenmaschine">
		/// Optional, die Kundenmaschine, der die neue Software zugeordnet werden soll.
		/// </param>
		/// <returns></returns>
		public Kundensoftware AddKundenSoftware(Kunde kunde, Kundenmaschine kundenmaschine = null)
		{
			string machinePK = "";
			if (kundenmaschine != null)
			{
				machinePK = kundenmaschine.UID;
			}
			var sRow = DataManager.SoftwareDataService.AddKundenSoftwareRow(kunde.CustomerId, machinePK);
			var sw = new Kundensoftware(sRow, kunde, kundenmaschine);
			this.myKundensoftwareList.Add(sw);

			return sw;
		}

		/// <summary>
		/// Gibt die Kundensoftware mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="kunde">Der Kunde, dem die Software zugeordnet ist.</param>
		/// <param name="softwarePK">Der Primärschlüssel der Kundensoftware.</param>
		/// <returns></returns>
		public Kundensoftware GetKundenSoftware(Kunde kunde, string softwarePK)
		{
			if (kunde == null || string.IsNullOrEmpty(softwarePK))
			{
				var msg = $"Parameter {nameof(kunde)} darf nicht Null sein.";
				throw new ArgumentNullException(msg, nameof(kunde));
			}
			return this.GetCustomersSoftware(kunde).FirstOrDefault(s => s.UID == softwarePK);
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der Kundensoftware des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public SortableBindingList<Kundensoftware> GetCustomersSoftware(Kunde kunde)
		{
			var list = new SortableBindingList<Kundensoftware>();
			foreach (dsSoftware.KundenSoftwareRow sRow in DataManager.SoftwareDataService.GetCustomerSoftwareRows(kunde.CustomerId))
			{
				var sw = this.myKundensoftwareList.FirstOrDefault(s => s.UID == sRow.UID);
				if (sw == null)
				{
					sw = new Kundensoftware(sRow, kunde);
					this.myKundensoftwareList.Add(sw);
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
			var list = new SBList<Kundensoftware>();
			foreach (dsSoftware.KundenSoftwareRow sRow in DataManager.SoftwareDataService.GetMachineSoftwareRows(machine.UID))
			{
				var sw = this.myKundensoftwareList.FirstOrDefault(s => s.UID == sRow.UID);
				if (sw == null)
				{
					sw = new Kundensoftware(sRow, machine.CurrentOwner, machine);
					this.myKundensoftwareList.Add(sw);
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
			if (this.myKundensoftwareList.Contains(software)) this.myKundensoftwareList.Remove(software);
			DataManager.SoftwareDataService.DeleteKundenSoftwareRow(software.UID);
		}

		/// <summary>
		/// Speichert neue, geänderte und gelöschte Daten in der Datenbank.
		/// </summary>
		public void UpdateKundenSoftware()
		{
			DataManager.SoftwareDataService.UpdateKundenSoftware();
		}

		/// <summary>
		/// Transferiert die einer Kundenmaschine zugeordnete Software zu einem anderen Kunden.
		/// </summary>
		/// <param name="kundenmaschine"></param>
		/// <param name="zielKunde"></param>
		/// <remarks>
		/// Letztlich wird dabei lediglich das Feld Kundennummer in Tabelle
		/// cpm_kundensoftware aktualisiert. Feld KundenMaschinenId bleibt unverändert, da
		/// die Software derselben Maschine zugeordnet bleibt.
		/// </remarks>
		internal void TransferSoftware(Kundenmaschine kundenmaschine, Kunde zielKunde)
		{
			var list = this.GetMachinesSoftware(kundenmaschine);
			if (list == null || list.Count == 0) return;
			foreach (var software in list)
			{
				software.Kundennummer = zielKunde.CustomerId;
			}
			this.UpdateKundenSoftware();
		}

		#endregion KUNDENSOFTWARE

		#region SOFTWARE-UPGRADES

		/// <summary>
		/// Gibt eine <seealso cref="SortableBindingList{T}"/> mit allen SoftwareUpgrade
		/// Elementen des Systems zurück. T ist vom Typ <seealso cref="SoftwareUpgrade"/>.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<SoftwareUpgrade> GetSoftwareUpgradeList()
		{
			if (this.mySoftwareUpgradeList == null)
			{
				this.mySoftwareUpgradeList = new SortableBindingList<SoftwareUpgrade>();
				foreach (var uRow in DataManager.SoftwareDataService.GetSoftwareUpgradeTable())
				{
					var upgrade = new SoftwareUpgrade(uRow);
					this.mySoftwareUpgradeList.Add(upgrade);
				}
			}
			return this.mySoftwareUpgradeList;
		}

		/// <summary>
		/// Erstellt ein neues <seealso cref="SoftwareUpgrade"/> Element und gibt es zurück.
		/// </summary>
		/// <param name="kunde">Der Kunde, für den das Upgrade durchgeführt werden soll.</param>
		/// <param name="alteSoftware">
		/// Die <seealso cref="Kundensoftware"/>, die aktualisiert werden soll.
		/// </param>
		/// <returns></returns>
		public SoftwareUpgrade AddSoftwareUpgrade(Kunde kunde, Kundensoftware alteSoftware)
		{
			var kundenId = kunde.CustomerId;
			var oldSwId = alteSoftware.UID;
			var oldLicence = alteSoftware.Lizenzschluessel;
			var machineModell = alteSoftware.Maschine.Maschinenmodell.Modellbezeichnung;
			var sn = alteSoftware.Maschine.Seriennummer;
			var newRow = DataManager.SoftwareDataService.AddSoftwareUpgradeRow(kundenId, oldSwId, oldLicence, machineModell, sn);
			if (newRow != null)
			{
				var newUpgrade = new SoftwareUpgrade(newRow);
				this.GetSoftwareUpgradeList().Add(newUpgrade);
				return newUpgrade;
			}
			var msg = $"Es konnte keine neue Zeile für das Software-Upgrade in der Datenbank erzeugt werden.";
			throw new System.Data.DataException(msg);
		}

		/// <summary>
		/// Löscht eine <seealso cref="SoftwareUpgrade"/> Instanz endgültig.
		/// </summary>
		/// <param name="kunde">
		/// Der <seealso cref="Kunde"/>, dem das <seealso cref="SoftwareUpgrade"/>
		/// zugeordnet ist.
		/// </param>
		/// <param name="alteSoftware">
		/// Die <seealso cref="Kundensoftware"/>, die aktualisiert werden soll, bzw. sollte.
		/// </param>
		/// <returns></returns>
		public int DeleteSoftwareUpgrade(Kunde kunde, Kundensoftware alteSoftware)
		{
			var result = 0;

			// Das SoftwareUpgrade Element aus der internen Auflistung entfernen.
			var dItem = this.GetSoftwareUpgradeList().FirstOrDefault(u => u.Kundennummer == kunde.CustomerId & u.AlteVersionId == alteSoftware.UID);
			if (dItem == null)
			{
				var msg = $"Die Software mit dem Primärschlüssel '{kunde.CustomerId}' und '{alteSoftware.UID}' gibt es in dieser Liste nicht.";
				throw new ApplicationException(msg);
			}
			this.GetSoftwareUpgradeList().Remove(dItem);

			// Den zugrundeliegenden Datensatz aus der Datenbank löschen (cpm_softwareupgrade).
			result = DataManager.SoftwareDataService.DeleteSoftwareUpgradeRow(kunde.CustomerId, alteSoftware.UID);

			return result;
		}

		/// <summary>
		/// Speichert alle neuen, geänderten und gelöschten SoftwareUpgrade Datensätze.
		/// </summary>
		public void UpdateSoftwareUpgrades()
		{
			DataManager.SoftwareDataService.UpdateSoftwareUpgrades();
		}

		#endregion SOFTWARE-UPGRADES

		#endregion PUBLIC PROCEDURES
	}
}