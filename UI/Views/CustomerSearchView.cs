﻿using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;

namespace Products.Common.Views
{
	public partial class CustomerSearchView : MetroForm
	{
		#region MEMBERS

		dsCustomer.CustomerRow mySelectedCustomerRow;
		readonly BindingSource bs = new BindingSource();
		bool setSelectedCustomerAsCurrent;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Returns the selected customer row.
		/// </summary>
		public dsCustomer.CustomerRow SelectedCustomer
		{
			get
			{
				return this.mySelectedCustomerRow;
			}
		}

		#endregion PUBLIC PROPERTIES

		#region PRIVATE PROCEDURES

		//private DataView GridDataView
		//{
		//  get
		//  {
		//    return this.dgvCustomers.DataSource as DataView;
		//  }
		//}

		#endregion PRIVATE PROCEDURES

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerSearchView class.
		/// </summary>
		public CustomerSearchView(string titel, bool setCustomerAsCurrent)
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			this.Text = titel;
			this.setSelectedCustomerAsCurrent = setCustomerAsCurrent;

			InitializeData();
			Application.Idle += Application_Idle;
		}

		void InitializeData()
		{
			dgvCustomers.AutoGenerateColumns = false;
			bs.DataSource = DataManager.CustomerDataService.GetCustomerTable();
			this.dgvCustomers.DataSource = bs;
			bs.Filter = string.Empty;
		}

		/// <summary>
		/// Creates a new instance of the CustomerSearchView class and shows just the customers
		/// contained in the given list.
		/// </summary>
		/// <param name="customerList"></param>
		public CustomerSearchView(Products.Common.SortableBindingList<Model.Entities.Kunde> customerList)
		{
			InitializeComponent();
			dgvCustomers.AutoGenerateColumns = false;
			this.colKundennummer.DataPropertyName = "CustomerId";
			this.colName1.DataPropertyName = "CompanyName1";
			this.colName2.DataPropertyName = "CompanyName2";
			this.colStrasse.DataPropertyName = "Street";
			this.colPostleitzahl.DataPropertyName = "ZipCode";
			this.colOrt.DataPropertyName = "City";
			this.dgvCustomers.DataSource = customerList;
			//this.sourceIsSortableList = true;
		}

		#endregion ### .ctor ###

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			//mtxtFilter.ShowButton = !string.IsNullOrEmpty(bs.Filter);
			mbtnOk.Enabled = (this.mySelectedCustomerRow != null) && (dgvCustomers.Rows.Count > 0);
		}

		void txtFilter_KeyUp(object sender, KeyEventArgs e)
		{
			var outputInfo = string.Empty;
			var keyWords = mtxtFilter.Text.Split();

			foreach (string word in keyWords)
			{
				if (outputInfo.Length == 0)
				{
					outputInfo = "(Name1 LIKE '%" + word + "%' OR Name2 LIKE '%" + word + "%' OR Ort LIKE '%" + word + "%' OR Kundennummer LIKE '%" + word + "%')";
				}
				else
				{
					outputInfo += " AND (Name1 LIKE '%" + word + "%' OR Name2 LIKE '%" + word + "%' OR Ort LIKE '%" + word + "%' OR Kundennummer LIKE '%" + word + "%')";
				}
				bs.Filter = outputInfo;
				// this.GridDataView.RowFilter = outputInfo;
			}
		}

		void txtFilterList_ClearClicked()
		{
			this.bs.Filter = string.Empty;
		}

		void dgvCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			SelectCurrentCustomerAndClose();
		}

		void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			mySelectedCustomerRow = (dgvCustomers.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as dsCustomer.CustomerRow;
			if (mySelectedCustomerRow != null)
			{
				mlblSelektierterKunde.Text = mySelectedCustomerRow.Name1;
			}
			else
			{
				mlblSelektierterKunde.Text = "Kein Kunde ausgewählt";
			}
		}

		void mbtnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			if (this.setSelectedCustomerAsCurrent) SelectCurrentCustomerAndClose();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			mySelectedCustomerRow = null;
			this.Close();
		}

		#endregion event handler

		#region private procedures

		void CustomerSearchView_Load(object sender, EventArgs e)
		{
			this.mtxtFilter.Focus();
		}

		void SelectCurrentCustomerAndClose()
		{
			if (this.mySelectedCustomerRow != null)
			{
				ModelManager.CustomerService.CurrentCustomer = ModelManager.CustomerService.GetKunde(this.mySelectedCustomerRow.Kundennummer, true);
				this.DialogResult = DialogResult.OK;
			}
			this.Close();
		}

		#endregion private procedures
	}
}