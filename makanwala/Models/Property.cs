public class Property
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public string City { get; set; }
    public PropertyType Type { get; set; }
    public string ImageUrl { get; set; }
}

public enum PropertyType
{
    House,
    Apartment,
    Condo,
    Land
}