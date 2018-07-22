namespace Products.Common.Views
{
	partial class LagerbestandView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagerbestandView));
			this.dgvProducts = new MetroFramework.Controls.MetroGrid();
			this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBezeichnung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBestandAktuell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBestelldatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBestellt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblIntro = new MetroFramework.Controls.MetroLabel();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikel,
            this.colBezeichnung1,
            this.colBezeichnung2,
            this.colBestandAktuell,
            this.colMengeneinheit,
            this.colBestelldatum,
            this.colBestellt});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvProducts.HighLightPercentage = 1.2F;
			this.dgvProducts.Location = new System.Drawing.Point(23, 100);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvProducts.MultiSelect = false;
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 21;
			this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProducts.RowTemplate.Height = 28;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(948, 470);
			this.dgvProducts.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvProducts.TabIndex = 0;
			// 
			// colArtikel
			// 
			this.colArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colArtikel.DataPropertyName = "Artikelnummer";
			this.colArtikel.FillWeight = 10F;
			this.colArtikel.HeaderText = "Artikel-Nr.";
			this.colArtikel.Name = "colArtikel";
			this.colArtikel.ReadOnly = true;
			// 
			// colBezeichnung1
			// 
			this.colBezeichnung1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung1.DataPropertyName = "Bezeichnung1";
			this.colBezeichnung1.FillWeight = 20F;
			this.colBezeichnung1.HeaderText = "Artikelname";
			this.colBezeichnung1.Name = "colBezeichnung1";
			this.colBezeichnung1.ReadOnly = true;
			// 
			// colBezeichnung2
			// 
			this.colBezeichnung2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBezeichnung2.DataPropertyName = "Bezeichnung2";
			this.colBezeichnung2.FillWeight = 20F;
			this.colBezeichnung2.HeaderText = "Artikelzusatz";
			this.colBezeichnung2.Name = "colBezeichnung2";
			this.colBezeichnung2.ReadOnly = true;
			// 
			// colBestandAktuell
			// 
			this.colBestandAktuell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBestandAktuell.DataPropertyName = "Bestand";
			this.colBestandAktuell.FillWeight = 10F;
			this.colBestandAktuell.HeaderText = "Lagerbestand";
			this.colBestandAktuell.Name = "colBestandAktuell";
			this.colBestandAktuell.ReadOnly = true;
			// 
			// colMengeneinheit
			// 
			this.colMengeneinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMengeneinheit.DataPropertyName = "Mengeneinheit";
			this.colMengeneinheit.FillWeight = 10F;
			this.colMengeneinheit.HeaderText = "ME";
			this.colMengeneinheit.MinimumWidth = 50;
			this.colMengeneinheit.Name = "colMengeneinheit";
			this.colMengeneinheit.ReadOnly = true;
			// 
			// colBestelldatum
			// 
			this.colBestelldatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBestelldatum.DataPropertyName = "LetzteBestellung";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = "-";
			this.colBestelldatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colBestelldatum.FillWeight = 13F;
			this.colBestelldatum.HeaderText = "Letzte Bestellung";
			this.colBestelldatum.Name = "colBestelldatum";
			this.colBestelldatum.ReadOnly = true;
			// 
			// colBestellt
			// 
			this.colBestellt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colBestellt.DataPropertyName = "LetzteLieferung";
			dataGridViewCellStyle4.NullValue = "-";
			this.colBestellt.DefaultCellStyle = dataGridViewCellStyle4;
			this.colBestellt.FillWeight = 13F;
			this.colBestellt.HeaderText = "Letzte Lieferung";
			this.colBestellt.Name = "colBestellt";
			this.colBestellt.ReadOnly = true;
			// 
			// lblIntro
			// 
			this.lblIntro.AutoSize = true;
			this.lblIntro.Location = new System.Drawing.Point(23, 78);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(94, 19);
			this.lblIntro.TabIndex = 65;
			this.lblIntro.Text = "Artikelgruppe ";
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(871, 595);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 68;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// LagerbestandView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 644);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.lblIntro);
			this.Controls.Add(this.dgvProducts);
			this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LagerbestandView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Lagerbestand";
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvProducts;
		private MetroFramework.Controls.MetroLabel lblIntro;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBezeichnung2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBestandAktuell;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMengeneinheit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBestelldatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBestellt;

	}
}