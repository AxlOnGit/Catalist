namespace Products.Common.Views
{
	partial class KundensoftwareSearchView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mbtnCancel = new MetroFramework.Controls.MetroButton();
			this.dgvKundensoftware = new MetroFramework.Controls.MetroGrid();
			this.mbtnOK = new MetroFramework.Controls.MetroButton();
			this.colSoftwarename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLizenzschluessel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvKundensoftware)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Location = new System.Drawing.Point(275, 601);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnCancel.TabIndex = 0;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseCustomBackColor = true;
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseStyleColors = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// dgvKundensoftware
			// 
			this.dgvKundensoftware.AllowUserToAddRows = false;
			this.dgvKundensoftware.AllowUserToDeleteRows = false;
			this.dgvKundensoftware.AllowUserToResizeRows = false;
			this.dgvKundensoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvKundensoftware.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvKundensoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvKundensoftware.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvKundensoftware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvKundensoftware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvKundensoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKundensoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoftwarename,
            this.colLizenzschluessel});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvKundensoftware.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvKundensoftware.EnableHeadersVisualStyles = false;
			this.dgvKundensoftware.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvKundensoftware.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvKundensoftware.HighLightPercentage = 1.2F;
			this.dgvKundensoftware.Location = new System.Drawing.Point(23, 100);
			this.dgvKundensoftware.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvKundensoftware.Name = "dgvKundensoftware";
			this.dgvKundensoftware.ReadOnly = true;
			this.dgvKundensoftware.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvKundensoftware.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvKundensoftware.RowHeadersVisible = false;
			this.dgvKundensoftware.RowHeadersWidth = 21;
			this.dgvKundensoftware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvKundensoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKundensoftware.Size = new System.Drawing.Size(480, 478);
			this.dgvKundensoftware.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvKundensoftware.TabIndex = 1;
			this.dgvKundensoftware.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKundensoftware_RowEnter);
			this.dgvKundensoftware.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKundensoftware_MouseDoubleClick);
			// 
			// mbtnOK
			// 
			this.mbtnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnOK.Location = new System.Drawing.Point(152, 601);
			this.mbtnOK.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.mbtnOK.Name = "mbtnOK";
			this.mbtnOK.Size = new System.Drawing.Size(100, 26);
			this.mbtnOK.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnOK.TabIndex = 2;
			this.mbtnOK.Text = "OK";
			this.mbtnOK.UseCustomBackColor = true;
			this.mbtnOK.UseSelectable = true;
			this.mbtnOK.UseStyleColors = true;
			this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
			// 
			// colSoftwarename
			// 
			this.colSoftwarename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSoftwarename.DataPropertyName = "Softwarename";
			this.colSoftwarename.FillWeight = 35F;
			this.colSoftwarename.HeaderText = "Bezeichnung";
			this.colSoftwarename.Name = "colSoftwarename";
			this.colSoftwarename.ReadOnly = true;
			// 
			// colLizenzschluessel
			// 
			this.colLizenzschluessel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLizenzschluessel.DataPropertyName = "Lizenzschluessel";
			this.colLizenzschluessel.FillWeight = 65F;
			this.colLizenzschluessel.HeaderText = "Lizenzschlüssel";
			this.colLizenzschluessel.Name = "colLizenzschluessel";
			this.colLizenzschluessel.ReadOnly = true;
			// 
			// KundensoftwareSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(526, 650);
			this.Controls.Add(this.mbtnOK);
			this.Controls.Add(this.dgvKundensoftware);
			this.Controls.Add(this.mbtnCancel);
			this.Name = "KundensoftwareSearchView";
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Kundensoftware";
			((System.ComponentModel.ISupportInitialize)(this.dgvKundensoftware)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnCancel;
		private MetroFramework.Controls.MetroGrid dgvKundensoftware;
		private MetroFramework.Controls.MetroButton mbtnOK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwarename;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLizenzschluessel;
	}
}