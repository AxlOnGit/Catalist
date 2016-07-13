﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using Products.Model.Entities;
using Products.Common.Interfaces;
using Products.Common.Panel;

namespace Products.Common.Views
{
	public partial class KundeMainView : MetroForm
	{

		#region members

		readonly Model.Entities.Kunde myKunde;

		Stack<pnlSlider> myPanelsBack = new Stack<pnlSlider>();
		Stack<pnlSlider> myPanelsNext = new Stack<pnlSlider>();

		pnlSlider myActivePanel;
		pnlKundeStart myStartPanel;
		pnlArtikelpreise myArtikelPanel;
		pnlArtikeldetail myArtikelDetailPanel;
		pnlKontakte myKontaktePanel;
		pnlAuftraege myAuftragsPanel;
		pnlAngebote myAngebotsPanel;
		pnlFinanzen myFinanzPanel;
		pnlMaschinen myMmaschinenPanel;
		pnlSoftwareliste mySoftwarePanel;
		pnlNotizen myNotizenPanel;

		#endregion

		#region public properties

		public Kunde CurrentCustomer { get { return this.myKunde; } }

		#endregion

		#region ### .ctor ###

		public KundeMainView(Kunde kunde, ILinkedItem openThis = null)
		{
			InitializeComponent();
			this.myKunde = kunde;
			this.Text = string.Format("[{0}] [{1}] - {2}", myKunde.CustomerId.Substring(0, 5), myKunde.Vertreter, myKunde.CompanyName1.Replace("&", "&&"));
			Application.Idle += Application_Idle;

			ShowStartPanel();

			if (openThis != null)
			{
				switch (openThis.LinkTypBezeichnung)
				{
					case "Kundenkontakt":
						this.LoadOrShowKontakte();
						break;

					case "Kundenmaschine":
						var machine = openThis as Kundenmaschine;
						if (machine != null)
						{
							this.ShowMaschine(machine);
						}
						break;
				}
			}
		}

		#endregion

		#region event handler

		[DebuggerStepThrough]
		void Application_Idle(object sender, EventArgs e)
		{
			this.SuspendLayout();
			mbtnStart.Visible = !(myActivePanel.Equals(myStartPanel));
			mbtnBack.Visible = !(myActivePanel.Equals(myStartPanel));
			mbtnNext.Visible = myPanelsNext.Count >= 1;
			this.ResumeLayout();
		}

		void KundeMainView_MouseEnter(object sender, EventArgs e)
		{
			if (!this.Focused)
			{
				this.Focus();
			}
		}

		void xcmdBingMaps_Click(object sender, EventArgs e)
		{
			this.myKunde.OpenInBingMaps();
		}

		void xcmdShowTouren_Click(object sender, EventArgs e)
		{
			var tlv = new TourListenView(this.myKunde.Tourliste, false);
			tlv.Show();
		}

		void mbtnStart_Click(object sender, EventArgs e)
		{
			ShowStartPanel();
		}

		void mbtnBack_Click(object sender, EventArgs e)
		{
			var currentActive = myActivePanel;
			var nextActive = myPanelsBack.Pop();
			if (currentActive.KeepLoaded) myPanelsNext.Push(currentActive);
			currentActive.Swipe(false);
			myActivePanel = nextActive;
			myActivePanel.Swipe(true);
			ToggleCloseButton();
		}

		void mbtnNext_Click(object sender, EventArgs e)
		{
			var currentActive = myActivePanel;
			var nextActive = myPanelsNext.Pop();
			if (currentActive.KeepLoaded) myPanelsBack.Push(currentActive);
			currentActive.Swipe(false);
			myActivePanel = nextActive;
			myActivePanel.Swipe(true);
			ToggleCloseButton();
		}

		void mbtnClose_Click(object sender, EventArgs e)
		{
			myPanelsBack.Clear();
			myPanelsNext.Clear();
			this.Close();
		}

		void KundeMainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			myActivePanel.Swipe(false);
			ClearPanels();
		}

		#endregion

		#region internal procedures

		void KundeMainView_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && (e.KeyCode == Keys.Home))
			{
				ShowStartPanel();
			}
		}

		#region LOAD OR SHOW

		internal void LoadOrShowAuftraege()
		{
			if (this.myAuftragsPanel == null)
			{
				this.myAuftragsPanel = new pnlAuftraege(this, myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) myPanelsBack.Push(myActivePanel);
			myActivePanel.Swipe(false);
			myAuftragsPanel.Swipe(true);
			myActivePanel = myAuftragsPanel;
			ToggleCloseButton();
		}

		internal void LoadOrShowAngebote()
		{
			if (this.myAngebotsPanel == null)
			{
				this.myAngebotsPanel = new pnlAngebote(this, myKunde,true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(myActivePanel);
			myActivePanel.Swipe(false);
			myAngebotsPanel.Swipe(true);
			myActivePanel = myAngebotsPanel;
			ToggleCloseButton();
		}

		internal void ShowAngebotsdetail(Offer angebot)
		{
			var angebotsDetailPanel = new pnlAngebotsdetail(this, angebot, true);
			if (myActivePanel.KeepLoaded) myPanelsBack.Push(myActivePanel);
			myActivePanel.Swipe(false);
			angebotsDetailPanel.Swipe(true);
			this.myActivePanel = angebotsDetailPanel;
			this.ToggleCloseButton();
		}

		internal void LoadOrShowArtikelpreise()
		{
			if (this.myArtikelPanel == null)
			{
				this.myArtikelPanel = new pnlArtikelpreise(this, myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myArtikelPanel.Swipe(true);
			this.myActivePanel = this.myArtikelPanel;
			this.ToggleCloseButton();
		}

		internal void LoadOrShowArtikeldetail(Product product)
		{
			if (this.myArtikelDetailPanel != null)
			{
				this.myArtikelDetailPanel.Dispose();
				this.myArtikelDetailPanel = null;
			}
			this.myArtikelDetailPanel = new pnlArtikeldetail(this, myKunde, product, true);
			if (this.myActivePanel.KeepLoaded) myPanelsBack.Push(myActivePanel);
			myActivePanel.Swipe(false);
			myArtikelDetailPanel.Swipe(true);
			myActivePanel = myArtikelDetailPanel;
			ToggleCloseButton();
		}

		internal void LoadOrShowKontakte()
		{
			if (this.myKontaktePanel == null)
			{
				this.myKontaktePanel = new Panel.pnlKontakte(this, myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myKontaktePanel.Swipe(true);
			this.myActivePanel = this.myKontaktePanel;
			this.ToggleCloseButton();
		}

		internal void LoadOrShowFinanzen()
		{
			if (this.myFinanzPanel == null)
			{
				this.myFinanzPanel = new pnlFinanzen(this, myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myFinanzPanel.Swipe(true);
			this.myActivePanel = this.myFinanzPanel;
			this.ToggleCloseButton();
		}

		internal void LoadOrShowMaschinen()
		{
			if (this.myMmaschinenPanel == null)
			{
				this.myMmaschinenPanel = new pnlMaschinen(this, this.myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myMmaschinenPanel.Swipe(true);
			myActivePanel = myMmaschinenPanel;
			this.ToggleCloseButton();
		}

		internal void LoadOrShowKundensoftware()
		{
			if (this.mySoftwarePanel == null)
			{
				this.mySoftwarePanel = new pnlSoftwareliste(this, this.myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.mySoftwarePanel.Swipe(true);
			this.myActivePanel = mySoftwarePanel;
			this.ToggleCloseButton();
			}

		internal void LoadOrShowNotizen()
		{
			if (this.myNotizenPanel == null)
			{
				this.myNotizenPanel = new pnlNotizen(this, this.myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myNotizenPanel.Swipe(true);
			this.myActivePanel = myNotizenPanel;
			this.ToggleCloseButton();
		}

		#endregion

		#region JUST SHOW

		internal pnlMaschinendetail ShowMaschine(Kundenmaschine kundenmaschine)
		{
			var detailPanel = new pnlMaschinendetail(this, kundenmaschine, true);
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			detailPanel.Swipe(true);
			this.myActivePanel = detailPanel;
			this.ToggleCloseButton();
			return detailPanel;
		}

		internal void ShowNotiz(Notiz notiz)
		{
			var notizPanel = new pnlNotiz(this, notiz, this.myKunde, false);
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			notizPanel.Swipe(true);
			this.myActivePanel = notizPanel;
			this.ToggleCloseButton();
		}

		internal void ShowSoftware(Kundensoftware software)
		{
			var softwarePanel = new pnlSoftware(this, software, true);
			if (myActivePanel.KeepLoaded) myPanelsBack.Push(myActivePanel);
			this.myActivePanel.Swipe(false);
			softwarePanel.Swipe(true);
			this.myActivePanel = softwarePanel;
			this.ToggleCloseButton();
		}

		#endregion

		#endregion

		#region private procedures

		void Next(pnlSlider panel)
		{
			if (panel.KeepLoaded)
			{
				this.myPanelsBack.Push(panel);
				this.myActivePanel = panel;
				panel.Swipe(true);
			}
		}

		void Back()
		{
			if (this.myActivePanel.KeepLoaded)
			{
				this.myPanelsNext.Push(this.myActivePanel);
				var panel = myPanelsBack.Pop();
				this.myActivePanel.Swipe(false);
				var backPanel = this.myPanelsBack.Pop();
				this.myActivePanel = backPanel;
				backPanel.Swipe(true);
			}
		}

		void ClearPanels()
		{
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is pnlSlider) //  ctrl.GetType().BaseType.Equals(typeof(Panel.pnlSlider)
				{
					this.Controls.Remove(ctrl);
					ctrl.Dispose();
				}
			}
		}

		internal void ShowStartPanel()
		{
			this.myPanelsBack.Clear();
			this.myPanelsNext.Clear();
			if (this.myActivePanel != null) this.myActivePanel.Swipe(false);
			if (this.myStartPanel == null)
			{
				this.myStartPanel = new pnlKundeStart(this, myKunde, true);
			}
			this.myPanelsBack.Push(this.myStartPanel);
			this.myActivePanel = this.myStartPanel;
			this.myActivePanel.Swipe(true);
			this.ToggleCloseButton();
		}

		void ToggleCloseButton()
		{
			if (this.myActivePanel == myStartPanel) // .Equals(myStartPanel)
			{
				this.mbtnStart2.Visible = false;
				this.mbtnClose.Location = new Point(22, this.Height - 52);
				this.mbtnStart2.Location = new Point(22, this.Height - 86);
				this.mbtnClose.Visible = true;
			}
			else
			{
				this.mbtnClose.Visible = false;
				this.mbtnStart2.Location = new Point(22, this.Height - 52);
				this.mbtnStart2.Visible = true;
			}
		}

		#endregion

	}
}