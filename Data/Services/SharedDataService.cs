using Products.Data.Datasets;
using Products.Data.Datasets.dsSharedTableAdapters;
using System;
using Products.Common;

namespace Products.Data.Services
{
	public class SharedDataService
	{

		#region members

		readonly string myCurrentUserPK;
		readonly dsShared mySharedDS = new dsShared();

		#region Adapter

		taHersteller myHerstellerAdapter;
		taLinkTyp myLinkTypAdapter;
		taMaschinenModell myMaschinenModellAdapter;
		taMaschinenSerie myMaschinenSerieAdapter;
		taMaschinenTyp myMaschinenTypAdapter;
		taPreset myPresetAdapter;
		taTinte myTinteAdapter;

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der SharedDataService Klasse.
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		/// </summary>
		public SharedDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		#region Hersteller

		/// <summary>
		/// Fügt der Tabelle Hersteller eine neue Zeile hinzu. Optional kann der Herstellername 
		/// angegeben werden.
		/// </summary>
		/// <param name="hersteller">Zeichenfolge mit dem Herstellernamen.</param>
		/// <returns></returns>
		public dsShared.HerstellerRow AddHerstellerRow(string hersteller = "Hersteller")
		{
			this.AssureHerstellerInitialized();
			var hRow = this.mySharedDS.Hersteller.NewHerstellerRow();
			hRow.UID = SequentialGuid.NewID().ToString();
			hRow.HerstellerName = hersteller;

			this.mySharedDS.Hersteller.AddHerstellerRow(hRow);
			this.UpdateHersteller(hRow);

			return hRow;
		}

		/// <summary>
		/// Gibt die Hersteller Tabelle des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.HerstellerDataTable GetHerstellerTable()
		{
			AssureHerstellerInitialized();
			return this.mySharedDS.Hersteller;
		}

		/// <summary>
		/// Gibt die HerstellerRow mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="herstellerPK"></param>
		/// <returns></returns>
		public dsShared.HerstellerRow GetHerstellerRow(string herstellerPK)
		{
			this.AssureHerstellerInitialized();
			return this.mySharedDS.Hersteller.FindByUID(herstellerPK);
		}

		/// <summary>
		/// Löscht die Herstellerzeile mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="herstellerPK"></param>
		/// <returns></returns>
		public int DeleteHerstellerRow(string herstellerPK)
		{
			int result = 0;
			var hRow = this.mySharedDS.Hersteller.FindByUID(herstellerPK);
			if (hRow != null)
			{
				hRow.Delete();
				result = this.myHerstellerAdapter.Update(hRow);
			}
			return result;
		}

		/// <summary>
		/// Überträgt Änderungen der angegebenen Row in die Datenbank oder, falls keine Row
		/// übergeben wird, die Änderung aller Datensätze.
		/// </summary>
		/// <param name="oneRow"></param>
		/// <returns></returns>
		public int UpdateHersteller(dsShared.HerstellerRow oneRow = null)
		{
			var result = 0;
			if (oneRow != null)
			{
				result = this.myHerstellerAdapter.Update(oneRow);
			}
			result = this.myHerstellerAdapter.Update(this.mySharedDS.Hersteller);
			return result;
		}

		#endregion

		#region LinkTyp

		/// <summary>
		/// Fügt der Tabelle LinkTyp eine neue Zeile hinzu und speichert sie in der Datenbank.
		/// </summary>
		/// <param name="linkTypName">Optional. Der Name des neuen LinkTyps.</param>
		/// <param name="herkunft">Optional. Die Herkunftsbezeichnung.</param>
		/// <returns></returns>
		public dsShared.LinkTypRow AddLinkTypRow(string linkTypName = "Bezeichnung", string herkunft = "Catalist")
		{
			this.AssureLinkTypInitialized();
			var lRow = this.mySharedDS.LinkTyp.NewLinkTypRow();
			lRow.UID = SequentialGuid.NewID().ToString();
			lRow.LinktypBezeichnung = linkTypName;
			lRow.Herkunft = herkunft;

			this.mySharedDS.LinkTyp.AddLinkTypRow(lRow);
			this.UpdateLinkTyp(lRow);

			return lRow;
		}

		/// <summary>
		/// Gibt die Tabelle cpm_linktyp zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.LinkTypDataTable GetLinkTypTable()
		{
			this.AssureLinkTypInitialized();
			return this.mySharedDS.LinkTyp;
		}

		/// <summary>
		/// Gibt die LinkTypRow mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="linkTypPK"></param>
		/// <returns></returns>
		public dsShared.LinkTypRow GetLinkTypRow(string linkTypPK)
		{
			this.AssureLinkTypInitialized();
			return this.mySharedDS.LinkTyp.FindByUID(linkTypPK);
		}

		/// <summary>
		/// Aktualisiert die angegebene Zeile oder die ganze Tabelle, wenn null übergeben wird.
		/// </summary>
		/// <param name="oneRow"></param>
		/// <returns></returns>
		public int UpdateLinkTyp(dsShared.LinkTypRow oneRow = null)
		{
			var result = 0;
			if (oneRow != null)
			{
				result = this.myLinkTypAdapter.Update(oneRow);
			}
			result = this.myLinkTypAdapter.Update(this.mySharedDS.LinkTyp);
			return result;
		}

		#endregion

		#region MaschinenModell

		public dsShared.MaschinenModellRow AddMaschinenModellRow(string modellBezeichnung = "Modellbezeichnung")
		{
			this.AsssureMaschinenModellInitialized();

			var mRow = this.mySharedDS.MaschinenModell.NewMaschinenModellRow();
			mRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			mRow.HerstellerrId = "00000000-0000-0000-0000-000000000000";
			mRow.MaschinenserieId = "00000000-0000-0000-0000-000000000000";
			mRow.MaschinenTypId = "00000000-0000-0000-0000-000000000000";
			mRow.Modellbezeichnung = modellBezeichnung;

			this.mySharedDS.MaschinenModell.AddMaschinenModellRow(mRow);
			this.UpdateMaschinenModell(mRow);

			return mRow;
		}

		/// <summary>
		/// Gibt die Tabelle MaschinenModell des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.MaschinenModellDataTable GetMaschinenModellTable() 
		{
			this.AsssureMaschinenModellInitialized();
			return this.mySharedDS.MaschinenModell;
		}

		/// <summary>
		/// Gibt die Zeile des MaschinenModells mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="modellPK">Primärschlüssel (GUID) des MaschinenModells</param>
		/// <returns></returns>
		public dsShared.MaschinenModellRow GetMaschinenModellRow(string modellPK) 
		{
			this.AsssureMaschinenModellInitialized();
			return this.mySharedDS.MaschinenModell.FindByUID(modellPK);
		}

		/// <summary>
		/// Löscht die MaschinenModell Zeile mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="modellPK"></param>
		/// <returns></returns>
		public int DeleteMaschinenModellRow(string modellPK) 
		{
			this.AsssureMaschinenModellInitialized();
			var mRow = this.mySharedDS.MaschinenModell.FindByUID(modellPK);
			if (mRow != null) mRow.Delete();
			return this.UpdateMaschinenModell(mRow);
		}

		/// <summary>
		/// Speichert Änderungen an der übergebenen Zeile oder der ganzen Tabelle, wenn keine
		/// MaschinenModellRow Instanz übergeben wird.
		/// </summary>
		/// <param name="mRow"></param>
		/// <returns></returns>
		public int UpdateMaschinenModell(dsShared.MaschinenModellRow mRow = null)
		{
			if (mRow != null)
			{
				return this.myMaschinenModellAdapter.Update(mRow);
			}
			return this.myMaschinenModellAdapter.Update(this.mySharedDS.MaschinenModell);
		}

		#endregion

		#region MaschinenSerie

		/// <summary>
		/// Fügt der Tabelle MaschinenSerie eine neue Zeile hinzu.
		/// </summary>
		/// <param name="serienBezeichnung">Optional. Die Bezeichnung der Serie.</param>
		/// <returns></returns>
		public dsShared.MaschinenSerieRow AddMaschinenSerieRow(string serienBezeichnung = "Bezeichnung") 
		{
			this.AssureMaschinenSerieInitialized();

			var mRow = this.mySharedDS.MaschinenSerie.NewMaschinenSerieRow();
			mRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			mRow.Serienname = serienBezeichnung;
			mRow.HerstellerId = "00000000-0000-0000-0000-000000000000";
			mRow.MaschinentypId = "00000000-0000-0000-0000-000000000000";
			mRow.LetzteFirmware = "-";
			mRow.Markteinfuehrung = DateTime.Now.Year;

			this.mySharedDS.MaschinenSerie.AddMaschinenSerieRow(mRow);
			this.UpdateMaschinenSerie(mRow);

			return mRow;
		}

		/// <summary>
		/// Gibt die gesamte Tabelle MaschinenSerie zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.MaschinenSerieDataTable GetMaschinenSerieTable() 
		{
			this.AssureMaschinenSerieInitialized();
			return this.mySharedDS.MaschinenSerie;
		}

		/// <summary>
		/// Gibt die MaschinenSerien Zeile mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="serienPK"></param>
		/// <returns></returns>
		public dsShared.MaschinenSerieRow GetMaschinenSerieRow(string serienPK) 
		{
			this.AssureMaschinenSerieInitialized();
			return this.mySharedDS.MaschinenSerie.FindByUID(serienPK);
		}

		/// <summary>
		/// Löscht die MaschinenSerie Zeile mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="serienPK">Primärschlüssel der zu löschenden Zeile.</param>
		/// <returns></returns>
		public int DeleteMaschinenSerieRow(string serienPK)
		{
			var sRow = this.mySharedDS.MaschinenSerie.FindByUID(serienPK);
			if (sRow != null)
			{
				sRow.Delete();
				return this.UpdateMaschinenSerie(sRow);
			}
			return 0;
		}

		/// <summary>
		/// Löscht die angegebene MaschinenSerieRow aus der Datenbank.
		/// </summary>
		/// <param name="serieRow"></param>
		/// <returns></returns>
		public int DeleteMaschinenSerieRow(dsShared.MaschinenSerieRow serieRow)
		{
			if (serieRow != null)
			{
				serieRow.Delete();
				return this.UpdateMaschinenSerie(serieRow);
			}
			return 0;
		}

		/// <summary>
		/// Aktualisiert die angegebene Zeile oder die gesamte Tahelle, falls keine spezifische Zeile übergeben wird.
		/// </summary>
		/// <param name="mRow"></param>
		public int UpdateMaschinenSerie(dsShared.MaschinenSerieRow mRow = null)
		{
			if (mRow != null)
			{
				return this.myMaschinenSerieAdapter.Update(mRow);
			}
			return this.myMaschinenSerieAdapter.Update(this.mySharedDS.MaschinenSerie);
		}

		#endregion

		#region MaschinenTyp

		/// <summary>
		/// Fügt der MaschinenTyp Tabelle eine neue Zeile hinzu.
		/// </summary>
		/// <param name="typBezeichnung"></param>
		/// <returns></returns>
		public dsShared.MaschinenTypRow AddMaschinenTypRow(string typBezeichnung = "Maschinentyp")
		{
			this.AssureMaschinenTypInitialized();

			var tRow = this.mySharedDS.MaschinenTyp.NewMaschinenTypRow();
			tRow.UID = SequentialGuid.NewSequentialGuid().ToString();
			tRow.MaschinentypName = typBezeichnung;

			this.mySharedDS.MaschinenTyp.AddMaschinenTypRow(tRow);
			this.UpdateMaschinenTyp(tRow);

			return tRow;
		}

		/// <summary>
		/// Gibt die MaschinenTyp Tabelle des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.MaschinenTypDataTable GetMaschinenTypTable()
		{
			this.AssureMaschinenTypInitialized();
			return this.mySharedDS.MaschinenTyp;
		}

		/// <summary>
		/// Speichert die Änderungen der übergebenen MaschinenTypRow oder die gesamte Tabelle, falls
		/// keine Zeile übergheben wurde.
		/// </summary>
		/// <param name="typRow">Die zu löschende MaschinenTypRow Instanz.</param>
		/// <returns>1, nach erfolgreichem Löschen oder 0, wenn die Zeile nicht gelöscht werden konnte.</returns>
		public int UpdateMaschinenTyp(dsShared.MaschinenTypRow typRow = null)
		{
			if (typRow != null)
			{
				typRow.Delete();
				return this.myMaschinenTypAdapter.Update(typRow);
			}
			return this.myMaschinenTypAdapter.Update(this.mySharedDS.MaschinenTyp);
		}

		/// <summary>
		/// Speichert Änderungen der übergebenen MaschinenTyp Zeile oder, falls keine übergeben wurde,
		/// alle Änderungen in der Datenbank.
		/// </summary>
		/// <param name="typPK"></param>
		/// <returns></returns>
		public int UpdateMaschinenTyp(string typPK) 
		{
			var tRow = this.mySharedDS.MaschinenTyp.FindByUID(typPK);
			if (tRow != null)
			{
				tRow.Delete();
				return this.myMaschinenTypAdapter.Update(tRow);
			}
			return 0;
		}

		#endregion

		#region Presets

		/// <summary>
		/// Erstellt eine neue PresetRow und speichert sie direkt in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public dsShared.PresetRow AddPresetRow() 
		{
			this.AssurePresetInitialized();
			var pRow = this.mySharedDS.Preset.NewPresetRow();
			pRow.UID = this.mySharedDS.Preset.Count + 1;
			pRow.PresetName = "Neues Preset";

			this.mySharedDS.Preset.AddPresetRow(pRow);
			this.UpdatePreset();

			return pRow;
		}

		/// <summary>
		/// Gibt die Preset Datentabelle des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.PresetDataTable GetPresetTable()
		{
			this.AssurePresetInitialized();
			return this.mySharedDS.Preset;
		}

		/// <summary>
		/// Aktualisiert die Tabelle Preset.
		/// </summary>
		/// <returns></returns>
		public int UpdatePreset()
		{
			if (this.mySharedDS.Preset.GetChanges() != null)
			{
				return this.myPresetAdapter.Update(this.mySharedDS.Preset);
			}
			return 0;
		}

		#endregion

		#region Tinte

		/// <summary>
		/// Fügt der Tabelle Tinte eine neue Zeile hinzu.
		/// </summary>
		/// <returns></returns>
		public dsShared.TinteRow AddTinteRow(string tintenTyp = "Tintentyp", string tintenBezeichnung = "Tintenbezeichnung")
		{
			this.AssureTinteInitialized();

			var tRow = this.mySharedDS.Tinte.NewTinteRow();
			tRow.UID = SequentialGuid.NewID().ToString();
			tRow.HerstellerId = "00000000-0000-0000-0000-000000000000";
			tRow.Typ = tintenTyp;
			tRow.Tintenbezeichnung = tintenBezeichnung;

			this.mySharedDS.Tinte.AddTinteRow(tRow);
			this.UpdateTinte(tRow);

			return tRow;
		}

		/// <summary>
		/// Gibt die Tabelle mit allen Tinten des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public dsShared.TinteDataTable GetTinteTable()
		{
			this.AssureTinteInitialized();
			return this.mySharedDS.Tinte;
		}

		/// <summary>
		/// Gibt die TinteRow mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="tintePK"></param>
		/// <returns></returns>
		public dsShared.TinteRow GetTinte(string tintePK)
		{
			this.AssureTinteInitialized();
			return this.mySharedDS.Tinte.FindByUID(tintePK);
		}

		/// <summary>
		/// Löscht die angegebene Zeile aus der Tabelle Tinte.
		/// </summary>
		/// <param name="tinteRow">Die zu löschende dsShared.TinteRow.</param>
		/// <returns></returns>
		public int DeleteTinteRow(dsShared.TinteRow tinteRow) 
		{
			this.AssureTinteInitialized();
			if (tinteRow != null) 
			{
				tinteRow.Delete();
				return this.UpdateTinte(tinteRow);
			}
			return 0;
		}

		/// <summary>
		/// Löscht den Tintentyp mit dem angegebenen Primärschlüssel.
		/// </summary>
		/// <param name="tintePK">Primärschlüssel (GUID) des Tintentyps.</param>
		/// <returns>1, wenn die Zeile erfolgreich gelöscht wurde, sonst 0.</returns>
		public int DeleteTinteRow(string tintePK)
		{
			this.AssureTinteInitialized();
			var tRow = this.mySharedDS.Tinte.FindByUID(tintePK);
			if (tRow != null)
			{
				tRow.Delete();
				return this.UpdateTinte(tRow);
			}
			return 0;
		}

		/// <summary>
		/// Speichert alle Änderungen an der Tabelle Tinte in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateTinte(dsShared.TinteRow oneRow = null)
		{
			if (oneRow != null)
			{
				return this.myTinteAdapter.Update(oneRow);
			}
			return this.myTinteAdapter.Update(this.mySharedDS.Tinte);
		}

		#endregion

		#endregion

		#region private procedures

		void AssureHerstellerInitialized()
		{
			if (this.myHerstellerAdapter == null)
			{
				this.myHerstellerAdapter = new taHersteller();
				this.myHerstellerAdapter.Fill(this.mySharedDS.Hersteller);
			}
		}

		void AssureLinkTypInitialized()
		{
			if (this.myLinkTypAdapter == null)
			{
				this.myLinkTypAdapter = new taLinkTyp();
				this.myLinkTypAdapter.Fill(this.mySharedDS.LinkTyp);
			}
		}

		void AsssureMaschinenModellInitialized()
		{
			if (this.myMaschinenModellAdapter == null)
			{
				this.myMaschinenModellAdapter = new taMaschinenModell();
				this.myMaschinenModellAdapter.Fill(this.mySharedDS.MaschinenModell);
			}
		}

		void AssureMaschinenSerieInitialized() 
		{
			if (this.myMaschinenSerieAdapter == null)
			{
				this.myMaschinenSerieAdapter = new taMaschinenSerie();
				this.myMaschinenSerieAdapter.Fill(this.mySharedDS.MaschinenSerie);
			}
		}

		void AssureMaschinenTypInitialized() 
		{
			if (this.myMaschinenTypAdapter == null)
			{
				this.myMaschinenTypAdapter = new taMaschinenTyp();
				this.myMaschinenTypAdapter.Fill(this.mySharedDS.MaschinenTyp);
			}
		}

		void AssurePresetInitialized()
		{
			if (this.myPresetAdapter == null)
			{
				this.myPresetAdapter = new taPreset();
				this.myPresetAdapter.Fill(this.mySharedDS.Preset);
			}
		}

		void AssureTinteInitialized()
		{
			if (this.myTinteAdapter == null)
			{
				this.myTinteAdapter = new taTinte();
				this.myTinteAdapter.Fill(this.mySharedDS.Tinte);
			}
		}

		#endregion

	}
}
