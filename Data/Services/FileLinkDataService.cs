﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Products.Data.Datasets;
using Products.Data.Datasets.dsFileLinkTableAdapters;

namespace Products.Data.Services
{
	public class FileLinkDataService
	{
		#region events

		public event EventHandler<FileLinkRowsCreatedEventArgs> FileLinkRowsCreated;

		#endregion events

		#region members

		readonly string myCurrentUserPK;
		readonly dsFileLink myDS = new dsFileLink();
		readonly taFileLink myFileLinkAdapter = new taFileLink();
		readonly taFileLinkXref myFileLinkXrefAdapter = new taFileLinkXref();
		readonly taFileLinkQueries myFileLinkQueryAdapter = new taFileLinkQueries();

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der FileLinkDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK"></param>
		public FileLinkDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region public procedures

		/// <summary>
		/// Fügt der Datenbank je eine DateiLinkRow und eine DateiLinkXrefRow für eine neue
		/// Dateiverknüpfung hinzu.
		/// </summary>
		/// <param name="fileInfo"></param>
		/// <param name="linkedItemPK"></param>
		/// <param name="linkedItemTypePK"></param>
		public dsFileLink.FileLinkRow AddFileLinkRows(string oldFilename, FileInfo fileInfo, string linkedItemPK, string linkedItemTypePK)
		{
			dsFileLink.FileLinkRow fRow = null;
			dsFileLink.FileLinkXrefRow xRow = null;

			// Wenn es für diese Datei noch keine FileLinkRow gibt ...
			if (this.myDS.FileLink.Count(f => f.FullName == fileInfo.FullName) <= 0)
			{
				fRow = this.myDS.FileLink.NewFileLinkRow();
				fRow.FullName = fileInfo.FullName;
				fRow.FileTitle = oldFilename;
				fRow.Description = fileInfo.Name;
				fRow.Extension = fileInfo.Extension.ToUpper();
				this.myDS.FileLink.AddFileLinkRow(fRow);

				this.myFileLinkAdapter.Update(fRow);
			}

			// Wenn es für diese Datei und diese Entität noch keine FileLinkXrefRow gibt ...
			if (this.myDS.FileLinkXref.Count(x => x.FullName == fileInfo.FullName & x.LinkedItemId == linkedItemPK) <= 0)
			{
				xRow = this.myDS.FileLinkXref.NewFileLinkXrefRow();
				xRow.ChangedBy = this.myCurrentUserPK;
				xRow.CreatedBy = this.myCurrentUserPK;
				xRow.FullName = fileInfo.FullName;
				xRow.LinkedItemId = linkedItemPK;
				xRow.LinkedItemTypeId = linkedItemTypePK;
				this.myDS.FileLinkXref.AddFileLinkXrefRow(xRow);

				this.myFileLinkXrefAdapter.Update(xRow);
			}

			// Abonnenten über die hinzugefügte Dateiverknüpfung informieren.
			if (FileLinkRowsCreated != null)
			{
				FileLinkRowsCreated(this, new FileLinkRowsCreatedEventArgs(fRow, xRow));
			}
			return fRow;
		}

		/// <summary>
		/// Gibt eine Liste aller FileLinkRows zurück, für die angegebene Entität zurück.
		/// </summary>
		/// <param name="linkedItemPK"></param>
		/// <returns></returns>
		public List<dsFileLink.FileLinkRow> GetFileLinkRows(string linkedItemPK)
		{
			var list = new List<dsFileLink.FileLinkRow>();
			var xRefs = this.myDS.FileLinkXref.Where(x => x.LinkedItemId == linkedItemPK);
			foreach (var xref in xRefs)
			{
				var fLink = this.myDS.FileLink.FirstOrDefault(f => f.FullName == xref.FullName);
				if (fLink != null) list.Add(fLink);
			}

			if (list.Count > 0) return list;
			return null;
		}

		/// <summary>
		/// Gibt True zurück, wenn es maximal eine Verknüpfung zu der angegebenen Datei gibt.
		/// </summary>
		/// <param name="fullName">Pfad und Dateiname der verknüpften Datei.</param>
		/// <returns>True, wenn maximal eine Verknüpfung existiert.</returns>
		public bool CanDelete(string fullName)
		{
			return this.myDS.FileLinkXref.Count(x => x.FullName == fullName) <= 1;
		}

		/// <summary>
		/// Löscht die FileLinkRow und alle XrefRows für die angegebene Datei.
		/// </summary>
		/// <param name="fileInfo"></param>
		public void DeleteFileLink(FileInfo fileInfo)
		{
			// Xrefs löschen
			var xRefs = this.myDS.FileLinkXref.Where(x => x.FullName == fileInfo.FullName);
			foreach (var xref in xRefs)
			{
				xref.Delete();
			}

			// FileLinkRows löschen (falls tatsächlich mehrere existieren
			var fLinks = this.myDS.FileLink.Where(f => f.FullName == fileInfo.FullName);
			foreach (var flink in fLinks)
			{
				flink.Delete();
			}
			this.Update();
		}

		/// <summary>
		/// Tabelle mit Infos zu den Dateien auf dem Server, die mit Maschinen verknüpft sind.
		/// </summary>
		/// <returns></returns>
		public dsFileLink.ServerMachineLinkDataTable GetServerMachineLinkTable()
		{
			var adapter = new taServerMachineLink();
			return adapter.GetData();
		}

		/// <summary>
		/// Aktualisiert alle Änderungen der FileLink- und FileLinkXref-Tabellen.
		/// </summary>
		/// <returns></returns>
		public int Update()
		{
			int result = 0;
			if (this.myDS.FileLink.GetChanges() != null) result = this.myFileLinkAdapter.Update(this.myDS.FileLink);
			if (this.myDS.FileLinkXref.GetChanges() != null) result += this.myFileLinkXrefAdapter.Update(this.myDS.FileLinkXref);

			return result;
		}

		#endregion public procedures

		#region private procedures

		private void InitializeData()
		{
			this.myFileLinkAdapter.Fill(this.myDS.FileLink);
			this.myFileLinkXrefAdapter.Fill(this.myDS.FileLinkXref);
		}

		#endregion private procedures

		#region sub classes

		public class FileLinkRowsCreatedEventArgs : EventArgs
		{
			public dsFileLink.FileLinkRow FileLinkRow { get; private set; }

			public dsFileLink.FileLinkXrefRow FileLinkXrefRow { get; private set; }

			/// <summary>
			/// Erzeugt eine neue Instanz der FileLinkRowsCreatedEventArgs Klasse.
			/// </summary>
			/// <param name="fileLinkRow">Die neue erstellte FileLinkRow.</param>
			/// <param name="fileLinkXrefRow">Die neu erstellte FileLinkXrefRow.</param>
			public FileLinkRowsCreatedEventArgs(dsFileLink.FileLinkRow fileLinkRow, dsFileLink.FileLinkXrefRow fileLinkXrefRow)
			{
				this.FileLinkRow = fileLinkRow;
				this.FileLinkXrefRow = fileLinkXrefRow;
			}
		}

		#endregion sub classes
	}
}