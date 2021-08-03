using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMVCCoreSecondApp.Controllers
{
    public class DemoController : Controller
    {
        //Tempdata,controller->view, one action to another action method, one controller to another controller
        public IActionResult Index()
        {

            dynamic a = 10; //int
            a = "Apple";  //string
            a = 10.09f;  //float
            a = 'c';    //char
           

            TempData["Message"] = "Hello MVC Core!";
            return RedirectToAction("Index", "Sample");
        }

        //both viewbag and viewdata transfer the data from controller to view
        //but viewbag is dynamic property ,viewdata is dictionary (expicit conversion is required)
        public IActionResult GetFruits()
        {
            List<string> fruit =new List<string>() { "Mango", "Orange", "Apple" };

            ViewData["fruitsname"] = fruit;

            ViewBag.fruitname = fruit;
            return View();
        }

        
        


       
       

       

    }
}
