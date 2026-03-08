using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;
using NakamaShop.ViewModels; // No olvides este using

namespace NakamaShop.Controllers
{
    public class AnimeController : Controller
    {
        private readonly IAnimeProductRepository _animeProductRepository;

        public AnimeController(IAnimeProductRepository animeProductRepository)
        {
            _animeProductRepository = animeProductRepository;
        }

        public IActionResult List()
        {
            // Creamos el ViewModel con los 50 productos y un título personalizado
            AnimeListViewModel animeListViewModel = new AnimeListViewModel(
                _animeProductRepository.AllAnimeProducts, 
                "Todos los Tesoros del Grand Line"
            );

            return View(animeListViewModel);
        }
    }
}