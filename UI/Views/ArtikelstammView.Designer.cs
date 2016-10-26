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
			this.dgvArtikel = new MetroFramework.Controls.MetroGrid();
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
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.mcmdAuftraege = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdShowInventoryView = new System.Windows.Forms.ToolStripMenuItem();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.mtoolTip = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.btnChangeKunde = new System.Windows.Forms.Button();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvArtikel
			// 
			this.dgvArtikel.AllowUserToAddRows = false;
			this.dgvArtikel.AllowUserToDeleteRows = false;
			this.dgvArtikel.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvArtikel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvArtikel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvArtikel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvArtikel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvArtikel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvArtikel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArtikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dgvArtikel.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvArtikel.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvArtikel.EnableHeadersVisualStyles = false;
			this.dgvArtikel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvArtikel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvArtikel.HighLightPercentage = 0.99F;
			this.dgvArtikel.Location = new System.Drawing.Point(23, 129);
			this.dgvArtikel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvArtikel.Name = "dgvArtikel";
			this.dgvArtikel.ReadOnly = true;
			this.dgvArtikel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvArtikel.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvArtikel.RowHeadersVisible = false;
			this.dgvArtikel.RowHeadersWidth = 21;
			this.dgvArtikel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvArtikel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArtikel.Size = new System.Drawing.Size(1101, 513);
			this.dgvArtikel.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvArtikel.TabIndex = 0;
			this.dgvArtikel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikel_RowEnter);
			this.dgvArtikel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArtikel_RowHeaderMouseClick);
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
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.mcmdAuftraege,
						this.xcmdShowInventoryView});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new System.Drawing.Size(146, 48);
			// 
			// mcmdAuftraege
			// 
			this.mcmdAuftraege.Image = global::Products.Common.Properties.Resources.auftrag_16_metrogreen;
			this.mcmdAuftraege.Name = "mcmdAuftraege";
			this.mcmdAuftraege.Size = new System.Drawing.Size(145, 22);
			this.mcmdAuftraege.Text = "Aufträge";
			this.mcmdAuftraege.Click += new System.EventHandler(this.mcmdAuftraege_Click);
			// 
			// xcmdShowInventoryView
			// 
			this.xcmdShowInventoryView.Image = global::Products.Common.Properties.Resources.lager_16_metrored;
			this.xcmdShowInventoryView.Name = "xcmdShowInventoryView";
			this.xcmdShowInventoryView.Size = new System.Drawing.Size(145, 22);
			this.xcmdShowInventoryView.Text = "Lagerbestand";
			this.xcmdShowInventoryView.Click += new System.EventHandler(this.xcmdShowInventoryView_Click);
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(312, 1);
			this.mtxtFilter.CustomButton.Name = "";
			this.mtxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtFilter.CustomButton.TabIndex = 1;
			this.mtxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFilter.CustomButton.UseSelectable = true;
			this.mtxtFilter.CustomButton.Visible = false;
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
			this.mtxtFilter.ShortcutsEnabled = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(334, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Red;
			this.mtxtFilter.TabIndex = 2;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.UseStyleColors = true;
			this.mtxtFilter.WaterMark = "Art.-Nr., Bezeichnung oder Matchcode eingeben";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.mtxtFilter_ClearClicked);
			// 
			// mtoolTip
			// 
			this.mtoolTip.OwnerDraw = true;
			// 
			// btnChangeKunde
			// 
			this.btnChangeKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnChangeKunde.BackColor = System.Drawing.Color.Transparent;
			this.btnChangeKunde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnChangeKunde.FlatAppearance.BorderSize = 0;
			this.btnChangeKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeKunde.Image = global::Products.Common.Properties.Resources.kunde_32_metrored;
			this.btnChangeKunde.Location = new System.Drawing.Point(363, 87);
			this.btnChangeKunde.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnChangeKunde.Name = "btnChangeKunde";
			this.btnChangeKunde.Size = new System.Drawing.Size(36, 36);
			this.btnChangeKunde.TabIndex = 11;
			this.btnChangeKunde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mtoolTip.SetToolTip(this.btnChangeKunde, "Den Artikelstamm eines  anderen Kunden anzeigen");
			this.btnChangeKunde.UseVisualStyleBackColor = false;
			this.btnChangeKunde.Click += new System.EventHandler(this.btnChangeKunde_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1024, 665);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 12;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// ArtikelstammView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 714);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.btnChangeKunde);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.dgvArtikel);
			this.Name = "ArtikelstammView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Artikelstamm";
			((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).EndInit();
			this.mctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvArtikel;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private Button btnChangeKunde;
		private MetroFramework.Drawing.Html.HtmlToolTip mtoolTip;
		private MetroFramework.Controls.MetroContextMenu mctxGrid;
		private ToolStripMenuItem mcmdAuftraege;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private ToolStripMenuItem xcmdShowInventoryView;
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