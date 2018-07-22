using System;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Maschinenauftrag
	{
		#region MEMBERS

		readonly dsMachines.MaschinenauftragRow myBase;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt den Primärschlüssel der Kundenmaschine dieses Maschinenauftrags zurück.
		/// </summary>
		public string MaschinenId => this.myBase.MaschinenId;

		/// <summary>
		/// Gibt die Kundenmaschine dieses Auftrags zurück.
		/// </summary>
		public Kundenmaschine Maschine => RepoManager.KundenmaschinenRepository.GetKundenmaschine(this.myBase.MaschinenId);

		/// <summary>
		/// Gibt die Bezeichnung des <seealso cref="Maschinenmodell"/> dieser Kundenmaschine zurück.
		/// /// </summary>
		public string Maschinenmodell => this.Maschine.Maschinenmodell.Modellbezeichnung;

		/// <summary>
		/// Gibt die bei uns gebräuchliche 5-stellige Kundennummer des Auftragskunden zurück.
		/// </summary>
		public string Kundennummer => this.Auftragskunde.KundenNrCpm;

		/// <summary>
		/// Gibt den Auftragskunden dieses Maschinenauftrags zurück.
		/// </summary>
		public Kunde Auftragskunde
		{
			get
			{
				if (this.Maschine != null) return this.Maschine.Kunde;
				return null;
			}
		}

		/// <summary>
		/// Gibt den KundenMatchcode des Auftragskunden zurück.
		/// </summary>
		public string Matchcode => this.Auftragskunde == null ? string.Empty : this.Auftragskunde.Matchcode;

		/// <summary>
		/// Gibt das Datum zurück, an dem der Kunde die Maschine bei uns bestellt hat.
		/// </summary>
		public DateTime? KundenbestellungAm
		{
			get
			{
				if (this.myBase.IsKundenbestellungAmNull()) return null;
				return this.myBase.KundenbestellungAm;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetKundenbestellungAmNull(); return; }
				this.myBase.KundenbestellungAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt den Namen der Person beim Kunden zurück, die die Maschine bestellt hat
		/// oder legt ihn fest.
		/// </summary>
		public string KundenbestellungDurch
		{
			get
			{
				if (this.myBase.IsKundenbestellungDurchNull()) return string.Empty;
				return this.myBase.KundenbestellungDurch;
			}
			set
			{
				if (string.IsNullOrEmpty(value)) this.myBase.SetKundenbestellungDurchNull();
				this.myBase.KundenbestellungDurch = value;
			}
		}

		/// <summary>
		/// Gibt zurück, wie der Besteller die Maschine in Auftrag gegeben hat. Z. B. per
		/// Telefon, E-Mail, Webshop etc.
		/// </summary>
		public string KundenbestellungPer
		{
			get
			{
				if (this.myBase.IsKundenbestellungPerNull()) return string.Empty;
				return this.myBase.KundenbestellungPer;
			}
			set
			{
				if (string.IsNullOrEmpty(value)) this.myBase.SetKundenbestellungPerNull();
				this.myBase.KundenbestellungPer = value;
			}
		}

		/// <summary>
		/// Gibt das Datum zurück, an dem wir die Maschine beim Hersteller bestellt haben
		/// oder legt es fest.
		/// </summary>
		public DateTime? MaschinenbestellungAm
		{
			get
			{
				if (this.myBase.IsMaschinenbestellungAmNull()) return null;
				return this.myBase.MaschinenbestellungAm;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetMaschinenbestellungAmNull(); return; }
				this.myBase.MaschinenbestellungAm = value.Value;
			}
		}

		/// <summary>
		/// Legt den Primärschlüssel des Mitarbeiters fest, der die Maschine beim
		/// Hersteller bestellt hat.
		/// </summary>
		public string MaschinenbestellungDurchId
		{
			get
			{
				return this.myBase.IsMaschinenbestellungDurchIdNull() ? string.Empty : this.myBase.MaschinenbestellungDurchId;
			}
			set
			{
				if (string.IsNullOrEmpty(value)) this.myBase.SetMaschinenbestellungDurchIdNull();
				this.myBase.MaschinenbestellungDurchId = value;
			}
		}

		/// <summary>
		/// Gibt die Instanz des Users zurück, der die Maschine beim Hersteller bestellt hat.
		/// </summary>
		public User MaschinenbestellungDurch
		{
			get
			{
				if (this.myBase.IsMaschinenbestellungDurchIdNull() || string.IsNullOrEmpty(this.myBase.MaschinenbestellungDurchId)) return null;
				return ModelManager.UserService.GetUser(this.myBase.MaschinenbestellungDurchId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt das voraussichtliche Lieferdatum der Maschine an den Kunden zurück oder
		/// legt es fest.
		/// </summary>
		public DateTime? LieferungZumKundenAm
		{
			get
			{
				if (this.myBase.IsLieferungZumKundenAmNull()) return null;
				return this.myBase.LieferungZumKundenAm;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetLieferungZumKundenAmNull(); return; }
				this.myBase.LieferungZumKundenAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Technikers zurück, der die Maschine an den Kunden
		/// ausliefert/ausgeliefert hat.
		/// </summary>
		public string LieferungZumKundenDurchId
		{
			get
			{
				return this.myBase.IsLieferungZumKundenDurchIdNull() ? string.Empty : this.myBase.LieferungZumKundenDurchId;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetLieferungZumKundenDurchIdNull();
				this.myBase.LieferungZumKundenDurchId = value;
			}
		}

		/// <summary>
		/// Gibt die <seealso cref="User"/> Instanz des Mitarbeiters (Technikers) zurück,
		/// der die Maschine an den Kunden ausliefert/ausgeliefert hat.
		/// </summary>
		public User LieferungZumKundenDurch
		{
			get
			{
				var userId = this.LieferungZumKundenDurchId;
				return string.IsNullOrEmpty(userId) ? null : ModelManager.UserService.GetUser(userId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt die Bestellnummer in Sage zurück oder legt sie fest.
		/// </summary>
		public string BestellIdSage
		{
			get
			{
				if (this.myBase.IsBestellIdSageNull()) return string.Empty;
				return this.myBase.BestellIdSage;
			}
			set
			{
				if (string.IsNullOrEmpty(value)) this.myBase.SetBestellIdSageNull();
				this.myBase.BestellIdSage = value;
			}
		}

		/// <summary>
		/// Gibt das Datum der voraussichtlichen Lieferung durch den Hersteller zurück oder
		/// legt es fest.
		/// </summary>
		public DateTime? MaschinenlieferungAm
		{
			get
			{
				if (this.myBase.IsMaschinenlieferungAmNull()) return null;
				return this.myBase.MaschinenlieferungAm;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetMaschinenlieferungAmNull(); return; }
				this.myBase.MaschinenlieferungAm = value.Value;
			}
		}

		/// <summary>
		/// Gibt die Anmerkungen zur Bestellung dieses Maschinenauftrags zurück oder legt
		/// sie fest.
		/// </summary>
		public string AnmerkungenBestellung
		{
			get
			{
				if (this.myBase.IsAnmerkungenBestellungNull()) return string.Empty;
				return this.myBase.AnmerkungenBestellung;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetAnmerkungenBestellungNull();
				this.myBase.AnmerkungenBestellung = value;
			}
		}

		/// <summary>
		/// Gibt True zurück, wenn es Anmerkungen zur Bestellung gibt.
		/// </summary>
		public bool HasAnmerkungenBestellung => !string.IsNullOrEmpty(this.AnmerkungenBestellung);

		/// <summary>
		/// Gibt True zurück, wenn es Anmerkungen zur Finanzierung gibt.
		/// </summary>
		public bool HasAnmerkungenFinanzierung => !string.IsNullOrEmpty(this.AnmerkungenFinanzierung);

		/// <summary>
		/// Gibt das Datum zurück, an dem die Finanzierungsgesellschaft den Maschinenkauf
		/// bestätigt hat.
		/// </summary>
		public DateTime? BestelleintrittAm
		{
			get
			{
				if (this.myBase.IsBestelleintrittAmNull()) return null;
				return this.myBase.BestelleintrittAm;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetBestelleintrittAmNull(); return; }
				this.myBase.BestelleintrittAm = value.Value;
			}
		}

		/// <summary>
		/// Das Flag legt fest, ob die Vertragsunterlagen vom Kunden vollständig ausgefüllt
		/// und unterschrieben wurden. Diese Eigenschaft kann die gelesen und festgelegt werden.
		/// </summary>
		public bool VertragsunterlagenFlag
		{
			get
			{
				return this.myBase.VertragsunterlagenFlag == "1";
			}
			set
			{
				switch (value)
				{
					case true:
					this.myBase.VertragsunterlagenFlag = "1";
					break;

					case false:
					this.myBase.VertragsunterlagenFlag = "0";
					break;
				}
			}
		}

		/// <summary>
		/// Dieses Flag legt fest, ob der Kunde die Übernahmebestätigung der
		/// Finanzierungsgesellschaft vollständig ausgefüllt und unterschrieben hat, und
		/// dass die Bestätigung an die Gesellschaft übermittelt wurde.
		/// </summary>
		public bool UebernahmebestaetigungFlag
		{
			get
			{
				return this.myBase.UebernahmebestaetigungFlag == "1";
			}
			set
			{
				switch (value)
				{
					case true:
					this.myBase.UebernahmebestaetigungFlag = "1";
					break;

					case false:
					this.myBase.UebernahmebestaetigungFlag = "0";
					break;
				}
			}
		}

		/// <summary>
		/// Dieses Flag legt fest, ob für die Maschine eine Objektversicherung
		/// abgeschlossen wurde.
		/// </summary>
		public bool ObjektversicherungFlag
		{
			get
			{
				return this.myBase.ObjektversicherungFlag == "1";
			}
			set
			{
				switch (value)
				{
					case true:
					this.myBase.ObjektversicherungFlag = "1";
					break;

					case false:
					this.myBase.ObjektversicherungFlag = "0";
					break;
				}
			}
		}

		/// <summary>
		/// Das Flag legt fest, ob der Kunde die AGB des Finanzdienstleisters unterzeichnet hat.
		/// </summary>
		/// <remarks>
		/// Das kann entweder implizit, durch Unterzeichnung der Vertragsunterlagen
		/// geschehen, wenn die AGB deren integraler Bestandteil sind (z. B. als
		/// rückseitiger Ausdruck) oder durch Unterzeichnung der AGB selbst, wenn diese
		/// separat vorliegen.
		/// </remarks>
		public bool AgbUnterzeichnetFlag
		{
			get
			{
				return this.myBase.AgbUnterzeichnetFlag == "1";
			}
			set
			{
				switch (value)
				{
					case true:
					this.myBase.AgbUnterzeichnetFlag = "1";
					break;

					case false:
					this.myBase.AgbUnterzeichnetFlag = "0";
					break;
				}
			}
		}

		/// <summary>
		/// Gibt die Anmerkungen zur Finanzierung des Maschinenauftrags zurück oder legt
		/// sie fest.
		/// </summary>
		public string AnmerkungenFinanzierung
		{
			get
			{
				if (this.myBase.IsAnmerkungenFinanzierungNull()) return string.Empty;
				return this.myBase.AnmerkungenFinanzierung;
			}
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetAnmerkungenFinanzierungNull();
				this.myBase.AnmerkungenFinanzierung = value;
			}
		}

		/// <summary>
		/// Gibt den Primärschlüssel des Users zurück, der die Maschine installiert hat
		/// oder legt ihn fest.
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
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) this.myBase.SetInstallationDurchIdNull();
				this.myBase.InstallationDurchId = value;
			}
		}

		/// <summary>
		/// Gibt die Instanz des Users zurück, der die Maschine installiert hat.
		/// </summary>
		public User InstallationDurch
		{
			get
			{
				if (this.myBase.IsInstallationDurchIdNull()) return null;
				return ModelManager.UserService.GetUser(this.myBase.InstallationDurchId, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt das Datum der Installation dieser Maschine zurück oder legt es fest.
		/// </summary>
		public DateTime? Installationsdatum
		{
			get
			{
				if (this.myBase.IsInstallationsdatumNull()) return null;
				return this.myBase.Installationsdatum;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetInstallationsdatumNull(); return; }
				this.myBase.Installationsdatum = value.Value;
			}
		}

		/// <summary>
		/// Das Flag legt fest, ob die Garantieunterlagen vollständig übermittelt und vom
		/// Hersteller bestätigt wurden.
		/// </summary>
		public bool GarantieunterlagenFlag
		{
			get
			{
				return this.myBase.GarantieunterlagenFlag == "1";
			}
			set
			{
				switch (value)
				{
					case true:
					this.myBase.GarantieunterlagenFlag = "1";
					break;

					case false:
					this.myBase.GarantieunterlagenFlag = "0";
					break;
				}
			}
		}

		/// <summary>
		/// Gibt das Datum des Ablaufs der Garantiezeit zurück oder legt es fest.
		/// </summary>
		public DateTime? Garantieablaufdatum
		{
			get
			{
				if (this.myBase.IsGarantieablaufdatumNull()) return null;
				return this.myBase.Garantieablaufdatum;
			}
			set
			{
				if (!value.HasValue || value == null) { this.myBase.SetGarantieablaufdatumNull(); return; }
				this.myBase.Garantieablaufdatum = value.Value;
			}
		}

		/// <summary>
		/// Gibt die Auftragsnummer des Kundenauftrags in Sage zurück oder legt sie fest.
		/// </summary>
		public string AuftragsnummerSage
		{
			get
			{
				return this.Maschine.AuftragsnummerSage;
			}
			set
			{
				this.Maschine.AuftragsnummerSage = value;
			}
		}

		/// <summary>
		/// Gibt das Datum des Auftrags in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Auftragsdatum
		{
			get
			{
				return this.Maschine.Auftragsdatum;
			}
			set
			{
				this.Maschine.Auftragsdatum = value;
			}
		}

		/// <summary>
		/// Gibt die Nummer der Rechnung/Direktrechnung in Sage zurück oder legt sie fest.
		/// </summary>
		public string RechnungsnummerSage
		{
			get
			{
				return this.Maschine.RechnungsnummerSage;
			}
			set
			{
				this.Maschine.RechnungsnummerSage = value;
			}
		}

		/// <summary>
		/// Gibt das Datum der Rechnung/Direktrechnung in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Rechnungsdatum
		{
			get
			{
				return this.Maschine.Rechnungsdatum;
			}
			set
			{
				this.Maschine.Rechnungsdatum = value;
			}
		}

		/// <summary>
		/// Gibt die Nummer des Lieferscheins in Sage zurück oder legt sie fest.
		/// </summary>
		public string LieferscheinnummerSage
		{
			get
			{
				return this.Maschine.LieferscheinnummerSage;
			}
			set
			{
				this.Maschine.LieferscheinnummerSage = value;
			}
		}

		/// <summary>
		/// Gibt das Datum des Lieferscheins in Sage zurück oder legt es fest.
		/// </summary>
		public DateTime? Lieferscheindatum
		{
			get
			{
				return this.Maschine.Lieferdatum;
			}
			set
			{
				this.Maschine.Lieferdatum = value;
			}
		}

		/// <summary>
		/// Gibt True zurück, wenn der Auftrag erledigt ist, sonst False.
		/// </summary>
		public bool AuftragErledigtFlag
		{
			get
			{
				if (this.myBase.IsAuftragErledigtFlagNull() || this.myBase.AuftragErledigtFlag == "0") return false;
				return true;
			}
			set
			{
				if (value == true) this.myBase.AuftragErledigtFlag = "1";
				else this.myBase.AuftragErledigtFlag = "0";
			}
		}

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="Maschinenauftrag"/> Klasse.
		/// </summary>
		/// <param name="baseRow">
		/// Die Instanz einer <seealso cref="dsMachines.MaschinenauftragRow"/> Datenzeile.
		/// </param>
		public Maschinenauftrag(dsMachines.MaschinenauftragRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion ### .ctor ###
	}
}