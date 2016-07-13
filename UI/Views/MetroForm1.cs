using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Products.Common.Views
{
	public partial class MetroForm1 : MetroForm
	{

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der MetroForm1 Klasse.
		/// </summary>
		public MetroForm1()
		{
			InitializeComponent();

			foreach (CaptionImage img in this.CaptionImages)
			{
				switch (img.Name)
				{
					case "imgClose":
						img.Location = new System.Drawing.Point(this.Width - 40, 3);
						break;

					case "imgMaxRestore":
						img.Location = new System.Drawing.Point(this.Width - 80, 3);
						break;

					case "imgMinimize":
						img.Location = new System.Drawing.Point(this.Width - 120, 3);
						break;

					default:
						break;
				}
				img.ImageMouseEnter += new CaptionImage.MouseEnter(img_ImageMouseEnter);
				img.ImageMouseLeave += new CaptionImage.MouseLeave(img_ImageMouseLeave);
				img.ImageMouseUp += new CaptionImage.MouseUp(img_ImageMouseUp);
			}
		}

		void img_ImageMouseUp(object sender, ImageMouseUpEventArgs e)
		{
			if ((sender as CaptionImage).Name == "imgMinimize")
			{
				this.WindowState = FormWindowState.Minimized;
			}
			else if ((sender as CaptionImage).Name == "imgMaxRestore")
			{
				if (this.WindowState == FormWindowState.Maximized)
				{
					this.WindowState = FormWindowState.Normal;
					(sender as CaptionImage).Image = Properties.Resources.maximize;
					(sender as CaptionImage).BackColor = System.Drawing.Color.FromArgb(199, 227, 116);
				}
				else
				{
					this.WindowState = FormWindowState.Maximized;
					(sender as CaptionImage).Image = Properties.Resources.restore;
					(sender as CaptionImage).BackColor = System.Drawing.Color.FromArgb(199, 227, 116);
				}
			}
			else if ((sender as CaptionImage).Name == "imgClose")
			{
				this.Close();
			}
		}

		void img_ImageMouseLeave(object sender, ImageMouseLeaveEventArgs e)
		{
			e.BackColor = System.Drawing.Color.Transparent;
		}

		void img_ImageMouseEnter(object sender, ImageMouseEnterEventArgs e)
		{
			e.BackColor = System.Drawing.Color.FromArgb(199, 227, 116);
		}

		#endregion

		#region event handler

		private void ServiceterminView_SizeChanged(object sender, EventArgs e)
		{
			int x = this.Width;
			CaptionImages.FindByName("imgClose").Location = new System.Drawing.Point(x - 40, 3);
			CaptionImages.FindByName("imgMaxRestore").Location = new System.Drawing.Point(x - 80, 3);
			CaptionImages.FindByName("imgMinimize").Location = new System.Drawing.Point(x - 120, 3);
		}

		#endregion

	}
}
