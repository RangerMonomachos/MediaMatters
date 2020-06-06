using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class book
    {
        public int bookID { get; set; }
        public string title { get; set; }
        public string auther { get; set; }
        public string edition { get; set; }
        public string publication { get; set; }
        public string ISBN { get; set; }
        public string Reason { get; set; }
    }
}
