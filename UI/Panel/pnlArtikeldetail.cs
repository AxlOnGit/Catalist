using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using Products.Common.Views;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Panel
{
	public partial class pnlArtikeldetail : pnlSlider
	{
		#region members

		readonly KundeMainView myParent;
		readonly Kunde myKunde;
		readonly Product myProduct;

		#endregion members

		#region ### .ctor ###

		public pnlArtikeldetail(ContainerControl parentCtrl, Kunde kunde, Product product, bool keepLoaded) : base(parentCtrl, keepLoaded)
		{
			InitializeComponent();
			this.myParent = parentCtrl as KundeMainView;
			this.myKunde = kunde;
			this.myProduct = product;
			this.InitBindings();
			this.ctxForm.Opening += ctxForm_Opening;
			this.OnClosed += pnlArtikeldetail_OnClosed;
		}

		void pnlArtikeldetail_OnClosed(object sender, EventArgs e)
		{
			ModelManager.ProductService.UpdateProducts(this.myKunde);
		}

		#endregion ### .ctor ###

		#region event handler

		void ctxForm_Opening(object sender, CancelEventArgs e)
		{
			this.xmnuPasteProperties.Enabled = ModelManager.ProductService.CurrentProduct != null;
		}

		void mbtnPresetWahl_Click(object sender, EventArgs e)
		{
			ChoosePreset();
		}

		void xmnuChoosePreset_Click(object sender, EventArgs e)
		{
			ChoosePreset();
		}

		void xmnuCopyProperties_Click(object sender, EventArgs e)
		{
			ModelManager.ProductService.CurrentProduct = this.myProduct;
		}

		void xmnuPasteProperties_Click(object sender, EventArgs e)
		{
			var product = ModelManager.ProductService.CurrentProduct;
			if (!string.IsNullOrEmpty(product.Beschreibung))
			{
				this.myProduct.Beschreibung = product.Beschreibung;
				this.txtDescription.Text = product.Beschreibung;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft1) && !string.IsNullOrEmpty(product.Wert1))
			{
				this.myProduct.Eigenschaft1 = product.Eigenschaft1;
				this.txtProperty1.Text = product.Eigenschaft1;
				this.myProduct.Wert1 = product.Wert1;
				this.txtValue1.Text = product.Wert1;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft2) && !string.IsNullOrEmpty(product.Wert2))
			{
				this.myProduct.Eigenschaft2 = product.Eigenschaft2;
				this.txtProperty2.Text = product.Eigenschaft2;
				this.myProduct.Wert2 = product.Wert2;
				this.txtValue2.Text = product.Wert2;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft3) && !string.IsNullOrEmpty(product.Wert3))
			{
				this.myProduct.Eigenschaft3 = product.Eigenschaft3;
				this.txtProperty3.Text = product.Eigenschaft3;
				this.myProduct.Wert3 = product.Wert3;
				this.txtValue3.Text = product.Wert3;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft4) && !string.IsNullOrEmpty(product.Wert4))
			{
				this.myProduct.Eigenschaft4 = product.Eigenschaft4;
				this.txtProperty4.Text = product.Eigenschaft4;
				this.myProduct.Wert4 = product.Wert4;
				this.txtValue4.Text = product.Wert4;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft5) && !string.IsNullOrEmpty(product.Wert5))
			{
				this.myProduct.Eigenschaft5 = product.Eigenschaft5;
				this.txtProperty5.Text = product.Eigenschaft5;
				this.myProduct.Wert5 = product.Wert5;
				this.txtValue5.Text = product.Wert5;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft6) && !string.IsNullOrEmpty(product.Wert6))
			{
				this.myProduct.Eigenschaft6 = product.Eigenschaft6;
				this.txtProperty6.Text = product.Eigenschaft6;
				this.myProduct.Wert6 = product.Wert6;
				this.txtValue6.Text = product.Wert6;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft7) && !string.IsNullOrEmpty(product.Wert7))
			{
				this.myProduct.Eigenschaft7 = product.Eigenschaft7;
				this.txtProperty7.Text = product.Eigenschaft7;
				this.myProduct.Wert7 = product.Wert7;
				this.txtValue7.Text = product.Wert7;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft8) && !string.IsNullOrEmpty(product.Wert8))
			{
				this.myProduct.Eigenschaft8 = product.Eigenschaft8;
				this.txtProperty8.Text = product.Eigenschaft8;
				this.myProduct.Wert8 = product.Wert8;
				this.txtValue8.Text = product.Wert8;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft9) && !string.IsNullOrEmpty(product.Wert9))
			{
				this.myProduct.Eigenschaft9 = product.Eigenschaft9;
				this.txtProperty9.Text = product.Eigenschaft9;
				this.myProduct.Wert9 = product.Wert9;
				this.txtValue9.Text = product.Wert9;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft10) && !string.IsNullOrEmpty(product.Wert10))
			{
				this.myProduct.Eigenschaft10 = product.Eigenschaft10;
				this.txtProperty10.Text = product.Eigenschaft10;
				this.myProduct.Wert10 = product.Wert10;
				this.txtValue10.Text = product.Wert10;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft11) && !string.IsNullOrEmpty(product.Wert11))
			{
				this.myProduct.Eigenschaft11 = product.Eigenschaft11;
				this.txtProperty11.Text = product.Eigenschaft11;
				this.myProduct.Wert11 = product.Wert11;
				this.txtValue11.Text = product.Wert11;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft12) && !string.IsNullOrEmpty(product.Wert12))
			{
				this.myProduct.Eigenschaft12 = product.Eigenschaft12;
				this.txtProperty12.Text = product.Eigenschaft12;
				this.myProduct.Wert12 = product.Wert12;
				this.txtValue12.Text = product.Wert12;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft13) && !string.IsNullOrEmpty(product.Wert13))
			{
				this.myProduct.Eigenschaft13 = product.Eigenschaft13;
				this.txtProperty13.Text = product.Eigenschaft13;
				this.myProduct.Wert13 = product.Wert13;
				this.txtValue13.Text = product.Wert13;
			}

			if (!string.IsNullOrEmpty(product.Eigenschaft14) && !string.IsNullOrEmpty(product.Wert14))
			{
				this.myProduct.Eigenschaft14 = product.Eigenschaft14;
				this.txtProperty14.Text = product.Eigenschaft14;
				this.myProduct.Wert14 = product.Wert14;
				this.txtValue14.Text = product.Wert14;
			}
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = this.mtxtFilter.Text.Split();

			if (keyWords.Length > 0)
			{
				foreach (string word in keyWords)
				{
					if (outputInfo.Length == 0)
					{
						outputInfo = "(SectionName LIKE '%" + word + "%')";
					}
					else
					{
						outputInfo += " AND (SectionName LIKE '%" + word + "%')";
					}
				}
				(this.cmbCategory.DataSource as DataView).RowFilter = outputInfo;
				if (this.cmbCategory.Items.Count == 0)
				{
					(this.cmbCategory.DataSource as DataView).RowFilter = string.Empty;
					this.mtxtFilter.Text = string.Empty;
				}
			}
			else
			{
				(this.cmbCategory.DataSource as DataView).RowFilter = string.Empty;
				this.mtxtFilter.Text = string.Empty;
			}
		}

		void mbtnFilterA_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "A.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.A));
		}

		void mbtnFilterB_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "B.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.B));
		}

		void mbtnFilterC_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "C.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.C));
		}

		void mbnFilterD_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "D.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.D));
		}

		void mbtnFilterE_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "E.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.E));
		}

		void mbtnFilterF_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "F.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.F));
		}

		void mbtnFilterG_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "G.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.G));
		}

		void mbtnFilterH_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "H.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.H));
		}

		void mbtnFilterI_Click(object sender, EventArgs e)
		{
			this.mtxtFilter.Text = "I.";
			this.mtxtFilter_KeyUp(this.mtxtFilter, new KeyEventArgs(Keys.I));
		}

		void mtxtFilter_ClearClicked()
		{
			(this.cmbCategory.DataSource as DataView).RowFilter = string.Empty;
		}

		#endregion event handler

		#region procedures

		void InitBindings()
		{
			if (this.myProduct != null)
			{
				this.mlblTitel.Text = string.Format("{0}   [Art.-Nr: {1}]", myProduct.Bezeichnung2, myProduct.Artikelnummer);
				var dvCatalog = DataManager.CatalogDataService.GetCatalogTable().DefaultView;
				dvCatalog.RowFilter = string.Empty;
				this.cmbCategory.DataSource = dvCatalog;
				this.cmbCategory.DisplayMember = "SectionName";
				this.cmbCategory.ValueMember = "Numbering";
				this.cmbCategory.DataBindings.Add("SelectedValue", myProduct, "Katalogsektion");

				this.txtDescription.DataBindings.Add("Text", myProduct, "Beschreibung");
				this.lblME.DataBindings.Add("Text", myProduct, "Mengeneinheit");

				var binding = this.lblPreisProME.DataBindings.Add("Text", myProduct, "Kundenpreis");
				binding.Format += bind_Format;

				var bndProp1 = txtProperty1.DataBindings.Add("Text", myProduct, "Eigenschaft1");
				bndProp1.NullValue = string.Empty;
				var bndVal1 = txtValue1.DataBindings.Add("Text", myProduct, "Wert1");
				bndVal1.NullValue = string.Empty;

				var bndProp2 = txtProperty2.DataBindings.Add("Text", myProduct, "Eigenschaft2");
				bndProp1.NullValue = string.Empty;
				var bndVal2 = txtValue2.DataBindings.Add("Text", myProduct, "Wert2");
				bndVal1.NullValue = string.Empty;

				var bndProp3 = txtProperty3.DataBindings.Add("Text", myProduct, "Eigenschaft3");
				bndProp1.NullValue = string.Empty;
				var bndVal3 = txtValue3.DataBindings.Add("Text", myProduct, "Wert3");
				bndVal1.NullValue = string.Empty;

				var bndProp4 = txtProperty4.DataBindings.Add("Text", myProduct, "Eigenschaft4");
				bndProp1.NullValue = string.Empty;
				var bndVal4 = txtValue4.DataBindings.Add("Text", myProduct, "Wert4");
				bndVal1.NullValue = string.Empty;

				var bndProp5 = txtProperty5.DataBindings.Add("Text", myProduct, "Eigenschaft5");
				bndProp1.NullValue = string.Empty;
				var bndVal5 = txtValue5.DataBindings.Add("Text", myProduct, "Wert5");
				bndVal1.NullValue = string.Empty;

				var bndProp6 = txtProperty6.DataBindings.Add("Text", myProduct, "Eigenschaft6");
				bndProp1.NullValue = string.Empty;
				var bndVal6 = txtValue6.DataBindings.Add("Text", myProduct, "Wert6");
				bndVal1.NullValue = string.Empty;

				var bndProp7 = txtProperty7.DataBindings.Add("Text", myProduct, "Eigenschaft7");
				bndProp1.NullValue = string.Empty;
				var bndVal7 = txtValue7.DataBindings.Add("Text", myProduct, "Wert7");
				bndVal1.NullValue = string.Empty;

				var bndProp8 = txtProperty8.DataBindings.Add("Text", myProduct, "Eigenschaft8");
				bndProp1.NullValue = string.Empty;
				var bndVal8 = txtValue8.DataBindings.Add("Text", myProduct, "Wert8");
				bndVal1.NullValue = string.Empty;

				var bndProp9 = txtProperty9.DataBindings.Add("Text", myProduct, "Eigenschaft9");
				bndProp1.NullValue = string.Empty;
				var bndVal9 = txtValue9.DataBindings.Add("Text", myProduct, "Wert9");
				bndVal1.NullValue = string.Empty;

				var bndProp10 = txtProperty10.DataBindings.Add("Text", myProduct, "Eigenschaft10");
				bndProp1.NullValue = string.Empty;
				var bndVal10 = txtValue10.DataBindings.Add("Text", myProduct, "Wert10");
				bndVal1.NullValue = string.Empty;

				var bndProp11 = txtProperty11.DataBindings.Add("Text", myProduct, "Eigenschaft11");
				bndProp1.NullValue = string.Empty;
				var bndVal11 = txtValue11.DataBindings.Add("Text", myProduct, "Wert11");
				bndVal1.NullValue = string.Empty;

				var bndProp12 = txtProperty12.DataBindings.Add("Text", myProduct, "Eigenschaft12");
				bndProp1.NullValue = string.Empty;
				var bndVal12 = txtValue12.DataBindings.Add("Text", myProduct, "Wert12");
				bndVal1.NullValue = string.Empty;

				var bndProp13 = txtProperty13.DataBindings.Add("Text", myProduct, "Eigenschaft13");
				bndProp1.NullValue = string.Empty;
				var bndVal13 = txtValue13.DataBindings.Add("Text", myProduct, "Wert13");
				bndVal1.NullValue = string.Empty;

				var bndProp14 = txtProperty14.DataBindings.Add("Text", myProduct, "Eigenschaft14");
				bndProp1.NullValue = string.Empty;
				var bndVal14 = txtValue14.DataBindings.Add("Text", myProduct, "Wert14");
				bndVal1.NullValue = string.Empty;

				var bndManufacturerLogo = this.txtManufacturerLogo.DataBindings.Add("Text", myProduct, "HerstellerlogoPfad");
				bndManufacturerLogo.NullValue = string.Empty;

				var bndProductLogo = this.txtProductLogo.DataBindings.Add("Text", myProduct, "ProduktlogoPfad");
				bndProductLogo.NullValue = string.Empty;

				var bndProductPicture = this.txtProductPicture.DataBindings.Add("Text", myProduct, "ProduktbildPfad");
				bndProductPicture.NullValue = string.Empty;

				var bndCheckedFlag = this.mchkChecked.DataBindings.Add("Checked", myProduct, "CheckedFlag");

				if (this.myProduct.Herstellerlogo != null) this.picManufacturer.Image = this.myProduct.Herstellerlogo;
			}
		}

		void ChoosePreset()
		{
			var spv = new SelectPresetView();
			if (spv.ShowDialog() == DialogResult.OK)
			{
				var msg = "Wenn Du jetzt auf Ok klickst, werden die bereits vorhandenen Namen der Eigenschaften (linke Spalte) überschrieben!";
				if (MetroMessageBox.Show(this, msg, "Catalist - Preset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					var preset = spv.SelectedPreset;

					if (!preset.IsProperty1Null())
					{
						this.myProduct.Eigenschaft1 = preset.Property1;
						this.txtProperty1.Text = preset.Property1;
					}
					if (!preset.IsProperty2Null())
					{
						this.myProduct.Eigenschaft2 = preset.Property2;
						this.txtProperty2.Text = preset.Property2;
					}
					if (!preset.IsProperty3Null())
					{
						this.myProduct.Eigenschaft3 = preset.Property3;
						this.txtProperty3.Text = preset.Property3;
					}
					if (!preset.IsProperty4Null())
					{
						this.myProduct.Eigenschaft4 = preset.Property4;
						this.txtProperty4.Text = preset.Property4;
					}
					if (!preset.IsProperty5Null())
					{
						this.myProduct.Eigenschaft5 = preset.Property5;
						this.txtProperty5.Text = preset.Property5;
					}
					if (!preset.IsProperty6Null())
					{
						this.myProduct.Eigenschaft6 = preset.Property6;
						this.txtProperty6.Text = preset.Property6;
					}
					if (!preset.IsProperty7Null())
					{
						this.myProduct.Eigenschaft7 = preset.Property7;
						this.txtProperty7.Text = preset.Property7;
					}
					if (!preset.IsProperty8Null())
					{
						this.myProduct.Eigenschaft8 = preset.Property8;
						this.txtProperty8.Text = preset.Property8;
					}
					if (!preset.IsProperty9Null())
					{
						this.myProduct.Eigenschaft9 = preset.Property9;
						this.txtProperty9.Text = preset.Property9;
					}
					if (!preset.IsProperty10Null())
					{
						this.myProduct.Eigenschaft10 = preset.Property10;
						this.txtProperty10.Text = preset.Property10;
					}
					if (!preset.IsProperty11Null())
					{
						this.myProduct.Eigenschaft11 = preset.Property11;
						this.txtProperty11.Text = preset.Property11;
					}
					if (!preset.IsProperty12Null())
					{
						this.myProduct.Eigenschaft12 = preset.Property12;
						this.txtProperty12.Text = preset.Property12;
					}
					if (!preset.IsProperty13Null())
					{
						this.myProduct.Eigenschaft13 = preset.Property13;
						this.txtProperty13.Text = preset.Property13;
					}
					if (!preset.IsProperty14Null())
					{
						this.myProduct.Eigenschaft14 = preset.Property14;
						this.txtProperty14.Text = preset.Property14;
					}
				}
				else
				{
					string msg1 = "Sollen alle vorhandenen Bezeichnungen der Eigenschaften gelöscht werden?";
					if (MetroMessageBox.Show(this, msg1, "Catalist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						this.txtProperty1.Text = string.Empty;
						this.txtProperty2.Text = string.Empty;
						this.txtProperty3.Text = string.Empty;
						this.txtProperty4.Text = string.Empty;
						this.txtProperty5.Text = string.Empty;
						this.txtProperty6.Text = string.Empty;
						this.txtProperty7.Text = string.Empty;
						this.txtProperty8.Text = string.Empty;
						this.txtProperty9.Text = string.Empty;
						this.txtProperty10.Text = string.Empty;
						this.txtProperty11.Text = string.Empty;
						this.txtProperty12.Text = string.Empty;
						this.txtProperty13.Text = string.Empty;
					}
				}
			}
		}

		void bind_Format(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(string))
			{
				e.Value = string.Format("{0:C2}", e.Value);
			}
		}

		#endregion procedures
	}
}