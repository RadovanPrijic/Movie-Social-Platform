using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.API.CustomActionFilters;
using MoviesApp.API.Data;
using MoviesApp.API.Models.Domain;
using MoviesApp.API.Models.DTO;
using MoviesApp.API.Repositories.IRepository;

namespace MoviesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesAppDbContext _dbContext;
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;

        public MoviesController(MoviesAppDbContext dbContext, IMovieRepository movieRepository, IMapper mapper)
        {
            this._dbContext = dbContext;
            this.movieRepository = movieRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await movieRepository.GetAllAsync(/*includeProperties: "Genres"*/);

            return Ok(mapper.Map<List<MovieDTO>>(movies));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetMovieById([FromRoute] int id)
        {
            var movie = await movieRepository.GetAsync(x => x.Id == id/*, includeProperties: "Genres"*/);

            if (movie == null) 
                return NotFound();
            
            return Ok(mapper.Map<MovieDTO>(movie));
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> CreateMovie([FromBody] MovieCreateDTO movieCreateDTO)
        {
            var movieDomainModel = mapper.Map<Movie>(movieCreateDTO);

            movieDomainModel = await movieRepository.CreateAsync(movieDomainModel);

            var movieDTO = mapper.Map<MovieDTO>(movieDomainModel);

            return CreatedAtAction(nameof(GetMovieById), new { id = movieDomainModel.Id }, movieDTO);
        }

        [HttpPut]
        [Route("{id:int}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateMovie([FromRoute] int id, [FromBody] MovieUpdateDTO movieUpdateDTO)
        {
            var movieDomainModel = await movieRepository.GetAsync(x => x.Id == id);

            if (movieDomainModel == null)
                return NotFound();

            movieDomainModel = mapper.Map<Movie>(movieUpdateDTO);

            movieDomainModel = await movieRepository.UpdateAsync(movieDomainModel);
            
            return Ok(mapper.Map<MovieDTO>(movieDomainModel));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteMovie([FromRoute] int id)
        {
            var movieDomainModel = await movieRepository.GetAsync(x => x.Id == id);

            if (movieDomainModel == null)
                return NotFound();

            movieDomainModel = await movieRepository.RemoveAsync(movieDomainModel);

            return Ok(mapper.Map<MovieDTO>(movieDomainModel));
        }

    }
}
