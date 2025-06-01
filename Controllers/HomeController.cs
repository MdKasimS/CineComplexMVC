using CineComplex_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CineComplex_MVC.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*
         * Do check out /Views. You can see controller named /Home
         * which contains 2 Razor pages Index & Privacy. Parllay you can check
         * HomeController.cs contains 2 methods named Index() and Privacy()
         * These two methods return "Views" for URLs as follows:
         *  1. GET: /Home                           -> Index() method is invoked
         *     (or its an index page so simly '/')
         *  2. GET: /Home/Privacy                   -> Privacy() method is invoked    
         *  
         *  
         */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
