using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Contracts.Schedule
{
	public interface IScheduleListener
	{

		/// <summary>
		/// Wird von Quartz.NET IJob Objekten innerhalb der Execute() Methode aufgerufen.
		/// </summary>
		/// <param name="executionParams">Ein Objekt, das als Parameter übergeben werden kann.</param>
		void ExecuteJob(object executionParams);

	}
}
