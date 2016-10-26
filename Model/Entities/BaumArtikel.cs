using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class BaumArtikel
	{

		#region members

		readonly dsProducts.BaumArtikelRow myBase;
		readonly Kunde myKunde;

		#endregion

		#region properties

		#region scalars

		public int Katalog { get { return this.myBase.Katalog; } }

		public int PkID { get { return this.myBase.PkID; } }

		public int ArtikelFKey { get { return this.myBase.ArtikelFKey; } }

		public int ParentID { get { return this.myBase.ParentID; } }

		public bool Aktiv { get { return this.myBase.Aktiv; } }

		public int SortID { get { return this.myBase.SortID; } }

		#endregion

		#region entities

		public Product Product
		{
			get
			{
				return ModelManager.ProductService.GetProductByArtikelFKey(this.myBase.ArtikelFKey, this.myKunde);
			}
		}

		#endregion

		#region product

		public string Typ { get { return this.Product.Typ; } }

		public string Artikelnummer { get { return this.Product.Artikelnummer; } }

		public string Bezeichnung1 { get { return (this.Product != null) ? this.Product.Bezeichnung1 : null; } }

		public string Bezeichnung2 { get { return (this.Product != null) ? this.Product.Bezeichnung2 : null; } }

		public string Matchcode { get { return (this.Product != null) ? this.Product.Matchcode : null; } }

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="BaumArtikel"/> Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public BaumArtikel(dsProducts.BaumArtikelRow baseRow, Kunde kunde = null)
		{
			this.myBase = baseRow;
			if (kunde == null) kunde = ModelManager.CustomerService.GetKunde("1000000000", false);
			this.myKunde = kunde;
		}

		#endregion

	}
}