using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.Domain
{
    public class ApplicationUser
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProfileDescription { get; set; }
        public ICollection<MovieRating> UserRatings { get; } = new List<MovieRating>();
        public ICollection<MovieReview> UserReviews { get; } = new List<MovieReview>();
    }
}
