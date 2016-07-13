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
	public partial class ContactSearchView : MetroForm
	{

		#region members

		readonly BindingSource bs = new BindingSource();
		dsContacts.KundenkontaktListeRow selectedContactRow;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt die aktuell ausgewählte KundenkontaktListeRow zurück.
		/// </summary>
		public Data.Datasets.dsContacts.KundenkontaktListeRow SelectedContactRow
		{
			get { return this.selectedContactRow; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ContactSearchView Klasse.
		/// </summary>
		public ContactSearchView()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dgvContacts.AutoGenerateColumns = false;
			this.bs.DataSource = Model.ModelManager.ContactService.GetKundenkontaktListe();
			this.dgvContacts.DataSource = bs;
		}

		void dgvContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var row = this.dgvContacts.Rows[e.RowIndex];
			var drv = row.DataBoundItem as DataRowView;
			this.selectedContactRow = drv.Row as dsContacts.KundenkontaktListeRow;
		}

		#endregion

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			string outputInfo = string.Empty;
			string[] keyWords = this.mtxtFilter.Text.Split();

			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = "(Kundennummer LIKE '%" + word + "%' OR Kontaktname LIKE '%" + word + "%' OR Firma LIKE '%" + word + "%')";
				}
				else
				{
					outputInfo += " AND (Kundennummer LIKE '%" + word + "%' OR Kontaktname LIKE '%" + word + "%' OR Firma LIKE '%" + word + "%')";
				}
				this.bs.Filter = outputInfo;
				this.mtxtFilter.ShowButton = !string.IsNullOrEmpty(outputInfo);
			}
		}

		#region public procedures
		#endregion

	}
}
