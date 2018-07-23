using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class PanelAngebote : PanelSlider
	{

		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		Offer myCurrentOffer;

		#endregion

		#region ### .ctor ###

		public PanelAngebote(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;

			this.InitializeData();
			Application.Idle += Application_Idle;
		}

		#endregion

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			var jau = dgvOffers.Rows.Count > 0;
			btnAngebotAnzeigen.Enabled = jau;
			mcmdAngebotAnzeigen.Enabled = jau;
			txtAngebotsinfo.Enabled = jau;
		}

		void dgvOffers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			myCurrentOffer = dgvOffers.Rows[e.RowIndex].DataBoundItem as Model.Entities.Offer;
			if (myCurrentOffer != null)
			{
				var anzeigenText = string.Format("Angebot vom {0:d} öffnen", myCurrentOffer.CreateDate);
				mtoolTipMain.SetToolTip(btnAngebotAnzeigen, anzeigenText);
				mcmdAngebotAnzeigen.Text = anzeigenText;
				txtAngebotsinfo.Text = myCurrentOffer.Comments;
			}
		}

		void txtAngebotsinfo_Validated(object sender, EventArgs e)
		{
			if (myCurrentOffer != null)
			{
				myCurrentOffer.Comments = txtAngebotsinfo.Text.Trim();
			}
		}

		void btnAngebotAnzeigen_Click(object sender, EventArgs e)
		{
			AngebotAnzeigen();
		}

		void mcmdAngebotAnzeigen_Click(object sender, EventArgs e)
		{
			AngebotAnzeigen();
		}

		void mcmcNeuesAngebot_Click(object sender, EventArgs e)
		{
			CreateOffer();
		}

		void btnNeuesAngebot_Click(object sender, EventArgs e)
		{
			CreateOffer();
		}

		void btnAngebotLoeschen_Click(object sender, EventArgs e)
		{
			this.DeleteOffer();
		}

		void mcmdDeleteAngebot_Click(object sender, EventArgs e)
		{
			this.DeleteOffer();
		}

		void dgvOffers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			AngebotAnzeigen();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			dgvOffers.AutoGenerateColumns = false;
			dgvOffers.DataSource = myKunde.OfferList.Sort("ChangeDate", System.ComponentModel.ListSortDirection.Descending);
		}

		void AngebotAnzeigen()
		{
			if (myCurrentOffer != null)
			{
				myParent.ShowAngebotsdetail(myCurrentOffer);
			}
		}

		void CreateOffer()
		{
			myParent.ShowAngebotsdetail(Model.ModelManager.OfferService.CreateOffer(myKunde));
		}

		void DeleteOffer()
		{
			if (this.myCurrentOffer != null)
			{
				if (MetroMessageBox.Show(this, "Dieses Angebot wirklich löschen?", "Catalist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Model.ModelManager.OfferService.DeleteOffer(this.myCurrentOffer);
					MetroMessageBox.Show(this,"So, das Angebot ist im Nirvana ...", "Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}


		#endregion

	}
}
