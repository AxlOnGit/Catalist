using System;
using DvApi32;

namespace David
{
	public class MessageItem2Mover
	{

		#region MEMBERS

		#endregion MEMBERS

		#region PUBLIC PROCEDURES

		public MessageItem2 Move(MessageItem2 msgItem2, string userPK, string forUserCalArchive)
		{
			var fieldsOldItem = msgItem2.Fields as Fields;
			var start = (DateTime)fieldsOldItem.Item(DavidFieldsEnum.SendTime).Value;
			var end = (DateTime)fieldsOldItem.Item(DavidFieldsEnum.StopTime).Value;
			var calCreateParams = DavidManager.MessageItem2Creator.CreateCalendarItem(start, end, userPK, forUserCalArchive);
			var fieldsNewItem = calCreateParams.MessageItem2Object.Fields as Fields;

			fieldsNewItem.Item(DavidFieldsEnum.AllDayEvent).Value = fieldsOldItem.Item(DavidFieldsEnum.AllDayEvent).Value;
			fieldsNewItem.Item(DavidFieldsEnum.Content).Value = fieldsOldItem.Item(DavidFieldsEnum.Content).Value;
			fieldsNewItem.Item(DavidFieldsEnum.HTML).Value = fieldsOldItem.Item(DavidFieldsEnum.HTML).Value;
			fieldsNewItem.Item(DavidFieldsEnum.Location).Value = fieldsOldItem.Item(DavidFieldsEnum.Location).Value;
			fieldsNewItem.Item(DavidFieldsEnum.ReminderTime).Value = fieldsOldItem.Item(DavidFieldsEnum.ReminderTime).Value;
			fieldsNewItem.Item(DavidFieldsEnum.ShowAs).Value = fieldsOldItem.Item(DavidFieldsEnum.ShowAs).Value;
			fieldsNewItem.Item(DavidFieldsEnum.Subject).Value = fieldsOldItem.Item(DavidFieldsEnum.Subject).Value;

			// Den neuen Termin zum Repository hinzufügen und im David speichern.
			DavidManager.DavidTerminRepo.AddMessageItem2(userPK, forUserCalArchive, calCreateParams.MessageItem2Object);
			calCreateParams.MessageItem2Object.Save();

			// Den alten Termin aus dem Repository entfernen und dann im David löschen.
			DavidManager.DavidTerminRepo.RemoveMessageItem2(userPK, forUserCalArchive, msgItem2);
			msgItem2.Delete();
			return calCreateParams.MessageItem2Object;
		}

		#endregion

	}
}
