using System;
using System.Text;
using David;
using Products.Common;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Appointment : Calendar.Appointment, ILinkedItem
	{
		#region MEMBERS

		private readonly DvApi32.MessageItem2 myMsgItem2Base;
		private readonly DvApi32.Fields myMsgItem2Fields;
		private dsAppointments.AppointmentXrefRow myXrefBase;
		private bool myIsDirty;

		#endregion MEMBERS

		#region events

		protected override void OnStartDateChanged()
		{
			this.StartsAt = StartDate;
			base.OnStartDateChanged();
		}

		protected override void OnEndDateChanged()
		{
			this.EndsAt = EndDate;
			base.OnEndDateChanged();
		}

		#endregion events

		#region public properties

		#region ILinkedItem

		public string Key => this.FullName;

		public string LinkTypeId => ModelManager.SharedItemsService.GetLinkTypeByName("Termin").UID;

		/// <summary>
		/// Gibt die Bezeichnung des verknüpften Elements zurück.
		/// </summary>
		public string ItemName => string.Format("{0} [{1}]", this.myMsgItem2Base.Subject, this.OwnerName);

		/// <summary>
		/// Gibt die Bezeichnung des Linktyps zurück.
		/// </summary>
		public string LinkTypBezeichnung => "Termin";

		#endregion ILinkedItem

		#region MessageItem2

		/// <summary>
		/// Gibt true zurück, wenn es sich bei dem Kalendereintrag um einen ganztägigen Termin
		/// handelt, sonst false.
		/// </summary>
		public new bool AllDayEvent
		{
			get
			{
				return (bool)this.GetFieldValue(DavidFieldsEnum.AllDayEvent);
			}
			set
			{
				if (this.AllDayEvent != value)
				{
					this.SetFieldValue(DavidFieldsEnum.AllDayEvent, value);
					base.AllDayEvent = value;
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt den Typ des Termins zurück oder legt ihn fest.
		/// </summary>
		public string AppointmentType
		{
			get { return this.myXrefBase.AppointmentType; }
			set
			{
				if (!this.AppointmentType.Equals(value))
				{
					this.myXrefBase.AppointmentType = value;
				}
			}
		}

		/// <summary>
		/// Gibt den Body des Kalendereintrags als ASCII kodierten Text zurück oder legt ihn fest.
		/// </summary>
		public string BodyAscii
		{
			get { return (string)this.GetFieldValue(DavidFieldsEnum.Content); }
			set
			{
				if (this.BodyAscii != value)
				{
					this.SetFieldValue(DavidFieldsEnum.Content, value);
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt den Body des Kalendereintrags im HTML Format zurück oder legt ihn fest.
		/// </summary>
		public string BodyHtml
		{
			get { return (string)this.GetFieldValue(DavidFieldsEnum.HTML); }
			set
			{
				if (this.BodyHtml != value)
				{
					this.SetFieldValue(DavidFieldsEnum.HTML, value);
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit der letzten Änderung des Kalendereintrags zurück.
		/// </summary>
		public DateTime ChangedAt => (DateTime)this.GetFieldValue(DavidFieldsEnum.LastChangedTime);

		/// <summary>
		/// Gibt Datum und Uhrzeit des Terminendes zurück oder legt sie fest.
		/// </summary>
		public DateTime EndsAt
		{
			get { return (DateTime)this.GetFieldValue(DavidFieldsEnum.StopTime); }
			set
			{
				if (!this.EndsAt.Equals(value))
				{
					this.SetFieldValue(DavidFieldsEnum.StopTime, value);
					EndDate = value;
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt den vollständigen Pfad des Kalendereintrags auf dem David Server zurück.
		/// </summary>
		public string FullName
		{
			get
			{
				var fName = this.GetFieldValue(DavidFieldsEnum.FileName) as string;
				if (fName == null) return null;
				return fName.EndsWith(".001", StringComparison.CurrentCulture) ? fName : string.Format("{0}.001", fName);
			}
		}

		/// <summary>
		/// Gibt den Ort zurück, an dem der Termin stattfindet oder legt ihn fest.
		/// </summary>
		public string Location
		{
			get { return this.GetFieldValue(DavidFieldsEnum.Location) as string; }
			set
			{
				if (!this.Location.Equals(value))
				{
					this.SetFieldValue(DavidFieldsEnum.Location, value);
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt die Anzahl an Minuten zurück, die der Benutzer vor dem Terminbeginn erinnert werden
		/// soll oder legt sie fest.
		/// </summary>
		public int RemindAt
		{
			get { return (int)this.GetFieldValue(DavidFieldsEnum.ReminderTime); }
			set
			{
				if (!this.RemindAt.Equals(value))
				{
					if (value.Equals(0)) value = -1;  // Der Wert -1 schaltet die Erinnerungsfunktion aus.
					this.SetFieldValue(DavidFieldsEnum.ReminderTime, value);
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt zurück, ob der Termin als 'Frei', 'Beschäftigt', 'Abwesend' oder 'Unter Vorbehalt'
		/// angezeigt werden soll oder legt das fest.
		/// </summary>
		public DvApi32.DvShowAsType ShowAs
		{
			get { return (DvApi32.DvShowAsType)this.GetFieldValue(DavidFieldsEnum.ShowAs); }
			set
			{
				if (this.ShowAs != value)
				{
					this.SetFieldValue(DavidFieldsEnum.ShowAs, value);
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit des Terminbeginns zurück oder legt sie fest.
		/// </summary>
		public DateTime StartsAt
		{
			get { return (DateTime)this.GetFieldValue(DavidFieldsEnum.SendTime); }
			set
			{
				if (!this.StartsAt.Equals(value))
				{
					this.SetFieldValue(DavidFieldsEnum.SendTime, value);
					StartDate = value;
					this.myIsDirty = true;
				}
			}
		}

		/// <summary>
		/// Gibt den Titel des Kalendereintrags zurück oder legt ihn fest.
		/// </summary>
		public string Subject
		{
			get { return this.myMsgItem2Base.Subject; }
			set
			{
				if (this.Subject != value)
				{
					this.myMsgItem2Base.Subject = value;
					Title = value;
					this.myIsDirty = true;
				}
			}
		}

		#endregion MessageItem2

		#region Entities and related

		/// <summary>
		/// Gibt den User zurück, der diesen Kalendereintrag ursprünglich erstellt hat.
		/// </summary>
		public User CreatedBy
		{
			get
			{
				var folder = ((int)this.GetFieldValue(DavidFieldsEnum.Creator)).ToString("X");
				return ModelManager.UserService.GetUser(folder, Services.UserService.UserSearchParamType.DavidUserFolder);
			}
		}

		/// <summary>
		/// Gibt den Namen des Users zurück, der den Kalendereintrag ursprünglich erstellt hat.
		/// </summary>
		public string CreatedByName => this.CreatedBy != null ? this.CreatedBy.NameFull : null;

		/// <summary>
		/// Gibt den Besitzer dieses Kalendereintrags zurück.
		/// </summary>
		public User Owner
		{
			get
			{
				var folder = ((int)this.GetFieldValue(DavidFieldsEnum.Owner)).ToString("X");
				return ModelManager.UserService.GetUser(folder, Services.UserService.UserSearchParamType.DavidUserFolder);
			}
		}

		/// <summary>
		/// Gibt den Namen des Benutzers zurück, in dessen Kalender dieser Kalendereintrag
		/// gespeichert ist.
		/// </summary>
		public string OwnerName => (this.Owner != null) ? this.Owner.NameFull : null;

		/// <summary>
		/// Gibt den User zurück, in dessen Kalender dieser Eintrag aktuell gespeichert ist.
		/// </summary>
		public User Responsible => ModelManager.UserService.GetUser(this.FullName, Services.UserService.UserSearchParamType.DavidFileName);

		/// <summary>
		/// Gibt Vor- und Nachnamen des Users zurück, in dessen Kalender dieser Eintrag aktuell
		/// gespeichert ist.
		/// </summary>
		public string ResponsibleName => this.Responsible != null ? this.Responsible.NameFull : null;

		#endregion Entities and related

		/// <summary>
		/// Gibt eine Übersicht für diesen Kalendereintrag im Ascii Format zurück (z. B. für ToolTips).
		/// </summary>
		/// <returns></returns>
		public string AppointmentInfo
		{
			get
			{
				var ev = Environment.NewLine;
				var sb = new StringBuilder();
				sb.AppendLine(string.Format("{0} - {1}", this.StartsAt.ToShortTimeString(), this.EndsAt.ToShortTimeString()));
				sb.AppendLine(string.Format("{0}", this.StartsAt.ToShortDateString()));
				sb.AppendLine(string.Format("{0}", this.Location));
				sb.AppendLine();
				sb.AppendLine(string.Format("{0}: {1} ({2})", this.ResponsibleName, this.Subject, this.AppointmentType));
				if (ModelManager.AppointmentService.GetLinkedItemsList(this).Count > 0) sb.AppendLine();
				foreach (var item in ModelManager.AppointmentService.GetLinkedItemsList(this))
				{
					sb.AppendLine("______________________________");
					sb.AppendLine(string.Format("{0}{1}{2}", item.LinkTypBezeichnung, ev, item.ItemName));
				}
				return sb.ToString();
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn der Kalendereintrag geändert wurde, sonst false.
		/// </summary>
		public bool IsDirty => this.myIsDirty;

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Appointment Klasse.
		/// </summary>
		/// <param name="baseItem2">
		/// Eine <seealso cref="DvApi32.MessageItem2"/> Instanz, die den Kalendereintrag in David repräsentiert.
		/// </param>
		/// <param name="xRefBase">
		/// Eine <seealso cref="Products.Data.Datasets.dsAppointments.AppointmentXrefRow"/> Instanz,
		/// die die Verknüpfung zwischen Kalendereintrag und dem verantwortlichen User repräsentiert.
		/// </param>
		public Appointment(DvApi32.MessageItem2 baseItem2, dsAppointments.AppointmentXrefRow xRefBase)
		{
			this.myMsgItem2Base = baseItem2;
			this.myMsgItem2Fields = baseItem2.Fields as DvApi32.Fields; ;
			this.myXrefBase = xRefBase;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region public procedures

		/// <summary>
		/// Gibt eine Übersicht im HTML-Format für diesen Kalendereintrag zurück (für ToolTips etc.).
		/// </summary>
		/// <returns></returns>
		public string GetAppointmentInfoHtml()
		{
			var sb = new StringBuilder();
			sb.Append(string.Format("<p><h3>{0}</h3></br>", this.ResponsibleName));
			sb.Append(string.Format("<em>{0}</br>", this.StartsAt.ToShortDateString()));
			sb.Append(string.Format("{0} - {1}</em></p>", this.StartsAt.ToShortTimeString(), this.EndsAt.ToShortTimeString()));
			sb.Append(string.Format("<q>{0}</q>", this.Subject));

			return sb.ToString();
		}

		internal SortableBindingList<ILinkedItem> GetLinkedItemsList() => ModelManager.AppointmentService.GetLinkedItemsList(this);

		/// <summary>
		/// Gibt die Felder und Feldinhalte der zugrundeliegenden MessageItem2 Instanz zurück.
		/// </summary>
		public string GetTermindetails()
		{
			var sb = new StringBuilder();
			for (int i = 0; i < 149; i++)
			{
				var field = ((DvApi32.Fields)this.myMsgItem2Base.Fields).Item(i);
				sb.AppendLine(string.Format("Feld {0}:\t{1}\t=> {2} ({3})", i, field.Name, field.Value.ToString(), field.GetType().ToString()));
			}
			return sb.ToString();
		}

		/// <summary>
		/// Aktualisiert dieses Appointment.
		/// </summary>
		/// <returns></returns>
		public int Update()
		{
			this.myMsgItem2Base.Save();
			return ModelManager.AppointmentService.Update();
		}

		#endregion public procedures

		#region private procedures

		private void InitializeData()
		{
			base.AllDayEvent = (bool)this.GetFieldValue(DavidFieldsEnum.AllDayEvent);
			this.Color = this.Responsible.AppointmentColor;
			this.SetBorderColor();
			this.DrawBorder = true;
			EndDate = this.EndsAt;
			this.Group = string.Empty;
			this.Layer = 0;
			this.Locked = false;
			StartDate = this.StartsAt;
			TextColor = System.Drawing.Color.FromArgb(32, 32, 32);
			Title = this.Subject;
		}

		private void SetBorderColor()
		{
			switch (ShowAs)
			{
				case DvApi32.DvShowAsType.DvShowAsBusy:
				BorderColor = System.Drawing.Color.DarkBlue;
				break;

				case DvApi32.DvShowAsType.DvShowAsFree:
				BorderColor = System.Drawing.Color.LightGreen;
				break;

				case DvApi32.DvShowAsType.DvShowAsOutOfOffice:
				BorderColor = System.Drawing.Color.DarkRed;
				break;

				case DvApi32.DvShowAsType.DvShowAsTentative:
				BorderColor = System.Drawing.Color.LightYellow;
				break;

				default:
				BorderColor = System.Drawing.Color.White;
				break;
			}
		}

		private object GetFieldValue(DavidFieldsEnum field) => this.myMsgItem2Fields.Item(field).Value;

		private void SetFieldValue(DavidFieldsEnum field, object value)
		{
			try
			{
				this.myMsgItem2Fields.Item(field).Value = value;
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion private procedures
	}
}