using FirstAppi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppi.Controllers
{
    [Route("api/[controller]")] // url: http://localhost:5075/api/movies
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // private field
        private static List<Movie> movies;

        public MoviesController()
        {
            movies = new List<Movie>
            {
                 new Movie {Id = 1, Title = "Inception", ReleaseDate = DateTime.Now, Duration = 150, Rating = 4 },
                 new Movie {Id = 2, Title = "Back to the Future", ReleaseDate = DateTime.MinValue, Duration = 180, Rating= 4.8 },
            };
        }

        [HttpGet] // GET: api/movies
        public IActionResult Get()
        {
            // returns all movies
            return Ok(movies);
        }

        // todo
        [HttpGet("{id:maxlength(2)}")] // GET: api/movies/1
        public IActionResult GetById(int id)
        {
            // does that resource with id exist?
            var existingMovie = movies.FirstOrDefault(movie => movie.Id == id);

            if (existingMovie == null)
            {
                //if no, return NotFound
                return NotFound();
            }

            // if yes, return model
            return Ok(existingMovie);
        }

        // implement HEAD
        //add http verb
        [HttpHead("{id}")] // api/movies/1
        public IActionResult CheckIfExists(int id)
        {
            var existingMovie = movies.FirstOrDefault(movie => movie.Id == id);

            if (existingMovie == null)
            {
                return NotFound();
            }

            return Ok(existingMovie);
        }

        // implement DELETE operation
        //add http verb
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // check if movie exists
            // return 404 if not found
            //delete if movie exists
            //return no content

            var existingMovie = movies.FirstOrDefault(movie => movie.Id == id);

            if (existingMovie == null)
            {
                return NotFound();
            }

            movies.Remove(existingMovie);
            return NoContent();
        }

        [HttpPost] // POST: api/movies
        public IActionResult Create([FromBody] Movie movie, [FromQuery] string genre, [FromHeader] string culture)
        {
            // model is valid?
            // if not, return bad request
            // else simulate database insert
            // return status code: 201

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            movie.Id = 100;
            movies.Add(movie);

            // return CreatedAtAction("Create", new { id = movie.Id }, movie);
            return CreatedAtAction(nameof(Create), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")] // http://localhost:{port}/api/movies/1 
        public IActionResult Update(int id, Movie movie)
        {
            // check if id exists; else return badRequest
            // if id exists, get the entity from database/in memory list
            // if movie not exists -> return not found
            // return OK updated movie

            if (id != movie.Id)
            {
                return BadRequest();
            }

            var existingMovie = movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            movies.Remove(existingMovie);

            existingMovie.Title = movie.Title;
            existingMovie.Duration = movie.Duration;
            existingMovie.Rating = movie.Rating;
            existingMovie.ReleaseDate = movie.ReleaseDate;

            movies.Add(existingMovie);

            return Ok(existingMovie);
        }

    }
}
