using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class ProspectService
	{

		#region members

		private SortableBindingList<Interessent> myInteressentList = null;

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ProspectService Klasse.
		/// </summary>
		public ProspectService()
		{
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt dem System einen neuen Interessenten hinzu.
		/// </summary>
		/// <returns></returns>
		public Interessent AddInteressent()
		{
			dsProspects.InteressentRow iRow = DataManager.ProspectDataService.AddInteressentRow(ModelManager.UserService.CurrentUser.UID);
			if (iRow != null)
			{
				Interessent newInteressent = new Interessent(iRow);
				this.GetInteressentenList().Add(newInteressent);
				return newInteressent;
			}
			return null;
		}

		/// <summary>
		/// Gibt eine sortierbare Liste aller Interessenten des Systems zurück.
		/// </summary>
		/// <returns></returns>
		public SortableBindingList<Interessent> GetInteressentenList()
		{
			if (this.myInteressentList == null)
			{
				this.myInteressentList = new SortableBindingList<Interessent>();
				foreach (var iRow in DataManager.ProspectDataService.GetInteressentenTable())
				{
					this.myInteressentList.Add(new Interessent(iRow));
				}
			}
			return this.myInteressentList;
		}

		/// <summary>
		/// Gibt den Interessenten mit dem angegebenen Primärschlüssel zurück.
		/// </summary>
		/// <param name="interessentPK"></param>
		/// <returns></returns>
		public Interessent GetInteressent(string interessentPK)
		{
			return this.GetInteressentenList().FirstOrDefault(i => i.UID == interessentPK);
		}

		/// <summary>
		/// Speichert alle Änderungen der Tabelle Interessent in der Datenbank.
		/// </summary>
		/// <returns></returns>
		public int UpdateInteressenten()
		{
			return DataManager.ProspectDataService.UpdateInteressent();
		}

		#endregion

		#region private procedures
		#endregion

	}
}
