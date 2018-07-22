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
using Products.Model;

namespace Products.Common.Views
{
	public partial class UserDetailView : MetroForm
	{

		#region members

		User myUser;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der UserDetailView Klasse.
		/// </summary>
		public UserDetailView(User user)
		{
			InitializeComponent();
			this.myUser = user;
			this.InitializeData();
		}

		#endregion

		#region event handler

		void lblAppointmentColor_Click(object sender, EventArgs e)
		{
			if (this.colorDlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				this.lblAppointmentColor.BackColor = this.colorDlg.Color;
				this.myUser.AppointmentColor = this.colorDlg.Color;
			}
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.DataBindings.Add("Text", myUser, "UserName");
			this.mtxtUserName.DataBindings.Add("Text", this.myUser, "UserName");
			this.mtxtSignature.DataBindings.Add("Text", myUser, "Signature");
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{
			ModelManager.UserService.Update();
			this.Close();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		private void mbtnPreloadUserCalendars_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK)
			{
				var userList = usv.SelectedUsers;
				if (userList.Count > 0)
				{
					var userCals = new string[userList.Count];
					for (int i = 0; i < userList.Count; i++)
					{
						userCals[i] = userList[i].UID;
					}
					CatalistRegistry.CalendarSettings.SetPreloadUserList(userCals);
				}
			}
		}
	}
}
