using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class UserSearchView : MetroForm
	{

		#region members

		User selectedUser;

		#endregion

		#region public properties

		public User SelectedUser { get { return selectedUser; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der UserSearchView Klasse.
		/// </summary>
		public UserSearchView()
		{
			InitializeComponent();
			dgvUser.AutoGenerateColumns = false;
			dgvUser.DataSource =  ModelManager.UserService.GetUserList();
		}

		#endregion

		#region event handler

		void dgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvUser.Rows.Count >= 1)
			{
				selectedUser = dgvUser.Rows[e.RowIndex].DataBoundItem as Model.Entities.User;
			}
		}

		#endregion

		#region private procedures

		void OkAndClose()
		{
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
