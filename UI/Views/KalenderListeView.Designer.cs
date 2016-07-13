namespace Products.Common.Views
{
	partial class KalenderListeView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvTermine = new MetroFramework.Controls.MetroGrid();
			this.colStartdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStartzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvTermine)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTermine
			// 
			this.dgvTermine.AllowUserToAddRows = false;
			this.dgvTermine.AllowUserToDeleteRows = false;
			this.dgvTermine.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvTermine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTermine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTermine.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTermine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTermine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTermine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTermine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartdatum,
            this.colStartzeit,
            this.colTitel});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTermine.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTermine.EnableHeadersVisualStyles = false;
			this.dgvTermine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTermine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTermine.HighLightPercentage = 0.8F;
			this.dgvTermine.Location = new System.Drawing.Point(23, 100);
			this.dgvTermine.Margin = new System.Windows.Forms.Padding(3, 40, 3, 20);
			this.dgvTermine.Name = "dgvTermine";
			this.dgvTermine.ReadOnly = true;
			this.dgvTermine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTermine.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvTermine.RowHeadersVisible = false;
			this.dgvTermine.RowHeadersWidth = 21;
			this.dgvTermine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTermine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTermine.Size = new System.Drawing.Size(998, 570);
			this.dgvTermine.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvTermine.TabIndex = 0;
			this.dgvTermine.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermine_RowEnter);
			this.dgvTermine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTermine_MouseDoubleClick);
			// 
			// colStartdatum
			// 
			this.colStartdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStartdatum.DataPropertyName = "StartDate";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colStartdatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colStartdatum.FillWeight = 10F;
			this.colStartdatum.HeaderText = "Datum";
			this.colStartdatum.Name = "colStartdatum";
			this.colStartdatum.ReadOnly = true;
			// 
			// colStartzeit
			// 
			this.colStartzeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStartzeit.DataPropertyName = "StartDate";
			dataGridViewCellStyle4.Format = "t";
			dataGridViewCellStyle4.NullValue = null;
			this.colStartzeit.DefaultCellStyle = dataGridViewCellStyle4;
			this.colStartzeit.FillWeight = 10F;
			this.colStartzeit.HeaderText = "Uhrzeit";
			this.colStartzeit.Name = "colStartzeit";
			this.colStartzeit.ReadOnly = true;
			// 
			// colTitel
			// 
			this.colTitel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTitel.DataPropertyName = "Title";
			this.colTitel.FillWeight = 80F;
			this.colTitel.HeaderText = "Termin";
			this.colTitel.Name = "colTitel";
			this.colTitel.ReadOnly = true;
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(808, 689);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 3;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(921, 689);
			this.mbtnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 4;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// KalenderListeView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(1051, 746);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.dgvTermine);
			this.Name = "KalenderListeView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Terminliste";
			((System.ComponentModel.ISupportInitialize)(this.dgvTermine)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTermine;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartzeit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTitel;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
	}
}