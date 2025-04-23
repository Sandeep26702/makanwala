using System.ComponentModel.DataAnnotations;

namespace makanwala.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }    // Primary Key

        [Required]
        public string Title { get; set; } = null!;

        public string Location { get; set; } = null!;

        public int Beds { get; set; }

        public int Baths { get; set; }

        public string Area { get; set; } = null!;

        public string Price { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string BadgeText { get; set; } = null!;

        public bool IsPremium { get; set; }

        public string[] Tags { get; set; } = null!;   // e.g. ["Waterfront", "Gated Community"]
    }
}
