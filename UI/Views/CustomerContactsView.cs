using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Products.Common.Views
{
	public partial class CustomerContactsView : Form
	{

		#region members

		private Model.Entities.Kunde customer;

		#endregion

		#region public properties

		/// <summary>
		/// Returns the currently selected contact.
		/// </summary>
		public Model.Entities.Kundenkontakt CurrentContact { get; set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerContactsView.
		/// </summary>
		/// <param name="parentCustomer"></param>
		public CustomerContactsView(Model.Entities.Kunde parentCustomer)
		{
			InitializeComponent();
			this.customer = parentCustomer;
			this.Text = string.Format("Ansprechpartner bei {0}", parentCustomer.CompanyName1);
			this.dgvContacts.AutoGenerateColumns = false;
			this.dgvEmail.AutoGenerateColumns = false;
			this.dgvContacts.DataSource = parentCustomer.Kontaktliste;
			//Application.Idle += new EventHandler(Application_Idle);
		}

		#endregion

		#region eventhandler

		void Application_Idle(object sender, EventArgs e)
		{
			this.lnkAddRow.Enabled = this.CurrentContact != null && this.dgvEmail.RowCount == 0;
		}

		private void dgvContacts_SelectionChanged(object sender, EventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (dgv.SelectedRows.Count > 0)
			{
				Model.Entities.Kundenkontakt contact;
				//Data.dsSage.OrderRow transRow;
				contact = dgv.SelectedRows[0].DataBoundItem as Model.Entities.Kundenkontakt;
				CurrentContact = contact;
				InitContextMenu();
				InitLinkCommands();
				this.Text = CurrentContact.Kontaktname;
				dgvEmail.DataSource = contact.ContactMailList();
			}
		}

		private void lnkAddRow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Data.DataManager.DataService.AddContactEmailRow(CurrentContact.Kundennummer, CurrentContact.Nummer);
			this.dgvContacts_SelectionChanged(this.dgvContacts, new EventArgs());
		}

		private void lnkCallLandline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CallLandline();
		}

		private void lnkCallMobile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CallMobile();
		}

		private void lnkCallOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CallOther();
		}

		private void NewFonCall(object sender, EventArgs e)
		{
			CallLandline();
		}

		void NewMobileFonCall(object sender, EventArgs e)
		{
			CallMobile();
		}

		void NewOtherFonCall(object sender, EventArgs e)
		{
			CallOther();
		}

		void SendEmail(object sender, EventArgs e)
		{
			string newMail = string.Format("mailto:{0}", this.CurrentContact.E_Mail);
			Process.Start(newMail);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (!panelCommands.Visible)
			{
				this.pictureBox1.Image = global::Products.Common.Properties.Resources.Customers_green_48;
			}
			else
			{
				this.pictureBox1.Image = global::Products.Common.Properties.Resources.Customers_48;
			}
			panelCommands.Visible = !panelCommands.Visible;
		}

		#endregion

		#region private procedures

		private void InitLinkCommands()
		{
			if (CurrentContact != null)
			{
				if (CurrentContact.Telefon.Length > 0)
				{
					lnkCallLandline.Visible = true;
					lnkCallLandline.Text = string.Format("{0} anrufen", CurrentContact.Telefon);
				}
				else lnkCallLandline.Visible = false;
				if (CurrentContact.Handy.Length > 0)
				{
					lnkCallMobile.Visible = true;
					lnkCallMobile.Text = string.Format("{0} anrufen", CurrentContact.Handy);
				}
				else lnkCallMobile.Visible = false;
				if (CurrentContact.Zusatz.Length > 0)
				{
					lnkCallOther.Visible = true;
					lnkCallOther.Text = string.Format("{0} anrufen", CurrentContact.Zusatz);
				}
				else lnkCallOther.Visible = false;
			}
		}

		private void InitContextMenu()
		{
			if (this.CurrentContact != null)
			{
				this.ctxContact.Items.Clear();
				// add context menu for calling via fon
				if (this.CurrentContact.Telefon.Length > 0)
				{
					string cmdTextFon = string.Format("Telefon anrufen: {0}", this.CurrentContact.Telefon);
					ToolStripMenuItem tsi = new ToolStripMenuItem();
					tsi.Text = cmdTextFon;
					tsi.Click += new EventHandler(NewFonCall);
					this.ctxContact.Items.Add(tsi);
				}

				// add context menu for calling via mobile fon
				if (this.CurrentContact.Handy.Length > 0)
				{
					string cmdTextMobileFon = string.Format("Mobil anrufen: {0}", this.CurrentContact.Handy);
					ToolStripMenuItem tsi = new ToolStripMenuItem();
					tsi.Text = cmdTextMobileFon;
					tsi.Click += new EventHandler(NewMobileFonCall);
					this.ctxContact.Items.Add(tsi);
				}

				// add context menu for calling via additional fon
				if (this.CurrentContact.Zusatz.Length > 0)
				{
					string cmdTextOtherFon = string.Format("Andere Nummer wählen: {0}", this.CurrentContact.Zusatz);
					ToolStripMenuItem tsi = new ToolStripMenuItem();
					tsi.Text = cmdTextOtherFon;
					tsi.Click += new EventHandler(NewOtherFonCall);
					this.ctxContact.Items.Add(tsi);
				}

				// add context menu for creating a new email
				if (this.CurrentContact.E_Mail.Length > 0)
				{
					string cmdTextEmail = string.Format("E-Mail an: {0}", this.CurrentContact.E_Mail);
					ToolStripMenuItem tsi = new ToolStripMenuItem();
					tsi.Text = cmdTextEmail;
					tsi.Click += new EventHandler(SendEmail);
					this.ctxContact.Items.Add(tsi);
				}
			}
		}

		private void CallLandline()
		{
			Agfeo.FonManager.FonService.MakeCall(CurrentContact.Telefon.Trim());
		}

		private void CallMobile()
		{
			Agfeo.FonManager.FonService.MakeCall(CurrentContact.Handy.Trim());
		}

		private void CallOther()
		{
			Agfeo.FonManager.FonService.MakeCall(CurrentContact.Zusatz.Trim());
		}

		#endregion

	}
}
