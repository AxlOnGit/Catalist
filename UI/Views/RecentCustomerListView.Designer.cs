﻿namespace Products.Common.Views
{
	partial class RecentCustomerListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCustomers = new MetroFramework.Controls.MetroGrid();
			this.colMatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdClearList = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtnOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mchkDontClose = new MetroFramework.Controls.MetroCheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AllowUserToResizeRows = false;
			this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomers.ColumnHeadersHeight = 16;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatchcode});
			this.dgvCustomers.ContextMenuStrip = this.metroContextMenu1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomers.EnableHeadersVisualStyles = false;
			this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvCustomers.HighLightPercentage = 1.2F;
			this.dgvCustomers.Location = new System.Drawing.Point(23, 100);
			this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCustomers.RowHeadersVisible = false;
			this.dgvCustomers.RowHeadersWidth = 21;
			this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.Size = new System.Drawing.Size(316, 366);
			this.dgvCustomers.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvCustomers.TabIndex = 0;
			this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
			this.dgvCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomers_MouseDoubleClick);
			// 
			// colMatchcode
			// 
			this.colMatchcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMatchcode.DataPropertyName = "Matchcode";
			this.colMatchcode.HeaderText = "  Die Letzten ...";
			this.colMatchcode.Name = "colMatchcode";
			this.colMatchcode.ReadOnly = true;
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdClearList});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(110, 26);
			this.metroContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
			// 
			// xcmdClearList
			// 
			this.xcmdClearList.Image = global::Products.Common.Properties.Resources.delete_16_metrored;
			this.xcmdClearList.Name = "xcmdClearList";
			this.xcmdClearList.Size = new System.Drawing.Size(109, 22);
			this.xcmdClearList.Text = "Leeren";
			this.xcmdClearList.Click += new System.EventHandler(this.xcmdClearList_Click);
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnOk.Image = null;
			this.mbtnOk.Location = new System.Drawing.Point(75, 507);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 26);
			this.mbtnOk.TabIndex = 1;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseVisualStyleBackColor = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Image = null;
			this.mbtnCancel.Location = new System.Drawing.Point(188, 507);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
			this.mbtnCancel.TabIndex = 2;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseVisualStyleBackColor = true;
			this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
			// 
			// mchkDontClose
			// 
			this.mchkDontClose.AutoSize = true;
			this.mchkDontClose.Location = new System.Drawing.Point(23, 473);
			this.mchkDontClose.Name = "mchkDontClose";
			this.mchkDontClose.Size = new System.Drawing.Size(144, 15);
			this.mchkDontClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.mchkDontClose.TabIndex = 3;
			this.mchkDontClose.Text = "Fenster geöffnet lassen";
			this.mchkDontClose.UseSelectable = true;
			// 
			// RecentCustomerListView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(362, 556);
			this.ControlBox = false;
			this.Controls.Add(this.mchkDontClose);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.dgvCustomers);
			this.Name = "RecentCustomerListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Zuletzt geöffnete Kunden";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvCustomers;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnOk;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnCancel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatchcode;
		private MetroFramework.Controls.MetroCheckBox mchkDontClose;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem xcmdClearList;
	}
}