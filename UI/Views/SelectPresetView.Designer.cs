namespace Products.Common.Views
{
	partial class SelectPresetView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPresetView));
			this.lstPresets = new System.Windows.Forms.ListBox();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mbtnOk = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// lstPresets
			// 
			this.lstPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPresets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstPresets.FormattingEnabled = true;
			this.lstPresets.Location = new System.Drawing.Point(23, 100);
			this.lstPresets.Name = "lstPresets";
			this.lstPresets.Size = new System.Drawing.Size(509, 314);
			this.lstPresets.TabIndex = 0;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnClose.Location = new System.Drawing.Point(432, 440);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 29);
			this.mbtnClose.TabIndex = 70;
			this.mbtnClose.Text = "Abbrechen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnOk.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnOk.Location = new System.Drawing.Point(227, 440);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 29);
			this.mbtnOk.TabIndex = 71;
			this.mbtnOk.Text = "Übernehmen";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseStyleColors = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// SelectPresetView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(555, 492);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.lstPresets);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectPresetView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Preset-Auswahl";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstPresets;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroButton mbtnOk;
	}
}