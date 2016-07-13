namespace Products.Common.Views
{
	partial class CustomerMachineView
	{
		private MetroFramework.Controls.MetroLabel lblKunde;
		private MetroFramework.Controls.MetroTextBox txtSerialNumber;
		private MetroFramework.Controls.MetroTextBox txtColorSet;
		private MetroFramework.Controls.MetroTextBox txtGekauftBei;
		private MetroFramework.Controls.MetroTextBox txtFirmware;
		private System.Windows.Forms.ComboBox cmbMachineModel;
		private MetroFramework.Controls.MetroLabel label1;
		private MetroFramework.Controls.MetroLabel label2;
		private MetroFramework.Controls.MetroLabel label3;
		private System.Windows.Forms.ComboBox cmbInkType;
		private MetroFramework.Controls.MetroLabel label4;
		private MetroFramework.Controls.MetroLabel label5;
		private MetroFramework.Controls.MetroLabel label6;
		private System.Windows.Forms.CheckBox chkLeasingFlag;
		private MetroFramework.Controls.MetroLabel label7;
		private MetroFramework.Controls.MetroGrid dgvSoftware;
		private MetroFramework.Controls.MetroLabel label9;
		private System.Windows.Forms.CheckBox chkMietkaufFlag;
		private MetroFramework.Controls.MetroLabel label10;
		private MetroFramework.Controls.MetroTextBox txtFinanzierungsgesellschaft;
		private System.Windows.Forms.CheckBox chkErstverwertungsFlag;
		private MetroFramework.Controls.MetroLabel label11;
		private MetroFramework.Controls.MetroTextBox txtAuftragInSage;
		private MetroFramework.Controls.MetroLabel label12;

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMachineView));
			this.lblKunde = new MetroFramework.Controls.MetroLabel();
			this.txtSerialNumber = new MetroFramework.Controls.MetroTextBox();
			this.txtColorSet = new MetroFramework.Controls.MetroTextBox();
			this.txtGekauftBei = new MetroFramework.Controls.MetroTextBox();
			this.txtFirmware = new MetroFramework.Controls.MetroTextBox();
			this.cmbMachineModel = new System.Windows.Forms.ComboBox();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.label3 = new MetroFramework.Controls.MetroLabel();
			this.cmbInkType = new System.Windows.Forms.ComboBox();
			this.label4 = new MetroFramework.Controls.MetroLabel();
			this.label5 = new MetroFramework.Controls.MetroLabel();
			this.label6 = new MetroFramework.Controls.MetroLabel();
			this.chkLeasingFlag = new System.Windows.Forms.CheckBox();
			this.label7 = new MetroFramework.Controls.MetroLabel();
			this.dgvSoftware = new MetroFramework.Controls.MetroGrid();
			this.colSoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInstallationsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHauptbenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLizenzSchluessel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnmerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label9 = new MetroFramework.Controls.MetroLabel();
			this.chkMietkaufFlag = new System.Windows.Forms.CheckBox();
			this.label10 = new MetroFramework.Controls.MetroLabel();
			this.txtFinanzierungsgesellschaft = new MetroFramework.Controls.MetroTextBox();
			this.chkErstverwertungsFlag = new System.Windows.Forms.CheckBox();
			this.label11 = new MetroFramework.Controls.MetroLabel();
			this.txtAuftragInSage = new MetroFramework.Controls.MetroTextBox();
			this.label12 = new MetroFramework.Controls.MetroLabel();
			this.dgvNotizen = new MetroFramework.Controls.MetroGrid();
			this.colErfassungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colThema = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNotiztext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNotizen = new MetroFramework.Controls.MetroLabel();
			this.label8 = new MetroFramework.Controls.MetroLabel();
			this.txtWartungsintervall = new MetroFramework.Controls.MetroTextBox();
			this.label13 = new MetroFramework.Controls.MetroLabel();
			this.label14 = new MetroFramework.Controls.MetroLabel();
			this.ndtpFinanzierungsende = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpKaufdatum = new Products.UI.Controls.NullableDateTimePicker();
			this.mbtnClose = new MetroFramework.Controls.MetroButton();
			this.btnNeueMaschine = new System.Windows.Forms.Button();
			this.btnNeueNotiz = new System.Windows.Forms.Button();
			this.btnNeueSoftware = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).BeginInit();
			this.SuspendLayout();
			// 
			// lblKunde
			// 
			this.lblKunde.AutoSize = true;
			this.lblKunde.Location = new System.Drawing.Point(23, 60);
			this.lblKunde.Name = "lblKunde";
			this.lblKunde.Size = new System.Drawing.Size(50, 19);
			this.lblKunde.TabIndex = 51;
			this.lblKunde.Text = "Modell";
			// 
			// txtSerialNumber
			// 
			// 
			// 
			// 
			this.txtSerialNumber.CustomButton.Image = null;
			this.txtSerialNumber.CustomButton.Location = new System.Drawing.Point(133, 2);
			this.txtSerialNumber.CustomButton.Name = "";
			this.txtSerialNumber.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtSerialNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSerialNumber.CustomButton.TabIndex = 1;
			this.txtSerialNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSerialNumber.CustomButton.UseSelectable = true;
			this.txtSerialNumber.CustomButton.Visible = false;
			this.txtSerialNumber.Lines = new string[0];
			this.txtSerialNumber.Location = new System.Drawing.Point(217, 148);
			this.txtSerialNumber.MaxLength = 32767;
			this.txtSerialNumber.Name = "txtSerialNumber";
			this.txtSerialNumber.PasswordChar = '\0';
			this.txtSerialNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSerialNumber.SelectedText = "";
			this.txtSerialNumber.SelectionLength = 0;
			this.txtSerialNumber.SelectionStart = 0;
			this.txtSerialNumber.Size = new System.Drawing.Size(153, 22);
			this.txtSerialNumber.TabIndex = 1;
			this.txtSerialNumber.UseSelectable = true;
			this.txtSerialNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSerialNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtColorSet
			// 
			// 
			// 
			// 
			this.txtColorSet.CustomButton.Image = null;
			this.txtColorSet.CustomButton.Location = new System.Drawing.Point(133, 2);
			this.txtColorSet.CustomButton.Name = "";
			this.txtColorSet.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtColorSet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtColorSet.CustomButton.TabIndex = 1;
			this.txtColorSet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtColorSet.CustomButton.UseSelectable = true;
			this.txtColorSet.CustomButton.Visible = false;
			this.txtColorSet.Lines = new string[0];
			this.txtColorSet.Location = new System.Drawing.Point(217, 195);
			this.txtColorSet.MaxLength = 32767;
			this.txtColorSet.Name = "txtColorSet";
			this.txtColorSet.PasswordChar = '\0';
			this.txtColorSet.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtColorSet.SelectedText = "";
			this.txtColorSet.SelectionLength = 0;
			this.txtColorSet.SelectionStart = 0;
			this.txtColorSet.Size = new System.Drawing.Size(153, 22);
			this.txtColorSet.TabIndex = 4;
			this.txtColorSet.UseSelectable = true;
			this.txtColorSet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtColorSet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtGekauftBei
			// 
			// 
			// 
			// 
			this.txtGekauftBei.CustomButton.Image = null;
			this.txtGekauftBei.CustomButton.Location = new System.Drawing.Point(136, 2);
			this.txtGekauftBei.CustomButton.Name = "";
			this.txtGekauftBei.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtGekauftBei.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtGekauftBei.CustomButton.TabIndex = 1;
			this.txtGekauftBei.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtGekauftBei.CustomButton.UseSelectable = true;
			this.txtGekauftBei.CustomButton.Visible = false;
			this.txtGekauftBei.Lines = new string[0];
			this.txtGekauftBei.Location = new System.Drawing.Point(23, 245);
			this.txtGekauftBei.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtGekauftBei.MaxLength = 32767;
			this.txtGekauftBei.Name = "txtGekauftBei";
			this.txtGekauftBei.PasswordChar = '\0';
			this.txtGekauftBei.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtGekauftBei.SelectedText = "";
			this.txtGekauftBei.SelectionLength = 0;
			this.txtGekauftBei.SelectionStart = 0;
			this.txtGekauftBei.Size = new System.Drawing.Size(156, 22);
			this.txtGekauftBei.TabIndex = 5;
			this.txtGekauftBei.UseSelectable = true;
			this.txtGekauftBei.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtGekauftBei.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtFirmware
			// 
			// 
			// 
			// 
			this.txtFirmware.CustomButton.Image = null;
			this.txtFirmware.CustomButton.Location = new System.Drawing.Point(81, 2);
			this.txtFirmware.CustomButton.Name = "";
			this.txtFirmware.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtFirmware.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFirmware.CustomButton.TabIndex = 1;
			this.txtFirmware.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFirmware.CustomButton.UseSelectable = true;
			this.txtFirmware.CustomButton.Visible = false;
			this.txtFirmware.Lines = new string[0];
			this.txtFirmware.Location = new System.Drawing.Point(406, 148);
			this.txtFirmware.MaxLength = 32767;
			this.txtFirmware.Name = "txtFirmware";
			this.txtFirmware.PasswordChar = '\0';
			this.txtFirmware.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFirmware.SelectedText = "";
			this.txtFirmware.SelectionLength = 0;
			this.txtFirmware.SelectionStart = 0;
			this.txtFirmware.Size = new System.Drawing.Size(101, 22);
			this.txtFirmware.TabIndex = 2;
			this.txtFirmware.UseSelectable = true;
			this.txtFirmware.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFirmware.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// cmbMachineModel
			// 
			this.cmbMachineModel.FormattingEnabled = true;
			this.cmbMachineModel.Location = new System.Drawing.Point(23, 149);
			this.cmbMachineModel.Name = "cmbMachineModel";
			this.cmbMachineModel.Size = new System.Drawing.Size(156, 21);
			this.cmbMachineModel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 19);
			this.label1.TabIndex = 58;
			this.label1.Text = "Maschinenmodell:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(217, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 19);
			this.label2.TabIndex = 59;
			this.label2.Text = "Seriennummer:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 19);
			this.label3.TabIndex = 60;
			this.label3.Text = "Tinte:";
			// 
			// cmbInkType
			// 
			this.cmbInkType.FormattingEnabled = true;
			this.cmbInkType.Location = new System.Drawing.Point(23, 195);
			this.cmbInkType.Name = "cmbInkType";
			this.cmbInkType.Size = new System.Drawing.Size(156, 21);
			this.cmbInkType.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(217, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 62;
			this.label4.Text = "Farbset:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 19);
			this.label5.TabIndex = 63;
			this.label5.Text = "Gekauft bei:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(409, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 19);
			this.label6.TabIndex = 64;
			this.label6.Text = "Kaufdatum:";
			// 
			// chkLeasingFlag
			// 
			this.chkLeasingFlag.AutoSize = true;
			this.chkLeasingFlag.Location = new System.Drawing.Point(23, 309);
			this.chkLeasingFlag.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.chkLeasingFlag.Name = "chkLeasingFlag";
			this.chkLeasingFlag.Size = new System.Drawing.Size(65, 17);
			this.chkLeasingFlag.TabIndex = 9;
			this.chkLeasingFlag.Text = "Leasing";
			this.chkLeasingFlag.UseVisualStyleBackColor = true;
			this.chkLeasingFlag.CheckedChanged += new System.EventHandler(this.chkLeasingFlag_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(406, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 19);
			this.label7.TabIndex = 66;
			this.label7.Text = "Firmware:";
			// 
			// dgvSoftware
			// 
			this.dgvSoftware.AllowUserToAddRows = false;
			this.dgvSoftware.AllowUserToDeleteRows = false;
			this.dgvSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
						this.colSoftwareName,
						this.colInstallationsdatum,
						this.colHauptbenutzer,
						this.colComputer,
						this.colLizenzSchluessel,
						this.colAnmerkungen});
			this.dgvSoftware.Location = new System.Drawing.Point(23, 608);
			this.dgvSoftware.Name = "dgvSoftware";
			this.dgvSoftware.RowHeadersWidth = 21;
			this.dgvSoftware.Size = new System.Drawing.Size(961, 122);
			this.dgvSoftware.TabIndex = 69;
			this.dgvSoftware.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_RowEnter);
			// 
			// colSoftwareName
			// 
			this.colSoftwareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSoftwareName.DataPropertyName = "Softwarename";
			this.colSoftwareName.HeaderText = "Software";
			this.colSoftwareName.Name = "colSoftwareName";
			this.colSoftwareName.Width = 78;
			// 
			// colInstallationsdatum
			// 
			this.colInstallationsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colInstallationsdatum.DataPropertyName = "Installationsdatum";
			this.colInstallationsdatum.HeaderText = "Installation";
			this.colInstallationsdatum.Name = "colInstallationsdatum";
			this.colInstallationsdatum.Width = 90;
			// 
			// colHauptbenutzer
			// 
			this.colHauptbenutzer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHauptbenutzer.DataPropertyName = "Hauptbenutzer";
			this.colHauptbenutzer.HeaderText = "Benutzer";
			this.colHauptbenutzer.Name = "colHauptbenutzer";
			this.colHauptbenutzer.Width = 78;
			// 
			// colComputer
			// 
			this.colComputer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colComputer.DataPropertyName = "Computer";
			this.colComputer.HeaderText = "Computer";
			this.colComputer.Name = "colComputer";
			this.colComputer.Width = 83;
			// 
			// colLizenzSchluessel
			// 
			this.colLizenzSchluessel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colLizenzSchluessel.DataPropertyName = "Lizenzschluessel";
			this.colLizenzSchluessel.HeaderText = "Lizenz";
			this.colLizenzSchluessel.Name = "colLizenzSchluessel";
			this.colLizenzSchluessel.Width = 63;
			// 
			// colAnmerkungen
			// 
			this.colAnmerkungen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAnmerkungen.DataPropertyName = "Anmerkungen";
			this.colAnmerkungen.HeaderText = "Bemerkungen";
			this.colAnmerkungen.Name = "colAnmerkungen";
			this.colAnmerkungen.Width = 104;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 586);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 19);
			this.label9.TabIndex = 70;
			this.label9.Text = "Software:";
			// 
			// chkMietkaufFlag
			// 
			this.chkMietkaufFlag.AutoSize = true;
			this.chkMietkaufFlag.Location = new System.Drawing.Point(122, 309);
			this.chkMietkaufFlag.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.chkMietkaufFlag.Name = "chkMietkaufFlag";
			this.chkMietkaufFlag.Size = new System.Drawing.Size(72, 17);
			this.chkMietkaufFlag.TabIndex = 8;
			this.chkMietkaufFlag.Text = "Mietkauf";
			this.chkMietkaufFlag.UseVisualStyleBackColor = true;
			this.chkMietkaufFlag.CheckedChanged += new System.EventHandler(this.chkMietkaufFlag_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(269, 337);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(157, 19);
			this.label10.TabIndex = 72;
			this.label10.Text = "Finanzierungsgesellschaft:";
			// 
			// txtFinanzierungsgesellschaft
			// 
			this.txtFinanzierungsgesellschaft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtFinanzierungsgesellschaft.CustomButton.Image = null;
			this.txtFinanzierungsgesellschaft.CustomButton.Location = new System.Drawing.Point(532, 2);
			this.txtFinanzierungsgesellschaft.CustomButton.Name = "";
			this.txtFinanzierungsgesellschaft.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtFinanzierungsgesellschaft.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFinanzierungsgesellschaft.CustomButton.TabIndex = 1;
			this.txtFinanzierungsgesellschaft.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFinanzierungsgesellschaft.CustomButton.UseSelectable = true;
			this.txtFinanzierungsgesellschaft.CustomButton.Visible = false;
			this.txtFinanzierungsgesellschaft.Lines = new string[0];
			this.txtFinanzierungsgesellschaft.Location = new System.Drawing.Point(432, 337);
			this.txtFinanzierungsgesellschaft.MaxLength = 32767;
			this.txtFinanzierungsgesellschaft.Name = "txtFinanzierungsgesellschaft";
			this.txtFinanzierungsgesellschaft.PasswordChar = '\0';
			this.txtFinanzierungsgesellschaft.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFinanzierungsgesellschaft.SelectedText = "";
			this.txtFinanzierungsgesellschaft.SelectionLength = 0;
			this.txtFinanzierungsgesellschaft.SelectionStart = 0;
			this.txtFinanzierungsgesellschaft.Size = new System.Drawing.Size(552, 22);
			this.txtFinanzierungsgesellschaft.TabIndex = 12;
			this.txtFinanzierungsgesellschaft.UseSelectable = true;
			this.txtFinanzierungsgesellschaft.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFinanzierungsgesellschaft.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// chkErstverwertungsFlag
			// 
			this.chkErstverwertungsFlag.AutoSize = true;
			this.chkErstverwertungsFlag.Location = new System.Drawing.Point(217, 309);
			this.chkErstverwertungsFlag.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.chkErstverwertungsFlag.Name = "chkErstverwertungsFlag";
			this.chkErstverwertungsFlag.Size = new System.Drawing.Size(171, 17);
			this.chkErstverwertungsFlag.TabIndex = 11;
			this.chkErstverwertungsFlag.Text = "Erstverwertung liegt bei uns";
			this.chkErstverwertungsFlag.UseVisualStyleBackColor = true;
			this.chkErstverwertungsFlag.CheckedChanged += new System.EventHandler(this.chkErstverwertungsFlag_CheckedChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(217, 223);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(106, 19);
			this.label11.TabIndex = 75;
			this.label11.Text = "Auftrag in SAGE:";
			// 
			// txtAuftragInSage
			// 
			// 
			// 
			// 
			this.txtAuftragInSage.CustomButton.Image = null;
			this.txtAuftragInSage.CustomButton.Location = new System.Drawing.Point(133, 2);
			this.txtAuftragInSage.CustomButton.Name = "";
			this.txtAuftragInSage.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtAuftragInSage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtAuftragInSage.CustomButton.TabIndex = 1;
			this.txtAuftragInSage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtAuftragInSage.CustomButton.UseSelectable = true;
			this.txtAuftragInSage.CustomButton.Visible = false;
			this.txtAuftragInSage.Lines = new string[0];
			this.txtAuftragInSage.Location = new System.Drawing.Point(217, 245);
			this.txtAuftragInSage.MaxLength = 32767;
			this.txtAuftragInSage.Name = "txtAuftragInSage";
			this.txtAuftragInSage.PasswordChar = '\0';
			this.txtAuftragInSage.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtAuftragInSage.SelectedText = "";
			this.txtAuftragInSage.SelectionLength = 0;
			this.txtAuftragInSage.SelectionStart = 0;
			this.txtAuftragInSage.Size = new System.Drawing.Size(153, 22);
			this.txtAuftragInSage.TabIndex = 7;
			this.txtAuftragInSage.UseSelectable = true;
			this.txtAuftragInSage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtAuftragInSage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(23, 337);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(119, 19);
			this.label12.TabIndex = 77;
			this.label12.Text = "Ende Finanzierung:";
			// 
			// dgvNotizen
			// 
			this.dgvNotizen.AllowUserToAddRows = false;
			this.dgvNotizen.AllowUserToDeleteRows = false;
			this.dgvNotizen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvNotizen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotizen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
						this.colErfassungsdatum,
						this.colThema,
						this.colNotiztext});
			this.dgvNotizen.Location = new System.Drawing.Point(23, 395);
			this.dgvNotizen.Name = "dgvNotizen";
			this.dgvNotizen.ReadOnly = true;
			this.dgvNotizen.RowHeadersWidth = 21;
			this.dgvNotizen.Size = new System.Drawing.Size(961, 133);
			this.dgvNotizen.TabIndex = 78;
			this.dgvNotizen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotizen_RowEnter);
			this.dgvNotizen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotizen_MouseDoubleClick);
			// 
			// colErfassungsdatum
			// 
			this.colErfassungsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colErfassungsdatum.DataPropertyName = "Erfassungsdatum";
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			this.colErfassungsdatum.DefaultCellStyle = dataGridViewCellStyle1;
			this.colErfassungsdatum.HeaderText = "Datum";
			this.colErfassungsdatum.MinimumWidth = 75;
			this.colErfassungsdatum.Name = "colErfassungsdatum";
			this.colErfassungsdatum.ReadOnly = true;
			this.colErfassungsdatum.Width = 75;
			// 
			// colThema
			// 
			this.colThema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colThema.DataPropertyName = "Thema";
			this.colThema.HeaderText = "Thema";
			this.colThema.MinimumWidth = 200;
			this.colThema.Name = "colThema";
			this.colThema.ReadOnly = true;
			this.colThema.Width = 200;
			// 
			// colNotiztext
			// 
			this.colNotiztext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colNotiztext.DataPropertyName = "Notiztext";
			this.colNotiztext.HeaderText = "Notiz";
			this.colNotiztext.MinimumWidth = 400;
			this.colNotiztext.Name = "colNotiztext";
			this.colNotiztext.ReadOnly = true;
			this.colNotiztext.Width = 400;
			// 
			// lblNotizen
			// 
			this.lblNotizen.AutoSize = true;
			this.lblNotizen.Location = new System.Drawing.Point(23, 373);
			this.lblNotizen.Name = "lblNotizen";
			this.lblNotizen.Size = new System.Drawing.Size(54, 19);
			this.lblNotizen.TabIndex = 79;
			this.lblNotizen.Text = "Notizen";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(577, 223);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 19);
			this.label8.TabIndex = 80;
			this.label8.Text = "Wartung";
			// 
			// txtWartungsintervall
			// 
			// 
			// 
			// 
			this.txtWartungsintervall.CustomButton.Image = null;
			this.txtWartungsintervall.CustomButton.Location = new System.Drawing.Point(30, 2);
			this.txtWartungsintervall.CustomButton.Name = "";
			this.txtWartungsintervall.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtWartungsintervall.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtWartungsintervall.CustomButton.TabIndex = 1;
			this.txtWartungsintervall.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtWartungsintervall.CustomButton.UseSelectable = true;
			this.txtWartungsintervall.CustomButton.Visible = false;
			this.txtWartungsintervall.Lines = new string[0];
			this.txtWartungsintervall.Location = new System.Drawing.Point(577, 245);
			this.txtWartungsintervall.MaxLength = 32767;
			this.txtWartungsintervall.Name = "txtWartungsintervall";
			this.txtWartungsintervall.PasswordChar = '\0';
			this.txtWartungsintervall.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtWartungsintervall.SelectedText = "";
			this.txtWartungsintervall.SelectionLength = 0;
			this.txtWartungsintervall.SelectionStart = 0;
			this.txtWartungsintervall.Size = new System.Drawing.Size(50, 22);
			this.txtWartungsintervall.TabIndex = 81;
			this.txtWartungsintervall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtWartungsintervall.UseSelectable = true;
			this.txtWartungsintervall.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtWartungsintervall.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(542, 245);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(29, 19);
			this.label13.TabIndex = 82;
			this.label13.Text = "alle";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(633, 245);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(54, 19);
			this.label14.TabIndex = 83;
			this.label14.Text = "Monate";
			// 
			// ndtpFinanzierungsende
			// 
			this.ndtpFinanzierungsende.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ndtpFinanzierungsende.Location = new System.Drawing.Point(148, 337);
			this.ndtpFinanzierungsende.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.ndtpFinanzierungsende.Name = "ndtpFinanzierungsende";
			this.ndtpFinanzierungsende.NullValue = " ";
			this.ndtpFinanzierungsende.Size = new System.Drawing.Size(98, 22);
			this.ndtpFinanzierungsende.TabIndex = 10;
			this.ndtpFinanzierungsende.Value = new System.DateTime(2015, 7, 2, 11, 12, 23, 762);
			this.ndtpFinanzierungsende.Validated += new System.EventHandler(this.ndtpFinanzierungsende_Validated);
			// 
			// ndtpKaufdatum
			// 
			this.ndtpKaufdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ndtpKaufdatum.Location = new System.Drawing.Point(406, 245);
			this.ndtpKaufdatum.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.ndtpKaufdatum.Name = "ndtpKaufdatum";
			this.ndtpKaufdatum.NullValue = " ";
			this.ndtpKaufdatum.Size = new System.Drawing.Size(98, 22);
			this.ndtpKaufdatum.TabIndex = 6;
			this.ndtpKaufdatum.Value = new System.DateTime(2015, 7, 2, 11, 12, 23, 762);
			this.ndtpKaufdatum.Validated += new System.EventHandler(this.ndtpKaufdatum_Validated);
			// 
			// mbtnClose
			// 
			this.mbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mbtnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnClose.Location = new System.Drawing.Point(894, 756);
			this.mbtnClose.Name = "mbtnClose";
			this.mbtnClose.Size = new System.Drawing.Size(90, 30);
			this.mbtnClose.TabIndex = 93;
			this.mbtnClose.Text = "Schließen";
			this.mbtnClose.UseSelectable = true;
			this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
			// 
			// btnNeueMaschine
			// 
			this.btnNeueMaschine.BackgroundImage = global::Products.Common.Properties.Resources.Maschine_metroblue;
			this.btnNeueMaschine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNeueMaschine.FlatAppearance.BorderSize = 0;
			this.btnNeueMaschine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeueMaschine.Location = new System.Drawing.Point(406, 736);
			this.btnNeueMaschine.Name = "btnNeueMaschine";
			this.btnNeueMaschine.Size = new System.Drawing.Size(50, 50);
			this.btnNeueMaschine.TabIndex = 94;
			this.btnNeueMaschine.UseVisualStyleBackColor = true;
			this.btnNeueMaschine.Click += new System.EventHandler(this.btnNeueMaschine_Click);
			// 
			// btnNeueNotiz
			// 
			this.btnNeueNotiz.BackgroundImage = global::Products.Common.Properties.Resources.Add_metrogblue;
			this.btnNeueNotiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNeueNotiz.FlatAppearance.BorderSize = 0;
			this.btnNeueNotiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeueNotiz.Location = new System.Drawing.Point(23, 533);
			this.btnNeueNotiz.Name = "btnNeueNotiz";
			this.btnNeueNotiz.Size = new System.Drawing.Size(50, 50);
			this.btnNeueNotiz.TabIndex = 95;
			this.btnNeueNotiz.UseVisualStyleBackColor = true;
			this.btnNeueNotiz.Click += new System.EventHandler(this.btnNeueNotiz_Click);
			// 
			// btnNeueSoftware
			// 
			this.btnNeueSoftware.BackgroundImage = global::Products.Common.Properties.Resources.Add_metrogblue;
			this.btnNeueSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNeueSoftware.FlatAppearance.BorderSize = 0;
			this.btnNeueSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeueSoftware.Location = new System.Drawing.Point(23, 736);
			this.btnNeueSoftware.Name = "btnNeueSoftware";
			this.btnNeueSoftware.Size = new System.Drawing.Size(50, 50);
			this.btnNeueSoftware.TabIndex = 96;
			this.btnNeueSoftware.UseVisualStyleBackColor = true;
			// 
			// CustomerMachineView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1007, 809);
			this.Controls.Add(this.btnNeueSoftware);
			this.Controls.Add(this.btnNeueNotiz);
			this.Controls.Add(this.btnNeueMaschine);
			this.Controls.Add(this.mbtnClose);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtWartungsintervall);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblNotizen);
			this.Controls.Add(this.dgvNotizen);
			this.Controls.Add(this.ndtpFinanzierungsende);
			this.Controls.Add(this.ndtpKaufdatum);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtAuftragInSage);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.chkErstverwertungsFlag);
			this.Controls.Add(this.txtFinanzierungsgesellschaft);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.chkMietkaufFlag);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dgvSoftware);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chkLeasingFlag);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbInkType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMachineModel);
			this.Controls.Add(this.txtFirmware);
			this.Controls.Add(this.txtGekauftBei);
			this.Controls.Add(this.txtColorSet);
			this.Controls.Add(this.txtSerialNumber);
			this.Controls.Add(this.lblKunde);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomerMachineView";
			this.Text = "Kundenmaschine";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMachineView_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UI.Controls.NullableDateTimePicker ndtpKaufdatum;
		private UI.Controls.NullableDateTimePicker ndtpFinanzierungsende;
		private MetroFramework.Controls.MetroGrid dgvNotizen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colErfassungsdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colThema;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNotiztext;
		private MetroFramework.Controls.MetroLabel lblNotizen;
		private MetroFramework.Controls.MetroLabel label8;
		private MetroFramework.Controls.MetroTextBox txtWartungsintervall;
		private MetroFramework.Controls.MetroLabel label13;
		private MetroFramework.Controls.MetroLabel label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwareName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInstallationsdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHauptbenutzer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colComputer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLizenzSchluessel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAnmerkungen;
		private MetroFramework.Controls.MetroButton mbtnClose;
		private System.Windows.Forms.Button btnNeueMaschine;
		private System.Windows.Forms.Button btnNeueNotiz;
		private System.Windows.Forms.Button btnNeueSoftware;
	}
}