using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Model.Entities
{
	public class Sonderpreis
	{

		#region members

		private Data.dsSage.KundenArtikelSonderpreiseRow myBase = null;
		private decimal myStandardPreis = 0.0m;
		private decimal myPreis1 = 0.0m;
		private decimal myPreis2 = 0.0m;
		private decimal myPreis3 = 0.0m;
		private decimal myPreis4 = 0.0m;

		#endregion

		#region public properties

		public string Kundennummer 
		{
			get 
			{
				return myBase.Kundennummer;
			}
		}

		public string Artikelgruppe
		{
			get
			{
				return myBase.Artikelgruppe;
			}
		}

		public decimal Standardpreis
		{
			get
			{
				return myStandardPreis;
			}
			private set
			{
				this.myStandardPreis = value;
			}
		}

		public decimal Rabatt
		{
			get
			{
				return myBase.Rabatt;
			}
			set
			{
				myBase.Rabatt = value;
			}
		}

		public decimal Menge1
		{
			get
			{
				return this.myBase.Menge1;
			}
			set
			{
				this.myBase.Menge1 = value;
			}
		}

		public decimal Rabatt1
		{
			get
			{
				return this.myBase.Rabatt1;
			}
			set
			{
				this.myBase.Rabatt1 = value;
			}
		}

		public decimal Preis1
		{
			get
			{
				return this.myPreis1;
			}
			set
			{
				this.myPreis1 = value;
				//NEXT: Nach Änderung den Rabattsatz neu berechnen
				// this.myBase.Rabatt1 = ...
			}
		}

		public decimal Menge2
		{
			get
			{
				return this.myBase.Menge2;
			}
			set
			{
				this.myBase.Menge2 = value;
			}
		}

		public decimal Rabatt2
		{
			get
			{
				return this.myBase.Rabatt2;
			}
			set
			{
				this.myBase.Rabatt2 = value;
			}
		}

		public decimal Preis2
		{
			get
			{
				return this.myPreis2;
			}
			set
			{
				this.myPreis2 = value;
				//NEXT: Nach Änderung den Rabattsatz neu berechnen
				// this.myBase.Rabatt2 = ...
			}
		}

		public decimal Menge3
		{
			get
			{
				return this.myBase.Menge3;
			}
			set
			{
				this.myBase.Menge3 = value;
			}
		}

		public decimal Rabatt3
		{
			get
			{
				return this.myBase.Rabatt3;
			}
			set
			{
				this.myBase.Rabatt3 = value;
			}
		}

		public decimal Preis3
		{
			get
			{
				return this.myPreis3;
			}
			set
			{
				this.myPreis3 = value;
				//NEXT: Nach Änderung den Rabattsatz neu berechnen
				// this.myBase.Rabatt3 = ...
			}
		}

		public decimal Menge4
		{
			get
			{
				return this.myBase.Menge4;
			}
			set
			{
				this.myBase.Menge4 = value;
			}
		}

		public decimal Rabatt4
		{
			get
			{
				return this.myBase.Rabatt4;
			}
			set
			{
				this.myBase.Rabatt4 = value;
			}
		}

		public decimal Preis4
		{
			get
			{
				return this.myPreis4;
			}
			set
			{
				this.myPreis4 = value;
				//NEXT: Nach Änderung den Rabattsatz neu berechnen
				// this.myBase.Rabatt4 = ...
			}
		}

		
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Sonderpreis Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Sonderpreis(Data.dsSage.KundenArtikelSonderpreiseRow baseRow, decimal standardPreis)
		{
			this.myBase = baseRow;
			this.Standardpreis = standardPreis;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Aktualisiert die Tabelle Kundenartikelsonderpreise auf dem MySql Server.
		/// </summary>
		/// <returns></returns>
		public int Update()
		{
			return ModelManager.ProductService.UpdateSonderpreise(this.Kundennummer);
		}

		#endregion

	}
}
