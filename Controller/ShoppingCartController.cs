using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;
using NakamaShop.ViewModels;

namespace NakamaShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IAnimeProductRepository _animeProductRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IAnimeProductRepository animeProductRepository,
                                      IShoppingCart shoppingCart)
        {
            _animeProductRepository = animeProductRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var viewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(viewModel);
        }

        public IActionResult AddToShoppingCart(int animeProductId)
        {
            var selectedProduct = _animeProductRepository.AllAnimeProducts
                .FirstOrDefault(p => p.AnimeProductId == animeProductId);

            if (selectedProduct != null)
                _shoppingCart.AddToCart(selectedProduct);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int animeProductId)
        {
            var selectedProduct = _animeProductRepository.AllAnimeProducts
                .FirstOrDefault(p => p.AnimeProductId == animeProductId);

            if (selectedProduct != null)
                _shoppingCart.RemoveFromCart(selectedProduct);

            return RedirectToAction("Index");
        }
    }
}