using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [Route("movies/movies")]
        public ActionResult Movies()
        {
        
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Zoomania"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);

        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if(!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if(String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex = {0} and sortBy = {1}", pageIndex, sortBy));
        //}

        ////:regex(\\d{2}):range(1-12)
        //[Route("movies/released/{year}/{month}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}