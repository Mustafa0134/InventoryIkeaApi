using InventoryIkeaApi.Database.Repositories.Interfaces;
using InventoryIkeaApi.Services.Interfaces;
using InventoryIkeaApi.Services;
using InventoryIkeaApi.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFurnitureRepository, FurnitureRepository>();
builder.Services.AddScoped<IFurnitureService, FurnitureService>();

var app = builder.Build();

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
