namespace Products.Common.Views
{
	partial class KundenmaschinenListView
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenmaschinenListView));
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.dgvWhatever = new MetroFramework.Controls.MetroGrid();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModellbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmnuGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdOpenMachine = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdOpenMaschinenauftrag = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdOpenCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdNeueKundenmaschine = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdNeuerMaschinenauftrag = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvWhatever)).BeginInit();
			this.cmnuGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(642, 633);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnClose.TabIndex = 0;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// dgvWhatever
			// 
			this.dgvWhatever.AllowUserToAddRows = false;
			this.dgvWhatever.AllowUserToDeleteRows = false;
			this.dgvWhatever.AllowUserToResizeRows = false;
			this.dgvWhatever.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvWhatever.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvWhatever.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvWhatever.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvWhatever.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvWhatever.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvWhatever.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWhatever.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundennummer,
            this.colMatchcode,
            this.colModellbezeichnung,
            this.colSeriennummer});
			this.dgvWhatever.ContextMenuStrip = this.cmnuGrid;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvWhatever.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvWhatever.EnableHeadersVisualStyles = false;
			this.dgvWhatever.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvWhatever.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvWhatever.HighLightPercentage = 1.2F;
			this.dgvWhatever.Location = new System.Drawing.Point(23, 100);
			this.dgvWhatever.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvWhatever.Name = "dgvWhatever";
			this.dgvWhatever.ReadOnly = true;
			this.dgvWhatever.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvWhatever.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvWhatever.RowHeadersVisible = false;
			this.dgvWhatever.RowHeadersWidth = 21;
			this.dgvWhatever.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvWhatever.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWhatever.Size = new System.Drawing.Size(719, 510);
			this.dgvWhatever.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvWhatever.TabIndex = 1;
			this.dgvWhatever.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWhatever_RowEnter);
			this.dgvWhatever.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvWhatever_MouseDoubleClick);
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "KundennummerCpm";
			this.colKundennummer.FillWeight = 15F;
			this.colKundennummer.HeaderText = "Kunden-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			this.colKundennummer.ReadOnly = true;
			// 
			// colMatchcode
			// 
			this.colMatchcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMatchcode.DataPropertyName = "Matchcode";
			this.colMatchcode.FillWeight = 40F;
			this.colMatchcode.HeaderText = "Firma";
			this.colMatchcode.Name = "colMatchcode";
			this.colMatchcode.ReadOnly = true;
			// 
			// colModellbezeichnung
			// 
			this.colModellbezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colModellbezeichnung.DataPropertyName = "Modellbezeichnung";
			this.colModellbezeichnung.FillWeight = 30F;
			this.colModellbezeichnung.HeaderText = "Modell";
			this.colModellbezeichnung.Name = "colModellbezeichnung";
			this.colModellbezeichnung.ReadOnly = true;
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			this.colSeriennummer.FillWeight = 15F;
			this.colSeriennummer.HeaderText = "Seriennummer";
			this.colSeriennummer.Name = "colSeriennummer";
			this.colSeriennummer.ReadOnly = true;
			// 
			// cmnuGrid
			// 
			this.cmnuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdOpenMachine,
            this.xcmdOpenMaschinenauftrag,
            this.xcmdOpenCustomer,
            this.toolStripMenuItem1,
            this.xcmdNeueKundenmaschine,
            this.xcmdNeuerMaschinenauftrag});
			this.cmnuGrid.Name = "cmnuGrid";
			this.cmnuGrid.Size = new System.Drawing.Size(209, 120);
			this.cmnuGrid.Opening += new System.ComponentModel.CancelEventHandler(this.cmnuGrid_Opening);
			// 
			// xcmdOpenMachine
			// 
			this.xcmdOpenMachine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xcmdOpenMachine.Image = global::Products.Common.Properties.Resources.open_16_metrolime;
			this.xcmdOpenMachine.Name = "xcmdOpenMachine";
			this.xcmdOpenMachine.Size = new System.Drawing.Size(208, 22);
			this.xcmdOpenMachine.Text = "Maschine öffnen";
			this.xcmdOpenMachine.Click += new System.EventHandler(this.xcmdOpenMachine_Click);
			// 
			// xcmdOpenMaschinenauftrag
			// 
			this.xcmdOpenMaschinenauftrag.Image = global::Products.Common.Properties.Resources.open_16_metrored;
			this.xcmdOpenMaschinenauftrag.Name = "xcmdOpenMaschinenauftrag";
			this.xcmdOpenMaschinenauftrag.Size = new System.Drawing.Size(208, 22);
			this.xcmdOpenMaschinenauftrag.Text = "Maschinenauftrag öffnen";
			this.xcmdOpenMaschinenauftrag.Click += new System.EventHandler(this.xcmdOpenMaschinenauftrag_Click);
			// 
			// xcmdOpenCustomer
			// 
			this.xcmdOpenCustomer.Image = global::Products.Common.Properties.Resources.open_16_metroyellow;
			this.xcmdOpenCustomer.Name = "xcmdOpenCustomer";
			this.xcmdOpenCustomer.Size = new System.Drawing.Size(208, 22);
			this.xcmdOpenCustomer.Text = "Kunden öffnen";
			this.xcmdOpenCustomer.Click += new System.EventHandler(this.xcmdOpenCustomer_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
			// 
			// xcmdNeueKundenmaschine
			// 
			this.xcmdNeueKundenmaschine.Image = global::Products.Common.Properties.Resources.add_16_metrolime;
			this.xcmdNeueKundenmaschine.Name = "xcmdNeueKundenmaschine";
			this.xcmdNeueKundenmaschine.Size = new System.Drawing.Size(208, 22);
			this.xcmdNeueKundenmaschine.Text = "Neue Kundenmaschine";
			this.xcmdNeueKundenmaschine.Click += new System.EventHandler(this.xcmdNeueKundenmaschine_Click);
			// 
			// xcmdNeuerMaschinenauftrag
			// 
			this.xcmdNeuerMaschinenauftrag.Image = global::Products.Common.Properties.Resources.add_16_metrored;
			this.xcmdNeuerMaschinenauftrag.Name = "xcmdNeuerMaschinenauftrag";
			this.xcmdNeuerMaschinenauftrag.Size = new System.Drawing.Size(208, 22);
			this.xcmdNeuerMaschinenauftrag.Text = "Neuer Maschinenauftrag";
			this.xcmdNeuerMaschinenauftrag.Click += new System.EventHandler(this.xcmdNeuerMaschinenauftrag_Click);
			// 
			// KundenmaschinenListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 682);
			this.ControlBox = false;
			this.Controls.Add(this.dgvWhatever);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KundenmaschinenListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Kundenmaschinen";
			((System.ComponentModel.ISupportInitialize)(this.dgvWhatever)).EndInit();
			this.cmnuGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroGrid dgvWhatever;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatchcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModellbezeichnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		private MetroFramework.Controls.MetroContextMenu cmnuGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenMachine;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenMaschinenauftrag;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenCustomer;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeueKundenmaschine;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeuerMaschinenauftrag;
	}
}