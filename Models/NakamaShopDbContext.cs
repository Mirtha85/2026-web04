using Microsoft.EntityFrameworkCore;

namespace NakamaShop.Models
{
    public class NakamaShopDbContext : DbContext
    {
        public NakamaShopDbContext(DbContextOptions<NakamaShopDbContext> options) : base(options) { }

        // Aquí definiremos tus tablas (ejemplo)
        public DbSet<AnimeProduct> AnimeProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}