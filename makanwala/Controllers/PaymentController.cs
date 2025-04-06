using makanwala.Models;
using Microsoft.AspNetCore.Mvc;

namespace makanwala.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult BookNow(int propertyId)
        {
            var property = PropertyData.GetTopOffers().FirstOrDefault(p => p.Id == propertyId);
            if (property == null || !property.IsAvailable)
            {
                return NotFound();
            }

            // Calculate 10% advance
            var advanceAmount = property.Price * 0.1m;

            var model = new BookingViewModel
            {
                PropertyId = property.Id,
                PropertyTitle = property.Title,
                PropertyImage = property.ImageUrl,
                AdvanceAmount = advanceAmount
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ProcessBooking(BookingViewModel model)
        {
            // In a real app: Process payment and save booking
            // For demo, we'll just mark property as booked
            var property = PropertyData.GetTopOffers().FirstOrDefault(p => p.Id == model.PropertyId);
            if (property != null)
            {
                property.IsAvailable = false;
            }

            return RedirectToAction("BookingConfirmation", new
            {
                propertyId = model.PropertyId,
                transactionId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
            });
        }

        public IActionResult BookingConfirmation(int propertyId, string transactionId)
        {
            var property = PropertyData.GetTopOffers().FirstOrDefault(p => p.Id == propertyId);
            if (property == null)
            {
                return NotFound();
            }

            ViewBag.TransactionId = transactionId;
            return View(property);
        }
    }
}