namespace Products.Common.Views
{
	partial class MaschinenmodellTreeView
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hersteller");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaschinenmodellTreeView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.containerMain = new System.Windows.Forms.SplitContainer();
			this.trvModels = new System.Windows.Forms.TreeView();
			this.xmnuTree = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdNeuerHersteller = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdHerstellerOeffnen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdNeueSerie = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdSerieOeffnen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdNeuesModell = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdKundenmaschinenlisteSerie = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgvModelle = new MetroFramework.Controls.MetroGrid();
			this.colModellbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHerstellername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModellSerienName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xmnuGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdOpenModel = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdNewModel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdKundenmaschinenListe = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdDeleteModel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdNeueKundenmaschine = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdNeuerMaschinenauftrag = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
			this.containerMain.Panel1.SuspendLayout();
			this.containerMain.Panel2.SuspendLayout();
			this.containerMain.SuspendLayout();
			this.xmnuTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvModelle)).BeginInit();
			this.xmnuGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(1032, 751);
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
			// containerMain
			// 
			this.containerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.containerMain.Location = new System.Drawing.Point(23, 100);
			this.containerMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.containerMain.Name = "containerMain";
			// 
			// containerMain.Panel1
			// 
			this.containerMain.Panel1.Controls.Add(this.trvModels);
			this.containerMain.Panel1.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
			// 
			// containerMain.Panel2
			// 
			this.containerMain.Panel2.Controls.Add(this.dgvModelle);
			this.containerMain.Size = new System.Drawing.Size(1109, 628);
			this.containerMain.SplitterDistance = 369;
			this.containerMain.TabIndex = 7;
			// 
			// trvModels
			// 
			this.trvModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvModels.ContextMenuStrip = this.xmnuTree;
			this.trvModels.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvModels.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.trvModels.ImageIndex = 0;
			this.trvModels.ImageList = this.imageList1;
			this.trvModels.ItemHeight = 24;
			this.trvModels.LineColor = System.Drawing.Color.Gray;
			this.trvModels.Location = new System.Drawing.Point(5, 20);
			this.trvModels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trvModels.Name = "trvModels";
			treeNode1.Name = "nodeHersteller";
			treeNode1.Text = "Hersteller";
			this.trvModels.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.trvModels.SelectedImageIndex = 0;
			this.trvModels.ShowLines = false;
			this.trvModels.ShowPlusMinus = false;
			this.trvModels.ShowRootLines = false;
			this.trvModels.Size = new System.Drawing.Size(359, 603);
			this.trvModels.TabIndex = 7;
			this.trvModels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvModels_AfterSelect);
			this.trvModels.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvModels_NodeMouseDoubleClick);
			// 
			// xmnuTree
			// 
			this.xmnuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdNeuerHersteller,
            this.xcmdHerstellerOeffnen,
            this.toolStripMenuItem1,
            this.xcmdNeueSerie,
            this.xcmdSerieOeffnen,
            this.toolStripMenuItem2,
            this.xcmdNeuesModell,
            this.toolStripMenuItem5,
            this.xcmdKundenmaschinenlisteSerie});
			this.xmnuTree.Name = "xmnuTree";
			this.xmnuTree.Size = new System.Drawing.Size(257, 154);
			this.xmnuTree.Opening += new System.ComponentModel.CancelEventHandler(this.xmnuTree_Opening);
			// 
			// xcmdNeuerHersteller
			// 
			this.xcmdNeuerHersteller.Enabled = false;
			this.xcmdNeuerHersteller.Image = global::Products.Common.Properties.Resources.add_16_metroblue;
			this.xcmdNeuerHersteller.Name = "xcmdNeuerHersteller";
			this.xcmdNeuerHersteller.Size = new System.Drawing.Size(256, 22);
			this.xcmdNeuerHersteller.Text = "Neuer Hersteller";
			this.xcmdNeuerHersteller.Click += new System.EventHandler(this.xcmdNeuerHersteller_Click);
			// 
			// xcmdHerstellerOeffnen
			// 
			this.xcmdHerstellerOeffnen.Enabled = false;
			this.xcmdHerstellerOeffnen.Image = global::Products.Common.Properties.Resources.open_16_metroblue;
			this.xcmdHerstellerOeffnen.Name = "xcmdHerstellerOeffnen";
			this.xcmdHerstellerOeffnen.Size = new System.Drawing.Size(256, 22);
			this.xcmdHerstellerOeffnen.Text = "Hersteller öffnen";
			this.xcmdHerstellerOeffnen.Click += new System.EventHandler(this.xcmdHerstellerOeffnen_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
			// 
			// xcmdNeueSerie
			// 
			this.xcmdNeueSerie.Enabled = false;
			this.xcmdNeueSerie.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdNeueSerie.Name = "xcmdNeueSerie";
			this.xcmdNeueSerie.Size = new System.Drawing.Size(256, 22);
			this.xcmdNeueSerie.Text = "Neue Serie";
			this.xcmdNeueSerie.Click += new System.EventHandler(this.xcmdNeueSerie_Click);
			// 
			// xcmdSerieOeffnen
			// 
			this.xcmdSerieOeffnen.Enabled = false;
			this.xcmdSerieOeffnen.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdSerieOeffnen.Name = "xcmdSerieOeffnen";
			this.xcmdSerieOeffnen.Size = new System.Drawing.Size(256, 22);
			this.xcmdSerieOeffnen.Text = "Serie öffnen";
			this.xcmdSerieOeffnen.Click += new System.EventHandler(this.xcmdSerieOeffnen_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
			// 
			// xcmdNeuesModell
			// 
			this.xcmdNeuesModell.Enabled = false;
			this.xcmdNeuesModell.Image = global::Products.Common.Properties.Resources.add_16_metrolime;
			this.xcmdNeuesModell.Name = "xcmdNeuesModell";
			this.xcmdNeuesModell.Size = new System.Drawing.Size(256, 22);
			this.xcmdNeuesModell.Text = "Neues Modell";
			this.xcmdNeuesModell.Click += new System.EventHandler(this.xcmdNeuesModell_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(253, 6);
			// 
			// xcmdKundenmaschinenlisteSerie
			// 
			this.xcmdKundenmaschinenlisteSerie.Enabled = false;
			this.xcmdKundenmaschinenlisteSerie.Image = global::Products.Common.Properties.Resources.list_16_metrolime;
			this.xcmdKundenmaschinenlisteSerie.Name = "xcmdKundenmaschinenlisteSerie";
			this.xcmdKundenmaschinenlisteSerie.Size = new System.Drawing.Size(256, 22);
			this.xcmdKundenmaschinenlisteSerie.Text = "Liste der Kundenmaschinen (Serie)";
			this.xcmdKundenmaschinenlisteSerie.Click += new System.EventHandler(this.xcmdKundenmaschinenlisteSerie_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "hersteller_16_black.png");
			this.imageList1.Images.SetKeyName(1, "hersteller_16_red.png");
			// 
			// dgvModelle
			// 
			this.dgvModelle.AllowUserToAddRows = false;
			this.dgvModelle.AllowUserToDeleteRows = false;
			this.dgvModelle.AllowUserToResizeRows = false;
			this.dgvModelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvModelle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvModelle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModelle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvModelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModellbezeichnung,
            this.colHerstellername,
            this.colModellSerienName});
			this.dgvModelle.ContextMenuStrip = this.xmnuGrid;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvModelle.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvModelle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvModelle.EnableHeadersVisualStyles = false;
			this.dgvModelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvModelle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModelle.HighLightPercentage = 1.2F;
			this.dgvModelle.Location = new System.Drawing.Point(0, 0);
			this.dgvModelle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvModelle.Name = "dgvModelle";
			this.dgvModelle.ReadOnly = true;
			this.dgvModelle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModelle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvModelle.RowHeadersVisible = false;
			this.dgvModelle.RowHeadersWidth = 21;
			this.dgvModelle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvModelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvModelle.Size = new System.Drawing.Size(736, 628);
			this.dgvModelle.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvModelle.TabIndex = 2;
			this.dgvModelle.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWhatever_RowEnter);
			this.dgvModelle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvWhatever_MouseDoubleClick);
			// 
			// colModellbezeichnung
			// 
			this.colModellbezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colModellbezeichnung.DataPropertyName = "Modellbezeichnung";
			this.colModellbezeichnung.HeaderText = "Modell";
			this.colModellbezeichnung.Name = "colModellbezeichnung";
			this.colModellbezeichnung.ReadOnly = true;
			// 
			// colHerstellername
			// 
			this.colHerstellername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHerstellername.DataPropertyName = "Herstellername";
			this.colHerstellername.HeaderText = "Hersteller";
			this.colHerstellername.Name = "colHerstellername";
			this.colHerstellername.ReadOnly = true;
			// 
			// colModellSerienName
			// 
			this.colModellSerienName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colModellSerienName.DataPropertyName = "ModellSerienName";
			this.colModellSerienName.HeaderText = "Serie";
			this.colModellSerienName.Name = "colModellSerienName";
			this.colModellSerienName.ReadOnly = true;
			// 
			// xmnuGrid
			// 
			this.xmnuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdOpenModel,
            this.xcmdNewModel,
            this.toolStripMenuItem4,
            this.xcmdKundenmaschinenListe,
            this.toolStripMenuItem3,
            this.xcmdDeleteModel,
            this.toolStripMenuItem8,
            this.xcmdNeueKundenmaschine,
            this.xcmdNeuerMaschinenauftrag});
			this.xmnuGrid.Name = "xmnuGrid";
			this.xmnuGrid.Size = new System.Drawing.Size(269, 154);
			this.xmnuGrid.Opening += new System.ComponentModel.CancelEventHandler(this.xmnuGrid_Opening);
			// 
			// xcmdOpenModel
			// 
			this.xcmdOpenModel.Enabled = false;
			this.xcmdOpenModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xcmdOpenModel.Image = global::Products.Common.Properties.Resources.open_16_metrolime;
			this.xcmdOpenModel.Name = "xcmdOpenModel";
			this.xcmdOpenModel.Size = new System.Drawing.Size(268, 22);
			this.xcmdOpenModel.Text = "Modell öffnen";
			this.xcmdOpenModel.Click += new System.EventHandler(this.xcmdModellOeffnen_Click);
			// 
			// xcmdNewModel
			// 
			this.xcmdNewModel.Enabled = false;
			this.xcmdNewModel.Image = global::Products.Common.Properties.Resources.add_16_metrolime;
			this.xcmdNewModel.Name = "xcmdNewModel";
			this.xcmdNewModel.Size = new System.Drawing.Size(268, 22);
			this.xcmdNewModel.Text = "Neues Modell";
			this.xcmdNewModel.Click += new System.EventHandler(this.xcmdNewModel_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(265, 6);
			// 
			// xcmdKundenmaschinenListe
			// 
			this.xcmdKundenmaschinenListe.Enabled = false;
			this.xcmdKundenmaschinenListe.Image = global::Products.Common.Properties.Resources.list_16_metrolime;
			this.xcmdKundenmaschinenListe.Name = "xcmdKundenmaschinenListe";
			this.xcmdKundenmaschinenListe.Size = new System.Drawing.Size(268, 22);
			this.xcmdKundenmaschinenListe.Text = "Liste der Kundenmaschinen (Modell)";
			this.xcmdKundenmaschinenListe.Click += new System.EventHandler(this.xcmdKundenmaschinenListe_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(265, 6);
			// 
			// xcmdDeleteModel
			// 
			this.xcmdDeleteModel.Enabled = false;
			this.xcmdDeleteModel.Image = global::Products.Common.Properties.Resources.garbage_16_metrolime;
			this.xcmdDeleteModel.Name = "xcmdDeleteModel";
			this.xcmdDeleteModel.Size = new System.Drawing.Size(268, 22);
			this.xcmdDeleteModel.Text = "Modell löschen";
			this.xcmdDeleteModel.Click += new System.EventHandler(this.xcmdModellLoeschen_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(265, 6);
			// 
			// xcmdNeueKundenmaschine
			// 
			this.xcmdNeueKundenmaschine.Enabled = false;
			this.xcmdNeueKundenmaschine.Image = global::Products.Common.Properties.Resources.add_16_metrolime;
			this.xcmdNeueKundenmaschine.Name = "xcmdNeueKundenmaschine";
			this.xcmdNeueKundenmaschine.Size = new System.Drawing.Size(268, 22);
			this.xcmdNeueKundenmaschine.Text = "Neue Kundenmaschine";
			this.xcmdNeueKundenmaschine.Click += new System.EventHandler(this.xcmdNeueKundenmaschine_Click);
			// 
			// xcmdNeuerMaschinenauftrag
			// 
			this.xcmdNeuerMaschinenauftrag.Enabled = false;
			this.xcmdNeuerMaschinenauftrag.Image = global::Products.Common.Properties.Resources.add_16_metrored;
			this.xcmdNeuerMaschinenauftrag.Name = "xcmdNeuerMaschinenauftrag";
			this.xcmdNeuerMaschinenauftrag.Size = new System.Drawing.Size(268, 22);
			this.xcmdNeuerMaschinenauftrag.Text = "Neuer Maschinenauftrag";
			this.xcmdNeuerMaschinenauftrag.Click += new System.EventHandler(this.xcmdNeuerMaschinenauftrag_Click);
			// 
			// MaschinenmodellTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 800);
			this.ControlBox = false;
			this.Controls.Add(this.containerMain);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MaschinenmodellTreeView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Hersteller, Maschinenserien und -modelle";
			this.containerMain.Panel1.ResumeLayout(false);
			this.containerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
			this.containerMain.ResumeLayout(false);
			this.xmnuTree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvModelle)).EndInit();
			this.xmnuGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.SplitContainer containerMain;
		private System.Windows.Forms.TreeView trvModels;
		private MetroFramework.Controls.MetroGrid dgvModelle;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModellbezeichnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHerstellername;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModellSerienName;
		private MetroFramework.Controls.MetroContextMenu xmnuTree;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeuerHersteller;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeueSerie;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeuesModell;
		private MetroFramework.Controls.MetroContextMenu xmnuGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenModel;
		private System.Windows.Forms.ToolStripMenuItem xcmdNewModel;
		private System.Windows.Forms.ToolStripMenuItem xcmdHerstellerOeffnen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdSerieOeffnen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem xcmdDeleteModel;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem xcmdKundenmaschinenListe;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem xcmdKundenmaschinenlisteSerie;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeueKundenmaschine;
		private System.Windows.Forms.ToolStripMenuItem xcmdNeuerMaschinenauftrag;
	}
}