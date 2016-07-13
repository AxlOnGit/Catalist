namespace Products.Common.Views
{
	partial class BestellungListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellungListView));
			this.dgvBestellungen = new MetroFramework.Controls.MetroGrid();
			this.colNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSummeUSt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBruttosumme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvDetails = new MetroFramework.Controls.MetroGrid();
			this.colArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBestellwert = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLieferdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mlblBestellungen = new MetroFramework.Controls.MetroLabel();
			this.mlblLieferungen = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.dgvLieferungen = new MetroFramework.Controls.MetroGrid();
			this.colNummer_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSumme_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBruttosumme_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvRechnungen = new MetroFramework.Controls.MetroGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.dgvNotes = new MetroFramework.Controls.MetroGrid();
			this.colDatum_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xmnuNotes = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdShowNote = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdAddNote = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdDeleteNote = new System.Windows.Forms.ToolStripMenuItem();
			this.mlblNotes = new MetroFramework.Controls.MetroLabel();
			this.btnDeleteNote = new System.Windows.Forms.Button();
			this.btnOpenNote = new System.Windows.Forms.Button();
			this.btnAddNotiz = new System.Windows.Forms.Button();
			this.dgvFileLinks = new MetroFramework.Controls.MetroGrid();
			this.colFileTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLieferungen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRechnungen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
			this.xmnuNotes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFileLinks)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBestellungen
			// 
			this.dgvBestellungen.AllowUserToAddRows = false;
			this.dgvBestellungen.AllowUserToDeleteRows = false;
			this.dgvBestellungen.AllowUserToResizeRows = false;
			this.dgvBestellungen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvBestellungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvBestellungen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvBestellungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBestellungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBestellungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNummer,
            this.colDatum,
            this.colSummeUSt_1,
            this.colBruttosumme});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvBestellungen.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvBestellungen.EnableHeadersVisualStyles = false;
			this.dgvBestellungen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvBestellungen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvBestellungen.HighLightPercentage = 1.2F;
			this.dgvBestellungen.Location = new System.Drawing.Point(23, 177);
			this.dgvBestellungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.dgvBestellungen.Name = "dgvBestellungen";
			this.dgvBestellungen.ReadOnly = true;
			this.dgvBestellungen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBestellungen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvBestellungen.RowHeadersVisible = false;
			this.dgvBestellungen.RowHeadersWidth = 21;
			this.dgvBestellungen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvBestellungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBestellungen.Size = new System.Drawing.Size(345, 213);
			this.dgvBestellungen.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvBestellungen.TabIndex = 1;
			this.dgvBestellungen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBestellungen_RowEnter);
			// 
			// colNummer
			// 
			this.colNummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNummer.DataPropertyName = "Nummer";
			this.colNummer.FillWeight = 25F;
			this.colNummer.HeaderText = "Bestellung";
			this.colNummer.Name = "colNummer";
			this.colNummer.ReadOnly = true;
			// 
			// colDatum
			// 
			this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum.DataPropertyName = "Datum";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colDatum.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDatum.FillWeight = 25F;
			this.colDatum.HeaderText = "Datum";
			this.colDatum.Name = "colDatum";
			this.colDatum.ReadOnly = true;
			// 
			// colSummeUSt_1
			// 
			this.colSummeUSt_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSummeUSt_1.DataPropertyName = "SummeUSt_1";
			this.colSummeUSt_1.FillWeight = 25F;
			this.colSummeUSt_1.HeaderText = "Netto";
			this.colSummeUSt_1.Name = "colSummeUSt_1";
			this.colSummeUSt_1.ReadOnly = true;
			// 
			// colBruttosumme
			// 
			this.colBruttosumme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBruttosumme.DataPropertyName = "Bruttosumme";
			this.colBruttosumme.FillWeight = 25F;
			this.colBruttosumme.HeaderText = "Brutto";
			this.colBruttosumme.Name = "colBruttosumme";
			this.colBruttosumme.ReadOnly = true;
			// 
			// dgvDetails
			// 
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikelnummer,
            this.colArtikelname,
            this.colMenge,
            this.colMengeneinheit,
            this.colBestellwert,
            this.colLieferdatum});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.HighLightPercentage = 1.2F;
			this.dgvDetails.Location = new System.Drawing.Point(23, 438);
			this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 21;
			this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(745, 275);
			this.dgvDetails.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvDetails.TabIndex = 4;
			// 
			// colArtikelnummer
			// 
			this.colArtikelnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelnummer.DataPropertyName = "Artikelnummer";
			this.colArtikelnummer.FillWeight = 20F;
			this.colArtikelnummer.HeaderText = "Art.-Nr.";
			this.colArtikelnummer.Name = "colArtikelnummer";
			this.colArtikelnummer.ReadOnly = true;
			// 
			// colArtikelname
			// 
			this.colArtikelname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelname.DataPropertyName = "Artikelbezeichnung";
			this.colArtikelname.FillWeight = 35F;
			this.colArtikelname.HeaderText = "Artikelbezeichnung";
			this.colArtikelname.Name = "colArtikelname";
			this.colArtikelname.ReadOnly = true;
			// 
			// colMenge
			// 
			this.colMenge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMenge.DataPropertyName = "Menge";
			dataGridViewCellStyle6.Format = "N0";
			dataGridViewCellStyle6.NullValue = null;
			this.colMenge.DefaultCellStyle = dataGridViewCellStyle6;
			this.colMenge.FillWeight = 11F;
			this.colMenge.HeaderText = "Menge";
			this.colMenge.Name = "colMenge";
			this.colMenge.ReadOnly = true;
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.FillWeight = 11F;
			this.colMengeneinheit.HeaderText = "Einheit";
			this.colMengeneinheit.Name = "colMengeneinheit";
			this.colMengeneinheit.ReadOnly = true;
			// 
			// colBestellwert
			// 
			this.colBestellwert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBestellwert.DataPropertyName = "Bestellwert";
			dataGridViewCellStyle7.Format = "C2";
			dataGridViewCellStyle7.NullValue = null;
			this.colBestellwert.DefaultCellStyle = dataGridViewCellStyle7;
			this.colBestellwert.FillWeight = 13F;
			this.colBestellwert.HeaderText = "Summe";
			this.colBestellwert.Name = "colBestellwert";
			this.colBestellwert.ReadOnly = true;
			// 
			// colLieferdatum
			// 
			this.colLieferdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLieferdatum.DataPropertyName = "Lieferdatum";
			this.colLieferdatum.FillWeight = 10F;
			this.colLieferdatum.HeaderText = "Lieferdatum";
			this.colLieferdatum.Name = "colLieferdatum";
			this.colLieferdatum.ReadOnly = true;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1300, 736);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Silver;
			this.mbtnClose.TabIndex = 7;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mlblBestellungen
			// 
			this.mlblBestellungen.AutoSize = true;
			this.mlblBestellungen.FontSize = MetroFramework.MetroLabelSize.Small;
			this.mlblBestellungen.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.mlblBestellungen.Location = new System.Drawing.Point(23, 156);
			this.mlblBestellungen.Name = "mlblBestellungen";
			this.mlblBestellungen.Size = new System.Drawing.Size(80, 15);
			this.mlblBestellungen.TabIndex = 15;
			this.mlblBestellungen.Text = "Bestellungen";
			// 
			// mlblLieferungen
			// 
			this.mlblLieferungen.AutoSize = true;
			this.mlblLieferungen.FontSize = MetroFramework.MetroLabelSize.Small;
			this.mlblLieferungen.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.mlblLieferungen.Location = new System.Drawing.Point(421, 159);
			this.mlblLieferungen.Name = "mlblLieferungen";
			this.mlblLieferungen.Size = new System.Drawing.Size(75, 15);
			this.mlblLieferungen.TabIndex = 16;
			this.mlblLieferungen.Text = "Lieferungen";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(23, 420);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(65, 15);
			this.metroLabel1.TabIndex = 17;
			this.metroLabel1.Text = "Positionen";
			// 
			// dgvLieferungen
			// 
			this.dgvLieferungen.AllowUserToAddRows = false;
			this.dgvLieferungen.AllowUserToDeleteRows = false;
			this.dgvLieferungen.AllowUserToResizeRows = false;
			this.dgvLieferungen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvLieferungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvLieferungen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvLieferungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLieferungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvLieferungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLieferungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNummer_l,
            this.colDatum_l,
            this.colSumme_l,
            this.colBruttosumme_l});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLieferungen.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvLieferungen.EnableHeadersVisualStyles = false;
			this.dgvLieferungen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvLieferungen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvLieferungen.HighLightPercentage = 1.2F;
			this.dgvLieferungen.Location = new System.Drawing.Point(421, 177);
			this.dgvLieferungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.dgvLieferungen.Name = "dgvLieferungen";
			this.dgvLieferungen.ReadOnly = true;
			this.dgvLieferungen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLieferungen.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvLieferungen.RowHeadersVisible = false;
			this.dgvLieferungen.RowHeadersWidth = 21;
			this.dgvLieferungen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvLieferungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLieferungen.Size = new System.Drawing.Size(345, 90);
			this.dgvLieferungen.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvLieferungen.TabIndex = 2;
			this.dgvLieferungen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLieferungen_RowEnter);
			// 
			// colNummer_l
			// 
			this.colNummer_l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNummer_l.DataPropertyName = "Nummer";
			this.colNummer_l.FillWeight = 25F;
			this.colNummer_l.HeaderText = "Lieferung";
			this.colNummer_l.Name = "colNummer_l";
			this.colNummer_l.ReadOnly = true;
			// 
			// colDatum_l
			// 
			this.colDatum_l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum_l.DataPropertyName = "Datum";
			this.colDatum_l.FillWeight = 25F;
			this.colDatum_l.HeaderText = "Datum";
			this.colDatum_l.Name = "colDatum_l";
			this.colDatum_l.ReadOnly = true;
			// 
			// colSumme_l
			// 
			this.colSumme_l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSumme_l.DataPropertyName = "SummeUSt_1";
			this.colSumme_l.FillWeight = 25F;
			this.colSumme_l.HeaderText = "Netto";
			this.colSumme_l.Name = "colSumme_l";
			this.colSumme_l.ReadOnly = true;
			// 
			// colBruttosumme_l
			// 
			this.colBruttosumme_l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBruttosumme_l.DataPropertyName = "Bruttosumme";
			this.colBruttosumme_l.FillWeight = 25F;
			this.colBruttosumme_l.HeaderText = "Brutto";
			this.colBruttosumme_l.Name = "colBruttosumme_l";
			this.colBruttosumme_l.ReadOnly = true;
			// 
			// dgvRechnungen
			// 
			this.dgvRechnungen.AllowUserToAddRows = false;
			this.dgvRechnungen.AllowUserToDeleteRows = false;
			this.dgvRechnungen.AllowUserToResizeRows = false;
			this.dgvRechnungen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvRechnungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRechnungen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvRechnungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRechnungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvRechnungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRechnungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvRechnungen.DefaultCellStyle = dataGridViewCellStyle14;
			this.dgvRechnungen.EnableHeadersVisualStyles = false;
			this.dgvRechnungen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvRechnungen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvRechnungen.HighLightPercentage = 1.2F;
			this.dgvRechnungen.Location = new System.Drawing.Point(423, 315);
			this.dgvRechnungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.dgvRechnungen.Name = "dgvRechnungen";
			this.dgvRechnungen.ReadOnly = true;
			this.dgvRechnungen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRechnungen.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvRechnungen.RowHeadersVisible = false;
			this.dgvRechnungen.RowHeadersWidth = 21;
			this.dgvRechnungen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvRechnungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRechnungen.Size = new System.Drawing.Size(345, 90);
			this.dgvRechnungen.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvRechnungen.TabIndex = 3;
			this.dgvRechnungen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRechnungen_RowEnter);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Nummer";
			this.dataGridViewTextBoxColumn1.FillWeight = 25F;
			this.dataGridViewTextBoxColumn1.HeaderText = "Rechnung";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
			this.dataGridViewTextBoxColumn2.FillWeight = 25F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "SummeUSt_1";
			this.dataGridViewTextBoxColumn3.FillWeight = 25F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Netto";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Bruttosumme";
			this.dataGridViewTextBoxColumn4.FillWeight = 25F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Brutto";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.Location = new System.Drawing.Point(421, 297);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(77, 15);
			this.metroLabel2.TabIndex = 19;
			this.metroLabel2.Text = "Rechnungen";
			// 
			// dgvNotes
			// 
			this.dgvNotes.AllowUserToAddRows = false;
			this.dgvNotes.AllowUserToDeleteRows = false;
			this.dgvNotes.AllowUserToResizeRows = false;
			this.dgvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDatum_n,
            this.colSubject,
            this.colBody});
			this.dgvNotes.ContextMenuStrip = this.xmnuNotes;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvNotes.EnableHeadersVisualStyles = false;
			this.dgvNotes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvNotes.HighLightPercentage = 1.2F;
			this.dgvNotes.Location = new System.Drawing.Point(816, 177);
			this.dgvNotes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.dgvNotes.Name = "dgvNotes";
			this.dgvNotes.ReadOnly = true;
			this.dgvNotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvNotes.RowHeadersVisible = false;
			this.dgvNotes.RowHeadersWidth = 21;
			this.dgvNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNotes.Size = new System.Drawing.Size(584, 213);
			this.dgvNotes.Style = MetroFramework.MetroColorStyle.Teal;
			this.dgvNotes.TabIndex = 5;
			this.dgvNotes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_RowEnter);
			this.dgvNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotes_MouseDoubleClick);
			// 
			// colDatum_n
			// 
			this.colDatum_n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum_n.DataPropertyName = "AssignedAt";
			dataGridViewCellStyle17.Format = "d";
			dataGridViewCellStyle17.NullValue = null;
			this.colDatum_n.DefaultCellStyle = dataGridViewCellStyle17;
			this.colDatum_n.FillWeight = 13F;
			this.colDatum_n.HeaderText = "Datum";
			this.colDatum_n.Name = "colDatum_n";
			this.colDatum_n.ReadOnly = true;
			// 
			// colSubject
			// 
			this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.DataPropertyName = "Subject";
			this.colSubject.FillWeight = 35F;
			this.colSubject.HeaderText = "Thema";
			this.colSubject.Name = "colSubject";
			this.colSubject.ReadOnly = true;
			// 
			// colBody
			// 
			this.colBody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBody.DataPropertyName = "Body";
			this.colBody.FillWeight = 52F;
			this.colBody.HeaderText = "Notiztext";
			this.colBody.Name = "colBody";
			this.colBody.ReadOnly = true;
			// 
			// xmnuNotes
			// 
			this.xmnuNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowNote,
            this.xcmdAddNote,
            this.toolStripMenuItem1,
            this.xcmdDeleteNote});
			this.xmnuNotes.Name = "xmnuNotes";
			this.xmnuNotes.Size = new System.Drawing.Size(137, 76);
			this.xmnuNotes.Opening += new System.ComponentModel.CancelEventHandler(this.xmnuNotes_Opening);
			// 
			// xcmdShowNote
			// 
			this.xcmdShowNote.Image = global::Products.Common.Properties.Resources.open_16_metroteal;
			this.xcmdShowNote.Name = "xcmdShowNote";
			this.xcmdShowNote.Size = new System.Drawing.Size(136, 22);
			this.xcmdShowNote.Text = "Öffnen";
			this.xcmdShowNote.Click += new System.EventHandler(this.xcmdShowNote_Click);
			// 
			// xcmdAddNote
			// 
			this.xcmdAddNote.Image = global::Products.Common.Properties.Resources.add_16_metroteal;
			this.xcmdAddNote.Name = "xcmdAddNote";
			this.xcmdAddNote.Size = new System.Drawing.Size(136, 22);
			this.xcmdAddNote.Text = "Hinzufügen";
			this.xcmdAddNote.Click += new System.EventHandler(this.xcmdAddNote_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
			// 
			// xcmdDeleteNote
			// 
			this.xcmdDeleteNote.Image = global::Products.Common.Properties.Resources.garbage_16_metroteal;
			this.xcmdDeleteNote.Name = "xcmdDeleteNote";
			this.xcmdDeleteNote.Size = new System.Drawing.Size(136, 22);
			this.xcmdDeleteNote.Text = "Löschen";
			this.xcmdDeleteNote.Click += new System.EventHandler(this.xcmdDeleteNote_Click);
			// 
			// mlblNotes
			// 
			this.mlblNotes.AutoSize = true;
			this.mlblNotes.FontSize = MetroFramework.MetroLabelSize.Small;
			this.mlblNotes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.mlblNotes.Location = new System.Drawing.Point(816, 159);
			this.mlblNotes.Name = "mlblNotes";
			this.mlblNotes.Size = new System.Drawing.Size(87, 15);
			this.mlblNotes.TabIndex = 21;
			this.mlblNotes.Text = "Bestellnotizen";
			// 
			// btnDeleteNote
			// 
			this.btnDeleteNote.BackColor = System.Drawing.Color.Transparent;
			this.btnDeleteNote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDeleteNote.FlatAppearance.BorderSize = 0;
			this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteNote.Image = global::Products.Common.Properties.Resources.garbage_32_metroteal;
			this.btnDeleteNote.Location = new System.Drawing.Point(1044, 135);
			this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnDeleteNote.Name = "btnDeleteNote";
			this.btnDeleteNote.Size = new System.Drawing.Size(36, 36);
			this.btnDeleteNote.TabIndex = 24;
			this.btnDeleteNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDeleteNote.UseVisualStyleBackColor = false;
			this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
			// 
			// btnOpenNote
			// 
			this.btnOpenNote.BackColor = System.Drawing.Color.Transparent;
			this.btnOpenNote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOpenNote.FlatAppearance.BorderSize = 0;
			this.btnOpenNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenNote.Image = global::Products.Common.Properties.Resources.open_32_metroteal;
			this.btnOpenNote.Location = new System.Drawing.Point(985, 135);
			this.btnOpenNote.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnOpenNote.Name = "btnOpenNote";
			this.btnOpenNote.Size = new System.Drawing.Size(36, 36);
			this.btnOpenNote.TabIndex = 23;
			this.btnOpenNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpenNote.UseVisualStyleBackColor = false;
			this.btnOpenNote.Click += new System.EventHandler(this.btnShowNotiz_Click);
			// 
			// btnAddNotiz
			// 
			this.btnAddNotiz.BackColor = System.Drawing.Color.Transparent;
			this.btnAddNotiz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddNotiz.FlatAppearance.BorderSize = 0;
			this.btnAddNotiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNotiz.Image = global::Products.Common.Properties.Resources.neu_32_metroteal;
			this.btnAddNotiz.Location = new System.Drawing.Point(926, 135);
			this.btnAddNotiz.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
			this.btnAddNotiz.Name = "btnAddNotiz";
			this.btnAddNotiz.Size = new System.Drawing.Size(36, 36);
			this.btnAddNotiz.TabIndex = 22;
			this.btnAddNotiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNotiz.UseVisualStyleBackColor = false;
			this.btnAddNotiz.Click += new System.EventHandler(this.btnAddNotiz_Click);
			// 
			// dgvFileLinks
			// 
			this.dgvFileLinks.AllowDrop = true;
			this.dgvFileLinks.AllowUserToAddRows = false;
			this.dgvFileLinks.AllowUserToDeleteRows = false;
			this.dgvFileLinks.AllowUserToResizeRows = false;
			this.dgvFileLinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFileLinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvFileLinks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvFileLinks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFileLinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvFileLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFileLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileTitle,
            this.colDescription,
            this.colExtension});
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFileLinks.DefaultCellStyle = dataGridViewCellStyle21;
			this.dgvFileLinks.EnableHeadersVisualStyles = false;
			this.dgvFileLinks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvFileLinks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFileLinks.HighLightPercentage = 1.2F;
			this.dgvFileLinks.Location = new System.Drawing.Point(816, 438);
			this.dgvFileLinks.Name = "dgvFileLinks";
			this.dgvFileLinks.ReadOnly = true;
			this.dgvFileLinks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFileLinks.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.dgvFileLinks.RowHeadersVisible = false;
			this.dgvFileLinks.RowHeadersWidth = 21;
			this.dgvFileLinks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvFileLinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFileLinks.Size = new System.Drawing.Size(584, 275);
			this.dgvFileLinks.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvFileLinks.TabIndex = 6;
			this.dgvFileLinks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileLinks_RowEnter);
			this.dgvFileLinks.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFileLinks_DragDrop);
			this.dgvFileLinks.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvFileLinks_DragOver);
			this.dgvFileLinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFileLinks_MouseDoubleClick);
			// 
			// colFileTitle
			// 
			this.colFileTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFileTitle.DataPropertyName = "FileTitle";
			this.colFileTitle.FillWeight = 30F;
			this.colFileTitle.HeaderText = "Dateititel";
			this.colFileTitle.Name = "colFileTitle";
			this.colFileTitle.ReadOnly = true;
			// 
			// colDescription
			// 
			this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDescription.DataPropertyName = "Description";
			this.colDescription.FillWeight = 60F;
			this.colDescription.HeaderText = "Beschreibung";
			this.colDescription.Name = "colDescription";
			this.colDescription.ReadOnly = true;
			// 
			// colExtension
			// 
			this.colExtension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colExtension.DataPropertyName = "Extension";
			this.colExtension.FillWeight = 10F;
			this.colExtension.HeaderText = "Typ";
			this.colExtension.Name = "colExtension";
			this.colExtension.ReadOnly = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(816, 420);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(124, 15);
			this.metroLabel3.TabIndex = 26;
			this.metroLabel3.Text = "Dateiverknüpfungen";
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(323, 1);
			this.mtxtFilter.CustomButton.Name = "";
			this.mtxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtFilter.CustomButton.TabIndex = 1;
			this.mtxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFilter.CustomButton.UseSelectable = true;
			this.mtxtFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtFilter.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtFilter.Lines = new string[0];
			this.mtxtFilter.Location = new System.Drawing.Point(23, 100);
			this.mtxtFilter.MaxLength = 32767;
			this.mtxtFilter.Name = "mtxtFilter";
			this.mtxtFilter.PasswordChar = '\0';
			this.mtxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFilter.SelectedText = "";
			this.mtxtFilter.SelectionLength = 0;
			this.mtxtFilter.SelectionStart = 0;
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(345, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtFilter.TabIndex = 0;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Artikel-Nr. oder Artikelbezeichnung";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.mtxtFilter_ClearClicked);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFilter_KeyUp);
			// 
			// BestellungListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1423, 785);
			this.ControlBox = false;
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.dgvFileLinks);
			this.Controls.Add(this.btnDeleteNote);
			this.Controls.Add(this.btnOpenNote);
			this.Controls.Add(this.btnAddNotiz);
			this.Controls.Add(this.mlblNotes);
			this.Controls.Add(this.dgvNotes);
			this.Controls.Add(this.dgvRechnungen);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.dgvLieferungen);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mlblLieferungen);
			this.Controls.Add(this.mlblBestellungen);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvDetails);
			this.Controls.Add(this.dgvBestellungen);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BestellungListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Bestellungen - <Lieferant>";
			((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLieferungen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRechnungen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
			this.xmnuNotes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFileLinks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvBestellungen;
		private MetroFramework.Controls.MetroGrid dgvDetails;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroLabel mlblBestellungen;
		private MetroFramework.Controls.MetroLabel mlblLieferungen;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSummeUSt_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBruttosumme;
		private MetroFramework.Controls.MetroGrid dgvLieferungen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNummer_l;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum_l;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSumme_l;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBruttosumme_l;
		private MetroFramework.Controls.MetroGrid dgvRechnungen;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroGrid dgvNotes;
		private MetroFramework.Controls.MetroLabel mlblNotes;
		private System.Windows.Forms.Button btnAddNotiz;
		private System.Windows.Forms.Button btnOpenNote;
		private MetroFramework.Controls.MetroContextMenu xmnuNotes;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowNote;
		private System.Windows.Forms.ToolStripMenuItem xcmdAddNote;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdDeleteNote;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum_n;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBody;
		private System.Windows.Forms.Button btnDeleteNote;
		private MetroFramework.Controls.MetroGrid dgvFileLinks;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExtension;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelnummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBestellwert;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLieferdatum;
	}
}