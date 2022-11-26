using Microsoft.AspNetCore.Mvc;

namespace wcup.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(int time, int numTimes = 1)
        {
            ViewData["Message"] = "Match time" + time;
            ViewData["NumTimes"] = numTimes;
            return View();

        }
    }
}
