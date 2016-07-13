using System;
using System.Text;
using System.Windows.Forms;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class OfferDetail
	{

		#region members

		dsOffers.OfferDetailRow myBase;
		string myCustomerPK;
		decimal rabattBetrag;

		#endregion

		#region public properties

		public dsOffers.OfferDetailRow BaseRow { get { return myBase; } }
		public string UID { get { return myBase.UID; } }
		public string OfferUid { get { return myBase.OfferUid; } }
		public int Position 
		{ 
			get { return myBase.PosIdx; } 
			set 
			{ 
				myBase.PosIdx = value;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}
		public string Artikelnummer
		{
			get { return myBase.ProductId; }
			set
			{
				myBase.ProductId = value; 
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}
		public string Artikelname
		{
			get { return myBase.ProductName; }
			set
			{
				myBase.ProductName = value; 
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}
		public string Einheit
		{
			get { return myBase.Unit; }
			set
			{
				myBase.Unit = value; 
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}

		public decimal Menge 
		{ get { return myBase.Quantitiy; } 
			set 
			{ 
				myBase.Quantitiy = value;
				Zeilensumme = value * Kundenpreis;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}

		public decimal Einzelpreis 
		{
			get 
			{ return myBase.UnitPrice; 
			} 
			set 
			{ 
				myBase.UnitPrice = value;
				Normalpreis = value;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}

		/// <summary>
		/// Gibt den mittleren Einkaufspreis des Artikels zurück oder legt ihn fest.
		/// </summary>
		public decimal MittlererEK
		{
			get { return myBase.Einkaufspreis; }
			set
			{
				this.myBase.Einkaufspreis = value; 
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}
		
		public decimal RabattProzent 
		{ 
			get { return myBase.DiscountPercent; } 
			set 
			{ 
				myBase.DiscountPercent = value; 
				myBase.UnitPriceCustomer = myBase.UnitPriceDefault * (100 - value) / 100;
				rabattBetrag = myBase.UnitPriceDefault * (value / 100);
				myBase.RowTotal = myBase.Quantitiy * myBase.UnitPriceCustomer;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}

		public decimal Rabattbetrag
		{
			get
			{
				return rabattBetrag;
			}
			set
			{
				rabattBetrag = value;
				if (value == 0)
				{
					myBase.DiscountPercent = 0;
					myBase.UnitPriceCustomer = myBase.UnitPriceDefault;
					myBase.RowTotal = myBase.UnitPriceDefault * myBase.Quantitiy;
				}
				else
				{
					if (myBase.UnitPriceDefault == 0)
					{
						myBase.DiscountPercent = 0;
						myBase.UnitPriceCustomer = 0;
						myBase.RowTotal = 0;
					}
					else
					{
						myBase.DiscountPercent = (100 - (((myBase.UnitPriceDefault - value) * 100) / myBase.UnitPriceDefault));
						myBase.UnitPriceCustomer = myBase.UnitPriceDefault - value;
						myBase.RowTotal = myBase.UnitPriceCustomer * myBase.Quantitiy;
					}
				}
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}

		public decimal Normalpreis 
		{ 
			get { return myBase.UnitPriceDefault; } 
			set 
			{ 
				myBase.UnitPriceDefault = value;
				myBase.UnitPriceCustomer = value - ((myBase.DiscountPercent / 100) * (value * myBase.Quantitiy));
				myBase.RowTotal = myBase.Quantitiy * myBase.UnitPriceCustomer;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}

		public decimal Kundenpreis 
		{ 
			get { return myBase.UnitPriceCustomer; } 
			set 
			{ 
				myBase.UnitPriceCustomer = value;
				myBase.RowTotal = value * Menge;
				this.ParentOffer.ChangeDate = DateTime.Now;
			} 
		}

		public decimal Zeilensumme 
		{ 
			get 
			{
				var result = 0.0m;
				if (this.Active)
				{
					var discountPct = this.myBase.DiscountPercent / 100;
					var unitPrice = Math.Round(this.myBase.UnitPriceDefault - (this.myBase.UnitPriceDefault * discountPct), 2 , MidpointRounding.AwayFromZero);
					result = this.Menge * unitPrice;
				}
				return result; 
			} 
			set 
			{ 
				myBase.RowTotal = value; 
			} 
		}

		public string Artikeltext 
		{ 
			get 
			{ 
				return myBase.Comment; 
			}
			set 
			{ 
				myBase.Comment = value.Replace("\t", "     ");
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn diese Position aktiv ist und in Angeboten und Angebotskalkulationen
		/// mit ihrem vollen Wert berücksichtigt werden soll.
		/// </summary>
		public bool Active 
		{
			get 
			{
				int flag;
				if (int.TryParse(myBase.ActiveFlag, out flag))
				{
					return (flag == 1);
				}
				return false;
			}
			set 
			{
				if (value == true)
				{
					myBase.ActiveFlag = "1";
				}
				else
				{
					myBase.ActiveFlag = "0";
				}
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// True, wenn diese Position auf eine neue Seite gedruckt werden soll.
		/// </summary>
		public bool NeueSeite
		{
			get
			{
				int flag;
				if (int.TryParse(myBase.NeueSeiteFlag, out flag))
				{
					return (flag == 1);
				}
				return false;
			}
			set
			{
				if (value == true)
				{
					myBase.NeueSeiteFlag = "1";
				}
				else
				{
					myBase.NeueSeiteFlag = "0";
				}
				this.ParentOffer.ChangeDate = DateTime.Now;
			}
		}

		/// <summary>
		/// Gibt das Angebot dieser Angebotsposition zurück.
		/// </summary>
		public Offer ParentOffer 
		{
			get { return ModelManager.OfferService.GetOffer(this.myCustomerPK, this.myBase.OfferUid); }
		}

		/// <summary>
		/// Gibt die Rohmarge pro Einheit zurück.
		/// </summary>
		public decimal RohmargeEinheit 
		{
			get 
			{
				if (this.ProductRow != null)
				{
					return myBase.UnitPriceCustomer - this.ProductRow.EK;
				}
				return 0.00m;
			}
		}

		public decimal RohmargeProzent 
		{
			get 
			{
				if (myBase.UnitPriceCustomer == 0 || this.ProductRow == null)
				{
					return 0;
				}
				else return ((myBase.UnitPriceCustomer - this.ProductRow.EK) * 100) / myBase.UnitPriceCustomer;
			}
		}

		/// <summary>
		/// Gibt die Rohmarge für diese Position zurück.
		/// Kundenpreis - Einkaufspreis * Menge
		/// </summary>
		public decimal RohmargeTotal
		{
			get 
			{
				return RohmargeEinheit * myBase.Quantitiy;
			}
		}

		/// <summary>
		/// Gibt Informationen zur Position als formatierte Zeichenfolge zurück.
		/// </summary>
		public string Positionsinfo 
		{
			get 
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine(string.Format("Artikelname:\t\t{0}", myBase.ProductName.ToUpper()));
				sb.AppendLine("--------------------");
				sb.AppendLine(string.Format("Einkaufspreis:\t\t{0:C2}", this.ProductRow.EK));
				sb.AppendLine(string.Format("Standardpreis:\t\t{0:C2}", myBase.UnitPriceDefault));
				sb.AppendLine(string.Format("Verkaufspreis:\t\t{0:C2}", myBase.UnitPriceCustomer));
				sb.AppendLine("--------------------");
				sb.AppendLine(string.Format("Rohmarge/Einheit:\t\t{0:C2} ({1:N2}%)", RohmargeEinheit, RohmargeProzent));
				sb.AppendLine(string.Format("Rohmarge gesamt:\t{0:C2}", RohmargeTotal));
				sb.AppendLine("--------------------");
				sb.AppendLine(string.Format("Summe Angebot:\t\t{0:C2}", ParentOffer.NetAmount));
				sb.AppendLine(string.Format("Rohmarge Angebot:\t{0:C2}", ParentOffer.Rohmarge));

				return sb.ToString();
			}
		}

		/// <summary>
		/// Returns true if this OfferDetail has been changed.
		/// </summary>
		public bool Dirty { get { return myBase.RowState != System.Data.DataRowState.Unchanged; } }

		#endregion

		#region private properties

		private dsProducts.ProductRow ProductRow
		{
			get 
			{ 
				return DataManager.ProductDataService.GetProductRow(this.myCustomerPK, this.myBase.ProductId); 
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the OfferDetail class.
		/// </summary>
		/// <param name="baseRow"></param>
		public OfferDetail(dsOffers.OfferDetailRow baseRow, string customerPK)
		{
			myBase = baseRow;
			this.myCustomerPK = customerPK;
			this.rabattBetrag = myBase.UnitPriceDefault - myBase.UnitPriceCustomer;
		}

		#endregion

		#region public procedures
		#endregion

	}
}
