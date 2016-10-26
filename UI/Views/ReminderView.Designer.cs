namespace Products.Common.Views
{
	partial class ReminderView
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
			this.mlblDescription = new MetroFramework.Controls.MetroLabel();
			this.mbtRemindAgain = new MetroFramework.Controls.MetroButton();
			this.mbtnDiscard = new MetroFramework.Controls.MetroButton();
			this.mcmbRemindMeIn = new MetroFramework.Controls.MetroComboBox();
			this.mbtnShowTask = new MetroFramework.Controls.MetroButton();
			this.mbtnShowReminder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mlblDescription
			// 
			this.mlblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mlblDescription.Location = new System.Drawing.Point(23, 100);
			this.mlblDescription.Name = "mlblDescription";
			this.mlblDescription.Size = new System.Drawing.Size(411, 61);
			this.mlblDescription.TabIndex = 0;
			this.mlblDescription.Text = "Erinnerungstext";
			// 
			// mbtRemindAgain
			// 
			this.mbtRemindAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtRemindAgain.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtRemindAgain.Location = new System.Drawing.Point(23, 226);
			this.mbtRemindAgain.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.mbtRemindAgain.Name = "mbtRemindAgain";
			this.mbtRemindAgain.Size = new System.Drawing.Size(133, 30);
			this.mbtRemindAgain.Style = MetroFramework.MetroColorStyle.Green;
			this.mbtRemindAgain.TabIndex = 29;
			this.mbtRemindAgain.Text = "Nochmal erinnern";
			this.mbtRemindAgain.UseSelectable = true;
			this.mbtRemindAgain.UseStyleColors = true;
			this.mbtRemindAgain.Click += new System.EventHandler(this.mbtRemindAgain_Click);
			// 
			// mbtnDiscard
			// 
			this.mbtnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtnDiscard.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnDiscard.Location = new System.Drawing.Point(301, 226);
			this.mbtnDiscard.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.mbtnDiscard.Name = "mbtnDiscard";
			this.mbtnDiscard.Size = new System.Drawing.Size(133, 30);
			this.mbtnDiscard.Style = MetroFramework.MetroColorStyle.Green;
			this.mbtnDiscard.TabIndex = 30;
			this.mbtnDiscard.Text = "Danke, das war\'s";
			this.mbtnDiscard.UseSelectable = true;
			this.mbtnDiscard.UseStyleColors = true;
			this.mbtnDiscard.Click += new System.EventHandler(this.mbtnDiscard_Click);
			// 
			// mcmbRemindMeIn
			// 
			this.mcmbRemindMeIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mcmbRemindMeIn.FormattingEnabled = true;
			this.mcmbRemindMeIn.ItemHeight = 23;
			this.mcmbRemindMeIn.Items.AddRange(new object[] {
            "5 Minuten",
            "10 Minuten",
            "20 Minuten",
            "30 Minuten",
            "1 Stunde"});
			this.mcmbRemindMeIn.Location = new System.Drawing.Point(23, 174);
			this.mcmbRemindMeIn.Name = "mcmbRemindMeIn";
			this.mcmbRemindMeIn.Size = new System.Drawing.Size(411, 29);
			this.mcmbRemindMeIn.TabIndex = 31;
			this.mcmbRemindMeIn.UseSelectable = true;
			// 
			// mbtnShowTask
			// 
			this.mbtnShowTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtnShowTask.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtnShowTask.Location = new System.Drawing.Point(162, 226);
			this.mbtnShowTask.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.mbtnShowTask.Name = "mbtnShowTask";
			this.mbtnShowTask.Size = new System.Drawing.Size(133, 30);
			this.mbtnShowTask.Style = MetroFramework.MetroColorStyle.Green;
			this.mbtnShowTask.TabIndex = 32;
			this.mbtnShowTask.Text = "Aufgabe anzeigen";
			this.mbtnShowTask.UseSelectable = true;
			this.mbtnShowTask.UseStyleColors = true;
			this.mbtnShowTask.Click += new System.EventHandler(this.mbtnShowTask_Click);
			// 
			// mbtnShowReminder
			// 
			this.mbtnShowReminder.BackColor = System.Drawing.Color.Transparent;
			this.mbtnShowReminder.FlatAppearance.BorderSize = 0;
			this.mbtnShowReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbtnShowReminder.Image = global::Products.Common.Properties.Resources.alarm_32_metrogreen;
			this.mbtnShowReminder.Location = new System.Drawing.Point(400, 18);
			this.mbtnShowReminder.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
			this.mbtnShowReminder.Name = "mbtnShowReminder";
			this.mbtnShowReminder.Size = new System.Drawing.Size(36, 36);
			this.mbtnShowReminder.TabIndex = 33;
			this.mbtnShowReminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtnShowReminder.UseVisualStyleBackColor = false;
			// 
			// ReminderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtnDiscard;
			this.ClientSize = new System.Drawing.Size(457, 279);
			this.ControlBox = false;
			this.Controls.Add(this.mbtnShowReminder);
			this.Controls.Add(this.mbtnShowTask);
			this.Controls.Add(this.mcmbRemindMeIn);
			this.Controls.Add(this.mbtnDiscard);
			this.Controls.Add(this.mbtRemindAgain);
			this.Controls.Add(this.mlblDescription);
			this.Name = "ReminderView";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "So, ist 12.00 Uhr jetzt!";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel mlblDescription;
		private MetroFramework.Controls.MetroButton mbtRemindAgain;
		private MetroFramework.Controls.MetroButton mbtnDiscard;
		private MetroFramework.Controls.MetroComboBox mcmbRemindMeIn;
		private MetroFramework.Controls.MetroButton mbtnShowTask;
		private System.Windows.Forms.Button mbtnShowReminder;
	}
}