using Microsoft.EntityFrameworkCore;

namespace NakamaShop.Models
{
    public class AnimeProductRepository : IAnimeProductRepository
    {
        private readonly NakamaShopDbContext _nakamaShopDbContext;

        public AnimeProductRepository(NakamaShopDbContext nakamaShopDbContext)
        {
            _nakamaShopDbContext = nakamaShopDbContext;
        }

        // Obtiene todos los productos incluyendo su categoría asociada
        public IEnumerable<AnimeProduct> AllAnimeProducts => 
            _nakamaShopDbContext.AnimeProducts.Include(a => a.Category);

        // Filtra solo los productos marcados como 'de la semana'
        public IEnumerable<AnimeProduct> ProductsOfTheWeek => 
            _nakamaShopDbContext.AnimeProducts.Include(a => a.Category)
                                             .Where(a => a.IsProductOfTheWeek);

        // Busca un producto específico por su ID
        public AnimeProduct? GetAnimeProductById(int animeProductId)
        {
            return _nakamaShopDbContext.AnimeProducts.FirstOrDefault(a => a.AnimeProductId == animeProductId);
        }
    }
}