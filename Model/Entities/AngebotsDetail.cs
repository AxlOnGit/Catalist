using Products.Data.Datasets;
using System.Windows.Forms;

namespace Products.Model.Entities
{
	/// <summary>
	/// Repräsentiert eine Sage-Angebotsposition.
	/// </summary>
	public class AngebotsDetail
	{

		#region members

		readonly dsSales.AngebotSagePositionRow myBase;

		#endregion

		#region public properties

		//Sequence
		public decimal Sequence { get { return this.myBase.Sequence; } }

		//VorgangsnummerTemporaer
		public string Angebotsnummer { get { return this.myBase.VorgangsnummerTemporaer; } }

		//Positionstyp
		public string Typ
		{
			get
			{
				switch (this.myBase.Positionstyp)
				{
					case 1:
						return "Artikel";

					case 2:
						return "Stückliste";

					case 4:
						return "Langtext";

					case 5:
						return "Text";

					case 6:
						return "Ausgeblendet";

					case 7:
						return "Zwischensumme";

					case 8:
						return "Umbruch";

					default:
						return "";
				}
			}
		}

		//Positionsart
		public string Positionsart { get { return this.myBase.Positionsart; } }

		//Artikelnummer
		public string Artikelnummer { get { return this.myBase.Artikelnummer; } }

		//Stuecklistennummer
		public string Stuecklistennummer { get { return this.myBase.Stuecklistennummer; } }

		//Bezeichnung1
		public string Bezeichnung1 { get { return this.myBase.Bezeichnung1; } }

		//Bezeichnung2
		public string Bezeichnung2 { get { return this.myBase.Bezeichnung2; } }

		//Hersteller
		public string HerstellerNummer { get { return this.myBase.Hersteller; } }

		public Lieferant Hersteller { get { return ModelManager.SupplierService.GetSupplier(this.HerstellerNummer); } }

		//Menge
		public double Menge { get { return this.myBase.IsMengeNull() ? 0 : this.myBase.Menge; } }

		//Einzelpreis
		public decimal Einzelpreis { get { return this.myBase.Einzelpreis; } }

		//Gesamtpreis
		public decimal Gesamtpreis { get { return this.myBase.Gesamtpreis; } }

		//Mengeneinheit
		public string Mengeneinheit { get { return this.myBase.Mengeneinheit; } }

		//Langtext
		public string Langtext { get { return this.myBase.Langtext; } }

		//Anker_RTFMemo
		public int AnkerRTFMemo { get { return this.myBase.Anker_RTFMemo; } }

		/// <summary>
		/// Gibt den Positionstext im RTF Format zurück.
		/// </summary>
		public string MemotextRtf
		{
			get
			{
				if (this.AnkerRTFMemo > 0)
				{
					var memoRow = Data.DataManager.SalesDataService.GetSystemMemoRow(this.AnkerRTFMemo);
					if (memoRow != null) return memoRow.Content;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt den Positionstext als normalen Text zurück.
		/// </summary>
		public string Memotext
		{
			get
			{
				if (!string.IsNullOrEmpty(this.MemotextRtf))
				{
					var rtf = new RichTextBox();
					rtf.Rtf = this.MemotextRtf;
					return rtf.Text;
				}
				return string.Empty;
			}
		}

		//Zwischensumme
		public decimal Zwischensumme { get { return this.myBase.Zwischensumme; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AngebotsDetail"/> Klasse, die eine Position in einem Sage-Angebot repräsentiert.
		/// </summary>
		/// <param name="baseRow"></param>
		public AngebotsDetail(dsSales.AngebotSagePositionRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
