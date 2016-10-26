using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Interfaces;
using Products.Common.Views;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlMaschinenListe : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		Kundenmaschine mySelectedMachine;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlMaschinen Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		public pnlMaschinenListe(ContainerControl parentCtrl, Model.Entities.Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();

			this.myParent = parentCtrl as Views.KundeMainView;
			this.myKunde = kunde;
			this.dgvMachines.AutoGenerateColumns = false;
			this.dgvMachines.DataSource = ModelManager.MachineService.GetKundenMaschineList(this.myKunde.CustomerId).Sort("Modellbezeichnung");
		}

		#endregion ### .ctor ###

		#region event handler

		void mctxGrid_Opening(object sender, CancelEventArgs e)
		{
			this.mcmnuDelete.Enabled = mySelectedMachine.CanDelete();
		}

		void dgvMachines_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var machine = dgvMachines.Rows[e.RowIndex].DataBoundItem as Kundenmaschine;
			if (machine != null)
			{
				this.mySelectedMachine = machine;

				var openText = string.Format("Öffnen ({0})", machine.Modellbezeichnung);
				this.mHtmlTip.SetToolTip(this.mbtnOpen, openText);
				this.mcmnuOpen.Text = openText;

				var openTerminText = string.Format("Servicetermine ({0})", machine.Modellbezeichnung);
				this.mcmnuServicetermine.Text = openTerminText;

				var moveText = string.Format("Verschieben ({0})", machine.Modellbezeichnung);
				this.mHtmlTip.SetToolTip(mbtnMove, moveText);
				this.mcmnuMove.Text = moveText;
			}
		}

		void pnlMaschinen_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && (e.KeyCode == Keys.Home))
			{
				this.myParent.ShowStartPanel();
			}
		}

		void dgvMachines_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowMachine();
		}

		void mbtnMaschineAnzeigen_Click(object sender, EventArgs e)
		{
			this.ShowMachine();
		}

		void mcmnuMaschineAnzeigen_Click(object sender, EventArgs e)
		{
			this.ShowMachine();
		}

		void mbtNeueMaschine_Click(object sender, EventArgs e)
		{
			this.AddMaschine();
		}

		void mcmnuNeueMaschine_Click(object sender, EventArgs e)
		{
			this.AddMaschine();
		}

		void mbtnServicetermine_Click(object sender, EventArgs e)
		{
			this.ShowServicetermine();
		}

		void mcmnuTermineAnzeigen_Click(object sender, EventArgs e)
		{
			this.ShowServicetermine();
		}

		void mbtnVerschieben_Click(object sender, EventArgs e)
		{
			this.MoveMaschine();
		}

		void mcmnuVerschieben_Click(object sender, EventArgs e)
		{
			this.MoveMaschine();
		}

		void mcmnuDelete_Click(object sender, EventArgs e)
		{
			DeleteMaschine();
		}

		#endregion event handler

		#region private procedures

		void ShowServicetermine()
		{
			if (this.mySelectedMachine == null) return;
			var machineAsLink = this.mySelectedMachine as ILinkedItem;
			var aList = ModelManager.AppointmentService.GetAppointmentList(machineAsLink.Key, machineAsLink.LinkTypeId);
			var adv = new AppointmentListView(aList, mySelectedMachine.Maschinenmodell.Modellbezeichnung);
			adv.Show();
		}

		void ShowMachine()
		{
			if (this.mySelectedMachine == null) return;
			this.myParent.ShowMaschine(mySelectedMachine);
		}

		void AddMaschine()
		{
			var newMachine = ModelManager.MachineService.AddKundenMaschine(this.myKunde.CustomerId);
			this.myParent.ShowMaschine(newMachine);
		}

		void MoveMaschine()
		{
			if (this.mySelectedMachine == null) return;
			var modell = this.mySelectedMachine.Modellbezeichnung;
			var msg = string.Empty;
			var csv = new CustomerSearchView("Zu welchem Kunden soll die Maschine verschoben werden?", false);
			if (csv.ShowDialog() != DialogResult.OK || csv.SelectedCustomer == null) return;

			if (this.myKunde.CustomerId == csv.SelectedCustomer.Kundennummer)
			{
				msg = string.Format("Die Maschine gehört doch schon zu {0}", myKunde.CompanyName1);
				MetroMessageBox.Show(this, msg, "Watt soll dat denn?", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			ModelManager.MachineService.TransferMachine(this.mySelectedMachine, this.myKunde.CustomerId, csv.SelectedCustomer.Kundennummer);
			msg = string.Format("Die Maschine '{0}' wurde zu '{1}' verschoben.", modell, csv.SelectedCustomer.Name1);
			MetroMessageBox.Show(this, msg);
		}

		void DeleteMaschine()
		{
			if (this.mySelectedMachine != null)
			{
				var msg = string.Format("Soll {0} mit der Seriennummer {1} wirklich gelöscht werden?", mySelectedMachine.Modellbezeichnung, mySelectedMachine.Seriennummer);

				if (MetroMessageBox.Show(this, msg, "Maschine löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					ModelManager.MachineService.DeleteKundenMachine(this.mySelectedMachine);
				}
			}
		}

		#endregion private procedures
	}
}