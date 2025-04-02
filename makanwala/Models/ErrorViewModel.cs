namespace makanwala.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
public class Property
{
    // ... existing properties ...
    public bool IsPremium { get; set; }
    public string[] Tags { get; set; } // ["Waterfront", "Gated Community", etc.]
}
