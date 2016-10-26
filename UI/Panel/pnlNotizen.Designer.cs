namespace Products.Common.Panel
{
	partial class pnlNotizen
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
			this.btnShowNote = new System.Windows.Forms.Button();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnAddNote = new System.Windows.Forms.Button();
			this.dgvNotizen = new MetroFramework.Controls.MetroGrid();
			this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxNotes = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdShowNote = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdAddNote = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdDeleteNote = new System.Windows.Forms.ToolStripMenuItem();
			this.mtxtNotiztext = new MetroFramework.Controls.MetroTextBox();
			this.mlnkFontSize = new MetroFramework.Controls.MetroLink();
			this.btnDeleteNote = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).BeginInit();
			this.mctxNotes.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShowNote
			// 
			this.btnShowNote.BackColor = System.Drawing.Color.Transparent;
			this.btnShowNote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnShowNote.FlatAppearance.BorderSize = 0;
			this.btnShowNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowNote.Image = global::Products.Common.Properties.Resources.open_32_metroorange;
			this.btnShowNote.Location = new System.Drawing.Point(99, 85);
			this.btnShowNote.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnShowNote.Name = "btnShowNote";
			this.btnShowNote.Size = new System.Drawing.Size(36, 36);
			this.btnShowNote.TabIndex = 18;
			this.btnShowNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnShowNote.UseVisualStyleBackColor = false;
			this.btnShowNote.Click += new System.EventHandler(this.btnShowNote_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(23, 99);
			this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(71, 25);
			this.metroLabel1.TabIndex = 17;
			this.metroLabel1.Text = "Notizen";
			// 
			// btnAddNote
			// 
			this.btnAddNote.BackColor = System.Drawing.Color.Transparent;
			this.btnAddNote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddNote.FlatAppearance.BorderSize = 0;
			this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNote.Image = global::Products.Common.Properties.Resources.neu_32_metroorange;
			this.btnAddNote.Location = new System.Drawing.Point(158, 85);
			this.btnAddNote.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.btnAddNote.Name = "btnAddNote";
			this.btnAddNote.Size = new System.Drawing.Size(36, 36);
			this.btnAddNote.TabIndex = 16;
			this.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNote.UseVisualStyleBackColor = false;
			this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
			// 
			// dgvNotizen
			// 
			this.dgvNotizen.AllowUserToDeleteRows = false;
			this.dgvNotizen.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
			this.dgvNotizen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvNotizen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvNotizen.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvNotizen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvNotizen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvNotizen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotizen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvNotizen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotizen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDatum,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.dgvNotizen.ContextMenuStrip = this.mctxNotes;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvNotizen.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvNotizen.EnableHeadersVisualStyles = false;
			this.dgvNotizen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvNotizen.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvNotizen.HighLightPercentage = 0.99F;
			this.dgvNotizen.Location = new System.Drawing.Point(23, 127);
			this.dgvNotizen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 26);
			this.dgvNotizen.Name = "dgvNotizen";
			this.dgvNotizen.ReadOnly = true;
			this.dgvNotizen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotizen.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvNotizen.RowHeadersVisible = false;
			this.dgvNotizen.RowHeadersWidth = 21;
			this.dgvNotizen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvNotizen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNotizen.Size = new System.Drawing.Size(1234, 318);
			this.dgvNotizen.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvNotizen.TabIndex = 15;
			this.dgvNotizen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotizen_RowEnter);
			this.dgvNotizen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotizen_MouseDoubleClick);
			// 
			// colDatum
			// 
			this.colDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDatum.DataPropertyName = "AssignedAt";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colDatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colDatum.FillWeight = 13F;
			this.colDatum.HeaderText = "Datum";
			this.colDatum.Name = "colDatum";
			this.colDatum.ReadOnly = true;
			this.colDatum.ToolTipText = "Erfassungsdatum";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Subject";
			this.dataGridViewTextBoxColumn7.FillWeight = 22F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Thema";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Body";
			this.dataGridViewTextBoxColumn8.FillWeight = 65F;
			this.dataGridViewTextBoxColumn8.HeaderText = "Text";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// mctxNotes
			// 
			this.mctxNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowNote,
            this.xcmdAddNote,
            this.toolStripMenuItem1,
            this.xcmdDeleteNote});
			this.mctxNotes.Name = "mctxNotes";
			this.mctxNotes.Size = new System.Drawing.Size(147, 76);
			// 
			// xcmdShowNote
			// 
			this.xcmdShowNote.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdShowNote.Name = "xcmdShowNote";
			this.xcmdShowNote.Size = new System.Drawing.Size(146, 22);
			this.xcmdShowNote.Text = "Notiz ö&ffnen";
			this.xcmdShowNote.Click += new System.EventHandler(this.xcmdShowNote_Click);
			// 
			// xcmdAddNote
			// 
			this.xcmdAddNote.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdAddNote.Name = "xcmdAddNote";
			this.xcmdAddNote.Size = new System.Drawing.Size(146, 22);
			this.xcmdAddNote.Text = "&Neue Notiz";
			this.xcmdAddNote.Click += new System.EventHandler(this.xcmdAddNote_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
			// 
			// xcmdDeleteNote
			// 
			this.xcmdDeleteNote.Image = global::Products.Common.Properties.Resources.delete_16_metroorange;
			this.xcmdDeleteNote.Name = "xcmdDeleteNote";
			this.xcmdDeleteNote.Size = new System.Drawing.Size(146, 22);
			this.xcmdDeleteNote.Text = "Notiz löschen";
			this.xcmdDeleteNote.Click += new System.EventHandler(this.xcmdDeleteNote_Click);
			// 
			// mtxtNotiztext
			// 
			this.mtxtNotiztext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtNotiztext.CustomButton.Image = null;
			this.mtxtNotiztext.CustomButton.Location = new System.Drawing.Point(1000, 1);
			this.mtxtNotiztext.CustomButton.Name = "";
			this.mtxtNotiztext.CustomButton.Size = new System.Drawing.Size(233, 233);
			this.mtxtNotiztext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtNotiztext.CustomButton.TabIndex = 1;
			this.mtxtNotiztext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtNotiztext.CustomButton.UseSelectable = true;
			this.mtxtNotiztext.CustomButton.Visible = false;
			this.mtxtNotiztext.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtNotiztext.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtNotiztext.Lines = new string[0];
			this.mtxtNotiztext.Location = new System.Drawing.Point(23, 474);
			this.mtxtNotiztext.MaxLength = 32767;
			this.mtxtNotiztext.Multiline = true;
			this.mtxtNotiztext.Name = "mtxtNotiztext";
			this.mtxtNotiztext.PasswordChar = '\0';
			this.mtxtNotiztext.ReadOnly = true;
			this.mtxtNotiztext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mtxtNotiztext.SelectedText = "";
			this.mtxtNotiztext.SelectionLength = 0;
			this.mtxtNotiztext.SelectionStart = 0;
			this.mtxtNotiztext.Size = new System.Drawing.Size(1234, 235);
			this.mtxtNotiztext.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtNotiztext.TabIndex = 19;
			this.mtxtNotiztext.UseSelectable = true;
			this.mtxtNotiztext.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtNotiztext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mlnkFontSize
			// 
			this.mlnkFontSize.Location = new System.Drawing.Point(23, 450);
			this.mlnkFontSize.Name = "mlnkFontSize";
			this.mlnkFontSize.Size = new System.Drawing.Size(86, 23);
			this.mlnkFontSize.TabIndex = 20;
			this.mlnkFontSize.Text = "Schriftgröße";
			this.mlnkFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlnkFontSize.UseSelectable = true;
			this.mlnkFontSize.Click += new System.EventHandler(this.mlnkFontSize_Click);
			// 
			// btnDeleteNote
			// 
			this.btnDeleteNote.BackColor = System.Drawing.Color.Transparent;
			this.btnDeleteNote.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.btnDeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDeleteNote.FlatAppearance.BorderSize = 0;
			this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteNote.Location = new System.Drawing.Point(1221, 85);
			this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(3, 10, 20, 20);
			this.btnDeleteNote.Name = "btnDeleteNote";
			this.btnDeleteNote.Size = new System.Drawing.Size(36, 36);
			this.btnDeleteNote.TabIndex = 21;
			this.btnDeleteNote.UseVisualStyleBackColor = false;
			this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNotiz_Click);
			// 
			// pnlNotizen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDeleteNote);
			this.Controls.Add(this.mlnkFontSize);
			this.Controls.Add(this.mtxtNotiztext);
			this.Controls.Add(this.btnShowNote);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnAddNote);
			this.Controls.Add(this.dgvNotizen);
			this.Name = "pnlNotizen";
			this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
			this.Size = new System.Drawing.Size(1280, 732);
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).EndInit();
			this.mctxNotes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		System.Windows.Forms.Button btnShowNote;
		MetroFramework.Controls.MetroLabel metroLabel1;
		System.Windows.Forms.Button btnAddNote;
		MetroFramework.Controls.MetroGrid dgvNotizen;
		MetroFramework.Controls.MetroTextBox mtxtNotiztext;
		MetroFramework.Controls.MetroLink mlnkFontSize;
		System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
		System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		System.Windows.Forms.Button btnDeleteNote;
		MetroFramework.Controls.MetroContextMenu mctxNotes;
		System.Windows.Forms.ToolStripMenuItem xcmdShowNote;
		System.Windows.Forms.ToolStripMenuItem xcmdAddNote;
		System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		System.Windows.Forms.ToolStripMenuItem xcmdDeleteNote;
	}
}
