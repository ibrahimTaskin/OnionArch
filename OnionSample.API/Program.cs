using OnionSample.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using OnionSample.Infrastructure.Repositories.Product;
using OnionSample.Application.Services;
using OnionSample.Application.Interfaces;
using OnionSample.CrossCuttingConcerns.Middlewares;
using OnionSample.Infrastructure.Context.Seed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnionDbConnection"));
});
// Aray�z ve uygulama s�n�f� aras�ndaki ba�lant�y� kurun
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();



var app = builder.Build();

// Seed i�lemini ger�ekle�tir
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
    SeedDataService.Initialize(services);
}

// Configure the HTTP request pipeline.
app.UseErrorHandlingMiddleware();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
