
namespace Products.PdfMaker
{
	public static class PdfManager
	{

		#region members

		static PdfService pdfService;

		#endregion

		#region public properties

		/// <summary>
		/// Returns the static singleton PdfService.
		/// </summary>
		public static PdfService PdfService
		{
			get
			{
				if (pdfService == null)
				{
					pdfService = new PdfService();
				}
				return pdfService;
			}
		}

		#endregion

	}
}
