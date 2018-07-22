namespace Products.Common.Views
{
	partial class KalenderView
	{

#pragma warning disable CS0618 // Typ oder Element ist veraltet

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
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.DateSelector = new System.Windows.Forms.MonthCalendar();
			this.mlblActiveUsers = new MetroFramework.Controls.MetroLabel();
			this.tipAppointmentInfo = new System.Windows.Forms.ToolTip(this.components);
			this.htipHtml = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.mcmdClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnFelix = new MetroFramework.Controls.MetroButton();
			this.mbtnMatti = new MetroFramework.Controls.MetroButton();
			this.mbtnJohannes = new MetroFramework.Controls.MetroButton();
			this.mbtnAxel = new MetroFramework.Controls.MetroButton();
			this.mbtnMarkusS = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mtxtSelectDate = new MetroFramework.Controls.MetroTextBox();
			this.xcmdShowAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdMoveAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdDeleteAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdCalendarSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRefreshAppointments = new System.Windows.Forms.Button();
			this.mbtnSettings = new MetroFramework.Controls.MetroButton();
			this.mbtnToday = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnForwardOneWeek = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnBackOneWeek = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
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
			this.DayViewMain.Size = new System.Drawing.Size(1139, 702);
			this.DayViewMain.StartDate = new System.DateTime(2016, 3, 14, 0, 0, 0, 0);
			this.DayViewMain.StartHour = 7;
			this.DayViewMain.TabIndex = 0;
			this.DayViewMain.Text = "Kalender";
			this.DayViewMain.WorkingHourEnd = 17;
			this.DayViewMain.WorkingMinuteEnd = 0;
			this.DayViewMain.WorkingMinuteStart = 0;
			this.DayViewMain.SelectionChanged += new System.EventHandler(this.DayViewMain_SelectionChanged);
			this.DayViewMain.AppointmentMove += new System.EventHandler<Calendar.AppointmentEventArgs>(this.DayViewMain_AppointmentMove);
			this.DayViewMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DayViewMain_MouseDoubleClick);
			// 
			// mctxCalendar
			// 
			this.mctxCalendar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mctxCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowAppointment,
            this.xcmdMoveAppointment,
            this.xcmdNewAppointment,
            this.xcmdDeleteAppointment,
            this.toolStripMenuItem1,
            this.xcmdCalendarSettings});
			this.mctxCalendar.Name = "mctxCalendar";
			this.mctxCalendar.Size = new System.Drawing.Size(222, 142);
			this.mctxCalendar.Opening += new System.ComponentModel.CancelEventHandler(this.mctxCalendar_Opening);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
			// 
			// DateSelector
			// 
			this.DateSelector.CalendarDimensions = new System.Drawing.Size(1, 3);
			this.DateSelector.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
			this.DateSelector.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateSelector.Location = new System.Drawing.Point(29, 159);
			this.DateSelector.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.DateSelector.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
			this.DateSelector.Name = "DateSelector";
			this.DateSelector.ScrollChange = 1;
			this.DateSelector.TabIndex = 5;
			this.DateSelector.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.DateSelector.TitleForeColor = System.Drawing.Color.Red;
			this.DateSelector.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.DateSelector.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateSelector_DateChanged);
			// 
			// mlblActiveUsers
			// 
			this.mlblActiveUsers.AutoSize = true;
			this.mlblActiveUsers.Location = new System.Drawing.Point(416, 83);
			this.mlblActiveUsers.Name = "mlblActiveUsers";
			this.mlblActiveUsers.Size = new System.Drawing.Size(111, 19);
			this.mlblActiveUsers.TabIndex = 2;
			this.mlblActiveUsers.Text = "Andere Kalender:";
			// 
			// tipAppointmentInfo
			// 
			this.tipAppointmentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			// 
			// htipHtml
			// 
			this.htipHtml.OwnerDraw = true;
			// 
			// mcmdClose
			// 
			this.mcmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmdClose.Image = null;
			this.mcmdClose.Location = new System.Drawing.Point(1272, 873);
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
			this.metroTextButton1.Location = new System.Drawing.Point(273, 77);
			this.metroTextButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.metroTextButton1.Name = "metroTextButton1";
			this.metroTextButton1.Size = new System.Drawing.Size(137, 26);
			this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTextButton1.TabIndex = 1;
			this.metroTextButton1.Text = "Angezeigte Kalender";
			this.metroTextButton1.UseSelectable = true;
			this.metroTextButton1.UseVisualStyleBackColor = true;
			this.metroTextButton1.Click += new System.EventHandler(this.mbtnActiveCalendars_Click);
			// 
			// mbtnFelix
			// 
			this.mbtnFelix.Location = new System.Drawing.Point(75, 660);
			this.mbtnFelix.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mbtnFelix.Name = "mbtnFelix";
			this.mbtnFelix.Size = new System.Drawing.Size(114, 23);
			this.mbtnFelix.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnFelix.TabIndex = 6;
			this.mbtnFelix.Text = "Felix";
			this.mbtnFelix.UseCustomBackColor = true;
			this.mbtnFelix.UseSelectable = true;
			this.mbtnFelix.UseStyleColors = true;
			this.mbtnFelix.Click += new System.EventHandler(this.mbtnFelix_Click);
			// 
			// mbtnMatti
			// 
			this.mbtnMatti.Location = new System.Drawing.Point(75, 696);
			this.mbtnMatti.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mbtnMatti.Name = "mbtnMatti";
			this.mbtnMatti.Size = new System.Drawing.Size(114, 23);
			this.mbtnMatti.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnMatti.TabIndex = 7;
			this.mbtnMatti.Text = "Matthias";
			this.mbtnMatti.UseCustomBackColor = true;
			this.mbtnMatti.UseSelectable = true;
			this.mbtnMatti.UseStyleColors = true;
			this.mbtnMatti.Click += new System.EventHandler(this.mbtnMatti_Click);
			// 
			// mbtnJohannes
			// 
			this.mbtnJohannes.Location = new System.Drawing.Point(75, 732);
			this.mbtnJohannes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mbtnJohannes.Name = "mbtnJohannes";
			this.mbtnJohannes.Size = new System.Drawing.Size(114, 23);
			this.mbtnJohannes.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnJohannes.TabIndex = 8;
			this.mbtnJohannes.Text = "Johannes";
			this.mbtnJohannes.UseCustomBackColor = true;
			this.mbtnJohannes.UseSelectable = true;
			this.mbtnJohannes.UseStyleColors = true;
			this.mbtnJohannes.Click += new System.EventHandler(this.mbtnJohannes_Click);
			// 
			// mbtnAxel
			// 
			this.mbtnAxel.Location = new System.Drawing.Point(75, 804);
			this.mbtnAxel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mbtnAxel.Name = "mbtnAxel";
			this.mbtnAxel.Size = new System.Drawing.Size(114, 23);
			this.mbtnAxel.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnAxel.TabIndex = 10;
			this.mbtnAxel.Text = "Axel";
			this.mbtnAxel.UseCustomBackColor = true;
			this.mbtnAxel.UseSelectable = true;
			this.mbtnAxel.UseStyleColors = true;
			this.mbtnAxel.Click += new System.EventHandler(this.mbtnAxel_Click);
			// 
			// mbtnMarkusS
			// 
			this.mbtnMarkusS.Location = new System.Drawing.Point(75, 768);
			this.mbtnMarkusS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mbtnMarkusS.Name = "mbtnMarkusS";
			this.mbtnMarkusS.Size = new System.Drawing.Size(114, 23);
			this.mbtnMarkusS.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnMarkusS.TabIndex = 9;
			this.mbtnMarkusS.Text = "Markus S.";
			this.mbtnMarkusS.UseCustomBackColor = true;
			this.mbtnMarkusS.UseSelectable = true;
			this.mbtnMarkusS.UseStyleColors = true;
			this.mbtnMarkusS.Click += new System.EventHandler(this.mbtnMarkusS_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(75, 628);
			this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(114, 19);
			this.metroLabel1.TabIndex = 21;
			this.metroLabel1.Text = "Neue Termine für:";
			// 
			// mtxtSelectDate
			// 
			// 
			// 
			// 
			this.mtxtSelectDate.CustomButton.Image = null;
			this.mtxtSelectDate.CustomButton.Location = new System.Drawing.Point(155, 1);
			this.mtxtSelectDate.CustomButton.Name = "";
			this.mtxtSelectDate.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtSelectDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSelectDate.CustomButton.TabIndex = 1;
			this.mtxtSelectDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSelectDate.CustomButton.UseSelectable = true;
			this.mtxtSelectDate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSelectDate.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtSelectDate.Lines = new string[0];
			this.mtxtSelectDate.Location = new System.Drawing.Point(30, 148);
			this.mtxtSelectDate.MaxLength = 32767;
			this.mtxtSelectDate.Name = "mtxtSelectDate";
			this.mtxtSelectDate.PasswordChar = '\0';
			this.mtxtSelectDate.PromptText = "Datum eingeben";
			this.mtxtSelectDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSelectDate.SelectedText = "";
			this.mtxtSelectDate.SelectionLength = 0;
			this.mtxtSelectDate.SelectionStart = 0;
			this.mtxtSelectDate.ShortcutsEnabled = true;
			this.mtxtSelectDate.ShowButton = true;
			this.mtxtSelectDate.ShowClearButton = true;
			this.mtxtSelectDate.Size = new System.Drawing.Size(177, 23);
			this.mtxtSelectDate.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtSelectDate.TabIndex = 2;
			this.mtxtSelectDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtSelectDate.UseSelectable = true;
			this.mtxtSelectDate.WaterMark = "Datum eingeben";
			this.mtxtSelectDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSelectDate.WaterMarkFont = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtSelectDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtSelectDate_KeyUp);
			this.mtxtSelectDate.Validated += new System.EventHandler(this.mtxtSelectDate_Validated);
			// 
			// xcmdShowAppointment
			// 
			this.xcmdShowAppointment.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdShowAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.xcmdShowAppointment.Name = "xcmdShowAppointment";
			this.xcmdShowAppointment.Size = new System.Drawing.Size(221, 22);
			this.xcmdShowAppointment.Text = "Ö&ffnen";
			this.xcmdShowAppointment.Click += new System.EventHandler(this.xcmdShowAppointment_Click);
			// 
			// xcmdMoveAppointment
			// 
			this.xcmdMoveAppointment.Image = global::Products.Common.Properties.Resources.move_16_metroorange;
			this.xcmdMoveAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.xcmdMoveAppointment.Name = "xcmdMoveAppointment";
			this.xcmdMoveAppointment.Size = new System.Drawing.Size(221, 22);
			this.xcmdMoveAppointment.Text = "&Verschieben (zu Mitarbeiter)";
			this.xcmdMoveAppointment.Click += new System.EventHandler(this.xcmdMoveAppointment_Click);
			// 
			// xcmdNewAppointment
			// 
			this.xcmdNewAppointment.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdNewAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.xcmdNewAppointment.Name = "xcmdNewAppointment";
			this.xcmdNewAppointment.Size = new System.Drawing.Size(221, 22);
			this.xcmdNewAppointment.Text = "&Neu";
			this.xcmdNewAppointment.Click += new System.EventHandler(this.xcmdNewAppointment_Click);
			// 
			// xcmdDeleteAppointment
			// 
			this.xcmdDeleteAppointment.Image = global::Products.Common.Properties.Resources.delete_16_metroorange;
			this.xcmdDeleteAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.xcmdDeleteAppointment.Name = "xcmdDeleteAppointment";
			this.xcmdDeleteAppointment.Size = new System.Drawing.Size(221, 22);
			this.xcmdDeleteAppointment.Text = "&Löschen";
			this.xcmdDeleteAppointment.Click += new System.EventHandler(this.xcmdDeleteAppointment_Click);
			// 
			// xcmdCalendarSettings
			// 
			this.xcmdCalendarSettings.Image = global::Products.Common.Properties.Resources.settings_a_16_metroorange;
			this.xcmdCalendarSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.xcmdCalendarSettings.Name = "xcmdCalendarSettings";
			this.xcmdCalendarSettings.Size = new System.Drawing.Size(221, 22);
			this.xcmdCalendarSettings.Text = "&Einstellungen";
			this.xcmdCalendarSettings.Click += new System.EventHandler(this.xcmdCalendarSettings_Click);
			// 
			// btnRefreshAppointments
			// 
			this.btnRefreshAppointments.BackColor = System.Drawing.Color.Transparent;
			this.btnRefreshAppointments.BackgroundImage = global::Products.Common.Properties.Resources.refresh_32_metroorange;
			this.btnRefreshAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnRefreshAppointments.FlatAppearance.BorderSize = 0;
			this.btnRefreshAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshAppointments.Location = new System.Drawing.Point(224, 72);
			this.btnRefreshAppointments.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
			this.btnRefreshAppointments.Name = "btnRefreshAppointments";
			this.btnRefreshAppointments.Size = new System.Drawing.Size(36, 36);
			this.btnRefreshAppointments.TabIndex = 0;
			this.tipAppointmentInfo.SetToolTip(this.btnRefreshAppointments, "David-Termine neu einlesen ...");
			this.btnRefreshAppointments.UseVisualStyleBackColor = false;
			this.btnRefreshAppointments.Click += new System.EventHandler(this.btnRefreshAppointments_Click);
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
			this.mbtnToday.TabIndex = 3;
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
			this.mbtnForwardOneWeek.TabIndex = 4;
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
			this.mbtnBackOneWeek.TabIndex = 2;
			this.tipAppointmentInfo.SetToolTip(this.mbtnBackOneWeek, "1 Woche zurück");
			this.mbtnBackOneWeek.UseCustomBackColor = true;
			this.mbtnBackOneWeek.UseSelectable = true;
			this.mbtnBackOneWeek.UseVisualStyleBackColor = true;
			this.mbtnBackOneWeek.Click += new System.EventHandler(this.mbtnBackOneWeek_Click);
			// 
			// KalenderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(1395, 911);
			this.ContextMenuStrip = this.mctxCalendar;
			this.Controls.Add(this.mtxtSelectDate);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mbtnMarkusS);
			this.Controls.Add(this.mbtnAxel);
			this.Controls.Add(this.mbtnJohannes);
			this.Controls.Add(this.mbtnMatti);
			this.Controls.Add(this.mbtnFelix);
			this.Controls.Add(this.btnRefreshAppointments);
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
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
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
		private System.Windows.Forms.Button btnRefreshAppointments;
		private MetroFramework.Controls.MetroButton mbtnFelix;
		private MetroFramework.Controls.MetroButton mbtnMatti;
		private MetroFramework.Controls.MetroButton mbtnJohannes;
		private MetroFramework.Controls.MetroButton mbtnAxel;
		private MetroFramework.Controls.MetroButton mbtnMarkusS;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox mtxtSelectDate;
		private System.Windows.Forms.ToolStripMenuItem xcmdMoveAppointment;
	}
}