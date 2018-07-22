using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common;
using Products.Common.Collections;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class ProductService
	{
		#region EVENTS

		public event EventHandler CurrentProductSet;

		#endregion EVENTS

		#region members

		readonly Dictionary<string, SBList<Product>> myProductDictionary = new Dictionary<string, SBList<Product>>();
		SBList<ProductCategory> myProductCategoryList;
		SBList<BaumRubrik> myBaumRubrikList;
		SBList<Rubrik> myRubrikList;
		readonly Dictionary<int, SortableBindingList<BaumArtikel>> myBaumArtikelDictionary = new Dictionary<int, SortableBindingList<BaumArtikel>>();
		Product myCurrentProduct;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt den derzeit ausgewählten Artikel zurück.
		/// </summary>
		public Product CurrentProduct
		{
			get
			{
				return this.myCurrentProduct;
			}
			set
			{
				this.myCurrentProduct = value;
				this.CurrentProductSet?.Invoke(this, new EventArgs());
			}
		}

		#endregion public properties

		#region public procedures

		#region PRODUKTE

		/// <summary>
		/// Gibt die Artikelliste des Systems zurück, angepasst an den angegebenen Kunden.
		/// </summary>
		/// <returns></returns>
		public SBList<Product> GetProductList(Kunde kunde)
		{
			if (!this.myProductDictionary.ContainsKey(kunde.CustomerId))
			{
				var list = new List<Product>();
				foreach (var pRow in DataManager.ProductDataService.GetProductDataTable(kunde.CustomerId))
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

		/// <summary>
		/// Gibt eine Liste der Produkte des angegebenen Kunden zurück, die dem angegebenen
		/// Filterkriterium entsprechen.
		/// </summary>
		/// <param name="kunde">Kunde.</param>
		/// <param name="filter">Suchtext.</param>
		/// <returns></returns>
		public SBList<Product> GetProductList(Kunde kunde, string filter)
		{
			var lowFilter = filter.ToLower();
			var filtered = this.GetProductList(kunde).Where(p => p.Artikelnummer.ToLower().Contains(lowFilter) | p.Bezeichnung1.ToLower().Contains(lowFilter));
			return new SBList<Product>(filtered);
		}

		public SortableBindingList<BaumArtikel> GetBaumArtikelList(int pkID, Kunde kunde)
		{
			if (!this.myBaumArtikelDictionary.ContainsKey(pkID))
			{
				var list = new SortableBindingList<BaumArtikel>();
				foreach (var baRow in DataManager.ProductDataService.GetBaumArtikelChildRows(pkID))
				{
					list.Add(new BaumArtikel(baRow, kunde));
				}
				this.myBaumArtikelDictionary.Add(pkID, list);
			}
			return this.myBaumArtikelDictionary[pkID];
		}

		/// <summary>
		/// Gibt den angegebenen Artikel für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde"></param>
		/// <param name="productPK"></param>
		/// <returns></returns>
		public Product GetProduct(Kunde kunde, string productPK, bool setAsCurrent)
		{
			var result = this.GetProductList(kunde).FirstOrDefault(p => p.Artikelnummer == productPK);
			if (result != null && setAsCurrent) this.CurrentProduct = result;
			return result;
			//return this.myProductDictionary[kunde.CustomerId].FirstOrDefault(p => p.Artikelnummer == productPK);
		}

		public Product GetProductByArtikelFKey(int artikelFKey, Kunde myKunde)
		{
			Product product = null;
			var eidamoArtikel = DataManager.ProductDataService.GetArtikelTable().FirstOrDefault(a => a.ID == artikelFKey);
			if (eidamoArtikel != null)
			{
				product = this.GetProduct(myKunde, eidamoArtikel.Artikelnummer, false);
			}
			return product;
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

		#endregion PRODUKTE

		#region RUBRIKEN

		/// <summary>
		/// Gibt die BaumRubrik mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="pkID">Primärschlüssel der gesuchten BaumRubrik.</param>
		/// <returns></returns>
		public BaumRubrik GetBaumRubrik(int pkID)
		{
			return this.GetBaumRubrikList().FirstOrDefault(b => b.PkID == pkID);
		}

		/// <summary>
		/// Gibt eine Liste der Kindelemente der angegebenen BaumRubrik zurück.
		/// </summary>
		/// <param name="parentID">
		/// Primärschlüssel der BaumRubrik deren Kindelemente gesucht werden.
		/// </param>
		/// <returns></returns>
		public SortableBindingList<BaumRubrik> GetBaumRubrikListByParentID(int parentID)
		{
			return new SortableBindingList<BaumRubrik>(this.GetBaumRubrikList().Where(b => b.Katalog == 1 & b.ParentID == parentID)).Sort("SortID");
		}

		/// <summary>
		/// Gibt die Rubrik mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="pkID">Primärschlüssel der gesuchten Rubrik.</param>
		/// <returns></returns>
		public Rubrik GetRubrik(int pkID)
		{
			if (this.myRubrikList == null)
			{
				this.myRubrikList = new SBList<Rubrik>();
				foreach (var rRow in DataManager.ProductDataService.GetRubrikTable())
				{
					var rubrik = new Rubrik(rRow);
					this.myRubrikList.Add(rubrik);
				}
			}
			return this.myRubrikList.FirstOrDefault(r => r.PkID == pkID);
		}

		/// <summary>
		/// Gibt die ID in der Eidamo Artikeltabelle des Artikels mit der angegebenen
		/// Artikelnummer zurück.
		/// </summary>
		/// <param name="artikel"></param>
		/// <returns></returns>
		public int GetArtikelID(string artikel)
		{
			return DataManager.ProductDataService.GetArtikelTable().FirstOrDefault(a => a.Artikelnummer == artikel).ID;
		}

		#endregion RUBRIKEN

		#region KATEGORIEN

		/// <summary>
		/// Erstellt eine neue Produktkategorie.
		/// </summary>
		/// <param name="parentCategory">
		/// Übergeordnete Produktkategorie, in die die neue Kategorie eingefügt wird.
		/// </param>
		/// <returns></returns>
		public ProductCategory AddProductCategory(ProductCategory parentCategory)
		{
			var category = DataManager.ProductDataService.AddProductCategoryRow(parentCategory.UID, "Neue Kategorie");
			if (category != null)
			{
				var newCategory = new ProductCategory(category);
				this.myProductCategoryList.Add(newCategory);
				return newCategory;
			}
			return null;
		}

		/// <summary>
		/// Gibt eine sortier- und filterbare Liste aller Artikelkategorien des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<ProductCategory> GetProductCategoryList()
		{
			if (this.myProductCategoryList == null)
			{
				this.myProductCategoryList = new SBList<ProductCategory>();
				foreach (var cRow in DataManager.ProductDataService.GetProductCategoryTable())
				{
					this.myProductCategoryList.Add(new ProductCategory(cRow));
				}
			}
			return this.myProductCategoryList;
		}

		/// <summary>
		/// Gibt die Artikelkategorie mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="categoryPK"></param>
		/// <returns></returns>
		public ProductCategory GetProductCategory(string categoryPK)
		{
			return this.GetProductCategoryList().FirstOrDefault(c => c.UID == categoryPK);
		}

		/// <summary>
		/// Gibt eine Liste aller Unterkategorien für die angegebene Artikelkategorie zurück.
		/// </summary>
		/// <param name="category"></param>
		/// <returns></returns>
		public List<ProductCategory> GetProductSubCategories(ProductCategory category)
		{
			var list = new List<ProductCategory>();
			list.AddRange(this.GetProductCategoryList().Where(c => c.ParentCategory == category));

			return list;
		}

		/// <summary>
		/// Gibt alle Artikelkategorien der 1. Ebene zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<ProductCategory> GetTopLevelProductCategories()
		{
			var list = new SBList<ProductCategory>();
			list.AddRange(this.GetProductCategoryList().Where(c => string.IsNullOrEmpty(c.ParentID)));

			return list;
		}

		#endregion KATEGORIEN

		#region ANDERE

		/// <summary>
		/// Gibt die dsProducts.SonderpreisRow für die angegebene Artikelgruppe und den
		/// angegebenen Kunden zurück.
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
		/// <param name="product">
		/// Artikel (bzw. seine Artikelgruppe), für den der Sonderpreis vereinbart wird.
		/// </param>
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

		public SortableBindingList<dsProducts.ProductSalesAllRow> GetDurchschnittsverkauf(string artikelPK)
		{
			var list = new SortableBindingList<dsProducts.ProductSalesAllRow>(DataManager.ProductDataService.GetProductSalesRows(artikelPK));
			return list;
		}

		#endregion ANDERE

		#region UPDATE

		/// <summary>
		/// Aktualisiert die Produkteigenschaften und Sonderpreise für die Artikel des
		/// angegebenen Kunden.
		/// </summary>
		/// <param name="kunde">
		/// Der <seealso cref="Kunde"/>, dessen Produkte aktualisiert werden sollen.
		/// </param>
		public void UpdateProducts(Kunde kunde)
		{
			DataManager.ProductDataService.UpdateProductCpm();
			DataManager.ProductDataService.UpdateSonderpreise(kunde.CustomerId);
		}

		/// <summary>
		/// Aktualisiert alle neuen, geänderten und gelöschten Produktkategorien in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateCategories()
		{
			return DataManager.ProductDataService.UpdateProductCategoryTable();
		}

		/// <summary>
		/// Aktualisiert die Sonderpreise des angegebenen Kunden.
		/// </summary>
		/// <param name="kunde">
		/// Kundennummer des Kunden, dessen Sonderpreise aktualisiert werden sollen.
		/// </param>
		/// <returns></returns>
		public int UpdateSonderpreise(Kunde kunde)
		{
			var result = DataManager.ProductDataService.UpdateSonderpreise(kunde.CustomerId);
			return result;
		}

		#endregion UPDATE

		#endregion public procedures

		#region private procedures

		SBList<BaumRubrik> GetBaumRubrikList()
		{
			if (this.myBaumRubrikList == null)
			{
				this.myBaumRubrikList = new SBList<BaumRubrik>();
				foreach (var brRow in DataManager.ProductDataService.GetBaumRubrikTable())
				{
					var bRubrik = new BaumRubrik(brRow);
					this.myBaumRubrikList.Add(bRubrik);
				}
			}
			return this.myBaumRubrikList;
		}

		#endregion private procedures

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

		#endregion STRUCTS
	}
}