namespace Products.PdfMaker
{
    public static class PdfManager
    {
        #region FIELDS

        static PdfService pdfService;

        #endregion FIELDS

        #region PUBLIC PROPERTIES

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

        #endregion PUBLIC PROPERTIES
    }
}
