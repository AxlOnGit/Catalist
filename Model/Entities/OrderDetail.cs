using System;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class OrderDetail
	{

		#region members

		dsOrders.OrderDetailRow myBase;

		#endregion

		#region public properties

		#region integrals

		public string Vorgang { get { return this.myBase.Vorgang; } }
		public string Nummer { get { return this.myBase.Nummer; } }

		/// <summary>
		/// Gibt 'S' bei Stücklisten- und 'A' bei Artikelpositionen zurück.
		/// </summary>
		public string Typ
		{
			get
			{
				return (this.myBase.Positionstyp == 1) ? "A" : "S";
			}
		}

		public string Position { get { return this.myBase.Positionszaehler; } }

		public string Artikelnummer
		{
			get
			{
				return (this.Typ == "A") ? this.myBase.Artikelnummer : this.myBase.Stuecklistennummer;
			}
		}

		public string Bezeichnung1 { get { return this.myBase.Bezeichnung1; } }
		public string Bezeichnung2 { get { return this.myBase.Bezeichnung2; } }
		public double Menge { get { return this.myBase.Menge; } }
		public string Mengeneinheit { get { return this.myBase.Mengeneinheit; } }
		public decimal Einheitspreis { get { return !this.myBase.IsEinheitspreisNull() ? this.myBase.Einheitspreis : 0.0m; } }
		public decimal Rabattsatz { get { return !this.myBase.IsRabattsatzNull() ? this.myBase.Rabattsatz: 0.0m; } }
		public decimal Einzelnettopreis { get { return !this.myBase.IsEinzelnettopreisNull() ? this.myBase.Einzelnettopreis : 0.0m; } }
		public decimal Gesamtnettopreis { get { return !this.myBase.IsGesamtnettopreisNull() ? this.myBase.Gesamtnettopreis : 0.0m; } }
		public decimal Steuersatz { get { return !this.myBase.IsSteuersatzNull() ? this.myBase.Steuersatz : 0.0m; } }
		public decimal Gesamtbruttopreis { get { return !this.myBase.IsGesamtbruttopreisNull() ? this.myBase.Gesamtbruttopreis : 0.0m; } }

		#endregion

		#region entities

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the OrderDetail class.
		/// </summary>
		/// <param name="baseRow"></param>
		public OrderDetail(dsOrders.OrderDetailRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

	}
}
