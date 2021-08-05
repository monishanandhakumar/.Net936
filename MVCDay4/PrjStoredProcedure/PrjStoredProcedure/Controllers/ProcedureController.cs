using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjStoredProcedure.Models;
using Microsoft.EntityFrameworkCore;


namespace PrjStoredProcedure.Controllers
{
    public class ProcedureController : Controller
    {
        private readonly NorthwindContext db;

        public ProcedureController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult TenProducts()
        {
            return View(db.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]"));
        }

        public IActionResult Order()
        {
            string cid = "VINET";
            return View(db.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders] @p0",parameters:new[] {cid}));
        }

        
    }
}
