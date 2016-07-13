using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Data;

namespace Products.Common.Views
{
	public partial class AxelsVerwaltungsView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der AxelsVerwaltungsView Klasse.
		/// </summary>
		public AxelsVerwaltungsView()
		{
			InitializeComponent();
		}

		#endregion

		#region event handler

		void mbtnKundenumsatzAktualisieren_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			DataManager.AllDataService.UpdateKundenumsatzTabelle();
			this.Cursor = Cursors.Default;
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		void mbtnLieferanten_Click(object sender, EventArgs e)
		{
			var llv = new LieferantenListView();
			llv.ShowDialog();
		}
	
	}
}
