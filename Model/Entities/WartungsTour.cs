using System;
using System.Linq;
using Products.Common;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class WartungsTour : ILinkedItem
	{
		#region members

		private readonly dsTechnik.WartungstourRow myBase;

		#endregion members

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Die Bezeichnung für dieses Element (Wartungstour), die in der Benutzeroberfläche angezeigt wird.
		/// </summary>
		public string ItemName
		{
			get
			{
				var techniker = (this.Techniker != null) ? this.Techniker.NameFirst : "-";
				return string.Format("{0} ({1})", this.myBase.Bezeichnung, techniker);
			}
		}

		/// <summary>
		/// Der Primärschlüssel des verknüpften Elements.
		/// </summary>
		public string Key
		{
			get
			{
				return this.myBase.UID;
			}
		}

		/// <summary>
		/// Die Bezeichnung für den Verknüpfungstyp des Elements.
		/// </summary>
		public string LinkTypBezeichnung
		{
			get
			{
				return "Wartungstour";
			}
		}

		/// <summary>
		/// Der Primärschlüssel (GUID) des Verknüpfungstyps.
		/// </summary>
		public string LinkTypeId
		{
			get
			{
				return "e31451d7-7c22-11e6-86d7-281878bb3fa2";
			}
		}

		#endregion ILinkedItem

		/// <summary>
		/// Gibt den Techniker (Benutzer) dieser Wartungstour  zurück.
		/// </summary>
		public User Techniker
		{
			get
			{
				return ModelManager.UserService.GetUser(this.myBase.TechnikerId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt eine Liste der Termine dieser Wartungstour zurück.
		/// </summary>
		public SortableBindingList<Appointment> TerminListe
		{
			get
			{
				return ModelManager.AppointmentService.GetAppointmentList(this);
			}
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit des 1. Termins dieser Tour zurück.
		/// </summary>
		public DateTime TourStart
		{
			get
			{
				return this.TerminListe.Min(t => t.StartsAt);
			}
		}

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="WartungsTour"/> Klasse.
		/// </summary>
		/// <param name="baseRow">Eine <seealso cref="dsTechnik.WartungstourRow"/></param> Instanz.
		public WartungsTour(dsTechnik.WartungstourRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion ### .ctor ###
	}
}