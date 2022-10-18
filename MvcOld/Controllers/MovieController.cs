using MvcOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public static List<Movie> movies  = new List<Movie>();
        [Route("/getallmovies")]
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            if (movies.Count == 0)
            {
                movies.Add(new Movie()
                {
                    Name = "Kantara",
                    Ratings = 9.6,
                    TicketPrice = 250
                });
            }
            return View(movies);
            
        }

        [HttpGet]
        public ActionResult AddNewMovie()
        {
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult AddNewMovie(Movie mMovie)
        {
            movies.Add(mMovie);
            return View("GetAllMovies", movies);
        }

        [HttpGet]
        public ActionResult AddAjaxNewMovie()
        {
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult AddAjaxNewMovie(Movie mMovie)
        {
            movies.Add(mMovie);
            return PartialView("GetAllMovies", movies);
        }

        [HttpGet]
        public ActionResult UpdateMovie(string name)
        {
            Movie found = movies.Where(single => single.Name == name).ToList().FirstOrDefault();
            return View(found);
        }

        [HttpPost]

        public ActionResult UpdateMovie(Movie uMovie)
        {
            Movie found = movies.Where(single => single.Name == uMovie.Name).ToList().FirstOrDefault();
            found.Ratings = uMovie.Ratings;
            found.TicketPrice = uMovie.TicketPrice;
            return View("GetAllMovies", movies );
        }

        [HttpGet]
        public ActionResult DeleteMovie(string name)
        {
            Movie found = movies.Where(single => single.Name == name).ToList().FirstOrDefault();
            return View(found);
        }

        [HttpPost]

        public ActionResult DeleteMovie(Movie dMovie)
        {
            Movie found = movies.Where(single => single.Name == dMovie.Name).ToList().FirstOrDefault();
            movies.Remove(found);
            return View("GetAllMovies", movies);
        }
    }
}