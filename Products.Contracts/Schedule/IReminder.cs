using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Contracts.Schedule
{
	public interface IReminder
	{

		string UID {get;}
		string Description { get; set; }
		DateTime RemindAt {get; set;}

	}
}
