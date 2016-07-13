#region using
using System.Drawing;
#endregion

namespace Products.Common.Helpers
{
	public class OfferColorSettings
	{

		#region members

		Font priceTotalFont;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt das Format für die Gesamtpreis Spalte in Angeboten zurück.
		/// </summary>
		public Font PriceTotalFont
		{
			get
			{
				if (priceTotalFont == null)
				{
					priceTotalFont = new Font("Calibri Light", 11, FontStyle.Bold);
				}
				return priceTotalFont;
			}
		}
		#endregion

	}
}
