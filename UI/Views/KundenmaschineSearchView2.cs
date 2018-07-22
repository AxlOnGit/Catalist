using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KundenmaschineSearchView2 : MetroForm
	{
		#region members

		readonly BindingSource bs = new BindingSource();
		dsMachines.KundenmaschinenListeRow mySelectedMachine;
		Kunde myKunde;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt die vom Benutzer ausgewählte Maschine zurück.
		/// </summary>
		public dsMachines.KundenmaschinenListeRow SelectedMachine
		{
			get { return this.mySelectedMachine; }
		}

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KundenmaschineSearchView2 Klasse.
		/// </summary>
		/// <param name="kunde">
		/// Wenn angegeben, wird die Auswahl auf Maschinen des angegebenen Kunden begrenzt.
		/// </param>
		public KundenmaschineSearchView2(Kunde kunde = null)
		{
			InitializeComponent();
			this.myKunde = kunde;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region private procedures

		void InitializeData()
		{
			this.dgvMachines.AutoGenerateColumns = false;
			this.dgvMachines.DataSource = bs;
			if (this.myKunde != null)
			{
				this.bs.DataSource = ModelManager.MachineService.GetKundenmaschinenSearchList(this.myKunde);
			}
			else
			{
				this.bs.DataSource = ModelManager.MachineService.GetKundenmaschinenSearchList();
			}
			this.bs.Filter = string.Empty;
		}

		#endregion private procedures

		#region event handlers

		void dgvMachines_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var row = this.dgvMachines.Rows[e.RowIndex];
				if (row == null || row.DataBoundItem == null) return;
				if (row.DataBoundItem is DataRowView)
				{
					var drv = row.DataBoundItem as DataRowView;
					this.mySelectedMachine = drv.Row as dsMachines.KundenmaschinenListeRow;
				}
				else if (row.DataBoundItem is dsMachines.KundenmaschinenListeRow)
				{
					this.mySelectedMachine = row.DataBoundItem as dsMachines.KundenmaschinenListeRow;
				}
			}
			catch (Exception ex)
			{
				var err = string.Format("{0}{1}{2}", ex.Message, Environment.NewLine, ex.InnerException);
				MetroMessageBox.Show(this, err, "Catalist - Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = this.mtxtFilter.Text.Split();

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

		void dgvMachines_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.mySelectedMachine != null)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		void mbtnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void mcmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handlers
	}
}