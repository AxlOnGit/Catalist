using System;
using DvApi32;

namespace David.API
{
	public class ItemNotificationEventArgs : EventArgs
	{

		#region public properties

		public ItemNotificationType NotificationType { get; }
		public IArchiveNotifyItems MsgItems2 { get; }
		public Archive SourceArchive { get; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ItemNotificationEventArgs"/> Klasse.
		/// </summary>
		/// <param name="itemNotificationType">Benachrichtigungstyp.</param>
		/// <param name="msgItems2"></param>
		/// <param name="archive"></param>
		public ItemNotificationEventArgs(ItemNotificationType itemNotificationType, IArchiveNotifyItems msgItems2, Archive archive)
		{
			NotificationType = itemNotificationType;
			MsgItems2 = msgItems2;
			SourceArchive = archive;
		}

		#endregion

	}
}
