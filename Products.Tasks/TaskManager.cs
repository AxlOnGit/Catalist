using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Tasks
{
	public static class TaskManager
	{

		#region members

		private static TaskService taskService = null;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den statischen TaskService zurück.
		/// </summary>
		public static TaskService TaskService
		{
			get 
			{
				if (taskService == null)
				{
					taskService = new TaskService();
				}
				return taskService;
			}
		}


		#endregion


	}
}
