using System;
using System.IO;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Services;
using Products.Model.Entities;

namespace Products.Model.Builder
{
	public class FileLinkBuilder
	{

		#region members

		private FileLinkDataService myDataService = null;

		#endregion

		#region public properties

		public FileInfo SourceFile { get; private set; }
		public DirectoryInfo DestinationDirectory { get; }
		public ILinkedItem LinkedItem { get; private set; }
		public bool myKeepSourceFile { get; private set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der FileLinkBuilder Klasse.
		/// </summary>
		/// <param name="fileLinkDataService"></param>
		public FileLinkBuilder(FileLinkDataService fileLinkDataService)
		{
			this.myDataService = fileLinkDataService;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt die zu verknüpfende Datei fest.
		/// </summary>
		/// <param name="sourceFile">FileInfo Instanz der zu verknüpfenden Date.</param>
		/// <returns></returns>
		public FileLinkBuilder SetSourceFile(FileInfo sourceFile)
		{
			this.SourceFile = sourceFile;
			return this;
		}

		/// <summary>
		/// Legt das angegebene ILinkedItem für die Dateiverknüpfung fest.
		/// </summary>
		/// <param name="linkedItem"></param>
		/// <returns></returns>
		public FileLinkBuilder SetLinkedItem(ILinkedItem linkedItem)
		{
			this.LinkedItem = linkedItem;
			return this;
		}

		/// <summary>
		/// Legt fest, ob die Quelldatei nach dem Kopieren gelöscht werden soll oder nicht.
		/// </summary>
		/// <param name="keepSourceFile"></param>
		/// <returns></returns>
		public FileLinkBuilder SetKeepSourceFile(bool keepSourceFile)
		{
			this.myKeepSourceFile = keepSourceFile;
			return this;
		}

		/// <summary>
		/// Erzeugt die Dateiverknüpfung mit den eingestellten Werten.
		/// </summary>
		/// <returns></returns>
		public FileLink Build()
		{
			try
			{
				if (this.LinkedItem == null) throw new ArgumentException("Es muss ein ILinkedItem angegeben werden.");
				if (this.SourceFile == null) throw new ArgumentException("Es muss die zu verknüpfende Datei angegeben werden.");

				string serverDir = CatalistRegistry.Application.LinkedFilesPath;
				var oldFileName = this.SourceFile.Name;
				string newFileName = string.Format("{0}{1}", DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss"), this.SourceFile.Extension);
				string newFullName = Path.Combine(serverDir, newFileName);
				var newFileInfo = this.SourceFile.CopyTo(newFullName, true);
				var fRow = DataManager.FileLinkDataService.AddFileLinkRows(oldFileName, newFileInfo, this.LinkedItem.Key, this.LinkedItem.LinkTypeId);
				if (!this.myKeepSourceFile) this.SourceFile.Delete();
				return new FileLink(fRow);
			}
			catch (System.IO.IOException ex)
			{
				var msg = string.Format("Beim Erstellen der Dateiverknüpfung gab es einen Fehler:{0}{1}", Environment.NewLine, ex.Message);
				throw new ApplicationException(msg);
			}
		}

		#endregion

	}
}
