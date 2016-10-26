namespace Products.Common.Views
{
	partial class FileExplorerView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.trvFolders = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgvFiles = new MetroFramework.Controls.MetroGrid();
			this.colFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(1119, 740);
			this.mbtnClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnClose.TabIndex = 0;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(23, 62);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 40);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.trvFolders);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvFiles);
			this.splitContainer1.Size = new System.Drawing.Size(707, 535);
			this.splitContainer1.SplitterDistance = 128;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 2;
			// 
			// trvFolders
			// 
			this.trvFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvFolders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvFolders.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.trvFolders.ImageIndex = 0;
			this.trvFolders.ImageList = this.imageList1;
			this.trvFolders.ItemHeight = 30;
			this.trvFolders.LineColor = System.Drawing.Color.Gray;
			this.trvFolders.Location = new System.Drawing.Point(0, 25);
			this.trvFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trvFolders.Name = "trvFolders";
			this.trvFolders.SelectedImageIndex = 1;
			this.trvFolders.ShowPlusMinus = false;
			this.trvFolders.Size = new System.Drawing.Size(128, 510);
			this.trvFolders.TabIndex = 0;
			this.trvFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFolders_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folderclosed_16.png");
			this.imageList1.Images.SetKeyName(1, "folderopen_16.png");
			// 
			// dgvFiles
			// 
			this.dgvFiles.AllowUserToAddRows = false;
			this.dgvFiles.AllowUserToDeleteRows = false;
			this.dgvFiles.AllowUserToResizeRows = false;
			this.dgvFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilename,
            this.colDescription,
            this.colSize,
            this.colType,
            this.colChangeDate});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFiles.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFiles.EnableHeadersVisualStyles = false;
			this.dgvFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.HighLightPercentage = 1.2F;
			this.dgvFiles.Location = new System.Drawing.Point(0, 0);
			this.dgvFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvFiles.Name = "dgvFiles";
			this.dgvFiles.ReadOnly = true;
			this.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFiles.RowHeadersVisible = false;
			this.dgvFiles.RowHeadersWidth = 21;
			this.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFiles.Size = new System.Drawing.Size(574, 535);
			this.dgvFiles.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvFiles.TabIndex = 0;
			this.dgvFiles.UseCustomBackColor = true;
			this.dgvFiles.UseCustomForeColor = true;
			this.dgvFiles.UseStyleColors = true;
			this.dgvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_RowEnter);
			this.dgvFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseDoubleClick);
			// 
			// colFilename
			// 
			this.colFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFilename.DataPropertyName = "Name";
			this.colFilename.FillWeight = 30F;
			this.colFilename.HeaderText = "Datei";
			this.colFilename.Name = "colFilename";
			this.colFilename.ReadOnly = true;
			// 
			// colDescription
			// 
			this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDescription.DataPropertyName = "CreationTime";
			this.colDescription.FillWeight = 30F;
			this.colDescription.HeaderText = "Beschreibung";
			this.colDescription.Name = "colDescription";
			this.colDescription.ReadOnly = true;
			// 
			// colSize
			// 
			this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSize.DataPropertyName = "Length";
			this.colSize.FillWeight = 15F;
			this.colSize.HeaderText = "Größe";
			this.colSize.Name = "colSize";
			this.colSize.ReadOnly = true;
			// 
			// colType
			// 
			this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colType.DataPropertyName = "Extension";
			this.colType.FillWeight = 15F;
			this.colType.HeaderText = "Typ";
			this.colType.Name = "colType";
			this.colType.ReadOnly = true;
			// 
			// colChangeDate
			// 
			this.colChangeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colChangeDate.DataPropertyName = "LastWriteTime";
			this.colChangeDate.FillWeight = 15F;
			this.colChangeDate.HeaderText = "Änderungsdatum";
			this.colChangeDate.Name = "colChangeDate";
			this.colChangeDate.ReadOnly = true;
			// 
			// FileExplorerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 784);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.mbtnClose);
			this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileExplorerView";
			this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 52);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Dateien";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView trvFolders;
		private MetroFramework.Controls.MetroGrid dgvFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFilename;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colChangeDate;
		private System.Windows.Forms.ImageList imageList1;
	}
}