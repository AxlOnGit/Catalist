namespace Products.Common.Views
{
	partial class ServiceterminListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceterminListView));
			this.lblKundenname = new MetroFramework.Controls.MetroLabel();
			this.dgvServicetermine = new MetroFramework.Controls.MetroGrid();
			this.colMaschinenmodell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTechnikername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTerminDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTerminUhrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colErstellername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colErstelltAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAddServicetermin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvServicetermine)).BeginInit();
			this.SuspendLayout();
			// 
			// lblKundenname
			// 
			this.lblKundenname.AutoSize = true;
			this.lblKundenname.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblKundenname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblKundenname.Location = new System.Drawing.Point(16, 94);
			this.lblKundenname.Name = "lblKundenname";
			this.lblKundenname.Size = new System.Drawing.Size(391, 25);
			this.lblKundenname.TabIndex = 0;
			this.lblKundenname.Text = "Theodor Bungert Werbetechnik GmbH && Co. KG";
			// 
			// dgvServicetermine
			// 
			this.dgvServicetermine.AllowUserToAddRows = false;
			this.dgvServicetermine.AllowUserToDeleteRows = false;
			this.dgvServicetermine.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvServicetermine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvServicetermine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvServicetermine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvServicetermine.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvServicetermine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvServicetermine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvServicetermine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvServicetermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServicetermine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaschinenmodell,
            this.colTechnikername,
            this.colTerminDatum,
            this.colTerminUhrzeit,
            this.colErstellername,
            this.colErstelltAm});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvServicetermine.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvServicetermine.EnableHeadersVisualStyles = false;
			this.dgvServicetermine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvServicetermine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvServicetermine.Location = new System.Drawing.Point(16, 134);
			this.dgvServicetermine.Name = "dgvServicetermine";
			this.dgvServicetermine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvServicetermine.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvServicetermine.RowHeadersWidth = 21;
			this.dgvServicetermine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvServicetermine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvServicetermine.Size = new System.Drawing.Size(946, 332);
			this.dgvServicetermine.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvServicetermine.TabIndex = 17;
			this.dgvServicetermine.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicetermine_RowEnter);
			this.dgvServicetermine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvServicetermine_MouseDoubleClick);
			// 
			// colMaschinenmodell
			// 
			this.colMaschinenmodell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinenmodell.DataPropertyName = "Maschinenmodell";
			this.colMaschinenmodell.FillWeight = 20.1F;
			this.colMaschinenmodell.HeaderText = "Maschinenmodell";
			this.colMaschinenmodell.MinimumWidth = 150;
			this.colMaschinenmodell.Name = "colMaschinenmodell";
			// 
			// colTechnikername
			// 
			this.colTechnikername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTechnikername.DataPropertyName = "Technikername";
			this.colTechnikername.FillWeight = 24.2F;
			this.colTechnikername.HeaderText = "Techniker";
			this.colTechnikername.MinimumWidth = 180;
			this.colTechnikername.Name = "colTechnikername";
			// 
			// colTerminDatum
			// 
			this.colTerminDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTerminDatum.DataPropertyName = "Termin";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colTerminDatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colTerminDatum.FillWeight = 10.7F;
			this.colTerminDatum.HeaderText = "Datum";
			this.colTerminDatum.MinimumWidth = 80;
			this.colTerminDatum.Name = "colTerminDatum";
			// 
			// colTerminUhrzeit
			// 
			this.colTerminUhrzeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTerminUhrzeit.DataPropertyName = "Termin";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "t";
			dataGridViewCellStyle4.NullValue = null;
			this.colTerminUhrzeit.DefaultCellStyle = dataGridViewCellStyle4;
			this.colTerminUhrzeit.FillWeight = 10.1F;
			this.colTerminUhrzeit.HeaderText = "Uhrzeit";
			this.colTerminUhrzeit.MinimumWidth = 75;
			this.colTerminUhrzeit.Name = "colTerminUhrzeit";
			// 
			// colErstellername
			// 
			this.colErstellername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colErstellername.DataPropertyName = "Erstellername";
			this.colErstellername.FillWeight = 24.2F;
			this.colErstellername.HeaderText = "erstellt von";
			this.colErstellername.MinimumWidth = 180;
			this.colErstellername.Name = "colErstellername";
			// 
			// colErstelltAm
			// 
			this.colErstelltAm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colErstelltAm.DataPropertyName = "ErstelltAm";
			this.colErstelltAm.FillWeight = 10.7F;
			this.colErstelltAm.HeaderText = "am";
			this.colErstelltAm.MinimumWidth = 80;
			this.colErstelltAm.Name = "colErstelltAm";
			// 
			// btnClose
			// 
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnClose.Location = new System.Drawing.Point(874, 521);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 30);
			this.btnClose.TabIndex = 18;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.AutoSize = true;
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.BackgroundImage = global::Products.Common.Properties.Resources.Garbage_metrogreen;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(84, 472);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(50, 50);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnAddServicetermin
			// 
			this.btnAddServicetermin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddServicetermin.AutoSize = true;
			this.btnAddServicetermin.BackColor = System.Drawing.Color.Transparent;
			this.btnAddServicetermin.BackgroundImage = global::Products.Common.Properties.Resources.Add_metrogreen;
			this.btnAddServicetermin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddServicetermin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddServicetermin.FlatAppearance.BorderSize = 0;
			this.btnAddServicetermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddServicetermin.Location = new System.Drawing.Point(16, 472);
			this.btnAddServicetermin.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
			this.btnAddServicetermin.Name = "btnAddServicetermin";
			this.btnAddServicetermin.Size = new System.Drawing.Size(50, 50);
			this.btnAddServicetermin.TabIndex = 15;
			this.btnAddServicetermin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddServicetermin.UseVisualStyleBackColor = false;
			this.btnAddServicetermin.Click += new System.EventHandler(this.btnAddServicetermin_Click);
			// 
			// ServiceterminListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 567);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvServicetermine);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddServicetermin);
			this.Controls.Add(this.lblKundenname);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ServiceterminListView";
			this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Serviceaufträge";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServicetermineListView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvServicetermine)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lblKundenname;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAddServicetermin;
		private MetroFramework.Controls.MetroGrid dgvServicetermine;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenmodell;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTechnikername;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTerminDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTerminUhrzeit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colErstellername;
		private System.Windows.Forms.DataGridViewTextBoxColumn colErstelltAm;
		private MetroFramework.Controls.MetroButton btnClose;
	}
}