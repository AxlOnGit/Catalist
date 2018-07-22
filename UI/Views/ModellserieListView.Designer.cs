namespace Products.Common.Views
{
	partial class ModellserieListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModellserieListView));
			this.dgvModellserien = new MetroFramework.Controls.MetroGrid();
			this.colSerienname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinentyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWartungskennzeichen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colWartungsintervall = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMarkteinfuehrung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvModellserien)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvModellserien
			// 
			this.dgvModellserien.AllowUserToAddRows = false;
			this.dgvModellserien.AllowUserToDeleteRows = false;
			this.dgvModellserien.AllowUserToResizeRows = false;
			this.dgvModellserien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvModellserien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModellserien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvModellserien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvModellserien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModellserien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvModellserien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModellserien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerienname,
            this.colHersteller,
            this.colMaschinentyp,
            this.colWartungskennzeichen,
            this.colWartungsintervall,
            this.colMarkteinfuehrung});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvModellserien.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvModellserien.EnableHeadersVisualStyles = false;
			this.dgvModellserien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvModellserien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModellserien.HighLightPercentage = 1.2F;
			this.dgvModellserien.Location = new System.Drawing.Point(23, 108);
			this.dgvModellserien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvModellserien.Name = "dgvModellserien";
			this.dgvModellserien.ReadOnly = true;
			this.dgvModellserien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModellserien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvModellserien.RowHeadersVisible = false;
			this.dgvModellserien.RowHeadersWidth = 21;
			this.dgvModellserien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvModellserien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvModellserien.Size = new System.Drawing.Size(846, 481);
			this.dgvModellserien.TabIndex = 0;
			// 
			// colSerienname
			// 
			this.colSerienname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSerienname.DataPropertyName = "Serienname";
			this.colSerienname.FillWeight = 25F;
			this.colSerienname.HeaderText = "Serie";
			this.colSerienname.Name = "colSerienname";
			this.colSerienname.ReadOnly = true;
			// 
			// colHersteller
			// 
			this.colHersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHersteller.DataPropertyName = "Herstellername";
			this.colHersteller.FillWeight = 30F;
			this.colHersteller.HeaderText = "Hersteller";
			this.colHersteller.Name = "colHersteller";
			this.colHersteller.ReadOnly = true;
			// 
			// colMaschinentyp
			// 
			this.colMaschinentyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinentyp.DataPropertyName = "Typbezeichnung";
			this.colMaschinentyp.FillWeight = 15F;
			this.colMaschinentyp.HeaderText = "Typ";
			this.colMaschinentyp.Name = "colMaschinentyp";
			this.colMaschinentyp.ReadOnly = true;
			// 
			// colWartungskennzeichen
			// 
			this.colWartungskennzeichen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colWartungskennzeichen.DataPropertyName = "Wartungskennzeichen";
			this.colWartungskennzeichen.FillWeight = 8F;
			this.colWartungskennzeichen.HeaderText = "Wartung";
			this.colWartungskennzeichen.Name = "colWartungskennzeichen";
			this.colWartungskennzeichen.ReadOnly = true;
			// 
			// colWartungsintervall
			// 
			this.colWartungsintervall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colWartungsintervall.DataPropertyName = "Wartungsintervall";
			this.colWartungsintervall.FillWeight = 8F;
			this.colWartungsintervall.HeaderText = "Intervall";
			this.colWartungsintervall.Name = "colWartungsintervall";
			this.colWartungsintervall.ReadOnly = true;
			// 
			// colMarkteinfuehrung
			// 
			this.colMarkteinfuehrung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMarkteinfuehrung.DataPropertyName = "Markteinfuehrung";
			this.colMarkteinfuehrung.FillWeight = 14F;
			this.colMarkteinfuehrung.HeaderText = "Markteinführung";
			this.colMarkteinfuehrung.Name = "colMarkteinfuehrung";
			this.colMarkteinfuehrung.ReadOnly = true;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(769, 612);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 4;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// ModellserieListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 661);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvModellserien);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ModellserieListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Text = "Modellserien";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dgvModellserien)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvModellserien;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSerienname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHersteller;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinentyp;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colWartungskennzeichen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWartungsintervall;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMarkteinfuehrung;
	}
}