using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using System.Text;
using Products.Common.ViewController;

namespace Products.Common.Views
{
	public partial class CalendarView : MetroForm
	{

		#region members

		private Model.Entities.CalendarOpenParams myOpenArgs = null;
		private List<Termin> myTerminliste = new List<Termin>();
		private Termin mySelectedTermin;
		private List<User> myUsersToShow = new List<User>();
		private bool calFelixAdded;
		private bool calMatthiasAdded;
		private bool calJohannesAdded;
		private bool calRoggeAdded;
		private bool calMarkusSAdded;
		private bool calTanjaAdded;
		private bool calSaskiaAdded;
		private bool calSezenAdded;
		private bool calJulianAdded;
		private bool calAxelAdded;
		private CalendarViewController myController;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den vom Benutzer ausgewählten Termin zurück.
		/// </summary>
		public Model.Entities.Termin SelektierterTermin
		{
			get { return mySelectedTermin; }
		}

		#endregion

		#region ### .ctor ###

		public CalendarView(Model.Entities.CalendarOpenParams openArgs)
		{
			InitializeComponent();
			myOpenArgs = openArgs;
			InitCalendar();
		}

		public CalendarView(CalendarViewController controller)
		{
			InitializeComponent();
			this.InitCalendar(controller);
		}

		#endregion

		#region event handler

		private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			if (dayView.DaysToShow == 1)
			{
				dayView.StartDate = e.Start;
			}
			else
			{
				dayView.StartDate = GetMondaySelectedWeek();
			}
		}

		private void lnkHeute_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			GoToToday();
		}

		private void btnHeute_Click(object sender, EventArgs e)
		{
			GoToToday();
		}
		
		private void btnEinTag_Click(object sender, EventArgs e)
		{
			Show1Day();
		}

		private void lnkEinTag_MouseClick(object sender, MouseEventArgs e)
		{
			Show1Day();
		}

		private void btnArbeitswoche_Click(object sender, EventArgs e)
		{
			Show5Days();
		}

		private void lnkArbeitswoche_MouseClick(object sender, MouseEventArgs e)
		{
			Show5Days();
		}

		private void btnGanzeWoche_Click(object sender, EventArgs e)
		{
			Show7Days();
		}

		private void lnkGanzeWoche_MouseClick(object sender, MouseEventArgs e)
		{
			Show7Days();
		}

		private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CalendarView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (mySelectedTermin != null)
			{
				mySelectedTermin.Update();
			}
		}

		private void chkAndereKalender_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			try
			{
				switch (e.Index)
				{
					//Felix
					case 0:
						User felix = ModelManager.UserService.GetUser("FD", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(felix))
						{
							myUsersToShow.Remove(felix);
						}
						else
						{
							if (!myUsersToShow.Contains(felix))
							{
								myUsersToShow.Add(felix);
								if (!calFelixAdded)
								{
									myTerminliste.AddRange(felix.Terminliste);
									calFelixAdded = true;
								}
							}
						}
						break;

					// Matthias
					case 1:
						User matthias = ModelManager.UserService.GetUser("MD", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(matthias))
						{
							myUsersToShow.Remove(matthias);
						}
						else
						{
							if (!myUsersToShow.Contains(matthias))
							{
								myUsersToShow.Add(matthias);
								if (!calMatthiasAdded)
								{
									myTerminliste.AddRange(matthias.Terminliste);
									calMatthiasAdded = true;
								}
							}
						}
						break;

					// Johannes
					case 2:
						User johannes = ModelManager.UserService.GetUser("JD", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(johannes))
						{
							myUsersToShow.Remove(johannes);
						}
						else
						{
							if (!myUsersToShow.Contains(johannes))
							{
								myUsersToShow.Add(johannes);
								if (!calJohannesAdded)
								{
									myTerminliste.AddRange(johannes.Terminliste);
									calJohannesAdded = true;
								}
							}
						}
						break;

					// Markus Sprehe
					case 3:
						User markus = ModelManager.UserService.GetUser("MS", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(markus))
						{
							myUsersToShow.Remove(markus);
						}
						else
						{
							if (!myUsersToShow.Contains(markus))
							{
								myUsersToShow.Add(markus);
								if (!calMarkusSAdded)
								{
									myTerminliste.AddRange(markus.Terminliste);
									calMarkusSAdded = true;
								}
							}
						}
						break;

					// Markus Roggenkamp
					case 4:
						User rogge = ModelManager.UserService.GetUser("MR", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(rogge))
						{
							myUsersToShow.Remove(rogge);
						}
						else
						{
							if (!myUsersToShow.Contains(rogge))
							{
								myUsersToShow.Add(rogge);
								if (!calRoggeAdded)
								{
									myTerminliste.AddRange(rogge.Terminliste);
									calRoggeAdded = true;
								}
							}
						}
						break;

					// Axel
					case 5:
						User axel = ModelManager.UserService.GetUser("AU", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(axel))
						{
							myUsersToShow.Remove(axel);
						}
						else
						{
							if (!myUsersToShow.Contains(axel))
							{
								myUsersToShow.Add(axel);
								if (!calAxelAdded)
								{
									myTerminliste.AddRange(axel.Terminliste);
									calAxelAdded = true;
								}
							}
						}
						break;

					// Tanja
					case 6:
						User tanja = ModelManager.UserService.GetUser("TT", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(tanja))
						{
							myUsersToShow.Remove(tanja);
						}
						else
						{
							if (!myUsersToShow.Contains(tanja))
							{
								myUsersToShow.Add(tanja);
								if (!calTanjaAdded)
								{
									myTerminliste.AddRange(tanja.Terminliste);
									calTanjaAdded = true;
								}
							}
						}
						break;

					// Saskia
					case 7:
						User saskia = ModelManager.UserService.GetUser("SP", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(saskia))
						{
							myUsersToShow.Remove(saskia);
						}
						else
						{
							if (!myUsersToShow.Contains(saskia))
							{
								myUsersToShow.Add(saskia);
								if (!calSaskiaAdded)
								{
									myTerminliste.AddRange(saskia.Terminliste);
									calSaskiaAdded = true;
								}
							}
						}
						break;

					// Sezen
					case 8:
						User sezen = ModelManager.UserService.GetUser("SC", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(sezen))
						{
							myUsersToShow.Remove(sezen);
						}
						else
						{
							if (!myUsersToShow.Contains(sezen))
							{
								myUsersToShow.Add(sezen);
								if (!calSezenAdded)
								{
									myTerminliste.AddRange(sezen.Terminliste);
									calSezenAdded = true;
								}
							}
						}
						break;

					// Julian
					case 9:
						User julian = ModelManager.UserService.GetUser("JZ", Model.Services.UserService.UserSearchParamType.SageLoginName);
						if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked && myUsersToShow.Contains(julian))
						{
							myUsersToShow.Remove(julian);
						}
						else
						{
							if (!myUsersToShow.Contains(julian))
							{
								myUsersToShow.Add(julian);
								if (!calJulianAdded)
								{
									myTerminliste.AddRange(julian.Terminliste);
									calJulianAdded = true;
								}
							}
						}
						break;

					default:
						break;
				}
				dayView.Invalidate();
				Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				Cursor = Cursors.Default;
				string msg = string.Format("{0}/n{1}", ex.Message, ex.InnerException.Message);
				MessageBox.Show(ex.Message);
			}
		}

		private void ctxmnuAddTermin_Click(object sender, EventArgs e)
		{
			UserSearchView usv = new UserSearchView();
			usv.ShowDialog();
			if (usv.DialogResult == System.Windows.Forms.DialogResult.OK && usv.SelectedUser != null)
			{

				CalendarDetailView cdv = new CalendarDetailView(AddTermin(usv.SelectedUser));
				cdv.Show();
			}
		}

		private void ctxmnuAddBesuchstermin_Click(object sender, EventArgs e)
		{
			if (this.myOpenArgs.Mitarbeiter == null) return;
			if (this.myOpenArgs.Kunde != null)
			{
				this.AddBesuchstermin(this.myOpenArgs.Mitarbeiter, this.myOpenArgs.Kunde);
			}
			else if (this.myOpenArgs.Interessent != null)
			{
				this.AddBesuchstermin(this.myOpenArgs.Mitarbeiter, this.myOpenArgs.Interessent);
			}
		}

		private void ctxmnuLinkBesuchstermin_Click(object sender, EventArgs e)
		{
			this.LinkBesuchstermin();
		}

		private void ctxcmdTermindetails_Click(object sender, EventArgs e)
		{
			if (mySelectedTermin != null)
			{
				MessageBox.Show(mySelectedTermin.Termindetails);
			}
		}

		private void ctxOpenAppointment_Click(object sender, EventArgs e)
		{
			OpenTermin();
		}

		private void dayView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			OpenTermin();
		}

		#region DayView events

		void dayView_NewAppointment(object sender, Calendar.NewAppointmentEventArgs args)
		{
		}

		void dayView_AppointmentMove(object sender, Calendar.AppointmentEventArgs e)
		{
			Model.Entities.Termin termin = e.Appointment as Model.Entities.Termin;
			if (termin != null)
			{
				termin.StartDate = e.Appointment.StartDate;
				termin.EndDate = e.Appointment.EndDate;
			}
		}

		void dayView_ResolveAppointments(object sender, Calendar.ResolveAppointmentsEventArgs args)
		{
			if (this.myTerminliste != null)
			{
				List<Calendar.Appointment> list = new List<Calendar.Appointment>();
				foreach (var termin in myTerminliste)
				{
					foreach (var user in myUsersToShow)
					{
						//
						if (termin.Owner.Equals(user) && termin.StartDate >= args.StartDate && termin.EndDate <= args.EndDate)
						{
							list.Add(termin);
						}
					}
				}
				args.Appointments = (List<Calendar.Appointment>)list;
			}
		}

		void dayView_SelectionChanged(object sender, EventArgs e)
		{
			Termin termin = dayView.SelectedAppointment as Termin;
			if (termin != null)
			{
				if (mySelectedTermin != null)
				{
					if (mySelectedTermin.Dirty) mySelectedTermin.Update();
				}
				mySelectedTermin = termin;
				mlblSelektierterTermin.Text = string.Format(" <~-~ v ~-~> {0} -- {1} -- {2} bis {3} Uhr", termin.Title, termin.StartDate.ToShortDateString(), termin.StartDate.ToShortTimeString(), termin.EndDate.ToShortTimeString()); 
				lblAktuellerTermin.Text = string.Format("{0} -- {1} -- {2} bis {3} Uhr", termin.Title, termin.StartDate.ToShortDateString(), termin.StartDate.ToShortTimeString(), termin.EndDate.ToShortTimeString()); ;
			}
			else
			{
				if (mySelectedTermin != null)
				{
					mySelectedTermin.Update();
				}
				mlblSelektierterTermin.Text = "Kein Termin ausgewählt";
				lblAktuellerTermin.Text = null;
			}
		}

		#endregion

		#endregion

		#region public procedures
		#endregion

		#region private procedures

		private void InitCalendar()
		{
			this.SetUserCalendarChecked(ModelManager.UserService.CurrentUser);

			monthCalendar.SelectionRange = new SelectionRange(DateTime.Today, DateTime.Today);
			dayView.StartDate = GetMondaySelectedWeek();
			this.dayView.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(dayView_ResolveAppointments);
			this.dayView.AppointmentMove += new EventHandler<Calendar.AppointmentEventArgs>(dayView_AppointmentMove);
			this.dayView.NewAppointment += new Calendar.NewAppointmentEventHandler(dayView_NewAppointment);
			this.dayView.SelectionChanged += new EventHandler(dayView_SelectionChanged);

			if (myOpenArgs.WirSuchenEinenTermin)
			{
				mlblKalenderVon.Text = "Terminsuche";
			}
			else
			{
				mlblKalenderVon.Text = string.Format("Kalender: {0}", ModelManager.UserService.CurrentUser.NameFull);
			}
			if (this.myOpenArgs.Mitarbeiter != null) this.SetUserCalendarChecked(this.myOpenArgs.Mitarbeiter);

			mlblSelektierterTermin.Text = "Kein Termin ausgewählt";
			lblAktuellerTermin.Text = string.Empty;
			dayView.StartHour = 8;
		}

		private void InitCalendar(CalendarViewController controller)
		{
			this.myController = controller;
		}

		private Termin AddTermin(User forUser)
		{
			string archive = forUser.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender);
			David.CreateMsgItm2Params createParams = David.DavidManager.DavidService.CreateCalendarItem(dayView.SelectionStart, dayView.SelectionEnd, archive);
			Model.Entities.Termin termin = new Model.Entities.Termin(createParams.MessageItem2Object);
			myTerminliste.Add(termin);
			return termin;
		}

		private Termin AddBesuchstermin(User forUser, object kundeOderInteressent)
		{
			this.SetUserCalendarChecked(forUser);
			string archive = forUser.GetDavidArchivePath(Global.DavidArchiveTypes.Kalender);
			David.CreateMsgItm2Params parms = David.DavidManager.DavidService.CreateCalendarItem(dayView.SelectionStart, dayView.SelectionEnd, archive);
			Termin termin = new Termin(parms.MessageItem2Object);
			if (kundeOderInteressent is Kunde)
			{
				if (this.myOpenArgs.Mitarbeiter != null && this.myOpenArgs.Kunde != null)
				{
					if (this.myOpenArgs.Mitarbeiter.LinkBesuchstermin(termin, this.myOpenArgs.Kunde))
					{
						termin.Title = string.Format("{0}: Besuchstermin ({1})", this.myOpenArgs.Kunde.CompanyName1, forUser.SageLoginName.ToLower());
						termin.HTML = string.Format("{0}/n{1}", this.myOpenArgs.Kunde.GetHtmlHead(), this.myOpenArgs.Kunde.GetHtmlNotizen());
						string msg = string.Format("Firma {0} hat jetzt einen Besuchstermin mit {1}.", this.myOpenArgs.Kunde.CompanyName1, this.myOpenArgs.Mitarbeiter.NameFull);
						MessageBox.Show(msg);
					}
				}
			}
			else if (kundeOderInteressent is Interessent)
			{
			}
			this.myTerminliste.Add(termin);
			return termin;
		}

		private void LinkBesuchstermin()
		{
			if (mySelectedTermin != null)
			{
				Views.CustomerSearchView csv = new CustomerSearchView("Mit welchem Kunden soll dieser Besuchstermin verknüpft werden?");
				if (csv.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					User user = ModelManager.UserService.GetUser(mySelectedTermin.FullName, Model.Services.UserService.UserSearchParamType.DavidFileName);
					Kunde kunde = ModelManager.CustomerService.GetKunde(csv.SelectedCustomer.Kundennummer);
					if (kunde != null)
					{
						if (user.LinkBesuchstermin(mySelectedTermin, kunde))
						{
							MessageBox.Show(string.Format("Der Eintrag für Firma {0} wurde der Besuchsterminliste von {1} angefügt.", kunde.CompanyName1, user.NameFull));
						}
						else
						{
							MessageBox.Show(string.Format("Der Eintrag für Firma {0} war in derBesuchsterminliste von {1} schon vorhanden.", kunde.CompanyName1), user.NameFull);
						}
					}
				}
			}
		}

		private DateTime GetMondaySelectedWeek()
		{
			switch (monthCalendar.SelectionStart.DayOfWeek)
			{
				case DayOfWeek.Tuesday:
					return monthCalendar.SelectionStart.AddDays(-1);

				case DayOfWeek.Wednesday:
					return monthCalendar.SelectionStart.AddDays(-2);

				case DayOfWeek.Thursday:
					return monthCalendar.SelectionStart.AddDays(-3);

				case DayOfWeek.Friday:
					return monthCalendar.SelectionStart.AddDays(-4);

				case DayOfWeek.Saturday:
					return monthCalendar.SelectionStart.AddDays(-5);

				case DayOfWeek.Sunday:
					return monthCalendar.SelectionStart.AddDays(-6);

				default:
					return monthCalendar.SelectionStart;
			}
		}

		private void GoToToday()
		{
			monthCalendar.SelectionRange = new SelectionRange(DateTime.Today, DateTime.Today);
			if (dayView.DaysToShow == 1)
			{
				dayView.StartDate = DateTime.Today;
			}
			else
			{
				dayView.StartDate = GetMondaySelectedWeek();
			}

		}

		private void Show1Day()
		{
			dayView.DaysToShow = 1;
		}

		private void Show5Days()
		{
			dayView.DaysToShow = 5;
		}

		private void Show7Days()
		{
			dayView.DaysToShow = 7;
		}

		private void OpenTermin()
		{
			if (mySelectedTermin == null) return;
			CalendarDetailView cdv = new CalendarDetailView(mySelectedTermin);
			cdv.ShowDialog();
			dayView.Invalidate();
		}

		private void SetUserCalendarChecked(User user)
		{
			int ix = 0;

			if (user == null)
			{
				user = ModelManager.UserService.CurrentUser;
			}
			switch (user.SageLoginName)
			{
				case "FD": ix = 0; break;
				case "MD": ix = 1; break;
				case "JD": ix = 2; break;
				case "MS": ix = 3; break;
				case "MR": ix = 4; break;
				case "AU": ix = 5; break;
				case "TT": ix = 6; break;
				case "SP": ix = 7; break;
				case "SC": ix = 8; break;
				case "JZ": ix = 9; break;
				default: ix = 5; break;
			}
			if (!this.chkAndereKalender.SelectedIndices.Contains(ix)) this.chkAndereKalender.SetItemChecked(ix, true);

		}

		#endregion

	}
}
