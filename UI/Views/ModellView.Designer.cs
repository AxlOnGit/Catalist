namespace Products.Common.Views
{
	partial class ModellView
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
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mcmbMaschinentyp = new MetroFramework.Controls.MetroComboBox();
			this.mcmbHersteller = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mcmbMaschinenserie = new MetroFramework.Controls.MetroComboBox();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.mtxtModellbezeichnung = new MetroFramework.Controls.MetroTextBox();
			this.btnAddModel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 220);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(91, 19);
			this.metroLabel3.TabIndex = 15;
			this.metroLabel3.Text = "Maschinentyp:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 136);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(68, 19);
			this.metroLabel2.TabIndex = 14;
			this.metroLabel2.Text = "Hersteller:";
			// 
			// mcmbMaschinentyp
			// 
			this.mcmbMaschinentyp.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbMaschinentyp.FormattingEnabled = true;
			this.mcmbMaschinentyp.ItemHeight = 23;
			this.mcmbMaschinentyp.Location = new System.Drawing.Point(146, 220);
			this.mcmbMaschinentyp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mcmbMaschinentyp.Name = "mcmbMaschinentyp";
			this.mcmbMaschinentyp.Size = new System.Drawing.Size(218, 29);
			this.mcmbMaschinentyp.TabIndex = 3;
			this.mcmbMaschinentyp.UseSelectable = true;
			// 
			// mcmbHersteller
			// 
			this.mcmbHersteller.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbHersteller.FormattingEnabled = true;
			this.mcmbHersteller.ItemHeight = 23;
			this.mcmbHersteller.Location = new System.Drawing.Point(146, 136);
			this.mcmbHersteller.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mcmbHersteller.Name = "mcmbHersteller";
			this.mcmbHersteller.Size = new System.Drawing.Size(218, 29);
			this.mcmbHersteller.TabIndex = 1;
			this.mcmbHersteller.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 178);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(100, 19);
			this.metroLabel1.TabIndex = 17;
			this.metroLabel1.Text = "Maschinenserie:";
			// 
			// mcmbMaschinenserie
			// 
			this.mcmbMaschinenserie.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbMaschinenserie.FormattingEnabled = true;
			this.mcmbMaschinenserie.ItemHeight = 23;
			this.mcmbMaschinenserie.Location = new System.Drawing.Point(146, 178);
			this.mcmbMaschinenserie.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mcmbMaschinenserie.Name = "mcmbMaschinenserie";
			this.mcmbMaschinenserie.Size = new System.Drawing.Size(218, 29);
			this.mcmbMaschinenserie.TabIndex = 2;
			this.mcmbMaschinenserie.UseSelectable = true;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(299, 313);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 5;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 100);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(53, 19);
			this.metroLabel4.TabIndex = 20;
			this.metroLabel4.Text = "Modell:";
			// 
			// mtxtModellbezeichnung
			// 
			// 
			// 
			// 
			this.mtxtModellbezeichnung.CustomButton.Image = null;
			this.mtxtModellbezeichnung.CustomButton.Location = new System.Drawing.Point(196, 1);
			this.mtxtModellbezeichnung.CustomButton.Name = "";
			this.mtxtModellbezeichnung.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtModellbezeichnung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtModellbezeichnung.CustomButton.TabIndex = 1;
			this.mtxtModellbezeichnung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtModellbezeichnung.CustomButton.UseSelectable = true;
			this.mtxtModellbezeichnung.CustomButton.Visible = false;
			this.mtxtModellbezeichnung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtModellbezeichnung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtModellbezeichnung.Lines = new string[0];
			this.mtxtModellbezeichnung.Location = new System.Drawing.Point(146, 100);
			this.mtxtModellbezeichnung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtModellbezeichnung.MaxLength = 32767;
			this.mtxtModellbezeichnung.Name = "mtxtModellbezeichnung";
			this.mtxtModellbezeichnung.PasswordChar = '\0';
			this.mtxtModellbezeichnung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtModellbezeichnung.SelectedText = "";
			this.mtxtModellbezeichnung.SelectionLength = 0;
			this.mtxtModellbezeichnung.SelectionStart = 0;
			this.mtxtModellbezeichnung.ShortcutsEnabled = true;
			this.mtxtModellbezeichnung.Size = new System.Drawing.Size(218, 23);
			this.mtxtModellbezeichnung.TabIndex = 0;
			this.mtxtModellbezeichnung.UseSelectable = true;
			this.mtxtModellbezeichnung.WaterMark = "Modellbezeichnung";
			this.mtxtModellbezeichnung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtModellbezeichnung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnAddModel
			// 
			this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddModel.BackColor = System.Drawing.Color.Transparent;
			this.btnAddModel.BackgroundImage = global::Products.Common.Properties.Resources.neu_metroblue;
			this.btnAddModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddModel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddModel.FlatAppearance.BorderSize = 0;
			this.btnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddModel.Location = new System.Drawing.Point(23, 303);
			this.btnAddModel.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnAddModel.Name = "btnAddModel";
			this.btnAddModel.Size = new System.Drawing.Size(36, 36);
			this.btnAddModel.TabIndex = 4;
			this.btnAddModel.UseVisualStyleBackColor = false;
			this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
			// 
			// ModellView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(422, 362);
			this.Controls.Add(this.btnAddModel);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.mtxtModellbezeichnung);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mcmbMaschinenserie);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mcmbMaschinentyp);
			this.Controls.Add(this.mcmbHersteller);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModellView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Text = "Maschinenmodell";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroComboBox mcmbMaschinentyp;
		private MetroFramework.Controls.MetroComboBox mcmbHersteller;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox mcmbMaschinenserie;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox mtxtModellbezeichnung;
		private System.Windows.Forms.Button btnAddModel;
	}
}