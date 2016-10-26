namespace Products.Common.Views
{
	partial class LieferantenListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LieferantenListView));
			this.dgvSuppliers = new MetroFramework.Controls.MetroGrid();
			this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdPurchaseOrders = new System.Windows.Forms.ToolStripMenuItem();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.btnChangeKunde = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSuppliers
			// 
			this.dgvSuppliers.AllowUserToResizeRows = false;
			this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName1,
            this.colName2,
            this.colStrasse,
            this.colPostleitzahl,
            this.colOrt,
            this.colTelefon});
			this.dgvSuppliers.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSuppliers.EnableHeadersVisualStyles = false;
			this.dgvSuppliers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSuppliers.HighLightPercentage = 1.2F;
			this.dgvSuppliers.Location = new System.Drawing.Point(23, 129);
			this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvSuppliers.Name = "dgvSuppliers";
			this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSuppliers.RowHeadersVisible = false;
			this.dgvSuppliers.RowHeadersWidth = 21;
			this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSuppliers.Size = new System.Drawing.Size(969, 574);
			this.dgvSuppliers.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvSuppliers.TabIndex = 1;
			this.dgvSuppliers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_RowEnter);
			// 
			// colName1
			// 
			this.colName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName1.DataPropertyName = "Name1";
			this.colName1.FillWeight = 20F;
			this.colName1.HeaderText = "Firma";
			this.colName1.Name = "colName1";
			// 
			// colName2
			// 
			this.colName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName2.DataPropertyName = "Name2";
			this.colName2.FillWeight = 20F;
			this.colName2.HeaderText = "Firmenzusatz";
			this.colName2.Name = "colName2";
			// 
			// colStrasse
			// 
			this.colStrasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStrasse.DataPropertyName = "Strasse";
			this.colStrasse.FillWeight = 20F;
			this.colStrasse.HeaderText = "Straße";
			this.colStrasse.Name = "colStrasse";
			// 
			// colPostleitzahl
			// 
			this.colPostleitzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPostleitzahl.DataPropertyName = "Postleitzahl";
			this.colPostleitzahl.FillWeight = 5F;
			this.colPostleitzahl.HeaderText = "Plz";
			this.colPostleitzahl.Name = "colPostleitzahl";
			// 
			// colOrt
			// 
			this.colOrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOrt.DataPropertyName = "Ort";
			this.colOrt.FillWeight = 20F;
			this.colOrt.HeaderText = "Ort";
			this.colOrt.MinimumWidth = 20;
			this.colOrt.Name = "colOrt";
			// 
			// colTelefon
			// 
			this.colTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTelefon.DataPropertyName = "Telefon";
			this.colTelefon.FillWeight = 10F;
			this.colTelefon.HeaderText = "Telefon";
			this.colTelefon.MinimumWidth = 15;
			this.colTelefon.Name = "colTelefon";
			// 
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdPurchaseOrders});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new System.Drawing.Size(143, 26);
			// 
			// xcmdPurchaseOrders
			// 
			this.xcmdPurchaseOrders.Image = global::Products.Common.Properties.Resources.purchase_16_metrored;
			this.xcmdPurchaseOrders.Name = "xcmdPurchaseOrders";
			this.xcmdPurchaseOrders.Size = new System.Drawing.Size(142, 22);
			this.xcmdPurchaseOrders.Text = "Bestellungen";
			this.xcmdPurchaseOrders.Click += new System.EventHandler(this.xcmdPurchaseOrders_Click);
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(391, 1);
			this.mtxtFilter.CustomButton.Name = "";
			this.mtxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtFilter.CustomButton.TabIndex = 1;
			this.mtxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFilter.CustomButton.UseSelectable = true;
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
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(413, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Red;
			this.mtxtFilter.TabIndex = 0;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Lieferanten-Nr, Matchcode oder Firma";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.mtxtFilter_ClearClicked);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFilter_KeyUp);
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(772, 729);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 2;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(885, 729);
			this.mbtnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 3;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// btnChangeKunde
			// 
			this.btnChangeKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnChangeKunde.BackColor = System.Drawing.Color.Transparent;
			this.btnChangeKunde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnChangeKunde.FlatAppearance.BorderSize = 0;
			this.btnChangeKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeKunde.Image = global::Products.Common.Properties.Resources.purchase_32_metrored;
			this.btnChangeKunde.Location = new System.Drawing.Point(459, 87);
			this.btnChangeKunde.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
			this.btnChangeKunde.Name = "btnChangeKunde";
			this.btnChangeKunde.Size = new System.Drawing.Size(36, 36);
			this.btnChangeKunde.TabIndex = 12;
			this.btnChangeKunde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip1.SetToolTip(this.btnChangeKunde, "Zeigt die Bestellungen des ausgewählten Lieferanten an");
			this.btnChangeKunde.UseVisualStyleBackColor = false;
			this.btnChangeKunde.Click += new System.EventHandler(this.btnChangeKunde_Click);
			// 
			// LieferantenListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 778);
			this.ControlBox = false;
			this.Controls.Add(this.btnChangeKunde);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.dgvSuppliers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LieferantenListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Lieferanten";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LieferantenListView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
			this.mctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvSuppliers;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStrasse;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private MetroFramework.Controls.MetroContextMenu mctxGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdPurchaseOrders;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
		private System.Windows.Forms.Button btnChangeKunde;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}