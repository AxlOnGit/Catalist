using System.Data;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class WartungsvorschlagView : MetroForm
	{

		#region members

		readonly SortableBindingList<Model.Services.Wartungsvorschlag> myTable;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="WartungsvorschlagView"/> Formularklasse.
		/// </summary>
		public WartungsvorschlagView(SortableBindingList<Model.Services.Wartungsvorschlag> gridTable)
		{
			InitializeComponent();
			this.myTable = gridTable;

			this.InitializeData();
		}

		#endregion

		#region event handler
		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvMachines.AutoGenerateColumns = false;
			this.dgvMachines.DataSource = this.myTable.Sort("LetzteWartung", System.ComponentModel.ListSortDirection.Descending);
		}
		
		#endregion

	}
}
