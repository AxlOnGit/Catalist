namespace Products.Common.Views
{
	partial class FileSearchView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvFiles = new MetroFramework.Controls.MetroGrid();
			this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdCreateZipFile = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdCopyTechnikordner = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCompressFiles = new MetroFramework.Controls.MetroButton();
			this.mbtnCopyTechnikordner = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvFiles
			// 
			this.dgvFiles.AllowUserToAddRows = false;
			this.dgvFiles.AllowUserToDeleteRows = false;
			this.dgvFiles.AllowUserToResizeRows = false;
			this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colCreationDate,
            this.colFilePath});
			this.dgvFiles.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFiles.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFiles.EnableHeadersVisualStyles = false;
			this.dgvFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.HighLightPercentage = 1.2F;
			this.dgvFiles.Location = new System.Drawing.Point(23, 100);
			this.dgvFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvFiles.Name = "dgvFiles";
			this.dgvFiles.ReadOnly = true;
			this.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFiles.RowHeadersVisible = false;
			this.dgvFiles.RowHeadersWidth = 21;
			this.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFiles.Size = new System.Drawing.Size(1254, 625);
			this.dgvFiles.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvFiles.TabIndex = 0;
			// 
			// colFileName
			// 
			this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFileName.DataPropertyName = "Name";
			this.colFileName.FillWeight = 30F;
			this.colFileName.HeaderText = "Dateiname";
			this.colFileName.Name = "colFileName";
			this.colFileName.ReadOnly = true;
			// 
			// colCreationDate
			// 
			this.colCreationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colCreationDate.DataPropertyName = "LastWriteTime";
			this.colCreationDate.FillWeight = 10F;
			this.colCreationDate.HeaderText = "Erstellt am";
			this.colCreationDate.Name = "colCreationDate";
			this.colCreationDate.ReadOnly = true;
			// 
			// colFilePath
			// 
			this.colFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFilePath.DataPropertyName = "DirectoryName";
			this.colFilePath.FillWeight = 60F;
			this.colFilePath.HeaderText = "Ordner";
			this.colFilePath.Name = "colFilePath";
			this.colFilePath.ReadOnly = true;
			// 
			// ctxGrid
			// 
			this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdCreateZipFile,
            this.xcmdCopyTechnikordner});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(213, 48);
			// 
			// xcmdCreateZipFile
			// 
			this.xcmdCreateZipFile.Image = global::Products.Common.Properties.Resources.zip_16_metrored;
			this.xcmdCreateZipFile.Name = "xcmdCreateZipFile";
			this.xcmdCreateZipFile.Size = new System.Drawing.Size(212, 22);
			this.xcmdCreateZipFile.Text = "ZIP-Datei erstellen";
			this.xcmdCreateZipFile.Click += new System.EventHandler(this.xcmdCreateZipFile_Click);
			// 
			// xcmdCopyTechnikordner
			// 
			this.xcmdCopyTechnikordner.Image = global::Products.Common.Properties.Resources.copy_16_metrored;
			this.xcmdCopyTechnikordner.Name = "xcmdCopyTechnikordner";
			this.xcmdCopyTechnikordner.Size = new System.Drawing.Size(212, 22);
			this.xcmdCopyTechnikordner.Text = "In Technikordner kopieren";
			this.xcmdCopyTechnikordner.Click += new System.EventHandler(this.xcmdCopyTechnikordner_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1177, 748);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 1;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnCompressFiles
			// 
			this.mbtnCompressFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnCompressFiles.BackgroundImage = global::Products.Common.Properties.Resources.zip_32_metrored;
			this.mbtnCompressFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnCompressFiles.Location = new System.Drawing.Point(23, 738);
			this.mbtnCompressFiles.Name = "mbtnCompressFiles";
			this.mbtnCompressFiles.Size = new System.Drawing.Size(36, 36);
			this.mbtnCompressFiles.TabIndex = 2;
			this.mbtnCompressFiles.UseSelectable = true;
			this.mbtnCompressFiles.Click += new System.EventHandler(this.mbtnCompressFiles_Click);
			// 
			// mbtnCopyTechnikordner
			// 
			this.mbtnCopyTechnikordner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnCopyTechnikordner.BackgroundImage = global::Products.Common.Properties.Resources.copy_16_metrored;
			this.mbtnCopyTechnikordner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnCopyTechnikordner.Location = new System.Drawing.Point(65, 738);
			this.mbtnCopyTechnikordner.Name = "mbtnCopyTechnikordner";
			this.mbtnCopyTechnikordner.Size = new System.Drawing.Size(36, 36);
			this.mbtnCopyTechnikordner.TabIndex = 3;
			this.mbtnCopyTechnikordner.UseSelectable = true;
			this.mbtnCopyTechnikordner.Click += new System.EventHandler(this.mbtnCopyTechnikordner_Click);
			// 
			// FileSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 797);
			this.Controls.Add(this.mbtnCopyTechnikordner);
			this.Controls.Add(this.mbtnCompressFiles);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvFiles);
			this.Name = "FileSearchView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Dateisuche";
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvFiles;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroButton mbtnCompressFiles;
		private MetroFramework.Controls.MetroContextMenu ctxGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdCreateZipFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCreationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
		private System.Windows.Forms.ToolStripMenuItem xcmdCopyTechnikordner;
		private MetroFramework.Controls.MetroButton mbtnCopyTechnikordner;
	}
}