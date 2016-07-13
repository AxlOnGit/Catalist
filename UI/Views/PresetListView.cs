using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Data;

namespace Products.Common.Views
{
	public partial class PresetListView : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the PresetListView class.
		/// </summary>
		public PresetListView()
		{
			InitializeComponent();
			this.InitializeGrid();
		}

		#endregion

		#region event handler

		void btnMinimize_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void PresetListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			DataManager.SharedDataService.UpdatePreset();
		}

		#endregion

		#region private procedures

		void InitializeGrid()
		{
			this.dgvPresets.AutoGenerateColumns = false;
			var dv = DataManager.SharedDataService.GetPresetTable().DefaultView;
			this.dgvPresets.DataSource = dv;
		}

		#endregion

	}
}
