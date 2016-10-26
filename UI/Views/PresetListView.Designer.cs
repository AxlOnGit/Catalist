namespace Products.Common.Views
{
	partial class PresetListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetListView));
			this.dgvPresets = new MetroFramework.Controls.MetroGrid();
			this.colPresetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProperty14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnMinimize = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPresets
			// 
			this.dgvPresets.AllowUserToAddRows = false;
			this.dgvPresets.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvPresets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPresets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPresets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvPresets.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPresets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvPresets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPresets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPresets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPresets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPresetName,
            this.colProperty1,
            this.colProperty2,
            this.colProperty3,
            this.colProperty4,
            this.colProperty5,
            this.colProperty6,
            this.colProperty7,
            this.colProperty8,
            this.colProperty9,
            this.colProperty10,
            this.colProperty11,
            this.colProperty12,
            this.colProperty13,
            this.colProperty14});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPresets.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPresets.EnableHeadersVisualStyles = false;
			this.dgvPresets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvPresets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvPresets.HighLightPercentage = 1.2F;
			this.dgvPresets.Location = new System.Drawing.Point(12, 100);
			this.dgvPresets.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.dgvPresets.Name = "dgvPresets";
			this.dgvPresets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPresets.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPresets.RowHeadersVisible = false;
			this.dgvPresets.RowHeadersWidth = 21;
			this.dgvPresets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvPresets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPresets.Size = new System.Drawing.Size(1229, 564);
			this.dgvPresets.Style = MetroFramework.MetroColorStyle.Blue;
			this.dgvPresets.TabIndex = 0;
			this.dgvPresets.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// colPresetName
			// 
			this.colPresetName.DataPropertyName = "PresetName";
			this.colPresetName.HeaderText = "Bezeichnung";
			this.colPresetName.Name = "colPresetName";
			this.colPresetName.Width = 97;
			// 
			// colProperty1
			// 
			this.colProperty1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colProperty1.DataPropertyName = "Property1";
			this.colProperty1.HeaderText = "1. Eigenschaft";
			this.colProperty1.MinimumWidth = 110;
			this.colProperty1.Name = "colProperty1";
			this.colProperty1.Width = 110;
			// 
			// colProperty2
			// 
			this.colProperty2.DataPropertyName = "Property2";
			this.colProperty2.HeaderText = "2. Eigenschaft";
			this.colProperty2.MinimumWidth = 110;
			this.colProperty2.Name = "colProperty2";
			this.colProperty2.Width = 110;
			// 
			// colProperty3
			// 
			this.colProperty3.DataPropertyName = "Property3";
			this.colProperty3.HeaderText = "3. Eigenschaft";
			this.colProperty3.MinimumWidth = 110;
			this.colProperty3.Name = "colProperty3";
			this.colProperty3.Width = 110;
			// 
			// colProperty4
			// 
			this.colProperty4.DataPropertyName = "Property4";
			this.colProperty4.HeaderText = "4. Eigenschaft";
			this.colProperty4.MinimumWidth = 110;
			this.colProperty4.Name = "colProperty4";
			this.colProperty4.Width = 110;
			// 
			// colProperty5
			// 
			this.colProperty5.DataPropertyName = "Property5";
			this.colProperty5.HeaderText = "5. Eigenschaft";
			this.colProperty5.MinimumWidth = 110;
			this.colProperty5.Name = "colProperty5";
			this.colProperty5.Width = 110;
			// 
			// colProperty6
			// 
			this.colProperty6.DataPropertyName = "Property6";
			this.colProperty6.HeaderText = "6. Eigenschaft";
			this.colProperty6.MinimumWidth = 110;
			this.colProperty6.Name = "colProperty6";
			this.colProperty6.Width = 110;
			// 
			// colProperty7
			// 
			this.colProperty7.DataPropertyName = "Property7";
			this.colProperty7.HeaderText = "7. Eigenschaft";
			this.colProperty7.MinimumWidth = 110;
			this.colProperty7.Name = "colProperty7";
			this.colProperty7.Width = 110;
			// 
			// colProperty8
			// 
			this.colProperty8.DataPropertyName = "Property8";
			this.colProperty8.HeaderText = "8. Eigenschaft";
			this.colProperty8.MinimumWidth = 110;
			this.colProperty8.Name = "colProperty8";
			this.colProperty8.Width = 110;
			// 
			// colProperty9
			// 
			this.colProperty9.DataPropertyName = "Property9";
			this.colProperty9.HeaderText = "9. Eigenschaft";
			this.colProperty9.MinimumWidth = 110;
			this.colProperty9.Name = "colProperty9";
			this.colProperty9.Width = 110;
			// 
			// colProperty10
			// 
			this.colProperty10.DataPropertyName = "Property10";
			this.colProperty10.HeaderText = "10. Eigenschaft";
			this.colProperty10.MinimumWidth = 110;
			this.colProperty10.Name = "colProperty10";
			this.colProperty10.Width = 110;
			// 
			// colProperty11
			// 
			this.colProperty11.DataPropertyName = "Property11";
			this.colProperty11.HeaderText = "11. Eigenschaft";
			this.colProperty11.MinimumWidth = 110;
			this.colProperty11.Name = "colProperty11";
			this.colProperty11.Width = 110;
			// 
			// colProperty12
			// 
			this.colProperty12.DataPropertyName = "Property12";
			this.colProperty12.HeaderText = "12. Eigenschaft";
			this.colProperty12.MinimumWidth = 110;
			this.colProperty12.Name = "colProperty12";
			this.colProperty12.Width = 110;
			// 
			// colProperty13
			// 
			this.colProperty13.DataPropertyName = "Property13";
			this.colProperty13.HeaderText = "13. Eigenschaft";
			this.colProperty13.MinimumWidth = 110;
			this.colProperty13.Name = "colProperty13";
			this.colProperty13.Width = 110;
			// 
			// colProperty14
			// 
			this.colProperty14.DataPropertyName = "Property14";
			this.colProperty14.HeaderText = "14. Eigenschaft";
			this.colProperty14.MinimumWidth = 110;
			this.colProperty14.Name = "colProperty14";
			this.colProperty14.Width = 110;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnMinimize.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnMinimize.Location = new System.Drawing.Point(1141, 677);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(100, 26);
			this.btnMinimize.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnMinimize.TabIndex = 68;
			this.btnMinimize.Text = "Schließen";
			this.btnMinimize.UseSelectable = true;
			this.btnMinimize.UseStyleColors = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// PresetListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 726);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.dgvPresets);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PresetListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowInTaskbar = false;
			this.Text = "Presets";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresetListView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		// private System.Windows.Forms.DataGridView dgvPresets;
		private MetroFramework.Controls.MetroGrid dgvPresets;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPresetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty4;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty5;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty6;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty7;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty8;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty9;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty10;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty11;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty12;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty13;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProperty14;
		private MetroFramework.Controls.MetroButton btnMinimize;
	}
}