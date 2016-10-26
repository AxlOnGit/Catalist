using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.OfficeBridge
{
	public static class ServiceManager
	{
		#region members

		static Services.ExcelService myExcelService;

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

		#endregion public properties
	}
}