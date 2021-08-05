using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjRoutingEg.Controllers
{
   //Attribute Routing
    [Route("Books")]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("All")]
        public IActionResult Getallbooks()
        {
            return View();
        }

        //fetching book by bookid

        [Route("byid/{id:int?}")]
        public IActionResult Getbookbyid(int id)
        {
            return View();
        }

        //fetching book by author

        [Route("{name=John}")]
        public IActionResult Getbookbyauthorname(string name)
        {
            return View();
        }

        //Route Constraint
        [Route("{name:maxlength(10)}")]
        public IActionResult GetbookbyName(string name)
        {
            return View();
        }

    }
}
