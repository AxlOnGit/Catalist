using System;
using System.Collections.Generic;
using System.Linq;
using Products.Model.Entities;
using Products.Data;
using Products.Common.Collections;
using System.IO;
using Products.Common.Interfaces;

namespace Products.Model.Services
{
	public class FileLinkService
	{

		#region members

		//private FileLinkDataService myDataService = null;
		readonly Dictionary<string, SBList<FileLink>> myFileLinkDictionary = new Dictionary<string, SBList<FileLink>>();

		#endregion

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
			var serverPath = Products.Common.Global.LinkedFilesPath;
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
		/// Gibt True zurück, wenn die Dateiverknüpfung gelöscht werden kann, ohne dass andere Referenzen 
		/// vor die Pumpe laufen. 
		/// </summary>
		/// <param name="fullName">Pfad und Dateiname der verknüpften Datei.</param>
		/// <returns>True, wenn es maximal eine Verknüpfung zu der angegebenen Datei gibt.</returns>
		public bool GetCanDelete(string fullName)
		{
			return DataManager.FileLinkDataService.CanDelete(fullName);
		}

		/// <summary>
		/// Aktualisiert alle Änderungen an den Dateiverknüpfungen.
		/// </summary>
		public void Update()
		{
			DataManager.FileLinkDataService.Update();
		}

		#endregion

	}
}
