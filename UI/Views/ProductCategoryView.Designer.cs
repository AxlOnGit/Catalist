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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Maschinen");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Maschinenzubehör");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tinten");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Kategorien", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCategoryView));
			this.trvCategories = new System.Windows.Forms.TreeView();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// trvCategories
			// 
			this.trvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvCategories.Dock = System.Windows.Forms.DockStyle.Left;
			this.trvCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.trvCategories.FullRowSelect = true;
			this.trvCategories.HideSelection = false;
			this.trvCategories.ImageKey = "ArrowRight.png";
			this.trvCategories.ItemHeight = 20;
			this.trvCategories.LineColor = System.Drawing.Color.Silver;
			this.trvCategories.Location = new System.Drawing.Point(20, 100);
			this.trvCategories.Name = "trvCategories";
			treeNode1.Name = "nodeMachines";
			treeNode1.Text = "Maschinen";
			treeNode2.Name = "nodeMachineAccessories";
			treeNode2.Text = "Maschinenzubehör";
			treeNode3.Name = "nodeInk";
			treeNode3.Text = "Tinten";
			treeNode4.Name = "nodeMain";
			treeNode4.Text = "Kategorien";
			this.trvCategories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
			this.trvCategories.SelectedImageKey = "ArrowRight.png";
			this.trvCategories.ShowLines = false;
			this.trvCategories.ShowRootLines = false;
			this.trvCategories.Size = new System.Drawing.Size(324, 520);
			this.trvCategories.StateImageList = this.imgList;
			this.trvCategories.TabIndex = 0;
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "ArrowRight.png");
			this.imgList.Images.SetKeyName(1, "ArrowDown.png");
			// 
			// ProductCategoryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 700);
			this.Controls.Add(this.trvCategories);
			this.Name = "ProductCategoryView";
			this.Padding = new System.Windows.Forms.Padding(20, 100, 20, 80);
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Artikelkategorien";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TreeView trvCategories;
		private System.Windows.Forms.ImageList imgList;
	}
}