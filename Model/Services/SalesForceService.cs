using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common.Collections;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class SalesForceService
	{

		#region members

		SBList<Tour> myTourList = null;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SalesService Klasse.
		/// </summary>
		public SalesForceService()
		{
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt der angebenen Tour den angegebenen Kunden hinzu.
		/// </summary>
		/// <param name="tour">Die Tour, der der angegebene Kunde hinzugefügt werden soll.</param>
		/// <param name="kunde">Der Kunde, der der angegebenen Tour hinzugefügt werden soll.</param>
		/// <returns></returns>
		public int AddTourKunde(Tour tour, Kunde kunde)
		{
			int result = 0;
			dsSalesForce.TourKundeXrefRow xkRow = DataManager.SalesForceDataService.AddTourKundeXrefRow(tour.UID, kunde.CustomerId, ModelManager.UserService.CurrentUser.UID);
			if (xkRow != null) result = 1;

			return result;
		}

		/// <summary>
		/// Fügt der angegebenen Tour den angegebenen Interessenten hinzu.
		/// </summary>
		/// <param name="tour">Die Tour, der der angegebene Interessent hinzugefügt werden soll.</param>
		/// <param name="interessent">Der Interessent, der der angegebenen Tour hinzugefügt werden soll.</param>
		/// <returns></returns>
		public int AddTourInteressent(Tour tour, Interessent interessent)
		{
			int result = 0;
			dsSalesForce.TourInteressentXrefRow xiRow = DataManager.SalesForceDataService.AddTourInteressentXrefRow(tour.UID, interessent.UID, ModelManager.UserService.CurrentUser.UID);
			if (xiRow != null) result = 1;

			return result;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Vertretertouren des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<Tour> GetTourList()
		{
			if (this.myTourList == null)
			{
				this.myTourList = new SBList<Tour>();
				foreach (var tRow in DataManager.SalesForceDataService.GetTourTable())
				{
					this.myTourList.Add(new Tour(tRow));
				}
			}
			return this.myTourList;
		}

		/// <summary>
		/// Gibt eine Liste der Interessenten für die angegebene Tour zurück.
		/// </summary>
		/// <param name="tour"></param>
		/// <returns></returns>
		public SBList<Interessent> GetInteressentenPerTour(Tour tour)
		{
			IEnumerable<dsSalesForce.TourInteressentXrefRow> xiRows = DataManager.SalesForceDataService.GetTourInteressentXrefListByTour(tour.UID);
			if (xiRows != null)
			{
				SBList<Interessent> list = new SBList<Interessent>();
				foreach (var xiRow in xiRows)
				{
					list.Add(ModelManager.ProspectService.GetInteressent(xiRow.InteressentId));
				}
				return list;
			}
			return null;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Kunden für die angegebene Tour zurück.
		/// </summary>
		/// <param name="tour"></param>
		/// <returns></returns>
		public SBList<Kunde> GetKundenPerTour(Tour tour)
		{
			IEnumerable<dsSalesForce.TourKundeXrefRow> xkRows = DataManager.SalesForceDataService.GetTourKundeXrefListByTour(tour.UID);
			if (xkRows != null)
			{
				SBList<Kunde> list = new SBList<Kunde>();
				foreach (var xkRow in xkRows)
				{
					list.Add(ModelManager.CustomerService.GetKunde(xkRow.Kundennummer, false));
				}
				return list;
			}
			return null;
		}

		/// <summary>
		/// Entfernt den Kunden mit der angegebenen Kundennummer aus der Tour mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <param name="tourPK"></param>
		/// <returns></returns>
		public int RemoveKundeFromTour(string kundePK, string tourPK)
		{
			return DataManager.SalesForceDataService.RemoveKundeFromTour(kundePK, tourPK);
		}

		#endregion

	}
}
