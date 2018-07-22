using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class FileLinkService
	{
		#region members

		//private FileLinkDataService myDataService = null;
		readonly Dictionary<string, SBList<FileLink>> myFileLinkDictionary = new Dictionary<string, SBList<FileLink>>();

		#endregion members

		#region public procedures

		/// <summary>
		/// Erzeugt einen neuen Dateinamen für Dateien, die im Serververzeichnis für
		/// verknüpfte Dateien gespeichert werden sollen.
		/// </summary>
		/// <param name="forFile"></param>
		/// <returns></returns>
		public FileInfo CopyFileToServerLinkFolder(string forFile)
		{
			var originalFileInfo = new FileInfo(forFile);
			var now = DateTime.Now;
			var serverPath = CatalistRegistry.Application.LinkedFilesPath;
			var newFilename = string.Format("{0}-{1}-{2}_{3}.{4}.{5}{6}",
				now.ToString("yyyy"),
				now.ToString("MM"),
				now.ToString("dd"),
				now.ToString("HH"),
				now.ToString("mm"),
				now.ToString("ss"),
				originalFileInfo.Extension);
			var newFileInfo = new FileInfo(Path.Combine(serverPath, newFilename));
			originalFileInfo.CopyTo(newFileInfo.FullName);
			return newFileInfo;
		}

		/// <summary>
		/// Erstellt eine neue Verknüpfung zwischen einer Datei und einer ILinkedItem Instanz.
		/// </summary>
		/// <param name="fileInfo">FileInfo Instanz der zu verknüpfenden Datei.</param>
		/// <param name="linkedItem">ILinkedItem Instanz des verknüpfenden Elements.</param>
		/// <param name="keepSourceFile">Wenn false, wird die Originaldatei gelöscht.</param>
		/// <returns></returns>
		public FileLink AddFileLink(FileInfo fileInfo, ILinkedItem linkedItem, bool keepSourceFile = true)
		{
			var builder = new Builder.FileLinkBuilder(DataManager.FileLinkDataService);
			builder
				.SetSourceFile(fileInfo)
				.SetLinkedItem(linkedItem)
				.SetKeepSourceFile(keepSourceFile);
			var newFileLink = builder.Build();
			if (this.myFileLinkDictionary.ContainsKey(linkedItem.Key))
			{
				this.myFileLinkDictionary[linkedItem.Key].Add(newFileLink);
			}
			else
			{
				var list = new SBList<FileLink>();
				list.Add(newFileLink);
				this.myFileLinkDictionary.Add(linkedItem.Key, list);
			}
			return newFileLink;
		}

		/// <summary>
		/// Gibt eine Liste aller Dateiverknüpfungen für das angegebene Element zurück.
		/// </summary>
		/// <param name="linkedItemPK">Primärschlüssel des verknüpften Elements.</param>
		/// <returns></returns>
		public SBList<FileLink> GetFileLinkList(string linkedItemPK)
		{
			if (this.myFileLinkDictionary.ContainsKey(linkedItemPK)) return this.myFileLinkDictionary[linkedItemPK];

			var list = new SBList<FileLink>();
			var fRows = DataManager.FileLinkDataService.GetFileLinkRows(linkedItemPK);
			if (fRows != null)
			{
				foreach (var fRow in fRows)
				{
					if (list.Count(f => f.FullName == fRow.FullName) == 0)
					{
						list.Add(new FileLink(fRow));
					}
				}
				if (list.Count > 0)
				{
					this.myFileLinkDictionary.Add(linkedItemPK, list);
					return list;
				}
			}
			return null;
		}

		/// <summary>
		/// Löscht die Dateiverknüpfung für das angegebene ILinkedItem.
		/// </summary>
		/// <param name="fileInfo">FileInfo Instanz der verknüpften Datei.</param>
		/// <param name="linkedItem">Das mit der Datei verknüpfte ILinkedItem.</param>
		public void DeleteFileLink(FileInfo fileInfo, ILinkedItem linkedItem, bool deleteFile = false)
		{
			if (this.myFileLinkDictionary.ContainsKey(linkedItem.Key))
			{
				var link = this.myFileLinkDictionary[linkedItem.Key].FirstOrDefault(f => f.FullName == fileInfo.FullName);
				if (link != null)
				{
					this.myFileLinkDictionary[linkedItem.Key].Remove(link);
				}
			}
			DataManager.FileLinkDataService.DeleteFileLink(fileInfo);
			if (deleteFile) fileInfo.Delete();
		}

		/// <summary>
		/// Gibt True zurück, wenn die Dateiverknüpfung gelöscht werden kann, ohne dass
		/// andere Referenzen vor die Pumpe laufen.
		/// </summary>
		/// <param name="fullName">Pfad und Dateiname der verknüpften Datei.</param>
		/// <returns>
		/// True, wenn es maximal eine Verknüpfung zu der angegebenen Datei gibt.
		/// </returns>
		public bool GetCanDelete(string fullName) => DataManager.FileLinkDataService.CanDelete(fullName);

		public int MoveFilesToMachineFolders()
		{
			int counter = 0;

			var ft = DataManager.FileLinkDataService.GetServerMachineLinkTable();
			foreach (var fRow in ft)
			{
				var fullName = fRow.FullName;
				var targetPath = fRow.Dateipfad;
				var title = fRow.Title;
				var ext = fRow.Extension;

				var sourceFile = new FileInfo(fullName);
				var targetFolder = new DirectoryInfo(targetPath);

				// Prüfen, ob sowohl Ursprungsdatei auf dem Server und Maschinenordner auf
				// der NASE existieren.
				if (!sourceFile.Exists)
				{
					var logEntry = $"Datei '{sourceFile}' fehlt. Ich lösche die Verknüpfungen in der Datenbank.";
					Common.Services.LogService.WriteLogEntry(logEntry);
					var kundenmaschine = RepoManager.KundenmaschinenRepository.GetKundenmaschine(fRow.LinkedItemId);
					this.DeleteFileLink(sourceFile, kundenmaschine);
					continue;
				}

				// Ursprungsdatei auf die NASE kopieren.
				try
				{
					if (!targetFolder.Exists) targetFolder.Create();  // Ordner erstellen, falls er noch nicht existiert.
					var targetFileName = $"{title}.{ext}";
					var targetFullName = Path.Combine(targetPath, targetFileName);

					// Kopieren ...
					var copiedFile = sourceFile.CopyTo(targetFullName, true);

					// ... und dann die Quelldatei löschen.
					if (copiedFile.Exists) sourceFile.Delete();

					// Schlussendlich die Spuren der Datei in der Datenbank löschen.
					var kundenmaschine = RepoManager.KundenmaschinenRepository.GetKundenmaschine(fRow.LinkedItemId);
					this.DeleteFileLink(sourceFile, kundenmaschine);

					counter++;
				}
				catch (Exception)
				{
					throw;
				}
			}
			return counter;
		}

		/// <summary>
		/// Aktualisiert alle Änderungen an den Dateiverknüpfungen.
		/// </summary>
		public void Update()
		{
			DataManager.FileLinkDataService.Update();
		}

		#endregion public procedures
	}
}