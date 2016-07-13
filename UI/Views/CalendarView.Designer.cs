namespace Products.Common.Views
{
	partial class CalendarView
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
			Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarView));
			this.dayView = new Calendar.DayView();
			this.ctxDayView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxmnuNeuerTermin = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxmnuAddBesuchstermin = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxmnuLinkBesuchstermin = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxOpenAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxcmdTermindetails = new System.Windows.Forms.ToolStripMenuItem();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.mbtnOK = new MetroFramework.Controls.MetroButton();
			this.lblAktuellerTermin = new MetroFramework.Controls.MetroLabel();
			this.chkAndereKalender = new System.Windows.Forms.CheckedListBox();
			this.mlblVanAnderen = new MetroFramework.Controls.MetroLabel();
			this.mlblKalenderVon = new MetroFramework.Controls.MetroLabel();
			this.mlblSelektierterTermin = new MetroFramework.Controls.MetroLabel();
			this.btnGanzeWoche = new MetroFramework.Controls.MetroButton();
			this.btnArbeitswoche = new MetroFramework.Controls.MetroButton();
			this.btnEinTag = new MetroFramework.Controls.MetroButton();
			this.btnHeute = new MetroFramework.Controls.MetroButton();
			this.ctxDayView.SuspendLayout();
			this.SuspendLayout();
			// 
			// dayView
			// 
			drawTool1.DayView = this.dayView;
			this.dayView.ActiveTool = drawTool1;
			this.dayView.AllowInplaceEditing = false;
			this.dayView.AmPmDisplay = false;
			this.dayView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dayView.AppHeightMode = Calendar.DayView.AppHeightDrawMode.EndHalfHourBlocksShort;
			this.dayView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dayView.ContextMenuStrip = this.ctxDayView;
			this.dayView.DaysToShow = 5;
			this.dayView.DrawAllAppBorder = false;
			this.dayView.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.dayView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.dayView.HalfHourHeight = 20;
			this.dayView.Location = new System.Drawing.Point(23, 319);
			this.dayView.MinHalfHourApp = true;
			this.dayView.Name = "dayView";
			this.dayView.SelectionEnd = new System.DateTime(2016, 3, 9, 23, 28, 51, 0);
			this.dayView.SelectionStart = new System.DateTime(2016, 3, 9, 23, 29, 0, 0);
			this.dayView.Size = new System.Drawing.Size(1453, 509);
			this.dayView.SlotsPerHour = 2;
			this.dayView.StartDate = new System.DateTime(((long)(0)));
			this.dayView.TabIndex = 0;
			this.dayView.Text = "Kalender";
			this.dayView.WorkingHourEnd = 17;
			this.dayView.WorkingMinuteEnd = 0;
			this.dayView.WorkingMinuteStart = 0;
			this.dayView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dayView_MouseDoubleClick);
			// 
			// ctxDayView
			// 
			this.ctxDayView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmnuNeuerTermin,
            this.ctxmnuAddBesuchstermin,
            this.ctxmnuLinkBesuchstermin,
            this.toolStripMenuItem1,
            this.ctxOpenAppointment,
            this.ctxcmdTermindetails});
			this.ctxDayView.Name = "ctxDayView";
			this.ctxDayView.Size = new System.Drawing.Size(216, 120);
			// 
			// ctxmnuNeuerTermin
			// 
			this.ctxmnuNeuerTermin.Name = "ctxmnuNeuerTermin";
			this.ctxmnuNeuerTermin.Size = new System.Drawing.Size(215, 22);
			this.ctxmnuNeuerTermin.Text = "Neuer Termin";
			this.ctxmnuNeuerTermin.Click += new System.EventHandler(this.ctxmnuAddTermin_Click);
			// 
			// ctxmnuAddBesuchstermin
			// 
			this.ctxmnuAddBesuchstermin.Name = "ctxmnuAddBesuchstermin";
			this.ctxmnuAddBesuchstermin.Size = new System.Drawing.Size(215, 22);
			this.ctxmnuAddBesuchstermin.Text = "Neuer Besuchstermin";
			this.ctxmnuAddBesuchstermin.Click += new System.EventHandler(this.ctxmnuAddBesuchstermin_Click);
			// 
			// ctxmnuLinkBesuchstermin
			// 
			this.ctxmnuLinkBesuchstermin.Name = "ctxmnuLinkBesuchstermin";
			this.ctxmnuLinkBesuchstermin.Size = new System.Drawing.Size(215, 22);
			this.ctxmnuLinkBesuchstermin.Text = "Besuchstermin verknüpfen";
			this.ctxmnuLinkBesuchstermin.Click += new System.EventHandler(this.ctxmnuLinkBesuchstermin_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
			// 
			// ctxOpenAppointment
			// 
			this.ctxOpenAppointment.Name = "ctxOpenAppointment";
			this.ctxOpenAppointment.Size = new System.Drawing.Size(215, 22);
			this.ctxOpenAppointment.Text = "Öffnen";
			this.ctxOpenAppointment.Click += new System.EventHandler(this.ctxOpenAppointment_Click);
			// 
			// ctxcmdTermindetails
			// 
			this.ctxcmdTermindetails.Name = "ctxcmdTermindetails";
			this.ctxcmdTermindetails.Size = new System.Drawing.Size(215, 22);
			this.ctxcmdTermindetails.Text = "Termindetails anzeigen";
			this.ctxcmdTermindetails.Click += new System.EventHandler(this.ctxcmdTermindetails_Click);
			// 
			// monthCalendar
			// 
			this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
			this.monthCalendar.CalendarDimensions = new System.Drawing.Size(7, 1);
			this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
			this.monthCalendar.Location = new System.Drawing.Point(20, 60);
			this.monthCalendar.Margin = new System.Windows.Forms.Padding(0);
			this.monthCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
			this.monthCalendar.MaxSelectionCount = 5;
			this.monthCalendar.MinDate = new System.DateTime(1963, 12, 17, 0, 0, 0, 0);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.ShowTodayCircle = false;
			this.monthCalendar.ShowWeekNumbers = true;
			this.monthCalendar.TabIndex = 1;
			this.monthCalendar.TodayDate = new System.DateTime(2015, 7, 8, 0, 0, 0, 0);
			this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
			// 
			// mbtnOK
			// 
			this.mbtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnOK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnOK.Location = new System.Drawing.Point(1382, 854);
			this.mbtnOK.Name = "mbtnOK";
			this.mbtnOK.Size = new System.Drawing.Size(100, 28);
			this.mbtnOK.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnOK.TabIndex = 7;
			this.mbtnOK.Text = "OK";
			this.mbtnOK.UseSelectable = true;
			this.mbtnOK.UseStyleColors = true;
			this.mbtnOK.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// lblAktuellerTermin
			// 
			this.lblAktuellerTermin.AutoSize = true;
			this.lblAktuellerTermin.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblAktuellerTermin.Location = new System.Drawing.Point(216, 291);
			this.lblAktuellerTermin.Name = "lblAktuellerTermin";
			this.lblAktuellerTermin.Size = new System.Drawing.Size(62, 25);
			this.lblAktuellerTermin.TabIndex = 6;
			this.lblAktuellerTermin.Text = "Termin";
			// 
			// chkAndereKalender
			// 
			this.chkAndereKalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.chkAndereKalender.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chkAndereKalender.CheckOnClick = true;
			this.chkAndereKalender.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAndereKalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.chkAndereKalender.FormattingEnabled = true;
			this.chkAndereKalender.Items.AddRange(new object[] {
            "Felix",
            "Matthias",
            "Johannes",
            "Markus",
            "Rogge",
            "Axel",
            "Tanja",
            "Saskia",
            "Sezen",
            "Julian"});
			this.chkAndereKalender.Location = new System.Drawing.Point(246, 238);
			this.chkAndereKalender.MultiColumn = true;
			this.chkAndereKalender.Name = "chkAndereKalender";
			this.chkAndereKalender.Size = new System.Drawing.Size(1230, 20);
			this.chkAndereKalender.TabIndex = 2;
			this.chkAndereKalender.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkAndereKalender_ItemCheck);
			// 
			// mlblVanAnderen
			// 
			this.mlblVanAnderen.AutoSize = true;
			this.mlblVanAnderen.Location = new System.Drawing.Point(111, 238);
			this.mlblVanAnderen.Name = "mlblVanAnderen";
			this.mlblVanAnderen.Size = new System.Drawing.Size(111, 19);
			this.mlblVanAnderen.TabIndex = 7;
			this.mlblVanAnderen.Text = "Andere Kalender:";
			// 
			// mlblKalenderVon
			// 
			this.mlblKalenderVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblKalenderVon.AutoSize = true;
			this.mlblKalenderVon.Location = new System.Drawing.Point(23, 866);
			this.mlblKalenderVon.Name = "mlblKalenderVon";
			this.mlblKalenderVon.Size = new System.Drawing.Size(115, 19);
			this.mlblKalenderVon.TabIndex = 10;
			this.mlblKalenderVon.Text = "Aktueller Kalender";
			// 
			// mlblSelektierterTermin
			// 
			this.mlblSelektierterTermin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblSelektierterTermin.AutoSize = true;
			this.mlblSelektierterTermin.Location = new System.Drawing.Point(246, 866);
			this.mlblSelektierterTermin.Name = "mlblSelektierterTermin";
			this.mlblSelektierterTermin.Size = new System.Drawing.Size(144, 19);
			this.mlblSelektierterTermin.TabIndex = 11;
			this.mlblSelektierterTermin.Text = "Kein Termin ausgewählt";
			// 
			// btnGanzeWoche
			// 
			this.btnGanzeWoche.BackgroundImage = global::Products.Common.Properties.Resources.a7_16_metrolime;
			this.btnGanzeWoche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnGanzeWoche.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnGanzeWoche.Location = new System.Drawing.Point(155, 275);
			this.btnGanzeWoche.Name = "btnGanzeWoche";
			this.btnGanzeWoche.Size = new System.Drawing.Size(38, 38);
			this.btnGanzeWoche.TabIndex = 6;
			this.btnGanzeWoche.UseSelectable = true;
			this.btnGanzeWoche.Click += new System.EventHandler(this.btnGanzeWoche_Click);
			// 
			// btnArbeitswoche
			// 
			this.btnArbeitswoche.BackgroundImage = global::Products.Common.Properties.Resources.a5_16_metrolime;
			this.btnArbeitswoche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnArbeitswoche.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnArbeitswoche.Location = new System.Drawing.Point(111, 275);
			this.btnArbeitswoche.Name = "btnArbeitswoche";
			this.btnArbeitswoche.Size = new System.Drawing.Size(38, 38);
			this.btnArbeitswoche.TabIndex = 5;
			this.btnArbeitswoche.UseSelectable = true;
			this.btnArbeitswoche.Click += new System.EventHandler(this.btnArbeitswoche_Click);
			// 
			// btnEinTag
			// 
			this.btnEinTag.BackgroundImage = global::Products.Common.Properties.Resources.a1_16_metrolime;
			this.btnEinTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnEinTag.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnEinTag.Location = new System.Drawing.Point(67, 275);
			this.btnEinTag.Name = "btnEinTag";
			this.btnEinTag.Size = new System.Drawing.Size(38, 38);
			this.btnEinTag.TabIndex = 4;
			this.btnEinTag.UseSelectable = true;
			this.btnEinTag.Click += new System.EventHandler(this.btnEinTag_Click);
			// 
			// btnHeute
			// 
			this.btnHeute.BackgroundImage = global::Products.Common.Properties.Resources.heute_16_metrolime;
			this.btnHeute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnHeute.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnHeute.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnHeute.Location = new System.Drawing.Point(23, 275);
			this.btnHeute.Name = "btnHeute";
			this.btnHeute.Size = new System.Drawing.Size(38, 38);
			this.btnHeute.Style = MetroFramework.MetroColorStyle.Lime;
			this.btnHeute.TabIndex = 3;
			this.btnHeute.Text = "Heute";
			this.btnHeute.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHeute.UseSelectable = true;
			this.btnHeute.UseStyleColors = true;
			this.btnHeute.Click += new System.EventHandler(this.btnHeute_Click);
			// 
			// CalendarView
			// 
			this.AcceptButton = this.mbtnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnOK;
			this.ClientSize = new System.Drawing.Size(1505, 905);
			this.Controls.Add(this.btnGanzeWoche);
			this.Controls.Add(this.btnArbeitswoche);
			this.Controls.Add(this.btnEinTag);
			this.Controls.Add(this.btnHeute);
			this.Controls.Add(this.mlblSelektierterTermin);
			this.Controls.Add(this.mlblKalenderVon);
			this.Controls.Add(this.mbtnOK);
			this.Controls.Add(this.dayView);
			this.Controls.Add(this.mlblVanAnderen);
			this.Controls.Add(this.chkAndereKalender);
			this.Controls.Add(this.lblAktuellerTermin);
			this.Controls.Add(this.monthCalendar);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CalendarView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Kalender";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalendarView_FormClosing);
			this.ctxDayView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		//private Calendar.Appointment termin;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private MetroFramework.Controls.MetroLabel lblAktuellerTermin;
		private System.Windows.Forms.ContextMenuStrip ctxDayView;
		private System.Windows.Forms.ToolStripMenuItem ctxmnuNeuerTermin;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ctxOpenAppointment;
		private MetroFramework.Controls.MetroButton mbtnOK;
		private System.Windows.Forms.CheckedListBox chkAndereKalender;
		private MetroFramework.Controls.MetroLabel mlblVanAnderen;
		private Calendar.DayView dayView;
		private MetroFramework.Controls.MetroLabel mlblKalenderVon;
		private MetroFramework.Controls.MetroLabel mlblSelektierterTermin;
		private MetroFramework.Controls.MetroButton btnHeute;
		private MetroFramework.Controls.MetroButton btnGanzeWoche;
		private MetroFramework.Controls.MetroButton btnArbeitswoche;
		private MetroFramework.Controls.MetroButton btnEinTag;
		private System.Windows.Forms.ToolStripMenuItem ctxcmdTermindetails;
		private System.Windows.Forms.ToolStripMenuItem ctxmnuLinkBesuchstermin;
		private System.Windows.Forms.ToolStripMenuItem ctxmnuAddBesuchstermin;
	}
}