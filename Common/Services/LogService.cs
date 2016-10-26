using System;
using System.IO;

namespace Products.Common.Services
{
	public static class LogService
	{

		#region members

		readonly static string docPath;
		readonly static string logFile;


		#endregion

		#region ### .ctor ###

		static LogService()
		{
			docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			logFile = Path.Combine(docPath, "catalist.log");
		}

		#endregion

		#region static procedures

		public static void WriteLogEntry(string logText)
		{
			using (var lFile = File.AppendText(logFile))
			{
				lFile.WriteLine(logText);
			}
		}

		#endregion

	}
}
