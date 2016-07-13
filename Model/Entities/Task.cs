using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data;
using Products.Common;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Task : ILinkedItem
	{

		#region events

		public event EventHandler ReminderChangedEvent;

		#endregion

		#region members

		private dsTasks.TaskRow myBase = null;
		private Reminder myReminder = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Aufgabe").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.myBase.TaskName; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Aufgabe"; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel dieser Aufgabe zurück.
		/// </summary>
		public string UID
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Benutzers zurück, der diese Aufgabe erstellt hat.
		/// </summary>
		public string OwnerUid
		{
			get { return this.myBase.OwnerUid; }
		}

		/// <summary>
		/// Gibt die Instanz des Benutzers zurück, der diese Aufgabe erstellt hat.
		/// </summary>
		public User Owner
		{
			get { return ModelManager.UserService.GetUser(this.myBase.OwnerUid, Services.UserService.UserSearchParamType.PrimaryKey); }
		}

		/// <summary>
		/// Gibt den Anzeigenamen des Benutzers zurück, der diese Aufgabe erstellt hat.
		/// </summary>
		public string OwnerDisplayName
		{
			get { return this.Owner.NameFull; }
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Benutzers zurück, der für diese Aufgabe zuständig ist.
		/// </summary>
		public string ResponsibleUid
		{
			get { return this.myBase.ResponsibleUid; }
		}

		/// <summary>
		/// Gibt die Instanz des Benutzers zurück, der für diese Aufgabe zuständig ist.
		/// </summary>
		public User Responsible
		{
			get { return ModelManager.UserService.GetUser(this.myBase.ResponsibleUid, Services.UserService.UserSearchParamType.PrimaryKey); }
		}

		/// <summary>
		/// Gibt den Anzeigenamen des Benutzers zurück, der für diese Aufgabe zuständig ist.
		/// </summary>
		public string ResponsibleDisplayName
		{
			get { return this.Responsible.NameFull; }
		}

		/// <summary>
		/// Gibt die Aufgabenkategorie zurück.
		/// </summary>
		public int Category
		{
			get { return this.myBase.CategoryId; }
			set { this.myBase.CategoryId = value; }
		}

		/// <summary>
		/// Gibt die Aufgabenbezeichnung zurück.
		/// </summary>
		public string Taskname
		{
			get { return this.myBase.TaskName; }
			set { this.myBase.TaskName = value; }
		}

		/// <summary>
		/// Gibt die Beschreibung dieser Aufgabe zurück.
		/// </summary>
		public string Description
		{
			get { return this.myBase.Description; }
			set { this.myBase.Description = value; }
		}

		/// <summary>
		/// Gibt die Priorität dieser Aufgabe zurück:
		/// 0 = niedrig
		/// 1 = normal
		/// 2 = hoch
		/// </summary>
		public sbyte Priority
		{
			get { return this.myBase.Priority; }
			set { this.myBase.Priority = value; }
		}

		/// <summary>
		/// Gibt den Status dieser Aufgabe zurück:
		/// 0 = Nicht begonnen
		/// 1 = In Bearbeitung
		/// 2 = Erledigt
		/// 3 = Wartet auf jemand anderen
		/// 4 = Zurückgestellt
		/// </summary>
		public sbyte Status
		{
			get { return this.myBase.Status; }
			set { this.myBase.Status = value; }
		}

		/// <summary>
		/// Gibt Startdatum dieser Aufgabe zurück.
		/// </summary>
		public DateTime StartsAt
		{
			get { return this.myBase.StartsAt; }
			set { this.myBase.StartsAt = value; }
		}

		/// <summary>
		/// Gibt das Fälligkeitsdatum dieser Aufgabe zurück.
		/// </summary>
		public DateTime? DueAt
		{
			get
			{
				if (this.myBase.IsDueAtNull())
				{
					return null;
				}
				return this.myBase.DueAt;
			}
			set
			{
				if (value.HasValue)
				{
					this.myBase.DueAt = value.Value;
				}
				else this.myBase.SetDueAtNull();
			}
		}

		/// <summary>
		/// Gibt das Erledigt-Kennzeichen zurück oder legt es fest.
		/// </summary>
		public bool CompletedFlag
		{
			get { return this.myBase.CompletedFlag == 0 ? false : true; }
			set { this.myBase.CompletedFlag = (value == true) ? (sbyte)1 : (sbyte)0; }
		}

		/// <summary>
		/// Gibt das Erledigungsdatum zurück oder legt es fest.
		/// </summary>
		public DateTime? CompletedAt
		{
			get 
			{
				if (this.myBase.IsCompletedAtNull())
				{
					return null;
				}
				return this.myBase.CompletedAt; 
			}
			set 
			{
				if (value.HasValue)
				{
					this.myBase.CompletedAt = value.Value;
				}
				else this.myBase.SetCompletedAtNull(); 
			}
		}

		/// <summary>
		/// Gibt den Prozentwert zurück, zu dem diese Aufgabe erledigt ist oder legt ihn fest.
		/// </summary>
		public int PercentCompleted
		{
			get { return this.myBase.PercentCompleted; }
			set { this.myBase.PercentCompleted = value; }
		}

		/// <summary>
		/// Gibt den Reminder für diesen Tasks zurück oder Null, falls es keinen gibt.
		/// </summary>
		/// <remarks>
		/// Die Eigenschaft gibt Null zurück, wenn für diesen Task kein Reminder eingerichtet wurde.
		/// </remarks>
		public Reminder Reminder 
		{
			get
			{
				if (this.myReminder == null)
				{
					this.myReminder = ModelManager.ReminderService.GetReminder(this.UID);
				}
				return this.myReminder;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Task Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Task(dsTasks.TaskRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt einen neuen Reminder für diesen Task.
		/// </summary>
		public void AddOrChangeReminder(DateTime remindAt)
		{
			if (this.myReminder == null)
			{
				Reminder reminder = ModelManager.ReminderService.AddReminder(this, remindAt);
				if (reminder != null)
				{
					if (ReminderChangedEvent != null)
					{
						ReminderChangedEvent(this, new EventArgs());
					}
				}
				else
				{
					this.Reminder.RemindAt = remindAt;
				}
			}
		}

		/// <summary>
		/// Wenn es einen Reminder für diesen Task gibt, wird der gelöscht.
		/// </summary>
		public void RemoveReminder()
		{
			if (this.Reminder == null) return;

			// Datensatz in der Datenbank löschen lassen
			string reminderPK = this.Reminder.UID;
			// ModelManager.ModelService.CurrentUser.DeleteReminder(this.Reminder);

			// Todo: Ggf. für den Reminder existierende Jobs im Scheduler löschen
		}

		/// <summary>
		/// Löscht den mit diesem Task verknüpften Reminder.
		/// </summary>
		internal void DeleteReminder()
		{
			if (this.Reminder != null)
			{
				DataManager.TaskDataService.DeleteReminderRow(this.Reminder.UID);
			}
		}

		#endregion

		#region private procedures

		#endregion

	}
}
