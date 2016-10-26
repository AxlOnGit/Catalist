using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using Products.Common;
using Products.Data.dsSageTableAdapters;
using Products.Data.EventSystem;
using Products.Data.Datasets;
using System.Data;

namespace Products.Data
{
	public class DataService
	{

		#region members

		const string myAxelsGuidString = "d4224429-749f-4ad0-8627-fcfb694816c7";

		Guid myAxelsGuid = Guid.Empty;
		DateTime myNoDate = new DateTime(100, 1, 1, 0, 0, 0);

		#region table adapter

		ta_cpm_KontaktEmail ta_cpm_KontaktEmail = new ta_cpm_KontaktEmail();
		taArtikel taArtikel = new taArtikel();
		taAuftragProArtikel taAuftragProArtikel = new taAuftragProArtikel();
		taCustomerContact taCustomerContact = new taCustomerContact();
		taCustomerSales taCustomerSales = new taCustomerSales();
		taInvoice taInvoice = new taInvoice();
		taKontaktEmail taKontaktEmail = new taKontaktEmail();
		taKontaktnummer taKontaktnummer = new taKontaktnummer();
		taKundenumsatz taKundenumsatz = new taKundenumsatz();
		taOffenePosten taOffenePosten = new taOffenePosten();
		taOrder taOrder = new taOrder();
		taOrderDetail taOrderDetail = new taOrderDetail();
		readonly taQueries taQueries = new taQueries();
		//taSuchkunde taSuchkunde = new taSuchkunde();
		taTransaction taTransaction = new taTransaction();
		taUnpaidItem taUnpaidItem = new taUnpaidItem();
		taUpsShipping taUpsShipping = new taUpsShipping();
		taVersandkostenstaffel taVersandkostenstaffel = new taVersandkostenstaffel();
		
		#endregion

		#endregion

		#region public properties

		internal bool CustomerInitialized { get; set; }
		internal string CustomizedPriceInitializedFor { get; set; }
		internal bool ProductDetailsInitialized { get; set; }
		internal bool CustomerSalesInitialized { get; set; }
		internal bool UnpaidItemsInitialized { get; set; }
		internal bool CustomerContactInitialized { get; set; }
		internal bool SupplierContactInitialized { get; set; }
		internal bool KatalogindexInitialized { get; set; }
		internal bool DatasetInitialized { get; set; }
		internal bool PresetsInitialized { get; set; }
		internal bool ProductsInitialized { get; set; }
		internal bool OfferInitialized { get; set; }
		internal bool ContactMailInitialized { get; set; }
		internal string ProductsInitializedFor { get; set; }
		internal string OrderInitializedFor { get; set; }
		internal string AllOrdersInitializedFor { get; set; }

		//private CustomerData cpmCustomerData = null;

		/// <summary>
		/// Returns the dsSage Dataset for the current customer.
		/// </summary>
		internal dsSage myDS { get; set; }

		/// <summary>
		/// Gets or sets the current customer.
		/// If the current customer changes the appropriate tables for this customer
		/// will get a refill (Kundenpreis, Auftrag, Auftragsdetails).
		/// </summary>
		public dsCustomer.CustomerRow CurrentCustomer { get; set; }

		/// <summary>
		/// Returns the CustomerData instance for the default customer (CPM).
		/// </summary>
		//public CustomerData CpmCustomerData { get { return cpmCustomerData; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the DataService
		/// </summary>
		public DataService()
		{
			myAxelsGuid = Guid.Parse(myAxelsGuidString);

			this.myDS = new dsSage();
	
			InitializeAdapters();
			InitializePermanentData();
		}

		#endregion

		#region public procedures

	
	
		#region Aufträge

		/// <summary>
		/// Loads the orders of the current customer which is 
		/// pretty time consuming, so we just load it on demand.
		/// </summary>
		/// <returns></returns>
		public dsSage.OrderDataTable GetTabelleOrdersPerKunde(string custNbr)
		{
			if (OrderInitializedFor == null || OrderInitializedFor != custNbr)
			{
				taOrder.ClearBeforeFill = true;
				taOrder.Fill(myDS.Order, custNbr);
				taOrderDetail.Fill(myDS.OrderDetail, custNbr);
				OrderInitializedFor = custNbr;
			}
			return myDS.Order;
		}

		public dsSage.OrderDataTable GetAllOrdersPerKunde(string custNbr)
		{
			if (AllOrdersInitializedFor == null || AllOrdersInitializedFor != custNbr)
			{
				taOrder.FillAll(myDS.Order, custNbr);
				taOrderDetail.FillAll(myDS.OrderDetail, custNbr);
				AllOrdersInitializedFor = custNbr;
			}
			return myDS.Order;
		}

		/// <summary>
		/// Weist das System an, die Auftragstabelle erneut zu laden.
		/// </summary>
		public void ResetOrdersInitialized()
		{
			OrderInitializedFor = string.Empty;
			AllOrdersInitializedFor = string.Empty;
		}

		public dsSage.OrderDetailDataTable GetTabelleOrderDetails()
		{
			return myDS.OrderDetail;
		}

		/// <summary>
		/// Gibt eine Liste aller Aufträge in Sage für den aktuellen Kunden zurück.
		/// </summary>
		/// <remarks>
		/// Das Dataset enthält immer nur die Aufträge des gerade aktiven Kunden.
		/// Der Filter lautet: Auftragsnummer = Vorgangsnummer (die sind bei Aufträgen identisch).
		/// </remarks>
		/// <returns></returns>
		public SortableBindingList<dsSage.OrderRow> GetOrderList()
		{
			var list = new SortableBindingList<dsSage.OrderRow>();
			IEnumerable<dsSage.OrderRow> oList = myDS.Order.Where(a => a.Auftrag == a.Nummer);
			foreach (var item in oList)
			{
				list.Add(item);
			}
			return list;
		}

		/// <summary>
		/// Returns a sortable list of orders where one of the detail rows
		/// matches the filter criteria.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		public SortableBindingList<dsSage.OrderRow> GetOrdersByDetailFilter(string filter)
		{
			var orderList = new SortableBindingList<dsSage.OrderRow>();
			foreach (dsSage.OrderDetailRow detailRow in GetTabelleOrderDetails().Where(o => o.VorgangspresetTemporaer == "D" || o.VorgangspresetTemporaer == "R"))
			{
				if (detailRow.Artikelnummer.ToUpperInvariant().Contains(filter.ToUpperInvariant())
					|| detailRow.Bezeichnung1.ToUpperInvariant().Contains(filter.ToUpperInvariant())
					|| detailRow.Bezeichnung2.ToUpperInvariant().Contains(filter.ToUpperInvariant()))
				{
					{
						foreach (dsSage.OrderRow orderRow in (detailRow.GetParentRows("Auftrag_Auftragsdetails") as dsSage.OrderRow[]).Where(o => o.Vorgang == "D" || o.Vorgang == "R"))
						{
							if (!orderList.Contains(orderRow))
							{
								orderList.Add(orderRow);
							}
						}
					}
				}
			}
			return orderList;
		}

		/// <summary>
		/// Gibt eine Tabelle mit allen Aufträgen für den angegebenen Artikel zurück.
		/// </summary>
		/// <param name="artikelNr"></param>
		/// <returns></returns>
		public dsSage.AuftragProArtikelDataTable GetAuftraegeProArtikel(string artikelNr)
		{
			return this.taAuftragProArtikel.GetData(artikelNr);
		}

		#endregion

		#region CustomerData

		//public CustomerData GetOrCreateCustomerData(string customerId, bool reset)
		//{
		//  CustomerData cd = myCustomerDataList.FirstOrDefault(c => c.CustomerId == customerId);
		//  if (cd == null) cd = new CustomerData(customerId);
		//  if (reset) cd.Reset();
		//  return cd;
		//}

		///// <summary>
		///// Erfasst einen neuen kundenspezifischen Sonderpreis für den angegebenen Kunden
		///// und die angegebene Artikelgruppe.
		///// </summary>
		///// <param name="kundenNummer">Die Kundennummer des betreffenden Kunden.</param>
		///// <param name="artikelGruppe">Die betreffende Artikelgruppe.</param>
		///// <param name="percent">Der Rabattbetrag in Prozent.</param>
		///// <returns>Gibt 1 zurück, wenn der Preis erfolgreich gespeichert wurde.</returns>
		//public int CreateOrChangeSpecialCustomerPrice(string kundennummer, dsSage.CustomizedPriceRow custPriceRow)
		//{
		//  try
		//  {
		//    string kdNr = custPriceRow.Kundennummer;
		//    string artGruppe = custPriceRow.Artikelgruppe;
		//    dsSage.KundenArtikelSonderpreiseRow priceRow = CurrentDataset.KundenArtikelSonderpreise.FirstOrDefault(s => s.Kundennummer == kundennummer && s.Artikelgruppe == artGruppe);
		//    if (priceRow != null)
		//    {
		//      priceRow.Rabatt = custPriceRow.Prozent;
		//      priceRow.Menge1 = custPriceRow.Menge1;
		//      priceRow.Rabatt1 = custPriceRow.Rabatt1;
		//      priceRow.Menge2 = custPriceRow.Menge2;
		//      priceRow.Rabatt2 = custPriceRow.Rabatt2;
		//      priceRow.Menge3 = custPriceRow.Menge3;
		//      priceRow.Rabatt3 = custPriceRow.Rabatt3;
		//      priceRow.Menge4 = custPriceRow.Menge4;
		//      priceRow.Rabatt4 = custPriceRow.Rabatt4;
		//    }
		//    else
		//    {
		//      dsSage.KundenArtikelSonderpreiseRow newRow = CurrentDataset.KundenArtikelSonderpreise.NewKundenArtikelSonderpreiseRow();
		//      newRow.Kundennummer = kundennummer;
		//      newRow.Artikelgruppe = custPriceRow.Artikelgruppe;
		//      newRow.Artikelnummer = "";
		//      newRow.Hersteller = "0000000000";
		//      newRow.Sonderpreis_Preisgruppe = 0.01m;
		//      newRow.Rabatt = custPriceRow.Prozent;
		//      newRow.Menge1 = custPriceRow.Menge1;
		//      newRow.Rabatt1 = custPriceRow.Rabatt1;
		//      newRow.Menge2 = custPriceRow.Menge2;
		//      newRow.Rabatt2 = custPriceRow.Rabatt2;
		//      newRow.Menge3 = custPriceRow.Menge3;
		//      newRow.Rabatt3 = custPriceRow.Rabatt3;
		//      newRow.Menge4 = custPriceRow.Menge4;
		//      newRow.Rabatt4 = custPriceRow.Rabatt4;
		//      newRow.KundenspezifischeArtikelnummer = "";
		//      CurrentDataset.KundenArtikelSonderpreise.AddKundenArtikelSonderpreiseRow(newRow);
		//    }
		//    return taKundenArtikelSonderpreise.Update(CurrentDataset.KundenArtikelSonderpreise);
		//  }
		//  catch (Exception ex)
		//  {
		//    throw ex;
		//  }
		//}
	
		#endregion

		#region Kunden

		/// <summary>
		/// Returns a row with the sales stats of for the given customer.
		/// </summary>
		/// <param name="custNbr"></param>
		/// <returns></returns>
		public dsSage.CustomerSalesRow GetVerkaufsstatistik(string custNbr)
		{
			if (!CustomerSalesInitialized)
			{
				taCustomerSales.Fill(myDS.CustomerSales);
				CustomerSalesInitialized = true;
			}
			return myDS.CustomerSales.FindByKundennummer(custNbr);
		}

		///////////// <summary>
		///////////// Returns the outstanding amounts for the given customer.
		///////////// </summary>
		///////////// <param name="custNbr"></param>
		///////////// <returns></returns>
		//////////public dsSage.UnpaidItemRow GetOffenePostenBetrag(string custNbr)
		//////////{
		//////////  if (!UnpaidItemsInitialized)
		//////////  {
		//////////    taUnpaidItem.Fill(CurrentDataset.UnpaidItem);
		//////////    UnpaidItemsInitialized = true;
		//////////  }
		//////////  return CurrentDataset.UnpaidItem.FindByKontonummer(custNbr);
		//////////}

		/// <summary>
		/// Returns the Euro amount needed for free home delivery.
		/// </summary>
		/// <returns></returns>
		//public decimal GetFrachtfreibetrag(string custNbr)
		//{
		//  if (CustomizedPriceInitializedFor != custNbr || CustomizedPriceInitializedFor == null)
		//  {
		//    GetCustomizedPricesAndProductDetails(custNbr);
		//  }

		//  return CurrentDataset.CustomizedPrice.FindByArtikel("Versandkostenfrei").Kundenpreis;
		//}

		/// <summary>
		/// Returns table Customer.
		/// </summary>
		/// <returns></returns>
		//////////public dsSage.CustomerDataTable GetKundenTabelle()
		//////////{
		//////////  if (!CustomerInitialized)
		//////////  {
		//////////    taCustomer.Fill(CurrentDataset.Customer);
		//////////    CustomerInitialized = true;
		//////////  }
		//////////  return CurrentDataset.Customer;
		//////////}

		public dsSage.kontaktemailDataTable GetContactTabelle()
		{
			if (!ContactMailInitialized)
			{
				taKontaktEmail.Fill(myDS.kontaktemail);
				ContactMailInitialized = true;
			}
			return myDS.kontaktemail;
		}

		public dsSage.kontaktemailRow AddContactEmailRow(string customerId, string contactId)
		{
			var newRow = myDS.kontaktemail.NewkontaktemailRow();
			newRow.Preset = "A";
			newRow.Konto = customerId;
			newRow.AnsprechpartnernummerZumKonto = contactId;
			newRow.URL = string.Empty;
			newRow.Anker = 0;
			newRow.EmailAngebot = "0";
			newRow.EmailAuftrag = "0";
			newRow.EmailDirektrechnung = "0";
			newRow.EmailGutschrift = "0";
			newRow.EmailKontoauszuege = "0";
			newRow.EmailKostenvoranschlag = "0";
			newRow.EmailLastschrifteinzug = "0";
			newRow.EmailLieferschein = "0";
			newRow.EmailMahnungen = "0";
			newRow.EmailProformarechnung = "0";
			newRow.EmailRechnung = "0";
			newRow.EmailSammelrechnung = "0";
			newRow.EmailStornorechnung = "0";
			newRow.EmailVorabbestaetigung = "0";
			newRow.EmailWerkstattauftrag = "0";
			newRow.XML_Export_Direktrechnung = "0";
			newRow.XML_Export_Rechnung = "0";
			newRow.Email24 = string.Empty;
			newRow.Email25 = string.Empty;
			newRow.Email26 = string.Empty;
			newRow.Email27 = string.Empty;
			newRow.Email28 = string.Empty;
			newRow.Email29 = string.Empty;
			newRow.Email30 = string.Empty;

			myDS.kontaktemail.AddkontaktemailRow(newRow);
			UpdateContactEmail();
			return newRow;
		}

		/// <summary>
		/// Looks up the phone numbers of all customers and contacts and returns their corresponding customer id.
		/// </summary>
		/// <param name="fonNbr">The phone number to search for.</param>
		/// <returns>The found customer's id.</returns>
		public string GetCustomerIdByFonNumber(string fonNbr)
		{
			var cRow = this.myDS.Kontaktnummer.FirstOrDefault(c => c.Telefon == fonNbr | c.Handy == fonNbr | c.Autotelefon == fonNbr);
			if (cRow != null) return cRow.Kundennummer;
			return string.Empty;
		}

		/// <summary>
		/// Returns a table with all UPS shippings for the given customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public dsSage.UpsShippingDataTable GetUpsLieferungen(string customerId)
		{
			return taUpsShipping.GetData(customerId);
		}

		#endregion

		#region Offene Posten

		///////////// <summary>
		///////////// Gibt die Tabelle mit allen Offenen Posten im System zurück.
		///////////// </summary>
		///////////// <returns></returns>
		//////////public dsSage.OffenePostenDataTable GetOffenePostenTabelle()
		//////////{
		//////////  return CurrentDataset.OffenePosten;
		//////////}

		#endregion

		#region Transaktionen

		/// <summary>
		/// Returns all transactions containing the given product for the given customer.
		/// </summary>
		/// <param name="customerId">The customer to whom the transactions belong.</param>
		/// <param name="productId">The product we're searching for.</param>
		/// <returns></returns>
		public dsSage.TransactionDataTable GetTransactionsByProduct(string customerId, string productId)
		{
			return this.taTransaction.GetData(customerId, productId);
		}

		#endregion

		#region Umsätze

		///// <summary>
		///// Returns the sales total of the current month for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalThisMonth(string customerId)
		//{
		//  DateTime fromDate = Utils.GetFirstOfMonth(DateTime.Today);
		//  DateTime toDate = DateTime.Today;
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		///// <summary>
		///// Returns the sales total of the previous month for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalPreviousMonth(string customerId)
		//{
		//  DateTime fromDate = Utils.GetFirstOfPreviousMonth(DateTime.Today);
		//  DateTime toDate = Utils.GetLastOfPreviousMonth(DateTime.Today);
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		///// <summary>
		///// Returns the sales total of the current quarter for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalThisQuarter(string customerId)
		//{
		//  DateTime fromDate = Products.Common.Utils.GetFirstOfThisQuarter(DateTime.Today);
		//  DateTime toDate = DateTime.Today;
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		///// <summary>
		///// Returns the sales total of the previous quarter for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalPreviousQuarter(string customerId)
		//{
		//  DateTime fromDate = Products.Common.Utils.GetFirstOfPreviousQuarter(DateTime.Today);
		//  DateTime toDate = Products.Common.Utils.GetLastOfPreviousQuarter(DateTime.Today);
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		///// <summary>
		///// Returns the sales total of the current year for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalThisYear(string customerId)
		//{
		//  DateTime fromDate = new DateTime(DateTime.Today.Year, 1, 1);
		//  DateTime toDate = DateTime.Today;
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		///// <summary>
		///// Returns the sales total of the previous year for the given customer.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotalPreviousYear(string customerId)
		//{
		//  DateTime from = new DateTime(DateTime.Today.Year - 1, 1, 1);
		//  DateTime until = new DateTime(DateTime.Today.Year - 1, 12, 31);
		//  return (decimal?)taQueries.GetSalesTotals(customerId, from, until);
		//}

		///// <summary>
		///// Returns the total sales of the given customer so far.
		///// </summary>
		///// <param name="customerId"></param>
		///// <returns></returns>
		//public decimal? GetSalesTotal(string customerId)
		//{
		//  DateTime fromDate = new DateTime(2005, 1, 1);
		//  DateTime toDate = DateTime.Today;
		//  return (decimal?)taQueries.GetSalesTotals(customerId, fromDate, toDate);
		//}

		/// <summary>
		/// Aktualisiert die Datenbasis für die monatlichen Kundenumsätze.
		/// <remarks>
		/// Das muss nur am Anfang eines Monats gestartet werden, damit der Vormonat
		/// in die Tabelle mit aufgenommen wird.
		/// </remarks>
		/// </summary>
		public void UpdateKundenumsatzTabelle()
		{
			// Kundenumsätze löschen
			this.taQueries.TruncateKundenumsatz();
			this.taKundenumsatz.ClearBeforeFill = true;
			this.taKundenumsatz.Fill(this.myDS.Kundenumsatz);

			//
			var taKundenumsatzBasis = new taKundenumsatzBasis();
			var bTable = taKundenumsatzBasis.GetData();
			foreach (var item in bTable)
			{
				var jan = new DateTime(item.Jahr, 1, 31);
				var feb = new DateTime(item.Jahr, 2, 28);
				var mar = new DateTime(item.Jahr, 3, 31);
				var apr = new DateTime(item.Jahr, 4, 30);
				var may = new DateTime(item.Jahr, 5, 31);
				var jun = new DateTime(item.Jahr, 6, 30);
				var jul = new DateTime(item.Jahr, 7, 31);
				var aug = new DateTime(item.Jahr, 8, 31);
				var sep = new DateTime(item.Jahr, 9, 30);
				var oct = new DateTime(item.Jahr, 10, 31);
				var nov = new DateTime(item.Jahr, 11, 30);
				var dec = new DateTime(item.Jahr, 12, 31);

				// Januar
				var uRowJan = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowJan.Kundennummer = item.Kundennummer;
				uRowJan.Datum = jan;
				uRowJan.Umsatz = item.IsUmsatzJanuarNull() ? 0 : item.UmsatzJanuar;
				uRowJan.Menge = item.IsMengeJanuarNull() ? 0 : item.MengeJanuar;
				uRowJan.RohgewinnAbsolut = item.IsRohgewinnJanuarAbsolutNull() ? 0 : item.RohgewinnJanuarAbsolut;
				uRowJan.RohgewinnProzent = item.IsRohgewinnJanuarProzentNull() ? 0 : item.RohgewinnJanuarProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowJan);

				// Februar
				var uRowFeb = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowFeb.Kundennummer = item.Kundennummer;
				uRowFeb.Datum = feb;
				uRowFeb.Umsatz = item.IsUmsatzFebruarNull() ? 0 : item.UmsatzFebruar;
				uRowFeb.Menge = item.IsMengeFebruarNull() ? 0 : item.MengeFebruar;
				uRowFeb.RohgewinnAbsolut = item.IsRohgewinnFebruarAbsolutNull() ? 0 : item.RohgewinnFebruarAbsolut;
				uRowFeb.RohgewinnProzent = item.IsRohgewinnFebruarProzentNull() ? 0 : item.RohgewinnFebruarProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowFeb);

				// März
				var uRowMar = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowMar.Kundennummer = item.Kundennummer;
				uRowMar.Datum = mar;
				uRowMar.Umsatz = item.IsUmsatzMaerzNull() ? 0 : item.UmsatzMaerz;
				uRowMar.Menge = item.IsMengeMaerzNull() ? 0 : item.MengeMaerz;
				uRowMar.RohgewinnAbsolut = item.IsRohgewinnMaerzAbsolutNull() ? 0 : item.RohgewinnMaerzAbsolut;
				uRowMar.RohgewinnProzent = item.IsRohgewinnMaerzProzentNull() ? 0 : item.RohgewinnMaerzProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowMar);

				// April
				var uRowApr = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowApr.Kundennummer = item.Kundennummer;
				uRowApr.Datum = apr;
				uRowApr.Umsatz = item.IsUmsatzAprilNull() ? 0 : item.UmsatzApril;
				uRowApr.Menge = item.IsMengeAprilNull() ? 0 : item.MengeApril;
				uRowApr.RohgewinnAbsolut = item.IsRohgewinnAprilAbsolutNull() ? 0 : item.RohgewinnAprilAbsolut;
				uRowApr.RohgewinnProzent = item.IsRohgewinnAprilProzentNull() ? 0 : item.RohgewinnAprilProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowApr);

				// Mai
				var uRowMay = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowMay.Kundennummer = item.Kundennummer;
				uRowMay.Datum = may;
				uRowMay.Umsatz = item.IsUmsatzMaiNull() ? 0 : item.UmsatzMai;
				uRowMay.Menge = item.IsMengeMaiNull() ? 0 : item.MengeMai;
				uRowMay.RohgewinnAbsolut = item.IsRohgewinnMaiAbsolutNull() ? 0 : item.RohgewinnMaiAbsolut;
				uRowMay.RohgewinnProzent = item.IsRohgewinnMaiProzentNull() ? 0 : item.RohgewinnMaiProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowMay);

				// Juni
				var uRowJun = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowJun.Kundennummer = item.Kundennummer;
				uRowJun.Datum = jun;
				uRowJun.Umsatz = item.IsUmsatzJuniNull() ? 0 : item.UmsatzJuni;
				uRowJun.Menge = item.IsMengeJuniNull() ? 0 : item.MengeJuni;
				uRowJun.RohgewinnAbsolut = item.IsRohgewinnJuniAbsolutNull() ? 0 : item.RohgewinnJuniAbsolut;
				uRowJun.RohgewinnProzent = item.IsRohgewinnJuniProzentNull() ? 0 : item.RohgewinnJuniProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowJun);

				// Juli
				var uRowJul = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowJul.Kundennummer = item.Kundennummer;
				uRowJul.Datum = jul;
				uRowJul.Umsatz = item.IsUmsatzJuliNull() ? 0 : item.UmsatzJuli;
				uRowJul.Menge = item.IsMengeJuliNull() ? 0 : item.MengeJuli;
				uRowJul.RohgewinnAbsolut = item.IsRohgewinnJuliAbsolutNull() ? 0 : item.RohgewinnJuliAbsolut;
				uRowJul.RohgewinnProzent = item.IsRohgewinnJuliProzentNull() ? 0 : item.RohgewinnJuliProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowJul);

				// August
				var uRowAug = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowAug.Kundennummer = item.Kundennummer;
				uRowAug.Datum = aug;
				uRowAug.Umsatz = item.IsUmsatzAugustNull() ? 0 : item.UmsatzAugust;
				uRowAug.Menge = item.IsMengeAugustNull() ? 0 : item.MengeAugust;
				uRowAug.RohgewinnAbsolut = item.IsRohgewinnAugustAbsolutNull() ? 0 : item.RohgewinnAugustAbsolut;
				uRowAug.RohgewinnProzent = item.IsRohgewinnAugustProzentNull() ? 0 : item.RohgewinnAugustProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowAug);

				// September
				var uRowSep = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowSep.Kundennummer = item.Kundennummer;
				uRowSep.Datum = sep;
				uRowSep.Umsatz = item.IsUmsatzSeptemberNull() ? 0 : item.UmsatzSeptember;
				uRowSep.Menge = item.IsMengeSeptemberNull() ? 0 : item.MengeSeptember;
				uRowSep.RohgewinnAbsolut = item.IsRohgewinnSeptemberAbsolutNull() ? 0 : item.RohgewinnSeptemberAbsolut;
				uRowSep.RohgewinnProzent = item.IsRohgewinnSeptemberProzentNull() ? 0 : item.RohgewinnSeptemberProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowSep);

				// Oktober
				var uRowOct = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowOct.Kundennummer = item.Kundennummer;
				uRowOct.Datum = oct;
				uRowOct.Umsatz = item.IsUmsatzOktoberNull() ? 0 : item.UmsatzOktober;
				uRowOct.Menge = item.IsMengeOktoberNull() ? 0 : item.MengeOktober;
				uRowOct.RohgewinnAbsolut = item.IsRohgewinnOktoberAbsolutNull() ? 0 : item.RohgewinnOktoberAbsolut;
				uRowOct.RohgewinnProzent = item.IsRohgewinnOktoberProzentNull() ? 0 : item.RohgewinnOktoberProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowOct);

				// November
				var uRowNov = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowNov.Kundennummer = item.Kundennummer;
				uRowNov.Datum = nov;
				uRowNov.Umsatz = item.IsUmsatzNovemberNull() ? 0 : item.UmsatzNovember;
				uRowNov.Menge = item.IsMengeNovemberNull() ? 0 : item.MengeNovember;
				uRowNov.RohgewinnAbsolut = item.IsRohgewinnNovemberAbsolutNull() ? 0 : item.RohgewinnNovemberAbsolut;
				uRowNov.RohgewinnProzent = item.IsRohgewinnNovemberProzentNull() ? 0 : item.RohgewinnNovemberProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowNov);

				// Dezember
				var uRowDec = this.myDS.Kundenumsatz.NewKundenumsatzRow();
				uRowDec.Kundennummer = item.Kundennummer;
				uRowDec.Datum = dec;
				uRowDec.Umsatz = item.IsUmsatzDezemberNull() ? 0 : item.UmsatzDezember;
				uRowDec.Menge = item.IsMengeDezemberNull() ? 0 : item.MengeDezember;
				uRowDec.RohgewinnAbsolut = item.IsRohgewinnDezemberAbsolutNull() ? 0 : item.RohgewinnDezemberAbsolut;
				uRowDec.RohgewinnProzent = item.IsRohgewinnDezemberProzentNull() ? 0 : item.RohgewinnDezemberProzent;
				this.myDS.Kundenumsatz.AddKundenumsatzRow(uRowDec);
			}
			this.taKundenumsatz.Update(this.myDS.Kundenumsatz);
		}

		#endregion

		#region +++ Update +++

		/// <summary>
		/// Update table kontaktemail.
		/// </summary>
		/// <returns></returns>
		public int UpdateContactEmail()
		{
			return taKontaktEmail.Update(myDS.kontaktemail);
		}

		#endregion

		#region bullshit

		/// <summary>
		/// Das funktioniert nicht. Nur ein kleiner Scherz ...
		/// </summary>
		public int UpdateCustomerTable()
		{
			throw new Exception("Bist Du behämmert? Du kannst keine Kunden ändern. Depp!");
		}

		#endregion

		#endregion

		#region private procedures

		// Drei Sekunden lang versuchen, den MySQL Server in der Firma zu erreichen.
		// Wenn der unerreichbar ist, wird FALSE zurückgeliefert.
		private bool ConnectMySqlCPM() 
		{
			try
			{
				var reply = new Ping().Send("192.168.0.101", 2000);
				if (reply.Status == IPStatus.Success)
				{
					return true;
				}
				else return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		void InitializeAdapters()
		{
			string conLocal = global::Products.Data.Properties.Settings.Default.conSageLocal;

			if (!ConnectMySqlCPM())
			{
				taArtikel.Connection.ConnectionString = conLocal;
				this.taCustomerContact.Connection.ConnectionString = conLocal;
				this.taCustomerSales.Connection.ConnectionString = conLocal;
				this.taInvoice.Connection.ConnectionString = conLocal;
				this.taKontaktEmail.Connection.ConnectionString = conLocal;
				this.taKontaktnummer.Connection.ConnectionString = conLocal;
				this.taKundenumsatz.Connection.ConnectionString = conLocal;
				this.taOrder.Connection.ConnectionString = conLocal;
				this.taOrderDetail.Connection.ConnectionString = conLocal;
				this.taTransaction.Connection.ConnectionString = conLocal;
				this.taUnpaidItem.Connection.ConnectionString = conLocal;
			}
		}

		void InitializePermanentData()
		{
			this.taInvoice.Fill(this.myDS.Invoice);
			this.taKontaktnummer.Fill(this.myDS.Kontaktnummer);
			this.taKundenumsatz.Fill(this.myDS.Kundenumsatz);
			this.taOffenePosten.Fill(this.myDS.OffenePosten);
			this.taVersandkostenstaffel.Fill(this.myDS.Versandkostenstaffel);

			// this.myDS.kontaktemail.kontaktemailRowChanged += Kontaktemail_kontaktemailRowChanged;
		}


		/// <summary>
		/// Syncs table Artikelzusatz. Which is, new products in Sage are added 
		/// and deactivated products are deleted from table Artikelzusatz.
		/// This is needed to provide referencial integrity between table Kundenpreis 
		/// and table Artikelzusatz.
		/// </summary>
		/// <returns></returns>
		//private int SyncProducts()
		//{
		//  int counter = 0;
		//  foreach (dsSage.CustomizedPriceRow row in CurrentDataset.CustomizedPrice)
		//  {
		//    if (row.GetProductDetailRows().Length == 0)
		//    {
		//      dsSage.ProductDetailRow newRow = CurrentDataset.ProductDetail.NewProductDetailRow();
		//      newRow.Artikel = row.Artikel;
		//      newRow.CheckedFlag = 0;
		//      newRow.InactiveFlag = 0;
		//      newRow.ChangeUser = Common.Global.UserName(Environment.UserName);
		//      newRow.ChangeDate = DateTime.Now;
		//      CurrentDataset.ProductDetail.AddProductDetailRow(newRow);
		//      counter += 1;
		//    }
		//  }

		//  foreach (dsSage.ProductDetailRow row in CurrentDataset.ProductDetail)
		//  {
		//    if (row.KundenpreisRow == null)
		//    {
		//      row.InactiveFlag = 1;
		//      //row.Delete();
		//      counter += 1;
		//    }
		//  }
		//  taProductDetail.Update(CurrentDataset.ProductDetail);
		//  return counter;
		//}

		//void ResetCustomerDataTables()
		//{
		//  this.CustomerInitialized = false;
		//  this.CustomizedPriceInitializedFor = null;
		//  this.ProductDetailsInitialized = false;
		//  this.OrderInitializedFor = null;
		//  this.OfferInitialized = false;
		//}

		#endregion

		#region events

		//////////void CustomerHasChangedEvent(object sender, dsSage.CustomerRowChangeEvent e)
		//////////{
		//////////  if (OnCustomerChanged != null)
		//////////  {
		//////////    OnCustomerChanged(sender, e);
		//////////  }
		//////////}

		//void Kontaktemail_kontaktemailRowChanged(object sender, dsSage.kontaktemailRowChangeEvent e)
		//{
		//	throw new NotImplementedException();
			//if (e.Action == System.Data.DataRowAction.Change)
			//{
			//  if (e.Row.EmailKostenvoranschlag == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in cRow.get .GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailKostenvoranschlag = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailAngebot == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailAngebot = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailAuftrag == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailAuftrag = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailDirektrechnung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailDirektrechnung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailGutschrift == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailGutschrift = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailKontoauszuege == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailKontoauszuege = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailLastschrifteinzug == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailLastschrifteinzug = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailLieferschein == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailLieferschein = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailMahnungen == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailMahnungen = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailProformarechnung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailProformarechnung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailRechnung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailRechnung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailSammelrechnung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailSammelrechnung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailStornorechnung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailStornorechnung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailVorabbestaetigung == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailVorabbestaetigung = "0";
			//      }
			//    }
			//  }

			//  if (e.Row.EmailWerkstattauftrag == "1")
			//  {
			//    foreach (dsSage.kontaktemailRow cRow in e.Row.CustomerRow.GetkontaktemailRows())
			//    {
			//      if (!cRow.Equals(e.Row))
			//      {
			//        cRow.EmailWerkstattauftrag = "0";
			//      }
			//    }
			//  }

			//  this.UpdateContactEmail();
			//}
		//}

		#endregion

		#region Test

		/// <summary>
		/// Test einer Abfrage auf die MySQL Datenbank mit Datumsparametern.
		/// </summary>
		/// <returns></returns>
		public long Test()
		{
			var fromDate = DateTime.Today.AddYears(-1).ToString("yyy-MM-dd");
			var toDate = DateTime.Today.ToString("yyy-MM-dd");
			var retObject = taQueries.GetCustomerCount(fromDate, toDate);
			return (long)retObject;
		}

		#endregion

	}
}
