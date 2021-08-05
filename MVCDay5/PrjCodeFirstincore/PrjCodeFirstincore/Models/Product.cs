using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrjCodeFirstincore.Models
{
    public class Product
    {
        [Key]
        public int Pid{get;set;}
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
