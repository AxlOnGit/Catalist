using System;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class AngeboteListView : MetroForm
	{

		#region members

		readonly Kunde myKunde;
		Angebot mySelectedAngebot;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="AngeboteListView"/> Formularklasse.
		/// </summary>
		public AngeboteListView(Kunde kunde = null)
		{
			this.InitializeComponent();
			if (kunde != null) this.myKunde = kunde;
			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvAngebote.AutoGenerateColumns = false;
			this.dgvDetails.AutoGenerateColumns = false;
			if (this.myKunde != null)
			{
				this.Text = string.Format("Angebote in Sage für {0}", this.myKunde.Matchcode);
				this.dgvAngebote.DataSource = Model.ModelManager.SalesService.GetAngeboteSageList(this.myKunde.CustomerId).Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
			}
			else
			{
				this.dgvAngebote.DataSource = Model.ModelManager.SalesService.GetAngeboteSageList().Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
			}
			this.dgvAngebote.RowEnter += DgvAngebote_RowEnter;
		}

		#endregion

		#region event handler

		void DgvAngebote_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedAngebot = dgvAngebote.Rows[e.RowIndex].DataBoundItem as Angebot;
			if (this.mySelectedAngebot != null)
			{
				this.dgvDetails.DataSource = Model.ModelManager.SalesService.GetAngebotsDetails(this.mySelectedAngebot);
				//var sb = new StringBuilder();
				//var criteria = string.Format("O{0}", this.mySelectedAngebot.Nummer);
				//foreach (var mail in Model.ModelManager.DavidService.GetMailItems(criteria))
				//{
				//	sb.AppendLine(mail.Betreff);
				//}
				//MessageBox.Show(sb.ToString());
			}
		}

		void xcmdSearchEmails_Click(object sender, EventArgs e)
		{
			if (this.mySelectedAngebot == null) return;
			var elv = new EmailListView(this.mySelectedAngebot);
			elv.ShowDialog();
		}

		#endregion

	}
}
