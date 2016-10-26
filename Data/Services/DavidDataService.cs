using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Products.Data.Datasets;
using Products.Data.Datasets.dsDavidTableAdapters;

namespace Products.Data.Services
{
	public class DavidDataService
	{

		#region members

		readonly Datasets.dsDavid myDS = new Datasets.dsDavid();
		taArchiv myArchivAdapter;
		readonly taNachricht myNachrichtAdapter = new taNachricht();

		#endregion

		#region ### .ctor ###

		public DavidDataService()
		{
			this.InitializeData();
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt eine Liste der Nachrichtendateien auf dem David-Server zurück,
		/// deren Betreffzeilen das angegebene Suchkriterium enthalten.
		/// </summary>
		/// <param name="searchFor">Suchkriterium.</param>
		/// <returns></returns>
		public List<string> GetMessageFullNames(string searchFor)
		{
			var list = new List<string>();
			var messages = this.myNachrichtAdapter.GetData(searchFor);
			foreach (var msg in messages)
			{
				var archiv = this.GetArchivTable().FirstOrDefault(a => a.ID == msg.arcID);
				if (archiv != null)
				{
					var file = string.Format("{0}.001", msg.srFileName);
					var path = archiv.Path;
					list.Add(Path.Combine(path, file));
				}
			}
			return list;
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			if (this.myArchivAdapter == null)
			{
				this.myArchivAdapter = new taArchiv();
			}
			this.myArchivAdapter.Fill(this.myDS.Archiv);
		}

		dsDavid.ArchivDataTable GetArchivTable()
		{
			return this.myDS.Archiv;
		}

		#endregion

	}
}
