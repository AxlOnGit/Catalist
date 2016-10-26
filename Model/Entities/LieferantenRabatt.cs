using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class LieferantenRabatt
	{

		#region members

		readonly dsSuppliers.RabattstaffelRow myBase;

		#endregion

		#region public properties

		/// <summary>
		/// Primärschlüssel dieses Rabattstaffel Eintrags.
		/// </summary>
		public int ID { get { return this.myBase.ID; } }

		/// <summary>
		/// Primärschlüssel des Artikels, für den diese Rabattstaffel gilt.
		/// </summary>
		public string Artikelnummer { get { return this.myBase.Artikelnummer; } }

		/// <summary>
		/// Primärschlüssel des Herstellers dieses Rabattstaffel Eintrags.
		/// </summary>
		public string HerstellerNummer { get { return this.myBase.Hersteller; } }

		/// <summary>
		/// Primärschlüssel des Lieferanten dieses Rabattstaffel Eintrags.
		/// </summary>
		public string LieferantenNummer { get { return this.myBase.Lieferant; } }

		public decimal Menge1 { get { return this.myBase.Menge1; } set { this.myBase.Menge1 = value; } }

		public decimal Preis1 { get { return this.myBase.Preis1; } set { this.myBase.Preis1 = value; } }

		public decimal Rabatt1 { get { return this.myBase.Rabatt1; } set { this.myBase.Rabatt1 = value; } }

		public decimal Menge2 { get { return this.myBase.Menge2; } set { this.myBase.Menge2 = value; } }

		public decimal Preis2 { get { return this.myBase.Preis2; } set { this.myBase.Preis2 = value; } }

		public decimal Rabatt2 { get { return this.myBase.Rabatt2; } set { this.myBase.Rabatt2 = value; } }

		public decimal Menge3 { get { return this.myBase.Menge3; } set { this.myBase.Menge3 = value; } }

		public decimal Preis3 { get { return this.myBase.Preis3; } set { this.myBase.Preis3 = value; } }

		public decimal Rabatt3 { get { return this.myBase.Rabatt3; } set { this.myBase.Rabatt3 = value; } }

		public decimal Menge4 { get { return this.myBase.Menge4; } set { this.myBase.Menge4 = value; } }

		public decimal Preis4 { get { return this.myBase.Preis4; } set { this.myBase.Preis4 = value; } }

		public decimal Rabatt4 { get { return this.myBase.Rabatt4; } set { this.myBase.Rabatt4 = value; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der LierantenRabatt Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public LieferantenRabatt(dsSuppliers.RabattstaffelRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

		#region public procedures
		#endregion

	}
}
