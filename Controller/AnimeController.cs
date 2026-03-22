using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;
using NakamaShop.ViewModels;

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
            AnimeListViewModel animeListViewModel = new AnimeListViewModel(
                _animeProductRepository.AllAnimeProducts,
                "Todos los Tesoros del Grand Line"
            );

            return View(animeListViewModel);
        }

        public IActionResult Details(int id)
        {
            var animeProduct = _animeProductRepository.GetAnimeProductById(id);
            if (animeProduct == null)
                return NotFound();

            return View(animeProduct);
        }
    }
}