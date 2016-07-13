using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsCustomerTableAdapters;

namespace Products.Data.Services
{
	public class CustomerDataService
	{

		#region members

		string myCurrentUserPK;

		#region Adapter

		readonly dsCustomer myCustomerDS = new dsCustomer();
		readonly taKundenSuche myKundenSucheAdapter = new taKundenSuche();
		readonly taKunde myKundeAdapter = new taKunde();
		readonly taCustomer myCustomerAdapter = new taCustomer();
		private bool myCustomersInitialized;
		private bool myKundenInitialized;

		#endregion

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CustomerDataService Klasse.
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		/// </summary>
		public CustomerDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine Tabelle mit Kunden zurück, bei denen die Suchzeichenfolge gefunden wurde.
		/// </summary>
		/// <param name="searchFor"></param>
		/// <returns></returns>
		public dsCustomer.KundenSucheDataTable SearchCustomer(string searchFor)
		{
			return this.myKundenSucheAdapter.GetData(searchFor);
		}

		#region Customer

		/// <summary>
		/// Gibt die Tabelle Customer zurück.
		/// </summary>
		/// <returns></returns>
		public dsCustomer.CustomerDataTable GetCustomerTable()
		{
			this.AssureCustomerInitialized();
			return this.myCustomerDS.Customer;
		}

		/// <summary>
		/// Gibt die CustomerRow mit der angegebenen Kundennummer zurück.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		public dsCustomer.CustomerRow GetCustomerRow(string kundePK)
		{
			return this.GetCustomerTable().FindByKundennummer(kundePK);
		}

		#endregion

		#region Kunde

		/// <summary>
		/// Fügt der Tabelle Kunde eine neue Zeile hinzu.
		/// </summary>
		/// <param name="kundePK"></param>
		/// <returns></returns>
		public dsCustomer.KundeRow AddKundeRow(string kundePK)
		{
			dsCustomer.KundeRow kRow = this.myCustomerDS.Kunde.NewKundeRow();
			kRow.Kundennummer = kundePK;
			kRow.Anmerkungen = "";
			kRow.Besuchsintervall = 6;
			kRow.Besuchszeit = 45;
			kRow.MitAnmeldungFlag = 0;
			kRow.KurzpreislisteFlag = 0;
			kRow.VorjahresvergleichFlag = 0;
			kRow.UmsatzSeitLetztemBesuchFlag = 0;
			kRow.AusdruckLetztesAngebotFlag = 0;
			kRow.OhneVorbereitungFlag = 0;
			kRow.WeihnachtsFlag = 0;
			kRow.LetzterBesuchstermin = new DateTime(1970, 1, 1, 0, 0, 0);
			kRow.NaechsterBesuchstermin = new DateTime(1970, 1, 1, 0, 0, 0);
			kRow.Wettbewerber = "";
			kRow.AktuellerHinweis = "";

			this.myCustomerDS.Kunde.AddKundeRow(kRow);
			this.UpdateKundeTabelle(kRow);

			return kRow;
		}

		/// <summary>
		/// Gibt die Tabelle Kunde zurück.
		/// </summary>
		/// <returns></returns>
		public dsCustomer.KundeDataTable GetKundeTable()
		{
			this.AssureKundeInitialized();
			return this.myCustomerDS.Kunde;
		}

		/// <summary>
		/// Gibt den 
		/// </summary>
		/// <param name="kundePK">Kundennummer des gesuchten Kunden.</param>
		/// <returns></returns>
		public dsCustomer.KundeRow GetKunde(string kundePK)
		{
			return this.GetKundeTable().FindByKundennummer(kundePK);
		}

		/// <summary>
		/// Aktualisiert die angegebene KundeRow oder die gesamte Tabelle, falls keine KundeRow übergeben wurde.
		/// </summary>
		/// <param name="kundeRow"></param>
		/// <returns></returns>
		public int UpdateKundeTabelle(dsCustomer.KundeRow kundeRow = null)
		{
			if (kundeRow != null)
			{
				return this.myKundeAdapter.Update(kundeRow);
			}
			return this.myKundeAdapter.Update(this.myCustomerDS.Kunde);
		}

		#endregion

		#endregion

		#region private procedures

		void AssureCustomerInitialized()
		{
			if (this.myCustomersInitialized) return;
			this.myCustomerAdapter.Fill(this.myCustomerDS.Customer);
			this.myCustomersInitialized = true;
		}

		void AssureKundeInitialized()
		{
			if (this.myKundenInitialized) return;
			this.myKundeAdapter.Fill(this.myCustomerDS.Kunde);
			this.myKundenInitialized = true;
		}

		#endregion

	}
}
