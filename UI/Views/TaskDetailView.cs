using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class TaskDetailView : MetroForm
	{
		#region members

		readonly Task myTask;
		readonly User myUser;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TaskDetailView Klasse.
		/// </summary>
		public TaskDetailView(Task task, User user)
		{
			InitializeComponent();
			this.myTask = task;
			this.myUser = user;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void TaskDetailView_MouseEnter(object sender, EventArgs e)
		{
			//this.Focus();
		}

		void mbtnShowReminder_Click(object sender, EventArgs e)
		{
			var reminder = this.myTask.Reminder;
			if (reminder == null) return;
			var rv = new ReminderView(this.myTask.Reminder);
			rv.ShowDialog();
		}

		void ndtpReminderDate_ValueChanged(object sender, EventArgs e)
		{
			// Beim Ausschalten der Checkbox muss der Reminder dieses Tasks gelöscht werden
			if (!this.ndtpReminderDate.Checked && this.myTask.Reminder != null) this.myTask.RemoveReminder();
		}

		void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void TaskDetailView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.TaskService.UpdateTasksAndReminders();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.DataBindings.Add("Text", this.myTask, "Taskname");
			this.mtxtTaskname.DataBindings.Add("Text", this.myTask, "Taskname");
			this.ndtpStartsAt.DataBindings.Add("Value", this.myTask, "StartsAt");
			var dueAtBinding = this.ndtpDueAt.DataBindings.Add("Value", this.myTask, "DueAt", true);
			dueAtBinding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

			this.mcmbPriority.ValueMember = "Key";
			this.mcmbPriority.DisplayMember = "Priority";
			this.mcmbPriority.DataSource = ModelManager.ModelService.PriorityList;
			this.mcmbPriority.DataBindings.Add("SelectedValue", this.myTask, "Priority");

			this.mcmbStatus.ValueMember = "Key";
			this.mcmbStatus.DisplayMember = "Status";
			this.mcmbStatus.DataSource = ModelManager.ModelService.StatusList;
			this.mcmbStatus.DataBindings.Add("SelectedValue", this.myTask, "Status");

			this.mtxtDescription.DataBindings.Add("Text", this.myTask, "Description");

			this.mcmbCompleted.DataBindings.Add("Text", this.myTask, "PercentCompleted");

			if (this.myTask.Reminder != null)
			{
				this.ndtpReminderDate.Checked = true;
				this.ndtpReminderDate.DataBindings.Add("Value", this.myTask.Reminder, "RemindAt");
				this.ndtpReminderTime.DataBindings.Add("Value", this.myTask.Reminder, "RemindAt");
			}
			else
			{
				this.ndtpReminderDate.Value = null;
				this.ndtpReminderDate.Checked = false;
				this.ndtpReminderTime.Value = null;
				this.ndtpReminderTime.Enabled = false;
			}
			this.FormClosing += TaskDetailView_FormClosing;
		}

		#endregion private procedures
	}
}