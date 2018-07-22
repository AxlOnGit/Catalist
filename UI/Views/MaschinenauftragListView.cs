using MetroFramework.Forms;
using Products.Model.Entities;
using System;
using System.Diagnostics;
using System.IO;

namespace Products.Common.Views
{
	public partial class MaschinenauftragListView : MetroForm
	{
		#region MEMBERS

		readonly SortableBindingList<Maschinenauftrag> myDatasource;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		public Maschinenauftrag SelectedMaschinenauftrag { get; private set; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="MaschinenauftragListView"/> Formularklasse.
		/// </summary>
		/// <param name="auftragsListe"></param>
		public MaschinenauftragListView(SortableBindingList<Maschinenauftrag> auftragsListe)
		{
			InitializeComponent();
			if (auftragsListe == null) auftragsListe = Model.ModelManager.MachineService.GetMaschinenauftragAktivListe();
			this.myDatasource = auftragsListe.Sort("Kundennummer");
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void dgvMaschinenauftraege_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			this.SelectedMaschinenauftrag = this.dgvMaschinenauftraege.Rows[e.RowIndex].DataBoundItem as Maschinenauftrag;
			var auftrag = this.SelectedMaschinenauftrag;
			if (auftrag != null)
			{
				// Titel
				this.mlblAuftragstitel.Text = $"{auftrag.Maschinenmodell} für Firma { auftrag.Matchcode}";

				// Bestelldatum Kunde
				this.mtxtKundenbestellungAm.Text = auftrag.KundenbestellungAm.HasValue ? auftrag.KundenbestellungAm.Value.ToShortDateString() : "-";

				// Lieferwunsch Kunde
				this.mtxtLieferungZumKundenAm.Text = auftrag.LieferungZumKundenAm.HasValue ? auftrag.LieferungZumKundenAm.Value.ToShortDateString() : "-";

				// Ausgeliefert am
				if (auftrag.Maschine.Rechnungsdatum.HasValue)
				{
					this.mtxtRechnungsOderLieferdatum.Text = auftrag.Maschine.Rechnungsdatum.Value.ToShortDateString();
				}
				else this.mtxtRechnungsOderLieferdatum.Text = auftrag.Maschine.Lieferdatum.HasValue ? auftrag.Maschine.Lieferdatum.Value.ToShortDateString() : "-";

				// Bestellt beim Hersteller
				this.mtxtMaschinenbestellungAm.Text = auftrag.MaschinenbestellungAm.HasValue ? auftrag.MaschinenbestellungAm.Value.ToShortDateString() : "-";

				// Hersteller liefert am
				this.mtxtMaschinenlieferungAm.Text = auftrag.MaschinenlieferungAm.HasValue ? auftrag.MaschinenlieferungAm.Value.ToShortDateString() : "-";
			}

			// Bemerkungen zur Bestellung
			this.mtxtAnmerkungenBestellung.Text = auftrag.AnmerkungenBestellung;
		}

		void mtxtAnmerkungenBestellung_Validated(object sender, EventArgs e)
		{
			if (this.SelectedMaschinenauftrag != null)
			{
				this.SelectedMaschinenauftrag.AnmerkungenBestellung = this.mtxtAnmerkungenBestellung.Text;
			}
		}

		void mtogglAlleAnzeigen_CheckedChanged(object sender, EventArgs e)
		{
			SortableBindingList<Maschinenauftrag> source = this.dgvMaschinenauftraege.DataSource as SortableBindingList<Maschinenauftrag>;
			var sortedBy = source.SortPropertyName;
			var sortDirection = source.SortDirection;

			switch (this.mtogglAlleAnzeigen.Checked)
			{
				case true:
					source = Model.ModelManager.MachineService.GetMaschinenauftragListe();
					break;

				case false:
					source = Model.ModelManager.MachineService.GetMaschinenauftragAktivListe();
					break;
			}

			if (sortedBy != null)
			{
				this.dgvMaschinenauftraege.DataSource = source.Sort(sortedBy, sortDirection);
				return;
			}
			this.dgvMaschinenauftraege.DataSource = source;
		}

		void dgvMaschinenauftraege_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.ShowMaschinenauftrag();
		}

		void xcmdShowMaschinenauftrag_Click(object sender, EventArgs e)
		{
			this.ShowMaschinenauftrag();
		}

		void xcmdShowCustomer_Click(object sender, EventArgs e)
		{
			this.ShowCustomer();
		}

		void xcmdShowMachine_Click(object sender, EventArgs e)
		{
			this.ShowMachine();
		}

		void mbtnNew_Click(object sender, EventArgs e)
		{
			Kunde kunde = null;
			// Kunden auswählen lassen
			var csv = new CustomerSearchView("Auftragskunden auswählen", false);
			csv.ShowDialog(this);
			if (csv.DialogResult == System.Windows.Forms.DialogResult.OK && csv.SelectedCustomer != null)
			{
				kunde = Model.ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, false);
			}

			// Maschinenmodell auswählen lassen
			Maschinenmodell modell = null;
			var mlv = new ModellListView();
			mlv.ShowDialog(this);
			if (mlv.DialogResult != System.Windows.Forms.DialogResult.OK && mlv.SelectedMaschinenmodell != null)
			{
				modell = mlv.SelectedMaschinenmodell;
			}

			if (kunde == null || modell == null) return;
			var newAuftrag = Model.ModelManager.MachineService.AddMaschinenauftrag(kunde, modell);
			var mav = new MaschinenauftragView(newAuftrag);
			mav.ShowDialog(this);
		}

		void xcmdOpenInExplorer_Click(object sender, EventArgs e)
		{
			var path = this.SelectedMaschinenauftrag.Maschine.Dateipfad;
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			Process.Start("Explorer.exe", path);
		}

		void mlnkSchrift_Click(object sender, EventArgs e)
		{
			int currentSize = (int)this.mtxtAnmerkungenBestellung.FontSize;
			var newSize = currentSize + 1;
			if (newSize == 3) newSize = 0;
			this.mtxtAnmerkungenBestellung.FontSize = (MetroFramework.MetroTextBoxSize)newSize;
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.dgvMaschinenauftraege.AutoGenerateColumns = false;
			this.dgvMaschinenauftraege.DataSource = this.myDatasource;
		}

		void ShowMaschinenauftrag()
		{
			if (this.SelectedMaschinenauftrag == null) return;
			var mav = new MaschinenauftragView(this.SelectedMaschinenauftrag);
			mav.Show();
		}

		void ShowCustomer()
		{
			if (this.SelectedMaschinenauftrag == null || this.SelectedMaschinenauftrag.Auftragskunde == null) return;
			var kmv = new KundeMainView(this.SelectedMaschinenauftrag.Auftragskunde);
			kmv.Show();
		}

		void ShowMachine()
		{
			if (this.SelectedMaschinenauftrag == null || this.SelectedMaschinenauftrag.Maschine == null) return;
			var kmv = new KundeMainView(this.SelectedMaschinenauftrag.Auftragskunde, this.SelectedMaschinenauftrag.Maschine);
			kmv.Show();
		}

		#endregion PRIVATE PROCEDURES
	}
}