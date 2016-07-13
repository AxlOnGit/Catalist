using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets.dsTasksTableAdapters;
using Products.Data.Datasets;
using Products.Common;

namespace Products.Data.Services
{
	public class TaskDataService
	{

		#region events

		/// <summary>
		/// Wird ausgelöst, nachdem eine ReminderRow gelöscht wurde.
		/// </summary>
		public event EventHandler<ReminderRowDeletedEventArgs> ReminderRowDeleted;

		#endregion

		#region members

		readonly string myCurrentUserPK;

		#region Adapter

		taTask myTaskAdapter;
		taReminder myReminderAdapter;

		#endregion

		dsTasks.TaskDataTable myTaskTable;
		dsTasks.ReminderDataTable myReminderTable;

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TaskDataService Klasse.
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		/// </summary>
		public TaskDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt eine neue TaskRow für den aktuell angemeldeten Benutzer und hängt sie an die Datenbank.
		/// </summary>
		/// <returns></returns>
		public dsTasks.TaskRow AddTaskRow()
		{
			this.AssureTasksInitialized();

			dsTasks.TaskRow tRow = this.myTaskTable.NewTaskRow();
			tRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			tRow.OwnerUid = this.myCurrentUserPK;
			tRow.ResponsibleUid = this.myCurrentUserPK;
			tRow.CategoryId = 0;
			tRow.TaskName = "Neue Aufgabe";
			tRow.Description = "Aufgabenbeschreibung";
			tRow.Priority = 1;
			tRow.Status = 0;
			tRow.StartsAt = DateTime.Today;
			tRow.DueAt = DateTime.Today.AddDays(7);
			tRow.CompletedFlag = 0;
			tRow.PercentCompleted = 0;

			this.myTaskTable.AddTaskRow(tRow);
			this.UpdateTaskTable();

			return tRow;
		}

		/// <summary>
		/// Gibt die Task Tabelle mit den Aufgaben des angemeldeten Benutzers zurück.
		/// </summary>
		/// <returns></returns>
		public dsTasks.TaskDataTable GetTaskTable()
		{
			this.AssureTasksInitialized();
			return this.myTaskTable;
		}

		/// <summary>
		/// Erstellt eine neue ReminderRow und fügt sie zur Datenbank hinzu.
		/// </summary>
		/// <param name="taskPK">Primärschlüssel des zugeordneten Tasks</param>
		/// <param name="taskName">Aufgabenbezeichung, die als Beschreibung des Reminders verwendet wird.</param>
		/// <param name="remindAt">Ausführungszeitpunkt des Reminders.</param>
		/// <returns></returns>
		public dsTasks.ReminderRow AddReminderRow(string taskPK, string taskName, DateTime remindAt)
		{
			this.AssureTasksInitialized();

			dsTasks.ReminderRow rRow = this.myReminderTable.NewReminderRow();
			rRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			rRow.TaskId = taskPK;
			rRow.RemindAt = remindAt;
			rRow.Description = taskName;
			rRow.Executed = "N";

			return rRow;
		}
	
		/// <summary>
		/// Gibt die ReminderRow für den Task mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="taskPK"></param>
		/// <returns></returns>
		public dsTasks.ReminderRow GetReminderRow(string taskPK)
		{
			this.AssureTasksInitialized();
			return this.myReminderTable.FirstOrDefault(r => r.TaskId == taskPK);
		}

		/// <summary>
		/// Löscht die ReminderRow mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="reminderPK">Primärschlüssel des Reminders.</param>
		public void DeleteReminderRow(string reminderPK)
		{
			dsTasks.ReminderRow rRow = this.myReminderTable.FindByUID(reminderPK);
			if (rRow != null)
			{
				var delEventArgs = new ReminderRowDeletedEventArgs(rRow.UID, rRow.Description);
				rRow.Delete();
				this.UpdateReminderTable();
				if (this.ReminderRowDeleted != null)
				{
					ReminderRowDeleted(this, delEventArgs);
				}
			}
		}

		/// <summary>
		/// Aktualisiert die Tabelle Task.
		/// </summary>
		/// <returns></returns>
		public int UpdateTaskTable()
		{
			if (this.myTaskTable.GetChanges() != null)
			{
				return this.myTaskAdapter.Update(this.myTaskTable);
			}
			return 0;
		}

		/// <summary>
		/// Speichert Änderungen an der Tabelle Reminder in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateReminderTable()
		{
			if (this.myReminderTable.GetChanges() != null)
			{
				return this.myReminderAdapter.Update(this.myReminderTable);
			}
			return 0;
		}

		#endregion

		#region private procedures

		void AssureTasksInitialized()
		{
			if (this.myTaskAdapter == null)
			{
				this.myTaskAdapter = new taTask();
				this.myReminderAdapter = new taReminder();
				this.myTaskTable = this.myTaskAdapter.GetData(this.myCurrentUserPK);
				this.myReminderTable = this.myReminderAdapter.GetData(this.myCurrentUserPK);
			}
		}

		#endregion

		#region SubClasses

		public class ReminderRowDeletedEventArgs : EventArgs
		{
			public string UID { get; private set; }
			public string Description { get; private set; }

			/// <summary>
			/// Erzeugt eine neue Instanz der ReminderDeletedEventArgs Klasse.
			/// </summary>
			/// <param name="reminderPK"></param>
			/// <param name="description"></param>
			public ReminderRowDeletedEventArgs(string reminderPK, string description)
			{
				this.UID = reminderPK;
				this.Description = description;
			}
		}

		#endregion

	}
}
