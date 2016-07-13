namespace Products.Common.Views
{
	partial class MetroForm1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
			Syncfusion.Windows.Forms.CaptionImage captionImage2 = new Syncfusion.Windows.Forms.CaptionImage();
			Syncfusion.Windows.Forms.CaptionImage captionImage3 = new Syncfusion.Windows.Forms.CaptionImage();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroForm1));
			this.SuspendLayout();
			// 
			// MetroForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
			this.BorderThickness = 2;
			this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
			this.CaptionBarHeight = 74;
			this.CaptionButtonColor = System.Drawing.Color.Black;
			this.CaptionButtonHoverColor = System.Drawing.Color.White;
			this.CaptionFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			captionImage1.BackColor = System.Drawing.Color.Transparent;
			captionImage1.Image = global::Products.Common.Properties.Resources.close;
			captionImage1.Location = new System.Drawing.Point(760, 3);
			captionImage1.Name = "imgClose";
			captionImage1.Size = new System.Drawing.Size(32, 32);
			captionImage2.BackColor = System.Drawing.Color.Transparent;
			captionImage2.Image = global::Products.Common.Properties.Resources.maximize;
			captionImage2.Location = new System.Drawing.Point(720, 3);
			captionImage2.Name = "imgMaxRestore";
			captionImage2.Size = new System.Drawing.Size(32, 32);
			captionImage3.BackColor = System.Drawing.Color.Transparent;
			captionImage3.Image = global::Products.Common.Properties.Resources.minimize;
			captionImage3.Location = new System.Drawing.Point(680, 3);
			captionImage3.Name = "imgMinimize";
			captionImage3.Size = new System.Drawing.Size(32, 32);
			this.CaptionImages.Add(captionImage1);
			this.CaptionImages.Add(captionImage2);
			this.CaptionImages.Add(captionImage3);
			this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Top;
			this.ClientSize = new System.Drawing.Size(788, 475);
			this.ControlBox = false;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
			this.Name = "MetroForm1";
			this.ShowMaximizeBox = false;
			this.ShowMinimizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Termin für Service-Auftrag";
			this.SizeChanged += new System.EventHandler(this.ServiceterminView_SizeChanged);
			this.ResumeLayout(false);

		}

		#endregion
	}
}