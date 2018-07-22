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
			this.dgvMachines = new MetroFramework.Controls.MetroGrid();
			this.colMaschinenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLetzteWartung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTerminvorschlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEntfernung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mtxtVorschlagAelterAls = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.mtxtMaxEntfernung = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xcmdShowPoisImage = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMachines
			// 
			this.dgvMachines.AllowUserToResizeRows = false;
			this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMachines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaschinenname,
            this.colKundenname,
            this.colPostleitzahl,
            this.colOrt,
            this.colLetzteWartung,
            this.colTerminvorschlag,
            this.colEntfernung});
			this.dgvMachines.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMachines.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMachines.EnableHeadersVisualStyles = false;
			this.dgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.HighLightPercentage = 1.2F;
			this.dgvMachines.Location = new System.Drawing.Point(23, 152);
			this.dgvMachines.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvMachines.RowHeadersVisible = false;
			this.dgvMachines.RowHeadersWidth = 21;
			this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMachines.Size = new System.Drawing.Size(1128, 527);
			this.dgvMachines.Style = MetroFramework.MetroColorStyle.Silver;
			this.dgvMachines.TabIndex = 0;
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
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 123);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(121, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Vorschläge älter als";
			// 
			// mtxtVorschlagAelterAls
			// 
			// 
			// 
			// 
			this.mtxtVorschlagAelterAls.CustomButton.Image = null;
			this.mtxtVorschlagAelterAls.CustomButton.Location = new System.Drawing.Point(17, 1);
			this.mtxtVorschlagAelterAls.CustomButton.Name = "";
			this.mtxtVorschlagAelterAls.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtVorschlagAelterAls.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtVorschlagAelterAls.CustomButton.TabIndex = 1;
			this.mtxtVorschlagAelterAls.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtVorschlagAelterAls.CustomButton.UseSelectable = true;
			this.mtxtVorschlagAelterAls.CustomButton.Visible = false;
			this.mtxtVorschlagAelterAls.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtVorschlagAelterAls.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtVorschlagAelterAls.Lines = new string[] {
        "12"};
			this.mtxtVorschlagAelterAls.Location = new System.Drawing.Point(146, 120);
			this.mtxtVorschlagAelterAls.MaxLength = 32767;
			this.mtxtVorschlagAelterAls.Name = "mtxtVorschlagAelterAls";
			this.mtxtVorschlagAelterAls.PasswordChar = '\0';
			this.mtxtVorschlagAelterAls.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtVorschlagAelterAls.SelectedText = "";
			this.mtxtVorschlagAelterAls.SelectionLength = 0;
			this.mtxtVorschlagAelterAls.SelectionStart = 0;
			this.mtxtVorschlagAelterAls.ShortcutsEnabled = true;
			this.mtxtVorschlagAelterAls.Size = new System.Drawing.Size(39, 23);
			this.mtxtVorschlagAelterAls.TabIndex = 0;
			this.mtxtVorschlagAelterAls.Text = "12";
			this.mtxtVorschlagAelterAls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtVorschlagAelterAls.UseSelectable = true;
			this.mtxtVorschlagAelterAls.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtVorschlagAelterAls.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtVorschlagAelterAls.Validated += new System.EventHandler(this.mtxtVorschlagAelterAls_Validated);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(187, 123);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(54, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Monate";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(525, 123);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(65, 19);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Kilometer";
			// 
			// mtxtMaxEntfernung
			// 
			// 
			// 
			// 
			this.mtxtMaxEntfernung.CustomButton.Image = null;
			this.mtxtMaxEntfernung.CustomButton.Location = new System.Drawing.Point(17, 1);
			this.mtxtMaxEntfernung.CustomButton.Name = "";
			this.mtxtMaxEntfernung.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtMaxEntfernung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtMaxEntfernung.CustomButton.TabIndex = 1;
			this.mtxtMaxEntfernung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtMaxEntfernung.CustomButton.UseSelectable = true;
			this.mtxtMaxEntfernung.CustomButton.Visible = false;
			this.mtxtMaxEntfernung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtMaxEntfernung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtMaxEntfernung.Lines = new string[] {
        "40"};
			this.mtxtMaxEntfernung.Location = new System.Drawing.Point(484, 120);
			this.mtxtMaxEntfernung.MaxLength = 32767;
			this.mtxtMaxEntfernung.Name = "mtxtMaxEntfernung";
			this.mtxtMaxEntfernung.PasswordChar = '\0';
			this.mtxtMaxEntfernung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtMaxEntfernung.SelectedText = "";
			this.mtxtMaxEntfernung.SelectionLength = 0;
			this.mtxtMaxEntfernung.SelectionStart = 0;
			this.mtxtMaxEntfernung.ShortcutsEnabled = true;
			this.mtxtMaxEntfernung.Size = new System.Drawing.Size(39, 23);
			this.mtxtMaxEntfernung.TabIndex = 4;
			this.mtxtMaxEntfernung.Text = "40";
			this.mtxtMaxEntfernung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtMaxEntfernung.UseSelectable = true;
			this.mtxtMaxEntfernung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtMaxEntfernung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtMaxEntfernung.Validated += new System.EventHandler(this.mtxtMaxEntfernung_Validated);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(324, 123);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(157, 19);
			this.metroLabel4.TabIndex = 5;
			this.metroLabel4.Text = "Entfernung nicht mehr als";
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowPoisImage});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(153, 48);
			this.ctxGrid.Opening += new System.ComponentModel.CancelEventHandler(this.ctxGrid_Opening);
			// 
			// xcmdShowPoisImage
			// 
			this.xcmdShowPoisImage.Image = global::Products.Common.Properties.Resources.pois_16_metrosilver;
			this.xcmdShowPoisImage.Name = "xcmdShowPoisImage";
			this.xcmdShowPoisImage.Size = new System.Drawing.Size(152, 22);
			this.xcmdShowPoisImage.Text = "Karte anzeigen";
			this.xcmdShowPoisImage.Click += new System.EventHandler(this.xcmdShowPoisImage_Click);
			// 
			// WartungsvorschlagView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1174, 751);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.mtxtMaxEntfernung);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mtxtVorschlagAelterAls);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.dgvMachines);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WartungsvorschlagView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "Wartungsübersicht";
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvMachines;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLetzteWartung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTerminvorschlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEntfernung;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox mtxtVorschlagAelterAls;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox mtxtMaxEntfernung;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.ContextMenuStrip ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowPoisImage;
	}
}