namespace Products.Common.Views
{
	partial class TourkundenDetailView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvTourkunden = new MetroFramework.Controls.MetroGrid();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFirmenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLetzterBesuchstermin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBesuchsintervall = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBesuchszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmeldungFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colKurzpreislisteFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colVorjahresvergleichFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colUmsatzSeitLetztemBesuchFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colAusdruckLetztesAngebotFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colOhneVorbereitungFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colWeihnachtsFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mtxtAnmerkungen = new MetroFramework.Controls.MetroTextBox();
			this.mtxtCompetition = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTourkunden)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTourkunden
			// 
			this.dgvTourkunden.AllowUserToAddRows = false;
			this.dgvTourkunden.AllowUserToDeleteRows = false;
			this.dgvTourkunden.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvTourkunden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTourkunden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTourkunden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTourkunden.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTourkunden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTourkunden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(145)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTourkunden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTourkunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTourkunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundennummer,
            this.colFirmenname,
            this.colLetzterBesuchstermin,
            this.colBesuchsintervall,
            this.colBesuchszeit,
            this.colAnmeldungFlag,
            this.colKurzpreislisteFlag,
            this.colVorjahresvergleichFlag,
            this.colUmsatzSeitLetztemBesuchFlag,
            this.colAusdruckLetztesAngebotFlag,
            this.colOhneVorbereitungFlag,
            this.colWeihnachtsFlag});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(145)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTourkunden.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTourkunden.EnableHeadersVisualStyles = false;
			this.dgvTourkunden.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTourkunden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTourkunden.HighLightPercentage = 0.99F;
			this.dgvTourkunden.Location = new System.Drawing.Point(23, 100);
			this.dgvTourkunden.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvTourkunden.Name = "dgvTourkunden";
			this.dgvTourkunden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(145)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTourkunden.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTourkunden.RowHeadersVisible = false;
			this.dgvTourkunden.RowHeadersWidth = 21;
			this.dgvTourkunden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTourkunden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTourkunden.Size = new System.Drawing.Size(1268, 442);
			this.dgvTourkunden.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvTourkunden.TabIndex = 0;
			this.dgvTourkunden.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourkunden_RowEnter);
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "KundenNrCpm";
			this.colKundennummer.FillWeight = 20F;
			this.colKundennummer.HeaderText = "Kd.-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			this.colKundennummer.ReadOnly = true;
			// 
			// colFirmenname
			// 
			this.colFirmenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFirmenname.DataPropertyName = "CompanyName1";
			this.colFirmenname.FillWeight = 45F;
			this.colFirmenname.HeaderText = "Firma";
			this.colFirmenname.Name = "colFirmenname";
			this.colFirmenname.ReadOnly = true;
			// 
			// colLetzterBesuchstermin
			// 
			this.colLetzterBesuchstermin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLetzterBesuchstermin.DataPropertyName = "LetzterBesuchstermin";
			dataGridViewCellStyle3.NullValue = "-";
			this.colLetzterBesuchstermin.DefaultCellStyle = dataGridViewCellStyle3;
			this.colLetzterBesuchstermin.FillWeight = 15F;
			this.colLetzterBesuchstermin.HeaderText = "Letzter Termin";
			this.colLetzterBesuchstermin.MinimumWidth = 100;
			this.colLetzterBesuchstermin.Name = "colLetzterBesuchstermin";
			// 
			// colBesuchsintervall
			// 
			this.colBesuchsintervall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBesuchsintervall.DataPropertyName = "Besuchsintervall";
			this.colBesuchsintervall.FillWeight = 10F;
			this.colBesuchsintervall.HeaderText = "Intervall";
			this.colBesuchsintervall.MinimumWidth = 50;
			this.colBesuchsintervall.Name = "colBesuchsintervall";
			this.colBesuchsintervall.ToolTipText = "Zeitraum in Monaten zwischen zwei Besuchsterminen";
			// 
			// colBesuchszeit
			// 
			this.colBesuchszeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBesuchszeit.DataPropertyName = "Besuchszeit";
			this.colBesuchszeit.FillWeight = 10F;
			this.colBesuchszeit.HeaderText = "Dauer";
			this.colBesuchszeit.MinimumWidth = 50;
			this.colBesuchszeit.Name = "colBesuchszeit";
			this.colBesuchszeit.ToolTipText = "Voraussichtliche Dauer von Besuchsterminen";
			// 
			// colAnmeldungFlag
			// 
			this.colAnmeldungFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAnmeldungFlag.DataPropertyName = "MitAnmeldungFlag";
			this.colAnmeldungFlag.HeaderText = "Anmeldung";
			this.colAnmeldungFlag.MinimumWidth = 72;
			this.colAnmeldungFlag.Name = "colAnmeldungFlag";
			this.colAnmeldungFlag.ToolTipText = "Anmeldung erforderlich?";
			this.colAnmeldungFlag.Width = 72;
			// 
			// colKurzpreislisteFlag
			// 
			this.colKurzpreislisteFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKurzpreislisteFlag.DataPropertyName = "KurzpreislisteFlag";
			this.colKurzpreislisteFlag.HeaderText = "Kurzpreisliste";
			this.colKurzpreislisteFlag.MinimumWidth = 80;
			this.colKurzpreislisteFlag.Name = "colKurzpreislisteFlag";
			this.colKurzpreislisteFlag.ToolTipText = "Kurzpreisliste für den Termin ausdrucken?";
			this.colKurzpreislisteFlag.Width = 80;
			// 
			// colVorjahresvergleichFlag
			// 
			this.colVorjahresvergleichFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colVorjahresvergleichFlag.DataPropertyName = "VorjahresvergleichFlag";
			this.colVorjahresvergleichFlag.HeaderText = "Vorjahresvergleich";
			this.colVorjahresvergleichFlag.MinimumWidth = 105;
			this.colVorjahresvergleichFlag.Name = "colVorjahresvergleichFlag";
			this.colVorjahresvergleichFlag.ToolTipText = "Vorjahresvergleich für den Termin ausdrucken?";
			this.colVorjahresvergleichFlag.Width = 105;
			// 
			// colUmsatzSeitLetztemBesuchFlag
			// 
			this.colUmsatzSeitLetztemBesuchFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colUmsatzSeitLetztemBesuchFlag.DataPropertyName = "UmsatzSeitLetztemBesuchFlag";
			this.colUmsatzSeitLetztemBesuchFlag.HeaderText = "Umsatzliste";
			this.colUmsatzSeitLetztemBesuchFlag.MinimumWidth = 70;
			this.colUmsatzSeitLetztemBesuchFlag.Name = "colUmsatzSeitLetztemBesuchFlag";
			this.colUmsatzSeitLetztemBesuchFlag.ToolTipText = "Umsatzliste für den Termin ausdrucken?";
			this.colUmsatzSeitLetztemBesuchFlag.Width = 70;
			// 
			// colAusdruckLetztesAngebotFlag
			// 
			this.colAusdruckLetztesAngebotFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAusdruckLetztesAngebotFlag.DataPropertyName = "AusdruckLetztesAngebotFlag";
			this.colAusdruckLetztesAngebotFlag.HeaderText = "Letztes Angebot";
			this.colAusdruckLetztesAngebotFlag.MinimumWidth = 110;
			this.colAusdruckLetztesAngebotFlag.Name = "colAusdruckLetztesAngebotFlag";
			this.colAusdruckLetztesAngebotFlag.ToolTipText = "Das letzte Angebot für den Termin ausdrucken?";
			this.colAusdruckLetztesAngebotFlag.Width = 110;
			// 
			// colOhneVorbereitungFlag
			// 
			this.colOhneVorbereitungFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colOhneVorbereitungFlag.DataPropertyName = "OhneVorbereitungFlag";
			this.colOhneVorbereitungFlag.HeaderText = "Ohne Vorbereitung";
			this.colOhneVorbereitungFlag.MinimumWidth = 120;
			this.colOhneVorbereitungFlag.Name = "colOhneVorbereitungFlag";
			this.colOhneVorbereitungFlag.ToolTipText = "Kennzeichen, dass für diesen Kunden keine Vorbereitung erforderlich ist";
			this.colOhneVorbereitungFlag.Width = 120;
			// 
			// colWeihnachtsFlag
			// 
			this.colWeihnachtsFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colWeihnachtsFlag.DataPropertyName = "WeihnachtsFlag";
			this.colWeihnachtsFlag.HeaderText = "Weihnachtsbesuch";
			this.colWeihnachtsFlag.MinimumWidth = 110;
			this.colWeihnachtsFlag.Name = "colWeihnachtsFlag";
			this.colWeihnachtsFlag.ToolTipText = "Kennzeichen, dass dieser Kunde einen Weihnachtsbesuch bekommt";
			this.colWeihnachtsFlag.Width = 110;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(1191, 714);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mbtnClose.TabIndex = 1;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mtxtAnmerkungen
			// 
			this.mtxtAnmerkungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtAnmerkungen.CustomButton.Image = null;
			this.mtxtAnmerkungen.CustomButton.Location = new System.Drawing.Point(357, 1);
			this.mtxtAnmerkungen.CustomButton.Name = "";
			this.mtxtAnmerkungen.CustomButton.Size = new System.Drawing.Size(81, 81);
			this.mtxtAnmerkungen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAnmerkungen.CustomButton.TabIndex = 1;
			this.mtxtAnmerkungen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAnmerkungen.CustomButton.UseSelectable = true;
			this.mtxtAnmerkungen.CustomButton.Visible = false;
			this.mtxtAnmerkungen.Lines = new string[0];
			this.mtxtAnmerkungen.Location = new System.Drawing.Point(23, 565);
			this.mtxtAnmerkungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.mtxtAnmerkungen.MaxLength = 32767;
			this.mtxtAnmerkungen.Multiline = true;
			this.mtxtAnmerkungen.Name = "mtxtAnmerkungen";
			this.mtxtAnmerkungen.PasswordChar = '\0';
			this.mtxtAnmerkungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mtxtAnmerkungen.SelectedText = "";
			this.mtxtAnmerkungen.SelectionLength = 0;
			this.mtxtAnmerkungen.SelectionStart = 0;
			this.mtxtAnmerkungen.ShortcutsEnabled = true;
			this.mtxtAnmerkungen.Size = new System.Drawing.Size(439, 83);
			this.mtxtAnmerkungen.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mtxtAnmerkungen.TabIndex = 1;
			this.mtxtAnmerkungen.UseSelectable = true;
			this.mtxtAnmerkungen.UseStyleColors = true;
			this.mtxtAnmerkungen.WaterMark = "Generelle Informationen zu diesem Kunden";
			this.mtxtAnmerkungen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAnmerkungen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtCompetition
			// 
			// 
			// 
			// 
			this.mtxtCompetition.CustomButton.Image = null;
			this.mtxtCompetition.CustomButton.Location = new System.Drawing.Point(290, 1);
			this.mtxtCompetition.CustomButton.Name = "";
			this.mtxtCompetition.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtCompetition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtCompetition.CustomButton.TabIndex = 1;
			this.mtxtCompetition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtCompetition.CustomButton.UseSelectable = true;
			this.mtxtCompetition.CustomButton.Visible = false;
			this.mtxtCompetition.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtCompetition.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtCompetition.Lines = new string[0];
			this.mtxtCompetition.Location = new System.Drawing.Point(23, 671);
			this.mtxtCompetition.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtCompetition.MaxLength = 500;
			this.mtxtCompetition.Name = "mtxtCompetition";
			this.mtxtCompetition.PasswordChar = '\0';
			this.mtxtCompetition.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtCompetition.SelectedText = "";
			this.mtxtCompetition.SelectionLength = 0;
			this.mtxtCompetition.SelectionStart = 0;
			this.mtxtCompetition.ShortcutsEnabled = true;
			this.mtxtCompetition.Size = new System.Drawing.Size(312, 23);
			this.mtxtCompetition.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mtxtCompetition.TabIndex = 3;
			this.mtxtCompetition.UseSelectable = true;
			this.mtxtCompetition.WaterMark = "Wettbewerber";
			this.mtxtCompetition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtCompetition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// TourkundenDetailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 763);
			this.Controls.Add(this.mtxtCompetition);
			this.Controls.Add(this.mtxtAnmerkungen);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvTourkunden);
			this.Name = "TourkundenDetailView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Kundendetails";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TourkundenDetailView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvTourkunden)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTourkunden;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroTextBox mtxtAnmerkungen;
		private MetroFramework.Controls.MetroTextBox mtxtCompetition;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFirmenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLetzterBesuchstermin;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBesuchsintervall;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBesuchszeit;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colAnmeldungFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colKurzpreislisteFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colVorjahresvergleichFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colUmsatzSeitLetztemBesuchFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colAusdruckLetztesAngebotFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colOhneVorbereitungFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colWeihnachtsFlag;
	}
}