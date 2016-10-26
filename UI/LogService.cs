using System;
using System.IO;

namespace Products.Common
{
	class LogService
	{

		#region members

		readonly string logFile;

		#endregion

		#region ### .ctor ###

		public LogService()
		{
			var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			this.logFile = Path.Combine(docPath, "catalist.log");
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt dem Catalist Logfile einen neuen Eintrag hinzu.
		/// </summary>
		/// <param name="logText"></param>
		public void WriteLogEntry(string logText)
		{
			using (var lFile = File.AppendText(this.logFile))
			{
				lFile.WriteLine(logText);
			}
		}

		#endregion


	}
}
