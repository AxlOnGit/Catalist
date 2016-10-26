using System;
using System.Windows.Forms;
using Products.Model;

namespace Products.Common.Panel
{
	public partial class pnlSoftware : pnlSlider
	{
		#region members

		Views.KundeMainView myParent;
		Model.Entities.Kundensoftware mySoftware;
		Model.Entities.Kunde myKunde;

		#endregion members

		#region ### .ctor ###

		public pnlSoftware(ContainerControl parentCtrl, Model.Entities.Kundensoftware software, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as Views.KundeMainView;
			this.mySoftware = software;
			this.myKunde = software.Kunde;

			this.InitializeData();
			this.OnClosed += pnlSoftware_OnClosed;
		}

		#endregion ### .ctor ###

		#region event handler

		void dtpInstallationsdatum_ValueChanged(object sender, EventArgs e)
		{
			this.mySoftware.Installationsdatum = dtpInstallationsdatum.Value as DateTime?;
		}

		void pnlSoftware_OnClosed(object sender, EventArgs e)
		{
			ModelManager.SoftwareService.UpdateKundenSoftware();
		}

		#endregion event handler

		#region private procedures

		void InitializeData()
		{
			this.mcmbSoftware.DataSource = ModelManager.SoftwareService.GetSoftwareList().Sort("Softwarename");
			this.mcmbSoftware.ValueMember = "UID";
			this.mcmbSoftware.DisplayMember = "ItemName";
			this.mcmbSoftware.DataBindings.Add("SelectedValue", mySoftware, "SoftwareId");

			this.mtxtLizenzschluessel.DataBindings.Add("Text", mySoftware, "Lizenzschluessel");

			this.dtpInstallationsdatum.Value = mySoftware.Installationsdatum;

			this.mcmbKundenmaschine.DataSource = ModelManager.MachineService.GetKundenMaschineList(this.myKunde.CustomerId);
			this.mcmbKundenmaschine.ValueMember = "UID";
			this.mcmbKundenmaschine.DisplayMember = "ItemName";
			this.mcmbKundenmaschine.DataBindings.Add("SelectedValue", mySoftware, "KundenmaschineId");

			this.mtxtComputer.DataBindings.Add("Text", mySoftware, "Computer");
			this.mtxtHauptbenutzer.DataBindings.Add("Text", mySoftware, "Hauptbenutzer");
			this.mtxtAnmerkungen.DataBindings.Add("Text", mySoftware, "Anmerkungen");
		}

		#endregion private procedures
	}
}