using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Suchkunde
	{

		#region members

		private dsCustomer.KundenSucheRow myBase = null;

		#endregion

		#region public properties

		public string Typ { get { return this.myBase.Typ; } }
		public string Fund { get { return !this.myBase.IsFundNull() ? this.myBase.Fund : string.Empty; } }
		public string Kundennummer { get { return this.myBase.Kundennummer; } }
		public string PK { get { return this.myBase.PK; } }
		public string Firma { get { return this.myBase.Firma; } }
		public string PLZ { get { return this.myBase.Plz; } }
		public string Ort { get { return this.myBase.Ort; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Suchkunde Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Suchkunde(dsCustomer.KundenSucheRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
