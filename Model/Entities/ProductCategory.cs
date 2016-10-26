using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class ProductCategory : ILinkedItem
	{

		#region members

		readonly dsProducts.ProductCategoryRow myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		public string ItemName
		{
			get
			{
				return this.myBase.Category;
			}
		}

		public string Key
		{
			get
			{
				return this.myBase.UID;
			}
		}

		public string LinkTypBezeichnung
		{
			get
			{
				return "Artikelkategorie";
			}
		}

		public string LinkTypeId
		{
			get
			{
				return ModelManager.SharedItemsService.GetLinkTypeByName("Artikelkategorie").UID;
			}
		}

		#endregion

		#region scalars

		public string UID { get { return this.myBase.UID; } }

		public string ParentID
		{
			get
			{
				if (!this.myBase.IsParentIDNull()) return this.myBase.ParentID;
				return null;
			}
			set
			{
				if (this.myBase.IsParentIDNull())
				{
					this.myBase.ParentID = value;
				}
				else
				{
					if (!this.myBase.ParentID.Equals(value)) this.myBase.ParentID = value;
				}
			}
		}

		public string Category
		{
			get { return this.myBase.Category; }
			set { if (!this.myBase.Category.Equals(value)) this.myBase.Category = value; }
		}

		#endregion

		#region entities

		public ProductCategory ParentCategory
		{
			get { return ModelManager.ProductService.GetProductCategory(this.ParentID); }
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ProductCategory"/> Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public ProductCategory(dsProducts.ProductCategoryRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
