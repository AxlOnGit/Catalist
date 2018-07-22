namespace Products.Common.Views
{
	partial class SoftwareUpgradeView
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
		private void InitializeComponent()
		{
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mlblMatchcode = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.mtxtNeueLizenz = new MetroFramework.Controls.MetroTextBox();
			this.mtxtAlteLizenz = new MetroFramework.Controls.MetroTextBox();
			this.mlnkAlteVersion = new MetroFramework.Controls.MetroLink();
			this.mlnkNeueVersion = new MetroFramework.Controls.MetroLink();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.mlblMaschinenmodell = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.mlnkAngefordertVon = new MetroFramework.Controls.MetroLink();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.mlnkKundeInformiertVon = new MetroFramework.Controls.MetroLink();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.ndtpKundeInformiertAm = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpErhaltenAm = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpAngefordertAm = new Products.UI.Controls.NullableDateTimePicker();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(688, 453);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnClose.TabIndex = 50;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mlblMatchcode
			// 
			this.mlblMatchcode.AutoSize = true;
			this.mlblMatchcode.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblMatchcode.Location = new System.Drawing.Point(23, 100);
			this.mlblMatchcode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
			this.mlblMatchcode.Name = "mlblMatchcode";
			this.mlblMatchcode.Size = new System.Drawing.Size(96, 25);
			this.mlblMatchcode.TabIndex = 1;
			this.mlblMatchcode.Text = "Matchcode";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 206);
			this.metroLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(116, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Vorgängerversion:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 242);
			this.metroLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(89, 19);
			this.metroLabel3.TabIndex = 3;
			this.metroLabel3.Text = "Neue Version:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(349, 206);
			this.metroLabel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(127, 19);
			this.metroLabel4.TabIndex = 5;
			this.metroLabel4.Text = "Alter Lizenzschlüssel:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(349, 242);
			this.metroLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(135, 19);
			this.metroLabel5.TabIndex = 7;
			this.metroLabel5.Text = "Neuer Lizenzschlüssel:";
			// 
			// mtxtNeueLizenz
			// 
			this.mtxtNeueLizenz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtNeueLizenz.CustomButton.Image = null;
			this.mtxtNeueLizenz.CustomButton.Location = new System.Drawing.Point(268, 1);
			this.mtxtNeueLizenz.CustomButton.Name = "";
			this.mtxtNeueLizenz.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtNeueLizenz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtNeueLizenz.CustomButton.TabIndex = 1;
			this.mtxtNeueLizenz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtNeueLizenz.CustomButton.UseSelectable = true;
			this.mtxtNeueLizenz.CustomButton.Visible = false;
			this.mtxtNeueLizenz.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtNeueLizenz.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtNeueLizenz.Lines = new string[0];
			this.mtxtNeueLizenz.Location = new System.Drawing.Point(490, 240);
			this.mtxtNeueLizenz.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtNeueLizenz.MaxLength = 32767;
			this.mtxtNeueLizenz.Name = "mtxtNeueLizenz";
			this.mtxtNeueLizenz.PasswordChar = '\0';
			this.mtxtNeueLizenz.PromptText = "Lizenzschlüssel neue Version";
			this.mtxtNeueLizenz.ReadOnly = true;
			this.mtxtNeueLizenz.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtNeueLizenz.SelectedText = "";
			this.mtxtNeueLizenz.SelectionLength = 0;
			this.mtxtNeueLizenz.SelectionStart = 0;
			this.mtxtNeueLizenz.ShortcutsEnabled = true;
			this.mtxtNeueLizenz.Size = new System.Drawing.Size(290, 23);
			this.mtxtNeueLizenz.TabIndex = 20;
			this.mtxtNeueLizenz.UseSelectable = true;
			this.mtxtNeueLizenz.WaterMark = "Lizenzschlüssel neue Version";
			this.mtxtNeueLizenz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtNeueLizenz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtAlteLizenz
			// 
			this.mtxtAlteLizenz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtAlteLizenz.CustomButton.Image = null;
			this.mtxtAlteLizenz.CustomButton.Location = new System.Drawing.Point(268, 1);
			this.mtxtAlteLizenz.CustomButton.Name = "";
			this.mtxtAlteLizenz.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtAlteLizenz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAlteLizenz.CustomButton.TabIndex = 1;
			this.mtxtAlteLizenz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAlteLizenz.CustomButton.UseSelectable = true;
			this.mtxtAlteLizenz.CustomButton.Visible = false;
			this.mtxtAlteLizenz.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAlteLizenz.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtAlteLizenz.Lines = new string[0];
			this.mtxtAlteLizenz.Location = new System.Drawing.Point(490, 204);
			this.mtxtAlteLizenz.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtAlteLizenz.MaxLength = 32767;
			this.mtxtAlteLizenz.Name = "mtxtAlteLizenz";
			this.mtxtAlteLizenz.PasswordChar = '\0';
			this.mtxtAlteLizenz.PromptText = "Lizenschlüssel Vorgängerversion";
			this.mtxtAlteLizenz.ReadOnly = true;
			this.mtxtAlteLizenz.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtAlteLizenz.SelectedText = "";
			this.mtxtAlteLizenz.SelectionLength = 0;
			this.mtxtAlteLizenz.SelectionStart = 0;
			this.mtxtAlteLizenz.ShortcutsEnabled = true;
			this.mtxtAlteLizenz.Size = new System.Drawing.Size(290, 23);
			this.mtxtAlteLizenz.TabIndex = 10;
			this.mtxtAlteLizenz.UseSelectable = true;
			this.mtxtAlteLizenz.WaterMark = "Lizenschlüssel Vorgängerversion";
			this.mtxtAlteLizenz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAlteLizenz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mlnkAlteVersion
			// 
			this.mlnkAlteVersion.Location = new System.Drawing.Point(145, 204);
			this.mlnkAlteVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.mlnkAlteVersion.Name = "mlnkAlteVersion";
			this.mlnkAlteVersion.Size = new System.Drawing.Size(158, 23);
			this.mlnkAlteVersion.TabIndex = 5;
			this.mlnkAlteVersion.Text = "Vorgängerversion";
			this.mlnkAlteVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkAlteVersion.UseSelectable = true;
			// 
			// mlnkNeueVersion
			// 
			this.mlnkNeueVersion.Location = new System.Drawing.Point(145, 240);
			this.mlnkNeueVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.mlnkNeueVersion.Name = "mlnkNeueVersion";
			this.mlnkNeueVersion.Size = new System.Drawing.Size(158, 23);
			this.mlnkNeueVersion.TabIndex = 15;
			this.mlnkNeueVersion.Text = "Klicken zum Auswählen";
			this.mlnkNeueVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkNeueVersion.UseSelectable = true;
			this.mlnkNeueVersion.Click += new System.EventHandler(this.mlnkNeueVersion_Click);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(23, 150);
			this.metroLabel6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(66, 19);
			this.metroLabel6.TabIndex = 21;
			this.metroLabel6.Text = "Maschine:";
			// 
			// mlblMaschinenmodell
			// 
			this.mlblMaschinenmodell.AutoSize = true;
			this.mlblMaschinenmodell.Location = new System.Drawing.Point(145, 150);
			this.mlblMaschinenmodell.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.mlblMaschinenmodell.Name = "mlblMaschinenmodell";
			this.mlblMaschinenmodell.Size = new System.Drawing.Size(161, 19);
			this.mlblMaschinenmodell.TabIndex = 24;
			this.mlblMaschinenmodell.Text = "Maschine [Seriennummer]";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(23, 314);
			this.metroLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(92, 19);
			this.metroLabel7.TabIndex = 25;
			this.metroLabel7.Text = "Beantragt am:";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(23, 350);
			this.metroLabel8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(82, 19);
			this.metroLabel8.TabIndex = 27;
			this.metroLabel8.Text = "Erhalten am:";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(262, 314);
			this.metroLabel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(33, 19);
			this.metroLabel9.TabIndex = 29;
			this.metroLabel9.Text = "von:";
			// 
			// mlnkAngefordertVon
			// 
			this.mlnkAngefordertVon.Location = new System.Drawing.Point(301, 313);
			this.mlnkAngefordertVon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.mlnkAngefordertVon.Name = "mlnkAngefordertVon";
			this.mlnkAngefordertVon.Size = new System.Drawing.Size(142, 23);
			this.mlnkAngefordertVon.TabIndex = 30;
			this.mlnkAngefordertVon.Text = "Klicken zum Auswählen";
			this.mlnkAngefordertVon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkAngefordertVon.UseSelectable = true;
			this.mlnkAngefordertVon.Click += new System.EventHandler(this.mlnkAngefordertVon_Click);
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(23, 386);
			this.metroLabel10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(109, 19);
			this.metroLabel10.TabIndex = 31;
			this.metroLabel10.Text = "Zum Kunden am:";
			// 
			// mlnkKundeInformiertVon
			// 
			this.mlnkKundeInformiertVon.Location = new System.Drawing.Point(301, 385);
			this.mlnkKundeInformiertVon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.mlnkKundeInformiertVon.Name = "mlnkKundeInformiertVon";
			this.mlnkKundeInformiertVon.Size = new System.Drawing.Size(142, 23);
			this.mlnkKundeInformiertVon.TabIndex = 45;
			this.mlnkKundeInformiertVon.Text = "Klicken zum Auswählen";
			this.mlnkKundeInformiertVon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkKundeInformiertVon.UseSelectable = true;
			this.mlnkKundeInformiertVon.Click += new System.EventHandler(this.mlnkKundeInformiertVon_Click);
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(262, 386);
			this.metroLabel11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(33, 19);
			this.metroLabel11.TabIndex = 33;
			this.metroLabel11.Text = "von:";
			// 
			// ndtpKundeInformiertAm
			// 
			this.ndtpKundeInformiertAm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpKundeInformiertAm.Location = new System.Drawing.Point(145, 381);
			this.ndtpKundeInformiertAm.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpKundeInformiertAm.Name = "ndtpKundeInformiertAm";
			this.ndtpKundeInformiertAm.Size = new System.Drawing.Size(111, 29);
			this.ndtpKundeInformiertAm.TabIndex = 40;
			this.ndtpKundeInformiertAm.Value = new System.DateTime(2016, 11, 14, 17, 32, 2, 662);
			this.ndtpKundeInformiertAm.Validating += new System.ComponentModel.CancelEventHandler(this.ndtpKundeInformiertAm_Validating);
			// 
			// ndtpErhaltenAm
			// 
			this.ndtpErhaltenAm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpErhaltenAm.Location = new System.Drawing.Point(145, 345);
			this.ndtpErhaltenAm.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpErhaltenAm.Name = "ndtpErhaltenAm";
			this.ndtpErhaltenAm.Size = new System.Drawing.Size(111, 29);
			this.ndtpErhaltenAm.TabIndex = 35;
			this.ndtpErhaltenAm.Value = new System.DateTime(2016, 11, 14, 17, 32, 2, 662);
			this.ndtpErhaltenAm.Validating += new System.ComponentModel.CancelEventHandler(this.ndtpErhaltenAm_Validating);
			// 
			// ndtpAngefordertAm
			// 
			this.ndtpAngefordertAm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpAngefordertAm.Location = new System.Drawing.Point(145, 309);
			this.ndtpAngefordertAm.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpAngefordertAm.Name = "ndtpAngefordertAm";
			this.ndtpAngefordertAm.Size = new System.Drawing.Size(111, 29);
			this.ndtpAngefordertAm.TabIndex = 25;
			this.ndtpAngefordertAm.Value = new System.DateTime(2016, 11, 14, 17, 32, 2, 662);
			this.ndtpAngefordertAm.Validating += new System.ComponentModel.CancelEventHandler(this.ndtpAngefordertAm_Validating);
			// 
			// SoftwareUpgradeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 502);
			this.ControlBox = false;
			this.Controls.Add(this.mlnkKundeInformiertVon);
			this.Controls.Add(this.metroLabel11);
			this.Controls.Add(this.ndtpKundeInformiertAm);
			this.Controls.Add(this.metroLabel10);
			this.Controls.Add(this.mlnkAngefordertVon);
			this.Controls.Add(this.metroLabel9);
			this.Controls.Add(this.ndtpErhaltenAm);
			this.Controls.Add(this.metroLabel8);
			this.Controls.Add(this.ndtpAngefordertAm);
			this.Controls.Add(this.metroLabel7);
			this.Controls.Add(this.mlblMaschinenmodell);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.mlnkNeueVersion);
			this.Controls.Add(this.mlnkAlteVersion);
			this.Controls.Add(this.mtxtNeueLizenz);
			this.Controls.Add(this.mtxtAlteLizenz);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mlblMatchcode);
			this.Controls.Add(this.mbtnClose);
			this.Name = "SoftwareUpgradeView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Software-Upgrade";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoftwareUpgradeView_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroLabel mlblMatchcode;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox mtxtNeueLizenz;
		private MetroFramework.Controls.MetroTextBox mtxtAlteLizenz;
		private MetroFramework.Controls.MetroLink mlnkAlteVersion;
		private MetroFramework.Controls.MetroLink mlnkNeueVersion;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel mlblMaschinenmodell;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private UI.Controls.NullableDateTimePicker ndtpAngefordertAm;
		private UI.Controls.NullableDateTimePicker ndtpErhaltenAm;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private MetroFramework.Controls.MetroLink mlnkAngefordertVon;
		private UI.Controls.NullableDateTimePicker ndtpKundeInformiertAm;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private MetroFramework.Controls.MetroLink mlnkKundeInformiertVon;
		private MetroFramework.Controls.MetroLabel metroLabel11;
	}
}