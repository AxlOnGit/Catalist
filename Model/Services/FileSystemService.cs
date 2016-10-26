using System.IO;
using Products.Common;

namespace Products.Model.Services
{
	public class FileSystemService
	{
		#region public procedures

		public SortableBindingList<FileInfo> SearchFiles(DirectoryInfo[] searchHere, string searchFor)
		{
			var result = new SortableBindingList<FileInfo>();

			foreach (var dirInfo in searchHere)
			{
				DirectorySearch(dirInfo.FullName, searchFor, result);
			}
			return result;
		}

		#endregion public procedures

		#region private procedures

		void DirectorySearch(string dirPath, string searchFor, SortableBindingList<FileInfo> list)
		{
			try
			{
				foreach (var file in Directory.GetFiles(dirPath, string.Format("*{0}*", searchFor), SearchOption.TopDirectoryOnly))
				{
					list.Add(new FileInfo(file));
				}
				foreach (string dir in Directory.GetDirectories(dirPath))
				{
					DirectorySearch(dir, searchFor, list);
				}

				//foreach (string dir in Directory.GetDirectories(dirPath))
				//{
				//	foreach (var file in Directory.GetFiles(dir, string.Format("*{0}*", searchFor), SearchOption.TopDirectoryOnly))
				//	{
				//		list.Add(new FileInfo(file));
				//	}
				//	DirectorySearch(dir, searchFor, list);
				//}
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		#endregion private procedures
	}
}