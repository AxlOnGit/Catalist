using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	/// <summary>
	/// Klasse für diverse Kalendervoreinstellungen.
	/// </summary>
	public class CalendarSettings
	{

		#region members

		readonly User myUser = null;
		readonly List<ILinkedItem> myLinkedItemsList = new List<ILinkedItem>();

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den Mitarbeiter zurück, für den aktuell Termine erstellt werden.
		/// </summary>
		public User TargetUser { get; private set; }

		/// <summary>
		/// Gibt die Liste von Elementen zurück, mit denen der nächste Termin verknüpft werden soll.
		/// </summary>
		public List<ILinkedItem> LinkedItemsList
		{
			get { return this.myLinkedItemsList; }
		}

		/// <summary>
		/// Legt fest, ob die Kundenadresse automatisch in den Terminort eingetragen wird.
		/// </summary>
		public bool AddCustomerAddress { get; set; }

		/// <summary>
		/// Legt fest, ob Kundendetails in den Text des Termins eingefügt werden.
		/// </summary>
		public bool AddCustomerInfo { get; set; }

		/// <summary>
		/// Legt fest, ob beim automatischen Eintragen von Termineigenschaften auch
		/// die (aktiven) Notizen des Kunden eingetragen werden sollen.
		/// </summary>
		public bool AddCustomerNotes { get; set; }

		/// <summary>
		/// Legt fest, ob die Sonderpreise des Kunden in neue Termine eingefügt werden.
		/// </summary>
		public bool AddCustomerPriceList { get; set; }

		/// <summary>
		/// Legt fest, ob für Service- und Wartungstermine ein Servicebericht erstellt werden soll.
		/// </summary>
		public bool CreateServiceReport { get; set; }

		/// <summary>
		/// Gibt die Farbe für Termine des Benutzers zurück oder legt sie fest.
		/// </summary>
		public System.Drawing.Color AppointmentColor
		{
			get { return this.myUser.AppointmentColor; }
			set 
			{ 
				this.myUser.AppointmentColor = value;
				ModelManager.UserService.Update();
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CalendarSettings Klasse.
		/// </summary>
		/// <param name="user"></param>
		public CalendarSettings(User user)
		{
			this.myUser = user;
			this.TargetUser = user;
			this.Initialize();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt den Mitarbeiter fest, für den neue Termine erfasst werden sollen.
		/// </summary>
		/// <param name="targetUser">Die Instanz des Users, für den neue Termine erfasst werden sollen.</param>
		/// <returns></returns>
		public CalendarSettings SetTargetUser(User targetUser)
		{
			this.TargetUser = targetUser;
			return this;
		}

		/// <summary>
		/// Legt fest, ob Kundendetails in den Text eines neuen Termins eingefügt werden sollen.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetAddCustomerInfo(bool yesOrNo)
		{
			this.AddCustomerInfo = yesOrNo;
			return this;
		}

		/// <summary>
		/// Legt fest, ob beim automatischen Eintragen von Termineigenschaften auch
		/// die Notizen des Kunden eingefügt werden sollen.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetAddCustomerNotes(bool yesOrNo)
		{
			this.AddCustomerNotes = yesOrNo;
			return this;
		}

		/// <summary>
		/// Legt fest, ob die Kundenadresse automatisch als Terminort verwendet werden soll.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetAddCustomerAddress(bool yesOrNo)
		{
			this.AddCustomerAddress = yesOrNo;
			return this;
		}

		/// <summary>
		/// Legt fest, ob die Sonderpreise des Kunden in neue Termine eingefügt werden.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetAddCustomerPriceList(bool yesOrNo)
		{
			this.AddCustomerPriceList = yesOrNo;
			return this;
		}

		/// <summary>
		/// Legt fest, ob bei neuen Service- oder Wartungsterminen ein automatischer
		/// Servicebericht erstellt werden soll.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetCreateServiceReport(bool yesOrNo)
		{
			this.CreateServiceReport = yesOrNo;
			return this;
		}

		/// <summary>
		/// Fügt der Liste von zu verknüpfenden Elementen ein neues Element hinzu.
		/// </summary>
		/// <param name="linkedItem">Das zu verknüpfende Element.</param>
		/// <returns></returns>
		public CalendarSettings AddLinkedItem(ILinkedItem linkedItem)
		{
			this.myLinkedItemsList.Add(linkedItem);
			return this;
		}

		#endregion

		#region private procedures

		void Initialize()
		{
			this.SetAddCustomerAddress(true)
				.SetAddCustomerInfo(true)
				.SetAddCustomerNotes(false)
				.SetAddCustomerPriceList(false)
				.SetCreateServiceReport(true);
		}

		#endregion

	}
}
