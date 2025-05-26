using System.Formats.Tar;
using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ADD SERVICES
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
 {
     opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
 });

var app = builder.Build();

// MIDDLEWARE

app.MapControllers();

app.Run();
