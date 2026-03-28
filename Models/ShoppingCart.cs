using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NakamaShop.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly NakamaShopDbContext _nakamaShopDbContext;

        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(NakamaShopDbContext nakamaShopDbContext)
        {
            _nakamaShopDbContext = nakamaShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services
                .GetRequiredService<IHttpContextAccessor>()
                ?.HttpContext?.Session;

            NakamaShopDbContext context = services
                .GetService<NakamaShopDbContext>()
                ?? throw new Exception("Error al inicializar el carrito");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(AnimeProduct animeProduct)
        {
            var shoppingCartItem =
                _nakamaShopDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.AnimeProduct.AnimeProductId == animeProduct.AnimeProductId
                      && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    AnimeProduct = animeProduct,
                    Amount = 1
                };
                _nakamaShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _nakamaShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(AnimeProduct animeProduct)
        {
            var shoppingCartItem =
                _nakamaShopDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.AnimeProduct.AnimeProductId == animeProduct.AnimeProductId
                      && s.ShoppingCartId == ShoppingCartId);

            int localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _nakamaShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _nakamaShopDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                _nakamaShopDbContext.ShoppingCartItems
                    .Where(c => c.ShoppingCartId == ShoppingCartId)
                    .Include(s => s.AnimeProduct)
                    .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _nakamaShopDbContext.ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _nakamaShopDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _nakamaShopDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            return _nakamaShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.AnimeProduct.Price * c.Amount)
                .Sum();
        }
    }
}