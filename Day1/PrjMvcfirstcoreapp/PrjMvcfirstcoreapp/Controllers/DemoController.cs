using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMvcfirstcoreapp.Models;

namespace PrjMvcfirstcoreapp.Controllers
{
    public class DemoController : Controller
    {

        //controller - Collection of action Methods
        public IActionResult Index()
        {
            return View();
        }
        //Normal Method

        public string MyName()
        {
            return "Devi";
        }

        //Action Method returing view result
        public ViewResult GetData()
        {
            return View();
        }
        //if we want to display only some set of strings
        //ContentResult
        public ContentResult Data()
        {
            return Content("<h1>Good Noon</h1>","text/html");
        }

        //Empty Result
        int simpleinterest;
        [NonAction]
        public EmptyResult SI()
        {
             simpleinterest = 1000 * 3 * 2 / 100;
            return new EmptyResult();
        }

        //returing json data

       public JsonResult Persondata()
        {
            Person person = new Person();
            person.Name = "SASI";
            person.City = "Mumbai";
            return Json(person);

        }

        public IActionResult Sample()
        {
            // return Content("<h2>Hello </h2>","text/html");
            Person person = new Person();
            person.Name = "SASI";
            person.City = "Mumbai";
            return Json(person);
        }

    }
}
