using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.Movie;
using IMDBSWA.Core.Api.key;
using IMDBSWA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

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
        /*private readonly TMDbClient client = Apikey.GetTMDbClient();
        [HttpGet("idyegöre/movieId")]
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
        //public IActionResult Post([FromBody] MovieCreateRequest dto)
        //{
        //    Movie entity = new() {  }
        //}
    }
}
