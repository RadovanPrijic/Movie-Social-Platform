using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace MoviesApp.API.Models.Domain
{
    public class MovieRating
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
