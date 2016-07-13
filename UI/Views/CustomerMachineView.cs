using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class CustomerMachineView : MetroForm
	{

		#region members

		Model.Entities.Kundenmaschine myMachine;
		Model.Entities.Notiz currentNotiz;
		Model.Entities.Kundensoftware currentSoftware;
			
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der CustomerMachineView Klasse.
		/// </summary>
		/// <param name="maschine">Verweis auf die zu bearbeitende Maschine.</param>
		public CustomerMachineView(Model.Entities.Kundenmaschine maschine)
		{
			InitializeComponent();
			myMachine = maschine;
			InitializeData();
		}

		#endregion

		#region event handler

		private void chkLeasingFlag_CheckedChanged(object sender, EventArgs e)
		{
			if (chkLeasingFlag.Checked)
			{
				myMachine.LeasingFlag = "1";
			}
			else myMachine.LeasingFlag = "0";
		}

		private void chkMietkaufFlag_CheckedChanged(object sender, EventArgs e)
		{
			if (chkMietkaufFlag.Checked)
			{
				myMachine.MietkaufFlag = "1";
			}
			else myMachine.MietkaufFlag = "0";
		}

		private void chkErstverwertungsFlag_CheckedChanged(object sender, EventArgs e)
		{
			if (chkErstverwertungsFlag.Checked)
			{
				myMachine.ErstverwertungsFlag = "1";
			}
			else myMachine.ErstverwertungsFlag = "0";
		}

		private void btnNeueMaschine_Click(object sender, EventArgs e)
		{
			Model.ModelManager.ModelService.NeueKundenmaschine(myMachine.Kunde);
		}

		private void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CustomerMachineView_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateMe();
		}

		private void ndtpKaufdatum_Validated(object sender, EventArgs e)
		{
			if (ndtpKaufdatum.Value == null)
			{
				myMachine.Kaufdatum = null;
			}
			else
			{
				myMachine.Kaufdatum = DateTime.Parse(ndtpKaufdatum.Value.ToString());
			}
		}

		private void ndtpFinanzierungsende_Validated(object sender, EventArgs e)
		{
			if (ndtpFinanzierungsende.Value == null)
			{
				myMachine.Finanzierungsende = null;
			}
			else
			{
				myMachine.Finanzierungsende = DateTime.Parse(ndtpFinanzierungsende.Value.ToString());
			}
		}

		private void btnNeueNotiz_Click(object sender, EventArgs e)
		{
			Views.NotizView nv = new NotizView(myMachine.AddNotiz(), myMachine);
			nv.Show();
		}

		private void dgvNotizen_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvNotizen.RowCount > 0)
			{
				currentNotiz = dgvNotizen.Rows[e.RowIndex].DataBoundItem as Model.Entities.Notiz;
			}
		}

		private void dgvNotizen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (currentNotiz != null)
			{
				NotizDetails();
			}
		}

		private void dgvSoftware_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			currentSoftware = dgvSoftware.Rows[e.RowIndex].DataBoundItem as Model.Entities.Kundensoftware;
		}

		#endregion

		#region private procedures

		private void InitializeData()
		{
			//this.Text = string.Format(@"Kundenmaschine von {0}, {1} [{2}]", myMachine.Kunde.CompanyName1, myMachine.Kunde.City, myMachine.Kunde.CustomerId.Substring(0, 5));
			this.Text = myMachine.Modell;
			this.lblKunde.DataBindings.Add("Text", myMachine, "Modell");

			this.txtColorSet.DataBindings.Add("Text", myMachine, "Farbset");
			this.txtFirmware.DataBindings.Add("Text", myMachine, "Firmware");
			this.txtGekauftBei.DataBindings.Add("Text", myMachine, "GekauftBei");
			this.txtSerialNumber.DataBindings.Add("Text", myMachine, "Seriennummer");
			this.txtAuftragInSage.DataBindings.Add("Text", myMachine, "AuftragsnummerSage");
			this.txtFinanzierungsgesellschaft.DataBindings.Add("Text", myMachine, "Finanzierungsgesellschaft");
			this.txtWartungsintervall.DataBindings.Add("Text", myMachine, "Wartungsintervall");

			this.cmbMachineModel.DataSource = Model.ModelManager.ModelService.Maschinenmodelle();
			this.cmbMachineModel.DisplayMember = "Modellbezeichnung";
			this.cmbMachineModel.ValueMember = "UID";
			this.cmbMachineModel.DataBindings.Add("SelectedValue", myMachine, "MaschinenmodellId");

			this.cmbInkType.DataSource = Model.ModelManager.ModelService.Tintentypen();
			this.cmbInkType.ValueMember = "UID";
			this.cmbInkType.DisplayMember = "Tintenbezeichnung";
			this.cmbInkType.DataBindings.Add("SelectedValue", myMachine, "TintenId");

			this.ndtpKaufdatum.Value = myMachine.Kaufdatum;
			this.ndtpFinanzierungsende.Value = myMachine.Finanzierungsende;

			if (myMachine.LeasingFlag == "1")
			{
				chkLeasingFlag.Checked = true;
			}
			else chkLeasingFlag.Checked = false;

			if (myMachine.MietkaufFlag == "1")
			{
				chkMietkaufFlag.Checked = true;
			}
			else chkMietkaufFlag.Checked = false;

			if (myMachine.ErstverwertungsFlag == "1")
			{
				chkErstverwertungsFlag.Checked = true;
			}
			else chkErstverwertungsFlag.Checked = false;

			dgvSoftware.AutoGenerateColumns = false;
			if (myMachine.Softwareliste != null && myMachine.Softwareliste.Count > 0)
			{
				dgvSoftware.DataSource = myMachine.Softwareliste;
			}

			dgvNotizen.AutoGenerateColumns = false;
			dgvNotizen.DataSource = myMachine.Notizliste;

			dgvSoftware.AutoGenerateColumns = false;
			dgvSoftware.DataSource = myMachine.Kunde.GetKundenmaschinenSoftware(myMachine);

		}

		private void NotizDetails()
		{
			Products.Common.Views.NotizView nv = new Products.Common.Views.NotizView(currentNotiz, myMachine);
			nv.Show();
		}

		private void UpdateMe()
		{
			Model.ModelManager.ModelService.UpdateKundenmaschinen();
		}
		
		#endregion

	}
}
