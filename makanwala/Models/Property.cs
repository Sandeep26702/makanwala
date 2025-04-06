namespace makanwala.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double Area { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public bool IsFeatured { get; set; }
        public string ImageUrl { get; set; }
        public List<string> GalleryImages { get; set; } = new List<string>();
        public List<string> Amenities { get; set; } = new List<string>();

        // New property for booking status
        public bool IsAvailable { get; set; } = true;
    }

    public static class PropertyData
    {
        public static List<Property> GetTopOffers()
        {
            return new List<Property>
        {
            new Property {
                Id = 1,
                Title = "Luxury Beachfront Villa",
                Description = "Stunning 5-bedroom villa with private beach access",
                Price = 75000000,
                Bedrooms = 5,
                Bathrooms = 4,
                Area = 5500,
                Location = "Goa",
                City = "North Goa",
                IsFeatured = true,
                ImageUrl = "/images/properties/villa1.jpg",
                GalleryImages = new List<string> {
                    "/images/properties/villa1.jpg",
                    "/images/properties/villa2.jpg",
                    "/images/properties/villa3.jpg"
                },
                Amenities = new List<string> {
                    "Private Pool", "Beach Access", "Gym",
                    "Home Theater", "24/7 Security"
                }
            },
            // Add more properties...
        };
        }
    }
}