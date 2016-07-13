using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsUserTableAdapters;
using Products.Common;

namespace Products.Data.Services
{
	public class UserDataService
	{

		#region public enums

		public enum UserSearchParamType
		{
			PrimaryKey,
			UserName,
			WindowsLoginName,
			SageLoginName,
			SageEmployeeId,
			DavidUserFolder,
			DavidLoginName,
			EmailAddressWork,
			EmailAddressPrivate
		}

		#endregion

		#region members

		private dsUser myUserDS = new dsUser();
		private taUser myUserAdapter = new taUser();

		#endregion

		#region public properties

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der UserService Klasse.
		/// </summary>
		public UserDataService()
		{
			this.InitializeData();
		}

		#endregion

		#region public procedures

		public dsUser.UserRow GetUserRow(string searchString, UserSearchParamType searchType)
		{
			switch (searchType)
			{
				case UserSearchParamType.PrimaryKey:
					return this.myUserDS.User.FindByUID(searchString);

				case UserSearchParamType.UserName:
					return this.myUserDS.User.FirstOrDefault(u => u.UserName.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.WindowsLoginName:
					return this.myUserDS.User.FirstOrDefault(u => u.UserName.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.SageLoginName:
					return this.myUserDS.User.FirstOrDefault(u => u.Login_Sage.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.SageEmployeeId:
					return this.myUserDS.User.FirstOrDefault(u => u.SageEmployeeId.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.DavidUserFolder:
					return this.myUserDS.User.FirstOrDefault(u => u.UserFolderDavid.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.DavidLoginName:
					return this.myUserDS.User.FirstOrDefault(u => u.Login_David.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.EmailAddressWork:
					return this.myUserDS.User.FirstOrDefault(u => u.EmailWork.ToUpper() == searchString.ToUpper());

				case UserSearchParamType.EmailAddressPrivate:
					return this.myUserDS.User.FirstOrDefault(u => u.EmailPrivate.ToUpper() == searchString.ToUpper());

				default:
					return null;
			}

		}

		public IEnumerable<dsUser.UserRow> GetAllUserRows()
		{
			return this.myUserDS.User;
		}

		/// <summary>
		/// Speichert geänderte Benutzerdaten in der Datenbank.
		/// </summary>
		public void Update()
		{
			this.myUserAdapter.Update(this.myUserDS.User);
		}

		#endregion

		#region private procedures

		private void InitializeData()
		{
			this.myUserAdapter.Fill(this.myUserDS.User);
		}

		#endregion

	}
}
