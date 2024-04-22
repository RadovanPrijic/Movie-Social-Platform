using MoviesApp.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.DTO
{
    public class MovieRatingCreateDTO
    {
        [Required]
        [Range(1,10)]
        public int Value { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int MovieId { get; set; }
    }
}
