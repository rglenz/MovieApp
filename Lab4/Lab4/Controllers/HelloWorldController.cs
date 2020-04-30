using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lab4.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "My Name is " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}