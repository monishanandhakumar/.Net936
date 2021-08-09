using EFCoreThreeTireArchitectureAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreThreeTireArchitectureAPI.Services
{
    public class EmployeeService:IEmployeeRepository
    {
        private readonly SampleContext db;

        public EmployeeService(SampleContext context)
        {
            db = context;
        }

        //Sync way
        public string GetEmp(int id)
        {
            dynamic empname = db.Employees.Where(e => e.EmpId == id).Select(n => n.Name).FirstOrDefault();
            return empname;
        }

        //Async way to increase cpu performance 
      public  async Task<string> GetEmployeebyId(int id)
        {
           dynamic emp =await db.Employees.Where(e => e.EmpId == id).Select(n => n.Name).FirstOrDefaultAsync();
            return emp;
        }
    }
}
