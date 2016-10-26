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
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ContactSearchView : MetroForm
	{
		#region members

		readonly BindingSource bs = new BindingSource();
		dsContacts.KundenkontaktListeRow mySelectedContactRow;
		Kundenkontakt mySelectedContact;

		#endregion members

		#region public properties

		/// <summary>
		/// Gibt die aktuell ausgewählte KundenkontaktListeRow zurück.
		/// </summary>
		public dsContacts.KundenkontaktListeRow SelectedContactRow
		{
			get { return this.mySelectedContactRow; }
		}

		/// <summary>
		/// Gibt die Instanz des ausgewählten Kundenkontakt zurück.
		/// </summary>
		public Kundenkontakt SelectedContact
		{
			get
			{
				if (this.mySelectedContactRow != null)
				{
					var key = string.Format("{0}{1}", this.mySelectedContactRow.Kundennummer, this.mySelectedContactRow.Nummer);
					this.mySelectedContact = ModelManager.ContactService.GetKundenkontakt(key);
					return this.mySelectedContact;
				}
				return null;
			}
		}

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ContactSearchView Klasse.
		/// </summary>
		public ContactSearchView()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region private procedures

		void InitializeData()
		{
			this.dgvContacts.AutoGenerateColumns = false;
			this.bs.DataSource = Model.ModelManager.ContactService.GetKundenkontaktListe();
			this.dgvContacts.DataSource = bs;
		}

		#endregion private procedures

		#region event handler

		void dgvContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var row = this.dgvContacts.Rows[e.RowIndex];
			var drv = row.DataBoundItem as DataRowView;
			this.mySelectedContactRow = drv.Row as dsContacts.KundenkontaktListeRow;
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = this.mtxtFilter.Text.Split();

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

		void dgvContacts_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		#endregion event handler
	}
}