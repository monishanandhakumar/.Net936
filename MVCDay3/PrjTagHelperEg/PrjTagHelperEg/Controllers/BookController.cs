using Microsoft.AspNetCore.Mvc;
using PrjTagHelperEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjTagHelperEg.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookIndex()
        {
            return View();
        }
        public IActionResult AddBook()
        {
            return View();
        }
        List<Book> b = new List<Book>();
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            b.Add(book);
            return RedirectToAction("DisplayBook", b);
        }
        public IActionResult DisplayBook(dynamic booklist)
        {
            
            return View(booklist);
        }

    }
}
