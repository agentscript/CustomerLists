using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using Microsoft.Ajax.Utilities;

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