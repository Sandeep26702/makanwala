using Microsoft.AspNetCore.Mvc;

//[Authorize(Roles = "Admin")]

namespace makanwala.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            // Add your dashboard statistics logic here
            return View();
        }

        public IActionResult Properties()
        {
            // Add properties management logic
            return View();
        }

        public IActionResult Categories()
        {
            // Add categories management logic
            return View();
        }

        public IActionResult Users()
        {
            // Add users management logic
            return View();
        }

        public IActionResult Messages()
        {
            // Add contact messages logic
            return View();
        }
    }
}
