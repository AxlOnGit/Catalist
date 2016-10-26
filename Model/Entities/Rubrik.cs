using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Rubrik
	{

		#region members

		readonly dsProducts.RubrikRow myBase;

		#endregion

		#region properties

		public int PkID { get { return this.myBase.PkID; } }

		public string Titel { get { return this.myBase.Titel; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="Rubrik"/> Klasse.
		/// </summary>
		/// <param name="baseRow">Basiszeile dieser <seealso cref="Rubrik"/> Instanz in Tabelle Rubrik.</param>
		public Rubrik(dsProducts.RubrikRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
