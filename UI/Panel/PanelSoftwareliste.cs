using System.Windows.Forms;
using MetroFramework;
using Products.Model;

namespace Products.Common.Panel
{
	public partial class PanelSoftwareliste : PanelSlider
	{
		#region members

		Views.KundeMainView myParent = null;
		Model.Entities.Kunde myKunde = null;
		Model.Entities.Kundensoftware mySelectedSoftware = null;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlSoftwareliste Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		public PanelSoftwareliste(ContainerControl parentCtrl, Model.Entities.Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			myParent = parentCtrl as Views.KundeMainView;
			myKunde = kunde;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvSoftware.Rows.Count > 0)
			{
				this.mySelectedSoftware = this.dgvSoftware.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kundensoftware;
			}
		}

		void btnAdd_Click(object sender, System.EventArgs e)
		{
			this.AddSoftware();
		}

		void dgvSoftware_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowSoftware();
		}

		void btnDelete_Click(object sender, System.EventArgs e)
		{
			this.DeleteSoftware();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.dgvSoftware.AutoGenerateColumns = false;
			this.dgvSoftware.DataSource = ModelManager.SoftwareService.GetCustomersSoftware(this.myKunde);
		}

		void ShowSoftware()
		{
			if (this.mySelectedSoftware != null)
			{
				this.myParent.ShowSoftware(this.mySelectedSoftware);
			}
		}

		void AddSoftware()
		{
			if (this.myKunde == null)
			{
				this.CustomerMissingError();
				return;
			}
			var sw = Model.ModelManager.SoftwareService.AddKundenSoftware(this.myKunde);
			this.myParent.ShowSoftware(sw);
		}

		void DeleteSoftware()
		{
			if (this.myKunde == null)
			{
				this.CustomerMissingError();
				return;
			}
			else
			{
				Model.ModelManager.SoftwareService.DeleteKundenSoftware(this.mySelectedSoftware);
			}
		}

		void CustomerMissingError()
		{
			MetroMessageBox.Show(this, "Aus nicht bekanntem Grund fehlt der Kunde.", "Fehler beim Hinzufügen der Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion private procedures
	}
}