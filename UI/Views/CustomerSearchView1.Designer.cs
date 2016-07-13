namespace Products.Common.Views
{
	partial class CustomerSearchView1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSuchkunden = new MetroFramework.Controls.MetroGrid();
			this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSuchkunden)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSuchkunden
			// 
			this.dgvSuchkunden.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvSuchkunden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSuchkunden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSuchkunden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSuchkunden.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSuchkunden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSuchkunden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSuchkunden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSuchkunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSuchkunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colFund,
            this.colKundennummer,
            this.colFirma,
            this.colPLZ,
            this.colOrt});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSuchkunden.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSuchkunden.EnableHeadersVisualStyles = false;
			this.dgvSuchkunden.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSuchkunden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSuchkunden.HighLightPercentage = 0.99F;
			this.dgvSuchkunden.Location = new System.Drawing.Point(23, 100);
			this.dgvSuchkunden.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvSuchkunden.Name = "dgvSuchkunden";
			this.dgvSuchkunden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSuchkunden.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSuchkunden.RowHeadersVisible = false;
			this.dgvSuchkunden.RowHeadersWidth = 21;
			this.dgvSuchkunden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSuchkunden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSuchkunden.Size = new System.Drawing.Size(1126, 495);
			this.dgvSuchkunden.Style = MetroFramework.MetroColorStyle.Magenta;
			this.dgvSuchkunden.TabIndex = 0;
			this.dgvSuchkunden.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuchkunden_RowEnter);
			this.dgvSuchkunden.DoubleClick += new System.EventHandler(this.dgvSuchkunden_DoubleClick);
			// 
			// colTyp
			// 
			this.colTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTyp.DataPropertyName = "Typ";
			this.colTyp.FillWeight = 10F;
			this.colTyp.HeaderText = "Typ";
			this.colTyp.Name = "colTyp";
			// 
			// colFund
			// 
			this.colFund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFund.DataPropertyName = "Fund";
			this.colFund.FillWeight = 30F;
			this.colFund.HeaderText = "Gefunden";
			this.colFund.Name = "colFund";
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Kundennummer";
			this.colKundennummer.FillWeight = 10F;
			this.colKundennummer.HeaderText = "Kunden-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			// 
			// colFirma
			// 
			this.colFirma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFirma.DataPropertyName = "Firma";
			this.colFirma.FillWeight = 30F;
			this.colFirma.HeaderText = "Firma";
			this.colFirma.Name = "colFirma";
			// 
			// colPLZ
			// 
			this.colPLZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPLZ.DataPropertyName = "Plz";
			this.colPLZ.FillWeight = 10F;
			this.colPLZ.HeaderText = "Plz";
			this.colPLZ.Name = "colPLZ";
			// 
			// colOrt
			// 
			this.colOrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOrt.DataPropertyName = "Ort";
			this.colOrt.FillWeight = 20F;
			this.colOrt.HeaderText = "Ort";
			this.colOrt.Name = "colOrt";
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(925, 618);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 61;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1049, 618);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 62;
			this.mbtnClose.Text = "Abbrechen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			// 
			// CustomerSearchView1
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(1172, 667);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.dgvSuchkunden);
			this.Name = "CustomerSearchView1";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Magenta;
			this.Text = "Kundensuche";
			((System.ComponentModel.ISupportInitialize)(this.dgvSuchkunden)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvSuchkunden;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFund;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFirma;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPLZ;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
	}
}