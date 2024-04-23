using MoviesApp.API.Models.Domain;
using MoviesApp.API.Models.DTO;

namespace MoviesApp.API.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<bool> isUserUnique(string email);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<User> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
