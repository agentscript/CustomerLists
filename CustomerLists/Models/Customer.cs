using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerLists.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }

        public int GetAge() {
            var Today = DateTime.Today;
            return Today.Year - this.DateofBirth.Year;
        }


    }
}