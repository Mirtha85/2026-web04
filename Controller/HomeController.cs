using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;
using NakamaShop.ViewModels;

namespace NakamaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimeProductRepository _animeProductRepository;

        public HomeController(IAnimeProductRepository animeProductRepository)
        {
            _animeProductRepository = animeProductRepository;
        }

        public IActionResult Index()
        {
            var productsOfTheWeek = _animeProductRepository.ProductsOfTheWeek;
            var homeViewModel = new HomeViewModel(productsOfTheWeek);
            return View(homeViewModel);
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            ViewBag.Success = "¡Message sent successfully! We will contact you soon. ⚓";
            return View();
        }
    }
}