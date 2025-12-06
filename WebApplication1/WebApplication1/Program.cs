using Microsoft.EntityFrameworkCore;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<Conexion>(opciones => opciones.UseSqlServer("name=StringConexion"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
