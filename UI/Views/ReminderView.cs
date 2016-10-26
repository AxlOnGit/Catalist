using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ReminderView : MetroForm
	{
		#region members

		readonly Reminder myReminder;
		Task myTask;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ReminderView Klasse.
		/// </summary>
		public ReminderView(Reminder reminder)
		{
			InitializeComponent();
			this.myReminder = reminder;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region private procedures

		bool SetNewRemindAt()
		{
			var newRemindAt = DateTime.MinValue;
			int minOrHour = 0;

			if (int.TryParse((string)this.mcmbRemindMeIn.SelectedValue, out minOrHour))
			{
				if (minOrHour == 1)
				{
					newRemindAt = DateTime.Now.AddHours(1);
				}
				else newRemindAt = DateTime.Now.AddMinutes(minOrHour);
				this.myReminder.SetNewRemindAt(newRemindAt);
				return true;
			}
			return false;
		}

		void InitializeData()
		{
			this.myTask = ModelManager.TaskService.GetTask(ModelManager.UserService.CurrentUser, this.myReminder.TaskId);
			this.mcmbRemindMeIn.SelectedIndex = 1;
			this.Text = string.Format("So, ist {0} Uhr jetzt!", DateTime.Now.ToShortTimeString());
			this.mlblDescription.Text = this.myReminder.Description;
		}

		#endregion private procedures

		#region event handler

		void mbtRemindAgain_Click(object sender, EventArgs e)
		{
			if (this.SetNewRemindAt())
			{
				this.Close();
			}
			else MetroMessageBox.Show(this, "Ich konnte die neue Erinnerungszeit nicht setzen.", "Wecker", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		void mbtnShowTask_Click(object sender, EventArgs e)
		{
			var tdv = new TaskDetailView(this.myTask, ModelManager.UserService.CurrentUser);
			tdv.Show();
			this.Close();
		}

		void mbtnDiscard_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler
	}
}