using NakamaShop.Models;

namespace NakamaShop.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            NakamaShopDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<NakamaShopDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
                context.SaveChanges();
            }

            if (!context.AnimeProducts.Any())
            {
                context.AnimeProducts.AddRange(
                    // FIGURAS
                    new AnimeProduct { Name = "Figura Luffy Gear 5", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Luffy Gear 5.jpg", Price = 89.99m, ShortDescription = "El Dios del Sol Nika", InStock = true, IsProductOfTheWeek = true, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Figura Zoro (Santoryu)", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Zoro (Santoryu).jpg", Price = 75.00m, ShortDescription = "Estilo de tres espadas", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Nendoroid Naruto Uzumaki", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Nendoroid Naruto Uzumaki.jpg", Price = 45.99m, ShortDescription = "Versión Shippuden articulada", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Figura Sasuke Uchiha", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Sasuke Uchiha.jpg", Price = 70.00m, ShortDescription = "Con efecto Chidori", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Goku Super Saiyan Blue", AnimeSeries = "Dragon Ball Super", ImageThumbnailUrl = "/Images/Goku Super Saiyan Blue.png", Price = 65.00m, ShortDescription = "Estatua Banpresto 25cm", InStock = true, IsProductOfTheWeek = true, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Vegeta (Orgullo Saiyan)", AnimeSeries = "Dragon Ball Z", ImageThumbnailUrl = "/Images/Vegeta (Orgullo Saiyan).jpg", Price = 62.50m, ShortDescription = "Pose de batalla clásica", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Eren Yeager (Forma Titán)", AnimeSeries = "Attack on Titan", ImageThumbnailUrl = "/Images/Eren Yeager (Forma Titán).jpg", Price = 95.00m, ShortDescription = "Figura edición limitada", InStock = false, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Mikasa Ackerman", AnimeSeries = "Attack on Titan", ImageThumbnailUrl = "/Images/Mikasa Ackerman.jpg", Price = 78.00m, ShortDescription = "Con equipo de maniobras 3D", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Tanjiro Kamado", AnimeSeries = "Demon Slayer", ImageThumbnailUrl = "/Images/Tanjiro Kamado.jpg", Price = 55.00m, ShortDescription = "Efecto respiración de agua", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Nezuko en caja", AnimeSeries = "Demon Slayer", ImageThumbnailUrl = "/Images/Nezuko en caja.jpg", Price = 48.00m, ShortDescription = "Versión pequeña adorable", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Satoru Gojo (Sin venda)", AnimeSeries = "Jujutsu Kaisen", ImageThumbnailUrl = "/Images/Satoru Gojo (Sin venda).jpg", Price = 110.00m, ShortDescription = "Expansión de dominio: Vacío Infinito", InStock = true, IsProductOfTheWeek = true, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Sukuna (Trono de huesos)", AnimeSeries = "Jujutsu Kaisen", ImageThumbnailUrl = "/Images/Sukuna (Trono de huesos).jpg", Price = 125.00m, ShortDescription = "Figura de lujo", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Deku Smash", AnimeSeries = "My Hero Academia", ImageThumbnailUrl = "/Images/Deku Smash.jpg", Price = 52.00m, ShortDescription = "One For All 100%", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "Bakugo Katsuki", AnimeSeries = "My Hero Academia", ImageThumbnailUrl = "/Images/Bakugo Katsuki.jpg", Price = 54.00m, ShortDescription = "Efecto explosión", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    new AnimeProduct { Name = "L (Death Note)", AnimeSeries = "Death Note", ImageThumbnailUrl = "/Images/L (Death Note).png", Price = 40.00m, ShortDescription = "Sentado con su pastel", InStock = true, IsProductOfTheWeek = false, Category = Categories["Figuras"] },
                    
                    // COLECCIONABLES
                    new AnimeProduct { Name = "Gomu Gomu no Mi", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Gomu Gomu no Mi.jpg", Price = 35.00m, ShortDescription = "Réplica escala real", InStock = true, IsProductOfTheWeek = true, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Ope Ope no Mi", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Ope Ope no Mi.jpg", Price = 35.00m, ShortDescription = "La fruta del Diablo de Law", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Kunai de Minato", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Kunai de Minato.jpg", Price = 22.00m, ShortDescription = "Metal pesado, escala 1:1", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Banda de la Hoja (Tachada)", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Banda de la Hoja (Tachada).jpg", Price = 12.00m, ShortDescription = "Protector de frente de Itachi", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Esfera de 4 estrellas", AnimeSeries = "Dragon Ball", ImageThumbnailUrl = "/Images/Esfera de 4 estrellas.jpg", Price = 15.00m, ShortDescription = "Resina transparente", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Radar del Dragón", AnimeSeries = "Dragon Ball", ImageThumbnailUrl = "/Images/Radar del Dragón.jpg", Price = 28.00m, ShortDescription = "Con luces y sonidos", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Llave del Sótano", AnimeSeries = "Attack on Titan", ImageThumbnailUrl = "/Images/Llave del Sótano.jpg", Price = 10.00m, ShortDescription = "El secreto de Grisha Yeager", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Death Note Real", AnimeSeries = "Death Note", ImageThumbnailUrl = "/Images/Death Note Real.jpg", Price = 20.00m, ShortDescription = "Cuaderno con reglas incluidas", InStock = true, IsProductOfTheWeek = true, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Dedo de Sukuna", AnimeSeries = "Jujutsu Kaisen", ImageThumbnailUrl = "/Images/Dedo de Sukuna.jpg", Price = 18.00m, ShortDescription = "Réplica de objeto maldito", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Katana de Tanjiro", AnimeSeries = "Demon Slayer", ImageThumbnailUrl = "/Images/Katana de Tanjiro.jpg", Price = 120.00m, ShortDescription = "Acero al carbono (ornamental)", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Pendientes Hanafuda", AnimeSeries = "Demon Slayer", ImageThumbnailUrl = "/Images/Pendientes Hanafuda.jpg", Price = 15.00m, ShortDescription = "Legado de la familia Kamado", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Pokéball Clásica", AnimeSeries = "Pokémon", ImageThumbnailUrl = "/Images/Pokéball Clásica.jpg", Price = 25.00m, ShortDescription = "Apertura por botón", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Póster Recompensa Sanji", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Póster Recompensa Sanji.jpg", Price = 8.00m, ShortDescription = "Only Alive version", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Sombrero de Chopper", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Sombrero de Chopper.jpg", Price = 25.00m, ShortDescription = "Suave y acolchado", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    new AnimeProduct { Name = "Máscara de Ken Kaneki", AnimeSeries = "Tokyo Ghoul", ImageThumbnailUrl = "/Images/Máscara de Ken Kaneki.jpg", Price = 30.00m, ShortDescription = "Cuero sintético ajustable", InStock = true, IsProductOfTheWeek = false, Category = Categories["Coleccionables"] },
                    
                    // MANGA
                    new AnimeProduct { Name = "One Piece Vol. 100", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/One Piece Vol. 100.jpg", Price = 9.99m, ShortDescription = "Edición conmemorativa", InStock = true, IsProductOfTheWeek = true, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Naruto Gold Vol. 1", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Naruto Gold Vol. 1.jpg", Price = 12.00m, ShortDescription = "Portada metalizada", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Berserk Deluxe Vol. 1", AnimeSeries = "Berserk", ImageThumbnailUrl = "/Images/Berserk Deluxe Vol. 1.jpg", Price = 49.99m, ShortDescription = "Tapa dura, formato grande", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Chainsaw Man Vol. 1", AnimeSeries = "Chainsaw Man", ImageThumbnailUrl = "/Images/Chainsaw Man Vol. 1.jpg", Price = 9.99m, ShortDescription = "El inicio de Denji", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Spy x Family Vol. 1", AnimeSeries = "Spy x Family", ImageThumbnailUrl = "/Images/Spy x Family Vol. 1.jpg", Price = 9.99m, ShortDescription = "Misión: Formar una familia", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Jujutsu Kaisen 0", AnimeSeries = "Jujutsu Kaisen", ImageThumbnailUrl = "/Images/Jujutsu Kaisen 0.png", Price = 9.99m, ShortDescription = "La precuela de Yuta Okkotsu", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "JoJo's Bizarre Adventure Part 1", AnimeSeries = "JoJo's", ImageThumbnailUrl = "/Images/JoJo's Bizarre Adventure Part 1.jpg", Price = 19.99m, ShortDescription = "Phantom Blood Vol 1", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Akira (Edición Integral)", AnimeSeries = "Akira", ImageThumbnailUrl = "/Images/Akira (Edición Integral).jpg", Price = 35.00m, ShortDescription = "Clásico cyberpunk", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Dragon Ball Color Vol. 1", AnimeSeries = "Dragon Ball", ImageThumbnailUrl = "/Images/Dragon Ball Color Vol. 1.jpg", Price = 14.00m, ShortDescription = "Saga de los Saiyans a color", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    new AnimeProduct { Name = "Uzumaki (Junji Ito)", AnimeSeries = "Terror", ImageThumbnailUrl = "/Images/Uzumaki (Junji Ito).jpg", Price = 25.00m, ShortDescription = "Obra maestra del horror", InStock = true, IsProductOfTheWeek = false, Category = Categories["Manga"] },
                    
                    // ROPA Y ACCESORIOS
                    new AnimeProduct { Name = "Capa de Akatsuki", AnimeSeries = "Naruto", ImageThumbnailUrl = "/Images/Capa de Akatsuki.jpg", Price = 45.00m, ShortDescription = "Nubes bordadas", InStock = true, IsProductOfTheWeek = true, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Sudadera Survey Corps", AnimeSeries = "Attack on Titan", ImageThumbnailUrl = "/Images/Sudadera Survey Corps.jpg", Price = 38.00m, ShortDescription = "Logo en la espalda", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Camiseta Capsule Corp", AnimeSeries = "Dragon Ball", ImageThumbnailUrl = "/Images/Camiseta Capsule Corp.jpg", Price = 22.00m, ShortDescription = "Algodón 100%", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Gorra de Jotaro", AnimeSeries = "JoJo's", ImageThumbnailUrl = "/Images/Gorra de Jotaro.jpg", Price = 18.00m, ShortDescription = "Con detalles dorados", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Calcetines Totoro", AnimeSeries = "Ghibli", ImageThumbnailUrl = "/Images/Calcetines Totoro.jpg", Price = 8.00m, ShortDescription = "Pack de 3 pares", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Mochila UA High School", AnimeSeries = "My Hero Academia", ImageThumbnailUrl = "/Images/Mochila UA High School.jpg", Price = 40.00m, ShortDescription = "Para futuros héroes", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Kimono de Zenitsu", AnimeSeries = "Demon Slayer", ImageThumbnailUrl = "/Images/Kimono de Zenitsu.jpg", Price = 35.00m, ShortDescription = "Patrón de triángulos amarillo", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Llavero de Pochita", AnimeSeries = "Chainsaw Man", ImageThumbnailUrl = "/Images/Llavero de Pochita.jpg", Price = 7.00m, ShortDescription = "Peluche pequeño", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Sombrero de paja de Monkey D. Luffy", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Sombrero de paja de Monkey D. Luffy.jpg", Price = 12.00m, ShortDescription = "Para el rey de los piratas", InStock = true, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] },
                    new AnimeProduct { Name = "Chaqueta de Portgas D. Ace", AnimeSeries = "One Piece", ImageThumbnailUrl = "/Images/Chaqueta de Portgas D. Ace.jpg", Price = 55.00m, ShortDescription = "Sin mangas, estilo vaquero", InStock = false, IsProductOfTheWeek = false, Category = Categories["Ropa y Accesorios"] }
                );
                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category>? categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var catList = new Category[]
                    {
                        new Category { CategoryName = "Figuras", Description = "Estatuas y figuras de alta calidad" },
                        new Category { CategoryName = "Coleccionables", Description = "Réplicas, accesorios y objetos únicos" },
                        new Category { CategoryName = "Manga", Description = "Tomos físicos de tus series favoritas" },
                        new Category { CategoryName = "Ropa y Accesorios", Description = "Lleva tu estilo ninja o pirata a todos lados" }
                    };
                    categories = new Dictionary<string, Category>();
                    foreach (var cat in catList) { categories.Add(cat.CategoryName, cat); }
                }
                return categories;
            }
        }
    }
}