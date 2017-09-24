using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
            //return RedirectToAction("About", "Home");
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            /*if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));*/

            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Name = "Zootopia" },
                new Movie { Name = "Despicable Me"}
            };
        }

        public ActionResult ByReleaseYearAndMonth(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/releaseyear/{year:regex(\\d{4})}")]
        public ActionResult ByReleaseYear(int year)
        {
            return Content("Year:" + year);
        }
    }
}