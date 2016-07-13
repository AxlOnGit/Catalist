using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Data.Datasets;

namespace Products.Common.Views
{
	public partial class KundenmaschineSearchView2 : MetroForm
	{

		#region members

		readonly BindingSource bs = new BindingSource();
		dsMachines.KundenmaschinenListeRow mySelectedMachine;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt die vom Benutzer ausgewählte Maschine zurück.
		/// </summary>
		public dsMachines.KundenmaschinenListeRow SelectedMachine
		{
			get { return this.mySelectedMachine; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KundenmaschineSearchView2 Klasse.
		/// </summary>
		public KundenmaschineSearchView2()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvMachines.AutoGenerateColumns = false;
			this.bs.DataSource = Model.ModelManager.MachineService.GetKundenmaschinenSearchList();
			this.dgvMachines.DataSource = bs;
		}

		#endregion

		#region event handlers

		void dgvMachines_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var row = this.dgvMachines.Rows[e.RowIndex];
			if (row == null) return;
			var drv = row.DataBoundItem as DataRowView;
			this.mySelectedMachine = drv.Row as dsMachines.KundenmaschinenListeRow;
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			string outputInfo = string.Empty;
			string[] keyWords = this.mtxtFilter.Text.Split();

			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = "(Maschine LIKE '%" + word + "%' OR Seriennummer LIKE '%" + word + "%' OR Firma LIKE '%" + word + "%')";
				}
				else
				{
					outputInfo += " AND (Maschine LIKE '%" + word + "%' OR Seriennummer LIKE '%" + word + "%' OR Firma LIKE '%" + word + "%')";
				}
				this.bs.Filter = outputInfo;
				this.mtxtFilter.ShowButton = !string.IsNullOrEmpty(outputInfo);
			}
		}

		void metroTextButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void mcmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
