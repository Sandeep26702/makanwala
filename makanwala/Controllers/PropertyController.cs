using Microsoft.AspNetCore.Mvc;

namespace makanwala.Controllers;
public class PropertyController : Controller
{
    // Goa Villa Details
    public IActionResult GoaVilla() 
    {
        return View(); // Looks for "GoaVilla.cshtml" in /Views/Property/
    }

    // Mumbai Penthouse Details
    public IActionResult MumbaiPenthouse() // Must match view name
    {
        return View(); // Looks in /Views/Property/ first
    }

    // Bangalore Farmhouse Details
    public IActionResult BangaloreFarmhouse()
    {
       
        return View();
    }
}