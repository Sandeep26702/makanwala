using makanwala.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace makanwala.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TopOffers()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string subject, string message)
        {
            // Add your contact form processing logic here
            // This is just a placeholder - implement email sending or database storage later

            TempData["SuccessMessage"] = "Thank you! Your message has been sent.";
            return RedirectToAction("Contact");
        }
    }
}
    

//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
