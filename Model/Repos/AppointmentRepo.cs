using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Common.Interfaces;
using Products.Model.Entities;

namespace Products.Model.Repos
{
	public class AppointmentRepo
	{
		#region MEMBERS

		private readonly string myCurrentUserPK;
		private readonly Dictionary<string, SortableBindingList<Appointment>> myAppointmentDictionary = new Dictionary<string, SortableBindingList<Appointment>>();
		private readonly Dictionary<string, SortableBindingList<ILinkedItem>> myLinkedItemsDictionary = new Dictionary<string, SortableBindingList<ILinkedItem>>();

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AppointmentRepo"/> Repository Klasse.
		/// </summary>
		/// <param name="currentUserPK"></param>
		public AppointmentRepo(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion ### .ctor ###
	}
}