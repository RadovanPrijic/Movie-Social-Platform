using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Models.DTO
{
    public class MovieRatingDTO
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime CreationDate { get; set; }
        public UserDTO User { get; set; }
        public MovieDTO Movie { get; set; }
    }
}
