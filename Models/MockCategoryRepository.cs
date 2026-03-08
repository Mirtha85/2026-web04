namespace NakamaShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { 
                    CategoryId = 1, 
                    CategoryName = "Figuras", 
                    Description = "Estatuas y figuras de acción de alta calidad" 
                },
                
                new Category { 
                    CategoryId = 2, 
                    CategoryName = "Coleccionables", 
                    Description = "Réplicas, accesorios y objetos únicos" 
                },
                
                new Category { 
                    CategoryId = 3, 
                    CategoryName = "Manga", 
                    Description = "Tomos físicos de tus series favoritas" 
                },

                new Category { 
                    CategoryId = 4, 
                    CategoryName = "Ropa y Accesorios", 
                    Description = "Lleva tu estilo ninja o pirata a todos lados con nuestra línea de ropa" 
                }
            };
    }
}