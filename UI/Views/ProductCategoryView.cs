using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class ProductCategoryView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ProductCategoryView"/> Klasse.
		/// </summary>
		public ProductCategoryView()
		{
			InitializeComponent();
		}

		#endregion

		#region event handler

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
		}

		void trvCategories_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			e.Node.StateImageIndex = 0;
		}

		void trvCategories_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			e.Node.StateImageIndex = 1;
		}

		#endregion

	}
}
