namespace Products.Common.Views
{
	partial class KalenderView
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
			Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalenderView));
			this.DayViewMain = new Calendar.DayView();
			this.mctxCalendar = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdShowAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdDeleteAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdCalendarSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.DateSelector = new System.Windows.Forms.MonthCalendar();
			this.mlblActiveUsers = new MetroFramework.Controls.MetroLabel();
			this.tipAppointmentInfo = new System.Windows.Forms.ToolTip(this.components);
			this.mbtnSettings = new MetroFramework.Controls.MetroButton();
			this.mbtnToday = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnForwardOneWeek = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnBackOneWeek = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.htipHtml = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.mcmdClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mctxCalendar.SuspendLayout();
			this.SuspendLayout();
			// 
			// DayViewMain
			// 
			drawTool1.DayView = this.DayViewMain;
			this.DayViewMain.ActiveTool = drawTool1;
			this.DayViewMain.AllowInplaceEditing = false;
			this.DayViewMain.AmPmDisplay = false;
			this.DayViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DayViewMain.AppHeightMode = Calendar.DayView.AppHeightDrawMode.FullHalfHourBlocksShort;
			this.DayViewMain.ContextMenuStrip = this.mctxCalendar;
			this.DayViewMain.DaysToShow = 5;
			this.DayViewMain.DrawAllAppBorder = false;
			this.DayViewMain.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.DayViewMain.Location = new System.Drawing.Point(224, 148);
			this.DayViewMain.Margin = new System.Windows.Forms.Padding(3, 3, 15, 30);
			this.DayViewMain.MinHalfHourApp = true;
			this.DayViewMain.MinimumSize = new System.Drawing.Size(0, 700);
			this.DayViewMain.Name = "DayViewMain";
			this.DayViewMain.SelectionEnd = new System.DateTime(((long)(0)));
			this.DayViewMain.SelectionStart = new System.DateTime(((long)(0)));
			this.DayViewMain.Size = new System.Drawing.Size(1139, 700);
			this.DayViewMain.StartDate = new System.DateTime(2016, 3, 14, 0, 0, 0, 0);
			this.DayViewMain.StartHour = 7;
			this.DayViewMain.TabIndex = 0;
			this.DayViewMain.Text = "Kalender";
			this.DayViewMain.WorkingHourEnd = 17;
			this.DayViewMain.WorkingMinuteEnd = 0;
			this.DayViewMain.WorkingMinuteStart = 0;
			this.DayViewMain.SelectionChanged += new System.EventHandler(this.DayViewMain_SelectionChanged);
			this.DayViewMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DayViewMain_MouseDoubleClick);
			// 
			// mctxCalendar
			// 
			this.mctxCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowAppointment,
            this.xcmdNewAppointment,
            this.xcmdDeleteAppointment,
            this.toolStripMenuItem1,
            this.xcmdCalendarSettings});
			this.mctxCalendar.Name = "mctxCalendar";
			this.mctxCalendar.Size = new System.Drawing.Size(156, 98);
			this.mctxCalendar.Opening += new System.ComponentModel.CancelEventHandler(this.mctxCalendar_Opening);
			// 
			// xcmdShowAppointment
			// 
			this.xcmdShowAppointment.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdShowAppointment.Name = "xcmdShowAppointment";
			this.xcmdShowAppointment.Size = new System.Drawing.Size(155, 22);
			this.xcmdShowAppointment.Text = "Öffnen";
			this.xcmdShowAppointment.Click += new System.EventHandler(this.xcmdShowAppointment_Click);
			// 
			// xcmdNewAppointment
			// 
			this.xcmdNewAppointment.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdNewAppointment.Name = "xcmdNewAppointment";
			this.xcmdNewAppointment.Size = new System.Drawing.Size(155, 22);
			this.xcmdNewAppointment.Text = "Neuer Termin";
			this.xcmdNewAppointment.Click += new System.EventHandler(this.xcmdNewAppointment_Click);
			// 
			// xcmdDeleteAppointment
			// 
			this.xcmdDeleteAppointment.Image = global::Products.Common.Properties.Resources.delete_16_metroorange;
			this.xcmdDeleteAppointment.Name = "xcmdDeleteAppointment";
			this.xcmdDeleteAppointment.Size = new System.Drawing.Size(155, 22);
			this.xcmdDeleteAppointment.Text = "Termin löschen";
			this.xcmdDeleteAppointment.Click += new System.EventHandler(this.xcmdDeleteAppointment_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
			// 
			// xcmdCalendarSettings
			// 
			this.xcmdCalendarSettings.Image = global::Products.Common.Properties.Resources.settings_a_16_metroorange;
			this.xcmdCalendarSettings.Name = "xcmdCalendarSettings";
			this.xcmdCalendarSettings.Size = new System.Drawing.Size(155, 22);
			this.xcmdCalendarSettings.Text = "Einstellungen";
			this.xcmdCalendarSettings.Click += new System.EventHandler(this.xcmdCalendarSettings_Click);
			// 
			// DateSelector
			// 
			this.DateSelector.CalendarDimensions = new System.Drawing.Size(1, 5);
			this.DateSelector.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
			this.DateSelector.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateSelector.Location = new System.Drawing.Point(34, 120);
			this.DateSelector.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.DateSelector.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
			this.DateSelector.Name = "DateSelector";
			this.DateSelector.ScrollChange = 1;
			this.DateSelector.TabIndex = 1;
			this.DateSelector.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.DateSelector.TitleForeColor = System.Drawing.Color.Red;
			this.DateSelector.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.DateSelector.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateSelector_DateChanged);
			// 
			// mlblActiveUsers
			// 
			this.mlblActiveUsers.AutoSize = true;
			this.mlblActiveUsers.Location = new System.Drawing.Point(367, 83);
			this.mlblActiveUsers.Name = "mlblActiveUsers";
			this.mlblActiveUsers.Size = new System.Drawing.Size(111, 19);
			this.mlblActiveUsers.TabIndex = 2;
			this.mlblActiveUsers.Text = "Andere Kalender:";
			// 
			// tipAppointmentInfo
			// 
			this.tipAppointmentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			// 
			// mbtnSettings
			// 
			this.mbtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnSettings.BackColor = System.Drawing.Color.Transparent;
			this.mbtnSettings.BackgroundImage = global::Products.Common.Properties.Resources.settings_24_metroorange;
			this.mbtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnSettings.Location = new System.Drawing.Point(1333, 83);
			this.mbtnSettings.Name = "mbtnSettings";
			this.mbtnSettings.Size = new System.Drawing.Size(30, 30);
			this.mbtnSettings.TabIndex = 12;
			this.tipAppointmentInfo.SetToolTip(this.mbtnSettings, "Einstellungen");
			this.mbtnSettings.UseCustomBackColor = true;
			this.mbtnSettings.UseCustomForeColor = true;
			this.mbtnSettings.UseSelectable = true;
			this.mbtnSettings.Click += new System.EventHandler(this.mbtnSettings_Click);
			// 
			// mbtnToday
			// 
			this.mbtnToday.Image = global::Products.Common.Properties.Resources.today_24_metrowhite;
			this.mbtnToday.Location = new System.Drawing.Point(775, 116);
			this.mbtnToday.Name = "mbtnToday";
			this.mbtnToday.Size = new System.Drawing.Size(100, 26);
			this.mbtnToday.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnToday.TabIndex = 10;
			this.tipAppointmentInfo.SetToolTip(this.mbtnToday, "Heute");
			this.mbtnToday.UseCustomBackColor = true;
			this.mbtnToday.UseCustomForeColor = true;
			this.mbtnToday.UseSelectable = true;
			this.mbtnToday.UseStyleColors = true;
			this.mbtnToday.UseVisualStyleBackColor = false;
			this.mbtnToday.Click += new System.EventHandler(this.mbtnToday_Click);
			// 
			// mbtnForwardOneWeek
			// 
			this.mbtnForwardOneWeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mbtnForwardOneWeek.Image = global::Products.Common.Properties.Resources.arrowright_24_metrowhite;
			this.mbtnForwardOneWeek.Location = new System.Drawing.Point(881, 116);
			this.mbtnForwardOneWeek.Name = "mbtnForwardOneWeek";
			this.mbtnForwardOneWeek.Size = new System.Drawing.Size(482, 26);
			this.mbtnForwardOneWeek.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnForwardOneWeek.TabIndex = 8;
			this.tipAppointmentInfo.SetToolTip(this.mbtnForwardOneWeek, "1 Woche weiter");
			this.mbtnForwardOneWeek.UseSelectable = true;
			this.mbtnForwardOneWeek.UseVisualStyleBackColor = true;
			this.mbtnForwardOneWeek.Click += new System.EventHandler(this.mbtnForwardOneWeek_Click);
			// 
			// mbtnBackOneWeek
			// 
			this.mbtnBackOneWeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mbtnBackOneWeek.Image = global::Products.Common.Properties.Resources.arrowleft_24_metrowhite;
			this.mbtnBackOneWeek.Location = new System.Drawing.Point(224, 116);
			this.mbtnBackOneWeek.Name = "mbtnBackOneWeek";
			this.mbtnBackOneWeek.Size = new System.Drawing.Size(545, 26);
			this.mbtnBackOneWeek.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnBackOneWeek.TabIndex = 5;
			this.tipAppointmentInfo.SetToolTip(this.mbtnBackOneWeek, "1 Woche zurück");
			this.mbtnBackOneWeek.UseCustomBackColor = true;
			this.mbtnBackOneWeek.UseSelectable = true;
			this.mbtnBackOneWeek.UseVisualStyleBackColor = true;
			this.mbtnBackOneWeek.Click += new System.EventHandler(this.mbtnBackOneWeek_Click);
			// 
			// htipHtml
			// 
			this.htipHtml.OwnerDraw = true;
			// 
			// mcmdClose
			// 
			this.mcmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmdClose.Image = null;
			this.mcmdClose.Location = new System.Drawing.Point(1272, 871);
			this.mcmdClose.Name = "mcmdClose";
			this.mcmdClose.Size = new System.Drawing.Size(100, 26);
			this.mcmdClose.Style = MetroFramework.MetroColorStyle.Orange;
			this.mcmdClose.TabIndex = 11;
			this.mcmdClose.Text = "Schließen";
			this.mcmdClose.UseSelectable = true;
			this.mcmdClose.UseVisualStyleBackColor = true;
			this.mcmdClose.Click += new System.EventHandler(this.mcmdClose_Click);
			// 
			// metroTextButton1
			// 
			this.metroTextButton1.Image = null;
			this.metroTextButton1.Location = new System.Drawing.Point(224, 76);
			this.metroTextButton1.Name = "metroTextButton1";
			this.metroTextButton1.Size = new System.Drawing.Size(137, 26);
			this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTextButton1.TabIndex = 13;
			this.metroTextButton1.Text = "Angezeigte Kalender";
			this.metroTextButton1.UseSelectable = true;
			this.metroTextButton1.UseVisualStyleBackColor = true;
			this.metroTextButton1.Click += new System.EventHandler(this.mbtnActiveCalendars_Click);
			// 
			// KalenderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1395, 920);
			this.ContextMenuStrip = this.mctxCalendar;
			this.Controls.Add(this.metroTextButton1);
			this.Controls.Add(this.mbtnSettings);
			this.Controls.Add(this.mcmdClose);
			this.Controls.Add(this.mbtnToday);
			this.Controls.Add(this.mbtnForwardOneWeek);
			this.Controls.Add(this.mbtnBackOneWeek);
			this.Controls.Add(this.mlblActiveUsers);
			this.Controls.Add(this.DateSelector);
			this.Controls.Add(this.DayViewMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KalenderView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalender";
			this.SizeChanged += new System.EventHandler(this.KalenderView_SizeChanged);
			this.mctxCalendar.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Calendar.DayView DayViewMain;
		private System.Windows.Forms.MonthCalendar DateSelector;
		private MetroFramework.Controls.MetroLabel mlblActiveUsers;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnBackOneWeek;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnForwardOneWeek;
		private System.Windows.Forms.ToolTip tipAppointmentInfo;
		private MetroFramework.Drawing.Html.HtmlToolTip htipHtml;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnToday;
		private MetroFramework.Controls.MetroContextMenu mctxCalendar;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowAppointment;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mcmdClose;
		private System.Windows.Forms.ToolStripMenuItem xcmdNewAppointment;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdCalendarSettings;
		private MetroFramework.Controls.MetroButton mbtnSettings;
		private System.Windows.Forms.ToolStripMenuItem xcmdDeleteAppointment;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
	}
}