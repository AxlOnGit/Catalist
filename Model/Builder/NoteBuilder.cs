using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Model.Entities;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Builder
{
	public class NoteBuilder
	{

		#region internal properties

		/// <summary>
		/// Die der Notiz übergeordnete Entität.
		/// </summary>
		/// <remarks>
		/// Möglich sind: Kunde, Interessent, Lieferant und Mitarbeiter.
		/// </remarks>
		internal ILinkedItem ParentItem { get; private set; }

		/// <summary>
		/// Die mit der Notiz verknüpfte Entität.
		/// </summary>
		/// <remarks>
		/// Möglich: Kunde, Interessent
		/// </remarks>
		internal ILinkedItem LinkedItem { get; private set; }

		/// <summary>
		/// Die Nummer des Ansprechpartners dieser Notiz, wenn ParentItem vom Typ Kunde ist.
		/// </summary>
		internal string ContactNumber { get; private set; }

		internal string ParentItemTypeId { get; private set; }

		internal string LinkedItemTypeId { get; private set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der NoteBuilder Klasse.
		/// </summary>
		/// <param name="parentItem">Das übergeordnete ILinkedItem (Kunde, Interessent, Lieferant oder Mitarbeiter.</param>
		/// <param name="linkedItem">Das ILinkedItem, das mit der Notiz verknüpft werden soll.</param>
		/// <param name="contactNumber">Die Nummer eines Ansprechpartners bei dem übergeordneten Kunden.</param>
		public NoteBuilder(ILinkedItem parentItem, ILinkedItem linkedItem, string contactNumber = null)
		{
			this.ParentItem = parentItem;
			this.LinkedItem = linkedItem;
			this.ContactNumber = contactNumber;
		}

		#endregion

		#region public procedures

		public NoteBuilder SetParentItem(ILinkedItem parentItem)
		{
			this.ParentItem = parentItem;
			return this;
		}

		public NoteBuilder SetLinkedItem(ILinkedItem linkedItem)
		{
			this.LinkedItem = linkedItem;
			return this;
		}

		public NoteBuilder SetContactNumber(string contactNumber)
		{
			this.ContactNumber = contactNumber;
			return this;
		}

		/// <summary>
		/// Erstellt die neue Notiz mit den eingestellten Eigenschaften.
		/// </summary>
		/// <returns>Die <seealso cref="Products.Model.Entities.Notiz"/> Instanz der neuen Notiz.</returns>
		public Notiz Build()
		{
			string currentUserPK = ModelManager.UserService.CurrentUser.UID;
			var nRow = DataManager.NotesDataService.AddNotizRow(this.ParentItem.Key, this.ParentItem.LinkTypeId, this.LinkedItem.Key, this.LinkedItem.LinkTypeId, this.ContactNumber);

			var note = new Notiz(nRow);
			return note;
		}

		#endregion

	}
}
