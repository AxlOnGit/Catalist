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
			this.dgvAuftraege = new MetroFramework.Controls.MetroGrid();
			this.colAuftrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.mcmdCopyAuftrag = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuftraege)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAuftraege
			// 
			this.dgvAuftraege.AllowUserToAddRows = false;
			this.dgvAuftraege.AllowUserToDeleteRows = false;
			this.dgvAuftraege.AllowUserToResizeRows = false;
			this.dgvAuftraege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAuftraege.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAuftraege.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAuftraege.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAuftraege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAuftraege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuftraege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuftrag,
            this.colDatum,
            this.colFirma});
			this.dgvAuftraege.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAuftraege.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAuftraege.EnableHeadersVisualStyles = false;
			this.dgvAuftraege.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvAuftraege.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAuftraege.Location = new System.Drawing.Point(23, 100);
			this.dgvAuftraege.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvAuftraege.Name = "dgvAuftraege";
			this.dgvAuftraege.ReadOnly = true;
			this.dgvAuftraege.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAuftraege.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAuftraege.RowHeadersVisible = false;
			this.dgvAuftraege.RowHeadersWidth = 21;
			this.dgvAuftraege.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvAuftraege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAuftraege.Size = new System.Drawing.Size(737, 494);
			this.dgvAuftraege.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvAuftraege.TabIndex = 0;
			this.dgvAuftraege.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuftraege_RowEnter);
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
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcmdCopyAuftrag});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new System.Drawing.Size(215, 26);
			// 
			// mcmdCopyAuftrag
			// 
			this.mcmdCopyAuftrag.Name = "mcmdCopyAuftrag";
			this.mcmdCopyAuftrag.Size = new System.Drawing.Size(214, 22);
			this.mcmdCopyAuftrag.Text = "Auftragsnummer kopieren";
			this.mcmdCopyAuftrag.Click += new System.EventHandler(this.mcmdCopyAuftrag_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(660, 617);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 13;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// AuftraegeProArtikelView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 666);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvAuftraege);
			this.Name = "AuftraegeProArtikelView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Aufträge für ";
			((System.ComponentModel.ISupportInitialize)(this.dgvAuftraege)).EndInit();
			this.mctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvAuftraege;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAuftrag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFirma;
		private MetroFramework.Controls.MetroContextMenu mctxGrid;
		private System.Windows.Forms.ToolStripMenuItem mcmdCopyAuftrag;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
	}
}