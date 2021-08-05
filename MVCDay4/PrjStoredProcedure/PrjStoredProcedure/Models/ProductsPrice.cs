using System;
using System.Collections.Generic;

#nullable disable

namespace PrjStoredProcedure.Models
{
    public partial class ProductsPrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
