namespace Products.Common.Views
{
	partial class EmailView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailView));
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mlblAngebot = new MetroFramework.Controls.MetroLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.mtxtBcc = new MetroFramework.Controls.MetroTextBox();
			this.mlblBcc = new MetroFramework.Controls.MetroLabel();
			this.mtxtBody = new MetroFramework.Controls.MetroTextBox();
			this.mlblFrom = new MetroFramework.Controls.MetroLabel();
			this.mtxtSubject = new MetroFramework.Controls.MetroTextBox();
			this.mtxtCc = new MetroFramework.Controls.MetroTextBox();
			this.mtxtTo = new MetroFramework.Controls.MetroTextBox();
			this.mlblCc = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnSend = new System.Windows.Forms.Button();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnSend = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel1.Location = new System.Drawing.Point(5, 531);
			this.metroLabel1.Margin = new System.Windows.Forms.Padding(5);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(52, 15);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Angebot";
			// 
			// mlblAngebot
			// 
			this.mlblAngebot.AutoSize = true;
			this.mlblAngebot.Location = new System.Drawing.Point(5, 5);
			this.mlblAngebot.Margin = new System.Windows.Forms.Padding(5);
			this.mlblAngebot.Name = "mlblAngebot";
			this.mlblAngebot.Size = new System.Drawing.Size(145, 19);
			this.mlblAngebot.TabIndex = 1;
			this.mlblAngebot.Text = "2016-1-26_14-03-48534";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(23, 100);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.mtxtBcc);
			this.splitContainer1.Panel1.Controls.Add(this.mlblBcc);
			this.splitContainer1.Panel1.Controls.Add(this.mtxtBody);
			this.splitContainer1.Panel1.Controls.Add(this.mlblFrom);
			this.splitContainer1.Panel1.Controls.Add(this.mtxtSubject);
			this.splitContainer1.Panel1.Controls.Add(this.mtxtCc);
			this.splitContainer1.Panel1.Controls.Add(this.mtxtTo);
			this.splitContainer1.Panel1.Controls.Add(this.mlblCc);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.mlblAngebot);
			this.splitContainer1.Size = new System.Drawing.Size(900, 588);
			this.splitContainer1.SplitterDistance = 551;
			this.splitContainer1.TabIndex = 2;
			// 
			// mtxtBcc
			// 
			// 
			// 
			// 
			this.mtxtBcc.CustomButton.Image = null;
			this.mtxtBcc.CustomButton.Location = new System.Drawing.Point(762, 1);
			this.mtxtBcc.CustomButton.Name = "";
			this.mtxtBcc.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtBcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtBcc.CustomButton.TabIndex = 1;
			this.mtxtBcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtBcc.CustomButton.UseSelectable = true;
			this.mtxtBcc.CustomButton.Visible = false;
			this.mtxtBcc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtBcc.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtBcc.Lines = new string[0];
			this.mtxtBcc.Location = new System.Drawing.Point(70, 153);
			this.mtxtBcc.MaxLength = 32767;
			this.mtxtBcc.Name = "mtxtBcc";
			this.mtxtBcc.PasswordChar = '\0';
			this.mtxtBcc.ReadOnly = true;
			this.mtxtBcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtBcc.SelectedText = "";
			this.mtxtBcc.SelectionLength = 0;
			this.mtxtBcc.SelectionStart = 0;
			this.mtxtBcc.Size = new System.Drawing.Size(784, 23);
			this.mtxtBcc.Style = MetroFramework.MetroColorStyle.White;
			this.mtxtBcc.TabIndex = 7;
			this.mtxtBcc.UseSelectable = true;
			this.mtxtBcc.UseStyleColors = true;
			this.mtxtBcc.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtBcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtBcc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtBcc_KeyUp);
			// 
			// mlblBcc
			// 
			this.mlblBcc.AutoSize = true;
			this.mlblBcc.Location = new System.Drawing.Point(25, 157);
			this.mlblBcc.Margin = new System.Windows.Forms.Padding(10);
			this.mlblBcc.Name = "mlblBcc";
			this.mlblBcc.Size = new System.Drawing.Size(32, 19);
			this.mlblBcc.Style = MetroFramework.MetroColorStyle.Red;
			this.mlblBcc.TabIndex = 8;
			this.mlblBcc.Text = "Bcc:";
			this.mlblBcc.UseStyleColors = true;
			this.mlblBcc.Click += new System.EventHandler(this.mlblBcc_Click);
			// 
			// mtxtBody
			// 
			this.mtxtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtBody.CustomButton.Image = null;
			this.mtxtBody.CustomButton.Location = new System.Drawing.Point(592, 2);
			this.mtxtBody.CustomButton.Name = "";
			this.mtxtBody.CustomButton.Size = new System.Drawing.Size(235, 235);
			this.mtxtBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtBody.CustomButton.TabIndex = 1;
			this.mtxtBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtBody.CustomButton.UseSelectable = true;
			this.mtxtBody.CustomButton.Visible = false;
			this.mtxtBody.Lines = new string[0];
			this.mtxtBody.Location = new System.Drawing.Point(25, 283);
			this.mtxtBody.MaxLength = 32767;
			this.mtxtBody.Multiline = true;
			this.mtxtBody.Name = "mtxtBody";
			this.mtxtBody.PasswordChar = '\0';
			this.mtxtBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtBody.SelectedText = "";
			this.mtxtBody.SelectionLength = 0;
			this.mtxtBody.SelectionStart = 0;
			this.mtxtBody.Size = new System.Drawing.Size(830, 240);
			this.mtxtBody.Style = MetroFramework.MetroColorStyle.White;
			this.mtxtBody.TabIndex = 6;
			this.mtxtBody.UseSelectable = true;
			this.mtxtBody.UseStyleColors = true;
			this.mtxtBody.WaterMark = "Nachrichtentext";
			this.mtxtBody.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// mlblFrom
			// 
			this.mlblFrom.AutoSize = true;
			this.mlblFrom.Location = new System.Drawing.Point(72, 17);
			this.mlblFrom.Margin = new System.Windows.Forms.Padding(10);
			this.mlblFrom.Name = "mlblFrom";
			this.mlblFrom.Size = new System.Drawing.Size(34, 19);
			this.mlblFrom.TabIndex = 5;
			this.mlblFrom.Text = "Von:";
			// 
			// mtxtSubject
			// 
			// 
			// 
			// 
			this.mtxtSubject.CustomButton.Image = null;
			this.mtxtSubject.CustomButton.Location = new System.Drawing.Point(807, 1);
			this.mtxtSubject.CustomButton.Name = "";
			this.mtxtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSubject.CustomButton.TabIndex = 1;
			this.mtxtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSubject.CustomButton.UseSelectable = true;
			this.mtxtSubject.CustomButton.Visible = false;
			this.mtxtSubject.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSubject.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtSubject.Lines = new string[0];
			this.mtxtSubject.Location = new System.Drawing.Point(25, 206);
			this.mtxtSubject.MaxLength = 32767;
			this.mtxtSubject.Name = "mtxtSubject";
			this.mtxtSubject.PasswordChar = '\0';
			this.mtxtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSubject.SelectedText = "";
			this.mtxtSubject.SelectionLength = 0;
			this.mtxtSubject.SelectionStart = 0;
			this.mtxtSubject.Size = new System.Drawing.Size(829, 23);
			this.mtxtSubject.Style = MetroFramework.MetroColorStyle.White;
			this.mtxtSubject.TabIndex = 3;
			this.mtxtSubject.UseSelectable = true;
			this.mtxtSubject.UseStyleColors = true;
			this.mtxtSubject.WaterMark = "Betreff";
			this.mtxtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// mtxtCc
			// 
			// 
			// 
			// 
			this.mtxtCc.CustomButton.Image = null;
			this.mtxtCc.CustomButton.Location = new System.Drawing.Point(762, 1);
			this.mtxtCc.CustomButton.Name = "";
			this.mtxtCc.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtCc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtCc.CustomButton.TabIndex = 1;
			this.mtxtCc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtCc.CustomButton.UseSelectable = true;
			this.mtxtCc.CustomButton.Visible = false;
			this.mtxtCc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtCc.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtCc.Lines = new string[0];
			this.mtxtCc.Location = new System.Drawing.Point(70, 106);
			this.mtxtCc.MaxLength = 32767;
			this.mtxtCc.Name = "mtxtCc";
			this.mtxtCc.PasswordChar = '\0';
			this.mtxtCc.ReadOnly = true;
			this.mtxtCc.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtCc.SelectedText = "";
			this.mtxtCc.SelectionLength = 0;
			this.mtxtCc.SelectionStart = 0;
			this.mtxtCc.Size = new System.Drawing.Size(784, 23);
			this.mtxtCc.Style = MetroFramework.MetroColorStyle.White;
			this.mtxtCc.TabIndex = 2;
			this.mtxtCc.UseSelectable = true;
			this.mtxtCc.UseStyleColors = true;
			this.mtxtCc.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtCc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtCc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCc_KeyUp);
			// 
			// mtxtTo
			// 
			// 
			// 
			// 
			this.mtxtTo.CustomButton.Image = null;
			this.mtxtTo.CustomButton.Location = new System.Drawing.Point(762, 1);
			this.mtxtTo.CustomButton.Name = "";
			this.mtxtTo.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtTo.CustomButton.TabIndex = 1;
			this.mtxtTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtTo.CustomButton.UseSelectable = true;
			this.mtxtTo.CustomButton.Visible = false;
			this.mtxtTo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtTo.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtTo.Lines = new string[0];
			this.mtxtTo.Location = new System.Drawing.Point(70, 59);
			this.mtxtTo.MaxLength = 32767;
			this.mtxtTo.Name = "mtxtTo";
			this.mtxtTo.PasswordChar = '\0';
			this.mtxtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtTo.SelectedText = "";
			this.mtxtTo.SelectionLength = 0;
			this.mtxtTo.SelectionStart = 0;
			this.mtxtTo.Size = new System.Drawing.Size(784, 23);
			this.mtxtTo.Style = MetroFramework.MetroColorStyle.White;
			this.mtxtTo.TabIndex = 1;
			this.mtxtTo.UseSelectable = true;
			this.mtxtTo.UseStyleColors = true;
			this.mtxtTo.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mlblCc
			// 
			this.mlblCc.AutoSize = true;
			this.mlblCc.Location = new System.Drawing.Point(25, 110);
			this.mlblCc.Margin = new System.Windows.Forms.Padding(10);
			this.mlblCc.Name = "mlblCc";
			this.mlblCc.Size = new System.Drawing.Size(27, 19);
			this.mlblCc.Style = MetroFramework.MetroColorStyle.Red;
			this.mlblCc.TabIndex = 3;
			this.mlblCc.Text = "Cc:";
			this.mlblCc.UseStyleColors = true;
			this.mlblCc.Click += new System.EventHandler(this.mlblCc_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(25, 63);
			this.metroLabel4.Margin = new System.Windows.Forms.Padding(10);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(28, 19);
			this.metroLabel4.TabIndex = 2;
			this.metroLabel4.Text = "An:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(25, 17);
			this.metroLabel3.Margin = new System.Windows.Forms.Padding(10);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(34, 19);
			this.metroLabel3.TabIndex = 1;
			this.metroLabel3.Text = "Von:";
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.Transparent;
			this.btnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSend.FlatAppearance.BorderSize = 0;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.Image = global::Products.Common.Properties.Resources.sendmail_32_metrored;
			this.btnSend.Location = new System.Drawing.Point(873, 61);
			this.btnSend.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(36, 36);
			this.btnSend.TabIndex = 6;
			this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.metroToolTip1.SetToolTip(this.btnSend, "Senden");
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Red;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(816, 715);
			this.mbtnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 62;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// mbtnSend
			// 
			this.mbtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnSend.Image = null;
			this.mbtnSend.Location = new System.Drawing.Point(645, 715);
			this.mbtnSend.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnSend.Name = "mbtnSend";
			this.mbtnSend.Size = new System.Drawing.Size(158, 26);
			this.mbtnSend.TabIndex = 63;
			this.mbtnSend.Text = "Senden und schließen";
			this.mbtnSend.UseSelectable = true;
			this.mbtnSend.UseVisualStyleBackColor = true;
			this.mbtnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// EmailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(946, 764);
			this.Controls.Add(this.mbtnSend);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmailView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "E-Mail: Angebot für Firma";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel mlblAngebot;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroLabel mlblCc;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox mtxtSubject;
		private MetroFramework.Controls.MetroTextBox mtxtCc;
		private MetroFramework.Controls.MetroTextBox mtxtTo;
		private MetroFramework.Controls.MetroLabel mlblFrom;
		private MetroFramework.Controls.MetroTextBox mtxtBody;
		private System.Windows.Forms.Button btnSend;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private MetroFramework.Controls.MetroTextBox mtxtBcc;
		private MetroFramework.Controls.MetroLabel mlblBcc;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnSend;
	}
}