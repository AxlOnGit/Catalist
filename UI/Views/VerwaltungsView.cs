using MetroFramework.Forms;
using System.Windows.Forms;
using Products.Model;

namespace Products.Common.Views
{
	public partial class VerwaltungsView : MetroForm
	{

		#region members

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der VerwaltungsView	Klasse.
		/// </summary>
		public VerwaltungsView()
		{
			InitializeComponent();
		}

		#endregion

		#region event handler

		void VerwaltungsView_MouseEnter(object sender, System.EventArgs e)
		{
			if (!this.Focused)
			{
				this.Focus();
			}
		}

		void metroTile1_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if (ModelManager.UserService.CurrentUser.UserName == "Axel Ullrich")
			{
				var axels = new AxelsVerwaltungsView();
				axels.ShowDialog(this);
			}
			this.Cursor = Cursors.Default;
		}

		void mtilePresets_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ShowPresetsView();
			this.Cursor = Cursors.Default;
		}

		void mtileMaschinenmodelle_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ShowMaschinenmodelleView();
			this.Cursor = Cursors.Default;
		}

		void mtileKataloginhalt_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ShowCatalogView();
			this.Cursor = Cursors.Default;
		}

		void mtileTinte_Click(object sender, System.EventArgs e)
		{
			this.ShowTintenListView();
		}

		void mtileTouren_Click(object sender, System.EventArgs e)
		{
			ShowTourenListenView();
		}

		void mtileArtikelstamm_Click(object sender, System.EventArgs e)
		{
			this.ShowArtikelstammView();
		}

		void mtileLieferanten_Click(object sender, System.EventArgs e)
		{
			var llv = new LieferantenListView();
			llv.Show();
		}

		void mtileDummy2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		void mtileUserSettings_Click(object sender, System.EventArgs e)
		{
			var udv = new UserDetailView(ModelManager.UserService.CurrentUser);
			udv.ShowDialog(this);
		}

		#endregion

		#region private procedures

		void ShowStatistikenView()
		{
			var av = new ArtikelstammView();
			av.Show(this);
		}

		void ShowMaschinenmodelleView()
		{
			var mmv = new MaschinenmodellView();
			mmv.ShowDialog();
		}

		void ShowPresetsView()
		{
			var plv = new PresetListView();
			plv.ShowDialog();
		}

		void ShowCatalogView()
		{
			var kv = new KatalogIndexView();
			kv.ShowDialog();
			kv.Dispose();
		}

		void ShowTintenListView()
		{
			var tlv = new TintenListView(ModelManager.SharedItemsService.TinteList);
			tlv.ShowDialog(this);
		}

		void ShowTourenListenView()
		{
			var tlv = new TourListenView(ModelManager.SalesForceService.GetTourList(), false);
			tlv.Show(this);
		}

		void ShowArtikelstammView()
		{
			var av = new ArtikelstammView();
			av.Show(this);
		}

		#endregion

	}
}
