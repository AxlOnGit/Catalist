using Products.UI.Controls;

namespace Products.Common.Panel
{
	partial class pnlKundenMaschine
	{
#pragma warning disable CS0618 // Typ oder Element ist veraltet
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlKundenMaschine));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label4 = new MetroFramework.Controls.MetroLabel();
			this.cmbInkType = new MetroFramework.Controls.MetroComboBox();
			this.label3 = new MetroFramework.Controls.MetroLabel();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.cmbMachineModel = new MetroFramework.Controls.MetroComboBox();
			this.txtColorSet = new MetroFramework.Controls.MetroTextBox();
			this.mtxtSerialNumber = new MetroFramework.Controls.MetroTextBox();
			this.mlblTitel = new MetroFramework.Controls.MetroLabel();
			this.mctxTree = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.mctxGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.xcmdOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mtabProperties = new MetroFramework.Controls.MetroTabControl();
			this.tabFiles = new System.Windows.Forms.TabPage();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.trvFolders = new System.Windows.Forms.TreeView();
			this.dgvFiles = new MetroFramework.Controls.MetroGrid();
			this.colFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabNotes = new MetroFramework.Controls.MetroTabPage();
			this.mtxtNoteText = new MetroFramework.Controls.MetroTextBox();
			this.mbtnDeleteNote = new System.Windows.Forms.Button();
			this.mbtnOpenNote = new System.Windows.Forms.Button();
			this.dgvNotizen = new MetroFramework.Controls.MetroGrid();
			this.colErfassungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colThema = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNotiztext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtnCreateNote = new System.Windows.Forms.Button();
			this.lblNotizen = new MetroFramework.Controls.MetroLabel();
			this.tabSoftware = new System.Windows.Forms.TabPage();
			this.mbtnDeleteSoftware = new System.Windows.Forms.Button();
			this.mbtnOpenSoftware = new System.Windows.Forms.Button();
			this.label9 = new MetroFramework.Controls.MetroLabel();
			this.mbtnCreateSoftware = new System.Windows.Forms.Button();
			this.dgvSoftware = new MetroFramework.Controls.MetroGrid();
			this.colSoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLizenzSchluessel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabSales = new System.Windows.Forms.TabPage();
			this.mcmbTechniker = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.mtxtSageInfos = new MetroFramework.Controls.MetroTextBox();
			this.mbtnOpenInSage = new MetroFramework.Controls.MetroButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.ndtpInstallation = new Products.UI.Controls.NullableDateTimePicker();
			this.ndtpLieferschein = new Products.UI.Controls.NullableDateTimePicker();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.ndtpRechnung = new Products.UI.Controls.NullableDateTimePicker();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.ndtpAuftrag = new Products.UI.Controls.NullableDateTimePicker();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mtxtLieferschein = new MetroFramework.Controls.MetroTextBox();
			this.mtxtRechnung = new MetroFramework.Controls.MetroTextBox();
			this.mtxtAuftrag = new MetroFramework.Controls.MetroTextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mtogglLeasing = new MetroFramework.Controls.MetroToggle();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.mtogglMietkauf = new MetroFramework.Controls.MetroToggle();
			this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
			this.mtogglErstverwertung = new MetroFramework.Controls.MetroToggle();
			this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
			this.mtxtFinanzierungDurch = new MetroFramework.Controls.MetroTextBox();
			this.ndtpVertragsende = new Products.UI.Controls.NullableDateTimePicker();
			this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
			this.mctxTree.SuspendLayout();
			this.mctxGrid.SuspendLayout();
			this.mtabProperties.SuspendLayout();
			this.tabFiles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
			this.tabNotes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).BeginInit();
			this.tabSoftware.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
			this.tabSales.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(818, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 122;
			this.label4.Text = "Farbset:";
			// 
			// cmbInkType
			// 
			this.cmbInkType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.cmbInkType.FormattingEnabled = true;
			this.cmbInkType.ItemHeight = 23;
			this.cmbInkType.Location = new System.Drawing.Point(644, 100);
			this.cmbInkType.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.cmbInkType.Name = "cmbInkType";
			this.cmbInkType.Size = new System.Drawing.Size(151, 29);
			this.cmbInkType.Style = MetroFramework.MetroColorStyle.Orange;
			this.cmbInkType.TabIndex = 2;
			this.cmbInkType.UseSelectable = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(598, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 19);
			this.label3.TabIndex = 121;
			this.label3.Text = "Tinte:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(317, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 19);
			this.label2.TabIndex = 120;
			this.label2.Text = "Seriennummer:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 19);
			this.label1.TabIndex = 119;
			this.label1.Text = "Maschinenmodell:";
			// 
			// cmbMachineModel
			// 
			this.cmbMachineModel.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.cmbMachineModel.FormattingEnabled = true;
			this.cmbMachineModel.ItemHeight = 23;
			this.cmbMachineModel.Location = new System.Drawing.Point(143, 100);
			this.cmbMachineModel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.cmbMachineModel.Name = "cmbMachineModel";
			this.cmbMachineModel.Size = new System.Drawing.Size(151, 29);
			this.cmbMachineModel.Style = MetroFramework.MetroColorStyle.Orange;
			this.cmbMachineModel.TabIndex = 0;
			this.cmbMachineModel.UseSelectable = true;
			// 
			// txtColorSet
			// 
			// 
			// 
			// 
			this.txtColorSet.CustomButton.Image = null;
			this.txtColorSet.CustomButton.Location = new System.Drawing.Point(125, 1);
			this.txtColorSet.CustomButton.Name = "";
			this.txtColorSet.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtColorSet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtColorSet.CustomButton.TabIndex = 1;
			this.txtColorSet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtColorSet.CustomButton.UseSelectable = true;
			this.txtColorSet.CustomButton.Visible = false;
			this.txtColorSet.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtColorSet.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtColorSet.Lines = new string[0];
			this.txtColorSet.Location = new System.Drawing.Point(878, 100);
			this.txtColorSet.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtColorSet.MaxLength = 32767;
			this.txtColorSet.Multiline = true;
			this.txtColorSet.Name = "txtColorSet";
			this.txtColorSet.PasswordChar = '\0';
			this.txtColorSet.PromptText = "z. B. CMYK";
			this.txtColorSet.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtColorSet.SelectedText = "";
			this.txtColorSet.SelectionLength = 0;
			this.txtColorSet.SelectionStart = 0;
			this.txtColorSet.ShortcutsEnabled = true;
			this.txtColorSet.Size = new System.Drawing.Size(153, 29);
			this.txtColorSet.Style = MetroFramework.MetroColorStyle.Orange;
			this.txtColorSet.TabIndex = 3;
			this.txtColorSet.UseSelectable = true;
			this.txtColorSet.WaterMark = "z. B. CMYK";
			this.txtColorSet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtColorSet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
			// 
			// mtxtSerialNumber
			// 
			// 
			// 
			// 
			this.mtxtSerialNumber.CustomButton.Image = null;
			this.mtxtSerialNumber.CustomButton.Location = new System.Drawing.Point(125, 1);
			this.mtxtSerialNumber.CustomButton.Name = "";
			this.mtxtSerialNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.mtxtSerialNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSerialNumber.CustomButton.TabIndex = 1;
			this.mtxtSerialNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSerialNumber.CustomButton.UseSelectable = true;
			this.mtxtSerialNumber.CustomButton.Visible = false;
			this.mtxtSerialNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtSerialNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtSerialNumber.Lines = new string[0];
			this.mtxtSerialNumber.Location = new System.Drawing.Point(422, 100);
			this.mtxtSerialNumber.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.mtxtSerialNumber.MaxLength = 32767;
			this.mtxtSerialNumber.Multiline = true;
			this.mtxtSerialNumber.Name = "mtxtSerialNumber";
			this.mtxtSerialNumber.PasswordChar = '\0';
			this.mtxtSerialNumber.PromptText = "z. B. 3.30";
			this.mtxtSerialNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSerialNumber.SelectedText = "";
			this.mtxtSerialNumber.SelectionLength = 0;
			this.mtxtSerialNumber.SelectionStart = 0;
			this.mtxtSerialNumber.ShortcutsEnabled = true;
			this.mtxtSerialNumber.Size = new System.Drawing.Size(153, 29);
			this.mtxtSerialNumber.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtSerialNumber.TabIndex = 1;
			this.mtxtSerialNumber.UseSelectable = true;
			this.mtxtSerialNumber.WaterMark = "z. B. 3.30";
			this.mtxtSerialNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSerialNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
			// 
			// mlblTitel
			// 
			this.mlblTitel.AutoSize = true;
			this.mlblTitel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.mlblTitel.Location = new System.Drawing.Point(23, 20);
			this.mlblTitel.Name = "mlblTitel";
			this.mlblTitel.Size = new System.Drawing.Size(64, 25);
			this.mlblTitel.TabIndex = 123;
			this.mlblTitel.Text = "Modell";
			// 
			// mctxTree
			// 
			this.mctxTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdOpenInExplorer});
			this.mctxTree.Name = "mctxTree";
			this.mctxTree.Size = new System.Drawing.Size(117, 26);
			// 
			// xcmdOpenInExplorer
			// 
			this.xcmdOpenInExplorer.Image = global::Products.Common.Properties.Resources.explorer_exe_original;
			this.xcmdOpenInExplorer.Name = "xcmdOpenInExplorer";
			this.xcmdOpenInExplorer.Size = new System.Drawing.Size(116, 22);
			this.xcmdOpenInExplorer.Text = "Explorer";
			this.xcmdOpenInExplorer.Click += new System.EventHandler(this.xcmdOpenInExplorer_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folderclosed_24_metroyellow.png");
			this.imageList1.Images.SetKeyName(1, "openfolder_24_metrored.png");
			// 
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcmdOpenFile});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new System.Drawing.Size(112, 26);
			// 
			// xcmdOpenFile
			// 
			this.xcmdOpenFile.Image = global::Products.Common.Properties.Resources.open_16_metroorange;
			this.xcmdOpenFile.Name = "xcmdOpenFile";
			this.xcmdOpenFile.Size = new System.Drawing.Size(111, 22);
			this.xcmdOpenFile.Text = "Öffnen";
			this.xcmdOpenFile.Click += new System.EventHandler(this.xcmdOpenFile_Click);
			// 
			// mtabProperties
			// 
			this.mtabProperties.Controls.Add(this.tabFiles);
			this.mtabProperties.Controls.Add(this.tabNotes);
			this.mtabProperties.Controls.Add(this.tabSoftware);
			this.mtabProperties.Controls.Add(this.tabSales);
			this.mtabProperties.HotTrack = true;
			this.mtabProperties.ItemSize = new System.Drawing.Size(100, 34);
			this.mtabProperties.Location = new System.Drawing.Point(23, 162);
			this.mtabProperties.Name = "mtabProperties";
			this.mtabProperties.SelectedIndex = 3;
			this.mtabProperties.ShowToolTips = true;
			this.mtabProperties.Size = new System.Drawing.Size(1242, 591);
			this.mtabProperties.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtabProperties.TabIndex = 4;
			this.mtabProperties.UseSelectable = true;
			this.mtabProperties.SelectedIndexChanged += new System.EventHandler(this.mtabProperties_SelectedIndexChanged);
			// 
			// tabFiles
			// 
			this.tabFiles.Controls.Add(this.metroLabel1);
			this.tabFiles.Controls.Add(this.splitContainer1);
			this.tabFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabFiles.Location = new System.Drawing.Point(4, 38);
			this.tabFiles.Name = "tabFiles";
			this.tabFiles.Padding = new System.Windows.Forms.Padding(20);
			this.tabFiles.Size = new System.Drawing.Size(1234, 549);
			this.tabFiles.TabIndex = 0;
			this.tabFiles.Text = "Dateien";
			this.tabFiles.UseVisualStyleBackColor = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(579, 20);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(70, 25);
			this.metroLabel1.TabIndex = 135;
			this.metroLabel1.Text = "Dateien";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.Location = new System.Drawing.Point(20, 51);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 40);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Panel1.Controls.Add(this.trvFolders);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3, 22, 3, 3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvFiles);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.splitContainer1.Size = new System.Drawing.Size(1194, 478);
			this.splitContainer1.SplitterDistance = 332;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 5;
			// 
			// trvFolders
			// 
			this.trvFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvFolders.ContextMenuStrip = this.mctxTree;
			this.trvFolders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvFolders.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.trvFolders.ImageIndex = 0;
			this.trvFolders.ImageList = this.imageList1;
			this.trvFolders.ItemHeight = 30;
			this.trvFolders.LineColor = System.Drawing.Color.Gray;
			this.trvFolders.Location = new System.Drawing.Point(3, 22);
			this.trvFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trvFolders.Name = "trvFolders";
			this.trvFolders.SelectedImageIndex = 1;
			this.trvFolders.ShowLines = false;
			this.trvFolders.ShowPlusMinus = false;
			this.trvFolders.ShowRootLines = false;
			this.trvFolders.Size = new System.Drawing.Size(326, 453);
			this.trvFolders.TabIndex = 5;
			this.trvFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFolders_AfterSelect);
			// 
			// dgvFiles
			// 
			this.dgvFiles.AllowUserToAddRows = false;
			this.dgvFiles.AllowUserToDeleteRows = false;
			this.dgvFiles.AllowUserToResizeRows = false;
			this.dgvFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilename,
            this.colSize,
            this.colType,
            this.colChangeDate});
			this.dgvFiles.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFiles.DefaultCellStyle = dataGridViewCellStyle14;
			this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFiles.EnableHeadersVisualStyles = false;
			this.dgvFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvFiles.HighLightPercentage = 1.2F;
			this.dgvFiles.Location = new System.Drawing.Point(0, 3);
			this.dgvFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvFiles.Name = "dgvFiles";
			this.dgvFiles.ReadOnly = true;
			this.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvFiles.RowHeadersVisible = false;
			this.dgvFiles.RowHeadersWidth = 21;
			this.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFiles.Size = new System.Drawing.Size(857, 475);
			this.dgvFiles.Style = MetroFramework.MetroColorStyle.Red;
			this.dgvFiles.TabIndex = 6;
			this.dgvFiles.UseCustomBackColor = true;
			this.dgvFiles.UseCustomForeColor = true;
			this.dgvFiles.UseStyleColors = true;
			this.dgvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_RowEnter);
			this.dgvFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseDoubleClick);
			// 
			// colFilename
			// 
			this.colFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFilename.DataPropertyName = "Name";
			this.colFilename.FillWeight = 55F;
			this.colFilename.HeaderText = "Datei";
			this.colFilename.Name = "colFilename";
			this.colFilename.ReadOnly = true;
			// 
			// colSize
			// 
			this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSize.DataPropertyName = "Length";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle13.Format = "N0";
			dataGridViewCellStyle13.NullValue = null;
			this.colSize.DefaultCellStyle = dataGridViewCellStyle13;
			this.colSize.FillWeight = 15F;
			this.colSize.HeaderText = "Größe";
			this.colSize.Name = "colSize";
			this.colSize.ReadOnly = true;
			// 
			// colType
			// 
			this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colType.DataPropertyName = "Extension";
			this.colType.FillWeight = 10F;
			this.colType.HeaderText = "Typ";
			this.colType.Name = "colType";
			this.colType.ReadOnly = true;
			// 
			// colChangeDate
			// 
			this.colChangeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colChangeDate.DataPropertyName = "LastWriteTime";
			this.colChangeDate.FillWeight = 20F;
			this.colChangeDate.HeaderText = "Änderungsdatum";
			this.colChangeDate.Name = "colChangeDate";
			this.colChangeDate.ReadOnly = true;
			// 
			// tabNotes
			// 
			this.tabNotes.Controls.Add(this.mtxtNoteText);
			this.tabNotes.Controls.Add(this.mbtnDeleteNote);
			this.tabNotes.Controls.Add(this.mbtnOpenNote);
			this.tabNotes.Controls.Add(this.dgvNotizen);
			this.tabNotes.Controls.Add(this.mbtnCreateNote);
			this.tabNotes.Controls.Add(this.lblNotizen);
			this.tabNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabNotes.HorizontalScrollbarBarColor = true;
			this.tabNotes.HorizontalScrollbarHighlightOnWheel = false;
			this.tabNotes.HorizontalScrollbarSize = 10;
			this.tabNotes.Location = new System.Drawing.Point(4, 38);
			this.tabNotes.Name = "tabNotes";
			this.tabNotes.Padding = new System.Windows.Forms.Padding(20);
			this.tabNotes.Size = new System.Drawing.Size(1234, 549);
			this.tabNotes.TabIndex = 1;
			this.tabNotes.Text = "Notizen";
			this.tabNotes.UseVisualStyleBackColor = true;
			this.tabNotes.VerticalScrollbarBarColor = true;
			this.tabNotes.VerticalScrollbarHighlightOnWheel = false;
			this.tabNotes.VerticalScrollbarSize = 10;
			// 
			// mtxtNoteText
			// 
			this.mtxtNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtNoteText.CustomButton.Image = null;
			this.mtxtNoteText.CustomButton.Location = new System.Drawing.Point(1048, 2);
			this.mtxtNoteText.CustomButton.Name = "";
			this.mtxtNoteText.CustomButton.Size = new System.Drawing.Size(143, 143);
			this.mtxtNoteText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtNoteText.CustomButton.TabIndex = 1;
			this.mtxtNoteText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtNoteText.CustomButton.UseSelectable = true;
			this.mtxtNoteText.CustomButton.Visible = false;
			this.mtxtNoteText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.mtxtNoteText.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtNoteText.Lines = new string[0];
			this.mtxtNoteText.Location = new System.Drawing.Point(20, 378);
			this.mtxtNoteText.MaxLength = 32767;
			this.mtxtNoteText.Multiline = true;
			this.mtxtNoteText.Name = "mtxtNoteText";
			this.mtxtNoteText.PasswordChar = '\0';
			this.mtxtNoteText.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtNoteText.SelectedText = "";
			this.mtxtNoteText.SelectionLength = 0;
			this.mtxtNoteText.SelectionStart = 0;
			this.mtxtNoteText.ShortcutsEnabled = true;
			this.mtxtNoteText.Size = new System.Drawing.Size(1194, 148);
			this.mtxtNoteText.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtNoteText.TabIndex = 135;
			this.mtxtNoteText.UseSelectable = true;
			this.mtxtNoteText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtNoteText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtxtNoteText.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtNoteText_Validating);
			// 
			// mbtnDeleteNote
			// 
			this.mbtnDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnDeleteNote.BackColor = System.Drawing.Color.Transparent;
			this.mbtnDeleteNote.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metroorange;
			this.mbtnDeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnDeleteNote.FlatAppearance.BorderSize = 0;
			this.mbtnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnDeleteNote.Location = new System.Drawing.Point(1178, 11);
			this.mbtnDeleteNote.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.mbtnDeleteNote.Name = "mbtnDeleteNote";
			this.mbtnDeleteNote.Size = new System.Drawing.Size(36, 36);
			this.mbtnDeleteNote.TabIndex = 133;
			this.mbtnDeleteNote.UseVisualStyleBackColor = false;
			this.mbtnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
			// 
			// mbtnOpenNote
			// 
			this.mbtnOpenNote.BackColor = System.Drawing.Color.Transparent;
			this.mbtnOpenNote.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metroorange;
			this.mbtnOpenNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnOpenNote.FlatAppearance.BorderSize = 0;
			this.mbtnOpenNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnOpenNote.Location = new System.Drawing.Point(24, 10);
			this.mbtnOpenNote.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.mbtnOpenNote.Name = "mbtnOpenNote";
			this.mbtnOpenNote.Size = new System.Drawing.Size(36, 36);
			this.mbtnOpenNote.TabIndex = 130;
			this.mbtnOpenNote.UseVisualStyleBackColor = false;
			this.mbtnOpenNote.Click += new System.EventHandler(this.mbtnOpenNote_Click);
			// 
			// dgvNotizen
			// 
			this.dgvNotizen.AllowUserToAddRows = false;
			this.dgvNotizen.AllowUserToDeleteRows = false;
			this.dgvNotizen.AllowUserToResizeRows = false;
			this.dgvNotizen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvNotizen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvNotizen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvNotizen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvNotizen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotizen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvNotizen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotizen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colErfassungsdatum,
            this.colThema,
            this.colNotiztext});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvNotizen.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvNotizen.EnableHeadersVisualStyles = false;
			this.dgvNotizen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvNotizen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvNotizen.Location = new System.Drawing.Point(20, 53);
			this.dgvNotizen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.dgvNotizen.Name = "dgvNotizen";
			this.dgvNotizen.ReadOnly = true;
			this.dgvNotizen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNotizen.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvNotizen.RowHeadersVisible = false;
			this.dgvNotizen.RowHeadersWidth = 21;
			this.dgvNotizen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvNotizen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNotizen.Size = new System.Drawing.Size(1194, 302);
			this.dgvNotizen.Style = MetroFramework.MetroColorStyle.Orange;
			this.dgvNotizen.TabIndex = 131;
			this.dgvNotizen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotizen_RowEnter);
			this.dgvNotizen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotizen_MouseDoubleClick);
			// 
			// colErfassungsdatum
			// 
			this.colErfassungsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colErfassungsdatum.DataPropertyName = "CreatedAt";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colErfassungsdatum.DefaultCellStyle = dataGridViewCellStyle3;
			this.colErfassungsdatum.FillWeight = 10F;
			this.colErfassungsdatum.HeaderText = "Datum";
			this.colErfassungsdatum.MinimumWidth = 75;
			this.colErfassungsdatum.Name = "colErfassungsdatum";
			this.colErfassungsdatum.ReadOnly = true;
			// 
			// colThema
			// 
			this.colThema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colThema.DataPropertyName = "Subject";
			this.colThema.FillWeight = 30F;
			this.colThema.HeaderText = "Thema";
			this.colThema.MinimumWidth = 200;
			this.colThema.Name = "colThema";
			this.colThema.ReadOnly = true;
			// 
			// colNotiztext
			// 
			this.colNotiztext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNotiztext.DataPropertyName = "Body";
			this.colNotiztext.FillWeight = 60F;
			this.colNotiztext.HeaderText = "Notiz";
			this.colNotiztext.MinimumWidth = 400;
			this.colNotiztext.Name = "colNotiztext";
			this.colNotiztext.ReadOnly = true;
			// 
			// mbtnCreateNote
			// 
			this.mbtnCreateNote.BackColor = System.Drawing.Color.Transparent;
			this.mbtnCreateNote.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metroorange;
			this.mbtnCreateNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnCreateNote.FlatAppearance.BorderSize = 0;
			this.mbtnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnCreateNote.Location = new System.Drawing.Point(83, 11);
			this.mbtnCreateNote.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.mbtnCreateNote.Name = "mbtnCreateNote";
			this.mbtnCreateNote.Size = new System.Drawing.Size(36, 36);
			this.mbtnCreateNote.TabIndex = 132;
			this.mbtnCreateNote.UseVisualStyleBackColor = false;
			this.mbtnCreateNote.Click += new System.EventHandler(this.mbtnCreateNote_Click);
			// 
			// lblNotizen
			// 
			this.lblNotizen.AutoSize = true;
			this.lblNotizen.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblNotizen.Location = new System.Drawing.Point(579, 20);
			this.lblNotizen.Name = "lblNotizen";
			this.lblNotizen.Size = new System.Drawing.Size(71, 25);
			this.lblNotizen.TabIndex = 134;
			this.lblNotizen.Text = "Notizen";
			// 
			// tabSoftware
			// 
			this.tabSoftware.Controls.Add(this.mbtnDeleteSoftware);
			this.tabSoftware.Controls.Add(this.mbtnOpenSoftware);
			this.tabSoftware.Controls.Add(this.label9);
			this.tabSoftware.Controls.Add(this.mbtnCreateSoftware);
			this.tabSoftware.Controls.Add(this.dgvSoftware);
			this.tabSoftware.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabSoftware.Location = new System.Drawing.Point(4, 38);
			this.tabSoftware.Name = "tabSoftware";
			this.tabSoftware.Padding = new System.Windows.Forms.Padding(20);
			this.tabSoftware.Size = new System.Drawing.Size(1234, 549);
			this.tabSoftware.TabIndex = 2;
			this.tabSoftware.Text = "Software";
			this.tabSoftware.UseVisualStyleBackColor = true;
			// 
			// mbtnDeleteSoftware
			// 
			this.mbtnDeleteSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnDeleteSoftware.BackColor = System.Drawing.Color.Transparent;
			this.mbtnDeleteSoftware.BackgroundImage = global::Products.Common.Properties.Resources.garbage_32_metroyellow;
			this.mbtnDeleteSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnDeleteSoftware.FlatAppearance.BorderSize = 0;
			this.mbtnDeleteSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnDeleteSoftware.Location = new System.Drawing.Point(1178, 11);
			this.mbtnDeleteSoftware.Margin = new System.Windows.Forms.Padding(3, 10, 20, 20);
			this.mbtnDeleteSoftware.Name = "mbtnDeleteSoftware";
			this.mbtnDeleteSoftware.Size = new System.Drawing.Size(36, 36);
			this.mbtnDeleteSoftware.TabIndex = 128;
			this.mbtnDeleteSoftware.UseVisualStyleBackColor = false;
			this.mbtnDeleteSoftware.Click += new System.EventHandler(this.mbtnDeleteSoftware_Click);
			// 
			// mbtnOpenSoftware
			// 
			this.mbtnOpenSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnOpenSoftware.BackColor = System.Drawing.Color.Transparent;
			this.mbtnOpenSoftware.BackgroundImage = global::Products.Common.Properties.Resources.open_32_metroyellow;
			this.mbtnOpenSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnOpenSoftware.FlatAppearance.BorderSize = 0;
			this.mbtnOpenSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnOpenSoftware.Location = new System.Drawing.Point(24, 10);
			this.mbtnOpenSoftware.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.mbtnOpenSoftware.Name = "mbtnOpenSoftware";
			this.mbtnOpenSoftware.Size = new System.Drawing.Size(36, 36);
			this.mbtnOpenSoftware.TabIndex = 125;
			this.mbtnOpenSoftware.UseVisualStyleBackColor = false;
			this.mbtnOpenSoftware.Click += new System.EventHandler(this.mbtnOpenSoftware_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.label9.Location = new System.Drawing.Point(579, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 25);
			this.label9.TabIndex = 129;
			this.label9.Text = "Software";
			// 
			// mbtnCreateSoftware
			// 
			this.mbtnCreateSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnCreateSoftware.BackColor = System.Drawing.Color.Transparent;
			this.mbtnCreateSoftware.BackgroundImage = global::Products.Common.Properties.Resources.neu_32_metroyellow;
			this.mbtnCreateSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnCreateSoftware.FlatAppearance.BorderSize = 0;
			this.mbtnCreateSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnCreateSoftware.Location = new System.Drawing.Point(83, 11);
			this.mbtnCreateSoftware.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
			this.mbtnCreateSoftware.Name = "mbtnCreateSoftware";
			this.mbtnCreateSoftware.Size = new System.Drawing.Size(36, 36);
			this.mbtnCreateSoftware.TabIndex = 127;
			this.mbtnCreateSoftware.UseVisualStyleBackColor = false;
			this.mbtnCreateSoftware.Click += new System.EventHandler(this.mbtnCreateSoftware_Click);
			// 
			// dgvSoftware
			// 
			this.dgvSoftware.AllowUserToAddRows = false;
			this.dgvSoftware.AllowUserToDeleteRows = false;
			this.dgvSoftware.AllowUserToResizeRows = false;
			this.dgvSoftware.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSoftware.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSoftware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoftwareName,
            this.colLizenzSchluessel});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSoftware.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvSoftware.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvSoftware.EnableHeadersVisualStyles = false;
			this.dgvSoftware.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSoftware.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSoftware.Location = new System.Drawing.Point(20, 53);
			this.dgvSoftware.Name = "dgvSoftware";
			this.dgvSoftware.ReadOnly = true;
			this.dgvSoftware.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSoftware.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvSoftware.RowHeadersVisible = false;
			this.dgvSoftware.RowHeadersWidth = 21;
			this.dgvSoftware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSoftware.Size = new System.Drawing.Size(1194, 476);
			this.dgvSoftware.Style = MetroFramework.MetroColorStyle.Yellow;
			this.dgvSoftware.TabIndex = 126;
			this.dgvSoftware.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_RowEnter);
			this.dgvSoftware.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSoftware_MouseDoubleClick);
			// 
			// colSoftwareName
			// 
			this.colSoftwareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSoftwareName.DataPropertyName = "Softwarename";
			this.colSoftwareName.FillWeight = 30F;
			this.colSoftwareName.HeaderText = "Software";
			this.colSoftwareName.Name = "colSoftwareName";
			this.colSoftwareName.ReadOnly = true;
			// 
			// colLizenzSchluessel
			// 
			this.colLizenzSchluessel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLizenzSchluessel.DataPropertyName = "Lizenzschluessel";
			this.colLizenzSchluessel.FillWeight = 70F;
			this.colLizenzSchluessel.HeaderText = "Lizenz";
			this.colLizenzSchluessel.Name = "colLizenzSchluessel";
			this.colLizenzSchluessel.ReadOnly = true;
			// 
			// tabSales
			// 
			this.tabSales.AllowDrop = true;
			this.tabSales.Controls.Add(this.ndtpVertragsende);
			this.tabSales.Controls.Add(this.metroLabel14);
			this.tabSales.Controls.Add(this.mtxtFinanzierungDurch);
			this.tabSales.Controls.Add(this.metroLabel13);
			this.tabSales.Controls.Add(this.metroLabel12);
			this.tabSales.Controls.Add(this.mtogglErstverwertung);
			this.tabSales.Controls.Add(this.metroLabel11);
			this.tabSales.Controls.Add(this.mtogglMietkauf);
			this.tabSales.Controls.Add(this.metroLabel10);
			this.tabSales.Controls.Add(this.mtogglLeasing);
			this.tabSales.Controls.Add(this.mcmbTechniker);
			this.tabSales.Controls.Add(this.metroLabel5);
			this.tabSales.Controls.Add(this.mtxtSageInfos);
			this.tabSales.Controls.Add(this.mbtnOpenInSage);
			this.tabSales.Controls.Add(this.metroLabel6);
			this.tabSales.Controls.Add(this.metroLabel7);
			this.tabSales.Controls.Add(this.metroLabel8);
			this.tabSales.Controls.Add(this.metroLabel9);
			this.tabSales.Controls.Add(this.ndtpInstallation);
			this.tabSales.Controls.Add(this.ndtpLieferschein);
			this.tabSales.Controls.Add(this.metroLabel4);
			this.tabSales.Controls.Add(this.ndtpRechnung);
			this.tabSales.Controls.Add(this.metroLabel3);
			this.tabSales.Controls.Add(this.ndtpAuftrag);
			this.tabSales.Controls.Add(this.metroLabel2);
			this.tabSales.Controls.Add(this.mtxtLieferschein);
			this.tabSales.Controls.Add(this.mtxtRechnung);
			this.tabSales.Controls.Add(this.mtxtAuftrag);
			this.tabSales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabSales.Location = new System.Drawing.Point(4, 38);
			this.tabSales.Name = "tabSales";
			this.tabSales.Padding = new System.Windows.Forms.Padding(20);
			this.tabSales.Size = new System.Drawing.Size(1234, 549);
			this.tabSales.TabIndex = 3;
			this.tabSales.Text = "Auftrag/Finanzierung";
			this.tabSales.UseVisualStyleBackColor = true;
			// 
			// mcmbTechniker
			// 
			this.mcmbTechniker.FormattingEnabled = true;
			this.mcmbTechniker.ItemHeight = 23;
			this.mcmbTechniker.Items.AddRange(new object[] {
            "Matthias",
            "Johannes",
            "Felix",
            "Axel",
            "Markus"});
			this.mcmbTechniker.Location = new System.Drawing.Point(117, 174);
			this.mcmbTechniker.MaxDropDownItems = 5;
			this.mcmbTechniker.Name = "mcmbTechniker";
			this.mcmbTechniker.PromptText = "Johannes";
			this.mcmbTechniker.Size = new System.Drawing.Size(112, 29);
			this.mcmbTechniker.Style = MetroFramework.MetroColorStyle.Orange;
			this.mcmbTechniker.TabIndex = 6;
			this.mcmbTechniker.UseSelectable = true;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(243, 178);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(28, 19);
			this.metroLabel5.TabIndex = 153;
			this.metroLabel5.Text = "am";
			// 
			// mtxtSageInfos
			// 
			this.mtxtSageInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.mtxtSageInfos.CustomButton.Image = null;
			this.mtxtSageInfos.CustomButton.Location = new System.Drawing.Point(598, 2);
			this.mtxtSageInfos.CustomButton.Name = "";
			this.mtxtSageInfos.CustomButton.Size = new System.Drawing.Size(135, 135);
			this.mtxtSageInfos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtxtSageInfos.CustomButton.TabIndex = 1;
			this.mtxtSageInfos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtSageInfos.CustomButton.UseSelectable = true;
			this.mtxtSageInfos.CustomButton.Visible = false;
			this.mtxtSageInfos.Lines = new string[0];
			this.mtxtSageInfos.Location = new System.Drawing.Point(475, 63);
			this.mtxtSageInfos.MaxLength = 32767;
			this.mtxtSageInfos.Multiline = true;
			this.mtxtSageInfos.Name = "mtxtSageInfos";
			this.mtxtSageInfos.PasswordChar = '\0';
			this.mtxtSageInfos.PromptText = "Infos zu SAGE Aufträgen, Rechnungen, Lieferungen für diese Maschine";
			this.mtxtSageInfos.ReadOnly = true;
			this.mtxtSageInfos.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtSageInfos.SelectedText = "";
			this.mtxtSageInfos.SelectionLength = 0;
			this.mtxtSageInfos.SelectionStart = 0;
			this.mtxtSageInfos.ShortcutsEnabled = true;
			this.mtxtSageInfos.Size = new System.Drawing.Size(736, 140);
			this.mtxtSageInfos.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtSageInfos.TabIndex = 152;
			this.mtxtSageInfos.UseSelectable = true;
			this.mtxtSageInfos.WaterMark = "Infos zu SAGE Aufträgen, Rechnungen, Lieferungen für diese Maschine";
			this.mtxtSageInfos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtSageInfos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mbtnOpenInSage
			// 
			this.mbtnOpenInSage.BackgroundImage = global::Products.Common.Properties.Resources.SageNCL_32;
			this.mbtnOpenInSage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mbtnOpenInSage.Location = new System.Drawing.Point(401, 60);
			this.mbtnOpenInSage.Name = "mbtnOpenInSage";
			this.mbtnOpenInSage.Size = new System.Drawing.Size(34, 34);
			this.mbtnOpenInSage.TabIndex = 151;
			this.toolTip1.SetToolTip(this.mbtnOpenInSage, "Öffnet (wenn einer da ist) den Auftrag in Sage");
			this.mbtnOpenInSage.UseCustomBackColor = true;
			this.mbtnOpenInSage.UseSelectable = true;
			this.mbtnOpenInSage.Click += new System.EventHandler(this.mbtnOpenInSage_Click);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(25, 178);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(86, 19);
			this.metroLabel6.TabIndex = 149;
			this.metroLabel6.Text = "Installiert von";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(25, 140);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(76, 19);
			this.metroLabel7.TabIndex = 148;
			this.metroLabel7.Text = "Lieferschein";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(25, 104);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(71, 19);
			this.metroLabel8.TabIndex = 147;
			this.metroLabel8.Text = "Rechnungs";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(25, 66);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(53, 19);
			this.metroLabel9.TabIndex = 146;
			this.metroLabel9.Text = "Auftrag";
			// 
			// ndtpInstallation
			// 
			this.ndtpInstallation.CustomFormat = "";
			this.ndtpInstallation.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpInstallation.Location = new System.Drawing.Point(284, 174);
			this.ndtpInstallation.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.ndtpInstallation.MinDate = new System.DateTime(2006, 12, 17, 0, 0, 0, 0);
			this.ndtpInstallation.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpInstallation.Name = "ndtpInstallation";
			this.ndtpInstallation.NullValue = " -";
			this.ndtpInstallation.Size = new System.Drawing.Size(105, 29);
			this.ndtpInstallation.TabIndex = 7;
			this.ndtpInstallation.Value = new System.DateTime(2016, 10, 26, 18, 21, 39, 144);
			this.ndtpInstallation.Validated += new System.EventHandler(this.ndtpInstallation_Validated);
			// 
			// ndtpLieferschein
			// 
			this.ndtpLieferschein.CustomFormat = "";
			this.ndtpLieferschein.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpLieferschein.Location = new System.Drawing.Point(284, 138);
			this.ndtpLieferschein.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.ndtpLieferschein.MinDate = new System.DateTime(2006, 12, 17, 0, 0, 0, 0);
			this.ndtpLieferschein.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpLieferschein.Name = "ndtpLieferschein";
			this.ndtpLieferschein.NullValue = "";
			this.ndtpLieferschein.Size = new System.Drawing.Size(105, 29);
			this.ndtpLieferschein.TabIndex = 5;
			this.ndtpLieferschein.Value = new System.DateTime(2016, 10, 26, 18, 21, 39, 144);
			this.ndtpLieferschein.Validated += new System.EventHandler(this.ndtpLieferschein_Validated);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(243, 141);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(35, 19);
			this.metroLabel4.TabIndex = 142;
			this.metroLabel4.Text = "vom";
			// 
			// ndtpRechnung
			// 
			this.ndtpRechnung.CustomFormat = "";
			this.ndtpRechnung.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpRechnung.Location = new System.Drawing.Point(284, 102);
			this.ndtpRechnung.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.ndtpRechnung.MinDate = new System.DateTime(2006, 12, 17, 0, 0, 0, 0);
			this.ndtpRechnung.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpRechnung.Name = "ndtpRechnung";
			this.ndtpRechnung.NullValue = "";
			this.ndtpRechnung.Size = new System.Drawing.Size(105, 29);
			this.ndtpRechnung.TabIndex = 3;
			this.ndtpRechnung.Value = new System.DateTime(2016, 10, 26, 18, 21, 39, 144);
			this.ndtpRechnung.Validated += new System.EventHandler(this.ndtpRechnung_Validated);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(243, 105);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(35, 19);
			this.metroLabel3.TabIndex = 140;
			this.metroLabel3.Text = "vom";
			// 
			// ndtpAuftrag
			// 
			this.ndtpAuftrag.CustomFormat = "";
			this.ndtpAuftrag.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpAuftrag.Location = new System.Drawing.Point(284, 63);
			this.ndtpAuftrag.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.ndtpAuftrag.MinDate = new System.DateTime(2006, 12, 17, 0, 0, 0, 0);
			this.ndtpAuftrag.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpAuftrag.Name = "ndtpAuftrag";
			this.ndtpAuftrag.NullValue = "";
			this.ndtpAuftrag.Size = new System.Drawing.Size(105, 29);
			this.ndtpAuftrag.TabIndex = 1;
			this.ndtpAuftrag.Value = new System.DateTime(2016, 10, 26, 18, 21, 39, 144);
			this.ndtpAuftrag.Validated += new System.EventHandler(this.ndtpAuftrag_Validated);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(243, 66);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(35, 19);
			this.metroLabel2.TabIndex = 138;
			this.metroLabel2.Text = "vom";
			// 
			// mtxtLieferschein
			// 
			// 
			// 
			// 
			this.mtxtLieferschein.CustomButton.Image = null;
			this.mtxtLieferschein.CustomButton.Location = new System.Drawing.Point(90, 1);
			this.mtxtLieferschein.CustomButton.Name = "";
			this.mtxtLieferschein.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtLieferschein.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtLieferschein.CustomButton.TabIndex = 1;
			this.mtxtLieferschein.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtLieferschein.CustomButton.UseSelectable = true;
			this.mtxtLieferschein.CustomButton.Visible = false;
			this.mtxtLieferschein.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtLieferschein.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtLieferschein.Lines = new string[] {
        "20160001712"};
			this.mtxtLieferschein.Location = new System.Drawing.Point(117, 138);
			this.mtxtLieferschein.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtLieferschein.MaxLength = 11;
			this.mtxtLieferschein.Name = "mtxtLieferschein";
			this.mtxtLieferschein.PasswordChar = '\0';
			this.mtxtLieferschein.PromptText = "Auftrags-Nr.";
			this.mtxtLieferschein.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtLieferschein.SelectedText = "";
			this.mtxtLieferschein.SelectionLength = 0;
			this.mtxtLieferschein.SelectionStart = 0;
			this.mtxtLieferschein.ShortcutsEnabled = true;
			this.mtxtLieferschein.Size = new System.Drawing.Size(112, 23);
			this.mtxtLieferschein.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtLieferschein.TabIndex = 4;
			this.mtxtLieferschein.Text = "20160001712";
			this.mtxtLieferschein.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtLieferschein.UseSelectable = true;
			this.mtxtLieferschein.WaterMark = "Auftrags-Nr.";
			this.mtxtLieferschein.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtLieferschein.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtRechnung
			// 
			// 
			// 
			// 
			this.mtxtRechnung.CustomButton.Image = null;
			this.mtxtRechnung.CustomButton.Location = new System.Drawing.Point(90, 1);
			this.mtxtRechnung.CustomButton.Name = "";
			this.mtxtRechnung.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtRechnung.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtRechnung.CustomButton.TabIndex = 1;
			this.mtxtRechnung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtRechnung.CustomButton.UseSelectable = true;
			this.mtxtRechnung.CustomButton.Visible = false;
			this.mtxtRechnung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtRechnung.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtRechnung.Lines = new string[] {
        "20160001712"};
			this.mtxtRechnung.Location = new System.Drawing.Point(117, 102);
			this.mtxtRechnung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtRechnung.MaxLength = 13;
			this.mtxtRechnung.Name = "mtxtRechnung";
			this.mtxtRechnung.PasswordChar = '\0';
			this.mtxtRechnung.PromptText = "Auftrags-Nr.";
			this.mtxtRechnung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtRechnung.SelectedText = "";
			this.mtxtRechnung.SelectionLength = 0;
			this.mtxtRechnung.SelectionStart = 0;
			this.mtxtRechnung.ShortcutsEnabled = true;
			this.mtxtRechnung.Size = new System.Drawing.Size(112, 23);
			this.mtxtRechnung.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtRechnung.TabIndex = 2;
			this.mtxtRechnung.Text = "20160001712";
			this.mtxtRechnung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.mtxtRechnung, "Hier bitte zur Identifikation ein \'R-\' oder \'D-\' vor die Rechnungsnummer setzten." +
        "");
			this.mtxtRechnung.UseSelectable = true;
			this.mtxtRechnung.WaterMark = "Auftrags-Nr.";
			this.mtxtRechnung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtRechnung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtxtAuftrag
			// 
			// 
			// 
			// 
			this.mtxtAuftrag.CustomButton.Image = null;
			this.mtxtAuftrag.CustomButton.Location = new System.Drawing.Point(90, 1);
			this.mtxtAuftrag.CustomButton.Name = "";
			this.mtxtAuftrag.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtAuftrag.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtAuftrag.CustomButton.TabIndex = 1;
			this.mtxtAuftrag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtAuftrag.CustomButton.UseSelectable = true;
			this.mtxtAuftrag.CustomButton.Visible = false;
			this.mtxtAuftrag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtAuftrag.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtAuftrag.Lines = new string[] {
        "20160001712"};
			this.mtxtAuftrag.Location = new System.Drawing.Point(117, 66);
			this.mtxtAuftrag.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtAuftrag.MaxLength = 11;
			this.mtxtAuftrag.Name = "mtxtAuftrag";
			this.mtxtAuftrag.PasswordChar = '\0';
			this.mtxtAuftrag.PromptText = "Auftrags-Nr.";
			this.mtxtAuftrag.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtAuftrag.SelectedText = "";
			this.mtxtAuftrag.SelectionLength = 0;
			this.mtxtAuftrag.SelectionStart = 0;
			this.mtxtAuftrag.ShortcutsEnabled = true;
			this.mtxtAuftrag.Size = new System.Drawing.Size(112, 23);
			this.mtxtAuftrag.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtAuftrag.TabIndex = 0;
			this.mtxtAuftrag.Text = "20160001712";
			this.mtxtAuftrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxtAuftrag.UseSelectable = true;
			this.mtxtAuftrag.WaterMark = "Auftrags-Nr.";
			this.mtxtAuftrag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtAuftrag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mtogglLeasing
			// 
			this.mtogglLeasing.AutoSize = true;
			this.mtogglLeasing.Location = new System.Drawing.Point(25, 255);
			this.mtogglLeasing.Name = "mtogglLeasing";
			this.mtogglLeasing.Size = new System.Drawing.Size(80, 17);
			this.mtogglLeasing.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtogglLeasing.TabIndex = 8;
			this.mtogglLeasing.Text = "Aus";
			this.mtogglLeasing.UseSelectable = true;
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(107, 254);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(52, 19);
			this.metroLabel10.TabIndex = 154;
			this.metroLabel10.Text = "Leasing";
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(282, 255);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(59, 19);
			this.metroLabel11.TabIndex = 156;
			this.metroLabel11.Text = "Mietkauf";
			// 
			// mtogglMietkauf
			// 
			this.mtogglMietkauf.AutoSize = true;
			this.mtogglMietkauf.Location = new System.Drawing.Point(200, 256);
			this.mtogglMietkauf.Name = "mtogglMietkauf";
			this.mtogglMietkauf.Size = new System.Drawing.Size(80, 17);
			this.mtogglMietkauf.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtogglMietkauf.TabIndex = 9;
			this.mtogglMietkauf.Text = "Aus";
			this.mtogglMietkauf.UseSelectable = true;
			// 
			// metroLabel12
			// 
			this.metroLabel12.AutoSize = true;
			this.metroLabel12.Location = new System.Drawing.Point(461, 255);
			this.metroLabel12.Name = "metroLabel12";
			this.metroLabel12.Size = new System.Drawing.Size(97, 19);
			this.metroLabel12.TabIndex = 158;
			this.metroLabel12.Text = "Erstverwertung";
			// 
			// mtogglErstverwertung
			// 
			this.mtogglErstverwertung.AutoSize = true;
			this.mtogglErstverwertung.Location = new System.Drawing.Point(379, 256);
			this.mtogglErstverwertung.Name = "mtogglErstverwertung";
			this.mtogglErstverwertung.Size = new System.Drawing.Size(80, 17);
			this.mtogglErstverwertung.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtogglErstverwertung.TabIndex = 10;
			this.mtogglErstverwertung.Text = "Aus";
			this.mtogglErstverwertung.UseSelectable = true;
			// 
			// metroLabel13
			// 
			this.metroLabel13.AutoSize = true;
			this.metroLabel13.Location = new System.Drawing.Point(25, 296);
			this.metroLabel13.Name = "metroLabel13";
			this.metroLabel13.Size = new System.Drawing.Size(83, 19);
			this.metroLabel13.TabIndex = 159;
			this.metroLabel13.Text = "Finanzierung";
			// 
			// mtxtFinanzierungDurch
			// 
			// 
			// 
			// 
			this.mtxtFinanzierungDurch.CustomButton.Image = null;
			this.mtxtFinanzierungDurch.CustomButton.Location = new System.Drawing.Point(203, 1);
			this.mtxtFinanzierungDurch.CustomButton.Name = "";
			this.mtxtFinanzierungDurch.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtxtFinanzierungDurch.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtFinanzierungDurch.CustomButton.TabIndex = 1;
			this.mtxtFinanzierungDurch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtxtFinanzierungDurch.CustomButton.UseSelectable = true;
			this.mtxtFinanzierungDurch.CustomButton.Visible = false;
			this.mtxtFinanzierungDurch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mtxtFinanzierungDurch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.mtxtFinanzierungDurch.Lines = new string[] {
        "20160001712"};
			this.mtxtFinanzierungDurch.Location = new System.Drawing.Point(116, 294);
			this.mtxtFinanzierungDurch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.mtxtFinanzierungDurch.MaxLength = 11;
			this.mtxtFinanzierungDurch.Name = "mtxtFinanzierungDurch";
			this.mtxtFinanzierungDurch.PasswordChar = '\0';
			this.mtxtFinanzierungDurch.PromptText = "Auftrags-Nr.";
			this.mtxtFinanzierungDurch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtxtFinanzierungDurch.SelectedText = "";
			this.mtxtFinanzierungDurch.SelectionLength = 0;
			this.mtxtFinanzierungDurch.SelectionStart = 0;
			this.mtxtFinanzierungDurch.ShortcutsEnabled = true;
			this.mtxtFinanzierungDurch.Size = new System.Drawing.Size(225, 23);
			this.mtxtFinanzierungDurch.Style = MetroFramework.MetroColorStyle.Orange;
			this.mtxtFinanzierungDurch.TabIndex = 160;
			this.mtxtFinanzierungDurch.Text = "20160001712";
			this.mtxtFinanzierungDurch.UseSelectable = true;
			this.mtxtFinanzierungDurch.WaterMark = "Auftrags-Nr.";
			this.mtxtFinanzierungDurch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtxtFinanzierungDurch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// ndtpVertragsende
			// 
			this.ndtpVertragsende.CustomFormat = "";
			this.ndtpVertragsende.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndtpVertragsende.Location = new System.Drawing.Point(406, 290);
			this.ndtpVertragsende.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.ndtpVertragsende.MinDate = new System.DateTime(2006, 12, 17, 0, 0, 0, 0);
			this.ndtpVertragsende.MinimumSize = new System.Drawing.Size(4, 29);
			this.ndtpVertragsende.Name = "ndtpVertragsende";
			this.ndtpVertragsende.NullValue = "";
			this.ndtpVertragsende.Size = new System.Drawing.Size(105, 29);
			this.ndtpVertragsende.TabIndex = 161;
			this.ndtpVertragsende.Value = new System.DateTime(2016, 10, 26, 18, 21, 39, 144);
			this.ndtpVertragsende.Validated += new System.EventHandler(this.ndtpVertragsende_Validated);
			// 
			// metroLabel14
			// 
			this.metroLabel14.AutoSize = true;
			this.metroLabel14.Location = new System.Drawing.Point(360, 293);
			this.metroLabel14.Name = "metroLabel14";
			this.metroLabel14.Size = new System.Drawing.Size(38, 19);
			this.metroLabel14.TabIndex = 162;
			this.metroLabel14.Text = "Ende";
			// 
			// pnlKundenMaschine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.mtabProperties);
			this.Controls.Add(this.mlblTitel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbInkType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMachineModel);
			this.Controls.Add(this.txtColorSet);
			this.Controls.Add(this.mtxtSerialNumber);
			this.DoubleBuffered = true;
			this.Name = "pnlKundenMaschine";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(1288, 776);
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Leave += new System.EventHandler(this.pnlKundenMaschine_Leave);
			this.mctxTree.ResumeLayout(false);
			this.mctxGrid.ResumeLayout(false);
			this.mtabProperties.ResumeLayout(false);
			this.tabFiles.ResumeLayout(false);
			this.tabFiles.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
			this.tabNotes.ResumeLayout(false);
			this.tabNotes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotizen)).EndInit();
			this.tabSoftware.ResumeLayout(false);
			this.tabSoftware.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
			this.tabSales.ResumeLayout(false);
			this.tabSales.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel label4;
		private MetroFramework.Controls.MetroComboBox cmbInkType;
		private MetroFramework.Controls.MetroLabel label3;
		private MetroFramework.Controls.MetroLabel label2;
		private MetroFramework.Controls.MetroLabel label1;
		private MetroFramework.Controls.MetroComboBox cmbMachineModel;
		private MetroFramework.Controls.MetroTextBox txtColorSet;
		private MetroFramework.Controls.MetroTextBox mtxtSerialNumber;
		private MetroFramework.Controls.MetroLabel mlblTitel;
		private System.Windows.Forms.ImageList imageList1;
		private MetroFramework.Controls.MetroContextMenu mctxGrid;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenFile;
		private MetroFramework.Controls.MetroContextMenu mctxTree;
		private System.Windows.Forms.ToolStripMenuItem xcmdOpenInExplorer;
		private MetroFramework.Controls.MetroTabControl mtabProperties;
		private System.Windows.Forms.TabPage tabFiles;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView trvFolders;
		private MetroFramework.Controls.MetroGrid dgvFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFilename;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colChangeDate;
		private MetroFramework.Controls.MetroTabPage tabNotes;
		private System.Windows.Forms.TabPage tabSoftware;
		private System.Windows.Forms.TabPage tabSales;
		private System.Windows.Forms.Button mbtnDeleteNote;
		private System.Windows.Forms.Button mbtnOpenNote;
		private MetroFramework.Controls.MetroGrid dgvNotizen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colErfassungsdatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colThema;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNotiztext;
		private System.Windows.Forms.Button mbtnCreateNote;
		private MetroFramework.Controls.MetroLabel lblNotizen;
		private System.Windows.Forms.Button mbtnDeleteSoftware;
		private System.Windows.Forms.Button mbtnOpenSoftware;
		private MetroFramework.Controls.MetroLabel label9;
		private System.Windows.Forms.Button mbtnCreateSoftware;
		private MetroFramework.Controls.MetroGrid dgvSoftware;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwareName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLizenzSchluessel;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private NullableDateTimePicker ndtpInstallation;
		private NullableDateTimePicker ndtpLieferschein;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private NullableDateTimePicker ndtpRechnung;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private NullableDateTimePicker ndtpAuftrag;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox mtxtLieferschein;
		private MetroFramework.Controls.MetroTextBox mtxtRechnung;
		private MetroFramework.Controls.MetroTextBox mtxtAuftrag;
		private MetroFramework.Controls.MetroButton mbtnOpenInSage;
		private System.Windows.Forms.ToolTip toolTip1;
		private MetroFramework.Controls.MetroTextBox mtxtSageInfos;
		private MetroFramework.Controls.MetroComboBox mcmbTechniker;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox mtxtNoteText;
		private NullableDateTimePicker ndtpVertragsende;
		private MetroFramework.Controls.MetroLabel metroLabel14;
		private MetroFramework.Controls.MetroTextBox mtxtFinanzierungDurch;
		private MetroFramework.Controls.MetroLabel metroLabel13;
		private MetroFramework.Controls.MetroLabel metroLabel12;
		private MetroFramework.Controls.MetroToggle mtogglErstverwertung;
		private MetroFramework.Controls.MetroLabel metroLabel11;
		private MetroFramework.Controls.MetroToggle mtogglMietkauf;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private MetroFramework.Controls.MetroToggle mtogglLeasing;

#pragma warning restore CS0618 // Typ oder Element ist veraltet

	}
}
