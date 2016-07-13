using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common;
using Products.Data;
using Products.Model.Entities;
using Products.Data.Datasets;
using Products.Common.Interfaces;
using System.IO;
using Products.Common.Collections;

namespace Products.Model.Services
{

	public class ModelService
	{

		#region members

		private SortableBindingList<TaskPriority> myPriorityList = null;
		private SortableBindingList<TaskStatus> myStatusList = null;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt eine nummerierte Liste mit Prioritäten für  zurück.
		/// </summary>
		public SortableBindingList<TaskPriority> PriorityList
		{
			get
			{
				if (this.myPriorityList == null)
				{
					this.myPriorityList = new SortableBindingList<TaskPriority>();
					this.myPriorityList.Add(new TaskPriority(0, "Niedrig"));
					this.myPriorityList.Add(new TaskPriority(1, "Normal"));
					this.myPriorityList.Add(new TaskPriority(2, "Hoch"));
				}
				return this.myPriorityList;
			}
		}

		/// <summary>
		/// Gibt eine nummerierte Liste mit Aufgabenstatus zurück.
		/// </summary>
		public SortableBindingList<TaskStatus> StatusList
		{
			get
			{
				if (this.myStatusList == null)
				{
					this.myStatusList = new SortableBindingList<TaskStatus>();
					this.myStatusList.Add(new TaskStatus(0, "Nicht begonnen"));
					this.myStatusList.Add(new TaskStatus(1, "In Bearbeitung"));
					this.myStatusList.Add(new TaskStatus(2, "Erledigt"));
					this.myStatusList.Add(new TaskStatus(3, "Wartet auf jemand anderen"));
					this.myStatusList.Add(new TaskStatus(4, "Zurückgestellt"));
				}
				return this.myStatusList;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the ModelService class.
		/// </summary>
		public ModelService()
		{
		}

		#endregion

		#region private procedures
		#endregion

		#region STRUCTS

		/// <summary>
		/// Struct für die Anzeige von Aufgabenprioritäten in Kombinationsfeldern.
		/// </summary>
		public struct TaskPriority
		{
			public sbyte Key { get; private set; }
			public string Priority { get; private set; }

			public TaskPriority(sbyte key, string prio)
				: this()
			{
				Key = key;
				Priority = prio;
			}
		}

		/// <summary>
		/// Struct für die Anzeige von Aufgabenstatus in Kombinationsfeldern.
		/// </summary>
		public struct TaskStatus
		{
			public sbyte Key { get; private set; }
			public string Status { get; private set; }

			public TaskStatus(sbyte key, string status)
				: this()
			{
				this.Key = key;
				this.Status = status;
			}
		}

		/// <summary>
		/// Struct für die Anzeige von Prozentwerten in Kombinationsfeldern.
		/// </summary>
		public struct TaskPercentage
		{
			public int Percentage;

			public TaskPercentage(int percentage)
				: this()
			{
				this.Percentage = percentage;
			}
		}

		#endregion

	}
}
