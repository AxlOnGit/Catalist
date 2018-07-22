namespace Products.Common.Panel
{
	partial class pnlMaschinenListe
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvMachines = new MetroFramework.Controls.MetroGrid();
			this.colModell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinentyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFarbset = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKaufdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGekauftBei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.mcmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuServicetermine = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuMove = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mcmnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
			this.mHtmlTip = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.mbtnMove = new MetroFramework.Controls.MetroButton();
			this.mbtnOpen = new MetroFramework.Controls.MetroButton();
			this.mbtNew = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMachines
			// 
			this.dgvMachines.AllowUserToAddRows = false;
			this.dgvMachines.AllowUserToDeleteRows = false;
			this.dgvMachines.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMachines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(173)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModell,
            this.colSeriennummer,
            this.colMaschinentyp,
            this.colHersteller,
            this.colTinte,
            this.colFarbset,
            this.colKaufdatum,
            this.colAnmerkungen,
            this.colGekauftBei});
			this.dgvMachines.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(173)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMachines.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvMachines.EnableHeadersVisualStyles = false;
			this.dgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.HighLightPercentage = 0.8F;
			this.dgvMachines.Location = new System.Drawing.Point(22, 140);
			this.dgvMachines.Margin = new System.Windows.Forms.Padding(2);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(173)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvMachines.RowHeadersVisible = false;
			this.dgvMachines.RowHeadersWidth = 21;
			this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMachines.Size = new System.Drawing.Size(1236, 561);
			this.dgvMachines.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvMachines.TabIndex = 0;
			this.dgvMachines.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_RowEnter);
			this.dgvMachines.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMachines_MouseDoubleClick);
			// 
			// colModell
			// 
			this.colModell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colModell.DataPropertyName = "Modellbezeichnung";
			this.colModell.HeaderText = "Maschine";
			this.colModell.Name = "colModell";
			this.colModell.ReadOnly = true;
			this.colModell.Width = 79;
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			this.colSeriennummer.HeaderText = "Serien-Nr.";
			this.colSeriennummer.Name = "colSeriennummer";
			this.colSeriennummer.Width = 81;
			// 
			// colMaschinentyp
			// 
			this.colMaschinentyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colMaschinentyp.DataPropertyName = "Maschinentyp";
			this.colMaschinentyp.HeaderText = "Typ";
			this.colMaschinentyp.MinimumWidth = 120;
			this.colMaschinentyp.Name = "colMaschinentyp";
			this.colMaschinentyp.Width = 120;
			// 
			// colHersteller
			// 
			this.colHersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHersteller.DataPropertyName = "Herstellername";
			this.colHersteller.HeaderText = "Hersteller";
			this.colHersteller.MinimumWidth = 120;
			this.colHersteller.Name = "colHersteller";
			this.colHersteller.Width = 120;
			// 
			// colTinte
			// 
			this.colTinte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTinte.DataPropertyName = "Tinte";
			this.colTinte.HeaderText = "Tinte";
			this.colTinte.Name = "colTinte";
			this.colTinte.ReadOnly = true;
			this.colTinte.Width = 55;
			// 
			// colFarbset
			// 
			this.colFarbset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colFarbset.DataPropertyName = "Farbset";
			this.colFarbset.HeaderText = "Farbset";
			this.colFarbset.Name = "colFarbset";
			this.colFarbset.Width = 68;
			// 
			// colKaufdatum
			// 
			this.colKaufdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKaufdatum.DataPropertyName = "Lieferdatum";
			dataGridViewCellStyle8.Format = "d";
			dataGridViewCellStyle8.NullValue = null;
			this.colKaufdatum.DefaultCellStyle = dataGridViewCellStyle8;
			this.colKaufdatum.HeaderText = "Lieferung";
			this.colKaufdatum.Name = "colKaufdatum";
			this.colKaufdatum.Width = 79;
			// 
			// colAnmerkungen
			// 
			this.colAnmerkungen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAnmerkungen.DataPropertyName = "Anmerkungen";
			this.colAnmerkungen.HeaderText = "Anmerkungen";
			this.colAnmerkungen.MinimumWidth = 400;
			this.colAnmerkungen.Name = "colAnmerkungen";
			this.colAnmerkungen.Width = 400;
			// 
			// colGekauftBei
			// 
			this.colGekauftBei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colGekauftBei.DataPropertyName = "Haendler";
			this.colGekauftBei.HeaderText = "Händler";
			this.colGekauftBei.Name = "colGekauftBei";
			this.colGekauftBei.Width = 71;
			// 
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcmnuOpen,
            this.mcmnuNew,
            this.mcmnuServicetermine,
            this.mcmnuMove,
            this.toolStripMenuItem1,
            this.mcmnuDelete});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new System.Drawing.Size(153, 120);
			this.mctxGrid.Opening += new System.ComponentModel.CancelEventHandler(this.mctxGrid_Opening);
			// 
			// mcmnuOpen
			// 
			this.mcmnuOpen.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.mcmnuOpen.Name = "mcmnuOpen";
			this.mcmnuOpen.Size = new System.Drawing.Size(152, 22);
			this.mcmnuOpen.Text = "Öffnen";
			this.mcmnuOpen.Click += new System.EventHandler(this.mcmnuMaschineAnzeigen_Click);
			// 
			// mcmnuNew
			// 
			this.mcmnuNew.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.mcmnuNew.Name = "mcmnuNew";
			this.mcmnuNew.Size = new System.Drawing.Size(152, 22);
			this.mcmnuNew.Text = "Neu";
			this.mcmnuNew.Click += new System.EventHandler(this.mcmnuNeueMaschine_Click);
			// 
			// mcmnuServicetermine
			// 
			this.mcmnuServicetermine.Image = global::Products.Common.Properties.Resources.calendar_16_metroyellow;
			this.mcmnuServicetermine.Name = "mcmnuServicetermine";
			this.mcmnuServicetermine.Size = new System.Drawing.Size(152, 22);
			this.mcmnuServicetermine.Text = "Servicetermine";
			this.mcmnuServicetermine.Click += new System.EventHandler(this.mcmnuTermineAnzeigen_Click);
			// 
			// mcmnuMove
			// 
			this.mcmnuMove.Image = global::Products.Common.Properties.Resources.move_16_metroyellow;
			this.mcmnuMove.Name = "mcmnuMove";
			this.mcmnuMove.Size = new System.Drawing.Size(152, 22);
			this.mcmnuMove.Text = "Verschieben";
			this.mcmnuMove.Click += new System.EventHandler(this.mcmnuVerschieben_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// mcmnuDelete
			// 
			this.mcmnuDelete.Image = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.mcmnuDelete.Name = "mcmnuDelete";
			this.mcmnuDelete.Size = new System.Drawing.Size(152, 22);
			this.mcmnuDelete.Text = "Löschen";
			this.mcmnuDelete.Click += new System.EventHandler(this.mcmnuDelete_Click);
			// 
			// mlblTitel
			// 
			this.mlblTitel.AutoSize = true;
			this.mlblTitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblTitel.Location = new System.Drawing.Point(22, 20);
			this.mlblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblTitel.Name = "mlblTitel";
			this.mlblTitel.Size = new System.Drawing.Size(94, 25);
			this.mlblTitel.TabIndex = 0;
			this.mlblTitel.Text = "Maschinen";
			// 
			// mHtmlTip
			// 
			this.mHtmlTip.AutoPopDelay = 5000;
			this.mHtmlTip.BackColor = System.Drawing.Color.Transparent;
			this.mHtmlTip.InitialDelay = 400;
			this.mHtmlTip.OwnerDraw = true;
			this.mHtmlTip.ReshowDelay = 100;
			this.mHtmlTip.UseAnimation = false;
			this.mHtmlTip.UseFading = false;
			// 
			// mbtnMove
			// 
			this.mbtnMove.BackColor = System.Drawing.Color.Transparent;
			this.mbtnMove.BackgroundImage = global::Products.Common.Properties.Resources.move_32_metroorange;
			this.mbtnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnMove.Location = new System.Drawing.Point(138, 100);
			this.mbtnMove.Margin = new System.Windows.Forms.Padding(2, 20, 20, 2);
			this.mbtnMove.Name = "mbtnMove";
			this.mbtnMove.Size = new System.Drawing.Size(36, 36);
			this.mbtnMove.TabIndex = 4;
			this.mHtmlTip.SetToolTip(this.mbtnMove, "Maschine zu anderem Kunden verschieben");
			this.mbtnMove.UseCustomBackColor = true;
			this.mbtnMove.UseSelectable = true;
			this.mbtnMove.Click += new System.EventHandler(this.mbtnVerschieben_Click);
			// 
			// mbtnOpen
			// 
			this.mbtnOpen.BackColor = System.Drawing.Color.Transparent;
			this.mbtnOpen.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metroorange;
			this.mbtnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnOpen.Location = new System.Drawing.Point(22, 100);
			this.mbtnOpen.Margin = new System.Windows.Forms.Padding(2, 20, 20, 2);
			this.mbtnOpen.Name = "mbtnOpen";
			this.mbtnOpen.Size = new System.Drawing.Size(36, 36);
			this.mbtnOpen.TabIndex = 1;
			this.mHtmlTip.SetToolTip(this.mbtnOpen, "Maschine öffnen");
			this.mbtnOpen.UseCustomBackColor = true;
			this.mbtnOpen.UseSelectable = true;
			this.mbtnOpen.Click += new System.EventHandler(this.mbtnMaschineAnzeigen_Click);
			// 
			// mbtNew
			// 
			this.mbtNew.BackColor = System.Drawing.Color.Transparent;
			this.mbtNew.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metroorange;
			this.mbtNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtNew.Location = new System.Drawing.Point(80, 100);
			this.mbtNew.Margin = new System.Windows.Forms.Padding(2, 20, 20, 2);
			this.mbtNew.Name = "mbtNew";
			this.mbtNew.Size = new System.Drawing.Size(36, 36);
			this.mbtNew.TabIndex = 2;
			this.mHtmlTip.SetToolTip(this.mbtNew, "Neue Maschine");
			this.mbtNew.UseCustomBackColor = true;
			this.mbtNew.UseSelectable = true;
			this.mbtNew.Click += new System.EventHandler(this.mbtNeueMaschine_Click);
			// 
			// pnlMaschinenListe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mbtnMove);
			this.Controls.Add(this.mbtnOpen);
			this.Controls.Add(this.mbtNew);
			this.Controls.Add(this.dgvMachines);
			this.Controls.Add(this.mlblTitel);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "pnlMaschinenListe";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1280, 723);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pnlMaschinen_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
			this.mctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroFramework.Controls.MetroLabel mlblTitel;
		MetroFramework.Controls.MetroGrid dgvMachines;
		MetroFramework.Controls.MetroButton mbtNew;
		MetroFramework.Controls.MetroButton mbtnOpen;
		MetroFramework.Controls.MetroContextMenu mctxGrid;
		System.Windows.Forms.ToolStripMenuItem mcmnuOpen;
		System.Windows.Forms.ToolStripMenuItem mcmnuNew;
		System.Windows.Forms.ToolStripMenuItem mcmnuServicetermine;
		System.Windows.Forms.ToolStripMenuItem mcmnuMove;
		MetroFramework.Controls.MetroButton mbtnMove;
		System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		System.Windows.Forms.ToolStripMenuItem mcmnuDelete;
		MetroFramework.Drawing.Html.HtmlToolTip mHtmlTip;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModell;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinentyp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHersteller;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTinte;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFarbset;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKaufdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAnmerkungen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGekauftBei;
	}
}
