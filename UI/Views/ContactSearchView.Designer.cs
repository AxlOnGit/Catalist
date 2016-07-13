namespace Products.Common.Views
{
	partial class ContactSearchView
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
			this.dgvContacts = new MetroFramework.Controls.MetroGrid();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKontaktname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPostleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.mcmdCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mcmdOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContacts
			// 
			this.dgvContacts.AllowUserToAddRows = false;
			this.dgvContacts.AllowUserToDeleteRows = false;
			this.dgvContacts.AllowUserToResizeRows = false;
			this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundennummer,
            this.colKontaktname,
            this.colFirma,
            this.colStrasse,
            this.colPostleitzahl,
            this.colOrt});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvContacts.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvContacts.EnableHeadersVisualStyles = false;
			this.dgvContacts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContacts.HighLightPercentage = 1.2F;
			this.dgvContacts.Location = new System.Drawing.Point(23, 129);
			this.dgvContacts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvContacts.Name = "dgvContacts";
			this.dgvContacts.ReadOnly = true;
			this.dgvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvContacts.RowHeadersVisible = false;
			this.dgvContacts.RowHeadersWidth = 21;
			this.dgvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContacts.Size = new System.Drawing.Size(914, 495);
			this.dgvContacts.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvContacts.TabIndex = 1;
			this.dgvContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_RowEnter);
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Kundennummer";
			this.colKundennummer.FillWeight = 10F;
			this.colKundennummer.HeaderText = "Kunden-Nr.";
			this.colKundennummer.Name = "colKundennummer";
			this.colKundennummer.ReadOnly = true;
			// 
			// colKontaktname
			// 
			this.colKontaktname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKontaktname.DataPropertyName = "Kontaktname";
			this.colKontaktname.FillWeight = 20F;
			this.colKontaktname.HeaderText = "Name";
			this.colKontaktname.Name = "colKontaktname";
			this.colKontaktname.ReadOnly = true;
			// 
			// colFirma
			// 
			this.colFirma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFirma.DataPropertyName = "Firma";
			this.colFirma.FillWeight = 20F;
			this.colFirma.HeaderText = "Firma";
			this.colFirma.Name = "colFirma";
			this.colFirma.ReadOnly = true;
			// 
			// colStrasse
			// 
			this.colStrasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStrasse.DataPropertyName = "Strasse";
			this.colStrasse.FillWeight = 20F;
			this.colStrasse.HeaderText = "Straße";
			this.colStrasse.Name = "colStrasse";
			this.colStrasse.ReadOnly = true;
			// 
			// colPostleitzahl
			// 
			this.colPostleitzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPostleitzahl.DataPropertyName = "Postleitzahl";
			this.colPostleitzahl.FillWeight = 10F;
			this.colPostleitzahl.HeaderText = "PLZ";
			this.colPostleitzahl.Name = "colPostleitzahl";
			this.colPostleitzahl.ReadOnly = true;
			// 
			// colOrt
			// 
			this.colOrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOrt.DataPropertyName = "Ort";
			this.colOrt.FillWeight = 20F;
			this.colOrt.HeaderText = "Ort";
			this.colOrt.Name = "colOrt";
			this.colOrt.ReadOnly = true;
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(344, 1);
			this.mtxtFilter.CustomButton.Name = "";
			this.mtxtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtFilter.CustomButton.TabIndex = 1;
			this.mtxtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFilter.CustomButton.UseSelectable = true;
			this.mtxtFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtFilter.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtFilter.Lines = new string[0];
			this.mtxtFilter.Location = new System.Drawing.Point(23, 100);
			this.mtxtFilter.MaxLength = 32767;
			this.mtxtFilter.Name = "mtxtFilter";
			this.mtxtFilter.PasswordChar = '\0';
			this.mtxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFilter.SelectedText = "";
			this.mtxtFilter.SelectionLength = 0;
			this.mtxtFilter.SelectionStart = 0;
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(366, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtFilter.TabIndex = 0;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Kontaktname, Firma, Kundennummer, Plz oder Ort";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFilter_KeyUp);
			// 
			// mcmdCancel
			// 
			this.mcmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mcmdCancel.Image = null;
			this.mcmdCancel.Location = new System.Drawing.Point(837, 644);
			this.mcmdCancel.Name = "mcmdCancel";
			this.mcmdCancel.Size = new System.Drawing.Size(100, 26);
			this.mcmdCancel.TabIndex = 3;
			this.mcmdCancel.Text = "Abbrechen";
			this.mcmdCancel.UseSelectable = true;
			this.mcmdCancel.UseVisualStyleBackColor = true;
			// 
			// mcmdOk
			// 
			this.mcmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mcmdOk.Image = null;
			this.mcmdOk.Location = new System.Drawing.Point(724, 644);
			this.mcmdOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mcmdOk.Name = "mcmdOk";
			this.mcmdOk.Size = new System.Drawing.Size(100, 26);
			this.mcmdOk.TabIndex = 2;
			this.mcmdOk.Text = "OK";
			this.mcmdOk.UseSelectable = true;
			this.mcmdOk.UseVisualStyleBackColor = true;
			// 
			// ContactSearchView
			// 
			this.AcceptButton = this.mcmdOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mcmdCancel;
			this.ClientSize = new System.Drawing.Size(960, 693);
			this.Controls.Add(this.mcmdOk);
			this.Controls.Add(this.mcmdCancel);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.dgvContacts);
			this.Name = "ContactSearchView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Kundenkontakte - Suche";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvContacts;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mcmdCancel;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mcmdOk;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKontaktname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFirma;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStrasse;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPostleitzahl;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
	}
}