using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace CineComplexAdminMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld

        static int num = 5;
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld
        //public IActionResult Index()
        //{
        //    string htmlContent = "This is my <b>Default</b> action in custome Index().";
        //    return Content(htmlContent, "text/html");
        //}

        // GET: /HelloWorld/Welcome
        //[HttpGet("HelloWorld/Welcome")]
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome
        //[HttpGet("HelloWorld/Welcome")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //string htmlContent = "This is the Welcome action method...";
            //return Content(htmlContent, "text/html");

            ViewData["checks"] = numTimes;
            ViewData["name"] = name;
            return View();
        }


        /*
         * Method overloading is a fundamental concept in many programming languages, allowing for multiple methods with the same name 
         * but different parameters. However, in the context of ASP.NET MVC (and web frameworks in general), method overloading can sometimes 
         * be tricky due to how routing and HTTP requests are handled.
         * 
         * In traditional method overloading, the method signatures (parameters) distinguish between different versions of a method. 
         * In ASP.NET MVC, routing maps URLs to specific controller actions, and relying on method overloading alone can lead to route conflicts or ambiguities, 
         * especially when dealing with HTTP GET requests.
         * 
         */

        // GET: /HelloWorld/Welcome?name=someStringValue?numTimes=someIntegerValue
        //[HttpGet("HelloWorld/Welcome2/{name}/{numTimes}")]
        public string Welcome2(string name, int numTimes = 1)
        {
            num += numTimes;
            ViewData["Clicks"] = num;
            return HttpUtility.HtmlEncode($"This is {name} clicks {num} times");
        }

    }
}




