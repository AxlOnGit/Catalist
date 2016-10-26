namespace Products.Common.Views
{
	partial class ProductCategoryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCategoryView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.trvCategories = new System.Windows.Forms.TreeView();
			this.mctxTree = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdNewCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdRenameCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.dgvProducts = new MetroFramework.Controls.MetroGrid();
			this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mctxTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// trvCategories
			// 
			this.trvCategories.AllowDrop = true;
			this.trvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvCategories.ContextMenuStrip = this.mctxTree;
			this.trvCategories.Dock = System.Windows.Forms.DockStyle.Left;
			this.trvCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.trvCategories.Indent = 20;
			this.trvCategories.ItemHeight = 30;
			this.trvCategories.LineColor = System.Drawing.Color.Silver;
			this.trvCategories.Location = new System.Drawing.Point(20, 100);
			this.trvCategories.Name = "trvCategories";
			this.trvCategories.ShowLines = false;
			this.trvCategories.ShowPlusMinus = false;
			this.trvCategories.ShowRootLines = false;
			this.trvCategories.Size = new System.Drawing.Size(312, 596);
			this.trvCategories.StateImageList = this.imgList;
			this.trvCategories.TabIndex = 0;
			this.trvCategories.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvCategories_AfterLabelEdit);
			this.trvCategories.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvCategories_AfterCollapse);
			this.trvCategories.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvCategories_AfterExpand);
			this.trvCategories.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvCategories_ItemDrag);
			this.trvCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvCategories_NodeMouseClick);
			this.trvCategories.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvCategories_DragDrop);
			this.trvCategories.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvCategories_DragEnter);
			this.trvCategories.DragOver += new System.Windows.Forms.DragEventHandler(this.trvCategories_DragOver);
			// 
			// mctxTree
			// 
			this.mctxTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdNewCategory,
            this.xcmdDeleteCategory,
            this.toolStripMenuItem1,
            this.xcmdRenameCategory});
			this.mctxTree.Name = "mctxTree";
			this.mctxTree.Size = new System.Drawing.Size(147, 76);
			this.mctxTree.Opening += new System.ComponentModel.CancelEventHandler(this.mctxTree_Opening);
			// 
			// xcmdNewCategory
			// 
			this.xcmdNewCategory.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdNewCategory.Name = "xcmdNewCategory";
			this.xcmdNewCategory.Size = new System.Drawing.Size(146, 22);
			this.xcmdNewCategory.Text = "Neu";
			this.xcmdNewCategory.Click += new System.EventHandler(this.xcmdNewCategory_Click);
			// 
			// xcmdDeleteCategory
			// 
			this.xcmdDeleteCategory.Image = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.xcmdDeleteCategory.Name = "xcmdDeleteCategory";
			this.xcmdDeleteCategory.Size = new System.Drawing.Size(146, 22);
			this.xcmdDeleteCategory.Text = "Löschen";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
			// 
			// xcmdRenameCategory
			// 
			this.xcmdRenameCategory.Image = global::Products.Common.Properties.Resources.rename_16_metroorange;
			this.xcmdRenameCategory.Name = "xcmdRenameCategory";
			this.xcmdRenameCategory.Size = new System.Drawing.Size(146, 22);
			this.xcmdRenameCategory.Text = "Umbenennen";
			this.xcmdRenameCategory.Click += new System.EventHandler(this.xcmdRenameCategory_Click);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "ArrowRight.png");
			this.imgList.Images.SetKeyName(1, "ArrowDown.png");
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToResizeRows = false;
			this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colArtikelnummer,
            this.colMatchcode,
            this.colBezeichnung1,
            this.colBezeichnung2});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.Location = new System.Drawing.Point(338, 100);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 21;
			this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(919, 596);
			this.dgvProducts.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvProducts.TabIndex = 1;
			// 
			// colTyp
			// 
			this.colTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTyp.DataPropertyName = "Typ";
			this.colTyp.FillWeight = 10F;
			this.colTyp.HeaderText = "Typ";
			this.colTyp.Name = "colTyp";
			// 
			// colArtikelnummer
			// 
			this.colArtikelnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelnummer.DataPropertyName = "Artikelnummer";
			this.colArtikelnummer.FillWeight = 20F;
			this.colArtikelnummer.HeaderText = "Art-Nr";
			this.colArtikelnummer.Name = "colArtikelnummer";
			// 
			// colMatchcode
			// 
			this.colMatchcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMatchcode.DataPropertyName = "Matchcode";
			this.colMatchcode.FillWeight = 20F;
			this.colMatchcode.HeaderText = "Matchcode";
			this.colMatchcode.Name = "colMatchcode";
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 25F;
			this.colBezeichnung1.HeaderText = "Artikelname";
			this.colBezeichnung1.Name = "colBezeichnung1";
			// 
			// colBezeichnung2
			// 
			this.colBezeichnung2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
			this.colBezeichnung2.FillWeight = 25F;
			this.colBezeichnung2.HeaderText = "Artikelzusatz";
			this.colBezeichnung2.Name = "colBezeichnung2";
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1157, 727);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnClose.TabIndex = 2;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// ProductCategoryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 776);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.trvCategories);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProductCategoryView";
			this.Padding = new System.Windows.Forms.Padding(20, 100, 20, 80);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Artikelkategorien";
			this.mctxTree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView trvCategories;
		private System.Windows.Forms.ImageList imgList;
		private MetroFramework.Controls.MetroGrid dgvProducts;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroContextMenu mctxTree;
		private System.Windows.Forms.ToolStripMenuItem xcmdNewCategory;
		private System.Windows.Forms.ToolStripMenuItem xcmdDeleteCategory;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xcmdRenameCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelnummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatchcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung2;
	}
}