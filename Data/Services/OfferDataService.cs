using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsOffersTableAdapters;
using Products.Common;
using System.Windows.Forms;

namespace Products.Data.Services
{
	public class OfferDataService
	{

		#region members

		readonly string myCurrentUserPK;

		readonly Dictionary<string, dsOffers.OfferDataTable> myOfferDictionary = new Dictionary<string, dsOffers.OfferDataTable>();
		readonly Dictionary<string, dsOffers.OfferDetailDataTable> myOfferDetailDictionary = new Dictionary<string, dsOffers.OfferDetailDataTable>();

		readonly taOffer myOfferAdapter = new taOffer();
		readonly taOfferDetail myOfferDetailAdapter = new taOfferDetail();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der OfferDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public OfferDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die Tabelle mit allen Angeboten für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public dsOffers.OfferDataTable GetOfferDataTable(string customerPK)
		{
			if (!this.myOfferDictionary.ContainsKey(customerPK))
			{
				// Daten für diesen Kunden noch nicht geladen - aber gleich ...
				this.myOfferDictionary.Add(customerPK, this.myOfferAdapter.GetData(customerPK));
				// Die Angebotspositionen nehmen wir an dieser Stelle direkt mit
				this.myOfferDetailDictionary.Add(customerPK, this.myOfferDetailAdapter.GetData(customerPK));
			}

			return this.myOfferDictionary[customerPK];
		}

		/// <summary>
		/// Gibt die Tabelle mit allen Angebotspositionen für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public dsOffers.OfferDetailDataTable GetOfferDetailDataTable(string customerPK)
		{
			if (!this.myOfferDetailDictionary.ContainsKey(customerPK))
			{
				this.myOfferDetailDictionary.Add(customerPK, this.myOfferDetailAdapter.GetData(customerPK));
			}
			return this.myOfferDetailDictionary[customerPK];
		}

		/// <summary>
		/// Erstellt eine neue OfferRow (ein neues Angebot) für den angegebenen Kunden.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <param name="userName"></param>
		/// <param name="paymentTerms"></param>
		/// <returns></returns>
		public dsOffers.OfferRow AddOfferRow(string customerPK, string userName, string paymentTerms)
		{
			var offerTable = this.GetOfferDataTable(customerPK);

			var now = DateTime.Now;
			var sb = new StringBuilder(now.Year);
			sb.Append(now.ToString("yy"));
			sb.Append(".");
			sb.Append(now.ToString("MM"));
			sb.Append(".");
			sb.Append(now.ToString("dd"));
			sb.Append("_");
			sb.Append(now.ToString("HH"));
			sb.Append(".");
			sb.Append(now.ToString("mm"));
			sb.Append("_");
			sb.Append(customerPK.Substring(0, 5));

			dsOffers.OfferRow oRow = offerTable.NewOfferRow();
			oRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			oRow.CustomerId = customerPK;
			oRow.CreateDate = now;
			oRow.CreateUser = userName;
			oRow.ChangeDate = now;
			oRow.ChangeUser = userName;
			oRow.Comments = "";
			oRow.OfferId = sb.ToString();
			oRow.Bestellkennzeichen = 0;
			oRow.Zahlungsbedingungen = paymentTerms;
			oRow.DruckdatumAngebot = new DateTime(1970, 1, 1);
			oRow.DruckdatumBestellung = new DateTime(1970, 1, 1);

			offerTable.AddOfferRow(oRow);
			return oRow;
		}

		/// <summary>
		/// Fügt dem angegebenen Angebot eine neue Position hinzu.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Angebotskunden.</param>
		/// <param name="offerPK">Primärschlüssel des Angebots.</param>
		/// <param name="productPK">Artikelnummer des hinzuzufügenden Artikels.</param>
		/// <param name="positionCount">Anzahl der bereits vorhandenen Angebotspositionen.</param>
		/// <returns></returns>
		public dsOffers.OfferDetailRow AddOfferDetailRow(string customerPK, string offerPK, string productPK, int positionCount)
		{
			var sbProductText = new StringBuilder();
			var pRow = DataManager.ProductDataService.GetProductRow(customerPK, productPK);
			var errMsg = "Für die angegebene Artikelnummer gibt es keinen Eintrag in der Artikeltabelle.";
			if (pRow == null) throw new ArgumentException(errMsg);
			sbProductText.Append(pRow.Bezeichnung2);

			var pTextRow = DataManager.ProductDataService.GetProductTextRow(pRow.ArtikelzusatztextAnker);
			var sRow = DataManager.ProductDataService.GetSonderpreisRow(customerPK, pRow.Artikelgruppe);
			if (pTextRow != null)
			{
				sbProductText.Clear();
				var rtf = new RichTextBox();
				rtf.Rtf = pTextRow.Content;
				var textArray = rtf.Text.Split( new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < textArray.Length; i++)
				{
					sbProductText.AppendLine(textArray[i]);
				}
			}

			var discountPercent = 0.0m;
			if (sRow != null) discountPercent = sRow.Rabatt / 100;

			var detailTable = this.GetOfferDetailDataTable(customerPK);
			var dRow = detailTable.NewOfferDetailRow();
			dRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			dRow.OfferUid = offerPK;
			dRow.ProductId = productPK;
			dRow.ProductName = pRow.Bezeichnung1;
			dRow.Unit = pRow.Mengeneinheit;
			dRow.Quantitiy = 1;
			dRow.UnitPrice = pRow.Verkaufspreis1;
			dRow.DiscountPercent = discountPercent * 100;
			dRow.UnitPriceDefault = pRow.Verkaufspreis1;
			dRow.UnitPriceCustomer = pRow.Verkaufspreis1 - (pRow.Verkaufspreis1 * discountPercent);
			dRow.RowTotal = pRow.Kundenpreis;
			dRow.Comment = sbProductText.ToString();
			dRow.PosIdx = positionCount + 1;
			dRow.ActiveFlag = "1";
			dRow.NeueSeiteFlag = "0";
			dRow.KatalogHeader = "";
			dRow.Einkaufspreis = pRow.EK;

			detailTable.AddOfferDetailRow(dRow);
			return dRow;
		}

		/// <summary>
		/// Löscht die OfferRow für das Angebot mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Angebotskunden.</param>
		/// <param name="offerPK">Primärschlüssel des Angebots.</param>
		public void DeleteOfferRow(string customerPK, string offerPK)
		{
			var oRow = this.GetOfferDataTable(customerPK).FirstOrDefault(o => o.UID == offerPK);
			if (oRow != null)
			{
				oRow.Delete();
				this.myOfferAdapter.Update(oRow);
			}
		}

		/// <summary>
		/// Löscht die OfferDetailRow für die Angebotsposition mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <param name="offerDetailPK"></param>
		public void DeleteOfferDetailRow(string customerPK, string offerDetailPK)
		{
			var dRow = this.myOfferDetailDictionary[customerPK].FirstOrDefault(d => d.UID == offerDetailPK);
			if (dRow != null)
			{
				dRow.Delete();
				this.myOfferDetailAdapter.Update(dRow);
			}
		}

		/// <summary>
		/// Aktualisiert alle geänderten oder neuen Angebote des angegebenen Kunden.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public int UpdateOfferTable(string customerPK)
		{
			this.UpdateOfferDetailTable(customerPK);

			var table = this.GetOfferDataTable(customerPK);
			if (table != null && table.GetChanges() != null)
			{
				return this.myOfferAdapter.Update(table);
			}
			return 0;
		}

		/// <summary>
		/// Aktualisiert alle geänderten oder neuen Angebotspositionen des angegebenen Angebots.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public int UpdateOfferDetailTable(string customerPK)
		{
			var table = this.GetOfferDetailDataTable(customerPK);
			if (table != null && table.GetChanges() != null)
			{
				return this.myOfferDetailAdapter.Update(table);
			}
			return 0;
		}

		#endregion

	}
}
