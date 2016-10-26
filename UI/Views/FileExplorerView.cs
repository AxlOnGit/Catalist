using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class FileExplorerView : MetroForm
	{
		#region members

		readonly Kundenmaschine myMachine;
		FileInfo mySelectedFile;

		#endregion members

		#region ### .ctor ###

		public FileExplorerView(Kundenmaschine machine)
		{
			InitializeComponent();
			this.myMachine = machine;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void trvFolders_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var dirInfo = e.Node.Tag as DirectoryInfo;
			if (dirInfo != null)
			{
				var files = new SortableBindingList<FileInfo>();
				foreach (var file in dirInfo.GetFiles())
				{
					files.Add(file);
				}
				this.dgvFiles.DataSource = files;
			}
		}

		void dgvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedFile = this.dgvFiles.Rows[e.RowIndex].DataBoundItem as FileInfo;
		}

		void dgvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedFile == null) return;
			Process.Start(this.mySelectedFile.FullName);
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.dgvFiles.AutoGenerateColumns = false;
			var dirInfo = new DirectoryInfo(this.myMachine.Dateipfad);
			var nodes = this.trvFolders.Nodes;
			nodes.Clear();
			var root = nodes.Add(this.myMachine.ItemName);
			root.Tag = dirInfo;
			AddSubNodes(root);
			this.trvFolders.SelectedNode = root;
		}

		void AddSubNodes(TreeNode parentNode)
		{
			var dirInfo = parentNode.Tag as DirectoryInfo;
			if (dirInfo != null)
			{
				foreach (var subDir in dirInfo.GetDirectories())
				{
					var subNode = parentNode.Nodes.Add(subDir.Name);
					subNode.Tag = subDir;
					AddSubNodes(subNode);
				}
			}
			parentNode.EnsureVisible();
		}

		#endregion private procedures
	}
}