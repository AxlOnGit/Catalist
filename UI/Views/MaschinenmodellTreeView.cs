using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class MaschinenmodellTreeView : MetroForm
	{
		#region MEMBERS

		Hersteller myCurrentHersteller;
		Maschinenserie myCurrentMaschinenserie;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		public Maschinenmodell SelectedModel { get; private set; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public MaschinenmodellTreeView()
		{
			InitializeComponent();
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void trvModels_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var root = this.trvModels.Nodes[0];
			var treeNode = e.Node;
			if (e.Node == root)
			{
				this.myCurrentHersteller = null;
				this.myCurrentMaschinenserie = null;
				return;
			}
			var modelList = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
			var gridList = new SortableBindingList<Maschinenmodell>();

			if (treeNode.Parent == root)
			{
				this.myCurrentHersteller = treeNode.Tag as Hersteller;
				foreach (var model in modelList)
				{
					if (model.Hersteller == (Hersteller)e.Node.Tag)
					{
						gridList.Add(model);
					}
				}
			}
			else
			{
				this.myCurrentHersteller = treeNode.Parent.Tag as Hersteller;
				this.myCurrentMaschinenserie = treeNode.Tag as Maschinenserie;
				foreach (var model in modelList)
				{
					if (model.Maschinenserie == (Maschinenserie)e.Node.Tag)
					{
						gridList.Add(model);
					}
				}
			}
			this.dgvModelle.DataSource = gridList;
		}

		void dgvWhatever_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.SelectedModel = this.dgvModelle.Rows[e.RowIndex].DataBoundItem as Maschinenmodell;
		}

		void dgvWhatever_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
				if (this.SelectedModel == null) return;
				var mv = new ModellView(this.SelectedModel);
				mv.ShowDialog(this);
				break;

				case MouseButtons.Middle:
				if (this.SelectedModel == null || this.SelectedModel.CanDelete) return;
				var list = RepoManager.KundenmaschinenRepository.GetKundenmaschinenList(this.SelectedModel);
				var titel = $"Kundenmaschinen des Maschinenmodells '{this.SelectedModel.Modellbezeichnung}'";
				var klv = new KundenmaschinenListView(list, titel);
				klv.Show(this);
				break;

				case MouseButtons.XButton1:
				break;

				case MouseButtons.XButton2:
				break;

				default:
				break;
			}
		}

		void xmnuTree_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var root = this.trvModels.Nodes[0];
			if (this.trvModels.SelectedNode.Parent == null)
			{
				// RootNode ist ausgewählt.
				this.xcmdNeuerHersteller.Enabled = true;
				this.xcmdHerstellerOeffnen.Enabled = false;
				this.xcmdNeueSerie.Enabled = false;
				this.xcmdNeuesModell.Enabled = false;
				this.xcmdSerieOeffnen.Enabled = false;
				this.xcmdKundenmaschinenlisteSerie.Enabled = false;
			}
			else if (this.trvModels.SelectedNode.Parent == root)
			{
				// Node eines Herstellers ist ausgewählt.
				this.xcmdNeuerHersteller.Enabled = false;
				this.xcmdHerstellerOeffnen.Enabled = true;
				this.xcmdNeueSerie.Enabled = true;
				this.xcmdSerieOeffnen.Enabled = false;
				this.xcmdNeuesModell.Enabled = false;
				this.xcmdKundenmaschinenlisteSerie.Enabled = false;
			}
			else
			{
				// Node einer Serie ist ausgewählt.
				this.xcmdHerstellerOeffnen.Enabled = false;
				this.xcmdNeuerHersteller.Enabled = false;
				this.xcmdNeueSerie.Enabled = false;
				this.xcmdSerieOeffnen.Enabled = true;
				this.xcmdNeuesModell.Enabled = true;
				this.xcmdKundenmaschinenlisteSerie.Enabled = true;
			}
		}

		void xmnuGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var root = this.trvModels.Nodes[0];
			if (this.trvModels.SelectedNode == null) this.trvModels.SelectedNode = root;

			var nodeType = string.Empty;
			if (this.trvModels.SelectedNode.Parent == null) nodeType = "Root";
			else if (this.trvModels.SelectedNode.Parent == root) nodeType = "Hersteller";
			else nodeType = "Serie";
			switch (nodeType)
			{
				case "Root":
				this.xcmdNewModel.Enabled = false;
				this.xcmdOpenModel.Enabled = false;
				this.xcmdKundenmaschinenListe.Enabled = false;
				this.xcmdDeleteModel.Enabled = false;
				this.xcmdNeueKundenmaschine.Enabled = false;
				this.xcmdNeuerMaschinenauftrag.Enabled = false;
				break;

				case "Hersteller":
				this.xcmdNewModel.Enabled = false;
				this.xcmdOpenModel.Enabled = this.SelectedModel != null;
				this.xcmdKundenmaschinenListe.Enabled = (this.SelectedModel != null && this.SelectedModel.CanDelete == false);
				this.xcmdDeleteModel.Enabled = (this.SelectedModel != null && this.SelectedModel.CanDelete);
				this.xcmdNeueKundenmaschine.Enabled = this.SelectedModel != null;
				this.xcmdNeuerMaschinenauftrag.Enabled = this.SelectedModel != null;
				break;

				case "Serie":
				this.xcmdNewModel.Enabled = true;
				this.xcmdOpenModel.Enabled = this.SelectedModel != null;

				// Wenn das Maschinenmodell nicht gelöscht werden kann, gibt es Kundenmaschinen
				this.xcmdKundenmaschinenListe.Enabled = this.SelectedModel.CanDelete == false;
				this.xcmdDeleteModel.Enabled = this.SelectedModel.CanDelete;
				this.xcmdNeueKundenmaschine.Enabled = this.SelectedModel != null;
				this.xcmdNeuerMaschinenauftrag.Enabled = this.SelectedModel != null;
				break;

				default:
				this.xcmdNewModel.Enabled = false;
				this.xcmdOpenModel.Enabled = false;
				this.xcmdDeleteModel.Enabled = false;
				this.xcmdKundenmaschinenListe.Enabled = false;
				break;
			}
		}

		void xcmdNeuerHersteller_Click(object sender, EventArgs e)
		{
			this.CreateHersteller();
		}

		void xcmdHerstellerOeffnen_Click(object sender, EventArgs e)
		{
			this.OpenHersteller();
		}

		void xcmdSerieOeffnen_Click(object sender, EventArgs e)
		{
			this.OpenSerie();
		}

		private void trvModels_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Tag is Hersteller) this.OpenHersteller();
			if (e.Node.Tag is Maschinenserie) this.OpenSerie();
		}

		void xcmdNeueSerie_Click(object sender, EventArgs e)
		{
			this.CreateSerie();
		}

		void xcmdNeuesModell_Click(object sender, EventArgs e)
		{
			this.CreateModel();
		}

		void xcmdModellOeffnen_Click(object sender, EventArgs e)
		{
			this.OpenModel();
		}

		void xcmdModellLoeschen_Click(object sender, EventArgs e)
		{
			this.DeleteModel();
		}

		void xcmdNewModel_Click(object sender, EventArgs e)
		{
			this.CreateModel();
		}

		void xcmdKundenmaschinenListe_Click(object sender, EventArgs e)
		{
			this.ShowKundenmaschinenListe();
		}

		void xcmdKundenmaschinenlisteSerie_Click(object sender, EventArgs e)
		{
			this.ShowKundenmaschinenlisteSerie();
		}

		void xcmdNeueKundenmaschine_Click(object sender, EventArgs e)
		{
			this.CreateKundenmaschine();
		}

		void xcmdNeuerMaschinenauftrag_Click(object sender, EventArgs e)
		{
			this.CreateMaschinenauftrag();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.dgvModelle.AutoGenerateColumns = false;

			// TreeView initialisieren
			this.trvModels.Nodes.Clear();
			var root = this.trvModels.Nodes.Add("Hersteller");
			var hList = ModelManager.SharedItemsService.HerstellerList.Sort("Herstellername");
			foreach (var hersteller in hList)
			{
				var newNode = root.Nodes.Add(hersteller.Herstellername);
				newNode.Tag = hersteller;
				newNode.ImageIndex = 0;
				newNode.SelectedImageIndex = 1;
				var sList = ModelManager.SharedItemsService.MaschinenSerieList.Sort("Serienname");
				foreach (var serie in sList)
				{
					if (serie.HerstellerId == hersteller.UID)
					{
						var sNode = newNode.Nodes.Add(serie.Serienname);
						sNode.Tag = serie;
						sNode.ImageIndex = 0;
						sNode.SelectedImageIndex = 1;
						if (this.myCurrentMaschinenserie == serie)
						{
							this.trvModels.SelectedNode = sNode;
							sNode.EnsureVisible();
						}
					}
				}
				newNode.EnsureVisible();
			}
		}

		void OpenHersteller()
		{
			if (this.myCurrentHersteller == null) return;
			var hv = new HerstellerView(this.myCurrentHersteller);
			hv.ShowDialog(this);
			this.InitializeData(); // TreeView aktualisieren
		}

		void CreateHersteller()
		{
			var hersteller = ModelManager.SharedItemsService.AddHersteller();
			var hv = new HerstellerView(hersteller);
			hv.ShowDialog(this);
			this.InitializeData(); // TreeView aktualisieren
		}

		void OpenSerie()
		{
			if (this.myCurrentMaschinenserie == null) return;
			var msv = new ModellserieView(this.myCurrentMaschinenserie);
			msv.ShowDialog(this);
			if (msv.DialogResult == DialogResult.OK) this.InitializeData();
		}

		void CreateSerie()
		{
			if (this.myCurrentHersteller == null)
			{
				MetroMessageBox.Show(this, "Das funktioniert nur, wenn Du links in der Baumstruktur einen Hersteller ausgewählt hast.");
				return;
			}
			var neueSerie = ModelManager.SharedItemsService.AddMaschinenSerie();
			neueSerie.HerstellerId = this.myCurrentHersteller.UID;
			this.InitializeData();
			var msv = new ModellserieView(neueSerie);
			msv.ShowDialog(this);
		}

		void OpenModel()
		{
			if (this.dgvModelle.RowCount == 0 || this.SelectedModel == null)
			{
				MetroMessageBox.Show(this, "Das funktioniert nur, wenn Du in der Liste ein Modell auswählst. Woher soll ich sonst wissen, was Du anzeigen willst?!");
				return;
			}
			var mv = new ModellView(this.SelectedModel);
			mv.ShowDialog(this);
		}

		void CreateModel()
		{
			if (this.myCurrentMaschinenserie == null)
			{
				MetroMessageBox.Show(this, "Das funktioniert nur, wenn Du links in der Baumstruktur eine Maschinenserie ausgewählt hast.");
				return;
			}
			var newModel = ModelManager.SharedItemsService.AddMaschinenModell();
			newModel.ModellSerieId = this.myCurrentMaschinenserie.UID;
			newModel.HerstellerId = this.myCurrentHersteller.UID;
			newModel.MaschinentypId = this.myCurrentMaschinenserie.MaschinentypId;

			var mv = new ModellView(newModel);
			if (mv.ShowDialog(this) == DialogResult.Cancel)
			{
				ModelManager.SharedItemsService.DeleteMaschinenModell(newModel);
			}
			else
			{
				var modelList = ModelManager.SharedItemsService.MaschinenModellList.Sort("Modellbezeichnung");
				var gridList = new SortableBindingList<Maschinenmodell>();
				foreach (var model in modelList)
				{
					if (model.Maschinenserie == (Maschinenserie)this.myCurrentMaschinenserie) gridList.Add(model);
				}
				this.dgvModelle.DataSource = gridList;
			}
		}

		void DeleteModel()
		{
			if (this.SelectedModel == null || !this.SelectedModel.CanDelete)
			{
				var msg = "Das funktioniert nur, wenn Du ein Maschinenmodell ausgewählt hast und wenn keine Kundenmaschinen dieses Modells gibt.";
				MetroMessageBox.Show(this, msg);
				return;
			}
			ModelManager.SharedItemsService.DeleteMaschinenModell(this.SelectedModel);
		}

		void ShowKundenmaschinenListe()
		{
			if (this.SelectedModel == null)
			{
				return;
			}
			var list = RepoManager.KundenmaschinenRepository.GetKundenmaschinenList(this.SelectedModel);
			if (list.Count > 0)
			{
				var titel = $"Kundenmaschinen für Maschinenmodell '{this.SelectedModel.Modellbezeichnung}'";
				var klv = new KundenmaschinenListView(list, titel);
				klv.Show(this);
			}
		}

		void ShowKundenmaschinenlisteSerie()
		{
			if (this.myCurrentMaschinenserie == null)
			{
				return;
			}
			var list = RepoManager.KundenmaschinenRepository.GetKundenmaschinenList(this.myCurrentMaschinenserie);
			var titel = $"Kundenmaschinen für Serie '{this.myCurrentMaschinenserie.Serienname}'";
			var klv = new KundenmaschinenListView(list, titel);
			klv.Show(this);
		}

		void CreateKundenmaschine()
		{
			if (this.SelectedModel == null)
			{
				MetroMessageBox.Show(this, "Dazu musst Du in der Liste erst ein Modell auswählen.");
				return;
			}
			Kunde kunde = null;
			Maschinenmodell modell = this.SelectedModel;

			var csv = new CustomerSearchView("Für welchen Kunden soll die neue Maschine erfasst werden?", true);
			if (csv.ShowDialog(this) == DialogResult.OK && csv.SelectedCustomer != null)
			{
				kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, true);
				var neueMaschine = ModelManager.MachineCreatorService.CreateKundenmaschine(kunde, modell, ModelManager.UserService.CurrentUser, string.Empty);
				if (neueMaschine != null)
				{
					var kmv = new KundeMainView(kunde, neueMaschine);
					kmv.Show();
				}
			}
		}

		void CreateMaschinenauftrag()
		{
			if (this.SelectedModel == null)
			{
				MetroMessageBox.Show(this, "Dazu musst Du in der Liste erst ein Modell auswählen.");
				return;
			}
			Kunde kunde = null;
			Maschinenmodell modell = this.SelectedModel;

			var csv = new CustomerSearchView("Für welchen Kunden soll die neue Maschine erfasst werden?", true);
			if (csv.ShowDialog(this) == DialogResult.OK && csv.SelectedCustomer != null)
			{
				kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, true);
				var neuerAuftrag = ModelManager.MachineService.AddMaschinenauftrag(kunde, modell);
				if (neuerAuftrag != null)
				{
					var mav = new MaschinenauftragView(neuerAuftrag);
					mav.Show();
				}
			}
		}

		#endregion PRIVATE PROCEDURES

	}
}