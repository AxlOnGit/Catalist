namespace Products.Common.Views
{
    partial class DialogNewMachine
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
        private void InitializeComponent()
        {
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.cmbMachineModel = new MetroFramework.Controls.MetroComboBox();
            this.mtxtSerialNumber = new MetroFramework.Controls.MetroTextBox();
            this.mbtnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(188, 205);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(100, 26);
            this.mbtnCancel.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbtnCancel.TabIndex = 0;
            this.mbtnCancel.Text = "Abbrechen";
            this.mbtnCancel.UseCustomBackColor = true;
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.UseStyleColors = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 116;
            this.label2.Text = "Seriennummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 115;
            this.label1.Text = "Maschinenmodell:";
            // 
            // cmbMachineModel
            // 
            this.cmbMachineModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMachineModel.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cmbMachineModel.FormattingEnabled = true;
            this.cmbMachineModel.ItemHeight = 23;
            this.cmbMachineModel.Location = new System.Drawing.Point(143, 100);
            this.cmbMachineModel.Name = "cmbMachineModel";
            this.cmbMachineModel.Size = new System.Drawing.Size(187, 29);
            this.cmbMachineModel.TabIndex = 113;
            this.cmbMachineModel.UseSelectable = true;
            this.cmbMachineModel.SelectedValueChanged += new System.EventHandler(this.cmbMachineModel_SelectedValueChanged);
            // 
            // mtxtSerialNumber
            // 
            this.mtxtSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtSerialNumber.CustomButton.Image = null;
            this.mtxtSerialNumber.CustomButton.Location = new System.Drawing.Point(159, 1);
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
            this.mtxtSerialNumber.Location = new System.Drawing.Point(143, 135);
            this.mtxtSerialNumber.MaxLength = 32767;
            this.mtxtSerialNumber.Multiline = true;
            this.mtxtSerialNumber.Name = "mtxtSerialNumber";
            this.mtxtSerialNumber.PasswordChar = '\0';
            this.mtxtSerialNumber.PromptText = "SN";
            this.mtxtSerialNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSerialNumber.SelectedText = "";
            this.mtxtSerialNumber.SelectionLength = 0;
            this.mtxtSerialNumber.SelectionStart = 0;
            this.mtxtSerialNumber.ShortcutsEnabled = true;
            this.mtxtSerialNumber.Size = new System.Drawing.Size(187, 29);
            this.mtxtSerialNumber.TabIndex = 114;
            this.mtxtSerialNumber.UseSelectable = true;
            this.mtxtSerialNumber.WaterMark = "SN";
            this.mtxtSerialNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSerialNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.mtxtSerialNumber.Validated += new System.EventHandler(this.mtxtSerialNumber_Validated);
            // 
            // mbtnOK
            // 
            this.mbtnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mbtnOK.Location = new System.Drawing.Point(65, 205);
            this.mbtnOK.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(100, 26);
            this.mbtnOK.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbtnOK.TabIndex = 117;
            this.mbtnOK.Text = "OK";
            this.mbtnOK.UseCustomBackColor = true;
            this.mbtnOK.UseSelectable = true;
            this.mbtnOK.UseStyleColors = true;
            this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
            // 
            // DialogNewMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 254);
            this.Controls.Add(this.mbtnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMachineModel);
            this.Controls.Add(this.mtxtSerialNumber);
            this.Controls.Add(this.mbtnCancel);
            this.Name = "DialogNewMachine";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Neue Maschine";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroComboBox cmbMachineModel;
        private MetroFramework.Controls.MetroTextBox mtxtSerialNumber;
        private MetroFramework.Controls.MetroButton mbtnOK;
    }
}