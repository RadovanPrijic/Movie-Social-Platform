using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoviesApp.API.Data;
using MoviesApp.API.Models.Domain;
using MoviesApp.API.Models.DTO;
using MoviesApp.API.Repositories.IRepository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MoviesApp.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MoviesAppDbContext _db;
        private string _secretKey;
        public UserRepository(MoviesAppDbContext db, IConfiguration configuration)
        {
            _db = db;
            _secretKey = configuration.GetValue<string>("Jwt:SecretKey");
        }
        public async Task<bool> isUserUnique(string email)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);

            if(user == null)
            {
                return true;
            }

            return false;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            //Line to check if email and password match the ones that are stored in the DB.
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == loginRequestDTO.Email.ToLower());

            if(user == null)
            {
                return new LoginResponseDTO()
                {
                    User = null,
                    Token = ""
                };
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                User = user,
                Token = tokenHandler.WriteToken(token)
            };

            return loginResponseDTO;
        }

        public async Task<User> Register(RegistrationRequestDTO registrationRequestDTO)
        {
            User user = new()
            {
                Email = registrationRequestDTO.Email
            }; // Use AutoMapper here and with all the right attributes.

            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();

            return user;
        }
    }
}
