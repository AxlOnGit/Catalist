namespace Products.Common.Panel
{
	partial class PanelSoftwareliste
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSoftware = new MetroFramework.Controls.MetroGrid();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.mToolTipp = new MetroFramework.Components.MetroToolTip();
			this.colSoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLizenzSchluessel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHauptbenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInstallationsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSoftware
			// 
			this.dgvSoftware.AllowUserToAddRows = false;
			this.dgvSoftware.AllowUserToDeleteRows = false;
			this.dgvSoftware.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
			this.dgvSoftware.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSoftware.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSoftware.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSoftware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoftwareName,
            this.colLizenzSchluessel,
            this.colComputer,
            this.colHauptbenutzer,
            this.colInstallationsdatum,
            this.colAnmerkungen});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSoftware.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSoftware.EnableHeadersVisualStyles = false;
			this.dgvSoftware.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSoftware.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvSoftware.HighLightPercentage = 0.99F;
			this.dgvSoftware.Location = new System.Drawing.Point(23, 72);
			this.dgvSoftware.Name = "dgvSoftware";
			this.dgvSoftware.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSoftware.RowHeadersVisible = false;
			this.dgvSoftware.RowHeadersWidth = 21;
			this.dgvSoftware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSoftware.Size = new System.Drawing.Size(1234, 628);
			this.dgvSoftware.Style = MetroFramework.MetroColorStyle.Purple;
			this.dgvSoftware.TabIndex = 0;
			this.dgvSoftware.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_RowEnter);
			this.dgvSoftware.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSoftware_MouseDoubleClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metropurple;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(141, 30);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 10, 20, 20);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(36, 36);
			this.btnDelete.TabIndex = 3;
			this.mToolTipp.SetToolTip(this.btnDelete, "Löschen");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOpen.BackColor = System.Drawing.Color.Transparent;
			this.btnOpen.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metropurple;
			this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpen.FlatAppearance.BorderSize = 0;
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen.Location = new System.Drawing.Point(82, 30);
			this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(36, 36);
			this.btnOpen.TabIndex = 2;
			this.mToolTipp.SetToolTip(this.btnOpen, "Öffnen");
			this.btnOpen.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metropurple;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(23, 30);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(36, 36);
			this.btnAdd.TabIndex = 1;
			this.mToolTipp.SetToolTip(this.btnAdd, "Neu");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// mToolTipp
			// 
			this.mToolTipp.Style = MetroFramework.MetroColorStyle.Blue;
			this.mToolTipp.StyleManager = null;
			this.mToolTipp.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// colSoftwareName
			// 
			this.colSoftwareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSoftwareName.DataPropertyName = "Softwarename";
			this.colSoftwareName.FillWeight = 15F;
			this.colSoftwareName.HeaderText = "Software";
			this.colSoftwareName.Name = "colSoftwareName";
			// 
			// colLizenzSchluessel
			// 
			this.colLizenzSchluessel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLizenzSchluessel.DataPropertyName = "Lizenzschluessel";
			this.colLizenzSchluessel.FillWeight = 24F;
			this.colLizenzSchluessel.HeaderText = "Lizenz";
			this.colLizenzSchluessel.Name = "colLizenzSchluessel";
			// 
			// colComputer
			// 
			this.colComputer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colComputer.DataPropertyName = "Computer";
			this.colComputer.FillWeight = 7F;
			this.colComputer.HeaderText = "Computer";
			this.colComputer.Name = "colComputer";
			// 
			// colHauptbenutzer
			// 
			this.colHauptbenutzer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHauptbenutzer.DataPropertyName = "Hauptbenutzer";
			this.colHauptbenutzer.FillWeight = 7F;
			this.colHauptbenutzer.HeaderText = "Benutzer";
			this.colHauptbenutzer.Name = "colHauptbenutzer";
			// 
			// colInstallationsdatum
			// 
			this.colInstallationsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colInstallationsdatum.DataPropertyName = "Installationsdatum";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colInstallationsdatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colInstallationsdatum.FillWeight = 7F;
			this.colInstallationsdatum.HeaderText = "Installation";
			this.colInstallationsdatum.Name = "colInstallationsdatum";
			// 
			// colAnmerkungen
			// 
			this.colAnmerkungen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAnmerkungen.DataPropertyName = "Anmerkungen";
			this.colAnmerkungen.FillWeight = 40F;
			this.colAnmerkungen.HeaderText = "Bemerkungen";
			this.colAnmerkungen.Name = "colAnmerkungen";
			// 
			// pnlSoftwareliste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvSoftware);
			this.Name = "pnlSoftwareliste";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1280, 723);
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnAdd;
		private MetroFramework.Controls.MetroGrid dgvSoftware;
		private MetroFramework.Components.MetroToolTip mToolTipp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwareName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLizenzSchluessel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colComputer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHauptbenutzer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInstallationsdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAnmerkungen;
	}
}
