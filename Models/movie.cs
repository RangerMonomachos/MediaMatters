using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class movie
    {
        public int movieID { get; set; }
        public string title { get; set; }
        public string release { get; set; }
        public string runtime { get; set; }
        public string reason { get; set; }
    }
}
