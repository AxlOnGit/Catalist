using System.Drawing;
using System.Windows.Forms;

namespace Products.Common.Views
{
	partial class ArtikelstammView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvArtikel = new MetroFramework.Controls.MetroGrid();
            this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtikelgruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEinkaufspreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerkaufspreis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKundenpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProzent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCtxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.MCmdAuftraege = new System.Windows.Forms.ToolStripMenuItem();
            this.XCmdShowInventoryView = new System.Windows.Forms.ToolStripMenuItem();
            this.MTxtFilter = new MetroFramework.Controls.MetroTextBox();
            this.MToolTip = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.BtnChangeKunde = new System.Windows.Forms.Button();
            this.MbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtikel)).BeginInit();
            this.MCtxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtikel
            // 
            this.DgvArtikel.AllowUserToAddRows = false;
            this.DgvArtikel.AllowUserToDeleteRows = false;
            this.DgvArtikel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DgvArtikel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvArtikel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvArtikel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArtikel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvArtikel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvArtikel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArtikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colArtikel,
            this.colBezeichnung1,
            this.colBezeichnung2,
            this.colArtikelgruppe,
            this.colMengeneinheit,
            this.colEinkaufspreis,
            this.colVerkaufspreis1,
            this.colKundenpreis,
            this.colProzent});
            this.DgvArtikel.ContextMenuStrip = this.MCtxGrid;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvArtikel.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvArtikel.EnableHeadersVisualStyles = false;
            this.DgvArtikel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvArtikel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvArtikel.HighLightPercentage = 0.99F;
            this.DgvArtikel.Location = new System.Drawing.Point(23, 129);
            this.DgvArtikel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.DgvArtikel.Name = "dgvArtikel";
            this.DgvArtikel.ReadOnly = true;
            this.DgvArtikel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvArtikel.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvArtikel.RowHeadersVisible = false;
            this.DgvArtikel.RowHeadersWidth = 21;
            this.DgvArtikel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvArtikel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArtikel.Size = new System.Drawing.Size(1101, 513);
            this.DgvArtikel.Style = MetroFramework.MetroColorStyle.Red;
            this.DgvArtikel.TabIndex = 0;
            this.DgvArtikel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArtikel_RowEnter);
            this.DgvArtikel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvArtikel_RowHeaderMouseClick);
            // 
            // colTyp
            // 
            this.colTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTyp.DataPropertyName = "Typ";
            this.colTyp.HeaderText = "Typ";
            this.colTyp.Name = "colTyp";
            this.colTyp.ReadOnly = true;
            // 
            // colArtikel
            // 
            this.colArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArtikel.DataPropertyName = "Artikelnummer";
            this.colArtikel.HeaderText = "Art.-Nr.";
            this.colArtikel.Name = "colArtikel";
            this.colArtikel.ReadOnly = true;
            // 
            // colBezeichnung1
            // 
            this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
            this.colBezeichnung1.HeaderText = "Artikelname";
            this.colBezeichnung1.Name = "colBezeichnung1";
            this.colBezeichnung1.ReadOnly = true;
            // 
            // colBezeichnung2
            // 
            this.colBezeichnung2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
            this.colBezeichnung2.HeaderText = "Artikelzusatz";
            this.colBezeichnung2.Name = "colBezeichnung2";
            this.colBezeichnung2.ReadOnly = true;
            // 
            // colArtikelgruppe
            // 
            this.colArtikelgruppe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArtikelgruppe.DataPropertyName = "Artikelgruppe";
            this.colArtikelgruppe.HeaderText = "Art.-Gruppe";
            this.colArtikelgruppe.Name = "colArtikelgruppe";
            this.colArtikelgruppe.ReadOnly = true;
            // 
            // colMengeneinheit
            // 
            this.colMengeneinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
            this.colMengeneinheit.HeaderText = "ME";
            this.colMengeneinheit.Name = "colMengeneinheit";
            this.colMengeneinheit.ReadOnly = true;
            // 
            // colEinkaufspreis
            // 
            this.colEinkaufspreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEinkaufspreis.DataPropertyName = "EK";
            this.colEinkaufspreis.HeaderText = "EK";
            this.colEinkaufspreis.Name = "colEinkaufspreis";
            this.colEinkaufspreis.ReadOnly = true;
            // 
            // colVerkaufspreis1
            // 
            this.colVerkaufspreis1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVerkaufspreis1.DataPropertyName = "Verkaufspreis1";
            this.colVerkaufspreis1.HeaderText = "Normalpreis";
            this.colVerkaufspreis1.Name = "colVerkaufspreis1";
            this.colVerkaufspreis1.ReadOnly = true;
            // 
            // colKundenpreis
            // 
            this.colKundenpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKundenpreis.DataPropertyName = "Kundenpreis";
            this.colKundenpreis.HeaderText = "Kundenpreis";
            this.colKundenpreis.Name = "colKundenpreis";
            this.colKundenpreis.ReadOnly = true;
            // 
            // colProzent
            // 
            this.colProzent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProzent.DataPropertyName = "Prozent";
            this.colProzent.HeaderText = "Rabatt (%)";
            this.colProzent.Name = "colProzent";
            this.colProzent.ReadOnly = true;
            // 
            // MCtxGrid
            // 
            this.MCtxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCmdAuftraege,
            this.XCmdShowInventoryView});
            this.MCtxGrid.Name = "mctxGrid";
            this.MCtxGrid.Size = new System.Drawing.Size(146, 48);
            // 
            // MCmdAuftraege
            // 
            this.MCmdAuftraege.Image = global::Products.Common.Properties.Resources.auftrag_16_metrogreen;
            this.MCmdAuftraege.Name = "MCmdAuftraege";
            this.MCmdAuftraege.Size = new System.Drawing.Size(145, 22);
            this.MCmdAuftraege.Text = "Aufträge";
            this.MCmdAuftraege.Click += new System.EventHandler(this.McmdAuftraege_Click);
            // 
            // XCmdShowInventoryView
            // 
            this.XCmdShowInventoryView.Image = global::Products.Common.Properties.Resources.lager_16_metrored;
            this.XCmdShowInventoryView.Name = "XCmdShowInventoryView";
            this.XCmdShowInventoryView.Size = new System.Drawing.Size(145, 22);
            this.XCmdShowInventoryView.Text = "Lagerbestand";
            this.XCmdShowInventoryView.Click += new System.EventHandler(this.XcmdShowInventoryView_Click);
            // 
            // mtxtFilter
            // 
            // 
            // 
            // 
            this.MTxtFilter.CustomButton.Image = null;
            this.MTxtFilter.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.MTxtFilter.CustomButton.Name = "";
            this.MTxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtFilter.CustomButton.TabIndex = 1;
            this.MTxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtFilter.CustomButton.UseSelectable = true;
            this.MTxtFilter.CustomButton.Visible = false;
            this.MTxtFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MTxtFilter.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.MTxtFilter.Lines = new string[0];
            this.MTxtFilter.Location = new System.Drawing.Point(23, 100);
            this.MTxtFilter.MaxLength = 32767;
            this.MTxtFilter.Name = "mtxtFilter";
            this.MTxtFilter.PasswordChar = '\0';
            this.MTxtFilter.WaterMark = "Art.-Nr., Bezeichnung oder Matchcode eingeben";
            this.MTxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtFilter.SelectedText = "";
            this.MTxtFilter.SelectionLength = 0;
            this.MTxtFilter.SelectionStart = 0;
            this.MTxtFilter.ShortcutsEnabled = true;
            this.MTxtFilter.ShowClearButton = true;
            this.MTxtFilter.Size = new System.Drawing.Size(334, 23);
            this.MTxtFilter.Style = MetroFramework.MetroColorStyle.Red;
            this.MTxtFilter.TabIndex = 2;
            this.MTxtFilter.UseSelectable = true;
            this.MTxtFilter.UseStyleColors = true;
            this.MTxtFilter.WaterMark = "Art.-Nr., Bezeichnung oder Matchcode eingeben";
            this.MTxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.MtxtFilter_ClearClicked);
            // 
            // MToolTip
            // 
            this.MToolTip.OwnerDraw = true;
            // 
            // BtnChangeKunde
            // 
            this.BtnChangeKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnChangeKunde.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangeKunde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnChangeKunde.FlatAppearance.BorderSize = 0;
            this.BtnChangeKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeKunde.Image = global::Products.Common.Properties.Resources.kunde_32_metrored;
            this.BtnChangeKunde.Location = new System.Drawing.Point(363, 87);
            this.BtnChangeKunde.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.BtnChangeKunde.Name = "BtnChangeKunde";
            this.BtnChangeKunde.Size = new System.Drawing.Size(36, 36);
            this.BtnChangeKunde.TabIndex = 11;
            this.BtnChangeKunde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MToolTip.SetToolTip(this.BtnChangeKunde, "Den Artikelstamm eines  anderen Kunden anzeigen");
            this.BtnChangeKunde.UseVisualStyleBackColor = false;
            this.BtnChangeKunde.Click += new System.EventHandler(this.BtnChangeKunde_Click);
            // 
            // MbtnClose
            // 
            this.MbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MbtnClose.Image = null;
            this.MbtnClose.Location = new System.Drawing.Point(1024, 665);
            this.MbtnClose.Name = "MbtnClose";
            this.MbtnClose.Size = new System.Drawing.Size(100, 26);
            this.MbtnClose.TabIndex = 12;
            this.MbtnClose.Text = "Schließen";
            this.MbtnClose.UseSelectable = true;
            this.MbtnClose.UseVisualStyleBackColor = true;
            this.MbtnClose.Click += new System.EventHandler(this.MbtnClose_Click);
            // 
            // ArtikelstammView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 714);
            this.Controls.Add(this.MbtnClose);
            this.Controls.Add(this.BtnChangeKunde);
            this.Controls.Add(this.MTxtFilter);
            this.Controls.Add(this.DgvArtikel);
            this.Name = "ArtikelstammView";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Artikelstamm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtikel)).EndInit();
            this.MCtxGrid.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid DgvArtikel;
		private MetroFramework.Controls.MetroTextBox MTxtFilter;
		private Button BtnChangeKunde;
		private MetroFramework.Drawing.Html.HtmlToolTip MToolTip;
		private MetroFramework.Controls.MetroContextMenu MCtxGrid;
		private ToolStripMenuItem MCmdAuftraege;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton MbtnClose;
		private ToolStripMenuItem XCmdShowInventoryView;
		private DataGridViewTextBoxColumn colTyp;
		private DataGridViewTextBoxColumn colArtikel;
		private DataGridViewTextBoxColumn colBezeichnung1;
		private DataGridViewTextBoxColumn colBezeichnung2;
		private DataGridViewTextBoxColumn colArtikelgruppe;
		private DataGridViewTextBoxColumn colMengeneinheit;
		private DataGridViewTextBoxColumn colEinkaufspreis;
		private DataGridViewTextBoxColumn colVerkaufspreis1;
		private DataGridViewTextBoxColumn colKundenpreis;
		private DataGridViewTextBoxColumn colProzent;
	}
}