using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wcup.Models;

namespace wcup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Details(int id)
        {
            if (id == 1)
            {
                return "Tunisia   1 : 0   Australia";
            }
            else if (id == 2)
            {
                return "Pháp   4 : 0   Đan Mạch";
            }
            else if (id == 3)
            {
                return "ABC   1 : 1   Bồ Đào Nha";
            }
            else
                return "No match found!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}