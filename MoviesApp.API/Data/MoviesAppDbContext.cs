using Microsoft.EntityFrameworkCore;
using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Data
{
    public class MoviesAppDbContext : DbContext
    {

        public MoviesAppDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }

    }
}
