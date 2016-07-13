using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;
using Products.Model.Services;
using Products.Model;

namespace Products.Common.Views
{
	public partial class CustomerDetailView : MetroForm
	{

		#region members

		Kunde myKunde;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="CustomerDetailView"/> Klasse.
		/// </summary>
		public CustomerDetailView(Kunde kunde)
		{
			InitializeComponent();
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void CustomerDetailView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.CustomerService.UpdateKunden();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("{0} ({1})", this.myKunde.CompanyName1, this.myKunde.KundenNrCpm);

			this.mdtpLastVisit.DataBindings.Add("Value", this.myKunde, "LetzterBesuchstermin");
			this.mdtpNextVisit.DataBindings.Add("Value", this.myKunde, "NaechsterBesuchstermin");

			this.mtxtAktuellerHinweis.DataBindings.Add("Text", this.myKunde, "AktuellerHinweis");
			this.mtxtBesuchsintervall.DataBindings.Add("Text", this.myKunde, "Besuchsintervall");
			this.mtxtBesuchszeit.DataBindings.Add("Text", this.myKunde, "Besuchszeit");
			this.mchkMitAnmeldung.DataBindings.Add("Checked", this.myKunde, "MitAnmeldungFlag");
			this.mchkChristmas.DataBindings.Add("Checked", this.myKunde, "WeihnachtsFlag");
			this.mchkKurzpreisliste.DataBindings.Add("Checked", this.myKunde, "KurzpreislisteFlag");
			this.mchkVorjahresvergleich.DataBindings.Add("Checked", this.myKunde, "VorjahresvergleichFlag");
			this.mchkUmsatzSeitLetztemBesuch.DataBindings.Add("Checked", this.myKunde, "UmsatzSeitLetztemBesuchFlag");
			this.mchkPrintLastOffer.DataBindings.Add("Checked", this.myKunde, "UmsatzSeitLetztemBesuchFlag");
			this.mchkOhneVorbereitung.DataBindings.Add("Checked", this.myKunde, "OhneVorbereitungFlag");
			this.mtxtAnmerkungen.DataBindings.Add("Text", this.myKunde, "Anmerkungen");
		}

		#endregion

	}
}
