using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.API.Models.Domain
{
    [Table("Movie")]
    public class Movie
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string PlotSummary { get; set; }
        public double? AverageRating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Budget { get; set; }
        public ICollection<MovieRating> MovieRatings { get; } = new List<MovieRating>();
        public ICollection<MovieReview> MovieReviews { get; } = new List<MovieReview>();
        public ICollection<Genre> Genres { get; } = new List<Genre>();
    }
}
