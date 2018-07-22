namespace Products.Common.Views
{
	partial class SoftwareView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareView));
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.mcmbSoftware = new MetroFramework.Controls.MetroComboBox();
			this.mtxtLizenzschluessel = new MetroFramework.Controls.MetroTextBox();
			this.mcmbKundenmaschine = new MetroFramework.Controls.MetroComboBox();
			this.mtxtHauptbenutzer = new MetroFramework.Controls.MetroTextBox();
			this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
			this.dtpInstallationsdatum = new Products.UI.Controls.NullableDateTimePicker();
			this.mtxtComputer = new MetroFramework.Controls.MetroTextBox();
			this.mStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.mtxtAnmerkungen = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.mStyleManager)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnClose.Location = new System.Drawing.Point(467, 454);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(93, 30);
			this.btnClose.Style = MetroFramework.MetroColorStyle.Orange;
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 125);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(150, 19);
			this.metroLabel1.TabIndex = 21;
			this.metroLabel1.Text = "Programmbezeichnung:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 154);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(101, 19);
			this.metroLabel2.TabIndex = 22;
			this.metroLabel2.Text = "Lizenz (Key/SN):";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 185);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(87, 19);
			this.metroLabel3.TabIndex = 23;
			this.metroLabel3.Text = "Installiert am:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 218);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(87, 19);
			this.metroLabel4.TabIndex = 24;
			this.metroLabel4.Text = "SN Maschine:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(23, 247);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(105, 19);
			this.metroLabel5.TabIndex = 25;
			this.metroLabel5.Text = "Computername:";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(23, 276);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(95, 19);
			this.metroLabel6.TabIndex = 26;
			this.metroLabel6.Text = "Hauptbenutzer";
			// 
			// mcmbSoftware
			// 
			this.mcmbSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmbSoftware.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.mcmbSoftware.FormattingEnabled = true;
			this.mcmbSoftware.ItemHeight = 19;
			this.mcmbSoftware.Location = new System.Drawing.Point(179, 119);
			this.mcmbSoftware.Name = "mcmbSoftware";
			this.mcmbSoftware.Size = new System.Drawing.Size(381, 25);
			this.mcmbSoftware.TabIndex = 0;
			this.mcmbSoftware.UseSelectable = true;
			// 
			// mtxtLizenzschluessel
			// 
			this.mtxtLizenzschluessel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtLizenzschluessel.CustomButton.Image = null;
			this.mtxtLizenzschluessel.CustomButton.Location = new System.Drawing.Point(359, 1);
			this.mtxtLizenzschluessel.CustomButton.Name = "";
			this.mtxtLizenzschluessel.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtLizenzschluessel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtLizenzschluessel.CustomButton.TabIndex = 1;
			this.mtxtLizenzschluessel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtLizenzschluessel.CustomButton.UseSelectable = true;
			this.mtxtLizenzschluessel.CustomButton.Visible = false;
			this.mtxtLizenzschluessel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtLizenzschluessel.Lines = new string[0];
			this.mtxtLizenzschluessel.Location = new System.Drawing.Point(179, 150);
			this.mtxtLizenzschluessel.MaxLength = 32767;
			this.mtxtLizenzschluessel.Name = "mtxtLizenzschluessel";
			this.mtxtLizenzschluessel.PasswordChar = '\0';
			this.mtxtLizenzschluessel.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtLizenzschluessel.SelectedText = "";
			this.mtxtLizenzschluessel.SelectionLength = 0;
			this.mtxtLizenzschluessel.SelectionStart = 0;
			this.mtxtLizenzschluessel.ShortcutsEnabled = true;
			this.mtxtLizenzschluessel.Size = new System.Drawing.Size(381, 23);
			this.mtxtLizenzschluessel.TabIndex = 1;
			this.mtxtLizenzschluessel.UseSelectable = true;
			this.mtxtLizenzschluessel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtLizenzschluessel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mcmbKundenmaschine
			// 
			this.mcmbKundenmaschine.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.mcmbKundenmaschine.FormattingEnabled = true;
			this.mcmbKundenmaschine.ItemHeight = 19;
			this.mcmbKundenmaschine.Location = new System.Drawing.Point(179, 212);
			this.mcmbKundenmaschine.Name = "mcmbKundenmaschine";
			this.mcmbKundenmaschine.Size = new System.Drawing.Size(222, 25);
			this.mcmbKundenmaschine.TabIndex = 3;
			this.mcmbKundenmaschine.UseSelectable = true;
			// 
			// mtxtHauptbenutzer
			// 
			// 
			// 
			// 
			this.mtxtHauptbenutzer.CustomButton.Image = null;
			this.mtxtHauptbenutzer.CustomButton.Location = new System.Drawing.Point(200, 1);
			this.mtxtHauptbenutzer.CustomButton.Name = "";
			this.mtxtHauptbenutzer.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtHauptbenutzer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtHauptbenutzer.CustomButton.TabIndex = 1;
			this.mtxtHauptbenutzer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtHauptbenutzer.CustomButton.UseSelectable = true;
			this.mtxtHauptbenutzer.CustomButton.Visible = false;
			this.mtxtHauptbenutzer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtHauptbenutzer.Lines = new string[0];
			this.mtxtHauptbenutzer.Location = new System.Drawing.Point(179, 272);
			this.mtxtHauptbenutzer.MaxLength = 32767;
			this.mtxtHauptbenutzer.Name = "mtxtHauptbenutzer";
			this.mtxtHauptbenutzer.PasswordChar = '\0';
			this.mtxtHauptbenutzer.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtHauptbenutzer.SelectedText = "";
			this.mtxtHauptbenutzer.SelectionLength = 0;
			this.mtxtHauptbenutzer.SelectionStart = 0;
			this.mtxtHauptbenutzer.ShortcutsEnabled = true;
			this.mtxtHauptbenutzer.Size = new System.Drawing.Size(222, 23);
			this.mtxtHauptbenutzer.TabIndex = 5;
			this.mtxtHauptbenutzer.UseSelectable = true;
			this.mtxtHauptbenutzer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtHauptbenutzer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroStyleExtender1
			// 
			this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// dtpInstallationsdatum
			// 
			this.dtpInstallationsdatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dtpInstallationsdatum.CalendarForeColor = System.Drawing.Color.Gray;
			this.dtpInstallationsdatum.Checked = false;
			this.dtpInstallationsdatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInstallationsdatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.dtpInstallationsdatum.Location = new System.Drawing.Point(179, 179);
			this.dtpInstallationsdatum.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtpInstallationsdatum.Name = "dtpInstallationsdatum";
			this.dtpInstallationsdatum.Size = new System.Drawing.Size(113, 29);
			this.dtpInstallationsdatum.TabIndex = 2;
			this.dtpInstallationsdatum.Value = new System.DateTime(2015, 7, 24, 17, 42, 31, 803);
			this.dtpInstallationsdatum.ValueChanged += new System.EventHandler(this.dtpInstallationsdatum_ValueChanged);
			// 
			// mtxtComputer
			// 
			// 
			// 
			// 
			this.mtxtComputer.CustomButton.Image = null;
			this.mtxtComputer.CustomButton.Location = new System.Drawing.Point(200, 1);
			this.mtxtComputer.CustomButton.Name = "";
			this.mtxtComputer.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtComputer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtComputer.CustomButton.TabIndex = 1;
			this.mtxtComputer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtComputer.CustomButton.UseSelectable = true;
			this.mtxtComputer.CustomButton.Visible = false;
			this.mtxtComputer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtComputer.Lines = new string[0];
			this.mtxtComputer.Location = new System.Drawing.Point(179, 243);
			this.mtxtComputer.MaxLength = 32767;
			this.mtxtComputer.Name = "mtxtComputer";
			this.mtxtComputer.PasswordChar = '\0';
			this.mtxtComputer.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtComputer.SelectedText = "";
			this.mtxtComputer.SelectionLength = 0;
			this.mtxtComputer.SelectionStart = 0;
			this.mtxtComputer.ShortcutsEnabled = true;
			this.mtxtComputer.Size = new System.Drawing.Size(222, 23);
			this.mtxtComputer.TabIndex = 4;
			this.mtxtComputer.UseSelectable = true;
			this.mtxtComputer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtComputer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mStyleManager
			// 
			this.mStyleManager.Owner = null;
			this.mStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(24, 301);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(94, 19);
			this.metroLabel7.TabIndex = 32;
			this.metroLabel7.Text = "Anmerkungen:";
			// 
			// mtxtAnmerkungen
			// 
			// 
			// 
			// 
			this.mtxtAnmerkungen.CustomButton.Image = null;
			this.mtxtAnmerkungen.CustomButton.Location = new System.Drawing.Point(269, 2);
			this.mtxtAnmerkungen.CustomButton.Name = "";
			this.mtxtAnmerkungen.CustomButton.Size = new System.Drawing.Size(109, 109);
			this.mtxtAnmerkungen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAnmerkungen.CustomButton.TabIndex = 1;
			this.mtxtAnmerkungen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAnmerkungen.CustomButton.UseSelectable = true;
			this.mtxtAnmerkungen.CustomButton.Visible = false;
			this.mtxtAnmerkungen.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAnmerkungen.Lines = new string[0];
			this.mtxtAnmerkungen.Location = new System.Drawing.Point(179, 301);
			this.mtxtAnmerkungen.MaxLength = 32767;
			this.mtxtAnmerkungen.Multiline = true;
			this.mtxtAnmerkungen.Name = "mtxtAnmerkungen";
			this.mtxtAnmerkungen.PasswordChar = '\0';
			this.mtxtAnmerkungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mtxtAnmerkungen.SelectedText = "";
			this.mtxtAnmerkungen.SelectionLength = 0;
			this.mtxtAnmerkungen.SelectionStart = 0;
			this.mtxtAnmerkungen.ShortcutsEnabled = true;
			this.mtxtAnmerkungen.Size = new System.Drawing.Size(381, 114);
			this.mtxtAnmerkungen.TabIndex = 6;
			this.mtxtAnmerkungen.UseSelectable = true;
			this.mtxtAnmerkungen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAnmerkungen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// SoftwareView
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 507);
			this.Controls.Add(this.mtxtAnmerkungen);
			this.Controls.Add(this.metroLabel7);
			this.Controls.Add(this.mtxtHauptbenutzer);
			this.Controls.Add(this.mtxtComputer);
			this.Controls.Add(this.mcmbKundenmaschine);
			this.Controls.Add(this.mtxtLizenzschluessel);
			this.Controls.Add(this.mcmbSoftware);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dtpInstallationsdatum);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SoftwareView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Kundensoftware";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoftwareView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.mStyleManager)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UI.Controls.NullableDateTimePicker dtpInstallationsdatum;
		private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
		private MetroFramework.Controls.MetroButton btnClose;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroComboBox mcmbSoftware;
		private MetroFramework.Controls.MetroTextBox mtxtLizenzschluessel;
		private MetroFramework.Controls.MetroComboBox mcmbKundenmaschine;
		private MetroFramework.Controls.MetroTextBox mtxtHauptbenutzer;
		private MetroFramework.Controls.MetroTextBox mtxtComputer;
		private MetroFramework.Components.MetroStyleManager mStyleManager;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroTextBox mtxtAnmerkungen;
	}
}