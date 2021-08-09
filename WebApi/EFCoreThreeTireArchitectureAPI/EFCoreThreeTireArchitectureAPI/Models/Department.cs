using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreThreeTireArchitectureAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Deptid { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
