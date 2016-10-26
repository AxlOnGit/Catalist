using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Common.Views;
using Products.Data;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlArtikelpreise : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		Product mySelectedProduct;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der pnlArtikelpreise Klasse.
		/// </summary>
		/// <param name="parentCtrl"></param>
		/// <param name="kunde"></param>
		/// <param name="keepLoaded"></param>
		public pnlArtikelpreise(ContainerControl parentCtrl, Kunde kunde, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;

			this.dgvProducts.AutoGenerateColumns = false;
			var dataSource = ModelManager.ProductService.GetProductList(kunde);
			var filter = "KatalogFlag == true";
			dataSource.Filter = filter;

			this.dgvProducts.DataSource = dataSource;
			this.mtxtFilter.Focus();
		}

		#endregion ### .ctor ###

		#region event handler

		void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.mySelectedProduct = this.dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
		}

		void dgvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ShowDetailsView();
		}

		void mbtnArtikeldetails_Click(object sender, EventArgs e)
		{
			ShowDetailsView();
		}

		void cmnuDetails_Click(object sender, EventArgs e)
		{
			ShowDetailsView();
		}

		void mbtnLagerbestand_Click(object sender, EventArgs e)
		{
			ShowInventoryView();
		}

		void cmnuInventory_Click(object sender, EventArgs e)
		{
			ShowInventoryView();
		}

		void mbtnKalkulation_Click(object sender, EventArgs e)
		{
			ShowCalcView();
		}

		void cmnuCalc_Click(object sender, EventArgs e)
		{
			ShowCalcView();
		}

		void pnlArtikelpreise_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && (e.KeyCode == Keys.Home))
			{
				myParent.ShowStartPanel();
			}
		}

		void cmnuSpecialPrice_Click(object sender, EventArgs e)
		{
			this.ShowSonderpreisView();
		}

		void xcmdLieferantenRabatt_Click(object sender, EventArgs e)
		{
			var llv = new LieferantenListView();
			if (llv.ShowDialog(this) == DialogResult.OK)
			{
				var supplierPK = llv.SelectedLieferant.Lieferantennummer;
				if (this.mySelectedProduct != null)
				{
					var rabatt = ModelManager.SupplierService.GetOrCreateRabattStaffel(this.mySelectedProduct.Artikelnummer, supplierPK);
					var lsv = new LieferantenStaffelpreisView(rabatt);
					lsv.ShowDialog();
				}
			}
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = mtxtFilter.Text.Split();

			if (keyWords.Length > 0)
			{
				foreach (string word in keyWords)
				{
					if (outputInfo.Length == 0)
					{
						outputInfo = string.Format(@"KatalogFlag == true AND (Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1)", word.ToLower());
					}
					else
					{
						outputInfo += string.Format(@" AND ((Bezeichnung1.ToLower().IndexOf(""{0}"") > -1 OR Matchcode.ToLower().IndexOf(""{0}"") > -1 OR Artikelnummer.ToLower().IndexOf(""{0}"") > -1))", word.ToLower());
					}
					(this.dgvProducts.DataSource as SBList<Product>).Filter = outputInfo;
				}
			}
			else
			{
				(this.dgvProducts.DataSource as SBList<Product>).Filter = "KatalogFlag == true";
			}
		}

		void mtxtFilter_ClearClicked()
		{
			(this.dgvProducts.DataSource as SBList<Product>).Filter = "KatalogFlag == true";
		}

		#endregion event handler

		#region private procedures

		void ShowCalcView()
		{
			if (this.mySelectedProduct != null)
			{
				string productName = string.Empty;
				string productGroup = string.Empty;
				decimal ek = 0m;
				decimal price = 0m;
				decimal salesPerPeriod = 0m;
				decimal salesTotal = 0m;
				decimal openAmount = 0m;
				decimal normalPrice = 0m;

				ek = this.mySelectedProduct.Einkaufspreis;
				price = this.mySelectedProduct.Kundenpreis;
				normalPrice = this.mySelectedProduct.Einkaufspreis;

				// get customer sales stats and outstanding amounts
				var statsRow = DataManager.AllDataService.GetVerkaufsstatistik(this.myKunde.CustomerId);
				openAmount = ModelManager.SalesService.GetOffenePostenTotal(this.myKunde);

				if (statsRow != null)
				{
					if (!statsRow.IsUmsatzPeriodeNull())
					{
						salesPerPeriod = statsRow.UmsatzPeriode;
					}
					if (!statsRow.IsUmsatzKumuliertNull())
					{
						salesTotal = statsRow.UmsatzKumuliert;
					}
				}

				if (mySelectedProduct.Mengeneinheit == "m²" || mySelectedProduct.Mengeneinheit == "lfm" || this.mySelectedProduct.Mengeneinheit == "lfdm")
				{
					var crv = new CalcRollView(
						this.mySelectedProduct,
						this.myKunde,
						ek,
						price,
						normalPrice,
						salesPerPeriod,
						salesTotal,
						openAmount);
					crv.ShowDialog(this);
				}
				else
				{
					var cv = new CalcItemView(
						this.mySelectedProduct,
						this.myKunde,
						ek,
						price,
						normalPrice,
						salesPerPeriod,
						salesTotal,
						openAmount);
					cv.ShowDialog(this);
				}
			}
		}

		void ShowDetailsView()
		{
			if (this.mySelectedProduct != null)
			{
				myParent.LoadOrShowArtikeldetail(mySelectedProduct);
			}
		}

		void ShowInventoryView()
		{
			if (this.mySelectedProduct != null)
			{
				var piv = new LagerbestandView(this.myKunde, this.mySelectedProduct);
				piv.ShowDialog();
			}
		}

		void ShowSonderpreisView()
		{
			if (this.mySelectedProduct != null)
			{
				var spv = new SonderpreisView(this.mySelectedProduct);
				if (spv.ShowDialog(this) == DialogResult.OK)
				{
					ModelManager.ProductService.UpdateProducts(this.myKunde);
					MetroMessageBox.Show(this, "Der neue Sonderpreis wurde gespeichert.", "Da sacht der Catalist", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		#endregion private procedures

		// static int counter = 1;

		void mbtnExport_Click(object sender, EventArgs e)
		{
			var pedv = new ProductExportDetailsView(this.myKunde, (IEnumerable<Product>)this.dgvProducts.DataSource);
			pedv.ShowDialog();

			//var now = DateTime.Today;
			//var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			//var filename = $"{now.ToString("yyyy")}-{now.ToString("MM")}-{now.ToString("dd")} - Artikelpreise_{this.myKunde.Matchcode} ({counter}).xlsx";
			//var fullName = Path.Combine(documents, filename);
			//OfficeBridge.ServiceManager.ExcelService.ExportToWorkbook((IEnumerable<Product>)this.dgvProducts.DataSource, fullName, this.myKunde.Matchcode);
			//counter += 1;
			//MetroMessageBox.Show(this, "Alle Artikel exportiert ...");
		}
	}
}