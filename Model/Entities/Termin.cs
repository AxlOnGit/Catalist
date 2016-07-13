using System;
using System.Text;
using David;
using Products.Common;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Termin : Calendar.Appointment, ILinkedItem
	{

		#region members

		private DvApi32.MessageItem2 myMsgItm2Base = null;
		private DvApi32.Fields myMsgItm2BaseFields = null;

		private bool myIsDirty = false;
		private string myCreatedBy = string.Empty;
		//private Model.Entities.User myCreateUser = null;
		//private Model.Entities.User myOwner = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.FullName; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Termin").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return string.Format("{0} [{1}]", myMsgItm2Base.Subject, this.Owner.UserName); }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Termin"; }
		}

		#endregion

		#region base properties

		/// <summary>
		/// True, wenn dieser Termin ein ganztägiges Ereignis ist.
		/// </summary>
		/// <remarks>MessageItem2 Index = 79.</remarks>
		public new bool AllDayEvent
		{
			get { return (bool)myMsgItm2BaseFields.Item(DavidFieldEnum.AllDayEvent).Value; }
			set 
			{
				bool baseValue = (bool)myMsgItm2BaseFields.Item(DavidFieldEnum.AllDayEvent).Value;
				if (value != baseValue)
				{
					base.AllDayEvent = value;
					myMsgItm2BaseFields.Item(DavidFieldEnum.AllDayEvent).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit des Terminendes zurück oder legt es fest.
		/// </summary>
		/// <remarks>MessageItem2 Index = 51.</remarks>
		public new DateTime EndDate
		{
			get
			{
				return base.EndDate;
			}
			set
			{
				if (value != (DateTime)myMsgItm2BaseFields.Item(DavidFieldEnum.EndsAt).Value)
				{
					base.EndDate = value;
					myMsgItm2BaseFields.Item(DavidFieldEnum.EndsAt).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Anfangsdatum und -zeit des Termins.
		/// </summary>
		/// <remarks>MessageItem2 Index = 8.</remarks>
		public new DateTime StartDate
		{
			get
			{
				return base.StartDate;
				//return (DateTime)myBaseFields.Item(8).Value;
			}
			set
			{
				if (value != (DateTime)myMsgItm2BaseFields.Item(DavidFieldEnum.StartsAt).Value)
				{
					myMsgItm2BaseFields.Item(DavidFieldEnum.StartsAt).Value = value;
					base.StartDate = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt den Titel des Termins zurück oder legt ihn fest.
		/// </summary>
		public new string Title
		{
			get
			{
				return this.myMsgItm2Base.Subject;
			}
			set
			{
				if (value != myMsgItm2Base.Subject)
				{
					myMsgItm2Base.Subject = value;
					base.Title = value;
					SetDirty(true);
				}
			}
		}

		#endregion

		#region termin properties

		/// <summary>
		/// Gibt den eindeutigen Schlüssel für diesen Termin zurück.
		/// </summary>
		public Guid TerminUID
		{
			get
			{
				if (myMsgItm2BaseFields.UserFields.Item("GUID") == null)
				{
					Guid uid = SequentialGuid.NewSequentialGuid();
					DvApi32.FieldDefinition def = myMsgItm2BaseFields.UserFields.CreateDefinition("GUID", DvApi32.DvFieldType.DvFieldText);
					myMsgItm2BaseFields.UserFields.Add(def, uid);
					myMsgItm2Base.Save();
					ModelManager.ModelService.SetXrefUID(myMsgItm2Base);
					return uid;
				}
				return Guid.Parse((string)myMsgItm2BaseFields.UserFields.Item("GUID").Value);
			}
		}

		/// <summary>
		/// Gibt den Termintext im HTML Format zurück oder legt ihn fest.
		/// </summary>
		/// <remarks>MessageItem2 Index = 104.</remarks>
		public string HTML
		{
			get { return (string)myMsgItm2BaseFields.Item(DavidFieldEnum.BodyHtml).Value; }
			set
			{
				if (!value.Equals(myMsgItm2BaseFields.Item(104).Value))
				{
					myMsgItm2BaseFields.Item(DavidFieldEnum.BodyHtml).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt den Text im Body des Kalendereintrags zurück oder legt ihn fest.
		/// </summary>
		/// <remarks>MessageItem2 Index = 132.</remarks>
		public string Content
		{
			get
			{
				return (string)myMsgItm2BaseFields.Item(DavidFieldEnum.BodyAscii).Value;
			}
			set
			{
				if (!value.Equals(myMsgItm2BaseFields.Item(DavidFieldEnum.BodyAscii).Value))
				{
					myMsgItm2BaseFields.Item(132).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt die Id des Erfassers des David-Kalendereintrags zurück.
		/// <remarks>
		/// Im MessageItem2 lautet der Bezeichner für diese Eigenschaft 'Creator'.
		/// Der MessageItem2 Index ist 53.
		/// 
		/// Dieser int ergibt nach Umwandlung in einen Hexadezimalen Wert den Namen des Dateiordners
		/// dieses Benutzers auf dem David Server zurück.
		/// Für mich ergibt sich z. B. aus 268681232 => 1003C010
		/// </remarks>
		/// </summary>
		public int CreatorId
		{
			get
			{
				return (int)myMsgItm2BaseFields.Item(DavidFieldEnum.CreatedBy).Value;
			}
		}

		/// <summary>
		/// Gibt das User Objekt zurück, das diesen Termin erstellt hat.
		/// </summary>
		public User Creator
		{
			get
			{
				int creatorId = (this.CreatorId == 268615680) ? 268681232 : this.CreatorId;
				return ModelManager.UserService.GetUser(creatorId.ToString("X"), Services.UserService.UserSearchParamType.DavidUserFolder);
			}
		}

		/// <summary>
		/// Gibt den Namen des Mitarbeiters zurück, der den Termin erstellt hat.
		/// </summary>
		/// <remarks>Diese Eigenschaft ist schreibgeschützt.</remarks>
		public string CreatorName
		{
			get
			{
				if (this.Creator != null)
				{
					return this.Creator.NameFull;
				}
				return "Unbekannt";
			}
		}

		/// <summary>
		/// Gibt die Id des Besitzers des David-Kalendereintrags zurück.
		/// <remarks>
		/// Im MessageItem2 lautet der Bezeichner 'Owner'.
		/// Der MessageItem2 Index = 4.
		/// 
		/// Dieser Integer ergibt umgewandelt nach Hex den Namen des Dateiordners
		/// dieses Benutzers auf dem David Server zurück.
		/// Für mich ergibt sich z. B. aus 268681232 => 1003C010
		/// </remarks>
		/// </summary>
		public int OwnerId
		{
			get { return (int)this.myMsgItm2BaseFields.Item(DavidFieldEnum.Owner).Value; }
		}

		/// <summary>
		/// Gibt den User zurück, in dessen Kalender dieser Kalendereintrag gespeichert ist.
		/// </summary>
		public User Owner
		{
			get
			{
				return ModelManager.UserService.GetUser(this.FullName, Services.UserService.UserSearchParamType.DavidFileName);
			}
		}

		/// <summary>
		/// Gibt den Namen des Mitarbeiters zurück, dem dieser Termin derzeit zugeordnet ist.
		/// </summary>
		public string OwnerName
		{
			get
			{
				if (this.Owner != null)
				{
					return this.Owner.NameFull;
				}
				return "Unbekannt";
			}
		}

		/// <summary>
		/// True, wenn der Termin geändert wurde.
		/// </summary>
		public bool Dirty { get { return myIsDirty; } }

		/// <summary>
		/// Gibt die Zeit in Minuten zurück, die vor dem Termin erinnert werden soll oder legt sie fest.
		/// </summary>
		public int RemindAt
		{
			get
			{
				return (int)myMsgItm2BaseFields.Item(DavidFieldEnum.RemindAt).Value;
			}
			set
			{
				if (!value.Equals(myMsgItm2BaseFields.Item(DavidFieldEnum.RemindAt).Value))
				{
					myMsgItm2BaseFields.Item(DavidFieldEnum.RemindAt).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt Pfad und Dateinamen des Kalendereintrags auf dem David Server zurück.
		/// </summary>
		public string FullName 
		{
			get
			{
				string fName = (string)myMsgItm2BaseFields.Item(DavidFieldEnum.FileName).Value;
				return fName.EndsWith(".001") ? fName : string.Format("{0}.001", fName);
			} 
		}

		/// <summary>
		/// Gibt das Datum der letzten Änderung zurück. Diese Eigenschaft ist schreibgeschützt.
		/// </summary>
		/// <remarks>MessageItem2 Index = 38.</remarks>
		public DateTime ChangedAt
		{
			get
			{
				return (DateTime)myMsgItm2BaseFields.Item(David.DavidFieldEnum.ChangedAt).Value;
			}
		}

		/// <summary>
		/// Gibt den Ort des Termins zurück oder legt ihn fest.
		/// </summary>
		public string Location 
		{
			get 
			{
				return (string)myMsgItm2BaseFields.Item(DavidFieldEnum.Location).Value;
			} 
			set 
			{
				if (!value.Equals(myMsgItm2BaseFields.Item(DavidFieldEnum.Location).Value))
				{
					myMsgItm2BaseFields.Item(DavidFieldEnum.Location).Value = value;
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Typ des Termins: Beschäftigt, Frei, Außer Haus, Vorläufig
		/// </summary>
		/// <remarks>MessageItem2 Index = 83.</remarks>
		public DvApi32.DvShowAsType ShowAs
		{
			get 
			{
				return (DvApi32.DvShowAsType)myMsgItm2BaseFields.Item(DavidFieldEnum.ShowAs).Value;
			}
			set 
			{
				int baseValue = (int)myMsgItm2BaseFields.Item(DavidFieldEnum.ShowAs).Value;
				if ((int)value != baseValue)
				{
					myMsgItm2BaseFields.Item(DavidFieldEnum.ShowAs).Value = value;
					SetBorderColor();
					SetDirty(true);
				}
			}
		}

		/// <summary>
		/// Gibt eine Zusammenfassung des aktuell ausgewählten Termins zurück.
		/// </summary>
		public string AppointmentInfo
		{
			get
			{
				return string.Format("{0}{5}{1}{5}{2} - {3} Uhr{5}{5}{4}",
					this.Owner.NameFirst.ToUpper(),					//0 Name
					this.StartDate.ToString("dd.MM.yyyy"),	//1 Datum
					this.StartDate.ToString("HH.mm"),				//2 Uhrzeit Start
					this.EndDate.ToString("HH.mm"),					//3 Uhrzeit Ende
					this.Title,															//4 Titel
					Environment.NewLine);										//5 Neue Zeile
			}
		}

		public string AppointmentInfoHtml
		{
			get
			{
				return string.Format("<p><strong>{0} am {1}</strong></p>{2}",
					this.Owner.NameFirst.ToUpper(),
					this.StartDate.ToString("dd.MM.yyyy ab HH.mm"),
					this.Title);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Termin Klasse.
		/// </summary>
		/// <param name="baseItem">Eine David CalendarItem Instanz.</param>
		public Termin(DvApi32.MessageItem2 baseItem) : base()
		{
			myMsgItm2Base = baseItem;
			myMsgItm2BaseFields = (DvApi32.Fields)baseItem.Fields;
			//myUser = user;
			InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Speichert den Termin im David Kalenderordner des Benutzers.
		/// </summary>
		public void Update()
		{
			if (myIsDirty)
			{
				myMsgItm2Base.Save();
			}
		}

		#endregion

		#region event handler
		#endregion

		#region private procedures

		private void InitializeData()
		{
			base.AllDayEvent = (bool)myMsgItm2BaseFields.Item(79).Value;
			SetBorderColor();
			this.Color = this.Owner.AppointmentColor;
			this.DrawBorder = true;
			base.EndDate = (DateTime)myMsgItm2BaseFields.Item(51).Value;
			this.Group = string.Empty;
			this.Layer = 0;
			this.Locked = false;
			base.StartDate = (DateTime)myMsgItm2BaseFields.Item(8).Value;
			base.TextColor = System.Drawing.Color.FromArgb(32, 32, 32);
			base.Title = this.Title;
			}

		private void SetBorderColor()
		{
			switch (ShowAs)
			{
				case DvApi32.DvShowAsType.DvShowAsBusy:
					base.BorderColor = System.Drawing.Color.DarkBlue;
					break;
				case DvApi32.DvShowAsType.DvShowAsFree:
					base.BorderColor = System.Drawing.Color.LightGreen;
					break;
				case DvApi32.DvShowAsType.DvShowAsOutOfOffice:
					base.BorderColor = System.Drawing.Color.DarkRed;
					break;
				case DvApi32.DvShowAsType.DvShowAsTentative:
					base.BorderColor = System.Drawing.Color.LightYellow;
					break;
				default:
					base.BorderColor = System.Drawing.Color.White;
					break;
			}

		}

		private void SetDirty(bool dirtyValue)
		{
			myIsDirty = dirtyValue;
		}

		#endregion

		/// <summary>
		/// Gibt die Felder und Feldinhalte der zugrundeliegenden MessageItem2 Instanz zurück.
		/// </summary>
		public string Termindetails 
		{ 
			get 
			{
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < 149; i++)
				{
					DvApi32.Field field = this.myMsgItm2BaseFields.Item(i);
					sb.AppendLine(string.Format("Feld {0}:\t{1}\t=> {2} ({3})", i, field.Name, field.Value.ToString(), field.GetType().ToString()));
				}
				return sb.ToString();
			} 
		}

	}
}
