namespace Products.Common.Views
{
	partial class CustomerContactsView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerContactsView));
			this.dgvContacts = new System.Windows.Forms.DataGridView();
			this.ctxContact = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dgvEmail = new System.Windows.Forms.DataGridView();
			this.colEmailKostenvoranschlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailAngebot = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailAuftrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailLieferschein = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailRechnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailDirektrechnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailStornorechnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailGutschrift = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailProformarechnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailSammelrechnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmailMahnungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblDescriptionEmail = new System.Windows.Forms.Label();
			this.lnkClose = new System.Windows.Forms.LinkLabel();
			this.lnkAddRow = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelCommands = new System.Windows.Forms.Panel();
			this.lnkCallOther = new System.Windows.Forms.LinkLabel();
			this.lnkCallLandline = new System.Windows.Forms.LinkLabel();
			this.lnkCallMobile = new System.Windows.Forms.LinkLabel();
			this.colMainContactFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colKontaktname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAbteilung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHandy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAutotelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colE_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWebshopkunde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colInfoPerMail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colInfoPerFax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colInfoPerBrief = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelCommands.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvContacts
			// 
			this.dgvContacts.AllowUserToAddRows = false;
			this.dgvContacts.AllowUserToDeleteRows = false;
			this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMainContactFlag,
            this.colKontaktname,
            this.colAbteilung,
            this.colTelefon,
            this.colTelefax,
            this.colHandy,
            this.colAutotelefon,
            this.colE_Mail,
            this.colWebshopkunde,
            this.colInfoPerMail,
            this.colInfoPerFax,
            this.colInfoPerBrief});
			this.dgvContacts.ContextMenuStrip = this.ctxContact;
			this.dgvContacts.Location = new System.Drawing.Point(33, 33);
			this.dgvContacts.Name = "dgvContacts";
			this.dgvContacts.ReadOnly = true;
			this.dgvContacts.RowHeadersWidth = 25;
			this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContacts.Size = new System.Drawing.Size(1276, 262);
			this.dgvContacts.TabIndex = 78;
			this.dgvContacts.SelectionChanged += new System.EventHandler(this.dgvContacts_SelectionChanged);
			// 
			// ctxContact
			// 
			this.ctxContact.Name = "ctxContact";
			this.ctxContact.Size = new System.Drawing.Size(61, 4);
			// 
			// dgvEmail
			// 
			this.dgvEmail.AllowUserToAddRows = false;
			this.dgvEmail.AllowUserToDeleteRows = false;
			this.dgvEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmailKostenvoranschlag,
            this.colEmailAngebot,
            this.colEmailAuftrag,
            this.colEmailLieferschein,
            this.colEmailRechnung,
            this.colEmailDirektrechnung,
            this.colEmailStornorechnung,
            this.colEmailGutschrift,
            this.colEmailProformarechnung,
            this.colEmailSammelrechnung,
            this.colEmailMahnungen});
			this.dgvEmail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvEmail.Location = new System.Drawing.Point(33, 363);
			this.dgvEmail.MultiSelect = false;
			this.dgvEmail.Name = "dgvEmail";
			this.dgvEmail.RowHeadersWidth = 25;
			this.dgvEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvEmail.Size = new System.Drawing.Size(1276, 83);
			this.dgvEmail.TabIndex = 80;
			// 
			// colEmailKostenvoranschlag
			// 
			this.colEmailKostenvoranschlag.DataPropertyName = "EmailKostenvoranschlag";
			this.colEmailKostenvoranschlag.HeaderText = "Kostenvoranschlag";
			this.colEmailKostenvoranschlag.MinimumWidth = 120;
			this.colEmailKostenvoranschlag.Name = "colEmailKostenvoranschlag";
			this.colEmailKostenvoranschlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colEmailKostenvoranschlag.Width = 120;
			// 
			// colEmailAngebot
			// 
			this.colEmailAngebot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailAngebot.DataPropertyName = "EmailAngebot";
			this.colEmailAngebot.HeaderText = "Angebot";
			this.colEmailAngebot.Name = "colEmailAngebot";
			this.colEmailAngebot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailAuftrag
			// 
			this.colEmailAuftrag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailAuftrag.DataPropertyName = "EmailAuftrag";
			this.colEmailAuftrag.HeaderText = "Auftrag";
			this.colEmailAuftrag.Name = "colEmailAuftrag";
			this.colEmailAuftrag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailLieferschein
			// 
			this.colEmailLieferschein.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailLieferschein.DataPropertyName = "EmailLieferschein";
			this.colEmailLieferschein.HeaderText = "Lieferschein";
			this.colEmailLieferschein.Name = "colEmailLieferschein";
			this.colEmailLieferschein.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailRechnung
			// 
			this.colEmailRechnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailRechnung.DataPropertyName = "EmailRechnung";
			this.colEmailRechnung.HeaderText = "Rechnung";
			this.colEmailRechnung.Name = "colEmailRechnung";
			this.colEmailRechnung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailDirektrechnung
			// 
			this.colEmailDirektrechnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailDirektrechnung.DataPropertyName = "EmailDirektrechnung";
			this.colEmailDirektrechnung.HeaderText = "Direktrechnung";
			this.colEmailDirektrechnung.Name = "colEmailDirektrechnung";
			this.colEmailDirektrechnung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailStornorechnung
			// 
			this.colEmailStornorechnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailStornorechnung.DataPropertyName = "EmailStornorechnung";
			this.colEmailStornorechnung.HeaderText = "Storno";
			this.colEmailStornorechnung.Name = "colEmailStornorechnung";
			this.colEmailStornorechnung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailGutschrift
			// 
			this.colEmailGutschrift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailGutschrift.DataPropertyName = "EmailGutschrift";
			this.colEmailGutschrift.HeaderText = "Gutschrift";
			this.colEmailGutschrift.Name = "colEmailGutschrift";
			this.colEmailGutschrift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailProformarechnung
			// 
			this.colEmailProformarechnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailProformarechnung.DataPropertyName = "EmailProformarechnung";
			this.colEmailProformarechnung.HeaderText = "Proforma";
			this.colEmailProformarechnung.Name = "colEmailProformarechnung";
			this.colEmailProformarechnung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailSammelrechnung
			// 
			this.colEmailSammelrechnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailSammelrechnung.DataPropertyName = "EmailSammelrechnung";
			this.colEmailSammelrechnung.HeaderText = "Sammelrechnung";
			this.colEmailSammelrechnung.Name = "colEmailSammelrechnung";
			this.colEmailSammelrechnung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colEmailMahnungen
			// 
			this.colEmailMahnungen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmailMahnungen.DataPropertyName = "EmailMahnungen";
			this.colEmailMahnungen.HeaderText = "Mahnung";
			this.colEmailMahnungen.Name = "colEmailMahnungen";
			this.colEmailMahnungen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// lblDescriptionEmail
			// 
			this.lblDescriptionEmail.AutoSize = true;
			this.lblDescriptionEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescriptionEmail.ForeColor = System.Drawing.Color.DarkBlue;
			this.lblDescriptionEmail.Location = new System.Drawing.Point(33, 330);
			this.lblDescriptionEmail.Name = "lblDescriptionEmail";
			this.lblDescriptionEmail.Size = new System.Drawing.Size(917, 20);
			this.lblDescriptionEmail.TabIndex = 81;
			this.lblDescriptionEmail.Text = "Der ausgewählt Ansprechpartner bekommt die folgenden Vorgänge per E-Mail zugestel" +
    "lt (jedenfalls, wenn Saskia sacht, dass das so ist ...)";
			// 
			// lnkClose
			// 
			this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkClose.AutoSize = true;
			this.lnkClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkClose.Location = new System.Drawing.Point(1270, 495);
			this.lnkClose.Name = "lnkClose";
			this.lnkClose.Size = new System.Drawing.Size(62, 17);
			this.lnkClose.TabIndex = 84;
			this.lnkClose.TabStop = true;
			this.lnkClose.Text = "Schließen";
			this.lnkClose.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// lnkAddRow
			// 
			this.lnkAddRow.AutoSize = true;
			this.lnkAddRow.Enabled = false;
			this.lnkAddRow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkAddRow.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkAddRow.Location = new System.Drawing.Point(750, 15);
			this.lnkAddRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnkAddRow.Name = "lnkAddRow";
			this.lnkAddRow.Size = new System.Drawing.Size(195, 19);
			this.lnkAddRow.TabIndex = 85;
			this.lnkAddRow.TabStop = true;
			this.lnkAddRow.Text = "Als Mailempfänger hinzufügen";
			this.lnkAddRow.Visible = false;
			this.lnkAddRow.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkAddRow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddRow_LinkClicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = global::Products.Common.Properties.Resources.Customers_green_48;
			this.pictureBox1.Location = new System.Drawing.Point(1, 473);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panelCommands
			// 
			this.panelCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCommands.Controls.Add(this.lnkCallOther);
			this.panelCommands.Controls.Add(this.lnkCallLandline);
			this.panelCommands.Controls.Add(this.lnkCallMobile);
			this.panelCommands.Controls.Add(this.lnkAddRow);
			this.panelCommands.Location = new System.Drawing.Point(55, 473);
			this.panelCommands.Name = "panelCommands";
			this.panelCommands.Size = new System.Drawing.Size(1209, 48);
			this.panelCommands.TabIndex = 86;
			// 
			// lnkCallOther
			// 
			this.lnkCallOther.AutoSize = true;
			this.lnkCallOther.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkCallOther.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkCallOther.Location = new System.Drawing.Point(454, 15);
			this.lnkCallOther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnkCallOther.Name = "lnkCallOther";
			this.lnkCallOther.Size = new System.Drawing.Size(161, 19);
			this.lnkCallOther.TabIndex = 87;
			this.lnkCallOther.TabStop = true;
			this.lnkCallOther.Text = "0176/76792751 anrufen";
			this.lnkCallOther.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallOther_LinkClicked);
			// 
			// lnkCallLandline
			// 
			this.lnkCallLandline.AutoSize = true;
			this.lnkCallLandline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkCallLandline.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkCallLandline.Location = new System.Drawing.Point(18, 15);
			this.lnkCallLandline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnkCallLandline.Name = "lnkCallLandline";
			this.lnkCallLandline.Size = new System.Drawing.Size(153, 19);
			this.lnkCallLandline.TabIndex = 86;
			this.lnkCallLandline.TabStop = true;
			this.lnkCallLandline.Text = "05401/832440 anrufen";
			this.lnkCallLandline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallLandline_LinkClicked);
			// 
			// lnkCallMobile
			// 
			this.lnkCallMobile.AutoSize = true;
			this.lnkCallMobile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkCallMobile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkCallMobile.Location = new System.Drawing.Point(227, 15);
			this.lnkCallMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnkCallMobile.Name = "lnkCallMobile";
			this.lnkCallMobile.Size = new System.Drawing.Size(161, 19);
			this.lnkCallMobile.TabIndex = 83;
			this.lnkCallMobile.TabStop = true;
			this.lnkCallMobile.Text = "0151/58803441 anrufen";
			this.lnkCallMobile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallMobile_LinkClicked);
			// 
			// colMainContactFlag
			// 
			this.colMainContactFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colMainContactFlag.DataPropertyName = "MainContactFlag";
			this.colMainContactFlag.HeaderText = "Hauptkontakt";
			this.colMainContactFlag.Name = "colMainContactFlag";
			this.colMainContactFlag.ReadOnly = true;
			this.colMainContactFlag.Width = 78;
			// 
			// colKontaktname
			// 
			this.colKontaktname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKontaktname.DataPropertyName = "Kontaktname";
			this.colKontaktname.HeaderText = "Name";
			this.colKontaktname.Name = "colKontaktname";
			this.colKontaktname.ReadOnly = true;
			this.colKontaktname.Width = 60;
			// 
			// colAbteilung
			// 
			this.colAbteilung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAbteilung.DataPropertyName = "Abteilung";
			this.colAbteilung.HeaderText = "Abteilung";
			this.colAbteilung.Name = "colAbteilung";
			this.colAbteilung.ReadOnly = true;
			this.colAbteilung.Width = 76;
			// 
			// colTelefon
			// 
			this.colTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTelefon.DataPropertyName = "Telefon";
			this.colTelefon.HeaderText = "Telefon";
			this.colTelefon.Name = "colTelefon";
			this.colTelefon.ReadOnly = true;
			this.colTelefon.Width = 68;
			// 
			// colTelefax
			// 
			this.colTelefax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTelefax.DataPropertyName = "Telefax";
			this.colTelefax.HeaderText = "Fax";
			this.colTelefax.Name = "colTelefax";
			this.colTelefax.ReadOnly = true;
			this.colTelefax.Width = 49;
			// 
			// colHandy
			// 
			this.colHandy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHandy.DataPropertyName = "Handy";
			this.colHandy.HeaderText = "Mobiltelefon";
			this.colHandy.Name = "colHandy";
			this.colHandy.ReadOnly = true;
			this.colHandy.Width = 89;
			// 
			// colAutotelefon
			// 
			this.colAutotelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAutotelefon.DataPropertyName = "Autotelefon";
			this.colAutotelefon.HeaderText = "Andere Nr.";
			this.colAutotelefon.Name = "colAutotelefon";
			this.colAutotelefon.ReadOnly = true;
			this.colAutotelefon.Width = 83;
			// 
			// colE_Mail
			// 
			this.colE_Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colE_Mail.DataPropertyName = "E_Mail";
			this.colE_Mail.HeaderText = "E-Mail";
			this.colE_Mail.Name = "colE_Mail";
			this.colE_Mail.ReadOnly = true;
			this.colE_Mail.Width = 61;
			// 
			// colWebshopkunde
			// 
			this.colWebshopkunde.DataPropertyName = "Webshopkunde";
			this.colWebshopkunde.HeaderText = "Webshop";
			this.colWebshopkunde.Name = "colWebshopkunde";
			this.colWebshopkunde.ReadOnly = true;
			// 
			// colInfoPerMail
			// 
			this.colInfoPerMail.DataPropertyName = "InfoPerMail";
			this.colInfoPerMail.HeaderText = "InfoMail";
			this.colInfoPerMail.Name = "colInfoPerMail";
			this.colInfoPerMail.ReadOnly = true;
			this.colInfoPerMail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colInfoPerMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colInfoPerFax
			// 
			this.colInfoPerFax.DataPropertyName = "InfoPerFax";
			this.colInfoPerFax.HeaderText = "InfoFax";
			this.colInfoPerFax.Name = "colInfoPerFax";
			this.colInfoPerFax.ReadOnly = true;
			// 
			// colInfoPerBrief
			// 
			this.colInfoPerBrief.DataPropertyName = "InfoBrief";
			this.colInfoPerBrief.HeaderText = "InfoBrief";
			this.colInfoPerBrief.Name = "colInfoPerBrief";
			this.colInfoPerBrief.ReadOnly = true;
			// 
			// CustomerContactsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.lnkClose;
			this.ClientSize = new System.Drawing.Size(1342, 522);
			this.Controls.Add(this.panelCommands);
			this.Controls.Add(this.lnkClose);
			this.Controls.Add(this.lblDescriptionEmail);
			this.Controls.Add(this.dgvEmail);
			this.Controls.Add(this.dgvContacts);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomerContactsView";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ansprechpartner bei Theodor Bungert Werbetechnik GmbH & Co. KG";
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelCommands.ResumeLayout(false);
			this.panelCommands.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvContacts;
		private System.Windows.Forms.DataGridView dgvEmail;
		private System.Windows.Forms.Label lblDescriptionEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailKostenvoranschlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailAngebot;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailAuftrag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailLieferschein;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailRechnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailDirektrechnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailStornorechnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailGutschrift;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailProformarechnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailSammelrechnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmailMahnungen;
		private System.Windows.Forms.ContextMenuStrip ctxContact;
		private System.Windows.Forms.LinkLabel lnkClose;
		private System.Windows.Forms.LinkLabel lnkAddRow;
		private System.Windows.Forms.Panel panelCommands;
		private System.Windows.Forms.LinkLabel lnkCallOther;
		private System.Windows.Forms.LinkLabel lnkCallLandline;
		private System.Windows.Forms.LinkLabel lnkCallMobile;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colMainContactFlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKontaktname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAbteilung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefax;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHandy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAutotelefon;
		private System.Windows.Forms.DataGridViewTextBoxColumn colE_Mail;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colWebshopkunde;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colInfoPerMail;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colInfoPerFax;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colInfoPerBrief;
	}
}