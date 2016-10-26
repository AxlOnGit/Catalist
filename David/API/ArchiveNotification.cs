using System.Collections.Generic;
using DvApi32;

namespace David.API
{
	public class ArchiveNotification : IArchiveNotification
	{

		#region delegates

		public delegate void ItemEventHandler(object sender, ItemNotificationEventArgs e);
		public delegate void UnreadEventHandler(object sender, UnreadNotificationEventArgs e);
		public delegate void ArchiveInfoEventHandler(object sender, Archive e);

		#endregion

		#region events

		public event ItemEventHandler ItemNotificationEvent;
		public event ItemEventHandler ItemNewEvent;
		public event ItemEventHandler ItemDeletedEvent;
		public event ItemEventHandler ItemModifiedEvent;
		public event ArchiveInfoEventHandler RefreshEvent;
		public event ArchiveInfoEventHandler RestoreEvent;
		public event UnreadEventHandler UnreadEvent;

		#endregion

		#region members

		readonly List<string> myArchiveIDs = new List<string>();

		#endregion

		#region public properties

		List<string> ArchiveIDs { get { return this.myArchiveIDs; } }

		#endregion

		#region event handler

		public void OnDeletedItems(Archive pArchiveSource, IArchiveNotifyItems pItems)
		{
			DoItemNotificationEvent(ItemNotificationType.Deleted, pArchiveSource, pItems);
			this.ItemDeletedEvent?.Invoke(this, new ItemNotificationEventArgs(ItemNotificationType.Deleted, pItems, pArchiveSource));
		}

		public void OnModifiedItems(Archive pArchiveSource, IArchiveNotifyItems pItems)
		{
			DoItemNotificationEvent(ItemNotificationType.Modified, pArchiveSource, pItems);
			this.ItemModifiedEvent?.Invoke(this, new ItemNotificationEventArgs(ItemNotificationType.Modified, pItems, pArchiveSource));
		}

		public void OnNewItems(Archive pArchiveSource, IArchiveNotifyItems pItems)
		{
			DoItemNotificationEvent(ItemNotificationType.New, pArchiveSource, pItems);
			this.ItemNewEvent?.Invoke(this, new ItemNotificationEventArgs(ItemNotificationType.New, pItems, pArchiveSource));
		}

		public void OnRefresh(Archive pArchiveSource)
		{
			this.RefreshEvent?.Invoke(this, pArchiveSource);
		}

		public void OnRestored(Archive pArchiveSource)
		{
			this.RestoreEvent?.Invoke(this, pArchiveSource);
		}

		public void OnUnreadCount(Archive pArchiveSource, int lCount)
		{
			this.UnreadEvent?.Invoke(this, new UnreadNotificationEventArgs(lCount, pArchiveSource));
		}

		#endregion

		#region public procedures

		public void AddArchive(Archive archive)
		{
			archive.SetNotification(this, false);
			ArchiveIDs.Add(archive.ID.ToString());
		}

		public bool ClearArchive(Archive archive)
		{
			if (ArchiveIDs.Exists(s => s == archive.ID.ToString()))
			{
				archive.SetNotification(this, true);
				ArchiveIDs.RemoveAll(s => s == archive.ID.ToString());
				return true;
			}
			return false;
		}

		public void ClearAll(Account account)
		{
			foreach (var archiveID in ArchiveIDs)
			{
				var archive = account.ArchiveFromID(archiveID);
				archive.SetNotification(this, true);
			}
			ArchiveIDs.Clear();
		}

		#endregion

		#region private procedures

		/// <summary>
		/// Event für alle Ereignisse (Löschen, Ändern und Neu)
		/// </summary>
		/// <param name="type">Ein Element der <seealso cref="ItemNotificationType"/> Auflistung.</param>
		/// <param name="pArchiveSource">Das betroffene David Archiv.</param>
		/// <param name="pItems">Die betroffenen MessageItem2 Instanzen.</param>
		void DoItemNotificationEvent(ItemNotificationType type, Archive pArchiveSource, IArchiveNotifyItems pItems)
		{
			if (ItemNotificationEvent != null)
			{
				ItemNotificationEvent.Invoke(this, new ItemNotificationEventArgs(type, pItems, pArchiveSource));
			}
		}

		#endregion

	}
}
