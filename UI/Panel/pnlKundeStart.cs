using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Agfeo;
using MetroFramework;
using MetroFramework.Interfaces;
using Products.Common.Interfaces;
using Products.Common.Views;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlKundeStart : Panel.pnlSlider, IMetroControl
	{
		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		dsSales.SalesRow currentSalesRow;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der mpnlStart Klasse.
		/// </summary>
		/// <param name="parentCtrl">Verweis auf den übergeordneten Container.</param>
		/// <param name="kunde">Der Kunde, um den es aktuell geht.</param>
		public pnlKundeStart(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();

			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void mtileArtikel_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowArtikelpreise();
			this.Cursor = Cursors.Default;
		}

		void mtileAuftraege_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowAuftraege();
			this.Cursor = Cursors.Default;
		}

		void mtileAngebote_Click(object sender, EventArgs e)
		{
			var optionen = new string[] { "Catalist Angebote", "SAGE Angebote" };
			var adg = new AuswahlDialog("Welcher Typ Angebot soll's denn werden?", optionen, MetroFramework.MetroColorStyle.Green);
			if (adg.ShowDialog() == DialogResult.OK)
			{
				switch (adg.SelectedOption)
				{
					case 1:
						var alv = new AngeboteListView(this.myKunde);
						alv.ShowDialog();
						break;

					default:
						this.myParent.LoadOrShowAngebote();
						break;
				}
			}
		}

		void mlnkTelefon_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			FonManager.FonService.MakeCall(mlnkTelefon.Text.Trim());
			this.Cursor = Cursors.Default;
		}

		void mlnkEmail_Click(object sender, EventArgs e)
		{
			this.myKunde.MailToMainContact();
		}

		void mtileKontakte_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowKontakte();
			this.Cursor = Cursors.Default;
		}

		void mtileFinanzen_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowFinanzen();
			this.Cursor = Cursors.Default;
		}

		void mtileMaschinen_Click(object sender, EventArgs e)
		{
			this.myParent.LoadOrShowMaschinen();
		}

		void mtileServicetermine_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ShowTerminListe();
			this.Cursor = Cursors.Default;
		}

		void ShowTerminListe()
		{
			var kundeAsLink = this.myKunde as ILinkedItem;
			var aList = ModelManager.AppointmentService.GetAppointmentList(kundeAsLink.Key, kundeAsLink.LinkTypeId);
			var alv = new AppointmentListView(aList, this.myKunde.CompanyName1);
			alv.Show();
		}

		void mtileSoftware_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowKundensoftware();
			this.Cursor = Cursors.Default;
		}

		void mtileUPS_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			var usv = new Views.UpsShippingView(myKunde.UpsLieferungenList());
			usv.ShowDialog();
			this.Cursor = Cursors.Default;
		}

		void mtileNotizen_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.myParent.LoadOrShowNotizen();
			this.Cursor = Cursors.Default;
		}

		void mtileKalender_Click(object sender, EventArgs e)
		{
			if (!David.DavidManager.DavidService.Connected)
			{
				MetroMessageBox.Show(this, "Der Server steht im Augenblick nicht zur Verfügung", "Irgendwatt mit dem David-Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			ServiceManager.UiService.ShowCalendar();
		}

		void dgvTop10b_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var drv = dgvTop10b.Rows[e.RowIndex].DataBoundItem as DataRowView;
			var sr = drv.Row as dsSales.SalesRow;
			this.currentSalesRow = sr;
		}

		void dgvTop10b_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.currentSalesRow != null)
			{
				var tlv = new Views.TransactionListView(myKunde.CustomerId, this.currentSalesRow.Artikel);
				tlv.Show(this);
			}
		}

		void mTileClose_Click(object sender, EventArgs e)
		{
			this.myParent.Close();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			if (this.myKunde.Inactive)
			{
				this.mlblKundennummer.ForeColor = System.Drawing.Color.DarkRed;
				this.mlblInactive.ForeColor = System.Drawing.Color.DarkRed;
				this.mlblInactive.Text = "Kunde ist inaktiv!";
			}
			this.mlblKundennummer.Text = string.Format("[{0}] - {1}", myKunde.CustomerId.Substring(0, 5), myKunde.CompanyName1.Replace("&", "&&"));
			this.mlblStrasse.Text = myKunde.Street;
			this.mlblPlzOrt.Text = string.Format("{0} {1}", myKunde.ZipCode, myKunde.City);
			this.mlblEntfernung.Text = string.Format("{0} Kilometer ungefähr von uns entfernt", this.myKunde.EntfernungZuReferenzkunde);
			var hauptKontakt = myKunde.Kontaktlist.FirstOrDefault(k => k.MainContactFlag == true);
			this.mlblFrachtfreigrenze.Text = myKunde.FocText;
			if (hauptKontakt != null)
			{
				this.mlblHauptkontakt.Text = hauptKontakt.Kontaktname;
				this.mlnkTelefon.Text = hauptKontakt.Telefon;
				this.mlnkEmail.Text = hauptKontakt.E_Mail;
			}
			else
			{
				this.mlblHauptkontakt.Text = "Es gibt für diesen Kunden keinen Ansprechpartner!";
			}
			this.dgvTop10b.AutoGenerateColumns = false;
			this.dgvTop10b.DataSource = ModelManager.SalesService.GetSalesTable(this.myKunde.CustomerId);
			this.dgvTop10b.Sort(colDatumZuletzt, System.ComponentModel.ListSortDirection.Descending);
		}

		#endregion private procedures
	}
}