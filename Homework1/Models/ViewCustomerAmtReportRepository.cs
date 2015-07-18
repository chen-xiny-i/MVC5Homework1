using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Homework1.Models
{   
	public  class ViewCustomerAmtReportRepository : EFRepository<ViewCustomerAmtReport>, IViewCustomerAmtReportRepository
	{

	}

	public  interface IViewCustomerAmtReportRepository : IRepository<ViewCustomerAmtReport>
	{

	}
}