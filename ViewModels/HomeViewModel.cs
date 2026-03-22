using NakamaShop.Models;

namespace NakamaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AnimeProduct> ProductsOfTheWeek { get; set; }

        public HomeViewModel(IEnumerable<AnimeProduct> productsOfTheWeek)
        {
            ProductsOfTheWeek = productsOfTheWeek;
        }
    }
}