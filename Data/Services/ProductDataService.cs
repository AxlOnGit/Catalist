using System;
using System.Collections.Generic;
using System.Linq;
using Products.Data.Datasets;
using Products.Data.Datasets.dsProductsTableAdapters;

namespace Products.Data.Services
{
	public class ProductDataService
	{

		#region members

		readonly string myCurrentUserPK;
		readonly Dictionary<string, dsProducts.ProductDataTable> myProductDictionary = new Dictionary<string, dsProducts.ProductDataTable>();
		readonly Dictionary<string, dsProducts.SonderpreisDataTable> mySonderpreisDictionary = new Dictionary<string, dsProducts.SonderpreisDataTable>();
		readonly dsProducts myDS = new dsProducts();
		readonly taProduct myProductAdapter = new taProduct();
		readonly taProductText myProductTextAdapter = new taProductText();
		readonly taProductCpm myProductCpmAdapter = new taProductCpm();
		readonly taSonderpreis mySonderpreisAdapter = new taSonderpreis();
		readonly taProductSales myProductSalesAdapter = new taProductSales();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ProductDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public ProductDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die kundenspezifische Artikelliste für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <returns></returns>
		/// <remarks>Die Liste wird in erster Linie für Angebote verwendet und enthält 
		/// alle im System vorhandenen Artikel, nicht nur Katalogartikel.</remarks>
		public dsProducts.ProductDataTable GetProductDataTable(string customerPK)
		{
			if (!this.myProductDictionary.ContainsKey(customerPK))
			{
				this.myProductDictionary.Add(customerPK, this.myProductAdapter.GetData(customerPK));
			}

			return this.myProductDictionary[customerPK];
		}

		/// <summary>
		/// Gibt den Artikel mit den kundenspezifischen Eigenschaften für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer.</param>
		/// <param name="productPK">Artikelnummer.</param>
		/// <returns></returns>
		public dsProducts.ProductRow GetProductRow(string customerPK, string productPK)
		{
			return this.GetProductDataTable(customerPK).FirstOrDefault(p => p.Artikel == productPK);
		}

		/// <summary>
		/// Gibt die entsprechende ProductCpmRow für den angegebenen Artikel zurück. Falls es für 
		/// den Artikel noch keinen Eintrag gibt, wird er an dieser Stelle erstellt.
		/// </summary>
		/// <param name="productPK">Artikelnummer des Artikels, um den es geht.</param>
		/// <param name="userName">Der Benutzername des aktuellen Mitarbeiters.</param>
		/// <returns></returns>
		public dsProducts.ProductCpmRow GetOrCreateProductCpmRow(string productPK, string userName)
		{
			var pRow = this.myDS.ProductCpm.FindByArtikel(productPK);
			if (pRow == null) // Für diesen Artikel gibt es noch keinen Eintrag in Tabelle artikel_cpm
			{
				pRow = this.myDS.ProductCpm.NewProductCpmRow();
				pRow.Artikel = productPK;
				pRow.CheckedFlag = 0;
				pRow.ChangeDate = DateTime.Today;
				pRow.ChangeUser = userName;
				pRow.InactiveFlag = 0;

				this.myDS.ProductCpm.AddProductCpmRow(pRow);
				this.myProductCpmAdapter.Update(pRow);
			}
			return pRow;
		}

		/// <summary>
		/// Gibt den Artikelzusatztext mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="textAnker"></param>
		/// <returns></returns>
		public dsProducts.ProductTextRow GetProductTextRow(int textAnker)
		{
			return this.myDS.ProductText.FirstOrDefault(t => t.ID == textAnker);
		}

		/// <summary>
		/// Gibt eine SonderpreisDataTable mit den kundenspezifischen Sonderpreisen für den
		/// angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennumer des Kunden, um dessen Sonderpreise es geht.</param>
		/// <returns></returns>
		public dsProducts.SonderpreisDataTable GetSonderpreise(string customerPK)
		{
			if (!this.mySonderpreisDictionary.ContainsKey(customerPK))
			{
				this.mySonderpreisDictionary.Add(customerPK, this.mySonderpreisAdapter.GetData(customerPK));
			}
			return this.mySonderpreisDictionary[customerPK];
		}

		/// <summary>
		/// Gibt die Sonderpreisvereinbarung für den angegebenen Artikel und Kunden zurück.
		/// </summary>
		/// <param name="customerPK"></param>
		/// <param name="productGroupPK"></param>
		/// <returns></returns>
		public dsProducts.SonderpreisRow GetSonderpreisRow(string customerPK, string productGroupPK)
		{
			return this.GetSonderpreise(customerPK).FirstOrDefault(s => s.Artikelgruppe == productGroupPK);
		}

		/// <summary>
		/// Erzeugt eine neue dsProducts.SonderpreisRow.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Kunden, für den der Sonderpreis eingerichtet wird.</param>
		/// <param name="artikelGruppe">Artikelgruppe, für den der Sonderpreis eingerichtet wird.</param>
		/// <returns></returns>
		public dsProducts.SonderpreisRow CreateSonderpreisRow(string customerPK, string artikelGruppe)
		{
			var sTable = this.GetSonderpreise(customerPK);
			dsProducts.SonderpreisRow sRow = null;
			if (sTable != null)
			{
				sRow = this.GetSonderpreise(customerPK).NewSonderpreisRow();
				sRow.Kundennummer = customerPK;
				sRow.Artikelgruppe = artikelGruppe;
				sRow.Artikelnummer = "";
				sRow.Hersteller = "0000000000";
				sRow.Sonderpreis_Preisgruppe = 0.01m;
				sRow.Rabatt = 0.0m;
				sRow.KundenspezifischeArtikelnummer = "";
				sRow.Menge1 = 0.0m;
				sRow.Rabatt1 = 0.0m;
				sRow.Menge2 = 0.0m;
				sRow.Rabatt2 = 0.0m;
				sRow.Menge3 = 0.0m;
				sRow.Rabatt3 = 0.0m;
				sRow.Menge4 = 0.0m;
				sRow.Rabatt4 = 0.0m;
				sTable.AddSonderpreisRow(sRow);
			}
			// Wir geben nur die neue DataRow zurück, ohne sie direkt in der Datenbank zu speichern!
			return sRow;
		}

		/// <summary>
		/// Gibt die Artikelverkäufe pro Artikel und Zeitraum (Monat) zurück.
		/// </summary>
		/// <param name="productPK"></param>
		/// <returns></returns>
		public dsProducts.ProductSalesDataTable GetProductSalesTable(string productPK)
		{
			return this.myProductSalesAdapter.GetData(productPK);
		}

		/// <summary>
		/// Speichert geänderte, gelöschte und neue Datensätze in der Tabelle ProductCpm.
		/// </summary>
		public void UpdateProductCpm()
		{
			if (this.myDS.ProductCpm.GetChanges() != null)
			{
				this.myProductCpmAdapter.Update(this.myDS.ProductCpm);
			}
		}

		/// <summary>
		/// Aktualisiert die Tabelle mit den kundenspezifischen Sonderpreisen des angegebenen Kunden.
		/// </summary>
		/// <param name="customerPK">Kundennummer des Kunden.</param>
		/// <returns>Gibt die Anzahl der aktualisierten Datensätze zurück.</returns>
		public int UpdateSonderpreise(string customerPK)
		{
			var table = this.mySonderpreisDictionary[customerPK];
			if (table != null)
			{
				return this.mySonderpreisAdapter.Update(table);
			}
			return 0;
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.myProductTextAdapter.Fill(this.myDS.ProductText);
			this.myProductCpmAdapter.Fill(this.myDS.ProductCpm);
		}

		#endregion

	}
}
