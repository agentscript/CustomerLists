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

        [Display(Name="Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d/mmm/yyyy}")]
        [Min18]
        public DateTime DateofBirth { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership ID Custom Name")]
        public byte MembershipTypeID { get; set; }

        public bool IsSubscribed { get; set; }

        public int GetAge()
        {
            if (this.DateofBirth != null)
            {
                var Today = DateTime.Today;
                return Today.Year - this.DateofBirth.Year;
            }
            else return 0;


        }
    }


    }
