using Examen1_BrayanAguilar_62051229.Models.Domain.Repositories;
using Examen1_BrayanAguilar_62051229.Models.Domain.Services;
using Examen1_BrayanAguilar_62051229.Models.Infrastructure.InMemory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registro de dependencias para FoodTrack
builder.Services.AddSingleton<IFoodTruckRepository, InMemoryFoodTruckRepository>();
builder.Services.AddSingleton<IOrderRepository, IinmemoryOrderRepository>();
builder.Services.AddSingleton<IEventLogRepository, InMemoryEventLogRepository>();

builder.Services.AddScoped<OrderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Si quieres que cargue primero FoodTrack, usa esta en lugar de la anterior:
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=FoodTrack}/{action=Index}/{id?}");

app.Run();
