namespace Products.Common.Views
{
	partial class CustomerOrderView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
			this.lblCustomerNameAdd = new MetroFramework.Controls.MetroLabel();
			this.lblStreet = new MetroFramework.Controls.MetroLabel();
			this.lblZipAndCity = new MetroFramework.Controls.MetroLabel();
			this.dgvOrders = new MetroFramework.Controls.MetroGrid();
			this.colVorgang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAuftrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBruttosumme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxTransactions = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xMnuOpenTransactionInSage = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvDetails = new MetroFramework.Controls.MetroGrid();
			this.colPositionszaehler = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEinheitspreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTransactions = new MetroFramework.Controls.MetroLabel();
			this.lblDetails = new MetroFramework.Controls.MetroLabel();
			this.txtFilterTransactions = new MetroFramework.Controls.MetroTextBox();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mtglNurRechnungen = new MetroFramework.Controls.MetroToggle();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mtglAllOrders = new MetroFramework.Controls.MetroToggle();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.taKundenmaschine1 = new Products.Data.dsSageTableAdapters.taKundenmaschine();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.ctxTransactions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCustomerName.Location = new System.Drawing.Point(29, 97);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(101, 19);
			this.lblCustomerName.TabIndex = 72;
			this.lblCustomerName.Text = "Firma (xxxxx)";
			// 
			// lblCustomerNameAdd
			// 
			this.lblCustomerNameAdd.AutoSize = true;
			this.lblCustomerNameAdd.Location = new System.Drawing.Point(29, 116);
			this.lblCustomerNameAdd.Name = "lblCustomerNameAdd";
			this.lblCustomerNameAdd.Size = new System.Drawing.Size(85, 19);
			this.lblCustomerNameAdd.TabIndex = 73;
			this.lblCustomerNameAdd.Text = "Firmenzusatz";
			// 
			// lblStreet
			// 
			this.lblStreet.AutoSize = true;
			this.lblStreet.Location = new System.Drawing.Point(29, 137);
			this.lblStreet.Name = "lblStreet";
			this.lblStreet.Size = new System.Drawing.Size(46, 19);
			this.lblStreet.TabIndex = 74;
			this.lblStreet.Text = "Straße";
			// 
			// lblZipAndCity
			// 
			this.lblZipAndCity.AutoSize = true;
			this.lblZipAndCity.Location = new System.Drawing.Point(29, 158);
			this.lblZipAndCity.Name = "lblZipAndCity";
			this.lblZipAndCity.Size = new System.Drawing.Size(64, 19);
			this.lblZipAndCity.TabIndex = 75;
			this.lblZipAndCity.Text = "Plz + Ort";
			// 
			// dgvOrders
			// 
			this.dgvOrders.AllowUserToAddRows = false;
			this.dgvOrders.AllowUserToDeleteRows = false;
			this.dgvOrders.AllowUserToResizeRows = false;
			this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVorgang,
            this.colAuftrag,
            this.colNummer,
            this.colDatum,
            this.colBruttosumme});
			this.dgvOrders.ContextMenuStrip = this.ctxTransactions;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvOrders.EnableHeadersVisualStyles = false;
			this.dgvOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvOrders.Location = new System.Drawing.Point(29, 216);
			this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvOrders.MultiSelect = false;
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.ReadOnly = true;
			this.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvOrders.RowHeadersVisible = false;
			this.dgvOrders.RowHeadersWidth = 20;
			this.dgvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrders.Size = new System.Drawing.Size(437, 220);
			this.dgvOrders.StandardTab = true;
			this.dgvOrders.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvOrders.TabIndex = 2;
			this.dgvOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_RowEnter);
			this.dgvOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOrders_MouseDoubleClick);
			// 
			// colVorgang
			// 
			this.colVorgang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colVorgang.DataPropertyName = "Vorgang";
			this.colVorgang.HeaderText = "Typ";
			this.colVorgang.Name = "colVorgang";
			this.colVorgang.ReadOnly = true;
			this.colVorgang.Width = 46;
			// 
			// colAuftrag
			// 
			this.colAuftrag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colAuftrag.DataPropertyName = "Auftrag";
			this.colAuftrag.HeaderText = "Auftrags-Nr.";
			this.colAuftrag.Name = "colAuftrag";
			this.colAuftrag.ReadOnly = true;
			this.colAuftrag.Width = 93;
			// 
			// colNummer
			// 
			this.colNummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colNummer.DataPropertyName = "Nummer";
			this.colNummer.HeaderText = "Vorgangs-Nr.";
			this.colNummer.Name = "colNummer";
			this.colNummer.ReadOnly = true;
			this.colNummer.Width = 98;
			// 
			// colDatum
			// 
			this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colDatum.DataPropertyName = "Datum";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colDatum.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDatum.HeaderText = "Datum";
			this.colDatum.Name = "colDatum";
			this.colDatum.ReadOnly = true;
			this.colDatum.Width = 64;
			// 
			// colBruttosumme
			// 
			this.colBruttosumme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colBruttosumme.DataPropertyName = "Bruttosumme";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.colBruttosumme.DefaultCellStyle = dataGridViewCellStyle3;
			this.colBruttosumme.HeaderText = "Auftragssumme";
			this.colBruttosumme.Name = "colBruttosumme";
			this.colBruttosumme.ReadOnly = true;
			this.colBruttosumme.Width = 110;
			// 
			// ctxTransactions
			// 
			this.ctxTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMnuOpenTransactionInSage});
			this.ctxTransactions.Name = "ctxTransactions";
			this.ctxTransactions.Size = new System.Drawing.Size(194, 26);
			// 
			// xMnuOpenTransactionInSage
			// 
			this.xMnuOpenTransactionInSage.Image = ((System.Drawing.Image)(resources.GetObject("xMnuOpenTransactionInSage.Image")));
			this.xMnuOpenTransactionInSage.Name = "xMnuOpenTransactionInSage";
			this.xMnuOpenTransactionInSage.Size = new System.Drawing.Size(193, 22);
			this.xMnuOpenTransactionInSage.Text = "Auftrag in Sage öffnen";
			this.xMnuOpenTransactionInSage.Click += new System.EventHandler(this.xMnuOpenTransactionInSage_Click);
			// 
			// dgvDetails
			// 
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPositionszaehler,
            this.colArtikelnummer,
            this.colBezeichnung1,
            this.colBezeichnung2,
            this.colMenge,
            this.colMengeneinheit,
            this.colEinheitspreis,
            this.colGesamtpreis});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.Location = new System.Drawing.Point(29, 482);
			this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 20;
			this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(1000, 287);
			this.dgvDetails.StandardTab = true;
			this.dgvDetails.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvDetails.TabIndex = 3;
			// 
			// colPositionszaehler
			// 
			this.colPositionszaehler.DataPropertyName = "Positionszaehler";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.colPositionszaehler.DefaultCellStyle = dataGridViewCellStyle7;
			this.colPositionszaehler.HeaderText = "Pos.";
			this.colPositionszaehler.MinimumWidth = 57;
			this.colPositionszaehler.Name = "colPositionszaehler";
			this.colPositionszaehler.ReadOnly = true;
			this.colPositionszaehler.Width = 57;
			// 
			// colArtikelnummer
			// 
			this.colArtikelnummer.DataPropertyName = "Artikelnummer";
			this.colArtikelnummer.HeaderText = "Artikel";
			this.colArtikelnummer.MinimumWidth = 130;
			this.colArtikelnummer.Name = "colArtikelnummer";
			this.colArtikelnummer.ReadOnly = true;
			this.colArtikelnummer.Width = 130;
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.HeaderText = "Bezeichnung";
			this.colBezeichnung1.MinimumWidth = 230;
			this.colBezeichnung1.Name = "colBezeichnung1";
			this.colBezeichnung1.ReadOnly = true;
			this.colBezeichnung1.Width = 230;
			// 
			// colBezeichnung2
			// 
			this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
			this.colBezeichnung2.HeaderText = "Artikeltext";
			this.colBezeichnung2.MinimumWidth = 230;
			this.colBezeichnung2.Name = "colBezeichnung2";
			this.colBezeichnung2.ReadOnly = true;
			this.colBezeichnung2.Width = 230;
			// 
			// colMenge
			// 
			this.colMenge.DataPropertyName = "Menge";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.colMenge.DefaultCellStyle = dataGridViewCellStyle8;
			this.colMenge.HeaderText = "Menge";
			this.colMenge.MinimumWidth = 74;
			this.colMenge.Name = "colMenge";
			this.colMenge.ReadOnly = true;
			this.colMenge.Width = 74;
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.HeaderText = "ME";
			this.colMengeneinheit.MinimumWidth = 52;
			this.colMengeneinheit.Name = "colMengeneinheit";
			this.colMengeneinheit.ReadOnly = true;
			this.colMengeneinheit.Width = 52;
			// 
			// colEinheitspreis
			// 
			this.colEinheitspreis.DataPropertyName = "Einheitspreis";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "C2";
			dataGridViewCellStyle9.NullValue = null;
			this.colEinheitspreis.DefaultCellStyle = dataGridViewCellStyle9;
			this.colEinheitspreis.HeaderText = "Einzelpreis";
			this.colEinheitspreis.MinimumWidth = 95;
			this.colEinheitspreis.Name = "colEinheitspreis";
			this.colEinheitspreis.ReadOnly = true;
			this.colEinheitspreis.Width = 95;
			// 
			// colGesamtpreis
			// 
			this.colGesamtpreis.DataPropertyName = "Gesamtpreis";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "C2";
			dataGridViewCellStyle10.NullValue = null;
			this.colGesamtpreis.DefaultCellStyle = dataGridViewCellStyle10;
			this.colGesamtpreis.HeaderText = "Gesamtpreis";
			this.colGesamtpreis.MinimumWidth = 106;
			this.colGesamtpreis.Name = "colGesamtpreis";
			this.colGesamtpreis.ReadOnly = true;
			this.colGesamtpreis.Width = 106;
			// 
			// lblTransactions
			// 
			this.lblTransactions.AutoSize = true;
			this.lblTransactions.Location = new System.Drawing.Point(29, 195);
			this.lblTransactions.Name = "lblTransactions";
			this.lblTransactions.Size = new System.Drawing.Size(92, 19);
			this.lblTransactions.TabIndex = 81;
			this.lblTransactions.Text = "Alle Vorgänge";
			// 
			// lblDetails
			// 
			this.lblDetails.AutoSize = true;
			this.lblDetails.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblDetails.Location = new System.Drawing.Point(29, 461);
			this.lblDetails.Name = "lblDetails";
			this.lblDetails.Size = new System.Drawing.Size(106, 19);
			this.lblDetails.TabIndex = 82;
			this.lblDetails.Text = "Vorgangsdetails";
			// 
			// txtFilterTransactions
			// 
			// 
			// 
			// 
			this.txtFilterTransactions.CustomButton.Image = null;
			this.txtFilterTransactions.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtFilterTransactions.CustomButton.Name = "";
			this.txtFilterTransactions.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtFilterTransactions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFilterTransactions.CustomButton.TabIndex = 1;
			this.txtFilterTransactions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFilterTransactions.CustomButton.UseSelectable = true;
			this.txtFilterTransactions.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtFilterTransactions.Lines = new string[0];
			this.txtFilterTransactions.Location = new System.Drawing.Point(493, 216);
			this.txtFilterTransactions.MaxLength = 32767;
			this.txtFilterTransactions.Name = "txtFilterTransactions";
			this.txtFilterTransactions.PasswordChar = '\0';
			this.txtFilterTransactions.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFilterTransactions.SelectedText = "";
			this.txtFilterTransactions.SelectionLength = 0;
			this.txtFilterTransactions.SelectionStart = 0;
			this.txtFilterTransactions.ShowButton = true;
			this.txtFilterTransactions.ShowClearButton = true;
			this.txtFilterTransactions.Size = new System.Drawing.Size(270, 29);
			this.txtFilterTransactions.Style = MetroFramework.MetroColorStyle.Orange;
			this.txtFilterTransactions.TabIndex = 90;
			this.txtFilterTransactions.UseSelectable = true;
			this.txtFilterTransactions.WaterMark = "Artikel-Nr. oder -name";
			this.txtFilterTransactions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFilterTransactions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtFilterTransactions.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txtFilterTransactions_ClearClicked);
			this.txtFilterTransactions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnClose.Location = new System.Drawing.Point(939, 803);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(90, 30);
			this.mbtnClose.TabIndex = 92;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mtglNurRechnungen
			// 
			this.mtglNurRechnungen.AutoSize = true;
			this.mtglNurRechnungen.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.mtglNurRechnungen.FontWeight = MetroFramework.MetroLinkWeight.Light;
			this.mtglNurRechnungen.Location = new System.Drawing.Point(493, 262);
			this.mtglNurRechnungen.Name = "mtglNurRechnungen";
			this.mtglNurRechnungen.Size = new System.Drawing.Size(80, 17);
			this.mtglNurRechnungen.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtglNurRechnungen.TabIndex = 93;
			this.mtglNurRechnungen.Text = "Aus";
			this.mtglNurRechnungen.UseSelectable = true;
			this.mtglNurRechnungen.CheckedChanged += new System.EventHandler(this.mtglNurRechnungen_CheckedChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(579, 262);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(162, 19);
			this.metroLabel2.TabIndex = 95;
			this.metroLabel2.Text = "Nur Rechnungen anzeigen";
			// 
			// mtglAllOrders
			// 
			this.mtglAllOrders.AutoSize = true;
			this.mtglAllOrders.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.mtglAllOrders.FontWeight = MetroFramework.MetroLinkWeight.Light;
			this.mtglAllOrders.Location = new System.Drawing.Point(493, 285);
			this.mtglAllOrders.Name = "mtglAllOrders";
			this.mtglAllOrders.Size = new System.Drawing.Size(80, 17);
			this.mtglAllOrders.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtglAllOrders.TabIndex = 96;
			this.mtglAllOrders.Text = "Aus";
			this.mtglAllOrders.UseSelectable = true;
			this.mtglAllOrders.CheckedChanged += new System.EventHandler(this.mtglAllOrders_CheckedChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(579, 285);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(218, 19);
			this.metroLabel1.TabIndex = 97;
			this.metroLabel1.Text = "Vorgänge aus allen Jahren anzeigen";
			// 
			// taKundenmaschine1
			// 
			this.taKundenmaschine1.ClearBeforeFill = true;
			// 
			// CustomerOrderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 861);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mtglAllOrders);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mtglNurRechnungen);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.txtFilterTransactions);
			this.Controls.Add(this.lblDetails);
			this.Controls.Add(this.lblTransactions);
			this.Controls.Add(this.dgvDetails);
			this.Controls.Add(this.dgvOrders);
			this.Controls.Add(this.lblZipAndCity);
			this.Controls.Add(this.lblStreet);
			this.Controls.Add(this.lblCustomerNameAdd);
			this.Controls.Add(this.lblCustomerName);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomerOrderView";
			this.Padding = new System.Windows.Forms.Padding(26, 60, 26, 23);
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Aufträge";
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ctxTransactions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lblCustomerName;
		private MetroFramework.Controls.MetroLabel lblCustomerNameAdd;
		private MetroFramework.Controls.MetroLabel lblStreet;
		private MetroFramework.Controls.MetroLabel lblZipAndCity;
		private MetroFramework.Controls.MetroGrid dgvOrders;
		private MetroFramework.Controls.MetroGrid dgvDetails;
		private MetroFramework.Controls.MetroLabel lblTransactions;
		private MetroFramework.Controls.MetroLabel lblDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVorgang;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAuftrag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBruttosumme;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPositionszaehler;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelnummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEinheitspreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGesamtpreis;
		private MetroFramework.Controls.MetroContextMenu ctxTransactions;
		private System.Windows.Forms.ToolStripMenuItem xMnuOpenTransactionInSage;
		private MetroFramework.Controls.MetroTextBox txtFilterTransactions;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroToggle mtglNurRechnungen;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private Data.dsSageTableAdapters.taKundenmaschine taKundenmaschine1;
		private MetroFramework.Controls.MetroToggle mtglAllOrders;
		private MetroFramework.Controls.MetroLabel metroLabel1;

	}
}