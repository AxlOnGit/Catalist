namespace Products.Common.Views
{
	partial class WartungsvorschlagView
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
			this.dgvMachines = new MetroFramework.Controls.MetroGrid();
			this.colMaschinenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLetzteWartung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTerminvorschlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEntfernung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWartungstour = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMachines
			// 
			this.dgvMachines.AllowUserToResizeRows = false;
			this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMachines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaschinenname,
            this.colKundenname,
            this.colPostleitzahl,
            this.colLetzteWartung,
            this.colTerminvorschlag,
            this.colEntfernung,
            this.colWartungstour});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMachines.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMachines.EnableHeadersVisualStyles = false;
			this.dgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.HighLightPercentage = 1.2F;
			this.dgvMachines.Location = new System.Drawing.Point(23, 100);
			this.dgvMachines.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMachines.RowHeadersVisible = false;
			this.dgvMachines.RowHeadersWidth = 21;
			this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMachines.Size = new System.Drawing.Size(1341, 574);
			this.dgvMachines.Style = MetroFramework.MetroColorStyle.Silver;
			this.dgvMachines.TabIndex = 0;
			// 
			// colMaschinenname
			// 
			this.colMaschinenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschinenname.DataPropertyName = "Maschinenname";
			this.colMaschinenname.FillWeight = 10F;
			this.colMaschinenname.HeaderText = "Maschine";
			this.colMaschinenname.Name = "colMaschinenname";
			// 
			// colKundenname
			// 
			this.colKundenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundenname.DataPropertyName = "Kundenname";
			this.colKundenname.FillWeight = 20F;
			this.colKundenname.HeaderText = "Firma";
			this.colKundenname.Name = "colKundenname";
			// 
			// colPostleitzahl
			// 
			this.colPostleitzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPostleitzahl.DataPropertyName = "Postleitzahl";
			this.colPostleitzahl.FillWeight = 10F;
			this.colPostleitzahl.HeaderText = "PLZ";
			this.colPostleitzahl.Name = "colPostleitzahl";
			// 
			// colLetzteWartung
			// 
			this.colLetzteWartung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLetzteWartung.DataPropertyName = "LetzteWartung";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colLetzteWartung.DefaultCellStyle = dataGridViewCellStyle2;
			this.colLetzteWartung.FillWeight = 10F;
			this.colLetzteWartung.HeaderText = "Letzte Wartung";
			this.colLetzteWartung.Name = "colLetzteWartung";
			// 
			// colTerminvorschlag
			// 
			this.colTerminvorschlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTerminvorschlag.DataPropertyName = "Terminvorschlag";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colTerminvorschlag.DefaultCellStyle = dataGridViewCellStyle3;
			this.colTerminvorschlag.FillWeight = 10F;
			this.colTerminvorschlag.HeaderText = "Terminvorschlag";
			this.colTerminvorschlag.Name = "colTerminvorschlag";
			// 
			// colEntfernung
			// 
			this.colEntfernung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEntfernung.DataPropertyName = "Entfernung";
			this.colEntfernung.FillWeight = 10F;
			this.colEntfernung.HeaderText = "Entfernung";
			this.colEntfernung.Name = "colEntfernung";
			// 
			// colWartungstour
			// 
			this.colWartungstour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colWartungstour.DataPropertyName = "Wartungstour";
			this.colWartungstour.FillWeight = 30F;
			this.colWartungstour.HeaderText = "Wartungstour";
			this.colWartungstour.Name = "colWartungstour";
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(1264, 697);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 1;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			// 
			// WartungsvorschlagView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 746);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.dgvMachines);
			this.Name = "WartungsvorschlagView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "Wartungsübersicht";
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvMachines;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschinenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLetzteWartung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTerminvorschlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEntfernung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWartungstour;
	}
}