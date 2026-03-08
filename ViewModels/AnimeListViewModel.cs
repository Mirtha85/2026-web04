using NakamaShop.Models;

namespace NakamaShop.ViewModels
{
    public class AnimeListViewModel
    {
        public IEnumerable<AnimeProduct> AnimeProducts { get; }
        public string? CurrentCategory { get; }

        public AnimeListViewModel(IEnumerable<AnimeProduct> animeProducts, string? currentCategory)
        {
            AnimeProducts = animeProducts;
            CurrentCategory = currentCategory;
        }
    }
}