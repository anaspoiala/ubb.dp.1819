using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Strategy
{
	public interface INotificationStrategy
	{
		void SendMessage(IEmployee employee, string msg);
	}
}
