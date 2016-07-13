/////////////////////////////////////////////////////////////////////
//
//	TestPdfFileWriter
//	Test/demo program for PdfFileWrite C# Class Library.
//
//	TableExample
//	Produce PDF file when the Table Example is clicked.
//
//	Granotech Limited
//	Author: Uzi Granot
//	Version: 1.0
//	Date: April 1, 2013
//	Copyright (C) 2013-2015 Granotech Limited. All Rights Reserved
//
//	PdfFileWriter C# class library and TestPdfFileWriter test/demo
//  application are free software.
//	They is distributed under the Code Project Open License (CPOL).
//	The document PdfFileWriterReadmeAndLicense.pdf contained within
//	the distribution specify the license agreement and other
//	conditions and notes. You must read this document and agree
//	with the conditions specified in order to use this software.
//
//	For version history please refer to PdfDocument.cs
//
/////////////////////////////////////////////////////////////////////

using PdfFileWriter;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace TestPdfFileWriter
{
public class TableExample
	{
	private PdfDocument		Document;
	private PdfPage			Page;
	private PdfContents		Contents;
	private PdfFont			NormalFont;
	private PdfFont			TableTitleFont;

	////////////////////////////////////////////////////////////////////
	// Create data table examples PDF document
	////////////////////////////////////////////////////////////////////
	
	public void Test
			(
			Boolean Debug,
			String	FileName
			)
		{
		// Create empty document
		// Arguments: page width: 8.5”, page height: 11”, Unit of measure: inches
		// Return value: PdfDocument main class
		Document = new PdfDocument(PaperType.Letter, false, UnitOfMeasure.Inch, FileName);

		// Debug property
		// By default it is set to false. Use it for debugging only.
		// If this flag is set, PDF objects will not be compressed, font and images will be replaced
		// by text place holder. You can view the file with a text editor but you cannot open it with PDF reader.
		Document.Debug = Debug;

		// define font resource
		NormalFont = new PdfFont(Document, "Arial", FontStyle.Regular, true);
		TableTitleFont = new PdfFont(Document, "Times New Roman", FontStyle.Bold, true);

		// stock price table
		CreateStockTable();

		// book list table
		CreateBookList();

		// argument: PDF file name
		Document.CreateFile();

		// start default PDF reader and display the file
		Process Proc = new Process();
	    Proc.StartInfo = new ProcessStartInfo(FileName);
	    Proc.Start();

		// exit
		return;
		}

	////////////////////////////////////////////////////////////////////
	// Create charting examples PDF document
	////////////////////////////////////////////////////////////////////
	
	public void CreateStockTable()
		{
		const Int32 ColDate = 0;
		const Int32 ColOpen = 1;
		const Int32 ColHigh = 2;
		const Int32 ColLow = 3;
		const Int32 ColClose = 4;
		const Int32 ColVolume = 5;

		// Add new page
		Page = new PdfPage(Document);

		// Add contents to page
		Contents = new PdfContents(Page);

		// create stock table
		PdfTable StockTable = new PdfTable(Page, Contents, NormalFont, 9.0);

		// divide columns width in proportion to following values
		StockTable.SetColumnWidth(1.2, 1.0, 1.0, 1.0, 1.0, 1.2);

		// set all borders
		StockTable.Borders.SetAllBorders(0.012, Color.DarkGray, 0.0025, Color.DarkGray);
//		StockTable.Borders.SetFrame(0.02, Color.DarkGray);
//		for(Int32 Index = 1; Index < 6; Index++) StockTable.Borders.SetHeaderVertBorder(Index, 0.06, Color.DarkBlue);
//		StockTable.Borders.SetCellVertBorder(1, 0.04, Color.DarkGreen);
//		StockTable.Borders.SetCellVertBorder(5, 0.04, Color.DarkRed);


		// make some changes to default header style
		StockTable.DefaultHeaderStyle.Alignment = ContentAlignment.BottomRight;

		// create private style for header first column
		StockTable.Header[ColDate].Style = StockTable.HeaderStyle;
		StockTable.Header[ColDate].Style.Alignment = ContentAlignment.MiddleLeft;

		StockTable.Header[ColDate].Value = "Date";
		StockTable.Header[ColOpen].Value = "Open";
		StockTable.Header[ColHigh].Value = "High";
		StockTable.Header[ColLow].Value = "Low";
		StockTable.Header[ColClose].Value = "Close";
		StockTable.Header[ColVolume].Value = "Volume";

		// make some changes to default cell style
		StockTable.DefaultCellStyle.Alignment = ContentAlignment.MiddleRight;
		StockTable.DefaultCellStyle.Format = "#,##0.00";

		// create private style for date column
		StockTable.Cell[ColDate].Style = StockTable.CellStyle;
		StockTable.Cell[ColDate].Style.Alignment = ContentAlignment.MiddleLeft;
		StockTable.Cell[ColDate].Style.Format = null;

		// create private styles for volumn column
		PdfTableStyle GoingUpStyle = StockTable.CellStyle;
		GoingUpStyle.BackgroundColor = Color.LightGreen;
		GoingUpStyle.Format = "#,##0";
		PdfTableStyle GoingDownStyle = StockTable.CellStyle;
		GoingDownStyle.BackgroundColor = Color.LightPink;
		GoingDownStyle.Format = "#,##0";

		// open stock daily price
		// takem from Yahoo Financial
		StreamReader Reader = new StreamReader("SP500.csv");

		// ignore header
		Reader.ReadLine();

		// read all daily prices
		for(;;)
			{
			String TextLine = Reader.ReadLine();
			if(TextLine == null) break;

			String[] Fld = TextLine.Split(new Char[] {','});

			StockTable.Cell[ColDate].Value = Fld[ColDate];
			StockTable.Cell[ColOpen].Value = Double.Parse(Fld[ColOpen], NFI.PeriodDecSep);
			StockTable.Cell[ColHigh].Value = Double.Parse(Fld[ColHigh], NFI.PeriodDecSep);
			StockTable.Cell[ColLow].Value = Double.Parse(Fld[ColLow], NFI.PeriodDecSep);
			StockTable.Cell[ColClose].Value = Double.Parse(Fld[ColClose], NFI.PeriodDecSep);
			StockTable.Cell[ColVolume].Value = Int32.Parse(Fld[ColVolume]);
			StockTable.Cell[ColVolume].Style = (Double) StockTable.Cell[ColClose].Value >= (Double) StockTable.Cell[ColOpen].Value ? GoingUpStyle : GoingDownStyle;
			StockTable.DrawRow();
			}

		StockTable.Close();

		// exit
		return;
		}

	////////////////////////////////////////////////////////////////////
	// Create charting examples PDF document
	////////////////////////////////////////////////////////////////////
	
	public void CreateBookList()
		{
		// Add new page
		Page = new PdfPage(Document);

		// Add contents to page
		Contents = new PdfContents(Page);

		PdfFont TitleFont = new PdfFont(Document, "Verdana", FontStyle.Bold);
		PdfFont AuthorFont = new PdfFont(Document, "Verdana", FontStyle.Italic);

		// create stock table
		PdfTable BookList = new PdfTable(Page, Contents, NormalFont, 9.0);

		// divide columns width in proportion to following values
		BookList.SetColumnWidth(1.0, 2.5, 1.2, 1.0, 0.5, 0.6, 1.2);

		// event handlers
		BookList.TableStartEvent += BookListTableStart;
		BookList.TableEndEvent += BookListTableEnd;

		// set display header at the top of each additional page
		BookList.HeaderOnEachPage = true;

		// headers
		BookList.Header[0].Value = "Book Cover";
		BookList.Header[1].Value = "Book Title and Authors";
		BookList.Header[2].Value = "Date\nPublished";
		BookList.Header[3].Value = "Type";
		BookList.Header[4].Value = "In\nStock";
		BookList.Header[5].Value = "Price";
		BookList.Header[6].Value = "Weblink";

		// make some changes to default header style
		BookList.DefaultHeaderStyle.Alignment = ContentAlignment.MiddleCenter;
		BookList.DefaultHeaderStyle.MultiLineText = true;
		BookList.DefaultHeaderStyle.TextBoxTextJustify = TextBoxJustify.Center;

		// default cell style
		BookList.DefaultCellStyle.Alignment = ContentAlignment.MiddleCenter;

		// create private style for in stock column
		BookList.Cell[4].Style= BookList.CellStyle;
		BookList.Cell[4].Style.Format = "#,##0";
		BookList.Cell[4].Style.Alignment = ContentAlignment.MiddleRight;
	
		// create private style for price column
		BookList.Cell[5].Style = BookList.CellStyle;
		BookList.Cell[5].Style.Format = "#,##0.00";
		BookList.Cell[5].Style.Alignment = ContentAlignment.MiddleRight;

		// book list text file
		StreamReader Reader = new StreamReader("BookList.txt");

		// loop for records
		for(;;)
			{
			// read one line
			String TextLine = Reader.ReadLine();
			if(TextLine == null) break;

			// split to fields (must be 8 fields)
			String[] Fld = TextLine.Split(new Char[] {'\t'});
			if(Fld.Length != 8) continue;

			// book cover
			BookList.Cell[0].Value = new PdfImage(Document, Fld[6]);

			// note create text box set Value field
			TextBox Box = BookList.Cell[1].CreateTextBox();
			Box.AddText(TitleFont, 10.0, Color.DarkBlue, Fld[0]);
			Box.AddText(NormalFont, 8.0, Color.Black, ", Author(s): ");
			Box.AddText(AuthorFont, 9.0, Color.DarkRed, Fld[2]);

			// date, type in-stock and price
			BookList.Cell[2].Value = Fld[1];
			BookList.Cell[3].Value = Fld[3];
			BookList.Cell[4].Value = Int32.Parse(Fld[5]);
			BookList.Cell[5].Value = Double.Parse(Fld[4], NFI.PeriodDecSep);

			// QRCode and web link
			BookList.Cell[6].Value = new PdfQRCode(Document, Fld[7], ErrorCorrection.M);
//			BarcodeEAN13 Barcode1 = new BarcodeEAN13("1234567890128");
//			BookList.Cell[6].Value = Barcode1;
//			BookList.Cell[6].Style.BarcodeBarWidth = 0.01;
//			BookList.Cell[6].Style.BarcodeHeight = 0.5;
			BookList.Cell[6].WebLink = Fld[7];

			// draw it
			BookList.DrawRow();
			}

		// close book list
		BookList.Close();

		// exit
		return;
		}

	void BookListTableStart
			(
			PdfTable	BookList,
			Double		TableStartPos
			)
		{
		Double PosX = 0.5 * (BookList.TableArea.Left + BookList.TableArea.Right);
		Double PosY = TableStartPos + TableTitleFont.Descent(16.0) + 0.05;
		BookList.Contents.DrawText(TableTitleFont, 16.0, PosX, PosY, TextJustify.Center, DrawStyle.Normal, Color.Chocolate, "Book List PdfTable Example"); 
		return;
		}

	void BookListTableEnd
			(
			PdfTable	BookList,
			Double		TableEndPos
			)
		{
		Double PosX = BookList.TableArea.Left;
		Double PosY = TableEndPos - TableTitleFont.Ascent(12.0) - 0.05;
		BookList.Contents.DrawText(TableTitleFont, 12.0, PosX, PosY, TextJustify.Left, DrawStyle.Normal, Color.Chocolate, "Either scan the Web link or click the area for more info."); 
		return;
		}
	}
}
