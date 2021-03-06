﻿namespace Products.Common.Views
{
	partial class KundenmaschineSearchView2
	{

#pragma warning disable CS0618 // Typ oder Element ist veraltet

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mtxtFilter = new MetroFramework.Controls.MetroTextBox();
			this.dgvMachines = new MetroFramework.Controls.MetroGrid();
			this.colMaschine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colZuordnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKundenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(718, 638);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 3;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mcmdCancel_Click);
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(605, 638);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 2;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOK_Click);
			// 
			// mtxtFilter
			// 
			// 
			// 
			// 
			this.mtxtFilter.CustomButton.Image = null;
			this.mtxtFilter.CustomButton.Location = new System.Drawing.Point(317, 1);
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
			this.mtxtFilter.PromptText = "Modell, Firma oder Seriennummer";
			this.mtxtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFilter.SelectedText = "";
			this.mtxtFilter.SelectionLength = 0;
			this.mtxtFilter.SelectionStart = 0;
			this.mtxtFilter.ShortcutsEnabled = true;
			this.mtxtFilter.ShowButton = true;
			this.mtxtFilter.ShowClearButton = true;
			this.mtxtFilter.Size = new System.Drawing.Size(339, 23);
			this.mtxtFilter.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mtxtFilter.TabIndex = 0;
			this.mtxtFilter.UseSelectable = true;
			this.mtxtFilter.WaterMark = "Modell, Firma oder Seriennummer";
			this.mtxtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFilter_KeyUp);
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
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
						this.colMaschine,
						this.colSeriennummer,
						this.colZuordnung,
						this.colKundennummer,
						this.colKundenname,
						this.colOrt});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMachines.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMachines.EnableHeadersVisualStyles = false;
			this.dgvMachines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvMachines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMachines.HighLightPercentage = 1.2F;
			this.dgvMachines.Location = new System.Drawing.Point(23, 129);
			this.dgvMachines.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvMachines.Name = "dgvMachines";
			this.dgvMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMachines.RowHeadersVisible = false;
			this.dgvMachines.RowHeadersWidth = 21;
			this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMachines.Size = new System.Drawing.Size(795, 486);
			this.dgvMachines.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvMachines.TabIndex = 1;
			this.dgvMachines.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_RowEnter);
			this.dgvMachines.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMachines_MouseDoubleClick);
			// 
			// colMaschine
			// 
			this.colMaschine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaschine.DataPropertyName = "Maschine";
			this.colMaschine.FillWeight = 15F;
			this.colMaschine.HeaderText = "Maschine";
			this.colMaschine.Name = "colMaschine";
			// 
			// colSeriennummer
			// 
			this.colSeriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSeriennummer.DataPropertyName = "Seriennummer";
			dataGridViewCellStyle2.NullValue = "?";
			this.colSeriennummer.DefaultCellStyle = dataGridViewCellStyle2;
			this.colSeriennummer.FillWeight = 15F;
			this.colSeriennummer.HeaderText = "Serien-Nr";
			this.colSeriennummer.Name = "colSeriennummer";
			// 
			// colZuordnung
			// 
			this.colZuordnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colZuordnung.DataPropertyName = "Zuordnung";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colZuordnung.DefaultCellStyle = dataGridViewCellStyle3;
			this.colZuordnung.FillWeight = 10F;
			this.colZuordnung.HeaderText = "Zuordnung";
			this.colZuordnung.Name = "colZuordnung";
			// 
			// colKundennummer
			// 
			this.colKundennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundennummer.DataPropertyName = "Kunde";
			this.colKundennummer.FillWeight = 10F;
			this.colKundennummer.HeaderText = "Kunden-Nr";
			this.colKundennummer.Name = "colKundennummer";
			// 
			// colKundenname
			// 
			this.colKundenname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colKundenname.DataPropertyName = "Firma";
			this.colKundenname.FillWeight = 25F;
			this.colKundenname.HeaderText = "Firma";
			this.colKundenname.Name = "colKundenname";
			// 
			// colOrt
			// 
			this.colOrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOrt.DataPropertyName = "Ort";
			this.colOrt.FillWeight = 25F;
			this.colOrt.HeaderText = "Ort";
			this.colOrt.Name = "colOrt";
			// 
			// KundenmaschineSearchView2
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(841, 687);
			this.Controls.Add(this.dgvMachines);
			this.Controls.Add(this.mtxtFilter);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.mbtnCancel);
			this.Name = "KundenmaschineSearchView2";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Kundenmaschinen - Suche";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
			this.ResumeLayout(false);

#pragma warning restore CS0618 // Typ oder Element ist veraltet

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox mtxtFilter;
		private MetroFramework.Controls.MetroGrid dgvMachines;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaschine;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeriennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colZuordnung;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundennummer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKundenname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
	}
}