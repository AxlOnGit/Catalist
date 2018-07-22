using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class SoftwareUpgrade
	{
		#region MEMBERS

		readonly dsSoftware.SoftwareUpgradeRow myBase;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt die Kundennummer des Kunden zurück, den das Upgrade betrifft.
		/// </summary>
		public string Kundennummer { get { return this.myBase.Kundennummer; } }

		/// <summary>
		/// Gibt die <seealso cref="Kunde"/> Instanz des von dem Upgrade betroffenen Kunden zurück.
		/// </summary>
		public Kunde Kunde { get { return ModelManager.CustomerService.GetKunde(this.Kundennummer, false); } }

		/// <summary>
		/// Gibt den Kunden-Matchcode zurück.
		/// </summary>
		public string Matchcode
		{
			get
			{
				return (this.Kunde == null) ? string.Empty : this.Kunde.Matchcode;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel der alten (zu aktualisierenden) Kundensoftware zurück.
		/// </summary>
		public string AlteVersionId
		{
			get
			{
				return this.myBase.AlteVersionId;
			}
		}

		/// <summary>
		/// Gibt die <seealso cref="Kundensoftware"/> Instanz der Software zurück, die aktualisiert
		/// wurde/werden soll.
		/// </summary>
		public Kundensoftware AlteVersion
		{
			get
			{
				return ModelManager.SoftwareService.GetKundenSoftware(this.Kunde, this.AlteVersionId);
			}
		}

		/// <summary>
		/// Gibt die Software-Bezeichnung der Software zurück, die aktualisiert wurde, bzw.
		/// aktualisiert werden soll.
		/// </summary>
		public string AlteVersionName
		{
			get { return (this.AlteVersion == null) ? string.Empty : this.AlteVersion.Softwarename; }
		}

		/// <summary>
		/// Gibt den Lizenzschlüssel der alten (zu aktualisierenden) Kundensoftware zurück oder legt
		/// ihn fest.
		/// </summary>
		public string AlteLizenz
		{
			get
			{
				return this.myBase.IsAlteLizenzNull() ? string.Empty : this.myBase.AlteLizenz;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetAlteLizenzNull();
				this.myBase.AlteLizenz = value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel der neuen (aktualisierten) Kundensoftware zurück.
		/// </summary>
		public string NeueVersionId
		{
			get
			{
				return this.myBase.IsNeueVersionIdNull() ? string.Empty : this.myBase.NeueVersionId;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetNeueVersionIdNull();
				this.myBase.NeueVersionId = value;
			}
		}

		/// <summary>
		/// Gibt die <seealso cref="Kundensoftware"/> Instanz der Software zurück, auf die
		/// aktualisiert wurde.
		/// </summary>
		public Kundensoftware NeueVersion
		{
			get
			{
				return string.IsNullOrEmpty(this.NeueVersionId) ? null : ModelManager.SoftwareService.GetKundenSoftware(this.Kunde, this.NeueVersionId);
			}
		}

		/// <summary>
		/// Gibt die Software-Bezeichnung der Software zurück, auf die aktualisiert wurde.
		/// </summary>
		public string NeueVersionName
		{
			get { return (this.NeueVersion == null) ? string.Empty : this.NeueVersion.Softwarename; }
		}

		/// <summary>
		/// Gibt den Lizenzschlüssel der neuen (aktualisierten) Kundensoftware zurück.
		/// </summary>
		public string NeueLizenz
		{
			get
			{
				return this.myBase.IsNeueLizenzNull() ? string.Empty : this.myBase.NeueLizenz;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetNeueLizenzNull();
				this.myBase.NeueLizenz = value;
			}
		}

		/// <summary>
		/// Gibt die Bezeichnung des Maschinenmodells zurück oder legt es fest.
		/// </summary>
		public string Maschinenmodell
		{
			get
			{
				return this.myBase.IsMaschinenmodellNull() ? null : this.myBase.Maschinenmodell;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { this.myBase.SetMaschinenmodellNull(); return; }
				this.myBase.Maschinenmodell = value;
			}
		}

		/// <summary>
		/// Gibt die Seriennummer der Maschine zurück, der die Software zugeordnet ist oder legt sie fest.
		/// </summary>
		public string Seriennummer
		{
			get
			{
				return this.myBase.IsSeriennummerNull() ? string.Empty : this.myBase.Seriennummer;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { this.myBase.SetSeriennummerNull(); return; }
				this.myBase.Seriennummer = value;
			}
		}

		/// <summary>
		/// Gibt das Datum zurück, an dem das Upgrade beim Aussteller angefordert wurde oder legt es fest.
		/// </summary>
		public DateTime? AngefordertAm
		{
			get
			{
				if (this.myBase.IsAngefordertAmNull()) return null;
				return this.myBase.AngefordertAm;
			}
			set
			{
				if (!value.HasValue) { this.myBase.SetAngefordertAmNull(); return; }
				this.myBase.AngefordertAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Mitarbeiters zurück, der das Upgrade beim Aussteller
		/// angefordert hat oder legt ihn fest.
		/// </summary>
		public string AngefordertVonId
		{
			get
			{
				return this.myBase.IsAngefordertVonIdNull() ? string.Empty : this.myBase.AngefordertVonId;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetAngefordertVonIdNull();
				this.myBase.AngefordertVonId = value;
			}
		}

		/// <summary>
		/// Gibt die <seealso cref="User"/> Instanz des Mitarbeiters zurück, der den neuen
		/// Lizenzschlüssel anfordert, bzw. angefordert hat.
		/// </summary>
		public User AngefordertVon
		{
			get
			{
				return string.IsNullOrEmpty(this.AngefordertVonId) ? null : ModelManager.UserService.GetUser(this.AngefordertVonId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt das Datum zurück, an dem wir die neue Lizenz vom Aussteller bekommen haben oder legt
		/// es fest.
		/// </summary>
		public DateTime? ErhaltenAm
		{
			get
			{
				if (this.myBase.IsErhaltenAmNull()) return null;
				return this.myBase.ErhaltenAm;
			}
			set
			{
				if (!value.HasValue) { this.myBase.SetErhaltenAmNull(); return; }
				this.myBase.ErhaltenAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt das Datum zurück, an dem der Kunde seine neue Lizenz von uns bekommen hat oder legt
		/// es fest.
		/// </summary>
		public DateTime? KundeInformiertAm
		{
			get
			{
				if (this.myBase.IsKundeInformiertAmNull()) return null;
				return this.myBase.KundeInformiertAm;
			}
			set
			{
				if (!value.HasValue) { this.myBase.SetKundeInformiertAmNull(); return; }
				this.myBase.KundeInformiertAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Mitarbeiters zurück, von dem der Kunde den neuen
		/// Lizenzschlüssel bekommen hat oder legt ihn fest.
		/// </summary>
		public string KundeInformiertVonId
		{
			get
			{
				return this.myBase.IsKundeInformiertVonIdNull() ? string.Empty : this.myBase.KundeInformiertVonId;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetKundeInformiertVonIdNull();
				this.myBase.KundeInformiertVonId = value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Mitarbeiters zurück, der dem Kunden den neuen
		/// Lizenzschlüssel übermittelt hat.
		/// </summary>
		public User KundeInformiertVon
		{
			get
			{
				return string.IsNullOrEmpty(this.KundeInformiertVonId) ? null : ModelManager.UserService.GetUser(this.KundeInformiertVonId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt die Bemerkungen zu diesem Upgrade Vorgang zurück oder legt sie fest.
		/// </summary>
		public string Bemerkungen
		{
			get
			{
				return this.myBase.IsBemerkungenNull() ? string.Empty : this.myBase.Bemerkungen;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetBemerkungenNull();
				this.myBase.Bemerkungen = value;
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="SoftwareUpgrade"/> Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public SoftwareUpgrade(dsSoftware.SoftwareUpgradeRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion ### .ctor ###
	}
}