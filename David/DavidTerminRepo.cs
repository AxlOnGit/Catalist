using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CatalistRegistry;
using DvApi32;

namespace David
{
	public class DavidTerminRepo
	{

		#region MEMBERS

		IApplication myApp;
		Account myAccount;
		bool myConnected;
		Dictionary<string, List<MessageItem2>> myMsgItm2Dictionary = new Dictionary<string, List<MessageItem2>>();

		#endregion

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Gibt eine Liste aller David Termine für den Benutzer mit dem angegebenen
		/// Primärschlüssel zurück.
		/// </summary>
		/// <param name="userArchivePath"></param>
		/// <returns></returns>
		public List<MessageItem2> GetMessageItem2List(string userPK, string userArchivePath)
		{
			if (!this.myMsgItm2Dictionary.ContainsKey(userPK)) this.LoadMessageItem2List(userPK, userArchivePath);
			return this.myMsgItm2Dictionary[userPK];
		}

		/// <summary>
		/// Entfernt alle Termineinträge aus dem internen Dictionary und erzwingt ein Neuladen beim
		/// nächsten Zugriff.
		/// </summary>
		public void Reset()
		{
			this.myMsgItm2Dictionary.Clear();
		}

		#endregion PUBLIC PROCEDURES

		#region PRIVATE/INTERNAL PROCEDURES

		void Connect()
		{
			if (this.myConnected) return;
			try
			{
				if (myApp == null)
				{
					myApp = new DavidAPIClass();
					myApp.LoginOptions = DvLoginOptions.DvLoginForceAsyncDuplicate;
					myAccount = myApp.Logon("", "", "", "", "", "AUTH");
					this.myConnected = true;
				}
			}
			catch (COMException)
			{
				this.myConnected = false;
			}
		}

		/// <summary>
		/// Fügt der Terminliste des angegebenen Benutzers den angegebenen Termin hinzu.
		/// </summary>
		/// <param name="userPK">Primärschlüssel des Benutzers.</param>
		/// <param name="userArchivePath">Der Pfad zum Kalendereintrag des Benutzers.</param>
		/// <param name="newItem2">Die <seealso cref="MessageItem2"/> Instanz mit dem Termin.</param>
		internal void AddMessageItem2(string userPK, string userArchivePath, MessageItem2 newItem2)
		{
			this.GetMessageItem2List(userPK, userArchivePath).Add(newItem2);
		}

		/// <summary>
		/// Entfernt das angegebene <seealso cref="MessageItem2"/> aus dem internen Dictionary.
		/// </summary>
		/// <param name="userPK">Primärschlüssel des Benutzers, dem das MessageItem2 zugeordnet ist.</param>
		/// <param name="forUserCalArchive">Das Benutzerarchiv, in dem sich das MessageItem2 befindet.</param>
		/// <param name="messageItem2">Die zu entfernende MessageItem2 Instanz.</param>
		internal void RemoveMessageItem2(string userPK, string forUserCalArchive, MessageItem2 messageItem2)
		{
			this.GetMessageItem2List(userPK, forUserCalArchive).Remove(messageItem2);
		}

		void LoadMessageItem2List(string userPK, string userArchivePath)
		{
			var msg = string.Empty;
			try
			{
				this.Connect();
				var monthsBack = CalendarSettings.GetAppointmentAge();
				var toDate = DateTime.Today.AddYears(1);
				var fromDate = DateTime.Today.AddMonths(monthsBack * -1);
				var from = fromDate.ToString("M-d-yyyy H:m:s");
				var to = toDate.ToString("M-d-yyyy H:m:s");
				var filter = $"OnlyEMail StatusTime=\"{from} - {to}\"{char.MinValue}";
				var calArchive = this.myAccount.GetArchive(userArchivePath);
				if (calArchive == null)
				{
					msg = $"Den Kalenderordner '{userArchivePath}' gibt es nicht.";
					throw new ApplicationException(msg);
				}
				var items = calArchive.GetArchiveEntries(filter);
				List<MessageItem2> list = new List<MessageItem2>();
				foreach (var item in items)
				{
					list.Add(item as MessageItem2);
				}
				this.myMsgItm2Dictionary.Add(userPK, list);
			}
			catch (Exception)
			{
				msg = $"Ich konnte auf das Archiv {userArchivePath} auf dem DAVID Server nicht zugreifen.";
				throw new ApplicationException(msg);
			}
		}

		#endregion PRIVATE/INTERNAL PROCEDURES

	}
}
