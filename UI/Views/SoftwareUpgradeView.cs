using System;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class SoftwareUpgradeView : MetroForm
	{
		#region MEMBERS

		readonly SoftwareUpgrade mySoftwareUpgrade;

		#endregion MEMBERS

		#region ### .ctor ###

		public SoftwareUpgradeView(SoftwareUpgrade upgrade)
		{
			InitializeComponent();
			this.mySoftwareUpgrade = upgrade;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void mlnkNeueVersion_Click(object sender, EventArgs e)
		{
			var ksv = new KundensoftwareSearchView(this.mySoftwareUpgrade.Kunde);
			ksv.ShowDialog(this);
			if (ksv.SelectedKundensoftware != null)
			{
				var versionId = ksv.SelectedKundensoftware.UID;
				var lizenz = ksv.SelectedKundensoftware.Lizenzschluessel;
				this.mySoftwareUpgrade.NeueVersionId = versionId;
				this.mySoftwareUpgrade.NeueLizenz = lizenz;
				this.mtxtNeueLizenz.Text = lizenz;
			}
		}

		void ndtpAngefordertAm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.mySoftwareUpgrade.AngefordertAm = (DateTime)this.ndtpAngefordertAm.Value;
		}

		void mlnkAngefordertVon_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			usv.ShowDialog(this);
			if (usv.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				this.mySoftwareUpgrade.AngefordertVonId = usv.SelectedUser.UID;
				this.mlnkAngefordertVon.Text = usv.SelectedUser.NameFull;
			}
		}

		void ndtpErhaltenAm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.mySoftwareUpgrade.ErhaltenAm = (DateTime)this.ndtpErhaltenAm.Value;
		}

		void ndtpKundeInformiertAm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.mySoftwareUpgrade.KundeInformiertAm = (DateTime)this.ndtpKundeInformiertAm.Value;
		}

		void mlnkKundeInformiertVon_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			usv.ShowDialog(this);
			if (usv.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				this.mySoftwareUpgrade.KundeInformiertVonId = usv.SelectedUser.UID;
				this.mlnkKundeInformiertVon.Text = usv.SelectedUser.NameFull;
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void SoftwareUpgradeView_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			Model.ModelManager.SoftwareService.UpdateSoftwareUpgrades();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.mlblMatchcode.Text = $"{this.mySoftwareUpgrade.Matchcode}";
			this.mlblMaschinenmodell.Text = $"{this.mySoftwareUpgrade.Maschinenmodell} [{this.mySoftwareUpgrade.Seriennummer}]";
			this.mlnkAlteVersion.Text = this.mySoftwareUpgrade.AlteVersionName;
			this.mtxtAlteLizenz.Text = this.mySoftwareUpgrade.AlteLizenz;
			this.mlnkNeueVersion.Text = this.mySoftwareUpgrade.NeueVersionName;
			this.mtxtNeueLizenz.Text = this.mySoftwareUpgrade.NeueLizenz;

			if (this.mySoftwareUpgrade.AngefordertVon != null) { this.mlnkAngefordertVon.DataBindings.Add("Text", this.mySoftwareUpgrade.AngefordertVon, "NameFull"); }
			if (this.mySoftwareUpgrade.KundeInformiertVon != null) { this.mlnkKundeInformiertVon.DataBindings.Add("Text", this.mySoftwareUpgrade.KundeInformiertVon, "NameFull"); }
			this.ndtpAngefordertAm.Value = this.mySoftwareUpgrade.AngefordertAm;
			if (this.mySoftwareUpgrade.AngefordertVon != null) { this.mlnkAngefordertVon.Text = this.mySoftwareUpgrade.AngefordertVon.NameFull; }
			this.ndtpErhaltenAm.Value = this.mySoftwareUpgrade.ErhaltenAm;
			this.ndtpKundeInformiertAm.Value = this.mySoftwareUpgrade.KundeInformiertAm;
			if (this.mySoftwareUpgrade.KundeInformiertVon != null) { this.mlnkKundeInformiertVon.Text = this.mySoftwareUpgrade.KundeInformiertVon.NameFull; }
		}

		#endregion PRIVATE PROCEDURES
	}
}