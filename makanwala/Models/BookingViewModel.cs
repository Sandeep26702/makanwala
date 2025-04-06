using System.ComponentModel.DataAnnotations;

namespace makanwala.Models
{

    public class BookingViewModel
    {
        public int PropertyId { get; set; }
        public string PropertyTitle { get; set; }
        public string PropertyImage { get; set; }
        public decimal AdvanceAmount { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }
    }
}