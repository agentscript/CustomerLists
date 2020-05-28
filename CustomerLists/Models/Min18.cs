using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace CustomerLists.Models
{
    public class Min18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validation)
        {
            var customer  = (Customer)validation.ObjectInstance;
            if(customer.MembershipTypeID== MembershipType.PayAsYouGo || customer.MembershipTypeID == MembershipType.Unknown)
                return ValidationResult.Success;
            if (customer.DateofBirth == null)
                return new ValidationResult("Birthday is required");

            var age = DateTime.Now.Year - customer.DateofBirth.Year;
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer's Age is less than 18");


        }

        
    }
}