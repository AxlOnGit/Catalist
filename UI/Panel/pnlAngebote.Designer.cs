using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace Products.Common.Panel
{
	partial class pnlAngebote
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.dgvOffers = new MetroGrid();
			this.colBestellkennzeichen = new DataGridViewCheckBoxColumn();
			this.colOfferId = new DataGridViewTextBoxColumn();
			this.colCreatedDate = new DataGridViewTextBoxColumn();
			this.colCreateUser = new DataGridViewTextBoxColumn();
			this.colChangeDate = new DataGridViewTextBoxColumn();
			this.colChangeUser = new DataGridViewTextBoxColumn();
			this.colComments = new DataGridViewTextBoxColumn();
			this.mctxGrid = new MetroContextMenu(this.components);
			this.mcmdAngebotAnzeigen = new ToolStripMenuItem();
			this.mcmcNeuesAngebot = new ToolStripMenuItem();
			this.txtAngebotsinfo = new MetroTextBox();
			this.metroLabel1 = new MetroLabel();
			this.mtoolTipMain = new MetroFramework.Components.MetroToolTip();
			this.btnNeuesAngebot = new Button();
			this.btnAngebotAnzeigen = new Button();
			this.btnAngebotLoeschen = new Button();
			this.mcmdDeleteAngebot = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
			this.mctxGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOffers
			// 
			this.dgvOffers.AllowUserToAddRows = false;
			this.dgvOffers.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
			this.dgvOffers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvOffers.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
			this.dgvOffers.BackgroundColor = Color.FromArgb(255, 255, 255);
			this.dgvOffers.BorderStyle = BorderStyle.None;
			this.dgvOffers.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.dgvOffers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(142, 188, 0);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(215, 255, 91);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dgvOffers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvOffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOffers.Columns.AddRange(new DataGridViewColumn[] {
            this.colBestellkennzeichen,
            this.colOfferId,
            this.colCreatedDate,
            this.colCreateUser,
            this.colChangeDate,
            this.colChangeUser,
            this.colComments});
			this.dgvOffers.ContextMenuStrip = this.mctxGrid;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(215, 255, 91);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.dgvOffers.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvOffers.EnableHeadersVisualStyles = false;
			this.dgvOffers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			this.dgvOffers.GridColor = Color.FromArgb(255, 255, 255);
			this.dgvOffers.HighLightPercentage = 0.99F;
			this.dgvOffers.Location = new Point(22, 141);
			this.dgvOffers.Margin = new Padding(2);
			this.dgvOffers.Name = "dgvOffers";
			this.dgvOffers.ReadOnly = true;
			this.dgvOffers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(142, 188, 0);
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(215, 255, 91);
			dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.dgvOffers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvOffers.RowHeadersVisible = false;
			this.dgvOffers.RowHeadersWidth = 21;
			this.dgvOffers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvOffers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvOffers.Size = new Size(1236, 503);
			this.dgvOffers.Style = MetroFramework.MetroColorStyle.Lime;
			this.dgvOffers.TabIndex = 0;
			this.dgvOffers.RowEnter += new DataGridViewCellEventHandler(this.dgvOffers_RowEnter);
			this.dgvOffers.MouseDoubleClick += new MouseEventHandler(this.dgvOffers_MouseDoubleClick);
			// 
			// colBestellkennzeichen
			// 
			this.colBestellkennzeichen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colBestellkennzeichen.DataPropertyName = "Bestellkennzeichen";
			this.colBestellkennzeichen.FillWeight = 5F;
			this.colBestellkennzeichen.HeaderText = "Bestellung";
			this.colBestellkennzeichen.Name = "colBestellkennzeichen";
			this.colBestellkennzeichen.ReadOnly = true;
			// 
			// colOfferId
			// 
			this.colOfferId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colOfferId.DataPropertyName = "OfferId";
			this.colOfferId.FillWeight = 15F;
			this.colOfferId.HeaderText = "Angebot";
			this.colOfferId.Name = "colOfferId";
			this.colOfferId.ReadOnly = true;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colCreatedDate.DataPropertyName = "CreateDate";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.colCreatedDate.DefaultCellStyle = dataGridViewCellStyle3;
			this.colCreatedDate.FillWeight = 10F;
			this.colCreatedDate.HeaderText = "Erfasst am";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.ReadOnly = true;
			// 
			// colCreateUser
			// 
			this.colCreateUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colCreateUser.DataPropertyName = "CreateUser";
			this.colCreateUser.FillWeight = 10F;
			this.colCreateUser.HeaderText = "von";
			this.colCreateUser.Name = "colCreateUser";
			this.colCreateUser.ReadOnly = true;
			// 
			// colChangeDate
			// 
			this.colChangeDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colChangeDate.DataPropertyName = "ChangeDate";
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			this.colChangeDate.DefaultCellStyle = dataGridViewCellStyle4;
			this.colChangeDate.FillWeight = 10F;
			this.colChangeDate.HeaderText = "Geändert am";
			this.colChangeDate.Name = "colChangeDate";
			this.colChangeDate.ReadOnly = true;
			// 
			// colChangeUser
			// 
			this.colChangeUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colChangeUser.DataPropertyName = "ChangeUser";
			this.colChangeUser.FillWeight = 10F;
			this.colChangeUser.HeaderText = "von";
			this.colChangeUser.Name = "colChangeUser";
			this.colChangeUser.ReadOnly = true;
			// 
			// colComments
			// 
			this.colComments.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.colComments.DataPropertyName = "Comments";
			this.colComments.FillWeight = 40F;
			this.colComments.HeaderText = "Anmerkungen";
			this.colComments.MinimumWidth = 500;
			this.colComments.Name = "colComments";
			this.colComments.ReadOnly = true;
			// 
			// mctxGrid
			// 
			this.mctxGrid.Items.AddRange(new ToolStripItem[] {
            this.mcmdAngebotAnzeigen,
            this.mcmcNeuesAngebot,
            this.mcmdDeleteAngebot});
			this.mctxGrid.Name = "mctxGrid";
			this.mctxGrid.Size = new Size(165, 92);
			// 
			// mcmdAngebotAnzeigen
			// 
			this.mcmdAngebotAnzeigen.Image = Properties.Resources.open_16_metrolime;
			this.mcmdAngebotAnzeigen.Name = "mcmdAngebotAnzeigen";
			this.mcmdAngebotAnzeigen.Size = new Size(164, 22);
			this.mcmdAngebotAnzeigen.Text = "Angebot öffnen";
			this.mcmdAngebotAnzeigen.Click += new System.EventHandler(this.mcmdAngebotAnzeigen_Click);
			// 
			// mcmcNeuesAngebot
			// 
			this.mcmcNeuesAngebot.Image = Properties.Resources.neu_metrolime;
			this.mcmcNeuesAngebot.Name = "mcmcNeuesAngebot";
			this.mcmcNeuesAngebot.Size = new Size(164, 22);
			this.mcmcNeuesAngebot.Text = "Neues Angebot";
			this.mcmcNeuesAngebot.Click += new System.EventHandler(this.mcmcNeuesAngebot_Click);
			// 
			// txtAngebotsinfo
			// 
			this.txtAngebotsinfo.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
			// 
			// 
			// 
			this.txtAngebotsinfo.CustomButton.Image = null;
			this.txtAngebotsinfo.CustomButton.Location = new Point(172, 2);
			this.txtAngebotsinfo.CustomButton.Margin = new Padding(2);
			this.txtAngebotsinfo.CustomButton.Name = "";
			this.txtAngebotsinfo.CustomButton.Size = new Size(105, 105);
			this.txtAngebotsinfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtAngebotsinfo.CustomButton.TabIndex = 1;
			this.txtAngebotsinfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtAngebotsinfo.CustomButton.UseSelectable = true;
			this.txtAngebotsinfo.CustomButton.Visible = false;
			this.txtAngebotsinfo.Lines = new string[0];
			this.txtAngebotsinfo.Location = new Point(22, 648);
			this.txtAngebotsinfo.Margin = new Padding(2);
			this.txtAngebotsinfo.MaxLength = 32767;
			this.txtAngebotsinfo.Multiline = true;
			this.txtAngebotsinfo.Name = "txtAngebotsinfo";
			this.txtAngebotsinfo.PasswordChar = '\0';
			this.txtAngebotsinfo.ScrollBars = ScrollBars.None;
			this.txtAngebotsinfo.SelectedText = "";
			this.txtAngebotsinfo.SelectionLength = 0;
			this.txtAngebotsinfo.SelectionStart = 0;
			this.txtAngebotsinfo.Size = new Size(280, 110);
			this.txtAngebotsinfo.TabIndex = 1;
			this.txtAngebotsinfo.TabStop = false;
			this.txtAngebotsinfo.UseSelectable = true;
			this.txtAngebotsinfo.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.txtAngebotsinfo.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
			this.txtAngebotsinfo.Validated += new System.EventHandler(this.txtAngebotsinfo_Validated);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new Point(22, 20);
			this.metroLabel1.Margin = new Padding(2, 0, 2, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new Size(86, 25);
			this.metroLabel1.TabIndex = 51;
			this.metroLabel1.Text = "Angebote";
			// 
			// mtoolTipMain
			// 
			this.mtoolTipMain.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtoolTipMain.StyleManager = null;
			this.mtoolTipMain.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// btnNeuesAngebot
			// 
			this.btnNeuesAngebot.BackColor = Color.Transparent;
			this.btnNeuesAngebot.FlatAppearance.BorderSize = 0;
			this.btnNeuesAngebot.FlatStyle = FlatStyle.Flat;
			this.btnNeuesAngebot.Image = Properties.Resources.neu_metrolime;
			this.btnNeuesAngebot.Location = new Point(82, 100);
			this.btnNeuesAngebot.Margin = new Padding(3, 20, 20, 3);
			this.btnNeuesAngebot.Name = "btnNeuesAngebot";
			this.btnNeuesAngebot.Size = new Size(36, 36);
			this.btnNeuesAngebot.TabIndex = 3;
			this.btnNeuesAngebot.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mtoolTipMain.SetToolTip(this.btnNeuesAngebot, "Neues Angebot");
			this.btnNeuesAngebot.UseVisualStyleBackColor = false;
			this.btnNeuesAngebot.Click += new System.EventHandler(this.btnNeuesAngebot_Click);
			// 
			// btnAngebotAnzeigen
			// 
			this.btnAngebotAnzeigen.BackColor = Color.Transparent;
			this.btnAngebotAnzeigen.FlatAppearance.BorderSize = 0;
			this.btnAngebotAnzeigen.FlatStyle = FlatStyle.Flat;
			this.btnAngebotAnzeigen.Image = Properties.Resources.open_32_metrolime;
			this.btnAngebotAnzeigen.Location = new Point(23, 100);
			this.btnAngebotAnzeigen.Margin = new Padding(3, 20, 20, 3);
			this.btnAngebotAnzeigen.Name = "btnAngebotAnzeigen";
			this.btnAngebotAnzeigen.Size = new Size(36, 36);
			this.btnAngebotAnzeigen.TabIndex = 2;
			this.btnAngebotAnzeigen.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mtoolTipMain.SetToolTip(this.btnAngebotAnzeigen, "Angebot öffnen");
			this.btnAngebotAnzeigen.UseVisualStyleBackColor = false;
			this.btnAngebotAnzeigen.Click += new System.EventHandler(this.btnAngebotAnzeigen_Click);
			// 
			// btnAngebotLoeschen
			// 
			this.btnAngebotLoeschen.BackColor = Color.Transparent;
			this.btnAngebotLoeschen.FlatAppearance.BorderSize = 0;
			this.btnAngebotLoeschen.FlatStyle = FlatStyle.Flat;
			this.btnAngebotLoeschen.Image = Properties.Resources.garbage_32_metrolime;
			this.btnAngebotLoeschen.Location = new Point(141, 100);
			this.btnAngebotLoeschen.Margin = new Padding(3, 20, 20, 3);
			this.btnAngebotLoeschen.Name = "btnAngebotLoeschen";
			this.btnAngebotLoeschen.Size = new Size(36, 36);
			this.btnAngebotLoeschen.TabIndex = 52;
			this.btnAngebotLoeschen.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.mtoolTipMain.SetToolTip(this.btnAngebotLoeschen, "Angebot löschen");
			this.btnAngebotLoeschen.UseVisualStyleBackColor = false;
			this.btnAngebotLoeschen.Click += new System.EventHandler(this.btnAngebotLoeschen_Click);
			// 
			// mcmdDeleteAngebot
			// 
			this.mcmdDeleteAngebot.Image = Properties.Resources.garbage_16_metrolime;
			this.mcmdDeleteAngebot.Name = "mcmdDeleteAngebot";
			this.mcmdDeleteAngebot.Size = new Size(164, 22);
			this.mcmdDeleteAngebot.Text = "Angebot löschen";
			this.mcmdDeleteAngebot.Click += new System.EventHandler(this.mcmdDeleteAngebot_Click);
			// 
			// pnlAngebote
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.btnAngebotLoeschen);
			this.Controls.Add(this.btnNeuesAngebot);
			this.Controls.Add(this.btnAngebotAnzeigen);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txtAngebotsinfo);
			this.Controls.Add(this.dgvOffers);
			this.DoubleBuffered = true;
			this.Margin = new Padding(2);
			this.Name = "pnlAngebote";
			this.Padding = new Padding(20);
			this.Size = new Size(1280, 780);
			((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
			this.mctxGrid.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		MetroGrid dgvOffers;
		MetroTextBox txtAngebotsinfo;
		MetroLabel metroLabel1;
		Button btnAngebotAnzeigen;
		Button btnNeuesAngebot;
		MetroToolTip mtoolTipMain;
		MetroContextMenu mctxGrid;
		ToolStripMenuItem mcmdAngebotAnzeigen;
		ToolStripMenuItem mcmcNeuesAngebot;
		DataGridViewCheckBoxColumn colBestellkennzeichen;
		DataGridViewTextBoxColumn colOfferId;
		DataGridViewTextBoxColumn colCreatedDate;
		DataGridViewTextBoxColumn colCreateUser;
		DataGridViewTextBoxColumn colChangeDate;
		DataGridViewTextBoxColumn colChangeUser;
		DataGridViewTextBoxColumn colComments;
		Button btnAngebotLoeschen;
		ToolStripMenuItem mcmdDeleteAngebot;
	}
}
