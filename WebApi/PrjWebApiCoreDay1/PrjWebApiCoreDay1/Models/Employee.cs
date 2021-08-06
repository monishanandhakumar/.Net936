using System;
using System.Collections.Generic;

#nullable disable

namespace PrjWebApiCoreDay1.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public int? Deptid { get; set; }
        public int? Salary { get; set; }
        public string Password { get; set; }

        public virtual Department Dept { get; set; }
    }
}
