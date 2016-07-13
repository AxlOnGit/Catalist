namespace Products.Common.Views
{
	partial class MainView
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.lnkClose = new System.Windows.Forms.LinkLabel();
			this.lnkTest = new System.Windows.Forms.LinkLabel();
			this.errSearch = new System.Windows.Forms.ErrorProvider(this.components);
			this.tBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ctxTbarIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxCmdShowMainView = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxCmdShowSettingsView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxCmdQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.lnkDummy = new System.Windows.Forms.LinkLabel();
			this.lblCurrentUser = new System.Windows.Forms.Label();
			this.ctxView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxCmdMaschinentypen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxCmdViewQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.txtSearchCustomer = new Products.Common.Controls.axlTextbox();
			this.picTopMost = new System.Windows.Forms.PictureBox();
			this.lnkQuit = new System.Windows.Forms.LinkLabel();
			this.lnkShowOfferView = new System.Windows.Forms.LinkLabel();
			this.lnkShowPresets = new System.Windows.Forms.LinkLabel();
			this.lnkCreateCatalog = new System.Windows.Forms.LinkLabel();
			this.lnkKatalog = new System.Windows.Forms.LinkLabel();
			this.lnkArtikel = new System.Windows.Forms.LinkLabel();
			this.lnkKalender = new System.Windows.Forms.LinkLabel();
			this.picLineOpen = new System.Windows.Forms.PictureBox();
			this.picCPM = new System.Windows.Forms.PictureBox();
			this.WhatClock = new AnalogClock.Clock();
			((System.ComponentModel.ISupportInitialize)(this.errSearch)).BeginInit();
			this.ctxTbarIcon.SuspendLayout();
			this.ctxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTopMost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLineOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCPM)).BeginInit();
			this.SuspendLayout();
			// 
			// lnkClose
			// 
			this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkClose.AutoSize = true;
			this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkClose.Location = new System.Drawing.Point(260, 605);
			this.lnkClose.Name = "lnkClose";
			this.lnkClose.Size = new System.Drawing.Size(65, 13);
			this.lnkClose.TabIndex = 8;
			this.lnkClose.TabStop = true;
			this.lnkClose.Text = "Minimieren";
			this.lnkClose.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
			// 
			// lnkTest
			// 
			this.lnkTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkTest.AutoSize = true;
			this.lnkTest.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkTest.Location = new System.Drawing.Point(29, 60);
			this.lnkTest.Name = "lnkTest";
			this.lnkTest.Size = new System.Drawing.Size(26, 13);
			this.lnkTest.TabIndex = 72;
			this.lnkTest.TabStop = true;
			this.lnkTest.Text = "Test";
			this.lnkTest.Visible = false;
			this.lnkTest.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTest_LinkClicked);
			// 
			// errSearch
			// 
			this.errSearch.ContainerControl = this;
			this.errSearch.Icon = ((System.Drawing.Icon)(resources.GetObject("errSearch.Icon")));
			// 
			// tBarIcon
			// 
			this.tBarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.tBarIcon.BalloonTipText = "Wenn das hier läuft, wird das Telefon überwacht und anrufende Kunden werden angez" +
		"eigt. Cool, oder?!";
			this.tBarIcon.BalloonTipTitle = "Axel sacht";
			this.tBarIcon.ContextMenuStrip = this.ctxTbarIcon;
			this.tBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("tBarIcon.Icon")));
			this.tBarIcon.Text = "Catalist™ by CPM";
			this.tBarIcon.Visible = true;
			this.tBarIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBarIcon_MouseClick);
			// 
			// ctxTbarIcon
			// 
			this.ctxTbarIcon.BackColor = System.Drawing.Color.White;
			this.ctxTbarIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.ctxCmdShowMainView,
						this.ctxCmdShowSettingsView,
						this.toolStripSeparator1,
						this.ctxCmdQuit});
			this.ctxTbarIcon.Name = "ctxTbarIcon";
			this.ctxTbarIcon.Size = new System.Drawing.Size(146, 76);
			// 
			// ctxCmdShowMainView
			// 
			this.ctxCmdShowMainView.Image = global::Products.Common.Properties.Resources.Desktop;
			this.ctxCmdShowMainView.Name = "ctxCmdShowMainView";
			this.ctxCmdShowMainView.Size = new System.Drawing.Size(145, 22);
			this.ctxCmdShowMainView.Text = "Startfenster";
			this.ctxCmdShowMainView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ctxCmdShowMainView.Click += new System.EventHandler(this.ctxCmdShowMainView_Click);
			// 
			// ctxCmdShowSettingsView
			// 
			this.ctxCmdShowSettingsView.Image = global::Products.Common.Properties.Resources.Presets;
			this.ctxCmdShowSettingsView.Name = "ctxCmdShowSettingsView";
			this.ctxCmdShowSettingsView.Size = new System.Drawing.Size(145, 22);
			this.ctxCmdShowSettingsView.Text = "Einstellungen";
			this.ctxCmdShowSettingsView.Click += new System.EventHandler(this.ctxCmdShowSettingsView_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
			// 
			// ctxCmdQuit
			// 
			this.ctxCmdQuit.Image = global::Products.Common.Properties.Resources.smallfail;
			this.ctxCmdQuit.Name = "ctxCmdQuit";
			this.ctxCmdQuit.Size = new System.Drawing.Size(145, 22);
			this.ctxCmdQuit.Text = "&Beenden";
			this.ctxCmdQuit.Click += new System.EventHandler(this.cMnuQuit_Click);
			// 
			// lnkDummy
			// 
			this.lnkDummy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkDummy.AutoSize = true;
			this.lnkDummy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkDummy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkDummy.Location = new System.Drawing.Point(73, 388);
			this.lnkDummy.Name = "lnkDummy";
			this.lnkDummy.Size = new System.Drawing.Size(16, 13);
			this.lnkDummy.TabIndex = 0;
			this.lnkDummy.TabStop = true;
			this.lnkDummy.Text = "...";
			this.lnkDummy.Visible = false;
			this.lnkDummy.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkDummy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDummy_LinkClicked);
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentUser.Location = new System.Drawing.Point(5, 611);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(38, 13);
			this.lblCurrentUser.TabIndex = 78;
			this.lblCurrentUser.Text = "label2";
			this.lblCurrentUser.Click += new System.EventHandler(this.lblCurrentUser_Click);
			// 
			// ctxView
			// 
			this.ctxView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.ctxCmdMaschinentypen,
						this.toolStripSeparator2,
						this.ctxCmdViewQuit});
			this.ctxView.Name = "ctxView";
			this.ctxView.Size = new System.Drawing.Size(163, 54);
			// 
			// ctxCmdMaschinentypen
			// 
			this.ctxCmdMaschinentypen.Image = global::Products.Common.Properties.Resources.Presets_64;
			this.ctxCmdMaschinentypen.Name = "ctxCmdMaschinentypen";
			this.ctxCmdMaschinentypen.Size = new System.Drawing.Size(162, 22);
			this.ctxCmdMaschinentypen.Text = "Maschinentypen";
			this.ctxCmdMaschinentypen.Click += new System.EventHandler(this.ctxCmdMaschinentypen_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
			// 
			// ctxCmdViewQuit
			// 
			this.ctxCmdViewQuit.Image = global::Products.Common.Properties.Resources.smallfail;
			this.ctxCmdViewQuit.Name = "ctxCmdViewQuit";
			this.ctxCmdViewQuit.Size = new System.Drawing.Size(162, 22);
			this.ctxCmdViewQuit.Text = "Beenden";
			this.ctxCmdViewQuit.Click += new System.EventHandler(this.ctxCmdViewQuit_Click);
			// 
			// txtSearchCustomer
			// 
			this.txtSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtSearchCustomer.Location = new System.Drawing.Point(73, 403);
			this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSearchCustomer.Name = "txtSearchCustomer";
			this.txtSearchCustomer.Size = new System.Drawing.Size(183, 22);
			this.txtSearchCustomer.TabIndex = 1;
			this.txtSearchCustomer.Watermark = "Kd-Nr., Firma oder Seriennummer";
			this.txtSearchCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerSearch_KeyUp);
			// 
			// picTopMost
			// 
			this.picTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picTopMost.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picTopMost.Image = global::Products.Common.Properties.Resources.Pin_gray_32;
			this.picTopMost.Location = new System.Drawing.Point(8, 584);
			this.picTopMost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picTopMost.Name = "picTopMost";
			this.picTopMost.Size = new System.Drawing.Size(27, 24);
			this.picTopMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTopMost.TabIndex = 80;
			this.picTopMost.TabStop = false;
			this.picTopMost.Click += new System.EventHandler(this.picTopMost_Click);
			// 
			// lnkQuit
			// 
			this.lnkQuit.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkQuit.Image = ((System.Drawing.Image)(resources.GetObject("lnkQuit.Image")));
			this.lnkQuit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkQuit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkQuit.Location = new System.Drawing.Point(5, 50);
			this.lnkQuit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkQuit.Name = "lnkQuit";
			this.lnkQuit.Size = new System.Drawing.Size(27, 24);
			this.lnkQuit.TabIndex = 79;
			this.lnkQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkQuit.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkQuit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkQuit_MouseClick);
			// 
			// lnkShowOfferView
			// 
			this.lnkShowOfferView.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkShowOfferView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkShowOfferView.Image = ((System.Drawing.Image)(resources.GetObject("lnkShowOfferView.Image")));
			this.lnkShowOfferView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkShowOfferView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkShowOfferView.Location = new System.Drawing.Point(202, 432);
			this.lnkShowOfferView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkShowOfferView.Name = "lnkShowOfferView";
			this.lnkShowOfferView.Size = new System.Drawing.Size(58, 64);
			this.lnkShowOfferView.TabIndex = 4;
			this.lnkShowOfferView.TabStop = true;
			this.lnkShowOfferView.Text = "Angebote";
			this.lnkShowOfferView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkShowOfferView.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkShowOfferView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowOfferView_LinkClicked);
			this.lnkShowOfferView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkShowOfferView_MouseClick);
			// 
			// lnkShowPresets
			// 
			this.lnkShowPresets.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkShowPresets.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkShowPresets.Image = ((System.Drawing.Image)(resources.GetObject("lnkShowPresets.Image")));
			this.lnkShowPresets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkShowPresets.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkShowPresets.Location = new System.Drawing.Point(204, 506);
			this.lnkShowPresets.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkShowPresets.Name = "lnkShowPresets";
			this.lnkShowPresets.Size = new System.Drawing.Size(58, 64);
			this.lnkShowPresets.TabIndex = 7;
			this.lnkShowPresets.TabStop = true;
			this.lnkShowPresets.Text = "Presets";
			this.lnkShowPresets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkShowPresets.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkShowPresets.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowPresets_LinkClicked);
			this.lnkShowPresets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkShowPresets_MouseClick);
			// 
			// lnkCreateCatalog
			// 
			this.lnkCreateCatalog.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkCreateCatalog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkCreateCatalog.Image = ((System.Drawing.Image)(resources.GetObject("lnkCreateCatalog.Image")));
			this.lnkCreateCatalog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkCreateCatalog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkCreateCatalog.Location = new System.Drawing.Point(70, 506);
			this.lnkCreateCatalog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkCreateCatalog.Name = "lnkCreateCatalog";
			this.lnkCreateCatalog.Size = new System.Drawing.Size(58, 64);
			this.lnkCreateCatalog.TabIndex = 5;
			this.lnkCreateCatalog.TabStop = true;
			this.lnkCreateCatalog.Text = "Katalog";
			this.lnkCreateCatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkCreateCatalog.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkCreateCatalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateCatalog_LinkClicked);
			this.lnkCreateCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkCreateCatalog_MouseClick);
			// 
			// lnkKatalog
			// 
			this.lnkKatalog.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkKatalog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkKatalog.Image = ((System.Drawing.Image)(resources.GetObject("lnkKatalog.Image")));
			this.lnkKatalog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkKatalog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkKatalog.Location = new System.Drawing.Point(138, 506);
			this.lnkKatalog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkKatalog.Name = "lnkKatalog";
			this.lnkKatalog.Size = new System.Drawing.Size(58, 64);
			this.lnkKatalog.TabIndex = 6;
			this.lnkKatalog.TabStop = true;
			this.lnkKatalog.Text = "Inhalt";
			this.lnkKatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkKatalog.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkKatalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKatalog_LinkClicked);
			this.lnkKatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkKatalog_MouseClick);
			// 
			// lnkArtikel
			// 
			this.lnkArtikel.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkArtikel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkArtikel.Image = ((System.Drawing.Image)(resources.GetObject("lnkArtikel.Image")));
			this.lnkArtikel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkArtikel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkArtikel.Location = new System.Drawing.Point(70, 432);
			this.lnkArtikel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.lnkArtikel.Name = "lnkArtikel";
			this.lnkArtikel.Size = new System.Drawing.Size(58, 64);
			this.lnkArtikel.TabIndex = 2;
			this.lnkArtikel.TabStop = true;
			this.lnkArtikel.Text = "Artikel";
			this.lnkArtikel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkArtikel.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkArtikel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArtikel_LinkClicked);
			this.lnkArtikel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkArtikel_MouseClick);
			// 
			// lnkKalender
			// 
			this.lnkKalender.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkKalender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkKalender.Image = ((System.Drawing.Image)(resources.GetObject("lnkKalender.Image")));
			this.lnkKalender.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkKalender.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkKalender.Location = new System.Drawing.Point(136, 432);
			this.lnkKalender.Name = "lnkKalender";
			this.lnkKalender.Size = new System.Drawing.Size(58, 64);
			this.lnkKalender.TabIndex = 3;
			this.lnkKalender.TabStop = true;
			this.lnkKalender.Text = "Kalender";
			this.lnkKalender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkKalender.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkKalender.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKalender_LinkClicked);
			this.lnkKalender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkKalender_MouseClick);
			// 
			// picLineOpen
			// 
			this.picLineOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picLineOpen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picLineOpen.Image = ((System.Drawing.Image)(resources.GetObject("picLineOpen.Image")));
			this.picLineOpen.Location = new System.Drawing.Point(298, 13);
			this.picLineOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picLineOpen.Name = "picLineOpen";
			this.picLineOpen.Size = new System.Drawing.Size(27, 24);
			this.picLineOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLineOpen.TabIndex = 76;
			this.picLineOpen.TabStop = false;
			this.picLineOpen.Click += new System.EventHandler(this.picLineOpen_Click);
			// 
			// picCPM
			// 
			this.picCPM.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picCPM.Image = ((System.Drawing.Image)(resources.GetObject("picCPM.Image")));
			this.picCPM.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCPM.InitialImage")));
			this.picCPM.Location = new System.Drawing.Point(76, 79);
			this.picCPM.Name = "picCPM";
			this.picCPM.Size = new System.Drawing.Size(180, 123);
			this.picCPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCPM.TabIndex = 64;
			this.picCPM.TabStop = false;
			this.picCPM.Click += new System.EventHandler(this.picCPM_Click);
			// 
			// WhatClock
			// 
			this.WhatClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.WhatClock.BackColor = System.Drawing.Color.White;
			this.WhatClock.BigMarkers = new AnalogClock.Marker[] {
				new AnalogClock.Marker("BigMarker90", 90F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker60", 60F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker30", 30F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker0", 0F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker330", 330F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker300", 300F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker270", 270F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker240", 240F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker210", 210F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker180", 180F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker150", 150F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("BigMarker120", 120F, System.Drawing.Color.Gray, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
			this.WhatClock.BorderStyle = AnalogClock.BorderStyles.Round;
			this.WhatClock.CenterPoint.Color = System.Drawing.Color.White;
			this.WhatClock.CenterPoint.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatClock.CenterPoint.RelativeRadius = 0.03F;
			this.WhatClock.CenterPoint.Tag = null;
			this.WhatClock.ForeColor = System.Drawing.Color.Gray;
			this.WhatClock.FrameColor = System.Drawing.Color.Gray;
			this.WhatClock.HourHand.Color = System.Drawing.Color.Gray;
			this.WhatClock.HourHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatClock.HourHand.RelativeRadius = 0.6F;
			this.WhatClock.HourHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatClock.HourHand.Tag = null;
			this.WhatClock.HourHand.Width = 5F;
			this.WhatClock.Location = new System.Drawing.Point(92, 225);
			this.WhatClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WhatClock.MinuteHand.Color = System.Drawing.Color.Gray;
			this.WhatClock.MinuteHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatClock.MinuteHand.RelativeRadius = 0.77F;
			this.WhatClock.MinuteHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatClock.MinuteHand.Tag = null;
			this.WhatClock.MinuteHand.Width = 5F;
			this.WhatClock.Name = "WhatClock";
			this.WhatClock.SecondHand.Color = System.Drawing.Color.Gray;
			this.WhatClock.SecondHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatClock.SecondHand.RelativeRadius = 0.9F;
			this.WhatClock.SecondHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatClock.SecondHand.Tag = null;
			this.WhatClock.SecondHand.Width = 1F;
			this.WhatClock.Size = new System.Drawing.Size(149, 152);
			this.WhatClock.SmallMarkers = new AnalogClock.Marker[] {
				new AnalogClock.Marker("SmallMarker90", 90F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker84", 84F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker78", 78F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker72", 72F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker66", 66F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker60", 60F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker54", 54F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker48", 48F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker42", 42F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker36", 36F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker30", 30F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker24", 24F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker18", 18F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker12", 12F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker6", 6F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker0", 0F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker354", 354F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker348", 348F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker342", 342F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker336", 336F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker330", 330F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker324", 324F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker318", 318F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker312", 312F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker306", 306F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker300", 300F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker294", 294F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker288", 288F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker282", 282F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker276", 276F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker270", 270F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker264", 264F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker258", 258F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker252", 252F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker246", 246F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker240", 240F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker234", 234F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker228", 228F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker222", 222F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker216", 216F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker210", 210F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker204", 204F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker198", 198F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker192", 192F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker186", 186F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker180", 180F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker174", 174F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker168", 168F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker162", 162F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker156", 156F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker150", 150F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker144", 144F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker138", 138F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker132", 132F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker126", 126F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker120", 120F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker114", 114F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker108", 108F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker102", 102F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
				new AnalogClock.Marker("SmallMarker96", 96F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 74.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
			this.WhatClock.Symbols = new AnalogClock.Symbol[] {
				new AnalogClock.Symbol("Symbol90", 90F, "12", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 0, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol60", 60F, "1", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 1, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol30", 30F, "2", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 2, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol0", 0F, "3", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 3, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol330", 330F, "4", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 4, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol300", 300F, "5", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 5, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol270", 270F, "6", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 6, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol240", 240F, "7", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 7, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol210", 210F, "8", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 8, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol180", 180F, "9", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 9, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol150", 150F, "10", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 10, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
				new AnalogClock.Symbol("Symbol120", 120F, "11", new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Gray, new System.Drawing.Point(1, 1), 11, true, true, AnalogClock.SymbolStyle.Numeric, 74.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null)};
			this.WhatClock.TabIndex = 81;
			this.WhatClock.UtcOffset = System.TimeSpan.Parse("02:00:00");
			this.WhatClock.Click += new System.EventHandler(this.WhatClock_Click);
			// 
			// MainView
			// 
			this.AcceptButton = this.lnkDummy;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.lnkClose;
			this.ClientSize = new System.Drawing.Size(333, 625);
			this.ContextMenuStrip = this.ctxView;
			this.ControlBox = false;
			this.Controls.Add(this.WhatClock);
			this.Controls.Add(this.picTopMost);
			this.Controls.Add(this.lnkQuit);
			this.Controls.Add(this.lnkShowOfferView);
			this.Controls.Add(this.lnkShowPresets);
			this.Controls.Add(this.lnkCreateCatalog);
			this.Controls.Add(this.lnkKatalog);
			this.Controls.Add(this.lnkArtikel);
			this.Controls.Add(this.lnkKalender);
			this.Controls.Add(this.txtSearchCustomer);
			this.Controls.Add(this.lblCurrentUser);
			this.Controls.Add(this.lnkDummy);
			this.Controls.Add(this.picLineOpen);
			this.Controls.Add(this.lnkTest);
			this.Controls.Add(this.lnkClose);
			this.Controls.Add(this.picCPM);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(287, 447);
			this.Name = "MainView";
			this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 15);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			this.Text = "CPM - Catalist";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainView_KeyUp);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDoubleClick);
			((System.ComponentModel.ISupportInitialize)(this.errSearch)).EndInit();
			this.ctxTbarIcon.ResumeLayout(false);
			this.ctxView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picTopMost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLineOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCPM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picCPM;
		private System.Windows.Forms.LinkLabel lnkClose;
		private System.Windows.Forms.LinkLabel lnkTest;
		private System.Windows.Forms.ErrorProvider errSearch;
		private System.Windows.Forms.PictureBox picLineOpen;
		private System.Windows.Forms.NotifyIcon tBarIcon;
		private System.Windows.Forms.ContextMenuStrip ctxTbarIcon;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdQuit;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdShowMainView;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdShowSettingsView;
		private System.Windows.Forms.LinkLabel lnkDummy;
		private System.Windows.Forms.Label lblCurrentUser;
		private Controls.axlTextbox txtSearchCustomer;
		private System.Windows.Forms.ContextMenuStrip ctxView;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdViewQuit;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdMaschinentypen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.LinkLabel lnkKalender;
		private System.Windows.Forms.LinkLabel lnkArtikel;
		private System.Windows.Forms.LinkLabel lnkKatalog;
		private System.Windows.Forms.LinkLabel lnkCreateCatalog;
		private System.Windows.Forms.LinkLabel lnkShowPresets;
		private System.Windows.Forms.LinkLabel lnkShowOfferView;
		private System.Windows.Forms.LinkLabel lnkQuit;
		private System.Windows.Forms.PictureBox picTopMost;
		private AnalogClock.Clock WhatClock;
	}
}

