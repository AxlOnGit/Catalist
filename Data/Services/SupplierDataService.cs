using System.Linq;
using Products.Data.Datasets;
using Products.Data.Datasets.dsSuppliersTableAdapters;
using Products.Common;

namespace Products.Data.Services
{
	public class SupplierDataService
	{

		#region members

		readonly string myCurrentUserPK;
		readonly dsSuppliers myDS = new dsSuppliers();

		#region Adapter

		readonly taLieferant myLieferantAdapter = new taLieferant();
		readonly taLieferantenKontakt myLieferantKontaktAdapter = new taLieferantenKontakt();
		readonly taBestellung myBestellungAdapter = new taBestellung();
		readonly taBestellDetail myBestellDetailAdapter = new taBestellDetail();
		readonly taRabattstaffel myRabattstaffelAdapter = new taRabattstaffel();
		readonly taOffeneBestellungen myOffeneBestellungenAdapter = new taOffeneBestellungen();

		#endregion

		#endregion

		#region private properties

		bool LieferantenLoaded { get; set; }
		bool KontakteLoaded { get; set; }
		bool RabattstaffelnLoaded{ get; set; }

		bool BestellungenLoaded { get; set; }
		bool LieferungenLoaded { get; set; }
		bool RechnungenLoaded { get; set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SupplierDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public SupplierDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die Lieferant DataTable des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsSuppliers.LieferantDataTable GetLieferantTable()
		{
			if (!this.LieferantenLoaded)
			{
				this.myLieferantAdapter.Fill(this.myDS.Lieferant);
				this.LieferantenLoaded = true;
			}
			return this.myDS.Lieferant;
		}

		/// <summary>
		/// Gibt die Rabattstaffel DataTable des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsSuppliers.RabattstaffelDataTable GetRabattstaffelTable()
		{
			if (!this.RabattstaffelnLoaded)
			{
				this.myRabattstaffelAdapter.Fill(this.myDS.Rabattstaffel);
				this.RabattstaffelnLoaded = true;
			}
			return this.myDS.Rabattstaffel;
		}

		///Gibt die Tabelle LieferantenKontakt des Systems zurück.
		public dsSuppliers.LieferantenKontaktDataTable GetKontaktTable()
		{
			if (!this.KontakteLoaded)
			{
				this.myLieferantKontaktAdapter.Fill(this.myDS.LieferantenKontakt);
				this.KontakteLoaded = true;
			}
			return this.myDS.LieferantenKontakt;
		}

		/// <summary>
		/// Erstellt eine neue RabattstaffelRow und fügt sie zur Datenbank hinzu.
		/// </summary>
		/// <param name="artikelPK"></param>
		/// <param name="lieferantPK"></param>
		/// <returns></returns>
		public dsSuppliers.RabattstaffelRow AddRabattstaffelRow(string artikelPK, string lieferantPK)
		{
			dsSuppliers.RabattstaffelRow rRow = this.myDS.Rabattstaffel.NewRabattstaffelRow();
			rRow.ID = this.myDS.Lieferant.Count + 1;
			rRow.ChainGuid = SequentialGuid.NewSequentialGuid();
			rRow.Sequence = 4611686018427387904;
			rRow.Guid = SequentialGuid.NewSequentialGuid();
			rRow.Artikelnummer = artikelPK;
			rRow.Hersteller = lieferantPK;
			rRow.Lieferant = lieferantPK;
			rRow.Satzart = 1;

			this.myDS.Rabattstaffel.AddRabattstaffelRow(rRow);
			this.UpdateRabattstaffel();

			return rRow;
		}

		/// <summary>
		/// Gibt die RabattstaffelRow für den angegebenen Artikel und den angegebenen Lieferanten zurück.
		/// </summary>
		/// <param name="artikelPK">Primärschlüssel des Artikels.</param>
		/// <param name="lieferantPK">Primärschlüssel des Lieferanten.</param>
		/// <returns></returns>
		public dsSuppliers.RabattstaffelRow GetRabattStaffel(string artikelPK, string lieferantPK)
		{
			return this.GetRabattstaffelTable().FirstOrDefault(r => r.Artikelnummer == artikelPK && r.Lieferant == lieferantPK);
		}

		/// <summary>
		/// Löscht den Rabattstaffel Eintrag für den angegebenen Artikel und den 
		/// angegebenen Lieferanten.
		/// </summary>
		/// <param name="rabattId"></param>
		/// <returns></returns>
		public int DeleteRabattstaffelRow(int rabattId)
		{
			int result = 0;
			dsSuppliers.RabattstaffelRow rRow = this.myDS.Rabattstaffel.FindByID(rabattId);
			if (rRow != null)
			{
				rRow.Delete();
				this.UpdateRabattstaffel();
				result = 1;
			}

			return result;
		}

		/// <summary>
		/// Aktualisiert die Rabattstaffel DataTable und überträgt alle Änderungen in die Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateRabattstaffel()
		{
			if (this.myDS.Rabattstaffel.GetChanges() != null)
			{
				return this.myRabattstaffelAdapter.Update(this.myDS.Rabattstaffel);
			}
			return 0;
		}

		#region BESTELLUNGEN/LIEFERUNGEN/RECHNUNGEN

		public dsSuppliers.BestellungDataTable GetBestellungTable()
		{
			if (!this.BestellungenLoaded)
			{
				this.myBestellungAdapter.Fill(this.myDS.Bestellung);
				this.myBestellDetailAdapter.Fill(this.myDS.BestellDetail);
				this.BestellungenLoaded = true;
			}
			return this.myDS.Bestellung;
		}

		public dsSuppliers.BestellDetailDataTable GetBestellDetailTable()
		{
			if (!this.BestellungenLoaded)
			{
				this.myBestellungAdapter.Fill(this.myDS.Bestellung);
				this.myBestellDetailAdapter.Fill(this.myDS.BestellDetail);
				this.BestellungenLoaded = true;
			}
			return this.myDS.BestellDetail;
		}

		/// <summary>
		/// Gibt die Tabelle mit den offenen Lieferantenbestellungen für den angegebenen Artikel zurück.
		/// </summary>
		/// <param name="productPK">Artikelnummer.</param>
		/// <returns></returns>
		public dsSuppliers.OffeneBestellungenDataTable GetOffeneBestellungenTable(string productPK)
		{
			return this.myOffeneBestellungenAdapter.GetData(productPK);
		}

		#endregion

		#endregion

	}
}
