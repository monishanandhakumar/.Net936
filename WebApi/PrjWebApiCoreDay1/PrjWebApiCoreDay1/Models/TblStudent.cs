using System;
using System.Collections.Generic;

#nullable disable

namespace PrjWebApiCoreDay1.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TotalMarks { get; set; }
    }
}
