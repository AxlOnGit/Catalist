namespace Products.Common.Views
{
	partial class AuswahlDialog
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
		void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuswahlDialog));
            this.PicBoxFragezeichen = new System.Windows.Forms.PictureBox();
            this.MLblTitel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFragezeichen)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxFragezeichen
            // 
            this.PicBoxFragezeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroyellow;
            this.PicBoxFragezeichen.InitialImage = global::Products.Common.Properties.Resources.frage_32_metrored;
            this.PicBoxFragezeichen.Location = new System.Drawing.Point(520, 20);
            this.PicBoxFragezeichen.Name = "PicBoxFragezeichen";
            this.PicBoxFragezeichen.Size = new System.Drawing.Size(32, 32);
            this.PicBoxFragezeichen.TabIndex = 3;
            this.PicBoxFragezeichen.TabStop = false;
            // 
            // MLblTitel
            // 
            this.MLblTitel.Location = new System.Drawing.Point(40, 60);
            this.MLblTitel.Margin = new System.Windows.Forms.Padding(20, 20, 40, 20);
            this.MLblTitel.Name = "MLblTitel";
            this.MLblTitel.Size = new System.Drawing.Size(385, 60);
            this.MLblTitel.TabIndex = 4;
            this.MLblTitel.Text = "Dialogtitel\r\nZeile Zwei\r\nZeile Drei";
            // 
            // AuswahlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 314);
            this.ControlBox = false;
            this.Controls.Add(this.MLblTitel);
            this.Controls.Add(this.PicBoxFragezeichen);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuswahlDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFragezeichen)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PicBoxFragezeichen;
		private MetroFramework.Controls.MetroLabel MLblTitel;
	}
}