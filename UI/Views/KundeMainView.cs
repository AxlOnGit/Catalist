using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Common.Interfaces;
using Products.Common.Panel;
using Products.Model.Entities;

namespace Products.Common.Views
{
	public partial class KundeMainView : MetroForm
	{
		#region MEMBERS

		readonly Model.Entities.Kunde myKunde;

		Stack<PanelSlider> myPanelsBack = new Stack<PanelSlider>();
		Stack<PanelSlider> myPanelsNext = new Stack<PanelSlider>();

		PanelSlider myActivePanel;
		PanelKundeStart myStartPanel;
		PanelArtikelpreise myArtikelPanel;
		PanelArtikeldetail myArtikelDetailPanel;
		PanelKontakte myKontaktePanel;
		PanelAuftrag myAuftragsPanel;
		PanelAngebote myAngebotsPanel;
		PanelFinanzen myFinanzPanel;
		PanelMaschinenListe myMmaschinenPanel;
		PanelSoftwareliste mySoftwarePanel;
		PanelNotizen myNotizenPanel;

		#endregion MEMBERS

		#region public properties

		public Kunde CurrentCustomer => this.myKunde;

		#endregion public properties

		#region ### .ctor ###

		public KundeMainView(Kunde kunde, ILinkedItem openThis = null)
		{
			InitializeComponent();
			this.myKunde = kunde;
			Model.ModelManager.CustomerService.CurrentCustomer = kunde;
			var name = this.myKunde.CompanyName1.Replace("&", "&&");
			var titel = $"[{this.myKunde.KundenNrCpm}] [{this.myKunde.Vertreter}] {name}";
			this.Text = titel;
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

		#endregion ### .ctor ###

		#region EVENT HANDLER

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
			//if (!this.Focused)
			//{
			//	this.Focus();
			//}
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

		#endregion EVENT HANDLER

		#region INTERNAL PROCEDURES

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
				this.myAuftragsPanel = new PanelAuftrag(this, myKunde, true);
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
				this.myAngebotsPanel = new PanelAngebote(this, myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(myActivePanel);
			myActivePanel.Swipe(false);
			myAngebotsPanel.Swipe(true);
			myActivePanel = myAngebotsPanel;
			ToggleCloseButton();
		}

		internal void ShowAngebotsdetail(Offer angebot)
		{
			var angebotsDetailPanel = new PanelAngebotsdetail(this, angebot, true);
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
				this.myArtikelPanel = new PanelArtikelpreise(this, myKunde, true);
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
			this.myArtikelDetailPanel = new PanelArtikeldetail(this, myKunde, product, true);
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
				this.myKontaktePanel = new Panel.PanelKontakte(this, myKunde, true);
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
				this.myFinanzPanel = new PanelFinanzen(this, myKunde, true);
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
				this.myMmaschinenPanel = new PanelMaschinenListe(this, this.myKunde, true);
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
				this.mySoftwarePanel = new PanelSoftwareliste(this, this.myKunde, true);
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
				this.myNotizenPanel = new PanelNotizen(this, this.myKunde, true);
			}
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			this.myNotizenPanel.Swipe(true);
			this.myActivePanel = myNotizenPanel;
			this.ToggleCloseButton();
		}

		#endregion LOAD OR SHOW

		#region JUST SHOW

		//internal pnlMaschinendetail ShowMaschine(Kundenmaschine kundenmaschine)
		internal PanelKundenMaschine ShowMaschine(Kundenmaschine kundenmaschine)
		{
			//var detailPanel = new pnlMaschinendetail(this, kundenmaschine, true);
			var detailPanel = new PanelKundenMaschine(this, kundenmaschine);
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			detailPanel.Swipe(true);
			this.myActivePanel = detailPanel;
			this.ToggleCloseButton();
			return detailPanel;
		}

		internal void ShowNotiz(Notiz notiz)
		{
			var notizPanel = new PanelNotiz(this, notiz, this.myKunde, false);
			if (this.myActivePanel.KeepLoaded) this.myPanelsBack.Push(this.myActivePanel);
			this.myActivePanel.Swipe(false);
			notizPanel.Swipe(true);
			this.myActivePanel = notizPanel;
			this.ToggleCloseButton();
		}

		internal void ShowSoftware(Kundensoftware software)
		{
			var softwarePanel = new PanelSoftware(this, software, true);
			if (myActivePanel.KeepLoaded) myPanelsBack.Push(myActivePanel);
			this.myActivePanel.Swipe(false);
			softwarePanel.Swipe(true);
			this.myActivePanel = softwarePanel;
			this.ToggleCloseButton();
		}

		#endregion JUST SHOW

		#endregion INTERNAL PROCEDURES

		#region PRIVATE PROCEDURES

		void Next(PanelSlider panel)
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
				if (ctrl is PanelSlider) //  ctrl.GetType().BaseType.Equals(typeof(Panel.pnlSlider)
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
				this.myStartPanel = new PanelKundeStart(this, myKunde, true);
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

		#endregion PRIVATE PROCEDURES
	}
}