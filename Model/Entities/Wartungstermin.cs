using System;
using System.Linq;
using David;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Wartungstermin
	{
		#region MEMBERS

		readonly dsAppointments.WartungsterminRow myBase;
		Kunde myKunde;
		Kunde myReferenzKunde;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt den Primärschlüssel der Maschine dieses Service- oder Wartungstermins zurück.
		/// </summary>
		public string MaschinenId => this.myBase.MaschinenId;

		public string Maschinenname => this.myBase.Maschine;

		public int Wartungsintervall => this.myBase.Wartungsintervall;

		public string Kundenname => this.myBase.Firma;

		/// <summary>
		/// Gibt den Pfad zum David Kalendereintrag dieses Service- oder Wartungstermins zurück.
		/// </summary>
		public string FullName => this.myBase.Terminpfad;

		/// <summary>
		/// Gibt Datum und Uhrzeit des Wartungstermins zurück.
		/// </summary>
		public DateTime StartsAt => this.myBase.StartsAt;

		/// <summary>
		/// Gibt das berechnete nächste Wartungsdatum für die Maschine zurück.
		/// </summary>
		/// <returns></returns>
		public DateTime NextServiceDueAt()
		{
			return this.StartsAt.AddMonths(this.myBase.Wartungsintervall);
		}

		public DateTime Terminvorschlag => this.NextServiceDueAt();

		public string Postleitzahl => this.myBase.Postleitzahl;

		public string Ort => this.myBase.Ort;

		/// <summary>
		/// Gibt die Entfernung in Kilometern zwischen der Kundenadresse dieser Maschine
		/// und der Adresse des Referenzkunden an.
		/// </summary>
		public double? Entfernung
		{
			get
			{
				if (this.Kunde != null && this.myReferenzKunde != null && this.Kunde.Adresskoordinaten != null && this.myReferenzKunde.Adresskoordinaten != null)
				{
					var fromCoords = this.Kunde.Adresskoordinaten;
					var toCoords = this.myReferenzKunde.Adresskoordinaten;
					return Common.Geocoding.GeoData.GetDistanceKm(fromCoords.Latitude, fromCoords.Longitude, toCoords.Latitude, toCoords.Longitude);
				}
				return null;
			}
		}

		#region ENTITIES

		/// <summary>
		/// Gibt die <seealso cref="Appointment"/> Instanz zu diesem Wartungstermin zurück.
		/// </summary>
		public Appointment Appointment
		{
			get
			{
				return ModelManager.AppointmentService.GetAppointment(this.myBase.Terminpfad);
			}
		}

		/// <summary>
		/// Gibt die Instanz des Kunden zurück, dem die Maschine gehört.
		/// </summary>
		public Kunde Kunde
			=> this.myKunde;

		#endregion ENTITIES

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="Wartungstermin"/> Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Wartungstermin(dsAppointments.WartungsterminRow baseRow, Kunde referenzKunde = null)
		{
			this.myBase = baseRow;
			this.SetKunde();
			this.myReferenzKunde = referenzKunde;
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Legt den Kunden fest, zu dessen Adresse die Entfernung berechnet werden soll.
		/// </summary>
		/// <param name="referenzKunde"></param>
		public void SetReferenzKunde(Kunde referenzKunde) => this.myReferenzKunde = referenzKunde;

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		void SetKunde()
		{
			this.myKunde = ModelManager.CustomerService.GetKunde(this.myBase.Kundennummer, false);
		}

		#endregion PRIVATE PROCEDURES
	}
}