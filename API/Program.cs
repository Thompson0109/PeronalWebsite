using Microsoft.EntityFrameworkCore;
using Personal_Website_Project.Data;
using Personal_Website_Project.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
/*builder.Services.AddDbContext<BlogContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefualtConnection"));
});*/

builder.Services.AddDbContext<BlogContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
