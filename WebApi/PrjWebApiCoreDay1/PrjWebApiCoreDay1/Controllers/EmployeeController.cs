using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrjWebApiCoreDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrjWebApiCoreDay1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly SampleContext db;

        public EmployeeController(SampleContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            List<Employee> emp = db.Employees.ToList();
            if (emp.Count > 0)
            {
                return Ok(emp);
            }

            else
            {
                return BadRequest("No Data found in employee");
            }
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {

            db.Employees.Add(employee);
            db.SaveChanges();
            return Ok("Record Added!!");

        }

        //Display employees of particular department

        //Passing Parameter as querystring
        [HttpGet]
        [Route("Getdept")]
        public IActionResult Get([FromQuery(Name ="deptname")]string deptname)
        {
            dynamic emp;
            try
            {

                var did = (from d in db.Departments
                           where d.Dname == deptname
                           select d.Deptid).SingleOrDefault();
                emp= (from e in db.Employees
                           where e.Deptid == did
                           select new { e.Name, e.Age, e.Deptid }).ToList();

            }
            
            catch(Exception e)
            {
                return NotFound("No Employee !!!");
            }

            return Ok(emp);

        }

        //Pass the employeename getsalary and calculate tax
    }
}
