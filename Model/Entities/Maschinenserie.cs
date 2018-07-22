using Products.Common;
using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Maschinenserie : ILinkedItem
	{
		#region MEMBERS

		readonly dsShared.MaschinenSerieRow myBase;
		SortableBindingList<Maschinenmodell> myModelle;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		#region ILINKEDITEM

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key => this.myBase.UID;

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId => ModelManager.SharedItemsService.GetLinkTypeByName("Maschinenserie").UID;

		/// <summary>
		/// Gibt die Bezeichnung dieser Serie zurück.
		/// </summary>
		public string ItemName => this.myBase.Serienname;

		/// <summary>
		/// Gibt die Zeichenfolge 'Maschinenserie' zurück.
		/// </summary>
		public string LinkTypBezeichnung => "Maschinenserie";

		#endregion ILINKEDITEM

		#region SKALARE

		/// <summary>
		/// Primärschlüssel der Serie.
		/// </summary>
		public string UID => myBase.UID;

		/// <summary>
		/// Bezeichnung dieser Serie.
		/// </summary>
		public string Serienname { get { return myBase.Serienname; } set { myBase.Serienname = value; } }

		/// <summary>
		/// Gibt die Kurzbezeichnung der Maschinenserie zurück. Wird z. B. im Dateisystem gebraucht.
		/// </summary>
		public string Kurzname { get { return this.myBase.Kurzname; } set { this.myBase.Kurzname = value; } }

		/// <summary>
		/// Gibt den Dateipfad zu dieser Maschinenserie im Technikordner zurück.
		/// </summary>
		public string Dateipfad { get { return this.myBase.Dateipfad; } set { this.myBase.Dateipfad = value; } }

		/// <summary>
		/// Gibt den Namen der Word-Vorlage an, die für Installations-Checklisten verwendet
		/// werden soll.
		/// </summary>
		public string InstallationsChecklistenVorlage
		{
			get { return this.myBase.InstChecklistVorlage; }
			set { this.myBase.InstChecklistVorlage = value; }
		}

		/// <summary>
		/// Gibt den Dateinamen der Word-Vorlage für Installationsberichte zurück oder legt ihn fest.
		/// </summary>
		public string InstallationsReportVorlage
		{
			get { return this.myBase.InstReportVorlage; }
			set { this.myBase.InstReportVorlage = value; }
		}

		/// <summary>
		/// GUID des Herstellers.
		/// </summary>
		public string HerstellerId { get { return myBase.HerstellerId; } set { myBase.HerstellerId = value; } }

		/// <summary>
		/// GUID des Maschinentyps.
		/// </summary>
		public string MaschinentypId { get { return myBase.MaschinentypId; } set { myBase.MaschinentypId = value; } }

		/// <summary>
		/// Gibt die Versionsnummer der aktuellen Firmware zurück.
		/// </summary>
		public string LetzteFirmware
		{
			get { return this.myBase.LetzteFirmware; }
			set
			{
				if (!this.myBase.LetzteFirmware.Equals(value, System.StringComparison.CurrentCultureIgnoreCase)) this.myBase.LetzteFirmware = value;
			}
		}

		/// <summary>
		/// Gibt das Jahr der Markteinführung zurück.
		/// </summary>
		public int Markteinfuehrung
		{
			get { return this.myBase.Markteinfuehrung; }
			set
			{
				if (!this.myBase.Markteinfuehrung.Equals(value)) this.myBase.Markteinfuehrung = value;
			}
		}

		/// <summary>
		/// Gibt True zurück, wenn diese Serie generell gewartet werden kann/soll.
		/// </summary>
		public bool Wartungskennzeichen
		{
			get { return (this.myBase.Wartungskennzeichen == 1); }
			set { this.myBase.Wartungskennzeichen = (ulong)((value == true) ? 1 : 0); }
		}

		/// <summary>
		/// Gibt das Wartungsintervall für Modelle dieser Serie in Monaten zurück oder legt es fest.
		/// </summary>
		public int Wartungsintervall
		{
			get { return this.myBase.Wartungsintervall; }
			set { this.myBase.Wartungsintervall = value; }
		}

		#endregion SKALARE

		#region ENTITIES

		/// <summary>
		/// Gibt den Hersteller dieser Serie als Objekt zurück.
		/// </summary>
		public Hersteller Hersteller => ModelManager.SharedItemsService.GetHersteller(myBase.HerstellerId);

		/// <summary>
		/// Gibt den Firmennamen des Herstellers zurück.
		/// </summary>
		public string Herstellername => this.Hersteller.Herstellername;

		/// <summary>
		/// Gibt den Maschinentyp der Serie als Objekt zurück.
		/// </summary>
		public Maschinentyp Maschinentyp => ModelManager.SharedItemsService.GetMaschinenTyp(this.MaschinentypId);

		/// <summary>
		/// Gibt die Bezeichnung des Maschinentyps zurück.
		/// </summary>
		public string Typbezeichnung => this.Maschinentyp.MaschinentypName;

		public SortableBindingList<Maschinenmodell> Maschinenmodelle
		{
			get
			{
				if (myModelle == null)
				{
					this.myModelle = ModelManager.SharedItemsService.GetMaschinenModellList(this);
				}
				return myModelle;
			}
		}

		#endregion ENTITIES

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Maschinenserie Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Maschinenserie(dsShared.MaschinenSerieRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion ### .ctor ###
	}
}