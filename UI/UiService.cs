using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Products.Model.Entities;
using Products.Common.ViewController;
using Products.Common.Views;
using Products.Model;

namespace Products.Common
{
	public class UiService
	{

		#region members
		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###
		#endregion

		#region public procedures

		/// <summary>
		/// Zeigt den Kalender für den angemeldeten User an.
		/// </summary>
		/// <param name="currentUser"></param>
		public void ShowCalendar()
		{
			Products.Common.Program.ShowCalendar();
		}

		public string GetControlMetrics(object control)
		{
			var sb = new StringBuilder();
			if (control is DataGridView)
			{
				int i = 1;
				var grid = control as DataGridView;
				foreach (DataGridViewColumn col in grid.Columns)
				{
					sb.AppendFormat("Sp. {0}: {1} - {2}pt{3}", i, col.HeaderText, col.Width, Environment.NewLine);
					i++;
				}
			}
			return sb.ToString();
		}

		#endregion

	}
}
