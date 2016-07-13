using System;
using System.Linq;
using Products.Common;
using Products.Data;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Order : ILinkedItem
	{

		#region members

		dsOrders.OrderRow myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.Auftrag; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Auftrag").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.Auftrag; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Auftrag"; }
		}

		#endregion

		#region integrals

		public string Vorgang { get { return myBase.Vorgang; } }
		public string Nummer { get { return myBase.Nummer; } }
		public string ParentOrder { get { return myBase.Auftrag; } }
		public DateTime Datum { get { return myBase.Datum; } }
		public string Kundennummer { get { return myBase.Kundennummer; } }
		public string CompanyName1 { get { return this.Kunde.CompanyName1; } }
		public string CompanyName2 { get { return this.Kunde.CompanyName2; } }
		public string Street { get { return this.Kunde.Street; } }
		public string ZipCode { get { return this.Kunde.ZipCode; } }
		public string City { get { return this.Kunde.City; } }
		public decimal Bruttosumme { get { return this.myBase.Bruttosumme; } }
		public decimal Nettosumme { get { return this.myBase.Nettosumme; } }
		public decimal UStBetrag { get { return this.Bruttosumme - this.Nettosumme; } }
		public decimal Gesamtrabatt { get { return this.myBase.Gesamtrabatt; } }
		public decimal Roherloes { get { return this.myBase.Roherloes; } }
		public string eMail { get { return this.Kunde.Hauptkontakt.E_Mail; } }

		public bool Geliefert { get { return this.myBase.OffeneLieferung == "0" ? true : false; } }

		public bool Berechnet { get { return this.myBase.OffeneRechnung == "0" ? true : false; } }

		public string Bearbeiter
		{
			get
			{
				if (!string.IsNullOrEmpty(this.myBase.Bearbeiter))
				{
					var user = ModelManager.UserService.GetUser(this.myBase.Bearbeiter, Services.UserService.UserSearchParamType.SageEmployeeId);
					if (user != null) return user.NameFull;
				}
				return "Unbekannt";
			}
		}

		#endregion

		#region entities

		public Kunde Kunde
		{
			get { return ModelManager.CustomerService.GetKunde(this.myBase.Kundennummer, false); }
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the Order class.
		/// </summary>
		/// <param name="baseRow"></param>
		public Order(dsOrders.OrderRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region private procedures

		#endregion

	}
}
