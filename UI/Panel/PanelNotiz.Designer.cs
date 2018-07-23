namespace Products.Common.Panel
{
	partial class PanelNotiz
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		void InitializeComponent()
		{
			this.label5 = new MetroFramework.Controls.MetroLabel();
			this.txtNotiztext = new MetroFramework.Controls.MetroTextBox();
			this.label3 = new MetroFramework.Controls.MetroLabel();
			this.lblErfassung = new MetroFramework.Controls.MetroLabel();
			this.cmbAnsprechpartner = new MetroFramework.Controls.MetroComboBox();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.cmbLinktype = new MetroFramework.Controls.MetroComboBox();
			this.mbtnWeiterleiten = new MetroFramework.Controls.MetroButton();
			this.mdtpErfassungsdatum = new MetroFramework.Controls.MetroDateTime();
			this.mtxtThema = new MetroFramework.Controls.MetroTextBox();
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
			this.metroLink1 = new MetroFramework.Controls.MetroLink();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 19);
			this.label5.TabIndex = 71;
			this.label5.Text = "Datum:";
			// 
			// txtNotiztext
			// 
			this.txtNotiztext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtNotiztext.CustomButton.Image = null;
			this.txtNotiztext.CustomButton.Location = new System.Drawing.Point(55, 2);
			this.txtNotiztext.CustomButton.Name = "";
			this.txtNotiztext.CustomButton.Size = new System.Drawing.Size(459, 459);
			this.txtNotiztext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNotiztext.CustomButton.TabIndex = 1;
			this.txtNotiztext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNotiztext.CustomButton.UseSelectable = true;
			this.txtNotiztext.CustomButton.Visible = false;
			this.txtNotiztext.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNotiztext.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtNotiztext.Lines = new string[0];
			this.txtNotiztext.Location = new System.Drawing.Point(84, 164);
			this.txtNotiztext.MaxLength = 32767;
			this.txtNotiztext.Multiline = true;
			this.txtNotiztext.Name = "txtNotiztext";
			this.txtNotiztext.PasswordChar = '\0';
			this.txtNotiztext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotiztext.SelectedText = "";
			this.txtNotiztext.SelectionLength = 0;
			this.txtNotiztext.SelectionStart = 0;
			this.txtNotiztext.Size = new System.Drawing.Size(517, 466);
			this.txtNotiztext.TabIndex = 5;
			this.txtNotiztext.UseSelectable = true;
			this.txtNotiztext.WaterMark = "Text der Notiz";
			this.txtNotiztext.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtNotiztext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 19);
			this.label3.TabIndex = 67;
			this.label3.Text = "Thema:";
			// 
			// lblErfassung
			// 
			this.lblErfassung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblErfassung.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblErfassung.Location = new System.Drawing.Point(139, 671);
			this.lblErfassung.Name = "lblErfassung";
			this.lblErfassung.Size = new System.Drawing.Size(462, 79);
			this.lblErfassung.TabIndex = 63;
			this.lblErfassung.Text = "Erfassungsdetails";
			this.lblErfassung.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbAnsprechpartner
			// 
			this.cmbAnsprechpartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbAnsprechpartner.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.cmbAnsprechpartner.FormattingEnabled = true;
			this.cmbAnsprechpartner.ItemHeight = 23;
			this.cmbAnsprechpartner.Location = new System.Drawing.Point(410, 100);
			this.cmbAnsprechpartner.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.cmbAnsprechpartner.Name = "cmbAnsprechpartner";
			this.cmbAnsprechpartner.Size = new System.Drawing.Size(191, 29);
			this.cmbAnsprechpartner.TabIndex = 2;
			this.cmbAnsprechpartner.UseSelectable = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(349, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 19);
			this.label2.TabIndex = 61;
			this.label2.Text = "Kontakt:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 636);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 19);
			this.label1.TabIndex = 58;
			this.label1.Text = "Typ:";
			// 
			// cmbLinktype
			// 
			this.cmbLinktype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbLinktype.DisplayMember = "LinktypBezeichnung";
			this.cmbLinktype.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.cmbLinktype.FormattingEnabled = true;
			this.cmbLinktype.ItemHeight = 23;
			this.cmbLinktype.Location = new System.Drawing.Point(84, 636);
			this.cmbLinktype.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.cmbLinktype.Name = "cmbLinktype";
			this.cmbLinktype.Size = new System.Drawing.Size(517, 29);
			this.cmbLinktype.TabIndex = 0;
			this.cmbLinktype.UseSelectable = true;
			this.cmbLinktype.ValueMember = "UID";
			// 
			// mbtnWeiterleiten
			// 
			this.mbtnWeiterleiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnWeiterleiten.BackColor = System.Drawing.Color.Transparent;
			this.mbtnWeiterleiten.BackgroundImage = global::Products.Common.Properties.Resources.forward_32_metroorange;
			this.mbtnWeiterleiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnWeiterleiten.Location = new System.Drawing.Point(565, 58);
			this.mbtnWeiterleiten.Name = "mbtnWeiterleiten";
			this.mbtnWeiterleiten.Size = new System.Drawing.Size(36, 36);
			this.mbtnWeiterleiten.TabIndex = 6;
			this.mbtnWeiterleiten.UseSelectable = true;
			// 
			// mdtpErfassungsdatum
			// 
			this.mdtpErfassungsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.mdtpErfassungsdatum.Location = new System.Drawing.Point(84, 100);
			this.mdtpErfassungsdatum.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpErfassungsdatum.Name = "mdtpErfassungsdatum";
			this.mdtpErfassungsdatum.Size = new System.Drawing.Size(135, 29);
			this.mdtpErfassungsdatum.TabIndex = 3;
			// 
			// mtxtThema
			// 
			this.mtxtThema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtThema.CustomButton.Image = null;
			this.mtxtThema.CustomButton.Location = new System.Drawing.Point(495, 1);
			this.mtxtThema.CustomButton.Name = "";
			this.mtxtThema.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtThema.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtThema.CustomButton.TabIndex = 1;
			this.mtxtThema.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtThema.CustomButton.UseSelectable = true;
			this.mtxtThema.CustomButton.Visible = false;
			this.mtxtThema.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtThema.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtThema.Lines = new string[0];
			this.mtxtThema.Location = new System.Drawing.Point(84, 135);
			this.mtxtThema.MaxLength = 32767;
			this.mtxtThema.Name = "mtxtThema";
			this.mtxtThema.PasswordChar = '\0';
			this.mtxtThema.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtThema.SelectedText = "";
			this.mtxtThema.SelectionLength = 0;
			this.mtxtThema.SelectionStart = 0;
			this.mtxtThema.Size = new System.Drawing.Size(517, 23);
			this.mtxtThema.TabIndex = 4;
			this.mtxtThema.UseSelectable = true;
			this.mtxtThema.WaterMark = "Thema";
			this.mtxtThema.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtThema.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mlblTitel
			// 
			this.mlblTitel.AutoSize = true;
			this.mlblTitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblTitel.Location = new System.Drawing.Point(23, 20);
			this.mlblTitel.Name = "mlblTitel";
			this.mlblTitel.Size = new System.Drawing.Size(43, 25);
			this.mlblTitel.TabIndex = 77;
			this.mlblTitel.Text = "Titel";
			// 
			// metroLink1
			// 
			this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLink1.Location = new System.Drawing.Point(84, 671);
			this.metroLink1.Name = "metroLink1";
			this.metroLink1.Size = new System.Drawing.Size(56, 23);
			this.metroLink1.TabIndex = 78;
			this.metroLink1.Text = "Schrift";
			this.metroLink1.UseSelectable = true;
			this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
			// 
			// pnlNotiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.metroLink1);
			this.Controls.Add(this.mlblTitel);
			this.Controls.Add(this.mtxtThema);
			this.Controls.Add(this.mdtpErfassungsdatum);
			this.Controls.Add(this.mbtnWeiterleiten);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNotiztext);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblErfassung);
			this.Controls.Add(this.cmbAnsprechpartner);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbLinktype);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "pnlNotiz";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1191, 773);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroFramework.Controls.MetroLabel label5;
		MetroFramework.Controls.MetroTextBox txtNotiztext;
		MetroFramework.Controls.MetroLabel label3;
		MetroFramework.Controls.MetroLabel lblErfassung;
		MetroFramework.Controls.MetroLabel label2;
		MetroFramework.Controls.MetroLabel label1;
		MetroFramework.Controls.MetroComboBox cmbAnsprechpartner;
		MetroFramework.Controls.MetroComboBox cmbLinktype;
		MetroFramework.Controls.MetroButton mbtnWeiterleiten;
		MetroFramework.Controls.MetroDateTime mdtpErfassungsdatum;
		MetroFramework.Controls.MetroTextBox mtxtThema;
		MetroFramework.Controls.MetroLabel mlblTitel;
		MetroFramework.Controls.MetroLink metroLink1;
	}
}
