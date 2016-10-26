using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Data;

namespace Products.Common.Views
{
	public partial class UpsShippingView : MetroForm
	{
		#region members

		dsSage.UpsShippingRow mySelectedShipment;

		#endregion members

		#region ### .ctor ###

		public UpsShippingView(Products.Data.dsSage.UpsShippingDataTable baseTable)
		{
			InitializeComponent();
			this.dgvSendungen.AutoGenerateColumns = false;
			this.dgvSendungen.DataSource = baseTable;
			this.AllowDrop = true;
			this.dgvSendungen.AllowDrop = true;
		}

		#endregion ### .ctor ###

		#region event handler

		void dgvSendungen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var drv = this.dgvSendungen.Rows[e.RowIndex].DataBoundItem as DataRowView;
				if (drv != null)
				{
					var tableRow = drv.Row as dsSage.UpsShippingRow;
					this.mySelectedShipment = tableRow;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		void dgvSendungen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Track();
		}

		void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		void dgvDateilinks_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
			{
				var filenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];
				foreach (string filename in filenames)
				{
					MetroMessageBox.Show(this, filename);
				}
			}
		}

		void dgvDateilinks_DragOver(object sender, DragEventArgs e)
		{
			if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
			{
				e.Effect = DragDropEffects.Copy;
			}
			else e.Effect = DragDropEffects.None;
		}

		void dgvShipments_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
			{
				e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler

		void xcmdTracking_Click(object sender, EventArgs e)
		{
			this.Track();
		}

		#region private procedures

		void Track()
		{
			if (this.mySelectedShipment == null) return;
			string trackMe = string.Format("http://wwwapps.ups.com/WebTracking/processInputRequest?sort_by=status&tracknums_displayed=1&TypeOfInquiryNumber=T&loc=en_US&InquiryNumber1=%{0}%&track.x=0&track.y=0\"", mySelectedShipment.TrackingNumber);
			var psi = new ProcessStartInfo(trackMe);
			Process.Start(psi);
		}

		#endregion private procedures

		void mctxUPS_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.xcmdTracking.Enabled = (this.mySelectedShipment != null);
		}
	}
}