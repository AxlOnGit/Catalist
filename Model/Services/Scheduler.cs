using Products.Contracts.Schedule;
using Products.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;

namespace Products.Model.Services
{
	public class Scheduler
	{

		#region members

		private IScheduler myScheduler = StdSchedulerFactory.GetDefaultScheduler();

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Scheduler Klasse.
		/// <param name="delay">Integer, der die Anzahl in Sekunden angibt, mit der der
		/// Start des Schedulers verzögert wird.</param>
		/// </summary>
		public Scheduler(int delay = 0)
		{
			// Start des Schedulers mit der angegebenen Anzahl von Sekunden Verzögerung, um ggf. andere Initialisierungen abzuschließen.
			if (delay > 0)
			{
				TimeSpan withDelay = new TimeSpan(0, 0, delay);
				this.myScheduler.StartDelayed(withDelay);
			}
			else this.myScheduler.Start(); // Start ohne Verzögerung.
		}

		#endregion

		#region public procedures

		public void Start()
		{
			if (this.myScheduler != null && !this.myScheduler.IsStarted || this.myScheduler.InStandbyMode)
			{
				this.myScheduler.Start();
			}
			else if (this.myScheduler == null)
			{
				this.myScheduler = StdSchedulerFactory.GetDefaultScheduler();
				this.myScheduler.Start();
			}
		}

		public void AddJob(Reminder instReminder, IScheduleListener instCaller)
		{
			IJob job = instReminder as IJob;
			DateTime startAtUtc = instReminder.RemindAt.ToUniversalTime();
			TimeOfDay start = new TimeOfDay(startAtUtc.Hour, startAtUtc.Minute);

				// JobDetail
			IJobDetail jobDetail = JobBuilder.Create<Reminder>()
				.WithDescription(instReminder.Description)
				.WithIdentity(instReminder.UID)
				.Build();
			jobDetail.JobDataMap["Caller"] = instCaller;
			jobDetail.JobDataMap["Reminder"] = instReminder;

				// Trigger
				DateTimeOffset offset = new DateTimeOffset(startAtUtc);
				ITrigger jobTrigger = TriggerBuilder.Create()
					.StartAt(new DateTimeOffset(startAtUtc))
					//.WithSimpleSchedule(_ => _
					//  .WithIntervalInSeconds(5)
					//  .WithRepeatCount(1))
				  .Build();

				// Detail und Trigger zum Scheduler hinzufügen
				this.myScheduler.ScheduleJob(jobDetail, jobTrigger);
		}

		/// <summary>
		/// Prüft, ob es einen Job für den Reminder mit dem angegebenen Primärschlüssel gibt.
		/// </summary>
		/// <param name="reminderPK">Zeichenfolge mit dem Primärschlüssel des Reminders.</param>
		/// <returns></returns>
		public bool JobExists(string reminderPK)
		{
			JobKey jobKey = new JobKey(reminderPK);
			return this.myScheduler.CheckExists(jobKey);
		}

		public void RemoveJob(string reminderPK)
		{
			JobKey jobKey = new JobKey(reminderPK);
			this.myScheduler.DeleteJob(jobKey);
		}

		/// <summary>
		/// Beendet die Ausführung des Schedulers und gibt verwendete Ressourcen frei.
		/// </summary>
		public void Shutdown()
		{
			this.myScheduler.Shutdown(false);
		}

		#endregion

	}
}
