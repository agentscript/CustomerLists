using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerLists.Models;

namespace CustomerLists.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        private ApplicationDbContext _context = null;

        public IEnumerable<Movies> GetMovies()
        {
            
            var movies = _context._Movies.Include(c=> c.Genre).ToList();
            return movies;
        }



        [Route("movies/Index")]
        public ActionResult Index()
        {

            return View(GetMovies());
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var Movies = _context._Movies.Include(c=>c.Genre).SingleOrDefault(c => c.ID==id);
            
            return View(Movies);
        }

        public ActionResult New()
        {
            var GenreType = _context._Genre.ToList();
            var viewModel = new MovieViewModel
            {
                Genre = GenreType
            };
            return View("Save", viewModel);
        }

        [Route("movies/edit/{id}")]
        public ActionResult Edit(int id)
        {
            var movies = _context._Movies.SingleOrDefault(c => c.ID == id);
            if (movies == null)
                return HttpNotFound();
            var viewModel = new MovieViewModel()
            {
                Movies = movies,
                Genre = _context._Genre.ToList()
            };
            return View("Save", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movies Movies)
        {
            if (Movies.MovieName != null)
            {
                _context._Movies.Add(Movies);
                _context.SaveChanges();
                return RedirectToAction("Index", "Movies");
            }

            return RedirectToAction("New", "Movies");
        }




    }
}