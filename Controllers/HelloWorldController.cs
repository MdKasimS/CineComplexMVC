using Microsoft.AspNetCore.Mvc;
using System.Web;

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
        [HttpGet("Home/Welcome")]
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // GET: /HelloWorld/Welcome?name=someStringValue?numTimes=someIntegerValue
        [HttpGet("Home/Welcome/{name}/{numTimes}")]
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode($"This is {name} clicks {numTimes} times");
        }

    }
}


