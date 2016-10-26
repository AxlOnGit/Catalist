namespace Products.Common.Views
{
	partial class AppointmentListView
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentListView));
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.dgvAppointments = new MetroFramework.Controls.MetroGrid();
			this.colStartsAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAppointmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdShowAppointment = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(742, 557);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 0;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// dgvAppointments
			// 
			this.dgvAppointments.AllowUserToResizeRows = false;
			this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartsAt,
            this.colSubject,
            this.colAppointmentType,
            this.colOwnerName});
			this.dgvAppointments.ContextMenuStrip = this.metroContextMenu1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAppointments.EnableHeadersVisualStyles = false;
			this.dgvAppointments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAppointments.HighLightPercentage = 1.2F;
			this.dgvAppointments.Location = new System.Drawing.Point(23, 100);
			this.dgvAppointments.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvAppointments.Name = "dgvAppointments";
			this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAppointments.RowHeadersVisible = false;
			this.dgvAppointments.RowHeadersWidth = 21;
			this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAppointments.Size = new System.Drawing.Size(819, 434);
			this.dgvAppointments.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvAppointments.TabIndex = 1;
			this.dgvAppointments.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_RowEnter);
			this.dgvAppointments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAppointments_MouseDoubleClick);
			// 
			// colStartsAt
			// 
			this.colStartsAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStartsAt.DataPropertyName = "StartsAt";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.colStartsAt.DefaultCellStyle = dataGridViewCellStyle2;
			this.colStartsAt.FillWeight = 15F;
			this.colStartsAt.HeaderText = "Datum";
			this.colStartsAt.Name = "colStartsAt";
			// 
			// colSubject
			// 
			this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.DataPropertyName = "Subject";
			this.colSubject.FillWeight = 45F;
			this.colSubject.HeaderText = "Termin";
			this.colSubject.Name = "colSubject";
			// 
			// colAppointmentType
			// 
			this.colAppointmentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colAppointmentType.DataPropertyName = "AppointmentType";
			this.colAppointmentType.FillWeight = 20F;
			this.colAppointmentType.HeaderText = "Terminart";
			this.colAppointmentType.MinimumWidth = 20;
			this.colAppointmentType.Name = "colAppointmentType";
			// 
			// colOwnerName
			// 
			this.colOwnerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOwnerName.DataPropertyName = "OwnerName";
			this.colOwnerName.FillWeight = 20F;
			this.colOwnerName.HeaderText = "Mitarbeiter";
			this.colOwnerName.Name = "colOwnerName";
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdShowAppointment});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(112, 26);
			// 
			// xcmdShowAppointment
			// 
			this.xcmdShowAppointment.Image = global::Products.Common.Properties.Resources.open_16_metroyellow;
			this.xcmdShowAppointment.Name = "xcmdShowAppointment";
			this.xcmdShowAppointment.Size = new System.Drawing.Size(111, 22);
			this.xcmdShowAppointment.Text = "Öffnen";
			this.xcmdShowAppointment.Click += new System.EventHandler(this.xcmdShowAppointment_Click);
			// 
			// AppointmentListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 606);
			this.Controls.Add(this.dgvAppointments);
			this.Controls.Add(this.mbtnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AppointmentListView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Kalendereinträge für ";
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroGrid dgvAppointments;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem xcmdShowAppointment;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartsAt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerName;
	}
}