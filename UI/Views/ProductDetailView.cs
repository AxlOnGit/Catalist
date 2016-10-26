using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class ProductDetailView : MetroForm
	{
		#region members

		readonly Product myProduct;
		readonly Kunde myKunde;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the ProductDetailView class.
		/// </summary>
		public ProductDetailView(Kunde kunde)
		{
			InitializeComponent();
			this.myKunde = kunde;
		}

		/// <summary>
		/// Creates a new instance of the ProductDetailView class.
		/// </summary>
		/// <param name="product">A dsSage.CustomizedPriceRow instance.</param>
		public ProductDetailView(Kunde kunde, Product product) : this(kunde)
		{
			this.myProduct = product;
			this.Text = string.Format("{0} [{1}]", product.Bezeichnung2, product.Artikelnummer);
			this.InitBindings();
		}

		#endregion ### .ctor ###

		#region event handler

		void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		void btnMinimize_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void ProductDetailView_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModelManager.ProductService.UpdateProducts(this.myKunde);
		}

		void xmnuChoosePreset_Click(object sender, EventArgs e)
		{
			ProductDetailView.ChoosePreset(this);
		}

		void mbtnPresetWahl_Click(object sender, EventArgs e)
		{
			ProductDetailView.ChoosePreset(this);
		}

		void lnkChoosePreset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.xmnuChoosePreset_Click(this, new EventArgs());
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

		void ctxForm_Opening(object sender, CancelEventArgs e)
		{
			if (ModelManager.ProductService.CurrentProduct == null)
			{
				this.xmnuPasteProperties.Enabled = false;
				return;
			}
			this.xmnuPasteProperties.Enabled = true;
		}

		void mbtnFilterA_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "A.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.A));
		}

		void mbtnFilterB_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "B.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.B));
		}

		void mbtnFilterC_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "C.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.C));
		}

		void mbnFilterD_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "D.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.D));
		}

		void mbtnFilterE_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "E.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.E));
		}

		void mbtnFilterF_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "F.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.F));
		}

		void mbtnFilterG_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "G.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.G));
		}

		void mbtnFilterH_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "H.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.H));
		}

		void mbtnFilterI_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = "I.";
			this.mtxtFilter_KeyUp(this.txtFilter, new KeyEventArgs(Keys.I));
		}

		void mtxtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = this.txtFilter.Text.Split();

			foreach (var word in keyWords)
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
				this.txtFilter.Text = string.Empty;
			}
		}

		void mbtnFilterClear_Click(object sender, EventArgs e)
		{
			this.txtFilter.Text = string.Empty;
			(this.cmbCategory.DataSource as DataView).RowFilter = string.Empty;
		}

		#endregion event handler

		#region private procedures

		void InitBindings()
		{
			if (this.myProduct != null)
			{
				DataView dvCatalog = DataManager.CatalogDataService.GetCatalogTable().DefaultView;
				dvCatalog.RowFilter = string.Empty;
				this.cmbCategory.DataSource = dvCatalog;
				this.cmbCategory.DisplayMember = "SectionName";
				this.cmbCategory.ValueMember = "Numbering";
				this.cmbCategory.DataBindings.Add("SelectedValue", this.myProduct, "Katalogsektion");

				this.txtDescription.DataBindings.Add("Text", this.myProduct, "Beschreibung");
				this.lblME.DataBindings.Add("Text", this.myProduct, "Mengeneinheit");

				var bind = this.lblPreisProME.DataBindings.Add("Text", this.myProduct, "Kundenpreis");
				bind.Format += bind_Format;

				var bndProp1 = txtProperty1.DataBindings.Add("Text", this.myProduct, "Eigenschaft1");
				bndProp1.NullValue = string.Empty;
				var bndVal1 = txtValue1.DataBindings.Add("Text", this.myProduct, "Wert1");
				bndVal1.NullValue = string.Empty;

				var bndProp2 = txtProperty2.DataBindings.Add("Text", this.myProduct, "Eigenschaft2");
				bndProp2.NullValue = string.Empty;
				var bndVal2 = txtValue2.DataBindings.Add("Text", this.myProduct, "Wert2");
				bndVal2.NullValue = string.Empty;

				var bndProp3 = txtProperty3.DataBindings.Add("Text", this.myProduct, "Eigenschaft3");
				bndProp3.NullValue = string.Empty;
				var bndVal3 = txtValue3.DataBindings.Add("Text", this.myProduct, "Wert3");
				bndVal3.NullValue = string.Empty;

				var bndProp4 = txtProperty4.DataBindings.Add("Text", this.myProduct, "Eigenschaft4");
				bndProp4.NullValue = string.Empty;
				var bndVal4 = txtValue4.DataBindings.Add("Text", this.myProduct, "Wert4");
				bndVal4.NullValue = string.Empty;

				var bndProp5 = txtProperty5.DataBindings.Add("Text", this.myProduct, "Eigenschaft5");
				bndProp5.NullValue = string.Empty;
				var bndVal5 = txtValue5.DataBindings.Add("Text", this.myProduct, "Wert5");
				bndVal5.NullValue = string.Empty;

				var bndProp6 = txtProperty6.DataBindings.Add("Text", this.myProduct, "Eigenschaft6");
				bndProp6.NullValue = string.Empty;
				var bndVal6 = txtValue6.DataBindings.Add("Text", this.myProduct, "Wert6");
				bndVal6.NullValue = string.Empty;

				var bndProp7 = txtProperty7.DataBindings.Add("Text", this.myProduct, "Eigenschaft7");
				bndProp7.NullValue = string.Empty;
				var bndVal7 = txtValue7.DataBindings.Add("Text", this.myProduct, "Wert7");
				bndVal7.NullValue = string.Empty;

				var bndProp8 = txtProperty8.DataBindings.Add("Text", this.myProduct, "Eigenschaft8");
				bndProp8.NullValue = string.Empty;
				var bndVal8 = txtValue8.DataBindings.Add("Text", this.myProduct, "Wert8");
				bndVal8.NullValue = string.Empty;

				var bndProp9 = txtProperty9.DataBindings.Add("Text", this.myProduct, "Eigenschaft9");
				bndProp9.NullValue = string.Empty;
				var bndVal9 = txtValue9.DataBindings.Add("Text", this.myProduct, "Wert9");
				bndVal9.NullValue = string.Empty;

				var bndProp10 = txtProperty10.DataBindings.Add("Text", this.myProduct, "Eigenschaft10");
				bndProp10.NullValue = string.Empty;
				var bndVal10 = txtValue10.DataBindings.Add("Text", this.myProduct, "Wert10");
				bndVal10.NullValue = string.Empty;

				var bndProp11 = txtProperty11.DataBindings.Add("Text", this.myProduct, "Eigenschaft11");
				bndProp11.NullValue = string.Empty;
				var bndVal11 = txtValue11.DataBindings.Add("Text", this.myProduct, "Wert11");
				bndVal11.NullValue = string.Empty;

				var bndProp12 = txtProperty12.DataBindings.Add("Text", this.myProduct, "Eigenschaft12");
				bndProp12.NullValue = string.Empty;
				var bndVal12 = txtValue12.DataBindings.Add("Text", this.myProduct, "Wert12");
				bndVal12.NullValue = string.Empty;

				var bndProp13 = txtProperty13.DataBindings.Add("Text", this.myProduct, "Eigenschaft13");
				bndProp13.NullValue = string.Empty;
				var bndVal13 = txtValue13.DataBindings.Add("Text", this.myProduct, "Wert13");
				bndVal13.NullValue = string.Empty;

				var bndProp14 = txtProperty14.DataBindings.Add("Text", this.myProduct, "Eigenschaft14");
				bndProp14.NullValue = string.Empty;
				var bndVal14 = txtValue14.DataBindings.Add("Text", this.myProduct, "Wert14");
				bndVal14.NullValue = string.Empty;

				var bndManufacturerLogo = this.txtManufacturerLogo.DataBindings.Add("Text", this.myProduct, "HerstellerlogoPfad");
				bndManufacturerLogo.NullValue = string.Empty;

				var bndProductLogo = this.txtProductLogo.DataBindings.Add("Text", this.myProduct, "ProduktlogoPfad");
				bndProductLogo.NullValue = string.Empty;

				var bndProductPicture = this.txtProductPicture.DataBindings.Add("Text", this.myProduct, "ProduktbildPfad");
				bndProductPicture.NullValue = string.Empty;

				var bndCheckedFlag = this.mchkChecked.DataBindings.Add("Checked", this.myProduct, "CheckedFlag");
			}
		}

		static void ChoosePreset(ProductDetailView instance)
		{
			var spv = new SelectPresetView();
			if (spv.ShowDialog() == DialogResult.OK)
			{
				string msg = "Wenn Du jetzt auf Ok klickst, werden die bereits vorhandenen Namen der Eigenschaften (linke Spalte) überschrieben!";
				if (MetroMessageBox.Show(instance, msg, "Catalist - Preset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					dsShared.PresetRow preset = spv.SelectedPreset;

					if (!preset.IsProperty1Null())
					{
						instance.myProduct.Eigenschaft1 = preset.Property1;
						instance.txtProperty1.Text = preset.Property1;
					}
					if (!preset.IsProperty2Null())
					{
						instance.myProduct.Eigenschaft2 = preset.Property2;
						instance.txtProperty2.Text = preset.Property2;
					}
					if (!preset.IsProperty3Null())
					{
						instance.myProduct.Eigenschaft3 = preset.Property3;
						instance.txtProperty3.Text = preset.Property3;
					}
					if (!preset.IsProperty4Null())
					{
						instance.myProduct.Eigenschaft4 = preset.Property4;
						instance.txtProperty4.Text = preset.Property4;
					}
					if (!preset.IsProperty5Null())
					{
						instance.myProduct.Eigenschaft5 = preset.Property5;
						instance.txtProperty5.Text = preset.Property5;
					}
					if (!preset.IsProperty6Null())
					{
						instance.myProduct.Eigenschaft6 = preset.Property6;
						instance.txtProperty6.Text = preset.Property6;
					}
					if (!preset.IsProperty7Null())
					{
						instance.myProduct.Eigenschaft7 = preset.Property7;
						instance.txtProperty7.Text = preset.Property7;
					}
					if (!preset.IsProperty8Null())
					{
						instance.myProduct.Eigenschaft8 = preset.Property8;
						instance.txtProperty8.Text = preset.Property8;
					}
					if (!preset.IsProperty9Null())
					{
						instance.myProduct.Eigenschaft9 = preset.Property9;
						instance.txtProperty9.Text = preset.Property9;
					}
					if (!preset.IsProperty10Null())
					{
						instance.myProduct.Eigenschaft10 = preset.Property10;
						instance.txtProperty10.Text = preset.Property10;
					}
					if (!preset.IsProperty11Null())
					{
						instance.myProduct.Eigenschaft11 = preset.Property11;
						instance.txtProperty11.Text = preset.Property11;
					}
					if (!preset.IsProperty12Null())
					{
						instance.myProduct.Eigenschaft12 = preset.Property12;
						instance.txtProperty12.Text = preset.Property12;
					}
					if (!preset.IsProperty13Null())
					{
						instance.myProduct.Eigenschaft13 = preset.Property13;
						instance.txtProperty13.Text = preset.Property13;
					}
					if (!preset.IsProperty14Null())
					{
						instance.myProduct.Eigenschaft14 = preset.Property14;
						instance.txtProperty14.Text = preset.Property14;
					}
				}
				else
				{
					string msg1 = "Sollen alle vorhandenen Bezeichnungen der Eigenschaften gelöscht werden?";
					if (MetroMessageBox.Show(instance, msg1, "Catalist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						instance.txtProperty1.Text = string.Empty;
						instance.txtProperty2.Text = string.Empty;
						instance.txtProperty3.Text = string.Empty;
						instance.txtProperty4.Text = string.Empty;
						instance.txtProperty5.Text = string.Empty;
						instance.txtProperty6.Text = string.Empty;
						instance.txtProperty7.Text = string.Empty;
						instance.txtProperty8.Text = string.Empty;
						instance.txtProperty9.Text = string.Empty;
						instance.txtProperty10.Text = string.Empty;
						instance.txtProperty11.Text = string.Empty;
						instance.txtProperty12.Text = string.Empty;
						instance.txtProperty13.Text = string.Empty;
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

		#endregion private procedures
	}
}