using IMDBSWA.Business.Abstract;
using IMDBSWA.Core.Api.key;
using IMDBSWA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvSeriesController : ControllerBase
    {
        private readonly ITvSeriesService _tvSeriesService;
        private readonly TMDbClient client=Apikey.GetTMDbClient();
        public TvSeriesController(ITvSeriesService tvSeriesService)
        {
            _tvSeriesService= tvSeriesService;
        }
        [HttpPost]
        public async Task<int> PostTvSeries(int tvSeriesid)
        {
            client.DefaultLanguage = "tr-TR";
            var searchTvseriesById=await client.GetTvShowAsync(tvSeriesid);
            TvSeries tvSeries = new()
            {
                TvSeriesId = tvSeriesid,
                Name = searchTvseriesById.Name,
                OriginTitle = searchTvseriesById.OriginalName,
                Overview = searchTvseriesById.Overview,
                PosterPath = searchTvseriesById.PosterPath,
                BackgroundPath = searchTvseriesById.BackdropPath,
                FirstAirDate = searchTvseriesById.FirstAirDate,
                OriginalLanguage = searchTvseriesById.OriginalLanguage,
                NumberofEpisodes=searchTvseriesById.NumberOfEpisodes,
                NumberofSeasons=searchTvseriesById.NumberOfSeasons,
                LastAirDate=searchTvseriesById.LastAirDate,
            };
            int result = _tvSeriesService.Add(tvSeries);
            return result;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _tvSeriesService.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _tvSeriesService.Delete(new() { Id = id });
            return Ok(result);
        }

    }
}
