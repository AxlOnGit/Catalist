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
using Products.Common.Collections;

namespace Products.Common.Views
{
	public partial class TourListenView : MetroForm
	{

		#region members

		SBList<Tour> myTouren;
		Tour selectedTour;
		bool isSearch;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt die ausgewählte Tour zurück.
		/// </summary>
		public Tour SelectedTour
		{
			get { return this.selectedTour; }
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der TourListenView Klasse.
		/// </summary>
		public TourListenView(SBList<Tour> tourenListe, bool search)
		{
			InitializeComponent();
			this.isSearch = search;
			this.myTouren = tourenListe;

			this.InitializeData();
		}

		#endregion

		#region event handler

		void dgvTouren_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			selectedTour = dgvTouren.Rows[e.RowIndex].DataBoundItem as Tour;
		}

		void dgvTouren_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (selectedTour != null)
			{
				this.ShowTourKundenView();
			}
		}

		void mbtnOpen_Click(object sender, EventArgs e)
		{
			if (this.isSearch)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				this.ShowTourKundenView();
			}
		}

		void ctxCmdOpen_Click(object sender, EventArgs e)
		{
			if (!this.isSearch)
			{
				this.ShowTourKundenView();
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			if (this.isSearch)
			{
				this.ctxCmdOpen.Text = "OK";
				this.mbtnOpen.Text = "OK";
			}
			this.dgvTouren.AutoGenerateColumns = false;
			this.dgvTouren.DataSource = this.myTouren;
		}

		void ShowTourKundenView()
		{
			if (this.selectedTour != null)
			{
				var tkv = new TourKundenView(selectedTour, selectedTour.Tourkunden);
				tkv.Show();
				this.Close();
			}
		}

		#endregion

	}
}
