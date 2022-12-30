using Microsoft.EntityFrameworkCore;
using MovieMauiAPI.Data;
using MovieMauiAPI.Models;
using System.Collections.Immutable;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
app.MapGet("api/movies", async (AppDbContext context) =>
{
    var items = await context.Movies.ToListAsync();
    return Results.Ok(items);
});
app.MapPost("api/movies", async (AppDbContext context, MovieModel movie) =>
{
    await context.Movies.AddAsync(movie);
    
    await context.SaveChangesAsync();

    return Results.Created($"api/movies/{movie.Id}", movie);
});
app.MapPut("api/movies/{id}", async(AppDbContext context, int id, MovieModel movie) =>
{
    var movieModel = await context.Movies.FirstOrDefaultAsync(c => c.Id == id);
    if(movieModel == null)
    {
        return Results.NotFound();
    }
    movieModel.Title = movie.Title;
    await context.SaveChangesAsync();
    return Results.NoContent();

});
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}