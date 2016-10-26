using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Product
	{
		#region members

		dsProducts.ProductRow myBase;
		dsProducts.ProductCpmRow myProductCpmBase;
		Kunde myKunde;
		bool myProductCpmDirty;
		bool mySonderpreiseDirty;
		string serverPicturePath = Common.Global.ManufacturerPicturePath;

		#endregion members

		#region public properties

		#region integrals

		public string Typ { get { return this.myBase.Typ; } }

		public string Kundennummer { get { return this.myKunde.CustomerId; } }

		/// <summary>
		/// Gibt die ArtikelID dieses Artikels in der Eidamo Tabelle tabArtikel zurück.
		/// </summary>
		public int ArtikelID { get { return ModelManager.ProductService.GetArtikelID(this.myBase.Artikel); } }

		public string Artikelnummer { get { return this.myBase.Artikel; } }

		public string Artikelgruppe { get { return this.myBase.Artikelgruppe; } }

		public string Lieferant { get { return this.myBase.FesterLieferant; } }

		public string Matchcode { get { return this.myBase.Matchcode; } }

		public string Hersteller { get { return this.myBase.Hersteller; } }

		public string Bezeichnung1 { get { return this.myBase.Bezeichnung1; } }

		public string Bezeichnung2 { get { return this.myBase.Bezeichnung2; } }

		public string Mengeneinheit { get { return this.myBase.Mengeneinheit; } }

		public decimal Einkaufspreis { get { return this.myBase.EK; } }

		public decimal Standardpreis { get { return this.myBase.Verkaufspreis1; } }

		public double Bestand { get { return this.myBase.Bestand; } }

		/// <summary>
		/// Gibt das Datum der letzten Bestellung für diesen Artikel zurück.
		/// </summary>
		public DateTime? LetzteBestellung
		{
			get
			{
				var result = ModelManager.SupplierService.GetDatumLetzteBestellung(this.Artikelnummer);
				if (result == DateTime.MinValue) return null;
				return result;
			}
		}

		/// <summary>
		/// Gibt das Datum der letzten Lieferung mit diesem Artikel zurück.
		/// </summary>
		public DateTime? LetzteLieferung
		{
			get
			{
				var result = ModelManager.SupplierService.GetDatumLetzteLieferung(this.Artikelnummer);
				if (result == DateTime.MinValue) return null;
				return result;
			}
		}

		/// <summary>
		/// Der gegebenenfalls rabattierte Kundenpreis.
		/// </summary>
		public decimal Kundenpreis
		{
			get
			{
				decimal defaultPrice = this.myBase.Verkaufspreis1;
				decimal discountPercent = (this.SonderpreisBase != null) ? this.SonderpreisBase.Rabatt : 0.0m;
				return defaultPrice - (defaultPrice * discountPercent / 100);
			}
		}

		/// <summary>
		/// Gibt den Artikelzusatztext im RTF-Format zurück.
		/// </summary>
		public string ZusatztextRTF
		{
			get
			{
				if (this.myBase.ArtikelzusatztextAnker > 0)
				{
					return DataManager.ProductDataService.GetProductTextRow(this.myBase.ArtikelzusatztextAnker).Content;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt den Artikelzusatztext zurück.
		/// </summary>
		public string Zusatztext
		{
			get
			{
				if (this.myBase.ArtikelzusatztextAnker > 0)
				{
					var rtf = new RichTextBox();
					rtf.Rtf = this.ZusatztextRTF;
					return rtf.Text;
				}
				return string.Empty;
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn es sich um einen Katalogartikel handelt.
		/// </summary>
		public bool KatalogFlag
		{
			get
			{
				if (this.myBase.USER_Katalogartikel == "1") return true;
				return false;
			}
		}

		/// <summary>
		/// Gibt 'Ja' zurück, wenn es sich um einen Katalogartikel handelt.
		/// </summary>
		public string Katalog
		{
			get { return (this.KatalogFlag) ? "Ja" : "Nein"; }
		}

		/// <summary>
		/// Gibt true zurück, wenn der Artikel geändert wurde.
		/// </summary>
		public bool ProductCpmDirty { get { return this.myProductCpmDirty; } }

		/// <summary>
		/// Gibt true zurück, wenn die Sonderpreise geändert wurden.
		/// </summary>
		public bool SonderpreiseDirty { get { return this.mySonderpreiseDirty; } }

		#region ARTIKEL_CPM

		/// <summary>
		/// Gibt die Katalogsektion des Artikels zurück.
		/// </summary>
		public string Katalogsektion
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return (this.myProductCpmBase.IsCategoryNull()) ? string.Empty : this.myProductCpmBase.Category;
			}
			set
			{
				this.myProductCpmBase.Category = value;
				this.SetProductsCpmDirty();
			}
		}

		public string KatalogsektionName
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsCategoryNull() || string.IsNullOrEmpty(this.myProductCpmBase.Category)) return string.Empty;
				var section = ModelManager.CatalogService.GetSectionName(this.myProductCpmBase.Category);
				return section;
			}
		}

		public string Beschreibung
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return (this.myProductCpmBase.IsDescriptionNull()) ? string.Empty : this.myProductCpmBase.Description;
			}
			set
			{
				this.myProductCpmBase.Description = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft1
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return (this.myProductCpmBase.IsProperty1Null()) ? string.Empty : this.myProductCpmBase.Property1;
			}
			set
			{
				this.myProductCpmBase.Property1 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert1
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return (this.myProductCpmBase.IsValue1Null()) ? string.Empty : this.myProductCpmBase.Value1;
			}
			set
			{
				this.myProductCpmBase.Value1 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft2
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return (this.myProductCpmBase.IsProperty2Null()) ? string.Empty : this.myProductCpmBase.Property2;
			}
			set
			{
				this.myProductCpmBase.Property2 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert2
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue2Null()) return string.Empty;
				return this.myProductCpmBase.Value2;
			}
			set
			{
				this.myProductCpmBase.Value2 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft3
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty3Null()) return string.Empty;
				return this.myProductCpmBase.Property3;
			}
			set
			{
				this.myProductCpmBase.Property3 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert3
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue3Null()) return string.Empty;
				return this.myProductCpmBase.Value3;
			}
			set
			{
				this.myProductCpmBase.Value3 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft4
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty4Null()) return string.Empty;
				return this.myProductCpmBase.Property4;
			}
			set
			{
				this.myProductCpmBase.Property4 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert4
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue4Null()) return string.Empty;
				return this.myProductCpmBase.Value4;
			}
			set
			{
				this.myProductCpmBase.Value4 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft5
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty5Null()) return string.Empty;
				return this.myProductCpmBase.Property5;
			}
			set
			{
				this.myProductCpmBase.Property5 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert5
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue5Null()) return string.Empty;
				return this.myProductCpmBase.Value5;
			}
			set
			{
				this.myProductCpmBase.Value5 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft6
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty6Null()) return string.Empty;
				return this.myProductCpmBase.Property6;
			}
			set
			{
				this.myProductCpmBase.Property6 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert6
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue6Null()) return string.Empty;
				return this.myProductCpmBase.Value6;
			}
			set
			{
				this.myProductCpmBase.Value6 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft7
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty7Null()) return string.Empty;
				return this.myProductCpmBase.Property7;
			}
			set
			{
				this.myProductCpmBase.Property7 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert7
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue7Null()) return string.Empty;
				return this.myProductCpmBase.Value7;
			}
			set
			{
				this.myProductCpmBase.Value7 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft8
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty8Null()) return string.Empty;
				return this.myProductCpmBase.Property8;
			}
			set
			{
				this.myProductCpmBase.Property8 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert8
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue8Null()) return string.Empty;
				return this.myProductCpmBase.Value8;
			}
			set
			{
				this.myProductCpmBase.Value8 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft9
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty9Null()) return string.Empty;
				return this.myProductCpmBase.Property9;
			}
			set
			{
				this.myProductCpmBase.Property9 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert9
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue9Null()) return string.Empty;
				return this.myProductCpmBase.Value9;
			}
			set
			{
				this.myProductCpmBase.Value9 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft10
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty10Null()) return string.Empty;
				return this.myProductCpmBase.Property10;
			}
			set
			{
				this.myProductCpmBase.Property10 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert10
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue10Null()) return string.Empty;
				return this.myProductCpmBase.Value10;
			}
			set
			{
				this.myProductCpmBase.Value10 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft11
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty11Null()) return string.Empty;
				return this.myProductCpmBase.Property11;
			}
			set
			{
				this.myProductCpmBase.Property11 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert11
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue11Null()) return string.Empty;
				return this.myProductCpmBase.Value11;
			}
			set
			{
				this.myProductCpmBase.Value11 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft12
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty12Null()) return string.Empty;
				return this.myProductCpmBase.Property12;
			}
			set
			{
				this.myProductCpmBase.Property12 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert12
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue12Null()) return string.Empty;
				return this.myProductCpmBase.Value12;
			}
			set
			{
				this.myProductCpmBase.Value12 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft13
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty13Null()) return string.Empty;
				return this.myProductCpmBase.Property13;
			}
			set
			{
				this.myProductCpmBase.Property13 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert13
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue13Null()) return string.Empty;
				return this.myProductCpmBase.Value13;
			}
			set
			{
				this.myProductCpmBase.Value13 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Eigenschaft14
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsProperty14Null()) return string.Empty;
				return this.myProductCpmBase.Property14;
			}
			set
			{
				this.myProductCpmBase.Property14 = value;
				this.SetProductsCpmDirty();
			}
		}

		public string Wert14
		{
			get
			{
				if (!KatalogFlag || this.myProductCpmBase.IsValue14Null()) return string.Empty;
				return this.myProductCpmBase.Value14;
			}
			set
			{
				this.myProductCpmBase.Value14 = value;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt den Pfad zum Herstellerlogo zurück.
		/// </summary>
		public string HerstellerlogoPfad
		{
			get
			{
				if (!KatalogFlag) return string.Empty;
				return !this.myProductCpmBase.IsManufacturerLogoNull() ? this.myProductCpmBase.ManufacturerLogo : string.Empty;
			}
			set
			{
				this.myProductCpmBase.ManufacturerLogo = value;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt ein Image des Herstellerlogos zurück.
		/// </summary>
		public Image Herstellerlogo
		{
			get
			{
				if (string.IsNullOrEmpty(this.HerstellerlogoPfad)) return null;

				var logoPath = Path.Combine(this.serverPicturePath, this.myProductCpmBase.ManufacturerLogo);
				if (File.Exists(logoPath))
				{
					var img = Image.FromFile(logoPath);
					return img;
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt den Pfad zum Produktlogo zurück.
		/// </summary>
		public string ProduktlogoPfad
		{
			get
			{
				if (this.KatalogFlag)
				{
					return !this.myProductCpmBase.IsProductLogoNull() ? this.myProductCpmBase.ProductLogo : string.Empty;
				}
				return null;
			}
			set
			{
				this.myProductCpmBase.ProductLogo = value;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt ein Image des Produktlogos zurück.
		/// </summary>
		public Image Produktlogo
		{
			get
			{
				var logoPath = this.myProductCpmBase.ProductLogo;
				if (string.IsNullOrEmpty(logoPath) && File.Exists(logoPath))
				{
					var img = Image.FromFile(this.ProduktlogoPfad);
					return img;
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt den Pfad zum Produktbild zurück.
		/// </summary>
		public string ProkuktbildPfad
		{
			get
			{
				if (this.KatalogFlag)
				{
					return !this.myProductCpmBase.IsProductPictureNull() ? this.myProductCpmBase.ProductPicture : string.Empty;
				}
				return null;
			}
			set
			{
				this.myProductCpmBase.ProductPicture = value;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt das Image des Produktbilds zurück.
		/// </summary>
		public Image Produktbild
		{
			get
			{
				if (!string.IsNullOrEmpty(this.ProduktlogoPfad) && File.Exists(this.ProduktlogoPfad))
				{
					var img = Image.FromFile(this.ProkuktbildPfad);
					return img;
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn der Artikel gecheckt wurde.
		/// </summary>
		public bool CheckedFlag
		{
			get
			{
				if (this.KatalogFlag)
				{
					return (this.myProductCpmBase.CheckedFlag == 1);
				}
				return false;
			}
			set
			{
				if (value == true) this.myProductCpmBase.CheckedFlag = 1;
				this.myProductCpmBase.CheckedFlag = 0;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt true zurück, wenn der Artikel gecheckt wurde.
		/// </summary>
		public bool InactiveFlag
		{
			get
			{
				if (this.KatalogFlag)
				{
					return (this.myProductCpmBase.InactiveFlag == 1);
				}
				return false;
			}
			set
			{
				if (value == true) this.myProductCpmBase.InactiveFlag = 1;
				this.myProductCpmBase.InactiveFlag = 0;
				this.SetProductsCpmDirty();
			}
		}

		/// <summary>
		/// Gibt das Datum der letzten Änderung zurück oder legt es fest.
		/// </summary>
		public DateTime ChangeDate
		{
			get
			{
				if (this.KatalogFlag)
				{
					return this.myProductCpmBase.ChangeDate;
				}
				return new DateTime(1963, 12, 17);
			}
			set
			{
				if (this.KatalogFlag) this.myProductCpmBase.ChangeDate = value;
			}
		}

		/// <summary>
		/// Gibt den Namen des Mitarbeiters zurück, der diesen Artikel zuletzt bearbeitet hat oder
		/// legt ihn fest.
		/// </summary>
		public string ChangeUser
		{
			get
			{
				if (this.KatalogFlag)
				{
					return this.myProductCpmBase.ChangeUser;
				}
				return string.Empty;
			}
			set
			{
				if (this.KatalogFlag) this.myProductCpmBase.ChangeUser = value;
			}
		}

		#endregion ARTIKEL_CPM

		#region SONDERPREISE

		/// <summary>
		/// Der Preisrabatt in Prozent.
		/// </summary>
		public decimal RabattProzent
		{
			get
			{
				if (this.SonderpreisBase != null)
				{
					return Math.Round(this.SonderpreisBase.Rabatt, 2, MidpointRounding.AwayFromZero);
				}
				return 0.0m;
			}
			set
			{
				this.GetOrCreateSonderpreisBase().Rabatt = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal RabattPreis
		{
			get
			{
				if (this.RabattProzent > 0)
				{
					var result = this.Standardpreis - (this.Standardpreis * this.RabattProzent / 100);
					return Math.Round(result, 2, MidpointRounding.AwayFromZero);
				}
				return this.Standardpreis;
			}
			set
			{
				var result = 100 - (value * 100 / this.Standardpreis);
				this.GetOrCreateSonderpreisBase().Rabatt = Math.Round(result, 2, MidpointRounding.AwayFromZero);
				this.SetSonderpreiseDirty();
			}
		}

		public string StaffelpreisInfo
		{
			get
			{
				var sb = new StringBuilder();

				if (this.Sonderpreis1 > 0) sb.Append($"Ab {this.SonderpreisMenge1}: {this.Sonderpreis1} €");
				if (this.Sonderpreis2 > 0)
				{
					if (sb.Length > 0)
					{
						sb.Append($"; ab {this.SonderpreisMenge2}: {this.Sonderpreis2} €");
					}
					else sb.Append($"Ab {this.SonderpreisMenge2}: {this.Sonderpreis2} €");
				}

				if (sb.Length == 0) return "-";
				return sb.ToString();
			}
		}

		public decimal SonderpreisMenge1
		{
			get
			{
				var result = (this.SonderpreisBase != null) ? this.SonderpreisBase.Menge1 : 0.0m;
				return Math.Round(result, 1, MidpointRounding.AwayFromZero);
			}
			set
			{
				this.GetOrCreateSonderpreisBase().Menge1 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisRabatt1
		{
			get { return (this.SonderpreisBase != null) ? this.SonderpreisBase.Rabatt1 : 0.0m; }
			set
			{
				this.GetOrCreateSonderpreisBase().Rabatt1 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal Sonderpreis1
		{
			get
			{
				if (this.SonderpreisRabatt1 > 0)
				{
					var result = this.Standardpreis - (this.Standardpreis * this.SonderpreisRabatt1 / 100);
					return Math.Round(result, 2, MidpointRounding.AwayFromZero);
				}
				return 0.0m;
			}
			set
			{
				var result = 100 - (value * 100 / this.Standardpreis);
				this.GetOrCreateSonderpreisBase().Rabatt1 = Math.Round(result, 2, MidpointRounding.AwayFromZero);
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisMenge2
		{
			get
			{
				var result = (this.SonderpreisBase != null) ? this.SonderpreisBase.Menge2 : 0.0m;
				return Math.Round(result, 1, MidpointRounding.AwayFromZero);
			}
			set
			{
				this.GetOrCreateSonderpreisBase().Menge2 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisRabatt2
		{
			get { return (this.SonderpreisBase != null) ? this.SonderpreisBase.Rabatt2 : 0.0m; }
			set
			{
				this.GetOrCreateSonderpreisBase().Rabatt2 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal Sonderpreis2
		{
			get
			{
				if (this.SonderpreisRabatt2 > 0)
				{
					var result = this.Standardpreis - (this.Standardpreis * this.SonderpreisRabatt2 / 100);
					return Math.Round(result, 2, MidpointRounding.AwayFromZero);
				}
				return 0.0m;
			}
			set
			{
				var result = 100 - (value * 100 / this.Standardpreis);
				this.GetOrCreateSonderpreisBase().Rabatt2 = Math.Round(result, 2, MidpointRounding.AwayFromZero);
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisMenge3
		{
			get
			{
				var result = (this.SonderpreisBase != null) ? this.SonderpreisBase.Menge3 : 0.0m;
				return Math.Round(result, 1, MidpointRounding.AwayFromZero);
			}
			set
			{
				this.GetOrCreateSonderpreisBase().Menge3 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisRabatt3
		{
			get { return (this.SonderpreisBase != null) ? this.SonderpreisBase.Rabatt3 : 0.0m; }
			set
			{
				this.GetOrCreateSonderpreisBase().Rabatt3 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal Sonderpreis3
		{
			get
			{
				if (this.SonderpreisRabatt3 > 0)
				{
					var result = this.Standardpreis - (this.Standardpreis * this.SonderpreisRabatt3 / 100);
					return Math.Round(result, 2, MidpointRounding.AwayFromZero);
				}
				return 0.0m;
			}
			set
			{
				var result = 100 - (value * 100 / this.Standardpreis);
				this.GetOrCreateSonderpreisBase().Rabatt3 = Math.Round(result, 2, MidpointRounding.AwayFromZero);
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisMenge4
		{
			get
			{
				var result = (this.SonderpreisBase != null) ? this.SonderpreisBase.Menge4 : 0.0m;
				return Math.Round(result, 1, MidpointRounding.AwayFromZero);
			}
			set
			{
				this.GetOrCreateSonderpreisBase().Menge4 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal SonderpreisRabatt4
		{
			get { return (this.SonderpreisBase != null) ? this.SonderpreisBase.Rabatt4 : 0.0m; }
			set
			{
				this.GetOrCreateSonderpreisBase().Rabatt4 = value;
				this.SetSonderpreiseDirty();
			}
		}

		public decimal Sonderpreis4
		{
			get
			{
				if (this.SonderpreisRabatt4 > 0)
				{
					var result = this.Standardpreis - (this.Standardpreis * this.SonderpreisRabatt4 / 100);
					return Math.Round(result, 2, MidpointRounding.AwayFromZero);
				}
				return 0.0m;
			}
			set
			{
				var result = 100 - (value * 100 / this.Standardpreis);
				this.GetOrCreateSonderpreisBase().Rabatt4 = Math.Round(result, 2, MidpointRounding.AwayFromZero);
				this.SetSonderpreiseDirty();
			}
		}

		#endregion SONDERPREISE

		#endregion integrals

		#endregion public properties

		#region private properties

		dsProducts.SonderpreisRow SonderpreisBase
		{
			get { return ModelManager.ProductService.GetSonderpreisRow(this.myKunde, this.Artikelgruppe); }
		}

		#endregion private properties

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Product Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Product(
			dsProducts.ProductRow baseRow,
			dsProducts.ProductCpmRow productCpmBaseRow,
			Kunde kunde)
		{
			myBase = baseRow;
			this.myProductCpmBase = productCpmBaseRow;
			this.myKunde = kunde;
		}

		#endregion ### .ctor ###

		#region private procedures

		void SetProductsCpmDirty()
		{
			if (!this.KatalogFlag) return;
			this.myProductCpmDirty = true;
			this.ChangeDate = DateTime.Now;
			this.ChangeUser = ModelManager.UserService.CurrentUser.NameFull;
		}

		dsProducts.SonderpreisRow GetOrCreateSonderpreisBase()
		{
			if (this.SonderpreisBase == null)
			{
				ModelManager.ProductService.CreateSonderpreis(this.myKunde, this);
			}
			return this.SonderpreisBase;
		}

		void SetSonderpreiseDirty()
		{
			this.mySonderpreiseDirty = true;
			this.ChangeDate = DateTime.Now;
			this.ChangeUser = ModelManager.UserService.CurrentUser.NameFull;
		}

		#endregion private procedures
	}
}