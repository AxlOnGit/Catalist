namespace Products.Common.Views
{
	partial class WartungsvorschlagView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WartungsvorschlagView));
            this.DgvMachines = new MetroFramework.Controls.MetroGrid();
            this.colMaschinenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKundenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetzteWartung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerminvorschlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntfernung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XCmdShowPoisImage = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.MTxtVorschlagAelterAls = new MetroFramework.Controls.MetroTextBox();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.Label4 = new MetroFramework.Controls.MetroLabel();
            this.MTxtMaxEntfernung = new MetroFramework.Controls.MetroTextBox();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMachines)).BeginInit();
            this.CtxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMachines
            // 
            this.DgvMachines.AllowUserToResizeRows = false;
            this.DgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMachines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaschinenname,
            this.colKundenname,
            this.colPostleitzahl,
            this.colOrt,
            this.colLetzteWartung,
            this.colTerminvorschlag,
            this.colEntfernung});
            this.DgvMachines.ContextMenuStrip = this.CtxGrid;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMachines.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvMachines.EnableHeadersVisualStyles = false;
            this.DgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvMachines.HighLightPercentage = 1.2F;
            this.DgvMachines.Location = new System.Drawing.Point(23, 152);
            this.DgvMachines.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.DgvMachines.Name = "DgvMachines";
            this.DgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvMachines.RowHeadersVisible = false;
            this.DgvMachines.RowHeadersWidth = 21;
            this.DgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMachines.Size = new System.Drawing.Size(1128, 527);
            this.DgvMachines.Style = MetroFramework.MetroColorStyle.Silver;
            this.DgvMachines.TabIndex = 0;
            // 
            // colMaschinenname
            // 
            this.colMaschinenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaschinenname.DataPropertyName = "Maschinenname";
            this.colMaschinenname.FillWeight = 10F;
            this.colMaschinenname.HeaderText = "Maschine";
            this.colMaschinenname.Name = "colMaschinenname";
            this.colMaschinenname.ReadOnly = true;
            // 
            // colKundenname
            // 
            this.colKundenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKundenname.DataPropertyName = "Kundenname";
            this.colKundenname.FillWeight = 25F;
            this.colKundenname.HeaderText = "Firma";
            this.colKundenname.Name = "colKundenname";
            this.colKundenname.ReadOnly = true;
            // 
            // colPostleitzahl
            // 
            this.colPostleitzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPostleitzahl.DataPropertyName = "Postleitzahl";
            this.colPostleitzahl.FillWeight = 10F;
            this.colPostleitzahl.HeaderText = "PLZ";
            this.colPostleitzahl.Name = "colPostleitzahl";
            this.colPostleitzahl.ReadOnly = true;
            // 
            // colOrt
            // 
            this.colOrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrt.DataPropertyName = "Ort";
            this.colOrt.FillWeight = 25F;
            this.colOrt.HeaderText = "Ort";
            this.colOrt.Name = "colOrt";
            this.colOrt.ReadOnly = true;
            // 
            // colLetzteWartung
            // 
            this.colLetzteWartung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLetzteWartung.DataPropertyName = "StartsAt";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colLetzteWartung.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLetzteWartung.FillWeight = 10F;
            this.colLetzteWartung.HeaderText = "Service am";
            this.colLetzteWartung.Name = "colLetzteWartung";
            this.colLetzteWartung.ReadOnly = true;
            // 
            // colTerminvorschlag
            // 
            this.colTerminvorschlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTerminvorschlag.DataPropertyName = "Terminvorschlag";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colTerminvorschlag.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTerminvorschlag.FillWeight = 10F;
            this.colTerminvorschlag.HeaderText = "Terminvorschlag";
            this.colTerminvorschlag.Name = "colTerminvorschlag";
            this.colTerminvorschlag.ReadOnly = true;
            // 
            // colEntfernung
            // 
            this.colEntfernung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEntfernung.DataPropertyName = "Entfernung";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colEntfernung.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEntfernung.FillWeight = 10F;
            this.colEntfernung.HeaderText = "Entfernung";
            this.colEntfernung.Name = "colEntfernung";
            this.colEntfernung.ReadOnly = true;
            // 
            // CtxGrid
            // 
            this.CtxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XCmdShowPoisImage});
            this.CtxGrid.Name = "ctxGrid";
            this.CtxGrid.Size = new System.Drawing.Size(152, 26);
            this.CtxGrid.Opening += new System.ComponentModel.CancelEventHandler(this.CtxGrid_Opening);
            // 
            // XCmdShowPoisImage
            // 
            this.XCmdShowPoisImage.Image = global::Products.Common.Properties.Resources.pois_16_metrosilver;
            this.XCmdShowPoisImage.Name = "XCmdShowPoisImage";
            this.XCmdShowPoisImage.Size = new System.Drawing.Size(151, 22);
            this.XCmdShowPoisImage.Text = "Karte anzeigen";
            this.XCmdShowPoisImage.Click += new System.EventHandler(this.XcmdShowPoisImage_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 123);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Vorschläge älter als";
            // 
            // MTxtVorschlagAelterAls
            // 
            // 
            // 
            // 
            this.MTxtVorschlagAelterAls.CustomButton.Image = null;
            this.MTxtVorschlagAelterAls.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.MTxtVorschlagAelterAls.CustomButton.Name = "";
            this.MTxtVorschlagAelterAls.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTxtVorschlagAelterAls.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtVorschlagAelterAls.CustomButton.TabIndex = 1;
            this.MTxtVorschlagAelterAls.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtVorschlagAelterAls.CustomButton.UseSelectable = true;
            this.MTxtVorschlagAelterAls.CustomButton.Visible = false;
            this.MTxtVorschlagAelterAls.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MTxtVorschlagAelterAls.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.MTxtVorschlagAelterAls.Lines = new string[] {
        "12"};
            this.MTxtVorschlagAelterAls.Location = new System.Drawing.Point(146, 120);
            this.MTxtVorschlagAelterAls.MaxLength = 32767;
            this.MTxtVorschlagAelterAls.Name = "MTxtVorschlagAelterAls";
            this.MTxtVorschlagAelterAls.PasswordChar = '\0';
            this.MTxtVorschlagAelterAls.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtVorschlagAelterAls.SelectedText = "";
            this.MTxtVorschlagAelterAls.SelectionLength = 0;
            this.MTxtVorschlagAelterAls.SelectionStart = 0;
            this.MTxtVorschlagAelterAls.ShortcutsEnabled = true;
            this.MTxtVorschlagAelterAls.Size = new System.Drawing.Size(39, 23);
            this.MTxtVorschlagAelterAls.TabIndex = 0;
            this.MTxtVorschlagAelterAls.Text = "12";
            this.MTxtVorschlagAelterAls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxtVorschlagAelterAls.UseSelectable = true;
            this.MTxtVorschlagAelterAls.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtVorschlagAelterAls.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTxtVorschlagAelterAls.Validated += new System.EventHandler(this.MtxtVorschlagAelterAls_Validated);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(187, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 19);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Monate";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(525, 123);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 19);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Kilometer";
            // 
            // MTxtMaxEntfernung
            // 
            // 
            // 
            // 
            this.MTxtMaxEntfernung.CustomButton.Image = null;
            this.MTxtMaxEntfernung.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.MTxtMaxEntfernung.CustomButton.Name = "";
            this.MTxtMaxEntfernung.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTxtMaxEntfernung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtMaxEntfernung.CustomButton.TabIndex = 1;
            this.MTxtMaxEntfernung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtMaxEntfernung.CustomButton.UseSelectable = true;
            this.MTxtMaxEntfernung.CustomButton.Visible = false;
            this.MTxtMaxEntfernung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MTxtMaxEntfernung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.MTxtMaxEntfernung.Lines = new string[] {
        "40"};
            this.MTxtMaxEntfernung.Location = new System.Drawing.Point(484, 120);
            this.MTxtMaxEntfernung.MaxLength = 32767;
            this.MTxtMaxEntfernung.Name = "MTxtMaxEntfernung";
            this.MTxtMaxEntfernung.PasswordChar = '\0';
            this.MTxtMaxEntfernung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtMaxEntfernung.SelectedText = "";
            this.MTxtMaxEntfernung.SelectionLength = 0;
            this.MTxtMaxEntfernung.SelectionStart = 0;
            this.MTxtMaxEntfernung.ShortcutsEnabled = true;
            this.MTxtMaxEntfernung.Size = new System.Drawing.Size(39, 23);
            this.MTxtMaxEntfernung.TabIndex = 4;
            this.MTxtMaxEntfernung.Text = "40";
            this.MTxtMaxEntfernung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxtMaxEntfernung.UseSelectable = true;
            this.MTxtMaxEntfernung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtMaxEntfernung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTxtMaxEntfernung.Validated += new System.EventHandler(this.MtxtMaxEntfernung_Validated);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(324, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 19);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Entfernung nicht mehr als";
            // 
            // WartungsvorschlagView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 751);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.MTxtMaxEntfernung);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.MTxtVorschlagAelterAls);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DgvMachines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WartungsvorschlagView";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Wartungsübersicht";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMachines)).EndInit();
            this.CtxGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid DgvMachines;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLetzteWartung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTerminvorschlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEntfernung;
		private MetroFramework.Controls.MetroLabel Label1;
		private MetroFramework.Controls.MetroTextBox MTxtVorschlagAelterAls;
		private MetroFramework.Controls.MetroLabel Label2;
		private MetroFramework.Controls.MetroLabel Label4;
		private MetroFramework.Controls.MetroTextBox MTxtMaxEntfernung;
		private MetroFramework.Controls.MetroLabel Label3;
		private System.Windows.Forms.ContextMenuStrip CtxGrid;
		private System.Windows.Forms.ToolStripMenuItem XCmdShowPoisImage;
	}
}