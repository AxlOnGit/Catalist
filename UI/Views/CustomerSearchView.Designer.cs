namespace Products.Common.Views
{
	partial class CustomerSearchView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCustomers = new MetroFramework.Controls.MetroGrid();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mlblSelektierterKunde = new MetroFramework.Controls.MetroLabel();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(60)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundennummer,
            this.colName1,
            this.colName2,
            this.colStrasse,
            this.colPostleitzahl,
            this.colOrt});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(60)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvCustomers.EnableHeadersVisualStyles = false;
			this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.HighLightPercentage = 0.8F;
			this.dgvCustomers.Location = new System.Drawing.Point(23, 135);
			this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(60)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvCustomers.RowHeadersVisible = false;
			this.dgvCustomers.RowHeadersWidth = 21;
			this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.Size = new System.Drawing.Size(1076, 609);
			this.dgvCustomers.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvCustomers.TabIndex = 1;
			this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
			this.dgvCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomers_MouseDoubleClick);
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Kundennummer";
			this.colKundennummer.FillWeight = 10F;
			this.colKundennummer.HeaderText = "Kunden-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			this.colKundennummer.ReadOnly = true;
			// 
			// colName1
			// 
			this.colName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName1.DataPropertyName = "Name1";
			this.colName1.FillWeight = 20F;
			this.colName1.HeaderText = "Name 1";
			this.colName1.Name = "colName1";
			this.colName1.ReadOnly = true;
			// 
			// colName2
			// 
			this.colName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName2.DataPropertyName = "Name2";
			this.colName2.FillWeight = 20F;
			this.colName2.HeaderText = "Name 2";
			this.colName2.Name = "colName2";
			this.colName2.ReadOnly = true;
			// 
			// colStrasse
			// 
			this.colStrasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStrasse.DataPropertyName = "Strasse";
			this.colStrasse.FillWeight = 20F;
			this.colStrasse.HeaderText = "Straße";
			this.colStrasse.Name = "colStrasse";
			this.colStrasse.ReadOnly = true;
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
			this.colOrt.FillWeight = 20F;
			this.colOrt.HeaderText = "Ort";
			this.colOrt.Name = "colOrt";
			this.colOrt.ReadOnly = true;
			// 
			// mlblSelektierterKunde
			// 
			this.mlblSelektierterKunde.AutoSize = true;
			this.mlblSelektierterKunde.Location = new System.Drawing.Point(406, 103);
			this.mlblSelektierterKunde.Name = "mlblSelektierterKunde";
			this.mlblSelektierterKunde.Size = new System.Drawing.Size(127, 19);
			this.mlblSelektierterKunde.TabIndex = 78;
			this.mlblSelektierterKunde.Text = "Ausgewählter Kunde";
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(355, 1);
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
			this.mtxtFilter.Location = new System.Drawing.Point(23, 103);
			this.mtxtFilter.MaxLength = 32767;
			this.mtxtFilter.Name = "mtxtFilter";
			this.mtxtFilter.PasswordChar = '\0';
			this.mtxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFilter.SelectedText = "";
			this.mtxtFilter.SelectionLength = 0;
			this.mtxtFilter.SelectionStart = 0;
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(377, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtFilter.TabIndex = 0;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Kunden-Nr., Firma, PLZ oder Matchcode";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txtFilterList_ClearClicked);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
			// 
			// mbtnOk
			// 
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(886, 764);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 2;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOK_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(999, 764);
			this.mbtnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 3;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// CustomerSearchView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(1129, 813);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.mlblSelektierterKunde);
			this.Controls.Add(this.dgvCustomers);
			this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomerSearchView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Kunden auswählen";
			this.Load += new System.EventHandler(this.CustomerSearchView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStrasse;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
		private MetroFramework.Controls.MetroLabel mlblSelektierterKunde;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
	}
}