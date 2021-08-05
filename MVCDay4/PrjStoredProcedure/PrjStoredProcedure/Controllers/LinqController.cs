using Microsoft.AspNetCore.Mvc;
using PrjStoredProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjStoredProcedure.Controllers
{
    public class LinqController : Controller
    {
        private readonly NorthwindContext db;

        public LinqController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //display the categoryname
        public IActionResult Getcategorybyname()
        {
            //Query syntax
            List<string> c = (from cat in db.Categories
                              orderby cat.CategoryName
                              select cat.CategoryName).ToList();
            //Method syntax
            dynamic c1 = (db.Categories.OrderBy(ca => ca.CategoryName)).ToList();

            return View(c);
        }
        //customer from germany
        public IActionResult Customer()
        {
            //Query syntax
            List<Customer> customers = (from c in db.Customers
                                        where c.Country =="germany"
                                        select c).ToList(); 

            return View(customers);
        }

        //display the employee details whoes region is notnull

        //display the customer infor for orderid 10248

        public IActionResult Custorderid()
        {
            //Query syntax
            List<Customer> customers = (from  o in db.Orders
                                        join c in db.Customers
                                        on o.CustomerId equals c.CustomerId
                                        where o.OrderId==10248
                                        select c).ToList();



            return View(customers);
        }

        public IActionResult Orderdetails()
        {
            //Query syntax
            return View(db.Orders.ToList());
        }
    }
}
