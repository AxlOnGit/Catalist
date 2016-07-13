using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Data;

namespace Products.Common.Views
{
	public partial class AuftraegeProArtikelView : MetroForm
	{

		#region members

		readonly string myArtikelNummer;
		dsSage.AuftragProArtikelRow mySelectedRow;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der AuftraegeProArtikelView Klasse.
		/// </summary>
		public AuftraegeProArtikelView(string artikelNummer)
		{
			InitializeComponent();
			this.myArtikelNummer = artikelNummer;
			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			try
			{
				if (string.IsNullOrEmpty(this.myArtikelNummer)) return;
				this.dgvAuftraege.AutoGenerateColumns = false;
				this.dgvAuftraege.DataSource = DataManager.AllDataService.GetAuftraegeProArtikel(this.myArtikelNummer);
			}
			catch (Exception)
			{
				this.Close();
			}
		}

		#endregion

		#region event handler

		void dgvAuftraege_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var drv = this.dgvAuftraege.Rows[e.RowIndex].DataBoundItem as DataRowView;
			if (drv != null)
			{
				this.mySelectedRow = drv.Row as dsSage.AuftragProArtikelRow;
			}
		}

		void mcmdCopyAuftrag_Click(object sender, EventArgs e)
		{
			if (this.mySelectedRow != null)
			{
				Clipboard.SetDataObject(mySelectedRow.Auftrag, true);
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
