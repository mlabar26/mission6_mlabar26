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
            if (ModelState.IsValid)
            {
                _MovieInfo.Add(mf);
                _MovieInfo.SaveChanges();
                return RedirectToAction("MovieList");
            }

            else
            {
                ViewBag.Categories = _MovieInfo.Categories.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            ViewBag.Categories = _MovieInfo.Categories.ToList();
            var movies = _MovieInfo.Responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieID)
        {
            ViewBag.Categories = _MovieInfo.Categories.ToList();
            var movie = _MovieInfo.Responses.Single(x => x.movieID == movieID);
            return View("AddMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit(movieForm mf)
        {
            if (ModelState.IsValid)
            {
                _MovieInfo.Update(mf);
                _MovieInfo.SaveChanges();
                return RedirectToAction("MovieList");
            }

            else
            {
                ViewBag.Categories = _MovieInfo.Categories.ToList();
                return View("AddMovies");
            }
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
