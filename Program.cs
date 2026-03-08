using NakamaShop.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. REGISTRAR SERVICIOS (Inyección de Dependencias)
// Esto le dice a la app: "Cuando alguien pida un ICategoryRepository, dale el Mock"
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IAnimeProductRepository, MockAnimeProductRepository>();

// Agregamos el soporte para Controladores y Vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. CONFIGURAR EL MIDDLEWARE (El pipeline de la app)
// Permite que la app use archivos estáticos (imágenes de anime, CSS, JS)
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Para ver errores detallados en desarrollo
}

// 3. CONFIGURAR LAS RUTAS
// Esto hace que si vas a /Anime/List, busque el AnimeController y la acción List
app.MapDefaultControllerRoute(); 

app.Run();
