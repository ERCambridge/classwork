using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moviesAPI.Models;

namespace moviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieAPIController : ControllerBase
    {
        private readonly MoviedbContext _context;

        public MovieAPIController(MoviedbContext context)
        {
            _context = context;
        }


        [HttpGet("Movies")]
        public async Task<List<Movie>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpPost("Movies/Create")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<Movie> AddMovie([Bind("MovieId, Title, ReleaseYear, Director")] Movie newMovie)
        {
                _context.Add(newMovie);
                await _context.SaveChangesAsync();
                return newMovie;
        }

        [HttpDelete("Movies/Remove/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Movie>> RemoveMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                return movie;
            }
            return Ok();
        }

        [HttpPut("Movies/update")]
        public async Task<IActionResult> UpdateMovie([Bind("MovieId, Title, ReleaseYear, Director")] Movie aMovie)
        {
            if (ModelState.IsValid)   // check if data passed passes all validity checks....
            {
                try                                     // Attempt to...
                {
                    _context.Update(aMovie);          //     Call Entity Framework to update data in data source
                    await _context.SaveChangesAsync();  //     Call Entity Framework to save/commit updated data in data source
                }
                catch (DbUpdateConcurrencyException)    // If unexpected data base error occurs..
                {
                    if (MovieExists(aMovie.MovieId))    //      and update item exists...
                    {
                        throw;                          //          throw the exception to next process in call stack
                    }
                    else                                //      and update item does not exist...
                    {
                        return NotFound();              //          return with Not Found (404) HTPP status code
                    }
                }
                return Ok();                            // If update was successful, return OK (200) HTTP status code
            }
            return BadRequest();                        // Data wassed was invalid - return Bad Request (400) HTTP status code
        }

        private bool MovieExists(int id)
        {
            // Call Entity Framework to determine is there is any gambler in data source with id passed
            //      and return what it returns (true if there is, false if there is not)
            return (_context.Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
