using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace makanwala.Controllers
{
   
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // यह action /Admin और /Admin/Dashboard दोनों को handle करेगा
        public IActionResult Dashboard()
        {
            return View();
        }

        // अन्य actions...
    }
}
