using System;
using DvApi32;

namespace David.API
{
	public class UnreadNotificationEventArgs : EventArgs
	{

		#region public properties

		public int UnreadCount { get; }
		public Archive SourceArchive { get; }

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
