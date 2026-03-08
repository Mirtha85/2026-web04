namespace NakamaShop.Models
{
    public class AnimeProduct
    {
        public int AnimeProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AnimeSeries { get; set; } = string.Empty; // Ej: "Naruto", "Dragon Ball"
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsProductOfTheWeek { get; set; } 
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}