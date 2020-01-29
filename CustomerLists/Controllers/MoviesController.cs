using CustomerLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerLists.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        List<Movies> movies = new List<Movies>() {

        new Movies{ MovieName = "Shrek",Synopsis="Shrek, an ogre, embarks on a journey with a donkey to rescue Princess Fiona from a vile lord and regain his swamp."},
        new Movies{MovieName = "Star Trek", Synopsis = "James T Kirk, who is the captain of the Starship Enterprise, explores the whole galaxy with his crew and goes on several adventures as they fight evil forces together." },
        new Movies {MovieName = "Zindagi Na Milegi Dobara", Synopsis = "Friends Kabir, Imran and Arjun take a vacation in Spain before Kabir's marriage. The trip turns into an opportunity to mend fences, heal wounds, fall in love with life and combat their worst fears." }
        };

        List<Person> people = new List<Person>() {
            new Person {Name = "Chintu Chaudhary" },
            new Person  {Name  =  "Brandon King" } ,
            new Person { Name  = "Olivia Pullman"} };


        [Route("movies/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("movies/listcustomers")]
        public ActionResult ListCustomers()
        {
            return View(people);
        }

      [Route("movies/listmovies")]
        public ActionResult ListMovies()
        {
            return View(movies);
        }


    }
}