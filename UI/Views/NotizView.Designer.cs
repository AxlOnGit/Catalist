namespace Products.Common.Views
{
	partial class NotizView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotizView));
			this.lblErfassung = new MetroFramework.Controls.MetroLabel();
			this.label3 = new MetroFramework.Controls.MetroLabel();
			this.txtNotiztext = new MetroFramework.Controls.MetroTextBox();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.mtxtThema = new MetroFramework.Controls.MetroTextBox();
			this.btnDelegiereMich = new System.Windows.Forms.Button();
			this.mtoolTip = new MetroFramework.Components.MetroToolTip();
			this.btnRemoveLink = new System.Windows.Forms.Button();
			this.dgvDateilinks = new MetroFramework.Controls.MetroGrid();
			this.colFileTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOpenFileLink = new System.Windows.Forms.Button();
			this.btnAddFileLink = new System.Windows.Forms.Button();
			this.mlblDateilinks = new MetroFramework.Controls.MetroLabel();
			this.mlblFontSize = new MetroFramework.Controls.MetroLink();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mdtpCreatedAt = new MetroFramework.Controls.MetroDateTime();
			this.mcmbKontakt = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvDateilinks)).BeginInit();
			this.SuspendLayout();
			// 
			// lblErfassung
			// 
			this.lblErfassung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblErfassung.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblErfassung.Location = new System.Drawing.Point(184, 546);
			this.lblErfassung.Name = "lblErfassung";
			this.lblErfassung.Size = new System.Drawing.Size(623, 86);
			this.lblErfassung.TabIndex = 7;
			this.lblErfassung.Text = "Am Hmpften erfasst von Gnurz";
			this.lblErfassung.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 19);
			this.label3.TabIndex = 52;
			this.label3.Text = "Thema:";
			// 
			// txtNotiztext
			// 
			this.txtNotiztext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtNotiztext.CustomButton.Image = null;
			this.txtNotiztext.CustomButton.Location = new System.Drawing.Point(366, 2);
			this.txtNotiztext.CustomButton.Name = "";
			this.txtNotiztext.CustomButton.Size = new System.Drawing.Size(357, 357);
			this.txtNotiztext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNotiztext.CustomButton.TabIndex = 1;
			this.txtNotiztext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNotiztext.CustomButton.UseSelectable = true;
			this.txtNotiztext.CustomButton.Visible = false;
			this.txtNotiztext.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNotiztext.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtNotiztext.Lines = new string[0];
			this.txtNotiztext.Location = new System.Drawing.Point(81, 164);
			this.txtNotiztext.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.txtNotiztext.MaxLength = 32767;
			this.txtNotiztext.Multiline = true;
			this.txtNotiztext.Name = "txtNotiztext";
			this.txtNotiztext.PasswordChar = '\0';
			this.txtNotiztext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotiztext.SelectedText = "";
			this.txtNotiztext.SelectionLength = 0;
			this.txtNotiztext.SelectionStart = 0;
			this.txtNotiztext.ShortcutsEnabled = true;
			this.txtNotiztext.Size = new System.Drawing.Size(726, 362);
			this.txtNotiztext.TabIndex = 2;
			this.txtNotiztext.UseSelectable = true;
			this.txtNotiztext.WaterMark = "Notizentext";
			this.txtNotiztext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNotiztext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.Location = new System.Drawing.Point(707, 846);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(100, 26);
			this.mbtnClose.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mbtnClose.TabIndex = 9;
			this.mbtnClose.Text = "Schließen";
			this.mtoolTip.SetToolTip(this.mbtnClose, "Hä? Was wohl ...");
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.UseStyleColors = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// mtxtThema
			// 
			this.mtxtThema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtThema.CustomButton.Image = null;
			this.mtxtThema.CustomButton.Location = new System.Drawing.Point(662, 1);
			this.mtxtThema.CustomButton.Name = "";
			this.mtxtThema.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtThema.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtThema.CustomButton.TabIndex = 1;
			this.mtxtThema.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtThema.CustomButton.UseSelectable = true;
			this.mtxtThema.CustomButton.Visible = false;
			this.mtxtThema.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtThema.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtThema.Lines = new string[0];
			this.mtxtThema.Location = new System.Drawing.Point(81, 135);
			this.mtxtThema.MaxLength = 32767;
			this.mtxtThema.Name = "mtxtThema";
			this.mtxtThema.PasswordChar = '\0';
			this.mtxtThema.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtThema.SelectedText = "";
			this.mtxtThema.SelectionLength = 0;
			this.mtxtThema.SelectionStart = 0;
			this.mtxtThema.ShortcutsEnabled = true;
			this.mtxtThema.Size = new System.Drawing.Size(684, 23);
			this.mtxtThema.TabIndex = 1;
			this.mtxtThema.UseSelectable = true;
			this.mtxtThema.WaterMark = "Worum geht\'s?";
			this.mtxtThema.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtThema.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnDelegiereMich
			// 
			this.btnDelegiereMich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelegiereMich.BackColor = System.Drawing.Color.Transparent;
			this.btnDelegiereMich.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDelegiereMich.FlatAppearance.BorderSize = 0;
			this.btnDelegiereMich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelegiereMich.Image = global::Products.Common.Properties.Resources.forward_32_metroorange;
			this.btnDelegiereMich.Location = new System.Drawing.Point(771, 122);
			this.btnDelegiereMich.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.btnDelegiereMich.Name = "btnDelegiereMich";
			this.btnDelegiereMich.Size = new System.Drawing.Size(36, 36);
			this.btnDelegiereMich.TabIndex = 4;
			this.btnDelegiereMich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mtoolTip.SetToolTip(this.btnDelegiereMich, "Diese Notiz jemand anderem auf\'s Auge drücken");
			this.btnDelegiereMich.UseVisualStyleBackColor = false;
			this.btnDelegiereMich.Click += new System.EventHandler(this.btnDelegiereMich_Click);
			// 
			// mtoolTip
			// 
			this.mtoolTip.AutoPopDelay = 3000;
			this.mtoolTip.InitialDelay = 500;
			this.mtoolTip.ReshowDelay = 100;
			this.mtoolTip.Style = MetroFramework.MetroColorStyle.Default;
			this.mtoolTip.StyleManager = null;
			this.mtoolTip.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtoolTip.UseAnimation = false;
			this.mtoolTip.UseFading = false;
			// 
			// btnRemoveLink
			// 
			this.btnRemoveLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveLink.BackColor = System.Drawing.Color.Transparent;
			this.btnRemoveLink.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.btnRemoveLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnRemoveLink.FlatAppearance.BorderSize = 0;
			this.btnRemoveLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveLink.Location = new System.Drawing.Point(771, 642);
			this.btnRemoveLink.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnRemoveLink.Name = "btnRemoveLink";
			this.btnRemoveLink.Size = new System.Drawing.Size(36, 36);
			this.btnRemoveLink.TabIndex = 7;
			this.mtoolTip.SetToolTip(this.btnRemoveLink, "Die ausgewählte Datei löschen");
			this.btnRemoveLink.UseVisualStyleBackColor = false;
			this.btnRemoveLink.Click += new System.EventHandler(this.btnRemoveLink_Click);
			// 
			// dgvDateilinks
			// 
			this.dgvDateilinks.AllowUserToAddRows = false;
			this.dgvDateilinks.AllowUserToDeleteRows = false;
			this.dgvDateilinks.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.dgvDateilinks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDateilinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDateilinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDateilinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDateilinks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvDateilinks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDateilinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDateilinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDateilinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
						this.colFileTitle,
						this.colDescription,
						this.colExtension});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDateilinks.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDateilinks.EnableHeadersVisualStyles = false;
			this.dgvDateilinks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvDateilinks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDateilinks.HighLightPercentage = 1.2F;
			this.dgvDateilinks.Location = new System.Drawing.Point(79, 684);
			this.dgvDateilinks.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvDateilinks.Name = "dgvDateilinks";
			this.dgvDateilinks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDateilinks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvDateilinks.RowHeadersVisible = false;
			this.dgvDateilinks.RowHeadersWidth = 21;
			this.dgvDateilinks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDateilinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDateilinks.Size = new System.Drawing.Size(728, 135);
			this.dgvDateilinks.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvDateilinks.TabIndex = 8;
			this.mtoolTip.SetToolTip(this.dgvDateilinks, "Liste der mit dieser Notiz verknüpften Dateien");
			this.dgvDateilinks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDateilinks_RowEnter);
			this.dgvDateilinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDateilinks_MouseDoubleClick);
			// 
			// colFileTitle
			// 
			this.colFileTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFileTitle.DataPropertyName = "FileTitle";
			this.colFileTitle.FillWeight = 30F;
			this.colFileTitle.HeaderText = "Dateititel";
			this.colFileTitle.Name = "colFileTitle";
			// 
			// colDescription
			// 
			this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDescription.DataPropertyName = "Description";
			this.colDescription.FillWeight = 60F;
			this.colDescription.HeaderText = "Beschreibung";
			this.colDescription.Name = "colDescription";
			// 
			// colExtension
			// 
			this.colExtension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colExtension.DataPropertyName = "Extension";
			this.colExtension.FillWeight = 10F;
			this.colExtension.HeaderText = "Typ";
			this.colExtension.Name = "colExtension";
			// 
			// btnOpenFileLink
			// 
			this.btnOpenFileLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOpenFileLink.BackColor = System.Drawing.Color.Transparent;
			this.btnOpenFileLink.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metroorange;
			this.btnOpenFileLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFileLink.FlatAppearance.BorderSize = 0;
			this.btnOpenFileLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFileLink.Location = new System.Drawing.Point(214, 642);
			this.btnOpenFileLink.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnOpenFileLink.Name = "btnOpenFileLink";
			this.btnOpenFileLink.Size = new System.Drawing.Size(36, 36);
			this.btnOpenFileLink.TabIndex = 6;
			this.mtoolTip.SetToolTip(this.btnOpenFileLink, "Die ausgewählte Datei mit dem dafür vorgesehenen Programm öffnen");
			this.btnOpenFileLink.UseVisualStyleBackColor = false;
			this.btnOpenFileLink.Click += new System.EventHandler(this.btnOpenFileLink_Click);
			// 
			// btnAddFileLink
			// 
			this.btnAddFileLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddFileLink.BackColor = System.Drawing.Color.Transparent;
			this.btnAddFileLink.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metroorange;
			this.btnAddFileLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddFileLink.FlatAppearance.BorderSize = 0;
			this.btnAddFileLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddFileLink.Location = new System.Drawing.Point(155, 645);
			this.btnAddFileLink.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.btnAddFileLink.Name = "btnAddFileLink";
			this.btnAddFileLink.Size = new System.Drawing.Size(36, 36);
			this.btnAddFileLink.TabIndex = 5;
			this.mtoolTip.SetToolTip(this.btnAddFileLink, "Neue Datei mit dieser Notiz verknüpfen");
			this.btnAddFileLink.UseVisualStyleBackColor = false;
			this.btnAddFileLink.Click += new System.EventHandler(this.btnAddFileLink_Click);
			// 
			// mlblDateilinks
			// 
			this.mlblDateilinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblDateilinks.AutoSize = true;
			this.mlblDateilinks.FontSize = MetroFramework.MetroLabelSize.Small;
			this.mlblDateilinks.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.mlblDateilinks.Location = new System.Drawing.Point(81, 666);
			this.mlblDateilinks.Name = "mlblDateilinks";
			this.mlblDateilinks.Size = new System.Drawing.Size(51, 15);
			this.mlblDateilinks.TabIndex = 136;
			this.mlblDateilinks.Text = "Dateien";
			// 
			// mlblFontSize
			// 
			this.mlblFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mlblFontSize.Location = new System.Drawing.Point(81, 531);
			this.mlblFontSize.Name = "mlblFontSize";
			this.mlblFontSize.Size = new System.Drawing.Size(97, 23);
			this.mlblFontSize.TabIndex = 3;
			this.mlblFontSize.Text = "Schriftgröße";
			this.mlblFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mlblFontSize.UseSelectable = true;
			this.mlblFontSize.Click += new System.EventHandler(this.mlblFontSize_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 100);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(51, 19);
			this.metroLabel1.TabIndex = 138;
			this.metroLabel1.Text = "Datum:";
			// 
			// mdtpCreatedAt
			// 
			this.mdtpCreatedAt.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
			this.mdtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.mdtpCreatedAt.Location = new System.Drawing.Point(81, 100);
			this.mdtpCreatedAt.MinimumSize = new System.Drawing.Size(0, 29);
			this.mdtpCreatedAt.Name = "mdtpCreatedAt";
			this.mdtpCreatedAt.Size = new System.Drawing.Size(110, 29);
			this.mdtpCreatedAt.Style = MetroFramework.MetroColorStyle.Orange;
			this.mdtpCreatedAt.TabIndex = 0;
			this.mdtpCreatedAt.UseStyleColors = true;
			// 
			// mcmbKontakt
			// 
			this.mcmbKontakt.FormattingEnabled = true;
			this.mcmbKontakt.ItemHeight = 23;
			this.mcmbKontakt.Location = new System.Drawing.Point(303, 100);
			this.mcmbKontakt.Name = "mcmbKontakt";
			this.mcmbKontakt.Size = new System.Drawing.Size(195, 29);
			this.mcmbKontakt.TabIndex = 139;
			this.mcmbKontakt.UseSelectable = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(242, 100);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(55, 19);
			this.metroLabel2.TabIndex = 140;
			this.metroLabel2.Text = "Kontakt:";
			// 
			// NotizView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 895);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mcmbKontakt);
			this.Controls.Add(this.mdtpCreatedAt);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mlblFontSize);
			this.Controls.Add(this.btnRemoveLink);
			this.Controls.Add(this.btnOpenFileLink);
			this.Controls.Add(this.mlblDateilinks);
			this.Controls.Add(this.btnAddFileLink);
			this.Controls.Add(this.dgvDateilinks);
			this.Controls.Add(this.btnDelegiereMich);
			this.Controls.Add(this.mtxtThema);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.txtNotiztext);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblErfassung);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NotizView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Thema der Notiz";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotizView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvDateilinks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lblErfassung;
		private MetroFramework.Controls.MetroLabel label3;
		private MetroFramework.Controls.MetroTextBox txtNotiztext;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private MetroFramework.Controls.MetroTextBox mtxtThema;
		private System.Windows.Forms.Button btnDelegiereMich;
		private MetroFramework.Components.MetroToolTip mtoolTip;
		private System.Windows.Forms.Button btnOpenFileLink;
		private MetroFramework.Controls.MetroLabel mlblDateilinks;
		private System.Windows.Forms.Button btnAddFileLink;
		private MetroFramework.Controls.MetroGrid dgvDateilinks;
		private System.Windows.Forms.Button btnRemoveLink;
		private MetroFramework.Controls.MetroLink mlblFontSize;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroDateTime mdtpCreatedAt;
		private MetroFramework.Controls.MetroComboBox mcmbKontakt;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExtension;
	}
}