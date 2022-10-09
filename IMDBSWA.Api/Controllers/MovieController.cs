using IMDBSWA.Business.Request.Movie;
using IMDBSWA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using TMDbLib.Client;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly TMDbClient client = new TMDbClient("2954778739480995cf5e744265900647");
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
        }
        [HttpPost]
        public async Task<List<MovieCreateRequest>> GetMovies([FromQuery] int[] movieIds)
        {
            var movieList = new List<MovieCreateRequest>();
            foreach (var movieId in movieIds)
            {
                var movie = await GetMovie(movieId);
                movieList.Add(movie);
            }
            return movieList;
        }
    }
}
