using Microsoft.AspNetCore.Mvc;

namespace makanwala.Controllers
{
    public class AccountController : Controller
    {
       
    [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

       
        [HttpGet]
        public IActionResult Forgot()
        {
            return View(); // Make sure this view exists
        }

        
    }
}

