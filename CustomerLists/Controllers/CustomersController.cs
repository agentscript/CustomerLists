using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerLists.Models;

namespace CustomerLists.Controllers
{
    public class CustomersController : Controller
    {

        List<Customers> people = new List<Customers>() {
            new Customers {Name = "Chintu Chaudhary" },
            new Customers  {Name  =  "Brandon King" } ,
            new Customers { Name  = "Olivia Pullman"} };

        // GET: Customers
        public ActionResult Index()
        {
            return View(people);
        }
    }
}