using NakamaShop.Models;

namespace NakamaShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IShoppingCart ShoppingCart { get; set; } = default!;
        public decimal ShoppingCartTotal { get; set; }
    }
}