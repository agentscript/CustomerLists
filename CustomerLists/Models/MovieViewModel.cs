using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerLists.Models
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genre;
        public Movies Movies;
    }
}