using System;
using DvApi32;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace David.API
{
	public class UnreadNotificationEventArgs : EventArgs
	{

		#region public properties

		public int UnreadCount { get; private set; }
		public Archive SourceArchive { get; private set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="UnreadNotificationEventArgs"/> Klasse.
		/// </summary>
		/// <param name="unreadCount"></param>
		/// <param name="archive"></param>
		public UnreadNotificationEventArgs(int unreadCount, Archive archive)
		{
			this.UnreadCount = unreadCount;
			this.SourceArchive = archive;
		}

		#endregion

	}
}
