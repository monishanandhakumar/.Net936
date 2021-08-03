using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjEFCoreDBFirst.Models; //access info inside models folder

namespace PrjEFCoreDBFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;
        
        //constructor injection
        public CategoryController(NorthwindContext context)
        {
            db = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        #region Display category
        //1 display catrgory table 
        public IActionResult GetCategory()
        {
            // return View(db.Categories.ToList());
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        //With scaffolding
        public IActionResult GetCategorywithscaff()
        {
            return View(db.Categories.ToList()); 
        }

        #endregion


        #region Adding_new_category
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }


        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");
        }

        #endregion

        #region Display particular category details
        public IActionResult Details(int id)
        {
            Category category = db.Categories.Find(id);

            return View(category);

        }

        #endregion

        #region Editcategory details
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category c)
        {
            Category category = db.Categories.Find(c.CategoryId);
            category.CategoryName = c.CategoryName;
            category.Description = c.Description;
            category.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");

        }

        #endregion
    }
}
