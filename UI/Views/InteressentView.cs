using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class InteressentView : MetroForm
	{

		#region members

		Interessent myInteressent;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der InteressentView Klasse.
		/// </summary>
		public InteressentView(Interessent interessent)
		{
			InitializeComponent();
			myInteressent = interessent;

			InitializeData();
		}

		#endregion

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void InteressentView_FormClosing(object sender, FormClosingEventArgs e)
		{
			myInteressent.Update();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.mtxtAdresszusatz.DataBindings.Add("Text", myInteressent, "Adresszusatz");
			this.mtxtAnmerkungen.DataBindings.Add("Text", myInteressent, "Anmerkungen");
			this.mtxtEmail.DataBindings.Add("Text", myInteressent, "Email");
			this.mtxtFax.DataBindings.Add("Text", myInteressent, "Fax");
			this.mtxtFirmenname.DataBindings.Add("Text", myInteressent, "Firmenname");
			this.mtxtFirmenzusatz.DataBindings.Add("Text", myInteressent, "Firmenzusatz");
			this.mtxtHerkunft.DataBindings.Add("Text", myInteressent, "Herkunft");
			this.mtxtKontakt.DataBindings.Add("Text", myInteressent, "Kontaktperson");
			this.mtxtMobil.DataBindings.Add("Text", myInteressent, "Mobil");
			this.mtxtOrt.DataBindings.Add("Text", myInteressent, "Ort");
			this.mtxtPlz.DataBindings.Add("Text", myInteressent, "Plz");
			this.mtxtStrasse.DataBindings.Add("Text", myInteressent, "Strasse");
			this.mtxtTelefon.DataBindings.Add("Text", myInteressent, "Telefon");
			this.mtxtWebsite.DataBindings.Add("Text", myInteressent, "Website");
			this.mdtpAkquiseAm.DataBindings.Add("Value", myInteressent, "AkquiseAm");

			this.mcmbAkquiseDurch.DataSource = ModelManager.UserService.GetActiveUsersList();
			this.mcmbAkquiseDurch.DisplayMember = "NameFull";
			this.mcmbAkquiseDurch.DataBindings.Add("SelectedItem", myInteressent, "Akquirierer");
		}
		
		#endregion

	}
}
