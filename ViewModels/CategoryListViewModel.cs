using NakamaShop.Models;

namespace NakamaShop.ViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories { get; }
        public string? Title { get; }

        public CategoryListViewModel(IEnumerable<Category> categories, string? title)
        {
            Categories = categories;
            Title = title;
        }
    }
}