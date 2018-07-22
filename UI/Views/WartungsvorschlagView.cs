using System;
using System.Collections.Generic;
using System.Data;
using System.Device.Location;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Common.Geocoding;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class WartungsvorschlagView : MetroForm
	{
		#region MEMBERS

		Kunde myReferenzKunde;
		int myVorschlagAelterAls = 12;
		int myMaxEntfernung = 40;

		#endregion MEMBERS

		#region ### .ctor ###

		public WartungsvorschlagView(Kunde referenzKunde)
		{
			InitializeComponent();
			this.myReferenzKunde = referenzKunde;
			this.dgvMachines.AutoGenerateColumns = false;
			this.SetGridData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		private void mtxtVorschlagAelterAls_Validated(object sender, EventArgs e)
		{
			int entry = 0;
			if (int.TryParse(this.mtxtVorschlagAelterAls.Text, out entry))
			{
				this.myVorschlagAelterAls = entry;
				this.SetGridData();
			}
			else MetroMessageBox.Show(this, $"'{this.mtxtVorschlagAelterAls.Text}' ist kein gültiger Wert. Hier funktionieren nur ganze Zahlen.");
		}

		private void mtxtMaxEntfernung_Validated(object sender, EventArgs e)
		{
			int entry = 0;
			if (int.TryParse(this.mtxtMaxEntfernung.Text, out entry))
			{
				this.myMaxEntfernung = entry;
				this.SetGridData();
			}
			else MetroMessageBox.Show(this, $"'{this.mtxtVorschlagAelterAls.Text}' ist kein gültiger Wert. Hier funktionieren nur ganze Zahlen.");
		}

		private void xcmdShowPoisImage_Click(object sender, EventArgs e)
		{
			var coords = new Dictionary<string, GeoCoordinate>();
			coords.Add("X", this.myReferenzKunde.Adresskoordinaten);
			var counter = 65;
			foreach (DataGridViewRow item in this.dgvMachines.SelectedRows)
			{
				var kunde = (item.DataBoundItem as Wartungstermin).Kunde;
				if (kunde != null)
				{
					coords.Add(char.ConvertFromUtf32(counter), kunde.Adresskoordinaten);
					counter++;
				}
			}
			if (coords.Count > 0)
			{
				var picture = GeoData.GetPoisImage(coords, 1200, 800);
				var tv = new TestView(picture);
				tv.Show();
			}
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.dgvMachines.AutoGenerateColumns = false;
		}

		void SetGridData()
		{
			var rawList = Model.ModelManager.AppointmentService.GetWartungsliste(this.myReferenzKunde)
				.Where(w => w.NextServiceDueAt() <= DateTime.Today.AddMonths(1) & w.NextServiceDueAt() >= DateTime.Today.AddMonths(-this.myVorschlagAelterAls) & w.Entfernung <= this.myMaxEntfernung);
			foreach (var item in rawList)
			{
				item.SetReferenzKunde(this.myReferenzKunde);
			}
			var list = new SortableBindingList<Wartungstermin>(rawList);
			this.dgvMachines.DataSource = list;
		}

		#endregion PRIVATE PROCEDURES

		private void ctxGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.xcmdShowPoisImage.Enabled = this.dgvMachines.SelectedRows.Count > 1;
		}
	}
}
