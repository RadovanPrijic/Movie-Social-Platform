using Microsoft.AspNetCore.Identity;

namespace MoviesApp.API.Models.Domain
{
    public class User : IdentityUser
    {
        public string ProfileDescription { get; set; }
        public ICollection<MovieRating> UserRatings { get; } = new List<MovieRating>();
        public ICollection<MovieReview> UserReviews { get; } = new List<MovieReview>();
    }
}
