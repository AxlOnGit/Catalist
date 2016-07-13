namespace Products.Common.Views
{
	partial class CalendarSettingsView
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
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mtxtForUser = new MetroFramework.Controls.MetroTextBox();
			this.mchkCustomerInfo = new MetroFramework.Controls.MetroCheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mchkSetCustomerAddress = new MetroFramework.Controls.MetroCheckBox();
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.mbtnSetForUser = new MetroFramework.Controls.MetroButton();
			this.mchkCreateServiceReport = new MetroFramework.Controls.MetroCheckBox();
			this.mbtnChooseCalendarColor = new MetroFramework.Controls.MetroButton();
			this.mchkSetAddCustomerNotes = new MetroFramework.Controls.MetroCheckBox();
			this.mlblAppointmentColor = new MetroFramework.Controls.MetroLabel();
			this.mchkSetAddCustomerPriceList = new MetroFramework.Controls.MetroCheckBox();
			this.SuspendLayout();
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(81, 448);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 6;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			// 
			// metroTextButton1
			// 
			this.metroTextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTextButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.metroTextButton1.Image = null;
			this.metroTextButton1.Location = new System.Drawing.Point(194, 448);
			this.metroTextButton1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.metroTextButton1.Name = "metroTextButton1";
			this.metroTextButton1.Size = new System.Drawing.Size(100, 26);
			this.metroTextButton1.TabIndex = 7;
			this.metroTextButton1.Text = "Abbrechen";
			this.metroTextButton1.UseSelectable = true;
			this.metroTextButton1.UseVisualStyleBackColor = true;
			// 
			// mtxtForUser
			// 
			// 
			// 
			// 
			this.mtxtForUser.CustomButton.Image = null;
			this.mtxtForUser.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.mtxtForUser.CustomButton.Name = "";
			this.mtxtForUser.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtForUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtForUser.CustomButton.TabIndex = 1;
			this.mtxtForUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtForUser.CustomButton.UseSelectable = true;
			this.mtxtForUser.CustomButton.Visible = false;
			this.mtxtForUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtForUser.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtForUser.Lines = new string[0];
			this.mtxtForUser.Location = new System.Drawing.Point(23, 118);
			this.mtxtForUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtForUser.MaxLength = 32767;
			this.mtxtForUser.Name = "mtxtForUser";
			this.mtxtForUser.PasswordChar = '\0';
			this.mtxtForUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtForUser.SelectedText = "";
			this.mtxtForUser.SelectionLength = 0;
			this.mtxtForUser.SelectionStart = 0;
			this.mtxtForUser.Size = new System.Drawing.Size(252, 23);
			this.mtxtForUser.TabIndex = 0;
			this.mtxtForUser.UseSelectable = true;
			this.mtxtForUser.WaterMark = "Mitarbeiter, für den Termine erstellt werden";
			this.mtxtForUser.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtForUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mchkCustomerInfo
			// 
			this.mchkCustomerInfo.AutoSize = true;
			this.mchkCustomerInfo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkCustomerInfo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkCustomerInfo.Location = new System.Drawing.Point(23, 175);
			this.mchkCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mchkCustomerInfo.Name = "mchkCustomerInfo";
			this.mchkCustomerInfo.Size = new System.Drawing.Size(223, 19);
			this.mchkCustomerInfo.TabIndex = 3;
			this.mchkCustomerInfo.Text = "Kundeninfos automatisch einfügen";
			this.mchkCustomerInfo.UseSelectable = true;
			// 
			// mchkSetCustomerAddress
			// 
			this.mchkSetCustomerAddress.AutoSize = true;
			this.mchkSetCustomerAddress.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkSetCustomerAddress.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkSetCustomerAddress.Location = new System.Drawing.Point(23, 239);
			this.mchkSetCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mchkSetCustomerAddress.Name = "mchkSetCustomerAddress";
			this.mchkSetCustomerAddress.Size = new System.Drawing.Size(246, 19);
			this.mchkSetCustomerAddress.TabIndex = 4;
			this.mchkSetCustomerAddress.Text = "Kundenadresse als Terminort einfügen";
			this.mchkSetCustomerAddress.UseSelectable = true;
			// 
			// mbtnSetForUser
			// 
			this.mbtnSetForUser.BackgroundImage = global::Products.Common.Properties.Resources.open_16_metrogray;
			this.mbtnSetForUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnSetForUser.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnSetForUser.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnSetForUser.Location = new System.Drawing.Point(281, 118);
			this.mbtnSetForUser.Name = "mbtnSetForUser";
			this.mbtnSetForUser.Size = new System.Drawing.Size(23, 23);
			this.mbtnSetForUser.Style = MetroFramework.MetroColorStyle.Silver;
			this.mbtnSetForUser.TabIndex = 1;
			this.mbtnSetForUser.UseCustomBackColor = true;
			this.mbtnSetForUser.UseSelectable = true;
			this.mbtnSetForUser.UseStyleColors = true;
			this.mbtnSetForUser.Click += new System.EventHandler(this.mbtnSetForUser_Click);
			// 
			// mchkCreateServiceReport
			// 
			this.mchkCreateServiceReport.AutoSize = true;
			this.mchkCreateServiceReport.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkCreateServiceReport.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkCreateServiceReport.Location = new System.Drawing.Point(23, 303);
			this.mchkCreateServiceReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mchkCreateServiceReport.Name = "mchkCreateServiceReport";
			this.mchkCreateServiceReport.Size = new System.Drawing.Size(233, 19);
			this.mchkCreateServiceReport.TabIndex = 5;
			this.mchkCreateServiceReport.Text = "Servicebericht automatisch erstellen";
			this.mchkCreateServiceReport.UseSelectable = true;
			// 
			// mbtnChooseCalendarColor
			// 
			this.mbtnChooseCalendarColor.BackgroundImage = global::Products.Common.Properties.Resources.open_16_metrogray;
			this.mbtnChooseCalendarColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnChooseCalendarColor.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnChooseCalendarColor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnChooseCalendarColor.Location = new System.Drawing.Point(281, 356);
			this.mbtnChooseCalendarColor.Name = "mbtnChooseCalendarColor";
			this.mbtnChooseCalendarColor.Size = new System.Drawing.Size(23, 23);
			this.mbtnChooseCalendarColor.Style = MetroFramework.MetroColorStyle.Silver;
			this.mbtnChooseCalendarColor.TabIndex = 8;
			this.mbtnChooseCalendarColor.UseCustomBackColor = true;
			this.mbtnChooseCalendarColor.UseSelectable = true;
			this.mbtnChooseCalendarColor.UseStyleColors = true;
			this.mbtnChooseCalendarColor.Click += new System.EventHandler(this.mlblAppointmentColor_Click);
			// 
			// mchkSetAddCustomerNotes
			// 
			this.mchkSetAddCustomerNotes.AutoSize = true;
			this.mchkSetAddCustomerNotes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkSetAddCustomerNotes.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkSetAddCustomerNotes.Location = new System.Drawing.Point(23, 207);
			this.mchkSetAddCustomerNotes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mchkSetAddCustomerNotes.Name = "mchkSetAddCustomerNotes";
			this.mchkSetAddCustomerNotes.Size = new System.Drawing.Size(238, 19);
			this.mchkSetAddCustomerNotes.TabIndex = 9;
			this.mchkSetAddCustomerNotes.Text = "Kundennotizen automatisch einfügen";
			this.mchkSetAddCustomerNotes.UseSelectable = true;
			// 
			// mlblAppointmentColor
			// 
			this.mlblAppointmentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.mlblAppointmentColor.Location = new System.Drawing.Point(23, 356);
			this.mlblAppointmentColor.Name = "mlblAppointmentColor";
			this.mlblAppointmentColor.Size = new System.Drawing.Size(252, 23);
			this.mlblAppointmentColor.TabIndex = 10;
			this.mlblAppointmentColor.Text = "Kalenderfarbe";
			this.mlblAppointmentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mlblAppointmentColor.UseCustomBackColor = true;
			this.mlblAppointmentColor.UseCustomForeColor = true;
			this.mlblAppointmentColor.Click += new System.EventHandler(this.mlblAppointmentColor_Click);
			// 
			// mchkSetAddCustomerPriceList
			// 
			this.mchkSetAddCustomerPriceList.AutoSize = true;
			this.mchkSetAddCustomerPriceList.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkSetAddCustomerPriceList.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkSetAddCustomerPriceList.Location = new System.Drawing.Point(23, 271);
			this.mchkSetAddCustomerPriceList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mchkSetAddCustomerPriceList.Name = "mchkSetAddCustomerPriceList";
			this.mchkSetAddCustomerPriceList.Size = new System.Drawing.Size(205, 19);
			this.mchkSetAddCustomerPriceList.TabIndex = 11;
			this.mchkSetAddCustomerPriceList.Text = "Kunden-Sonderpreise einfügen";
			this.mchkSetAddCustomerPriceList.UseSelectable = true;
			// 
			// CalendarSettingsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 497);
			this.Controls.Add(this.mchkSetAddCustomerPriceList);
			this.Controls.Add(this.mlblAppointmentColor);
			this.Controls.Add(this.mchkSetAddCustomerNotes);
			this.Controls.Add(this.mbtnChooseCalendarColor);
			this.Controls.Add(this.mchkCreateServiceReport);
			this.Controls.Add(this.mchkSetCustomerAddress);
			this.Controls.Add(this.mchkCustomerInfo);
			this.Controls.Add(this.mtxtForUser);
			this.Controls.Add(this.mbtnSetForUser);
			this.Controls.Add(this.metroTextButton1);
			this.Controls.Add(this.mbtnOk);
			this.Name = "CalendarSettingsView";
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "Kalendereinstellungen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
		private MetroFramework.Controls.MetroButton mbtnSetForUser;
		private MetroFramework.Controls.MetroTextBox mtxtForUser;
		private MetroFramework.Controls.MetroCheckBox mchkCustomerInfo;
		private System.Windows.Forms.ToolTip toolTip1;
		private MetroFramework.Controls.MetroCheckBox mchkSetCustomerAddress;
		private System.Windows.Forms.ColorDialog colorDlg;
		private MetroFramework.Controls.MetroCheckBox mchkCreateServiceReport;
		private MetroFramework.Controls.MetroButton mbtnChooseCalendarColor;
		private MetroFramework.Controls.MetroCheckBox mchkSetAddCustomerNotes;
		private MetroFramework.Controls.MetroLabel mlblAppointmentColor;
		private MetroFramework.Controls.MetroCheckBox mchkSetAddCustomerPriceList;
	}
}