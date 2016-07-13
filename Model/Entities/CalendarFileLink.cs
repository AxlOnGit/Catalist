using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class CalendarFileLink : ILinkedItem
	{

		#region members

		readonly FileInfo myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		public string Key
		{
			get { return myBase.FullName; }
		}

		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Datei").UID; }
		}

		public string ItemName
		{
			get { return myBase.Name; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Datei"; }
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CalendarFileLink Klasse.
		/// </summary>
		/// <param name="fileInfoBase"></param>
		public CalendarFileLink(FileInfo fileInfoBase)
		{
			this.myBase = fileInfoBase;
		}

		#endregion

	}
}
