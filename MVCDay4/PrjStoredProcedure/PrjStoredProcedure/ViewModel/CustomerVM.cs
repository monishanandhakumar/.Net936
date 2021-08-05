using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrjStoredProcedure.ViewModel
{
    public class CustomerVM
    {
        [Key]
        public string CustomerId { get; set; } //Customer.cs
        public string CompanyName { get; set; }//Customer.cs
        public int OrderId { get; set; } //Order.cs
        public DateTime? OrderDate { get; set; } //Order.cs
    }
}
