using System;
using System.Diagnostics;
using System.IO;
using PdfFileWriter;
using Products.Model.Entities;

namespace Products.PdfMaker
{
	public class PdfService
	{

		#region constants

		const double pageHeight = 297D;
		const double lineHeight = 7D;
		const double doubleLHeight = 14D;
		const double yTableOrigin = 204D;
		const double xLeftMargin = 10D;
		const double xRightMargin = 200D;
		const double xVLine1 = 20D;
		const double xVLine2 = 56D;
		const double xVLine3 = 128D;
		const double xVLine4 = 150D;
		const double xVLine5 = 175D;
		const double xSummary = 150D;
		const double xPage = 190D;

		const double xFTab1 = 60D;
		const double xFTab2 = 100D;
		const double xFTab3 = 155D;

		const int colPos = 0;
		const int colArtNr = 1;
		const int colArtBez = 2;
		const int colMenge = 3;
		const int colPreis = 4;
		const int colGesamt = 5;

		const double pageWidth = 210D;

		#endregion

		#region members

		Offer myOffer;
		PdfFont fontDefault;
		PdfFont myFontBold;
		PdfFont fontFooter;
		PdfFont fontFooterBold;
		PdfFont fontPriceTotal;
		int pageNumber;
		decimal zwischenSumme;
		bool lastRow;
		private double lastPosition;

		#endregion

		#region public procedures

		public void PrintOffer(Offer offer, bool asOrder = false)
		{
			try
			{
				ResetVars();
				myOffer = offer;
				var fileAndPath = Path.Combine(CatalistRegistry.Application.OfferFilePath, offer.OfferId + ".pdf");

				if (File.Exists(fileAndPath))
				{
					// Datei in das lokale TEMP Verzeichnis kopieren
					var temp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
					var prefix = asOrder ? "B" : "A";
					var tempFilename = string.Format("{0}{1}.pdf", prefix, DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"));
					var tempFileAndPath = Path.Combine(temp, tempFilename);
					File.Copy(fileAndPath, tempFileAndPath);
					var proc = new Process();
					proc.StartInfo = new ProcessStartInfo(tempFileAndPath);
					proc.Start();
				}
				else
				{
					CreateOfferDocument(offer, asOrder);
				}
			}
			catch (IOException ioEx)
			{
				throw ioEx;
			}
		}

		public FileInfo CreateOfferDocument(Offer offer, bool asOrder = false, bool withPreview = true)
		{
			ResetVars();
			myOffer = offer;
			PdfDocument doc;
			PdfPage page;
			PdfContents content;
			PdfImage img;
			double lineSpacing;
			double descent;
			const double fontSize = 10.0;
			bool isOffer = (this.myOffer.Bestellkennzeichen | asOrder);

			string fullName = Path.Combine(CatalistRegistry.Application.OfferFilePath, offer.OfferId + ".pdf");
			doc = new PdfDocument(PaperType.A4, false, UnitOfMeasure.mm, fullName);
			doc.Debug = false;
			page = new PdfPage(doc);
			content = new PdfContents(page);
			content.SetLineWidth(0.03);

			fontDefault = new PdfFont(doc, "Calibri", System.Drawing.FontStyle.Regular, true);
			myFontBold = new PdfFont(doc, "Calibri", System.Drawing.FontStyle.Bold, true);
			fontFooter = new PdfFont(doc, "Calibri Light", System.Drawing.FontStyle.Regular, true);
			fontFooterBold = new PdfFont(doc, "Calibri Light", System.Drawing.FontStyle.Bold, true);
			fontPriceTotal = new PdfFont(doc, "Calibri Light", System.Drawing.FontStyle.Bold, true);

			lineSpacing = fontDefault.LineSpacing(fontSize);
			descent = fontDefault.Descent(fontSize);

			// Header
			string imagePath = Path.Combine(CatalistRegistry.Application.PicturePath, "briefkopf.png");
			img = new PdfImage(doc, imagePath);
			content.DrawImage(img, 5, pageHeight - 27.9 - 5, 199.6, 27.4);
			content.DrawLine(xLeftMargin - 5, pageHeight - 27.9 - 5 - 2, xRightMargin + 5, pageHeight - 27.9 - 5 - 2);

			string absender = @"Cut & Print Media GmbH & Co. KG · Osterheide 9 · 49124 Georgsmarienhütte";
			content.DrawText(fontDefault, fontSize - 4, 18, pageHeight - 49.5, absender);
			content.DrawLine(18, pageHeight - 50.5, 84.5, pageHeight - 50.5, 0.1);
			content.DrawText(fontDefault, fontSize + 2, 18, pageHeight - 55, offer.Customer.CompanyName1);
			content.DrawText(fontDefault, fontSize + 2, 18, pageHeight - 65, offer.Customer.Street);
			string zipCity = string.Format("{0} {1}", offer.Customer.ZipCode, offer.Customer.City);
			content.DrawText(fontDefault, fontSize + 2, 18, pageHeight - 71, zipCity);

			string vorgang = isOffer ? "Bestellung" : "Angebot";
			content.DrawText(fontDefault, fontSize + 2, xVLine3 + 5, pageHeight - 55, "Kunden-Nr.:");
			content.DrawText(fontDefault, fontSize + 2, xVLine5 - 13, pageHeight - 55, offer.CustomerId.Substring(0, 5));
			content.DrawText(fontDefault, fontSize + 2, xVLine3 + 5, pageHeight - 60, vorgang + " Nr.:");
			content.DrawText(fontDefault, fontSize + 2, xVLine5 - 13, pageHeight - 60, offer.OfferId);
			content.DrawText(fontDefault, fontSize + 2, xVLine3 + 5, pageHeight - 65, "Datum:");
			content.DrawText(fontDefault, fontSize + 2, xVLine5 - 13, pageHeight - 65, offer.ChangeDate.ToShortDateString());
			content.DrawText(fontDefault, fontSize + 2, xVLine3 + 5, pageHeight - 70, "Bearbeitet von:");
			content.DrawText(fontDefault, fontSize + 2, xVLine5 - 13, pageHeight - 70, offer.ChangeUser);

			content.DrawText(myFontBold, fontSize + 2, 10, pageHeight - 96.5, vorgang + " " + offer.OfferId);

			var table = new PdfTable(page, content, fontDefault, 9);
			table.TableStartEvent += tab_TableStartEvent;
			table.TableEndEvent += tab_TableEndEvent;
			table.TableArea = new PdfRectangle(10D, 35D, 200D, pageHeight - 40);
			table.RowTopPosition = pageHeight - 100D; // 10cm vom oberen Rand
			table.SetColumnWidth(9D, 34D, 86D, 13D, 19D, 19D);
			table.HeaderOnEachPage = true;

			table.Header[colPos].Style = table.HeaderStyle;
			table.Header[colPos].Style.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			table.Header[colPos].Value = "Pos.";

			table.Header[colArtNr].Value = "Artikel-Nr.";
			table.Header[colArtBez].Value = "Artikelbezeichnung";

			table.Header[colMenge].Style = table.HeaderStyle;
			table.Header[colMenge].Style.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			table.Header[colMenge].Value = "Menge";

			table.Header[colPreis].Style = table.HeaderStyle;
			table.Header[colPreis].Style.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			table.Header[colPreis].Value = "Einzelpreis";

			table.Header[colGesamt].Style = table.HeaderStyle;
			table.Header[colGesamt].Style.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			table.Header[colGesamt].Value = "Gesamtpreis";

			table.DefaultHeaderStyle.Font = myFontBold;
			table.DefaultHeaderStyle.Alignment = System.Drawing.ContentAlignment.TopLeft;
			table.DefaultHeaderStyle.MultiLineText = false;

			table.DefaultCellStyle.Font = fontDefault;
			table.DefaultCellStyle.FontSize = 9;
			table.DefaultCellStyle.Alignment = System.Drawing.ContentAlignment.TopLeft;

			table.Cell[colPos].Style = table.CellStyle;
			table.Cell[colPos].Style.Alignment = System.Drawing.ContentAlignment.TopRight;

			table.Cell[colArtNr].Style = table.CellStyle;
			table.Cell[colArtNr].Style.TextBoxTextJustify = TextBoxJustify.Left;

			table.Cell[colArtBez].Style = table.CellStyle;
			table.Cell[colArtBez].Style.TextBoxTextJustify = TextBoxJustify.Left;

			table.Cell[colMenge].Style = table.CellStyle;
			table.Cell[colMenge].Style.Format = "#,##0";
			table.Cell[colMenge].Style.Alignment = System.Drawing.ContentAlignment.TopRight;

			table.Cell[colPreis].Style = table.CellStyle;
			table.Cell[colPreis].Style.Format = "#,##0.00";
			table.Cell[colPreis].Style.Alignment = System.Drawing.ContentAlignment.TopRight;

			table.Cell[colGesamt].Style = table.CellStyle;
			table.Cell[colGesamt].Style.ForegroundColor = System.Drawing.Color.DarkRed;
			table.Cell[colGesamt].Style.Format = "#,##0.00";
			table.Cell[colGesamt].Style.Alignment = System.Drawing.ContentAlignment.TopRight;

			int dCount = offer.OfferDetails.Count;
			for (int i = 0; i < dCount; i++)
			{
				lastRow |= i == dCount - 1;

				table.Cell[colPos].Value = offer.OfferDetails[i].Position;
				table.Cell[colArtNr].Value = offer.OfferDetails[i].Artikelnummer;
				TextBox txtBezeichnung = table.Cell[colArtBez].CreateTextBox();
				txtBezeichnung.AddText(myFontBold, 9, offer.OfferDetails[i].Artikelname);
				if (!isOffer) txtBezeichnung.AddText(fontDefault, 9, string.Format("\n\n{0}", offer.OfferDetails[i].Artikeltext.Replace("\t", " ")));
				table.Cell[colMenge].Value = string.Format("{0:#,##0} {1}", offer.OfferDetails[i].Menge, offer.OfferDetails[i].Einheit);

				if (!isOffer)
				{
					table.Cell[colPreis].Value = offer.OfferDetails[i].Kundenpreis;
					table.Cell[colGesamt].Value = offer.OfferDetails[i].Zeilensumme;
					zwischenSumme += offer.OfferDetails[i].Zeilensumme;
				}
				else
				{
					table.Cell[colPreis].Value = "-";
					table.Cell[colGesamt].Value = "-";
				}
				table.DrawRow(offer.OfferDetails[i].NeueSeite);
			}
			table.Close();

			try
			{
				doc.CreateFile();
				if (File.Exists(fullName) && withPreview)
				{
					// Datei in das lokale TEMP Verzeichnis kopieren
					var temp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
					string prefix = asOrder ? "B" : "A";
					var tempFilename = string.Format("{0}{1}.pdf", prefix, DateTime.Now.ToString("yyyy-MM-dd_hh.mm.ss"));
					var tempFileAndPath = Path.Combine(temp, tempFilename);
					File.Copy(fullName, tempFileAndPath);
					var proc = new Process();
					proc.StartInfo = new ProcessStartInfo(tempFileAndPath);
					proc.Start();
				}

				return new FileInfo(fullName);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void ResetVars()
		{
			pageNumber = 0;
			zwischenSumme = 0;
			lastRow = false;
			lastPosition = 0;
		}

		#endregion

		#region event handlers

		void tab_TableStartEvent(PdfTable Table, double TableStartPos)
		{
			pageNumber += 1;
			string aOrb = myOffer.Bestellkennzeichen ? "Bestellung " : "Angebot CPM, Nr. ";
			if (pageNumber > 1)
			{
				Table.Contents.DrawText(fontDefault, 8D, xLeftMargin, TableStartPos + 3, aOrb + myOffer.OfferId);
			}
			Table.Contents.DrawText(fontDefault, 8D, xPage, TableStartPos + 3, "Seite " + pageNumber);
		}

		void tab_TableEndEvent(PdfTable Table, double TableEndPos)
		{
			lastPosition = TableEndPos;
			if (!lastRow)
			{
				if (!myOffer.Bestellkennzeichen) DrawSubtotal(Table.Contents);
			}
			else
			{
				if (!myOffer.Bestellkennzeichen) DrawSummary(Table.Contents, myOffer);
			}
			DrawFooter(Table.Contents, fontFooter);
		}

		void DrawSubtotal(PdfContents content)
		{
			string betrag;
			content.DrawText(fontDefault, 10D, xSummary, lastPosition - 5, DrawStyle.Normal, "Zwischensumme:");
			betrag = string.Format("{0:N2}", zwischenSumme);
			content.DrawText(fontDefault, 10D, xRightMargin - 1, lastPosition - 5, TextJustify.Right, DrawStyle.Underline, System.Drawing.Color.Black, betrag);
		}

		#endregion

		#region private procedures

		void DrawSummary(PdfContents content, Offer offer)
		{
			content.SaveGraphicsState();

			// Textbox für Nettopreishinweis, Zahlungs- und Lieferbedingungen
			var livingInABox = new TextBox(125);
			var nl = Environment.NewLine;
			string nettopreise = "Alle angegebenen Preise in Euro, zuzüglich der gesetzlich gültigen Mehrwertsteuer.";
			livingInABox.AddText(fontDefault, 8.0, nettopreise + nl);
			livingInABox.AddText(fontDefault, 8.0, this.myOffer.Zahlungsbedingungen + nl);
			livingInABox.AddText(fontDefault, 8.0, this.myOffer.Customer.FocText);
			double yPosition = lastPosition - 4;
			content.DrawText(10.5, ref yPosition, 0.0, 0, 0.0, 1.2, TextBoxJustify.Left, livingInABox);

			string betrag;
			// Nettosumme
			content.DrawText(fontDefault, 10D, xSummary, lastPosition - 5, DrawStyle.Normal, "Summe (netto):");
			betrag = string.Format("{0:N2}", offer.NetAmount);
			content.DrawText(fontDefault, 10D, xRightMargin - 1, lastPosition - 5, TextJustify.Right, DrawStyle.Normal, System.Drawing.Color.Black, betrag);

			// USt.
			content.DrawText(fontDefault, 10D, xSummary, lastPosition - 9.2, DrawStyle.Normal, "USt. Betrag: (19%):");
			betrag = string.Format("{0:N2}", offer.TaxAmount);
			content.DrawText(fontDefault, 10D, xRightMargin - 1, lastPosition - 9.2, TextJustify.Right, DrawStyle.Normal, System.Drawing.Color.Black, betrag);

			// Angebotsbetrag
			content.DrawText(fontDefault, 10D, xSummary, lastPosition - 13.4, DrawStyle.Normal, "Angebotsbetrag:");
			betrag = string.Format("{0:N2}", offer.OfferTotal);
			content.DrawText(fontDefault, 10D, xRightMargin - 1, lastPosition - 13.4, TextJustify.Right, DrawStyle.Underline, System.Drawing.Color.Black, betrag);
			content.DrawText(fontDefault, 8D, xSummary, lastPosition - 17.6, TextJustify.Left, DrawStyle.Normal, System.Drawing.Color.DarkGray, "(Alle ausgewiesenen Beträge in Euro)");

			content.RestoreGraphicsState();
		}

		void DrawFooter(PdfContents content, PdfFont font)
		{
			content.SaveGraphicsState();
			// Persönlich haftende Gesellschafterin
			content.DrawText(this.myFontBold, 8, 5, 20.5, "Persönlich haftende Gesellschafterin");
			content.DrawText(font, 8, 5, 17, "Cut & Print Media GmbH & Co. KG");
			content.DrawText(font, 8, 5, 14, "Geschäftsführer: Felix Deutz");
			content.DrawText(font, 8, 5, 11, "USt.-ID: DE 814 912 333");
			content.DrawText(font, 8, 5, 8, "HRA 200901");
			content.DrawText(font, 8, 5, 5, "http://www.cut-print.de");

			// Handelsregister
			content.DrawText(this.myFontBold, 8, xFTab1, 20.5, "Handelsregister");
			content.DrawText(font, 8, xFTab1, 17, "Amtsgericht Osnabrück");
			content.DrawText(font, 8, xFTab1, 14, "HRB 201534");
			content.DrawText(font, 8, xFTab1, 11, "St-Nr.: 65/207/16220");

			// Bankverbindung
			content.DrawText(this.myFontBold, 8, xFTab2, 20.5, "Bankverbindung");
			content.DrawText(font, 8, xFTab2, 17, "Volksbank Georgsmarienhütte");
			content.DrawText(font, 8, xFTab2, 14, "BLZ: 265 659 28");
			content.DrawText(font, 8, xFTab2, 11, "Konto: 500 5555 000");
			content.DrawText(font, 8, xFTab2, 8, "IBAN: DE06 265 659 28 500 5555 000");
			content.DrawText(font, 8, xFTab2, 5, "SWIFT Code: GENODEF1HGM");

			// AGB
			content.DrawText(this.myFontBold, 8, xFTab3, 20.5, "AGB");
			content.DrawText(font, 8, xFTab3, 17, "Für alle unsere Angebote, Kaufverträge");
			content.DrawText(font, 8, xFTab3, 14, "und rechtsgeschäftlichen Erklärungen");
			content.DrawText(font, 8, xFTab3, 11, "gelten unsere allgemeinen");
			content.DrawText(font, 8, xFTab3, 8, "Geschäftsbedingungen");
		}

		#endregion

	}
}
