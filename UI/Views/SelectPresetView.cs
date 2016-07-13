using System.Data;
using System.Windows.Forms;
using Products.Data.Datasets;
using Products.Data;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class SelectPresetView : MetroForm
	{

		#region members

		readonly BindingSource bs = new BindingSource();

		#endregion

		#region public properties

		/// <summary>
		///  Returns the selected Preset (PresetRow).
		/// </summary>
		public dsShared.PresetRow SelectedPreset
		{
			get
			{
				var drv = lstPresets.SelectedItem as DataRowView;
				return drv.Row as dsShared.PresetRow;
			}
		}

		#endregion

		#region ### .ctor ###

		public SelectPresetView()
		{
			InitializeComponent();
			InitListbox();
		}

		#endregion

		#region event handlers

		void mbtnOk_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		void mbtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitListbox()
		{
			bs.DataSource = DataManager.SharedDataService.GetPresetTable();
			this.lstPresets.DataSource = bs;
			this.lstPresets.DisplayMember = "PresetName";
		}

		#endregion

	}
}
