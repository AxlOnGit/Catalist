using System;
using System.Collections.Generic;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class WartungsVorschlag
	{

		#region members

		readonly dsMachines.KundenmaschinenListeRow myBase;

		#endregion

		#region pubic properties

		/// <summary>
		/// Primärschlüssel der Kundenmaschine.
		/// </summary>
		public string UID { get { return this.myBase.UID; } }

		/// <summary>
		/// Gibt die Modellbezeichnung der Maschine zurück.
		/// </summary>
		public string Bezeichnung {
			get
			{
				if (this.Maschine == null) return "";
				return this.Maschine.Modellbezeichnung;
			}
		}
		public string Seriennummer { get { return this.myBase.Seriennummer; } }
		public DateTime Zuordnungsdatum { get { return this.myBase.Zuordnung; } }
		public bool Wartungskennzeichen { get { return this.myBase.Wartungskennzeichen == 1; } }
		public int Wartungsintervall { get { return this.myBase.Wartungsintervall; } }
		public DateTime Auftragsdatum { get { return this.myBase.Auftragsdatum; } }
		public DateTime Installationsdatum { get { return this.myBase.Installationsdatum; } }
		public DateTime Kaufdatum { get { return this.myBase.Kaufdatum; } }
		public DateTime? Vorschlagdatum
		{
			get
			{

				DateTime? vorschlag = null;
				var list = new List<DateTime>();

				return vorschlag;
			}
		}

		#region ENTITIES

		/// <summary>
		/// Gibt die Kundenmaschine zurück.
		/// </summary>
		public Kundenmaschine Maschine
		{
			get
			{
				return ModelManager.MachineService.GetKundenMaschine(this.Kunde, this.UID);
			}
		}

		/// <summary>
		/// Gibt den Eigentümer der Kundenmaschine zurück.
		/// </summary>
		public Kunde Kunde { get { return ModelManager.CustomerService.GetKunde(this.myBase.Kundennummer, false); } }

		#endregion

		#endregion

		#region ### .ctor ###

		public WartungsVorschlag(dsMachines.KundenmaschinenListeRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

		#region public procedures
		#endregion

	}
}
