namespace Products.Common.Panel
{
	partial class pnlKundeStart
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlKundeStart));
			this.mlblHauptkontakt = new MetroFramework.Controls.MetroLabel();
			this.mlblPlzOrt = new MetroFramework.Controls.MetroLabel();
			this.mlblStrasse = new MetroFramework.Controls.MetroLabel();
			this.mlnkEmail = new MetroFramework.Controls.MetroLink();
			this.mlnkTelefon = new MetroFramework.Controls.MetroLink();
			this.mlblKundennummer = new MetroFramework.Controls.MetroLabel();
			this.dgvTop10b = new MetroFramework.Controls.MetroGrid();
			this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatumZuletzt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUmsatz = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mtileKalender = new MetroFramework.Controls.MetroTile();
			this.mtileNotizen = new MetroFramework.Controls.MetroTile();
			this.mtileUPS = new MetroFramework.Controls.MetroTile();
			this.mtileServicetermine = new MetroFramework.Controls.MetroTile();
			this.mtileSoftware = new MetroFramework.Controls.MetroTile();
			this.mtileMaschinen = new MetroFramework.Controls.MetroTile();
			this.mtileKontakte = new MetroFramework.Controls.MetroTile();
			this.mtileArtikel = new MetroFramework.Controls.MetroTile();
			this.mtileFinanzen = new MetroFramework.Controls.MetroTile();
			this.mtileAngebote = new MetroFramework.Controls.MetroTile();
			this.mtileAuftraege = new MetroFramework.Controls.MetroTile();
			this.mlblFrachtfreigrenze = new MetroFramework.Controls.MetroLabel();
			this.mTileClose = new MetroFramework.Controls.MetroTile();
			this.mlblInactive = new MetroFramework.Controls.MetroLabel();
			this.mlblEntfernung = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvTop10b)).BeginInit();
			this.SuspendLayout();
			// 
			// mlblHauptkontakt
			// 
			this.mlblHauptkontakt.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblHauptkontakt.Location = new System.Drawing.Point(698, 188);
			this.mlblHauptkontakt.Name = "mlblHauptkontakt";
			this.mlblHauptkontakt.Size = new System.Drawing.Size(533, 25);
			this.mlblHauptkontakt.TabIndex = 14;
			this.mlblHauptkontakt.Text = "Hauptkontakt";
			// 
			// mlblPlzOrt
			// 
			this.mlblPlzOrt.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblPlzOrt.Location = new System.Drawing.Point(698, 122);
			this.mlblPlzOrt.Name = "mlblPlzOrt";
			this.mlblPlzOrt.Size = new System.Drawing.Size(533, 25);
			this.mlblPlzOrt.TabIndex = 11;
			this.mlblPlzOrt.Text = "PLZ Ort";
			// 
			// mlblStrasse
			// 
			this.mlblStrasse.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblStrasse.Location = new System.Drawing.Point(698, 97);
			this.mlblStrasse.Name = "mlblStrasse";
			this.mlblStrasse.Size = new System.Drawing.Size(533, 25);
			this.mlblStrasse.TabIndex = 10;
			this.mlblStrasse.Text = "Straße";
			// 
			// mlnkEmail
			// 
			this.mlnkEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mlnkEmail.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.mlnkEmail.FontWeight = MetroFramework.MetroLinkWeight.Light;
			this.mlnkEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkEmail.Location = new System.Drawing.Point(698, 235);
			this.mlnkEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.mlnkEmail.Name = "mlnkEmail";
			this.mlnkEmail.Size = new System.Drawing.Size(533, 23);
			this.mlnkEmail.TabIndex = 16;
			this.mlnkEmail.Text = "E-Mail";
			this.mlnkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkEmail.UseSelectable = true;
			this.mlnkEmail.Click += new System.EventHandler(this.mlnkEmail_Click);
			// 
			// mlnkTelefon
			// 
			this.mlnkTelefon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mlnkTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.mlnkTelefon.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.mlnkTelefon.FontWeight = MetroFramework.MetroLinkWeight.Light;
			this.mlnkTelefon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkTelefon.Location = new System.Drawing.Point(698, 213);
			this.mlnkTelefon.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.mlnkTelefon.Name = "mlnkTelefon";
			this.mlnkTelefon.Size = new System.Drawing.Size(533, 23);
			this.mlnkTelefon.TabIndex = 15;
			this.mlnkTelefon.Text = "Telefon";
			this.mlnkTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkTelefon.UseSelectable = true;
			this.mlnkTelefon.Click += new System.EventHandler(this.mlnkTelefon_Click);
			// 
			// mlblKundennummer
			// 
			this.mlblKundennummer.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblKundennummer.ForeColor = System.Drawing.Color.DarkGreen;
			this.mlblKundennummer.Location = new System.Drawing.Point(698, 38);
			this.mlblKundennummer.Name = "mlblKundennummer";
			this.mlblKundennummer.Size = new System.Drawing.Size(533, 25);
			this.mlblKundennummer.TabIndex = 18;
			this.mlblKundennummer.Text = "Kunden-Nr. - Firma";
			this.mlblKundennummer.UseCustomForeColor = true;
			// 
			// dgvTop10b
			// 
			this.dgvTop10b.AllowUserToAddRows = false;
			this.dgvTop10b.AllowUserToDeleteRows = false;
			this.dgvTop10b.AllowUserToResizeRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
			this.dgvTop10b.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvTop10b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTop10b.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvTop10b.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTop10b.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTop10b.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(255, 0, ((int)(((byte)(148)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(255, ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTop10b.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvTop10b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTop10b.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikel,
            this.colBezeichnung1,
            this.colDatumZuletzt,
            this.colUmsatz,
            this.colAnzahl});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(255, ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTop10b.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvTop10b.EnableHeadersVisualStyles = false;
			this.dgvTop10b.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTop10b.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvTop10b.HighLightPercentage = 0.9F;
			this.dgvTop10b.Location = new System.Drawing.Point(698, 310);
			this.dgvTop10b.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
			this.dgvTop10b.Name = "dgvTop10b";
			this.dgvTop10b.ReadOnly = true;
			this.dgvTop10b.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(255, 0, ((int)(((byte)(148)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(255, ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTop10b.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvTop10b.RowHeadersVisible = false;
			this.dgvTop10b.RowHeadersWidth = 21;
			this.dgvTop10b.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTop10b.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTop10b.Size = new System.Drawing.Size(533, 268);
			this.dgvTop10b.Style = MetroFramework.MetroColorStyle.Magenta;
			this.dgvTop10b.TabIndex = 22;
			this.dgvTop10b.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTop10b_RowEnter);
			this.dgvTop10b.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTop10b_MouseDoubleClick);
			// 
			// colArtikel
			// 
			this.colArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikel.DataPropertyName = "Artikel";
			this.colArtikel.FillWeight = 15F;
			this.colArtikel.HeaderText = "Art.-Nr.";
			this.colArtikel.Name = "colArtikel";
			this.colArtikel.ReadOnly = true;
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 35F;
			this.colBezeichnung1.HeaderText = "Bezeichnung";
			this.colBezeichnung1.Name = "colBezeichnung1";
			this.colBezeichnung1.ReadOnly = true;
			// 
			// colDatumZuletzt
			// 
			this.colDatumZuletzt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatumZuletzt.DataPropertyName = "Datum";
			dataGridViewCellStyle9.Format = "d";
			dataGridViewCellStyle9.NullValue = null;
			this.colDatumZuletzt.DefaultCellStyle = dataGridViewCellStyle9;
			this.colDatumZuletzt.FillWeight = 15F;
			this.colDatumZuletzt.HeaderText = "Zuletzt am";
			this.colDatumZuletzt.Name = "colDatumZuletzt";
			this.colDatumZuletzt.ReadOnly = true;
			// 
			// colUmsatz
			// 
			this.colUmsatz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colUmsatz.DataPropertyName = "Umsatz";
			dataGridViewCellStyle10.Format = "N2";
			dataGridViewCellStyle10.NullValue = null;
			this.colUmsatz.DefaultCellStyle = dataGridViewCellStyle10;
			this.colUmsatz.FillWeight = 15F;
			this.colUmsatz.HeaderText = "Umsatz";
			this.colUmsatz.Name = "colUmsatz";
			this.colUmsatz.ReadOnly = true;
			// 
			// colAnzahl
			// 
			this.colAnzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAnzahl.DataPropertyName = "Anzahl";
			this.colAnzahl.FillWeight = 10F;
			this.colAnzahl.HeaderText = "Anzahl";
			this.colAnzahl.Name = "colAnzahl";
			this.colAnzahl.ReadOnly = true;
			// 
			// mtileKalender
			// 
			this.mtileKalender.ActiveControl = null;
			this.mtileKalender.Location = new System.Drawing.Point(410, 478);
			this.mtileKalender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileKalender.Name = "mtileKalender";
			this.mtileKalender.Size = new System.Drawing.Size(100, 100);
			this.mtileKalender.Style = MetroFramework.MetroColorStyle.Red;
			this.mtileKalender.TabIndex = 10;
			this.mtileKalender.Text = "Kalender";
			this.mtileKalender.TileImage = global::Products.Common.Properties.Resources.calendar_48_metrowhite;
			this.mtileKalender.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileKalender.UseSelectable = true;
			this.mtileKalender.UseTileImage = true;
			this.mtileKalender.Click += new System.EventHandler(this.mtileKalender_Click);
			// 
			// mtileNotizen
			// 
			this.mtileNotizen.ActiveControl = null;
			this.mtileNotizen.Location = new System.Drawing.Point(518, 368);
			this.mtileNotizen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileNotizen.Name = "mtileNotizen";
			this.mtileNotizen.Size = new System.Drawing.Size(100, 100);
			this.mtileNotizen.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtileNotizen.TabIndex = 9;
			this.mtileNotizen.Text = "Notizen";
			this.mtileNotizen.TileImage = global::Products.Common.Properties.Resources.notes_48_metrowhite;
			this.mtileNotizen.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileNotizen.UseSelectable = true;
			this.mtileNotizen.UseTileImage = true;
			this.mtileNotizen.Click += new System.EventHandler(this.mtileNotizen_Click);
			// 
			// mtileUPS
			// 
			this.mtileUPS.ActiveControl = null;
			this.mtileUPS.Location = new System.Drawing.Point(410, 368);
			this.mtileUPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileUPS.Name = "mtileUPS";
			this.mtileUPS.Size = new System.Drawing.Size(100, 100);
			this.mtileUPS.Style = MetroFramework.MetroColorStyle.Silver;
			this.mtileUPS.TabIndex = 8;
			this.mtileUPS.Text = "Tracking";
			this.mtileUPS.TileImage = ((System.Drawing.Image)(resources.GetObject("mtileUPS.TileImage")));
			this.mtileUPS.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileUPS.UseSelectable = true;
			this.mtileUPS.UseTileImage = true;
			this.mtileUPS.Click += new System.EventHandler(this.mtileUPS_Click);
			// 
			// mtileServicetermine
			// 
			this.mtileServicetermine.ActiveControl = null;
			this.mtileServicetermine.Location = new System.Drawing.Point(410, 148);
			this.mtileServicetermine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileServicetermine.Name = "mtileServicetermine";
			this.mtileServicetermine.Size = new System.Drawing.Size(208, 100);
			this.mtileServicetermine.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtileServicetermine.TabIndex = 6;
			this.mtileServicetermine.Text = "Terminliste";
			this.mtileServicetermine.TileImage = global::Products.Common.Properties.Resources.service_48_metrogray;
			this.mtileServicetermine.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileServicetermine.UseSelectable = true;
			this.mtileServicetermine.UseTileImage = true;
			this.mtileServicetermine.Click += new System.EventHandler(this.mtileServicetermine_Click);
			// 
			// mtileSoftware
			// 
			this.mtileSoftware.ActiveControl = null;
			this.mtileSoftware.Location = new System.Drawing.Point(410, 258);
			this.mtileSoftware.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileSoftware.Name = "mtileSoftware";
			this.mtileSoftware.Size = new System.Drawing.Size(208, 100);
			this.mtileSoftware.Style = MetroFramework.MetroColorStyle.Purple;
			this.mtileSoftware.TabIndex = 7;
			this.mtileSoftware.Text = "Software";
			this.mtileSoftware.TileImage = global::Products.Common.Properties.Resources.software_48_metrowhite;
			this.mtileSoftware.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileSoftware.UseSelectable = true;
			this.mtileSoftware.UseTileImage = true;
			this.mtileSoftware.Click += new System.EventHandler(this.mtileSoftware_Click);
			// 
			// mtileMaschinen
			// 
			this.mtileMaschinen.ActiveControl = null;
			this.mtileMaschinen.Location = new System.Drawing.Point(410, 38);
			this.mtileMaschinen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileMaschinen.Name = "mtileMaschinen";
			this.mtileMaschinen.Size = new System.Drawing.Size(208, 100);
			this.mtileMaschinen.TabIndex = 5;
			this.mtileMaschinen.Text = "Maschinen";
			this.mtileMaschinen.TileImage = global::Products.Common.Properties.Resources.maschine_metrowhite;
			this.mtileMaschinen.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileMaschinen.UseSelectable = true;
			this.mtileMaschinen.UseTileImage = true;
			this.mtileMaschinen.Click += new System.EventHandler(this.mtileMaschinen_Click);
			// 
			// mtileKontakte
			// 
			this.mtileKontakte.ActiveControl = null;
			this.mtileKontakte.Location = new System.Drawing.Point(194, 148);
			this.mtileKontakte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileKontakte.Name = "mtileKontakte";
			this.mtileKontakte.Size = new System.Drawing.Size(208, 100);
			this.mtileKontakte.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mtileKontakte.TabIndex = 1;
			this.mtileKontakte.Text = "Kontakte";
			this.mtileKontakte.TileImage = global::Products.Common.Properties.Resources.kontakte_48_metrogray;
			this.mtileKontakte.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileKontakte.UseSelectable = true;
			this.mtileKontakte.UseTileImage = true;
			this.mtileKontakte.Click += new System.EventHandler(this.mtileKontakte_Click);
			// 
			// mtileArtikel
			// 
			this.mtileArtikel.ActiveControl = null;
			this.mtileArtikel.Location = new System.Drawing.Point(194, 38);
			this.mtileArtikel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileArtikel.Name = "mtileArtikel";
			this.mtileArtikel.Size = new System.Drawing.Size(208, 100);
			this.mtileArtikel.Style = MetroFramework.MetroColorStyle.Red;
			this.mtileArtikel.TabIndex = 0;
			this.mtileArtikel.Text = "Artikelpreise";
			this.mtileArtikel.TileImage = global::Products.Common.Properties.Resources.artikel_48_metrowhite;
			this.mtileArtikel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileArtikel.UseSelectable = true;
			this.mtileArtikel.UseTileImage = true;
			this.mtileArtikel.Click += new System.EventHandler(this.mtileArtikel_Click);
			// 
			// mtileFinanzen
			// 
			this.mtileFinanzen.ActiveControl = null;
			this.mtileFinanzen.Location = new System.Drawing.Point(194, 478);
			this.mtileFinanzen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileFinanzen.Name = "mtileFinanzen";
			this.mtileFinanzen.Size = new System.Drawing.Size(208, 100);
			this.mtileFinanzen.Style = MetroFramework.MetroColorStyle.Pink;
			this.mtileFinanzen.TabIndex = 4;
			this.mtileFinanzen.Text = "Finanzen";
			this.mtileFinanzen.TileImage = global::Products.Common.Properties.Resources.Euro_metrowhite;
			this.mtileFinanzen.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileFinanzen.UseSelectable = true;
			this.mtileFinanzen.UseTileImage = true;
			this.mtileFinanzen.Click += new System.EventHandler(this.mtileFinanzen_Click);
			// 
			// mtileAngebote
			// 
			this.mtileAngebote.ActiveControl = null;
			this.mtileAngebote.BackColor = System.Drawing.SystemColors.Control;
			this.mtileAngebote.Location = new System.Drawing.Point(194, 368);
			this.mtileAngebote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileAngebote.Name = "mtileAngebote";
			this.mtileAngebote.Size = new System.Drawing.Size(208, 100);
			this.mtileAngebote.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtileAngebote.TabIndex = 3;
			this.mtileAngebote.Text = "Angebote";
			this.mtileAngebote.TileImage = global::Products.Common.Properties.Resources.angebot_48_metrogray1;
			this.mtileAngebote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileAngebote.UseSelectable = true;
			this.mtileAngebote.UseTileImage = true;
			this.mtileAngebote.Click += new System.EventHandler(this.mtileAngebote_Click);
			// 
			// mtileAuftraege
			// 
			this.mtileAuftraege.ActiveControl = null;
			this.mtileAuftraege.Location = new System.Drawing.Point(194, 258);
			this.mtileAuftraege.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mtileAuftraege.Name = "mtileAuftraege";
			this.mtileAuftraege.Size = new System.Drawing.Size(208, 100);
			this.mtileAuftraege.Style = MetroFramework.MetroColorStyle.Green;
			this.mtileAuftraege.TabIndex = 2;
			this.mtileAuftraege.Text = "Aufträge";
			this.mtileAuftraege.TileImage = global::Products.Common.Properties.Resources.auftrag_48_metrowhite;
			this.mtileAuftraege.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtileAuftraege.UseSelectable = true;
			this.mtileAuftraege.UseTileImage = true;
			this.mtileAuftraege.Click += new System.EventHandler(this.mtileAuftraege_Click);
			// 
			// mlblFrachtfreigrenze
			// 
			this.mlblFrachtfreigrenze.AutoSize = true;
			this.mlblFrachtfreigrenze.Location = new System.Drawing.Point(698, 269);
			this.mlblFrachtfreigrenze.Name = "mlblFrachtfreigrenze";
			this.mlblFrachtfreigrenze.Size = new System.Drawing.Size(83, 19);
			this.mlblFrachtfreigrenze.TabIndex = 23;
			this.mlblFrachtfreigrenze.Text = "Frachtfrei ab";
			// 
			// mTileClose
			// 
			this.mTileClose.ActiveControl = null;
			this.mTileClose.Location = new System.Drawing.Point(518, 478);
			this.mTileClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mTileClose.Name = "mTileClose";
			this.mTileClose.Size = new System.Drawing.Size(100, 100);
			this.mTileClose.Style = MetroFramework.MetroColorStyle.Silver;
			this.mTileClose.TabIndex = 24;
			this.mTileClose.Text = "Schließen";
			this.mTileClose.TileImage = global::Products.Common.Properties.Resources.poweroff_48_metrowhite;
			this.mTileClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mTileClose.UseSelectable = true;
			this.mTileClose.UseTileImage = true;
			this.mTileClose.Click += new System.EventHandler(this.mTileClose_Click);
			// 
			// mlblInactive
			// 
			this.mlblInactive.AutoSize = true;
			this.mlblInactive.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.mlblInactive.ForeColor = System.Drawing.Color.Green;
			this.mlblInactive.Location = new System.Drawing.Point(700, 68);
			this.mlblInactive.Name = "mlblInactive";
			this.mlblInactive.Size = new System.Drawing.Size(107, 19);
			this.mlblInactive.TabIndex = 25;
			this.mlblInactive.Text = "Kunde ist aktiv";
			this.mlblInactive.UseCustomForeColor = true;
			// 
			// mlblEntfernung
			// 
			this.mlblEntfernung.Location = new System.Drawing.Point(700, 152);
			this.mlblEntfernung.Name = "mlblEntfernung";
			this.mlblEntfernung.Size = new System.Drawing.Size(531, 25);
			this.mlblEntfernung.TabIndex = 26;
			this.mlblEntfernung.Text = "Entfernung";
			// 
			// pnlKundeStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.mlblEntfernung);
			this.Controls.Add(this.mlblInactive);
			this.Controls.Add(this.mTileClose);
			this.Controls.Add(this.mlblFrachtfreigrenze);
			this.Controls.Add(this.dgvTop10b);
			this.Controls.Add(this.mlblKundennummer);
			this.Controls.Add(this.mtileKalender);
			this.Controls.Add(this.mlnkEmail);
			this.Controls.Add(this.mlnkTelefon);
			this.Controls.Add(this.mlblHauptkontakt);
			this.Controls.Add(this.mlblPlzOrt);
			this.Controls.Add(this.mlblStrasse);
			this.Controls.Add(this.mtileNotizen);
			this.Controls.Add(this.mtileUPS);
			this.Controls.Add(this.mtileServicetermine);
			this.Controls.Add(this.mtileSoftware);
			this.Controls.Add(this.mtileMaschinen);
			this.Controls.Add(this.mtileKontakte);
			this.Controls.Add(this.mtileArtikel);
			this.Controls.Add(this.mtileFinanzen);
			this.Controls.Add(this.mtileAngebote);
			this.Controls.Add(this.mtileAuftraege);
			this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.Name = "pnlKundeStart";
			this.Padding = new System.Windows.Forms.Padding(30, 33, 30, 33);
			this.Size = new System.Drawing.Size(1264, 723);
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			((System.ComponentModel.ISupportInitialize)(this.dgvTop10b)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroFramework.Controls.MetroTile mtileAuftraege;
		MetroFramework.Controls.MetroTile mtileAngebote;
		MetroFramework.Controls.MetroTile mtileFinanzen;
		MetroFramework.Controls.MetroTile mtileArtikel;
		MetroFramework.Controls.MetroTile mtileKontakte;
		MetroFramework.Controls.MetroTile mtileMaschinen;
		MetroFramework.Controls.MetroTile mtileSoftware;
		MetroFramework.Controls.MetroTile mtileServicetermine;
		MetroFramework.Controls.MetroTile mtileUPS;
		MetroFramework.Controls.MetroTile mtileNotizen;
		MetroFramework.Controls.MetroLabel mlblStrasse;
		MetroFramework.Controls.MetroLabel mlblPlzOrt;
		MetroFramework.Controls.MetroLabel mlblHauptkontakt;
		MetroFramework.Controls.MetroLink mlnkTelefon;
		MetroFramework.Controls.MetroLink mlnkEmail;
		MetroFramework.Controls.MetroTile mtileKalender;
		MetroFramework.Controls.MetroLabel mlblKundennummer;
		MetroFramework.Controls.MetroGrid dgvTop10b;
		System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
		System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		System.Windows.Forms.DataGridViewTextBoxColumn colDatumZuletzt;
		System.Windows.Forms.DataGridViewTextBoxColumn colUmsatz;
		System.Windows.Forms.DataGridViewTextBoxColumn colAnzahl;
		MetroFramework.Controls.MetroLabel mlblFrachtfreigrenze;
		MetroFramework.Controls.MetroTile mTileClose;
		private MetroFramework.Controls.MetroLabel mlblInactive;
		private MetroFramework.Controls.MetroLabel mlblEntfernung;
	}
}