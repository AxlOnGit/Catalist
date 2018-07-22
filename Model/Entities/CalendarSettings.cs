using System.Collections.Generic;
using System.ComponentModel;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	/// <summary>
	/// Klasse für diverse Kalendervoreinstellungen.
	/// </summary>
	public class CalendarSettings
	{
		#region EVENTS

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion EVENTS

		#region MEMBERS

		readonly User myUser;
		readonly List<ILinkedItem> myLinkedItemsList = new List<ILinkedItem>();

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt die Liste der Mitarbeiter zurück, deren Kalender beim Start geladen werden sollen oder legt sie fest.
		/// </summary>
		public List<User> PreloadUserList
		{
			get
			{
				var list = new List<User>();
				list.Add(this.myUser);
				var keyArray = CatalistRegistry.CalendarSettings.GetPreloadUserList();
				foreach (var item in keyArray)
				{
					if (item == this.myUser.UID) continue;
					list.Add(ModelManager.UserService.GetUser(item, Services.UserService.UserSearchParamType.PrimaryKey));
				}
				return list;
			}
			set
			{
				var keyArray = new string[value.Count - 1];
				for (int i = 0; i < value.Count; i++)
				{
					keyArray[i] = value[i].UID;
				}
				CatalistRegistry.CalendarSettings.SetPreloadUserList(keyArray);
			}
		}

		/// <summary>
		/// Gibt den Mitarbeiter zurück, für den aktuell Termine erstellt werden.
		/// </summary>
		public User TargetUser
		{
			get
			{
				if (string.IsNullOrEmpty(CatalistRegistry.CalendarSettings.GetTargetUserKey()))
				{
					CatalistRegistry.CalendarSettings.SetTargetUserKey(this.myUser.UID);
					return this.myUser;
				}
				return ModelManager.UserService.GetUser(CatalistRegistry.CalendarSettings.GetTargetUserKey(), Services.UserService.UserSearchParamType.PrimaryKey);
			}
			private set
			{
				CatalistRegistry.CalendarSettings.SetTargetUserKey(value.UID);
				this.NotifyPropertyChanged("TargetUser");
			}
		}

		/// <summary>
		/// Gibt das maximale Alter der zu ladenden Kalendereinträge zurück oder legt es fest.
		/// </summary>
		public int AppointmentAge
		{
			get
			{
				return CatalistRegistry.CalendarSettings.GetAppointmentAge();
			}
			set
			{
				CatalistRegistry.CalendarSettings.SetAppointmentAge(value);
			}
		}

		/// <summary>
		/// Gibt die Liste von Elementen zurück, mit denen der nächste Termin verknüpft werden soll.
		/// </summary>
		public List<ILinkedItem> LinkedItemsList => this.myLinkedItemsList;

		/// <summary>
		/// Legt fest, ob die Kundenadresse automatisch in den Terminort eingetragen wird.
		/// </summary>
		public bool AddCustomerAddress
		{
			get
			{
				return CatalistRegistry.CalendarSettings.GetAddCustomerAddressFlag();
			}
			set
			{
				CatalistRegistry.CalendarSettings.SetAddCustomerAddressFlag(value);
			}
		}

		/// <summary>
		/// Legt fest, ob Kundendetails in den Text des Termins eingefügt werden.
		/// </summary>
		public bool AddCustomerInfo
		{
			get
			{
				return CatalistRegistry.CalendarSettings.GetAddCustomerInfoFlag();
			}
			set
			{
				CatalistRegistry.CalendarSettings.SetAddCustomerInfoFlag(value);
			}
		}

		/// <summary>
		/// Legt fest, ob beim automatischen Eintragen von Termineigenschaften auch die (aktiven)
		/// Notizen des Kunden eingetragen werden sollen.
		/// </summary>
		public bool AddCustomerNotes
		{
			get
			{
				return CatalistRegistry.CalendarSettings.GetAddCustomerNotesFlag();
			}
			set
			{
				CatalistRegistry.CalendarSettings.SetAddCustomerNotesFlag(value);
			}
		}

		/// <summary>
		/// Legt fest, ob die Sonderpreise des Kunden in neue Termine eingefügt werden.
		/// </summary>
		public bool AddCustomerPriceList
		{
			get { return CatalistRegistry.CalendarSettings.GetAddCustomerPriceListFlag(); }
			set { CatalistRegistry.CalendarSettings.SetAddCustomerPriceListFlag(value); }
		}

		/// <summary>
		/// Legt fest, ob für Service- und Wartungstermine ein Servicebericht erstellt werden soll.
		/// </summary>
		public bool CreateServiceReport
		{
			get { return CatalistRegistry.CalendarSettings.GetCreateServiceReport(); }
			set { CatalistRegistry.CalendarSettings.SetCreateServiceReport(value); }
		}

		/// <summary>
		/// Gibt die Farbe für Termine des Benutzers zurück oder legt sie fest.
		/// </summary>
		public System.Drawing.Color AppointmentColor
		{
			get
			{
				var color = System.Drawing.Color.FromArgb(CatalistRegistry.CalendarSettings.GetAppointmentColor());
				return color;
			}
			set
			{
				CatalistRegistry.CalendarSettings.SetAppointmentColor(value.ToArgb());
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CalendarSettings Klasse.
		/// </summary>
		/// <param name="user"></param>
		public CalendarSettings(User user)
		{
			this.myUser = user;
			this.Initialize();
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Legt den Mitarbeiter fest, für den neue Termine erfasst werden sollen.
		/// </summary>
		/// <param name="targetUser">
		/// Die Instanz des Users, für den neue Termine erfasst werden sollen.
		/// </param>
		/// <returns></returns>
		public CalendarSettings SetTargetUser(User targetUser)
		{
			this.TargetUser = targetUser;
			this.NotifyPropertyChanged("TargetUser");
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
			this.NotifyPropertyChanged("AddCustomerInfo");
			return this;
		}

		/// <summary>
		/// Legt fest, ob beim automatischen Eintragen von Termineigenschaften auch die Notizen des
		/// Kunden eingefügt werden sollen.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetAddCustomerNotes(bool yesOrNo)
		{
			this.AddCustomerNotes = yesOrNo;
			this.NotifyPropertyChanged("AddCustomerNotes");
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
			this.NotifyPropertyChanged("AddCustomerAddress");
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
			this.NotifyPropertyChanged("AddCustomerPriceList");
			return this;
		}

		/// <summary>
		/// Legt fest, ob bei neuen Service- oder Wartungsterminen ein automatischer Servicebericht
		/// erstellt werden soll.
		/// </summary>
		/// <param name="yesOrNo"></param>
		/// <returns></returns>
		public CalendarSettings SetCreateServiceReport(bool yesOrNo)
		{
			this.CreateServiceReport = yesOrNo;
			this.NotifyPropertyChanged("CreateServiceReport");
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
			this.NotifyPropertyChanged("LinkedItemsList");
			return this;
		}

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		void Initialize()
		{
			if (this.TargetUser == null) this.TargetUser = ModelManager.UserService.CurrentUser;
		}

		void NotifyPropertyChanged(string propertyName)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion PRIVATE PROCEDURES
	}
}