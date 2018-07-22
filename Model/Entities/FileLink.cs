using System;
using System.IO;
using System.Linq;
using Products.Data.Datasets;
using Products.Common.Interfaces;
using Products.Data;

namespace Products.Model.Entities
{
	public class FileLink : ILinkedItem
	{

		#region members

		readonly dsFileLink.FileLinkRow myBase;
		readonly FileInfo myFileInfo;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.FullName; }
		}

		public string ItemName
		{
			get { return this.FileTitle; }
		}

		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Datei").UID; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Datei"; }
		}

		#endregion

		/// <summary>
		/// Gibt den Primärschlüssel (GUID) des Dateilinks zurück.
		/// </summary>
		public string FullName
		{
			get { return this.myBase.FullName; }
		}

		/// <summary>
				/// Gibt nur den Dateinamen der Datei zurück, so wie sie im Dateisystem gespeichert ist.
				/// </summary>
		public string FileName
		{
			get
			{
				return this.myFileInfo.Name;
			}
		}

		/// <summary>
		/// Gibt den Dateinamen an, so wie er in der Benutzeroberfläche angezeigt wird.
		/// <remarks>
		/// Der tatsächliche Dateiname wird automatisch generiert und die Datei dann im System abgelegt.
		/// </remarks>
		/// </summary>
		public string FileTitle
		{
			get { return this.myBase.FileTitle; }
			set { this.myBase.FileTitle = value; }
		}

		/// <summary>
		/// Gibt den Dateitypen der Verknüpfung zurück. Diese Einstellung ist schreibgeschützt.
		/// </summary>
		public string Extension
		{
			get { return this.myBase.Extension; }
			private set { this.myBase.Extension = value.ToUpper(); }
		}

		public string Description
		{
			get { return this.myBase.Description; }
			set { this.myBase.Description = value; }
		}

		/// <summary>
		/// Gibt das Erstellungsdatum der Datei zurück.
		/// </summary>
		public DateTime? CreationTime
		{
			get
			{
				if (this.myFileInfo != null)
				{
					return this.myFileInfo.CreationTime;
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt den Zeitpunkt des letzten Schreibzugriffs auf die Datei zurück.
		/// </summary>
		public DateTime? LastWriteTime
		{
			get
			{
				if (this.myFileInfo != null)
				{
					return this.myFileInfo.LastWriteTime;
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt den Zeitpunkt des letzten Lesezugriffs auf die Datei zurück.
		/// </summary>
		public DateTime? LastAccessTime
		{
			get
			{
				if (this.myFileInfo != null)
				{
					return this.myFileInfo.LastAccessTime;
				}
				return null;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Dateilink Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public FileLink(dsFileLink.FileLinkRow baseRow)
		{
			//this.myXrefBase = fileLinkXrefRow;
			this.myBase = baseRow;
			this.myFileInfo = new FileInfo(baseRow.FullName);
		}

		#endregion

		#region public procedures;

		/// <summary>
		/// Erstellt eine Kopie der Datei mit dem angegebenen Namen im selben Verzeichnis.
		/// </summary>
		/// <param name="fileName">Dateiname der Kopie.</param>
		/// <param name="overwrite">Wenn true, wird eine eventuell vorhandene Datei überschrieben.</param>
		/// <returns></returns>
		public FileInfo CopyTo(string fileName, bool overwrite)
		{
			return this.myFileInfo.CopyTo(fileName, overwrite);
		}

		/// <summary>
		/// Gibt True zurück, wenn die verknüpfte Datei gelöscht werden kann, weil
		/// es keine weiteren Verknüpfungen zu ihr gibt.
		/// </summary>
		/// <returns>True, wenn dies die einzige Verknüpfung zu dieser Datei ist.</returns>
		public bool GetCanDelete()
		{
			return ModelManager.FileLinkService.GetCanDelete(this.FullName);
		}

		#endregion

		#region private procedures
		#endregion

		}
}
