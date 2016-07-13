using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class AppointmentType
	{

		#region members

		readonly dsAppointments.AppointmentTypeRow myBase;

		#endregion

		#region public properties

		public string Name { get { return this.myBase.Name; } set { this.myBase.Name = value; } }

		#endregion

		#region ### .ctor ###

		public AppointmentType(dsAppointments.AppointmentTypeRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
