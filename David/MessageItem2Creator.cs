using System;
using DvApi32;

namespace David
{
	public class MessageItem2Creator
	{

		/// <summary>
		/// Erstellt einen neuen David Kalendereintrag mit den angegebenen Daten und einigen
		/// Defaultwerten.
		/// </summary>
		/// <param name="start">Anfangsdatum und -uhrzeit des Termins.</param>
		/// <param name="end">Enddatum und -uhrzeit des Termins.</param>
		/// <param name="userPK">Primärschlüssel des Benutzers, für den der Termin angelegt werden soll.</param>
		/// <param name="forUserCalArchive">Pfad zum Kalenderverzeichnis des Benutzers auf dem David Server.</param>
		/// <returns></returns>
		public CreationParameters CreateCalendarItem(DateTime start, DateTime end, string userPK, string forUserCalArchive)
		{
			var cal = DavidManager.DavidService.Account.GetArchive(forUserCalArchive);
			var msg = $"Ich konnte auf den Kalenderordner '{forUserCalArchive}' nicht zugreifen.";
			if (cal == null) throw new ApplicationException(msg);
			var newItem2 = cal.CreateArchiveEntry(DvItemTypes.DvCalendarItem);
			var fields = (Fields)newItem2.Fields;

			newItem2.Subject = "Termin";
			fields.Item(DavidFieldsEnum.SendTime).Value = start;
			fields.Item(DavidFieldsEnum.StopTime).Value = end;
			fields.Item(DavidFieldsEnum.Content).Value = "Text"; // Text
			fields.Item(DavidFieldsEnum.HTML).Value = "<p>Text</p>"; // HTML Text
			fields.Item(DavidFieldsEnum.Location).Value = "Terminort"; // Terminort
			fields.Item(DavidFieldsEnum.ReminderTime).Value = -1; // ReminderTime
			var uid = this.CreateGuidField(newItem2);
			newItem2.Save();
			var fileName = ((string)fields.Item(DavidFieldsEnum.FileName).Value).EndsWith(".001", StringComparison.CurrentCulture)
				? (string)fields.Item(DavidFieldsEnum.FileName).Value
				: $"{fields.Item(DavidFieldsEnum.FileName).Value}.001";

			DavidManager.DavidTerminRepo.AddMessageItem2(userPK, forUserCalArchive, newItem2);

			return new CreationParameters(newItem2, fileName, uid);
		}

		#region private procedures

		Guid CreateGuidField(MessageItem2 forMessageItem2)
		{
			var fields = (Fields)forMessageItem2.Fields;
			if (fields.UserFields.Count == 0)
			{
				var uid = Products.Common.SequentialGuid.NewID().ToString();
				var def = fields.UserFields.CreateDefinition("GUID", DvFieldType.DvFieldText);
				fields.UserFields.Add(def, uid);
				return Guid.Parse(uid);
			}
			return Guid.Empty;
		}

		#endregion private procedures

		public struct CreationParameters
		{
			public MessageItem2 MessageItem2Object { get; }
			public string Filename { get; }
			public Guid UID { get; }

			/// <summary>
			/// Erzeugt eine neue Instanz der <seealso cref="CreationParameters"/> Struktur.
			/// </summary>
			/// <param name="msgItem2"></param>
			/// <param name="fileName"></param>
			/// <param name="uid"></param>
			public CreationParameters(MessageItem2 msgItem2, string fileName, Guid uid)
			{
				this.MessageItem2Object = msgItem2;
				this.Filename = fileName;
				this.UID = uid;
			}
		}

	}
}
