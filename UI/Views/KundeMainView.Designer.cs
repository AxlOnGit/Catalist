namespace Products.Common.Views
{
	partial class KundeMainView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeMainView));
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mbtnStart2 = new MetroFramework.Controls.MetroButton();
			this.ctxView = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdBingMaps = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdShowTouren = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnStart = new MetroFramework.Controls.MetroButton();
			this.mbtnNext = new MetroFramework.Controls.MetroButton();
			this.mbtnBack = new MetroFramework.Controls.MetroButton();
			this.ctxView.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnClose.BackColor = System.Drawing.Color.Transparent;
			this.mbtnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnClose.ForeColor = System.Drawing.Color.Black;
			this.mbtnClose.Location = new System.Drawing.Point(22, 920);
			this.mbtnClose.Margin = new System.Windows.Forms.Padding(2);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(162, 30);
			this.mbtnClose.TabIndex = 10;
			this.mbtnClose.Text = " Schließen";
			this.mbtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnStart2
			// 
			this.mbtnStart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnStart2.BackColor = System.Drawing.Color.Transparent;
			this.mbtnStart2.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnStart2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnStart2.ForeColor = System.Drawing.Color.Black;
			this.mbtnStart2.Location = new System.Drawing.Point(22, 886);
			this.mbtnStart2.Margin = new System.Windows.Forms.Padding(2);
			this.mbtnStart2.Name = "mbtnStart2";
			this.mbtnStart2.Size = new System.Drawing.Size(162, 30);
			this.mbtnStart2.TabIndex = 12;
			this.mbtnStart2.Text = " Start";
			this.mbtnStart2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtnStart2.UseCustomBackColor = true;
			this.mbtnStart2.UseSelectable = true;
			this.mbtnStart2.Click += new System.EventHandler(this.mbtnStart_Click);
			// 
			// ctxView
			// 
			this.ctxView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdBingMaps,
            this.xcmdShowTouren});
			this.ctxView.Name = "ctxView";
			this.ctxView.Size = new System.Drawing.Size(169, 48);
			// 
			// xcmdBingMaps
			// 
			this.xcmdBingMaps.Image = global::Products.Common.Properties.Resources.bing_16;
			this.xcmdBingMaps.Name = "xcmdBingMaps";
			this.xcmdBingMaps.Size = new System.Drawing.Size(168, 22);
			this.xcmdBingMaps.Text = "Bing Maps öffnen";
			this.xcmdBingMaps.Click += new System.EventHandler(this.xcmdBingMaps_Click);
			// 
			// xcmdShowTouren
			// 
			this.xcmdShowTouren.Image = global::Products.Common.Properties.Resources.tour_16_metroyellow;
			this.xcmdShowTouren.Name = "xcmdShowTouren";
			this.xcmdShowTouren.Size = new System.Drawing.Size(168, 22);
			this.xcmdShowTouren.Text = "Touren anzeigen";
			this.xcmdShowTouren.Click += new System.EventHandler(this.xcmdShowTouren_Click);
			// 
			// mbtnStart
			// 
			this.mbtnStart.BackColor = System.Drawing.Color.Transparent;
			this.mbtnStart.BackgroundImage = global::Products.Common.Properties.Resources.start_metroblack;
			this.mbtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnStart.DisplayFocus = true;
			this.mbtnStart.Location = new System.Drawing.Point(22, 63);
			this.mbtnStart.Name = "mbtnStart";
			this.mbtnStart.Size = new System.Drawing.Size(60, 30);
			this.mbtnStart.TabIndex = 11;
			this.mbtnStart.UseCustomBackColor = true;
			this.mbtnStart.UseSelectable = true;
			this.mbtnStart.Visible = false;
			this.mbtnStart.Click += new System.EventHandler(this.mbtnStart_Click);
			// 
			// mbtnNext
			// 
			this.mbtnNext.BackColor = System.Drawing.Color.Transparent;
			this.mbtnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnNext.BackgroundImage")));
			this.mbtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnNext.Location = new System.Drawing.Point(154, 63);
			this.mbtnNext.Name = "mbtnNext";
			this.mbtnNext.Size = new System.Drawing.Size(60, 30);
			this.mbtnNext.TabIndex = 1;
			this.mbtnNext.UseSelectable = true;
			this.mbtnNext.Visible = false;
			this.mbtnNext.Click += new System.EventHandler(this.mbtnNext_Click);
			// 
			// mbtnBack
			// 
			this.mbtnBack.BackColor = System.Drawing.Color.Transparent;
			this.mbtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnBack.BackgroundImage")));
			this.mbtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnBack.Location = new System.Drawing.Point(88, 63);
			this.mbtnBack.Name = "mbtnBack";
			this.mbtnBack.Size = new System.Drawing.Size(60, 30);
			this.mbtnBack.TabIndex = 0;
			this.mbtnBack.UseSelectable = true;
			this.mbtnBack.Visible = false;
			this.mbtnBack.Click += new System.EventHandler(this.mbtnBack_Click);
			// 
			// KundeMainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1310, 972);
			this.ContextMenuStrip = this.ctxView;
			this.Controls.Add(this.mbtnStart2);
			this.Controls.Add(this.mbtnStart);
			this.Controls.Add(this.mbtnNext);
			this.Controls.Add(this.mbtnBack);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1280, 900);
			this.Name = "KundeMainView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			this.Text = "[10000] - Cut && Print Media GmbH && Co. KG";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KundeMainView_FormClosing);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KundeMainView_KeyUp);
			this.MouseEnter += new System.EventHandler(this.KundeMainView_MouseEnter);
			this.ctxView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroButton mbtnBack;
		private MetroFramework.Controls.MetroButton mbtnNext;
		private MetroFramework.Controls.MetroButton mbtnStart;
		private MetroFramework.Controls.MetroButton mbtnStart2;
		private MetroFramework.Controls.MetroContextMenu ctxView;
		private System.Windows.Forms.ToolStripMenuItem xcmdBingMaps;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowTouren;
	}
}