using System;
using System.Collections.Generic;
using System.Linq;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class NotesService
	{

		#region events

		//public event EventHandler<NoteCreatedEventArgs> NoteCreated;
		//public event EventHandler<NoteDeletedEventArgs> NoteDeliting;

		#endregion

		#region members

		readonly string myCurrentUserPK = null;
		readonly List<Notiz> myNotesPool = new List<Notiz>();
		readonly Dictionary<string, SBList<Notiz>> myNotesDict = new Dictionary<string, SBList<Notiz>>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der NotesService Klasse.
		/// </summary>
		public NotesService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		public Notiz AddNote(Builder.NoteBuilder noteBuilder)
		{
			Notiz note = noteBuilder.Build();
			SBList<Notiz> list = this.GetNotesList(noteBuilder.LinkedItem.Key, noteBuilder.LinkedItem.LinkTypeId);
			list.Add(note);

			return note;
		}

		public SBList<Notiz> GetNotesList(string linkedItemPK, string linkedItemTypePK)
		{
			// Bereits geladene Notizen zurückgeben.
			if (this.myNotesDict.ContainsKey(linkedItemPK)) return this.myNotesDict[linkedItemPK];

			// Wir haben die Notizen des Kunden oder Interessenten noch nicht geladen, machen wir jetzt ...
			var nRows = DataManager.NotesDataService.GetNotizRows(linkedItemPK);
			SBList<Notiz> nList = new SBList<Notiz>();
			foreach (var nRow in nRows)
			{
				nList.Add(new Notiz(nRow));
			}
			this.myNotesDict.Add(linkedItemPK, nList);

			return nList;
		}

		/// <summary>
		/// Löscht die angegebene Notiz.
		/// </summary>
		/// <param name="notiz">Die zu löschende Notiz.</param>
		/// <returns></returns>
		public int DeleteNote(Notiz notiz)
		{
			int result = 0;
			if (notiz.GetCanDelete()) // Wenn Notiz gelöscht werden kann (keine Dateiverknüpfungen etc.)
			{
				// Abonnenten informieren, dass die Notiz gelöscht wird.
				//if (this.NoteDeliting != null)
				//{
				//  NoteDeliting(this, new NoteDeletedEventArgs(notiz, notiz.LinkedItemId));
				//}

				// Notiz aus dem Dictionary löschen.
				if (this.myNotesDict.ContainsKey(notiz.LinkedItemId) && this.myNotesDict[notiz.LinkedItemId].Contains(notiz))
				{
					this.myNotesDict[notiz.LinkedItemId].Remove(notiz);
				}
				// Datenbankzeile löschen
				result = DataManager.NotesDataService.DeleteNotizRow(notiz.UID);
			}
			return result;
		}

		/// <summary>
		/// Aktualisiert alle neuen, gelöschten und geänderten Notizen.
		/// </summary>
		public void UpdateNotes()
		{
			DataManager.NotesDataService.UpdateNotizRows();
		}

		#endregion

		#region private procedures
		#endregion

		#region SUB CLASSES

		public class NoteCreatedEventArgs : EventArgs
		{

			public Notiz Notiz { get; private set; }
			public string LinkedItemPK { get; private set; }

			public NoteCreatedEventArgs(Notiz notiz, string linkedItemPK)
			{
				this.Notiz = notiz;
				this.LinkedItemPK = linkedItemPK;
			}
		}

		public class NoteDeletedEventArgs : EventArgs
		{
			public Notiz Note { get; private set; }
			public string LinkedItemPK { get; private set; }

			public NoteDeletedEventArgs(Notiz note, string linkedItemPK)
			{
				this.Note = note;
				this.LinkedItemPK = linkedItemPK;
			}
		}

		#endregion

	}
}
