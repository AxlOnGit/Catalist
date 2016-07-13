using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KundenmaschineSearchView : MetroForm
	{

		#region members

		Kundenmaschine selectedMachine;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt die Kundenmaschine zurück, die vom Benutzer ausgewählt wurde.
		/// </summary>
		public Kundenmaschine SelectedMachine
		{
			get { return selectedMachine; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KundenmaschineSearchView Klasse.
		/// </summary>
		public KundenmaschineSearchView(SortableBindingList<Kundenmaschine> machineList)
		{
			InitializeComponent();
			dgvMaschine.AutoGenerateColumns = false;
			dgvMaschine.DataSource = machineList;
		}

		#endregion

		#region event handler

		void dgvMaschine_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvMaschine.Rows[e.RowIndex] != null)
			{
				selectedMachine = dgvMaschine.Rows[e.RowIndex].DataBoundItem as Kundenmaschine;
			}
		}

		void btnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Quit();
		}

		void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Quit();
		}

		#endregion

		#region private procedures

		void Quit()
		{
			if (selectedMachine == null)
			{
				this.DialogResult = DialogResult.Cancel;
			}
			this.Close();
		}

		#endregion

	}
}