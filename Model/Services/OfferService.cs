using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Model.Entities;
using Products.Common.Collections;
using Products.Data;

namespace Products.Model.Services
{
	public class OfferService
	{

		#region members

		readonly Dictionary<string, SBList<Offer>> myOfferDictionary = new Dictionary<string, SBList<Offer>>();
		readonly Dictionary<string, SBList<OfferDetail>> myOfferDetailDictionary = new Dictionary<string, SBList<OfferDetail>>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Creates and returns a new offer for this customer.
		/// </summary>
		/// <param name="kunde">Der Angebotskunde</param>
		/// <returns></returns>
		public Offer CreateOffer(Kunde kunde)
		{
			var oRow = DataManager.OfferDataService.AddOfferRow(kunde.CustomerId, ModelManager.UserService.CurrentUser.NameFull, kunde.Zahlungsbedingungen);
			var offer = new Offer(oRow);
			this.GetOfferList(kunde.CustomerId).Add(offer);
			return offer;
		}

		/// <summary>
		/// Gibt eine neue Angebotsposition zurück.
		/// </summary>
		/// <param name="offer">Angebot, für das die neue Position erstellt wird.</param>
		/// <param name="product">Artikel der Angebotsposition.</param>
		public void AddOfferDetail(Offer offer, Product product)
		{
			int posCount = offer.OfferDetails.Count;
			var newRow = DataManager.OfferDataService.AddOfferDetailRow(offer.CustomerId, offer.UID, product.Artikelnummer, posCount);
			if (newRow != null)
			{
				var detail = new OfferDetail(newRow, offer.CustomerId);
				offer.OfferDetails.Add(detail);
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Angebote des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Angebotskunden.</param>
		/// <returns></returns>
		public SBList<Offer> GetOfferList(string customerPK)
		{
			if (!this.myOfferDictionary.ContainsKey(customerPK))
			{
				var list = new SBList<Offer>();
				foreach (var oRow in DataManager.OfferDataService.GetOfferDataTable(customerPK))
				{
					list.Add(new Offer(oRow));
				}
				this.myOfferDictionary.Add(customerPK, list);
				return list;
			}
			return this.myOfferDictionary[customerPK];
		}

		/// <summary>
		/// Gibt das Angebot mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Angebotskunden.</param>
		/// <param name="offerPK">Primärschlüssel des Angebots.</param>
		/// <returns></returns>
		public Offer GetOffer(string customerPK, string offerPK)
		{
			return this.GetOfferList(customerPK).FirstOrDefault(o => o.UID == offerPK);
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit den Angebotspositionen des angegebenen
		/// Angebots zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Angebotskunden.</param>
		/// <param name="offerPK">Primärschlüssel des Angebots.</param>
		/// <returns></returns>
		public SBList<OfferDetail> GetOfferDetailList(string customerPK, string offerPK)
		{
			if (!this.myOfferDetailDictionary.ContainsKey(offerPK))
			{
				var list = new SBList<OfferDetail>();
				foreach (var dRow in DataManager.OfferDataService.GetOfferDetailDataTable(customerPK).Where(d => d.OfferUid == offerPK))
				{
					list.Add(new OfferDetail(dRow, customerPK));
				}
				this.myOfferDetailDictionary.Add(offerPK, list);
			}
			return this.myOfferDetailDictionary[offerPK];
		}

		/// <summary>
		/// Löscht das angegebene Angebot einschließlich aller Angebotspositionen.
		/// </summary>
		/// <param name="offer"></param>
		public void DeleteOffer(Offer offer)
		{
			// Angebotspositionen löschen.
			foreach (var detail in this.GetOfferDetailList(offer.CustomerId, offer.UID))
			{
				DataManager.OfferDataService.DeleteOfferDetailRow(offer.CustomerId, detail.UID);
			}
			// DetailListe aus dem internen Dictionary entfernen.
			this.myOfferDetailDictionary.Remove(offer.UID);

			// Angebot löschen und aus der internen Auflistung entfernen.
			this.GetOfferList(offer.CustomerId).Remove(offer);
			DataManager.OfferDataService.DeleteOfferRow(offer.CustomerId, offer.UID);
		}

		/// <summary>
		/// Löscht die angegebene Angebotsposition;
		/// </summary>
		/// <param name="offerDetail"></param>
		public void DeleteOfferDetail(OfferDetail offerDetail)
		{
			var offer = offerDetail.ParentOffer;
			// Position aus der internen Auflistung entfernen.
			this.GetOfferDetailList(offer.CustomerId, offer.UID).Remove(offerDetail);
			DataManager.OfferDataService.DeleteOfferDetailRow(offer.CustomerId, offerDetail.UID);
		}

		/// <summary>
		/// Aktualisiert alle Angebote des angegebenen Kunden.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public int UpdateOffers(string customerPK)
		{
			return DataManager.OfferDataService.UpdateOfferTable(customerPK);
		}

		/// <summary>
		/// Aktualisiert alle Angebotspositionen des angegebenen Angebots.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		public int UpdateOfferDetails(string customerPK)
		{
			return DataManager.OfferDataService.UpdateOfferDetailTable(customerPK);
		}

		#endregion

		#region private procedures
		#endregion

	}
}
