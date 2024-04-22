using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Azure;

namespace MoviesApp.API.Models.Domain
{
    public class Genre
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; } = new List<Movie>();
    }
}
