using EFCoreThreeTireArchitectureAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreThreeTireArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //BAL-BusinessAccessLayer
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository context)
        {
            employeeRepository = context;
        }

        [HttpGet("{empid}")]
        public async Task<IActionResult> GetEmployeeName(int empid)
        {
            dynamic employee=await employeeRepository.GetEmployeebyId(empid);

            if(employee!=null)
            {
                return Ok(employee);
            }
            else
            {
                //return NotFound(" No Employee data found !!!");
                return Ok(" No Employee data found !!!");
            }
          
        }

    }
}
