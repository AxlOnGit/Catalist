namespace Products.Common.Views
{
	partial class AuftraegeProArtikelView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAuftraege = new MetroFramework.Controls.MetroGrid();
            this.colAuftrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCtxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.mcmdCopyAuftrag = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuftraege)).BeginInit();
            this.MCtxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAuftraege
            // 
            this.DgvAuftraege.AllowUserToAddRows = false;
            this.DgvAuftraege.AllowUserToDeleteRows = false;
            this.DgvAuftraege.AllowUserToResizeRows = false;
            this.DgvAuftraege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAuftraege.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvAuftraege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAuftraege.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvAuftraege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAuftraege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuftraege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuftrag,
            this.colDatum,
            this.colFirma});
            this.DgvAuftraege.ContextMenuStrip = this.MCtxGrid;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAuftraege.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAuftraege.EnableHeadersVisualStyles = false;
            this.DgvAuftraege.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvAuftraege.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvAuftraege.Location = new System.Drawing.Point(23, 100);
            this.DgvAuftraege.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.DgvAuftraege.Name = "DgvAuftraege";
            this.DgvAuftraege.ReadOnly = true;
            this.DgvAuftraege.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAuftraege.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAuftraege.RowHeadersVisible = false;
            this.DgvAuftraege.RowHeadersWidth = 21;
            this.DgvAuftraege.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAuftraege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAuftraege.Size = new System.Drawing.Size(737, 494);
            this.DgvAuftraege.Style = MetroFramework.MetroColorStyle.Green;
            this.DgvAuftraege.TabIndex = 0;
            this.DgvAuftraege.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAuftraege_RowEnter);
            // 
            // colAuftrag
            // 
            this.colAuftrag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuftrag.DataPropertyName = "Auftrag";
            this.colAuftrag.FillWeight = 20F;
            this.colAuftrag.HeaderText = "Auftrag";
            this.colAuftrag.Name = "colAuftrag";
            this.colAuftrag.ReadOnly = true;
            // 
            // colDatum
            // 
            this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDatum.DataPropertyName = "Datum";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colDatum.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDatum.FillWeight = 20F;
            this.colDatum.HeaderText = "vom";
            this.colDatum.Name = "colDatum";
            this.colDatum.ReadOnly = true;
            // 
            // colFirma
            // 
            this.colFirma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFirma.DataPropertyName = "Firma";
            this.colFirma.FillWeight = 60F;
            this.colFirma.HeaderText = "Kunde";
            this.colFirma.Name = "colFirma";
            this.colFirma.ReadOnly = true;
            // 
            // MCtxGrid
            // 
            this.MCtxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcmdCopyAuftrag});
            this.MCtxGrid.Name = "mctxGrid";
            this.MCtxGrid.Size = new System.Drawing.Size(215, 26);
            // 
            // mcmdCopyAuftrag
            // 
            this.mcmdCopyAuftrag.Name = "mcmdCopyAuftrag";
            this.mcmdCopyAuftrag.Size = new System.Drawing.Size(214, 22);
            this.mcmdCopyAuftrag.Text = "Auftragsnummer kopieren";
            this.mcmdCopyAuftrag.Click += new System.EventHandler(this.McmdCopyAuftrag_Click);
            // 
            // MBtnClose
            // 
            this.MBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnClose.Image = null;
            this.MBtnClose.Location = new System.Drawing.Point(660, 617);
            this.MBtnClose.Name = "MBtnClose";
            this.MBtnClose.Size = new System.Drawing.Size(100, 26);
            this.MBtnClose.TabIndex = 13;
            this.MBtnClose.Text = "Schließen";
            this.MBtnClose.UseSelectable = true;
            this.MBtnClose.UseVisualStyleBackColor = true;
            this.MBtnClose.Click += new System.EventHandler(this.MbtnClose_Click);
            // 
            // AuftraegeProArtikelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 666);
            this.Controls.Add(this.MBtnClose);
            this.Controls.Add(this.DgvAuftraege);
            this.Name = "AuftraegeProArtikelView";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Aufträge für ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuftraege)).EndInit();
            this.MCtxGrid.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid DgvAuftraege;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAuftrag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFirma;
		private MetroFramework.Controls.MetroContextMenu MCtxGrid;
		private System.Windows.Forms.ToolStripMenuItem mcmdCopyAuftrag;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton MBtnClose;
	}
}