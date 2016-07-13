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

		FileInfo myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		string ILinkedItem.Key
		{
			get { return myBase.FullName; }
		}

		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Datei").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return myBase.Name; }
		}

		string ILinkedItem.LinkTypBezeichnung
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
