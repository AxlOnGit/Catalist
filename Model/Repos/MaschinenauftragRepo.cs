using System;
using System.Linq;
using Products.Common;
using Products.Model.Entities;

namespace Products.Model.Repos
{
	/// <summary>
	/// Klasse zur Verwaltung geladener <seealso cref="Maschinenauftrag"/> Instanzen.
	/// </summary>
	public class MaschinenauftragRepo
	{
		#region MEMBERS

		readonly SortableBindingList<Maschinenauftrag> myAuftragsListe = new SortableBindingList<Maschinenauftrag>();

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="MaschinenauftragRepo"/> Klasse.
		/// </summary>
		public MaschinenauftragRepo()
		{
			this.InitializeRepo();
		}

		#endregion ### .ctor ###

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Fügt den angegebenen <seealso cref="Maschinenauftrag"/> zum Repository hinzu.
		/// </summary>
		/// <param name="maschinenauftrag"></param>
		public void AddMaschinenauftrag(Maschinenauftrag maschinenauftrag)
		{
			this.myAuftragsListe.Add(maschinenauftrag);
		}

		/// <summary>
		/// Gibt den <seealso cref="Maschinenauftrag"/> für die angegebene
		/// <seealso cref="Kundenmaschine"/> zurück.
		/// </summary>
		/// <param name="kundenmaschine">
		/// Die <seealso cref="Kundenmaschine"/>, des gesuchten Maschinenauftrags.
		/// </param>
		/// .
		/// <returns></returns>
		public Maschinenauftrag GetMaschinenauftrag(Kundenmaschine kundenmaschine)
		{
			return this.myAuftragsListe.FirstOrDefault(a => a.MaschinenId == kundenmaschine.UID);
		}

		/// <summary>
		/// Entfernt den angegebenen <seealso cref="Maschinenauftrag"/> aus dem Repository.
		/// </summary>
		/// <param name="maschinenauftrag">
		/// Die zu entfernende <seealso cref="Maschinenauftrag"/> Instanz.
		/// </param>
		public void RemoveMaschinenauftrag(Maschinenauftrag maschinenauftrag)
		{
			try
			{
				if (this.myAuftragsListe.Contains(maschinenauftrag)) this.myAuftragsListe.Remove(maschinenauftrag);
			}
			catch (Exception)
			{
				throw new OperationCanceledException("Der Maschinenauftrag konnte aus der Auflistung nicht entfernt werden");
			}
		}

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		void InitializeRepo()
		{
			// Die interne Liste mit Maschinenaufträgen für alle Einträge der Tabelle
			// Maschinenauftrag (cpm_maschinenauftrag) füllen.
			foreach (var aRow in Data.DataManager.MachineDataService.GetMaschinenauftragTabelle())
			{
				this.myAuftragsListe.Add(new Maschinenauftrag(aRow));
			}
		}

		#endregion PRIVATE PROCEDURES
	}
}