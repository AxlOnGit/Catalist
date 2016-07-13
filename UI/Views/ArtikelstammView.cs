using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class ArtikelstammView : MetroForm
	{

		#region members

		Kunde myKunde;
		Product mySelectedProduct;
		SBList<Product> myDatasource;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der ArtikelstammView Klasse.
		/// </summary>
		public ArtikelstammView(Kunde kunde = null)
		{
			InitializeComponent();
			if (kunde == null)
			{
				myKunde = ModelManager.CustomerService.GetKunde("1000000000", false);
			}
			else myKunde = kunde;
			this.myDatasource = ModelManager.ProductService.GetProductList(myKunde);
			this.mtxtFilter.KeyUp += this.mtxtFilter_KeyUp; 
			this.dgvArtikel.AutoGenerateColumns = false;

			this.InitializeData();
			this.Location.Offset(1, 1);
			this.Location.Offset(-1, -1);
		}

		#endregion

		#region event handler

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			if (string.IsNullOrEmpty(this.mtxtFilter.Text))
			{
				this.myDatasource.Filter = "";
				return;
			}

			var outputInfo = string.Empty;
			var keyWords = this.mtxtFilter.Text.Split();
			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = string.Format(@"(Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1)", word.ToLower());
				}
				else
				{
					outputInfo += string.Format(@" AND ((Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1))", word.ToLower());
				}
				this.myDatasource.Filter = outputInfo;
				// this.mtxtFilter.ShowButton = !string.IsNullOrEmpty(outputInfo);
			}
		}

		void mtxtFilter_ClearClicked()
		{
			this.myDatasource.Filter = "";
			this.mtxtFilter.ShowButton = false;
		}

		void btnChangeKunde_Click(object sender, EventArgs e)
		{
			var csv = new CustomerSearchView("Für welchen Kunden soll der Artikelstamm angezeigt werden?", true);
			if (csv.ShowDialog() == DialogResult.OK)
			{
				this.myKunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer, false);
				if (myKunde != null) this.InitializeData();
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			this.Text = string.Format("Artikelstamm für {0}{1}", myKunde.CompanyName1.Replace("&", "&&"), Environment.NewLine);
			dgvArtikel.DataSource = this.myDatasource;
		}

		#endregion

		void mcmdAuftraege_Click(object sender, EventArgs e)
		{
			if (this.mySelectedProduct != null)
			{
				var apav = new AuftraegeProArtikelView(this.mySelectedProduct.Artikelnummer);
				apav.ShowDialog();
			}
		}

		void dgvArtikel_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedProduct = this.dgvArtikel.Rows[e.RowIndex].DataBoundItem as Product;
		}

		void dgvArtikel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.dgvArtikel.ClearSelection();
		}

		void xcmdShowInventoryView_Click(object sender, EventArgs e)
		{
			if (this.mySelectedProduct != null)
			{
				var piv = new LagerbestandView(this.myKunde, this.mySelectedProduct);
				piv.ShowDialog();
			}
		}

	}
}
