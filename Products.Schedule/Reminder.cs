using System;
using System.Linq;
using Products.Contracts.Schedule;
using Products.Data;
using Quartz;

namespace Products.Schedule
{
	public class Reminder : IJob
	{

		#region members

		dsSage.ReminderRow myBase = null;
		private bool myIsUpdateRequired = false;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den Primärschlüssel dieser Erinnerung zurück.
		/// </summary>
		public string UID { get { return this.myBase.UID; } }

		/// <summary>
		/// Gibt den Primärschlüssel des verknüpften Tasks zurück.
		/// </summary>
		public string TaskId { get { return this.myBase.TaskId; } }

		/// <summary>
		/// Datum und Uhrzeit der Erinnerung.
		/// </summary>
		public DateTime RemindAt
		{
			get
			{
				return this.myBase.RemindAt;
			}
			set
			{
				this.myBase.RemindAt = value;
				this.myIsUpdateRequired = true;
			}
		}

		/// <summary>
		/// Der Text der Erinnerung.
		/// </summary>
		public string Description
		{
			get { return this.myBase.Description; }
			set { this.myBase.Description = value; }
		}

		public bool IsUpdateRequired
		{
			get
			{
				return this.myIsUpdateRequired;
			}
			private set
			{
				this.myIsUpdateRequired = value;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Reminder Klasse.
		/// </summary>
		/// <param name="baseRow">Eine <seealso cref="dsSage.ReminderRow"/> Instanz, die Basis dieser Erinnerung ist.</param>
		public Reminder(dsSage.ReminderRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

		#region public procedures

		public void SetNewRemindAt(DateTime newRemindAt)
		{
			this.RemindAt = newRemindAt;
			// MACHEN: Scheduler über den geänderten Reminder (neu zu erstellenden Job) informieren.
		}

		/// <summary>
		/// Löscht ggf. im Scheduler vorhandene Jobs für diesen Reminder.
		/// </summary>
		public void Remove()
		{
			// MACHEN: Diese Erinnerung aus dem Scheduler entfernen, falls vorhanden.
		}

		#endregion

		#region private procedures
		#endregion

		#region IJob Schnittstelle
		
		/// <summary>
		/// Wird vom Scheduler aufgerufen, wenn der Trigger für diesen Reminder ausgelöst wird.
		/// </summary>
		/// <param name="context"></param>
		public void Execute(IJobExecutionContext context)
		{
			JobDataMap map = context.JobDetail.JobDataMap;
			if (map != null)
			{
				IScheduleListener listener = map["Caller"] as IScheduleListener;
				if (listener != null)
				{
					listener.ExecuteJob(this);
				}
			}
		}

		#endregion

	}
}
