using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.ApiModels;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [Route("/" +
        "api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext context;
        private readonly IMapper mapper;

        public MoviesController(MovieDbContext context  , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movie = await context.Movies.Include(m=>m.Genre).ToListAsync();

            if(movie ==null)
                return NotFound();


            var movieResource = mapper.Map<List<Movie>, List<MoviesApiModel>>(movie);

            return Ok(movieResource);
        }

        [HttpGet("/api/movies/{id}")]

        public async Task<IActionResult> GetMovies(int id)
        {
            var movies = await context.Movies.Include(m=>m.Genre).SingleOrDefaultAsync(m=>m.Id == id);

            if(movies == null) 
                return NotFound();

            var result = mapper.Map<Movie , MoviesApiModel>(movies);

            return Ok(result);
        }

        [HttpPost("/api/movies/new")]

        public async Task<IActionResult> CreateMovies([FromBody] MoviesApiModel movie)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Addmovie = mapper.Map<MoviesApiModel, Movie>(movie);


            context.Movies.Add(Addmovie);   

            await context.SaveChangesAsync();
            var result = mapper.Map<Movie, MoviesApiModel>(Addmovie);

            return Ok(result);

        }

        [HttpPut("/api/movies/update/{id}")]

        public async Task<IActionResult> UpdateMovie(int id , [FromBody]MoviesApiModel movie)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Mainmovie = await context.Movies.FindAsync(id);
            var Updatemovie = mapper.Map<MoviesApiModel, Movie>(movie , Mainmovie);

            await context.SaveChangesAsync();
            var result = mapper.Map<Movie, MoviesApiModel>(Updatemovie);

            return Ok(result);


        }
        [HttpDelete("/api/movies/delete/{id}")]

        public async Task<IActionResult> DeleteMovie (int id , [FromBody]MoviesApiModel movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Mainmovie = await context.Movies.FindAsync(id);
            var DeleteMovie = mapper.Map<MoviesApiModel, Movie>(movie , Mainmovie);

            context.Movies.Remove(DeleteMovie);

            var result = mapper.Map<Movie , MoviesApiModel>(DeleteMovie);

            return Ok(result);

        }



    }
}
