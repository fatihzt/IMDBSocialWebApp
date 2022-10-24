using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.Movie;
using IMDBSWA.Core.Api.key;
using IMDBSWA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using Movie = IMDBSWA.Entities.Movie;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        /*private readonly TMDbClient client = new TMDbClient("2954778739480995cf5e744265900647");*/
        private readonly TMDbClient client = Apikey.GetTMDbClient();
        /*[HttpGet("idyegöre/movieId")]
        public async Task<MovieCreateRequest> GetMovie(int movieId)
        {
            client.DefaultLanguage = "tr-TR";
            var searchMovieById = await client.GetMovieAsync(movieId);
            var movie = new MovieCreateRequest
            {
                MovieId = searchMovieById.Id,
                OriginalTitle = searchMovieById.OriginalTitle,
                OriginalLanguage=searchMovieById.OriginalLanguage,
                ReleaseDate=searchMovieById.ReleaseDate,
            };
            return movie;
        }*/

        /*[HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result=_movieService.Get(m=>m.MovieId == id);
            return Ok(result);
        }*/

        //[HttpPost]
        //public  async IActionResult PostMovie([FromBody] MovieCreateRequest dto)
        //{
        //    var moviedb=await client.GetMovieAsync(dto.MovieId);
        //    client.DefaultLanguage = "tr-TR";

        //    Movie entity = new() { MovieId = dto.MovieId, OriginalTitle=dto.OriginalTitle, OriginalLanguage = dto.OriginalLanguage, ReleaseDate = dto.ReleaseDate };
        //    int result = _movieService.Add(entity);
        //    return Ok(result > 0 ? "Success" : "Error");
        //}
        [HttpPost]
        public async Task<int> PostMovie(int movieId)
        {
            client.DefaultLanguage = "tr-TR";
            var searchMovieById = await client.GetMovieAsync(movieId);
            Movie movie = new()
            {
                MovieId = movieId,
                Overview = searchMovieById.Overview,
                OriginalTitle = searchMovieById.OriginalTitle,
                OriginalLanguage = searchMovieById.OriginalLanguage,
                PosterPath = searchMovieById.PosterPath,
                BackgroundPath=searchMovieById.BackdropPath,
                Adult=searchMovieById.Adult,
                Budget=searchMovieById.Budget,
                ReleaseDate = searchMovieById.ReleaseDate,
            };
            int result = _movieService.Add(movie);
            return result;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _movieService.Delete(new() { Id = id });
            return Ok(result);
        }
    }
}
