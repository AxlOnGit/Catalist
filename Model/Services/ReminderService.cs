using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Contracts.Schedule;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;
using Quartz;

namespace Products.Model.Services
{
	public class ReminderService : IScheduleListener
	{
		#region public events

		public event EventHandler<JobReminderExecutedEventArgs> JobReminderExecuted;

		#endregion public events

		#region public procedures

		/// <summary>
		/// Erstellt einen neuen Reminder für den angegebenen Task.
		/// </summary>
		/// <param name="instTask"></param>
		/// <returns></returns>
		internal Reminder AddReminder(Task instTask, DateTime remindAt)
		{
			var rRow = DataManager.TaskDataService.AddReminderRow(instTask.UID, instTask.Taskname, remindAt);
			if (rRow != null)
			{
				var reminder = new Reminder(rRow);
				ModelManager.SchedulerService.AddJob(reminder, this);
				return reminder;
			}
			else return null;
		}

		/// <summary>
		/// Gibt den Reminder für den angegebenen Task zurück oder Null, wenn keinen gips, ne?!
		/// </summary>
		/// <param name="taskId">Der Primärschlüssel des Tasks.</param>
		/// <returns>
		/// Eine <seealso cref="Products.Model.Entities.Reminder"/> Instanz, wenn es eine Erinnerung
		/// für diese Aufgabe gibt oder Null, wenn nicht.
		/// </returns>
		internal Reminder GetReminder(string taskId)
		{
			var rRow = DataManager.TaskDataService.GetReminderRow(taskId);
			if (rRow != null)
			{
				return new Reminder(rRow);
			}
			else return null;
		}

		/// <summary>
		/// Richtet die heutigen Erinnerungen für den angegebenen User ein.
		/// </summary>
		internal void InitializeReminders()
		{
		}

		/// <summary>
		/// Aktualisiert den Job für diesen Reminder im Scheduler.
		/// </summary>
		/// <param name="reminder"></param>
		internal void UpdateReminder(Reminder reminder)
		{
			if (ModelManager.SchedulerService.JobExists(reminder.UID))
			{
				ModelManager.SchedulerService.RemoveJob(reminder.UID);
			}
			ModelManager.SchedulerService.AddJob(reminder, this);
		}

		/// <summary>
		/// Beendet den Schedulerdienst und gibt die verwendeten Ressourcen frei.
		/// </summary>
		public void ShutdownScheduler()
		{
			ModelManager.SchedulerService.Shutdown();
		}

		#region IScheduleListener Schnittstelle

		void IScheduleListener.ExecuteJob(object executionParams)
		{
			if (this.JobReminderExecuted != null)
			{
				Reminder reminder = (executionParams as Reminder);
				if (reminder != null)
				{
					this.JobReminderExecuted.Invoke(this, new JobReminderExecutedEventArgs(reminder));
				}
			}
		}

		#endregion IScheduleListener Schnittstelle

		#endregion public procedures

		#region sub classes

		public class JobReminderExecutedEventArgs : EventArgs
		{
			public Reminder ReminderJob { get; private set; }

			/// <summary>
			/// Erzeugt eine neue Instanz der JobReminderExecutedEventArgs Klasse.
			/// </summary>
			/// <param name="instReminder">
			/// Die Instanz des <seealso cref="Products.Model.Entities.Reminder"/> Objekts, für das
			/// ein Trigger ausgelöst wurde.
			/// </param>
			public JobReminderExecutedEventArgs(Reminder instReminder)
			{
				this.ReminderJob = instReminder;
			}
		}

		#endregion sub classes
	}
}