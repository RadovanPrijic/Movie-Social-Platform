using MoviesApp.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.DTO
{
    public class MovieReviewCreateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "The minimum length of a movie review is 1 character.")]
        [MaxLength(4000, ErrorMessage = "The maximum length of a movie review is 4000 characters.")]
        public string Text { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int MovieId { get; set; }
    }
}
