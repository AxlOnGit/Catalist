using System;
using System.Diagnostics;
using System.Linq;
using Products.Common;
using Products.Common.Collections;
using Products.Data;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class UserService
	{
		#region PUBLIC ENUMS

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

		#endregion PUBLIC ENUMS

		#region MEMBERS

		SBList<User> myUsersList;
		SBList<User> myActiveUsersList;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt den derzeit am System angemeldeten User zurück.
		/// </summary>
		public User CurrentUser
		{
			get
			{
				var envUser = Environment.UserName.ToLower();
				if (Environment.UserName.ToLower() == "a.ullrich@cut-print.de") envUser = "felix";
				var user = this.myUsersList.FirstOrDefault(u => u.LoginWindows.ToLower() == envUser);
				if (user != null) return user;
				return this.myUsersList.FirstOrDefault(u => u.LoginWindows.ToLower() == "axel");
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Products.Model.Services.UserService Klasse.
		/// </summary>
		public UserService()
		{
			this.InitializeUserList();

			// Im DataManager den Primärschlüssel des derzeit am System angemeldeten
			// Benutzers festlegen.
			DataManager.CurrentUserPK = this.CurrentUser.UID;
			ModelManager.CurrentUserPK = this.CurrentUser.UID;

			this.InitializeReminders();
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Gibt eine sortierbare Liste aller Benutzer des Systems zurück.
		/// </summary>
		public SBList<User> GetUserList() => this.myUsersList.Sort("NameFirst");

		/// <summary>
		/// Gibt eine Liste aller aktiven User des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SBList<User> GetActiveUsersList() => this.myActiveUsersList.Sort("NameFirst");

		/// <summary>
		/// Gibt den User zurück, der den Suchkriterien entspricht.
		/// </summary>
		/// <param name="searchFor">Die Zeichenfolge anhand der gesucht wird.</param>
		/// <param name="searchType">Der Typ der Suche.</param>
		/// <returns></returns>
		public User GetUser(string searchFor, UserSearchParamType searchType)
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
				var arr = searchFor.Split(new char[] { '\\' });
				foreach (var str in arr)
				{
					var user = this.GetUser(str, UserSearchParamType.DavidUserFolder);
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

		/// <summary>
		/// Gibt eine Liste von Mitarbeitern entsprechend ihrer jeweiligen Rolle zurück.
		/// </summary>
		/// <param name="userType"></param>
		/// <returns></returns>
		public SortableBindingList<User> GetSpecialUserList(SpecialUserType userType)
		{
			var list = new SortableBindingList<User>();
			switch (userType)
			{
				case SpecialUserType.Technicien:
				list.Add(this.GetUser("Felix", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("Matthias", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("Johannes", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("MarkusR", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("Axel", UserSearchParamType.WindowsLoginName));
				return list;

				case SpecialUserType.SalesAndMarketing:
				list.Add(this.GetUser("Markus", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("Tanja", UserSearchParamType.WindowsLoginName));
				return list;

				case SpecialUserType.Accounting:
				list.Add(this.GetUser("Eva", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("Margret", UserSearchParamType.WindowsLoginName));
				return list;

				case SpecialUserType.Warehouse:
				list.Add(this.GetUser("eduard", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("JulianZ", UserSearchParamType.WindowsLoginName));
				list.Add(this.GetUser("MarkusR", UserSearchParamType.WindowsLoginName));
				return list;

				default:
				return null;
			}
		}

		/// <summary>
		/// Aktualisiert alle Änderungen der User Instanzen.
		/// </summary>
		public void Update()
		{
			DataManager.UserDataService.Update();
		}

		#endregion PUBLIC PROCEDURES

		#region PUBLIC PROCEDURES

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
		}

		void InitializeReminders()
		{
			Debug.Print("Initializing Reminders ...");
		}

		#endregion PUBLIC PROCEDURES
	}
}