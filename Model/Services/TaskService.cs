using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Data;
using Products.Model.Entities;
using Products.Data.Datasets;

namespace Products.Model.Services
{
	public class TaskService
	{

		#region members

		private Dictionary<User, SortableBindingList<Task>> myTaskRepository = null;

		private string myCurrentUserPK;

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TaskService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des aktuell am System angemeldeten Benutzers.</param>
		public TaskService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			DataManager.TaskDataService.ReminderRowDeleted += new EventHandler<Data.Services.TaskDataService.ReminderRowDeletedEventArgs>(TaskDataService_ReminderRowDeleted);
		}

		#endregion

		#region event handler

		private void TaskDataService_ReminderRowDeleted(object sender, Data.Services.TaskDataService.ReminderRowDeletedEventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt eine neue Aufgabe für den angegebenen Benutzer und gibt die dann zurück.
		/// </summary>
		/// <param name="user">Die Benutzerinstanz, für die die neue Aufgabe erstellt werden soll.</param>
		/// <returns>Die Instanz eines neuen Task Objekts.</returns>
		public Task AddTask(User user)
		{
			dsTasks.TaskRow tRow = DataManager.TaskDataService.AddTaskRow();
			if (tRow != null)
			{
				Task newTask = new Task(tRow);
				this.GetTaskList(user).Add(newTask);
				return newTask;
			}
			return null;
		}

		public SortableBindingList<Task> GetTaskList(User forUser)
		{
			if (this.myTaskRepository != null)
			{
				if (this.myTaskRepository.ContainsKey(forUser))
				{
					// Task Dictionary gibt es und es enthält auch die Taskliste des angegebenen Users.
					return this.myTaskRepository[forUser];
				}
				else
				{
					// Task Dictionary gibt es aber für den User wurde die Taskliste noch nicht erstellt.
					SortableBindingList<Task> taskList = this.CreateTaskList();
					if (taskList != null)
					{
						this.myTaskRepository.Add(forUser, taskList);
						return taskList;
					}
					else return null;
				}
			}
			else if (this.myTaskRepository == null)
			{
				// Es gibt noch kein Dictionary. Versuchen, die Tasks für den User zu holen und wenn erfolgreich Dictionary instanzieren.
				SortableBindingList<Task> taskList = this.CreateTaskList();
				if (taskList != null)
				{
					this.myTaskRepository = new Dictionary<User, SortableBindingList<Task>>();
					this.myTaskRepository.Add(forUser, taskList);
					return taskList;
				}
				else return null;
			}
			return null;
		}

		/// <summary>
		/// Gibt den Task mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="taskPK"></param>
		/// <returns></returns>
		public Task GetTask(User user, string taskPK)
		{
			return this.GetTaskList(user).FirstOrDefault(t => t.UID == taskPK);
		}

		/// <summary>
		/// Aktualisiert die Task Tabelle in der Datenbank.
		/// </summary>
		public void UpdateTasksAndReminders()
		{
			DataManager.TaskDataService.UpdateTaskTable();
			foreach (var repItem in this.myTaskRepository)
			{
				foreach (var task in repItem.Value)
				{
					if (task.Reminder != null && task.Reminder.IsUpdateRequired)
					{
						ModelManager.ReminderService.UpdateReminder(task.Reminder);
					}
				}
			}
			DataManager.TaskDataService.UpdateReminderTable();
		}

		#endregion

		#region private procedures

		private SortableBindingList<Task> CreateTaskList()
		{
			SortableBindingList<Task> taskList = new SortableBindingList<Task>();
			foreach (var tRow in DataManager.TaskDataService.GetTaskTable())
			{
				taskList.Add(new Task(tRow));
			}
			return taskList;
		}

		#endregion

	}
}
