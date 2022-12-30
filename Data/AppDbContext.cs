using Microsoft.EntityFrameworkCore;
using MovieMauiAPI.Models;

namespace MovieMauiAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<MovieModel> Movies => Set<MovieModel>();
    }
}
