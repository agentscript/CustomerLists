using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using CustomerLists.Migrations;
using CustomerLists.Models;


namespace CustomerLists.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ViewResult Index()
        {
            var people = _context._Customers.ToList();
            return View(people);
        }

        public ActionResult New()
        {
            
            var memTypes = _context._MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = memTypes
            };
            return View(viewModel);
        }


        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = _context._Customers.SingleOrDefault(c=>c.ID==id);
            
            return View(customer);
        }




    }
}