namespace Products.Common.Panel
{
	partial class pnlArtikelpreise
	{

#pragma warning disable CS0618 // Typ oder Element ist veraltet

		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		void InitializeComponent()
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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnuDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuCalc = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuSpecialPrice = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuInventory = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdLieferantenRabatt = new System.Windows.Forms.ToolStripMenuItem();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.dgvProducts = new MetroFramework.Controls.MetroGrid();
			this.Export = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelgruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEinkaufspreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStandardpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRabatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKatalogsektion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colChangeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.mbtnExport = new MetroFramework.Controls.MetroButton();
			this.mbtnLagerbestand = new MetroFramework.Controls.MetroButton();
			this.mbtnArtikeldetails = new MetroFramework.Controls.MetroButton();
			this.mbtnKalkulation = new MetroFramework.Controls.MetroButton();
			this.mchkToggleChecked = new MetroFramework.Controls.MetroCheckBox();
			this.ctxGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.cmnuDetails,
						this.cmnuCalc,
						this.toolStripSeparator2,
						this.cmnuSpecialPrice,
						this.toolStripSeparator1,
						this.cmnuInventory,
						this.xcmdLieferantenRabatt});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(206, 126);
			// 
			// cmnuDetails
			// 
			this.cmnuDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.cmnuDetails.Image = global::Products.Common.Properties.Resources.details_16_metrored;
			this.cmnuDetails.Name = "cmnuDetails";
			this.cmnuDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.cmnuDetails.Size = new System.Drawing.Size(205, 22);
			this.cmnuDetails.Text = "Details anzeigen";
			this.cmnuDetails.Click += new System.EventHandler(this.cmnuDetails_Click);
			// 
			// cmnuCalc
			// 
			this.cmnuCalc.Image = global::Products.Common.Properties.Resources.calc_16_metrored;
			this.cmnuCalc.Name = "cmnuCalc";
			this.cmnuCalc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
			this.cmnuCalc.Size = new System.Drawing.Size(205, 22);
			this.cmnuCalc.Text = "Kalkulation";
			this.cmnuCalc.Click += new System.EventHandler(this.cmnuCalc_Click);
			// 
			// cmnuSpecialPrice
			// 
			this.cmnuSpecialPrice.Image = global::Products.Common.Properties.Resources.euro_16_metrored;
			this.cmnuSpecialPrice.Name = "cmnuSpecialPrice";
			this.cmnuSpecialPrice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.cmnuSpecialPrice.Size = new System.Drawing.Size(205, 22);
			this.cmnuSpecialPrice.Text = "Sonderpreis";
			this.cmnuSpecialPrice.Click += new System.EventHandler(this.cmnuSpecialPrice_Click);
			// 
			// cmnuInventory
			// 
			this.cmnuInventory.Image = global::Products.Common.Properties.Resources.lager_16_metrored;
			this.cmnuInventory.Name = "cmnuInventory";
			this.cmnuInventory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.cmnuInventory.Size = new System.Drawing.Size(205, 22);
			this.cmnuInventory.Text = "Lagerbestände";
			this.cmnuInventory.Click += new System.EventHandler(this.cmnuInventory_Click);
			// 
			// xcmdLieferantenRabatt
			// 
			this.xcmdLieferantenRabatt.Image = global::Products.Common.Properties.Resources.discount_16_metrored;
			this.xcmdLieferantenRabatt.Name = "xcmdLieferantenRabatt";
			this.xcmdLieferantenRabatt.Size = new System.Drawing.Size(205, 22);
			this.xcmdLieferantenRabatt.Text = "Lieferantenrabatt";
			this.xcmdLieferantenRabatt.Click += new System.EventHandler(this.xcmdLieferantenRabatt_Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(324, 109);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(47, 19);
			this.metroLabel3.TabIndex = 89;
			this.metroLabel3.Text = "Details";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(405, 109);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(42, 19);
			this.metroLabel2.TabIndex = 88;
			this.metroLabel2.Text = "Lager";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(470, 109);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(71, 19);
			this.metroLabel1.TabIndex = 87;
			this.metroLabel1.Text = "Kalkulation";
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
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
						this.Export,
						this.colArtikel,
						this.colBezeichnung1,
						this.colArtikelgruppe,
						this.colMengeneinheit,
						this.colEinkaufspreis,
						this.colStandardpreis,
						this.colKundenpreis,
						this.colRabatt,
						this.colKatalogsektion,
						this.colChecked,
						this.colChangeUser});
			this.dgvProducts.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.HighLightPercentage = 1.2F;
			this.dgvProducts.Location = new System.Drawing.Point(23, 132);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvProducts.MultiSelect = false;
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 21;
			this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(1234, 567);
			this.dgvProducts.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvProducts.TabIndex = 0;
			this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
			this.dgvProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseDoubleClick);
			// 
			// Export
			// 
			this.Export.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Export.DataPropertyName = "SelectedFlag";
			this.Export.FillWeight = 4F;
			this.Export.HeaderText = "Export";
			this.Export.Name = "Export";
			// 
			// colArtikel
			// 
			this.colArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikel.DataPropertyName = "Artikelnummer";
			this.colArtikel.FillWeight = 11F;
			this.colArtikel.HeaderText = "Art.-Nr.";
			this.colArtikel.Name = "colArtikel";
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 22F;
			this.colBezeichnung1.HeaderText = "Artikelname";
			this.colBezeichnung1.Name = "colBezeichnung1";
			// 
			// colArtikelgruppe
			// 
			this.colArtikelgruppe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelgruppe.DataPropertyName = "Artikelgruppe";
			this.colArtikelgruppe.FillWeight = 7F;
			this.colArtikelgruppe.HeaderText = "Art.-Gruppe";
			this.colArtikelgruppe.Name = "colArtikelgruppe";
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.FillWeight = 4F;
			this.colMengeneinheit.HeaderText = "ME";
			this.colMengeneinheit.Name = "colMengeneinheit";
			// 
			// colEinkaufspreis
			// 
			this.colEinkaufspreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEinkaufspreis.DataPropertyName = "Einkaufspreis";
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.colEinkaufspreis.DefaultCellStyle = dataGridViewCellStyle3;
			this.colEinkaufspreis.FillWeight = 8F;
			this.colEinkaufspreis.HeaderText = "Einkaufspreis";
			this.colEinkaufspreis.Name = "colEinkaufspreis";
			// 
			// colStandardpreis
			// 
			this.colStandardpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStandardpreis.DataPropertyName = "Standardpreis";
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.colStandardpreis.DefaultCellStyle = dataGridViewCellStyle4;
			this.colStandardpreis.FillWeight = 8F;
			this.colStandardpreis.HeaderText = "Normalpreis";
			this.colStandardpreis.Name = "colStandardpreis";
			// 
			// colKundenpreis
			// 
			this.colKundenpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundenpreis.DataPropertyName = "Kundenpreis";
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.colKundenpreis.DefaultCellStyle = dataGridViewCellStyle5;
			this.colKundenpreis.FillWeight = 8F;
			this.colKundenpreis.HeaderText = "Kundenpreis";
			this.colKundenpreis.Name = "colKundenpreis";
			// 
			// colRabatt
			// 
			this.colRabatt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colRabatt.DataPropertyName = "RabattProzent";
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = null;
			this.colRabatt.DefaultCellStyle = dataGridViewCellStyle6;
			this.colRabatt.FillWeight = 7F;
			this.colRabatt.HeaderText = "Rabatt (%)";
			this.colRabatt.Name = "colRabatt";
			// 
			// colKatalogsektion
			// 
			this.colKatalogsektion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKatalogsektion.DataPropertyName = "StaffelpreisInfo";
			this.colKatalogsektion.FillWeight = 7F;
			this.colKatalogsektion.HeaderText = "Staffelpreise";
			this.colKatalogsektion.Name = "colKatalogsektion";
			// 
			// colChecked
			// 
			this.colChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colChecked.DataPropertyName = "CheckedFlag";
			this.colChecked.FalseValue = "";
			this.colChecked.FillWeight = 4F;
			this.colChecked.HeaderText = "Geprüft";
			this.colChecked.Name = "colChecked";
			// 
			// colChangeUser
			// 
			this.colChangeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colChangeUser.DataPropertyName = "ChangeUser";
			this.colChangeUser.FillWeight = 10F;
			this.colChangeUser.HeaderText = "Geändert von";
			this.colChangeUser.Name = "colChangeUser";
			// 
			// mlblTitel
			// 
			this.mlblTitel.AutoSize = true;
			this.mlblTitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblTitel.Location = new System.Drawing.Point(23, 20);
			this.mlblTitel.Name = "mlblTitel";
			this.mlblTitel.Size = new System.Drawing.Size(105, 25);
			this.mlblTitel.TabIndex = 0;
			this.mlblTitel.Text = "Artikelpreise";
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(249, 1);
			this.mtxtFilter.CustomButton.Name = "";
			this.mtxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtFilter.CustomButton.TabIndex = 1;
			this.mtxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFilter.CustomButton.UseSelectable = true;
			this.mtxtFilter.Lines = new string[0];
			this.mtxtFilter.Location = new System.Drawing.Point(23, 70);
			this.mtxtFilter.MaxLength = 32767;
			this.mtxtFilter.Name = "mtxtFilter";
			this.mtxtFilter.PasswordChar = '\0';
			this.mtxtFilter.PromptText = "Art.-Nr., Matchcode oder Bezeichnung";
			this.mtxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFilter.SelectedText = "";
			this.mtxtFilter.SelectionLength = 0;
			this.mtxtFilter.SelectionStart = 0;
			this.mtxtFilter.ShortcutsEnabled = true;
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(271, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Red;
			this.mtxtFilter.TabIndex = 1;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Art.-Nr., Matchcode oder Bezeichnung";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.mtxtFilter_ClearClicked);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFilter_KeyUp);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(560, 109);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(48, 19);
			this.metroLabel4.TabIndex = 91;
			this.metroLabel4.Text = "Export";
			// 
			// mbtnExport
			// 
			this.mbtnExport.BackColor = System.Drawing.Color.Transparent;
			this.mbtnExport.BackgroundImage = global::Products.Common.Properties.Resources.excelexport_32;
			this.mbtnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnExport.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnExport.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnExport.Location = new System.Drawing.Point(566, 70);
			this.mbtnExport.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnExport.Name = "mbtnExport";
			this.mbtnExport.Size = new System.Drawing.Size(36, 36);
			this.mbtnExport.TabIndex = 90;
			this.mbtnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnExport.UseCustomBackColor = true;
			this.mbtnExport.UseSelectable = true;
			this.mbtnExport.Click += new System.EventHandler(this.mbtnExport_Click);
			// 
			// mbtnLagerbestand
			// 
			this.mbtnLagerbestand.BackColor = System.Drawing.Color.Transparent;
			this.mbtnLagerbestand.BackgroundImage = global::Products.Common.Properties.Resources.lager_32_metrored;
			this.mbtnLagerbestand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnLagerbestand.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnLagerbestand.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnLagerbestand.Location = new System.Drawing.Point(408, 70);
			this.mbtnLagerbestand.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnLagerbestand.Name = "mbtnLagerbestand";
			this.mbtnLagerbestand.Size = new System.Drawing.Size(36, 36);
			this.mbtnLagerbestand.TabIndex = 3;
			this.mbtnLagerbestand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnLagerbestand.UseCustomBackColor = true;
			this.mbtnLagerbestand.UseSelectable = true;
			this.mbtnLagerbestand.Click += new System.EventHandler(this.mbtnLagerbestand_Click);
			// 
			// mbtnArtikeldetails
			// 
			this.mbtnArtikeldetails.BackColor = System.Drawing.Color.Transparent;
			this.mbtnArtikeldetails.BackgroundImage = global::Products.Common.Properties.Resources.details_32_metrored;
			this.mbtnArtikeldetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnArtikeldetails.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnArtikeldetails.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnArtikeldetails.Location = new System.Drawing.Point(329, 70);
			this.mbtnArtikeldetails.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnArtikeldetails.Name = "mbtnArtikeldetails";
			this.mbtnArtikeldetails.Size = new System.Drawing.Size(36, 36);
			this.mbtnArtikeldetails.TabIndex = 2;
			this.mbtnArtikeldetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnArtikeldetails.UseCustomBackColor = true;
			this.mbtnArtikeldetails.UseSelectable = true;
			this.mbtnArtikeldetails.Click += new System.EventHandler(this.mbtnArtikeldetails_Click);
			// 
			// mbtnKalkulation
			// 
			this.mbtnKalkulation.BackColor = System.Drawing.Color.Transparent;
			this.mbtnKalkulation.BackgroundImage = global::Products.Common.Properties.Resources.calc_32_metrored;
			this.mbtnKalkulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnKalkulation.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnKalkulation.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.mbtnKalkulation.Location = new System.Drawing.Point(487, 70);
			this.mbtnKalkulation.Margin = new System.Windows.Forms.Padding(3, 20, 40, 3);
			this.mbtnKalkulation.Name = "mbtnKalkulation";
			this.mbtnKalkulation.Size = new System.Drawing.Size(36, 36);
			this.mbtnKalkulation.TabIndex = 4;
			this.mbtnKalkulation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mbtnKalkulation.UseCustomBackColor = true;
			this.mbtnKalkulation.UseSelectable = true;
			this.mbtnKalkulation.Click += new System.EventHandler(this.mbtnKalkulation_Click);
			// 
			// mchkToggleChecked
			// 
			this.mchkToggleChecked.AutoSize = true;
			this.mchkToggleChecked.Checked = true;
			this.mchkToggleChecked.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mchkToggleChecked.Location = new System.Drawing.Point(41, 110);
			this.mchkToggleChecked.Name = "mchkToggleChecked";
			this.mchkToggleChecked.Size = new System.Drawing.Size(110, 15);
			this.mchkToggleChecked.Style = MetroFramework.MetroColorStyle.Red;
			this.mchkToggleChecked.TabIndex = 92;
			this.mchkToggleChecked.Text = "Alle deaktivieren";
			this.mchkToggleChecked.UseSelectable = true;
			this.mchkToggleChecked.CheckedChanged += new System.EventHandler(this.mchkToggleChecked_CheckedChanged);
			// 
			// pnlArtikelpreise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mchkToggleChecked);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.mbtnExport);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mbtnLagerbestand);
			this.Controls.Add(this.mbtnArtikeldetails);
			this.Controls.Add(this.mbtnKalkulation);
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.mlblTitel);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "pnlArtikelpreise";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1280, 723);
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pnlArtikelpreise_KeyUp);
			this.ctxGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

#pragma warning restore CS0618 // Typ oder Element ist veraltet

		}

		#endregion

		MetroFramework.Controls.MetroLabel mlblTitel;
		System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		System.Windows.Forms.ToolStripMenuItem cmnuSpecialPrice;
		System.Windows.Forms.ToolStripMenuItem cmnuInventory;
		System.Windows.Forms.ToolStripMenuItem cmnuCalc;
		MetroFramework.Controls.MetroGrid dgvProducts;
		System.Windows.Forms.ContextMenuStrip ctxGrid;
		System.Windows.Forms.ToolStripMenuItem cmnuDetails;
		MetroFramework.Controls.MetroLabel metroLabel3;
		MetroFramework.Controls.MetroLabel metroLabel2;
		MetroFramework.Controls.MetroLabel metroLabel1;
		MetroFramework.Controls.MetroButton mbtnLagerbestand;
		MetroFramework.Controls.MetroButton mbtnArtikeldetails;
		MetroFramework.Controls.MetroButton mbtnKalkulation;
		MetroFramework.Controls.MetroTextBox mtxtFilter;
		System.Windows.Forms.ToolStripMenuItem xcmdLieferantenRabatt;
		private MetroFramework.Controls.MetroButton mbtnExport;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Export;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelgruppe;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEinkaufspreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStandardpreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenpreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRabatt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKatalogsektion;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked;
		private System.Windows.Forms.DataGridViewTextBoxColumn colChangeUser;
		private MetroFramework.Controls.MetroCheckBox mchkToggleChecked;
	}
}
