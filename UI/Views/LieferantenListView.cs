using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class LieferantenListView : MetroForm
	{

		#region members

		Lieferant mySelectedLieferant;
		SBList<Lieferant> myDataSource;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den vom Benutzer ausgewählten Lieferanten zurück.
		/// </summary>
		public Lieferant SelectedLieferant
		{
			get { return this.mySelectedLieferant; }
			private set { this.mySelectedLieferant = value; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der LieferantListView Klasse.
		/// </summary>
		public LieferantenListView()
		{
			InitializeComponent();

			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvSuppliers.AutoGenerateColumns = false;
			this.myDataSource = ModelManager.SupplierService.GetSupplierList().Sort("Name1");
			this.dgvSuppliers.DataSource = this.myDataSource;
		}

		#endregion

		#region event handler

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			if (string.IsNullOrEmpty(this.mtxtFilter.Text))
			{
				this.myDataSource.Filter = "";
				return;
			}

			string outputInfo = string.Empty;
			string[] keyWords = this.mtxtFilter.Text.Split();
			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = string.Format(@"(Name1.ToLower().IndexOf(""{0}"") > -1 OR Name2.ToLower().IndexOf(""{0}"") > -1 OR Lieferantennummer.ToLower().IndexOf(""{0}"") > -1)", word.ToLower());
				}
				else
				{
					outputInfo += string.Format(@" AND ((Name1.ToLower().IndexOf(""{0}"") > -1 OR Name2.ToLower().IndexOf(""{0}"") > -1 OR Lieferantennummer.ToLower().IndexOf(""{0}"") > -1))", word.ToLower());
				}
				this.myDataSource.Filter = outputInfo;
			}
		}

		void dgvSuppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgvSuppliers.RowCount == 0)
			{
				this.Text = "Kein Lieferant mit dem eingegebenen Filter gefunden";
				return;
			}
			this.SelectedLieferant = this.dgvSuppliers.Rows[e.RowIndex].DataBoundItem as Lieferant;
			if (this.SelectedLieferant.Kontaktperson != null)
			{
				this.Text = string.Format("{0} [{1}] - Ansprechpartner: {2}", this.SelectedLieferant.Name1, this.SelectedLieferant.Lieferantennummer.Substring(0, 5), this.SelectedLieferant.Kontaktperson.Kontaktname);
			}
			else
			{
				this.Text = string.Format("{0} [{1}] - * Kein Ansprechpartner eingetragen *", this.SelectedLieferant.Name1, this.SelectedLieferant.Lieferantennummer.Substring(0, 5));
			}
			this.Invalidate();
		}

		void btnChangeKunde_Click(object sender, EventArgs e)
		{
			this.ShowPurchaseOrders();
		}

		void xcmdPurchaseOrders_Click(object sender, EventArgs e)
		{
			this.ShowPurchaseOrders();
		}

		void mtxtFilter_ClearClicked()
		{
			this.myDataSource.Filter = "";
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		void LieferantenListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.myDataSource != null && !string.IsNullOrEmpty(this.myDataSource.Filter))
			{
				this.myDataSource.Filter = "";
			} 
		}

		#endregion

		#region private procedures

		void ShowPurchaseOrders()
		{
			if (this.mySelectedLieferant.GetBestellungList() != null)
			{
				var blv = new BestellungListView(this.mySelectedLieferant);
				blv.Show();
			}
		}

		#endregion

	}
}
