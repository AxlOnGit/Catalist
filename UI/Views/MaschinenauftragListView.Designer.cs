namespace Products.Common.Views
{
	partial class MaschinenauftragListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaschinenauftragListView));
			this.dgvMaschinenauftraege = new MetroFramework.Controls.MetroGrid();
			this.ctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdShowMaschinenauftrag = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdShowCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdShowMachine = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mbtnNew = new MetroFramework.Controls.MetroButton();
			this.mtogglAlleAnzeigen = new MetroFramework.Controls.MetroToggle();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mtxtKundenbestellungAm = new MetroFramework.Controls.MetroTextBox();
			this.mtxtMaschinenbestellungAm = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.mtxtLieferungZumKundenAm = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.mtxtMaschinenlieferungAm = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.mtxtRechnungsOderLieferdatum = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.mlblAuftragstitel = new MetroFramework.Controls.MetroLabel();
			this.mtxtAnmerkungenBestellung = new MetroFramework.Controls.MetroTextBox();
			this.mlnkSchrift = new MetroFramework.Controls.MetroLink();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinenmodell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLieferungZumKundenAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAuftragErledigtFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colHasAnmerkungenBestellung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaschinenauftraege)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMaschinenauftraege
			// 
			this.dgvMaschinenauftraege.AllowUserToAddRows = false;
			this.dgvMaschinenauftraege.AllowUserToDeleteRows = false;
			this.dgvMaschinenauftraege.AllowUserToResizeRows = false;
			this.dgvMaschinenauftraege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMaschinenauftraege.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMaschinenauftraege.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMaschinenauftraege.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvMaschinenauftraege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMaschinenauftraege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMaschinenauftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaschinenauftraege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundennummer,
            this.colMatchcode,
            this.colMaschinenmodell,
            this.col2,
            this.colLieferungZumKundenAm,
            this.colAuftragErledigtFlag,
            this.colHasAnmerkungenBestellung});
			this.dgvMaschinenauftraege.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMaschinenauftraege.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMaschinenauftraege.EnableHeadersVisualStyles = false;
			this.dgvMaschinenauftraege.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMaschinenauftraege.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMaschinenauftraege.HighLightPercentage = 1.2F;
			this.dgvMaschinenauftraege.Location = new System.Drawing.Point(23, 100);
			this.dgvMaschinenauftraege.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvMaschinenauftraege.Name = "dgvMaschinenauftraege";
			this.dgvMaschinenauftraege.ReadOnly = true;
			this.dgvMaschinenauftraege.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMaschinenauftraege.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvMaschinenauftraege.RowHeadersVisible = false;
			this.dgvMaschinenauftraege.RowHeadersWidth = 21;
			this.dgvMaschinenauftraege.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMaschinenauftraege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMaschinenauftraege.Size = new System.Drawing.Size(938, 397);
			this.dgvMaschinenauftraege.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvMaschinenauftraege.TabIndex = 10;
			this.dgvMaschinenauftraege.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaschinenauftraege_RowEnter);
			this.dgvMaschinenauftraege.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMaschinenauftraege_MouseDoubleClick);
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowMaschinenauftrag,
            this.xcmdShowCustomer,
            this.xcmdShowMachine,
            this.toolStripMenuItem1,
            this.xcmdOpenInExplorer});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(172, 98);
			// 
			// xcmdShowMaschinenauftrag
			// 
			this.xcmdShowMaschinenauftrag.Image = global::Products.Common.Properties.Resources.auftrag_16_metrogreen;
			this.xcmdShowMaschinenauftrag.Name = "xcmdShowMaschinenauftrag";
			this.xcmdShowMaschinenauftrag.Size = new System.Drawing.Size(171, 22);
			this.xcmdShowMaschinenauftrag.Text = "Auftrag öffnen";
			this.xcmdShowMaschinenauftrag.Click += new System.EventHandler(this.xcmdShowMaschinenauftrag_Click);
			// 
			// xcmdShowCustomer
			// 
			this.xcmdShowCustomer.Image = global::Products.Common.Properties.Resources.customer_16_metrogreen;
			this.xcmdShowCustomer.Name = "xcmdShowCustomer";
			this.xcmdShowCustomer.Size = new System.Drawing.Size(171, 22);
			this.xcmdShowCustomer.Text = "Kunden öffnen";
			this.xcmdShowCustomer.Click += new System.EventHandler(this.xcmdShowCustomer_Click);
			// 
			// xcmdShowMachine
			// 
			this.xcmdShowMachine.Image = global::Products.Common.Properties.Resources.machine_16_metrogreen;
			this.xcmdShowMachine.Name = "xcmdShowMachine";
			this.xcmdShowMachine.Size = new System.Drawing.Size(171, 22);
			this.xcmdShowMachine.Text = "Maschine öffnen";
			this.xcmdShowMachine.Click += new System.EventHandler(this.xcmdShowMachine_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
			// 
			// xcmdOpenInExplorer
			// 
			this.xcmdOpenInExplorer.Image = global::Products.Common.Properties.Resources.explorer_exe_original;
			this.xcmdOpenInExplorer.Name = "xcmdOpenInExplorer";
			this.xcmdOpenInExplorer.Size = new System.Drawing.Size(171, 22);
			this.xcmdOpenInExplorer.Text = "Im Explorer öffnen";
			this.xcmdOpenInExplorer.Click += new System.EventHandler(this.xcmdOpenInExplorer_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(861, 786);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Green;
			this.mbtnClose.TabIndex = 25;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnNew
			// 
			this.mbtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnNew.Location = new System.Drawing.Point(861, 68);
			this.mbtnNew.Name = "mbtnNew";
			this.mbtnNew.Size = new System.Drawing.Size(100, 26);
			this.mbtnNew.Style = MetroFramework.MetroColorStyle.Green;
			this.mbtnNew.TabIndex = 20;
			this.mbtnNew.Text = "&Neu ...";
			this.mbtnNew.UseCustomBackColor = true;
			this.mbtnNew.UseSelectable = true;
			this.mbtnNew.UseStyleColors = true;
			this.mbtnNew.Click += new System.EventHandler(this.mbtnNew_Click);
			// 
			// mtogglAlleAnzeigen
			// 
			this.mtogglAlleAnzeigen.AutoSize = true;
			this.mtogglAlleAnzeigen.Location = new System.Drawing.Point(171, 77);
			this.mtogglAlleAnzeigen.Name = "mtogglAlleAnzeigen";
			this.mtogglAlleAnzeigen.Size = new System.Drawing.Size(80, 17);
			this.mtogglAlleAnzeigen.Style = MetroFramework.MetroColorStyle.Green;
			this.mtogglAlleAnzeigen.TabIndex = 5;
			this.mtogglAlleAnzeigen.Text = "Aus";
			this.mtogglAlleAnzeigen.UseSelectable = true;
			this.mtogglAlleAnzeigen.CheckedChanged += new System.EventHandler(this.mtogglAlleAnzeigen_CheckedChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 75);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(142, 19);
			this.metroLabel1.TabIndex = 4;
			this.metroLabel1.Text = "Alle Aufträge anzeigen";
			// 
			// metroLabel2
			// 
			this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 564);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(127, 19);
			this.metroLabel2.TabIndex = 5;
			this.metroLabel2.Text = "Bestelldatum Kunde:";
			// 
			// mtxtKundenbestellungAm
			// 
			this.mtxtKundenbestellungAm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.mtxtKundenbestellungAm.CustomButton.Image = null;
			this.mtxtKundenbestellungAm.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.mtxtKundenbestellungAm.CustomButton.Name = "";
			this.mtxtKundenbestellungAm.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtKundenbestellungAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtKundenbestellungAm.CustomButton.TabIndex = 1;
			this.mtxtKundenbestellungAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtKundenbestellungAm.CustomButton.UseSelectable = true;
			this.mtxtKundenbestellungAm.CustomButton.Visible = false;
			this.mtxtKundenbestellungAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtKundenbestellungAm.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtKundenbestellungAm.Lines = new string[] {
        "-"};
			this.mtxtKundenbestellungAm.Location = new System.Drawing.Point(176, 562);
			this.mtxtKundenbestellungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtKundenbestellungAm.MaxLength = 32767;
			this.mtxtKundenbestellungAm.Name = "mtxtKundenbestellungAm";
			this.mtxtKundenbestellungAm.PasswordChar = '\0';
			this.mtxtKundenbestellungAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtKundenbestellungAm.SelectedText = "";
			this.mtxtKundenbestellungAm.SelectionLength = 0;
			this.mtxtKundenbestellungAm.SelectionStart = 0;
			this.mtxtKundenbestellungAm.ShortcutsEnabled = true;
			this.mtxtKundenbestellungAm.Size = new System.Drawing.Size(78, 23);
			this.mtxtKundenbestellungAm.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtKundenbestellungAm.TabIndex = 6;
			this.mtxtKundenbestellungAm.Text = "-";
			this.mtxtKundenbestellungAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtKundenbestellungAm.UseSelectable = true;
			this.mtxtKundenbestellungAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtKundenbestellungAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtMaschinenbestellungAm
			// 
			this.mtxtMaschinenbestellungAm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.mtxtMaschinenbestellungAm.CustomButton.Image = null;
			this.mtxtMaschinenbestellungAm.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.mtxtMaschinenbestellungAm.CustomButton.Name = "";
			this.mtxtMaschinenbestellungAm.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtMaschinenbestellungAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtMaschinenbestellungAm.CustomButton.TabIndex = 1;
			this.mtxtMaschinenbestellungAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtMaschinenbestellungAm.CustomButton.UseSelectable = true;
			this.mtxtMaschinenbestellungAm.CustomButton.Visible = false;
			this.mtxtMaschinenbestellungAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtMaschinenbestellungAm.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtMaschinenbestellungAm.Lines = new string[] {
        "-"};
			this.mtxtMaschinenbestellungAm.Location = new System.Drawing.Point(176, 598);
			this.mtxtMaschinenbestellungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtMaschinenbestellungAm.MaxLength = 32767;
			this.mtxtMaschinenbestellungAm.Name = "mtxtMaschinenbestellungAm";
			this.mtxtMaschinenbestellungAm.PasswordChar = '\0';
			this.mtxtMaschinenbestellungAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtMaschinenbestellungAm.SelectedText = "";
			this.mtxtMaschinenbestellungAm.SelectionLength = 0;
			this.mtxtMaschinenbestellungAm.SelectionStart = 0;
			this.mtxtMaschinenbestellungAm.ShortcutsEnabled = true;
			this.mtxtMaschinenbestellungAm.Size = new System.Drawing.Size(78, 23);
			this.mtxtMaschinenbestellungAm.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtMaschinenbestellungAm.TabIndex = 8;
			this.mtxtMaschinenbestellungAm.Text = "-";
			this.mtxtMaschinenbestellungAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtMaschinenbestellungAm.UseSelectable = true;
			this.mtxtMaschinenbestellungAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtMaschinenbestellungAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 600);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(147, 19);
			this.metroLabel3.TabIndex = 7;
			this.metroLabel3.Text = "Bestellt beim Hersteller:";
			// 
			// mtxtLieferungZumKundenAm
			// 
			this.mtxtLieferungZumKundenAm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.mtxtLieferungZumKundenAm.CustomButton.Image = null;
			this.mtxtLieferungZumKundenAm.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.mtxtLieferungZumKundenAm.CustomButton.Name = "";
			this.mtxtLieferungZumKundenAm.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtLieferungZumKundenAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtLieferungZumKundenAm.CustomButton.TabIndex = 1;
			this.mtxtLieferungZumKundenAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtLieferungZumKundenAm.CustomButton.UseSelectable = true;
			this.mtxtLieferungZumKundenAm.CustomButton.Visible = false;
			this.mtxtLieferungZumKundenAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtLieferungZumKundenAm.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtLieferungZumKundenAm.Lines = new string[] {
        "-"};
			this.mtxtLieferungZumKundenAm.Location = new System.Drawing.Point(417, 562);
			this.mtxtLieferungZumKundenAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtLieferungZumKundenAm.MaxLength = 32767;
			this.mtxtLieferungZumKundenAm.Name = "mtxtLieferungZumKundenAm";
			this.mtxtLieferungZumKundenAm.PasswordChar = '\0';
			this.mtxtLieferungZumKundenAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtLieferungZumKundenAm.SelectedText = "";
			this.mtxtLieferungZumKundenAm.SelectionLength = 0;
			this.mtxtLieferungZumKundenAm.SelectionStart = 0;
			this.mtxtLieferungZumKundenAm.ShortcutsEnabled = true;
			this.mtxtLieferungZumKundenAm.Size = new System.Drawing.Size(78, 23);
			this.mtxtLieferungZumKundenAm.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtLieferungZumKundenAm.TabIndex = 10;
			this.mtxtLieferungZumKundenAm.Text = "-";
			this.mtxtLieferungZumKundenAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtLieferungZumKundenAm.UseSelectable = true;
			this.mtxtLieferungZumKundenAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtLieferungZumKundenAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel4
			// 
			this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(283, 564);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(126, 19);
			this.metroLabel4.TabIndex = 9;
			this.metroLabel4.Text = "Lieferwunsch Kunde:";
			// 
			// mtxtMaschinenlieferungAm
			// 
			this.mtxtMaschinenlieferungAm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.mtxtMaschinenlieferungAm.CustomButton.Image = null;
			this.mtxtMaschinenlieferungAm.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.mtxtMaschinenlieferungAm.CustomButton.Name = "";
			this.mtxtMaschinenlieferungAm.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtMaschinenlieferungAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtMaschinenlieferungAm.CustomButton.TabIndex = 1;
			this.mtxtMaschinenlieferungAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtMaschinenlieferungAm.CustomButton.UseSelectable = true;
			this.mtxtMaschinenlieferungAm.CustomButton.Visible = false;
			this.mtxtMaschinenlieferungAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtMaschinenlieferungAm.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtMaschinenlieferungAm.Lines = new string[] {
        "-"};
			this.mtxtMaschinenlieferungAm.Location = new System.Drawing.Point(417, 598);
			this.mtxtMaschinenlieferungAm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtMaschinenlieferungAm.MaxLength = 32767;
			this.mtxtMaschinenlieferungAm.Name = "mtxtMaschinenlieferungAm";
			this.mtxtMaschinenlieferungAm.PasswordChar = '\0';
			this.mtxtMaschinenlieferungAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtMaschinenlieferungAm.SelectedText = "";
			this.mtxtMaschinenlieferungAm.SelectionLength = 0;
			this.mtxtMaschinenlieferungAm.SelectionStart = 0;
			this.mtxtMaschinenlieferungAm.ShortcutsEnabled = true;
			this.mtxtMaschinenlieferungAm.Size = new System.Drawing.Size(78, 23);
			this.mtxtMaschinenlieferungAm.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtMaschinenlieferungAm.TabIndex = 12;
			this.mtxtMaschinenlieferungAm.Text = "-";
			this.mtxtMaschinenlieferungAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtMaschinenlieferungAm.UseSelectable = true;
			this.mtxtMaschinenlieferungAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtMaschinenlieferungAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel5
			// 
			this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(283, 600);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(128, 19);
			this.metroLabel5.TabIndex = 11;
			this.metroLabel5.Text = "Hersteller liefert am:";
			// 
			// mtxtRechnungsOderLieferdatum
			// 
			this.mtxtRechnungsOderLieferdatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.mtxtRechnungsOderLieferdatum.CustomButton.Image = null;
			this.mtxtRechnungsOderLieferdatum.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.mtxtRechnungsOderLieferdatum.CustomButton.Name = "";
			this.mtxtRechnungsOderLieferdatum.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtRechnungsOderLieferdatum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtRechnungsOderLieferdatum.CustomButton.TabIndex = 1;
			this.mtxtRechnungsOderLieferdatum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtRechnungsOderLieferdatum.CustomButton.UseSelectable = true;
			this.mtxtRechnungsOderLieferdatum.CustomButton.Visible = false;
			this.mtxtRechnungsOderLieferdatum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtRechnungsOderLieferdatum.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtRechnungsOderLieferdatum.Lines = new string[] {
        "-"};
			this.mtxtRechnungsOderLieferdatum.Location = new System.Drawing.Point(646, 562);
			this.mtxtRechnungsOderLieferdatum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.mtxtRechnungsOderLieferdatum.MaxLength = 32767;
			this.mtxtRechnungsOderLieferdatum.Name = "mtxtRechnungsOderLieferdatum";
			this.mtxtRechnungsOderLieferdatum.PasswordChar = '\0';
			this.mtxtRechnungsOderLieferdatum.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtRechnungsOderLieferdatum.SelectedText = "";
			this.mtxtRechnungsOderLieferdatum.SelectionLength = 0;
			this.mtxtRechnungsOderLieferdatum.SelectionStart = 0;
			this.mtxtRechnungsOderLieferdatum.ShortcutsEnabled = true;
			this.mtxtRechnungsOderLieferdatum.Size = new System.Drawing.Size(78, 23);
			this.mtxtRechnungsOderLieferdatum.Style = MetroFramework.MetroColorStyle.Green;
			this.mtxtRechnungsOderLieferdatum.TabIndex = 14;
			this.mtxtRechnungsOderLieferdatum.Text = "-";
			this.mtxtRechnungsOderLieferdatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtRechnungsOderLieferdatum.UseSelectable = true;
			this.mtxtRechnungsOderLieferdatum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtRechnungsOderLieferdatum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel6
			// 
			this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(535, 564);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(105, 19);
			this.metroLabel6.TabIndex = 13;
			this.metroLabel6.Text = "Ausgeliefert am:";
			// 
			// mlblAuftragstitel
			// 
			this.mlblAuftragstitel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblAuftragstitel.AutoSize = true;
			this.mlblAuftragstitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblAuftragstitel.Location = new System.Drawing.Point(23, 517);
			this.mlblAuftragstitel.Name = "mlblAuftragstitel";
			this.mlblAuftragstitel.Size = new System.Drawing.Size(163, 25);
			this.mlblAuftragstitel.TabIndex = 15;
			this.mlblAuftragstitel.Text = "Maschine für Kunde";
			// 
			// mtxtAnmerkungenBestellung
			// 
			this.mtxtAnmerkungenBestellung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtAnmerkungenBestellung.CustomButton.Image = null;
			this.mtxtAnmerkungenBestellung.CustomButton.Location = new System.Drawing.Point(679, 2);
			this.mtxtAnmerkungenBestellung.CustomButton.Name = "";
			this.mtxtAnmerkungenBestellung.CustomButton.Size = new System.Drawing.Size(103, 103);
			this.mtxtAnmerkungenBestellung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAnmerkungenBestellung.CustomButton.TabIndex = 1;
			this.mtxtAnmerkungenBestellung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAnmerkungenBestellung.CustomButton.UseSelectable = true;
			this.mtxtAnmerkungenBestellung.CustomButton.Visible = false;
			this.mtxtAnmerkungenBestellung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAnmerkungenBestellung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtAnmerkungenBestellung.Lines = new string[0];
			this.mtxtAnmerkungenBestellung.Location = new System.Drawing.Point(176, 639);
			this.mtxtAnmerkungenBestellung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.mtxtAnmerkungenBestellung.MaxLength = 32767;
			this.mtxtAnmerkungenBestellung.Multiline = true;
			this.mtxtAnmerkungenBestellung.Name = "mtxtAnmerkungenBestellung";
			this.mtxtAnmerkungenBestellung.PasswordChar = '\0';
			this.mtxtAnmerkungenBestellung.PromptText = "Bemerkungen zur Bestellung";
			this.mtxtAnmerkungenBestellung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mtxtAnmerkungenBestellung.SelectedText = "";
			this.mtxtAnmerkungenBestellung.SelectionLength = 0;
			this.mtxtAnmerkungenBestellung.SelectionStart = 0;
			this.mtxtAnmerkungenBestellung.ShortcutsEnabled = true;
			this.mtxtAnmerkungenBestellung.Size = new System.Drawing.Size(785, 108);
			this.mtxtAnmerkungenBestellung.TabIndex = 15;
			this.mtxtAnmerkungenBestellung.UseSelectable = true;
			this.mtxtAnmerkungenBestellung.WaterMark = "Bemerkungen zur Bestellung";
			this.mtxtAnmerkungenBestellung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAnmerkungenBestellung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtAnmerkungenBestellung.Validated += new System.EventHandler(this.mtxtAnmerkungenBestellung_Validated);
			// 
			// mlnkSchrift
			// 
			this.mlnkSchrift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlnkSchrift.Location = new System.Drawing.Point(176, 748);
			this.mlnkSchrift.Name = "mlnkSchrift";
			this.mlnkSchrift.Size = new System.Drawing.Size(85, 23);
			this.mlnkSchrift.TabIndex = 26;
			this.mlnkSchrift.Text = "Schriftgröße";
			this.mlnkSchrift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkSchrift.UseSelectable = true;
			this.mlnkSchrift.Click += new System.EventHandler(this.mlnkSchrift_Click);
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Kundennummer";
			this.colKundennummer.FillWeight = 10F;
			this.colKundennummer.HeaderText = "Kd.-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			this.colKundennummer.ReadOnly = true;
			// 
			// colMatchcode
			// 
			this.colMatchcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMatchcode.DataPropertyName = "Matchcode";
			this.colMatchcode.FillWeight = 25F;
			this.colMatchcode.HeaderText = "Auftragskunde";
			this.colMatchcode.MinimumWidth = 204;
			this.colMatchcode.Name = "colMatchcode";
			this.colMatchcode.ReadOnly = true;
			this.colMatchcode.ToolTipText = "Matchcode des Auftragskunden";
			// 
			// colMaschinenmodell
			// 
			this.colMaschinenmodell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinenmodell.DataPropertyName = "Maschinenmodell";
			this.colMaschinenmodell.FillWeight = 20F;
			this.colMaschinenmodell.HeaderText = "Maschine";
			this.colMaschinenmodell.MinimumWidth = 163;
			this.colMaschinenmodell.Name = "colMaschinenmodell";
			this.colMaschinenmodell.ReadOnly = true;
			this.colMaschinenmodell.ToolTipText = "Bezeichnung des Maschinenmodells";
			// 
			// col2
			// 
			this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col2.DataPropertyName = "KundenbestellungAm";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.col2.DefaultCellStyle = dataGridViewCellStyle2;
			this.col2.FillWeight = 10F;
			this.col2.HeaderText = "Bestellung";
			this.col2.MinimumWidth = 87;
			this.col2.Name = "col2";
			this.col2.ReadOnly = true;
			this.col2.ToolTipText = "Datum, an dem der Kunde die Maschine bestellt hat";
			// 
			// colLieferungZumKundenAm
			// 
			this.colLieferungZumKundenAm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLieferungZumKundenAm.DataPropertyName = "LieferungZumKundenAm";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colLieferungZumKundenAm.DefaultCellStyle = dataGridViewCellStyle3;
			this.colLieferungZumKundenAm.FillWeight = 10F;
			this.colLieferungZumKundenAm.HeaderText = "Auslieferung";
			this.colLieferungZumKundenAm.Name = "colLieferungZumKundenAm";
			this.colLieferungZumKundenAm.ReadOnly = true;
			this.colLieferungZumKundenAm.ToolTipText = "Datum (gewünschtes) der Auslieferung an den Kunden";
			// 
			// colAuftragErledigtFlag
			// 
			this.colAuftragErledigtFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAuftragErledigtFlag.DataPropertyName = "AuftragErledigtFlag";
			this.colAuftragErledigtFlag.FillWeight = 10F;
			this.colAuftragErledigtFlag.HeaderText = "Auftrag erledigt";
			this.colAuftragErledigtFlag.Name = "colAuftragErledigtFlag";
			this.colAuftragErledigtFlag.ReadOnly = true;
			// 
			// colHasAnmerkungenBestellung
			// 
			this.colHasAnmerkungenBestellung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHasAnmerkungenBestellung.DataPropertyName = "HasAnmerkungenBestellung";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.NullValue = false;
			this.colHasAnmerkungenBestellung.DefaultCellStyle = dataGridViewCellStyle4;
			this.colHasAnmerkungenBestellung.FillWeight = 15F;
			this.colHasAnmerkungenBestellung.HeaderText = "Anmerkungen";
			this.colHasAnmerkungenBestellung.Name = "colHasAnmerkungenBestellung";
			this.colHasAnmerkungenBestellung.ReadOnly = true;
			// 
			// MaschinenauftragListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 835);
			this.Controls.Add(this.mlnkSchrift);
			this.Controls.Add(this.mtxtAnmerkungenBestellung);
			this.Controls.Add(this.mlblAuftragstitel);
			this.Controls.Add(this.mtxtRechnungsOderLieferdatum);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.mtxtMaschinenlieferungAm);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.mtxtLieferungZumKundenAm);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.mtxtMaschinenbestellungAm);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.mtxtKundenbestellungAm);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mtogglAlleAnzeigen);
			this.Controls.Add(this.mbtnNew);
			this.Controls.Add(this.dgvMaschinenauftraege);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MaschinenauftragListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Maschinenaufträge";
			((System.ComponentModel.ISupportInitialize)(this.dgvMaschinenauftraege)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroGrid dgvMaschinenauftraege;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroButton mbtnNew;
		private MetroFramework.Controls.MetroContextMenu ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowCustomer;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowMaschinenauftrag;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowMachine;
		private MetroFramework.Controls.MetroToggle mtogglAlleAnzeigen;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox mtxtKundenbestellungAm;
		private MetroFramework.Controls.MetroTextBox mtxtMaschinenbestellungAm;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox mtxtLieferungZumKundenAm;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox mtxtMaschinenlieferungAm;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox mtxtRechnungsOderLieferdatum;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel mlblAuftragstitel;
		private MetroFramework.Controls.MetroTextBox mtxtAnmerkungenBestellung;
		private MetroFramework.Controls.MetroLink mlnkSchrift;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenInExplorer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatchcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenmodell;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLieferungZumKundenAm;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colAuftragErledigtFlag;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colHasAnmerkungenBestellung;
	}
}