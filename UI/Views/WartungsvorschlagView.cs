using MetroFramework;
using MetroFramework.Forms;
using Products.Common.Geocoding;
using Products.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Device.Location;
using System.Linq;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class WartungsvorschlagView : MetroForm
    {
        #region MEMBERS

        Kunde ReferenzKunde { get; set; }

        int VorschlagAelterAls { get; set; } = 12;

        int MaxEntfernung { get; set; } = 40;

        #endregion MEMBERS

        #region ### .ctor ###

        public WartungsvorschlagView(Kunde referenzKunde)
        {
            InitializeComponent();
            this.ReferenzKunde = referenzKunde;
            this.DgvMachines.AutoGenerateColumns = false;
            this.SetGridData();
        }

        #endregion ### .ctor ###

        #region EVENT HANDLER

        void MtxtVorschlagAelterAls_Validated(object sender, EventArgs e)
        {
            int entry = 0;
            if (int.TryParse(this.MTxtVorschlagAelterAls.Text, out entry))
            {
                this.VorschlagAelterAls = entry;
                this.SetGridData();
            }
            else MetroMessageBox.Show(this, $"'{this.MTxtVorschlagAelterAls.Text}' ist kein gültiger Wert. Hier funktionieren nur ganze Zahlen.");
        }

        void MtxtMaxEntfernung_Validated(object sender, EventArgs e)
        {
            int entry = 0;
            if (int.TryParse(this.MTxtMaxEntfernung.Text, out entry))
            {
                this.MaxEntfernung = entry;
                this.SetGridData();
            }
            else MetroMessageBox.Show(this, $"'{this.MTxtVorschlagAelterAls.Text}' ist kein gültiger Wert. Hier funktionieren nur ganze Zahlen.");
        }

        void XcmdShowPoisImage_Click(object sender, EventArgs e)
        {
            var coords = new Dictionary<string, GeoCoordinate>();
            coords.Add("X", this.ReferenzKunde.Adresskoordinaten);
            var counter = 65;
            foreach (DataGridViewRow item in this.DgvMachines.SelectedRows)
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

        void CtxGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.XCmdShowPoisImage.Enabled = this.DgvMachines.SelectedRows.Count > 1;
        }

        #endregion EVENT HANDLER

        #region METHODS

        void SetGridData()
        {
            var rawList = Model.ModelManager.AppointmentService.GetWartungsliste(this.ReferenzKunde)
                .Where(w => w.NextServiceDueAt() <= DateTime.Today.AddMonths(1) & w.NextServiceDueAt() >= DateTime.Today.AddMonths(-this.VorschlagAelterAls) & w.Entfernung <= this.MaxEntfernung);
            foreach (var item in rawList)
            {
                item.SetReferenzKunde(this.ReferenzKunde);
            }
            var list = new SortableBindingList<Wartungstermin>(rawList);
            this.DgvMachines.DataSource = list;
        }

        #endregion METHODS
    }
}
