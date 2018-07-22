using Products.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Products.Model.Services
{
	public class MachinePathCreatorService
	{
		#region PUBLIC PROCEDURES

		/// <summary>
		/// Prüft, ob der Dateipfad für die angegebene Kundenmaschine vorhanden und korrekt
		/// ist und erstellt ihn gegebenenfalls.
		/// </summary>
		/// <param name="kundenmaschine"></param>
		/// <returns></returns>
		public string CheckOrCreateMachinePath(Kundenmaschine kundenmaschine)
		{
			// zunächst den korrekten Maschinenpfad zusammenbauen
			var sn = kundenmaschine.Seriennummer.Replace("/", "_").Replace("?", "-");
			var model = kundenmaschine.Modellbezeichnung.Replace("/", "_").Replace(@"\", "_").Replace("?", "");
			var ownerName = kundenmaschine.CurrentOwner.Matchcode.Replace("/", "_");
			var ordnerMaschine = $"{model}_{sn} ({ownerName})";
			var ordnerSerie = kundenmaschine.Maschinenserie.Dateipfad;
			var ordnerKorrekt = Path.Combine(ordnerSerie, ordnerMaschine);

			var ordnerInDB = kundenmaschine.Dateipfad;

			// Prüfen, ob es Abweichungen zwischen dem Dateipfad in der Datenbank und dem
			// korrekten Dateipfad gibt. Ist immer der Fall, wenn in der DB nichts
			// eingetragen ist oder es Unterschiede gibt.
			if (string.IsNullOrEmpty(ordnerInDB) || !ordnerKorrekt.Equals(ordnerInDB, StringComparison.CurrentCultureIgnoreCase))
			{
				// Wenn der in der DB eingetragene Ordner existiert, sämtliche enthaltene
				// Ordner, Unterordner samt Dateien in den korrekten neuen Ordner kopieren.
				try
				{
					if (!Directory.Exists(ordnerKorrekt)) Directory.CreateDirectory(ordnerKorrekt);
					if (Directory.Exists(ordnerInDB)) this.DirectoryCopy(ordnerInDB, ordnerKorrekt, true, true);
				}
				catch (Exception)
				{
					throw;
				}
			}
			return ordnerKorrekt;
		}

		#endregion PUBLIC PROCEDURES

		#region PRIVATE PROCEDURES

		void DirectoryCopy(string sourcePath, string destPath, bool moveItBaby = false, bool copySubfolders = true)
		{
			// Alle Unterverzeichnisse des angegebenen Quellpfads ermitteln.
			var sourceDirInfo = new DirectoryInfo(sourcePath);
			if (!Directory.Exists(sourcePath) | !Directory.Exists(destPath))
				throw new DirectoryNotFoundException($"Einen der Ordner '{sourcePath}' oder '{destPath}' gibt es nicht.");

			// Alle Dateien des Quellpfads in den neuen korrekten Ordner kopieren.
			var files = sourceDirInfo.GetFiles();
			foreach (var file in files)
			{
				var pathFolder = Path.Combine(destPath, file.Name);
				if (moveItBaby)
				{
					file.MoveTo(pathFolder);
				}
				else
				{
					file.CopyTo(pathFolder, false);
				}
			}

			// Wenn rekursiv kopiert/verschoben werden soll, alle Unterverzeichnisse
			// durchlaufen. Liste der Unterverzeichnisse erstellen.
			var subFolders = sourceDirInfo.GetDirectories();
			if (copySubfolders)
			{
				foreach (var subFolder in subFolders)
				{
					var pathSubFolder = Path.Combine(destPath, subFolder.Name);
					if (!Directory.Exists(pathSubFolder)) Directory.CreateDirectory(pathSubFolder);
					this.DirectoryCopy(subFolder.FullName, pathSubFolder, moveItBaby, copySubfolders);
					try
					{
						if (moveItBaby)
						{
							System.Threading.Thread.Sleep(1000);
							Directory.Delete(pathSubFolder);
						}
					}
					catch (IOException ioEx)
					{
						var logEntry = $"{DateTime.Now} - Problem beim Löschen des Ordners '{sourcePath}': {ioEx.Message}";
						Common.Services.LogService.WriteLogEntry(logEntry);
					}
				}
			}
			try
			{
				if (moveItBaby)
				{
					System.Threading.Thread.Sleep(1000);
					Directory.Delete(sourcePath);
				}
			}
			catch (IOException ioEx)
			{
				var logEntry = $"{DateTime.Now} - Problem beim Löschen des Ordners '{sourcePath}': {ioEx.Message}";
				Common.Services.LogService.WriteLogEntry(logEntry);
			}
		}

		#endregion PRIVATE PROCEDURES
	}
}