namespace Products.Common.Views
{
	partial class ContactListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactListView));
			this.dtvContacts = new MetroFramework.Controls.MetroGrid();
			this.colKontaktname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colE_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnOkk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCanell = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			((System.ComponentModel.ISupportInitialize)(this.dtvContacts)).BeginInit();
			this.SuspendLayout();
			// 
			// dtvContacts
			// 
			this.dtvContacts.AllowUserToResizeRows = false;
			this.dtvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtvContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dtvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dtvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKontaktname,
            this.colE_Mail,
            this.colTelefon,
            this.colTelefax});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtvContacts.DefaultCellStyle = dataGridViewCellStyle5;
			this.dtvContacts.EnableHeadersVisualStyles = false;
			this.dtvContacts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dtvContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dtvContacts.HighLightPercentage = 1.2F;
			this.dtvContacts.Location = new System.Drawing.Point(23, 100);
			this.dtvContacts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dtvContacts.Name = "dtvContacts";
			this.dtvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtvContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dtvContacts.RowHeadersVisible = false;
			this.dtvContacts.RowHeadersWidth = 25;
			this.dtvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtvContacts.Size = new System.Drawing.Size(685, 433);
			this.dtvContacts.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dtvContacts.TabIndex = 0;
			this.dtvContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvContacts_RowEnter);
			// 
			// colKontaktname
			// 
			this.colKontaktname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKontaktname.DataPropertyName = "Kontaktname";
			this.colKontaktname.FillWeight = 25F;
			this.colKontaktname.HeaderText = "Name";
			this.colKontaktname.Name = "colKontaktname";
			// 
			// colE_Mail
			// 
			this.colE_Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colE_Mail.DataPropertyName = "E_Mail";
			this.colE_Mail.FillWeight = 25F;
			this.colE_Mail.HeaderText = "E-Mail";
			this.colE_Mail.Name = "colE_Mail";
			// 
			// colTelefon
			// 
			this.colTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTelefon.DataPropertyName = "Telefon";
			this.colTelefon.FillWeight = 25F;
			this.colTelefon.HeaderText = "Telefon";
			this.colTelefon.Name = "colTelefon";
			// 
			// colTelefax
			// 
			this.colTelefax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTelefax.DataPropertyName = "Telefax";
			this.colTelefax.FillWeight = 25F;
			this.colTelefax.HeaderText = "Fax";
			this.colTelefax.Name = "colTelefax";
			// 
			// mbtnOkk
			// 
			this.mbtnOkk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOkk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOkk.Image = null;
			this.mbtnOkk.Location = new System.Drawing.Point(488, 556);
			this.mbtnOkk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOkk.Name = "mbtnOkk";
			this.mbtnOkk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOkk.TabIndex = 5;
			this.mbtnOkk.Text = "OK";
			this.mbtnOkk.UseSelectable = true;
			this.mbtnOkk.UseVisualStyleBackColor = true;
			// 
			// mbtnCanell
			// 
			this.mbtnCanell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCanell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCanell.Image = null;
			this.mbtnCanell.Location = new System.Drawing.Point(601, 556);
			this.mbtnCanell.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnCanell.Name = "mbtnCanell";
			this.mbtnCanell.Size = new System.Drawing.Size(100, 26);
			this.mbtnCanell.TabIndex = 6;
			this.mbtnCanell.Text = "Abbrechen";
			this.mbtnCanell.UseSelectable = true;
			this.mbtnCanell.UseVisualStyleBackColor = true;
			// 
			// ContactListView
			// 
			this.AcceptButton = this.mbtnOkk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCanell;
			this.ClientSize = new System.Drawing.Size(731, 605);
			this.Controls.Add(this.mbtnCanell);
			this.Controls.Add(this.mbtnOkk);
			this.Controls.Add(this.dtvContacts);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ContactListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Kontakte in Firma";
			((System.ComponentModel.ISupportInitialize)(this.dtvContacts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dtvContacts;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKontaktname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colE_Mail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefax;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOkk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCanell;
	}
}