using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.DTO
{
    public class MovieUpdateDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string PlotSummary { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int Budget { get; set; }
        [Required]
        public List<GenreDTO> Genres { get; }
    }
}
