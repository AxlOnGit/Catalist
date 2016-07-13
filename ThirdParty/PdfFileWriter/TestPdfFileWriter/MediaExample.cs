using PdfFileWriter;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace TestPdfFileWriter
{
public class MediaExample
	{
	private	PdfDocument Document;
	private	PdfPage		Page;
	private PdfFont		ArialNormal;
	private PdfFont		Comic;

	////////////////////////////////////////////////////////////////////
	// Create charting examples PDF document
	////////////////////////////////////////////////////////////////////
	
	public void Test
			(
			Boolean Debug,
			String	FileName
			)
		{
		// Step 1: Create empty document
		// Arguments: page width: 8.5”, page height: 11”, Unit of measure: inches
		// Return value: PdfDocument main class
		Document = new PdfDocument(PaperType.Letter, false, UnitOfMeasure.Inch, FileName);

		// Debug property
		// By default it is set to false. Use it for debugging only.
		// If this flag is set, PDF objects will not be compressed, font and images will be replaced
		// by text place holder. You can view the file with a text editor but you cannot open it with PDF reader.
		Document.Debug = Debug;

		// for encryption test
//		Document.SetEncryption("Password", Permission.All & ~Permission.Print);

		ArialNormal = new PdfFont(Document, "Arial", FontStyle.Regular, true);
		Comic = new PdfFont(Document, "Comic Sans MS", FontStyle.Bold, true);

		// Step 3: Add new page
		Page = new PdfPage(Document);

		// Step 4:Add contents to page
		PdfContents Contents = new PdfContents(Page);

		// save graphics state
		Contents.SaveGraphicsState();

		// Draw frame around the page
		// Set line width to 0.02"
		Contents.SetLineWidth(0.02);

		// set frame color dark blue
		Contents.SetColorStroking(Color.DarkBlue);
		Contents.SetColorNonStroking(Color.FromArgb(240, 250, 250));

		// rectangle position: x=1.0", y=1.0", width=6.5", height=9.0"
		Contents.DrawRectangle(1.0, 1.0, 6.5, 9.0, PaintOp.CloseFillStroke);
		Contents.DrawLine(1.0, 8.5, 7.5, 8.5);
		Contents.DrawLine(1.0, 6.0, 7.5, 6.0);
		Contents.DrawLine(1.0, 3.5, 7.5, 3.5);

		// page heading
		Contents.DrawText(Comic, 40.0, 4.25, 9.25, TextJustify.Center, 0.02, Color.FromArgb(128, 0, 255), Color.FromArgb(255, 0, 128), "PDF FILE WRITER");

		// change nonstroking (fill) color to purple
		Contents.SetColorNonStroking(Color.Purple);

		// Draw second line of heading text
		// arguments: Handwriting font, Font size 30 point, Position X=4.25", Y=9.0"
		// Text Justify: Center (text center will be at X position)
		Contents.DrawText(Comic, 30.0, 4.25, 8.75, TextJustify.Center, "Media Example");

		// create embedded media file
		Example1();
		Example2();

		// restore graphics sate (non stroking color will be restored to default)
		Contents.RestoreGraphicsState();

		// create the PDF file
		Document.CreateFile();

		// start default PDF reader and display the file
		Process Proc = new Process();
	    Proc.StartInfo = new ProcessStartInfo(FileName);
	    Proc.Start();

		// exit
		return;
		}

	private void Example1()
		{
		// create embedded media file
		PdfEmbeddedFile LooneyTunes = new PdfEmbeddedFile(Document, "LooneyTunes.mp4");

		PdfDisplayMedia DisplayMedia = new PdfDisplayMedia(LooneyTunes);

		PdfRectangle AnnotRect = ImageSizePos.ImageArea(480, 360, new PdfRectangle(1.2, 6.2, 7.3, 8.3), ContentAlignment.MiddleRight);

		// create PdfObject for annotation
		PdfAnnotation Annotation = new PdfAnnotation(Page, AnnotRect, DisplayMedia);

		Annotation.ActivateActionWhenPageIsVisible(false);

		return;
		}

	private void Example2()
		{
		// create embedded media file
		PdfEmbeddedFile EmbeddedMediaFile = new PdfEmbeddedFile(Document, "Ring01.wav");

		PdfDisplayMedia DisplayMedia = new PdfDisplayMedia(EmbeddedMediaFile);
		//DisplayMedia.SetMediaWindow(MediaWindow.Hidden);

		PdfRectangle AnnotRect = new PdfRectangle(5.2, 3.7, 7.3, 5.8);

		// create PdfObject for annotation
		PdfAnnotation Annotation = new PdfAnnotation(Page, AnnotRect, DisplayMedia);

		PdfXObject Normal = AnnotationArea(AnnotRect.Width, AnnotRect.Height, Color.Lavender, Color.Indigo, "Normal");
		PdfXObject RollOver = AnnotationArea(AnnotRect.Width, AnnotRect.Height, Color.Yellow, Color.Brown, "RollOver");
		PdfXObject Down = AnnotationArea(AnnotRect.Width, AnnotRect.Height, Color.LightPink, Color.DarkRed, "Down");
		Annotation.Appearance(Normal, RollOver, Down);
		return;
		}

	private PdfXObject AnnotationArea
			(
			Double		Width,
			Double		Height,
			Color		FillColor,
			Color		BorderColor,
			String		Text
			)
		{
		PdfXObject XObject = new PdfXObject(Document, Width, Height);
		XObject.SaveGraphicsState();
		XObject.SetColorNonStroking(FillColor);
		XObject.SetColorStroking(BorderColor);
		XObject.DrawRectangle(0.02 * Width, 0.02 * Height, 0.96 * Width, 0.96 * Height, PaintOp.CloseFillStroke);
		XObject.SetColorNonStroking(BorderColor);
		XObject.DrawText(ArialNormal, 14.0, 0.5 * Width, 0.5 * Height, TextJustify.Center, Text);
		XObject.RestoreGraphicsState();
		return(XObject);
		}

	private void Benny()
		{
		// create embedded media file
		PdfEmbeddedFile EmbeddedMediaFile = new PdfEmbeddedFile(Document, "Benny.mov");

		// Section 8.5 page 669 table 8.64
		PdfDisplayMedia DisplayMedia = new PdfDisplayMedia(EmbeddedMediaFile);

		// repeat count (zero is play indefinitly)
		DisplayMedia.RepeatCount(0);

		PdfRectangle AnnotRect = ImageSizePos.ImageArea(1920, 1080, 1.5, 2.0, 5.5, 7.0, ContentAlignment.TopLeft);

		// create PdfObject for annotation
		PdfAnnotation Annotation = new PdfAnnotation(Page, AnnotRect, DisplayMedia);
		return;
		}

	private void DogAndCat()
		{
		// create embedded media file
		PdfEmbeddedFile EmbeddedMediaFile = new PdfEmbeddedFile(Document, "BugsBunny.mp4");

		// Section 8.5 page 669 table 8.64
		PdfDisplayMedia DisplayMedia = new PdfDisplayMedia(EmbeddedMediaFile);

		// display media options
		DisplayMedia.DisplayControls(true);

		// repeat count (zero is play indefinitly)
		DisplayMedia.RepeatCount(1);

//		DisplayMedia.SetMediaWindow(MediaWindow.Floating, 480, 270, WindowPosition.UpperLeft, WindowTitleBar.TitleBarWithCloseButton, WindowResize.KeepAspectRatio, "User video title");

		PdfRectangle AnnotRect = ImageSizePos.ImageArea(160, 120, 1.5, 2.0, 5.5, 7.0, ContentAlignment.TopLeft);

		// create PdfObject for annotation
		PdfAnnotation Annotation = new PdfAnnotation(Page, AnnotRect, DisplayMedia);

		PdfXObject NormalAppearance = new PdfXObject(Document, AnnotRect.Width, AnnotRect.Height);
		NormalAppearance.SaveGraphicsState();
		NormalAppearance.SetColorNonStroking(Color.CornflowerBlue);
		NormalAppearance.SetColorStroking(Color.DarkGoldenrod);
		NormalAppearance.DrawOval(0.0, 0.0, AnnotRect.Width, AnnotRect.Height, PaintOp.CloseFillStroke);
		NormalAppearance.RestoreGraphicsState();
		Annotation.Appearance(NormalAppearance);

		Annotation.ActivateActionWhenPageIsVisible(false);

		return;
		}

	}
}

