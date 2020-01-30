using CustomerLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CustomerLists.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        List<Movies> movies = new List<Movies>() {

        new Movies{ ID =1,MovieName = "Shrek",Synopsis="Shrek, an ogre, embarks on a journey with a donkey to rescue Princess Fiona from a vile lord and regain his swamp."},
        new Movies{ID=2,MovieName = "Star Trek", Synopsis = "James T Kirk, who is the captain of the Starship Enterprise, explores the whole galaxy with his crew and goes on several adventures as they fight evil forces together." },
        new Movies {ID =3,MovieName = "Zindagi Na Milegi Dobara", Synopsis = "Friends Kabir, Imran and Arjun take a vacation in Spain before Kabir's marriage. The trip turns into an opportunity to mend fences, heal wounds, fall in love with life and combat their worst fears." }
        };



        [Route("movies/Index")]
        public ActionResult Index()
        {
            return View(movies);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            Movies movie = null;
            foreach(Movies m in movies) {
                if (m.ID == id)
                    movie = m;
            }
            return View(movie);
        }

        
     

    }
}