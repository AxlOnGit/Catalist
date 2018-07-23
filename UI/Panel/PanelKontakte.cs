using System.Windows.Forms;
using Agfeo;
using Products.Common.Views;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class PanelKontakte : PanelSlider
	{

		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		Kundenkontakt mySelectedKontakt;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlKontake Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		public PanelKontakte(ContainerControl parentCtrl, Model.Entities.Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;

			this.dgvContacts.AutoGenerateColumns = false;
			this.dgvContacts.DataSource = this.myKunde.Kontaktlist;
		}

		#endregion

		#region event handler

		void dgvContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var kontakt = this.dgvContacts.Rows[e.RowIndex].DataBoundItem as Kundenkontakt;
			if (kontakt != null)
			{
				foreach (ToolStripMenuItem item in ctxGrid.Items)
				{
					if (item.Tag != null)
					{
						item.Click -= (System.EventHandler)item.Tag;
						item.Tag = null;
					}
				}
				this.ctxGrid.Items.Clear();
				this.mySelectedKontakt = kontakt;

				if (!string.IsNullOrEmpty(kontakt.Telefon))
				{
					var xmnuFestAnrufen = new ToolStripMenuItem();
					xmnuFestAnrufen.Text = string.Format("Büro: {0} anrufen", kontakt.Telefon);
					this.ctxGrid.Items.Add(xmnuFestAnrufen);
					var festHandler = new System.EventHandler(xmnuFestAnrufen_Click);
					xmnuFestAnrufen.Tag = festHandler;
					xmnuFestAnrufen.Click += festHandler;
				}
				if (!string.IsNullOrEmpty(kontakt.Handy))
				{
					var xmnuMobilAnrufen = new ToolStripMenuItem();
					xmnuMobilAnrufen.Text = string.Format("Mobil: {0} anrufen", kontakt.Handy);
					this.ctxGrid.Items.Add(xmnuMobilAnrufen);
					var mobilHandler = new System.EventHandler(xmnuMobilAnrufen_Click);
					xmnuMobilAnrufen.Tag = mobilHandler;
					xmnuMobilAnrufen.Click += mobilHandler;
				}
				if (!string.IsNullOrEmpty(kontakt.E_Mail))
				{
					var xmnuSendMail = new ToolStripMenuItem();
					xmnuSendMail.Text = string.Format("E-Mail an: {0}", kontakt.E_Mail);
					this.ctxGrid.Items.Add(xmnuSendMail);
					var mailHandler = new System.EventHandler(xmnuSendMail_Click);
					xmnuSendMail.Tag = mailHandler;
					xmnuSendMail.Click += mailHandler;
				}
			}
		}

		void xmnuSendMail_Click(object sender, System.EventArgs e)
		{
			ModelManager.PostBuedel.SendMailViaDefaultMailer(this.mySelectedKontakt.E_Mail, "Betreff");
		}

		void xmnuMobilAnrufen_Click(object sender, System.EventArgs e)
		{
			FonManager.FonService.MakeCall(this.mySelectedKontakt.Handy);
		}

		void xmnuFestAnrufen_Click(object sender, System.EventArgs e)
		{
			FonManager.FonService.MakeCall(this.mySelectedKontakt.Telefon);
		}

		void pnlKontakte_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && (e.KeyCode == Keys.Home))
			{
				this.myParent.ShowStartPanel();
			}
		}

		#endregion

	}
}
