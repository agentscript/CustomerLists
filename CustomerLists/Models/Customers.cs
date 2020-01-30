using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerLists.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public DateTime DateofBirth { get; set; }


        public int GetAge() {
            var Today = DateTime.Today;
            return Today.Year - this.DateofBirth.Year;
        }


    }
}