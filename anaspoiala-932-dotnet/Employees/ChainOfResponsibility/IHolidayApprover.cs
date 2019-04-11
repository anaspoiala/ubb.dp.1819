using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ChainOfResponsibility
{
	public interface IHolidayApprover
	{
		bool ApproveHolidayRequest();

		IHolidayApprover NextApprover();
	}
}
