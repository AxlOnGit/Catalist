using System;
using MetroFramework.Forms;
using Products.Data;

namespace Products.Common.Views
{
	public partial class KatalogIndexView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the KatalogView class.
		/// </summary>
		public KatalogIndexView()
		{
			InitializeComponent();
			this.dgvKatalog.DataSource = DataManager.CatalogDataService.GetCatalogTable();
		}

		#endregion

		#region event handler

		// Closes the view.
		void mbtnClose_Click(object sender, EventArgs e)
		{
			DataManager.CatalogDataService.Update();
			this.Close();
		}

		#endregion

	}
}
