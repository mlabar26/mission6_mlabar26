using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext _MovieInfo { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext movie)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(movieForm mf)
        {
            _MovieInfo.Add(mf);
            _MovieInfo.SaveChanges();
            return View();
        }

        public IActionResult MovieList ()
        {
            return View();
        }
    }
}
