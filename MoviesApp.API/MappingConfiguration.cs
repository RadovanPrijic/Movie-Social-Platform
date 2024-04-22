using AutoMapper;
using MoviesApp.API.Models.Domain;
using MoviesApp.API.Models.DTO;

namespace MoviesApp.API
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<Movie, MovieCreateDTO>().ReverseMap();
            CreateMap<Movie, MovieUpdateDTO>().ReverseMap();

            CreateMap<MovieRating, MovieRatingDTO>().ReverseMap();
            CreateMap<MovieRating, MovieRatingCreateDTO>().ReverseMap();
            CreateMap<MovieRating, MovieRatingUpdateDTO>().ReverseMap();

            CreateMap<MovieReview, MovieReviewDTO>().ReverseMap();
            CreateMap<MovieReview, MovieReviewCreateDTO>().ReverseMap();
            CreateMap<MovieReview, MovieReviewUpdateDTO>().ReverseMap();

            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();

            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}