using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class LieferantenStaffelpreisView : MetroForm
	{

		#region members

		readonly LieferantenRabatt myRabatt;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der LieferantenStaffepreisView Klasse.
		/// </summary>
		public LieferantenStaffelpreisView(LieferantenRabatt rabattStaffel)
		{
			InitializeComponent();
			this.myRabatt = rabattStaffel;

			this.InitializeData();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			if (myRabatt == null) return;
			this.mlblArtikel.Text = this.myRabatt.Artikelnummer;

			this.mtxtMenge1.DataBindings.Add("Text", myRabatt, "Menge1");
			this.mtxtMenge2.DataBindings.Add("Text", myRabatt, "Menge2");
			this.mtxtMenge3.DataBindings.Add("Text", myRabatt, "Menge3");
			this.mtxtMenge4.DataBindings.Add("Text", myRabatt, "Menge4");

			this.mtxtPreis1.DataBindings.Add("Text", myRabatt, "Preis1");
			this.mtxtPreis2.DataBindings.Add("Text", myRabatt, "Preis2");
			this.mtxtPreis3.DataBindings.Add("Text", myRabatt, "Preis3");
			this.mtxtPreis4.DataBindings.Add("Text", myRabatt, "Preis4");

			this.mtxtRabatt1.DataBindings.Add("Text", myRabatt, "Rabatt1");
			this.mtxtRabatt2.DataBindings.Add("Text", myRabatt, "Rabatt2");
			this.mtxtRabatt3.DataBindings.Add("Text", myRabatt, "Rabatt3");
			this.mtxtRabatt4.DataBindings.Add("Text", myRabatt, "Rabatt4");
		}

		#endregion

	}
}
