namespace Products.Common.Views
{
	partial class ProductListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListView));
			this.dgvProducts = new MetroFramework.Controls.MetroGrid();
			this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelgruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVerkaufspreis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProzent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKatalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStandardlagerEinkauf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colChangeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnuDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuCalc = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cmnuSpecialPrice = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmnuInventory = new System.Windows.Forms.ToolStripMenuItem();
			this.lblCustomer = new MetroFramework.Controls.MetroLabel();
			this.mtxtCustomer = new MetroFramework.Controls.MetroTextBox();
			this.lnkCustomerName = new System.Windows.Forms.LinkLabel();
			this.txtProductsFilter = new Products.Common.Controls.axlTextbox();
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.mbtnLagerbestand = new MetroFramework.Controls.MetroButton();
			this.mbtnArtikeldetails = new MetroFramework.Controls.MetroButton();
			this.mbtnKalkulation = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikel,
            this.colBezeichnung1,
            this.colArtikelgruppe,
            this.colMengeneinheit,
            this.colEK,
            this.colVerkaufspreis1,
            this.colKundenpreis,
            this.colProzent,
            this.colKatalog,
            this.colStandardlagerEinkauf,
            this.colChecked,
            this.colChangeUser});
			this.dgvProducts.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.HighLightPercentage = 1.3F;
			this.dgvProducts.Location = new System.Drawing.Point(23, 128);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvProducts.MultiSelect = false;
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvProducts.RowHeadersWidth = 25;
			this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(1459, 558);
			this.dgvProducts.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvProducts.TabIndex = 3;
			this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
			this.dgvProducts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProducts_KeyUp);
			this.dgvProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseDoubleClick);
			// 
			// colArtikel
			// 
			this.colArtikel.DataPropertyName = "Artikel";
			this.colArtikel.HeaderText = "Art.-Nr.";
			this.colArtikel.MinimumWidth = 130;
			this.colArtikel.Name = "colArtikel";
			this.colArtikel.ReadOnly = true;
			this.colArtikel.Width = 130;
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.HeaderText = "Artikelname";
			this.colBezeichnung1.MinimumWidth = 200;
			this.colBezeichnung1.Name = "colBezeichnung1";
			this.colBezeichnung1.ReadOnly = true;
			this.colBezeichnung1.Width = 200;
			// 
			// colArtikelgruppe
			// 
			this.colArtikelgruppe.DataPropertyName = "Artikelgruppe";
			this.colArtikelgruppe.HeaderText = "Art.-Gruppe";
			this.colArtikelgruppe.MinimumWidth = 95;
			this.colArtikelgruppe.Name = "colArtikelgruppe";
			this.colArtikelgruppe.ReadOnly = true;
			this.colArtikelgruppe.Width = 95;
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.HeaderText = "ME";
			this.colMengeneinheit.MinimumWidth = 50;
			this.colMengeneinheit.Name = "colMengeneinheit";
			this.colMengeneinheit.ReadOnly = true;
			this.colMengeneinheit.Width = 50;
			// 
			// colEK
			// 
			this.colEK.DataPropertyName = "EK";
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.colEK.DefaultCellStyle = dataGridViewCellStyle3;
			this.colEK.HeaderText = "Einkaufspreis";
			this.colEK.MinimumWidth = 100;
			this.colEK.Name = "colEK";
			this.colEK.ReadOnly = true;
			// 
			// colVerkaufspreis1
			// 
			this.colVerkaufspreis1.DataPropertyName = "Verkaufspreis1";
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.colVerkaufspreis1.DefaultCellStyle = dataGridViewCellStyle4;
			this.colVerkaufspreis1.HeaderText = "Normalpreis";
			this.colVerkaufspreis1.MinimumWidth = 100;
			this.colVerkaufspreis1.Name = "colVerkaufspreis1";
			this.colVerkaufspreis1.ReadOnly = true;
			// 
			// colKundenpreis
			// 
			this.colKundenpreis.DataPropertyName = "Kundenpreis";
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.colKundenpreis.DefaultCellStyle = dataGridViewCellStyle5;
			this.colKundenpreis.HeaderText = "Kundenpreis";
			this.colKundenpreis.MinimumWidth = 100;
			this.colKundenpreis.Name = "colKundenpreis";
			this.colKundenpreis.ReadOnly = true;
			// 
			// colProzent
			// 
			this.colProzent.DataPropertyName = "Prozent";
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = null;
			this.colProzent.DefaultCellStyle = dataGridViewCellStyle6;
			this.colProzent.HeaderText = "Rabatt (%)";
			this.colProzent.MinimumWidth = 85;
			this.colProzent.Name = "colProzent";
			this.colProzent.ReadOnly = true;
			this.colProzent.Width = 85;
			// 
			// colKatalog
			// 
			this.colKatalog.DataPropertyName = "Katalog";
			this.colKatalog.HeaderText = "Katolog";
			this.colKatalog.MinimumWidth = 310;
			this.colKatalog.Name = "colKatalog";
			this.colKatalog.ReadOnly = true;
			this.colKatalog.Width = 310;
			// 
			// colStandardlagerEinkauf
			// 
			this.colStandardlagerEinkauf.DataPropertyName = "StandardlagerEinkauf";
			this.colStandardlagerEinkauf.HeaderText = "Lager";
			this.colStandardlagerEinkauf.MinimumWidth = 65;
			this.colStandardlagerEinkauf.Name = "colStandardlagerEinkauf";
			this.colStandardlagerEinkauf.ReadOnly = true;
			this.colStandardlagerEinkauf.Width = 65;
			// 
			// colChecked
			// 
			this.colChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colChecked.DataPropertyName = "CheckedFlag";
			this.colChecked.FalseValue = "";
			this.colChecked.HeaderText = "Geprüft";
			this.colChecked.Name = "colChecked";
			this.colChecked.ReadOnly = true;
			this.colChecked.Width = 51;
			// 
			// colChangeUser
			// 
			this.colChangeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colChangeUser.DataPropertyName = "ChangeUser";
			this.colChangeUser.HeaderText = "Geändert durch";
			this.colChangeUser.MinimumWidth = 120;
			this.colChangeUser.Name = "colChangeUser";
			this.colChangeUser.ReadOnly = true;
			this.colChangeUser.Width = 120;
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuDetails,
            this.cmnuCalc,
            this.toolStripSeparator2,
            this.cmnuSpecialPrice,
            this.toolStripSeparator1,
            this.cmnuInventory});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(206, 104);
			// 
			// cmnuDetails
			// 
			this.cmnuDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.cmnuDetails.Image = global::Products.Common.Properties.Resources.details_24_metrogreen;
			this.cmnuDetails.Name = "cmnuDetails";
			this.cmnuDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.cmnuDetails.Size = new System.Drawing.Size(205, 22);
			this.cmnuDetails.Text = "Details anzeigen";
			this.cmnuDetails.Click += new System.EventHandler(this.cmnuDetails_Click);
			// 
			// cmnuCalc
			// 
			this.cmnuCalc.Image = global::Products.Common.Properties.Resources.calculator_24_metroblue;
			this.cmnuCalc.Name = "cmnuCalc";
			this.cmnuCalc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
			this.cmnuCalc.Size = new System.Drawing.Size(205, 22);
			this.cmnuCalc.Text = "Kalkulation";
			this.cmnuCalc.Click += new System.EventHandler(this.cmnuCalc_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
			// 
			// cmnuSpecialPrice
			// 
			this.cmnuSpecialPrice.Image = ((System.Drawing.Image)(resources.GetObject("cmnuSpecialPrice.Image")));
			this.cmnuSpecialPrice.Name = "cmnuSpecialPrice";
			this.cmnuSpecialPrice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.cmnuSpecialPrice.Size = new System.Drawing.Size(205, 22);
			this.cmnuSpecialPrice.Text = "Sonderpreis";
			this.cmnuSpecialPrice.Click += new System.EventHandler(this.cmnuSpecialPrice_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
			// 
			// cmnuInventory
			// 
			this.cmnuInventory.Image = global::Products.Common.Properties.Resources.lager_24_metroyellow;
			this.cmnuInventory.Name = "cmnuInventory";
			this.cmnuInventory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.cmnuInventory.Size = new System.Drawing.Size(205, 22);
			this.cmnuInventory.Text = "Lagerbestände";
			this.cmnuInventory.Click += new System.EventHandler(this.cmnuInventory_Click);
			// 
			// lblCustomer
			// 
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.Location = new System.Drawing.Point(23, 67);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(48, 19);
			this.lblCustomer.TabIndex = 2;
			this.lblCustomer.Text = "Kunde:";
			this.lblCustomer.Visible = false;
			// 
			// mtxtCustomer
			// 
			// 
			// 
			// 
			this.mtxtCustomer.CustomButton.Image = null;
			this.mtxtCustomer.CustomButton.Location = new System.Drawing.Point(27, 2);
			this.mtxtCustomer.CustomButton.Name = "";
			this.mtxtCustomer.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.mtxtCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtCustomer.CustomButton.TabIndex = 1;
			this.mtxtCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtCustomer.CustomButton.UseSelectable = true;
			this.mtxtCustomer.CustomButton.Visible = false;
			this.mtxtCustomer.Lines = new string[] {
        "10001"};
			this.mtxtCustomer.Location = new System.Drawing.Point(77, 67);
			this.mtxtCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mtxtCustomer.MaxLength = 32767;
			this.mtxtCustomer.Name = "mtxtCustomer";
			this.mtxtCustomer.PasswordChar = '\0';
			this.mtxtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtCustomer.SelectedText = "";
			this.mtxtCustomer.SelectionLength = 0;
			this.mtxtCustomer.SelectionStart = 0;
			this.mtxtCustomer.Size = new System.Drawing.Size(47, 22);
			this.mtxtCustomer.TabIndex = 0;
			this.mtxtCustomer.Text = "10001";
			this.mtxtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtCustomer.UseSelectable = true;
			this.mtxtCustomer.Visible = false;
			this.mtxtCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyUp);
			// 
			// lnkCustomerName
			// 
			this.lnkCustomerName.AutoSize = true;
			this.lnkCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkCustomerName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkCustomerName.Location = new System.Drawing.Point(140, 67);
			this.lnkCustomerName.Name = "lnkCustomerName";
			this.lnkCustomerName.Size = new System.Drawing.Size(45, 17);
			this.lnkCustomerName.TabIndex = 67;
			this.lnkCustomerName.TabStop = true;
			this.lnkCustomerName.Text = "Kunde";
			this.lnkCustomerName.Visible = false;
			this.lnkCustomerName.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkCustomerName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCustomerName_LinkClicked);
			// 
			// txtProductsFilter
			// 
			this.txtProductsFilter.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductsFilter.Location = new System.Drawing.Point(23, 96);
			this.txtProductsFilter.Name = "txtProductsFilter";
			this.txtProductsFilter.Size = new System.Drawing.Size(220, 25);
			this.txtProductsFilter.TabIndex = 71;
			this.txtProductsFilter.Watermark = "Artikelfilter";
			this.txtProductsFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductsFilter_KeyUp);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnClose.Location = new System.Drawing.Point(1382, 716);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 30);
			this.btnClose.TabIndex = 73;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// mbtnLagerbestand
			// 
			this.mbtnLagerbestand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnLagerbestand.BackgroundImage = global::Products.Common.Properties.Resources.lager_32_metrored;
			this.mbtnLagerbestand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnLagerbestand.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnLagerbestand.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnLagerbestand.Location = new System.Drawing.Point(102, 710);
			this.mbtnLagerbestand.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnLagerbestand.Name = "mbtnLagerbestand";
			this.mbtnLagerbestand.Size = new System.Drawing.Size(36, 36);
			this.mbtnLagerbestand.TabIndex = 76;
			this.mbtnLagerbestand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnLagerbestand.UseSelectable = true;
			this.mbtnLagerbestand.Click += new System.EventHandler(this.mbtnLagerbestand_Click);
			// 
			// mbtnArtikeldetails
			// 
			this.mbtnArtikeldetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnArtikeldetails.BackgroundImage = global::Products.Common.Properties.Resources.details_32_metrored;
			this.mbtnArtikeldetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnArtikeldetails.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnArtikeldetails.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnArtikeldetails.Location = new System.Drawing.Point(23, 710);
			this.mbtnArtikeldetails.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnArtikeldetails.Name = "mbtnArtikeldetails";
			this.mbtnArtikeldetails.Size = new System.Drawing.Size(36, 36);
			this.mbtnArtikeldetails.TabIndex = 75;
			this.mbtnArtikeldetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnArtikeldetails.UseSelectable = true;
			this.mbtnArtikeldetails.Click += new System.EventHandler(this.mbtnArtikeldetails_Click);
			// 
			// mbtnKalkulation
			// 
			this.mbtnKalkulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnKalkulation.BackgroundImage = global::Products.Common.Properties.Resources.calc_32_metrored;
			this.mbtnKalkulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnKalkulation.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnKalkulation.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnKalkulation.Location = new System.Drawing.Point(181, 710);
			this.mbtnKalkulation.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnKalkulation.Name = "mbtnKalkulation";
			this.mbtnKalkulation.Size = new System.Drawing.Size(36, 36);
			this.mbtnKalkulation.TabIndex = 74;
			this.mbtnKalkulation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnKalkulation.UseSelectable = true;
			this.mbtnKalkulation.Click += new System.EventHandler(this.mbtnKalkulation_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(164, 746);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(71, 19);
			this.metroLabel1.TabIndex = 77;
			this.metroLabel1.Text = "Kalkulation";
			// 
			// metroLabel2
			// 
			this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(99, 746);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(42, 19);
			this.metroLabel2.TabIndex = 78;
			this.metroLabel2.Text = "Lager";
			// 
			// metroLabel3
			// 
			this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(18, 746);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(47, 19);
			this.metroLabel3.TabIndex = 79;
			this.metroLabel3.Text = "Details";
			// 
			// ProductListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(1505, 769);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mbtnLagerbestand);
			this.Controls.Add(this.mbtnArtikeldetails);
			this.Controls.Add(this.mbtnKalkulation);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtProductsFilter);
			this.Controls.Add(this.lnkCustomerName);
			this.Controls.Add(this.mtxtCustomer);
			this.Controls.Add(this.lblCustomer);
			this.Controls.Add(this.dgvProducts);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ProductListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Artikelliste pro Kunde";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductListView_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvProducts;
		private MetroFramework.Controls.MetroLabel lblCustomer;
		private MetroFramework.Controls.MetroTextBox mtxtCustomer;
		private System.Windows.Forms.ContextMenuStrip ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem cmnuDetails;
		private System.Windows.Forms.ToolStripMenuItem cmnuCalc;
		private System.Windows.Forms.ToolStripMenuItem cmnuInventory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelgruppe;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVerkaufspreis1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenpreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProzent;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKatalog;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStandardlagerEinkauf;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked;
		private System.Windows.Forms.DataGridViewTextBoxColumn colChangeUser;
		private System.Windows.Forms.LinkLabel lnkCustomerName;
		private Controls.axlTextbox txtProductsFilter;
		private System.Windows.Forms.ToolStripMenuItem cmnuSpecialPrice;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private MetroFramework.Controls.MetroButton btnClose;
		private MetroFramework.Controls.MetroButton mbtnKalkulation;
		private MetroFramework.Controls.MetroButton mbtnArtikeldetails;
		private MetroFramework.Controls.MetroButton mbtnLagerbestand;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
	}
}