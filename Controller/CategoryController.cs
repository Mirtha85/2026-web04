using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;
using NakamaShop.ViewModels;

namespace NakamaShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            // Obtenemos todas las categorías (Figuras, Manga, Ropa, etc.)
            var categories = _categoryRepository.AllCategories;

            // Creamos el ViewModel específico para la vista de categorías
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel(
                categories, 
                "Explora por Categoría"
            );

            return View(categoryListViewModel);
        }
    }
}