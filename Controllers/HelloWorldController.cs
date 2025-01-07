using Microsoft.AspNetCore.Mvc;

namespace CineComplex_MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: /HelloWorld
        public string Index()
        {
            return "This is my <b>Default</b> action.";
        }

        // GET: /HelloWorld/Welcome
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

       
    }
}


