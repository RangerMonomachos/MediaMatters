using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMatters.Models;


namespace MediaMatters.Controllers
{
    public class HomeController: Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly IBookRepository br;
        //private readonly IAlbumRepository ar;
        //private readonly IMovieRepository mr;
        //public HomeController(IBookRepository bookRepository)
        //{
        //    br = bookRepository;
        //}
        //public HomeController(IAlbumRepository albumRepository)
        //{
        //    ar = albumRepository;
        //}
        //public HomeController(IMovieRepository movieRepository)
        //{
        //    mr = movieRepository;
        //}
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Albums()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }
    }
}
