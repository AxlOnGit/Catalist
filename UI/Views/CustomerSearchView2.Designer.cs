namespace Products.Common.Views
{
	partial class CustomerSearchView2
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearchView2));
			this.dgvCustomers = new MetroFramework.Controls.MetroGrid();
			this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnOpen = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerId,
            this.colName1,
            this.colName2,
            this.colStreet,
            this.colZipCode,
            this.colCity});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCustomers.EnableHeadersVisualStyles = false;
			this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.HighLightPercentage = 0.8F;
			this.dgvCustomers.Location = new System.Drawing.Point(12, 103);
			this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvCustomers.MultiSelect = false;
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCustomers.RowHeadersVisible = false;
			this.dgvCustomers.RowHeadersWidth = 21;
			this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.ShowCellToolTips = false;
			this.dgvCustomers.ShowEditingIcon = false;
			this.dgvCustomers.Size = new System.Drawing.Size(1098, 561);
			this.dgvCustomers.StandardTab = true;
			this.dgvCustomers.Style = MetroFramework.MetroColorStyle.Magenta;
			this.dgvCustomers.TabIndex = 0;
			this.dgvCustomers.TabStop = false;
			this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
			this.dgvCustomers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCustomers_KeyUp);
			this.dgvCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomers_MouseDoubleClick);
			// 
			// colCustomerId
			// 
			this.colCustomerId.DataPropertyName = "CustomerId";
			this.colCustomerId.HeaderText = "Kunden-Nr.";
			this.colCustomerId.MinimumWidth = 95;
			this.colCustomerId.Name = "colCustomerId";
			this.colCustomerId.ReadOnly = true;
			this.colCustomerId.Width = 95;
			// 
			// colName1
			// 
			this.colName1.DataPropertyName = "CompanyName1";
			this.colName1.HeaderText = "Firma";
			this.colName1.MinimumWidth = 240;
			this.colName1.Name = "colName1";
			this.colName1.ReadOnly = true;
			this.colName1.Width = 240;
			// 
			// colName2
			// 
			this.colName2.DataPropertyName = "CompanyName2";
			this.colName2.HeaderText = "Firmenzusatz";
			this.colName2.MinimumWidth = 240;
			this.colName2.Name = "colName2";
			this.colName2.ReadOnly = true;
			this.colName2.Width = 240;
			// 
			// colStreet
			// 
			this.colStreet.DataPropertyName = "Street";
			this.colStreet.HeaderText = "Straße";
			this.colStreet.MinimumWidth = 240;
			this.colStreet.Name = "colStreet";
			this.colStreet.ReadOnly = true;
			this.colStreet.Width = 240;
			// 
			// colZipCode
			// 
			this.colZipCode.DataPropertyName = "ZipCode";
			this.colZipCode.HeaderText = "PLZ";
			this.colZipCode.MinimumWidth = 60;
			this.colZipCode.Name = "colZipCode";
			this.colZipCode.ReadOnly = true;
			this.colZipCode.Width = 60;
			// 
			// colCity
			// 
			this.colCity.DataPropertyName = "City";
			this.colCity.HeaderText = "Ort";
			this.colCity.MinimumWidth = 200;
			this.colCity.Name = "colCity";
			this.colCity.ReadOnly = true;
			this.colCity.Width = 200;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1010, 687);
			this.mbtnClose.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 61;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnOpen
			// 
			this.mbtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnOpen.Image = null;
			this.mbtnOpen.Location = new System.Drawing.Point(897, 687);
			this.mbtnOpen.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOpen.Name = "mbtnOpen";
			this.mbtnOpen.Size = new System.Drawing.Size(100, 26);
			this.mbtnOpen.TabIndex = 62;
			this.mbtnOpen.Text = "Öffnen";
			this.mbtnOpen.UseSelectable = true;
			this.mbtnOpen.UseVisualStyleBackColor = true;
			this.mbtnOpen.Click += new System.EventHandler(this.mbtnOpen_Click);
			// 
			// CustomerSearchView2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 736);
			this.Controls.Add(this.mbtnOpen);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvCustomers);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomerSearchView2";
			this.Padding = new System.Windows.Forms.Padding(20, 100, 20, 20);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			this.Text = "Ergebnis der Kundensuche";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStreet;
		private System.Windows.Forms.DataGridViewTextBoxColumn colZipCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOpen;
	}
}