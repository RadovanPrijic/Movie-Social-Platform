using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Models.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string ProfileDescription { get; set; }
        /*public List<MovieRating> UserRatings { get; }
        public List<MovieReview> UserReviews { get; }*/
    }
}
