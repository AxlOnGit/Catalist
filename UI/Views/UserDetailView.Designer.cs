namespace Products.Common.Views
{
	partial class UserDetailView
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
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.mlblColorText = new MetroFramework.Controls.MetroLabel();
			this.lblAppointmentColor = new System.Windows.Forms.Label();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mtxtUserName = new MetroFramework.Controls.MetroTextBox();
			this.mtxtSignature = new MetroFramework.Controls.MetroTextBox();
			this.mtxtOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.SuspendLayout();
			// 
			// mlblColorText
			// 
			this.mlblColorText.AutoSize = true;
			this.mlblColorText.Location = new System.Drawing.Point(23, 135);
			this.mlblColorText.Name = "mlblColorText";
			this.mlblColorText.Size = new System.Drawing.Size(94, 19);
			this.mlblColorText.TabIndex = 0;
			this.mlblColorText.Text = "Kalenderfarbe:";
			// 
			// lblAppointmentColor
			// 
			this.lblAppointmentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
			this.lblAppointmentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAppointmentColor.Location = new System.Drawing.Point(125, 135);
			this.lblAppointmentColor.Name = "lblAppointmentColor";
			this.lblAppointmentColor.Size = new System.Drawing.Size(152, 23);
			this.lblAppointmentColor.TabIndex = 1;
			this.lblAppointmentColor.Click += new System.EventHandler(this.lblAppointmentColor_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 100);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(96, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Benutzername:";
			// 
			// mtxtUserName
			// 
			// 
			// 
			// 
			this.mtxtUserName.CustomButton.Image = null;
			this.mtxtUserName.CustomButton.Location = new System.Drawing.Point(130, 1);
			this.mtxtUserName.CustomButton.Name = "";
			this.mtxtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtUserName.CustomButton.TabIndex = 1;
			this.mtxtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtUserName.CustomButton.UseSelectable = true;
			this.mtxtUserName.CustomButton.Visible = false;
			this.mtxtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtUserName.Lines = new string[0];
			this.mtxtUserName.Location = new System.Drawing.Point(125, 100);
			this.mtxtUserName.MaxLength = 32767;
			this.mtxtUserName.Name = "mtxtUserName";
			this.mtxtUserName.PasswordChar = '\0';
			this.mtxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtUserName.SelectedText = "";
			this.mtxtUserName.SelectionLength = 0;
			this.mtxtUserName.SelectionStart = 0;
			this.mtxtUserName.ShortcutsEnabled = true;
			this.mtxtUserName.Size = new System.Drawing.Size(152, 23);
			this.mtxtUserName.TabIndex = 0;
			this.mtxtUserName.UseSelectable = true;
			this.mtxtUserName.WaterMark = "Benutzername";
			this.mtxtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtSignature
			// 
			this.mtxtSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtSignature.CustomButton.Image = null;
			this.mtxtSignature.CustomButton.Location = new System.Drawing.Point(-67, 1);
			this.mtxtSignature.CustomButton.Name = "";
			this.mtxtSignature.CustomButton.Size = new System.Drawing.Size(405, 405);
			this.mtxtSignature.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSignature.CustomButton.TabIndex = 1;
			this.mtxtSignature.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSignature.CustomButton.UseSelectable = true;
			this.mtxtSignature.CustomButton.Visible = false;
			this.mtxtSignature.Lines = new string[0];
			this.mtxtSignature.Location = new System.Drawing.Point(125, 180);
			this.mtxtSignature.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.mtxtSignature.MaxLength = 32767;
			this.mtxtSignature.Multiline = true;
			this.mtxtSignature.Name = "mtxtSignature";
			this.mtxtSignature.PasswordChar = '\0';
			this.mtxtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mtxtSignature.SelectedText = "";
			this.mtxtSignature.SelectionLength = 0;
			this.mtxtSignature.SelectionStart = 0;
			this.mtxtSignature.ShortcutsEnabled = true;
			this.mtxtSignature.Size = new System.Drawing.Size(339, 407);
			this.mtxtSignature.TabIndex = 2;
			this.mtxtSignature.UseSelectable = true;
			this.mtxtSignature.WaterMark = "E-Mail Signatur";
			this.mtxtSignature.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSignature.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtOk
			// 
			this.mtxtOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mtxtOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mtxtOk.Image = null;
			this.mtxtOk.Location = new System.Drawing.Point(251, 610);
			this.mtxtOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mtxtOk.Name = "mtxtOk";
			this.mtxtOk.Size = new System.Drawing.Size(100, 26);
			this.mtxtOk.TabIndex = 5;
			this.mtxtOk.Text = "OK";
			this.mtxtOk.UseSelectable = true;
			this.mtxtOk.UseVisualStyleBackColor = true;
			this.mtxtOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// metroTextButton1
			// 
			this.metroTextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTextButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.metroTextButton1.Image = null;
			this.metroTextButton1.Location = new System.Drawing.Point(364, 610);
			this.metroTextButton1.Name = "metroTextButton1";
			this.metroTextButton1.Size = new System.Drawing.Size(100, 26);
			this.metroTextButton1.TabIndex = 6;
			this.metroTextButton1.Text = "Abbrechen";
			this.metroTextButton1.UseSelectable = true;
			this.metroTextButton1.UseVisualStyleBackColor = true;
			this.metroTextButton1.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// UserDetailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 659);
			this.Controls.Add(this.metroTextButton1);
			this.Controls.Add(this.mtxtOk);
			this.Controls.Add(this.mtxtSignature);
			this.Controls.Add(this.mtxtUserName);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblAppointmentColor);
			this.Controls.Add(this.mlblColorText);
			this.Name = "UserDetailView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "Mitarbeitername";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDlg;
		private MetroFramework.Controls.MetroLabel mlblColorText;
		private System.Windows.Forms.Label lblAppointmentColor;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox mtxtUserName;
		private MetroFramework.Controls.MetroTextBox mtxtSignature;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mtxtOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
	}
}