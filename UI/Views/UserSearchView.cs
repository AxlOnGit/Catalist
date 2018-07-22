using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class UserSearchView : MetroForm
	{

		#region MEMBERS

		User mySelectedUser;
		List<User> mySelectedUsers = new List<User>();

		#endregion

		#region public properties

		public User SelectedUser => mySelectedUser;

		public List<User> SelectedUsers => this.mySelectedUsers;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der UserSearchView Klasse.
		/// </summary>
		public UserSearchView()
		{
			InitializeComponent();
			dgvUser.AutoGenerateColumns = false;
			dgvUser.DataSource = ModelManager.UserService.GetUserList();
		}

		#endregion

		#region event handler

		void dgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvUser.Rows.Count >= 1)
			{
				mySelectedUser = dgvUser.Rows[e.RowIndex].DataBoundItem as User;
			}
		}

		private void mbtnOk_Click(object sender, System.EventArgs e)
		{
			this.OkAndClose();
		}

		#endregion

		#region private procedures

		void OkAndClose()
		{
			foreach (DataGridViewRow row in this.dgvUser.SelectedRows)
			{
				this.mySelectedUsers.Add(row.DataBoundItem as User);
			}
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		void CancelAndClose()
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		#endregion

	}
}
