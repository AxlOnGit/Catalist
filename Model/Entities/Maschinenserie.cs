using Products.Common;
using Products.Data.Datasets;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class Maschinenserie : ILinkedItem
	{

		#region members

		readonly dsShared.MaschinenSerieRow myBase;
		SortableBindingList<Maschinenmodell> myModelle;

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
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Maschinenserie").UID; }
		}

		public string ItemName
		{
			get { return this.myBase.Serienname; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Maschinenserie"; }
		}

		#endregion

		#region skalare

		/// <summary>
		/// Primärschlüssel der Serie.
		/// </summary>
		public string UID { get { return myBase.UID; } }

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

		public int Wartungsintervall
		{
			get { return this.myBase.Wartungsintervall; }
		}

		#endregion

		#region entities

		/// <summary>
		/// Gibt den Hersteller dieser Serie als Objekt zurück.
		/// </summary>
		public Hersteller Hersteller
		{
			get
			{
				return ModelManager.SharedItemsService.GetHersteller(myBase.HerstellerId);
			}
		}

		/// <summary>
		/// Gibt den Firmennamen des Herstellers zurück.
		/// </summary>
		public string Herstellername
		{
			get { return this.Hersteller.Herstellername; }
		}

		/// <summary>
		/// Gibt den Maschinentyp der Serie als Objekt zurück.
		/// </summary>
		public Maschinentyp Maschinentyp
		{
			get
			{
				return ModelManager.SharedItemsService.GetMaschinenTyp(this.MaschinentypId);
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung des Maschinentyps zurück.
		/// </summary>
		public string Typbezeichnung
		{
			get { return this.Maschinentyp.MaschinentypName; }
		}

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

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Maschinenserie Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Maschinenserie(dsShared.MaschinenSerieRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures
		
		#endregion

		#region private procedures

		#endregion

	}
}
