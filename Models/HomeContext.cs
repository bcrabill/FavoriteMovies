using Microsoft.EntityFrameworkCore;

namespace FavoriteMovies.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) {}

        public DbSet<Movie> Movies {get; set;}

        public DbSet<User> Users { get; set;}

        public DbSet<Favorite> Favorites { get; set;}
    }
}