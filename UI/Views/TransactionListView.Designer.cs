namespace Products.Common.Views
{
	partial class TransactionListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionListView));
			this.dgvTransactions = new MetroFramework.Controls.MetroGrid();
			this.colVorgangstyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAuftrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.AllowUserToAddRows = false;
			this.dgvTransactions.AllowUserToDeleteRows = false;
			this.dgvTransactions.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVorgangstyp,
            this.colNummer,
            this.colAuftrag,
            this.colDatum,
            this.colArtikelnummer,
            this.colMenge,
            this.colGesamtpreis});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTransactions.EnableHeadersVisualStyles = false;
			this.dgvTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTransactions.HighLightPercentage = 0.9F;
			this.dgvTransactions.Location = new System.Drawing.Point(23, 100);
			this.dgvTransactions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.ReadOnly = true;
			this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(194)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTransactions.RowHeadersVisible = false;
			this.dgvTransactions.RowHeadersWidth = 21;
			this.dgvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTransactions.Size = new System.Drawing.Size(784, 501);
			this.dgvTransactions.Style = MetroFramework.MetroColorStyle.Magenta;
			this.dgvTransactions.TabIndex = 1;
			// 
			// colVorgangstyp
			// 
			this.colVorgangstyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.colVorgangstyp.DataPropertyName = "Vorgang";
			this.colVorgangstyp.HeaderText = "Vorgang";
			this.colVorgangstyp.Name = "colVorgangstyp";
			this.colVorgangstyp.ReadOnly = true;
			this.colVorgangstyp.Width = 74;
			// 
			// colNummer
			// 
			this.colNummer.DataPropertyName = "Nummer";
			this.colNummer.HeaderText = "Nummer";
			this.colNummer.MinimumWidth = 100;
			this.colNummer.Name = "colNummer";
			this.colNummer.ReadOnly = true;
			// 
			// colAuftrag
			// 
			this.colAuftrag.DataPropertyName = "Auftrag";
			this.colAuftrag.HeaderText = "Auftrag";
			this.colAuftrag.MinimumWidth = 100;
			this.colAuftrag.Name = "colAuftrag";
			this.colAuftrag.ReadOnly = true;
			// 
			// colDatum
			// 
			this.colDatum.DataPropertyName = "Datum";
			this.colDatum.HeaderText = "Datum";
			this.colDatum.MinimumWidth = 90;
			this.colDatum.Name = "colDatum";
			this.colDatum.ReadOnly = true;
			this.colDatum.Width = 90;
			// 
			// colArtikelnummer
			// 
			this.colArtikelnummer.DataPropertyName = "Artikelnummer";
			this.colArtikelnummer.HeaderText = "Artikel";
			this.colArtikelnummer.MinimumWidth = 200;
			this.colArtikelnummer.Name = "colArtikelnummer";
			this.colArtikelnummer.ReadOnly = true;
			this.colArtikelnummer.Width = 200;
			// 
			// colMenge
			// 
			this.colMenge.DataPropertyName = "Menge";
			this.colMenge.HeaderText = "Menge";
			this.colMenge.MinimumWidth = 100;
			this.colMenge.Name = "colMenge";
			this.colMenge.ReadOnly = true;
			// 
			// colGesamtpreis
			// 
			this.colGesamtpreis.DataPropertyName = "Gesamtpreis";
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.colGesamtpreis.DefaultCellStyle = dataGridViewCellStyle3;
			this.colGesamtpreis.HeaderText = "Gesamt netto";
			this.colGesamtpreis.MinimumWidth = 120;
			this.colGesamtpreis.Name = "colGesamtpreis";
			this.colGesamtpreis.ReadOnly = true;
			this.colGesamtpreis.Width = 120;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Location = new System.Drawing.Point(707, 624);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Magenta;
			this.mbtnClose.TabIndex = 2;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// TransactionListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(830, 673);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvTransactions);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TransactionListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowIcon = false;
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			this.Text = "Vorgangsliste für Artikel ...";
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTransactions;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVorgangstyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAuftrag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelnummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGesamtpreis;
		private MetroFramework.Controls.MetroButton mbtnClose;

	}
}