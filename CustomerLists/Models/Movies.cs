using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerLists.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public String MovieName { get; set; }
        public String Synopsis { get; set; }
        public string Rating { get; set; }
    }
}