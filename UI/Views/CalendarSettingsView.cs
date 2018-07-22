using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class CalendarSettingsView : MetroForm
	{
		#region members

		readonly CalendarSettings myCalendarSettings;

		#endregion members

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CalendarSettingsView Klasse.
		/// </summary>
		public CalendarSettingsView(CalendarSettings calendarSettings)
		{
			InitializeComponent();
			this.myCalendarSettings = calendarSettings;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region event handler

		void mbtnSetForUser_Click(object sender, EventArgs e)
		{
			var usv = new UserSearchView();
			if (usv.ShowDialog() == DialogResult.OK)
			{
				this.myCalendarSettings.SetTargetUser(usv.SelectedUser);
				this.mtxtForUser.Text = usv.SelectedUser.NameFull;
			}
		}

		void mlblAppointmentColor_Click(object sender, EventArgs e)
		{
			if (this.colorDlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				this.mlblAppointmentColor.BackColor = this.colorDlg.Color;
				this.myCalendarSettings.AppointmentColor = this.colorDlg.Color;
			}
		}

		#endregion event handler

		void InitializeData()
		{
			this.mtxtForUser.DataBindings.Add("Text", this.myCalendarSettings.TargetUser, "NameFull", true, DataSourceUpdateMode.OnPropertyChanged);
			this.mchkCustomerInfo.DataBindings.Add("Checked", this.myCalendarSettings, "AddCustomerInfo");
			this.mchkSetAddCustomerNotes.DataBindings.Add("Checked", this.myCalendarSettings, "AddCustomerNotes");
			this.mchkSetCustomerAddress.DataBindings.Add("Checked", this.myCalendarSettings, "AddCustomerAddress");
			this.mchkSetAddCustomerPriceList.DataBindings.Add("Checked", this.myCalendarSettings, "AddCustomerPriceList");
			this.mchkCreateServiceReport.DataBindings.Add("Checked", this.myCalendarSettings, "CreateServiceReport");
			this.mlblAppointmentColor.DataBindings.Add("BackColor", this.myCalendarSettings, "AppointmentColor");
		}
	}
}