namespace Products.Common.Views
{
	partial class TintenListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TintenListView));
			this.dgvTinten = new MetroFramework.Controls.MetroGrid();
			this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTintenbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHersteller = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.btnNeueTinte = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTinten)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTinten
			// 
			this.dgvTinten.AllowUserToAddRows = false;
			this.dgvTinten.AllowUserToDeleteRows = false;
			this.dgvTinten.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvTinten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTinten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTinten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTinten.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTinten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTinten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(109)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTinten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTinten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTinten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colTintenbezeichnung,
            this.colHersteller});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(109)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTinten.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTinten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.dgvTinten.EnableHeadersVisualStyles = false;
			this.dgvTinten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTinten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTinten.HighLightPercentage = 0.9F;
			this.dgvTinten.Location = new System.Drawing.Point(23, 100);
			this.dgvTinten.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvTinten.Name = "dgvTinten";
			this.dgvTinten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(109)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTinten.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTinten.RowHeadersVisible = false;
			this.dgvTinten.RowHeadersWidth = 21;
			this.dgvTinten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTinten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTinten.Size = new System.Drawing.Size(506, 650);
			this.dgvTinten.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvTinten.TabIndex = 0;
			// 
			// colTyp
			// 
			this.colTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTyp.DataPropertyName = "Typ";
			this.colTyp.HeaderText = "Tintentyp";
			this.colTyp.Name = "colTyp";
			// 
			// colTintenbezeichnung
			// 
			this.colTintenbezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTintenbezeichnung.DataPropertyName = "Tintenbezeichnung";
			this.colTintenbezeichnung.HeaderText = "Name";
			this.colTintenbezeichnung.Name = "colTintenbezeichnung";
			// 
			// colHersteller
			// 
			this.colHersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHersteller.DataPropertyName = "HerstellerId";
			this.colHersteller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colHersteller.HeaderText = "Hersteller";
			this.colHersteller.Name = "colHersteller";
			this.colHersteller.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colHersteller.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Location = new System.Drawing.Point(429, 773);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Red;
			this.mbtnClose.TabIndex = 1;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			// 
			// btnNeueTinte
			// 
			this.btnNeueTinte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeueTinte.BackColor = System.Drawing.Color.Transparent;
			this.btnNeueTinte.BackgroundImage = global::Products.Common.Properties.Resources.neu_metrored;
			this.btnNeueTinte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNeueTinte.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnNeueTinte.FlatAppearance.BorderSize = 0;
			this.btnNeueTinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeueTinte.Location = new System.Drawing.Point(23, 763);
			this.btnNeueTinte.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnNeueTinte.Name = "btnNeueTinte";
			this.btnNeueTinte.Size = new System.Drawing.Size(36, 36);
			this.btnNeueTinte.TabIndex = 53;
			this.btnNeueTinte.UseVisualStyleBackColor = false;
			this.btnNeueTinte.Click += new System.EventHandler(this.btnNeueTinte_Click);
			// 
			// TintenListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(552, 822);
			this.Controls.Add(this.btnNeueTinte);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvTinten);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TintenListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Tinten";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TintenListView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvTinten)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTinten;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTintenbezeichnung;
		private System.Windows.Forms.DataGridViewComboBoxColumn colHersteller;
		private System.Windows.Forms.Button btnNeueTinte;
	}
}