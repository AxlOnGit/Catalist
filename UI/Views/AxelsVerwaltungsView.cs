using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Data;
using Products.Model;

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

		#endregion ### .ctor ###

		#region event handler

		void mbtnKundenumsatzAktualisieren_Click(object sender, EventArgs e)
		{
			var msg = "Augenblick, das kann eine Weile dauern.";
			MetroMessageBox.Show(this, msg, "Aktualisierung der Kundenumsätze", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DataManager.AllDataService.UpdateKundenumsatzTabelle();
			msg = "So, die Kundenumsätze sind aktuell.";
			MetroMessageBox.Show(this, msg, "Aktualisierung der Kundenumsätze", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler

		#region private procedures

		void mbtnLieferanten_Click(object sender, EventArgs e)
		{
			var llv = new LieferantenListView();
			llv.ShowDialog();
		}

		void mbtnCleanTerminXRefs_Click(object sender, EventArgs e)
		{
			ModelManager.AppointmentService.CleanAppointmentLinkXRefs();
		}

		#endregion private procedures
	}
}