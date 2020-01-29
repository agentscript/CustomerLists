using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerLists.Models
{
    public class ViewModelMoviePerson
    {

        public Person Person {get;set;}
        public List<Movies> MoviesSeen { get; set; }

    }
}