using EFCoreThreeTireArchitectureAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreThreeTireArchitectureAPI.Services
{
  public interface IEmployeeRepository
    {
        //async
        Task<string> GetEmployeebyId(int id);

        //sync
        string GetEmp(int id);
    }
}
