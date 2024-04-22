
namespace MoviesApp.API.Models.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string PlotSummary { get; set; }
        public double? AverageRating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Budget { get; set; }
        public List<GenreDTO> Genres { get; }
    }
}
