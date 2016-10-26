namespace Products.Common.Views
{
	partial class SelectUsersView
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
			this.chkListUsers = new System.Windows.Forms.CheckedListBox();
			this.mbtnOk = new MetroFramework.Controls.MetroButton();
			this.mbtnCancel = new MetroFramework.Controls.MetroButton();
			this.mchkToggleSelectAll = new MetroFramework.Controls.MetroCheckBox();
			this.SuspendLayout();
			// 
			// chkListUsers
			// 
			this.chkListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chkListUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chkListUsers.CheckOnClick = true;
			this.chkListUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkListUsers.FormattingEnabled = true;
			this.chkListUsers.Location = new System.Drawing.Point(50, 144);
			this.chkListUsers.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
			this.chkListUsers.Name = "chkListUsers";
			this.chkListUsers.Size = new System.Drawing.Size(322, 374);
			this.chkListUsers.TabIndex = 0;
			this.chkListUsers.ThreeDCheckBoxes = true;
			// 
			// mbtnOk
			// 
			this.mbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnOk.Location = new System.Drawing.Point(159, 552);
			this.mbtnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this.mbtnOk.Name = "mbtnOk";
			this.mbtnOk.Size = new System.Drawing.Size(100, 29);
			this.mbtnOk.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnOk.TabIndex = 1;
			this.mbtnOk.Text = "OK";
			this.mbtnOk.UseSelectable = true;
			this.mbtnOk.UseStyleColors = true;
			this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
			// 
			// mbtnCancel
			// 
			this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtnCancel.Location = new System.Drawing.Point(272, 552);
			this.mbtnCancel.Name = "mbtnCancel";
			this.mbtnCancel.Size = new System.Drawing.Size(100, 29);
			this.mbtnCancel.Style = MetroFramework.MetroColorStyle.Orange;
			this.mbtnCancel.TabIndex = 2;
			this.mbtnCancel.Text = "Abbrechen";
			this.mbtnCancel.UseSelectable = true;
			this.mbtnCancel.UseStyleColors = true;
			// 
			// mchkToggleSelectAll
			// 
			this.mchkToggleSelectAll.AutoSize = true;
			this.mchkToggleSelectAll.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.mchkToggleSelectAll.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
			this.mchkToggleSelectAll.Location = new System.Drawing.Point(23, 100);
			this.mchkToggleSelectAll.Name = "mchkToggleSelectAll";
			this.mchkToggleSelectAll.Size = new System.Drawing.Size(110, 19);
			this.mchkToggleSelectAll.Style = MetroFramework.MetroColorStyle.Orange;
			this.mchkToggleSelectAll.TabIndex = 3;
			this.mchkToggleSelectAll.Text = "Alle auswählen";
			this.mchkToggleSelectAll.UseSelectable = true;
			this.mchkToggleSelectAll.UseStyleColors = true;
			this.mchkToggleSelectAll.CheckedChanged += new System.EventHandler(this.mchkToggleSelectAll_CheckedChanged);
			// 
			// SelectUsersView
			// 
			this.AcceptButton = this.mbtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnCancel;
			this.ClientSize = new System.Drawing.Size(395, 604);
			this.ControlBox = false;
			this.Controls.Add(this.mchkToggleSelectAll);
			this.Controls.Add(this.mbtnCancel);
			this.Controls.Add(this.mbtnOk);
			this.Controls.Add(this.chkListUsers);
			this.Name = "SelectUsersView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Mitarbeiterauswahl";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox chkListUsers;
		private MetroFramework.Controls.MetroButton mbtnOk;
		private MetroFramework.Controls.MetroButton mbtnCancel;
		private MetroFramework.Controls.MetroCheckBox mchkToggleSelectAll;
	}
}