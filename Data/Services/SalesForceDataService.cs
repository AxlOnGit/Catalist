using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSalesForceTableAdapters;

namespace Products.Data.Services
{
	public class SalesForceDataService
	{

		#region members

		readonly string myCurrentUserPK;

		readonly dsSalesForce mySalesDS = new dsSalesForce();

		#region Adapter

		taTour myTourAdapter;
		taTourKundeXref myTourKundeAdapter;
		taTourInteressentXref myTourProspectAdapter;

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SalesDataService Klasse.
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		/// </summary>
		public SalesForceDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt eine neue TourKundeXrefRow für die angegebene Tour und den angegebenen Kunden.
		/// </summary>
		/// <param name="tourId">Primärschlüssel der Tour.</param>
		/// <param name="kundePK">Kundennummer des Kunden.</param>
		/// <param name="creatorPK">Primärschlüssel des Benutzers, der die neue TourKundeXrefRow erstellt.</param>
		/// <returns></returns>
		public dsSalesForce.TourKundeXrefRow AddTourKundeXrefRow(string tourId, string kundePK, string creatorPK)
		{
			this.AssureTourKundeXrefInitialized();
			var xRow = this.mySalesDS.TourKundeXref.NewTourKundeXrefRow();
			xRow.TourId = tourId;
			xRow.Kundennummer = kundePK;
			xRow.ErstelltAm = DateTime.Now;
			xRow.AktualisiertAm = xRow.ErstelltAm;
			xRow.ErstelltVon = creatorPK;
			xRow.AktualisiertVon = xRow.ErstelltVon;
			this.mySalesDS.TourKundeXref.AddTourKundeXrefRow(xRow);
			this.UpdateTourKundeXref(xRow);

			return xRow;
		}

		public dsSalesForce.TourInteressentXrefRow AddTourInteressentXrefRow(string tourId, string interessentPK, string creatorPK)
		{
			var xRow = this.mySalesDS.TourInteressentXref.NewTourInteressentXrefRow();
			xRow.TourId = tourId;
			xRow.InteressentId = interessentPK;
			xRow.AktualisiertAm = DateTime.Now;
			xRow.AktualisiertVon = creatorPK;
			xRow.ErstelltAm = xRow.AktualisiertAm;
			xRow.ErstelltVon = xRow.AktualisiertVon;
			this.mySalesDS.TourInteressentXref.AddTourInteressentXrefRow(xRow);
			this.UpdateTourInteressentXref(xRow);

			return xRow;
		}

		/// <summary>
		/// Gibt die Tabelle Tour mit allen Vertretertouren des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsSalesForce.TourDataTable GetTourTable()
		{
			this.AssureTourInitialized();
			return this.mySalesDS.Tour;
		}

		/// <summary>
		/// Gibt die Tabelle TourInteressentXref zurück.
		/// </summary>
		/// <returns></returns>
		public dsSalesForce.TourInteressentXrefDataTable GetTourInteressentXrefTable()
		{
			this.AssureTourInteressentXrefInitialized();
			return this.mySalesDS.TourInteressentXref;
		}

		/// <summary>
		/// Gibt alle TourInteressentXrefs mit der angegebenen TourId zurück.
		/// </summary>
		/// <param name="tourPK"></param>
		/// <returns></returns>
		public IEnumerable<dsSalesForce.TourInteressentXrefRow> GetTourInteressentXrefListByTour(string tourPK)
		{
			this.AssureTourInteressentXrefInitialized();
			return this.mySalesDS.TourInteressentXref.Where(x => x.TourId == tourPK);
		}

		/// <summary>
		/// Gibt die Tabelle TourKundeXref zurück.
		/// </summary>
		/// <returns></returns>
		public dsSalesForce.TourKundeXrefDataTable GetTourKundeXrefTable()
		{
			this.AssureTourKundeXrefInitialized();
			return this.mySalesDS.TourKundeXref;
		}

		/// <summary>
		/// Gibt alle TourKundeXrefRows mit der angegebene TourId zurück.
		/// </summary>
		/// <param name="tourPK"></param>
		/// <returns></returns>
		public IEnumerable<dsSalesForce.TourKundeXrefRow> GetTourKundeXrefListByTour(string tourPK)
		{
			this.AssureTourKundeXrefInitialized();
			return this.mySalesDS.TourKundeXref.Where(x => x.TourId == tourPK);
		}

		/// <summary>
		/// Löscht die TourKundeXrefRow für die angegebene Tour und den angegebenen Kunden.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <param name="tourPK"></param>
		/// <returns></returns>
		public int RemoveKundeFromTour(string kundePK, string tourPK)
		{
			var xRow = this.mySalesDS.TourKundeXref.FirstOrDefault(x => x.Kundennummer == kundePK && x.TourId == tourPK);
			if (xRow != null)
			{
				xRow.Delete();
				return this.UpdateTourKundeXref(xRow);
			}
			return 0;
		}

		/// <summary>
		/// Aktualisiert die angegebene TourInteressentXrefRow oder die gesamte Tabelle, falls keine TourInteressentXrefRow übergeben wird.
		/// </summary>
		/// <param name="xRefRow"></param>
		/// <returns></returns>
		public int UpdateTourInteressentXref(dsSalesForce.TourInteressentXrefRow xRefRow = null)
		{
			if (xRefRow != null)
			{
				return this.myTourProspectAdapter.Update(xRefRow);
			}
			else return this.myTourProspectAdapter.Update(this.mySalesDS.TourInteressentXref);
		}

		/// <summary>
		/// Aktualisiert die angegebene TourKundeXrefRow oder die gesamte Tabelle, falls keine TourKundeXrefRow übergeben wird.
		/// </summary>
		/// <param name="xRefRow"></param>
		/// <returns></returns>
		public int UpdateTourKundeXref(dsSalesForce.TourKundeXrefRow xRefRow = null)
		{
			if (xRefRow != null)
			{
				return this.myTourKundeAdapter.Update(xRefRow);
			}
			else return this.myTourKundeAdapter.Update(this.mySalesDS.TourKundeXref);
		}

		#endregion

		#region private procedures

		private void AssureTourInitialized()
		{
			if (this.myTourAdapter == null)
			{
				this.myTourAdapter = new taTour();
				this.myTourAdapter.Fill(this.mySalesDS.Tour);
			}
		}

		private void AssureTourInteressentXrefInitialized()
		{
			if (this.myTourProspectAdapter == null)
			{
				this.myTourProspectAdapter = new taTourInteressentXref();
				this.myTourProspectAdapter.Fill(this.mySalesDS.TourInteressentXref);
			}
		}

		private void AssureTourKundeXrefInitialized()
		{
			if (this.myTourKundeAdapter == null)
			{
				this.myTourKundeAdapter = new taTourKundeXref();
				this.myTourKundeAdapter.Fill(this.mySalesDS.TourKundeXref);
			}
		}

		#endregion

	}
}
