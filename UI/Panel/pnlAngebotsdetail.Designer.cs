using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace Products.Common.Panel
{
	partial class pnlAngebotsdetail
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

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
		void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			this.mlblTitle = new MetroLabel();
			this.dgvOfferDetails = new MetroGrid();
			this.ctxGrid = new MetroContextMenu(this.components);
			this.ccmdNewDetail = new ToolStripMenuItem();
			this.ccmdDeleteDetail = new ToolStripMenuItem();
			this.ccmdPrint2 = new ToolStripMenuItem();
			this.nachObenToolStripMenuItem = new ToolStripSeparator();
			this.xcmdMoveUp = new ToolStripMenuItem();
			this.xcmdMoveDown = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.ccmdTaschenrechner = new ToolStripMenuItem();
			this.mToolTip = new MetroToolTip();
			this.mchkBestellkennzeichen = new MetroCheckBox();
			this.btnMailToUser = new Button();
			this.btnMailToCustomer = new Button();
			this.btnRechner = new Button();
			this.btnDrucken = new Button();
			this.btnPositionLoeschen = new Button();
			this.btnNeuePosition = new Button();
			this.ctxForm = new MetroContextMenu(this.components);
			this.ccmdPrint = new ToolStripMenuItem();
			this.mcmdMailToCustomer = new ToolStripMenuItem();
			this.mcmdMailToUser = new ToolStripMenuItem();
			this.txtPositionsinfo = new MetroTextBox();
			this.txtRowComment = new MetroTextBox();
			this.mlblPositionstext = new MetroLabel();
			this.mtxtZahlungsbedingungen = new MetroTextBox();
			this.mlblZahlungsbedingungen = new MetroLabel();
			this.colActive = new DataGridViewCheckBoxColumn();
			this.colPosIndex = new DataGridViewTextBoxColumn();
			this.colProductId = new DataGridViewTextBoxColumn();
			this.colProductName = new DataGridViewTextBoxColumn();
			this.colQuantity = new DataGridViewTextBoxColumn();
			this.colUnit = new DataGridViewTextBoxColumn();
			this.colEK = new DataGridViewTextBoxColumn();
			this.colUnitPrice = new DataGridViewTextBoxColumn();
			this.colRabattbetrag = new DataGridViewTextBoxColumn();
			this.colDiscountPercent = new DataGridViewTextBoxColumn();
			this.colUnitPriceCustomer = new DataGridViewTextBoxColumn();
			this.colRowTotal = new DataGridViewTextBoxColumn();
			this.colKatalogHeader = new DataGridViewTextBoxColumn();
			this.colNeueSeite = new DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvOfferDetails)).BeginInit();
			this.ctxGrid.SuspendLayout();
			this.ctxForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// mlblTitle
			// 
			this.mlblTitle.AutoSize = true;
			this.mlblTitle.FontSize = MetroLabelSize.Tall;
			this.mlblTitle.Location = new Point(23, 20);
			this.mlblTitle.Name = "mlblTitle";
			this.mlblTitle.Size = new Size(132, 25);
			this.mlblTitle.TabIndex = 0;
			this.mlblTitle.Text = "Angebot vom ...";
			// 
			// dgvOfferDetails
			// 
			this.dgvOfferDetails.AllowUserToAddRows = false;
			this.dgvOfferDetails.AllowUserToDeleteRows = false;
			this.dgvOfferDetails.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
			this.dgvOfferDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvOfferDetails.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
						| AnchorStyles.Left) 
						| AnchorStyles.Right)));
			this.dgvOfferDetails.BackgroundColor = Color.FromArgb(255, 255, 255);
			this.dgvOfferDetails.BorderStyle = BorderStyle.None;
			this.dgvOfferDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.dgvOfferDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(142, 188, 0);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(165, 219, 0);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dgvOfferDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvOfferDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOfferDetails.Columns.AddRange(new DataGridViewColumn[] {
						this.colActive,
						this.colPosIndex,
						this.colProductId,
						this.colProductName,
						this.colQuantity,
						this.colUnit,
						this.colEK,
						this.colUnitPrice,
						this.colRabattbetrag,
						this.colDiscountPercent,
						this.colUnitPriceCustomer,
						this.colRowTotal,
						this.colKatalogHeader,
						this.colNeueSeite});
			this.dgvOfferDetails.ContextMenuStrip = this.ctxGrid;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(165, 219, 0);
			dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
			this.dgvOfferDetails.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvOfferDetails.EnableHeadersVisualStyles = false;
			this.dgvOfferDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			this.dgvOfferDetails.GridColor = Color.FromArgb(255, 255, 255);
			this.dgvOfferDetails.Location = new Point(23, 142);
			this.dgvOfferDetails.MultiSelect = false;
			this.dgvOfferDetails.Name = "dgvOfferDetails";
			this.dgvOfferDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = Color.FromArgb(142, 188, 0);
			dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(165, 219, 0);
			dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
			this.dgvOfferDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvOfferDetails.RowHeadersVisible = false;
			this.dgvOfferDetails.RowHeadersWidth = 21;
			this.dgvOfferDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvOfferDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvOfferDetails.Size = new Size(1234, 321);
			this.dgvOfferDetails.Style = MetroColorStyle.Lime;
			this.dgvOfferDetails.TabIndex = 0;
			this.dgvOfferDetails.RowEnter += new DataGridViewCellEventHandler(this.dgvOfferDetails_RowEnter);
			// 
			// ctxGrid
			// 
			this.ctxGrid.BackColor = Color.White;
			this.ctxGrid.Items.AddRange(new ToolStripItem[] {
						this.ccmdNewDetail,
						this.ccmdDeleteDetail,
						this.ccmdPrint2,
						this.nachObenToolStripMenuItem,
						this.xcmdMoveUp,
						this.xcmdMoveDown,
						this.toolStripMenuItem2,
						this.ccmdTaschenrechner});
			this.ctxGrid.Name = "ctxGrid";
			this.ctxGrid.Size = new Size(202, 148);
			// 
			// ccmdNewDetail
			// 
			this.ccmdNewDetail.Image = Properties.Resources.neu_metrolime;
			this.ccmdNewDetail.Name = "ccmdNewDetail";
			this.ccmdNewDetail.ShortcutKeyDisplayString = "(Strg+N)";
			this.ccmdNewDetail.ShortcutKeys = ((Keys)((Keys.Control | Keys.N)));
			this.ccmdNewDetail.Size = new Size(201, 22);
			this.ccmdNewDetail.Text = "Neue Position";
			this.ccmdNewDetail.Click += new System.EventHandler(this.ccmdNewDetail_Click);
			// 
			// ccmdDeleteDetail
			// 
			this.ccmdDeleteDetail.Image = Properties.Resources.garbage_16_metrolime;
			this.ccmdDeleteDetail.Name = "ccmdDeleteDetail";
			this.ccmdDeleteDetail.ShortcutKeyDisplayString = "";
			this.ccmdDeleteDetail.Size = new Size(201, 22);
			this.ccmdDeleteDetail.Text = "Position löschen";
			this.ccmdDeleteDetail.Click += new System.EventHandler(this.ccmdDeleteDetail_Click);
			// 
			// ccmdPrint2
			// 
			this.ccmdPrint2.Image = Properties.Resources.print_16_metrolime;
			this.ccmdPrint2.Name = "ccmdPrint2";
			this.ccmdPrint2.ShortcutKeyDisplayString = "(Strg+P)";
			this.ccmdPrint2.ShortcutKeys = ((Keys)((Keys.Control | Keys.P)));
			this.ccmdPrint2.Size = new Size(201, 22);
			this.ccmdPrint2.Text = "Drucken";
			this.ccmdPrint2.Click += new System.EventHandler(this.ccmdPrint2_Click);
			// 
			// nachObenToolStripMenuItem
			// 
			this.nachObenToolStripMenuItem.Name = "nachObenToolStripMenuItem";
			this.nachObenToolStripMenuItem.Size = new Size(198, 6);
			// 
			// xcmdMoveUp
			// 
			this.xcmdMoveUp.Image = Properties.Resources.arrowup_16_metrolime;
			this.xcmdMoveUp.Name = "xcmdMoveUp";
			this.xcmdMoveUp.Size = new Size(201, 22);
			this.xcmdMoveUp.Text = "Rauf";
			this.xcmdMoveUp.Click += new System.EventHandler(this.xcmdMoveUp_Click);
			// 
			// xcmdMoveDown
			// 
			this.xcmdMoveDown.Image = Properties.Resources.arrowdown_16_metrolime;
			this.xcmdMoveDown.Name = "xcmdMoveDown";
			this.xcmdMoveDown.Size = new Size(201, 22);
			this.xcmdMoveDown.Text = "Runter";
			this.xcmdMoveDown.Click += new System.EventHandler(this.xcmdMoveDown_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(198, 6);
			// 
			// ccmdTaschenrechner
			// 
			this.ccmdTaschenrechner.Image = Properties.Resources.calc_16_metrolime;
			this.ccmdTaschenrechner.Name = "ccmdTaschenrechner";
			this.ccmdTaschenrechner.Size = new Size(201, 22);
			this.ccmdTaschenrechner.Text = "Taschenrechner";
			this.ccmdTaschenrechner.Click += new System.EventHandler(this.ccmdTaschenrechner_Click);
			// 
			// mToolTip
			// 
			this.mToolTip.Style = MetroColorStyle.Green;
			this.mToolTip.StyleManager = null;
			this.mToolTip.Theme = MetroThemeStyle.Default;
			this.mToolTip.UseAnimation = false;
			this.mToolTip.UseFading = false;
			// 
			// mchkBestellkennzeichen
			// 
			this.mchkBestellkennzeichen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.mchkBestellkennzeichen.AutoSize = true;
			this.mchkBestellkennzeichen.FontSize = MetroCheckBoxSize.Medium;
			this.mchkBestellkennzeichen.FontWeight = MetroCheckBoxWeight.Light;
			this.mchkBestellkennzeichen.Location = new Point(845, 466);
			this.mchkBestellkennzeichen.Name = "mchkBestellkennzeichen";
			this.mchkBestellkennzeichen.Size = new Size(217, 19);
			this.mchkBestellkennzeichen.TabIndex = 6;
			this.mchkBestellkennzeichen.Text = "als Bestellung drucken/versenden";
			this.mToolTip.SetToolTip(this.mchkBestellkennzeichen, "Dieses Angebot als Bestellung kennzeichnen");
			this.mchkBestellkennzeichen.UseSelectable = true;
			// 
			// btnMailToUser
			// 
			this.btnMailToUser.BackColor = Color.Transparent;
			this.btnMailToUser.FlatAppearance.BorderSize = 0;
			this.btnMailToUser.FlatStyle = FlatStyle.Flat;
			this.btnMailToUser.Image = Properties.Resources.mail_32_metrogreen;
			this.btnMailToUser.Location = new Point(217, 100);
			this.btnMailToUser.Margin = new Padding(3, 20, 20, 3);
			this.btnMailToUser.Name = "btnMailToUser";
			this.btnMailToUser.Size = new Size(36, 36);
			this.btnMailToUser.TabIndex = 65;
			this.btnMailToUser.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnMailToUser, "Sendet das Angebot als Bestellung an einen Kollegen");
			this.btnMailToUser.UseVisualStyleBackColor = false;
			this.btnMailToUser.Click += new System.EventHandler(this.btnMailToUser_Click);
			// 
			// btnMailToCustomer
			// 
			this.btnMailToCustomer.BackColor = Color.Transparent;
			this.btnMailToCustomer.FlatAppearance.BorderSize = 0;
			this.btnMailToCustomer.FlatStyle = FlatStyle.Flat;
			this.btnMailToCustomer.Image = Properties.Resources.email_32_metrogreen;
			this.btnMailToCustomer.Location = new Point(158, 100);
			this.btnMailToCustomer.Margin = new Padding(3, 20, 20, 3);
			this.btnMailToCustomer.Name = "btnMailToCustomer";
			this.btnMailToCustomer.Size = new Size(36, 36);
			this.btnMailToCustomer.TabIndex = 64;
			this.btnMailToCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnMailToCustomer, "Sendet das Angebot als E-Mail Anhang an den Kunden");
			this.btnMailToCustomer.UseVisualStyleBackColor = false;
			this.btnMailToCustomer.Click += new System.EventHandler(this.btnMailToCustomer_Click);
			// 
			// btnRechner
			// 
			this.btnRechner.BackColor = Color.Transparent;
			this.btnRechner.FlatAppearance.BorderSize = 0;
			this.btnRechner.FlatStyle = FlatStyle.Flat;
			this.btnRechner.Image = Properties.Resources.calc_32_metrolime;
			this.btnRechner.Location = new Point(276, 100);
			this.btnRechner.Margin = new Padding(3, 20, 20, 3);
			this.btnRechner.Name = "btnRechner";
			this.btnRechner.Size = new Size(36, 36);
			this.btnRechner.TabIndex = 5;
			this.btnRechner.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnRechner, "Taschenrechner");
			this.btnRechner.UseVisualStyleBackColor = false;
			this.btnRechner.Click += new System.EventHandler(this.btnRechner_Click);
			// 
			// btnDrucken
			// 
			this.btnDrucken.BackColor = Color.Transparent;
			this.btnDrucken.FlatAppearance.BorderSize = 0;
			this.btnDrucken.FlatStyle = FlatStyle.Flat;
			this.btnDrucken.Image = Properties.Resources.print_32_metrolime;
			this.btnDrucken.Location = new Point(99, 100);
			this.btnDrucken.Margin = new Padding(3, 20, 20, 3);
			this.btnDrucken.Name = "btnDrucken";
			this.btnDrucken.Size = new Size(36, 36);
			this.btnDrucken.TabIndex = 4;
			this.btnDrucken.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnDrucken, "Angebot drucken");
			this.btnDrucken.UseVisualStyleBackColor = false;
			this.btnDrucken.Click += new System.EventHandler(this.btnDrucken_Click);
			// 
			// btnPositionLoeschen
			// 
			this.btnPositionLoeschen.BackColor = Color.Transparent;
			this.btnPositionLoeschen.FlatAppearance.BorderSize = 0;
			this.btnPositionLoeschen.FlatStyle = FlatStyle.Flat;
			this.btnPositionLoeschen.Image = Properties.Resources.garbage_32_metrolime;
			this.btnPositionLoeschen.Location = new Point(1204, 100);
			this.btnPositionLoeschen.Margin = new Padding(3, 20, 20, 3);
			this.btnPositionLoeschen.Name = "btnPositionLoeschen";
			this.btnPositionLoeschen.Size = new Size(36, 36);
			this.btnPositionLoeschen.TabIndex = 3;
			this.btnPositionLoeschen.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnPositionLoeschen, "Position löschen");
			this.btnPositionLoeschen.UseVisualStyleBackColor = false;
			this.btnPositionLoeschen.Click += new System.EventHandler(this.btnPositionLoeschen_Click);
			// 
			// btnNeuePosition
			// 
			this.btnNeuePosition.BackColor = Color.Transparent;
			this.btnNeuePosition.FlatAppearance.BorderSize = 0;
			this.btnNeuePosition.FlatStyle = FlatStyle.Flat;
			this.btnNeuePosition.Image = Properties.Resources.neu_metrolime;
			this.btnNeuePosition.Location = new Point(40, 100);
			this.btnNeuePosition.Margin = new Padding(20, 20, 20, 3);
			this.btnNeuePosition.Name = "btnNeuePosition";
			this.btnNeuePosition.Size = new Size(36, 36);
			this.btnNeuePosition.TabIndex = 2;
			this.btnNeuePosition.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mToolTip.SetToolTip(this.btnNeuePosition, "Neue Position");
			this.btnNeuePosition.UseVisualStyleBackColor = false;
			this.btnNeuePosition.Click += new System.EventHandler(this.btnNeuePosition_Click);
			// 
			// ctxForm
			// 
			this.ctxForm.Items.AddRange(new ToolStripItem[] {
						this.ccmdPrint,
						this.mcmdMailToCustomer,
						this.mcmdMailToUser});
			this.ctxForm.Name = "ctxForm";
			this.ctxForm.Size = new Size(249, 70);
			// 
			// ccmdPrint
			// 
			this.ccmdPrint.Image = Properties.Resources.print_16_metrolime;
			this.ccmdPrint.Name = "ccmdPrint";
			this.ccmdPrint.ShortcutKeyDisplayString = "(Strg+P)";
			this.ccmdPrint.Size = new Size(248, 22);
			this.ccmdPrint.Text = "Drucken";
			this.ccmdPrint.Click += new System.EventHandler(this.ccmdPrint_Click);
			// 
			// mcmdMailToCustomer
			// 
			this.mcmdMailToCustomer.Image = Properties.Resources.email_16_metrogreen;
			this.mcmdMailToCustomer.Name = "mcmdMailToCustomer";
			this.mcmdMailToCustomer.Size = new Size(248, 22);
			this.mcmdMailToCustomer.Text = "Per E-Mail zum Kunden";
			this.mcmdMailToCustomer.Click += new System.EventHandler(this.mcmdMailToCustomer_Click);
			// 
			// mcmdMailToUser
			// 
			this.mcmdMailToUser.Image = Properties.Resources.mail_16_metrolime;
			this.mcmdMailToUser.Name = "mcmdMailToUser";
			this.mcmdMailToUser.Size = new Size(248, 22);
			this.mcmdMailToUser.Text = "Als Bestellung zu einem Kollegen";
			this.mcmdMailToUser.Click += new System.EventHandler(this.mcmdMailToUser_Click);
			// 
			// txtPositionsinfo
			// 
			this.txtPositionsinfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			// 
			// 
			// 
			this.txtPositionsinfo.CustomButton.Image = null;
			this.txtPositionsinfo.CustomButton.Location = new Point(149, 2);
			this.txtPositionsinfo.CustomButton.Name = "";
			this.txtPositionsinfo.CustomButton.Size = new Size(259, 259);
			this.txtPositionsinfo.CustomButton.Style = MetroColorStyle.Blue;
			this.txtPositionsinfo.CustomButton.TabIndex = 1;
			this.txtPositionsinfo.CustomButton.Theme = MetroThemeStyle.Light;
			this.txtPositionsinfo.CustomButton.UseSelectable = true;
			this.txtPositionsinfo.CustomButton.Visible = false;
			this.txtPositionsinfo.Enabled = false;
			this.txtPositionsinfo.FontWeight = MetroTextBoxWeight.Light;
			this.txtPositionsinfo.Lines = new string[0];
			this.txtPositionsinfo.Location = new Point(845, 491);
			this.txtPositionsinfo.MaxLength = 32767;
			this.txtPositionsinfo.Multiline = true;
			this.txtPositionsinfo.Name = "txtPositionsinfo";
			this.txtPositionsinfo.PasswordChar = '\0';
			this.txtPositionsinfo.ScrollBars = ScrollBars.None;
			this.txtPositionsinfo.SelectedText = "";
			this.txtPositionsinfo.SelectionLength = 0;
			this.txtPositionsinfo.SelectionStart = 0;
			this.txtPositionsinfo.Size = new Size(411, 264);
			this.txtPositionsinfo.TabIndex = 7;
			this.txtPositionsinfo.TabStop = false;
			this.txtPositionsinfo.UseSelectable = true;
			this.txtPositionsinfo.WaterMarkColor = Color.FromArgb((109), (109), (109));
			this.txtPositionsinfo.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
			// 
			// txtRowComment
			// 
			this.txtRowComment.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
			// 
			// 
			// 
			this.txtRowComment.CustomButton.Image = null;
			this.txtRowComment.CustomButton.Location = new Point(429, 1);
			this.txtRowComment.CustomButton.Name = "";
			this.txtRowComment.CustomButton.Size = new Size(163, 163);
			this.txtRowComment.CustomButton.Style = MetroColorStyle.Blue;
			this.txtRowComment.CustomButton.TabIndex = 1;
			this.txtRowComment.CustomButton.Theme = MetroThemeStyle.Light;
			this.txtRowComment.CustomButton.UseSelectable = true;
			this.txtRowComment.CustomButton.Visible = false;
			this.txtRowComment.FontWeight = MetroTextBoxWeight.Light;
			this.txtRowComment.Lines = new string[0];
			this.txtRowComment.Location = new Point(23, 488);
			this.txtRowComment.Margin = new Padding(3, 3, 15, 3);
			this.txtRowComment.MaxLength = 2000;
			this.txtRowComment.Multiline = true;
			this.txtRowComment.Name = "txtRowComment";
			this.txtRowComment.PasswordChar = '\0';
			this.txtRowComment.ScrollBars = ScrollBars.Both;
			this.txtRowComment.SelectedText = "";
			this.txtRowComment.SelectionLength = 0;
			this.txtRowComment.SelectionStart = 0;
			this.txtRowComment.Size = new Size(593, 165);
			this.txtRowComment.TabIndex = 1;
			this.txtRowComment.UseSelectable = true;
			this.txtRowComment.WaterMarkColor = Color.FromArgb((109), (109), (109));
			this.txtRowComment.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
			// 
			// mlblPositionstext
			// 
			this.mlblPositionstext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.mlblPositionstext.AutoSize = true;
			this.mlblPositionstext.Location = new Point(23, 466);
			this.mlblPositionstext.Name = "mlblPositionstext";
			this.mlblPositionstext.Size = new Size(80, 19);
			this.mlblPositionstext.TabIndex = 63;
			this.mlblPositionstext.Text = "Positionstext";
			// 
			// mtxtZahlungsbedingungen
			// 
			this.mtxtZahlungsbedingungen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			// 
			// 
			// 
			this.mtxtZahlungsbedingungen.CustomButton.Image = null;
			this.mtxtZahlungsbedingungen.CustomButton.Location = new Point(531, 2);
			this.mtxtZahlungsbedingungen.CustomButton.Name = "";
			this.mtxtZahlungsbedingungen.CustomButton.Size = new Size(59, 59);
			this.mtxtZahlungsbedingungen.CustomButton.Style = MetroColorStyle.Blue;
			this.mtxtZahlungsbedingungen.CustomButton.TabIndex = 1;
			this.mtxtZahlungsbedingungen.CustomButton.Theme = MetroThemeStyle.Light;
			this.mtxtZahlungsbedingungen.CustomButton.UseSelectable = true;
			this.mtxtZahlungsbedingungen.CustomButton.Visible = false;
			this.mtxtZahlungsbedingungen.FontSize = MetroTextBoxSize.Medium;
			this.mtxtZahlungsbedingungen.FontWeight = MetroTextBoxWeight.Light;
			this.mtxtZahlungsbedingungen.Lines = new string[] {
				"Zahlungsbedingungen"};
			this.mtxtZahlungsbedingungen.Location = new Point(23, 691);
			this.mtxtZahlungsbedingungen.MaxLength = 250;
			this.mtxtZahlungsbedingungen.Multiline = true;
			this.mtxtZahlungsbedingungen.Name = "mtxtZahlungsbedingungen";
			this.mtxtZahlungsbedingungen.PasswordChar = '\0';
			this.mtxtZahlungsbedingungen.ScrollBars = ScrollBars.None;
			this.mtxtZahlungsbedingungen.SelectedText = "";
			this.mtxtZahlungsbedingungen.SelectionLength = 0;
			this.mtxtZahlungsbedingungen.SelectionStart = 0;
			this.mtxtZahlungsbedingungen.Size = new Size(593, 64);
			this.mtxtZahlungsbedingungen.TabIndex = 66;
			this.mtxtZahlungsbedingungen.Text = "Zahlungsbedingungen";
			this.mtxtZahlungsbedingungen.UseSelectable = true;
			this.mtxtZahlungsbedingungen.WaterMarkColor = Color.FromArgb((109), (109), (109));
			this.mtxtZahlungsbedingungen.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
			// 
			// mlblZahlungsbedingungen
			// 
			this.mlblZahlungsbedingungen.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.mlblZahlungsbedingungen.AutoSize = true;
			this.mlblZahlungsbedingungen.Location = new Point(23, 669);
			this.mlblZahlungsbedingungen.Name = "mlblZahlungsbedingungen";
			this.mlblZahlungsbedingungen.Size = new Size(138, 19);
			this.mlblZahlungsbedingungen.TabIndex = 67;
			this.mlblZahlungsbedingungen.Text = "Zahlungsbedingungen";
			// 
			// colActive
			// 
			this.colActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colActive.DataPropertyName = "Active";
			this.colActive.FillWeight = 5F;
			this.colActive.HeaderText = "Aktiv";
			this.colActive.Name = "colActive";
			this.colActive.Resizable = DataGridViewTriState.True;
			this.colActive.SortMode = DataGridViewColumnSortMode.Automatic;
			this.colActive.ToolTipText = "Deaktiviert = Alternativposition";
			// 
			// colPosIndex
			// 
			this.colPosIndex.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colPosIndex.DataPropertyName = "Position";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.colPosIndex.DefaultCellStyle = dataGridViewCellStyle3;
			this.colPosIndex.FillWeight = 5F;
			this.colPosIndex.HeaderText = "Pos.";
			this.colPosIndex.Name = "colPosIndex";
			// 
			// colProductId
			// 
			this.colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colProductId.DataPropertyName = "Artikelnummer";
			this.colProductId.FillWeight = 15F;
			this.colProductId.HeaderText = "Art.-Nr.";
			this.colProductId.Name = "colProductId";
			this.colProductId.ReadOnly = true;
			// 
			// colProductName
			// 
			this.colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colProductName.DataPropertyName = "Artikelname";
			this.colProductName.FillWeight = 15F;
			this.colProductName.HeaderText = "Bezeichnung";
			this.colProductName.Name = "colProductName";
			// 
			// colQuantity
			// 
			this.colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colQuantity.DataPropertyName = "Menge";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = null;
			this.colQuantity.DefaultCellStyle = dataGridViewCellStyle4;
			this.colQuantity.FillWeight = 5F;
			this.colQuantity.HeaderText = "Menge";
			this.colQuantity.Name = "colQuantity";
			// 
			// colUnit
			// 
			this.colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colUnit.DataPropertyName = "Einheit";
			this.colUnit.FillWeight = 5F;
			this.colUnit.HeaderText = "ME";
			this.colUnit.Name = "colUnit";
			this.colUnit.ToolTipText = "Mengeneinheit";
			// 
			// colEK
			// 
			this.colEK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colEK.DataPropertyName = "MittlererEK";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.colEK.DefaultCellStyle = dataGridViewCellStyle5;
			this.colEK.FillWeight = 8F;
			this.colEK.HeaderText = "EK";
			this.colEK.Name = "colEK";
			this.colEK.ToolTipText = "Einkaufspreis";
			// 
			// colUnitPrice
			// 
			this.colUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colUnitPrice.DataPropertyName = "Einzelpreis";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Format = "C2";
			dataGridViewCellStyle6.NullValue = null;
			this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
			this.colUnitPrice.FillWeight = 8F;
			this.colUnitPrice.HeaderText = "Einzelpreis";
			this.colUnitPrice.Name = "colUnitPrice";
			// 
			// colRabattbetrag
			// 
			this.colRabattbetrag.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colRabattbetrag.DataPropertyName = "Rabattbetrag";
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "C2";
			dataGridViewCellStyle7.NullValue = null;
			this.colRabattbetrag.DefaultCellStyle = dataGridViewCellStyle7;
			this.colRabattbetrag.FillWeight = 8F;
			this.colRabattbetrag.HeaderText = "Rabatt";
			this.colRabattbetrag.Name = "colRabattbetrag";
			// 
			// colDiscountPercent
			// 
			this.colDiscountPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colDiscountPercent.DataPropertyName = "RabattProzent";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N2";
			dataGridViewCellStyle8.NullValue = null;
			this.colDiscountPercent.DefaultCellStyle = dataGridViewCellStyle8;
			this.colDiscountPercent.FillWeight = 8F;
			this.colDiscountPercent.HeaderText = "Rabatt (%)";
			this.colDiscountPercent.Name = "colDiscountPercent";
			// 
			// colUnitPriceCustomer
			// 
			this.colUnitPriceCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colUnitPriceCustomer.DataPropertyName = "Kundenpreis";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "C2";
			dataGridViewCellStyle9.NullValue = null;
			this.colUnitPriceCustomer.DefaultCellStyle = dataGridViewCellStyle9;
			this.colUnitPriceCustomer.FillWeight = 8F;
			this.colUnitPriceCustomer.HeaderText = "Kundenpreis";
			this.colUnitPriceCustomer.Name = "colUnitPriceCustomer";
			this.colUnitPriceCustomer.ReadOnly = true;
			// 
			// colRowTotal
			// 
			this.colRowTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colRowTotal.DataPropertyName = "Zeilensumme";
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "C2";
			dataGridViewCellStyle10.NullValue = null;
			this.colRowTotal.DefaultCellStyle = dataGridViewCellStyle10;
			this.colRowTotal.FillWeight = 8F;
			this.colRowTotal.HeaderText = "Gesamtpreis";
			this.colRowTotal.Name = "colRowTotal";
			this.colRowTotal.ReadOnly = true;
			// 
			// colKatalogHeader
			// 
			this.colKatalogHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colKatalogHeader.DataPropertyName = "KatalogHeader";
			this.colKatalogHeader.FillWeight = 10F;
			this.colKatalogHeader.HeaderText = "Überschrift";
			this.colKatalogHeader.Name = "colKatalogHeader";
			// 
			// colNeueSeite
			// 
			this.colNeueSeite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colNeueSeite.DataPropertyName = "NeueSeite";
			this.colNeueSeite.FillWeight = 7F;
			this.colNeueSeite.HeaderText = "Neue Seite";
			this.colNeueSeite.Name = "colNeueSeite";
			this.colNeueSeite.ToolTipText = "Druckt diese Position auf einer neuen Seite";
			// 
			// pnlAngebotsdetail
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ContextMenuStrip = this.ctxForm;
			this.Controls.Add(this.mlblZahlungsbedingungen);
			this.Controls.Add(this.mtxtZahlungsbedingungen);
			this.Controls.Add(this.btnMailToUser);
			this.Controls.Add(this.btnMailToCustomer);
			this.Controls.Add(this.mlblPositionstext);
			this.Controls.Add(this.mchkBestellkennzeichen);
			this.Controls.Add(this.txtPositionsinfo);
			this.Controls.Add(this.txtRowComment);
			this.Controls.Add(this.btnRechner);
			this.Controls.Add(this.btnDrucken);
			this.Controls.Add(this.btnPositionLoeschen);
			this.Controls.Add(this.btnNeuePosition);
			this.Controls.Add(this.dgvOfferDetails);
			this.Controls.Add(this.mlblTitle);
			this.Margin = new Padding(4, 5, 4, 5);
			this.Name = "pnlAngebotsdetail";
			this.Padding = new Padding(20);
			this.Size = new Size(1280, 778);
			((System.ComponentModel.ISupportInitialize)(this.dgvOfferDetails)).EndInit();
			this.ctxGrid.ResumeLayout(false);
			this.ctxForm.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroLabel mlblTitle;
		MetroGrid dgvOfferDetails;
		Button btnNeuePosition;
		Button btnPositionLoeschen;
		Button btnDrucken;
		Button btnRechner;
		MetroToolTip mToolTip;
		MetroContextMenu ctxGrid;
		ToolStripMenuItem ccmdNewDetail;
		ToolStripMenuItem ccmdDeleteDetail;
		ToolStripMenuItem ccmdPrint2;
		MetroContextMenu ctxForm;
		ToolStripMenuItem ccmdPrint;
		MetroTextBox txtPositionsinfo;
		MetroTextBox txtRowComment;
		MetroCheckBox mchkBestellkennzeichen;
		ToolStripMenuItem ccmdTaschenrechner;
		MetroLabel mlblPositionstext;
		Button btnMailToCustomer;
		ToolStripMenuItem mcmdMailToCustomer;
		ToolStripMenuItem mcmdMailToUser;
		Button btnMailToUser;
		MetroTextBox mtxtZahlungsbedingungen;
		MetroLabel mlblZahlungsbedingungen;
		ToolStripSeparator nachObenToolStripMenuItem;
		ToolStripMenuItem xcmdMoveUp;
		ToolStripMenuItem xcmdMoveDown;
		ToolStripSeparator toolStripMenuItem2;
		private DataGridViewCheckBoxColumn colActive;
		private DataGridViewTextBoxColumn colPosIndex;
		private DataGridViewTextBoxColumn colProductId;
		private DataGridViewTextBoxColumn colProductName;
		private DataGridViewTextBoxColumn colQuantity;
		private DataGridViewTextBoxColumn colUnit;
		private DataGridViewTextBoxColumn colEK;
		private DataGridViewTextBoxColumn colUnitPrice;
		private DataGridViewTextBoxColumn colRabattbetrag;
		private DataGridViewTextBoxColumn colDiscountPercent;
		private DataGridViewTextBoxColumn colUnitPriceCustomer;
		private DataGridViewTextBoxColumn colRowTotal;
		private DataGridViewTextBoxColumn colKatalogHeader;
		private DataGridViewCheckBoxColumn colNeueSeite;
	}
}
