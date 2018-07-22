namespace Products.Common.Views
{
	partial class HerstellerView
	{

#pragma warning disable CS0618 // Typ oder Element ist veraltet

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
			this.mbtnCancel = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mtxtHerstellername = new MetroFramework.Controls.MetroTextBox();
			this.mbtnOk = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Location = new System.Drawing.Point(193, 182);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnCancel.TabIndex = 0;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseCustomBackColor = true;
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseStyleColors = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 100);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(136, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Name des Herstellers:";
			// 
			// mtxtHerstellername
			// 
			this.mtxtHerstellername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtHerstellername.CustomButton.Image = null;
			this.mtxtHerstellername.CustomButton.Location = new System.Drawing.Point(153, 1);
			this.mtxtHerstellername.CustomButton.Name = "";
			this.mtxtHerstellername.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtHerstellername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtHerstellername.CustomButton.TabIndex = 1;
			this.mtxtHerstellername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtHerstellername.CustomButton.UseSelectable = true;
			this.mtxtHerstellername.CustomButton.Visible = false;
			this.mtxtHerstellername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtHerstellername.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtHerstellername.Lines = new string[0];
			this.mtxtHerstellername.Location = new System.Drawing.Point(165, 98);
			this.mtxtHerstellername.MaxLength = 32767;
			this.mtxtHerstellername.Name = "mtxtHerstellername";
			this.mtxtHerstellername.PasswordChar = '\0';
			this.mtxtHerstellername.PromptText = "Herstellername";
			this.mtxtHerstellername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtHerstellername.SelectedText = "";
			this.mtxtHerstellername.SelectionLength = 0;
			this.mtxtHerstellername.SelectionStart = 0;
			this.mtxtHerstellername.ShortcutsEnabled = true;
			this.mtxtHerstellername.Size = new System.Drawing.Size(175, 23);
			this.mtxtHerstellername.TabIndex = 2;
			this.mtxtHerstellername.UseSelectable = true;
			this.mtxtHerstellername.WaterMark = "Herstellername";
			this.mtxtHerstellername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtHerstellername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Location = new System.Drawing.Point(70, 182);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnOk.TabIndex = 3;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseCustomBackColor = true;
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseStyleColors = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// HerstellerView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(363, 231);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.mtxtHerstellername);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mbtnCancel);
			this.Name = "HerstellerView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Maschinenhersteller";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HerstellerView_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnCancel;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox mtxtHerstellername;
		private MetroFramework.Controls.MetroButton mbtnOk;
	}
}