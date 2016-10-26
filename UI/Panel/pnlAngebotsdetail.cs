using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Model;
using Products.Model.Entities;
using Products.PdfMaker;

namespace Products.Common.Panel
{
	public partial class pnlAngebotsdetail : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		readonly Offer myOffer;
		OfferDetail myCurrentOfferDetail;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlAngebotsdetail Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="offer"></param>
		public pnlAngebotsdetail(ContainerControl parentCtrl, Offer offer, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myOffer = offer;

			InitializeData();
			Application.Idle += Application_Idle;
			this.OnClosed += pnlAngebotsdetail_OnClosed;
		}

		#endregion ### .ctor ###

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			var jau = dgvOfferDetails.Rows.Count > 0;
			ccmdDeleteDetail.Enabled = jau;
			btnPositionLoeschen.Enabled = jau;
			ccmdPrint.Enabled = jau;
			ccmdPrint2.Enabled = jau;
			btnDrucken.Enabled = jau;
		}

		void dgvOfferDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			myCurrentOfferDetail = dgvOfferDetails.Rows[e.RowIndex].DataBoundItem as OfferDetail;
			if (myCurrentOfferDetail != null)
			{
				var loeschText = string.Format("Lösche Position {0} ({1})", myCurrentOfferDetail.Position, myCurrentOfferDetail.Artikelname);
				this.mToolTip.SetToolTip(btnPositionLoeschen, loeschText);
				this.txtPositionsinfo.Text = myCurrentOfferDetail.Positionsinfo;
				this.txtRowComment.DataBindings.Clear();
				this.txtRowComment.DataBindings.Add("Text", myCurrentOfferDetail, "Artikeltext");
				this.txtRowComment.Text = string.IsNullOrEmpty(this.myCurrentOfferDetail.Artikeltext) ? string.Empty : this.myCurrentOfferDetail.Artikeltext;
				//this.txtRowComment.Text = myCurrentOfferDetail.Artikeltext;
			}
		}

		void btnNeuePosition_Click(object sender, EventArgs e)
		{
			AddOfferDetail();
		}

		void ccmdNewDetail_Click(object sender, EventArgs e)
		{
			AddOfferDetail();
		}

		void btnPositionLoeschen_Click(object sender, EventArgs e)
		{
			DeleteOfferDetail();
		}

		void ccmdDeleteDetail_Click(object sender, EventArgs e)
		{
			DeleteOfferDetail();
		}

		void btnDrucken_Click(object sender, EventArgs e)
		{
			Print();
		}

		void ccmdPrint2_Click(object sender, EventArgs e)
		{
			Print();
		}

		void ccmdPrint_Click(object sender, EventArgs e)
		{
			Print();
		}

		void xcmdMoveUp_Click(object sender, EventArgs e)
		{
			if (this.myCurrentOfferDetail == null) return;
			this.myOffer.MoveUp(this.myCurrentOfferDetail);
		}

		void xcmdMoveDown_Click(object sender, EventArgs e)
		{
			if (this.myCurrentOfferDetail == null) return;
			this.myOffer.MoveDown(this.myCurrentOfferDetail);
		}

		void btnMailToCustomer_Click(object sender, EventArgs e)
		{
			this.MailToCustomer();
		}

		void mcmdMailToCustomer_Click(object sender, EventArgs e)
		{
			this.MailToCustomer();
		}

		void btnMailToUser_Click(object sender, EventArgs e)
		{
			this.MailToUser();
		}

		void mcmdMailToUser_Click(object sender, EventArgs e)
		{
			this.MailToUser();
		}

		void btnRechner_Click(object sender, EventArgs e)
		{
			ShowCalculator();
		}

		void ccmdTaschenrechner_Click(object sender, EventArgs e)
		{
			ShowCalculator();
		}

		void pnlAngebotsdetail_OnClosed(object sender, EventArgs e)
		{
			ModelManager.OfferService.UpdateOffers(this.myOffer.CustomerId);
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			dgvOfferDetails.AutoGenerateColumns = false;
			if (myOffer != null)
			{
				this.mchkBestellkennzeichen.DataBindings.Add("Checked", myOffer, "Bestellkennzeichen");
				this.mtxtZahlungsbedingungen.DataBindings.Add("Text", myOffer, "Zahlungsbedingungen");
				this.mlblTitle.Text = string.Format("Angebot Nr. {0} vom {1}, (erstellt von {2})", myOffer.OfferId, myOffer.CreateDate, myOffer.CreateUser);
				this.dgvOfferDetails.DataSource = myOffer.OfferDetails.Sort("Position");
			}
		}

		void DeleteOfferDetail()
		{
			if (myCurrentOfferDetail != null)
			{
				ModelManager.OfferService.DeleteOfferDetail(this.myCurrentOfferDetail);
			}
		}

		void AddOfferDetail()
		{
			var psv = new ProductSearchView(myOffer.Customer);
			psv.ProductChosen += Psv_ProductChosen;
			psv.Show();
		}

		void Psv_ProductChosen(object sender, EventArgs e)
		{
			var psv = sender as ProductSearchView;
			var product = psv.SelectedProduct;
			if (product != null)
			{
				ModelManager.OfferService.AddOfferDetail(this.myOffer, product);
				this.dgvOfferDetails.DataSource = this.myOffer.OfferDetails.Sort("Position");
			}
		}

		void Print()
		{
			if (dgvOfferDetails.Rows.Count > 0)
			{
				if (myOffer.Dirty)
				{
					dgvOfferDetails.Focus();
					PdfManager.PdfService.CreateOfferDocument(myOffer);
				}
				else
				{
					PdfManager.PdfService.PrintOffer(myOffer);
				}

				if (this.myOffer.Bestellkennzeichen)
				{
					this.myOffer.SetPrintDateOrder();
				}
				else this.myOffer.SetPrintDateOffer();
			}
		}

		void MailToCustomer()
		{
			Kundenkontakt contact = null;
			var clv = new ContactListView(this.myOffer.Customer);
			if (clv.ShowDialog() == DialogResult.OK && clv.SelectedContact != null)
			{
				contact = clv.SelectedContact;
				var pdfFile = PdfMaker.PdfManager.PdfService.CreateOfferDocument(this.myOffer, false, false);
				var nl = Environment.NewLine;
				var bodyParams = new string[6];
				bodyParams[0] = nl;
				bodyParams[1] = "Sehr geehrte(r)";
				bodyParams[2] = contact.Kontaktname;
				bodyParams[3] = "Vielen Dank für Ihre Anfrage.";
				bodyParams[4] = "Sie finden Ihr Angebot als PDF Datei im Anhang dieser Nachricht.";
				bodyParams[5] = ModelManager.UserService.CurrentUser.Signature;
				var body = string.Format("{1} {2}{0}{0}{3}{0}{4}{0}{0}{5}", bodyParams);
				var newMessage = ModelManager.PostBuedel.CreateMailMessage(contact.E_Mail, "Angebot", body, pdfFile);
				var ev = new EmailView(newMessage, this.myOffer.Customer);
				ev.ShowDialog();
				this.myOffer.SetPrintDateOffer();
			}
		}

		void MailToUser()
		{
			User receivingUser = null;
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK && usv.SelectedUser != null)
			{
				receivingUser = usv.SelectedUser;
				var pdfFile = PdfManager.PdfService.CreateOfferDocument(this.myOffer, true);
				var sendingUser = ModelManager.UserService.CurrentUser;
				var subject = string.Format("Bestellung für {0} (gesendet von {1})", this.myOffer.Customer.CompanyName1, sendingUser.NameFull);
				var body = string.Format("Moin {0}. Kannst Du Dich bitte um die Bestellung für {1} im Anhang kümmern? \n\nBesten Dank\n{2}",
					receivingUser.NameFirst,
					this.myOffer.Customer.CompanyName1,
					sendingUser.NameFirst);
				ModelManager.PostBuedel.SendEmail(receivingUser.EmailWork, subject, body, pdfFile, new List<string> { sendingUser.EmailWork });

				var msg = string.Format("Die Bestellung für {0} wurde an {1} gesendet", this.myOffer.Customer.CompanyName1, receivingUser.NameFull);
				MetroMessageBox.Show(this, msg, "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.myOffer.SetPrintDateOrder();
			}
		}

		void ShowCalculator()
		{
			var calc = new Process();
			calc.StartInfo = new ProcessStartInfo("calc.exe");
			calc.Start();
		}

		#endregion private procedures
	}
}