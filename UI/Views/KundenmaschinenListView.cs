using MetroFramework;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using System;

namespace Products.Common.Views
{
	public partial class KundenmaschinenListView : MetroForm
	{
		#region MEMBERS

		readonly string myTitle;
		readonly SortableBindingList<Kundenmaschine> myKundenmaschinenList;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		public Kundenmaschine SelectedMachine { get; private set; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		public KundenmaschinenListView(SortableBindingList<Kundenmaschine> kundenmaschinenListe, string titel)
		{
			InitializeComponent();
			this.myTitle = titel;
			this.myKundenmaschinenList = kundenmaschinenListe;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void dgvWhatever_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			this.SelectedMachine = this.dgvWhatever.Rows[e.RowIndex].DataBoundItem as Kundenmaschine;
		}

		void cmnuGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.xcmdOpenCustomer.Enabled = this.SelectedMachine != null;
			this.xcmdOpenMachine.Enabled = this.SelectedMachine != null;
			this.xcmdOpenMaschinenauftrag.Enabled = (this.SelectedMachine != null && this.SelectedMachine.Maschinenauftrag != null);
			this.xcmdNeueKundenmaschine.Enabled = this.SelectedMachine != null;
			this.xcmdNeuerMaschinenauftrag.Enabled = this.SelectedMachine != null;
		}

		void xcmdOpenMachine_Click(object sender, EventArgs e)
		{
			this.OpenMaschine();
		}

		void xcmdOpenMaschinenauftrag_Click(object sender, EventArgs e)
		{
			if (this.SelectedMachine == null || this.SelectedMachine.Maschinenauftrag == null)
			{
				MetroMessageBox.Show(this, "Für diese Kundenmaschine gibt es keinen Maschinenauftrag.");
				return;
			}
			var mav = new MaschinenauftragView(this.SelectedMachine.Maschinenauftrag);
			mav.Show();
		}

		void xcmdOpenCustomer_Click(object sender, EventArgs e)
		{
			if (this.SelectedMachine == null)
			{
				MetroMessageBox.Show(this, "Du musst erst eine Kundenmaschine auswählen.");
				return;
			}
			var kmv = new KundeMainView(this.SelectedMachine.CurrentOwner);
			kmv.Show();
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
			this.Text = this.myTitle;
			this.dgvWhatever.AutoGenerateColumns = false;
			this.dgvWhatever.DataSource = this.myKundenmaschinenList.Sort("Matchcode");
		}

		void OpenMaschine()
		{
			if (this.SelectedMachine == null)
			{
				MetroMessageBox.Show(this, "Du musst erste eine Kundenmaschine auswählen.");
				return;
			}
			var kmv = new KundeMainView(this.SelectedMachine.CurrentOwner, this.SelectedMachine);
			kmv.Show();
		}

		void CreateKundenmaschine()
		{
			if (this.SelectedMachine == null)
			{
				MetroMessageBox.Show(this, "Du musst erst eine Kundenmaschine auswählen. Das neue Maschine wird dann das selbe Modell haben.");
				return;
			}
			Kunde kunde = null;
			Maschinenmodell modell = this.SelectedMachine.Maschinenmodell;
			User currentUser = ModelManager.UserService.CurrentUser;

			var csv = new CustomerSearchView("Für welchen Kunden soll die neue Maschine erfasst werden?", true);
			if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, false);

			var neueMaschine = ModelManager.MachineCreatorService.CreateKundenmaschine(kunde, modell, currentUser, string.Empty);
			if (neueMaschine != null)
			{
				var kmv = new KundeMainView(kunde, neueMaschine);
				kmv.Show();
			}
		}

		void CreateMaschinenauftrag()
		{
			if (this.SelectedMachine == null)
			{
				MetroMessageBox.Show(this, "Du musst erst eine Kundenmaschine auswählen. Das neue Maschine wird dann das selbe Modell haben.");
				return;
			}
			Kunde kunde = null;
			Maschinenmodell modell = this.SelectedMachine.Maschinenmodell;

			var csv = new CustomerSearchView("Für welchen Kunden soll der Maschinenauftrag erfasst werden?", true);
			if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, false);

			var neuerAuftrag = ModelManager.MachineService.AddMaschinenauftrag(kunde, modell);
			if (neuerAuftrag != null)
			{
				var mav = new MaschinenauftragView(neuerAuftrag);
				mav.Show();
			}
		}

		#endregion PRIVATE PROCEDURES

		void dgvWhatever_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		}
	}
}