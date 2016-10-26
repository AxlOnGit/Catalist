using System;
using System.Linq;
using Products.Common;
using Products.Model.Entities;
using Products.Data;
using System.Diagnostics;
using Products.Common.Collections;

namespace Products.Model.Services
{
	public class UserService
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
			DavidFileName,
			EmailAddressWork,
			EmailAddressPrivate
		}

		public enum SpecialUserType
		{
			Technicien,
			SalesAndMarketing,
			Accounting,
			Warehouse
		}

		#endregion

		#region members

		SBList<User> myUsersList;
		SBList<User> myActiveUsersList;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den derzeit am System angemeldeten User zurück.
		/// </summary>
		public User CurrentUser
		{
			get
			{
				var user = this.myUsersList.FirstOrDefault(u => u.LoginWindows.ToUpper() == Environment.UserName.ToUpper());
				if (user != null) return user;
				return this.myUsersList.FirstOrDefault(u => u.LoginWindows.ToLower() == "axel");
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Products.Model.Services.UserService Klasse.
		/// </summary>
		public UserService()
		{
			this.InitializeUserList();

			// Im DataManager den Primärschlüssel des derzeit am System angemeldeten Benutzers festlegen.
			DataManager.CurrentUserPK = this.CurrentUser.UID;
			ModelManager.CurrentUserPK = this.CurrentUser.UID;

			this.InitializeReminders();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine sortierbare Liste aller Benutzer des Systems zurück.
		/// </summary>
		public SBList<User> GetUserList()
		{
			return this.myUsersList.Sort("NameFirst");
		}

		public SBList<User> GetActiveUsersList()
		{
			return this.myActiveUsersList.Sort("NameFirst");
		}

		/// <summary>
		/// Gibt den User zurück, der den Suchkriterien entspricht.
		/// </summary>
		/// <param name="searchFor">Die Zeichenfolge anhand der gesucht wird.</param>
		/// <param name="searchType">Der Typ der Suche.</param>
		/// <returns></returns>
		public User FindUser(string searchFor, UserSearchParamType searchType)
		{
			switch (searchType)
			{
				case UserSearchParamType.PrimaryKey:
					return this.myUsersList.FirstOrDefault(u => u.UID.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.UserName:
					return this.myUsersList.FirstOrDefault(u => u.UserName.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.WindowsLoginName:
					return this.myUsersList.FirstOrDefault(u => u.LoginWindows.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.SageLoginName:
					return this.myUsersList.FirstOrDefault(u => u.SageLoginName.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.SageEmployeeId:
					return this.myUsersList.FirstOrDefault(u => u.SageEmplyeeId.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.DavidUserFolder:
					return this.myUsersList.FirstOrDefault(u => u.DavidUserFolder.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.DavidLoginName:
					return this.myUsersList.FirstOrDefault(u => u.DavidLoginName.ToUpper() == ((string)searchFor).ToUpper());

				case UserSearchParamType.DavidFileName:
					var arr = ((string)searchFor).Split(new char[] { '\\' });
					foreach (var str in arr)
					{
						var user = this.FindUser(str, UserSearchParamType.DavidUserFolder);
						if (user != null) return user;
					}
					return null;

				case UserSearchParamType.EmailAddressWork:
					return this.myUsersList.FirstOrDefault(u => u.EmailWork.ToUpper() == searchFor.ToUpper());

				case UserSearchParamType.EmailAddressPrivate:
					return this.myUsersList.FirstOrDefault(u => u.EmailPrivate.ToUpper() == searchFor.ToUpper());

				default:
					return null;
			}
		}

		public SortableBindingList<User> GetSpecialUserList(SpecialUserType userType)
		{
			var list = new SortableBindingList<User>();
			switch (userType)
			{
				case SpecialUserType.Technicien:
					list.Add(this.FindUser("Felix", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("Matthias", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("Johannes", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("MarkusR", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("Axel", UserSearchParamType.WindowsLoginName));
					return list;

				case SpecialUserType.SalesAndMarketing:
					list.Add(this.FindUser("Markus", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("Tanja", UserSearchParamType.WindowsLoginName));
					return list;

				case SpecialUserType.Accounting:
					list.Add(this.FindUser("Eva", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("Margret", UserSearchParamType.WindowsLoginName));
					return list;

				case SpecialUserType.Warehouse:
					list.Add(this.FindUser("eduard", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("JulianZ", UserSearchParamType.WindowsLoginName));
					list.Add(this.FindUser("MarkusR", UserSearchParamType.WindowsLoginName));
					return list;

				default:
					return null;
			}
		}

		public void Update()
		{
			DataManager.UserDataService.Update();
		}

		#endregion

		#region private procedures

		void InitializeUserList()
		{
			this.myUsersList = new SBList<User>();
			this.myActiveUsersList = new SBList<User>();
			foreach (var uRow in DataManager.UserDataService.GetAllUserRows())
			{
				var user = new User(uRow);
				this.myUsersList.Add(user);
				if (user.LoginWindows.ToLower() != "mario" && !string.IsNullOrEmpty(user.LoginWindows)) this.myActiveUsersList.Add(user);
			}
			var markus = this.myUsersList.FirstOrDefault(u => u.SageLoginName.ToLower() == "ms");
			var tanja = this.myUsersList.FirstOrDefault(u => u.SageLoginName.ToLower() == "tt");
			tanja.CalendarSettings.SetTargetUser(markus);
		}

		void InitializeReminders()
		{
			Debug.Print("Initializing Reminders ...");
		}

		#endregion

	}
}
