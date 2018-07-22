#region using
using System;
using System.Drawing;
#endregion

namespace Products.Common.Helpers
{
	public class OfferColorSettings : IDisposable
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

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && priceTotalFont != null)
			{
				priceTotalFont.Dispose();
			}
			priceTotalFont.Dispose();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~OfferColorSettings()
		{
			Dispose(false);
		}

		#endregion

	}
}
