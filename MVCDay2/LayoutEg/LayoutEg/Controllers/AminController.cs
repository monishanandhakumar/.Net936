using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutEg.Controllers
{
    public class AminController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }

        public IActionResult DeleteEmployee()
        {
            return View();
        }
    }
}
