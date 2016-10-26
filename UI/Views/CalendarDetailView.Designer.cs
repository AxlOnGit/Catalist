namespace Products.Common.Views
{
	partial class CalendarDetailView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarDetailView));
			this.dtpStartsAtDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndsAtDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndsAtTime = new System.Windows.Forms.DateTimePicker();
			this.dtpStartsAtTime = new System.Windows.Forms.DateTimePicker();
			this.htmlEditor = new MSDN.Html.Editor.HtmlEditorControl();
			this.mtxtSubject = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mchkAllDayEvent = new MetroFramework.Controls.MetroCheckBox();
			this.mchkErinnerung = new MetroFramework.Controls.MetroCheckBox();
			this.mcmbErinnerung = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.mcmbAnzeigenAls = new MetroFramework.Controls.MetroComboBox();
			this.mlblCreator = new MetroFramework.Controls.MetroLabel();
			this.mlblLetzteAenderung = new MetroFramework.Controls.MetroLabel();
			this.mbtnClose = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
			this.mcmbAppointmentType = new MetroFramework.Controls.MetroComboBox();
			this.dgvLinkedItems = new MetroFramework.Controls.MetroGrid();
			this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLinkTypBezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mctxLinkedItems = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdAddLinkedItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xcmdOpenLinkedItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.xcmdDeleteLinkedItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mtxtLocation = new MetroFramework.Controls.MetroTextBox();
			this.mbtnSetAutoProperties = new System.Windows.Forms.Button();
			this.mbtnRemoveLinkedItem = new System.Windows.Forms.Button();
			this.mbtnAddLinkedItem = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mbtnSettings = new MetroFramework.Controls.MetroButton();
			this.mbtnOpenLinkedItem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLinkedItems)).BeginInit();
			this.mctxLinkedItems.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpStartsAtDate
			// 
			this.dtpStartsAtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartsAtDate.Location = new System.Drawing.Point(70, 167);
			this.dtpStartsAtDate.Name = "dtpStartsAtDate";
			this.dtpStartsAtDate.Size = new System.Drawing.Size(96, 22);
			this.dtpStartsAtDate.TabIndex = 2;
			this.dtpStartsAtDate.Validated += new System.EventHandler(this.dtpBeginnDatum_Validated);
			// 
			// dtpEndsAtDate
			// 
			this.dtpEndsAtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndsAtDate.Location = new System.Drawing.Point(70, 195);
			this.dtpEndsAtDate.Name = "dtpEndsAtDate";
			this.dtpEndsAtDate.Size = new System.Drawing.Size(96, 22);
			this.dtpEndsAtDate.TabIndex = 4;
			this.dtpEndsAtDate.ValueChanged += new System.EventHandler(this.dtpEndeDatum_ValueChanged);
			// 
			// dtpEndsAtTime
			// 
			this.dtpEndsAtTime.CustomFormat = "HH:mm";
			this.dtpEndsAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndsAtTime.Location = new System.Drawing.Point(172, 195);
			this.dtpEndsAtTime.Name = "dtpEndsAtTime";
			this.dtpEndsAtTime.ShowCheckBox = true;
			this.dtpEndsAtTime.Size = new System.Drawing.Size(66, 22);
			this.dtpEndsAtTime.TabIndex = 5;
			this.dtpEndsAtTime.Value = new System.DateTime(2015, 7, 9, 11, 30, 0, 0);
			// 
			// dtpStartsAtTime
			// 
			this.dtpStartsAtTime.CustomFormat = "HH:mm";
			this.dtpStartsAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartsAtTime.Location = new System.Drawing.Point(172, 167);
			this.dtpStartsAtTime.Name = "dtpStartsAtTime";
			this.dtpStartsAtTime.ShowCheckBox = true;
			this.dtpStartsAtTime.Size = new System.Drawing.Size(66, 22);
			this.dtpStartsAtTime.TabIndex = 3;
			this.dtpStartsAtTime.Value = new System.DateTime(2015, 7, 9, 8, 0, 0, 0);
			// 
			// htmlEditor
			// 
			this.htmlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.htmlEditor.BackColor = System.Drawing.Color.Transparent;
			this.htmlEditor.BodyFont = new MSDN.Html.Editor.HtmlFontProperty("Segoe UI", MSDN.Html.Editor.HtmlFontSize.Default, false, false, false, false, false, false);
			this.htmlEditor.BorderSize = ((byte)(1));
			this.htmlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.htmlEditor.InnerText = "Text";
			this.htmlEditor.Location = new System.Drawing.Point(23, 250);
			this.htmlEditor.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
			this.htmlEditor.Name = "htmlEditor";
			this.htmlEditor.NavigateAction = MSDN.Html.Editor.NavigateActionOption.NeuesFenster;
			this.htmlEditor.Padding = new System.Windows.Forms.Padding(3);
			this.htmlEditor.Size = new System.Drawing.Size(656, 529);
			this.htmlEditor.TabIndex = 9;
			// 
			// mtxtSubject
			// 
			this.mtxtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtSubject.CustomButton.Image = null;
			this.mtxtSubject.CustomButton.Location = new System.Drawing.Point(1036, 2);
			this.mtxtSubject.CustomButton.Name = "";
			this.mtxtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSubject.CustomButton.TabIndex = 1;
			this.mtxtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSubject.CustomButton.UseSelectable = true;
			this.mtxtSubject.CustomButton.Visible = false;
			this.mtxtSubject.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSubject.Lines = new string[0];
			this.mtxtSubject.Location = new System.Drawing.Point(23, 91);
			this.mtxtSubject.MaxLength = 32767;
			this.mtxtSubject.Name = "mtxtSubject";
			this.mtxtSubject.PasswordChar = '\0';
			this.mtxtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSubject.SelectedText = "";
			this.mtxtSubject.SelectionLength = 0;
			this.mtxtSubject.SelectionStart = 0;
			this.mtxtSubject.Size = new System.Drawing.Size(1060, 26);
			this.mtxtSubject.TabIndex = 0;
			this.mtxtSubject.UseSelectable = true;
			this.mtxtSubject.WaterMark = "Name des Termins";
			this.mtxtSubject.WaterMarkColor = System.Drawing.Color.Gray;
			this.mtxtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10F);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 167);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(40, 19);
			this.metroLabel1.TabIndex = 17;
			this.metroLabel1.Text = "Start:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 195);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(41, 19);
			this.metroLabel2.TabIndex = 18;
			this.metroLabel2.Text = "Ende:";
			// 
			// mchkAllDayEvent
			// 
			this.mchkAllDayEvent.AutoSize = true;
			this.mchkAllDayEvent.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkAllDayEvent.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkAllDayEvent.Location = new System.Drawing.Point(300, 167);
			this.mchkAllDayEvent.Name = "mchkAllDayEvent";
			this.mchkAllDayEvent.Size = new System.Drawing.Size(84, 19);
			this.mchkAllDayEvent.TabIndex = 7;
			this.mchkAllDayEvent.Text = "Ganztägig";
			this.mchkAllDayEvent.UseSelectable = true;
			// 
			// mchkErinnerung
			// 
			this.mchkErinnerung.AutoSize = true;
			this.mchkErinnerung.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkErinnerung.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkErinnerung.Location = new System.Drawing.Point(300, 195);
			this.mchkErinnerung.Name = "mchkErinnerung";
			this.mchkErinnerung.Size = new System.Drawing.Size(91, 19);
			this.mchkErinnerung.TabIndex = 6;
			this.mchkErinnerung.Text = "Erinnerung:";
			this.mchkErinnerung.UseSelectable = true;
			// 
			// mcmbErinnerung
			// 
			this.mcmbErinnerung.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbErinnerung.FormattingEnabled = true;
			this.mcmbErinnerung.ItemHeight = 23;
			this.mcmbErinnerung.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "30",
            "60",
            "90",
            "120"});
			this.mcmbErinnerung.Location = new System.Drawing.Point(397, 190);
			this.mcmbErinnerung.Name = "mcmbErinnerung";
			this.mcmbErinnerung.Size = new System.Drawing.Size(84, 29);
			this.mcmbErinnerung.TabIndex = 8;
			this.mcmbErinnerung.UseSelectable = true;
			this.mcmbErinnerung.SelectedValueChanged += new System.EventHandler(this.mcmbErinnerung_SelectedValueChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(526, 194);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(85, 19);
			this.metroLabel3.TabIndex = 22;
			this.metroLabel3.Text = "Anzeigen als:";
			// 
			// mcmbAnzeigenAls
			// 
			this.mcmbAnzeigenAls.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbAnzeigenAls.FormattingEnabled = true;
			this.mcmbAnzeigenAls.ItemHeight = 23;
			this.mcmbAnzeigenAls.Items.AddRange(new object[] {
            "Beschäftigt",
            "Frei",
            "Unter Vorbehalt",
            "Außer Haus"});
			this.mcmbAnzeigenAls.Location = new System.Drawing.Point(617, 190);
			this.mcmbAnzeigenAls.Name = "mcmbAnzeigenAls";
			this.mcmbAnzeigenAls.Size = new System.Drawing.Size(143, 29);
			this.mcmbAnzeigenAls.TabIndex = 9;
			this.mcmbAnzeigenAls.UseSelectable = true;
			this.mcmbAnzeigenAls.SelectedIndexChanged += new System.EventHandler(this.mcmbAnzeigenAls_SelectedIndexChanged);
			this.mcmbAnzeigenAls.Validated += new System.EventHandler(this.mcmbAnzeigenAls_Validated);
			// 
			// mlblCreator
			// 
			this.mlblCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblCreator.AutoSize = true;
			this.mlblCreator.Location = new System.Drawing.Point(23, 787);
			this.mlblCreator.Name = "mlblCreator";
			this.mlblCreator.Size = new System.Drawing.Size(84, 19);
			this.mlblCreator.TabIndex = 24;
			this.mlblCreator.Text = "Erfasst von ...";
			// 
			// mlblLetzteAenderung
			// 
			this.mlblLetzteAenderung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblLetzteAenderung.AutoSize = true;
			this.mlblLetzteAenderung.Location = new System.Drawing.Point(23, 806);
			this.mlblLetzteAenderung.Name = "mlblLetzteAenderung";
			this.mlblLetzteAenderung.Size = new System.Drawing.Size(141, 19);
			this.mlblLetzteAenderung.TabIndex = 25;
			this.mlblLetzteAenderung.Text = "Letzte Änderung am ...";
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Image = null;
			this.mbtnClose.Location = new System.Drawing.Point(983, 799);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.TabIndex = 13;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseVisualStyleBackColor = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mcmbAppointmentType
			// 
			this.mcmbAppointmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmbAppointmentType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.mcmbAppointmentType.FormattingEnabled = true;
			this.mcmbAppointmentType.ItemHeight = 23;
			this.mcmbAppointmentType.Location = new System.Drawing.Point(702, 250);
			this.mcmbAppointmentType.Name = "mcmbAppointmentType";
			this.mcmbAppointmentType.PromptText = "Art des Termins";
			this.mcmbAppointmentType.Size = new System.Drawing.Size(381, 29);
			this.mcmbAppointmentType.TabIndex = 10;
			this.mcmbAppointmentType.UseSelectable = true;
			// 
			// dgvLinkedItems
			// 
			this.dgvLinkedItems.AllowUserToAddRows = false;
			this.dgvLinkedItems.AllowUserToDeleteRows = false;
			this.dgvLinkedItems.AllowUserToResizeRows = false;
			this.dgvLinkedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLinkedItems.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvLinkedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvLinkedItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvLinkedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLinkedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvLinkedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLinkedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colLinkTypBezeichnung});
			this.dgvLinkedItems.ContextMenuStrip = this.mctxLinkedItems;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLinkedItems.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvLinkedItems.EnableHeadersVisualStyles = false;
			this.dgvLinkedItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvLinkedItems.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvLinkedItems.HighLightPercentage = 1.2F;
			this.dgvLinkedItems.Location = new System.Drawing.Point(702, 362);
			this.dgvLinkedItems.MultiSelect = false;
			this.dgvLinkedItems.Name = "dgvLinkedItems";
			this.dgvLinkedItems.ReadOnly = true;
			this.dgvLinkedItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLinkedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvLinkedItems.RowHeadersVisible = false;
			this.dgvLinkedItems.RowHeadersWidth = 21;
			this.dgvLinkedItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvLinkedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLinkedItems.Size = new System.Drawing.Size(381, 417);
			this.dgvLinkedItems.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvLinkedItems.TabIndex = 12;
			this.dgvLinkedItems.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkedItems_RowEnter);
			// 
			// colItemName
			// 
			this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colItemName.DataPropertyName = "ItemName";
			this.colItemName.FillWeight = 65F;
			this.colItemName.HeaderText = "Verknüpft mit";
			this.colItemName.Name = "colItemName";
			this.colItemName.ReadOnly = true;
			// 
			// colLinkTypBezeichnung
			// 
			this.colLinkTypBezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLinkTypBezeichnung.DataPropertyName = "LinkTypBezeichnung";
			this.colLinkTypBezeichnung.FillWeight = 35F;
			this.colLinkTypBezeichnung.HeaderText = "Typ";
			this.colLinkTypBezeichnung.Name = "colLinkTypBezeichnung";
			this.colLinkTypBezeichnung.ReadOnly = true;
			// 
			// mctxLinkedItems
			// 
			this.mctxLinkedItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdAddLinkedItem,
            this.xcmdOpenLinkedItem,
            this.toolStripMenuItem1,
            this.xcmdDeleteLinkedItem});
			this.mctxLinkedItems.Name = "mctxLinkedItems";
			this.mctxLinkedItems.Size = new System.Drawing.Size(187, 76);
			// 
			// xcmdAddLinkedItem
			// 
			this.xcmdAddLinkedItem.Image = global::Products.Common.Properties.Resources.add_16_metroorange;
			this.xcmdAddLinkedItem.Name = "xcmdAddLinkedItem";
			this.xcmdAddLinkedItem.Size = new System.Drawing.Size(186, 22);
			this.xcmdAddLinkedItem.Text = "Neue Verknüpfung";
			this.xcmdAddLinkedItem.Click += new System.EventHandler(this.xcmdAddLinkedItem_Click);
			// 
			// xcmdOpenLinkedItem
			// 
			this.xcmdOpenLinkedItem.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdOpenLinkedItem.Name = "xcmdOpenLinkedItem";
			this.xcmdOpenLinkedItem.Size = new System.Drawing.Size(186, 22);
			this.xcmdOpenLinkedItem.Text = "Element öffnen";
			this.xcmdOpenLinkedItem.Click += new System.EventHandler(this.xcmdOpenLinkedItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
			// 
			// xcmdDeleteLinkedItem
			// 
			this.xcmdDeleteLinkedItem.Image = global::Products.Common.Properties.Resources.delete_16_metroorange;
			this.xcmdDeleteLinkedItem.Name = "xcmdDeleteLinkedItem";
			this.xcmdDeleteLinkedItem.Size = new System.Drawing.Size(186, 22);
			this.xcmdDeleteLinkedItem.Text = "Verknüpfung löschen";
			this.xcmdDeleteLinkedItem.Click += new System.EventHandler(this.xcmdDeleteLinkedItem_Click);
			// 
			// mtxtLocation
			// 
			this.mtxtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtLocation.CustomButton.Image = null;
			this.mtxtLocation.CustomButton.Location = new System.Drawing.Point(1036, 2);
			this.mtxtLocation.CustomButton.Name = "";
			this.mtxtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtLocation.CustomButton.TabIndex = 1;
			this.mtxtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtLocation.CustomButton.UseSelectable = true;
			this.mtxtLocation.CustomButton.Visible = false;
			this.mtxtLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtLocation.Lines = new string[0];
			this.mtxtLocation.Location = new System.Drawing.Point(23, 123);
			this.mtxtLocation.MaxLength = 32767;
			this.mtxtLocation.Name = "mtxtLocation";
			this.mtxtLocation.PasswordChar = '\0';
			this.mtxtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtLocation.SelectedText = "";
			this.mtxtLocation.SelectionLength = 0;
			this.mtxtLocation.SelectionStart = 0;
			this.mtxtLocation.Size = new System.Drawing.Size(1060, 26);
			this.mtxtLocation.TabIndex = 1;
			this.mtxtLocation.UseSelectable = true;
			this.mtxtLocation.WaterMark = "Ort des Termins";
			this.mtxtLocation.WaterMarkColor = System.Drawing.Color.Gray;
			this.mtxtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10F);
			// 
			// mbtnSetAutoProperties
			// 
			this.mbtnSetAutoProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnSetAutoProperties.BackColor = System.Drawing.Color.Transparent;
			this.mbtnSetAutoProperties.BackgroundImage = global::Products.Common.Properties.Resources.info_32_metroorange;
			this.mbtnSetAutoProperties.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnSetAutoProperties.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnSetAutoProperties.FlatAppearance.BorderSize = 0;
			this.mbtnSetAutoProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnSetAutoProperties.Location = new System.Drawing.Point(841, 320);
			this.mbtnSetAutoProperties.Margin = new System.Windows.Forms.Padding(10, 10, 20, 3);
			this.mbtnSetAutoProperties.Name = "mbtnSetAutoProperties";
			this.mbtnSetAutoProperties.Size = new System.Drawing.Size(36, 36);
			this.mbtnSetAutoProperties.TabIndex = 26;
			this.toolTip1.SetToolTip(this.mbtnSetAutoProperties, "Termineigenschaften automatisch eintragen");
			this.mbtnSetAutoProperties.UseVisualStyleBackColor = false;
			this.mbtnSetAutoProperties.Click += new System.EventHandler(this.mbtnSetAutoProperties_Click);
			// 
			// mbtnRemoveLinkedItem
			// 
			this.mbtnRemoveLinkedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnRemoveLinkedItem.BackColor = System.Drawing.Color.Transparent;
			this.mbtnRemoveLinkedItem.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.mbtnRemoveLinkedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnRemoveLinkedItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnRemoveLinkedItem.FlatAppearance.BorderSize = 0;
			this.mbtnRemoveLinkedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnRemoveLinkedItem.Location = new System.Drawing.Point(1040, 320);
			this.mbtnRemoveLinkedItem.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
			this.mbtnRemoveLinkedItem.Name = "mbtnRemoveLinkedItem";
			this.mbtnRemoveLinkedItem.Size = new System.Drawing.Size(36, 36);
			this.mbtnRemoveLinkedItem.TabIndex = 14;
			this.toolTip1.SetToolTip(this.mbtnRemoveLinkedItem, "Das markierte Element aus der Liste entfernen");
			this.mbtnRemoveLinkedItem.UseVisualStyleBackColor = false;
			this.mbtnRemoveLinkedItem.Click += new System.EventHandler(this.mbtnRemoveLinkedItem_Click);
			// 
			// mbtnAddLinkedItem
			// 
			this.mbtnAddLinkedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnAddLinkedItem.BackColor = System.Drawing.Color.Transparent;
			this.mbtnAddLinkedItem.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metroorange;
			this.mbtnAddLinkedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnAddLinkedItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnAddLinkedItem.FlatAppearance.BorderSize = 0;
			this.mbtnAddLinkedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnAddLinkedItem.Location = new System.Drawing.Point(709, 320);
			this.mbtnAddLinkedItem.Margin = new System.Windows.Forms.Padding(10, 10, 20, 3);
			this.mbtnAddLinkedItem.Name = "mbtnAddLinkedItem";
			this.mbtnAddLinkedItem.Size = new System.Drawing.Size(36, 36);
			this.mbtnAddLinkedItem.TabIndex = 11;
			this.toolTip1.SetToolTip(this.mbtnAddLinkedItem, "Neue Verknüpfung mit diesem Termin einfügen");
			this.mbtnAddLinkedItem.UseVisualStyleBackColor = false;
			this.mbtnAddLinkedItem.Click += new System.EventHandler(this.mbtnAddLinkedItem_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.UseAnimation = false;
			this.toolTip1.UseFading = false;
			// 
			// mbtnSettings
			// 
			this.mbtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnSettings.BackColor = System.Drawing.Color.Transparent;
			this.mbtnSettings.BackgroundImage = global::Products.Common.Properties.Resources.settings_24_metroorange;
			this.mbtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnSettings.Location = new System.Drawing.Point(709, 785);
			this.mbtnSettings.Name = "mbtnSettings";
			this.mbtnSettings.Size = new System.Drawing.Size(30, 30);
			this.mbtnSettings.TabIndex = 27;
			this.toolTip1.SetToolTip(this.mbtnSettings, "Einstellungen für neue Termine und den Kalender anzeigen und ändern");
			this.mbtnSettings.UseCustomBackColor = true;
			this.mbtnSettings.UseCustomForeColor = true;
			this.mbtnSettings.UseSelectable = true;
			this.mbtnSettings.Click += new System.EventHandler(this.mbtnSettings_Click);
			// 
			// mbtnOpenLinkedItem
			// 
			this.mbtnOpenLinkedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOpenLinkedItem.BackColor = System.Drawing.Color.Transparent;
			this.mbtnOpenLinkedItem.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metroorange;
			this.mbtnOpenLinkedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnOpenLinkedItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnOpenLinkedItem.FlatAppearance.BorderSize = 0;
			this.mbtnOpenLinkedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnOpenLinkedItem.Location = new System.Drawing.Point(775, 320);
			this.mbtnOpenLinkedItem.Margin = new System.Windows.Forms.Padding(10, 10, 20, 3);
			this.mbtnOpenLinkedItem.Name = "mbtnOpenLinkedItem";
			this.mbtnOpenLinkedItem.Size = new System.Drawing.Size(36, 36);
			this.mbtnOpenLinkedItem.TabIndex = 28;
			this.toolTip1.SetToolTip(this.mbtnOpenLinkedItem, "Das verknüpfte Element öffnen");
			this.mbtnOpenLinkedItem.UseVisualStyleBackColor = false;
			this.mbtnOpenLinkedItem.Click += new System.EventHandler(this.xcmdOpenLinkedItem_Click);
			// 
			// CalendarDetailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1106, 848);
			this.Controls.Add(this.mbtnOpenLinkedItem);
			this.Controls.Add(this.mbtnSettings);
			this.Controls.Add(this.mbtnSetAutoProperties);
			this.Controls.Add(this.mbtnRemoveLinkedItem);
			this.Controls.Add(this.mbtnAddLinkedItem);
			this.Controls.Add(this.mtxtLocation);
			this.Controls.Add(this.dgvLinkedItems);
			this.Controls.Add(this.mcmbAppointmentType);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.mlblLetzteAenderung);
			this.Controls.Add(this.mlblCreator);
			this.Controls.Add(this.mcmbAnzeigenAls);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.mcmbErinnerung);
			this.Controls.Add(this.mchkErinnerung);
			this.Controls.Add(this.mchkAllDayEvent);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mtxtSubject);
			this.Controls.Add(this.htmlEditor);
			this.Controls.Add(this.dtpStartsAtTime);
			this.Controls.Add(this.dtpEndsAtTime);
			this.Controls.Add(this.dtpEndsAtDate);
			this.Controls.Add(this.dtpStartsAtDate);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 700);
			this.Name = "CalendarDetailView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Termin";
			((System.ComponentModel.ISupportInitialize)(this.dgvLinkedItems)).EndInit();
			this.mctxLinkedItems.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpStartsAtDate;
		private System.Windows.Forms.DateTimePicker dtpEndsAtDate;
		private System.Windows.Forms.DateTimePicker dtpEndsAtTime;
		private System.Windows.Forms.DateTimePicker dtpStartsAtTime;
		private MSDN.Html.Editor.HtmlEditorControl htmlEditor;
		private MetroFramework.Controls.MetroTextBox mtxtSubject;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroCheckBox mchkAllDayEvent;
		private MetroFramework.Controls.MetroCheckBox mchkErinnerung;
		private MetroFramework.Controls.MetroComboBox mcmbErinnerung;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox mcmbAnzeigenAls;
		private MetroFramework.Controls.MetroLabel mlblCreator;
		private MetroFramework.Controls.MetroLabel mlblLetzteAenderung;
		private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtnClose;
		private MetroFramework.Controls.MetroComboBox mcmbAppointmentType;
		private MetroFramework.Controls.MetroGrid dgvLinkedItems;
		private MetroFramework.Controls.MetroTextBox mtxtLocation;
		private MetroFramework.Controls.MetroContextMenu mctxLinkedItems;
		private System.Windows.Forms.ToolStripMenuItem xcmdAddLinkedItem;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenLinkedItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLinkTypBezeichnung;
		private System.Windows.Forms.ToolStripMenuItem xcmdDeleteLinkedItem;
		private System.Windows.Forms.Button mbtnAddLinkedItem;
		private System.Windows.Forms.Button mbtnRemoveLinkedItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.Button mbtnSetAutoProperties;
		private System.Windows.Forms.ToolTip toolTip1;
		private MetroFramework.Controls.MetroButton mbtnSettings;
		private System.Windows.Forms.Button mbtnOpenLinkedItem;
	}
}