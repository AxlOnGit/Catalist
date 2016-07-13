using System;
using System.Windows.Forms;
using Products.Model;

namespace Products.Common.Panel
{
	public partial class pnlSoftware : pnlSlider
	{

		#region members

		private Views.KundeMainView myParent = null;
		private Model.Entities.Kundensoftware mySoftware = null;
		private Model.Entities.Kunde myKunde = null;

		#endregion

		#region ### .ctor ###

		public pnlSoftware(ContainerControl parentCtrl, Model.Entities.Kundensoftware software, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			myParent = parentCtrl as Views.KundeMainView;
			mySoftware = software;
			myKunde = software.Kunde;

			InitializeData();
			this.OnClosed += new EventHandler(pnlSoftware_OnClosed);
		}

		#endregion

		#region event handler

		void dtpInstallationsdatum_ValueChanged(object sender, EventArgs e)
		{
			mySoftware.Installationsdatum = dtpInstallationsdatum.Value as DateTime?;
		}

		void pnlSoftware_OnClosed(object sender, EventArgs e)
		{
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			mcmbSoftware.DataSource = ModelManager.SoftwareService.GetSoftwareList().Sort("Softwarename");
			mcmbSoftware.ValueMember = "UID";
			mcmbSoftware.DisplayMember = "Softwarename";
			mcmbSoftware.DataBindings.Add("SelectedValue", mySoftware, "SoftwareId");

			mtxtLizenzschluessel.DataBindings.Add("Text", mySoftware, "Lizenzschluessel");

			dtpInstallationsdatum.Value = mySoftware.Installationsdatum;

			mcmbKundenmaschine.DataSource = ModelManager.MachineService.GetKundenMaschineList(this.myKunde.CustomerId);
			mcmbKundenmaschine.ValueMember = "UID";
			mcmbKundenmaschine.DisplayMember = "Seriennummer";
			mcmbKundenmaschine.DataBindings.Add("SelectedValue", mySoftware, "KundenmaschineId");

			mtxtComputer.DataBindings.Add("Text", mySoftware, "Computer");
			mtxtHauptbenutzer.DataBindings.Add("Text", mySoftware, "Hauptbenutzer");
			mtxtAnmerkungen.DataBindings.Add("Text", mySoftware, "Anmerkungen");
		}

		#endregion

	}
}
