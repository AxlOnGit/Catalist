using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Services;

namespace Products.Model.Entities
{
	public class Kundenmaschine : ILinkedItem
	{
		#region members

		dsMachines.KundenMaschineRow myBase;
		Dictionary<DateTime, Kunde> myOwnerList;
		readonly DateTime noDate = new DateTime(100, 1, 1);
		readonly string nl = Environment.NewLine;

		#endregion members

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

		#endregion ### .ctor ###

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
			get { return string.Format("{0} [{1}]", this.Modellbezeichnung, this.Seriennummer); }
		}

		public string LinkTypBezeichnung
		{
			get { return "Kundenmaschine"; }
		}

		#endregion ILinkedItem

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
		/// Gibt die Kundennummer des Kunden zurück, dem diese Kundenmaschine zugeordnet ist oder
		/// legt sie fest.
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
		public Kunde Kunde
		{
			get { return ModelManager.CustomerService.GetKunde(this.myBase.Kundennummer, false); }
		}

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
				if (!this.myBase.MaschinenmodellId.Equals(value, StringComparison.CurrentCultureIgnoreCase))
				{
					var serieOriginal = this.Maschinenserie;
					this.myBase.MaschinenmodellId = value;

					// Wenn das neu zugewiesene Modell zu einer anderen Serie gehört, wird das
					// Wartungsintervall der neuen Serie bei dieser Maschine eingetragen.
					var serieNeu = this.Maschinenserie;
					if (!serieOriginal.Equals(serieNeu))
					{
						this.Wartungsintervall = serieNeu.Wartungsintervall;
					}
				}
			}
		}

		/// <summary>
		/// Gibt dieSeriennummer der Kundenmaschine zurück oder legt sie fest.
		/// </summary>
		public string Seriennummer
		{
			get
			{
				if (this.myBase.IsSeriennummerNull()) return string.Empty;

				var sn = this.myBase.Seriennummer;
				if (sn.Contains(nl)) this.myBase.Seriennummer = sn.Replace(sn, string.Empty);
				return myBase.Seriennummer;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetSeriennummerNull();
					return;
				}
				if (!this.myBase.IsSeriennummerNull() || !value.Equals(this.myBase.Seriennummer, StringComparison.CurrentCulture))
					this.myBase.Seriennummer = value.Replace(nl, string.Empty);
			}
		}

		/// <summary>
		/// Gibt die Version der Maschinen Firmware zurück oder legt sie fest.
		/// </summary>
		public string Firmware
		{
			get
			{
				if (this.myBase.IsFirmwareNull()) return string.Empty;
				return myBase.Firmware;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetFirmwareNull();
					return;
				}
				if (this.myBase.IsFirmwareNull() || !value.Equals(this.myBase.Firmware, StringComparison.CurrentCulture))
					this.myBase.Firmware = value.Replace(nl, string.Empty);
			}
		}

		/// <summary>
		/// Gibt den Namen der Firma zurück, bei der die Kundenmaschine gekauft wurde oder legt ihn fest.
		/// </summary>
		public string Haendler
		{
			get
			{
				if (this.myBase.IsHaendlerNull()) return string.Empty;
				return myBase.Haendler;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetHaendlerNull();
					return;
				}
				if (this.myBase.IsHaendlerNull() || !value.Equals(this.myBase.Haendler, StringComparison.CurrentCulture))
					this.myBase.Haendler = value;
			}
		}

		/// <summary>
		/// Gibt das Auftragsdatum in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Auftragsdatum
		{
			get
			{
				if (this.myBase.IsAuftragsdatumNull())
				{
					return null;
				}
				return this.myBase.Auftragsdatum;
			}
			set
			{
				if (!value.HasValue)
				{
					this.myBase.SetAuftragsdatumNull();
					return;
				}
				if (this.myBase.IsAuftragsdatumNull() || !value.Equals(this.myBase.Auftragsdatum))
					this.myBase.Auftragsdatum = value.Value;
			}
		}

		/// <summary>
		/// Gibt das Rechnungsdatum in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Rechnungsdatum
		{
			get
			{
				if (this.myBase.IsRechnungsdatumNull())
				{
					return null;
				}
				return this.myBase.Rechnungsdatum;
			}
			set
			{
				if (!value.HasValue)
				{
					this.myBase.SetAuftragsdatumNull();
					return;
				}
				if (this.myBase.IsRechnungsdatumNull() || !value.Equals(this.myBase.Rechnungsdatum))
					this.myBase.Rechnungsdatum = value.Value;
			}
		}

		/// <summary>
		/// Gibt das Kauf- bzw. Lieferdatum in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Lieferdatum
		{
			get
			{
				if (myBase.IsLieferdatumNull() || myBase.Lieferdatum.Equals(noDate))
				{
					return null;
				}
				return myBase.Lieferdatum;
			}
			set
			{
				if (!value.HasValue)
				{
					this.myBase.SetLieferdatumNull();
				}
				else
				{
					if (this.myBase.IsLieferdatumNull() || !value.Equals(this.myBase.Lieferdatum))
						this.myBase.Lieferdatum = value.Value;
				}
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Users zurück, der diese Maschine installiert hat oder legt
		/// ihn fest.
		/// </summary>
		public string InstallationDurchId
		{
			get
			{
				if (this.myBase.IsInstallationDurchIdNull()) return string.Empty;
				return this.myBase.InstallationDurchId;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetInstallationDurchIdNull();
					return;
				}
				if (this.myBase.IsInstallationDurchIdNull() || !value.Equals(this.myBase.InstallationDurchId, StringComparison.CurrentCulture))
					this.myBase.InstallationDurchId = value;
			}
		}

		public DateTime? Installationsdatum
		{
			get
			{
				if (myBase.IsInstallationsdatumNull())
				{
					return null;
				}
				return myBase.Installationsdatum;
			}
			set
			{
				if (!value.HasValue)
				{
					this.myBase.SetInstallationsdatumNull();
				}
				else
				{
					if (this.myBase.IsInstallationsdatumNull() || !value.Equals(this.myBase.Installationsdatum))
						this.myBase.Installationsdatum = value.Value;
				}
			}
		}

		/// <summary>
		/// Gibt die Auftragsnummer für diese Maschine in unserer Auftragsverarbeitung (Sage NCL)
		/// zurück. Zumindest, wenn sich einer erbarmt hat, die zu pflegen ...
		/// </summary>
		public string AuftragsnummerSage
		{
			get
			{
				if (this.myBase.IsAuftragsnummerSageNull()) return string.Empty;
				return myBase.AuftragsnummerSage;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetAuftragsnummerSageNull();
					return;
				}
				if (this.myBase.IsAuftragsnummerSageNull() || !value.Equals(this.myBase.AuftragsnummerSage, StringComparison.CurrentCulture))
					this.myBase.AuftragsnummerSage = value;
			}
		}

		/// <summary>
		/// Gibt die Rechnungs- oder Lieferscheinnummer in Sage zurück oder legt sie fest.
		/// </summary>
		public string RechnungsnummerSage
		{
			get
			{
				if (this.myBase.IsRechnungsnummerSageNull()) return string.Empty;
				return this.myBase.RechnungsnummerSage;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetRechnungsnummerSageNull();
					return;
				}
				if (this.myBase.IsRechnungsdatumNull() || !value.Equals(this.myBase.RechnungsnummerSage, StringComparison.CurrentCulture))
				{
					if (!value.StartsWith("d-", StringComparison.CurrentCultureIgnoreCase)
						& !value.StartsWith("r-", StringComparison.CurrentCultureIgnoreCase))
						value = $"D-{value}";
					this.myBase.RechnungsnummerSage = (value.Length > 13 ? value.Substring(0, 13) : value.PadRight(11, '?'));
				}
			}
		}

		public string LieferscheinnummerSage
		{
			get
			{
				return this.myBase.IsLieferscheinnummerSageNull() ? string.Empty : this.myBase.LieferscheinnummerSage;
			}
			set
			{
				if (this.myBase.IsLieferscheinnummerSageNull() || !value.Equals(this.LieferscheinnummerSage, StringComparison.CurrentCulture))
					this.myBase.LieferscheinnummerSage = (value.Length > 11 ? value.Substring(0, 11) : value.PadRight(11, '?'));
			}
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
		/// Gibt das Datum zurück, an dem die Finanzierung endet.
		/// </summary>
		public DateTime? Finanzierungsende
		{
			get
			{
				if (this.myBase.IsFinanzierungsendeNull()) return null;
				return this.myBase.Finanzierungsende;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetFinanzierungsendeNull();
					return;
				}
				if (this.myBase.IsFinanzierungsendeNull() || !value.Equals(this.myBase.Finanzierungsende))
					this.myBase.Finanzierungsende = value.Value;
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
		/// Gibt das Kennzeichen zurück, ob wir nach Ablauf des Leasing Vertrags das Recht zur
		/// Erstverwertung haben.
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
		/// Gibt den Namen der Gesellschaft/Firma zurück, über die die Maschine finanziert wurde.
		/// </summary>
		public string Finanzierungsgesellschaft
		{
			get
			{
				if (this.myBase.IsFinanzierungsgesellschaftNull()) return string.Empty;
				return myBase.Finanzierungsgesellschaft;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetFinanzierungsgesellschaftNull();
					return;
				}
				if (this.myBase.IsFinanzierungsgesellschaftNull() || !value.Equals(this.myBase.Finanzierungsgesellschaft, StringComparison.CurrentCulture))
					this.myBase.Finanzierungsgesellschaft = value;
			}
		}

		/// <summary>
		/// Gibt Anmerkungen zu dieser Maschine zurück oder legt sie fest.
		/// </summary>
		public string Anmerkungen
		{
			get
			{
				if (this.myBase.IsAnmerkungenNull()) return string.Empty;
				return myBase.Anmerkungen;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetAnmerkungenNull();
					return;
				}
				if (this.myBase.IsAnmerkungenNull() || !value.Equals(this.myBase.Anmerkungen, StringComparison.CurrentCulture))
					this.myBase.Anmerkungen = value;
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
				if (!this.myBase.TintenId.Equals(value, StringComparison.CurrentCultureIgnoreCase))
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
				if (this.myBase.IsFarbenSetNull()) return string.Empty;
				return this.myBase.FarbenSet;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetFarbenSetNull();
					return;
				}
				if (this.myBase.IsFarbenSetNull() || !value.Equals(this.myBase.FarbenSet, StringComparison.CurrentCulture))
					this.myBase.FarbenSet = value;
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
		/// Gibt das <seealso cref="Maschinenmodell"/> dieser Maschine zurück.
		/// </summary>
		public Maschinenmodell Maschinenmodell
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenModell(this.myBase.MaschinenmodellId);
			}
		}

		/// <summary>
		/// Gibt die Modellbezeichnung dieser Maschine zurück.
		/// </summary>
		public string Modellbezeichnung
		{
			get { return this.Maschinenmodell.Modellbezeichnung; }
		}

		/// <summary>
		/// Gibt die <seealso cref="Maschinenserie"/> dieser Maschine zurück.
		/// </summary>
		public Maschinenserie Maschinenserie
		{
			get
			{
				return ModelManager.SharedItemsService.GetModellSerie(this.Maschinenmodell.ModellSerieId);
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
		public string Herstellername
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenModell(this.myBase.MaschinenmodellId).Herstellername;
			}
		}

		/// <summary>
		/// Gibt True zurück, wenn diese Maschine zu einer Serie gehört, die herkömmlicher Weise
		/// gewartet wird.
		/// </summary>
		/// <remarks>
		/// Dieses Kennzeichen sagt nichts darüber aus, ob diese Maschine tatsächlich regelmäßig
		/// gewartet wird. Das ergibt sich vielmehr aus dem Wartungsintervall. Ist dies &gt; 0, wird
		/// die Maschine gewartet, und zwar alle "Wartungsintervall" Monate.
		/// </remarks>
		public bool Wartungskennzeichen { get { return this.Maschinenserie.Wartungskennzeichen; } }

		/// <summary>
		/// Gibt das Wartungsintervall für diese Maschine in Monaten zurück. Ist dies auf einen Wert
		/// &gt; 0 festgelegt, findet für diese Maschine eine periodische Wartung statt, zumindest
		/// theoretisch ... :-|.
		/// </summary>
		public int Wartungsintervall
		{
			get
			{
				return myBase.Wartungsintervall;
			}
			set
			{
				if (!value.Equals(this.myBase.Wartungsintervall))
					this.myBase.Wartungsintervall = value;
			}
		}

		/// <summary>
		/// Gibt den Dateipfad für diese Maschine im Technikordner auf der NASE82002 zurück.
		/// </summary>
		public string Dateipfad
		{
			get
			{
				if (this.myBase.IsDateipfadNull()) return string.Empty;
				return this.myBase.Dateipfad;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetDateipfadNull();
					return;
				}
				if (this.myBase.IsDateipfadNull() || !value.Equals(this.myBase.Dateipfad, StringComparison.CurrentCulture))
					this.myBase.Dateipfad = value;
			}
		}

		/// <summary>
		/// Sonderausstattung der Maschine, z. B. Heizung, Zusatzlüfter etc.
		/// </summary>
		public string Sonderausstattlung
		{
			get
			{
				if (this.myBase.IsSonderausstattungNull()) return string.Empty;
				return this.myBase.Sonderausstattung;
			}
			set
			{
				if (value == null)
				{
					this.myBase.SetSonderausstattungNull();
					return;
				}
				if (this.myBase.IsSonderausstattungNull() || !value.Equals(this.myBase.Sonderausstattung, StringComparison.CurrentCulture))
					this.myBase.Sonderausstattung = value;
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

		/// <summary>
		/// Gibt einen Überblick über die SAGE Aufträge, Rechnungen und Lieferungen zurück, in denen
		/// die Seriennummer dieser Maschine auftaucht.
		/// </summary>
		public string SageOrderInfo
		{
			get
			{
				if (string.IsNullOrEmpty(this.Seriennummer)) return string.Empty;
				return ModelManager.OrderService.GetOrderInfoBySerialNumber(this.Seriennummer, this.CurrentOwner.CustomerId);
			}
		}

		#endregion public properties

		#region public procedures

		/// <summary>
		/// Fügt einen neuen Dateilink zu dieser Kundenmaschine hinzu.
		/// </summary>
		/// <param name="pathAndName">Pfad und Dateiname der hinzuzufügenden Datei.</param>
		/// <param name="deleteSourceFile">Soll die Originaldatei gelöscht werden?</param>
		public void AddFileLink(string pathAndName, bool deleteSourceFile)
		{
			ModelManager.FileLinkService.AddFileLink(new System.IO.FileInfo(pathAndName), this, deleteSourceFile);
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

		#endregion public procedures
	}
}