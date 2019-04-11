using Employees.State;
using Employees.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
	public interface IEmployee
	{
		IBillableDay CurrentBillableDay();

		NotificationType NotificationMechanism();
	}
}
