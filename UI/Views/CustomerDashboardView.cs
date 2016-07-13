using System;
using System.Data;
using System.Windows.Forms;

namespace Products.Common.Views
{
	public partial class CustomerDashboardView : Form
	{

		#region events and delegates
		#endregion

		#region members

		private Model.Entities.Kunde myCustomer = null;
		private Data.dsSage.ProductSalesRow currentProductRow = null;
		private Model.Entities.HistoryItem currentHistoryItem = null;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerGeneralView class for the given customer.
		/// </summary>
		/// <param name="customer"></param>
		public CustomerDashboardView(Model.Entities.Kunde customer)
		{
			InitializeComponent();
			this.myCustomer = customer;
			InitThisView();
		}

		#endregion

		#region event handler

		private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void rateSalesVolume_CurrentRatingChanged(object sender, EventArgs e)
		{
			string title = string.Format("Umsätze: {0}", this.rateSalesVolume.LabelTextItems[this.rateSalesVolume.CurrentRating - 1]);
			this.tPanelSales.TitleText = title;
		}

		private void ratePaymentMoral_CurrentRatingChanged(object sender, EventArgs e)
		{
			string title = string.Format("Zahlungen: {0}", this.ratePaymentMoral.LabelTextItems[this.ratePaymentMoral.CurrentRating - 1]);
			this.tPanelPayments.TitleText = title;
		}

		private void rateSympathy_CurrentRatingChanged(object sender, EventArgs e)
		{
			string title = string.Format("Historie: {0}", this.rateSympathy.LabelTextItems[this.rateSympathy.CurrentRating - 1]);
			this.tPanelHistory.TitleText = title;
		}

		private void lnkPaymentNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Hier werden in Zukunft Notizen in Bezug auf das Zahlungsverhalten des Kunden angezeigt.", "Noch nich feddich ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void lnkOpenInSage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			myCustomer.OpenInSage(Properties.Settings.Default.Sage_ExePath);
		}

		private void lnkUnpaidItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			UnpaidItemsListView ulv = new UnpaidItemsListView(myCustomer);
			ulv.Show(this);
		}

		private void lnkOrderSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CustomerOrderView cmv = new CustomerOrderView(myCustomer, false);
			cmv.Show(this);
		}

		private void dgvTop10b_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dgvTop10b.SelectedRows != null && this.dgvTop10b.SelectedRows.Count == 1)
			{
				DataRowView drv = this.dgvTop10b.SelectedRows[0].DataBoundItem as DataRowView;
				Data.dsSage.ProductSalesRow psv = drv.Row as Data.dsSage.ProductSalesRow;
				this.currentProductRow = psv;
			}
		}

		private void dgvHistory_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dgvHistory.SelectedRows != null && this.dgvHistory.SelectedRows.Count == 1)
			{
				Model.Entities.HistoryItem hit = dgvHistory.SelectedRows[0].DataBoundItem as Model.Entities.HistoryItem;
				this.currentHistoryItem = hit;
			}
		}

		private void dgvTop10b_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.currentProductRow != null)
			{
				TransactionListView tlv = new TransactionListView(myCustomer.CustomerId, this.currentProductRow.Artikel);
				tlv.Show(this);
			}
		}

		private void lnkContacts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CustomerContactsView ccv = new CustomerContactsView(myCustomer);
			ccv.Show(this);
		}

		private void lnkProductListView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProductListView plv = new ProductListView(myCustomer);
			plv.Show();
		}

		private void lnkUpsShipping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			UpsShippingView usv = new UpsShippingView(this.myCustomer.UpsLieferungen());
			usv.Show();
		}

		private void lnkNewPhoneNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowPhoneNoteView();
		}

		private void picPanelSwitch_Click(object sender, EventArgs e)
		{
			if (panTopCommands.Visible)
			{
				this.picPanelSwitch.Image = global::Products.Common.Properties.Resources.Customers_48;
			}
			else
			{
				this.picPanelSwitch.Image = global::Products.Common.Properties.Resources.Customers_green_48;
			}
			panTopCommands.Visible = !panTopCommands.Visible;
		}

		private void lnkShowOffers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OfferListView olv = new OfferListView(myCustomer);
			olv.Show();
		}

		private void lnkBingMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			myCustomer.OpenInBingMaps();
		}

		private void lnkShowHistoryDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (currentHistoryItem != null)
			{
				CustomerOrderView cmv = new CustomerOrderView(myCustomer, false);
				cmv.Show(this);
				switch (currentHistoryItem.ItemType)
				{
					case "Direktrechnung":
						cmv.SelectRow("D", currentHistoryItem.ID);
						break;

					case "Rechnung":
						cmv.SelectRow("R", currentHistoryItem.ID);
						break;

					default:
						cmv.SelectRow("A", currentHistoryItem.ID);
						break;
				}
			}
		}

		private void lnkKundenmaschinen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MachineListView mlv = new MachineListView(myCustomer);
			mlv.Show(this);
		}

		private void lnkSoftware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SoftwareListView slv = new SoftwareListView(myCustomer);
			slv.Show();
		}

		private void lnkServicetermine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ServiceterminListView slv = new ServiceterminListView(myCustomer);
			slv.Show(this);
		}

		#endregion // event handler

		#region private procedures

		private void InitThisView()
		{
			this.rateSalesVolume.CurrentRating = 5;
			this.ratePaymentMoral.CurrentRating = 4;
			this.rateSympathy.CurrentRating = 5;

			string companyName = myCustomer.CompanyName1.Replace("&", "&&");
			this.lblCustomerHeader.Text = string.Format("{0}, {1} - [Kunden-Nr. {2}]", companyName, myCustomer.City, myCustomer.CustomerId.Substring(0,5));
			this.Text = myCustomer.CompanyName1;

			this.lblSalesCurrentMonth.Text = string.Format("{0:MMMM} {0:yyy}", DateTime.Today);
			this.lblSalesThisMonthValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzDieserMonatBetrag());

			this.lblSalesPreviousMonth.Text = this.GetPreviousMonthString();
			this.lblSalesPreviousMonthValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzVormonatBetrag());

			this.lblSalesCurrentQuarter.Text = Utils.GetQuarterString(Utils.QuarterType.Current) + ":";
			this.lblSalesThisQuarterValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzDiesQuartalBetrag());

			this.lblSalesPreviousQuarter.Text = Utils.GetQuarterString(Utils.QuarterType.Previous) + ":";
			this.lblSalesPreviousQuarterValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzVorherigesQuartalBetrag());

			this.lblSalesCurrentYear.Text = string.Format("{0:yyy}", DateTime.Today);
			this.lblSalesThisYearValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzDiesJahrBetrag());

			this.lblSalesPreviousYear.Text = string.Format("{0}", DateTime.Today.Year - 1);
			this.lblSalesPreviousYearValue.Text = string.Format("{0:N2}", myCustomer.GetUmsatzVorjahrBetrag());

			this.lblSalesTotalValue.Text = string.Format("{0:N2}", myCustomer.GetGesamtumsatzBetrag());

			this.chkSperrvermerk1.Checked = myCustomer.DunningFlag;
			this.chkSperrvermerk2.Checked = myCustomer.DeliveryStopFlag;
			this.chkSperrvermerk3.Checked = myCustomer.AdvancePaymentFlag;
			this.txtZahlungenTageNetto.Text = myCustomer.ZahlungenTageNetto.ToString();
			this.txtZahlungenTageSkonto.Text = myCustomer.ZahlungenTageSkonto.ToString();
			this.txtZahlungenProzent.Text = myCustomer.ZahlungenProzent.ToString("N1");
			this.lblUnpaidItemsValue.Text = string.Format("{0:N2}", myCustomer.OffenePostenTotal);

			this.dgvTop10b.AutoGenerateColumns = false;
			this.dgvTop10b.DataSource = myCustomer.GetVerkaufteProdukteTabelle();

			this.dgvHistory.AutoGenerateColumns = false;
			this.dgvHistory.DataSource = myCustomer.Historienliste();
		}

		private string GetPreviousMonthString()
		{
			if (DateTime.Today.Month == 1)
			{
				return string.Format("Dezember {0}", DateTime.Today.Year - 1);
			}
			else return string.Format("{0} {1:yyy}",Utils.GetMonthString(DateTime.Today.Month - 1), DateTime.Today);
		}

		private void ShowPhoneNoteView()
		{
			PhoneNoteView pnv = new PhoneNoteView();
			pnv.Show();
		}

		#endregion

	}
}
