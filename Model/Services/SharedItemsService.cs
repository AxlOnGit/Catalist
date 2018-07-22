using Products.Common;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;
using System;
using System.Linq;

namespace Products.Model.Services
{
	public class SharedItemsService
	{
		#region members

		readonly SortableBindingList<Linktyp> myLinkTypList = new SortableBindingList<Linktyp>();
		SortableBindingList<Hersteller> myHerstellerList;
		SortableBindingList<Maschinenmodell> myMaschinenModellList;
		SortableBindingList<Maschinenserie> myMaschinenSerieList;
		SortableBindingList<Maschinentyp> myMaschinenTypList;
		SortableBindingList<Tinte> myTinteList;

		/// <summary>
		/// Schreibt neue, geänderte und gelöschte Daten in die Herstellertabelle der Datenbank.
		/// </summary>
		public void UpdateHersteller()
		{
			DataManager.SharedDataService.UpdateHersteller();
		}

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Linktypen des Systems zurück.
		/// </summary>
		public SortableBindingList<Linktyp> LinkTypList { get { return this.myLinkTypList; } }

		/// <summary>
		/// Gibt eine sortierbare Liste aller Hersteller des Systems zurück.
		/// </summary>
		public SortableBindingList<Hersteller> HerstellerList
		{
			get
			{
				if (this.myHerstellerList == null)
				{
					this.myHerstellerList = new SortableBindingList<Hersteller>();
					foreach (var hRow in DataManager.SharedDataService.GetHerstellerTable())
					{
						this.myHerstellerList.Add(new Hersteller(hRow));
					}
				}
				return this.myHerstellerList;
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Maschinenmodellen des Systems zurück.
		/// </summary>
		public SortableBindingList<Maschinenmodell> MaschinenModellList
		{
			get
			{
				if (this.myMaschinenModellList == null)
				{
					this.myMaschinenModellList = new SortableBindingList<Maschinenmodell>();
					foreach (var mRow in DataManager.SharedDataService.GetMaschinenModellTable())
					{
						this.myMaschinenModellList.Add(new Maschinenmodell(mRow));
					}
				}
				return this.myMaschinenModellList;
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Maschinenserien des Systems zurück.
		/// </summary>
		public SortableBindingList<Maschinenserie> MaschinenSerieList
		{
			get
			{
				if (this.myMaschinenSerieList == null)
				{
					this.myMaschinenSerieList = new SortableBindingList<Maschinenserie>();
					foreach (var sRow in DataManager.SharedDataService.GetMaschinenSerieTable())
					{
						this.myMaschinenSerieList.Add(new Maschinenserie(sRow));
					}
				}
				return this.myMaschinenSerieList;
			}
		}

		public void UpdateMaschinenSerien()
		{
			DataManager.SharedDataService.UpdateMaschinenSerie();
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Maschinentypen des Systems zurück.
		/// </summary>
		public SortableBindingList<Maschinentyp> MaschinenTypList
		{
			get
			{
				if (this.myMaschinenTypList == null)
				{
					this.myMaschinenTypList = new SortableBindingList<Maschinentyp>();
					foreach (var tRow in DataManager.SharedDataService.GetMaschinenTypTable())
					{
						this.myMaschinenTypList.Add(new Maschinentyp(tRow));
					}
				}
				return this.myMaschinenTypList;
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste mit allen Tintentypen des Systems zurück.
		/// </summary>
		public SortableBindingList<Tinte> TinteList
		{
			get
			{
				if (this.myTinteList == null)
				{
					this.myTinteList = new SortableBindingList<Tinte>();
					foreach (var tRow in DataManager.SharedDataService.GetTinteTable())
					{
						this.myTinteList.Add(new Tinte(tRow));
					}
				}
				return this.myTinteList;
			}
		}

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt einen neue Instanz der SharedItemsService Klasse.
		/// </summary>
		public SharedItemsService()
		{
			this.InitializeLinkTypeList();
		}

		#endregion ### .ctor ###

		#region public procedures

		#region LinkTyp

		/// <summary>
		/// Gibt den LinkTyp mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="linkTypePK">Primärschlüssel des gesuchten LinkTyps.</param>
		/// <returns></returns>
		internal Linktyp GetLinkTypeByPK(string linkTypePK)
		{
			return this.LinkTypList.FirstOrDefault(l => l.UID == linkTypePK);
		}

		/// <summary>
		/// Gibt den LinkTyp mit der angebenen Bezeichnung zurück.
		/// </summary>
		/// <param name="linkTypeName"></param>
		/// <returns></returns>
		public Linktyp GetLinkTypeByName(string linkTypeName)
		{
			return this.LinkTypList.FirstOrDefault(l => l.Bezeichnung == linkTypeName);
		}

		/// <summary>
		/// Ermittelt den Objekttyp des angegebenen ILinkedItem und gibt den entsprechenden
		/// Linktyp zurück.
		/// </summary>
		/// <param name="item">Das Element dessen Linktyp gesucht wird.</param>
		/// <returns></returns>
		public Linktyp GetLinkTypeByEntity(ILinkedItem item)
		{
			return this.GetLinkTypeByName(item.LinkTypBezeichnung);
		}

		#endregion LinkTyp

		#region Hersteller

		/// <summary>
		/// Erstellt einen neuen Hersteller.
		/// </summary>
		/// <param name="firma"></param>
		/// <returns></returns>
		public Hersteller AddHersteller(string firma = "Firmenname")
		{
			var hersteller = new Hersteller(DataManager.SharedDataService.AddHerstellerRow(firma));
			this.HerstellerList.Add(hersteller);

			return hersteller;
		}

		/// <summary>
		/// Gibt den Hersteller mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="herstellerPK"></param>
		/// <returns></returns>
		internal Hersteller GetHersteller(string herstellerPK)
		{
			return this.HerstellerList.FirstOrDefault(h => h.UID == herstellerPK);
		}

		#endregion Hersteller

		#region MaschinenModell

		/// <summary>
		/// Erstellt ein neues Maschinenmodell.
		/// </summary>
		public Maschinenmodell AddMaschinenModell()
		{
			var modell = new Maschinenmodell(DataManager.SharedDataService.AddMaschinenModellRow());
			this.MaschinenModellList.Add(modell);

			return modell;
		}

		/// <summary>
		/// Gibt das Maschinenmodell mit dem angegebenen Prinärschlüssel zurück.
		/// </summary>
		/// <param name="modellPK"></param>
		/// <returns></returns>
		internal Maschinenmodell GetMaschinenModell(string modellPK)
		{
			return this.MaschinenModellList.FirstOrDefault(m => m.UID == modellPK);
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Maschinenmodelle der angegebenen
		/// Maschinenserie zurück.
		/// </summary>
		/// <param name="maschinenserie"></param>
		/// <returns></returns>
		internal SortableBindingList<Maschinenmodell> GetMaschinenModellList(Maschinenserie maschinenserie)
		{
			var list = new SortableBindingList<Maschinenmodell>();
			foreach (var modell in this.MaschinenModellList.Where(m => m.ModellSerieId == maschinenserie.UID))
			{
				list.Add(modell);
			}
			return list;
		}

		/// <summary>
		/// Löscht das angegebene <seealso cref="Maschinenmodell"/>.
		/// </summary>
		/// <param name="maschinenModell">Das zu löschende <seealso cref="Maschinenmodell"/>.</param>
		public void DeleteMaschinenModell(Maschinenmodell maschinenModell)
		{
			bool modelRemoved = false;
			if (maschinenModell.CanDelete)
			{
				if (this.myMaschinenModellList.Contains(maschinenModell))
				{
					this.myMaschinenModellList.Remove(maschinenModell);
					modelRemoved = true;
				}
				if (!DataManager.SharedDataService.DeleteMaschinenModellRow(maschinenModell.UID).Equals(1) && modelRemoved)
				{
					this.myMaschinenModellList.Add(maschinenModell);
				}
			}
		}

		/// <summary>
		/// Aktualisiert die Tabelle MaschinenModell.
		/// </summary>
		/// <returns></returns>
		public int UpdateMaschinenModell()
		{
			return DataManager.SharedDataService.UpdateMaschinenModell();
		}

		#endregion MaschinenModell

		#region MaschinenSerie

		/// <summary>
		/// Erstellt eine neue Maschinenserie.
		/// </summary>
		/// <returns></returns>
		public Maschinenserie AddMaschinenSerie()
		{
			var serie = new Maschinenserie(DataManager.SharedDataService.AddMaschinenSerieRow());
			if (serie != null) this.MaschinenSerieList.Add(serie);

			return serie;
		}

		/// <summary>
		/// Gibt die Instanz der MaschinenSerie mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="seriePK"></param>
		/// <returns></returns>
		public Maschinenserie GetModellSerie(string seriePK)
		{
			return this.MaschinenSerieList.FirstOrDefault(s => s.UID == seriePK);
		}

		#endregion MaschinenSerie

		#region MaschinenTyp

		/// <summary>
		/// Erstellt einen neuen Maschinentyp.
		/// </summary>
		/// <param name="bezeichnung"></param>
		/// <returns></returns>
		public Maschinentyp AddMaschinenTyp(string bezeichnung = "Bezeichnung")
		{
			var typ = new Maschinentyp(DataManager.SharedDataService.AddMaschinenTypRow(bezeichnung));
			this.MaschinenTypList.Add(typ);

			return typ;
		}

		/// <summary>
		/// Gibt das MaschinenModell mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="maschinenTypPK"></param>
		/// <returns></returns>
		internal Maschinentyp GetMaschinenTyp(string maschinenTypPK)
		{
			return this.MaschinenTypList.FirstOrDefault(t => t.UID == maschinenTypPK);
		}

		#endregion MaschinenTyp

		#region Tinte

		/// <summary>
		/// Erstellt eine neue Tinte
		/// </summary>
		/// <returns></returns>
		public Tinte AddTinte()
		{
			var tRow = DataManager.SharedDataService.AddTinteRow();
			if (tRow != null)
			{
				var newTinte = new Tinte(tRow);
				if (newTinte != null)
				{
					this.TinteList.Add(newTinte);
				}
				return newTinte;
			}
			return null;
		}

		/// <summary>
		/// Gibt die Tinte mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="tintePK">Primärschlüssel (GUID) der Tinte.</param>
		/// <returns></returns>
		public Tinte GetTinte(string tintePK)
		{
			return this.TinteList.FirstOrDefault(t => t.UID == tintePK);
		}

		/// <summary>
		/// Aktualisiert alle Tinten des Systems.
		/// </summary>
		public int UpdateTinteList()
		{
			return DataManager.SharedDataService.UpdateTinte();
		}

		#endregion Tinte

		#endregion public procedures

		#region private procedures

		private void InitializeLinkTypeList()
		{
			foreach (var lRow in DataManager.SharedDataService.GetLinkTypTable())
			{
				this.myLinkTypList.Add(new Linktyp(lRow));
			}
		}

		#endregion private procedures
	}
}