using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model;

namespace Products.Common.Views
{
	public partial class EmailView : MetroForm
	{
		#region members

		MailMessage myMessage;
		Model.Entities.Kunde myKunde;
		List<string> myCcList;
		List<string> myBccList;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Initialisiert eine neue Instanz der EmailView Klasse.
		/// </summary>
		public EmailView(MailMessage message, Model.Entities.Kunde kunde)
		{
			InitializeComponent();
			this.myMessage = message;
			this.myKunde = kunde;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void mlblCc_Click(object sender, EventArgs e)
		{
			var clv = new ContactListView(this.myKunde);
			if (clv.ShowDialog() == DialogResult.OK)
			{
				if (this.myCcList == null)
				{
					this.myCcList = new List<string>();
				}
				this.myCcList.Add(clv.SelectedContact.E_Mail);
				this.UpdateCcTextbox();
			}
		}

		void mlblBcc_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK)
			{
				if (this.myBccList == null)
				{
					this.myBccList = new List<string>();
				}
				this.myBccList.Add(usv.SelectedUser.EmailWork);
			}
			this.UpdateBccTextbox();
		}

		void mtxtBcc_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back && this.myBccList.Count > 0)
			{
				int indexLast = this.myBccList.Count - 1;
				this.myBccList.RemoveAt(indexLast);
			}
			this.UpdateBccTextbox();
		}

		void mtxtCc_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back && this.myCcList.Count > 0)
			{
				int indexLast = this.myCcList.Count - 1;
				this.myCcList.RemoveAt(indexLast);
			}
			this.UpdateCcTextbox();
		}

		void btnSend_Click(object sender, EventArgs e)
		{
			if (this.myMessage.To.Count == 0)
			{
				MetroMessageBox.Show(this, "Also, einen Empfänger sollte es schon geben.", "Der Catalist Postbüdel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (string.IsNullOrEmpty(this.myMessage.Subject))
			{
				if (MetroMessageBox.Show(this, "Soll die Nachricht jetzt echt ohne Betreff verschickt werden?", "Der Catalist Postbüdel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
				{
					return;
				}
			}
			if (myCcList != null && myCcList.Count > 0)
			{
				foreach (var address in this.myCcList)
				{
					this.myMessage.CC.Add(address);
				}
			}
			// Die Bcc Empfänger eintragen (der Verfasser wird selbst immer aufgenommen)
			if (this.myBccList != null && this.myBccList.Count > 0)
			{
				foreach (var address in this.myBccList)
				{
					this.myMessage.Bcc.Add(address);
				}
				this.myMessage.Bcc.Add(Model.ModelManager.UserService.CurrentUser.EmailWork);
			}
			else this.myMessage.Bcc.Add(Model.ModelManager.UserService.CurrentUser.EmailWork);

			ModelManager.PostBuedel.SendEmail(this.myMessage);
			MetroMessageBox.Show(this, "Die E-Mail und eine Kopie an Dich selbst sind unterwegs ...", "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.mlblFrom.DataBindings.Add("Text", this.myMessage.From, "Address");
			if (this.myMessage.To.Count == 1) this.mtxtTo.DataBindings.Add("Text", this.myMessage.To[0], "Address");
			if (this.myMessage.CC.Count == 1) this.mtxtCc.DataBindings.Add("Text", this.myMessage.CC[0], "Address");
			this.mtxtSubject.DataBindings.Add("Text", this.myMessage, "Subject");
			this.mtxtBody.DataBindings.Add("Text", this.myMessage, "Body");
			this.mlblAngebot.DataBindings.Add("Text", this.myMessage.Attachments[0], "Name");
		}

		void UpdateCcTextbox()
		{
			if (this.myCcList != null)
			{
				if (this.myCcList.Count > 0)
				{
					this.mtxtCc.Text = this.myCcList[0];
					for (int i = 1; i < this.myCcList.Count; i++)
					{
						this.mtxtCc.Text += string.Format("; {0}", this.myCcList[i]);
					}
				}
				else this.mtxtCc.Text = string.Empty;
			}
			else this.mtxtCc.Text = string.Empty;
		}

		void UpdateBccTextbox()
		{
			if (this.myBccList != null)
			{
				if (this.myBccList.Count > 0)
				{
					this.mtxtBcc.Text = this.myBccList[0];
					for (int i = 1; i < this.myBccList.Count; i++)
					{
						this.mtxtBcc.Text += string.Format("; {0}", this.myBccList[i]);
					}
				}
				else this.mtxtBcc.Text = string.Empty;
			}
			else this.mtxtBcc.Text = string.Empty;
		}

		#endregion private procedures
	}
}