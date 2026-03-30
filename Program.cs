using Microsoft.EntityFrameworkCore;
using NakamaShop.Data;
using NakamaShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAnimeProductRepository, AnimeProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddDbContext<NakamaShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Shopping Cart
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(
    sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseSession(); // ← debe ir antes de MapDefaultControllerRoute
app.UseDeveloperExceptionPage();
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
