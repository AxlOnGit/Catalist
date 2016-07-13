using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class TaskListView : MetroForm
	{

		#region members

		User myUser;
		SortableBindingList<Task> myTaskList;
		Task mySelectedTask;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TaskListView Klasse.
		/// </summary>
		public TaskListView(SortableBindingList<Task> taskList, User forUser)
		{
			InitializeComponent();
			this.myTaskList = taskList;
			this.myUser = forUser;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void TaskListView_MouseEnter(object sender, EventArgs e)
		{
			this.Focus();
		}

		void dgvTasks_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedTask = this.dgvTasks.Rows[e.RowIndex].DataBoundItem as Model.Entities.Task;
			this.mtxtDescription.DataBindings.Clear();
			this.mtxtDescription.DataBindings.Add("Text", this.mySelectedTask, "Description");
		}

		void btnShowDetails_Click(object sender, EventArgs e)
		{
			this.ShowTaskDetails();
		}

		void dgvTasks_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowTaskDetails();
		}

		void btnNewTask_Click(object sender, EventArgs e)
		{
			var task = Model.ModelManager.TaskService.AddTask(this.myUser);
			this.dgvTasks.ClearSelection();
			int ixLastRow = this.dgvTasks.Rows.Count - 1;
			this.dgvTasks.Rows[ixLastRow].Selected = true;
		}

		void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void TaskListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Model.ModelManager.TaskService.UpdateTasksAndReminders();
		}

		#endregion

		#region public procedures
		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvTasks.AutoGenerateColumns = false;
			this.dgvTasks.DataSource = this.myTaskList;
			this.dgvTasks.RowEnter += dgvTasks_RowEnter;
			this.dgvTasks.MouseDoubleClick += dgvTasks_MouseDoubleClick;

			this.FormClosing += TaskListView_FormClosing;
		}

		void ShowTaskDetails()
		{
			if (this.mySelectedTask == null) return;
			var tdv = new TaskDetailView(this.mySelectedTask, this.myUser);
			tdv.ShowDialog();
		}

		#endregion

	}
}
