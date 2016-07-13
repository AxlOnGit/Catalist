namespace Products.Common.Views
{
	partial class MaschinenmodellView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaschinenmodellView));
			this.dgvModelle = new MetroFramework.Controls.MetroGrid();
			this.colHerstellerrId = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colMaschinenTypId = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colModellbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.btnAddMaschinenModell = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvModelle)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvModelle
			// 
			this.dgvModelle.AllowUserToAddRows = false;
			this.dgvModelle.AllowUserToDeleteRows = false;
			this.dgvModelle.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvModelle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvModelle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvModelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvModelle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvModelle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModelle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvModelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHerstellerrId,
            this.colMaschinenTypId,
            this.colModellbezeichnung});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvModelle.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvModelle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvModelle.EnableHeadersVisualStyles = false;
			this.dgvModelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvModelle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvModelle.HighLightPercentage = 0.9F;
			this.dgvModelle.Location = new System.Drawing.Point(23, 75);
			this.dgvModelle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvModelle.MultiSelect = false;
			this.dgvModelle.Name = "dgvModelle";
			this.dgvModelle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvModelle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvModelle.RowHeadersVisible = false;
			this.dgvModelle.RowHeadersWidth = 21;
			this.dgvModelle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvModelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvModelle.Size = new System.Drawing.Size(714, 550);
			this.dgvModelle.Style = MetroFramework.MetroColorStyle.Purple;
			this.dgvModelle.TabIndex = 0;
			// 
			// colHerstellerrId
			// 
			this.colHerstellerrId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHerstellerrId.DataPropertyName = "HerstellerId";
			this.colHerstellerrId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colHerstellerrId.FillWeight = 30F;
			this.colHerstellerrId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colHerstellerrId.HeaderText = "Hersteller";
			this.colHerstellerrId.MinimumWidth = 200;
			this.colHerstellerrId.Name = "colHerstellerrId";
			this.colHerstellerrId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colMaschinenTypId
			// 
			this.colMaschinenTypId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinenTypId.DataPropertyName = "MaschinentypId";
			this.colMaschinenTypId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colMaschinenTypId.FillWeight = 30F;
			this.colMaschinenTypId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colMaschinenTypId.HeaderText = "Maschinentyp";
			this.colMaschinenTypId.MinimumWidth = 150;
			this.colMaschinenTypId.Name = "colMaschinenTypId";
			this.colMaschinenTypId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colModellbezeichnung
			// 
			this.colModellbezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colModellbezeichnung.DataPropertyName = "Modellbezeichnung";
			this.colModellbezeichnung.FillWeight = 40F;
			this.colModellbezeichnung.HeaderText = "Modellbezeichnung";
			this.colModellbezeichnung.MinimumWidth = 300;
			this.colModellbezeichnung.Name = "colModellbezeichnung";
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnClose.Location = new System.Drawing.Point(637, 648);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Purple;
			this.mbtnClose.TabIndex = 51;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// btnAddMaschinenModell
			// 
			this.btnAddMaschinenModell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddMaschinenModell.BackColor = System.Drawing.Color.Transparent;
			this.btnAddMaschinenModell.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metropurple;
			this.btnAddMaschinenModell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddMaschinenModell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddMaschinenModell.FlatAppearance.BorderSize = 0;
			this.btnAddMaschinenModell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddMaschinenModell.Location = new System.Drawing.Point(23, 638);
			this.btnAddMaschinenModell.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnAddMaschinenModell.Name = "btnAddMaschinenModell";
			this.btnAddMaschinenModell.Size = new System.Drawing.Size(36, 36);
			this.btnAddMaschinenModell.TabIndex = 52;
			this.btnAddMaschinenModell.UseVisualStyleBackColor = false;
			this.btnAddMaschinenModell.Click += new System.EventHandler(this.btnAddMaschinenModell_Click);
			// 
			// MaschinenmodellView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnClose;
			this.ClientSize = new System.Drawing.Size(760, 697);
			this.Controls.Add(this.btnAddMaschinenModell);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvModelle);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MaschinenmodellView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "Maschinenmodelle";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaschinenmodellView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvModelle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvModelle;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.Button btnAddMaschinenModell;
		private System.Windows.Forms.DataGridViewComboBoxColumn colHerstellerrId;
		private System.Windows.Forms.DataGridViewComboBoxColumn colMaschinenTypId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModellbezeichnung;
	}
}