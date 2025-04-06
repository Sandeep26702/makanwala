using Microsoft.AspNetCore.Mvc;

namespace makanwala.Controllers;
public class PropertyController : Controller
{
    // Goa Villa Details
    public IActionResult GoaVilla()
    {
        ViewData["Title"] = "Luxury Sea-Facing Villa";
        return View();
    }

    // Mumbai Penthouse Details
    public IActionResult MumbaiPenthouse()
    {
        ViewData["Title"] = "Penthouse with City View";
        return View();
    }

    // Bangalore Farmhouse Details
    public IActionResult BangaloreFarmhouse()
    {
        ViewData["Title"] = "Luxury Farm House";
        return View();
    }
}