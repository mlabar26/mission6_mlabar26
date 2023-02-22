using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission6_mlabar26.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_mlabar26.Controllers
{
    public class HomeController : Controller
    {
        private MovieInfoContext _MovieInfo { get; set; }

        public HomeController(MovieInfoContext movie)
        {
            _MovieInfo = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = _MovieInfo.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(movieForm mf)
        {
            _MovieInfo.Add(mf);
            _MovieInfo.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies = _MovieInfo.Responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        public IActionResult Edit ()
        {
            ViewBag.Categories = _MovieInfo.Categories.ToList();
            //var movie = _MovieInfo.Responses.Single();
            return View("AddMovies");
        }

        public IActionResult Delete ()
        {
            return View();
        }
    }
}
