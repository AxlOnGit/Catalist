namespace Products.Common.Views
{
	partial class SoftwareListView
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareListView));
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
			this.dgvSoftware = new MetroFramework.Controls.MetroGrid();
			this.colSoftware = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInstDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHauptbenutzerr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colComputa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLizenzschluessell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mtxtAnmerkungen = new MetroFramework.Controls.MetroTextBox();
			this.btnNew = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnClose.Location = new System.Drawing.Point(737, 505);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(86, 30);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 328);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(91, 19);
			this.metroLabel1.TabIndex = 51;
			this.metroLabel1.Text = "Anmerkungen";
			// 
			// dgvSoftware
			// 
			this.dgvSoftware.AllowUserToAddRows = false;
			this.dgvSoftware.AllowUserToDeleteRows = false;
			this.dgvSoftware.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvSoftware.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSoftware.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSoftware.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSoftware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSoftware.ColumnHeadersHeight = 20;
			this.dgvSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoftware,
            this.colInstDatum,
            this.colHauptbenutzerr,
            this.colComputa,
            this.colLizenzschluessell});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSoftware.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSoftware.EnableHeadersVisualStyles = false;
			this.dgvSoftware.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSoftware.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftware.Location = new System.Drawing.Point(23, 91);
			this.dgvSoftware.MultiSelect = false;
			this.dgvSoftware.Name = "dgvSoftware";
			this.dgvSoftware.ReadOnly = true;
			this.dgvSoftware.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSoftware.RowHeadersWidth = 21;
			this.dgvSoftware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSoftware.Size = new System.Drawing.Size(811, 213);
			this.dgvSoftware.TabIndex = 2;
			this.dgvSoftware.TabStop = false;
			this.dgvSoftware.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_RowEnter);
			this.dgvSoftware.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSoftware_MouseDoubleClick);
			// 
			// colSoftware
			// 
			this.colSoftware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSoftware.DataPropertyName = "Softwarename";
			this.colSoftware.FillWeight = 25F;
			this.colSoftware.HeaderText = "Programm";
			this.colSoftware.Name = "colSoftware";
			this.colSoftware.ReadOnly = true;
			// 
			// colInstDatum
			// 
			this.colInstDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colInstDatum.DataPropertyName = "Installationsdatum";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colInstDatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colInstDatum.FillWeight = 10F;
			this.colInstDatum.HeaderText = "Installation";
			this.colInstDatum.Name = "colInstDatum";
			this.colInstDatum.ReadOnly = true;
			// 
			// colHauptbenutzerr
			// 
			this.colHauptbenutzerr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHauptbenutzerr.DataPropertyName = "Hauptbenutzer";
			this.colHauptbenutzerr.FillWeight = 15F;
			this.colHauptbenutzerr.HeaderText = "Benutzer";
			this.colHauptbenutzerr.Name = "colHauptbenutzerr";
			this.colHauptbenutzerr.ReadOnly = true;
			// 
			// colComputa
			// 
			this.colComputa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colComputa.DataPropertyName = "Computer";
			this.colComputa.FillWeight = 15F;
			this.colComputa.HeaderText = "Computer";
			this.colComputa.Name = "colComputa";
			this.colComputa.ReadOnly = true;
			// 
			// colLizenzschluessell
			// 
			this.colLizenzschluessell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLizenzschluessell.DataPropertyName = "Lizenzschluessel";
			this.colLizenzschluessell.FillWeight = 35F;
			this.colLizenzschluessell.HeaderText = "Key/SN";
			this.colLizenzschluessell.Name = "colLizenzschluessell";
			this.colLizenzschluessell.ReadOnly = true;
			// 
			// mtxtAnmerkungen
			// 
			this.mtxtAnmerkungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtAnmerkungen.CustomButton.Image = null;
			this.mtxtAnmerkungen.CustomButton.Location = new System.Drawing.Point(695, 1);
			this.mtxtAnmerkungen.CustomButton.Name = "";
			this.mtxtAnmerkungen.CustomButton.Size = new System.Drawing.Size(115, 115);
			this.mtxtAnmerkungen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtAnmerkungen.CustomButton.TabIndex = 1;
			this.mtxtAnmerkungen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAnmerkungen.CustomButton.UseSelectable = true;
			this.mtxtAnmerkungen.CustomButton.Visible = false;
			this.mtxtAnmerkungen.Enabled = false;
			this.mtxtAnmerkungen.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAnmerkungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.mtxtAnmerkungen.Lines = new string[0];
			this.mtxtAnmerkungen.Location = new System.Drawing.Point(23, 350);
			this.mtxtAnmerkungen.MaxLength = 32767;
			this.mtxtAnmerkungen.Multiline = true;
			this.mtxtAnmerkungen.Name = "mtxtAnmerkungen";
			this.mtxtAnmerkungen.PasswordChar = '\0';
			this.mtxtAnmerkungen.ReadOnly = true;
			this.mtxtAnmerkungen.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtAnmerkungen.SelectedText = "";
			this.mtxtAnmerkungen.SelectionLength = 0;
			this.mtxtAnmerkungen.SelectionStart = 0;
			this.mtxtAnmerkungen.Size = new System.Drawing.Size(811, 117);
			this.mtxtAnmerkungen.TabIndex = 53;
			this.mtxtAnmerkungen.UseSelectable = true;
			this.mtxtAnmerkungen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAnmerkungen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.BackColor = System.Drawing.Color.Transparent;
			this.btnNew.BackgroundImage = global::Products.Common.Properties.Resources.Add_metrogblue;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNew.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnNew.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnNew.Location = new System.Drawing.Point(23, 473);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(52, 52);
			this.btnNew.TabIndex = 1;
			this.btnNew.UseSelectable = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// SoftwareListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 558);
			this.Controls.Add(this.mtxtAnmerkungen);
			this.Controls.Add(this.dgvSoftware);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnClose);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SoftwareListView";
			this.Text = "Software";
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnClose;
		private MetroFramework.Controls.MetroButton btnNew;
		private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroGrid dgvSoftware;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoftware;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInstDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHauptbenutzerr;
		private System.Windows.Forms.DataGridViewTextBoxColumn colComputa;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLizenzschluessell;
		private MetroFramework.Controls.MetroTextBox mtxtAnmerkungen;
	}
}