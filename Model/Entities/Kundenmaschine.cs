using System;
using System.Linq;
using System.Collections.Generic;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using Products.Model;
using Products.Model.Services;
using Products.Data.Datasets;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class Kundenmaschine : ILinkedItem
	{

		#region members

		dsMachines.KundenMaschineRow myBase;
		Dictionary<DateTime, Kunde> myOwnerList;
		readonly DateTime noDate = new DateTime(100, 1, 1);

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Kundenmaschine").UID; }
		}

		public string ItemName
		{
			get { return string.Format("{0} [{1}]", this.Maschinenmodell, this.Seriennummer); }
		}

		public string LinkTypBezeichnung
		{
			get { return "Kundenmaschine"; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel (GUID) dieser Kundenmaschine zurück.
		/// </summary>
		public string UID
		{
			get
			{
				return myBase.UID;
			}
		}

		/// <summary>
		/// Gibt die Kundennummer des Kunden zurück, dem diese Kundenmaschine zugeordnet ist oder legt sie fest.
		/// </summary>
		public string Kundennummer
		{
			get
			{
				return this.CurrentOwner.CustomerId;
			}
		}

		/// <summary>
		/// Gibt den Kunden (Eigentümer/Besitzer/Leasingnehmer oder watt) dieser Maschine zurück.
		/// </summary>
		//public Kunde Kunde
		//{
		//  get { return ModelManager.CustomerService.GetKunde(this.myBase.Kundennummer); }
		//}

		/// <summary>
		/// Gibt den Primärschlüssel (GUID) des Maschinenmodells zurück.
		/// </summary>
		public string MaschinenmodellId
		{
			get
			{
				return myBase.MaschinenmodellId;
			}
			set
			{
				myBase.MaschinenmodellId = value;
			}
		}

		/// <summary>
		/// Gibt dieSeriennummer der Kundenmaschine zurück oder legt sie fest.
		/// </summary>
		public String Seriennummer
		{
			get
			{
				return myBase.Seriennummer;
			}
			set
			{
				myBase.Seriennummer = value;
			}
		}

		/// <summary>
		/// Gibt die Version der Maschinen Firmware zurück oder legt sie fest.
		/// </summary>
		public string Firmware
		{
			get
			{
				return myBase.Firmware;
			}
			set
			{
				myBase.Firmware = value;
			}
		}

		/// <summary>
		/// Gibt den Namen der Firma zurück, bei der die Kundenmaschine gekauft wurde oder legt ihn fest.
		/// </summary>
		public string GekauftBei
		{
			get
			{
				return myBase.VerkauftDurch;
			}
			set
			{
				myBase.VerkauftDurch = value;
			}
		}

		/// <summary>
		/// Gibt das Kaufdatum zurück oder legt es fest.
		/// </summary>
		public DateTime? Kaufdatum
		{
			get
			{
				if (myBase.Kaufdatum.Equals(noDate))
				{
					return null;
				}
				return myBase.Kaufdatum;
			}
			set
			{
				value = value.HasValue ? value : noDate;
				myBase.Kaufdatum = value.Value;
			}
		}

		/// <summary>
		/// Gibt die Auftragsnummer für diese Maschine in 
		/// unserer Auftragsverarbeitung (Sage NCL) zurück.
		/// Zumindest, wenn sich einer erbarmt hat, die zu pflegen ...
		/// </summary>
		public string AuftragsnummerSage
		{
			get { return myBase.AuftragsnummerSage; }
			set { myBase.AuftragsnummerSage = value; }
		}

		/// <summary>
		/// Gibt das Kennzeichen zurück, ob es für die Maschine einen Leasing Vertrag gibt.
		/// </summary>
		public bool LeasingFlag
		{
			get
			{
				return (myBase.LeasingFlag == "1");
			}
			set
			{
				myBase.LeasingFlag = (value == true) ? "1" : "0";
			}
		}

		/// <summary>
		/// Gibt das Datum zurück, an dem die 
		/// Finanzierung endet.
		/// </summary>
		public DateTime? Finanzierungsende
		{
			get
			{
				if (myBase.Finanzierungsende.Equals(noDate))
				{
					return null;
				}
				return myBase.Finanzierungsende;
			}
			set
			{
				value = value.HasValue ? value : new DateTime(100, 1, 1);
				myBase.Finanzierungsende = value.Value;
			}
		}

		/// <summary>
		/// Gibt das Kennzeichen zurück, ob für die Maschine ein Mietkauf vereinbart ist.
		/// </summary>
		public bool MietkaufFlag
		{
			get
			{
				return (myBase.MietkaufFlag == "1");
			}
			set
			{
				myBase.MietkaufFlag = (value == true) ? "1" : "0";
			}
		}

		/// <summary>
		/// Gibt das Kennzeichen zurück, ob wir nach Ablauf des
		/// Leasing Vertrags das Recht zur Erstverwertung haben.
		/// </summary>
		public bool ErstverwertungsFlag
		{
			get
			{
				return (myBase.ErstverwertungsFlag == "1");
			}
			set
			{
				myBase.ErstverwertungsFlag = (value == true) ? "1" : "0";
			}
		}

		/// <summary>
		/// Gibt den Namen der Gesellschaft/Firma zurück, 
		/// über die die Maschine finanziert wurde.
		/// </summary>
		public string Finanzierungsgesellschaft
		{
			get { return myBase.Finanzierungsgesellschaft; }
			set { myBase.Finanzierungsgesellschaft = value; }
		}

		/// <summary>
		/// Gibt Anmerkungen zu dieser Maschine zurück oder legt sie fest.
		/// </summary>
		public string Anmerkungen
		{
			get
			{
				return myBase.Anmerkungen;
			}
			set
			{
				myBase.Anmerkungen = value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel der in diese Maschine eingefüllten Tinte zurück.
		/// </summary>
		public string TintenId
		{
			get
			{
				return myBase.TintenId;
			}
			set
			{
				myBase.TintenId = value;
			}
		}

		/// <summary>
		/// Gibt das installierte Farbset dieser Maschine zurück oder legt es fest.
		/// </summary>
		public string Farbset
		{
			get
			{
				return myBase.FarbenSet;
			}
			set
			{
				myBase.FarbenSet = value;
			}
		}

		/// <summary>
		/// Gibt die in dieser Maschine eingefüllte Tinte zurück.
		/// </summary>
		public string Tinte
		{
			get
			{
				var tRow = DataManager.SharedDataService.GetTinte(myBase.TintenId);
				return tRow == null ? string.Empty : tRow.Tintenbezeichnung;
			}
		}

		/// <summary>
		/// Gibt das Maschinenmodell zurück.
		/// </summary>
		public string Maschinenmodell
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenModell(this.myBase.MaschinenmodellId).Modellbezeichnung;
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung des Maschinentyps zurück.
		/// </summary>
		public string Maschinentyp
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenModell(this.myBase.MaschinenmodellId).Maschinentyp;
			}
		}

		/// <summary>
		/// Gibt den Namen der Herstellerfirma zurück.
		/// </summary>
		public string Hersteller
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenModell(this.myBase.MaschinenmodellId).Herstellername;
			}
		}

		/// <summary>
		/// Gibt das Wartungsintervall für diese Maschine in Monaten zurück.
		/// </summary>
		public int Wartungsintervall
		{
			get
			{
				return myBase.Wartungsintervall;
			}
			set
			{
				myBase.Wartungsintervall = value;
			}
		}

		/// <summary>
		/// Gibt die Liste aller bisherigen und des derzeitigen Eigentümers der Maschine zurück.
		/// </summary>
		public Dictionary<DateTime, Kunde> OwnerList
		{
			get { return this.myOwnerList; }
		}

		/// <summary>
		/// Gibt den derzeitigen Eigentümer der Maschine zurück.
		/// </summary>
		public Kunde CurrentOwner
		{
			get
			{
				foreach (var item in this.OwnerList)
				{
					if (item.Key >= DateTime.Today) return item.Value;
				}
				return null;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Klasse Kundenmaschine.
		/// </summary>
		/// <param name="baseRow"></param>
		public Kundenmaschine(dsMachines.KundenMaschineRow baseRow, Dictionary<DateTime, Kunde> ownerList)
		{
			this.myBase = baseRow;
			this.myOwnerList = ownerList;
			//ModelManager.NotesService.NoteCreated += new EventHandler<NotesService.NoteCreatedEventArgs>(NotesService_NoteCreated);
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt einen neuen Dateilink zu dieser Kundenmaschine hinzu.
		/// </summary>
		/// <param name="pathAndName">Pfad und Dateiname der hinzuzufügenden Datei.</param>
		/// <param name="deleteSourceFile">Soll die Originaldatei gelöscht werden?</param>
		public void AddFileLink(string pathAndName, bool deleteSourceFile)
		{
			ModelManager.FileLinkService.AddFileLink(new System.IO.FileInfo(pathAndName), this, Global.LinkedFilesPath, deleteSourceFile);
		}

		/// <summary>
		/// Löscht die angegebene Dateiverknüpfung.
		/// </summary>
		/// <param name="fileLink"></param>
		/// <param name="deleteFile"></param>
		public void RemoveFileLink(FileLink fileLink, bool deleteFile)
		{
			ModelManager.FileLinkService.DeleteFileLink(new System.IO.FileInfo(fileLink.FullName), this, deleteFile);
		}

		/// <summary>
		/// True, wenn weder Notizen noch Software mit dieser Maschine verknüpft sind.
		/// </summary>
		/// <returns></returns>
		public bool CanDelete()
		{
			var thisAsLink = this as ILinkedItem;
			var notes = ModelManager.NotesService.GetNotesList(thisAsLink.Key, thisAsLink.LinkTypeId);
			var software = ModelManager.SoftwareService.GetMachinesSoftware(this);
			return (notes.Count == 0 && software.Count == 0);
		}

		public void Update()
		{
			ModelManager.FileLinkService.Update();
			ModelManager.SoftwareService.UpdateKundenSoftware();
			ModelManager.NotesService.UpdateNotes();
		}

		#endregion

		#region private procedures

		#endregion

	}
}
