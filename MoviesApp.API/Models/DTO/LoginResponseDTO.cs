using MoviesApp.API.Models.Domain;

namespace MoviesApp.API.Models.DTO
{
    public class LoginResponseDTO
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
