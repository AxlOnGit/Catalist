using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets.dsAppointmentsTableAdapters;
using Products.Data.Datasets;

namespace Products.Data.Services
{
	public class AppointmentDataService
	{

		#region members

		string myCurrentUserPK;

		#region Adapter

		readonly taAppointmentXref myAppointmentXrefAdapter = new taAppointmentXref();
		readonly taAppointmentLinkXref myAppointmentLinkXrefAdapter = new taAppointmentLinkXref();
		readonly taAppointmentType myAppointmentTypeAdapter = new taAppointmentType();
		readonly taLocation myLocationAdapter = new taLocation();

		#endregion

		#region Data Store

		readonly dsAppointments myDS = new dsAppointments();

		#endregion

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der AppointmentDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public AppointmentDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		public void AddLinkXrefRow(string fullName, string linkedItemPK, string linkedItemTypePK)
		{
			var lRow = this.myDS.AppointmentLinkXref.NewAppointmentLinkXrefRow();
			lRow.FullName = fullName;
			lRow.LinkedItemId = linkedItemPK;
			lRow.LinkedItemTypeId = linkedItemTypePK;
			this.myDS.AppointmentLinkXref.AddAppointmentLinkXrefRow(lRow);

			this.myAppointmentLinkXrefAdapter.Update(lRow);
		}

		public void RemoveLinkedItem(string fullName, string linkedItemPK)
		{
			var linkXrefRow = this.myDS.AppointmentLinkXref.FirstOrDefault(l => l.FullName == fullName & l.LinkedItemId == linkedItemPK);
			if (linkXrefRow != null)
			{
				linkXrefRow.Delete();
				this.myAppointmentLinkXrefAdapter.Update(linkXrefRow);
			}
		}

		/// <summary>
		/// Erstellt eine neue AppointmentXrefRow.
		/// </summary>
		/// <param name="fileName">Dateiname zur David Kalenderdatei auf dem David-Server.</param>
		/// <param name="appointmentType">Der Typ des Termins.</param>
		/// <returns></returns>
		public dsAppointments.AppointmentXrefRow AddAppointmentXref(string fileName, string appointmentType)
		{
			var xRow = this.myDS.AppointmentXref.NewAppointmentXrefRow();
			xRow.AppointmentType = appointmentType;
			xRow.FullName = fileName;
			this.myDS.AppointmentXref.AddAppointmentXrefRow(xRow);
			this.myAppointmentXrefAdapter.Update(xRow);

			return xRow;
		}

		/// <summary>
		/// Gibt die AppointmentXrefRow für den angegebenen Kalendereintrag.
		/// </summary>
		/// <param name="fileName">Vollständiger Dateiname zum Kalendereintrag auf dem David-Server.</param>
		/// <returns></returns>
		public dsAppointments.AppointmentXrefRow GetXrefRow(string fileName)
		{
			var xRow = this.myDS.AppointmentXref.FindByFullName(fileName);

			if (xRow == null) xRow = this.CreateAppointmentXrefRow(fileName);
			return xRow;
		}

		/// <summary>
		/// Gibt eine Liste aller AppointmentLinkXrefRow Objekte für den angegebenen David Kalendereintrag zurück.
		/// </summary>
		/// <param name="fullName">Vollständiger Dateiname des David Kalendereintrags.</param>
		/// <returns></returns>
		public IEnumerable<dsAppointments.AppointmentLinkXrefRow> GetLinkXrefRowsForAppointment(string fullName)
		{
			return this.myDS.AppointmentLinkXref.Where(l => l.FullName == fullName);
		}

		/// <summary>
		/// Gibt eine Liste aller AppointmentLinkXrefRows für das angegebene LinkedItem zurück.
		/// </summary>
		/// <param name="linkedItemPK">Primärschlüssel des LinkedItems.</param>
		/// <returns></returns>
		public IEnumerable<dsAppointments.AppointmentLinkXrefRow> GetLinkXrefRowsForItem(string linkedItemPK)
		{
			return this.myDS.AppointmentLinkXref.Where(l => l.LinkedItemId == linkedItemPK);
		}

		/// <summary>
		/// Gibt die AppointmentTypeDataTable des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsAppointments.AppointmentTypeDataTable GetAppointmentTypeTable()
		{
			return this.myDS.AppointmentType;
		}

		/// <summary>
		/// Gibt die LocationDataTable des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsAppointments.LocationDataTable GetLocationTable()
		{
			return this.myDS.Location;
		}

		/// <summary>
		/// Aktualisiert alle neuen, geänderten und gelöschten AppointmentXrefRows, AppointmentTypeRows und LocationRows.
		/// </summary>
		/// <returns></returns>
		public int Update()
		{
			int result = 0;

			if (this.myDS.AppointmentXref.GetChanges() != null)
			{
				result = this.myAppointmentXrefAdapter.Update(this.myDS.AppointmentXref);
			}
			if (this.myDS.AppointmentLinkXref.GetChanges() != null)
			{
				result += this.myAppointmentLinkXrefAdapter.Update(this.myDS.AppointmentLinkXref);
			}
			if (this.myDS.AppointmentType.GetChanges() != null)
			{
				result += this.myAppointmentTypeAdapter.Update(this.myDS.AppointmentType);
			}
			if (this.myDS.Location.GetChanges() != null)
			{
				result += this.myLocationAdapter.Update(this.myDS.Location);
			}

			return result;
		}

		#endregion

		#region private procedures

		private void InitializeData()
		{
			this.myAppointmentXrefAdapter.Fill(this.myDS.AppointmentXref);
			this.myAppointmentLinkXrefAdapter.Fill(this.myDS.AppointmentLinkXref);
			this.myAppointmentTypeAdapter.Fill(this.myDS.AppointmentType);
			this.myLocationAdapter.Fill(this.myDS.Location);
		}

		private dsAppointments.AppointmentXrefRow CreateAppointmentXrefRow(string fileName, string appointmentType = "Undefiniert")
		{
			var xRow = this.myDS.AppointmentXref.NewAppointmentXrefRow();
			xRow.FullName = fileName;
			xRow.AppointmentType = appointmentType;
			this.myDS.AppointmentXref.AddAppointmentXrefRow(xRow);
			this.myAppointmentXrefAdapter.Update(xRow);

			return xRow;
		}

		#endregion

	}
}
