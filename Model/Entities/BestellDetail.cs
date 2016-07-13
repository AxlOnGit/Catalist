using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class BestellDetail
	{

		#region members

		readonly dsSuppliers.BestellDetailRow myBase;

		#endregion

		#region public properties

		public string Vorgang { get { return this.myBase.Vorgang; } }
		public string Nummer { get { return this.myBase.Nummer; } }
		public int Positionstyp { get { return this.myBase.Positionstyp; } }
		public string Artikelnummer { get { return this.myBase.Artikelnummer; } }
		public string Artikelbezeichnung { get { return this.myBase.Artikelbezeichnung1; } }
		public double Bestellmenge { get { return this.myBase.Bestellmenge; } }
		public double Liefermenge { get { return this.myBase.Liefermenge; } }
		public double Menge
		{
			get
			{
				if (this.Vorgang == "B")
				{
					return this.myBase.Bestellmenge;
				}
				else
				{
					return this.myBase.Liefermenge;
				}
			}
		}
		public string Mengeneinheit { get { return this.myBase.Mengeneinheit; } }
		public decimal Einkaufspreis { get { return this.myBase.Einkaufspreis; } }
		public decimal Rabattsatz1 { get { return this.myBase.Rabattsatz1; } }
		public decimal Bestellwert { get { return this.myBase.Bestellwert; } }
		public DateTime Lieferdatum { get { return this.myBase.Lieferdatum; } }
		public string Lieferwoche { get { return this.myBase.Lieferwoche; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der BestellDetail Klasse.
		/// </summary>
		/// <param name="baseRow">Eine <seealso cref="dsSuppliers.BestellDetailRow"/> Instanz. Basis dieser BestellDetail Instanz.</param>
		public BestellDetail(dsSuppliers.BestellDetailRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
