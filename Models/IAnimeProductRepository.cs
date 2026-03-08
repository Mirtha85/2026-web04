namespace NakamaShop.Models
{
    public interface IAnimeProductRepository
    {
        IEnumerable<AnimeProduct> AllAnimeProducts { get; }
        IEnumerable<AnimeProduct> ProductsOfTheWeek { get; }
        AnimeProduct? GetAnimeProductById(int animeProductId);
    }
}