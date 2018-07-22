using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Novacode;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;

namespace Products.DocxCreator
{
	public class DocXService
	{
		#region members

		private Data.Datasets.dsCatalog.CatalogDataTable catalogTable;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the DocXService class.
		/// </summary>
		public DocXService(Data.Datasets.dsCatalog.CatalogDataTable catTable)
		{
			this.catalogTable = catTable;
		}

		#endregion ### .ctor ###

		#region public procedures

		/// <summary>
		/// Erstellt einen neuen Servicebericht für den Servicetermin für eine CJV30 oder JV33.
		/// </summary>
		/// <param name="serviceTermin"></param>
		/// <returns></returns>
		public string CreateServiceReportCJV30(Appointment serviceTermin)
		{
			try
			{
				// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze Nummer muss
				// noch einmal überdacht werden.

				// Kunde kunde = serviceTermin.Kunde; string reportFilename =
				// string.Format("{0:yyyy-MM-dd_mmss}_{1}_{2}.docx", serviceTermin.StartsAt,
				// serviceTermin.Kundennummer.Substring(0, 5), serviceTermin.Techniker.NameFirst);
				// string reportFilePath = System.IO.Path.Combine(Common.Global.LinkedFilesPath, reportFilename);
				var templateFilePath = Path.Combine(CatalistRegistry.Application.TemplatePath, "sb_cjv30.docx");

				using (DocX doc = DocX.Load(templateFilePath))
				{
					foreach (Paragraph p in doc.Paragraphs)
					{
						var adresseTelefon = p.GetBookmarks().FirstOrDefault(b => b.Name == "Addresse_Telefon");
						if (adresseTelefon != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// adresseTelefon.Paragraph.InsertText(string.Format("{0}-{1}\n{2}",
							// kunde.Street, kunde.ZipCode + kunde.City, kunde.Kontaktlist[0].Telefon));
						}
						var annahmeDurch = p.GetBookmarks().FirstOrDefault(b => b.Name == "Annahme_durch");
						if (annahmeDurch != null)
						{
							annahmeDurch.Paragraph.InsertText(serviceTermin.OwnerName);
						}
						var datumService = p.GetBookmarks().FirstOrDefault(b => b.Name == "Datum_Service");
						if (datumService != null)
						{
							datumService.Paragraph.InsertText(string.Format("{0:dd.MM.yyyy}", serviceTermin.StartsAt));
						}
						var firmenName = p.GetBookmarks().FirstOrDefault(b => b.Name == "Kunde_Firmenname");
						if (firmenName != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							//firmenName.Paragraph.InsertText(kunde.CompanyName1);
						}
						var modell = p.GetBookmarks().FirstOrDefault(b => b.Name == "Maschine_Modell");
						if (modell != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// modell.Paragraph.InsertText(serviceTermin.Maschinenmodell);
						}
						var kundenNummer = p.GetBookmarks().FirstOrDefault(b => b.Name == "Kunde_Nummer");
						if (kundenNummer != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// kundenNummer.Paragraph.InsertText(kunde.CustomerId.Substring(0, 5));
						}
						var sn = p.GetBookmarks().FirstOrDefault(b => b.Name == "Maschine_Seriennummer");
						if (sn != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// sn.Paragraph.InsertText(serviceTermin.Maschine.Seriennummer);
						}
						var kontakt = p.GetBookmarks().FirstOrDefault(b => b.Name == "Kunde_Ansprechpartner");
						if (kontakt != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// kontakt.Paragraph.InsertText(kunde.Kontaktlist[0].Kontaktname);
						}
						var techniker = p.GetBookmarks().FirstOrDefault(b => b.Name == "Name_Techniker");
						if (techniker != null)
						{
							// APPT: DocXService -> CreateServiceReportCJV30 Ich denke, diese ganze
							// Nummer muss noch einmal überdacht werden.

							// techniker.Paragraph.InsertText(serviceTermin.Technikername);
						}
					}
					// APPT: DocXService -> CreateServiceReportCJV30
					// Ich denke, diese ganze Nummer muss noch einmal überdacht werden.
					//doc.SaveAs(reportFilePath);

					//serviceTermin.AddFileLink(reportFilePath, deleteSourceFile: false);
				}
				//return reportFilePath;
				throw new ApplicationException("Sorry, die Funktion gibt's noch nicht.");
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Creates a Word document with the product catalog for the given customer.
		/// </summary>
		/// <param name="customer"></param>
		public string CreateCatalogDocument(dsCustomer.CustomerRow customer, string catalogPath, bool shorty)
		{
			var kunde = ModelManager.CustomerService.GetKunde(customer.Kundennummer, true);
			if (kunde == null) return string.Empty;

			var catFileName = string.Format("{0:yyyy-MM-dd_mmss}_({1})_{2}.docx", DateTime.Now, kunde.KundenNrCpm, kunde.Matchcode);
			var catCompleteFilePath = string.Format("{0}{1}", catalogPath, catFileName);

			using (DocX doc = DocX.Load(CatalistRegistry.Application.CatalogTemplateFilePath))
			{
				// Firmenname und Kundennummer einfügen
				var companyAndNumber = string.Format(@"{0} - [Ihre Kd.-Nr.: {1}]", kunde.CompanyName1, kunde.KundenNrCpm);
				foreach (Paragraph p in doc.Paragraphs)
				{
					var cbm = p.GetBookmarks().FirstOrDefault(bookmark => bookmark.Name == "Firmenname");
					if (cbm != null)
					{
						cbm.Paragraph.InsertText(companyAndNumber);
						p.StyleName = "Firmenname";
						cbm.Paragraph.StyleName = "Firmenname";
					}
				}

				// Iterate over all catalog outline entries.
				foreach (var cRow in DataManager.CatalogDataService.GetCatalogTable())
				{
					// Iterate over all products of the current section
					var pList = ModelManager.ProductService.GetProductList(kunde).Where(p => p.KatalogFlag == true & p.Katalogsektion == cRow.Numbering).OrderBy(c => c.Artikelnummer);
					foreach (var product in pList)
					{
						if (!product.InactiveFlag)
						{
							// Find
							foreach (Paragraph p in doc.Paragraphs)
							{
								var b = p.GetBookmarks().FirstOrDefault(bm => bm.Name == cRow.Numbering);
								if (b != null)
								{
									if (cRow.Numbering == "J00")
									{
										System.Threading.Thread.Sleep(100);
									}

									Table t = null;
									if (shorty)
									{
										t = this.NewShortDocTable(doc, product);
									}
									else
									{
										t = this.NewDocTable(doc, product);
									}
									if (t != null)
									{
										var pi = b.Paragraph.InsertParagraphBeforeSelf(string.Empty);
										pi.InsertTableBeforeSelf(t);
									}
								}
							}
						}
					}
				}
				// Save the created catalog file.
				doc.SaveAs(catCompleteFilePath);
				return catCompleteFilePath;
			}
		}

		#endregion public procedures

		#region private procedures

		Table NewShortDocTable(DocX doc, Product product)
		{
			Paragraph pProductName = null;
			var newTable = doc.AddTable(1, 3);
			foreach (Paragraph p in newTable.Paragraphs)
			{
				p.StyleName = "KeepTogether";
			}
			// Productname
			pProductName = newTable.Rows[0].Cells[0].Paragraphs[0];
			pProductName.Append(product.Bezeichnung2);
			pProductName.StyleName = "ArtikelnameKurz";

			// Insert customer price string
			//newTable.Rows[0].Cells[1].Paragraphs[0].Append("Preis");
			newTable.Rows[0].Cells[1].Paragraphs[0].Append(PreisUndStaffelpreisText(product));
			newTable.Rows[0].Cells[1].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);
			newTable.Rows[0].Cells[1].Width = 80;
			//newTable.Rows[0].Cells[2].Paragraphs[0].Append(string.Format("{0:C2}/{1}", productRow.KundenpreisRow.Kundenpreis, productRow.KundenpreisRow.Mengeneinheit));
			newTable.Rows[0].Cells[2].Paragraphs[0].Append(PreisUndStaffelpreise(product));
			newTable.Rows[0].Cells[2].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);

			newTable.AutoFit = AutoFit.Window;
			foreach (Row r in newTable.Rows)
			{
				foreach (Cell c in r.Cells)
				{
					c.MarginBottom = 3;
					c.MarginTop = 5;
				}
			}

			// Set the border
			var border = new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, System.Drawing.Color.Gray);
			newTable.SetBorder(TableBorderType.Left, border);
			newTable.SetBorder(TableBorderType.Right, border);
			newTable.SetBorder(TableBorderType.Top, border);
			newTable.SetBorder(TableBorderType.Bottom, border);
			newTable.SetBorder(TableBorderType.InsideH, border);
			newTable.SetBorder(TableBorderType.InsideV, border);

			return newTable;
		}

		Table NewDocTable(DocX doc, Product product)
		{
			Paragraph pProductName = null;
			Paragraph pDescription = null;
			Paragraph pManufacturerLogo = null;
			Paragraph pProductImage = null;

			Image manufacturerImage = null;
			Image productImage = null;
			Picture manufacturerPicture = null;
			Picture productPicture = null;
			int picWidth = Properties.Settings.Default.PictureWidth;

			if (product.Herstellerlogo == null)
			{
				manufacturerImage = doc.AddImage(CatalistRegistry.Application.ManufacturerPicturePath + "dummy.png");
			}
			else
			{
				manufacturerImage = doc.AddImage(CatalistRegistry.Application.ManufacturerPicturePath + product.HerstellerlogoPfad);
			}
			manufacturerPicture = manufacturerImage.CreatePicture();
			manufacturerPicture.Height = picWidth * manufacturerPicture.Height / manufacturerPicture.Width;
			manufacturerPicture.Width = picWidth;

			if (product.Produktbild != null)
			{
				productImage = doc.AddImage(CatalistRegistry.Application.ProductPicturePath + product.ProkuktbildPfad);
			}

			var props = GetProperties(product);
			if (props.Count > 0)
			{
				var nt = doc.AddTable(props.Count + 1, 3);

				foreach (Paragraph p in nt.Paragraphs)
				{
					p.StyleName = "KeepTogether";
				}

				if (nt.RowCount > 1) nt.MergeCellsInColumn(0, 0, props.Count);

				// Productname
				pProductName = nt.Rows[0].Cells[0].Paragraphs[0];
				pProductName.Append(product.Bezeichnung1);
				pProductName.StyleName = "Artikelname";

				// Manufacturer logo
				if (product.Herstellerlogo != null)
				{
					pManufacturerLogo = pProductName.InsertParagraphAfterSelf(string.Empty);
					pManufacturerLogo.AppendPicture(manufacturerPicture).StyleName = "KeepTogether";
					pManufacturerLogo.SetLineSpacing(LineSpacingType.Before, 0.5F);
					pManufacturerLogo.SetLineSpacing(LineSpacingType.After, 0.5F);
					pManufacturerLogo.Alignment = Alignment.center;
				}

				// Product image
				if (product.Produktbild != null)
				{
					productImage = doc.AddImage(CatalistRegistry.Application.ProductPicturePath + product.ProkuktbildPfad);
					productPicture = productImage.CreatePicture();
					productPicture.Height = picWidth * productPicture.Height / productPicture.Width;
					productPicture.Width = picWidth;

					if (pManufacturerLogo != null)
					{
						pProductImage = pManufacturerLogo.InsertParagraphAfterSelf(string.Empty);
						pProductImage.AppendPicture(productPicture);
					}
					else
					{
						pProductImage = pProductName.InsertParagraphAfterSelf(string.Empty);
						pProductImage.AppendPicture(productPicture);
					}
					pProductImage.Alignment = Alignment.center;
					pProductImage.SetLineSpacing(LineSpacingType.After, 0.5F);
				}

				// Product description
				if (product.Herstellerlogo == null && product.Produktbild == null)
				{
					pDescription = pProductName.InsertParagraphAfterSelf(string.Empty);
				}
				else if (product.Herstellerlogo != null && product.Produktbild == null)
				{
					pDescription = pManufacturerLogo.InsertParagraphAfterSelf(string.Empty);
				}
				else
				{
					pDescription = pProductImage.InsertParagraphAfterSelf(string.Empty);
				}
				pDescription.Append(product.Beschreibung).Alignment = Alignment.left;
				nt.Rows[0].Cells[0].Width = 100;

				// Insert properties and values
				int counter = 0;
				foreach (var property in props)
				{
					nt.Rows[counter].Cells[1].Paragraphs[0].Append(property.Key).StyleName = "KeepTogether";
					nt.Rows[counter].Cells[1].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);
					nt.Rows[counter].Cells[1].Width = 80;
					nt.Rows[counter].Cells[2].Paragraphs[0].Append(property.Value).StyleName = "KeepTogether";
					nt.Rows[counter].Cells[2].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);
					counter += 1;
				}

				// Insert customer price string
				nt.Rows[counter].Cells[1].Paragraphs[0].Append(PreisUndStaffelpreisText(product));
				nt.Rows[counter].Cells[1].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);
				nt.Rows[counter].Cells[1].Width = 80;
				nt.Rows[counter].Cells[2].Paragraphs[0].Append(PreisUndStaffelpreise(product));
				nt.Rows[counter].Cells[2].Paragraphs[0].SetLineSpacing(LineSpacingType.After, 0F);

				nt.AutoFit = AutoFit.Window;
				foreach (Row r in nt.Rows)
				{
					foreach (Cell c in r.Cells)
					{
						c.MarginBottom = 3;
						c.MarginTop = 5;
					}
				}

				// Set the border
				var border = new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, System.Drawing.Color.Gray);
				nt.SetBorder(TableBorderType.Left, border);
				nt.SetBorder(TableBorderType.Right, border);
				nt.SetBorder(TableBorderType.Top, border);
				nt.SetBorder(TableBorderType.Bottom, border);
				nt.SetBorder(TableBorderType.InsideH, border);
				nt.SetBorder(TableBorderType.InsideV, border);

				return nt;
			}
			return null;
		}

		private string PreisUndStaffelpreisText(Product product)
		{
			//nt.Rows[counter].Cells[1].Paragraphs[0].Append("Preis");
			var sb = new StringBuilder();
			sb.Append("Preis");
			if (product.SonderpreisMenge1 >= 0.01m && product.SonderpreisRabatt1 >= 0.01m)
			{
				sb.AppendFormat("\nab {0:N0}", product.SonderpreisMenge1);
			}

			if (product.SonderpreisMenge2 >= 0.01m && product.SonderpreisRabatt2 >= 0.01m)
			{
				sb.AppendFormat("\nab {0:N0}", product.SonderpreisMenge2);
			}

			if (product.SonderpreisMenge3 >= 0.01m && product.SonderpreisRabatt3 >= 0.01m)
			{
				sb.AppendFormat("\nab {0:N0}", product.SonderpreisMenge3);
			}

			if (product.SonderpreisMenge4 >= 0.01m && product.SonderpreisRabatt4 >= 0.01m)
			{
				sb.AppendFormat("\nab {0:N0}", product.SonderpreisMenge4);
			}

			return sb.ToString();
		}

		private string PreisUndStaffelpreise(Product product)
		{
			//nt.Rows[counter].Cells[2].Paragraphs[0].Append(string.Format("{0:C2}/{1}",productRow.KundenpreisRow.Kundenpreis, productRow.KundenpreisRow.Mengeneinheit));
			var sb = new StringBuilder();
			decimal rabattPreis = 0.00m;

			sb.AppendFormat("{0:C2} / {1}", product.Kundenpreis, product.Mengeneinheit);

			if (product.SonderpreisMenge1 >= 0.01m && product.SonderpreisRabatt1 >= 0.01m)
			{
				rabattPreis = (100 - product.SonderpreisRabatt1) * product.Standardpreis / 100;
				sb.AppendFormat("\n{0:C2} / {1}", rabattPreis, product.Mengeneinheit);
			}

			if (product.SonderpreisMenge2 >= 0.01m && product.SonderpreisRabatt2 >= 0.01m)
			{
				rabattPreis = (100 - product.SonderpreisRabatt2) * product.Standardpreis / 100;
				sb.AppendFormat("\n{0:C2} / {1}", rabattPreis, product.Mengeneinheit);
			}

			if (product.SonderpreisMenge3 >= 0.01m && product.SonderpreisRabatt3 >= 0.01m)
			{
				rabattPreis = (100 - product.SonderpreisRabatt3) * product.Standardpreis / 100;
				sb.AppendFormat("\n{0:C2} / {1}", rabattPreis, product.Mengeneinheit);
			}

			if (product.SonderpreisMenge4 >= 0.01m && product.SonderpreisRabatt4 >= 0.01m)
			{
				rabattPreis = (100 - product.SonderpreisRabatt4) * product.Standardpreis / 100;
				sb.AppendFormat("\n{0:C2} / {1}", rabattPreis, product.Mengeneinheit);
			}

			return sb.ToString();
		}

		Dictionary<string, string> GetProperties(Product product)
		{
			var propList = new Dictionary<string, string>();

			if (!string.IsNullOrEmpty(product.Eigenschaft1) && !string.IsNullOrEmpty(product.Wert1)) propList.Add(product.Eigenschaft1, product.Wert1);
			if (!string.IsNullOrEmpty(product.Eigenschaft2) && !string.IsNullOrEmpty(product.Wert2)) propList.Add(product.Eigenschaft2, product.Wert2);
			if (!string.IsNullOrEmpty(product.Eigenschaft3) && !string.IsNullOrEmpty(product.Wert3)) propList.Add(product.Eigenschaft3, product.Wert3);
			if (!string.IsNullOrEmpty(product.Eigenschaft4) && !string.IsNullOrEmpty(product.Wert4)) propList.Add(product.Eigenschaft4, product.Wert4);
			if (!string.IsNullOrEmpty(product.Eigenschaft5) && !string.IsNullOrEmpty(product.Wert5)) propList.Add(product.Eigenschaft5, product.Wert5);
			if (!string.IsNullOrEmpty(product.Eigenschaft6) && !string.IsNullOrEmpty(product.Wert6)) propList.Add(product.Eigenschaft6, product.Wert6);
			if (!string.IsNullOrEmpty(product.Eigenschaft7) && !string.IsNullOrEmpty(product.Wert7)) propList.Add(product.Eigenschaft7, product.Wert7);
			if (!string.IsNullOrEmpty(product.Eigenschaft8) && !string.IsNullOrEmpty(product.Wert8)) propList.Add(product.Eigenschaft8, product.Wert8);
			if (!string.IsNullOrEmpty(product.Eigenschaft9) && !string.IsNullOrEmpty(product.Wert9)) propList.Add(product.Eigenschaft9, product.Wert9);
			if (!string.IsNullOrEmpty(product.Eigenschaft10) && !string.IsNullOrEmpty(product.Wert10)) propList.Add(product.Eigenschaft10, product.Wert10);
			if (!string.IsNullOrEmpty(product.Eigenschaft11) && !string.IsNullOrEmpty(product.Wert11)) propList.Add(product.Eigenschaft11, product.Wert11);
			if (!string.IsNullOrEmpty(product.Eigenschaft12) && !string.IsNullOrEmpty(product.Wert12)) propList.Add(product.Eigenschaft12, product.Wert12);
			if (!string.IsNullOrEmpty(product.Eigenschaft13) && !string.IsNullOrEmpty(product.Wert13)) propList.Add(product.Eigenschaft13, product.Wert13);
			if (!string.IsNullOrEmpty(product.Eigenschaft14) && !string.IsNullOrEmpty(product.Wert14)) propList.Add(product.Eigenschaft14, product.Wert14);

			return propList;
		}

		#endregion private procedures
	}
}