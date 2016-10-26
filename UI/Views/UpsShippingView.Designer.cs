namespace Products.Common.Views
{
	partial class UpsShippingView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpsShippingView));
			this.dgvSendungen = new MetroFramework.Controls.MetroGrid();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRerenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTrackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coleMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxUPS = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdTracking = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSendungen)).BeginInit();
			this.mctxUPS.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSendungen
			// 
			this.dgvSendungen.AllowUserToAddRows = false;
			this.dgvSendungen.AllowUserToDeleteRows = false;
			this.dgvSendungen.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvSendungen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSendungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSendungen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSendungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSendungen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSendungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSendungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSendungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSendungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDatum,
            this.colRerenz,
            this.colKg,
            this.colTrackingNumber,
            this.coleMail});
			this.dgvSendungen.ContextMenuStrip = this.mctxUPS;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSendungen.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSendungen.EnableHeadersVisualStyles = false;
			this.dgvSendungen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSendungen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSendungen.HighLightPercentage = 0.99F;
			this.dgvSendungen.Location = new System.Drawing.Point(23, 100);
			this.dgvSendungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvSendungen.MultiSelect = false;
			this.dgvSendungen.Name = "dgvSendungen";
			this.dgvSendungen.ReadOnly = true;
			this.dgvSendungen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSendungen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSendungen.RowHeadersVisible = false;
			this.dgvSendungen.RowHeadersWidth = 21;
			this.dgvSendungen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSendungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSendungen.Size = new System.Drawing.Size(819, 446);
			this.dgvSendungen.Style = MetroFramework.MetroColorStyle.Silver;
			this.dgvSendungen.TabIndex = 70;
			this.dgvSendungen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSendungen_RowEnter);
			this.dgvSendungen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSendungen_MouseDoubleClick);
			// 
			// colDatum
			// 
			this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum.DataPropertyName = "Datum";
			this.colDatum.FillWeight = 10F;
			this.colDatum.HeaderText = "Datum";
			this.colDatum.Name = "colDatum";
			this.colDatum.ReadOnly = true;
			// 
			// colRerenz
			// 
			this.colRerenz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colRerenz.DataPropertyName = "Rerenz";
			this.colRerenz.FillWeight = 20F;
			this.colRerenz.HeaderText = "Referenz";
			this.colRerenz.Name = "colRerenz";
			this.colRerenz.ReadOnly = true;
			// 
			// colKg
			// 
			this.colKg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKg.DataPropertyName = "Kg";
			this.colKg.FillWeight = 10F;
			this.colKg.HeaderText = "Gewicht";
			this.colKg.Name = "colKg";
			this.colKg.ReadOnly = true;
			// 
			// colTrackingNumber
			// 
			this.colTrackingNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTrackingNumber.DataPropertyName = "TrackingNumber";
			this.colTrackingNumber.FillWeight = 30F;
			this.colTrackingNumber.HeaderText = "Tracking-Nr.";
			this.colTrackingNumber.Name = "colTrackingNumber";
			this.colTrackingNumber.ReadOnly = true;
			// 
			// coleMail
			// 
			this.coleMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.coleMail.DataPropertyName = "eMail";
			this.coleMail.FillWeight = 30F;
			this.coleMail.HeaderText = "E-Mail";
			this.coleMail.Name = "coleMail";
			this.coleMail.ReadOnly = true;
			// 
			// mctxUPS
			// 
			this.mctxUPS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdTracking});
			this.mctxUPS.Name = "mctxUPS";
			this.mctxUPS.Size = new System.Drawing.Size(120, 26);
			this.mctxUPS.Opening += new System.ComponentModel.CancelEventHandler(this.mctxUPS_Opening);
			// 
			// xcmdTracking
			// 
			this.xcmdTracking.Image = global::Products.Common.Properties.Resources.iexplore_16_metrosilver;
			this.xcmdTracking.Name = "xcmdTracking";
			this.xcmdTracking.Size = new System.Drawing.Size(119, 22);
			this.xcmdTracking.Text = "Tracking";
			this.xcmdTracking.Click += new System.EventHandler(this.xcmdTracking_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(742, 569);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Silver;
			this.mbtnClose.TabIndex = 71;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// UpsShippingView
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 618);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvSendungen);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpsShippingView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowIcon = false;
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "UPS Sendungen für ";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dgvSendungen)).EndInit();
			this.mctxUPS.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvSendungen;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRerenz;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKg;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTrackingNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn coleMail;
		private MetroFramework.Controls.MetroContextMenu mctxUPS;
		private System.Windows.Forms.ToolStripMenuItem xcmdTracking;
	}
}