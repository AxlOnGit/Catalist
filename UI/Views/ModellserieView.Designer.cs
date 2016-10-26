namespace Products.Common.Views
{
	partial class ModellserieView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModellserieView));
			this.mtxtSerienname = new MetroFramework.Controls.MetroTextBox();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mtxtDateipfad = new MetroFramework.Controls.MetroTextBox();
			this.mcmbHersteller = new MetroFramework.Controls.MetroComboBox();
			this.mtxtLetzteFirmware = new MetroFramework.Controls.MetroTextBox();
			this.mtxtEinfuehrung = new MetroFramework.Controls.MetroTextBox();
			this.mcmbMaschinentyp = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.btnAddSerie = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnSetTechnikordner = new System.Windows.Forms.Button();
			this.mtxtWartungsintervall = new MetroFramework.Controls.MetroTextBox();
			this.mlblAlle = new MetroFramework.Controls.MetroLabel();
			this.chkWartungskennzeichen = new MetroFramework.Controls.MetroCheckBox();
			this.mlblMonate = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// mtxtSerienname
			// 
			// 
			// 
			// 
			this.mtxtSerienname.CustomButton.Image = null;
			this.mtxtSerienname.CustomButton.Location = new System.Drawing.Point(196, 1);
			this.mtxtSerienname.CustomButton.Name = "";
			this.mtxtSerienname.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtSerienname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSerienname.CustomButton.TabIndex = 1;
			this.mtxtSerienname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSerienname.CustomButton.UseSelectable = true;
			this.mtxtSerienname.CustomButton.Visible = false;
			this.mtxtSerienname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSerienname.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtSerienname.Lines = new string[0];
			this.mtxtSerienname.Location = new System.Drawing.Point(146, 98);
			this.mtxtSerienname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtSerienname.MaxLength = 32767;
			this.mtxtSerienname.Name = "mtxtSerienname";
			this.mtxtSerienname.PasswordChar = '\0';
			this.mtxtSerienname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSerienname.SelectedText = "";
			this.mtxtSerienname.SelectionLength = 0;
			this.mtxtSerienname.SelectionStart = 0;
			this.mtxtSerienname.ShortcutsEnabled = true;
			this.mtxtSerienname.Size = new System.Drawing.Size(218, 23);
			this.mtxtSerienname.TabIndex = 0;
			this.toolTip1.SetToolTip(this.mtxtSerienname, "Der Name für diese Modellserie");
			this.mtxtSerienname.UseSelectable = true;
			this.mtxtSerienname.WaterMark = "Bezeichnung";
			this.mtxtSerienname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSerienname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(763, 463);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 5;
			this.mbtnClose.Text = "Schließen";
			this.toolTip1.SetToolTip(this.mbtnClose, "Fenster schließen");
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mtxtDateipfad
			// 
			this.mtxtDateipfad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtDateipfad.CustomButton.Image = null;
			this.mtxtDateipfad.CustomButton.Location = new System.Drawing.Point(666, 1);
			this.mtxtDateipfad.CustomButton.Name = "";
			this.mtxtDateipfad.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtDateipfad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtDateipfad.CustomButton.TabIndex = 1;
			this.mtxtDateipfad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtDateipfad.CustomButton.UseSelectable = true;
			this.mtxtDateipfad.CustomButton.Visible = false;
			this.mtxtDateipfad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtDateipfad.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtDateipfad.Lines = new string[0];
			this.mtxtDateipfad.Location = new System.Drawing.Point(146, 292);
			this.mtxtDateipfad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtDateipfad.MaxLength = 32767;
			this.mtxtDateipfad.Name = "mtxtDateipfad";
			this.mtxtDateipfad.PasswordChar = '\0';
			this.mtxtDateipfad.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtDateipfad.SelectedText = "";
			this.mtxtDateipfad.SelectionLength = 0;
			this.mtxtDateipfad.SelectionStart = 0;
			this.mtxtDateipfad.ShortcutsEnabled = true;
			this.mtxtDateipfad.Size = new System.Drawing.Size(688, 23);
			this.mtxtDateipfad.TabIndex = 5;
			this.toolTip1.SetToolTip(this.mtxtDateipfad, "Dies ist der Dateiordner, in dem alle technischen Dokumente und andere Dateien fü" +
				"r diese Serie gespeichert werden");
			this.mtxtDateipfad.UseSelectable = true;
			this.mtxtDateipfad.WaterMark = "Pfad auswählen oder eintragen (besser auswählen - eintragen geht meist schief)";
			this.mtxtDateipfad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtDateipfad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mcmbHersteller
			// 
			this.mcmbHersteller.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbHersteller.FormattingEnabled = true;
			this.mcmbHersteller.ItemHeight = 23;
			this.mcmbHersteller.Location = new System.Drawing.Point(146, 134);
			this.mcmbHersteller.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mcmbHersteller.Name = "mcmbHersteller";
			this.mcmbHersteller.Size = new System.Drawing.Size(218, 29);
			this.mcmbHersteller.TabIndex = 1;
			this.toolTip1.SetToolTip(this.mcmbHersteller, "Hersteller der Modellserie");
			this.mcmbHersteller.UseSelectable = true;
			// 
			// mtxtLetzteFirmware
			// 
			// 
			// 
			// 
			this.mtxtLetzteFirmware.CustomButton.Image = null;
			this.mtxtLetzteFirmware.CustomButton.Location = new System.Drawing.Point(86, 1);
			this.mtxtLetzteFirmware.CustomButton.Name = "";
			this.mtxtLetzteFirmware.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtLetzteFirmware.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtLetzteFirmware.CustomButton.TabIndex = 1;
			this.mtxtLetzteFirmware.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtLetzteFirmware.CustomButton.UseSelectable = true;
			this.mtxtLetzteFirmware.CustomButton.Visible = false;
			this.mtxtLetzteFirmware.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtLetzteFirmware.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtLetzteFirmware.Lines = new string[0];
			this.mtxtLetzteFirmware.Location = new System.Drawing.Point(146, 218);
			this.mtxtLetzteFirmware.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtLetzteFirmware.MaxLength = 32767;
			this.mtxtLetzteFirmware.Name = "mtxtLetzteFirmware";
			this.mtxtLetzteFirmware.PasswordChar = '\0';
			this.mtxtLetzteFirmware.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtLetzteFirmware.SelectedText = "";
			this.mtxtLetzteFirmware.SelectionLength = 0;
			this.mtxtLetzteFirmware.SelectionStart = 0;
			this.mtxtLetzteFirmware.ShortcutsEnabled = true;
			this.mtxtLetzteFirmware.Size = new System.Drawing.Size(108, 23);
			this.mtxtLetzteFirmware.TabIndex = 3;
			this.toolTip1.SetToolTip(this.mtxtLetzteFirmware, "Die Version der zuletzt veröffentlichten Firmware für diese Serie");
			this.mtxtLetzteFirmware.UseSelectable = true;
			this.mtxtLetzteFirmware.WaterMark = "Version";
			this.mtxtLetzteFirmware.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtLetzteFirmware.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtEinfuehrung
			// 
			// 
			// 
			// 
			this.mtxtEinfuehrung.CustomButton.Image = null;
			this.mtxtEinfuehrung.CustomButton.Location = new System.Drawing.Point(86, 1);
			this.mtxtEinfuehrung.CustomButton.Name = "";
			this.mtxtEinfuehrung.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtEinfuehrung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtEinfuehrung.CustomButton.TabIndex = 1;
			this.mtxtEinfuehrung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtEinfuehrung.CustomButton.UseSelectable = true;
			this.mtxtEinfuehrung.CustomButton.Visible = false;
			this.mtxtEinfuehrung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtEinfuehrung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtEinfuehrung.Lines = new string[0];
			this.mtxtEinfuehrung.Location = new System.Drawing.Point(146, 254);
			this.mtxtEinfuehrung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtEinfuehrung.MaxLength = 32767;
			this.mtxtEinfuehrung.Name = "mtxtEinfuehrung";
			this.mtxtEinfuehrung.PasswordChar = '\0';
			this.mtxtEinfuehrung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtEinfuehrung.SelectedText = "";
			this.mtxtEinfuehrung.SelectionLength = 0;
			this.mtxtEinfuehrung.SelectionStart = 0;
			this.mtxtEinfuehrung.ShortcutsEnabled = true;
			this.mtxtEinfuehrung.Size = new System.Drawing.Size(108, 23);
			this.mtxtEinfuehrung.TabIndex = 4;
			this.toolTip1.SetToolTip(this.mtxtEinfuehrung, "Das Jahr der Markteinführung");
			this.mtxtEinfuehrung.UseSelectable = true;
			this.mtxtEinfuehrung.WaterMark = "Jahr";
			this.mtxtEinfuehrung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtEinfuehrung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mcmbMaschinentyp
			// 
			this.mcmbMaschinentyp.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbMaschinentyp.FormattingEnabled = true;
			this.mcmbMaschinentyp.ItemHeight = 23;
			this.mcmbMaschinentyp.Location = new System.Drawing.Point(146, 176);
			this.mcmbMaschinentyp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mcmbMaschinentyp.Name = "mcmbMaschinentyp";
			this.mcmbMaschinentyp.Size = new System.Drawing.Size(218, 29);
			this.mcmbMaschinentyp.TabIndex = 2;
			this.toolTip1.SetToolTip(this.mcmbMaschinentyp, "Der Maschinentyp dieser Serie");
			this.mcmbMaschinentyp.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 98);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(41, 19);
			this.metroLabel1.TabIndex = 9;
			this.metroLabel1.Text = "Serie:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 134);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(68, 19);
			this.metroLabel2.TabIndex = 10;
			this.metroLabel2.Text = "Hersteller:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 176);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(91, 19);
			this.metroLabel3.TabIndex = 11;
			this.metroLabel3.Text = "Maschinentyp:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 218);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(117, 19);
			this.metroLabel4.TabIndex = 12;
			this.metroLabel4.Text = "Aktuelle Firmware:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(23, 254);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(108, 19);
			this.metroLabel5.TabIndex = 13;
			this.metroLabel5.Text = "Markteinführung:";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(23, 292);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(94, 19);
			this.metroLabel6.TabIndex = 14;
			this.metroLabel6.Text = "Technikordner:";
			// 
			// btnAddSerie
			// 
			this.btnAddSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddSerie.BackColor = System.Drawing.Color.Transparent;
			this.btnAddSerie.BackgroundImage = global::Products.Common.Properties.Resources.neu_metroblue;
			this.btnAddSerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddSerie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddSerie.FlatAppearance.BorderSize = 0;
			this.btnAddSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddSerie.Location = new System.Drawing.Point(23, 453);
			this.btnAddSerie.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnAddSerie.Name = "btnAddSerie";
			this.btnAddSerie.Size = new System.Drawing.Size(36, 36);
			this.btnAddSerie.TabIndex = 53;
			this.toolTip1.SetToolTip(this.btnAddSerie, "Neue Maschinenserie erstellen");
			this.btnAddSerie.UseVisualStyleBackColor = false;
			this.btnAddSerie.Click += new System.EventHandler(this.btnAddSerie_Click);
			// 
			// btnSetTechnikordner
			// 
			this.btnSetTechnikordner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetTechnikordner.BackColor = System.Drawing.Color.Transparent;
			this.btnSetTechnikordner.BackgroundImage = global::Products.Common.Properties.Resources.open_16_metroblue;
			this.btnSetTechnikordner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSetTechnikordner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSetTechnikordner.FlatAppearance.BorderSize = 0;
			this.btnSetTechnikordner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetTechnikordner.Location = new System.Drawing.Point(840, 292);
			this.btnSetTechnikordner.Name = "btnSetTechnikordner";
			this.btnSetTechnikordner.Size = new System.Drawing.Size(23, 23);
			this.btnSetTechnikordner.TabIndex = 54;
			this.toolTip1.SetToolTip(this.btnSetTechnikordner, "Den Dialog zur Auswahl des Technikordners öffnen");
			this.btnSetTechnikordner.UseVisualStyleBackColor = false;
			this.btnSetTechnikordner.Click += new System.EventHandler(this.btnSetTechnikordner_Click);
			// 
			// mtxtWartungsintervall
			// 
			// 
			// 
			// 
			this.mtxtWartungsintervall.CustomButton.Image = null;
			this.mtxtWartungsintervall.CustomButton.Location = new System.Drawing.Point(12, 1);
			this.mtxtWartungsintervall.CustomButton.Name = "";
			this.mtxtWartungsintervall.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtWartungsintervall.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtWartungsintervall.CustomButton.TabIndex = 1;
			this.mtxtWartungsintervall.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtWartungsintervall.CustomButton.UseSelectable = true;
			this.mtxtWartungsintervall.CustomButton.Visible = false;
			this.mtxtWartungsintervall.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtWartungsintervall.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtWartungsintervall.Lines = new string[0];
			this.mtxtWartungsintervall.Location = new System.Drawing.Point(290, 328);
			this.mtxtWartungsintervall.Margin = new System.Windows.Forms.Padding(2, 3, 2, 10);
			this.mtxtWartungsintervall.MaxLength = 32767;
			this.mtxtWartungsintervall.Name = "mtxtWartungsintervall";
			this.mtxtWartungsintervall.PasswordChar = '\0';
			this.mtxtWartungsintervall.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtWartungsintervall.SelectedText = "";
			this.mtxtWartungsintervall.SelectionLength = 0;
			this.mtxtWartungsintervall.SelectionStart = 0;
			this.mtxtWartungsintervall.ShortcutsEnabled = true;
			this.mtxtWartungsintervall.Size = new System.Drawing.Size(34, 23);
			this.mtxtWartungsintervall.TabIndex = 7;
			this.mtxtWartungsintervall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.mtxtWartungsintervall, "Das Jahr der Markteinführung");
			this.mtxtWartungsintervall.UseSelectable = true;
			this.mtxtWartungsintervall.WaterMark = "X";
			this.mtxtWartungsintervall.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtWartungsintervall.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mlblAlle
			// 
			this.mlblAlle.AutoSize = true;
			this.mlblAlle.Location = new System.Drawing.Point(257, 328);
			this.mlblAlle.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
			this.mlblAlle.Name = "mlblAlle";
			this.mlblAlle.Size = new System.Drawing.Size(29, 19);
			this.mlblAlle.TabIndex = 56;
			this.mlblAlle.Text = "alle";
			// 
			// chkWartungskennzeichen
			// 
			this.chkWartungskennzeichen.AutoSize = true;
			this.chkWartungskennzeichen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.chkWartungskennzeichen.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.chkWartungskennzeichen.Location = new System.Drawing.Point(146, 328);
			this.chkWartungskennzeichen.Name = "chkWartungskennzeichen";
			this.chkWartungskennzeichen.Size = new System.Drawing.Size(113, 19);
			this.chkWartungskennzeichen.TabIndex = 6;
			this.chkWartungskennzeichen.Text = "Wird gewartet,";
			this.chkWartungskennzeichen.UseSelectable = true;
			// 
			// mlblMonate
			// 
			this.mlblMonate.AutoSize = true;
			this.mlblMonate.Location = new System.Drawing.Point(328, 328);
			this.mlblMonate.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
			this.mlblMonate.Name = "mlblMonate";
			this.mlblMonate.Size = new System.Drawing.Size(54, 19);
			this.mlblMonate.TabIndex = 57;
			this.mlblMonate.Text = "Monate";
			// 
			// ModellserieView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(886, 512);
			this.Controls.Add(this.mlblMonate);
			this.Controls.Add(this.chkWartungskennzeichen);
			this.Controls.Add(this.mlblAlle);
			this.Controls.Add(this.mtxtWartungsintervall);
			this.Controls.Add(this.btnSetTechnikordner);
			this.Controls.Add(this.btnAddSerie);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mcmbMaschinentyp);
			this.Controls.Add(this.mtxtEinfuehrung);
			this.Controls.Add(this.mtxtLetzteFirmware);
			this.Controls.Add(this.mcmbHersteller);
			this.Controls.Add(this.mtxtDateipfad);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.mtxtSerienname);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModellserieView";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Text = "Maschinenserie";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox mtxtSerienname;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroTextBox mtxtDateipfad;
		private MetroFramework.Controls.MetroComboBox mcmbHersteller;
		private MetroFramework.Controls.MetroTextBox mtxtLetzteFirmware;
		private MetroFramework.Controls.MetroTextBox mtxtEinfuehrung;
		private MetroFramework.Controls.MetroComboBox mcmbMaschinentyp;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.Button btnAddSerie;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnSetTechnikordner;
		private MetroFramework.Controls.MetroLabel mlblAlle;
		private MetroFramework.Controls.MetroTextBox mtxtWartungsintervall;
		private MetroFramework.Controls.MetroCheckBox chkWartungskennzeichen;
		private MetroFramework.Controls.MetroLabel mlblMonate;
	}
}