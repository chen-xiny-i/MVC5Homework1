using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework1.Models;


namespace Homework1.Controllers
{
    public class CustomerReportController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CustomerReport
        public ActionResult Index()
        {
            return View(db.ViewCustomerAmtReport.ToList());
        }
    }
}
