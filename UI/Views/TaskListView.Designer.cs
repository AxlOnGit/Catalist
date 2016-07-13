namespace Products.Common.Views
{
	partial class TaskListView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListView));
			this.dgvTasks = new MetroFramework.Controls.MetroGrid();
			this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPercentCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStartsAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDueAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClose = new MetroFramework.Controls.MetroButton();
			this.mtxtDescription = new MetroFramework.Controls.MetroTextBox();
			this.btnShowDetails = new System.Windows.Forms.Button();
			this.btnPositionLoeschen = new System.Windows.Forms.Button();
			this.btnNewTask = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTasks
			// 
			this.dgvTasks.AllowUserToResizeRows = false;
			this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPriority,
            this.colStatus,
            this.colPercentCompleted,
            this.colTaskName,
            this.colStartsAt,
            this.colDueAt,
            this.colResponsible,
            this.colOwner});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTasks.EnableHeadersVisualStyles = false;
			this.dgvTasks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvTasks.HighLightPercentage = 1.2F;
			this.dgvTasks.Location = new System.Drawing.Point(27, 164);
			this.dgvTasks.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
			this.dgvTasks.Name = "dgvTasks";
			this.dgvTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTasks.RowHeadersVisible = false;
			this.dgvTasks.RowHeadersWidth = 21;
			this.dgvTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTasks.Size = new System.Drawing.Size(1393, 472);
			this.dgvTasks.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvTasks.TabIndex = 0;
			// 
			// colPriority
			// 
			this.colPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPriority.DataPropertyName = "Priority";
			this.colPriority.FillWeight = 8F;
			this.colPriority.HeaderText = "Priorität";
			this.colPriority.Name = "colPriority";
			this.colPriority.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStatus.DataPropertyName = "Status";
			this.colStatus.FillWeight = 8F;
			this.colStatus.HeaderText = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			// 
			// colPercentCompleted
			// 
			this.colPercentCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPercentCompleted.DataPropertyName = "PercentCompleted";
			this.colPercentCompleted.FillWeight = 9F;
			this.colPercentCompleted.HeaderText = "Erledigt (%)";
			this.colPercentCompleted.Name = "colPercentCompleted";
			this.colPercentCompleted.ReadOnly = true;
			// 
			// colTaskName
			// 
			this.colTaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTaskName.DataPropertyName = "Taskname";
			this.colTaskName.FillWeight = 35F;
			this.colTaskName.HeaderText = "Aufgabe";
			this.colTaskName.Name = "colTaskName";
			this.colTaskName.ReadOnly = true;
			// 
			// colStartsAt
			// 
			this.colStartsAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStartsAt.DataPropertyName = "StartsAt";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = "Kein Datum";
			this.colStartsAt.DefaultCellStyle = dataGridViewCellStyle2;
			this.colStartsAt.FillWeight = 9F;
			this.colStartsAt.HeaderText = "Start";
			this.colStartsAt.Name = "colStartsAt";
			this.colStartsAt.ReadOnly = true;
			// 
			// colDueAt
			// 
			this.colDueAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDueAt.DataPropertyName = "DueAt";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = "Keine Ahnung";
			this.colDueAt.DefaultCellStyle = dataGridViewCellStyle3;
			this.colDueAt.FillWeight = 9F;
			this.colDueAt.HeaderText = "Fällig";
			this.colDueAt.Name = "colDueAt";
			this.colDueAt.ReadOnly = true;
			// 
			// colResponsible
			// 
			this.colResponsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colResponsible.DataPropertyName = "ResponsibleDisplayName";
			this.colResponsible.FillWeight = 10F;
			this.colResponsible.HeaderText = "Zuständig";
			this.colResponsible.Name = "colResponsible";
			this.colResponsible.ReadOnly = true;
			// 
			// colOwner
			// 
			this.colOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOwner.DataPropertyName = "OwnerDisplayName";
			this.colOwner.FillWeight = 10F;
			this.colOwner.HeaderText = "Erstellt von";
			this.colOwner.Name = "colOwner";
			this.colOwner.ReadOnly = true;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
			this.btnClose.Location = new System.Drawing.Point(1302, 850);
			this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(117, 30);
			this.btnClose.Style = MetroFramework.MetroColorStyle.Lime;
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseSelectable = true;
			this.btnClose.UseStyleColors = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// mtxtDescription
			// 
			this.mtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtDescription.CustomButton.Image = null;
			this.mtxtDescription.CustomButton.Location = new System.Drawing.Point(1223, 1);
			this.mtxtDescription.CustomButton.Name = "";
			this.mtxtDescription.CustomButton.Size = new System.Drawing.Size(169, 169);
			this.mtxtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtDescription.CustomButton.TabIndex = 1;
			this.mtxtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtDescription.CustomButton.UseSelectable = true;
			this.mtxtDescription.CustomButton.Visible = false;
			this.mtxtDescription.Lines = new string[] {
        "Aufgabenbeschreibung"};
			this.mtxtDescription.Location = new System.Drawing.Point(27, 651);
			this.mtxtDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 23);
			this.mtxtDescription.MaxLength = 32767;
			this.mtxtDescription.Multiline = true;
			this.mtxtDescription.Name = "mtxtDescription";
			this.mtxtDescription.PasswordChar = '\0';
			this.mtxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtDescription.SelectedText = "";
			this.mtxtDescription.SelectionLength = 0;
			this.mtxtDescription.SelectionStart = 0;
			this.mtxtDescription.Size = new System.Drawing.Size(1393, 171);
			this.mtxtDescription.Style = MetroFramework.MetroColorStyle.Lime;
			this.mtxtDescription.TabIndex = 7;
			this.mtxtDescription.Text = "Aufgabenbeschreibung";
			this.mtxtDescription.UseSelectable = true;
			this.mtxtDescription.UseStyleColors = true;
			this.mtxtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
			this.mtxtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnShowDetails
			// 
			this.btnShowDetails.BackColor = System.Drawing.Color.Transparent;
			this.btnShowDetails.FlatAppearance.BorderSize = 0;
			this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowDetails.Image = global::Products.Common.Properties.Resources.open_32_metrolime;
			this.btnShowDetails.Location = new System.Drawing.Point(115, 115);
			this.btnShowDetails.Margin = new System.Windows.Forms.Padding(3, 23, 23, 3);
			this.btnShowDetails.Name = "btnShowDetails";
			this.btnShowDetails.Size = new System.Drawing.Size(42, 42);
			this.btnShowDetails.TabIndex = 10;
			this.btnShowDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip1.SetToolTip(this.btnShowDetails, "Die markierte Aufgabe öffnen");
			this.btnShowDetails.UseVisualStyleBackColor = false;
			this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
			// 
			// btnPositionLoeschen
			// 
			this.btnPositionLoeschen.BackColor = System.Drawing.Color.Transparent;
			this.btnPositionLoeschen.FlatAppearance.BorderSize = 0;
			this.btnPositionLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPositionLoeschen.Image = global::Products.Common.Properties.Resources.garbage_32_metrolime;
			this.btnPositionLoeschen.Location = new System.Drawing.Point(1358, 115);
			this.btnPositionLoeschen.Margin = new System.Windows.Forms.Padding(3, 23, 23, 3);
			this.btnPositionLoeschen.Name = "btnPositionLoeschen";
			this.btnPositionLoeschen.Size = new System.Drawing.Size(42, 42);
			this.btnPositionLoeschen.TabIndex = 9;
			this.btnPositionLoeschen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip1.SetToolTip(this.btnPositionLoeschen, "Die markierte Aufgabe löschen");
			this.btnPositionLoeschen.UseVisualStyleBackColor = false;
			// 
			// btnNewTask
			// 
			this.btnNewTask.BackColor = System.Drawing.Color.Transparent;
			this.btnNewTask.FlatAppearance.BorderSize = 0;
			this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewTask.Image = global::Products.Common.Properties.Resources.neu_metrolime;
			this.btnNewTask.Location = new System.Drawing.Point(47, 115);
			this.btnNewTask.Margin = new System.Windows.Forms.Padding(23, 23, 23, 3);
			this.btnNewTask.Name = "btnNewTask";
			this.btnNewTask.Size = new System.Drawing.Size(42, 42);
			this.btnNewTask.TabIndex = 8;
			this.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip1.SetToolTip(this.btnNewTask, "Neue Aufgabe einfügen");
			this.btnNewTask.UseVisualStyleBackColor = false;
			this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.BackColor = System.Drawing.Color.White;
			this.toolTip1.InitialDelay = 250;
			this.toolTip1.ReshowDelay = 100;
			// 
			// TaskListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1447, 909);
			this.Controls.Add(this.btnShowDetails);
			this.Controls.Add(this.btnPositionLoeschen);
			this.Controls.Add(this.btnNewTask);
			this.Controls.Add(this.mtxtDescription);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvTasks);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TaskListView";
			this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "Meine Aufgaben";
			this.toolTip1.SetToolTip(this, "Deine Aufgabenliste halt ...");
			this.MouseEnter += new System.EventHandler(this.TaskListView_MouseEnter);
			((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvTasks;
		private MetroFramework.Controls.MetroButton btnClose;
		private MetroFramework.Controls.MetroTextBox mtxtDescription;
		private System.Windows.Forms.Button btnNewTask;
		private System.Windows.Forms.Button btnPositionLoeschen;
		private System.Windows.Forms.Button btnShowDetails;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPercentCompleted;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartsAt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDueAt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colResponsible;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwner;
	}
}