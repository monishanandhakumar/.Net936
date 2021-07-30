using Microsoft.AspNetCore.Mvc;
using PrjMvcfirstcoreapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMvcfirstcoreapp.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Displaydept()
        {
            Department department = new Department();
            department.did = 101;
            department.dname = "ADMIN";
            return View(department);
        }

        public IActionResult ListDept()
        {
            List<Department> dept = new List<Department>();
            dept.Add(new Department {did=101,dname="Admin" });
            dept.Add(new Department { did = 102, dname = "UX" });
            dept.Add(new Department { did = 103, dname = "HR" });
            return View(dept);
        }


    }
}
