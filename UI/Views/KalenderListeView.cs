using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KalenderListeView : MetroForm
	{

		#region members

		User myUser;
		BindingSource bs;
		Appointment selectedTermin;
		
		#endregion

		#region public properties

		/// <summary>
		/// Gibt den vom Benutzer ausgewählten Termin zurück.
		/// </summary>
		public Appointment SelectedTermin
		{
			get
			{
				return selectedTermin;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der KalenderListeView Klasse.
		/// </summary>
		public KalenderListeView(User forUser)
		{
			InitializeComponent();
			myUser = forUser;

			InitializeData();
		}

		#endregion

		#region event handler

		void dgvTermine_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			selectedTermin = dgvTermine.Rows[e.RowIndex].DataBoundItem as Appointment;
		}

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		void dgvTermine_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (selectedTermin != null)
			{
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			selectedTermin = null;
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			if (myUser != null)
			{
				dgvTermine.AutoGenerateColumns = false;
				bs = new BindingSource();
				bs.DataSource = myUser.Terminliste;
				bs.Sort = "StartDate DESC";
				dgvTermine.DataSource = bs;
			}
		}

		#endregion

	}
}
