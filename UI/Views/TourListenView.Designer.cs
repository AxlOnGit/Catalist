namespace Products.Common.Views
{
	partial class TourListenView
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
			this.dgvTouren = new MetroFramework.Controls.MetroGrid();
			this.colTourname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVertreter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTourSage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.ctxCmdOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnOpen = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvTouren)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTouren
			// 
			this.dgvTouren.AllowUserToAddRows = false;
			this.dgvTouren.AllowUserToDeleteRows = false;
			this.dgvTouren.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvTouren.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTouren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTouren.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTouren.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTouren.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTouren.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTouren.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTouren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTouren.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTourname,
            this.colVertreter,
            this.colTourSage});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTouren.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTouren.EnableHeadersVisualStyles = false;
			this.dgvTouren.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTouren.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTouren.HighLightPercentage = 1.2F;
			this.dgvTouren.Location = new System.Drawing.Point(23, 100);
			this.dgvTouren.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvTouren.Name = "dgvTouren";
			this.dgvTouren.ReadOnly = true;
			this.dgvTouren.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTouren.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTouren.RowHeadersVisible = false;
			this.dgvTouren.RowHeadersWidth = 21;
			this.dgvTouren.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTouren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTouren.Size = new System.Drawing.Size(520, 553);
			this.dgvTouren.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvTouren.TabIndex = 0;
			this.dgvTouren.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTouren_RowEnter);
			this.dgvTouren.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTouren_MouseDoubleClick);
			// 
			// colTourname
			// 
			this.colTourname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTourname.DataPropertyName = "Tourname";
			this.colTourname.FillWeight = 60F;
			this.colTourname.HeaderText = "Tour";
			this.colTourname.Name = "colTourname";
			this.colTourname.ReadOnly = true;
			// 
			// colVertreter
			// 
			this.colVertreter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colVertreter.DataPropertyName = "VertreterName";
			this.colVertreter.FillWeight = 30F;
			this.colVertreter.HeaderText = "Tour von";
			this.colVertreter.Name = "colVertreter";
			this.colVertreter.ReadOnly = true;
			// 
			// colTourSage
			// 
			this.colTourSage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTourSage.DataPropertyName = "TourInSage";
			this.colTourSage.FillWeight = 10F;
			this.colTourSage.HeaderText = "Tour-Nr.";
			this.colTourSage.Name = "colTourSage";
			this.colTourSage.ReadOnly = true;
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCmdOpen});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(112, 26);
			// 
			// ctxCmdOpen
			// 
			this.ctxCmdOpen.Image = global::Products.Common.Properties.Resources.open_16_metroyellow;
			this.ctxCmdOpen.Name = "ctxCmdOpen";
			this.ctxCmdOpen.Size = new System.Drawing.Size(111, 22);
			this.ctxCmdOpen.Text = "Öffnen";
			this.ctxCmdOpen.Click += new System.EventHandler(this.ctxCmdOpen_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(436, 676);
			this.mbtnClose.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 3;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnOpen
			// 
			this.mbtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOpen.Image = null;
			this.mbtnOpen.Location = new System.Drawing.Point(323, 676);
			this.mbtnOpen.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOpen.Name = "mbtnOpen";
			this.mbtnOpen.Size = new System.Drawing.Size(100, 26);
			this.mbtnOpen.TabIndex = 4;
			this.mbtnOpen.Text = "Öffnen";
			this.mbtnOpen.UseSelectable = true;
			this.mbtnOpen.UseVisualStyleBackColor = true;
			this.mbtnOpen.Click += new System.EventHandler(this.mbtnOpen_Click);
			// 
			// TourListenView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 725);
			this.ContextMenuStrip = this.ctxGrid;
			this.Controls.Add(this.mbtnOpen);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvTouren);
			this.Name = "TourListenView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Außendienst-Touren";
			((System.ComponentModel.ISupportInitialize)(this.dgvTouren)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTouren;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTourname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVertreter;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTourSage;
		private MetroFramework.Controls.MetroContextMenu ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdOpen;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOpen;
	}
}