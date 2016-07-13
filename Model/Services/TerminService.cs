using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Model.Entities;
using David;

namespace Products.Model.Services
{
	public class TerminService
	{
		#region members

		private Dictionary<string, SortableBindingList<Termin>> terminListen 
			= new Dictionary<string,SortableBindingList<Termin>>();

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TerminService Klasse.
		/// </summary>
		public TerminService()
		{
			this.InitializeService();
		}

		#endregion

		/// <summary>
		/// Gibt eine sortierte Liste aller Termine des Benutzers mit dem angegebenen Sage Login zurück.
		/// </summary>
		/// <param name="sageUserLogin"></param>
		/// <returns></returns>
		public SortableBindingList<Termin> GetTerminliste(string sageUserLogin)
		{
			try
			{
				if (this.terminListen.ContainsKey(sageUserLogin))
				{
					return this.terminListen[sageUserLogin];
				}
				else
				{
					this.AddUserTermine(sageUserLogin);
					return this.terminListen[sageUserLogin];
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#region private procedures

		private void InitializeService()
		{
			try
			{
				this.AddUserTermine(ModelManager.UserService.CurrentUser.SageLoginName);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void AddUserTermine(string sageUserLogin)
		{
			try
			{
				var user = ModelManager.UserService.GetUser(sageUserLogin, UserService.UserSearchParamType.SageLoginName);
				if (user != null)
				{
					var userArchive = user.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender);
					var liste = new SortableBindingList<Termin>();
					var items2Liste = David.DavidManager.DavidService.GetCalendarItems(userArchive);
					foreach (DvApi32.MessageItem2 item2 in items2Liste)
					{
						// Erinnerungen für abgelaufene Termine ausstellen => ReminderTime = -1 (Feld Nr. 78)
						var fields = (DvApi32.Fields)item2.Fields;
						if (((DateTime)fields.Item(DavidFieldEnum.StartsAt).Value <= DateTime.Now) && ((int)fields.Item(DavidFieldEnum.RemindAt).Value > -1))
						{
							fields.Item(DavidFieldEnum.RemindAt).Value = -1;
							item2.Save();
						}
						liste.Add(new Termin(item2));
					}
					terminListen.Add(user.SageLoginName, liste);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

	}
}
