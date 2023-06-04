namespace Ecommerce_Website.Models
{
    public class Banner:BaseEntity<int>
    {   
        public string Label { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
