using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Common;
using Products.Model.Entities;
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class SelectUsersView : MetroForm
	{

		#region members

		readonly SBList<User> myUserList;
		
		#endregion

		#region public properties

		/// <summary>
		/// Gibt die Liste der ausgewählten Benutzer zurück.
		/// </summary>
		public CheckedListBox.CheckedItemCollection CheckedUsersList
		{
			get { return this.chkListUsers.CheckedItems; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SelectUsersView Klasse.
		/// </summary>
		public SelectUsersView(SBList<User> userList, List<User> selectedUsersList, string title = "Mitarbeiterauswahl")
		{
			InitializeComponent();
			this.Text = title;
			this.myUserList = userList;
			this.InitializeData(selectedUsersList);
		}

		#endregion

		#region private procedures

		void InitializeData(List<User> selectedUsers)
		{
			this.chkListUsers.SelectedValue = "NameFull";

			int counter = this.myUserList.Count;
			this.myUserList.Sort("NameFirst");
			for (int i = 0; i < counter; i++)
			{
				User user = this.myUserList[i];
				this.chkListUsers.Items.Add(user);
				if (selectedUsers.Contains(user))
				{
					this.chkListUsers.SetItemChecked(i, true);
				}
			}
		}

		#endregion

		void mchkToggleSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.myUserList.Count; i++)
			{
				this.chkListUsers.SetItemChecked(i, this.mchkToggleSelectAll.CheckState == CheckState.Checked);
			}
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{

		}

	}
}
