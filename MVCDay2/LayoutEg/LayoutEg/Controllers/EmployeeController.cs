using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutEg.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmpInfo()
        {
            return View();
        }

        public IActionResult Deleteemp()
        {
            return View();
        }

    }
}
