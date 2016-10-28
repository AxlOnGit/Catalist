using System;
using System.Collections.Generic;
using Products.Common;
using Products.Common.Geocoding;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class CustomerService
	{
		#region EVENTS

		public event EventHandler CurrentCustomerSet;

		#endregion EVENTS

		#region CONSTANTS

		const string cpmPrimaryKey = "1000000000";

		#endregion CONSTANTS

		#region MEMBERS

		Dictionary<string, Kunde> myCustomerDictionary;
		Kunde myCurrentCustomer;

		#endregion MEMBERS

		#region ### .ctor ###

		public CustomerService()
		{
			this.myCurrentCustomer = this.GetKunde(cpmPrimaryKey, true);
		}

		#endregion ### .ctor ###

		#region PUBLIC PROPERTIES

		public Kunde CurrentCustomer
		{
			get
			{
				return this.myCurrentCustomer;
			}
			set
			{
				this.myCurrentCustomer = value;
				this.CurrentCustomerSet?.Invoke(this, new EventArgs());
			}
		}

		#endregion PUBLIC PROPERTIES

		#region PUBLIC PROCEDURES

		#region Kundensuche

		/// <summary>
		/// Gibt eine sortierbare Liste mit Suchergebnissen der Kundensuche zurück.
		/// </summary>
		/// <param name="searchFor">Suchzeichenfolge.</param>
		/// <returns>Eine <seealso cref="SortableBindingList"/> Instanz.</returns>
		public SortableBindingList<Suchkunde> GetKundenSucheResults(string searchFor)
		{
			var sTable = DataManager.CustomerDataService.SearchCustomer(searchFor);
			if (sTable != null && sTable.Count > 0)
			{
				var list = new SortableBindingList<Suchkunde>();
				foreach (var fund in sTable)
				{
					list.Add(new Suchkunde(fund));
				}
				return list;
			}
			return null;
		}

		#endregion Kundensuche

		/// <summary>
		/// Gibt eine neue dsCustomer.KundeRow Instanz zurück.
		/// </summary>
		/// <param name="kunde">Kunde, für den die neue Instanz erstellt wird.</param>
		/// <returns></returns>
		public dsCustomer.KundeRow AddKunde(Kunde kunde)
		{
			return DataManager.CustomerDataService.AddKundeRow(kunde.CustomerId);
		}

		/// <summary>
		/// Gibt den Kunden mit dem angegebenen Primärschlüssel (Kundennummer) zurück.
		/// </summary>
		/// <param name="kundePK">Kundennummer des gesuchten Kunden.</param>
		/// <returns>
		/// Eine <seealso cref="Kunde"/> Instanz oder null, wenn es diese Kundennummer nicht gibt.
		/// </returns>
		public Kunde GetKunde(string kundePK, bool setAsCurrent)
		{
			Kunde result = null;
			if (this.myCustomerDictionary == null)
			{
				var kunde = new Kunde(DataManager.CustomerDataService.GetCustomerRow(kundePK));
				if (kunde != null)
				{
					this.myCustomerDictionary = new Dictionary<string, Kunde>();
					this.myCustomerDictionary.Add(kundePK, kunde);
					if (kunde.Adresskoordinaten == null) this.GetAdresskoordinaten(kunde);
					result = kunde;
				}
			}
			else
			{
				if (this.myCustomerDictionary.ContainsKey(kundePK))
				{
					result = this.myCustomerDictionary[kundePK];
				}
				else
				{
					var kunde = new Kunde(DataManager.CustomerDataService.GetCustomerRow(kundePK));
					this.myCustomerDictionary.Add(kundePK, kunde);
					if (kunde.Adresskoordinaten == null) this.GetAdresskoordinaten(kunde);
					result = kunde;
				}
			}
			if (result != null && setAsCurrent) this.CurrentCustomer = result;
			return result;
		}

		internal void GetAdresskoordinaten(Kunde kunde)
		{
			try
			{
				var adresse = string.Format("{0}, {1} {2}", kunde.Street, kunde.ZipCode, kunde.City);
				var coords = GeoData.GetAddressCoordinates(kunde.Matchcode, adresse);
				if (coords != null)
				{
					DataManager.CustomerDataService.SetAddressCoordinates(kunde.CustomerId, coords.Latitude, coords.Longitude);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gibt eine Liste aller Kunden einer Vertretertour zurück.
		/// </summary>
		/// <param name="tourPK"></param>
		/// <returns></returns>
		public SortableBindingList<Kunde> GetKundeListByTour(string tourPK)
		{
			var rowList = DataManager.SalesForceDataService.GetTourKundeXrefListByTour(tourPK);
			if (rowList != null)
			{
				var list = new SortableBindingList<Kunde>();
				foreach (var xRow in rowList)
				{
					list.Add(this.GetKunde(xRow.Kundennummer, false));
				}
				return list;
			}
			return null;
		}

		/// <summary>
		/// Überträgt Änderungen an der Tabelle Kunden in die Datenbank.
		/// </summary>
		public void UpdateKunden()
		{
			DataManager.CustomerDataService.UpdateKundeTabelle();
		}

		#endregion PUBLIC PROCEDURES
	}
}