using System;
using System.Linq;
using Products.Common;
using Products.Data;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Servicetermin : ILinkedItem
	{

		#region members

		dsSage.ServiceterminRow myBase = null;
		Appointment davidTermin = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		string ILinkedItem.Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		string ILinkedItem.LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Servicetermin").UID; }
		}

		string ILinkedItem.ItemName
		{
			get { return this.TerminSubject; }
		}

		string ILinkedItem.LinkTypBezeichnung
		{
			get { return "Servicetermin"; }
		}

		#endregion

		/// <summary>
		/// Gibt den GUID des Servicetermins zurück.
		/// </summary>
		public string UID
		{
			get { return myBase.UID; }
		}

		/// <summary>
		/// Gibt die Kundennummer des Kunden zurück, bei dem der Termin stattfindet bzw. stattgefunden hat.
		/// </summary>
		public string Kundennummer
		{
			get { return myBase.Kundennummer; }
			private set { myBase.Kundennummer = value; }
		}

		/// <summary>
		/// Gibt den GUID des Datensatzes für die Kundenmaschine zurück.
		/// </summary>
		public string KundenmaschineID
		{
			get{ return myBase.KundenmaschineID; }
			private set { myBase.KundenmaschineID = value; }
		}

		/// <summary>
		/// Gibt den GUID des Benutzers zurück, der den Servicetermin wahrnimmt bzw. wahrgenommen hat.
		/// </summary>
		public string TechnikerID
		{
			get { return myBase.TechnikerID; }
			private set { myBase.TechnikerID = value; }
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit des Termins zurück.
		/// </summary>
		public DateTime? Termin
		{
			get
			{
				if (DavidTermin != null)
				{
					return DavidTermin.StartDate;
				}
				return null;
			}
			set
			{
				DavidTermin.StartDate = value.Value;
			}
		}

		/// <summary>
		/// Gibt den Datumsanteil des Terminbeginns zurück.
		/// </summary>
		public DateTime? Startdatum
		{
			get
			{
				if (DavidTermin != null)
				{
					return DavidTermin.StartDate;
				}
				return null;
			}
			set { DavidTermin.StartDate = value.Value; }
		}

		/// <summary>
		/// Gibt den Datumsanteil des Terminendes zurück.
		/// </summary>
		public DateTime? Enddatum
		{
			get 
			{
				if (DavidTermin != null)
				{
					return DavidTermin.EndDate;
				}
				return null;
			}
			set { DavidTermin.EndDate = value.Value; }
		}

		/// <summary>
		/// Gibt den vollständigen Pfad und Dateinamen der diesen Termin repräsentierenden
		/// Datei im David Dateisystem zurück.
		/// </summary>
		public string Kalendereintrag
		{
			get { return myBase.Kalendereintrag; }
			set { myBase.Kalendereintrag = value; }
		}

		/// <summary>
		/// Das Subject dieses Termins.
		/// </summary>
		public string TerminSubject
		{
			get
			{
				if (DavidTermin != null)
				{
					return DavidTermin.Title;
				}
				return string.Empty;
			}
			set { DavidTermin.Title = value; }
		}

		/// <summary>
		/// Der Bodytext für diesen Termin.
		/// </summary>
		public string TerminBody
		{
			get
			{
				if (DavidTermin != null)
				{
					return DavidTermin.BodyAscii;
				}
				return string.Empty;
			}
			set { DavidTermin.BodyAscii = value; }
		}

		/// <summary>
		/// Gibt den Body des Termins im HTML Format zurück oder legt ihn fest.
		/// </summary>
		public string TerminHtmlBody
		{
			get
			{
				if (DavidTermin != null)
				{
					return DavidTermin.BodyHtml;
				}
				return string.Empty;
			}
			set
			{
				DavidTermin.BodyHtml = value;
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung für das Maschinenmodell zurück.
		/// </summary>
		public string Maschinenmodell
		{
			get { return Maschine.Maschinenmodell; }
		}

		/// <summary>
		/// Gibt den Namen des Technikers für diesen Termin zurück.
		/// </summary>
		public string Technikername
		{
			get { return Techniker.NameFull; }
		}

		public DateTime ErstelltAm
		{
			get { return myBase.ErstelltAm; }
			set { myBase.ErstelltAm = value; }
		}

		public string ErstelltVonID
		{
			get{ return myBase.ErstelltVon; }
			private set { myBase.ErstelltVon = value; }
		}

		public string ErstellerName
		{
			get { return Ersteller.NameFull; }
		}

		public DateTime GeaendertAm
		{
			get { return myBase.AktualisiertAm; }
			set { myBase.AktualisiertAm = value; }
		}

		public string GeaendertVonID
		{
			get { return myBase.AktualisiertVon; }
			set { myBase.AktualisiertVon = value; }
		}

		//MACHEN: Löschen ...!
		//public Guid AktualisiertVonId
		//{
		//  get { return Guid.Parse(myBase.AktualisiertVon); }
		//  private set { myBase.AktualisiertVon = value.ToString(); }
		//}

		#region entities

		/// <summary>
		/// Gibt die Kundeninstanz des Kunden zurück, bei dem der Serviceeinsatz stattfindet oder stattfand.
		/// </summary>
		public Kunde Kunde
		{
			get { return ModelManager.CustomerService.GetKunde(myBase.Kundennummer); }
		}

		/// <summary>
		/// Gibt einen Verweis auf die Maschine zurück, für die der Servicetermin gilt.
		/// </summary>
		public Kundenmaschine Maschine
		{
			get { return ModelManager.MachineService.GetKundenMaschine(this.Kunde, this.myBase.KundenmaschineID); }
		}

		/// <summary>
		/// Gibt ein <seealso cref="DvApi32.CalendarItem"/> zurück, dass den verknüpften Kalendereintrag 
		/// dieses Termins in David repräsentiert.
		/// </summary>
		public DvApi32.CalendarItem DavidKalendereintrag
		{
			get
			{
				try
				{
					if (!string.IsNullOrEmpty(myBase.Kalendereintrag) && System.IO.File.Exists(myBase.Kalendereintrag))
					{
						return David.DavidManager.DavidService.GetCalendarItem(myBase.Kalendereintrag);
					}
					else
					{
						myBase.Kalendereintrag = string.Empty;
						return null;
					}
				}
				catch (System.IO.FileNotFoundException)
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Gibt den David Termin für diesen Serviceeinsatz zurück.
		/// </summary>
		public Appointment DavidTermin
		{
			get
			{
				if (davidTermin != null)
				{
					return davidTermin;
				}
				if (!string.IsNullOrEmpty(myBase.Kalendereintrag))
				{
					try
					{
						//davidTermin = new Termin(David.DavidManager.DavidService.GetMessageItem2(myBase.Kalendereintrag), myBase.Kalendereintrag);
						davidTermin = ModelManager.AppointmentService.GetAppointmentList(this.Techniker).FirstOrDefault(a => a.FullName == this.myBase.Kalendereintrag);
						//davidTermin = new Termin(David.DavidManager.DavidService.GetMessageItem2(myBase.Kalendereintrag));
						return davidTermin;
					}
					catch (System.IO.FileNotFoundException)
					{
						return null;
					}
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt eine Liste der mit diesem Servicetermin verknüpften Dokumente zurück. Diese Eigenschaft ist schreibgeschützt.
		/// </summary>
		public SortableBindingList<FileLink> Dateilinks
		{
			get { return ModelManager.FileLinkService.GetFileLinkList(this.UID); } }

		/// <summary>
		/// Gibt die Benutzerinstanz zurück, die den Servicetechniker repräsentiert oder legt sie fest.
		/// </summary>
		public User Techniker
		{
			get
			{
				return ModelManager.UserService.GetUser(myBase.TechnikerID, Services.UserService.UserSearchParamType.PrimaryKey);
			}
			set
			{
				myBase.TechnikerID = value.UID;
			}
		}

		/// <summary>
		/// Gibt die Benutzerinstanz zurück, die den Ersteller des Eintrags repräsentiert.
		/// </summary>
		public User Ersteller
		{
			get
			{
				return ModelManager.UserService.GetUser(myBase.ErstelltVon, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt die Benutzerinstanz des Mitarbeiters zurück, der diesen Eintrag zuletzt bearbeitet hat.
		/// </summary>
		public User LetzterBearbeiter
		{
			get
			{
				return ModelManager.UserService.GetUser(myBase.AktualisiertVon, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Servicetermin Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Servicetermin(dsSage.ServiceterminRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Erstellt einen neuen David Kalendereintrag.
		/// </summary>
		public void CreateDavidKalendereintrag(DateTime beginn, DateTime ende)
		{
			Kalendereintrag = David.DavidManager.DavidService.CreateServicetermin
				(beginn,
				 ende,
				 Techniker.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender),
				 string.Format("{0}: Servicetermin, {1} ({2})", Kunde.CompanyName1, Maschine.Maschinenmodell, Maschine.Seriennummer),
				 string.Format("{0}, {1} {2}", Kunde.Street, Kunde.ZipCode, Kunde.City));
		}

		/// <summary>
		/// Erzeugt eine neue Dateiverknüpfung für diesen Termin.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="deleteOriginal"></param>
		public void AddFileLink(string fileName, bool deleteSourceFile = false)
		{
			FileLink newFileLink = ModelManager.FileLinkService.AddFileLink(new System.IO.FileInfo(fileName), this, Global.LinkedFilesPath, deleteSourceFile);
		}

		/// <summary>
		/// Löscht den angegebenen Dateilink.
		/// </summary>
		/// <param name="linkedFile"></param>
		public void DeleteDateilink(FileLink linkedFile)
		{
			ModelManager.FileLinkService.DeleteFileLink(new System.IO.FileInfo(linkedFile.FullName), this, true);
		}

		/// <summary>
		/// Speichert die geänderten Einstellungen für diesen Termin.
		/// </summary>
		public void Update()
		{
			ModelManager.FileLinkService.Update();
			ModelManager.ModelService.UpdateCalendarItem(DavidKalendereintrag, Kalendereintrag);
			ModelManager.ModelService.UpdateServicetermine();
		}

		#endregion

	}
}
