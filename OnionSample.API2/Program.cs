using Microsoft.EntityFrameworkCore;
using OnionSample.Application.Interfaces;
using OnionSample.Application.Services;
using OnionSample.Infrastructure.Context;
using OnionSample.Infrastructure.Context.Seed;
using OnionSample.Infrastructure.Repositories.Product;
using OnionSample.CrossCuttingConcerns.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnionDbConnection"));
});
// Arayüz ve uygulama sýnýfý arasýndaki baðlantýyý kurun
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();


// Seed iþlemini gerçekleþtir
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
    SeedDataService.Initialize(services);
}

// Configure the HTTP request pipeline.
app.UseErrorHandlingMiddleware();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
