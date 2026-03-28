namespace NakamaShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(AnimeProduct animeProduct);
        int RemoveFromCart(AnimeProduct animeProduct);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}