using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Versandstaffelpreis
	{
		#region members
		#endregion

		#region public properties

		public string Kundennummer { get; set; }

		public decimal AbWert { get; set; }
		public decimal Versandkosten { get; set; }

		#endregion

		#region ### .ctor ###

		public Versandstaffelpreis()
		{
		}

		#endregion

	}
}
