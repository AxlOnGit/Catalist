using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Model.EventSystem
{
	public class DateilinkDeletedEventArgs : EventArgs
	{

		#region members

		private string myFilename = string.Empty;

		#endregion

		#region public properties

		/// <summary>
		/// Der vollständige Pfad und Dateiname der vom Server gelöschten Datei.
		/// </summary>
		public string Filename { get { return this.myFilename; } }

		#endregion

		#region ### .ctor ###

		public DateilinkDeletedEventArgs(string filename)
		{
			this.myFilename = filename;
		}

		#endregion

	}
}
