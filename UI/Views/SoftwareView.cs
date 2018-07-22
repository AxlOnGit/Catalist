using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class SoftwareView : MetroForm
	{
		#region members

		private Model.Entities.Kundensoftware mySoftware;
		private Model.Entities.Kunde myCustomer;
		private Model.Entities.Kundenmaschine myMachine;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neuen Instanz der SoftwareView Klasse.
		/// </summary>
		public SoftwareView(Model.Entities.Kundensoftware software, Model.Entities.Kunde kunde, Model.Entities.Kundenmaschine maschine = null)
		{
			InitializeComponent();
			mySoftware = software;
			myCustomer = kunde;
			myMachine = maschine;
			InitializeData();
		}

		#endregion ### .ctor ###

		#region private procedures

		private void InitializeData()
		{
			mcmbSoftware.DataSource = Model.ModelManager.ModelService.Softwareliste();
			mcmbSoftware.ValueMember = "UID";
			mcmbSoftware.DisplayMember = "Softwarename";
			mcmbSoftware.DataBindings.Add("SelectedValue", mySoftware, "SoftwareId");

			mtxtLizenzschluessel.DataBindings.Add("Text", mySoftware, "Lizenzschluessel");

			dtpInstallationsdatum.Value = mySoftware.Installationsdatum;

			mcmbKundenmaschine.DataSource = myCustomer.Kundenmaschinenliste;
			mcmbKundenmaschine.ValueMember = "UID";
			mcmbKundenmaschine.DisplayMember = "Seriennummer";
			mcmbKundenmaschine.DataBindings.Add("SelectedValue", mySoftware, "KundenmaschineId");

			mtxtComputer.DataBindings.Add("Text", mySoftware, "Computer");
			mtxtHauptbenutzer.DataBindings.Add("Text", mySoftware, "Hauptbenutzer");
			mtxtAnmerkungen.DataBindings.Add("Text", mySoftware, "Anmerkungen");
		}

		#endregion private procedures

		#region event handler

		private void dtpInstallationsdatum_ValueChanged(object sender, EventArgs e)
		{
			mySoftware.Installationsdatum = dtpInstallationsdatum.Value as DateTime?;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SoftwareView_FormClosing(object sender, FormClosingEventArgs e)
		{
			mySoftware.Update();
		}

		#endregion event handler
	}
}