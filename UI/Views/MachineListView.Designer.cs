namespace Products.Common.Views
{
	partial class MachineListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineListView));
			this.dgvMachines = new System.Windows.Forms.DataGridView();
			this.colModell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinentyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKaufdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGekauftBei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFarbset = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuNew = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuService = new System.Windows.Forms.ToolStripMenuItem();
			this.wartungsaufträgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuerWartungsauftragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reparaturaufträgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmnuLinkToOtherCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.lnkClose = new System.Windows.Forms.LinkLabel();
			this.panelCommand = new System.Windows.Forms.Panel();
			this.lnkShowDetails = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.lnkNewMachine = new System.Windows.Forms.LinkLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.panelCommand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMachines
			// 
			this.dgvMachines.AllowUserToAddRows = false;
			this.dgvMachines.AllowUserToDeleteRows = false;
			this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModell,
            this.colMaschinentyp,
            this.colHersteller,
            this.colSeriennummer,
            this.colKaufdatum,
            this.colGekauftBei,
            this.colTinte,
            this.colFarbset,
            this.colAnmerkungen});
			this.dgvMachines.ContextMenuStrip = this.ctxGrid;
			this.dgvMachines.Location = new System.Drawing.Point(12, 12);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersWidth = 25;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvMachines.Size = new System.Drawing.Size(1158, 434);
			this.dgvMachines.TabIndex = 0;
			this.dgvMachines.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_RowEnter);
			this.dgvMachines.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMachines_MouseDoubleClick);
			// 
			// colModell
			// 
			this.colModell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colModell.DataPropertyName = "Modell";
			this.colModell.HeaderText = "Maschine";
			this.colModell.Name = "colModell";
			this.colModell.ReadOnly = true;
			this.colModell.Width = 81;
			// 
			// colMaschinentyp
			// 
			this.colMaschinentyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colMaschinentyp.DataPropertyName = "Maschinentyp";
			this.colMaschinentyp.HeaderText = "Typ";
			this.colMaschinentyp.MinimumWidth = 120;
			this.colMaschinentyp.Name = "colMaschinentyp";
			this.colMaschinentyp.Width = 120;
			// 
			// colHersteller
			// 
			this.colHersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHersteller.DataPropertyName = "Hersteller";
			this.colHersteller.HeaderText = "Hersteller";
			this.colHersteller.MinimumWidth = 120;
			this.colHersteller.Name = "colHersteller";
			this.colHersteller.Width = 120;
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			this.colSeriennummer.HeaderText = "Serien-Nr.";
			this.colSeriennummer.Name = "colSeriennummer";
			this.colSeriennummer.Width = 83;
			// 
			// colKaufdatum
			// 
			this.colKaufdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKaufdatum.DataPropertyName = "Kaufdatum";
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			this.colKaufdatum.DefaultCellStyle = dataGridViewCellStyle1;
			this.colKaufdatum.HeaderText = "Kaufdatum";
			this.colKaufdatum.Name = "colKaufdatum";
			this.colKaufdatum.Width = 88;
			// 
			// colGekauftBei
			// 
			this.colGekauftBei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colGekauftBei.DataPropertyName = "GekauftBei";
			this.colGekauftBei.HeaderText = "gekauft bei";
			this.colGekauftBei.Name = "colGekauftBei";
			this.colGekauftBei.Width = 91;
			// 
			// colTinte
			// 
			this.colTinte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTinte.DataPropertyName = "Tinte";
			this.colTinte.HeaderText = "Tinte";
			this.colTinte.Name = "colTinte";
			this.colTinte.ReadOnly = true;
			this.colTinte.Width = 57;
			// 
			// colFarbset
			// 
			this.colFarbset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colFarbset.DataPropertyName = "Farbset";
			this.colFarbset.HeaderText = "Farbset";
			this.colFarbset.Name = "colFarbset";
			this.colFarbset.Width = 70;
			// 
			// colAnmerkungen
			// 
			this.colAnmerkungen.DataPropertyName = "Anmerkungen";
			this.colAnmerkungen.HeaderText = "Anmerkungen";
			this.colAnmerkungen.MinimumWidth = 400;
			this.colAnmerkungen.Name = "colAnmerkungen";
			this.colAnmerkungen.Width = 400;
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOpen,
            this.cmnuNew,
            this.cmnuService,
            this.cmnuSeparator1,
            this.cmnuLinkToOtherCustomer});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(157, 98);
			// 
			// cmnuOpen
			// 
			this.cmnuOpen.Name = "cmnuOpen";
			this.cmnuOpen.Size = new System.Drawing.Size(156, 22);
			this.cmnuOpen.Text = "Öffnen";
			// 
			// cmnuNew
			// 
			this.cmnuNew.Name = "cmnuNew";
			this.cmnuNew.Size = new System.Drawing.Size(156, 22);
			this.cmnuNew.Text = "Neue Maschine";
			// 
			// cmnuService
			// 
			this.cmnuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wartungsaufträgeToolStripMenuItem,
            this.neuerWartungsauftragToolStripMenuItem,
            this.reparaturaufträgeToolStripMenuItem});
			this.cmnuService.Name = "cmnuService";
			this.cmnuService.Size = new System.Drawing.Size(156, 22);
			this.cmnuService.Text = "Service";
			// 
			// wartungsaufträgeToolStripMenuItem
			// 
			this.wartungsaufträgeToolStripMenuItem.Name = "wartungsaufträgeToolStripMenuItem";
			this.wartungsaufträgeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.wartungsaufträgeToolStripMenuItem.Text = "Wartungsaufträge";
			// 
			// neuerWartungsauftragToolStripMenuItem
			// 
			this.neuerWartungsauftragToolStripMenuItem.Name = "neuerWartungsauftragToolStripMenuItem";
			this.neuerWartungsauftragToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.neuerWartungsauftragToolStripMenuItem.Text = "Neuer Wartungsauftrag";
			// 
			// reparaturaufträgeToolStripMenuItem
			// 
			this.reparaturaufträgeToolStripMenuItem.Name = "reparaturaufträgeToolStripMenuItem";
			this.reparaturaufträgeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.reparaturaufträgeToolStripMenuItem.Text = "Reparaturaufträge";
			// 
			// cmnuSeparator1
			// 
			this.cmnuSeparator1.Name = "cmnuSeparator1";
			this.cmnuSeparator1.Size = new System.Drawing.Size(153, 6);
			// 
			// cmnuLinkToOtherCustomer
			// 
			this.cmnuLinkToOtherCustomer.Image = global::Products.Common.Properties.Resources.ausrufezeichen01;
			this.cmnuLinkToOtherCustomer.Name = "cmnuLinkToOtherCustomer";
			this.cmnuLinkToOtherCustomer.Size = new System.Drawing.Size(156, 22);
			this.cmnuLinkToOtherCustomer.Text = "Neu zuordnen";
			this.cmnuLinkToOtherCustomer.Click += new System.EventHandler(this.cmnuLinkToOtherCustomer_Click);
			// 
			// lnkClose
			// 
			this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkClose.AutoSize = true;
			this.lnkClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkClose.Location = new System.Drawing.Point(1108, 497);
			this.lnkClose.Name = "lnkClose";
			this.lnkClose.Size = new System.Drawing.Size(62, 17);
			this.lnkClose.TabIndex = 3;
			this.lnkClose.TabStop = true;
			this.lnkClose.Text = "Schließen";
			this.lnkClose.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
			// 
			// panelCommand
			// 
			this.panelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCommand.Controls.Add(this.lnkShowDetails);
			this.panelCommand.Controls.Add(this.linkLabel1);
			this.panelCommand.Controls.Add(this.lnkNewMachine);
			this.panelCommand.Location = new System.Drawing.Point(56, 474);
			this.panelCommand.Name = "panelCommand";
			this.panelCommand.Size = new System.Drawing.Size(1046, 48);
			this.panelCommand.TabIndex = 51;
			// 
			// lnkShowDetails
			// 
			this.lnkShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkShowDetails.AutoSize = true;
			this.lnkShowDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkShowDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkShowDetails.Location = new System.Drawing.Point(3, 16);
			this.lnkShowDetails.Name = "lnkShowDetails";
			this.lnkShowDetails.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.lnkShowDetails.Size = new System.Drawing.Size(77, 17);
			this.lnkShowDetails.TabIndex = 48;
			this.lnkShowDetails.TabStop = true;
			this.lnkShowDetails.Text = "Ö&ffnen";
			this.lnkShowDetails.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkShowDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowDetails_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1.Location = new System.Drawing.Point(222, 16);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.linkLabel1.Size = new System.Drawing.Size(79, 17);
			this.linkLabel1.TabIndex = 47;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "&Service";
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkServicetermine_LinkClicked);
			// 
			// lnkNewMachine
			// 
			this.lnkNewMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkNewMachine.AutoSize = true;
			this.lnkNewMachine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkNewMachine.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkNewMachine.Location = new System.Drawing.Point(88, 16);
			this.lnkNewMachine.Name = "lnkNewMachine";
			this.lnkNewMachine.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.lnkNewMachine.Size = new System.Drawing.Size(128, 17);
			this.lnkNewMachine.TabIndex = 46;
			this.lnkNewMachine.TabStop = true;
			this.lnkNewMachine.Text = "&Neue Maschine";
			this.lnkNewMachine.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkNewMachine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewMachine_LinkClicked);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::Products.Common.Properties.Resources.Liste2_metrogreen;
			this.pictureBox2.Location = new System.Drawing.Point(2, 474);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 50;
			this.pictureBox2.TabStop = false;
			// 
			// MachineListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1182, 523);
			this.Controls.Add(this.panelCommand);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lnkClose);
			this.Controls.Add(this.dgvMachines);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MachineListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Maschinenliste";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineListView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.panelCommand.ResumeLayout(false);
			this.panelCommand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMachines;
		private System.Windows.Forms.LinkLabel lnkClose;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panelCommand;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel lnkNewMachine;
		private System.Windows.Forms.LinkLabel lnkShowDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModell;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinentyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHersteller;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKaufdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGekauftBei;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTinte;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFarbset;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAnmerkungen;
		private System.Windows.Forms.ContextMenuStrip ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem cmnuOpen;
		private System.Windows.Forms.ToolStripMenuItem cmnuNew;
		private System.Windows.Forms.ToolStripMenuItem cmnuService;
		private System.Windows.Forms.ToolStripMenuItem wartungsaufträgeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem neuerWartungsauftragToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reparaturaufträgeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator cmnuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cmnuLinkToOtherCustomer;
	}
}