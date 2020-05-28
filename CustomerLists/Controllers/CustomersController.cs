using System;
using System.Data.Entity;
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
            var people = _context._Customers.Include(c=> c.MembershipType).ToList();
            return View(people);
        }

        public ActionResult New()
        {
            
            var memTypes = _context._MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                MembershipTypes = memTypes
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(CustomerViewModel _customerAdded)
        {

            if (!ModelState.IsValid)
            {
                var ViewModel = new CustomerViewModel
                {
                    Customer = _customerAdded.Customer,
                    MembershipTypes = _context._MembershipTypes.ToList()
                };

                return View("CustomerForm", ViewModel);
            }


            if(_customerAdded.Customer.ID==0)
            _context._Customers.Add(_customerAdded.Customer);
            else
            {
                var CustomerInDb = _context._Customers.Single(c => c.ID == _customerAdded.Customer.ID);
                CustomerInDb.Name = _customerAdded.Customer.Name;
                CustomerInDb.DateofBirth = _customerAdded.Customer.DateofBirth;
                CustomerInDb.MembershipType = _customerAdded.Customer.MembershipType;
                CustomerInDb.MembershipTypeID = _customerAdded.Customer.MembershipTypeID;
                CustomerInDb.IsSubscribed = _customerAdded.Customer.IsSubscribed;
            }



            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");

        }



        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = _context._Customers.Include(c => c.MembershipType).SingleOrDefault(c=>c.ID==id);
            
            return View(customer);
        }

        [Route("customers/edit/{id}")]
        public ActionResult Edit(int id)
        {
            var customer = _context._Customers.SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context._MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}