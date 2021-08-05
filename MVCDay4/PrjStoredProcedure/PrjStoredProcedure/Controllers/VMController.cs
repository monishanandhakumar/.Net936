using Microsoft.AspNetCore.Mvc;
using PrjStoredProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjStoredProcedure.ViewModel;

namespace PrjStoredProcedure.Controllers
{
    public class VMController : Controller
    {
        private readonly NorthwindContext db;

        public VMController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CusOrder()
        {
           var  customerlist= (from cust in db.Customers
                                           join
                                        or in db.Orders
                                            on cust.CustomerId equals or.CustomerId
                                           select new { cust.CustomerId, cust.CompanyName, or.OrderId, or.OrderDate }).ToList();

            List<CustomerVM> custvm = new List<CustomerVM>();
            foreach(var item in customerlist)
            {
                CustomerVM objvm = new CustomerVM();
                objvm.CustomerId = item.CustomerId;
                objvm.CompanyName = item.CompanyName;
                objvm.OrderId = item.OrderId;
                objvm.OrderDate = item.OrderDate;
                custvm.Add(objvm);
            }

            return View(custvm);
        }
    }
}
