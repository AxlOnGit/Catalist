namespace Products.Common.Views
{
	partial class TaskDetailView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailView));
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.mtxtTaskname = new MetroFramework.Controls.MetroTextBox();
			this.mtxtDescription = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.mcmbStatus = new MetroFramework.Controls.MetroComboBox();
			this.mcmbPriority = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.mcmbCompleted = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.mbtnShowReminder = new System.Windows.Forms.Button();
			this.btnShowDetails = new System.Windows.Forms.Button();
			this.btnNewTask = new System.Windows.Forms.Button();
			this.ndtpReminderTime = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpReminderDate = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpDueAt = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpStartsAt = new Products.UI.Controls.NullableDateTimePicker();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.btnClose.Location = new System.Drawing.Point(790, 694);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 26);
			this.btnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.UseStyleColors = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// mtxtTaskname
			// 
			this.mtxtTaskname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtTaskname.CustomButton.Image = null;
			this.mtxtTaskname.CustomButton.Location = new System.Drawing.Point(846, 1);
			this.mtxtTaskname.CustomButton.Name = "";
			this.mtxtTaskname.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtTaskname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtTaskname.CustomButton.TabIndex = 1;
			this.mtxtTaskname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtTaskname.CustomButton.UseSelectable = true;
			this.mtxtTaskname.CustomButton.Visible = false;
			this.mtxtTaskname.Lines = new string[0];
			this.mtxtTaskname.Location = new System.Drawing.Point(23, 154);
			this.mtxtTaskname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.mtxtTaskname.MaxLength = 32767;
			this.mtxtTaskname.Name = "mtxtTaskname";
			this.mtxtTaskname.PasswordChar = '\0';
			this.mtxtTaskname.PromptText = "Aufgabe";
			this.mtxtTaskname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtTaskname.SelectedText = "";
			this.mtxtTaskname.SelectionLength = 0;
			this.mtxtTaskname.SelectionStart = 0;
			this.mtxtTaskname.ShortcutsEnabled = true;
			this.mtxtTaskname.Size = new System.Drawing.Size(868, 23);
			this.mtxtTaskname.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtTaskname.TabIndex = 0;
			this.mtxtTaskname.UseSelectable = true;
			this.mtxtTaskname.UseStyleColors = true;
			this.mtxtTaskname.WaterMark = "Aufgabe";
			this.mtxtTaskname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtTaskname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtDescription
			// 
			this.mtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtDescription.CustomButton.Image = null;
			this.mtxtDescription.CustomButton.Location = new System.Drawing.Point(543, 2);
			this.mtxtDescription.CustomButton.Name = "";
			this.mtxtDescription.CustomButton.Size = new System.Drawing.Size(321, 321);
			this.mtxtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtDescription.CustomButton.TabIndex = 1;
			this.mtxtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtDescription.CustomButton.UseSelectable = true;
			this.mtxtDescription.CustomButton.Visible = false;
			this.mtxtDescription.Lines = new string[0];
			this.mtxtDescription.Location = new System.Drawing.Point(23, 343);
			this.mtxtDescription.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.mtxtDescription.MaxLength = 1000;
			this.mtxtDescription.Multiline = true;
			this.mtxtDescription.Name = "mtxtDescription";
			this.mtxtDescription.PasswordChar = '\0';
			this.mtxtDescription.PromptText = "Beschreibung";
			this.mtxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtDescription.SelectedText = "";
			this.mtxtDescription.SelectionLength = 0;
			this.mtxtDescription.SelectionStart = 0;
			this.mtxtDescription.ShortcutsEnabled = true;
			this.mtxtDescription.Size = new System.Drawing.Size(867, 326);
			this.mtxtDescription.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtDescription.TabIndex = 8;
			this.mtxtDescription.UseSelectable = true;
			this.mtxtDescription.UseStyleColors = true;
			this.mtxtDescription.WaterMark = "Beschreibung";
			this.mtxtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 207);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(79, 19);
			this.metroLabel1.TabIndex = 14;
			this.metroLabel1.Text = "Beginnt am:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 249);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(66, 19);
			this.metroLabel2.TabIndex = 15;
			this.metroLabel2.Text = "Fällig am:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(284, 207);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(43, 19);
			this.metroLabel3.TabIndex = 16;
			this.metroLabel3.Text = "Status";
			// 
			// mcmbStatus
			// 
			this.mcmbStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.mcmbStatus.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbStatus.FormattingEnabled = true;
			this.mcmbStatus.ItemHeight = 19;
			this.mcmbStatus.Location = new System.Drawing.Point(349, 207);
			this.mcmbStatus.Name = "mcmbStatus";
			this.mcmbStatus.Size = new System.Drawing.Size(198, 25);
			this.mcmbStatus.Style = MetroFramework.MetroColorStyle.Lime;
			this.mcmbStatus.TabIndex = 3;
			this.mcmbStatus.UseSelectable = true;
			this.mcmbStatus.UseStyleColors = true;
			// 
			// mcmbPriority
			// 
			this.mcmbPriority.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.mcmbPriority.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbPriority.FormattingEnabled = true;
			this.mcmbPriority.ItemHeight = 19;
			this.mcmbPriority.Location = new System.Drawing.Point(349, 249);
			this.mcmbPriority.Name = "mcmbPriority";
			this.mcmbPriority.Size = new System.Drawing.Size(103, 25);
			this.mcmbPriority.Style = MetroFramework.MetroColorStyle.Lime;
			this.mcmbPriority.TabIndex = 4;
			this.mcmbPriority.UseSelectable = true;
			this.mcmbPriority.UseStyleColors = true;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(284, 249);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(59, 19);
			this.metroLabel4.TabIndex = 18;
			this.metroLabel4.Text = "Priorität:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(23, 291);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(83, 19);
			this.metroLabel5.TabIndex = 20;
			this.metroLabel5.Text = "Erinnern am:";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(214, 291);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(28, 19);
			this.metroLabel6.TabIndex = 22;
			this.metroLabel6.Text = "um";
			// 
			// mcmbCompleted
			// 
			this.mcmbCompleted.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.mcmbCompleted.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbCompleted.FormattingEnabled = true;
			this.mcmbCompleted.ItemHeight = 19;
			this.mcmbCompleted.Items.AddRange(new object[] {
						"0",
						"25",
						"50",
						"75",
						"100"});
			this.mcmbCompleted.Location = new System.Drawing.Point(553, 249);
			this.mcmbCompleted.Name = "mcmbCompleted";
			this.mcmbCompleted.Size = new System.Drawing.Size(70, 25);
			this.mcmbCompleted.Style = MetroFramework.MetroColorStyle.Lime;
			this.mcmbCompleted.TabIndex = 5;
			this.mcmbCompleted.UseSelectable = true;
			this.mcmbCompleted.UseStyleColors = true;
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(475, 249);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(72, 19);
			this.metroLabel7.TabIndex = 24;
			this.metroLabel7.Text = "% erledigt:";
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
			this.metroToolTip1.UseAnimation = false;
			this.metroToolTip1.UseFading = false;
			// 
			// mbtnShowReminder
			// 
			this.mbtnShowReminder.BackColor = System.Drawing.Color.Transparent;
			this.mbtnShowReminder.FlatAppearance.BorderSize = 0;
			this.mbtnShowReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnShowReminder.Image = global::Products.Common.Properties.Resources.alarm_32_metrolime;
			this.mbtnShowReminder.Location = new System.Drawing.Point(838, 100);
			this.mbtnShowReminder.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.mbtnShowReminder.Name = "mbtnShowReminder";
			this.mbtnShowReminder.Size = new System.Drawing.Size(36, 36);
			this.mbtnShowReminder.TabIndex = 25;
			this.mbtnShowReminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.metroToolTip1.SetToolTip(this.mbtnShowReminder, "Erinnerung anzeigen");
			this.mbtnShowReminder.UseVisualStyleBackColor = false;
			this.mbtnShowReminder.Click += new System.EventHandler(this.mbtnShowReminder_Click);
			// 
			// btnShowDetails
			// 
			this.btnShowDetails.BackColor = System.Drawing.Color.Transparent;
			this.btnShowDetails.FlatAppearance.BorderSize = 0;
			this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowDetails.Image = global::Products.Common.Properties.Resources.open_32_metrolime;
			this.btnShowDetails.Location = new System.Drawing.Point(99, 100);
			this.btnShowDetails.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnShowDetails.Name = "btnShowDetails";
			this.btnShowDetails.Size = new System.Drawing.Size(36, 36);
			this.btnShowDetails.TabIndex = 11;
			this.btnShowDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.metroToolTip1.SetToolTip(this.btnShowDetails, "Auftragsdetails anzeigen");
			this.btnShowDetails.UseVisualStyleBackColor = false;
			// 
			// btnNewTask
			// 
			this.btnNewTask.BackColor = System.Drawing.Color.Transparent;
			this.btnNewTask.FlatAppearance.BorderSize = 0;
			this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewTask.Image = global::Products.Common.Properties.Resources.neu_metrolime;
			this.btnNewTask.Location = new System.Drawing.Point(40, 100);
			this.btnNewTask.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
			this.btnNewTask.Name = "btnNewTask";
			this.btnNewTask.Size = new System.Drawing.Size(36, 36);
			this.btnNewTask.TabIndex = 9;
			this.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.metroToolTip1.SetToolTip(this.btnNewTask, "Neue Aufgabe erstellen");
			this.btnNewTask.UseVisualStyleBackColor = false;
			// 
			// ndtpReminderTime
			// 
			this.ndtpReminderTime.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpReminderTime.CustomFormat = "HH.mm";
			this.ndtpReminderTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpReminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.ndtpReminderTime.Location = new System.Drawing.Point(248, 291);
			this.ndtpReminderTime.MinimumSize = new System.Drawing.Size(0, 29);
			this.ndtpReminderTime.Name = "ndtpReminderTime";
			this.ndtpReminderTime.NullValue = "Nix";
			this.ndtpReminderTime.Size = new System.Drawing.Size(57, 29);
			this.ndtpReminderTime.TabIndex = 7;
			this.ndtpReminderTime.Value = new System.DateTime(2016, 2, 3, 9, 26, 36, 35);
			// 
			// ndtpReminderDate
			// 
			this.ndtpReminderDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpReminderDate.Checked = false;
			this.ndtpReminderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpReminderDate.Location = new System.Drawing.Point(112, 291);
			this.ndtpReminderDate.MinimumSize = new System.Drawing.Size(0, 29);
			this.ndtpReminderDate.Name = "ndtpReminderDate";
			this.ndtpReminderDate.NullValue = "Nö";
			this.ndtpReminderDate.ShowCheckBox = true;
			this.ndtpReminderDate.Size = new System.Drawing.Size(96, 29);
			this.ndtpReminderDate.TabIndex = 6;
			this.ndtpReminderDate.Value = new System.DateTime(2016, 2, 3, 9, 26, 36, 35);
			this.ndtpReminderDate.ValueChanged += new System.EventHandler(this.ndtpReminderDate_ValueChanged);
			// 
			// ndtpDueAt
			// 
			this.ndtpDueAt.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpDueAt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpDueAt.Location = new System.Drawing.Point(112, 249);
			this.ndtpDueAt.MinimumSize = new System.Drawing.Size(0, 29);
			this.ndtpDueAt.Name = "ndtpDueAt";
			this.ndtpDueAt.Size = new System.Drawing.Size(96, 29);
			this.ndtpDueAt.TabIndex = 2;
			this.ndtpDueAt.Value = new System.DateTime(2016, 2, 3, 9, 26, 36, 35);
			// 
			// ndtpStartsAt
			// 
			this.ndtpStartsAt.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpStartsAt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpStartsAt.Location = new System.Drawing.Point(112, 207);
			this.ndtpStartsAt.MinimumSize = new System.Drawing.Size(0, 29);
			this.ndtpStartsAt.Name = "ndtpStartsAt";
			this.ndtpStartsAt.Size = new System.Drawing.Size(96, 29);
			this.ndtpStartsAt.TabIndex = 1;
			this.ndtpStartsAt.Value = new System.DateTime(2016, 2, 3, 9, 26, 36, 35);
			// 
			// TaskDetailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 745);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnShowReminder);
			this.Controls.Add(this.ndtpReminderTime);
			this.Controls.Add(this.ndtpReminderDate);
			this.Controls.Add(this.ndtpDueAt);
			this.Controls.Add(this.ndtpStartsAt);
			this.Controls.Add(this.mcmbCompleted);
			this.Controls.Add(this.metroLabel7);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.mcmbPriority);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.mcmbStatus);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnShowDetails);
			this.Controls.Add(this.btnNewTask);
			this.Controls.Add(this.mtxtDescription);
			this.Controls.Add(this.mtxtTaskname);
			this.Controls.Add(this.btnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TaskDetailView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Aufgabe ...";
			this.MouseEnter += new System.EventHandler(this.TaskDetailView_MouseEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

#pragma warning restore CS0618 // Typ oder Element ist veraltet

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnClose;
		private MetroFramework.Controls.MetroTextBox mtxtTaskname;
		private MetroFramework.Controls.MetroTextBox mtxtDescription;
		private System.Windows.Forms.Button btnNewTask;
		private System.Windows.Forms.Button btnShowDetails;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox mcmbStatus;
		private MetroFramework.Controls.MetroComboBox mcmbPriority;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroComboBox mcmbCompleted;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private UI.Controls.NullableDateTimePicker ndtpStartsAt;
		private UI.Controls.NullableDateTimePicker ndtpDueAt;
		private UI.Controls.NullableDateTimePicker ndtpReminderDate;
		private UI.Controls.NullableDateTimePicker ndtpReminderTime;
		private System.Windows.Forms.Button mbtnShowReminder;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
	}
}