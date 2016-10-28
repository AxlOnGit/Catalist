using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace CatalistStart
{
	class Program
	{
		static void Main(string[] args)
		{
			int delay = 60000;
			var oneDrive = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\OneDrive", "UserFolder", null).ToString();
			var path = Path.Combine(oneDrive, @"CPM\CPM_INTERN\Für Alle\Catalist\Catalist on Steroids\Catalist.UI.exe");

			// Befehlszeilenparameter auslesen
			switch (args.Length)
			{
				case 2:
					int.TryParse(args[0], out delay);
					path = args[1];
					break;

				case 1:
					int.TryParse(args[0], out delay);
					break;

				case 0:
					break;
			}

			// Erstma Päusken machen ...
			System.Threading.Thread.Sleep(delay);

			// Catalist starten
			try
			{
				var catalist = new Process();
				catalist.StartInfo.FileName = path;
				if (File.Exists(path))
				{
					catalist.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					catalist.Start();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}