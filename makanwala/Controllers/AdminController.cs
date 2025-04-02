using Microsoft.AspNetCore.Mvc;

//[Authorize(Roles = "Admin")]

namespace makanwala.Controllers
{
    public class AdminController : Controller
    {
    // Static list to store properties (temporary replacement for database)
    private static List<Property> _properties = new List<Property>
    {
        new Property { Id = 1, Title = "Luxury Villa", Price = 45000000, City = "Goa", Type = PropertyType.House },
        new Property { Id = 2, Title = "Modern Apartment", Price = 22000000, City = "Mumbai", Type = PropertyType.Apartment }
    };

        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Properties List
        public IActionResult Properties()
        {
            return View(_properties);
        }

        // GET: Add Property Form
        public IActionResult AddProperty()
        {
            return View();
        }

        // POST: Add Property
        [HttpPost]
        public IActionResult AddProperty(Property property)
        {
            property.Id = _properties.Count + 1;
            _properties.Add(property);
            return RedirectToAction("Properties");
        }

        // GET: Edit Property
        public IActionResult EditProperty(int id)
        {
            var property = _properties.FirstOrDefault(p => p.Id == id);
            if (property == null) return NotFound();
            return View(property);
        }

        // POST: Update Property
        [HttpPost]
        public IActionResult EditProperty(Property updatedProperty)
        {
            var index = _properties.FindIndex(p => p.Id == updatedProperty.Id);
            if (index != -1)
            {
                _properties[index] = updatedProperty;
            }
            return RedirectToAction("Properties");
        }

        // Delete Property
        public IActionResult DeleteProperty(int id)
        {
            _properties.RemoveAll(p => p.Id == id);
            return RedirectToAction("Properties");
        }
    }