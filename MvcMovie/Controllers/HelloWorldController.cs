using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //call controller view method, use view template to generate html response
        public IActionResult Index()
        {
            return View();
        }

        //
        //Get: /HelloWorld/Welcome/
        //Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
