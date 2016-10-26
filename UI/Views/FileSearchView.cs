using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class FileSearchView : MetroForm
	{
		#region members

		readonly Kundenmaschine myMachine;
		readonly string mySearchString;

		#endregion members

		#region ### .ctor ###

		public FileSearchView(Kundenmaschine machine, string searchFor)
		{
			InitializeComponent();
			this.myMachine = machine;
			this.mySearchString = searchFor;

			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void mbtnCompressFiles_Click(object sender, EventArgs e)
		{
			this.CreateZipFile();
		}

		void xcmdCreateZipFile_Click(object sender, EventArgs e)
		{
			this.CreateZipFile();
		}

		void mbtnCopyTechnikordner_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(this.myMachine.Dateipfad))
			{
				this.CopyToTechFolder();
			}
			else MetroMessageBox.Show(this, "Bitte erst einen Technikordner für die Maschine anlegen.", "Geht so nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		void xcmdCopyTechnikordner_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(this.myMachine.Dateipfad))
			{
				this.CopyToTechFolder();
			}
			else MetroMessageBox.Show(this, "Bitte erst einen Technikordner für die Maschine anlegen.", "Geht so nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
			var directories = new DirectoryInfo[]
			{
				new DirectoryInfo(@"\\NASE82002\technik\Parameter\Mimaki"),
				new DirectoryInfo(@"\\NASE82002\technik\Service Maschinen\_Mimaki"),
				new DirectoryInfo(@"\\NASE82002\technik\Wartung")
			};

			var list = Model.ModelManager.FileSystemService.SearchFiles(directories, this.mySearchString);
			this.dgvFiles.DataSource = list;
		}

		void CopyToTechFolder()
		{
			var counter = 0;
			foreach (DataGridViewRow row in this.dgvFiles.SelectedRows)
			{
				var fi = row.DataBoundItem as FileInfo;
				if (fi != null)
				{
					var fileName = fi.Name;
					var destFullName = Path.Combine(this.myMachine.Dateipfad, fileName);
					if (!File.Exists(destFullName))
					{
						fi.CopyTo(destFullName);
						counter += 1;
					}
				}
			}
			var msg = string.Format("Ich habe {0} Dateien in den Ordner {1} kopiert.", counter, this.myMachine.Dateipfad);
			MetroMessageBox.Show(this, msg, "Kopieren", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void CreateZipFile()
		{
			var destPath = string.Empty;
			var zipFile = string.Format("{0}.zip", this.mySearchString);
			var fullName = string.Empty;
			if (this.dgvFiles.SelectedRows.Count > 0)
			{
				var dirSearch = new FolderBrowserDialog();
				dirSearch.RootFolder = Environment.SpecialFolder.MyComputer;
				if (dirSearch.ShowDialog() == DialogResult.OK)
				{
					destPath = dirSearch.SelectedPath;
					fullName = Path.Combine(destPath, zipFile);
					using (ZipFile archive = new ZipFile(fullName))
					{
						foreach (DataGridViewRow item in this.dgvFiles.SelectedRows)
						{
							var fi = item.DataBoundItem as FileInfo;
							if (fi != null)
							{
								archive.AddFile(fi.FullName, "");
							}
						}
						archive.Save();
						var msg = string.Format("Die Dateien wurden in das Archiv {0} kopiert.{1}Soll ich den Ordner jetzt öffnen?", fullName, Environment.NewLine);
						if (MetroMessageBox.Show(this, msg, "ZIP-Archiv", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							var explorer = new Process();
							explorer.StartInfo.FileName = "explorer.exe";
							explorer.StartInfo.Arguments = destPath;
							explorer.Start();
						}
					}
				}
				else
				{
					var msg = "Vorgang abgebrochen";
					MetroMessageBox.Show(this, msg, "ZIP-Archiv", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				var msg = "Es muss wenigstens eine Datei ausgewählt werden.";
				MetroMessageBox.Show(this, msg, "ZIP-Archiv", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		#endregion private procedures
	}
}