namespace NakamaShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NakamaShopDbContext _nakamaShopDbContext;

        public CategoryRepository(NakamaShopDbContext nakamaShopDbContext)
        {
            _nakamaShopDbContext = nakamaShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _nakamaShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}