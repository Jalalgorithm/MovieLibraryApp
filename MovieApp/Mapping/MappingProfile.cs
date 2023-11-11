using AutoMapper;
using MovieApp.ApiModels;
using MovieApp.Models;

namespace MovieApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Genre , GenreApiModel>();
            CreateMap<Movie , MoviesApiModel>();
            CreateMap<MoviesApiModel, Movie>();
        }
    }
}
