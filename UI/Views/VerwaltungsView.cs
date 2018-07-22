using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;

namespace Products.Common.Views
{
	public partial class VerwaltungsView : MetroForm
	{
		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der VerwaltungsView Klasse.
		/// </summary>
		public VerwaltungsView()
		{
			InitializeComponent();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		private void VerwaltungsView_MouseEnter(object sender, EventArgs e)
		{
			if (!this.Focused)
			{
				//this.Focus();
			}
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if (ModelManager.UserService.CurrentUser.UserName == "Axel Ullrich")
			{
				var axels = new AxelsVerwaltungsView();
				axels.Show(this);
			}
			this.Cursor = Cursors.Default;
		}

		private void mtilePresets_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ShowPresetsView();
			this.Cursor = Cursors.Default;
		}

		private void mtileMaschinenmodelle_Click(object sender, EventArgs e)
		{
			this.ShowMaschinenmodelleView();
		}

		private void mtileKataloginhalt_Click(object sender, EventArgs e)
		{
			this.ShowCatalogView();
		}

		private void mtileTinte_Click(object sender, EventArgs e)
		{
			this.ShowTintenListView();
		}

		private void mtileTouren_Click(object sender, EventArgs e)
		{
			ShowTourenListenView();
		}

		private void mtileArtikelstamm_Click(object sender, EventArgs e)
		{
			this.ShowArtikelstammView();
		}

		private void mtileLieferanten_Click(object sender, EventArgs e)
		{
			var llv = new LieferantenListView();
			llv.Show();
		}

		private void mtileSoftwareUpgrades_Click(object sender, EventArgs e)
		{
			this.ShowSoftwareUpgradeListView();
		}

		private void mtileSoftware_Click(object sender, EventArgs e)
		{
			this.ShowSoftwareListView();
		}

		private void mtileDummy2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mtileUserSettings_Click(object sender, EventArgs e)
		{
			var udv = new UserDetailView(ModelManager.UserService.CurrentUser);
			udv.Show(this);
		}

		private void mtileMaschinenauftraege_Click(object sender, EventArgs e)
		{
			this.ShowMaschinenauftraegeListView();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		private void ShowStatistikenView()
		{
			var av = new ArtikelstammView();
			av.Show(this);
		}

		private void ShowMaschinenmodelleView()
		{
			//var mmv = new ModellListView();
			var mtv = new MaschinenmodellTreeView();
			mtv.Show(this);
		}

		private void ShowPresetsView()
		{
			var plv = new PresetListView();
			plv.Show(this);
		}

		private void ShowCatalogView()
		{
			var kv = new KatalogIndexView();
			kv.Show(this);
		}

		private void ShowTintenListView()
		{
			var tlv = new TintenListView(ModelManager.SharedItemsService.TinteList);
			tlv.Show(this);
		}

		private void ShowTourenListenView()
		{
			var tlv = new TourListenView(ModelManager.SalesForceService.GetTourList(), false);
			tlv.Show(this);
		}

		private void ShowArtikelstammView()
		{
			var av = new ArtikelstammView();
			av.Show(this);
		}

		private void ShowSoftwareListView()
		{
			throw new NotImplementedException();
		}

		private void ShowSoftwareUpgradeListView()
		{
			var sulv = new SoftwareUpgradeListView(null);
			sulv.Show();
		}

		private void ShowMaschinenauftraegeListView()
		{
			var mal = new MaschinenauftragListView(null);
			mal.Show();
		}

		#endregion PRIVATE PROCEDURES
	}
}