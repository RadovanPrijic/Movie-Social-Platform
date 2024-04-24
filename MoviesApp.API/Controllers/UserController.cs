using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using MoviesApp.API.CustomActionFilters;
using MoviesApp.API.Data;
using MoviesApp.API.Models.Domain;
using MoviesApp.API.Models.DTO;
using MoviesApp.API.Repositories;
using MoviesApp.API.Repositories.IRepository;

namespace MoviesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MoviesAppDbContext _dbContext;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(MoviesAppDbContext dbContext, IUserRepository userRepository, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("login")]
        [ValidateModel]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var loginResponse = await _userRepository.Login(loginRequestDTO);

            if(string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { message = "You have entered an incorrect email address or password." });
            }

            return Ok(loginResponse);
        }

        [HttpPost]
        [Route("register")]
        [ValidateModel]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO registrationRequestDTO)
        {
            bool isUserUnique = await _userRepository.isUserUnique(registrationRequestDTO.Email);

            if (!isUserUnique)
            {
                return BadRequest(new { message = "The entered email address already exists." });
            }

            var userDomainModel = await _userRepository.Register(registrationRequestDTO);

            if (userDomainModel == null)
            {
                return BadRequest(new { message = "An error has occured in the registration process." });
            }

            return Ok();
        }
    }
}
