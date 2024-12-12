using ConsumeAPIsC_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moviesAPI.Models;

namespace ConsumeAPIsC_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _service;

        public MovieController(MovieService movieService)
        {
            _service = movieService;
        }
        [HttpGet("movies")]
        public Task<List<Movie>> GetMovies()
        {
            return _service.GetAllMovies();
        }

        [HttpPost("movies/create")]
        public Task<Movie> CreateMovie(Movie newMovie)
        {
            return _service.AddMovie(newMovie);
        }

        [HttpDelete("movies/delete/{id}")]
        public Task<Movie> DeleteMovie(int id)
        {
            return _service.RemoveMovie(id);
        }

        [HttpPut("movies/update")]
        public Task<Movie> PutMovie(Movie movie)
        {
            return _service.UpdateMovie(movie);
        }
    }
}
