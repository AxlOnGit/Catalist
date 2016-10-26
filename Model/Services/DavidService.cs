using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Model.Entities;

namespace Products.Model.Services
{
	/// <summary>
	/// Datenzugriff auf den DAVID SQL Server.
	/// </summary>
	public class DavidService
	{

		#region members
		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine sortierbare Liste von MailItems zurück, deren Betreffzeile
		/// dem angegebenen Suchkriterium entspricht.
		/// </summary>
		/// <param name="searchFor"></param>
		/// <returns></returns>
		public SortableBindingList<MailItem> GetMailItems(string searchFor)
		{
			var list = new SortableBindingList<MailItem>();
			var fullNames = Data.DataManager.DavidDataService.GetMessageFullNames(searchFor);
			foreach (var fullName in fullNames)
			{
				var msgItm2 = David.DavidManager.DavidService.GetMessageItem2(fullName);
				if (msgItm2 != null)
				{
					list.Add(new MailItem(msgItm2, fullName));
				}
			}

			return list;
		}

		#endregion

	}
}
