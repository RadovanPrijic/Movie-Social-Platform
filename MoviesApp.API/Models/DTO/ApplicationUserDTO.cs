using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Models.DTO
{
    public class ApplicationUserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<MovieRating> UserRatings { get; }
        public List<MovieReview> UserReviews { get; }
    }
}
