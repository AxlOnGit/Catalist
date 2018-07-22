namespace Products.Common.Views
{
	partial class SoftwareUpgradeListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareUpgradeListView));
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.dgvSoftwareUpgrades = new MetroFramework.Controls.MetroGrid();
			this.mbtnNewSoftwareUpgrade = new MetroFramework.Controls.MetroButton();
			this.colMatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlteVersionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlteLizenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNeueVersionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNeueLizenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinenmodell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAngefordertAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colErhaltenAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareUpgrades)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(1181, 710);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnClose.TabIndex = 0;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseCustomBackColor = true;
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// dgvSoftwareUpgrades
			// 
			this.dgvSoftwareUpgrades.AllowUserToAddRows = false;
			this.dgvSoftwareUpgrades.AllowUserToDeleteRows = false;
			this.dgvSoftwareUpgrades.AllowUserToResizeRows = false;
			this.dgvSoftwareUpgrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSoftwareUpgrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftwareUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSoftwareUpgrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSoftwareUpgrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftwareUpgrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSoftwareUpgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSoftwareUpgrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatchcode,
            this.colAlteVersionName,
            this.colAlteLizenz,
            this.colNeueVersionName,
            this.colNeueLizenz,
            this.colMaschinenmodell,
            this.colSeriennummer,
            this.colAngefordertAm,
            this.colErhaltenAm});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSoftwareUpgrades.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSoftwareUpgrades.EnableHeadersVisualStyles = false;
			this.dgvSoftwareUpgrades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSoftwareUpgrades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftwareUpgrades.HighLightPercentage = 1.2F;
			this.dgvSoftwareUpgrades.Location = new System.Drawing.Point(23, 100);
			this.dgvSoftwareUpgrades.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvSoftwareUpgrades.Name = "dgvSoftwareUpgrades";
			this.dgvSoftwareUpgrades.ReadOnly = true;
			this.dgvSoftwareUpgrades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftwareUpgrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSoftwareUpgrades.RowHeadersVisible = false;
			this.dgvSoftwareUpgrades.RowHeadersWidth = 21;
			this.dgvSoftwareUpgrades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSoftwareUpgrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSoftwareUpgrades.Size = new System.Drawing.Size(1258, 587);
			this.dgvSoftwareUpgrades.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvSoftwareUpgrades.TabIndex = 1;
			this.dgvSoftwareUpgrades.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftwareUpgrades_RowEnter);
			this.dgvSoftwareUpgrades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSoftwareUpgrades_MouseDoubleClick);
			// 
			// mbtnNewSoftwareUpgrade
			// 
			this.mbtnNewSoftwareUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnNewSoftwareUpgrade.Location = new System.Drawing.Point(23, 710);
			this.mbtnNewSoftwareUpgrade.Name = "mbtnNewSoftwareUpgrade";
			this.mbtnNewSoftwareUpgrade.Size = new System.Drawing.Size(100, 26);
			this.mbtnNewSoftwareUpgrade.Style = MetroFramework.MetroColorStyle.Lime;
			this.mbtnNewSoftwareUpgrade.TabIndex = 2;
			this.mbtnNewSoftwareUpgrade.Text = "Neu ...";
			this.mbtnNewSoftwareUpgrade.UseCustomBackColor = true;
			this.mbtnNewSoftwareUpgrade.UseSelectable = true;
			this.mbtnNewSoftwareUpgrade.UseStyleColors = true;
			this.mbtnNewSoftwareUpgrade.Click += new System.EventHandler(this.mbtnNewSoftwareUpgrade_Click);
			// 
			// colMatchcode
			// 
			this.colMatchcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMatchcode.DataPropertyName = "Matchcode";
			this.colMatchcode.FillWeight = 14F;
			this.colMatchcode.HeaderText = "Kunde";
			this.colMatchcode.Name = "colMatchcode";
			this.colMatchcode.ReadOnly = true;
			// 
			// colAlteVersionName
			// 
			this.colAlteVersionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAlteVersionName.DataPropertyName = "AlteVersionName";
			this.colAlteVersionName.FillWeight = 9F;
			this.colAlteVersionName.HeaderText = "Alte Software";
			this.colAlteVersionName.Name = "colAlteVersionName";
			this.colAlteVersionName.ReadOnly = true;
			// 
			// colAlteLizenz
			// 
			this.colAlteLizenz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAlteLizenz.DataPropertyName = "AlteLizenz";
			this.colAlteLizenz.FillWeight = 21F;
			this.colAlteLizenz.HeaderText = "Alte Lizenz";
			this.colAlteLizenz.Name = "colAlteLizenz";
			this.colAlteLizenz.ReadOnly = true;
			// 
			// colNeueVersionName
			// 
			this.colNeueVersionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNeueVersionName.DataPropertyName = "NeueVersionName";
			this.colNeueVersionName.FillWeight = 9F;
			this.colNeueVersionName.HeaderText = "Neue Software";
			this.colNeueVersionName.Name = "colNeueVersionName";
			this.colNeueVersionName.ReadOnly = true;
			// 
			// colNeueLizenz
			// 
			this.colNeueLizenz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNeueLizenz.DataPropertyName = "NeueLizenz";
			this.colNeueLizenz.FillWeight = 21F;
			this.colNeueLizenz.HeaderText = "Neue Lizenz";
			this.colNeueLizenz.Name = "colNeueLizenz";
			this.colNeueLizenz.ReadOnly = true;
			// 
			// colMaschinenmodell
			// 
			this.colMaschinenmodell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinenmodell.DataPropertyName = "Maschinenmodell";
			this.colMaschinenmodell.FillWeight = 7F;
			this.colMaschinenmodell.HeaderText = "Maschine";
			this.colMaschinenmodell.Name = "colMaschinenmodell";
			this.colMaschinenmodell.ReadOnly = true;
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			this.colSeriennummer.FillWeight = 7F;
			this.colSeriennummer.HeaderText = "Seriennummer";
			this.colSeriennummer.Name = "colSeriennummer";
			this.colSeriennummer.ReadOnly = true;
			// 
			// colAngefordertAm
			// 
			this.colAngefordertAm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAngefordertAm.DataPropertyName = "AngefordertAm";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colAngefordertAm.DefaultCellStyle = dataGridViewCellStyle2;
			this.colAngefordertAm.FillWeight = 6F;
			this.colAngefordertAm.HeaderText = "Angefordert";
			this.colAngefordertAm.Name = "colAngefordertAm";
			this.colAngefordertAm.ReadOnly = true;
			// 
			// colErhaltenAm
			// 
			this.colErhaltenAm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colErhaltenAm.DataPropertyName = "ErhaltenAm";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colErhaltenAm.DefaultCellStyle = dataGridViewCellStyle3;
			this.colErhaltenAm.FillWeight = 6F;
			this.colErhaltenAm.HeaderText = "Erhalten";
			this.colErhaltenAm.Name = "colErhaltenAm";
			this.colErhaltenAm.ReadOnly = true;
			// 
			// SoftwareUpgradeListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1304, 759);
			this.Controls.Add(this.mbtnNewSoftwareUpgrade);
			this.Controls.Add(this.dgvSoftwareUpgrades);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SoftwareUpgradeListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Software-Upgrades";
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareUpgrades)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroGrid dgvSoftwareUpgrades;
		private MetroFramework.Controls.MetroButton mbtnNewSoftwareUpgrade;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatchcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAlteVersionName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAlteLizenz;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNeueVersionName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNeueLizenz;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenmodell;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAngefordertAm;
		private System.Windows.Forms.DataGridViewTextBoxColumn colErhaltenAm;
	}
}