using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class ContactListView : MetroForm
	{

		#region members

		Model.Entities.Kunde myKunde;
		Model.Entities.Kundenkontakt mySelectedContact;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den vom Benutzer ausgewählten Ansprechpartner zurück.
		/// </summary>
		public Model.Entities.Kundenkontakt SelectedContact
		{
			get { return this.mySelectedContact; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Initialisiert eine neue Instanz der ContactListView Klasse.
		/// </summary>
		public ContactListView(Model.Entities.Kunde kunde)
		{
			InitializeComponent();
			this.myKunde = kunde;
			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.dtvContacts.AutoGenerateColumns = false;
			if (this.myKunde != null)
			{
				this.Text = string.Format("Kontakte der Firma {0}", this.myKunde.CompanyName1.Replace("&", "&&"));
				this.dtvContacts.DataSource = this.myKunde.Kontaktlist.Sort("Nummer");
			}
		}

		#endregion

		#region event handler

		void dtvContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedContact = this.dtvContacts.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kundenkontakt;
		}

		#endregion

	}
}
