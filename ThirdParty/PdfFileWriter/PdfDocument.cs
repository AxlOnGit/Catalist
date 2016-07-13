﻿/////////////////////////////////////////////////////////////////////
//
//	PdfFileWriter
//	PDF File Write C# Class Library.
//
//	PdfDocument
//	The main class of PDF object.
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
//	Version History:
//
//	Version 1.0 2013/04/01
//		Original revision
//	Version 1.1 2013/04/09
//		Allow program to be compiled in regions that define
//		decimal separator to be non period (comma)
//	Version 1.2 2013/07/21
//		The original revision supported image resources with
//		jpeg file format only.
//		Version 1.2 support all image files acceptable to Bitmap class.
//		See ImageFormat class. The program was tested with:
//		Bmp, Gif, Icon, Jpeg, Png and Tiff.
//	Version 1.3 2014/02/07
//		Fix bug in PdfContents.DrawBezierNoP2(PointD P1, PointD P3)
//	Version 1.4 2014/03/01
//		PdfContents
//		Add method: public void TranslateScaleRotate(Double OrigX,
//			Double OrigY, Double ScaleX, Double ScaleY, Double Rotate);
//		Add method: public String ReverseString(Strint Text);
//		Fix some problems with DrawXObject(...); methods
//		PdfFont
//		Extensive changes to font substitution (see article)
//		PdfImage
//		Add method: public SizeD ImageSizeAndDensity(Double Width,
//			Double Height, Double Density);
//		This method controls the size of the bitmap (see article)
//		Add method: public void SetImageQuality(Int32 ImageQuality);
//		This method controls the image quality (see article)
//		PdfTilingPattern
//		Fix bug in public static PdfTilingPattern SetWeavePattern(...);
//	Version 1.5 2014/05/05
//		Add barcode feature. Supported barcodes are:
//		Code-128, Code39, UPC-A, EAN-13
//	Version 1.6 2014/07/09
//		Fix FontApi unanaged code resource disposition.
//		Clear PdfDocument object after CreateFile.
//	Version 1.7 2014/08/25
//		Add encryption support
//		Add Web link support
//		Add QRCode support
//		Change compression to .net System.io.compression
//	Version 1.8 2014/09/12
//		Add bookmark (document outline) support
//	Version 1.9 2014/10/06
//		New features
//		Support for Microsoft Charting
//		Support for Metafile images
//		Support for image cropping
//		Support for PrintDocument output to PDF file
//		Fixs
//		Font loading. Fix the problem of missing table.
//	Version 1.9.1 2014/10/12
//		Fix decimal separator problem in regions that define
//		decimal separator to be non period (comma) in the
//		ChartExample.cs code
//	Version 1.10.0 2014/12/02
//		Add support for data tables. Add source code documentation.
//		Increase maximum number of images per document.
//	Version 1.11.0 2015/01/19
//		Add support for video, sound and attached files.
//	Version 1.12.0 2015/04/13
//		Page order control.
//		Rewrite of table borders and grid lines.
//
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;

namespace PdfFileWriter
{
/////////////////////////////////////////////////////////////////////
/// <summary>
/// Unit of measure enumeration
/// </summary>
/// <remarks>
/// User unit of measure enumeration.
/// </remarks>
/////////////////////////////////////////////////////////////////////
public enum UnitOfMeasure
	{
	/// <summary>
	/// Point
	/// </summary>
	Point,

	/// <summary>
	/// Inch
	/// </summary>
	Inch,

	/// <summary>
	/// CM
	/// </summary>
	cm,

	/// <summary>
	/// MM
	/// </summary>
	mm,
	}

/////////////////////////////////////////////////////////////////////
/// <summary>
/// Standard paper size enumeration 
/// </summary>
/////////////////////////////////////////////////////////////////////
public enum PaperType
	{
	/// <summary>
	/// Letter
	/// </summary>
	Letter,

	/// <summary>
	/// Legal
	/// </summary>
	Legal,

	/// <summary>
	/// A3
	/// </summary>
	A3,			// 297mm 420mm

	/// <summary>
	/// A4
	/// </summary>
	A4,			// 210mm 297mm

	/// <summary>
	/// A5
	/// </summary>
	A5,			// 148mm 210mm
	}

/////////////////////////////////////////////////////////////////////
/// <summary>
/// Number Format Information static class
/// </summary>
/// <remarks>
/// Adobe readers expect decimal separator to be a period.
/// Some countries define decimal separator as a comma.
/// The project uses NFI.DecSep to force period for all regions.
/// </remarks>
/////////////////////////////////////////////////////////////////////
public static class NFI
	{
	/// <summary>
	/// Define period as number decimal separator.
	/// </summary>
	/// <remarks>
	/// NumberFormatInfo is used with string formatting to set the
	/// decimal separator to a period regardless of region.
	/// </remarks>
	public static NumberFormatInfo PeriodDecSep {get; private set;}

	// static constructor
	static NFI()
		{
		// number format (decimal separator is period)
		PeriodDecSep = new NumberFormatInfo();
		PeriodDecSep.NumberDecimalSeparator = ".";
		return;
		}
	}

/////////////////////////////////////////////////////////////////////
/// <summary>
/// PDF document class
/// </summary>
/// <remarks>
/// <para>
/// The main class for controlling the production of the PDF document.
/// </para>
/// <para>
/// Creating a PDF is a six steps process.
/// </para>
/// <para>
/// Step 1: Create one document object this PdfDocument class.
/// </para>
/// <para>
/// Step 2: Create resource objects such as fonts or images (i.e. PdfFont or PdfImage).
/// </para>
/// <para>
/// Step 3: Create page object PdfPage.
/// </para>
/// <para>
/// Step 4: Create contents object PdfContents.
/// </para>
/// <para>
/// Step 5: Add text and graphics to the contents object (using PdfContents methods).
/// </para>
/// <para>
/// Repeat steps 3, 4 and 5 for additional pages
/// </para>
/// <para>
/// Step 6: Create your PDF document file by calling CreateFile method of PdfDocument.
/// </para>
/// <para>
/// <a href="http://www.codeproject.com/Articles/570682/PDF-File-Writer-Csharp-Class-Library-Version#DocumentCreation">For example of document creation see 3.1. Document Creation Overview</a>
/// </para>
/// </remarks>
/////////////////////////////////////////////////////////////////////
public class PdfDocument : IDisposable
	{
	/// <summary>
	/// Library revision number
	/// </summary>
	public static readonly String RevisionNumber = "1.12.0";

	/// <summary>
	/// Library revision date
	/// </summary>
	public static readonly String RevisionDate = "2015/04/13";

	/// <summary>
	/// Scale factor
	/// </summary>
	/// <remarks>
	/// From user unit of measure to points.
	/// </remarks>
	public Double ScaleFactor {get; internal set;}

	/// <summary>
	/// Page count
	/// </summary>
	/// <remarks>
	/// Current page count
	/// </remarks>
	public Int32 PageCount
		{
		get
			{
			return(PageArray.Count);
			}
		}

	/// <summary>
	/// Get page object
	/// </summary>
	/// <param name="Index">Page index (zero based)</param>
	/// <returns>PdfPage object</returns>
	public PdfPage GetPage
			(
			Int32	Index
			)
		{
		if(Index < 0 || Index >= PageArray.Count) throw new ApplicationException("GetPage invalid argument");
		return(PageArray[Index]);
		}

	internal	String			FileName;			// PDF document file name
	internal	PdfBinaryWriter PdfFile;			// PDF document file stream
	internal	SizeD			PageSize;			// in points
	internal	List<PdfObject>	ObjectArray = new List<PdfObject>(); // list of all PDF indirect objects for this document
	internal	List<PdfPage>	PageArray = new List<PdfPage>();
	internal 	PdfObject		CatalogObject;		// catalog object
	internal 	PdfObject		PagesObject;		// parent object of all pages
	internal	PdfEncryption	Encryption;			// encryption dictionary
	internal	PdfBookmark		BookmarksRoot;		// bookmarks (document outline) dictionary
	internal	Int32[]			ResCodeNo = new Int32[(Int32) ResCode.Length]; // resource code next number
	internal	Byte[]			DocumentID;			// document ID
	internal	List<PdfWebLink> WebLinkArray = new List<PdfWebLink>();	// list of web link objects

	/// <summary>
	/// Debug flag
	/// </summary>
	/// <remarks>
	/// Debug flag. Default is false. The program will generate normal PDF file.
	/// If debug flag is true, the library will not compress contents, will replace images and font file with text place holder.
	/// The generated file can be viewed with a text editor but cannot be loaded into PDF reader.
	/// </remarks>
	public Boolean Debug = false;

	// random number generator
	internal static RNGCryptoServiceProvider RandNumGen = new RNGCryptoServiceProvider();

	// translation of user units to points
	// must agree with UnitOfMeasure enumeration
	internal static Double[] UnitInPoints = new Double[]
		{
		1.0,			// Point
		72.0,			// Inch
		72.0 / 2.54,	// cm
		72.0 / 25.4,	// mm
		};

	// standard paper sizes (in points)
	// must agree with PaperType enumeration
	internal static SizeD[] PaperTypeSize = new SizeD[]
		{
		new SizeD(8.5 * 72, 11.0 * 72),					// letter
		new SizeD(8.5 * 72, 14.0 * 72),					// legal
		new SizeD(29.7 * 72 / 2.54, 42.0 * 72 / 2.54),	// A3
		new SizeD(21.0 * 72 / 2.54, 29.7 * 72 / 2.54),	// A4
		new SizeD(14.8 * 72 / 2.54, 21.0 * 72 / 2.54),	// A5
		};

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// PDF document constructor.
	/// </summary>
	/// <param name="FileName">Document file name.</param>
	/// <remarks>
	/// This constructor generates a document with default letter size
	/// page (height 11”, width 8.5”). Page orientation is portrait.
	/// Unit of measure is points (1/72 inch). Scale factor is 1.0.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public PdfDocument
			(
			String	FileName
			)
		{
		// constructor helper
		ConstructorHelper(8.5 * 72.0, 11.0 * 72.0, 1.0, FileName);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// PDF document constructor.
	/// </summary>
	/// <param name="Width">Page Width</param>
	/// <param name="Height">Page height</param>
	/// <param name="ScaleFactor">Scale factor</param>
	/// <param name="FileName">Document file name.</param>
	/// <remarks>
	/// This constructor generates a document with default page size
	/// as per Width and Height arguments. The ScaleFactor determines
	/// the user units of measure. It is the number of points in one
	/// user unit. For example, if user unit of measure is inch, the scale
	/// factor is 72.0. If height is greater than width the default page
	/// orientation is portrait. Otherwise it is landscape.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public PdfDocument
			(
			Double		Width,			// page width
			Double		Height,			// page height
			Double		ScaleFactor,	// scale factor from user units to points (i.e. 72.0 for inch)
			String		FileName
			)
		{
		// constructor helper
		ConstructorHelper(ScaleFactor * Width, ScaleFactor * Height, ScaleFactor, FileName);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// PDF document constructor
	/// </summary>
	/// <param name="Width">Page width.</param>
	/// <param name="Height">Page height.</param>
	/// <param name="UnitOfMeasure">Unit of measure code.</param>
	/// <param name="FileName">Document file name.</param>
	/// <remarks>
	/// This constructor generates a document with default page size
	/// as per Width and Height arguments. The UnitOfMeasure code
	/// determines the ScaleFactor.	If height is greater than width 
	/// the default page orientation is portrait. Otherwise it is landscape.
	/// Unit of measure code is: Point, Inch, cm or mm.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public PdfDocument
			(
			Double			Width,			// page width
			Double			Height,			// page height
			UnitOfMeasure	UnitOfMeasure,	// unit of measure: Point, Inch, cm, mm
			String			FileName
			)
		{
		// constructor helper
		Double Scale = UnitInPoints[(Int32) UnitOfMeasure];
		ConstructorHelper(Scale * Width, Scale * Height, Scale, FileName);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// PDF document constructor
	/// </summary>
	/// <param name="PaperType">Paper type</param>
	/// <param name="Landscape">True for landscape, false for portrait.</param>
	/// <param name="UnitOfMeasure">Unit of measure code.</param>
	/// <param name="FileName">Document file name.</param>
	/// <remarks>
	/// Page type is Letter, Legal or A4.
	/// Page orientation is portrait or landscape.
	/// Unit of measure is: Point, Inch, cm, mm.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public PdfDocument
			(
			PaperType		PaperType,
			Boolean			Landscape,
			UnitOfMeasure	UnitOfMeasure,
			String			FileName
			)
		{
		// set scale factor (user units to points)
		Double Scale = UnitInPoints[(Int32) UnitOfMeasure];
		Double Width = PaperTypeSize[(Int32) PaperType].Width;
		Double Height = PaperTypeSize[(Int32) PaperType].Height;

		// for landscape swap width and height
		if(Landscape) ConstructorHelper(Height, Width, Scale, FileName);
		else ConstructorHelper(Width, Height, Scale, FileName);
		return;
		}

	////////////////////////////////////////////////////////////////////
	// Initial Object Array
	////////////////////////////////////////////////////////////////////

	private void ConstructorHelper
			(
			Double		Width,			// page width
			Double		Height,			// page height
			Double		ScaleFactor,	// scale factor from user units to points (i.e. 72.0 for inch)
			String		FileName
			)
		{
		// set scale factor (user units to points)
		this.ScaleFactor = ScaleFactor;

		// save page default size
		PageSize = new SizeD(Width, Height);

		// PDF document root object the Catalog object
		CatalogObject = new PdfObject(this, ObjectType.Dictionary, "/Catalog");

		// add viewer preferences
		CatalogObject.Dictionary.Add("/ViewerPreferences", "<</PrintScaling/None>>");

		// Parent object for all pages
		PagesObject = new PdfObject(this, ObjectType.Dictionary, "/Pages");

		// add indirect reference to pages within the catalog object
		CatalogObject.Dictionary.AddIndirectReference("/Pages", PagesObject);

		// document id
		DocumentID = RandomByteArray(16);

		// save file name
		this.FileName = FileName;

		// convert stream to binary writer
		PdfFile = new PdfBinaryWriter(new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None));

		// write PDF version number
		PdfFile.WriteString("%PDF-1.7\n");

		// add this comment to tell compression programs that this is a binary file
		PdfFile.WriteString("%\u00b5\u00b5\u00b5\u00b5\n");

		// exit
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Set encryption
	/// </summary>
	/// <remarks>
	/// The PDF File Writer library will encrypt the PDF document
	/// using AES-128 encryption.
	/// The PDF reader will open the document without requesting
	/// a password. Permissions flags are set to allow all.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public void SetEncryption()
		{
		SetEncryption(null, null, Permission.All);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Set encryption
	/// </summary>
	/// <param name="Permissions">Permission flags.</param>
	/// <remarks>
	/// The PDF File Writer library will encrypt the PDF document
	/// using AES-128 encryption.
	/// The PDF reader will open the document without requesting
	/// a password. Permissions will be set as per argument.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public void SetEncryption
			(
			Permission	Permissions
			)
		{
		SetEncryption(null, null, Permissions);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Set encryption
	/// </summary>
	/// <param name="UserPassword">User password</param>
	/// <param name="Permissions">Permission flags</param>
	/// <remarks>
	/// The PDF File Writer library will encrypt the PDF document
	/// using AES-128 encryption.
	/// The PDF reader will open the document with user password.
	/// Permissions will be set as per argument.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public void SetEncryption
			(
			String		UserPassword,
			Permission	Permissions
			)
		{
		SetEncryption(UserPassword, null, Permissions);
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Set encryption
	/// </summary>
	/// <param name="UserPassword">User password</param>
	/// <param name="OwnerPassword">Owner password</param>
	/// <param name="Permissions">Permission flags</param>
	/// <remarks>
	/// The PDF File Writer library will encrypt the PDF document
	/// using AES-128 encryption.
	/// The PDF reader will accept either user or owner passwords.
	/// If owner password is used to open document, the PDF reader
	/// will open it with all permissions set to allow operation.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public void SetEncryption
			(
			String		UserPassword,
			String		OwnerPassword,
			Permission	Permissions
			)
		{
		// encryption can be set only once
		if(Encryption != null) throw new ApplicationException("Encryption is already set");

		// create encryption dictionary object
		Encryption = new PdfEncryption(this, UserPassword, OwnerPassword, Permissions);

		// exit
		return;
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Gets bookmarks root
	/// </summary>
	/// <returns>Root bookmark object</returns>
	////////////////////////////////////////////////////////////////////
	public PdfBookmark GetBookmarksRoot()
		{
		// create bookmarks root node if this is the first time
		if(BookmarksRoot == null) BookmarksRoot = new PdfBookmark(this);

		// return bookmarks node to the user
		return(BookmarksRoot);
		}

	/// <summary>
	/// Move page to another position
	/// </summary>
	/// <param name="SourceIndex">Page's current position</param>
	/// <param name="DestinationIndex">Page's new position</param>
	public void MovePage
			(
			Int32	SourceIndex,
			Int32	DestinationIndex
			)
		{
		if(SourceIndex < 0 || SourceIndex >= PageCount || DestinationIndex < 0 || DestinationIndex > PageCount) throw new ApplicationException("Move page invalid argument");

		// there is only one page or no move
		if(DestinationIndex != SourceIndex && DestinationIndex != SourceIndex + 1)
			{
			PdfPage SourcePage = PageArray[SourceIndex];
			PageArray.RemoveAt(SourceIndex);
			if(DestinationIndex > SourceIndex) DestinationIndex--;
			PageArray.Insert(DestinationIndex, SourcePage);
			}
		return;		
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Create PDF document file
	/// </summary>
	/// <remarks>
	/// The last step of document creation after all pages were constructed.
	/// FileName is the path and name of the output file.
	/// </remarks>
	////////////////////////////////////////////////////////////////////
	public void CreateFile()
		{
		// create page array
		StringBuilder Kids = new StringBuilder("[");
		for(Int32 Index = 0; Index < PageArray.Count; Index++) Kids.AppendFormat("{0} 0 R ", PageArray[Index].ObjectNumber);
		if(Kids.Length > 1) Kids.Length--;
		Kids.Append("]");
		PagesObject.Dictionary.Add("/Kids", Kids.ToString());			

		// page count
		PagesObject.Dictionary.AddInteger("/Count", PageArray.Count);

		// objects
		for(Int32 Index = 0; Index < ObjectArray.Count; Index++) ObjectArray[Index].WriteObjectHeaderToPdfFile();

		// save cross reference table position
		Int32 XRefPos = (Int32) PdfFile.BaseStream.Position;

		// cross reference
		PdfFile.WriteFormat("xref\n0 {0}\n0000000000 65535 f \n", ObjectArray.Count + 1);
		foreach(PdfObject PO in ObjectArray) PdfFile.WriteFormat("{0:0000000000} 00000 n \n", PO.FilePosition);
	
		// trailer
		PdfFile.WriteFormat("trailer\n<</Size {0}/Root 1 0 R/ID [{1}{1}]{2}>>\nstartxref\n{3}\n",
			ObjectArray.Count + 1, ByteArrayToPdfHexString(DocumentID),
			Encryption == null ? String.Empty : String.Format("/Encrypt {0} 0 R", Encryption.ObjectNumber), XRefPos);

		// write PDF end of file marker
		PdfFile.WriteString("%%EOF\n");

		// close file
		PdfFile.Close();

		// dispose all FontApi resources
		foreach(PdfObject Obj in ObjectArray)
			{
			if(Obj.GetType() == typeof(PdfFont)) ((PdfFont) Obj).FontInfo.Dispose();
			}

		// dispose encryption resources
		if(Encryption != null)
			{
			Encryption.Dispose();
			Encryption = null;
			}

		// successful exit
		return;
		}

	////////////////////////////////////////////////////////////////////
	// Convert byte array to PDF string
	// used for document id and encryption
	////////////////////////////////////////////////////////////////////

	internal String ByteArrayToPdfHexString
			(
			Byte[]	ByteArray
			)
		{
		// convert to hex string
		StringBuilder HexText = new StringBuilder("<");
		for(Int32 index = 0; index < ByteArray.Length; index++) HexText.AppendFormat("{0:x2}", (Int32) ByteArray[index]);
		HexText.Append(">");
		return(HexText.ToString());
		}

	////////////////////////////////////////////////////////////////////
	// C# string text to PDF strings only
	////////////////////////////////////////////////////////////////////

	internal String TextToPdfString
			(
			String		Text,
			PdfObject	Parent
			)
		{
		// convert C# string to byte array
		Byte[] ByteArray = TextToByteArray(Text);

		// encryption is active. PDF string must be encrypted except for encryption dictionary
		if(Encryption != null && Encryption != Parent) ByteArray = Encryption.EncryptByteArray(Parent.ObjectNumber, ByteArray);

		// convert byte array to PDF string format
		return(ByteArrayToPdfString(ByteArray));
		}

	////////////////////////////////////////////////////////////////////
	// C# string text to byte array
	// This method is used for PDF strings only
	////////////////////////////////////////////////////////////////////

	internal Byte[] TextToByteArray
			(
			String		Text
			)
		{
		// scan input text for Unicode characters and for non printing characters
		Boolean Unicode = false;
		foreach(Char TestChar in Text) 
			{
			// test for non printable characters
			if(TestChar < ' ' || TestChar > '~' && TestChar < 160) throw new ApplicationException("Text string must be made of printable characters");

			// test for Unicode string
			if(TestChar > 255) Unicode = true;
			}

		// declare output byte array
		Byte[] ByteArray = null;

		// all characters are one byte long
		if(!Unicode)
			{
			// save each imput character in one byte
			ByteArray = new Byte[Text.Length];
			Int32 Index = 0;
			foreach(Char TestChar in Text) ByteArray[Index++] = (Byte) TestChar;
			}

		// Unicode case. we have some two bytes characters
		else
			{
			// allocate output byte array
			ByteArray = new Byte[2 * Text.Length + 2];

			// add Unicode marker at the start of the string
			ByteArray[0] = 0xfe;
			ByteArray[1] = 0xff;

			// save each character as two bytes
			Int32 Index = 2;
			foreach(Char TestChar in Text)
				{
				ByteArray[Index++] = (Byte) (TestChar >> 8);
				ByteArray[Index++] = (Byte) TestChar;
				}
			}

		// return output byte array
		return(ByteArray);
		}

	////////////////////////////////////////////////////////////////////
	// Byte array to PDF String
	// This method is used for PDF strings only
	////////////////////////////////////////////////////////////////////

	internal String ByteArrayToPdfString
			(
			Byte[]	ByteArray
			)
		{
		// create output string with open and closing parenthesis
		StringBuilder Str = new StringBuilder("(");
		foreach(Byte TestByte in ByteArray)
			{
			// CR and NL must be replaced by \r and \n
			// Otherwise PDF readers will convert CR or NL or CR-NL to NL
			if(TestByte == '\r') Str.Append("\\r");
			else if(TestByte == '\n') Str.Append("\\n");

			// the three characters \ ( ) must be preceded by \
			else
				{
				if(TestByte == (Byte) '\\' || TestByte == (Byte) '(' || TestByte == (Byte) ')') Str.Append('\\');	
				Str.Append((Char) TestByte);
				}
			}
		Str.Append(')');
		return(Str.ToString());
		}

	////////////////////////////////////////////////////////////////////
	// Create random byte array
	////////////////////////////////////////////////////////////////////

	internal static Byte[] RandomByteArray
			(
			Int32	Length
			)
		{
		Byte[] ByteArray = new Byte[Length];
		RandNumGen.GetBytes(ByteArray);
		return(ByteArray);
		}

	////////////////////////////////////////////////////////////////////
	// Generate unique resource number
	////////////////////////////////////////////////////////////////////

	internal String GenerateResourceNumber
			(
			Char	Code		// one letter code for each type of resource
			)
		{
		// create resource code
		return(String.Format("/{0}{1}", Code, ++ResCodeNo[PdfObject.ResCodeLetter.IndexOf(Code)]));
		}

	////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Dispose PDF document object
	/// </summary>
	////////////////////////////////////////////////////////////////////
	public void Dispose()
		{
		if(PdfFile != null) PdfFile.Close();
		return;
		}
	}
}
