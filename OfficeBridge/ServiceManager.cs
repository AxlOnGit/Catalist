namespace Products.OfficeBridge
{
	public static class ServiceManager
	{
		#region members

		static Services.ExcelService myExcelService;
		static Services.InstChecklistCreator myInstChecklistCreator;
		static Services.InstReportCreator myInstReportCreator;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt den statischen singleton ExcelService des Systems zurück.
		/// </summary>
		public static Services.ExcelService ExcelService
		{
			get
			{
				if (myExcelService == null) myExcelService = new Services.ExcelService();
				return myExcelService;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton <seealso cref="Services.InstChecklistCreator"/>
		/// des Systems zurück.
		/// </summary>
		public static Services.InstChecklistCreator InstallationChecklistCreator
		{
			get
			{
				if (myInstChecklistCreator == null) myInstChecklistCreator = new Services.InstChecklistCreator();
				return myInstChecklistCreator;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton <seealso cref="InstallationReportCreator"/> des Systems zurück.
		/// </summary>
		public static Services.InstReportCreator InstallationReportCreator
		{
			get
			{
				if (myInstReportCreator == null) myInstReportCreator = new Services.InstReportCreator();
				return myInstReportCreator;
			}
		}

		#endregion PUBLIC PROPERTIES
	}
}