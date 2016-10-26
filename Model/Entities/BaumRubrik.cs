using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class BaumRubrik
	{

		#region members

		readonly dsProducts.BaumRubrikRow myBase;

		#endregion

		#region properties


		#region scalar

		public int Katalog { get { return this.myBase.Katalog; } }

		public int PkID { get { return this.myBase.PkID; } }

		public int RubrikFKey { get { return this.myBase.RubrikFKey; } }

		public string Titel { get { return ModelManager.ProductService.GetRubrik(this.myBase.RubrikFKey).Titel; } }

		public int ParentID { get { return this.myBase.ParentID; } }

		public bool Aktiv { get { return this.myBase.Aktiv; } }

		public int SortID { get { return this.myBase.SortID; } }

		#endregion

		#region entities

		/// <summary>
		/// Gibt die Instanz der übergeordneten BaumRubrik zurück.
		/// </summary>
		public BaumRubrik Parent
		{
			get { return ModelManager.ProductService.GetBaumRubrik(this.myBase.ParentID); }
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="BaumRubrik"/> Klasse.
		/// </summary>
		/// <param name="baseRow">Basiszeile dieser <seealso cref="BaumRubrik"/> Instanz in Tabelle BaumRubrik. </param>
		public BaumRubrik(dsProducts.BaumRubrikRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
