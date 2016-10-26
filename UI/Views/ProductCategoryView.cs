using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ProductCategoryView : MetroForm
	{

		#region members

		readonly Kunde myKunde;
		string expandedImg = Path.Combine(Application.StartupPath, "expanded.png");
		string collapsedImg = Path.Combine(Application.StartupPath, "collapsed.png");
		string categoryImg = Path.Combine(Application.StartupPath, "category.png");


		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ProductCategoryView"/> Klasse.
		/// </summary>
		public ProductCategoryView(Kunde kunde = null)
		{
			InitializeComponent();

			if (kunde == null) this.myKunde = ModelManager.CustomerService.GetKunde("1000000000", false);
			this.InitializeTree();

			this.dgvProducts.AutoGenerateColumns = false;
			this.dgvProducts.DataSource = ModelManager.ProductService.GetProductList(this.myKunde);
		}

		#endregion

		#region event handler

		void xcmdNewCategory_Click(object sender, EventArgs e)
		{
			var parentNode = this.trvCategories.SelectedNode;
			if (parentNode != null)
			{
				var parentCategory = parentNode.Tag as ProductCategory;
				if (parentCategory != null)
				{
					var newCategory = ModelManager.ProductService.AddProductCategory(parentCategory);
					if (newCategory != null)
					{
						var newNode = new TreeNode(newCategory.Category);
						newNode.Tag = newCategory;
						newNode.StateImageIndex = 0;
						parentNode.Nodes.Add(newNode);
						parentNode.Expand();
						this.trvCategories.SelectedNode = newNode;
						trvCategories.LabelEdit = true;
						newNode.BeginEdit();
					}
				}
			}
		}

		void trvCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!e.Node.IsExpanded)
			{
				e.Node.Expand();
			}
			else
			{
				e.Node.Collapse();
			}
			if (e.Node != this.trvCategories.SelectedNode)
			{
				if (e.Node != this.trvCategories.Nodes[0])
				{
					var rubrik = e.Node.Tag as BaumRubrik;
					if (rubrik != null)
					{
						this.dgvProducts.DataSource = ModelManager.ProductService.GetBaumArtikelList(rubrik.PkID, this.myKunde);
					}
				}
				else this.dgvProducts.DataSource = ModelManager.ProductService.GetProductList(this.myKunde);
			}
		}

		void trvCategories_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			e.Node.StateImageIndex = 0;
		}

		void trvCategories_AfterExpand(object sender, TreeViewEventArgs e)
		{
			e.Node.StateImageIndex = 1;
		}

		void mctxTree_Opening(object sender, CancelEventArgs e)
		{
			this.xcmdDeleteCategory.Enabled = this.trvCategories.SelectedNode.Nodes.Count > 0;
		}

		void xcmdRenameCategory_Click(object sender, EventArgs e)
		{
			var node = this.trvCategories.SelectedNode;
			if (node != null)
			{
				this.trvCategories.LabelEdit = true;
				if (!node.IsEditing)
				{
					node.BeginEdit();
				}
			}
		}

		void trvCategories_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			var category = e.Node.Tag as ProductCategory;
			if (category != null)
			{
				category.Category = e.Label;
				ModelManager.ProductService.UpdateCategories();
				this.trvCategories.LabelEdit = false;
			}
		}

		#region DRAG'N DROP

		void trvCategories_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
			{
				DoDragDrop(e.Item, DragDropEffects.Move);
			}
		}

		void trvCategories_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
		}

		void trvCategories_DragOver(object sender, DragEventArgs e)
		{
			var woBinIch = this.trvCategories.PointToClient(new Point(e.X, e.Y));
			this.trvCategories.SelectedNode = this.trvCategories.GetNodeAt(woBinIch);
		}

		void trvCategories_DragDrop(object sender, DragEventArgs e)
		{
			var woBinIch = this.trvCategories.PointToClient(new Point(e.X, e.Y));
			var targetNode = this.trvCategories.GetNodeAt(woBinIch);
			var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

			if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
			{
				draggedNode.Remove();
				targetNode.Nodes.Add(draggedNode);
				var draggedCat = draggedNode.Tag as ProductCategory;
				var targetCat = targetNode.Tag as ProductCategory;
				if (draggedCat != null && targetCat != null)
				{
					draggedCat.ParentID = targetCat.UID;
					ModelManager.ProductService.UpdateCategories();
				}
			}
			targetNode.Expand();
		}

		bool ContainsNode(TreeNode node1, TreeNode node2)
		{
			if (node2.Parent == null) return false;
			if (node2.Parent.Equals(node1)) return true;
			return ContainsNode(node1, node2.Parent);
		}

		#endregion

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region procedures

		void InitializeTree()
		{
			this.trvCategories.Nodes.Clear();
			var root = new TreeNode("Artikelstamm");
			root.StateImageIndex = 0;
			this.trvCategories.Nodes.Add(root);

			foreach (var rubrik in ModelManager.ProductService.GetBaumRubrikListByParentID(0))
			{
				var node = new TreeNode(rubrik.Titel);
				node.Tag = rubrik;
				//node.StateImageIndex = 0;
				root.Nodes.Add(node);
				this.AddSubNodes(node);
				if (node.Nodes.Count > 0) node.StateImageIndex = 0;
			}
		}

		void AddSubNodes(TreeNode theSubNode)
		{
			var parentRubrik = theSubNode.Tag as BaumRubrik;
			if (parentRubrik != null)
			{
				foreach (var subRubrik in ModelManager.ProductService.GetBaumRubrikListByParentID(parentRubrik.PkID))
			{
					var subNode = new TreeNode(subRubrik.Titel);
					subNode.Tag = subRubrik;
					//subNode.StateImageIndex = 0;
					theSubNode.Nodes.Add(subNode);
					this.AddSubNodes(subNode);
				}
			}
		}

		#endregion

	}
}
