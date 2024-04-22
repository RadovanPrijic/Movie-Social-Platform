using Microsoft.EntityFrameworkCore;
using MoviesApp.API;
using MoviesApp.API.Data;
using MoviesApp.API.Repositories;
using MoviesApp.API.Repositories.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MoviesAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesAppConnectionString")));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddAutoMapper(typeof(MappingConfiguration));

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
