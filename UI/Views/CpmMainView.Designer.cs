namespace Products.Common.Views
{
	partial class CpmMainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpmMainView));
			this.WhatWatch = new AnalogClock.Clock();
			this.mbtnMinimize = new MetroFramework.Controls.MetroButton();
			this.mlblCurrentUser = new MetroFramework.Controls.MetroLabel();
			this.errSearch = new System.Windows.Forms.ErrorProvider(this.components);
			this.tBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ctxTbarIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxCmdShowMainView = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxCmdShowSettingsView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxCmdQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxCmdMaschinentypen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxCmdViewQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.lnkDummy = new System.Windows.Forms.LinkLabel();
			this.mHtmlTip = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.mtxtSearch = new MetroFramework.Controls.MetroTextBox();
			this.btnTopMost = new MetroFramework.Controls.MetroButton();
			this.btnLineOpen = new MetroFramework.Controls.MetroButton();
			this.mtileVerwaltung = new MetroFramework.Controls.MetroTile();
			this.mtileKatalog = new MetroFramework.Controls.MetroTile();
			this.mtileAngebote = new MetroFramework.Controls.MetroTile();
			this.mtileKalender = new MetroFramework.Controls.MetroTile();
			this.mtileArtikel = new MetroFramework.Controls.MetroTile();
			this.picCPM = new System.Windows.Forms.PictureBox();
			this.mlblVersion = new MetroFramework.Controls.MetroLabel();
			this.AppointmentWorker = new System.ComponentModel.BackgroundWorker();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.mradioArtikel = new MetroFramework.Controls.MetroRadioButton();
			this.mradioKunden = new MetroFramework.Controls.MetroRadioButton();
			this.mlnkCurrentCustomer = new MetroFramework.Controls.MetroLink();
			this.mtileQuit = new MetroFramework.Controls.MetroTile();
			this.mbtnShowRecentCustomers = new MetroFramework.Controls.MetroButton();
			this.btnTest = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errSearch)).BeginInit();
			this.ctxTbarIcon.SuspendLayout();
			this.ctxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCPM)).BeginInit();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// WhatWatch
			// 
			this.WhatWatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.WhatWatch.BackColor = System.Drawing.Color.White;
			this.WhatWatch.BigMarkers = new AnalogClock.Marker[] {
        new AnalogClock.Marker("BigMarker90", 90F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker60", 60F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker30", 30F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker0", 0F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker330", 330F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker300", 300F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker270", 270F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker240", 240F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker210", 210F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker180", 180F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker150", 150F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker120", 120F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
			this.WhatWatch.BorderStyle = AnalogClock.BorderStyles.Round;
			this.WhatWatch.CenterPoint.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			this.WhatWatch.CenterPoint.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatWatch.CenterPoint.RelativeRadius = 0.035F;
			this.WhatWatch.CenterPoint.Tag = null;
			this.WhatWatch.ForeColor = System.Drawing.Color.Gray;
			this.WhatWatch.FrameColor = System.Drawing.Color.Gray;
			this.WhatWatch.HourHand.Color = System.Drawing.Color.Gray;
			this.WhatWatch.HourHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatWatch.HourHand.RelativeRadius = 0.6F;
			this.WhatWatch.HourHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatWatch.HourHand.Tag = null;
			this.WhatWatch.HourHand.Width = 5F;
			this.WhatWatch.Location = new System.Drawing.Point(213, 62);
			this.WhatWatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WhatWatch.MinuteHand.Color = System.Drawing.Color.Gray;
			this.WhatWatch.MinuteHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatWatch.MinuteHand.RelativeRadius = 0.77F;
			this.WhatWatch.MinuteHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatWatch.MinuteHand.Tag = null;
			this.WhatWatch.MinuteHand.Width = 5F;
			this.WhatWatch.Name = "WhatWatch";
			this.WhatWatch.SecondHand.Color = System.Drawing.Color.Gray;
			this.WhatWatch.SecondHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
			this.WhatWatch.SecondHand.RelativeRadius = 0.9F;
			this.WhatWatch.SecondHand.Style = AnalogClock.HandStyle.Pointed;
			this.WhatWatch.SecondHand.Tag = null;
			this.WhatWatch.SecondHand.Width = 1F;
			this.WhatWatch.Size = new System.Drawing.Size(123, 123);
			this.WhatWatch.SmallMarkers = new AnalogClock.Marker[] {
        new AnalogClock.Marker("SmallMarker90", 90F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker84", 84F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker78", 78F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker72", 72F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker66", 66F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker60", 60F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker54", 54F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker48", 48F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker42", 42F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker36", 36F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker30", 30F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker24", 24F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker18", 18F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker12", 12F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker6", 6F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker0", 0F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker354", 354F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker348", 348F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker342", 342F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker336", 336F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker330", 330F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker324", 324F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker318", 318F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker312", 312F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker306", 306F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker300", 300F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker294", 294F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker288", 288F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker282", 282F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker276", 276F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker270", 270F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker264", 264F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker258", 258F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker252", 252F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker246", 246F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker240", 240F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker234", 234F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker228", 228F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker222", 222F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker216", 216F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker210", 210F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker204", 204F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker198", 198F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker192", 192F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker186", 186F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker180", 180F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker174", 174F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker168", 168F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker162", 162F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker156", 156F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker150", 150F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker144", 144F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker138", 138F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker132", 132F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker126", 126F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker120", 120F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker114", 114F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker108", 108F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker102", 102F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker96", 96F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 61.5F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
			this.WhatWatch.Symbols = new AnalogClock.Symbol[] {
        new AnalogClock.Symbol("Symbol90", 90F, "12", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 0, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol60", 60F, "1", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 1, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol30", 30F, "2", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 2, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol0", 0F, "3", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 3, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol330", 330F, "4", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 4, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol300", 300F, "5", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 5, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol270", 270F, "6", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 6, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol240", 240F, "7", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 7, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol210", 210F, "8", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 8, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol180", 180F, "9", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 9, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol150", 150F, "10", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 10, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol120", 120F, "11", new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 11, true, true, AnalogClock.SymbolStyle.Numeric, 61.5F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null)};
			this.WhatWatch.TabIndex = 82;
			this.mHtmlTip.SetToolTip(this.WhatWatch, "Anklicken beendet Catalist endgültig");
			this.WhatWatch.UpdateFrequency = 10;
			this.WhatWatch.Click += new System.EventHandler(this.WhatClock_Click);
			// 
			// mbtnMinimize
			// 
			this.mbtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnMinimize.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnMinimize.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnMinimize.Location = new System.Drawing.Point(246, 593);
			this.mbtnMinimize.Name = "mbtnMinimize";
			this.mbtnMinimize.Size = new System.Drawing.Size(90, 30);
			this.mbtnMinimize.TabIndex = 10;
			this.mbtnMinimize.Text = "Minimieren";
			this.mHtmlTip.SetToolTip(this.mbtnMinimize, "Minimiert die Anwendung. Zum vollständigen Beenden des Programms bitte auf die Uh" +
        "r oben klicken.");
			this.mbtnMinimize.UseSelectable = true;
			this.mbtnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// mlblCurrentUser
			// 
			this.mlblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblCurrentUser.AutoSize = true;
			this.mlblCurrentUser.Location = new System.Drawing.Point(23, 604);
			this.mlblCurrentUser.Name = "mlblCurrentUser";
			this.mlblCurrentUser.Size = new System.Drawing.Size(81, 19);
			this.mlblCurrentUser.TabIndex = 94;
			this.mlblCurrentUser.Text = "metroLabel1";
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
			this.tBarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tBarIcon_MouseClick);
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
			this.ctxCmdShowMainView.Image = ((System.Drawing.Image)(resources.GetObject("ctxCmdShowMainView.Image")));
			this.ctxCmdShowMainView.Name = "ctxCmdShowMainView";
			this.ctxCmdShowMainView.Size = new System.Drawing.Size(145, 22);
			this.ctxCmdShowMainView.Text = "Startfenster";
			this.ctxCmdShowMainView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ctxCmdShowMainView.Click += new System.EventHandler(this.ctxCmdShowMainView_Click);
			// 
			// ctxCmdShowSettingsView
			// 
			this.ctxCmdShowSettingsView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ctxCmdShowSettingsView.Image = global::Products.Common.Properties.Resources.settings_24_metrogray;
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
			this.ctxCmdQuit.Image = global::Products.Common.Properties.Resources.exit_24_metrored;
			this.ctxCmdQuit.Name = "ctxCmdQuit";
			this.ctxCmdQuit.Size = new System.Drawing.Size(145, 22);
			this.ctxCmdQuit.Text = "&Beenden";
			this.ctxCmdQuit.Click += new System.EventHandler(this.ctxCmdViewQuit_Click);
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
			this.ctxCmdMaschinentypen.Image = ((System.Drawing.Image)(resources.GetObject("ctxCmdMaschinentypen.Image")));
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
			this.ctxCmdViewQuit.Image = global::Products.Common.Properties.Resources.exit_24_metrored;
			this.ctxCmdViewQuit.Name = "ctxCmdViewQuit";
			this.ctxCmdViewQuit.Size = new System.Drawing.Size(162, 22);
			this.ctxCmdViewQuit.Text = "Beenden";
			this.ctxCmdViewQuit.Click += new System.EventHandler(this.ctxCmdViewQuit_Click);
			// 
			// lnkDummy
			// 
			this.lnkDummy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkDummy.AutoSize = true;
			this.lnkDummy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkDummy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkDummy.Location = new System.Drawing.Point(320, 246);
			this.lnkDummy.Name = "lnkDummy";
			this.lnkDummy.Size = new System.Drawing.Size(18, 20);
			this.lnkDummy.TabIndex = 0;
			this.lnkDummy.TabStop = true;
			this.lnkDummy.Text = "...";
			this.lnkDummy.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkDummy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDummy_LinkClicked);
			// 
			// mHtmlTip
			// 
			this.mHtmlTip.AutoPopDelay = 10000;
			this.mHtmlTip.InitialDelay = 500;
			this.mHtmlTip.OwnerDraw = true;
			this.mHtmlTip.ReshowDelay = 100;
			this.mHtmlTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.mHtmlTip.ToolTipTitle = "Catalist by CPM";
			// 
			// mtxtSearch
			// 
			this.mtxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			// 
			// 
			// 
			this.mtxtSearch.CustomButton.Image = global::Products.Common.Properties.Resources.search_16_metroblack;
			this.mtxtSearch.CustomButton.Location = new System.Drawing.Point(289, 2);
			this.mtxtSearch.CustomButton.Name = "";
			this.mtxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSearch.CustomButton.TabIndex = 1;
			this.mtxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSearch.CustomButton.UseSelectable = true;
			this.mtxtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtSearch.Lines = new string[0];
			this.mtxtSearch.Location = new System.Drawing.Point(23, 273);
			this.mtxtSearch.MaxLength = 32767;
			this.mtxtSearch.Name = "mtxtSearch";
			this.mtxtSearch.PasswordChar = '\0';
			this.mtxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSearch.SelectedText = "";
			this.mtxtSearch.SelectionLength = 0;
			this.mtxtSearch.SelectionStart = 0;
			this.mtxtSearch.ShowButton = true;
			this.mtxtSearch.ShowClearButton = true;
			this.mtxtSearch.Size = new System.Drawing.Size(313, 26);
			this.mtxtSearch.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtSearch.TabIndex = 100;
			this.mHtmlTip.SetToolTip(this.mtxtSearch, "Artikelsuche: *<Kundennummer> <Artikelname> sucht nach Artikeln für den Kunden mi" +
        "t der vorangestellten Kundennummer");
			this.mtxtSearch.UseSelectable = true;
			this.mtxtSearch.WaterMark = "Kd-Nr, Firma, Seriennummer | STRG+Y = CPM";
			this.mtxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtSearch_ButtonClick);
			this.mtxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
			// 
			// btnTopMost
			// 
			this.btnTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTopMost.BackColor = System.Drawing.Color.Transparent;
			this.btnTopMost.BackgroundImage = global::Products.Common.Properties.Resources.topmost_24_metrogray;
			this.btnTopMost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnTopMost.Location = new System.Drawing.Point(23, 565);
			this.btnTopMost.Name = "btnTopMost";
			this.btnTopMost.Size = new System.Drawing.Size(36, 36);
			this.btnTopMost.TabIndex = 8;
			this.mHtmlTip.SetToolTip(this.btnTopMost, "Wenn dieses Symbol rot leuchtet, bleibt dieses Fenster immer sichtbar und wird vo" +
        "n anderen Fenstern nicht überdeckt.");
			this.btnTopMost.UseSelectable = true;
			this.btnTopMost.Click += new System.EventHandler(this.btnTopMost_Click);
			// 
			// btnLineOpen
			// 
			this.btnLineOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLineOpen.BackColor = System.Drawing.Color.Transparent;
			this.btnLineOpen.BackgroundImage = global::Products.Common.Properties.Resources.telefon_32_metrogreen;
			this.btnLineOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLineOpen.Location = new System.Drawing.Point(65, 565);
			this.btnLineOpen.Name = "btnLineOpen";
			this.btnLineOpen.Size = new System.Drawing.Size(36, 36);
			this.btnLineOpen.TabIndex = 9;
			this.mHtmlTip.SetToolTip(this.btnLineOpen, "Wenn der Hörer grün leuchtet, ist die Anrufererkennung aktiviert.");
			this.btnLineOpen.UseSelectable = true;
			this.btnLineOpen.Click += new System.EventHandler(this.mpicLineOpen_Click);
			// 
			// mtileVerwaltung
			// 
			this.mtileVerwaltung.ActiveControl = null;
			this.mtileVerwaltung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileVerwaltung.Location = new System.Drawing.Point(130, 441);
			this.mtileVerwaltung.Name = "mtileVerwaltung";
			this.mtileVerwaltung.Size = new System.Drawing.Size(100, 100);
			this.mtileVerwaltung.Style = MetroFramework.MetroColorStyle.Purple;
			this.mtileVerwaltung.TabIndex = 6;
			this.mtileVerwaltung.Text = "Verwaltung";
			this.mtileVerwaltung.TileImage = global::Products.Common.Properties.Resources.admin_48_metrowhite;
			this.mtileVerwaltung.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mHtmlTip.SetToolTip(this.mtileVerwaltung, "Hier lassen sich Sammlungen von Artikeleigenschaften verwalten, die dann neuen Ar" +
        "tikeln zugewiesen werden können.");
			this.mtileVerwaltung.UseSelectable = true;
			this.mtileVerwaltung.UseTileImage = true;
			this.mtileVerwaltung.Click += new System.EventHandler(this.mtilePresets_Click);
			// 
			// mtileKatalog
			// 
			this.mtileKatalog.ActiveControl = null;
			this.mtileKatalog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileKatalog.Location = new System.Drawing.Point(24, 441);
			this.mtileKatalog.Name = "mtileKatalog";
			this.mtileKatalog.Size = new System.Drawing.Size(100, 100);
			this.mtileKatalog.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtileKatalog.TabIndex = 4;
			this.mtileKatalog.Text = "Katalog";
			this.mtileKatalog.TileImage = global::Products.Common.Properties.Resources.catalog_48_metrogray;
			this.mtileKatalog.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mHtmlTip.SetToolTip(this.mtileKatalog, "Hier lassen sich Kurzpreislisten und Kataloge erstellen.");
			this.mtileKatalog.UseSelectable = true;
			this.mtileKatalog.UseTileImage = true;
			this.mtileKatalog.Click += new System.EventHandler(this.mtileKatalog_Click);
			// 
			// mtileAngebote
			// 
			this.mtileAngebote.ActiveControl = null;
			this.mtileAngebote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileAngebote.Location = new System.Drawing.Point(236, 335);
			this.mtileAngebote.Name = "mtileAngebote";
			this.mtileAngebote.Size = new System.Drawing.Size(100, 100);
			this.mtileAngebote.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtileAngebote.TabIndex = 3;
			this.mtileAngebote.Text = "Aufgaben";
			this.mtileAngebote.TileImage = global::Products.Common.Properties.Resources.task_48_metrogray;
			this.mtileAngebote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mHtmlTip.SetToolTip(this.mtileAngebote, "Hier kann man nach dem Auswählen eines Kunden dessen Angebote anzeigen und bearbe" +
        "iten.");
			this.mtileAngebote.UseSelectable = true;
			this.mtileAngebote.UseTileImage = true;
			this.mtileAngebote.Click += new System.EventHandler(this.mtileAngebote_Click);
			// 
			// mtileKalender
			// 
			this.mtileKalender.ActiveControl = null;
			this.mtileKalender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileKalender.Location = new System.Drawing.Point(130, 335);
			this.mtileKalender.Name = "mtileKalender";
			this.mtileKalender.Size = new System.Drawing.Size(100, 100);
			this.mtileKalender.Style = MetroFramework.MetroColorStyle.Red;
			this.mtileKalender.TabIndex = 2;
			this.mtileKalender.Text = "Kalender";
			this.mtileKalender.TileImage = global::Products.Common.Properties.Resources.calendar_48_metrowhite;
			this.mtileKalender.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mHtmlTip.SetToolTip(this.mtileKalender, "Zur Einsicht und Planung von Terminen. Der Kalender wird automatisch mit dem Kale" +
        "nder in David synchronisiert.");
			this.mtileKalender.UseSelectable = true;
			this.mtileKalender.UseTileImage = true;
			this.mtileKalender.Click += new System.EventHandler(this.mtileKalender_Click);
			// 
			// mtileArtikel
			// 
			this.mtileArtikel.ActiveControl = null;
			this.mtileArtikel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileArtikel.Location = new System.Drawing.Point(23, 335);
			this.mtileArtikel.Name = "mtileArtikel";
			this.mtileArtikel.Size = new System.Drawing.Size(100, 100);
			this.mtileArtikel.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mtileArtikel.TabIndex = 0;
			this.mtileArtikel.Text = "Termine";
			this.mtileArtikel.TileImage = global::Products.Common.Properties.Resources.liste_48_metrosilver;
			this.mtileArtikel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mHtmlTip.SetToolTip(this.mtileArtikel, "Zuerst wählt man einen Kunden aus und bekommt anschließend dessen Artikelpreise a" +
        "ngezeigt");
			this.mtileArtikel.UseCustomForeColor = true;
			this.mtileArtikel.UseSelectable = true;
			this.mtileArtikel.UseTileImage = true;
			this.mtileArtikel.Click += new System.EventHandler(this.mtileArtikel_Click);
			// 
			// picCPM
			// 
			this.picCPM.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picCPM.BackColor = System.Drawing.Color.Transparent;
			this.picCPM.Image = ((System.Drawing.Image)(resources.GetObject("picCPM.Image")));
			this.picCPM.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCPM.InitialImage")));
			this.picCPM.Location = new System.Drawing.Point(23, 62);
			this.picCPM.Name = "picCPM";
			this.picCPM.Size = new System.Drawing.Size(180, 123);
			this.picCPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCPM.TabIndex = 65;
			this.picCPM.TabStop = false;
			this.mHtmlTip.SetToolTip(this.picCPM, "Öffnet das Fenster für allgemeine Einstellungen");
			this.picCPM.Click += new System.EventHandler(this.picCPM_Click);
			// 
			// mlblVersion
			// 
			this.mlblVersion.AutoSize = true;
			this.mlblVersion.FontSize = MetroFramework.MetroLabelSize.Small;
			this.mlblVersion.Location = new System.Drawing.Point(224, 197);
			this.mlblVersion.Name = "mlblVersion";
			this.mlblVersion.Size = new System.Drawing.Size(100, 15);
			this.mlblVersion.TabIndex = 96;
			this.mlblVersion.Text = "Ver. X.X.X.XX (VIP)";
			this.mlblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AppointmentWorker
			// 
			this.AppointmentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AppointmentWorker_DoWork);
			this.AppointmentWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AppointmentWorker_RunWorkerCompleted);
			// 
			// metroPanel1
			// 
			this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroPanel1.Controls.Add(this.mradioArtikel);
			this.metroPanel1.Controls.Add(this.mradioKunden);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(23, 246);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(152, 21);
			this.metroPanel1.TabIndex = 98;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// mradioArtikel
			// 
			this.mradioArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mradioArtikel.AutoSize = true;
			this.mradioArtikel.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mradioArtikel.Location = new System.Drawing.Point(87, 3);
			this.mradioArtikel.Name = "mradioArtikel";
			this.mradioArtikel.Size = new System.Drawing.Size(55, 15);
			this.mradioArtikel.Style = MetroFramework.MetroColorStyle.Red;
			this.mradioArtikel.TabIndex = 3;
			this.mradioArtikel.Text = "Artikel";
			this.mradioArtikel.UseSelectable = true;
			this.mradioArtikel.CheckedChanged += new System.EventHandler(this.mradioArtikel_CheckedChanged);
			// 
			// mradioKunden
			// 
			this.mradioKunden.AutoSize = true;
			this.mradioKunden.Checked = true;
			this.mradioKunden.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mradioKunden.Location = new System.Drawing.Point(3, 3);
			this.mradioKunden.Name = "mradioKunden";
			this.mradioKunden.Size = new System.Drawing.Size(60, 15);
			this.mradioKunden.Style = MetroFramework.MetroColorStyle.Lime;
			this.mradioKunden.TabIndex = 2;
			this.mradioKunden.TabStop = true;
			this.mradioKunden.Text = "Kunden";
			this.mradioKunden.UseSelectable = true;
			// 
			// mlnkCurrentCustomer
			// 
			this.mlnkCurrentCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mlnkCurrentCustomer.Location = new System.Drawing.Point(23, 306);
			this.mlnkCurrentCustomer.Name = "mlnkCurrentCustomer";
			this.mlnkCurrentCustomer.Size = new System.Drawing.Size(282, 23);
			this.mlnkCurrentCustomer.TabIndex = 99;
			this.mlnkCurrentCustomer.Text = "Letzter Kunde";
			this.mlnkCurrentCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkCurrentCustomer.UseSelectable = true;
			this.mlnkCurrentCustomer.Click += new System.EventHandler(this.mlnkCurrentCustomer_Click);
			// 
			// mtileQuit
			// 
			this.mtileQuit.ActiveControl = null;
			this.mtileQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mtileQuit.Location = new System.Drawing.Point(236, 441);
			this.mtileQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileQuit.Name = "mtileQuit";
			this.mtileQuit.Size = new System.Drawing.Size(100, 100);
			this.mtileQuit.Style = MetroFramework.MetroColorStyle.Silver;
			this.mtileQuit.TabIndex = 97;
			this.mtileQuit.Text = "Beenden";
			this.mtileQuit.TileImage = global::Products.Common.Properties.Resources.poweroff_48_metrowhite;
			this.mtileQuit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileQuit.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.mtileQuit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtileQuit.UseSelectable = true;
			this.mtileQuit.UseTileImage = true;
			this.mtileQuit.Click += new System.EventHandler(this.mtileQuit_Click);
			// 
			// mbtnShowRecentCustomers
			// 
			this.mbtnShowRecentCustomers.Location = new System.Drawing.Point(311, 305);
			this.mbtnShowRecentCustomers.Name = "mbtnShowRecentCustomers";
			this.mbtnShowRecentCustomers.Size = new System.Drawing.Size(25, 23);
			this.mbtnShowRecentCustomers.TabIndex = 101;
			this.mbtnShowRecentCustomers.Text = "...";
			this.mbtnShowRecentCustomers.UseCustomBackColor = true;
			this.mbtnShowRecentCustomers.UseCustomForeColor = true;
			this.mbtnShowRecentCustomers.UseSelectable = true;
			this.mbtnShowRecentCustomers.Click += new System.EventHandler(this.mbtnShowRecentCustomers_Click);
			// 
			// btnTest
			// 
			this.btnTest.AutoSize = true;
			this.btnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnTest.BackColor = System.Drawing.Color.Transparent;
			this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
			this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTest.Location = new System.Drawing.Point(23, 217);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(66, 25);
			this.btnTest.TabIndex = 102;
			this.btnTest.Text = "Testing ...";
			this.btnTest.UseVisualStyleBackColor = false;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// CpmMainView
			// 
			this.AcceptButton = this.lnkDummy;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(359, 646);
			this.ContextMenuStrip = this.ctxView;
			this.ControlBox = false;
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.mbtnShowRecentCustomers);
			this.Controls.Add(this.mtxtSearch);
			this.Controls.Add(this.mlnkCurrentCustomer);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.mtileQuit);
			this.Controls.Add(this.mlblVersion);
			this.Controls.Add(this.lnkDummy);
			this.Controls.Add(this.btnTopMost);
			this.Controls.Add(this.btnLineOpen);
			this.Controls.Add(this.mlblCurrentUser);
			this.Controls.Add(this.mtileVerwaltung);
			this.Controls.Add(this.mtileKatalog);
			this.Controls.Add(this.mtileAngebote);
			this.Controls.Add(this.mtileKalender);
			this.Controls.Add(this.mtileArtikel);
			this.Controls.Add(this.mbtnMinimize);
			this.Controls.Add(this.WhatWatch);
			this.Controls.Add(this.picCPM);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "CpmMainView";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Cut && Print Media";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CpmMainView_FormClosing);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CpmMainView_KeyUp);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CpmMainView_MouseDoubleClick);
			this.MouseEnter += new System.EventHandler(this.CpmMainView_MouseEnter);
			((System.ComponentModel.ISupportInitialize)(this.errSearch)).EndInit();
			this.ctxTbarIcon.ResumeLayout(false);
			this.ctxView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCPM)).EndInit();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picCPM;
		private AnalogClock.Clock WhatWatch;
		private MetroFramework.Controls.MetroButton mbtnMinimize;
		private MetroFramework.Controls.MetroTile mtileArtikel;
		private MetroFramework.Controls.MetroTile mtileKalender;
		private MetroFramework.Controls.MetroTile mtileAngebote;
		private MetroFramework.Controls.MetroTile mtileKatalog;
		private MetroFramework.Controls.MetroTile mtileVerwaltung;
		private MetroFramework.Controls.MetroLabel mlblCurrentUser;
		private System.Windows.Forms.ErrorProvider errSearch;
		private MetroFramework.Controls.MetroButton btnLineOpen;
		private MetroFramework.Controls.MetroButton btnTopMost;
		private System.Windows.Forms.NotifyIcon tBarIcon;
		private System.Windows.Forms.ContextMenuStrip ctxTbarIcon;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdShowMainView;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdShowSettingsView;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdQuit;
		private System.Windows.Forms.ContextMenuStrip ctxView;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdMaschinentypen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ctxCmdViewQuit;
		private System.Windows.Forms.LinkLabel lnkDummy;
		private MetroFramework.Drawing.Html.HtmlToolTip mHtmlTip;
		private MetroFramework.Controls.MetroLabel mlblVersion;
		private MetroFramework.Controls.MetroTile mtileQuit;
		private System.ComponentModel.BackgroundWorker AppointmentWorker;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroRadioButton mradioArtikel;
		private MetroFramework.Controls.MetroRadioButton mradioKunden;
		private MetroFramework.Controls.MetroLink mlnkCurrentCustomer;
		private MetroFramework.Controls.MetroTextBox mtxtSearch;
		private MetroFramework.Controls.MetroButton mbtnShowRecentCustomers;
		private System.Windows.Forms.Button btnTest;
	}
}