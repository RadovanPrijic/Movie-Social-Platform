using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Data
{
    public class MoviesAppDbContext : IdentityDbContext<User>
    {
        public MoviesAppDbContext(DbContextOptions<MoviesAppDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
