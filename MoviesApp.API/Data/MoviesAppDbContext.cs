using Microsoft.AspNetCore.Identity;
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

            string basicUserRoleId = "4066da82-f923-4a73-ae50-a29a5c76c5c1";
            string movieCriticRoleId = "c15e545b-fe60-4307-a970-41f1111e0b0f";
            string adminRoleId = "53fee358-1930-4d37-8c9c-4225365c33c1";

            var roles = new List<IdentityRole>
            { 
                new IdentityRole
                {
                    Id = basicUserRoleId,
                    ConcurrencyStamp = basicUserRoleId,
                    Name = "Basic_User",
                    NormalizedName = "BASIC_USER"
                },
                new IdentityRole
                {
                    Id = movieCriticRoleId,
                    ConcurrencyStamp = movieCriticRoleId,
                    Name = "Movie_Critic",
                    NormalizedName = "MOVIE_CRITIC"
                },
                new IdentityRole
                {
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }

    }
}
