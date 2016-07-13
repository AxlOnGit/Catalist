namespace Products.Common.Panel
{
	partial class pnlMaschinen
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMaschinen));
			this.dgvMachines = new MetroFramework.Controls.MetroGrid();
			this.colModell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaschinentyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKaufdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGekauftBei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFarbset = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
			this.mHtmlTip = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.mbtnMove = new MetroFramework.Controls.MetroButton();
			this.mbtnServicetermine = new MetroFramework.Controls.MetroButton();
			this.mbtnOpen = new MetroFramework.Controls.MetroButton();
			this.mbtNew = new MetroFramework.Controls.MetroButton();
			this.mcmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuServicetermine = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuMove = new System.Windows.Forms.ToolStripMenuItem();
			this.mcmnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMachines
			// 
			this.dgvMachines.AllowUserToAddRows = false;
			this.dgvMachines.AllowUserToDeleteRows = false;
			this.dgvMachines.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMachines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModell,
            this.colMaschinentyp,
            this.colHersteller,
            this.colSeriennummer,
            this.colKaufdatum,
            this.colGekauftBei,
            this.colTinte,
            this.colFarbset,
            this.colAnmerkungen});
			this.dgvMachines.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMachines.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMachines.EnableHeadersVisualStyles = false;
			this.dgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.HighLightPercentage = 0.8F;
			this.dgvMachines.Location = new System.Drawing.Point(22, 140);
			this.dgvMachines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMachines.RowHeadersVisible = false;
			this.dgvMachines.RowHeadersWidth = 21;
			this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvMachines.Size = new System.Drawing.Size(1236, 561);
			this.dgvMachines.TabIndex = 0;
			this.dgvMachines.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_RowEnter);
			this.dgvMachines.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMachines_MouseDoubleClick);
			// 
			// colModell
			// 
			this.colModell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colModell.DataPropertyName = "Maschinenmodell";
			this.colModell.HeaderText = "Maschine";
			this.colModell.Name = "colModell";
			this.colModell.ReadOnly = true;
			this.colModell.Width = 79;
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
			this.colHersteller.DataPropertyName = "Hersteller";
			this.colHersteller.HeaderText = "Hersteller";
			this.colHersteller.MinimumWidth = 120;
			this.colHersteller.Name = "colHersteller";
			this.colHersteller.Width = 120;
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			this.colSeriennummer.HeaderText = "Serien-Nr.";
			this.colSeriennummer.Name = "colSeriennummer";
			this.colSeriennummer.Width = 81;
			// 
			// colKaufdatum
			// 
			this.colKaufdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colKaufdatum.DataPropertyName = "Kaufdatum";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colKaufdatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colKaufdatum.HeaderText = "Kaufdatum";
			this.colKaufdatum.Name = "colKaufdatum";
			this.colKaufdatum.Width = 86;
			// 
			// colGekauftBei
			// 
			this.colGekauftBei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colGekauftBei.DataPropertyName = "GekauftBei";
			this.colGekauftBei.HeaderText = "gekauft bei";
			this.colGekauftBei.Name = "colGekauftBei";
			this.colGekauftBei.Width = 89;
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
			// colAnmerkungen
			// 
			this.colAnmerkungen.DataPropertyName = "Anmerkungen";
			this.colAnmerkungen.HeaderText = "Anmerkungen";
			this.colAnmerkungen.MinimumWidth = 400;
			this.colAnmerkungen.Name = "colAnmerkungen";
			this.colAnmerkungen.Width = 400;
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
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
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
			this.mHtmlTip.OwnerDraw = true;
			// 
			// mbtnMove
			// 
			this.mbtnMove.BackColor = System.Drawing.Color.Transparent;
			this.mbtnMove.BackgroundImage = global::Products.Common.Properties.Resources.move_32_metroblue;
			this.mbtnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnMove.Location = new System.Drawing.Point(196, 100);
			this.mbtnMove.Margin = new System.Windows.Forms.Padding(2, 20, 20, 2);
			this.mbtnMove.Name = "mbtnMove";
			this.mbtnMove.Size = new System.Drawing.Size(36, 36);
			this.mbtnMove.TabIndex = 4;
			this.mHtmlTip.SetToolTip(this.mbtnMove, "Maschine zu anderem Kunden verschieben");
			this.mbtnMove.UseCustomBackColor = true;
			this.mbtnMove.UseSelectable = true;
			this.mbtnMove.Click += new System.EventHandler(this.mbtnVerschieben_Click);
			// 
			// mbtnServicetermine
			// 
			this.mbtnServicetermine.BackColor = System.Drawing.Color.Transparent;
			this.mbtnServicetermine.BackgroundImage = global::Products.Common.Properties.Resources.calendar_32_metroblue;
			this.mbtnServicetermine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnServicetermine.Location = new System.Drawing.Point(138, 100);
			this.mbtnServicetermine.Margin = new System.Windows.Forms.Padding(2, 20, 20, 2);
			this.mbtnServicetermine.Name = "mbtnServicetermine";
			this.mbtnServicetermine.Size = new System.Drawing.Size(36, 36);
			this.mbtnServicetermine.TabIndex = 3;
			this.mHtmlTip.SetToolTip(this.mbtnServicetermine, "Servicetermine anzeigen");
			this.mbtnServicetermine.UseCustomBackColor = true;
			this.mbtnServicetermine.UseSelectable = true;
			this.mbtnServicetermine.Click += new System.EventHandler(this.mbtnServicetermine_Click);
			// 
			// mbtnOpen
			// 
			this.mbtnOpen.BackColor = System.Drawing.Color.Transparent;
			this.mbtnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnOpen.BackgroundImage")));
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
			this.mbtNew.BackgroundImage = global::Products.Common.Properties.Resources.neu_metroblue;
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
			// mcmnuOpen
			// 
			this.mcmnuOpen.Image = global::Products.Common.Properties.Resources.open_16_metroblue;
			this.mcmnuOpen.Name = "mcmnuOpen";
			this.mcmnuOpen.Size = new System.Drawing.Size(152, 22);
			this.mcmnuOpen.Text = "Öffnen";
			this.mcmnuOpen.Click += new System.EventHandler(this.mcmnuMaschineAnzeigen_Click);
			// 
			// mcmnuNew
			// 
			this.mcmnuNew.Image = global::Products.Common.Properties.Resources.add_16_metroblue;
			this.mcmnuNew.Name = "mcmnuNew";
			this.mcmnuNew.Size = new System.Drawing.Size(152, 22);
			this.mcmnuNew.Text = "Neu";
			this.mcmnuNew.Click += new System.EventHandler(this.mcmnuNeueMaschine_Click);
			// 
			// mcmnuServicetermine
			// 
			this.mcmnuServicetermine.Image = global::Products.Common.Properties.Resources.calendar_16_metroblue;
			this.mcmnuServicetermine.Name = "mcmnuServicetermine";
			this.mcmnuServicetermine.Size = new System.Drawing.Size(152, 22);
			this.mcmnuServicetermine.Text = "Servicetermine";
			this.mcmnuServicetermine.Click += new System.EventHandler(this.mcmnuTermineAnzeigen_Click);
			// 
			// mcmnuMove
			// 
			this.mcmnuMove.Image = global::Products.Common.Properties.Resources.move_16_metroblue;
			this.mcmnuMove.Name = "mcmnuMove";
			this.mcmnuMove.Size = new System.Drawing.Size(152, 22);
			this.mcmnuMove.Text = "Verschieben";
			this.mcmnuMove.Click += new System.EventHandler(this.mcmnuVerschieben_Click);
			// 
			// mcmnuDelete
			// 
			this.mcmnuDelete.Image = global::Products.Common.Properties.Resources.garbage_16_metroblue;
			this.mcmnuDelete.Name = "mcmnuDelete";
			this.mcmnuDelete.Size = new System.Drawing.Size(152, 22);
			this.mcmnuDelete.Text = "Löschen";
			this.mcmnuDelete.Click += new System.EventHandler(this.mcmnuDelete_Click);
			// 
			// pnlMaschinen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mbtnMove);
			this.Controls.Add(this.mbtnServicetermine);
			this.Controls.Add(this.mbtnOpen);
			this.Controls.Add(this.mbtNew);
			this.Controls.Add(this.dgvMachines);
			this.Controls.Add(this.mlblTitel);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "pnlMaschinen";
			this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
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
		MetroFramework.Controls.MetroButton mbtnServicetermine;
		MetroFramework.Controls.MetroContextMenu mctxGrid;
		System.Windows.Forms.ToolStripMenuItem mcmnuOpen;
		System.Windows.Forms.ToolStripMenuItem mcmnuNew;
		System.Windows.Forms.ToolStripMenuItem mcmnuServicetermine;
		System.Windows.Forms.ToolStripMenuItem mcmnuMove;
		MetroFramework.Controls.MetroButton mbtnMove;
		System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		System.Windows.Forms.ToolStripMenuItem mcmnuDelete;
		MetroFramework.Drawing.Html.HtmlToolTip mHtmlTip;
		System.Windows.Forms.DataGridViewTextBoxColumn colModell;
		System.Windows.Forms.DataGridViewTextBoxColumn colMaschinentyp;
		System.Windows.Forms.DataGridViewTextBoxColumn colHersteller;
		System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		System.Windows.Forms.DataGridViewTextBoxColumn colKaufdatum;
		System.Windows.Forms.DataGridViewTextBoxColumn colGekauftBei;
		System.Windows.Forms.DataGridViewTextBoxColumn colTinte;
		System.Windows.Forms.DataGridViewTextBoxColumn colFarbset;
		System.Windows.Forms.DataGridViewTextBoxColumn colAnmerkungen;
	}
}
