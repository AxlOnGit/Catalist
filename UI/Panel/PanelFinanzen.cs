using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Products.Data;
using Products.Model;
using Products.Model.Entities;
using Products.Common.Views;

namespace Products.Common.Panel
{
	public partial class PanelFinanzen : PanelSlider
	{

		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlFinanzen Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		public PanelFinanzen(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvOffenePosten.AutoGenerateColumns = false;
			this.dgvOffenePosten.DataSource = DataManager.SalesDataService.GetOffenePostenTable(myKunde.CustomerId);

			this.dgvVersandkostenstaffel.AutoGenerateColumns = false;
			this.dgvVersandkostenstaffel.DataSource = myKunde.Versandstaffelpreisliste;

			this.lblSalesCurrentMonth.Text = string.Format("{0:MMMM} {0:yyy}", DateTime.Today);
			this.lblSalesThisMonthValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesThisMonth());

			this.lblSalesPreviousMonth.Text = this.GetPreviousMonthString();
			this.lblSalesPreviousMonthValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesPreviousMonth());

			this.lblSalesCurrentQuarter.Text = Utils.GetQuarterString(Utils.QuarterType.Current) + ":";
			this.lblSalesThisQuarterValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesThisQuarter());

			this.lblSalesPreviousQuarter.Text = Utils.GetQuarterString(Utils.QuarterType.Previous) + ":";
			this.lblSalesPreviousQuarterValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesPreviousQuarter());

			this.lblSalesCurrentYear.Text = string.Format("{0:yyy}", DateTime.Today);
			this.lblSalesThisYearValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesThisYear());

			this.lblSalesPreviousYear.Text = string.Format("{0}", DateTime.Today.Year - 1);
			this.lblSalesPreviousYearValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesPreviousYear());

			this.lblSalesTotalValue.Text = string.Format("{0:N2}", myKunde.GetAmountSalesTotal());

			this.mchkLieferstopp.Checked = myKunde.DunningFlag;
			this.mchkMahnbescheid.Checked = myKunde.DeliveryStopFlag;
			this.mchkVorkasse.Checked = myKunde.AdvancePaymentFlag;
			this.mlblUnpaidItemsValue.Text = string.Format("Offene Rechnungen total:{0:C2}", ModelManager.SalesService.GetOffenePostenTotal(this.myKunde));

			this.mlblBedingungenNetto.Text = string.Format("{0} Tage netto", myKunde.ZahlungenTageNetto);
			this.mlblBedingungenSkonto.Text = string.Format("{0} Tage {1:N1} % Skonto", myKunde.ZahlungenTageSkonto, myKunde.ZahlungenProzent);

			this.mlblMonatsdurchschnittWert.Text = myKunde.GetSalesAverageAmount().ToString("C2");

			this.Umsatzdiagramm.Series[0].YValueMembers = "Umsatz";
			this.Umsatzdiagramm.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
			this.Umsatzdiagramm.Series[0].XValueMember = "Datum";
			this.Umsatzdiagramm.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

			this.Umsatzdiagramm.Series[1].YValueMembers = "GewinnAbsolut";
			this.Umsatzdiagramm.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
			this.Umsatzdiagramm.Series[1].XValueMember = "Datum";
			this.Umsatzdiagramm.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

			this.Umsatzdiagramm.DataSource = ModelManager.SalesService.GetSalesStats(this.myKunde).Sort("Datum");
		}

		string GetPreviousMonthString()
		{
			if (DateTime.Today.Month == 1)
			{
				return string.Format("Dezember {0}", DateTime.Today.Year - 1);
			}
			return string.Format("{0} {1:yyy}", Utils.GetMonthString(DateTime.Today.Month - 1), DateTime.Today);
		}

		#endregion

	}
}
