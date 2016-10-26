namespace Products.Common.Views
{
	partial class AngeboteListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvAngebote = new MetroFramework.Controls.MetroGrid();
			this.colNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBruttosumme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGesamtrabatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xmnuAngebote = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xcmdSearchEmails = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.dgvDetails = new MetroFramework.Controls.MetroGrid();
			this.colArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAngebote)).BeginInit();
			this.xmnuAngebote.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAngebote
			// 
			this.dgvAngebote.AllowUserToResizeRows = false;
			this.dgvAngebote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAngebote.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAngebote.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAngebote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAngebote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAngebote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAngebote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAngebote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNummer,
            this.colDatum,
            this.colKundennummer,
            this.colBruttosumme,
            this.colGesamtrabatt});
			this.dgvAngebote.ContextMenuStrip = this.xmnuAngebote;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAngebote.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvAngebote.EnableHeadersVisualStyles = false;
			this.dgvAngebote.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvAngebote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAngebote.HighLightPercentage = 1.2F;
			this.dgvAngebote.Location = new System.Drawing.Point(23, 100);
			this.dgvAngebote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvAngebote.Name = "dgvAngebote";
			this.dgvAngebote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAngebote.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvAngebote.RowHeadersVisible = false;
			this.dgvAngebote.RowHeadersWidth = 21;
			this.dgvAngebote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvAngebote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAngebote.Size = new System.Drawing.Size(707, 172);
			this.dgvAngebote.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvAngebote.TabIndex = 0;
			// 
			// colNummer
			// 
			this.colNummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNummer.DataPropertyName = "Nummer";
			this.colNummer.FillWeight = 17.5F;
			this.colNummer.HeaderText = "Angebot";
			this.colNummer.Name = "colNummer";
			// 
			// colDatum
			// 
			this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum.DataPropertyName = "Datum";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colDatum.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDatum.FillWeight = 17.5F;
			this.colDatum.HeaderText = "vom";
			this.colDatum.Name = "colDatum";
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Matchcode";
			this.colKundennummer.FillWeight = 25F;
			this.colKundennummer.HeaderText = "Kunde";
			this.colKundennummer.Name = "colKundennummer";
			// 
			// colBruttosumme
			// 
			this.colBruttosumme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBruttosumme.DataPropertyName = "Bruttosumme";
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.colBruttosumme.DefaultCellStyle = dataGridViewCellStyle3;
			this.colBruttosumme.FillWeight = 20F;
			this.colBruttosumme.HeaderText = "Bruttosumme";
			this.colBruttosumme.Name = "colBruttosumme";
			// 
			// colGesamtrabatt
			// 
			this.colGesamtrabatt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colGesamtrabatt.DataPropertyName = "Gesamtrabatt";
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.colGesamtrabatt.DefaultCellStyle = dataGridViewCellStyle4;
			this.colGesamtrabatt.FillWeight = 20F;
			this.colGesamtrabatt.HeaderText = "Rabatt";
			this.colGesamtrabatt.Name = "colGesamtrabatt";
			// 
			// xmnuAngebote
			// 
			this.xmnuAngebote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdSearchEmails});
			this.xmnuAngebote.Name = "xmnuAngebote";
			this.xmnuAngebote.Size = new System.Drawing.Size(167, 26);
			// 
			// xcmdSearchEmails
			// 
			this.xcmdSearchEmails.Image = global::Products.Common.Properties.Resources.email_16_metrogreen;
			this.xcmdSearchEmails.Name = "xcmdSearchEmails";
			this.xcmdSearchEmails.Size = new System.Drawing.Size(166, 22);
			this.xcmdSearchEmails.Text = "E-Mails suchen ...";
			this.xcmdSearchEmails.Click += new System.EventHandler(this.xcmdSearchEmails_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(630, 627);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 2;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// dgvDetails
			// 
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikelnummer,
            this.colBezeichnung1,
            this.colBezeichnung2,
            this.colMenge,
            this.colGesamtpreis});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDetails.HighLightPercentage = 1.2F;
			this.dgvDetails.Location = new System.Drawing.Point(23, 295);
			this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 21;
			this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(707, 309);
			this.dgvDetails.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvDetails.TabIndex = 1;
			// 
			// colArtikelnummer
			// 
			this.colArtikelnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikelnummer.DataPropertyName = "Artikelnummer";
			this.colArtikelnummer.FillWeight = 22F;
			this.colArtikelnummer.HeaderText = "Artikel";
			this.colArtikelnummer.Name = "colArtikelnummer";
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 28F;
			this.colBezeichnung1.HeaderText = "Artikelname";
			this.colBezeichnung1.Name = "colBezeichnung1";
			// 
			// colBezeichnung2
			// 
			this.colBezeichnung2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
			this.colBezeichnung2.FillWeight = 28F;
			this.colBezeichnung2.HeaderText = "Artikelzusatz";
			this.colBezeichnung2.Name = "colBezeichnung2";
			// 
			// colMenge
			// 
			this.colMenge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMenge.DataPropertyName = "Menge";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.colMenge.DefaultCellStyle = dataGridViewCellStyle8;
			this.colMenge.FillWeight = 11F;
			this.colMenge.HeaderText = "Menge";
			this.colMenge.Name = "colMenge";
			// 
			// colGesamtpreis
			// 
			this.colGesamtpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colGesamtpreis.DataPropertyName = "Gesamtpreis";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "C2";
			dataGridViewCellStyle9.NullValue = null;
			this.colGesamtpreis.DefaultCellStyle = dataGridViewCellStyle9;
			this.colGesamtpreis.FillWeight = 11F;
			this.colGesamtpreis.HeaderText = "Gesamt";
			this.colGesamtpreis.Name = "colGesamtpreis";
			// 
			// AngeboteListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 676);
			this.Controls.Add(this.dgvDetails);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvAngebote);
			this.Name = "AngeboteListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "SAGE Angebote";
			((System.ComponentModel.ISupportInitialize)(this.dgvAngebote)).EndInit();
			this.xmnuAngebote.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvAngebote;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroGrid dgvDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelnummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGesamtpreis;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBruttosumme;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGesamtrabatt;
		private System.Windows.Forms.ContextMenuStrip xmnuAngebote;
		private System.Windows.Forms.ToolStripMenuItem xcmdSearchEmails;
	}
}