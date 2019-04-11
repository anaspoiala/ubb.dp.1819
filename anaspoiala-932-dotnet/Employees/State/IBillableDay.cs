using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.State
{
	public interface IBillableDay
	{
		bool IsEmployeeWorking(IEmployee employee);
		bool IsEmployeeInOffice(IEmployee employee);
	}
}
