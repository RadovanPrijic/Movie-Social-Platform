using MoviesApp.API.Data;
using MoviesApp.API.Models.Domain;
using MoviesApp.API.Repositories.IRepository;

namespace MoviesApp.API.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly MoviesAppDbContext _db;

        public MovieRepository(MoviesAppDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
