using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrjCodeFirstincore.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Suppliername { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
