using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;
using Products.Common.Interfaces;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class Tour : ILinkedItem
	{

		#region members

		private dsSalesForce.TourRow myBase = null;
		private User myVertreter = null;
		private SBList<Kunde> myTourkunden = null;
		private SBList<Interessent> myTourInteressenten = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Außendienst-Tour").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.Tourname; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Außendienst-Tour"; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel dieser Tour zurück.
		/// </summary>
		public string UID
		{
			get { return myBase.UID; }
		}

		/// <summary>
		/// Gibt die Tourbezeichnung zurück.
		/// </summary>
		public string Tourname
		{
			get { return myBase.Tourname; }
			set { myBase.Tourname = value; }
		}

		/// <summary>
		/// Gibt die Nummer dieser Tour in Sage zurück.
		/// </summary>
		public int TourInSage
		{
			get { return myBase.TourSage; }
			set { myBase.TourSage = value; }
		}

		/// <summary>
		/// Primärschlüssel des Mitarbeiters, der für diese Tour zuständig ist.
		/// </summary>
		public string VertreterId
		{
			get { return myBase.VertreterId; }
			set 
			{ 
				myBase.VertreterId = value;
			}
		}

		/// <summary>
		/// Name des Mitarbeiters, der für die Tour zuständig ist.
		/// </summary>

		public string VertreterName
		{
			get { return this.Vertreter.NameFull; }
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Kunden zurück, die zu dieser Tour gehören.
		/// </summary>
		public SBList<Kunde> Tourkunden
		{
			get
			{
				if (this.myTourkunden == null)
				{
					this.myTourkunden = ModelManager.SalesForceService.GetKundenPerTour(this);
				}
				return this.myTourkunden;
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der mit dieser Tour verknüpften Interessenten zurück.
		/// </summary>
		public SBList<Interessent> TourInteressenten
		{
			get
			{
				if (myTourInteressenten == null)
				{
					this.myTourInteressenten = ModelManager.SalesForceService.GetInteressentenPerTour(this);
				}
				return myTourInteressenten;
			}
		}

		/// <summary>
		/// Gibt den für diese Tour zuständigen Außendienstmitarbeiter zurück.
		/// </summary>
		public User Vertreter
		{
			get
			{
				if (myVertreter == null)
				{
					myVertreter = ModelManager.UserService.GetUser(myBase.VertreterId, Services.UserService.UserSearchParamType.PrimaryKey);
				}
				return myVertreter;
			}
			set
			{
				this.VertreterId = value.UID;
				myVertreter = value;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Tour Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Tour(dsSalesForce.TourRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt dieser Tour den Kunden mit der angegebenen Kundennummer hinzu.
		/// </summary>
		/// <param name="kundennummer"></param>
		public void AddKunde(Kunde kunde)
		{
			try
			{
				if (ModelManager.SalesForceService.AddTourKunde(this, kunde) == 1)
				{
					if (!Tourkunden.Contains(kunde))
					{
						Tourkunden.Add(kunde);
					}
				} 
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Fügt der internen Auflistung von Interessenten díe angegebene Interessenten Instanz hinzu.
		/// </summary>
		/// <param name="interessent"></param>
		public void AddInteressent(Interessent interessent)
		{
			try
			{
				if (ModelManager.SalesForceService.AddTourInteressent(this, interessent) == 1)
				{
					if (!this.TourInteressenten.Contains(interessent))
					{
						this.TourInteressenten.Add(interessent);
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Entfernt den angegebenen Kunden aus dieser Tour.
		/// </summary>
		/// <param name="kunde"></param>
		public void Remove(Kunde kunde)
		{
			if (ModelManager.SalesForceService.RemoveKundeFromTour(kunde.CustomerId, this.UID) == 1)
			{
				if (this.myTourkunden.Contains(kunde))
				{
					this.myTourkunden.Remove(kunde);
				}
			}
		}

		#endregion

	}
}
