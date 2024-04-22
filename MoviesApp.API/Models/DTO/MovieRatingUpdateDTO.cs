using MoviesApp.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.DTO
{
    public class MovieRatingUpdateDTO
    {
        [Required]
        [Range(1, 10)]
        public int Value { get; set; }
    }
}
