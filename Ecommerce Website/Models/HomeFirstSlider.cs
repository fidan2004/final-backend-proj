using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Ecommerce_Website.Models;

public class HomeFirstSlider:BaseEntity<int>
{
    public string Precent { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
