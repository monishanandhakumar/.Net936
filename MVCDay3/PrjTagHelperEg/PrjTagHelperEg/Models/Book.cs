using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjTagHelperEg.Models
{
    public class Book
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }

        public string Author { get; set; }
        public int Totalpages { set; get; }
        public string Description { get; set; }

        public List<string> BookType { get; set; }

    }
}
