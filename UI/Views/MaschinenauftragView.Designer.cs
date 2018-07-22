namespace Products.Common.Views
{
	partial class MaschinenauftragView
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
			this.components = new System.ComponentModel.Container();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mtxtKundenbestellungDurch = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mcmbKundenbestellungPer = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.mtxtBestellIdSage = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.mtxtAnmerkungenBestellung = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
			this.mtxtAuftragsnummerSage = new MetroFramework.Controls.MetroTextBox();
			this.mlnkMaschinenbestellungDurchId = new MetroFramework.Controls.MetroLink();
			this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
			this.mlnkLieferungZumKundenDurch = new MetroFramework.Controls.MetroLink();
			this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
			this.mlnkInstallationDurch = new MetroFramework.Controls.MetroLink();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.mdtpKundenbestellungAm = new MetroFramework.Controls.MetroDateTime();
			this.mdtpMaschinenbestellungAm = new MetroFramework.Controls.MetroDateTime();
			this.mdtpMaschinenlieferungAm = new MetroFramework.Controls.MetroDateTime();
			this.mdtpLieferungZumKundenAm = new MetroFramework.Controls.MetroDateTime();
			this.mdtpInstallationsdatum = new MetroFramework.Controls.MetroDateTime();
			this.mtogglAuftragErledigtFlag = new MetroFramework.Controls.MetroToggle();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.mctxForm = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdCreateInstDocuments = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmbTintenTyp = new MetroFramework.Controls.MetroComboBox();
			this.mtxtFarbSet = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
			this.mctxForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(708, 711);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnClose.TabIndex = 70;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 124);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(137, 19);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Kundenbestellung am:";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mtxtKundenbestellungDurch
			// 
			// 
			// 
			// 
			this.mtxtKundenbestellungDurch.CustomButton.Image = null;
			this.mtxtKundenbestellungDurch.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.mtxtKundenbestellungDurch.CustomButton.Name = "";
			this.mtxtKundenbestellungDurch.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.mtxtKundenbestellungDurch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtKundenbestellungDurch.CustomButton.TabIndex = 1;
			this.mtxtKundenbestellungDurch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtKundenbestellungDurch.CustomButton.UseSelectable = true;
			this.mtxtKundenbestellungDurch.CustomButton.Visible = false;
			this.mtxtKundenbestellungDurch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtKundenbestellungDurch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtKundenbestellungDurch.Lines = new string[0];
			this.mtxtKundenbestellungDurch.Location = new System.Drawing.Point(363, 120);
			this.mtxtKundenbestellungDurch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtKundenbestellungDurch.MaxLength = 32767;
			this.mtxtKundenbestellungDurch.Name = "mtxtKundenbestellungDurch";
			this.mtxtKundenbestellungDurch.PasswordChar = '\0';
			this.mtxtKundenbestellungDurch.PromptText = "Bernd Bestellma";
			this.mtxtKundenbestellungDurch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtKundenbestellungDurch.SelectedText = "";
			this.mtxtKundenbestellungDurch.SelectionLength = 0;
			this.mtxtKundenbestellungDurch.SelectionStart = 0;
			this.mtxtKundenbestellungDurch.ShortcutsEnabled = true;
			this.mtxtKundenbestellungDurch.Size = new System.Drawing.Size(187, 29);
			this.mtxtKundenbestellungDurch.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtKundenbestellungDurch.TabIndex = 5;
			this.mtxtKundenbestellungDurch.UseSelectable = true;
			this.mtxtKundenbestellungDurch.WaterMark = "Bernd Bestellma";
			this.mtxtKundenbestellungDurch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtKundenbestellungDurch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(327, 124);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(30, 19);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "von";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mcmbKundenbestellungPer
			// 
			this.mcmbKundenbestellungPer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmbKundenbestellungPer.FormattingEnabled = true;
			this.mcmbKundenbestellungPer.ItemHeight = 23;
			this.mcmbKundenbestellungPer.Items.AddRange(new object[] {
            "Telefon",
            "E-Mail",
            "Persönlich",
            "Webshop",
            "Brief"});
			this.mcmbKundenbestellungPer.Location = new System.Drawing.Point(591, 120);
			this.mcmbKundenbestellungPer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mcmbKundenbestellungPer.Name = "mcmbKundenbestellungPer";
			this.mcmbKundenbestellungPer.Size = new System.Drawing.Size(192, 29);
			this.mcmbKundenbestellungPer.Style = MetroFramework.MetroColorStyle.Lime;
			this.mcmbKundenbestellungPer.TabIndex = 10;
			this.mcmbKundenbestellungPer.UseSelectable = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(556, 124);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(29, 19);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "per";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 171);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(169, 19);
			this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel4.TabIndex = 12;
			this.metroLabel4.Text = "Beim Hersteller bestellt am:";
			this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(327, 171);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(30, 19);
			this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel5.TabIndex = 13;
			this.metroLabel5.Text = "von";
			this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mtxtBestellIdSage
			// 
			this.mtxtBestellIdSage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtBestellIdSage.CustomButton.Image = null;
			this.mtxtBestellIdSage.CustomButton.Location = new System.Drawing.Point(164, 1);
			this.mtxtBestellIdSage.CustomButton.Name = "";
			this.mtxtBestellIdSage.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.mtxtBestellIdSage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtBestellIdSage.CustomButton.TabIndex = 1;
			this.mtxtBestellIdSage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtBestellIdSage.CustomButton.UseSelectable = true;
			this.mtxtBestellIdSage.CustomButton.Visible = false;
			this.mtxtBestellIdSage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtBestellIdSage.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtBestellIdSage.Lines = new string[0];
			this.mtxtBestellIdSage.Location = new System.Drawing.Point(591, 167);
			this.mtxtBestellIdSage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtBestellIdSage.MaxLength = 32767;
			this.mtxtBestellIdSage.Name = "mtxtBestellIdSage";
			this.mtxtBestellIdSage.PasswordChar = '\0';
			this.mtxtBestellIdSage.PromptText = "Bestellnummer Sage";
			this.mtxtBestellIdSage.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtBestellIdSage.SelectedText = "";
			this.mtxtBestellIdSage.SelectionLength = 0;
			this.mtxtBestellIdSage.SelectionStart = 0;
			this.mtxtBestellIdSage.ShortcutsEnabled = true;
			this.mtxtBestellIdSage.Size = new System.Drawing.Size(192, 29);
			this.mtxtBestellIdSage.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtBestellIdSage.TabIndex = 25;
			this.mtxtBestellIdSage.UseSelectable = true;
			this.mtxtBestellIdSage.WaterMark = "Bestellnummer Sage";
			this.mtxtBestellIdSage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtBestellIdSage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(23, 218);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(128, 19);
			this.metroLabel6.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel6.TabIndex = 17;
			this.metroLabel6.Text = "Hersteller liefert am:";
			this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mtxtAnmerkungenBestellung
			// 
			this.mtxtAnmerkungenBestellung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtAnmerkungenBestellung.CustomButton.Image = null;
			this.mtxtAnmerkungenBestellung.CustomButton.Location = new System.Drawing.Point(484, 2);
			this.mtxtAnmerkungenBestellung.CustomButton.Name = "";
			this.mtxtAnmerkungenBestellung.CustomButton.Size = new System.Drawing.Size(113, 113);
			this.mtxtAnmerkungenBestellung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAnmerkungenBestellung.CustomButton.TabIndex = 1;
			this.mtxtAnmerkungenBestellung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAnmerkungenBestellung.CustomButton.UseSelectable = true;
			this.mtxtAnmerkungenBestellung.CustomButton.Visible = false;
			this.mtxtAnmerkungenBestellung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAnmerkungenBestellung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtAnmerkungenBestellung.Lines = new string[0];
			this.mtxtAnmerkungenBestellung.Location = new System.Drawing.Point(198, 355);
			this.mtxtAnmerkungenBestellung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtAnmerkungenBestellung.MaxLength = 32767;
			this.mtxtAnmerkungenBestellung.Multiline = true;
			this.mtxtAnmerkungenBestellung.Name = "mtxtAnmerkungenBestellung";
			this.mtxtAnmerkungenBestellung.PasswordChar = '\0';
			this.mtxtAnmerkungenBestellung.PromptText = "Anmerkungen zur Bestellung";
			this.mtxtAnmerkungenBestellung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.mtxtAnmerkungenBestellung.SelectedText = "";
			this.mtxtAnmerkungenBestellung.SelectionLength = 0;
			this.mtxtAnmerkungenBestellung.SelectionStart = 0;
			this.mtxtAnmerkungenBestellung.ShortcutsEnabled = true;
			this.mtxtAnmerkungenBestellung.Size = new System.Drawing.Size(600, 118);
			this.mtxtAnmerkungenBestellung.TabIndex = 45;
			this.mtxtAnmerkungenBestellung.UseSelectable = true;
			this.mtxtAnmerkungenBestellung.WaterMark = "Anmerkungen zur Bestellung";
			this.mtxtAnmerkungenBestellung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAnmerkungenBestellung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(23, 355);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(94, 19);
			this.metroLabel7.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel7.TabIndex = 19;
			this.metroLabel7.Text = "Anmerkungen:";
			this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// metroLabel15
			// 
			this.metroLabel15.AutoSize = true;
			this.metroLabel15.Location = new System.Drawing.Point(23, 589);
			this.metroLabel15.Name = "metroLabel15";
			this.metroLabel15.Size = new System.Drawing.Size(112, 19);
			this.metroLabel15.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel15.TabIndex = 35;
			this.metroLabel15.Text = "Auftragsnummer:";
			this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mtxtAuftragsnummerSage
			// 
			// 
			// 
			// 
			this.mtxtAuftragsnummerSage.CustomButton.Image = null;
			this.mtxtAuftragsnummerSage.CustomButton.Location = new System.Drawing.Point(95, 1);
			this.mtxtAuftragsnummerSage.CustomButton.Name = "";
			this.mtxtAuftragsnummerSage.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.mtxtAuftragsnummerSage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAuftragsnummerSage.CustomButton.TabIndex = 1;
			this.mtxtAuftragsnummerSage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAuftragsnummerSage.CustomButton.UseSelectable = true;
			this.mtxtAuftragsnummerSage.CustomButton.Visible = false;
			this.mtxtAuftragsnummerSage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAuftragsnummerSage.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtAuftragsnummerSage.Lines = new string[0];
			this.mtxtAuftragsnummerSage.Location = new System.Drawing.Point(198, 585);
			this.mtxtAuftragsnummerSage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtAuftragsnummerSage.MaxLength = 32767;
			this.mtxtAuftragsnummerSage.Name = "mtxtAuftragsnummerSage";
			this.mtxtAuftragsnummerSage.PasswordChar = '\0';
			this.mtxtAuftragsnummerSage.PromptText = "20160009999";
			this.mtxtAuftragsnummerSage.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtAuftragsnummerSage.SelectedText = "";
			this.mtxtAuftragsnummerSage.SelectionLength = 0;
			this.mtxtAuftragsnummerSage.SelectionStart = 0;
			this.mtxtAuftragsnummerSage.ShortcutsEnabled = true;
			this.mtxtAuftragsnummerSage.Size = new System.Drawing.Size(123, 29);
			this.mtxtAuftragsnummerSage.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtAuftragsnummerSage.TabIndex = 60;
			this.mtxtAuftragsnummerSage.UseSelectable = true;
			this.mtxtAuftragsnummerSage.WaterMark = "20160009999";
			this.mtxtAuftragsnummerSage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAuftragsnummerSage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// mlnkMaschinenbestellungDurchId
			// 
			this.mlnkMaschinenbestellungDurchId.Location = new System.Drawing.Point(363, 171);
			this.mlnkMaschinenbestellungDurchId.Name = "mlnkMaschinenbestellungDurchId";
			this.mlnkMaschinenbestellungDurchId.Size = new System.Drawing.Size(209, 23);
			this.mlnkMaschinenbestellungDurchId.TabIndex = 20;
			this.mlnkMaschinenbestellungDurchId.Text = "Besteller auswählen";
			this.mlnkMaschinenbestellungDurchId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkMaschinenbestellungDurchId.UseSelectable = true;
			this.mlnkMaschinenbestellungDurchId.Click += new System.EventHandler(this.mlnkMaschinenbestellungDurchId_Click);
			// 
			// metroLabel19
			// 
			this.metroLabel19.AutoSize = true;
			this.metroLabel19.Location = new System.Drawing.Point(23, 542);
			this.metroLabel19.Name = "metroLabel19";
			this.metroLabel19.Size = new System.Drawing.Size(172, 19);
			this.metroLabel19.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel19.TabIndex = 107;
			this.metroLabel19.Text = "Auslieferung an Kunden am:";
			this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mlnkLieferungZumKundenDurch
			// 
			this.mlnkLieferungZumKundenDurch.Location = new System.Drawing.Point(368, 541);
			this.mlnkLieferungZumKundenDurch.Name = "mlnkLieferungZumKundenDurch";
			this.mlnkLieferungZumKundenDurch.Size = new System.Drawing.Size(209, 23);
			this.mlnkLieferungZumKundenDurch.TabIndex = 110;
			this.mlnkLieferungZumKundenDurch.Text = "Techniker auswählen";
			this.mlnkLieferungZumKundenDurch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkLieferungZumKundenDurch.UseSelectable = true;
			this.mlnkLieferungZumKundenDurch.Click += new System.EventHandler(this.mlnkLieferungZumKundenDurch_Click);
			// 
			// metroLabel20
			// 
			this.metroLabel20.AutoSize = true;
			this.metroLabel20.Location = new System.Drawing.Point(327, 542);
			this.metroLabel20.Name = "metroLabel20";
			this.metroLabel20.Size = new System.Drawing.Size(42, 19);
			this.metroLabel20.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel20.TabIndex = 109;
			this.metroLabel20.Text = "durch";
			this.metroLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// metroLabel13
			// 
			this.metroLabel13.AutoSize = true;
			this.metroLabel13.Location = new System.Drawing.Point(327, 218);
			this.metroLabel13.Name = "metroLabel13";
			this.metroLabel13.Size = new System.Drawing.Size(117, 19);
			this.metroLabel13.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel13.TabIndex = 111;
			this.metroLabel13.Text = "wenn\'s glatt läuft ...";
			this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mlnkInstallationDurch
			// 
			this.mlnkInstallationDurch.Location = new System.Drawing.Point(368, 494);
			this.mlnkInstallationDurch.Name = "mlnkInstallationDurch";
			this.mlnkInstallationDurch.Size = new System.Drawing.Size(209, 23);
			this.mlnkInstallationDurch.TabIndex = 115;
			this.mlnkInstallationDurch.Text = "Techniker auswählen";
			this.mlnkInstallationDurch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkInstallationDurch.UseSelectable = true;
			this.mlnkInstallationDurch.Click += new System.EventHandler(this.mlnkInstallationDurch_Click);
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(327, 495);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(42, 19);
			this.metroLabel8.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel8.TabIndex = 114;
			this.metroLabel8.Text = "durch";
			this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(23, 495);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(157, 19);
			this.metroLabel9.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel9.TabIndex = 112;
			this.metroLabel9.Text = "Maschineninstallation am:";
			this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mdtpKundenbestellungAm
			// 
			this.mdtpKundenbestellungAm.Checked = false;
			this.mdtpKundenbestellungAm.CustomFormat = " ";
			this.mdtpKundenbestellungAm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mdtpKundenbestellungAm.Location = new System.Drawing.Point(198, 120);
			this.mdtpKundenbestellungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mdtpKundenbestellungAm.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpKundenbestellungAm.Name = "mdtpKundenbestellungAm";
			this.mdtpKundenbestellungAm.ShowCheckBox = true;
			this.mdtpKundenbestellungAm.Size = new System.Drawing.Size(123, 29);
			this.mdtpKundenbestellungAm.Style = MetroFramework.MetroColorStyle.Lime;
			this.mdtpKundenbestellungAm.TabIndex = 0;
			this.mdtpKundenbestellungAm.UseStyleColors = true;
			this.mdtpKundenbestellungAm.ValueChanged += new System.EventHandler(this.mdtpKundenbestellungAm_ValueChanged);
			// 
			// mdtpMaschinenbestellungAm
			// 
			this.mdtpMaschinenbestellungAm.Checked = false;
			this.mdtpMaschinenbestellungAm.CustomFormat = " ";
			this.mdtpMaschinenbestellungAm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mdtpMaschinenbestellungAm.Location = new System.Drawing.Point(198, 167);
			this.mdtpMaschinenbestellungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mdtpMaschinenbestellungAm.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpMaschinenbestellungAm.Name = "mdtpMaschinenbestellungAm";
			this.mdtpMaschinenbestellungAm.ShowCheckBox = true;
			this.mdtpMaschinenbestellungAm.Size = new System.Drawing.Size(123, 29);
			this.mdtpMaschinenbestellungAm.Style = MetroFramework.MetroColorStyle.Lime;
			this.mdtpMaschinenbestellungAm.TabIndex = 15;
			this.mdtpMaschinenbestellungAm.UseStyleColors = true;
			this.mdtpMaschinenbestellungAm.ValueChanged += new System.EventHandler(this.mdtpMaschinenbestellungAm_ValueChanged);
			// 
			// mdtpMaschinenlieferungAm
			// 
			this.mdtpMaschinenlieferungAm.Checked = false;
			this.mdtpMaschinenlieferungAm.CustomFormat = " ";
			this.mdtpMaschinenlieferungAm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mdtpMaschinenlieferungAm.Location = new System.Drawing.Point(198, 214);
			this.mdtpMaschinenlieferungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mdtpMaschinenlieferungAm.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpMaschinenlieferungAm.Name = "mdtpMaschinenlieferungAm";
			this.mdtpMaschinenlieferungAm.ShowCheckBox = true;
			this.mdtpMaschinenlieferungAm.Size = new System.Drawing.Size(123, 29);
			this.mdtpMaschinenlieferungAm.Style = MetroFramework.MetroColorStyle.Lime;
			this.mdtpMaschinenlieferungAm.TabIndex = 30;
			this.mdtpMaschinenlieferungAm.UseStyleColors = true;
			this.mdtpMaschinenlieferungAm.ValueChanged += new System.EventHandler(this.mdtpMaschinenlieferungAm_ValueChanged);
			// 
			// mdtpLieferungZumKundenAm
			// 
			this.mdtpLieferungZumKundenAm.Checked = false;
			this.mdtpLieferungZumKundenAm.CustomFormat = " ";
			this.mdtpLieferungZumKundenAm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mdtpLieferungZumKundenAm.Location = new System.Drawing.Point(198, 538);
			this.mdtpLieferungZumKundenAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mdtpLieferungZumKundenAm.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpLieferungZumKundenAm.Name = "mdtpLieferungZumKundenAm";
			this.mdtpLieferungZumKundenAm.ShowCheckBox = true;
			this.mdtpLieferungZumKundenAm.Size = new System.Drawing.Size(123, 29);
			this.mdtpLieferungZumKundenAm.Style = MetroFramework.MetroColorStyle.Lime;
			this.mdtpLieferungZumKundenAm.TabIndex = 55;
			this.mdtpLieferungZumKundenAm.UseStyleColors = true;
			this.mdtpLieferungZumKundenAm.ValueChanged += new System.EventHandler(this.mdtpLieferungZumKundenAm_ValueChanged);
			// 
			// mdtpInstallationsdatum
			// 
			this.mdtpInstallationsdatum.Checked = false;
			this.mdtpInstallationsdatum.CustomFormat = " ";
			this.mdtpInstallationsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mdtpInstallationsdatum.Location = new System.Drawing.Point(198, 491);
			this.mdtpInstallationsdatum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mdtpInstallationsdatum.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpInstallationsdatum.Name = "mdtpInstallationsdatum";
			this.mdtpInstallationsdatum.ShowCheckBox = true;
			this.mdtpInstallationsdatum.Size = new System.Drawing.Size(123, 29);
			this.mdtpInstallationsdatum.Style = MetroFramework.MetroColorStyle.Lime;
			this.mdtpInstallationsdatum.TabIndex = 50;
			this.mdtpInstallationsdatum.UseStyleColors = true;
			this.mdtpInstallationsdatum.ValueChanged += new System.EventHandler(this.mdtpInstallationsdatum_ValueChanged);
			// 
			// mtogglAuftragErledigtFlag
			// 
			this.mtogglAuftragErledigtFlag.AutoSize = true;
			this.mtogglAuftragErledigtFlag.Location = new System.Drawing.Point(198, 657);
			this.mtogglAuftragErledigtFlag.Name = "mtogglAuftragErledigtFlag";
			this.mtogglAuftragErledigtFlag.Size = new System.Drawing.Size(80, 17);
			this.mtogglAuftragErledigtFlag.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtogglAuftragErledigtFlag.TabIndex = 65;
			this.mtogglAuftragErledigtFlag.Text = "Aus";
			this.mtogglAuftragErledigtFlag.UseSelectable = true;
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(23, 655);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(105, 19);
			this.metroLabel10.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel10.TabIndex = 122;
			this.metroLabel10.Text = "Auftrag erledigt:";
			this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mctxForm
			// 
			this.mctxForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdOpenInExplorer,
            this.toolStripMenuItem1,
            this.xcmdCreateInstDocuments});
			this.mctxForm.Name = "mctxForm";
			this.mctxForm.Size = new System.Drawing.Size(246, 54);
			// 
			// xcmdOpenInExplorer
			// 
			this.xcmdOpenInExplorer.Image = global::Products.Common.Properties.Resources.explorer_exe_original;
			this.xcmdOpenInExplorer.Name = "xcmdOpenInExplorer";
			this.xcmdOpenInExplorer.Size = new System.Drawing.Size(245, 22);
			this.xcmdOpenInExplorer.Text = "Im Explorer öffnen";
			this.xcmdOpenInExplorer.Click += new System.EventHandler(this.xcmdOpenInExplorer_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
			// 
			// xcmdCreateInstDocuments
			// 
			this.xcmdCreateInstDocuments.Image = global::Products.Common.Properties.Resources.documents_16_metrolime;
			this.xcmdCreateInstDocuments.Name = "xcmdCreateInstDocuments";
			this.xcmdCreateInstDocuments.Size = new System.Drawing.Size(245, 22);
			this.xcmdCreateInstDocuments.Text = "Installationsdokumente erstellen";
			this.xcmdCreateInstDocuments.Click += new System.EventHandler(this.xcmdCreateInstDocuments_Click);
			// 
			// mcmbTintenTyp
			// 
			this.mcmbTintenTyp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmbTintenTyp.FormattingEnabled = true;
			this.mcmbTintenTyp.ItemHeight = 23;
			this.mcmbTintenTyp.Items.AddRange(new object[] {
            "Telefon",
            "E-Mail",
            "Persönlich",
            "Webshop",
            "Brief"});
			this.mcmbTintenTyp.Location = new System.Drawing.Point(198, 261);
			this.mcmbTintenTyp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mcmbTintenTyp.Name = "mcmbTintenTyp";
			this.mcmbTintenTyp.Size = new System.Drawing.Size(159, 29);
			this.mcmbTintenTyp.Style = MetroFramework.MetroColorStyle.Lime;
			this.mcmbTintenTyp.TabIndex = 35;
			this.mcmbTintenTyp.UseSelectable = true;
			// 
			// mtxtFarbSet
			// 
			// 
			// 
			// 
			this.mtxtFarbSet.CustomButton.Image = null;
			this.mtxtFarbSet.CustomButton.Location = new System.Drawing.Point(131, 1);
			this.mtxtFarbSet.CustomButton.Name = "";
			this.mtxtFarbSet.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.mtxtFarbSet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtFarbSet.CustomButton.TabIndex = 1;
			this.mtxtFarbSet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFarbSet.CustomButton.UseSelectable = true;
			this.mtxtFarbSet.CustomButton.Visible = false;
			this.mtxtFarbSet.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtFarbSet.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtFarbSet.Lines = new string[0];
			this.mtxtFarbSet.Location = new System.Drawing.Point(198, 308);
			this.mtxtFarbSet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtFarbSet.MaxLength = 32767;
			this.mtxtFarbSet.Name = "mtxtFarbSet";
			this.mtxtFarbSet.PasswordChar = '\0';
			this.mtxtFarbSet.PromptText = "CMYK-?-?";
			this.mtxtFarbSet.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFarbSet.SelectedText = "";
			this.mtxtFarbSet.SelectionLength = 0;
			this.mtxtFarbSet.SelectionStart = 0;
			this.mtxtFarbSet.ShortcutsEnabled = true;
			this.mtxtFarbSet.Size = new System.Drawing.Size(159, 29);
			this.mtxtFarbSet.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtFarbSet.TabIndex = 40;
			this.mtxtFarbSet.UseSelectable = true;
			this.mtxtFarbSet.WaterMark = "CMYK-?-?";
			this.mtxtFarbSet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFarbSet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(23, 266);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(65, 19);
			this.metroLabel11.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel11.TabIndex = 125;
			this.metroLabel11.Text = "Tintentyp:";
			this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// metroLabel12
			// 
			this.metroLabel12.AutoSize = true;
			this.metroLabel12.Location = new System.Drawing.Point(23, 313);
			this.metroLabel12.Name = "metroLabel12";
			this.metroLabel12.Size = new System.Drawing.Size(54, 19);
			this.metroLabel12.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroLabel12.TabIndex = 126;
			this.metroLabel12.Text = "Farbset:";
			this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MaschinenauftragView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 760);
			this.ContextMenuStrip = this.mctxForm;
			this.Controls.Add(this.metroLabel12);
			this.Controls.Add(this.metroLabel11);
			this.Controls.Add(this.mtxtFarbSet);
			this.Controls.Add(this.mcmbTintenTyp);
			this.Controls.Add(this.metroLabel10);
			this.Controls.Add(this.mtogglAuftragErledigtFlag);
			this.Controls.Add(this.mdtpLieferungZumKundenAm);
			this.Controls.Add(this.mdtpInstallationsdatum);
			this.Controls.Add(this.mdtpMaschinenlieferungAm);
			this.Controls.Add(this.mdtpMaschinenbestellungAm);
			this.Controls.Add(this.mdtpKundenbestellungAm);
			this.Controls.Add(this.mlnkInstallationDurch);
			this.Controls.Add(this.metroLabel8);
			this.Controls.Add(this.metroLabel9);
			this.Controls.Add(this.metroLabel13);
			this.Controls.Add(this.mlnkLieferungZumKundenDurch);
			this.Controls.Add(this.metroLabel20);
			this.Controls.Add(this.metroLabel19);
			this.Controls.Add(this.mlnkMaschinenbestellungDurchId);
			this.Controls.Add(this.mtxtAuftragsnummerSage);
			this.Controls.Add(this.metroLabel15);
			this.Controls.Add(this.metroLabel7);
			this.Controls.Add(this.mtxtAnmerkungenBestellung);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.mtxtBestellIdSage);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.mcmbKundenbestellungPer);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mtxtKundenbestellungDurch);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mbtnClose);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MaschinenauftragView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Maschinenauftrag ...";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaschinenauftragView_FormClosing);
			this.mctxForm.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox mtxtKundenbestellungDurch;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroComboBox mcmbKundenbestellungPer;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox mtxtBestellIdSage;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroTextBox mtxtAnmerkungenBestellung;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel15;
		private MetroFramework.Controls.MetroTextBox mtxtAuftragsnummerSage;
		private MetroFramework.Controls.MetroLink mlnkMaschinenbestellungDurchId;
		private MetroFramework.Controls.MetroLabel metroLabel19;
		private MetroFramework.Controls.MetroLink mlnkLieferungZumKundenDurch;
		private MetroFramework.Controls.MetroLabel metroLabel20;
		private MetroFramework.Controls.MetroLabel metroLabel13;
		private MetroFramework.Controls.MetroLink mlnkInstallationDurch;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private MetroFramework.Controls.MetroDateTime mdtpKundenbestellungAm;
		private MetroFramework.Controls.MetroDateTime mdtpMaschinenbestellungAm;
		private MetroFramework.Controls.MetroDateTime mdtpMaschinenlieferungAm;
		private MetroFramework.Controls.MetroDateTime mdtpLieferungZumKundenAm;
		private MetroFramework.Controls.MetroDateTime mdtpInstallationsdatum;
		private MetroFramework.Controls.MetroToggle mtogglAuftragErledigtFlag;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private MetroFramework.Controls.MetroContextMenu mctxForm;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenInExplorer;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdCreateInstDocuments;
		private MetroFramework.Controls.MetroComboBox mcmbTintenTyp;
		private MetroFramework.Controls.MetroTextBox mtxtFarbSet;
		private MetroFramework.Controls.MetroLabel metroLabel11;
		private MetroFramework.Controls.MetroLabel metroLabel12;
	}
}