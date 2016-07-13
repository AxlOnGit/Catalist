using System;
using System.Text;
using Products.Data;
using Products.Common.Interfaces;
using Products.Data.Datasets;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class Offer : ILinkedItem
	{

		#region members

		dsOffers.OfferRow myBase;

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
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Angebot-Catalist").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.OfferId; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Angebot-Catalist"; }
		}

		#endregion

		#region integrals

		public string UID { get { return this.myBase.UID; } }
		public string CustomerId { get { return this.myBase.CustomerId; } }

		public DateTime CreateDate 
		{
			get { return this.myBase.CreateDate; } 
			set 
			{ 
				this.myBase.CreateDate = value;
 
			} 
		}
		public string CreateUser 
		{ 
			get { return this.myBase.CreateUser; } 
			set 
			{ 
				this.myBase.ChangeUser = value;
				this.myBase.ChangeUser = ModelManager.UserService.CurrentUser.UserName;
			} 
		}

		public DateTime ChangeDate 
		{ get { return this.myBase.ChangeDate; } 
			set
			{ 
				this.myBase.ChangeDate = value; 
				this.ChangeUser = ModelManager.UserService.CurrentUser.NameFull; 
			}
		}

		public string ChangeUser 
		{
			get { return this.myBase.ChangeUser; }
			set 
			{ 
				this.myBase.ChangeUser = value; 
				this.myBase.ChangeDate = DateTime.Now; 
			}
		}

		public string Comments 
		{
			get { return this.myBase.Comments; }
			set 
			{ 
				this.myBase.Comments = value;
				this.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Die Angebotsnummer, so wie sie auf dem Ausdruck erscheint.
		/// </summary>
		public string OfferId
		{ 
			get { return myBase.OfferId; } 
			set 
			{ 
				myBase.OfferId = value;
				this.ChangeDate = DateTime.Now;
			} 
		}

		/// <summary>
		/// Kompletter Pfad und Dateiname des Angebots im Dateisystem.
		/// </summary>
		public string FileNameAndPath { get; set; }

		/// <summary>
		/// Gibt das Bestellkennzeichen zurück oder legt es fest.
		/// <remarks>Das Kack MySQL kommt mit Boolean nicht klar, deshalb muss man
		/// von 0, bzw. 1 mach True, bzw. False konvertieren. Ätzend ...</remarks>
		/// </summary>
		public bool Bestellkennzeichen 
		{ 
			get 
			{ 
				return (myBase.Bestellkennzeichen == 0) ? false : true; 
			} 
			set 
			{
				if (value == true)
				{
					myBase.Bestellkennzeichen = 1;
				}
				else
				{
					myBase.Bestellkennzeichen = 0;
				}
				this.ChangeDate = DateTime.Now;
			} 
		}

		/// <summary>
		/// Zahlungsbedingungen für dieses Angebot.
		/// </summary>
		public string Zahlungsbedingungen
		{
			get
			{
				if (this.myBase.IsZahlungsbedingungenNull())
				{
					this.myBase.Zahlungsbedingungen = this.Customer.Zahlungsbedingungen;
				}
				return this.myBase.Zahlungsbedingungen;
			}
			set
			{
				this.myBase.Zahlungsbedingungen = value;
				this.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Returns the total net amount of this offer.
		/// </summary>
		public decimal NetAmount
		{
			get
			{
				decimal retVal = 0.00m;
				foreach (OfferDetail dtl in OfferDetails)
				{
					retVal += dtl.Zeilensumme;
				}
				return retVal;
			}
		}

		/// <summary>
		/// Returns the tax amount for this offer.
		/// </summary>
		public decimal TaxAmount
		{
			get
			{
				return (NetAmount * Common.Global.TaxRateMultiplier) - NetAmount;
			}
		}

		/// <summary>
		/// Returns the offer amount incl. tax.
		/// </summary>
		public decimal OfferTotal
		{
			get
			{
				return NetAmount + TaxAmount;
			}
		}

		/// <summary>
		/// Gibt die Rohmarge für das gesamte Angebot zurück.
		/// </summary>
		public decimal Rohmarge
		{
			get
			{
				decimal retVal = 0;
				foreach (Model.Entities.OfferDetail od in OfferDetails)
				{
					retVal += od.RohmargeTotal;
				}
				return retVal;
			}
		}

		/// <summary>
		/// Gibt das letzte Druckdatum des Angebots zurück.
		/// </summary>
		public DateTime? DruckdatumAngebot
		{
			get
			{
				if (this.myBase.IsDruckdatumAngebotNull() && this.myBase.DruckdatumAngebot.Equals(new DateTime(1970,1,1)))
				{
					return null;
				}
				else return this.myBase.DruckdatumAngebot;
			}
			set
			{
				if (value.HasValue)
				{
					this.myBase.DruckdatumAngebot = value.Value;
				}
				else this.myBase.DruckdatumAngebot = new DateTime(1970,1,1);
				this.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Gibt das letzte Druckdatum der Bestellung zurück.
		/// </summary>
		public DateTime? DruckdatumBestellung
		{
			get
			{
				if (this.myBase.IsDruckdatumBestellungNull() && this.myBase.DruckdatumBestellung.Equals(new DateTime(1970,1,1)))
				{
					return null;
				}
				else return this.myBase.DruckdatumBestellung;
			}
			set
			{
				if (value.HasValue)
				{
					this.myBase.DruckdatumBestellung = value.Value;
				}
				else this.myBase.SetDruckdatumBestellungNull();
				this.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Gibt einen Überblick über das Angebot als Zeichenfolge zurück.
		/// </summary>
		public string OfferInfo
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine(string.Format("Positionen:\t{0}", OfferDetails.Count));
				sb.AppendLine(string.Format("Angebot (netto):\t{0:C2}", NetAmount));
				sb.AppendLine(string.Format("Rohmarge:\t{0:C2}", Rohmarge));

				return sb.ToString();
			}
		}

		/// <summary>
		/// Returns true if this offer has been modified.
		/// </summary>
		public bool Dirty 
		{ 
			get 
			{ 
				return myBase.RowState != System.Data.DataRowState.Unchanged || GetDetailsDirty(); 
			} 
		}

		#endregion

		#region entities

		/// <summary>
		/// Returns the Customer referenced by this offer.
		/// </summary>
		public Kunde Customer
		{
			get
			{
				if (myBase.CustomerId != null)
				{
					return ModelManager.CustomerService.GetKunde(myBase.CustomerId, false);
				}
				return null;
			}
			set
			{
				myBase.CustomerId = value.CustomerId;
			}
		}

		/// <summary>
		/// Returns a sortable list of all offer details for this offer.
		/// </summary>
		public SBList<OfferDetail> OfferDetails
		{
			get
			{
				return ModelManager.OfferService.GetOfferDetailList(this.CustomerId, this.UID);
			}
		}

		void OfferDetails_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			this.OfferDetails.Sort("Position");
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the Offer class.
		/// </summary>
		/// <param name="baseRow"></param>
		public Offer(dsOffers.OfferRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region private procedures

		private bool GetDetailsDirty()
		{
			foreach (OfferDetail detail in OfferDetails)
			{
				if (detail.Dirty) return true;
			}
			return false;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt das Druckdatum des Angebots auf das aktuelle Datum und die aktuelle Uhrzeit fest.
		/// </summary>
		public void SetPrintDateOffer()
		{
			this.DruckdatumAngebot = DateTime.Now;
		}

		/// <summary>
		/// Legt das Druckdatum der Bestellung auf das aktuelle Datum und die aktuelle Uhrzeit fest.
		/// </summary>
		public void SetPrintDateOrder()
		{
			this.DruckdatumBestellung = DateTime.Now;
		}

		#region Positionen

		public void MoveUp(OfferDetail detail)
		{
			var prevPos = this.OfferDetails[detail.Position - 2];
			prevPos.Position = detail.Position;
			detail.Position -= 1;
			this.OfferDetails.Sort("Position");
		}

		public void MoveDown(OfferDetail detail)
		{
			var nextPos = this.OfferDetails[detail.Position];
			nextPos.Position = detail.Position;
			detail.Position += 1;
			this.OfferDetails.Sort("Position");
		}

		#endregion

		#endregion

	}
}
