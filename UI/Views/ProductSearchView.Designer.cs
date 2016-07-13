namespace Products.Common.Views
{
	partial class ProductSearchView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvProducts = new MetroFramework.Controls.MetroGrid();
			this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKatalog = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelgruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVerkaufspreis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProzent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.cmnuOk = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdShowLager = new System.Windows.Forms.ToolStripMenuItem();
			this.txtProductsFilter = new MetroFramework.Controls.MetroTextBox();
			this.mToggleCatalogOnly = new MetroFramework.Controls.MetroToggle();
			this.lblCatalogOnly = new MetroFramework.Controls.MetroLabel();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mchkDoNotClose = new MetroFramework.Controls.MetroCheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.AllowUserToResizeRows = false;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colKatalog,
            this.colArtikel,
            this.colBezeichnung1,
            this.colBezeichnung2,
            this.colArtikelgruppe,
            this.colMengeneinheit,
            this.colEK,
            this.colVerkaufspreis1,
            this.colKundenpreis,
            this.colProzent});
			this.dgvProducts.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle19;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.HighLightPercentage = 1.2F;
			this.dgvProducts.Location = new System.Drawing.Point(36, 109);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvProducts.MultiSelect = false;
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 21;
			this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(1282, 553);
			this.dgvProducts.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvProducts.TabIndex = 1;
			this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
			this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
			this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
			// 
			// colTyp
			// 
			this.colTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTyp.DataPropertyName = "Typ";
			this.colTyp.FillWeight = 5F;
			this.colTyp.HeaderText = "Typ";
			this.colTyp.Name = "colTyp";
			this.colTyp.ReadOnly = true;
			// 
			// colKatalog
			// 
			this.colKatalog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKatalog.DataPropertyName = "KatalogFlag";
			this.colKatalog.FillWeight = 5F;
			this.colKatalog.HeaderText = "Katalog";
			this.colKatalog.Name = "colKatalog";
			this.colKatalog.ReadOnly = true;
			// 
			// colArtikel
			// 
			this.colArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikel.DataPropertyName = "Artikelnummer";
			this.colArtikel.FillWeight = 10.6F;
			this.colArtikel.HeaderText = "Art.-Nr.";
			this.colArtikel.MinimumWidth = 50;
			this.colArtikel.Name = "colArtikel";
			this.colArtikel.ReadOnly = true;
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 19F;
			this.colBezeichnung1.HeaderText = "Bezeichnung";
			this.colBezeichnung1.MinimumWidth = 50;
			this.colBezeichnung1.Name = "colBezeichnung1";
			this.colBezeichnung1.ReadOnly = true;
			// 
			// colBezeichnung2
			// 
			this.colBezeichnung2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
			this.colBezeichnung2.FillWeight = 19F;
			this.colBezeichnung2.HeaderText = "Zusatz";
			this.colBezeichnung2.MinimumWidth = 50;
			this.colBezeichnung2.Name = "colBezeichnung2";
			this.colBezeichnung2.ReadOnly = true;
			// 
			// colArtikelgruppe
			// 
			this.colArtikelgruppe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelgruppe.DataPropertyName = "Artikelgruppe";
			this.colArtikelgruppe.FillWeight = 7.5F;
			this.colArtikelgruppe.HeaderText = "Art.-Gruppe";
			this.colArtikelgruppe.MinimumWidth = 50;
			this.colArtikelgruppe.Name = "colArtikelgruppe";
			this.colArtikelgruppe.ReadOnly = true;
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.FillWeight = 3.5F;
			this.colMengeneinheit.HeaderText = "ME";
			this.colMengeneinheit.MinimumWidth = 50;
			this.colMengeneinheit.Name = "colMengeneinheit";
			this.colMengeneinheit.ReadOnly = true;
			// 
			// colEK
			// 
			this.colEK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEK.DataPropertyName = "Einkaufspreis";
			this.colEK.FillWeight = 7.9F;
			this.colEK.HeaderText = "Einkaufspreis";
			this.colEK.MinimumWidth = 50;
			this.colEK.Name = "colEK";
			this.colEK.ReadOnly = true;
			// 
			// colVerkaufspreis1
			// 
			this.colVerkaufspreis1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colVerkaufspreis1.DataPropertyName = "Standardpreis";
			dataGridViewCellStyle13.Format = "C2";
			dataGridViewCellStyle13.NullValue = null;
			this.colVerkaufspreis1.DefaultCellStyle = dataGridViewCellStyle13;
			this.colVerkaufspreis1.FillWeight = 7.9F;
			this.colVerkaufspreis1.HeaderText = "Normalpreis";
			this.colVerkaufspreis1.MinimumWidth = 50;
			this.colVerkaufspreis1.Name = "colVerkaufspreis1";
			this.colVerkaufspreis1.ReadOnly = true;
			// 
			// colKundenpreis
			// 
			this.colKundenpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundenpreis.DataPropertyName = "Kundenpreis";
			dataGridViewCellStyle14.Format = "C2";
			dataGridViewCellStyle14.NullValue = null;
			this.colKundenpreis.DefaultCellStyle = dataGridViewCellStyle14;
			this.colKundenpreis.FillWeight = 7.9F;
			this.colKundenpreis.HeaderText = "Kundenpreis";
			this.colKundenpreis.MinimumWidth = 50;
			this.colKundenpreis.Name = "colKundenpreis";
			this.colKundenpreis.ReadOnly = true;
			// 
			// colProzent
			// 
			this.colProzent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colProzent.DataPropertyName = "RabattProzent";
			dataGridViewCellStyle18.Format = "N2";
			dataGridViewCellStyle18.NullValue = null;
			this.colProzent.DefaultCellStyle = dataGridViewCellStyle18;
			this.colProzent.FillWeight = 6.6F;
			this.colProzent.HeaderText = "Rabatt (%)";
			this.colProzent.MinimumWidth = 50;
			this.colProzent.Name = "colProzent";
			this.colProzent.ReadOnly = true;
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOk,
            this.xcmdShowLager});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(146, 48);
			// 
			// cmnuOk
			// 
			this.cmnuOk.Image = global::Products.Common.Properties.Resources.neu_32_metrored;
			this.cmnuOk.Name = "cmnuOk";
			this.cmnuOk.Size = new System.Drawing.Size(145, 22);
			this.cmnuOk.Text = "Übernehmen";
			this.cmnuOk.Click += new System.EventHandler(this.cmnuOk_Click);
			// 
			// xcmdShowLager
			// 
			this.xcmdShowLager.Image = global::Products.Common.Properties.Resources.lager_16_metrored;
			this.xcmdShowLager.Name = "xcmdShowLager";
			this.xcmdShowLager.Size = new System.Drawing.Size(145, 22);
			this.xcmdShowLager.Text = "Lagerbestand";
			this.xcmdShowLager.Click += new System.EventHandler(this.xcmdShowLager_Click);
			// 
			// txtProductsFilter
			// 
			// 
			// 
			// 
			this.txtProductsFilter.CustomButton.Image = null;
			this.txtProductsFilter.CustomButton.Location = new System.Drawing.Point(374, 2);
			this.txtProductsFilter.CustomButton.Name = "";
			this.txtProductsFilter.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtProductsFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtProductsFilter.CustomButton.TabIndex = 1;
			this.txtProductsFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtProductsFilter.CustomButton.UseSelectable = true;
			this.txtProductsFilter.CustomButton.Visible = false;
			this.txtProductsFilter.Lines = new string[0];
			this.txtProductsFilter.Location = new System.Drawing.Point(36, 82);
			this.txtProductsFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtProductsFilter.MaxLength = 32767;
			this.txtProductsFilter.Name = "txtProductsFilter";
			this.txtProductsFilter.PasswordChar = '\0';
			this.txtProductsFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtProductsFilter.SelectedText = "";
			this.txtProductsFilter.SelectionLength = 0;
			this.txtProductsFilter.SelectionStart = 0;
			this.txtProductsFilter.Size = new System.Drawing.Size(394, 22);
			this.txtProductsFilter.TabIndex = 0;
			this.txtProductsFilter.UseSelectable = true;
			this.txtProductsFilter.WaterMark = "Art.-Nr., Bezeichnung oder Matchcode";
			this.txtProductsFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtProductsFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtProductsFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductsFilter_KeyUp);
			// 
			// mToggleCatalogOnly
			// 
			this.mToggleCatalogOnly.AutoSize = true;
			this.mToggleCatalogOnly.Location = new System.Drawing.Point(36, 685);
			this.mToggleCatalogOnly.Name = "mToggleCatalogOnly";
			this.mToggleCatalogOnly.Size = new System.Drawing.Size(80, 17);
			this.mToggleCatalogOnly.Style = MetroFramework.MetroColorStyle.Red;
			this.mToggleCatalogOnly.TabIndex = 2;
			this.mToggleCatalogOnly.Text = "Aus";
			this.mToggleCatalogOnly.UseSelectable = true;
			this.mToggleCatalogOnly.CheckedChanged += new System.EventHandler(this.mToggleCatalogOnly_CheckedChanged);
			// 
			// lblCatalogOnly
			// 
			this.lblCatalogOnly.AutoSize = true;
			this.lblCatalogOnly.Location = new System.Drawing.Point(117, 682);
			this.lblCatalogOnly.Name = "lblCatalogOnly";
			this.lblCatalogOnly.Size = new System.Drawing.Size(115, 19);
			this.lblCatalogOnly.TabIndex = 5;
			this.lblCatalogOnly.Text = "Nur Katalogartikel";
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(567, 685);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 6;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(673, 685);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 7;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// mchkDoNotClose
			// 
			this.mchkDoNotClose.AutoSize = true;
			this.mchkDoNotClose.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkDoNotClose.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkDoNotClose.Location = new System.Drawing.Point(460, 82);
			this.mchkDoNotClose.Name = "mchkDoNotClose";
			this.mchkDoNotClose.Size = new System.Drawing.Size(154, 19);
			this.mchkDoNotClose.TabIndex = 8;
			this.mchkDoNotClose.Text = "Fenster nicht schließen";
			this.mchkDoNotClose.UseSelectable = true;
			// 
			// ProductSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(1341, 734);
			this.Controls.Add(this.mchkDoNotClose);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.lblCatalogOnly);
			this.Controls.Add(this.mToggleCatalogOnly);
			this.Controls.Add(this.txtProductsFilter);
			this.Controls.Add(this.dgvProducts);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductSearchView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Artikelsuche";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductSearchView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvProducts;
		private MetroFramework.Controls.MetroContextMenu ctxGrid;
		private MetroFramework.Controls.MetroTextBox txtProductsFilter;
		private System.Windows.Forms.ToolStripMenuItem cmnuOk;
		private MetroFramework.Controls.MetroToggle mToggleCatalogOnly;
		private MetroFramework.Controls.MetroLabel lblCatalogOnly;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTyp;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colKatalog;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelgruppe;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVerkaufspreis1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenpreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProzent;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowLager;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
		private MetroFramework.Controls.MetroCheckBox mchkDoNotClose;
	}
}