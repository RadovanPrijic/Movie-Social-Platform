using System.ComponentModel.DataAnnotations;

namespace MoviesApp.API.Models.DTO
{
    public class LoginRequestDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
