using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace MoviesApp.API.Models.Domain
{
    public class MovieReview
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }
        public User User { get; set; } = null!;
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
