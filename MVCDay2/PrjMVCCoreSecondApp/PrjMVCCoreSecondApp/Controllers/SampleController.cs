using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMVCCoreSecondApp.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
