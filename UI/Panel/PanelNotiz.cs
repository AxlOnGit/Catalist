using System;
using System.Windows.Forms;
using Products.Model;
using Products.Model.Entities;
using Products.Common.Views;
using MetroFramework;

namespace Products.Common.Panel
{
	public partial class PanelNotiz : PanelSlider
	{

		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		readonly Notiz myNotiz;

		#endregion

		#region ###  .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlNotiz Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="notiz"></param>
		public PanelNotiz(ContainerControl parentCtrl, Notiz notiz, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myNotiz = notiz;
			this.myKunde = kunde;

			InitializeData();
			this.OnClosed += pnlNotiz_OnClosed;
		}

		#endregion

		#region event handlers

		void metroLink1_Click(object sender, EventArgs e)
		{
			if (this.txtNotiztext.FontSize == MetroTextBoxSize.Tall)
			{
				this.txtNotiztext.FontSize = MetroTextBoxSize.Small;
				return;
			}
			this.txtNotiztext.FontSize += 1;
		}

		void pnlNotiz_OnClosed(object sender, EventArgs e)
		{
			ModelManager.NotesService.UpdateNotes();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.mlblTitel.Text = this.myNotiz.Subject;
			this.cmbLinktype.DataSource = ModelManager.SharedItemsService.LinkTypList;
			this.cmbLinktype.ValueMember = "UID";
			this.cmbLinktype.DisplayMember = "Bezeichnung";
			this.cmbLinktype.DataBindings.Add("SelectedValue", this.myNotiz.LinkedItemType, "UID");

			this.cmbAnsprechpartner.DataSource = ModelManager.ContactService.GetContactListForCustomer(this.myKunde.CustomerId);
			this.cmbAnsprechpartner.ValueMember = "Nummer";
			this.cmbAnsprechpartner.DisplayMember = "Kontaktname";
			this.cmbAnsprechpartner.DataBindings.Add("SelectedValue", this.myNotiz, "ContactNumber");

			this.lblErfassung.DataBindings.Add("Text", this.myNotiz, "MetaData");
			this.mtxtThema.DataBindings.Add("Text", this.myNotiz, "Subject");
			this.txtNotiztext.DataBindings.Add("Text", this.myNotiz, "Body");

			this.mdtpErfassungsdatum.DataBindings.Add("Value", this.myNotiz, "CreatedAt");
		}

		#endregion

	}
}
