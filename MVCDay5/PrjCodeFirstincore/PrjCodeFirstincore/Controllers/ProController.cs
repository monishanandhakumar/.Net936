using Microsoft.AspNetCore.Mvc;
using PrjCodeFirstincore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjCodeFirstincore.Controllers
{
    public class ProController : Controller
    {
        private readonly EFContext db;

        public ProController(EFContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {

            return View(db.Products.ToList());
        }
    }
}
