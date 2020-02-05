using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;





namespace CustomerLists.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> _Customers { get; set; }
        public DbSet<Movies> _Movies { get; set; }

        public ApplicationDbContext()
        {
        }
    }
}