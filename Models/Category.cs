namespace NakamaShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty; // Ej: "Figuras", "Manga", "Ropa"
        public string? Description { get; set; }
        public List<AnimeProduct>? AnimeProducts { get; set; }
    }
}