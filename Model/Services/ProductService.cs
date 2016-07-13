using System.Collections.Generic;
using System.Linq;
using Products.Common.Collections;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class ProductService
	{

		#region members

		readonly Dictionary<string, SBList<Product>> myProductDictionary = new Dictionary<string, SBList<Product>>();

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den derzeit ausgewählten Artikel zurück. 
		/// </summary>
		public Product CurrentProduct { get; set; }

		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die Artikelliste des Systems zurück, angepasst an den angegebenen Kunden.
		/// </summary>
		/// <returns></returns>
		public SBList<Product> GetProductList(Kunde kunde)
		{
			if (!this.myProductDictionary.ContainsKey(kunde.CustomerId))
			{
				var list = new List<Product>();
				foreach (var pRow in Data.DataManager.ProductDataService.GetProductDataTable(kunde.CustomerId))
				{
					dsProducts.ProductCpmRow pcRow = null;
					if (pRow.USER_Katalogartikel == "1")
					{
						pcRow = DataManager.ProductDataService.GetOrCreateProductCpmRow(pRow.Artikel, ModelManager.UserService.CurrentUser.NameFull);
					}
					list.Add(new Product(pRow, pcRow, kunde));
				}
				var sblist = new SBList<Product>(list);
				this.myProductDictionary.Add(kunde.CustomerId, sblist);
			}
			return this.myProductDictionary[kunde.CustomerId];
		}

		public SBList<Product> GetProductList(Kunde kunde, string filter)
		{
			var lowFilter = filter.ToLower();
			var filtered = this.GetProductList(kunde).Where(p => p.Artikelnummer.ToLower().Contains(lowFilter) | p.Bezeichnung1.ToLower().Contains(lowFilter));
			return new SBList<Product>(filtered);
		}

		/// <summary>
		/// Gibt den angegebenen Artikel für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <param name="product"></param>
		/// <returns></returns>
		public Product GetProduct(Kunde kunde, Product product)
		{
			return this.myProductDictionary[kunde.CustomerId].FirstOrDefault(p => p.Artikelnummer == product.Artikelnummer);
		}

		/// <summary>
		/// Gibt alle Artikel der angegebenen Artikelgruppe für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kundennummer</param>
		/// <param name="product">Artikel</param>
		/// <returns></returns>
		public SBList<Product> GetProductsByArtikelgruppe(Kunde kunde, Product product)
		{
			var pList = this.GetProductList(kunde).Where(p => p.Artikelgruppe == product.Artikelgruppe);
			return new SBList<Product>(pList);
		}

		/// <summary>
		/// Gibt alle Artikel der angegebenen Artikelgruppe für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kundennummer</param>
		/// <param name="artikelgruppe">Artikelgruppe</param>
		/// <returns></returns>
		public SBList<Product> GetProductsByArtikelgruppe(Kunde kunde, string artikelgruppe)
		{
			var pList = this.GetProductList(kunde).Where(p => p.Artikelgruppe == artikelgruppe);
			return new SBList<Product>(pList);
		}

		/// <summary>
		/// Gibt die dsProducts.SonderpreisRow für die angegebene Artikelgruppe und den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kunde.</param>
		/// <param name="artikelgruppe">Artikelgruppe.</param>
		/// <returns></returns>
		public dsProducts.SonderpreisRow GetSonderpreisRow(Kunde kunde, string artikelgruppe)
		{
			return DataManager.ProductDataService.GetSonderpreisRow(kunde.CustomerId, artikelgruppe);
		}

		/// <summary>
		/// Gibt den Rechnungsbetrag zurück, ab dem der Kunde Frei-Haus beliefert wird.
		/// </summary>
		/// <param name="kunde"></param>
		/// <returns></returns>
		public decimal GetFocAmount(Kunde kunde)
		{
			return this.GetProductList(kunde).FirstOrDefault(p => p.Artikelnummer.ToLower() == "versandkostenfrei").Kundenpreis;
		}

		/// <summary>
		/// Erstellt eine 
		/// </summary>
		/// <param name="kunde">Kunde, dem der Sonderpreis zugeordnet wird.</param>
		/// <param name="product">Artikel (bzw. seine Artikelgruppe), für den der Sonderpreis vereinbart wird.</param>
		/// <returns></returns>
		public dsProducts.SonderpreisRow CreateSonderpreis(Kunde kunde, Product product)
		{
			return DataManager.ProductDataService.CreateSonderpreisRow(customerPK: kunde.CustomerId, artikelGruppe: product.Artikelgruppe);
		}

		public SBList<ProductSale> GetProductSales(string productPK)
		{
			var list = new SBList<ProductSale>();
			var sTable = DataManager.ProductDataService.GetProductSalesTable(productPK);
			foreach (var sRow in sTable)
			{
				list.Add(new ProductSale(sRow.Zeitraum, sRow.Menge));
			}
			return list;
		}

		/// <summary>
		/// Aktualisiert die Produkteigenschaften und Sonderpreise für die
		/// Artikel des angegebenen Kunden.
		/// </summary>
		/// <param name="kunde">Der <seealso cref="Kunde"/>, dessen Produkte aktualisiert werden sollen.</param>
		public void UpdateProducts(Kunde kunde)
		{
			DataManager.ProductDataService.UpdateProductCpm();
			DataManager.ProductDataService.UpdateSonderpreise(kunde.CustomerId);
		}

		/// <summary>
		/// Aktualisiert die Sonderpreise des angegebenen Kunden.
		/// </summary>
		/// <param name="kunde">Kundennummer des Kunden, dessen Sonderpreise aktualisiert werden sollen.</param>
		/// <returns></returns>
		public int UpdateSonderpreise(Kunde kunde)
		{
			var result = DataManager.ProductDataService.UpdateSonderpreise(kunde.CustomerId);
			return result;
		}

		#endregion

		#region private procedures

		#endregion

		#region STRUCTS

		public struct ProductSale
		{
			public string Zeitraum { get; private set; }
			public double Menge { get; private set; }

			public ProductSale(string zeitraum, double menge)
			{
				this.Zeitraum = zeitraum;
				this.Menge = menge;
			}
		}

		#endregion

	}
}
