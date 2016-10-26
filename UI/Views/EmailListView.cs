using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class EmailListView : MetroForm
	{

		#region members

		readonly Angebot myAngebot;
		MailItem mySelectedMailItem;
		FileInfo mySelectedAttachment;

		#endregion

		#region ### .ctor ###

		public EmailListView(Angebot angebot)
		{
			InitializeComponent();
			this.myAngebot = angebot;

			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvAnhang.AutoGenerateColumns = false;
			this.dgvEmails.AutoGenerateColumns = false;
			if (this.myAngebot != null)
			{
				var criteria = string.Format("O{0}", this.myAngebot.Nummer);
				this.dgvEmails.DataSource = Model.ModelManager.DavidService.GetMailItems(criteria);
			}
		}

		void dgvEmails_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedMailItem = this.dgvEmails.Rows[0].DataBoundItem as MailItem;
			if (this.mySelectedMailItem != null)
			{
				// Dateianhänge der Mail suchen
				var attachments = David.DavidManager.DavidService.GetAttachmentList(this.mySelectedMailItem.FullName);
				this.dgvAnhang.DataSource = attachments;
			}
		}
		void dgvAnhang_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedAttachment = this.dgvAnhang.Rows[e.RowIndex].DataBoundItem as FileInfo;
		}

		void dgvAnhang_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedAttachment != null)
			{
				Process.Start(this.mySelectedAttachment.FullName);
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
