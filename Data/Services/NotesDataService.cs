using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsNotesTableAdapters;
using Products.Common;

namespace Products.Data.Services
{
	public class NotesDataService
	{

		#region members

		readonly string myCurrentUserPK;

		readonly dsNotes myDS = new dsNotes();
		readonly taNote myNoteAdapter = new taNote();

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der NotesDataService Klasse.
		/// </summary>
		public NotesDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine Liste aller NoteRows für das angegebene LinkedItem zurück.
		/// </summary>
		/// <param name="parentItemPK">Primärschlüssel der mit der Notiz verknüpften Entität.</param>
		/// <returns></returns>
		public IEnumerable<dsNotes.NoteRow> GetNotizRows(string parentItemPK)
		{
			return this.myDS.Note.Where(n => n.LinkedItemId == parentItemPK);
		}

		/// <summary>
		/// Erstellt eine neue NotizRow mit dem angegebenen Ersteller.
		/// </summary>
		/// <param name="linkedItemPK">Primärschlüssel des übergeordneten Elements.</param>
		/// <param name="contactNumber">Interne Nummer des Ansprechpartners.</param>
		/// <param name="linkedItemTypePK">Typ des verknüpften Elements.</param>
		/// <param name="parentItemPK">Verweis auf das übergeordnete Element.</param>
		/// <param name="parentItemTypePK">Primärschlüssel des übergeordneten Elements.</param>
		/// <remarks>
		/// Parameter "parentItemPK" muss entweder zu einem Kunden oder Interessenten gehören.
		/// </remarks>
		/// <returns></returns>
		public dsNotes.NoteRow AddNotizRow(string parentItemPK, string parentItemTypePK, string linkedItemPK, string linkedItemTypePK, string contactNumber = null)
		{
			var now = DateTime.Now;
			var newRow = this.myDS.Note.NewNoteRow();
			if (contactNumber == null) contactNumber = "00001";

			newRow.UID = SequentialGuid.NewID().ToString();
			newRow.ParentItemId = parentItemPK;
			newRow.ParentItemTypeId = parentItemTypePK;
			newRow.ContactNumber = contactNumber;
			newRow.LinkedItemId = linkedItemPK;
			newRow.LinkedItemTypeId = linkedItemTypePK;
			newRow.Subject = "Titel";
			newRow.Body = "Notiztext";
			newRow.AssignedTo = this.myCurrentUserPK;
			newRow.AssignedAt = now;
			newRow.CreatedBy = this.myCurrentUserPK;
			newRow.CreatedAt = now;
			newRow.InactiveFlag = 0;
			newRow.CompletedFlag = 0;

			this.myDS.Note.AddNoteRow(newRow);
			this.myNoteAdapter.Update(newRow);

			return newRow;
		}

		/// <summary>
		/// Löscht die Notiz mit dem angegebenen Primärschlüssel und alle dazu gehörigen Xref Einträge.
		/// </summary>
		/// <param name="notizPK"></param>
		/// <returns>Die Anzahl der insgesamt gelöschten Datensätze.</returns>
		public int DeleteNotizRow(string notizPK)
		{
			// NotizRow löschen
			var nRow = this.myDS.Note.FindByUID(notizPK);
			if (nRow != null) nRow.Delete();
			return this.myNoteAdapter.Update(nRow);
		}

		/// <summary>
		/// Aktualisiert alle neuen, gelöschten und geänderten NotizRows.
		/// </summary>
		/// <returns></returns>
		public int UpdateNotizRows()
		{
			if (this.myDS.Note.GetChanges() != null)
			{
				return this.myNoteAdapter.Update(this.myDS.Note);
			}
			return 0;
		}

		#endregion

		#region private procedures

		private void InitializeData()
		{
			this.myNoteAdapter.Fill(this.myDS.Note);
		}

		#endregion

	}
}
