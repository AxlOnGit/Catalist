using System;
using System.Collections.Generic;
using System.Data;
using System.Device.Location;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Common.Collections;
using Products.Common.Extensions;
using Products.Common.Geocoding;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Kunde : ILinkedItem
	{
		#region members

		dsCustomer.CustomerRow myBase;
		dsCustomer.KundeRow myKundeRow;
		SBList<Tour> myTourList;
		Kundenkontakt myHauptKontakt;
		Kunde myReferenzkunde;
		readonly string newLine = Environment.NewLine;
		readonly DateTime today = DateTime.Today;

		#endregion members

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.Kundennummer; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Kunde").UID; }
		}

		public string ItemName
		{
			get { return string.Format(@"{0} ({1})", myBase.Name1, this.KundenNrCpm); }
		}

		public string LinkTypBezeichnung
		{
			get { return "Kunde"; }
		}

		#endregion ILinkedItem

		#region skalare

		#region Basics

		/// <summary>
		/// Gibt True zurück, wenn der Kunde inaktiv ist.
		/// </summary>
		public bool Inactive
		{
			get { return this.myBase.Statuskennzeichen.ToLower() == "ja"; }
		}

		/// <summary>
		/// Returns the CustomerRow on which this customer is based on.
		/// </summary>
		dsCustomer.CustomerRow BaseRow { get { return myBase; } }

		/// <summary>
		/// Gibt die 10-stellige Kundennummer (Primärschlüssel) des Kunden zurück.
		/// </summary>
		public string CustomerId { get { return this.myBase.Kundennummer; } }

		/// <summary>
		/// Gibt die bei CPM gebräuchliche 5-stellige Kundennummer zurück.
		/// </summary>
		public string KundenNrCpm { get { return this.myBase.Kundennummer.Substring(0, 5); } }

		/// <summary>
		/// Returns the customer's company name.
		/// </summary>
		public string CompanyName1 { get { return string.Format(@"{0}", myBase.Name1); } }

		/// <summary>
		/// Returns additions to the company's name such as the company's owner or main contact.
		/// </summary>
		public string CompanyName2 { get { return myBase.Name2; } }

		/// <summary>
		/// Gibt den Matchcode dieses Kunden zurück.
		/// </summary>
		public string Matchcode
		{
			get
			{
				if (this.CustomerId.Equals("1000000000", StringComparison.CurrentCultureIgnoreCase)) return "CPM";
				return myBase.Kurzbezeichnung;
			}
		}

		/// <summary>
		/// Returns the company's street.
		/// </summary>
		public string Street { get { return myBase.Strasse; } }

		/// <summary>
		/// Returns the customer's zip code.
		/// </summary>
		public string ZipCode { get { return myBase.Postleitzahl; } }

		/// <summary>
		/// Returns the customer's city.
		/// </summary>
		public string City { get { return myBase.Ort; } }

		/// <summary>
		/// Gibt die Telefonnummer des Hauptkontakts zurück.
		/// </summary>
		public string Telefon
		{
			get
			{
				if (this.Hauptkontakt != null)
				{
					return this.Hauptkontakt.Telefon;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt die E-Mail Adresse des Hauptkontakts zurück.
		/// </summary>
		public string Email
		{
			get
			{
				if (this.Hauptkontakt != null)
				{
					return this.Hauptkontakt.E_Mail;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Seit wann sind die bei uns Kunde?
		/// </summary>
		public DateTime Anlagedatum
		{
			get { return this.myBase.Anlagedatum; }
		}

		/// <summary>
		/// Name des Hauptkontakts.
		/// </summary>
		public string HauptkontaktName
		{
			get
			{
				if (this.Hauptkontakt != null)
				{
					return this.Hauptkontakt.Kontaktname;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt den 3-stelligen Vertreter-Code zurück.
		/// </summary>
		public string Vertreter
		{
			get { return this.myBase.Vertreter1; }
		}

		/// <summary>
		/// Returns a flag indicating whether the customer is marked for a dunning letter or already
		/// has received one.
		/// </summary>
		public bool DunningFlag { get { return myBase.Sperrvermerk1 == "1"; } }

		/// <summary>
		/// Returns a flag indicating whether the customer's deliveries are halted.
		/// </summary>
		public bool DeliveryStopFlag { get { return myBase.Sperrvermerk2 == "1"; } }

		/// <summary>
		/// Returns a flag indicating whether the customer has to pay his orders prior to delivery.
		/// </summary>
		public bool AdvancePaymentFlag { get { return myBase.Sperrvermerk3 == "1"; } }

		/// <summary>
		/// Gibt das Zahlungsziel in Tagen an, ab dem der Rechnungsbetrag ohne Skonto fällig wird.
		/// </summary>
		public short ZahlungenTageNetto { get { return myBase.Zahlungskond_1_TageNetto; } }

		/// <summary>
		/// Gibt das Zahlungsziel in Tagen an, bis zu dem vom Rechnungsbetrag Skonto gezogen werden
		/// darf. Der Skontosatz ergibt sich aus ZahlungenProzent.
		/// </summary>
		public short ZahlungenTageSkonto { get { return myBase.Zahlungskond_1_TageSkonto1; } }

		/// <summary>
		/// Gibt den Skontosatz in Prozent zurück.
		/// </summary>
		public decimal ZahlungenProzent { get { return myBase.Zahlungskond_1_Prozent1; } }

		/// <summary>
		/// Text der Zahlungsbedingungen dieses Kunden.
		/// </summary>
		public string Zahlungsbedingungen
		{
			get
			{
				return string.Format("Ihre Zahlungsbedingungen: {0} Tage netto, {1} Tage {2:N1}% Skonto", this.ZahlungenTageNetto, this.ZahlungenTageSkonto, this.ZahlungenProzent);
			}
		}

		/// <summary>
		/// Kurzform der Zahlungsbedingungen.
		/// </summary>
		/// <returns></returns>
		string PaymentTermsShort()
		{
			return string.Format("{0} Tage netto, {1} Tage {2:N0}% Skonto", this.ZahlungenTageNetto, this.ZahlungenTageSkonto, this.ZahlungenProzent);
		}

		/// <summary>
		/// Gibt die Anzahl der Maschinen dieses Kunden zurück.
		/// </summary>
		public int AnzahlMaschinen
		{
			get
			{
				return 0;
				//return this.Kundenmaschinenliste.Count;
			}
		}

		/// <summary>
		/// Gibt die Anzahl der Aufträge dieses Kunden zurück.
		/// </summary>
		public int AnzahlAuftraege
		{
			get
			{
				return 0;
				//return this.Auftragsliste.Count(a => a.Vorgang == "A");
			}
		}

		/// <summary>
		/// Gibt die Anzahl der Rechnungen und Direktrechnungen dieses Kunden zurück.
		/// </summary>
		public int AnzahlRechnungen
		{
			get
			{
				return 0;
				//return this.Auftragsliste.Count(a => a.Vorgang == "D" | a.Vorgang == "R");
			}
		}

		/// <summary>
		/// Gibt die Anzahl der Angebote für diesen Kunden zurück.
		/// </summary>
		public int AnzahlAngebote
		{
			get
			{
				return 0;
				//return this.Angebotsliste.Count;
			}
		}

		/// <summary>
		/// Gibt die Anzahl der Ansprechpartner bei diesem Kunden zurück.
		/// </summary>
		public int AnzahlKontakte
		{
			get
			{
				return 0;
				//return this.Kontaktlist.Count;
			}
		}

		/// <summary>
		/// Gibt die Anzahl der zukünftigen Servicetermine zurück.
		/// </summary>
		public int AnzahlServicetermine
		{
			//APPT: Kunde -> AnzahlServicetermine
			get { return 0; }
		}

		/// <summary>
		/// Gibt die Anzahl der installierten Programme bei diesem Kunden zurück.
		/// </summary>
		public int AnzahlSoftware
		{
			get
			{
				return 0;
				//return this.Softwareliste.Count;
			}
		}

		public decimal FocAmount
		{
			get
			{
				if (this.Versandstaffelpreisliste.Count > 0)
				{
					var freiPreis = this.Versandstaffelpreisliste.FirstOrDefault(v => v.AbWert > 0 && v.Versandkosten == 0);
					if (freiPreis != null)
					{
						return freiPreis.AbWert;
					}
					else return 0;
				}
				return 0;
			}
		}

		/// <summary>
		/// Gibt die Frachtfreigrenze als Text zurück.
		/// </summary>
		public string FocText
		{
			get
			{
				if (this.Versandstaffelpreisliste.Count > 0)
				{
					var freiPreis = this.Versandstaffelpreisliste.FirstOrDefault(v => v.AbWert > 0 && v.Versandkosten == 0);
					if (freiPreis != null)
					{
						if (freiPreis.AbWert < 0.5m)
						{
							return "Ihre Lieferungen erhalten Sie von uns immer frachtfrei.";
						}
						else
						{
							return string.Format("Wir beliefern Sie frachtfrei ab einem Bestellwert von {0:N2} EUR netto.", freiPreis.AbWert);
						}
					}
					else return "Für Lieferungen unter 250,- EUR netto fällt die normale Frachtkostenpauschale i.H.v. derzeit 8,50 EUR an.";
				}
				else return "Für Lieferungen unter 250,- EUR fällt die normale Frachtkostenpauschale i.H.v. derzeit 8,50 EUR an.";
			}
		}

		/// <summary>
		/// Gibt das Datum des letzten Besuchstermins zurück.
		/// </summary>
		public DateTime? LetzterBesuchstermin
		{
			get
			{
				if (this.KundenRow.IsLetzterBesuchsterminNull())
				{
					return null;
				}
				return this.KundenRow.LetzterBesuchstermin;
			}
			set
			{
				if (value.HasValue)
				{
					this.KundenRow.LetzterBesuchstermin = value.Value;
				}
				else this.KundenRow.SetLetzterBesuchsterminNull();
			}
		}

		/// <summary>
		/// Gibt den nächsten Besuchstermin bei diesem Kunden zurück oder legt ihn fest.
		/// </summary>
		public DateTime? NaechsterBesuchstermin
		{
			get
			{
				if (this.KundenRow.IsNaechsterBesuchsterminNull())
				{
					return null;
				}
				return this.KundenRow.NaechsterBesuchstermin;
			}
			set
			{
				if (value.HasValue)
				{
					this.KundenRow.NaechsterBesuchstermin = value.Value;
				}
				else this.KundenRow.SetNaechsterBesuchsterminNull();
			}
		}

		#endregion Basics

		#region Umsätze

		public decimal GetAmountSalesThisMonth()
		{
			var from = Utils.GetFirstOfMonth(today);
			var to = Utils.GetLastOfMonth(today);
			return ModelManager.SalesService.GetSalesTotals(this, from, to);
		}

		public decimal GetAmountSalesPreviousMonth()
		{
			var from = Utils.GetFirstOfPreviousMonth(today);
			var to = Utils.GetLastOfPreviousMonth(today);
			return ModelManager.SalesService.GetSalesTotals(this, from, to);
		}

		public decimal GetAmountSalesThisQuarter()
		{
			var from = Utils.GetFirstOfThisQuarter(today);
			var to = Utils.GetLastOfThisQuarter(today);
			return ModelManager.SalesService.GetSalesTotals(this, from, to);
		}

		public decimal GetAmountSalesPreviousQuarter()
		{
			var from = Utils.GetFirstOfPreviousQuarter(today);
			var to = Utils.GetLastOfPreviousQuarter(today);
			return ModelManager.SalesService.GetSalesTotals(this, from, to);
		}

		public decimal GetAmountSalesThisYear()
		{
			var from = new DateTime(DateTime.Today.Year, 1, 1);
			return ModelManager.SalesService.GetSalesTotals(this, from, today);
		}

		public decimal GetAmountSalesPreviousYear()
		{
			var from = new DateTime(DateTime.Today.Year - 1, 1, 1);
			var to = new DateTime(DateTime.Today.Year - 1, 12, 31);
			return ModelManager.SalesService.GetSalesTotals(this, from, to);
		}

		public decimal GetAmountSalesTotal()
		{
			var from = today.AddYears(-20);
			return ModelManager.SalesService.GetSalesTotals(this, from, today);
		}

		/// <summary>
		/// Returns the total amount of all unpaid sales.
		/// </summary>
		public decimal OffenePostenTotal
		{
			get
			{
				return ModelManager.SalesService.GetOffenePostenTotal(this);
			}
		}

		#region Umsatzstatistiken

		///////////// <summary>
		///////////// Gibt eine sortierbare Liste aller Monatsumsätze dieses Kunden zurück.
		///////////// </summary>
		///////////// <returns></returns>
		//////////public SBList<KundenMonatsumsatz> GetMonatsumsatzliste()
		//////////{
		//////////  return ModelManager.ModelService.GetMonatsumsatz(this);
		//////////}

		/// <summary>
		/// Gibt den Umsatzdurchschnit dieses Kunden zurück.
		/// </summary>
		/// <returns></returns>
		public double GetSalesAverageAmount()
		{
			var liste = new List<double>();
			var sList = ModelManager.SalesService.GetSalesStats(this);
			foreach (var item in sList)
			{
				if (item.Datum < DateTime.Today)
				{
					liste.Add((double)item.Umsatz);
				}
			}
			return liste.Median();
		}

		#endregion Umsatzstatistiken

		#endregion Umsätze

		#region cpm_kunde

		// Für den Vertrieb

		/// <summary>
		/// Gibt generelle Informationen zu diesem Kunden zurück oder legt sie fest.
		/// </summary>
		public string Anmerkungen
		{
			get { return this.KundenRow.Anmerkungen; }
			set { this.KundenRow.Anmerkungen = value; }
		}

		/// <summary>
		/// Das Besuchsintervall in Monaten.
		/// </summary>
		public int Besuchsintervall
		{
			get { return this.KundenRow.Besuchsintervall; }
			set { this.KundenRow.Besuchsintervall = value; }
		}

		/// <summary>
		/// Gibt die normalerweise veranschlagte Besuchszeit bei diesem Kunden zurück.
		/// </summary>
		public int Besuchszeit
		{
			get { return this.KundenRow.Besuchszeit; }
			set { this.KundenRow.Besuchszeit = value; }
		}

		/// <summary>
		/// Kennzeichen, ob Besuche nur mit Anmeldung stattfinden sollten.
		/// </summary>
		public bool MitAnmeldungFlag
		{
			get { return (this.KundenRow.MitAnmeldungFlag == 1); }
			set { this.KundenRow.MitAnmeldungFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, ob für Termine eine Kurzpreisliste ausgedruckt werden soll.
		/// </summary>
		public bool KurzpreislisteFlag
		{
			get { return (this.KundenRow.KurzpreislisteFlag == 1); }
			set { this.KundenRow.KurzpreislisteFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, ob für Termine eine Vorjahresvergleich ausgedruckt werden soll.
		/// </summary>
		public bool VorjahresvergleichFlag
		{
			get { return (this.KundenRow.VorjahresvergleichFlag == 1); }
			set { this.KundenRow.VorjahresvergleichFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, ob für Termine die Umsätze seit dem letztem Besuch ausgedruckt werden sollen.
		/// </summary>
		public bool UmsatzSeitLetztemBesuchFlag
		{
			get { return (this.KundenRow.UmsatzSeitLetztemBesuchFlag == 1); }
			set { this.KundenRow.UmsatzSeitLetztemBesuchFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, ob für Termine das zuletzt erstellte Angebot ausgedruckt werden soll.
		/// </summary>
		public bool AusdruckLetztesAngebotFlag
		{
			get { return (this.KundenRow.AusdruckLetztesAngebotFlag == 1); }
			set { this.KundenRow.AusdruckLetztesAngebotFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, dass für Termine keine Vorbereitungen erforderlich sind.
		/// </summary>
		public bool OhneVorbereitungFlag
		{
			get { return (this.KundenRow.OhneVorbereitungFlag == 1); }
			set { this.KundenRow.OhneVorbereitungFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Kennzeichen, ob dieser Kunden einen Weihnachtsbesuch bekommt.
		/// </summary>
		public bool WeihnachtsFlag
		{
			get { return (this.KundenRow.WeihnachtsFlag == 1); }
			set { this.KundenRow.WeihnachtsFlag = (value == true) ? 1 : 0; }
		}

		/// <summary>
		/// Gibt die Wettbewerber des Kunden zurück.
		/// </summary>
		public string Wettbewerber
		{
			get { return this.KundenRow.Wettbewerber; }
			set { this.KundenRow.Wettbewerber = value; }
		}

		/// <summary>
		/// Wird im Text von Terminen ganz oben als Hinweis für den Außendienst (oder wen immer) angezeigt.
		/// </summary>
		public string AktuellerHinweis
		{
			get { return this.KundenRow.AktuellerHinweis; }
			set { this.KundenRow.AktuellerHinweis = value; }
		}

		#endregion cpm_kunde

		#region Geo-Koordinaten

		/// <summary>
		/// Gibt den Kunden zurück, zu dem die Entfernung gemessen wird, die von der Eigenschaft
		/// 'EntfernungZuReferenzkunde' zurückgegeben wird.
		/// </summary>
		public Kunde Referenzkunde
		{
			get
			{
				return this.myReferenzkunde;
			}
			set
			{
				if (!this.myReferenzkunde.Equals(value))
				{
					this.myReferenzkunde = value;
				}
			}
		}

		/// <summary>
		/// Gibt Längen- und Breitengrad der Kundenadresse zurück.
		/// </summary>
		public GeoCoordinate Adresskoordinaten
		{
			get
			{
				GeoCoordinate result = null;
				if (!this.KundenRow.IsLatitudeNull() && !this.KundenRow.IsLongitudeNull())
				{
					result = new GeoCoordinate(this.myKundeRow.Latitude, this.myKundeRow.Longitude);
				}
				return result;
			}
		}

		/// <summary>
		/// Gibt die Entfernung in Kilometern zwischen der Adresse dieses Kunden und dem in der
		/// Eigenschaft 'Referenzkunde' gespeicherten Kunden zurück.
		/// </summary>
		public double EntfernungZuReferenzkunde
		{
			get
			{
				if (this.myReferenzkunde == null) this.myReferenzkunde = ModelManager.CustomerService.GetKunde("1000000000", false);
				if (this.Referenzkunde.Adresskoordinaten == null) ModelManager.CustomerService.GetAdresskoordinaten(this.Referenzkunde);
				if (this.Adresskoordinaten != null)
				{
					var luftlinie = GeoData.GetDistance(this.Adresskoordinaten.Latitude, this.Adresskoordinaten.Longitude, this.Referenzkunde.Adresskoordinaten.Latitude, this.Referenzkunde.Adresskoordinaten.Longitude);
					return luftlinie * 1.3;
				}
				return 0.0;
			}
		}

		#endregion Geo-Koordinaten

		#endregion skalare

		#region entities

		/// <summary>
		/// Returns an unfiltered table with all orders for this customer.
		/// </summary>
		public dsSage.OrderDataTable Auftragsliste
		{
			get
			{
				return DataManager.AllDataService.GetTabelleOrdersPerKunde(this.CustomerId);
			}
		}

		/// <summary>
		/// Returns a list of all offers for this customer.
		/// </summary>
		public SBList<Offer> OfferList
		{
			get
			{
				return ModelManager.OfferService.GetOfferList(this.CustomerId);
			}
		}

		/// <summary>
		/// Gibt den Hauptkontakt dieses Kunden zurück.
		/// </summary>
		public Kundenkontakt Hauptkontakt
		{
			get
			{
				if (this.myHauptKontakt == null)
				{
					this.myHauptKontakt = this.Kontaktlist.FirstOrDefault(k => k.Nummer == myBase.Ansprechpartner_Nummer);
				}
				return this.myHauptKontakt;
			}
		}

		/// <summary>
		/// Returns a list of all contacts for this customer.
		/// </summary>
		public SortableBindingList<Kundenkontakt> Kontaktlist
		{
			get
			{
				return Model.ModelManager.ContactService.GetContactListForCustomer(this.CustomerId);
			}
		}

		/// <summary>
		/// Gibt eine Liste aller Notizen für diesen Kunden zurück.
		/// </summary>
		public SBList<Notiz> Notizlist
		{
			get
			{
				return ModelManager.NotesService.GetNotesList(this.CustomerId, ModelManager.SharedItemsService.GetLinkTypeByName("Kunde").UID);
			}
		}

		/// <summary>
		/// Returns a table with all UPS shipments of this customer.
		/// </summary>
		/// <returns></returns>
		public dsSage.UpsShippingDataTable UpsLieferungenList()
		{
			return Data.DataManager.AllDataService.GetUpsLieferungen(CustomerId);
		}

		/// <summary>
		/// Returns all history items of this customer.
		/// </summary>
		/// <returns></returns>
		//////public SortableBindingList<HistoryItem> Historienliste()
		//////{
		//////  return ModelManager.ModelService.GetHistorienElemente(this);
		//////}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Touren zurück, zu denen dieser Kunde gehört.
		/// </summary>
		public SBList<Tour> Tourliste
		{
			get
			{
				if (this.myTourList == null)
				{
					this.myTourList = new SBList<Tour>();
					foreach (var item in ModelManager.SalesForceService.GetTourList())
					{
						if (item.Tourkunden.FirstOrDefault(k => k.CustomerId == this.CustomerId) != null)
						{
							this.myTourList.Add(item);
						}
					}
				}
				return this.myTourList;
			}
		}

		/// <summary>
		/// Gibt die Versandkostenstaffel für diesen Kunden zurück.
		/// </summary>
		public SBList<Versandstaffelpreis> Versandstaffelpreisliste
		{
			get
			{
				return ModelManager.SalesService.GetVersandstaffel(this.CustomerId);
			}
		}

		#endregion entities

		#endregion public properties

		#region private properties

		dsCustomer.KundeRow KundenRow
		{
			get
			{
				if (this.myKundeRow == null)
				{
					// Gibt die entsprechende Zeile aus der Tabelle Kunde zurück oder legt ggf. eine
					// neue Zeile an.
					myKundeRow = DataManager.CustomerDataService.GetKunde(this.CustomerId);
					if (this.myKundeRow == null)
					{
						this.myKundeRow = ModelManager.CustomerService.AddKunde(this);
					}
				}
				return this.myKundeRow;
			}
		}

		#endregion private properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="Kunde"/> Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Kunde(dsCustomer.CustomerRow baseRow)
		{
			this.myBase = baseRow;
			//ModelManager.NotesService.NoteCreated += new EventHandler<NotesService.NoteCreatedEventArgs>(NotesService_NoteCreated);
			//ModelManager.NotesService.NoteDeliting += new EventHandler<NotesService.NoteDeletedEventArgs>(NotesService_NoteDeleted);
		}

		#endregion ### .ctor ###

		#region event handler

		//void NotesService_NoteCreated(object sender, NotesService.NoteCreatedEventArgs e)
		//{
		//	if (e.Notiz.ParentItemId == this.myBase.Kundennummer)
		//	{
		//		this.Notizlist.Add(e.Notiz);
		//	}
		//}

		//void NotesService_NoteDeleted(object sender, NotesService.NoteDeletedEventArgs e)
		//{
		//	if (e.Note.ParentItemId == this.myBase.Kundennummer)
		//	{
		//		this.Notizlist.Remove(e.Note);
		//	}
		//}

		#endregion event handler

		#region public procedures

		/// <summary>
		/// Stellt eine Telefonverbindung zum Hauptansprechpartner dieses Kunden her.
		/// </summary>
		public void CallMainContact()
		{
			if (this.Hauptkontakt != null)
			{
				ModelManager.ContactService.CallContact(this.Hauptkontakt);
			}
		}

		/// <summary>
		/// Gibt eine Liste der Software für die angegebene Maschine zurück.
		/// </summary>
		/// <param name="myMachine"></param>
		/// <returns></returns>
		public SBList<Kundensoftware> GetKundenmaschinenSoftware(Kundenmaschine myMachine)
		{
			return ModelManager.SoftwareService.GetMachinesSoftware(myMachine);
		}

		/// <summary>
		/// Öffnet das Standard-Mailprogramm mit einer neuen E-Mail an den Hauptkontakt dieses Kunden.
		/// </summary>
		public void MailToMainContact()
		{
			if (this.Hauptkontakt != null && !string.IsNullOrEmpty(this.Hauptkontakt.E_Mail))
			{
				ModelManager.PostBuedel.SendMailViaDefaultMailer(this.Hauptkontakt.E_Mail);
			}
		}

		/// <summary>
		/// Opens the customers address in BING Maps.
		/// </summary>
		public void OpenInBingMaps()
		{
			try
			{
				var psi = new ProcessStartInfo(Global.CreateBingMapsURL(this.Street, this.ZipCode + " " + City));
				Process.Start(psi);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Opens this user in Sage New Classic fuck piss program.
		/// </summary>
		public void OpenInSage(string exePath)
		{
			var paramString = string.Format(" /M001 /X\"PA1110|00000\" /B/P\"{0}\"", this.CustomerId);
			var psi = new ProcessStartInfo(exePath, paramString);
			Process.Start(psi);
		}

		#region HTML

		public string GetCustomerInfoHtml(Kundenkontakt contact)
		{
			var sb = new StringBuilder();
			sb.AppendFormat(@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">{0}", newLine);
			sb.AppendFormat("<html><head>{0}", newLine);
			sb.AppendFormat(@"<meta content=""text/html; charset=utf-8"" http-equiv=Content-Type>{0}", newLine);
			sb.AppendFormat(@"<meta name=GENERATOR content=""MSHTML 11.00.10586.3"">{0}", newLine);
			sb.AppendFormat(@"<body>{0}", newLine);

			// Allgemeine Infos vorab
			if (!string.IsNullOrEmpty(this.KundenRow.Anmerkungen))
			{
				sb.AppendFormat("<p><font face=Calibri size=2 color=red><u>Anmerkungen</u><br>{0}</font></p>", this.KundenRow.Anmerkungen);
			}

			if (contact != null)
			{
				sb.AppendFormat("<p><font face=Calibri size=4>{0}</font><br>", this.CompanyName1);
				sb.AppendFormat("<font face=Calibri size=2><u>Kontakt</u><br>{0}<br>", contact.Kontaktname);
				sb.Append(string.Format("E-Mail: {0} <br>", contact.E_Mail));
				if (contact.Webshopkunde)
				{
					sb.Append("Kontakt hat einen Webshop Account");
				}
				sb.Append("</font></p>");
			}

			sb.AppendFormat("<p><font face=Calibri size=2>{0}<br>{1} {2}<br>Telefon: {3}</font></p>", this.Street, this.ZipCode, this.City, this.Telefon);

			sb.Append(@"<table cellPadding=0><tbody>");

			sb.Append(@"<tr><td align=""right""><font face=Calibri size=2><strong><u>Zeit</u></strong></font></td>");
			sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>&nbsp;Aktuell</u></strong></font></td>");
			sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>&nbsp;Vorher</u></strong></font></td></tr>");

			sb.Append(@"<tr><td align=""right""><font face=Calibri size=2>Monat:</font></TD>");
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td>", this.GetAmountSalesThisMonth());
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td></tr>", this.GetAmountSalesPreviousMonth());

			sb.Append(@"<tr><td align=""right""><font face=Calibri size=2>Quartal:</font></td>");
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td>", this.GetAmountSalesThisQuarter());
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td></tr>", this.GetAmountSalesPreviousQuarter());

			sb.Append(@"<tr><td align=""right""><font face=Calibri size=2>Jahr:</font></td>");
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td>", this.GetAmountSalesThisYear());
			sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0:C2}</font></td></tr>", this.GetAmountSalesPreviousYear());

			sb.Append(@"<tr><td align=""right""><u><font face=Calibri size=2>Gesamt:</font></u></td>");
			sb.AppendFormat(@"<td colspan=""2""><u><font face=Calibri size=2>&nbsp;{0:C2}</font></u></td></tr></tbody></table><br>", this.GetAmountSalesTotal());

			sb.Append(this.GetLastProductsSoldHtml());

			// Besuchsintervall
			sb.AppendFormat("<p><font face=Calibri size=2><u>Besuchsintervall</u><br>Alle {0} Monate (etwa {1} Minuten)</font></p>", this.Besuchsintervall, this.Besuchszeit);

			// Wettbewerber
			if (!string.IsNullOrEmpty(this.KundenRow.Wettbewerber))
			{
				sb.AppendFormat("<p><font face=Calibri size=2><u>Wettbewerber</u><br>{0}</font></p>", this.KundenRow.Wettbewerber);
			}

			// Maschinenliste
			if (ModelManager.MachineService.GetKundenMaschineList(this.CustomerId).Count > 0)
			{
				sb.Append("<div><font face=Calibri size=2><u>Maschinen</u></font></div><ul>");
				foreach (var item in this.GetMaschinenListeText())
				{
					sb.AppendFormat("<li><font face=Calibri size=2>{0}</font></li>", item);
				}
				sb.Append("</ul>");
			}

			// Frei-Haus-Lieferungen
			sb.AppendFormat("<p><font face=Calibri size=2><u>Frei-Haus ab</u><br>{0:C2}</font></p>", this.FocAmount);

			// Zahlungsziele
			sb.AppendFormat("<p><font face=Calibri size=2><u>Zahlungsziel</u><br>{0}</font></p>", this.PaymentTermsShort());

			// Vertreter
			sb.AppendFormat("<p><font face=Calibri size=2><u>Vertreter</u><br>{0}</font></p>", this.myBase.Vertreter1);

			return sb.ToString();
		}

		public string GetLastProductsSoldHtml()
		{
			var sb = new StringBuilder();
			var sales = ModelManager.SalesService.GetSalesTable(this.CustomerId);
			if (sales.Count > 10)
			{
				sb.Append(@"<table cellPadding=0><tbody>");
				sb.Append(@"<tr><td><font face=Calibri size=2><strong><u>Datum</u></strong></font></td>");
				sb.Append(@"<td><font face=Calibri size=2><strong><u>Artikel</u></strong></font></td>");
				sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>&nbsp;Menge</u></strong></font></td></tr>");
				for (int i = 0; i < 10; i++)
				{
					sb.AppendFormat(@"<tr><td><font face=Calibri size=2>{0}&nbsp;</font></TD>", sales[i].Datum.ToShortDateString());
					sb.AppendFormat(@"<td align=""left""><font face=Calibri size=2>{0}</font></td>", sales[i].Bezeichnung1);
					sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0}</font></td></tr>", sales[i].Anzahl);
				}
				sb.Append(@"</table>");
			}
			else
			{
				sb.Append(@"<table cellPadding=0><tbody>");
				sb.Append(@"<tr><td><font face=Calibri size=2><strong><u>Datum</u></strong></font></td>");
				sb.Append(@"<td><font face=Calibri size=2><strong><u>Artikel</u></strong></font></td>");
				sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>&nbsp;Menge</u></strong></font></td></tr>");
				foreach (var item in sales)
				{
					sb.AppendFormat(@"<tr><td><font face=Calibri size=2>&nbsp;{0}</font></TD>", item.Datum.ToShortDateString());
					sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0}</font></td>", item.Bezeichnung1);
					sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>&nbsp;{0}</font></td></tr>", item.Anzahl);
				}
				sb.Append(@"</table>");
			}
			return sb.ToString();
		}

		public string GetSpecialPriceListHtml()
		{
			var sb = new StringBuilder();
			var priceList = ModelManager.ProductService.GetProductList(this).Where(
				p => p.Kundenpreis < p.Standardpreis & p.KatalogFlag == true);

			sb.Append(@"<table cellPadding=0><tbody><tr>");
			sb.Append(@"<td align=""left""><font face=Calibri size=2><strong><u>Artikel</u></strong></font></td>");
			sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>Std.-Preis</u></strong></font></td>");
			sb.Append(@"<td align=""right""><font face=Calibri size=2><strong><u>&nbsp;Kundenpreis</u></strong></font></td></tr>");
			foreach (var item in priceList)
			{
				sb.AppendFormat(@"<tr><td><font face=Calibri size=2>{0}</font></TD>", item.Bezeichnung1);
				sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>{0:C2}</font></td>", item.Standardpreis);
				sb.AppendFormat(@"<td align=""right""><font face=Calibri size=2>{0:C2}</font></td></tr>", item.Kundenpreis);
			}
			sb.Append(@"</table>");

			return sb.ToString();
		}

		/// <summary>
		/// Gibt den Inhalt der aktiven Notizen dieses Kunden im HTML-Format zurück.
		/// </summary>
		/// <returns></returns>
		public string GetNotesHtml()
		{
			var sb = new StringBuilder();
			foreach (var item in this.Notizlist.Sort("AssignedAt", System.ComponentModel.ListSortDirection.Descending).Where(n => n.InactiveFlag == false))
			{
				sb.AppendFormat(@"<p><font face=Calibri size=2>{0}<br><strong><u>{1}</u></strong><br>", item.AssignedAt.ToShortDateString(), item.Subject);
				sb.AppendFormat("{0}</font></p>", item.Body);
			}
			return sb.ToString();
		}

		#region MUSS UMGESCHRIEBEN WERDEN

		//public void UpdateServicetermine()
		//{
		//	throw new NotImplementedException();
		//}

		#endregion MUSS UMGESCHRIEBEN WERDEN

		#endregion HTML

		#region TXT

		//public string GetCustomerInfoText(Kundenkontakt contact)
		//{
		//	throw new NotImplementedException();
		//}

		//public string GetLastProductsSoldText()
		//{
		//	throw new NotImplementedException();
		//}

		//public string GetSpecialPriceListText()
		//{
		//	throw new NotImplementedException();
		//}

		//public string GetNotesText()
		//{
		//	throw new NotImplementedException();
		//}

		#endregion TXT

		#endregion public procedures

		#region private procedures

		List<string> GetMaschinenListeText()
		{
			var list = new List<string>();
			var mList = ModelManager.MachineService.GetKundenMaschineList(this.CustomerId);

			foreach (var machine in mList.Sort("Modellbezeichnung"))
			{
				list.Add(string.Format("{0} ({1})", machine.Maschinenmodell.Modellbezeichnung, machine.Seriennummer));
			}
			return list;
		}

		#endregion private procedures
	}
}