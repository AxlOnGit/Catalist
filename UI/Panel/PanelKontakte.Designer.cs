namespace Products.Common.Panel
{
	partial class PanelKontakte
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvContacts = new MetroFramework.Controls.MetroGrid();
			this.ctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
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
			this.SuspendLayout();
			// 
			// dgvContacts
			// 
			this.dgvContacts.AllowUserToAddRows = false;
			this.dgvContacts.AllowUserToDeleteRows = false;
			this.dgvContacts.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(123)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
			this.dgvContacts.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(123)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvContacts.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvContacts.EnableHeadersVisualStyles = false;
			this.dgvContacts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContacts.HighLightPercentage = 0.8F;
			this.dgvContacts.Location = new System.Drawing.Point(23, 100);
			this.dgvContacts.Name = "dgvContacts";
			this.dgvContacts.ReadOnly = true;
			this.dgvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(123)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvContacts.RowHeadersVisible = false;
			this.dgvContacts.RowHeadersWidth = 21;
			this.dgvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContacts.Size = new System.Drawing.Size(1234, 500);
			this.dgvContacts.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvContacts.TabIndex = 0;
			this.dgvContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_RowEnter);
			// 
			// ctxGrid
			// 
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new System.Drawing.Size(61, 4);
			// 
			// mlblTitel
			// 
			this.mlblTitel.AutoSize = true;
			this.mlblTitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblTitel.Location = new System.Drawing.Point(22, 20);
			this.mlblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblTitel.Name = "mlblTitel";
			this.mlblTitel.Size = new System.Drawing.Size(139, 25);
			this.mlblTitel.TabIndex = 0;
			this.mlblTitel.Text = "Ansprechpartner";
			// 
			// colMainContactFlag
			// 
			this.colMainContactFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colMainContactFlag.DataPropertyName = "MainContactFlag";
			this.colMainContactFlag.HeaderText = "Hauptkontakt";
			this.colMainContactFlag.Name = "colMainContactFlag";
			this.colMainContactFlag.ReadOnly = true;
			this.colMainContactFlag.Width = 83;
			// 
			// colKontaktname
			// 
			this.colKontaktname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKontaktname.DataPropertyName = "Kontaktname";
			this.colKontaktname.HeaderText = "Name";
			this.colKontaktname.Name = "colKontaktname";
			this.colKontaktname.ReadOnly = true;
			this.colKontaktname.Width = 59;
			// 
			// colAbteilung
			// 
			this.colAbteilung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAbteilung.DataPropertyName = "Abteilung";
			this.colAbteilung.HeaderText = "Abteilung";
			this.colAbteilung.Name = "colAbteilung";
			this.colAbteilung.ReadOnly = true;
			this.colAbteilung.Width = 81;
			// 
			// colTelefon
			// 
			this.colTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTelefon.DataPropertyName = "Telefon";
			this.colTelefon.HeaderText = "Telefon";
			this.colTelefon.Name = "colTelefon";
			this.colTelefon.ReadOnly = true;
			this.colTelefon.Width = 67;
			// 
			// colTelefax
			// 
			this.colTelefax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTelefax.DataPropertyName = "Telefax";
			this.colTelefax.HeaderText = "Fax";
			this.colTelefax.Name = "colTelefax";
			this.colTelefax.ReadOnly = true;
			this.colTelefax.Width = 47;
			// 
			// colHandy
			// 
			this.colHandy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHandy.DataPropertyName = "Handy";
			this.colHandy.HeaderText = "Mobiltelefon";
			this.colHandy.Name = "colHandy";
			this.colHandy.ReadOnly = true;
			this.colHandy.Width = 97;
			// 
			// colAutotelefon
			// 
			this.colAutotelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAutotelefon.DataPropertyName = "Autotelefon";
			this.colAutotelefon.HeaderText = "Andere Nr.";
			this.colAutotelefon.Name = "colAutotelefon";
			this.colAutotelefon.ReadOnly = true;
			this.colAutotelefon.Width = 85;
			// 
			// colE_Mail
			// 
			this.colE_Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colE_Mail.DataPropertyName = "E_Mail";
			this.colE_Mail.HeaderText = "E-Mail";
			this.colE_Mail.Name = "colE_Mail";
			this.colE_Mail.ReadOnly = true;
			this.colE_Mail.Width = 62;
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
			this.colInfoPerMail.DataPropertyName = "InfoPerEmail";
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
			this.colInfoPerBrief.DataPropertyName = "InfoPerBrief";
			this.colInfoPerBrief.HeaderText = "InfoBrief";
			this.colInfoPerBrief.Name = "colInfoPerBrief";
			this.colInfoPerBrief.ReadOnly = true;
			// 
			// pnlKontakte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvContacts);
			this.Controls.Add(this.mlblTitel);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "pnlKontakte";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1280, 723);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pnlKontakte_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroFramework.Controls.MetroLabel mlblTitel;
		MetroFramework.Controls.MetroGrid dgvContacts;
		MetroFramework.Controls.MetroContextMenu ctxGrid;
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
